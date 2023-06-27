using ModuleA.ViewModels;
using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleAModule : IModule
    {
        private readonly IRegionManager _RegionManager;

        public ModuleAModule(IRegionManager regionManager)
        {
            _RegionManager = regionManager;
        }


        public void OnInitialized(IContainerProvider containerProvider)
        {
            // View Discovery
            //_RegionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));

            // View Injection
            //var view = containerProvider.Resolve<ViewA>();
            //_RegionManager.Regions["ContentRegion"].Add(view);
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
        }
    }
}