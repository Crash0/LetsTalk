using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Client.Contracts;

namespace LetsTalk.Client.Proxies
{
    [Export(typeof(ITelephonyServiceCallbacks))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    class TelephoneServiceCallbackHandeler : ITelephonyServiceCallbacks
    {
        public event CallerConnectEvent OnCallerConnect;
        public event ConnectSucceededEvent OnConnectionSucceeded;

        public void CallerConnect(CallerInfo caller)
        {
            OnCallerConnect?.Invoke(this, caller);
        }

        public void ConnectionSucceeded()
        {
            OnConnectionSucceeded?.Invoke(this);
        }
    }
}
