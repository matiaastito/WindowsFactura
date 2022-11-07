using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class DetalleFactura
    {
        public Factura factura { get; set; }
        public Producto producto { get; set; }
    }
}
