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
    public partial class FrmAgregarStock : Form
    {

        Producto aux;
        public FrmAgregarStock()
        {
            InitializeComponent();
        }

        private void FrmAgregarStock_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            lblStockActualGramos.Visible = false;
            lblStockGramos.Visible=false;


        }

        public void CargarGrilla()
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();



            dgvAgregarStock.DataSource = null;
            dgvAgregarStock.DataSource = productoNegocio.listaproducto();

            dgvAgregarStock.Columns["IDProducto"].Visible = false;
            dgvAgregarStock.Columns["Activo"].Visible = false;
            dgvAgregarStock.Columns["IDProveedor"].Visible = false;
            dgvAgregarStock.Columns["CodigoProducto"].Visible = false;
            dgvAgregarStock.Columns["PrecioUnidad"].Visible = false;
            dgvAgregarStock.Columns["PrecioFinal"].Visible = false;
            dgvAgregarStock.Columns["Proveedor"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aux = (Producto)dgvAgregarStock.CurrentRow.DataBoundItem;

            txtNombreProd.Text= aux.NombreProducto;
            txtStockActual.Text = aux.Stock.ToString();

            bool esPorPeso = (aux.CantidadUnidad == 1000);
            if (esPorPeso)
            {

                lblStockActualGramos.Visible = true;
                lblStockGramos.Visible = true;

                lblStockActual.Visible = false;
                lblModificarStock.Visible=false;
            }


        }


        private void btnGuardarStock_Click(object sender, EventArgs e)
        {
            if (aux == null)
            {
                MessageBox.Show("Primero seleccioná un producto.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Stock actual tal como está guardado en el producto (unidades o gramos)
            int stockActual = aux.Stock;

            // 3) Lo que el usuario quiere agregar
            int cantidadIngresada;
            if (!int.TryParse(txtStockModificado.Text, out cantidadIngresada) || cantidadIngresada <= 0)
            {
                MessageBox.Show("Ingresá una cantidad válida para agregar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockModificado.Focus();
                return;
            }

            // 4) Detectar si es producto por peso:
            // en el alta, para productos en gramos usaste: CantidadUnidad = 1000
            bool esPorPeso = (aux.CantidadUnidad == 1000);

            int stockASumar;
            int SumarUnidadPaquete;

            int CantidadUnidad;
        

            if (esPorPeso)
            {
                // 🧀 Producto por peso: el usuario escribe KILOS
                // Ej: queso, ingreso 20 -> sumo 20 * 1000 gramos
                stockASumar = cantidadIngresada * 1000;
                SumarUnidadPaquete = cantidadIngresada + aux.UnidadPaquete;

                CantidadUnidad = 0;
            }
            else
            {
                int paquetesNuevos = int.Parse(txtCantidadPaquetes.Text);

                // 2) Leer cuántas unidades trae AHORA cada pack (puede haber cambiado)
                int unidadesPorPackNuevo = int.Parse(txtStockModificado.Text);

                // 3) Calcular cuántas unidades nuevas se suman al stock
                int unidadesNuevas = paquetesNuevos * unidadesPorPackNuevo;

                // 4) Lo que vas a sumar al stock total de unidades
                stockASumar = unidadesNuevas;

                // 5) Actualizar la cantidad de packs (UnidadPaquete)
                SumarUnidadPaquete = aux.UnidadPaquete + paquetesNuevos;

                // 6) Actualizar también la presentación del producto
                CantidadUnidad = unidadesPorPackNuevo;

            }

            int stockNuevo = stockActual + stockASumar;

            // 5) Confirmación con TU mensaje:
            DialogResult respuesta = MessageBox.Show(
                "Desea Cancelar La Operacion?",
                "Cancelar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // SI el usuario responde NO → limpiamos todo y NO guardamos
            if (respuesta == DialogResult.No)
            {
                txtNombreProd.Text = "";
                txtStockActual.Text = "";
                txtStockModificado.Text = "";
                return;
            }

            // SI el usuario responde SÍ → aplicamos el cambio de stock
          
            aux.Stock = stockNuevo;
            aux.UnidadPaquete = SumarUnidadPaquete;

            aux.Stock = stockNuevo;
            aux.UnidadPaquete = SumarUnidadPaquete;
            aux.CantidadUnidad = CantidadUnidad;


            // 6) Guardar en BD
            ProductoNegocio productoNegocio = new ProductoNegocio();
            productoNegocio.ModificarStock(aux);   // UPDATE SOLO DEL STOCK

            // 7) Refrescar UI
            txtStockActual.Text = stockNuevo.ToString();
            txtStockModificado.Text = "";

            MessageBox.Show("Stock actualizado correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarGrilla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProd.Text = "";
            txtStockActual.Text = "";
            txtStockModificado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmVenta frmVenta = new frmVenta();

            frmVenta.Owner = this;
            frmVenta.Show();
            this.Hide();

        }
    }
    
}
