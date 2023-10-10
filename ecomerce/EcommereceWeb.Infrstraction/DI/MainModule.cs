using Autofac;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.Infrstraction.Repositories;

namespace EcommereceWeb.Infrstraction.DI
{
    public class MainModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.Load("EcommereceWeb.Infrstraction"))
                .Where(t=>t.Name.EndsWith("Repository") || t.Name.EndsWith("Manager")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
