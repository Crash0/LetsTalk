using Prism.Commands;

namespace LetsTalk.Core.Common.UI
{
    public static class AgentCommands
    {
        private static CompositeCommand callCommand = new CompositeCommand();

        public static CompositeCommand CallCommand
        {
            get { return callCommand; }
            set { callCommand = value; }
        }
    }
}