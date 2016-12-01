using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsTalk.Client.Contracts;

namespace LetsTalk.Client.Proxies
{
    using LetsTalk.Client.Contracts.DataContracts;

    [Export(typeof(ITelephonyServiceCallbacks))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class TelephoneServiceCallbackHandeler : ITelephonyServiceCallbacks
    {
        public event CallerConnectEvent OnCallerConnect;

        public event ConnectSucceededEvent OnConnectionSucceeded;

        public event ServerDisconnectEvent OnServerDisconnect;

        public event ConnectionFailedEvent OnConnectionFailed;

        public void CallerConnect(CallerInfo caller)
        {
            OnCallerConnect?.Invoke(this, caller);
        }

        public void ConnectionSucceeded()
        {
            OnConnectionSucceeded?.Invoke(this);
        }

        public void ConnectionFailed(ConnectionFailedInfo failInfo)
        {
            OnConnectionFailed?.Invoke(this, failInfo);
        }

        public void ServerDisconnect()
        {
            OnServerDisconnect?.Invoke(this);
        }
    }
}
