using EjemploApi.Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace EjemploApi.Business.Facade.Logic.Controllers
{
    public class UsuarioAsyncV2Controller : ApiController
    {
        private readonly IUsuarioBlAsync _usuarioBlAsync;

        public UsuarioAsyncV2Controller(IUsuarioBlAsync usuarioBlAsync)
        {
            this._usuarioBlAsync = usuarioBlAsync;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAsync(string key)
        {
            Thread.Sleep(10000);
            var result = await this._usuarioBlAsync.GetAsync(key);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IHttpActionResult> AddAsync(Usuario entity, string key)
        {
            Thread.Sleep(10000);
            var result = await this._usuarioBlAsync.AddAsync(entity, key);
            return Ok(result);
        }
    }
}