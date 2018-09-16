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

            var mainWindow = new MainWindow(new MainWindowViewModel());
            mainWindow.Show();
        }
    }
}