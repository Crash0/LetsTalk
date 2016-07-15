using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Kernel.Messages.Authentication.Commands;
using NServiceBus;

namespace LetsTalk.Authentication
{
    public class LogInRequestHandeler : IHandleMessages<LoginRequestLoginCommand>
    {
        public void Handle(LoginRequestLoginCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
