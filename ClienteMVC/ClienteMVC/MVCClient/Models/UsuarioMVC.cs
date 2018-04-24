using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCClient.Models
{
    public class UsuarioMVC
    {
        #region Properties
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region Constructor
        public UsuarioMVC(string id, string nombre, string apellido)
        {
            this.Id = Convert.ToInt32(id);
            this.Nombre = nombre;
            this.Apellido = apellido;
        } 
        #endregion
    }
}