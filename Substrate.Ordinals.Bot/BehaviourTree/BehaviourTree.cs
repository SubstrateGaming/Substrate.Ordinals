namespace Substrate.Ordinals.Bot.BehaviourTree
{
    public abstract class Node
    {
        public string? Name { get; }

        protected Node(string? name = null)
        {
            Name = name;
        }

        public string? Description { get; internal set; }

        public abstract bool Execute();
    }

    public class Selector : Node
    {
        private readonly List<Node> _nodes;

        public Selector(List<Node> nodes) : base(null)
        {
            _nodes = nodes;
        }

        public Selector(string name, List<Node> nodes) : base(name)
        {
            _nodes = nodes;
        }

        public override bool Execute()
        {
            foreach (var node in _nodes)
            {
                if (node.Execute())
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Sequence : Node
    {
        private readonly List<Node> _nodes;

        public Sequence(List<Node> nodes) : base(null)
        {
            _nodes = nodes;
        }

        public Sequence(string name, List<Node> nodes) : base(name)
        {
            _nodes = nodes;
        }

        public override bool Execute()
        {
            foreach (var node in _nodes)
            {
                if (!node.Execute())
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Inverter : Node
    {
        private readonly Node _node;

        public Inverter(Node node) : base(null)
        {
            _node = node;
        }

        public override bool Execute()
        {
            return !_node.Execute();
        }
    }

    public class Action : Node
    {
        private readonly Func<bool> _action;

        public Action(Func<bool> action) : base(null)
        {
            _action = action;
        }

        public Action(string name, Func<bool> action) : base(name)
        {
            _action = action;
        }

        public override bool Execute()
        {
            return _action();
        }
    }

    public class Condition : Node
    {
        private readonly Func<bool> _condition;

        public Condition(Func<bool> condition) : base(null)
        {
            _condition = condition;
        }

        public Condition(string name, Func<bool> condition) : base(name)
        {
            _condition = condition;
        }

        public override bool Execute()
        {
            return _condition();
        }
    }

    public class RandomSelector : Node
    {
        private readonly List<Node> _nodes;
        private readonly Random _random = new();

        public RandomSelector(List<Node> nodes) : base(null)
        {
            _nodes = nodes;
        }

        public RandomSelector(string name, List<Node> nodes) : base(name)
        {
            _nodes = nodes;
        }

        public override bool Execute()
        {
            if (!_nodes.Any())
            {
                return false;
            }

            var randomNode = _nodes[_random.Next(_nodes.Count)];
            return randomNode.Execute();
        }
    }
}