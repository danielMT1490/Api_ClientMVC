using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMVC.IoCConfig
{
    public class HttpClientModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<HttpClient>()
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
