using System;

namespace LetsTalk.Core.Kernel.Messages.Authentication.Commands
{
    public class LoginRequestLoginCommand
    {
        public Guid LoginAttemptGuid { get; set; }
    }
}
