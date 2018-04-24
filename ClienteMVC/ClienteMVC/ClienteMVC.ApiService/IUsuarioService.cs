using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMVC.ApiService
{
    public interface IUsuarioService
    {
        Task<UsuarioServiceModel> GetAsync();
        Task<UsuarioServiceModel> SetAsync(UsuarioServiceModel usuarioServiceModel);
    }
}
