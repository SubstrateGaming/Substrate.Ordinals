using Serilog;
using Substrate.Integration;
using Substrate.Integration.Client;
using Substrate.Integration.Helper;
using Substrate.NetApi.Model.Types;
using Substrate.Ordinals.Bot.BehaviourTree;
using Action = Substrate.Ordinals.Bot.BehaviourTree.Action;

namespace Ajuna.AAA.Season2.Bot.Bot
{
    public class BaseBotAI
    {
        public string Name { get; }

        private readonly SubstrateNetwork _client;
        private readonly int _timeout;

        private readonly DateTime _lastActionTime;
        private bool _updateNext;

        private readonly Node _root;

        private readonly Account _faucet;

        private readonly Random _random;

        public BaseBotAI(string name, SubstrateNetwork client, Account faucet, int timeout = 1)
        {
            Name = name;

            _client = client;
            _timeout = timeout;

            _lastActionTime = DateTime.UtcNow;
            _updateNext = true;

            _root = GetStrategy();

            _faucet = faucet ?? BaseClient.Alice;

            _random = new Random();
        }

        private Node GetStrategy()
        {
            var strategy = new Selector(new List<Node>
            {
                new Sequence(new List<Node>
                {
                    new Condition(IsPlayTime),
                    new Selector(new List<Node> {
                        new Sequence("Connection", new List<Node>
                        {
                            new Inverter(new Condition(() => _client.IsConnected)),
                            new Action(() => _client.ConnectAsync(true, true, CancellationToken.None).Result)
                        }),
                        new Sequence("Wait", new List<Node>
                        {
                            new Condition(_client.ExtrinsicManager.PreInblock.Any),
                            new Action(() => Wait(1000))
                        }),
                        new Sequence("Token", new List<Node>
                        {
                            new Inverter(new Condition(() => HasTokensAsync().Result)),
                            new Action(() => GetTokensAsync().Result)
                        }),
                        new Sequence("Avatar", new List<Node>
                        {
                            new Condition(NeedUpdate),
                            new Action(() => DoUpdateAsync().Result)
                        }),
                        new Sequence("Play", new List<Node>
                        {
                            new Action(() => TickGame())
                        }),
                    }),
                }),
                new Action(Finish)
            });

            return strategy;
        }

        private bool TickGame()
        {
            // do Inscriptions

            return true;
        }

        private async Task<bool> DoUpdateAsync()
        {
            Log.Debug("{name}|Do update", Name);

            return true;
        }

        private bool NeedUpdate()
        {
            return false;
        }

        public bool Tick()
        {
            // Make sure to respect the cooldown period between actions
            if ((DateTime.UtcNow - _lastActionTime).TotalSeconds < _timeout)
            {
                return true;
            }

            Log.Debug("{name}|Executing strategy", Name);

            // Fetch player data
            return _root.Execute();
        }

        public bool Reconnect()
        {
            if (_client.IsConnected)
            {
                _client.DisconnectAsync().Wait();
            }

            _client.ConnectAsync(true, true, CancellationToken.None).Wait();
            return true;
        }

        private bool Wait(int time)
        {
            var check = _client.ExtrinsicManager;
            Log.Information("Waiting for {time} ms", time);
            Thread.Sleep(time);
            return true;
        }

        private async Task<bool> GetTokensAsync()
        {
            var accountSharp = await _client.GetAccountAsync(_faucet, CancellationToken.None);
            if (accountSharp == null || accountSharp.Data == null || accountSharp.Data.Free == null)
            {
                Log.Warning("{name}|No faucet account found.", Name);
                return false;
            }

            var amountDOT = _random.Next(2, 10);

            if (accountSharp.Data.Free < amountDOT * SubstrateNetwork.DECIMALS)
            {
                Log.Warning("{name}|Faucet balance to low {value} DOT.", Name, Math.Round((decimal)accountSharp.Data.Free / SubstrateNetwork.DECIMALS, 2));
                return false;
            }

            var waitTime = _random.Next(1000, 10000);
            Thread.Sleep(waitTime);

            var subscription = await _client.TransferKeepAliveAsync(SubstrateNetwork.Alice, _client.Account.ToAccountId32(), amountDOT, 10, CancellationToken.None);
            if (subscription == null)
            {
                Log.Warning("{name}|Couldn't get tokens from faucet.", Name);
                return false;
            }

            return true;
        }

        private async Task<bool> HasTokensAsync()
        {
            var account = await _client.GetAccountAsync(CancellationToken.None);
            if (account == null || account.Data == null)
            {
                Log.Warning("{name}|No account found!", Name);
                return false;
            }

            if (account.Data.Free < 500 * SubstrateNetwork.DECIMALS)
            {
                Log.Warning("{name}|Account balance to low {value} BAJU.", Name, Math.Round((decimal)account.Data.Free / SubstrateNetwork.DECIMALS, 2));
                return false;
            }

            return true;
        }

        private bool IsPlayTime()
        {
            return true;
        }

        private bool Finish()
        {
            return false;
        }
    }
}