using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMVC.IoCConfig
{
    public class IoCConfig
    {
        public static IContainer Build(Assembly ApiAssembys ,ViewRegistrationSource viewRegistrationSource)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(ApiAssembys);

            builder.RegisterFilterProvider();

            builder.RegisterSource(viewRegistrationSource);

            builder.RegisterModule(new UsuarioServiceModule());

            builder.RegisterModule(new HttpClientModule());



            return builder.Build();
        }
    }
}
