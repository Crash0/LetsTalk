using System;
using System.ComponentModel.Composition;
using System.ServiceModel;
using LetsTalk.Core.Common.Contracts;

namespace LetsTalk.Core.Common.ServiceModel
{
    public class UserClientBase<T> : ClientBase<T> where T : class
    {
        
        public UserClientBase()
        {
            MessageHeader<string> header = new MessageHeader<string>("_identity.GetAuthenticationToken()");

            var contextScope = new OperationContextScope(InnerChannel);
            
            OperationContext.Current.OutgoingMessageHeaders.Add(header.GetUntypedHeader("String","System"));

        }
    }
}
