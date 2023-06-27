using Prism.Mvvm;

namespace WpfPrismPractice.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _Title = "Fuck";

        public string Title
        {
            get => _Title;
            set => SetProperty(ref _Title, value);
        }

        public MainWindowViewModel()
        {
            
        }
    }
}
