using Autofac;
using System.Windows;
using VisaDataCollector.ViewModel;

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
            mainWindow.Show();
        }
    }
}