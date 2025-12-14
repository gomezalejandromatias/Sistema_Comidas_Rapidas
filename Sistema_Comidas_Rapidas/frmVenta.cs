using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Negocio;
using Sistema_Comidas_Rapidas.Helpers;

namespace Sistema_Comidas_Rapidas
{
    public partial class frmVenta : Form
    {
        public int fila = -1;
        public decimal cantidad = 0;
        int contador = 0;
        private List<VentaCombo> detallesActuales = new List<VentaCombo>();



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
            dgvVenta.DataSource = comboNegocio.listacomboParaVenta();


            dgvVenta.Columns["IdCombo"].Visible = false;
            dgvVenta.Columns["CodigoCombo"].Visible = false;
            dgvVenta.Columns["Activo"].Visible = false;


            // ⭐ Ajusta la columna del nombre automáticamente
            ///   dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // ⭐ Hace que la columna nombre ocupe todo el ancho disponible
            ///  dgvVenta.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar peso de cada columna
            dgvVenta.Columns["Nombre"].FillWeight = 400;             // más chica
            dgvVenta.Columns["Precio"].FillWeight = 100;             // más chica
            dgvVenta.Columns["Ingredientes"].FillWeight = 400; // MUCHO más grande
            dgvVenta.Columns["FechaAlta"].FillWeight = 200;

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
            int idCombo = Convert.ToInt32(dgvVenta.Rows[fila].Cells["IdCombo"].Value);
            string nombre = dgvVenta.Rows[fila].Cells["Nombre"].Value.ToString();
            decimal precio = Convert.ToDecimal(dgvVenta.Rows[fila].Cells["Precio"].Value);

            // 3️⃣ Creo el item para el ListView (carrito)
            ListViewItem item = new ListViewItem(nombre);      // Producto
            item.SubItems.Add(precio.ToString("0.00"));        // Precio
            item.SubItems.Add("1");                            // Cantidad
            item.SubItems.Add(precio.ToString("0.00"));        // Subtotal

            cantidad = cantidad + precio;

            // 4️⃣ Lo agrego al carrito
            listViewCarrito.Items.Add(item);
            lblMostrarSubtotal.Text = cantidad.ToString("0.00");

            VentaCombo det = new VentaCombo();
            det.IdCombo = idCombo;
            det.Cantidad = 1;         // por ahora 1 siempre
            det.PrecioUnitario = precio;

            detallesActuales.Add(det);
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

            // 2) Validar forma de pago
            if (comboBoxFormaPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una forma de pago.");
                return;
            }

