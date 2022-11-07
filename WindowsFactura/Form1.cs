using LibreriaFactura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFactura
{
    public partial class Form1 : Form
    {
        List<Producto> listaProductos = new List<Producto>();
        List<DetalleFactura> listaDetalle = new List<DetalleFactura>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicializarProductos_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();
            Producto producto2 = new Producto();
            Categoria categoria1 = new Categoria("Hardware", listaProductos);
            Categoria categoria2 = new Categoria("Software", listaProductos);

            producto1.Nombre = "Teclado";
            producto1.Precio = 550;
            producto1.Categoria = categoria1;
            producto1.DetallesFactura = listaDetalle;

            producto2.Nombre = "Windows XP";
            producto2.Precio = 1200;
            producto2.Categoria = categoria2;
            producto2.DetallesFactura = listaDetalle;

            listaProductos.Add(producto1);
            listaProductos.Add(producto2);

            MessageBox.Show("Productos ingresados con exito");


        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            gridProductos.DataSource = listaProductos;
        }
    }
}
