using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(string contrasena, string nombre)
        {
            Contrasena = contrasena;
            Nombre = nombre;
           
        }

        public string Contrasena { get; set; }
        public string Nombre { get; set; }

        public Cliente Cliente { get; set; }

    }
}
