using System.ServiceModel;

namespace LetsTalk.Core.Common.ServiceModel
{
    public class UserClientBase<T> : ClientBase<T> where T : class 
    {
    }
}
