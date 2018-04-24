using Autofac;
using EjemploApi.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.AutofacConfiguration
{
    public class UsuarioBlModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<UsuarioBlAsync>()
                .As<IUsuarioBlAsync>()
                .InstancePerRequest();
               
            base.Load(builder);
        }

    }
}
