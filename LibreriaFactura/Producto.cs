using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class Producto
    {
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public Categoria Categoria { get; set; }

        public List<DetalleFactura> DetallesFactura { get; set; }
    }
}
