using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommereceWeb.Application.DI
{
    public class MainModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.Load("EcommereceWeb.Application"))
                .Where(t => t.Name.EndsWith("Service") || t.Name.EndsWith("Manager")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
