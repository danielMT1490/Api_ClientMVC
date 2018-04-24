using Autofac.Integration.WebApi;
using EjemploApi.AutofacConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace EjemploApi.Business.Facade.Logic
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.DependencyResolver = 
                new AutofacWebApiDependencyResolver(
                    IoCconfig.Build(
                        Assembly.GetExecutingAssembly()));

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
