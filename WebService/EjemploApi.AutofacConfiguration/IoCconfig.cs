using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.AutofacConfiguration
{
    public class IoCconfig
    {
        public static IContainer Build(Assembly ApiAssembys)
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(ApiAssembys);

            builder.RegisterModule(new RedisModule());

            builder.RegisterModule(new UsuarioBlModule());



            return builder.Build();
        }
    }
}
