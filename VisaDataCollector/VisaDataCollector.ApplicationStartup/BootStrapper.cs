using Autofac;
using VisaDataCollector.ViewModel.Implementations;
using VisaDataCollector.ViewModel.Interfaces;

namespace VisaDataCollector.ApplicationStartup
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<WinViewLoader>().As<IWinViewLoader>();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowViewModel>().AsSelf();

            builder.RegisterType<VisaApplicationManagerViewModel>().As<IVisaApplicationManagerViewModel>();



            return builder.Build();
        }
    }
}