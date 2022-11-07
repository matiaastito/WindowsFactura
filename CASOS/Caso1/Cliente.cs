using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS.Caso1
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
