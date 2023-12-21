using Substrate.Integration;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using Substrate.Integration.Helper;
using Substrate.NetApi.Model.Types;
using Serilog;
using System.Text;
using Substrate.NetApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Yaml;
using Substrate.Ordinals.Bot.Model;
using System.Text.Json;
using System.Runtime.InteropServices;

namespace Substrate.Ordinals.Bot
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .CreateLogger();

            Log.Logger = logger;

            // Add this to your C# console app's Main method to give yourself
            // a CancellationToken that is canceled when the user hits Ctrl+C.
            var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("Canceling...");
                cts.Cancel();
                e.Cancel = true;
            };

            var config = new ConfigurationBuilder()
                // this will be used more later on
                .SetBasePath(AppContext.BaseDirectory)
                // I chose using YML files for my config data as I am familiar with them
                .AddYamlFile("config.yml")
                .Build();

            try
            {
                Log.Information("Press Ctrl+C to end.");
                await MainAsync(config, cts.Token);
            }
            catch (OperationCanceledException)
            {
                // This is the normal way we close.
                Log.Warning("OperationCanceledException!!!");
            }

            // Finally, once just before the application exits...
            await Log.CloseAndFlushAsync();
        }

        static async Task MainAsync(IConfigurationRoot config, CancellationToken token)
        {
            Log.Information("Ordinal Wallet: ");
            var ordAccount = Console.ReadLine();
            if (!int.TryParse(ordAccount, out int ordAccountResult))
            {
                throw new NotSupportedException("Invalid choice.");
            }

            var key = $"mnemnonic:ord{ordAccountResult}";
            var mnemonicSeed = config[key];

            var ordinalType = "pdc-20";
            var ordinalOperation = "mint";

            Log.Information("Enter Ordinal Ticker: ");
            var ordinalTicker = Console.ReadLine();

            Log.Information("Enter Ordinal Amount: ");
            var ordinalAmount = Console.ReadLine();

            Console.WriteLine("WebSocket URL");
            Log.Information("1: {rpcendpoint}", config["endpoints:wss1"]);
            Log.Information("2: {rpcendpoint}", config["endpoints:wss2"]);
            Log.Information("3: {rpcendpoint}", config["endpoints:wss3"]);
            Log.Information("(default): {rpcendpoint}", config["endpoints:wss1"]);
            Log.Information("Enter choice (1-3):");

            var choiceUrl = Console.ReadLine();
            if ( !int.TryParse(choiceUrl, out int chhoiceUrlResult))
            {
                throw new NotSupportedException("Invalid choice.");
            }

            var webSocketUrl = config[$"endpoints:wss{chhoiceUrlResult}"];

            Log.Information("WebSocket URL: {rpcendpoint}", webSocketUrl);

            var account = Mnemonic.GetAccountFromMnemonic(mnemonicSeed, "", KeyType.Sr25519);
            Log.Information("Account Initialized: {account}", account.Value);

            var ordinalMint = new OrdinalMint() {
                Protocol = "pdc-20",
                Operation = "mint",
                Ticker = "300",
                Amount = "300"
            };

            var ordinalMintSerialized = JsonSerializer.Serialize(ordinalMint);
            Log.Information("Ordinal JSON: {json}", ordinalMintSerialized);

            while (true)
            {
                SubstrateNetwork client = new SubstrateNetwork(account, NetworkType.Live, webSocketUrl);
                try
                {
                    var isConnected = await client.ConnectAsync(true, true, CancellationToken.None);
                    Log.Information("Connected to Substrate Network: {isConnected}", isConnected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(10000);
                }

                while (client.IsConnected)
                {
                    try
                    {
                        // Initialize account and connect to network
                        //Account account = BaseClient.RandomAccount(27121977 + i);

                        var accountData = await client.GetAccountAsync(account, CancellationToken.None);
                        if (accountData == null)
                        {
                            Log.Information("Account not found on chain. Please fund the account and try again.");
                            return;
                        }
                        Log.Information("Account found on chain. Balance: " + accountData.Data.Free.ToString());

                        var bytes = ASCIIEncoding.ASCII.GetBytes(ordinalMintSerialized);
                        var baseVec = new BaseVec<U8>();
                        baseVec.Create(bytes.Select(p => new U8(p)).ToArray());

                        // Submit and watch transaction
                        Log.Information("Submitting transaction...");
                        var cancellationTokenSource = new CancellationTokenSource();
                        var subscriptionId1 = await client.RemarkWithEventAsync(baseVec, 10, cancellationTokenSource.Token);

                        if (subscriptionId1 == null)
                        {
                            Log.Warning("Failed to submit transaction.");
                            break;
                        }

                        Log.Information("RemarksAsync submitted. Subscription ID: {subscriptionId1}", subscriptionId1);

                        for (var j = 0; j < 10; j++)
                        {
                            var info = client.ExtrinsicManager.Get(subscriptionId1);
                            Console.WriteLine($"[{info.Index}][{info.LastUpdated}] {info.ExtrinsicType} {info.TransactionEvent}");
                            if (info.TransactionEvent == Substrate.NetApi.Model.Rpc.TransactionEvent.BestChainBlockIncluded)
                            {
                                Log.Information("Transaction included in block.");
                                break;
                            }
                            else if (info.TransactionEvent == Substrate.NetApi.Model.Rpc.TransactionEvent.Invalid)
                            {
                                Log.Information("Transaction failed.");
                                Thread.Sleep(3000);
                                break;
                            }

                            Thread.Sleep(1000);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Warning(ex.Message);
                    }
                }

                await client.DisconnectAsync();

                Log.Information("Waiting to reconnect...");
                Thread.Sleep(5000);
            }

        }
    }
}