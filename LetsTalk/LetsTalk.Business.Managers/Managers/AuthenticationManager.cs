using System.ServiceModel;
using LetsTalk.Business.Contracts;

namespace LetsTalk.Business.Managers
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall,
        ConcurrencyMode = ConcurrencyMode.Multiple,
        ReleaseServiceInstanceOnTransactionComplete = false)]
    public class AuthenticationManager: ManagerBase , IAuthenticationService
    {
        [OperationBehavior(TransactionScopeRequired = true)]
        public string GetAuthenticationToken(string loginId, string passHash)
        {
            return "NotImplemented Token";
        }
    }
}