            try
            {
                VentaNegocio ventaNegocio = new VentaNegocio();
                Venta v = new Venta();

                // 3) Completar datos de la venta
                v.NumeroVenta = ObtenerUltimoNumeroVenta();
                v.FechaVenta = DateTime.Now;
                v.TotalPrecio = cantidad;   // total general que venís acumulando
                v.FormaPago = comboBoxFormaPago.SelectedItem.ToString();
                v.Detalles = detallesActuales;   // la lista de combos del carrito

                // 4) Guardar venta (acá se llama al SP_GuardarVentaCompleta)
                ventaNegocio.guardarventa(v);

                // 5) Si llegó hasta acá, la venta se guardó OK
                lblVentaExitosa.Text = "Venta exitosa";
                lblTotalCobro.Text = "Total a Cobrar: $" + cantidad.ToString();

                // Limpiar carrito y totales para la próxima venta
                listViewCarrito.Items.Clear();
                cantidad = 0;
               lblMostrarSubtotal.Visible=false;
            }
            catch (SqlException ex)
            {
                // Errores que vienen desde SQL (incluye RAISERROR del SP)
                if (ex.Message.Contains("No hay stock suficiente del producto"))
                {
                    // Mensaje claro de stock insuficiente
                    MessageBox.Show(ex.Message,
                                    "Stock insuficiente",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                else
                {
                    // Otros errores de SQL (FK, sintaxis, etc.)
                    MessageBox.Show("Error en la base de datos: " + ex.Message,
                                    "Error en la venta",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }

                // IMPORTANTE: acá NO limpio el carrito ni la cantidad.
                // Así el usuario puede corregir y volver a intentar.
            }
            catch (Exception ex)
            {
                // Errores de C# (nulos, lógica, etc.)
                MessageBox.Show("Ocurrió un error al realizar la venta: " + ex.Message,
                                "Error en la venta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {


            listViewCarrito.Items.Clear();
            cantidad = 0;
          

         
            lblTotal.Text = "";
            lblVentaExitosa.Text = "";
            lblMostrarSubtotal.Text = "";
            lblTotalCobro.Text = "";

            CargarProductos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Combo> listrafiltrada;
            ComboNegocio comboNegocio = new ComboNegocio();
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {

                listrafiltrada = comboNegocio.listacombo().FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));


            }

            else
            {
                listrafiltrada = comboNegocio.listacombo();
            }

            dgvVenta.DataSource = null;
            dgvVenta.DataSource = listrafiltrada;

            dgvVenta.Columns["IdCombo"].Visible = false;
            dgvVenta.Columns["CodigoCombo"].Visible = false;
            dgvVenta.Columns["Activo"].Visible = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listViewCarrito.Items.Clear();
            cantidad = 0;
            lblTotal.Text = "";
            lblVentaExitosa.Text = "";
            lblMostrarSubtotal.Text = "";
            lblTotalCobro.Text = "";


            CargarProductos();
        }

        private void cargaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Owner = this;
            form1.Show();
            this.Hide();
        }


        private void comboBoxFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        public int ObtenerUltimoNumeroVenta()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Busco el último Número de Venta y le sumo 1
                datos.SetearConsulta(
                    "SELECT CAST(ISNULL(MAX(NumeroVenta), 0) + 1 AS INT) AS ProximoNumero FROM Ventas"
                );

                object resultado = datos.EjecutarEscalar();

                // Si viene null o DBNull → arranco en 1
                if (resultado == null || resultado == DBNull.Value)
                    return 1;

                int numero;
                if (!int.TryParse(resultado.ToString(), out numero))
                    numero = 1;

                return numero;
            }
            catch (Exception)
            {
                // Si algo raro pasa en SQL, por lo menos no revienta todo
                return 1;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            comboBoxFormaPago.Items.Add("Efectivo");
            comboBoxFormaPago.Items.Add("Transferencia");
            comboBoxFormaPago.Items.Add("QR");

            

            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblVersion.Text = "Versión 1.0";

            lblTotal.Visible = false;
            UIHelper.BotonPrincipal(btnVender);
            UIHelper.BotonSecundarioPremium(btnLimpiar);
            UIHelper.BotonPeligroPremium(btnCancelarVenta);

            UIHelper.BotonSecundarioPremium(btnSeleccionarProducto);

            UIHelper.LabelPremium(lblFiltar);
            UIHelper.LabelPremium(lblTotal);
            UIHelper.LabelPremium(lblProductos);
            UIHelper.LabelPremium(lblFormaPago);
            UIHelper.LabelPremium(lblTotalCobro);
            UIHelper.LabelPremium(lblVentaExitosa);
            UIHelper.LabelTituloPremium(lblTitulo);
            UIHelper.LabelPremium(lblMostrarSubtotal);
            UIHelper.LabelPremium(lblSubtotal);


            UIHelper.DataGridViewModerno(dgvVenta);
            UIHelper.ListViewModerno(listViewCarrito);
            UIHelper.ComboBoxModerno(comboBoxFormaPago);
            dgvVenta.ClearSelection();
        }

        private void combosdeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCombo frmCombo = new FrmCombo();

            frmCombo.Owner = this;
            frmCombo.Show();
            this.Hide();



        }

        private void registrosDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleVenta frmDetalleVenta = new FrmDetalleVenta();
            frmDetalleVenta.Owner = this;
            frmDetalleVenta.Show();
            this.Hide();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {



            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.Owner = this;
            frmProveedor.Show();
            this.Hide();





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void movimientosDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblVersion frmAgregarStock = new lblVersion();
            frmAgregarStock.Owner = this;
            frmAgregarStock.Show();
            this.Hide();
        }
    }
}
