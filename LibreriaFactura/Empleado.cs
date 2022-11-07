using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class Empleado:Persona
    {
        public Empleado(string apellido, string nombre, string dNI, int legajo) : base(apellido, nombre, dNI)
        {
            Legajo = legajo;
        }

        public int Legajo { get; set; }
    }
}
