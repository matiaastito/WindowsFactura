using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class Factura
    {
        public Factura(Empleado empleado, Cliente cliente, int nroFactura, List<DetalleFactura> detalleFacturas)
        {
            this.empleado = empleado;
            this.cliente = cliente;
            NroFactura = nroFactura;
            this.detalleFacturas = detalleFacturas;
        }

        public Empleado empleado { get; set; }

        public Cliente cliente { get; set; }

        public int NroFactura { get; set; }

        public List<DetalleFactura> detalleFacturas { get; set; }
    }
}
