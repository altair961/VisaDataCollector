using Autofac;
using System.Windows;

namespace VisaDataCollector.View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bootstrapper = new BootStrapper();
            var container = bootstrapper.Bootstrapp();

            var mainWindow = container.Resolve<MainWindow>();

            //WindowViewLoaderService.Register(TypeOf(MainWindowView), TypeOf(MainWindowViewModel);
            //WindowViewLoaderService.Register(TypeOf(MyWindowView), TypeOf(MyWindowViewModel);

            mainWindow.Show();
        }
    }
}