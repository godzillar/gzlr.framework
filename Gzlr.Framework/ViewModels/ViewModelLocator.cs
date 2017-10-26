namespace Gzlr.Framework.ViewModels
{
    using Autofac;
    using Configuration;
    using Interfaces;

    public class ViewModelLocator
    {
        private readonly IContainer _container;

        public ViewModelLocator()
        {
            var builder = new ContainerBuilder();
            AutofacConfig.Register(builder);
            _container = builder.Build();
        }

        public IMainViewModel MainViewModel => _container.Resolve<IMainViewModel>();
    }
}