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
using Sistema_Comidas_Rapidas.Helpers;

namespace Sistema_Comidas_Rapidas
{
    public partial class lblVersion : Form
    {

        Producto aux;
        public lblVersion()
        {
            InitializeComponent();
        }

        private void FrmAgregarStock_Load(object sender, EventArgs e)
        {
            CargarGrilla();

            lblStockActualGramos.Visible = false;
            lblStockGramos.Visible=false;
            lblAclaratorio.Visible = false;

            UIHelper.LabelTituloPremium(lblTitulo);
            UIHelper.DataGridViewModerno(dgvAgregarStock);

            UIHelper.LabelPremium(lblCantidadPaquetes);
            UIHelper.LabelPremium(lblModificarStock);
            UIHelper.LabelPremium(lblNombreProducto);
            UIHelper.LabelPremium(lblStockActual);
            UIHelper.LabelPremium(lblStockActualGramos);
            UIHelper.BotonPrincipal(btnGuardarStock);
            UIHelper.BotonAmarilloPremium(btnLimpiar);
            UIHelper.BotonPeligroPremium(btnCancelar);
            UIHelper.BotonAmarilloPremium(txtSeleccionar);
            UIHelper.LabelPremium(lblSubTitulo);
            UIHelper.LabelPremium(lblStockGramos);
            UIHelper.LabelPremium(lblAclaratorio);
            






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
         
            dgvAgregarStock.Columns["Proveedor"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aux = (Producto)dgvAgregarStock.CurrentRow.DataBoundItem;

            txtNombreProd.Text= aux.NombreProducto;
            txtStockActual.Text = aux.Stock.ToString();
            txtPrecioStock.Text = aux.PrecioUnidad.ToString("0.00");

            bool esPorPeso = (aux.CantidadUnidad == 1000);
            if (esPorPeso)
            {

                lblStockActualGramos.Visible = true;
                lblStockGramos.Visible = true;
                lblAclaratorio.Visible = true;

                lblStockActual.Visible = false;
                lblModificarStock.Visible=false;
                lblCantidadPaquetes.Visible = false;
                txtCantidadPaquetes.Visible=false;


                

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

            // ✅ PRECIO OBLIGATORIO (precio por unidad o por kilo)
            decimal precioIngresado;
            if (!decimal.TryParse(txtPrecioStock.Text, out precioIngresado) || precioIngresado <= 0)
            {
                MessageBox.Show("Ingresá el precio por unidad/kilo (mayor a 0).", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioStock.Focus();
                return;
            }

            int stockActual = aux.Stock;

            // Para peso: kilos. Para unidades: unidades por pack.
            int valorIngresado;
            if (!int.TryParse(txtStockModificado.Text, out valorIngresado) || valorIngresado <= 0)
            {
                MessageBox.Show("Ingresá una cantidad válida.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockModificado.Focus();
                return;
            }

            bool esPorPeso = (aux.CantidadUnidad == 1000);

            int stockASumar = 0;
            int sumarUnidadPaquete = 0;
            int cantidadUnidadNueva = aux.CantidadUnidad;

            decimal precioFinalCompra = 0; // ✅ costo total de esta carga

            try
            {
                if (esPorPeso)
                {
                    // valorIngresado = KILOS
                    stockASumar = valorIngresado * 1000; // gramos
                    sumarUnidadPaquete = aux.UnidadPaquete + valorIngresado; // kilos acumulados
                    cantidadUnidadNueva = 1000;

                    // ✅ costo de esta compra (kilos * $/kilo)
                    precioFinalCompra = valorIngresado * precioIngresado;
                }
                else
                {
                    int paquetesNuevos;
                    if (!int.TryParse(txtCantidadPaquetes.Text, out paquetesNuevos) || paquetesNuevos <= 0)
                    {
                        MessageBox.Show("Ingresá una cantidad de paquetes válida.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCantidadPaquetes.Focus();
                        return;
                    }

                    int unidadesPorPackNuevo = valorIngresado; // txtStockModificado = unid/pack
                    int unidadesNuevas = paquetesNuevos * unidadesPorPackNuevo;

                    stockASumar = unidadesNuevas;
                    sumarUnidadPaquete = aux.UnidadPaquete + paquetesNuevos;
                    cantidadUnidadNueva = unidadesPorPackNuevo;

                    // ✅ costo de esta compra (unidades nuevas * $/unidad)
                    precioFinalCompra = unidadesNuevas * precioIngresado;
                }

                int stockNuevo = stockActual + stockASumar;

                DialogResult respuesta = MessageBox.Show(
                    "Desea Agregar Stock?",
                    "Actualizar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.No)
                {
                    txtNombreProd.Text = "";
                    txtStockActual.Text = "";
                    txtStockModificado.Text = "";
                    txtPrecioStock.Text = "";
                    return;
                }

                // ✅ Aplicar cambios
                aux.Stock = stockNuevo;
                aux.UnidadPaquete = sumarUnidadPaquete;
                aux.CantidadUnidad = cantidadUnidadNueva;

                // ✅ guardar precio por unidad/kilo (siempre)
                aux.PrecioUnidad = precioIngresado;

                // ✅ guardar precio final (costo total de esta carga)
                aux.PrecioFinal = precioFinalCompra;

                // Guardar en BD
                ProductoNegocio productoNegocio = new ProductoNegocio();
                productoNegocio.ModificarStock(aux); // tu UPDATE ya incluye PrecioFinal

                // UI
                txtStockActual.Text = stockNuevo.ToString();
                txtStockModificado.Text = "";

                MessageBox.Show(
                    "Stock actualizado.\nCosto de esta compra: $" + precioFinalCompra.ToString("0.00"),
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar stock: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProd.Text = "";
            txtStockActual.Text = "";
            txtStockModificado.Text = "";
            txtCantidadPaquetes.Text = "";
            txtPrecioStock.Text = "";

            lblModificarStock.Visible = true;
            lblCantidadPaquetes.Visible = true;
            txtCantidadPaquetes.Visible= true;
            lblStockActualGramos.Visible = false;
            lblAclaratorio.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmVenta frmVenta = new frmVenta();

            frmVenta.Owner = this;
            frmVenta.Show();
            this.Hide();

        }

        private void dgvAgregarStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStockModificado_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
