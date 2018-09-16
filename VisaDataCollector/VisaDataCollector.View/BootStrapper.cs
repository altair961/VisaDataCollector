using Autofac;
using VisaDataCollector.ViewModel.Implementations;
using VisaDataCollector.ViewModel.Interfaces;

namespace VisaDataCollector.View
{
    public class BootStrapper
    {
        public IContainer Bootstrapp()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowViewModel>().AsSelf();

            builder.RegisterType<VisaApplicationManagerViewModel>().As<IVisaApplicationManagerViewModel>();

            return builder.Build();
        }
    }
}