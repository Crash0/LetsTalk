using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;

namespace LetsTalk.Core.Common.UI
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class AgentCommandProxy
    {
        public virtual CompositeCommand CallCommand => AgentCommands.CallCommand;

    }
}
