﻿using Autofac;
using EjemploApi.DataAccess.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploApi.AutofacConfiguration
{
    public class RedisModule : Module    
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterGeneric(typeof(RedisDao<>))
                .As(typeof(IGetAsync<>))
                .As(typeof(ISetAsync<>))
                .InstancePerRequest();

            base.Load(builder);
        }
    }
}
