using Autofac;
using Gzlr.Framework.Interfaces;
using Gzlr.Framework.ViewModels;
using Gzlr.Service;
using Gzlr.Service.Interfaces;

namespace Gzlr.Framework.Configuration
{
    public class AutofacConfig
    {
        public static void Register(ContainerBuilder builder)
        {
            builder.RegisterType<Class1>().As<IClass1>().SingleInstance();
            builder.Register(c => new MainViewModel(c.Resolve<IClass1>())).As<IMainViewModel>();
        }
    }
}