using System;
using Prism.Commands;

namespace LetsTalk.Agent.Modules.Controllers
{
    public interface IPhoneController
    {
        DelegateCommand<Guid> CallCommand { get; }
    }
}