using System;
using System.ServiceModel;
using LetsTalk.Core.Common.Exceptions;

namespace LetsTalk.Business.Managers
{
    public class ManagerBase
    {
        protected string LoginToken ;
        public ManagerBase()
        {
            var operationContext = OperationContext.Current;
            if (operationContext != null)
            {
                LoginToken = operationContext.IncomingMessageHeaders.GetHeader<string>("String", "System");
                //TODO:MEssage Authserver and Authorize token
            }
        }
        protected T ExecuteFaultHandeledOperation<T>(Func<T> codeToExecute)
        {
            try
            {
                return codeToExecute.Invoke();
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
        protected void ExecuteFaultHandeledOperation(Action codeToExecute)
        {
            try
            {
                codeToExecute.Invoke();
            }
            catch (FaultException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}