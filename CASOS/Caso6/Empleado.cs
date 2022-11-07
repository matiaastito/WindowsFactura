using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS.Caso6
{
    public class Empleado
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string CUIL { get; set; }
        public DatosContacto DatosContacto { get; set; }
    }
}
