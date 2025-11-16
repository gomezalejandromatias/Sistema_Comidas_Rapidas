using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Sistema_Comidas_Rapidas
{
    public partial class frmVenta : Form
    {
        public int fila = -1;
        public frmVenta()
        {
            InitializeComponent();
            ConfigurarListView();
            CargarProductos();
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            
        }

        private void listViewCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CargarProductos()
        {

            ProductoNegocio productoNegocio = new ProductoNegocio();
          


            dgvVenta.DataSource = null;
            dgvVenta.DataSource = productoNegocio.listaproducto();

           
            dgvVenta.Columns["IDProducto"].Visible = false;
            dgvVenta.Columns["FechaIngreso"].Visible = false;
            dgvVenta.Columns["Activo"].Visible = false;
            

        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // si tocaste el header, no sirve

            // Esto obtiene la fila seleccionada
             fila = e.RowIndex;

            // Esto obtiene el nombre del producto seleccionado
            string nombre = dgvVenta.Rows[fila].Cells["Nombre"].Value.ToString();

            // Esto obtiene el precio del producto seleccionado
            decimal precio = Convert.ToDecimal(dgvVenta.Rows[fila].Cells["Precio"].Value);

            MessageBox.Show("Seleccionaste: " + nombre + "  $" + precio);
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            // 1️⃣ Si no seleccionaste nada → aviso
            if (fila < 0)
            {
                MessageBox.Show("Por favor seleccione un producto.");
                return;
            }

            // 2️⃣ Obtengo los valores del producto en la fila seleccionada
            string nombre = dgvVenta.Rows[fila].Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(dgvVenta.Rows[fila].Cells["Precio"].Value);

            // 3️⃣ Creo el item para el ListView (carrito)
            ListViewItem item = new ListViewItem(nombre);      // Producto
            item.SubItems.Add(precio.ToString("0.00"));        // Precio
            item.SubItems.Add("1");                            // Cantidad
            item.SubItems.Add(precio.ToString("0.00"));        // Subtotal

            // 4️⃣ Lo agrego al carrito
            listViewCarrito.Items.Add(item);
        }

        public void ConfigurarListView()
        {
            listViewCarrito.View = View.Details;
            listViewCarrito.FullRowSelect = true;

            listViewCarrito.Columns.Add("Producto", 150);
            listViewCarrito.Columns.Add("Precio", 70);
            listViewCarrito.Columns.Add("Cantidad", 70);
            listViewCarrito.Columns.Add("Subtotal", 80);
        }
    }
}
