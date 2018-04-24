using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMVC.ApiService
{
    public class UsuarioServiceModel
    {
        #region Properties
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        public UsuarioServiceModel(string id, string nombre, string apellido)
        {
            this.Id = Convert.ToInt32(id);
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
