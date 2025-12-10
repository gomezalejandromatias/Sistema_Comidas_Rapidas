using Dominio;
using Negocio;
using Sistema_Comidas_Rapidas.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Comidas_Rapidas
{
    public partial class FrmProveedor : Form
    {
        Proveedores proveedores;
        Proveedores aux;
        public FrmProveedor()
        {
            InitializeComponent();

            CargarProveedor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                proveedores = new Proveedores();

                proveedores.Nombre = txtNombreProv.Text;
                proveedores.Telefono = txtTelProv.Text;
                proveedores.Email = txtEmailProv.Text;
                proveedores.Direccion = txtDireccionProv.Text;
                proveedores.Descripcion = rtbProv.Text;

                ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

                proveedorNegocio.AgregarProveedor(proveedores);



                MessageBox.Show("bien");

                CargarProveedor();





            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CargarProveedor()
        {

            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();


            dtgProveedor.DataSource = null;
            dtgProveedor.DataSource = proveedorNegocio.ListaProveedores();


            dtgProveedor.Columns["Activo"].Visible = false;
            dtgProveedor.Columns["IDProveedor"].Visible = false;



        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();

            Proveedores seleccionado;


            seleccionado = (Proveedores)dtgProveedor.CurrentRow.DataBoundItem;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el Proveedor?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Proveedores)dtgProveedor.CurrentRow.DataBoundItem;

                    proveedorNegocio.EliminarProv(seleccionado.idproveedor);
                    CargarProveedor();

                    MessageBox.Show("bien");

                }



            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificarDefinitivoProv.Visible = true;
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            aux = (Proveedores)dtgProveedor.CurrentRow.DataBoundItem;

            txtNombreProv.Text = aux.Nombre;
            txtTelProv.Text = aux.Telefono;
            txtDireccionProv.Text = aux.Direccion;
            txtEmailProv.Text = aux.Email;
            rtbProv.Text = aux.Descripcion;


        }


        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            btnModificarDefinitivoProv.Visible = false;

            UIHelper.DataGridViewModerno(dtgProveedor);
        }

        private void btnModificarDefinitivoProv_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Desea eliminar el Producto?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {

                try
                {
                    // 🔹 Validaciones

                    if (txtNombreProv.Text.Trim() == "")
                    {
                        MessageBox.Show("Por favor, ingresá el nombre del proveedor.", "Atención");
                        txtNombreProv.Focus();
                        return;
                    }

                    if (txtTelProv.Text.Trim() == "")
                    {
                        MessageBox.Show("Por favor, ingresá el teléfono del proveedor.", "Atención");
                        txtTelProv.Focus();
                        return;
                    }

                    if (txtDireccionProv.Text.Trim() == "")
                    {
                        MessageBox.Show("Por favor, ingresá la dirección del proveedor.", "Atención");
                        txtDireccionProv.Focus();
                        return;
                    }

                    string email = txtEmailProv.Text.Trim();

                    if (email != "")
                    {
                        if (!email.Contains("@") || !email.Contains("."))
                        {
                            MessageBox.Show("El email no parece válido. Revisalo.", "Atención");
                            txtEmailProv.Focus();
                            return;
                        }
                    }

                    // 🔹 ACÁ USAMOS aux, NO new Proveedores

                    aux.Nombre = txtNombreProv.Text.Trim();
                    aux.Telefono = txtTelProv.Text.Trim();
                    aux.Direccion = txtDireccionProv.Text.Trim();
                    aux.Email = email;
                    aux.Descripcion = rtbProv.Text.Trim();

                    ProveedorNegocio negocio = new ProveedorNegocio();
                    negocio.ModificarProv(aux);   // 👉 va aux

                    MessageBox.Show("Proveedor modificado correctamente ✔", "Información");

                    CargarProveedor();

                    btnModificarDefinitivoProv.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al modificar el proveedor: " + ex.Message, "Error");
                }
            }

            txtNombreProv.Text = "";
            txtTelProv.Text = "";
            txtDireccionProv.Text = "";
            txtEmailProv.Text = "";
            rtbProv.Text = "";

            btnModificarDefinitivoProv.Visible = false;
            btnAgregar.Visible = true;
            btnEliminar.Visible = true;

            txtNombreProv.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProv.Text = "";
            txtTelProv.Text = "";
            txtDireccionProv.Text = "";
            txtEmailProv.Text = "";
            rtbProv.Text = "";



            txtNombreProv.Focus();
        }

        private void btnVoverVentas_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Cancelar La Operacion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {

                frmVenta frmVenta = new frmVenta();
                frmVenta.Owner = this;
                frmVenta.Show();
                this.Hide();




            }
        }
    }
}
