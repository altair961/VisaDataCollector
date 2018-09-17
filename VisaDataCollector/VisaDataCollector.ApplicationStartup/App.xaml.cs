using Autofac;
using System.Windows;
using VisaDataCollector.ViewModel.Implementations;

namespace VisaDataCollector.ApplicationStartup
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bootstarpper = new Bootstrapper();
            var container = bootstarpper.Bootstrap();

            var mainWindow = container.Resolve<MainWindow>();

            mainWindow.Show();
        }
    }
}