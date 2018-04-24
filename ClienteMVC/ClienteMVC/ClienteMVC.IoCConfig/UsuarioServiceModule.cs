using Autofac;
using ClienteMVC.ApiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMVC.IoCConfig
{
    public class UsuarioServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<UsuarioService>()
                .As<IUsuarioService>()
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
