using ModuleA.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;

namespace WpfPrismPractice.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _RegionManager;
        private readonly IEventAggregator _EventAggregator;
        
        private string _Title = "Fuck";
        private bool _IsChecked;
        private DelegateCommand<string> _NavigateCommand;

        public string Title
        {
            get => _Title;
            set => SetProperty(ref _Title, value);
        }
        
        public bool IsChecked
        {
            get { return _IsChecked; }
            set { SetProperty(ref _IsChecked, value); }
        }


        public DelegateCommand<string> NavigateCommand => _NavigateCommand;


        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _RegionManager = regionManager;
            _EventAggregator = eventAggregator;
            _NavigateCommand = new DelegateCommand<string>(ExecuteCommandName)
                .ObservesCanExecute(() => IsChecked);
        }

        private void ExecuteCommandName(string viewName)
        {
            var p = new NavigationParameters();
            p.Add("id", 23);

            _RegionManager.RequestNavigate("ContentRegion", viewName, p);

            _EventAggregator.GetEvent<MessageEvent>().Publish($"Navigated to {viewName}");
        }

        

    }
}
