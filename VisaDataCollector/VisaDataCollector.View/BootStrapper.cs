using Autofac;
using VisaDataCollector.ViewModel;

namespace VisaDataCollector.View
{
    public class BootStrapper
    {
        public IContainer Bootstrapp()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainWindowViewModel>().AsSelf();

            return builder.Build();
        }
    }
}