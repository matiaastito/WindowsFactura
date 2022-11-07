using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS.Caso1
{

    public class Pedido
    {
        public int NroPedido {get; set;}
        public string Detalle { get; set; }
        public Cliente Cliente { get; set; }
    }
}
