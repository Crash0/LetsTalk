using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Core.Kernel.Messages.Authentication.Commands;
using NServiceBus;
using System.ComponentModel.Composition;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Authentication
{
    public class LogInRequestHandeler : IHandleMessages<LoginRequestLoginCommand>
    {
        [Import] private IDataRepositoryFactory _dataRepositoryFactory;
        public void Handle(LoginRequestLoginCommand message)
        {
            throw new NotImplementedException();
            //var authenticationRepository = _dataRepositoryFactory.GetDataRepository<IauthenticationRepository>()
        }
    }
}
