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
        public decimal cantidad = 0;
        public List<Venta> ventasRealizadas = new List<Venta>();


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

          ComboNegocio comboNegocio = new ComboNegocio();          


            dgvVenta.DataSource = null;
            dgvVenta.DataSource = comboNegocio.listacombo();

           
            dgvVenta.Columns["IdCombo"].Visible = false;
            dgvVenta.Columns["CodigoCombo"].Visible = false;
            dgvVenta.Columns["Activo"].Visible = false;


            // ⭐ Ajusta la columna del nombre automáticamente
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // ⭐ Hace que la columna nombre ocupe todo el ancho disponible
            dgvVenta.Columns["NombreCombo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // si tocaste el header, no sirve

            // Esto obtiene la fila seleccionada
             fila = e.RowIndex;

            // Esto obtiene el nombre del producto seleccionado
            string nombre = dgvVenta.Rows[fila].Cells["NombreCombo"].Value.ToString();

            // Esto obtiene el precio del producto seleccionado
            decimal precio = Convert.ToDecimal(dgvVenta.Rows[fila].Cells["Precio"].Value);

            
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
            string nombre = dgvVenta.Rows[fila].Cells["NombreCombo"].Value.ToString();
            decimal precio = Convert.ToDecimal(dgvVenta.Rows[fila].Cells["Precio"].Value);

            // 3️⃣ Creo el item para el ListView (carrito)
            ListViewItem item = new ListViewItem(nombre);      // Producto
            item.SubItems.Add(precio.ToString("0.00"));        // Precio
            item.SubItems.Add("1");                            // Cantidad
            item.SubItems.Add(precio.ToString("0.00"));        // Subtotal

            cantidad = cantidad + precio;

            // 4️⃣ Lo agrego al carrito
            listViewCarrito.Items.Add(item);
            lblTotal.Text = cantidad.ToString("0.00");
        }

        public void ConfigurarListView()
        {
            listViewCarrito.View = View.Details;
            listViewCarrito.FullRowSelect = true;

            listViewCarrito.Columns.Add("Combo", 150);
            listViewCarrito.Columns.Add("Precio", 70);
            listViewCarrito.Columns.Add("Cantidad", 70);
            listViewCarrito.Columns.Add("Subtotal", 80);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (listViewCarrito.Items.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito.");
                return;
            }

            // 2️⃣ Creo una nueva venta
            Venta v = new Venta();
            v.FechaVenta = DateTime.Now;     // Fecha y hora actual
            v.TotalPrecio = cantidad;    // 👉 USAMOS EL totalGeneral QUE YA TENÉS

            // 3️⃣ Guardo la venta en la lista
            ventasRealizadas.Add(v);

            // 4️⃣ Muestro un mensaje al usuario
            lblVentaExitosa.Text = "Venta Exitosa";
            lblTotalCobro.Text = "Total a Cobrar: $" + cantidad.ToString();

            // 5️⃣ Limpio para la próxima venta
            listViewCarrito.Items.Clear();  // Vacía el carrito
            cantidad = 0;               // Reinicia el total
            lblTotal.Visible= false;
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {


            listViewCarrito.Items.Clear();  
            cantidad = 0;               
            lblTotal.Visible= false;
            
            CargarProductos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Combo> listrafiltrada;
            ComboNegocio comboNegocio = new ComboNegocio();
            string filtro =txtFiltro.Text;

            if (filtro != "")
            {

              listrafiltrada = comboNegocio.listacombo().FindAll(x => x.NombreCombo.ToLower().Contains(filtro.ToLower()));


            }

            else
            {
                listrafiltrada = comboNegocio.listacombo();
            }

            dgvVenta.DataSource = null;
            dgvVenta.DataSource = listrafiltrada;
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listViewCarrito.Items.Clear();
            cantidad = 0;
            lblTotal.Visible = false;
            lblVentaExitosa.Visible= false;
            lblTotalCobro.Visible= false;
            lblTotal.Visible=false;

            CargarProductos();
        }

        private void cargaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Owner = this;  
            form1.Show();
            this.Hide();
        }
    }
}
