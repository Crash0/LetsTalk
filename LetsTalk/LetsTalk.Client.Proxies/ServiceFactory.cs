using System.ComponentModel.Composition;
using LetsTalk.Core.Common.Contracts;
using LetsTalk.Core.Common.Core;

namespace LetsTalk.Client.Proxies
{
    [Export(typeof(IServiceFactory))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ServiceFactory : IServiceFactory
    {
        public T CreateClient<T>() where T : IServiceContract
        {
            return ObjectBase.Container.GetExportedValue<T>();
        }
    }
}