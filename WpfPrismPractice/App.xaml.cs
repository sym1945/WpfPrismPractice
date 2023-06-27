using Prism.Ioc;
using System.Windows;
using WpfPrismPractice.Views;

namespace WpfPrismPractice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        // 프로그램 MainWindow 반환
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
