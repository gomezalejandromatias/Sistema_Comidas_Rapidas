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
                // 🔹 Nombre obligatorio
                if (string.IsNullOrWhiteSpace(txtNombreProv.Text))
                {
                    MessageBox.Show("El nombre del proveedor es obligatorio.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreProv.Focus();
                    return;
                }

                // 🔹 Teléfono obligatorio (solo números)
                if (string.IsNullOrWhiteSpace(txtTelProv.Text) || !txtTelProv.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El teléfono es obligatorio y debe contener solo números.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelProv.Focus();
                    return;
                }

                // 🔹 Email OPCIONAL
                if (!string.IsNullOrWhiteSpace(txtEmailProv.Text))
                {
                    if (!IsValidEmail(txtEmailProv.Text))
                    {
                        MessageBox.Show("El email ingresado no tiene un formato válido.", "Atención",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmailProv.Focus();
                        return;
                    }
                }

                // 🔹 Dirección obligatoria
                if (string.IsNullOrWhiteSpace(txtDireccionProv.Text))
                {
                    MessageBox.Show("La dirección es obligatoria.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDireccionProv.Focus();
                    return;
                }

                // 🔹 Crear proveedor (descripción opcional)
                Proveedores proveedores = new Proveedores
                {
                    Nombre = txtNombreProv.Text.Trim(),
                    Telefono = txtTelProv.Text.Trim(),
                    Email = txtEmailProv.Text.Trim(),        // puede quedar vacío
                    Direccion = txtDireccionProv.Text.Trim(),
                    Descripcion = rtbProv.Text.Trim()        // puede quedar vacío
                };

                ProveedorNegocio proveedorNegocio = new ProveedorNegocio();
                proveedorNegocio.AgregarProveedor(proveedores);

                MessageBox.Show("Proveedor agregado correctamente ✔", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarProveedor();
                txtNombreProv.Text = "";
                txtTelProv.Text = "";
                txtDireccionProv.Text = "";
                txtEmailProv.Text = "";
                rtbProv.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNombreProv.Text = "";
            txtTelProv.Text = "";
            txtDireccionProv.Text = "";
            txtEmailProv.Text = "";
            rtbProv.Text = "";
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

            try
            {
                // 1) Validar que haya filas en el DataGridView
                if (dtgProveedor.Rows.Count == 0)
                {
                    MessageBox.Show("No hay proveedores para eliminar.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2) Validar que haya una fila seleccionada
                if (dtgProveedor.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un proveedor de la lista.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtgProveedor.Focus();
                    return;
                }

                // 3) Validar que el DataBoundItem no sea null
                Proveedores seleccionado = dtgProveedor.CurrentRow.DataBoundItem as Proveedores;
                if (seleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el proveedor seleccionado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4) Validar que el ID sea válido
                if (seleccionado.idproveedor <= 0)
                {
                    MessageBox.Show("El proveedor seleccionado tiene un ID inválido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 5) Confirmación
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea eliminar el proveedor seleccionado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    proveedorNegocio.EliminarProv(seleccionado.idproveedor);
                    CargarProveedor();

                    MessageBox.Show("Proveedor eliminado correctamente.", "Listo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proveedor: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificarDefinitivoProv.Visible = true;
            btnAgregar.Visible = false;
            btnCncelarCambios.Visible = true;
           
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
            btnCncelarCambios.Visible = false;

            UIHelper.BotonPrincipal(btnAgregar);
            UIHelper.BotonPeligroPremium(btnEliminar);
            UIHelper.BotonAmarilloPremium(btnModificar);
            UIHelper.BotonAmarilloPremium(btnModificarDefinitivoProv);
            UIHelper.BotonAmarilloPremium(btnLimpiar);
            UIHelper.BotonAmarilloPremium(btnVoverVentas);
            UIHelper.BotonAmarilloPremium(btnCncelarCambios);

            UIHelper.LabelPremium(lblDescripcion);
            UIHelper.LabelPremium(lblDireccion);
            UIHelper.LabelPremium(lblEmail);
            UIHelper.LabelPremium(lblNombre);
            UIHelper.LabelPremium(lblSubtitulo);
            UIHelper.LabelPremium(lblTelefono);
            UIHelper.LabelPremium (lblTitulo);
            UIHelper.LabelPremium(lblFiltroProv);



            UIHelper.DataGridViewModerno(dtgProveedor);
        }

        private void btnModificarDefinitivoProv_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Desea Modificar el Producto?", "modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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
            btnCncelarCambios.Visible = false;

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

        private void btnCncelarCambios_Click(object sender, EventArgs e)
        {

            txtNombreProv.Text = "";
            txtTelProv.Text = "";
            txtDireccionProv.Text = "";
            txtEmailProv.Text = "";
            rtbProv.Text = "";

            btnModificarDefinitivoProv.Visible = false;
            btnAgregar.Visible = true;
            btnCncelarCambios.Visible = false;


            txtNombreProv.Focus();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Proveedores> listafiltrada;
            string filtro = txtFiltro.Text;

            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();


            if (filtro != "")
            {
                listafiltrada = proveedorNegocio.ListaProveedores().FindAll(x => x.Nombre.ToLower().Contains(filtro));




            }

            else
            {
                listafiltrada = proveedorNegocio.ListaProveedores();

            }

            dtgProveedor.DataSource = null;
            dtgProveedor.DataSource = listafiltrada;

            dtgProveedor.Columns["idproveedor"].Visible = false;
            dtgProveedor.Columns["Activo"].Visible = false;
        }
    }
}
