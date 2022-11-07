using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class Categoria
    {
        public Categoria(string nombre, List<Producto> productos)
        {
            Nombre = nombre;
            this.productos = productos;
        }

        public string Nombre { get; set; }

        public List<Producto> productos { get; set; }
    }
}
