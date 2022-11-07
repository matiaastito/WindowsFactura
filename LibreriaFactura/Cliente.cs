using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class Cliente : Persona
    {
        public Cliente(string apellido, string nombre, string dNI, int iD) : base(apellido, nombre, dNI)
        {
            ID = iD;
        }

        public int ID { get; set; }

        public List<Factura> facturas { get; set; }

        public Usuario Usuario { get; set; }
    }
}
