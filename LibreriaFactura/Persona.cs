using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public abstract class Persona
    {
        protected Persona(string nombre, string apellido, string dNI)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
    }
}
