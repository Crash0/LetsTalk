using System;
using LetsTalk.Core.Common.UI.Commands;
using Prism.Events;

namespace LetsTalk.Core.Common.UI.Events
{
    public class AddToolBarButtonEvent : PubSubEvent<ToolbarActionDelegate>
    {
    }
}