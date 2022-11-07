using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS.Caso3
{
    public class Tripulacion
    {
        public int NroVuelo { get; set; }
        public int CantTripulantes { get; set; }
        public List<Azafata> Azafatas { get; set; }
    }
}
