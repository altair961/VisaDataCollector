using System.Windows;
using VisaDataCollector.ViewModel.Implementations;

namespace VisaDataCollector.ApplicationStartup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _mainWindowViewModel;

        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;

            _mainWindowViewModel = mainWindowViewModel;
            DataContext = _mainWindowViewModel;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _mainWindowViewModel.Load();
        }
    }
}