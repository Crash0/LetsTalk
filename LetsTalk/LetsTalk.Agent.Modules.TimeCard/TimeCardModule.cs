using LetsTalk.Agent.Modules.TimeCard.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace LetsTalk.Agent.Modules.TimeCard
{
    public class TimeCardModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(LetsTalk.Core.Common.UI.RegionNames.MainRegion, typeof(StampingLog));
        }
    }
}
