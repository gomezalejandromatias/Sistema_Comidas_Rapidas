using Dominio;
using Negocio;
using Sistema_Comidas_Rapidas.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Comidas_Rapidas
{
    public partial class Form1 : Form
    {
        List<Producto> lista = new List<Producto>();
        int unidades, paquetes, kilos;

        Producto aux;
        string tipo;

        public Form1()
        {
            InitializeComponent();

            dvbListaProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvbListaProducto.Font = new Font("Segoe UI", 10);  // tamaño normal
            dvbListaProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            txtFechaIngreso.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtFechaIngreso.ReadOnly = true;







            CargarGrilla();
        }




        private void CargarGrilla()
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();

            dvbListaProducto.DataSource = null;
            dvbListaProducto.DataSource = productoNegocio.listaproducto();

            dvbListaProducto.Columns["IDProducto"].Visible = false;
            dvbListaProducto.Columns["Activo"].Visible = false;
            dvbListaProducto.Columns["IDProveedor"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            Producto aux = new Producto();

            try
            {
                // 1) VALIDACIONES BÁSICAS COMUNES

                // Nombre
                if (comboBoxaProveedor.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná un proveedor.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Proveedores prov = (Proveedores)comboBoxaProveedor.SelectedItem;
                aux.IDProveedor = prov.idproveedor;

                string nombre = txtNombreProducto.Text.Trim();
                if (nombre.Length == 0)
                {
                    MessageBox.Show("Ingresá un nombre de producto.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombreProducto.Focus();
                    return;
                }
                aux.NombreProducto = nombre;

                // Proveedor
                aux.FechaIngreso = DateTime.Now;

                // Tipo de producto (Unidades o Gramos)
                if (comboBoxElijeTipoProducto.SelectedItem == null)
                {
                    MessageBox.Show("Seleccioná el tipo de producto (unidades o gramos).", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tipo = comboBoxElijeTipoProducto.SelectedItem.ToString();

                // Código y fecha
                aux.CodigoProducto = "C" + new Random().Next(1000, 9999);

                // Categoría
                aux.Categoria = txtCategoria.Text.Trim();

                // Precio por unidad (precio base)
                decimal precio;
                if (!decimal.TryParse(txtPrecioUnidad.Text, out precio) || precio <= 0)
                {
                    MessageBox.Show("El precio debe ser un número válido y mayor a 0.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrecioUnidad.Focus();
                    return;
                }
                aux.PrecioUnidad = precio;


                // 2) LÓGICA SEGÚN TIPO DE PRODUCTO

                // =========================================
                //      CASO A: PRODUCTO EN GRAMOS
                // =========================================
                if (tipo == "Producto en Gramos")
                {
                    // txtCantidadGramo → KILOS que escribe el usuario (ej: 10)
                    // txtStockGramo   → GRAMOS totales (ej: 10000), debería estar calculado (kilos * 1000)


                    if (!int.TryParse(txtCantidadGramo.Text, out kilos) || kilos <= 0)
                    {
                        MessageBox.Show("Ingresá la cantidad de kilos (número entero mayor a 0).", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCantidadGramo.Focus();
                        return;
                    }

                    int stockGramos;
                    // Si el usuario ya ve el total de gramos, lo leemos.
                    // Si está vacío, lo calculamos nosotros.
                    if (!int.TryParse(txtStockGramo.Text, out stockGramos) || stockGramos <= 0)
                    {
                        stockGramos = kilos * 1000;
                        txtStockGramo.Text = stockGramos.ToString();
                    }

                    // Cómo lo guardamos en el objeto:
                    // UnidadPaquete = cantidad de "kilos comprados"
                    // CantidadUnidad = 1000 → definimos 1 "unidad lógica" = 1000 gramos
                    aux.UnidadPaquete = kilos;        // ej: 10 (kilos)
                    aux.CantidadUnidad = 1000;        // cada "unidad" son 1000 gramos
                    aux.Stock = stockGramos;          // ej: 10000 gramos

                    // PrecioFinal: depende de cómo lo quieras manejar
                    // Ejemplo: precio es "precio por kilo" → PrecioFinal = kilos * precio
                    aux.PrecioFinal = kilos * precio;
                }

                // =========================================
                //      CASO B: PRODUCTO EN UNIDADES
                // =========================================
                else // "Producto en Unidades"
                {
                    int unidadesPorPaquete;
                    int cantidadPaquetes;

                    // txtUnidadPaquete → cuántas unidades trae cada paquete (ej: 6 salchichas por paquete)
                    if (!int.TryParse(txtUnidadPaquete.Text, out unidadesPorPaquete) || unidadesPorPaquete <= 0)
                    {
                        MessageBox.Show("Ingresá la cantidad por paquete (unidades por paquete).", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUnidadPaquete.Focus();
                        return;
                    }

                    // txtCantidadPaquete → cuántos paquetes compraste (ej: 10 paquetes)
                    if (!int.TryParse(txtCantidadPaquete.Text, out cantidadPaquetes) || cantidadPaquetes <= 0)
                    {
                        MessageBox.Show("Ingresá la cantidad de paquetes.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCantidadPaquete.Focus();
                        return;
                    }

                    // Calculamos el stock total en unidades
                    int stockUnidades = unidadesPorPaquete * cantidadPaquetes;
                    txtStock.Text = stockUnidades.ToString();

                    // Guardamos en el objeto:
                    aux.CantidadUnidad = unidadesPorPaquete;  // ej: 6
                    aux.UnidadPaquete = cantidadPaquetes;    // ej: 10
                    aux.Stock = stockUnidades;       // ej: 60

                    // PrecioFinal: ejemplo simple → precio * stock total
                    aux.PrecioFinal = stockUnidades * precio;
                }


                // 3) GUARDAR EN LISTA Y BD

                ////  lista.Add(aux);
                productoNegocio.AgregarProducto(aux);

                MessageBox.Show("Producto agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                // ERROR POR CLAVE ÚNICA DUPLICADA
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show("Ya existe ese Producto con ese nombre. Elegí otro.",
                        "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtNombreProducto.Focus();
                }
                else
                {
                    // Otros errores SQL
                    MessageBox.Show("Error SQL: " + sqlEx.Message, "Error SQL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // 4) LIMPIAR CAMPOS PARA UNA NUEVA CARGA

            txtNombreProducto.Text = "";
            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";
            txtCantidadGramo.Text = "";
            txtStockGramo.Text = "";


            lblGramos.Visible = false;

            // Ocultar controles de UNIDADES
            lblProductoporPeso.Visible = false;

            txtStockGramo.Visible = false;
            txtCantidadGramo.Visible = false;

            CargarGrilla();
            comboBoxaProveedor.Focus();



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";

            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";

            txtBucarProducto.Text = "";

            comboBoxaProveedor.Focus();
        }

        private void txtBucarProducto_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listafiltrada;
            string filtro = txtBucarProducto.Text;

            ProductoNegocio productoNegocio = new ProductoNegocio();


            if (filtro != "")
            {
                listafiltrada = productoNegocio.listaproducto().FindAll(x => x.NombreProducto.ToLower().Contains(filtro));




            }

            else
            {
                listafiltrada = productoNegocio.listaproducto();

            }

            dvbListaProducto.DataSource = null;
            dvbListaProducto.DataSource = listafiltrada;

            dvbListaProducto.Columns["IDProducto"].Visible = false;
            dvbListaProducto.Columns["Activo"].Visible = false;



        }


        public void CalcularStock()
        {


            if (int.TryParse(txtUnidadPaquete.Text, out unidades) &&
                int.TryParse(txtCantidadPaquete.Text, out paquetes))
            {
                Producto aux = new Producto();

                int total = unidades * paquetes;
                txtStock.Text = total.ToString();






            }


            else if (int.TryParse(txtCantidadGramo.Text, out kilos))
            {
                unidades = kilos * 1000;
                txtStockGramo.Text = unidades.ToString();
            }


            else
            {
                txtStock.Text = "";
                txtStockGramo.Text = "";
            }
        }

        private void txtUnidadPaquete_TextChanged(object sender, EventArgs e)
        {
            CalcularStock();
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";

            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";

            txtBucarProducto.Text = "";

            DialogResult respuesta = MessageBox.Show("Desea Cancelar La Operacion?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                frmVenta frmVenta = new frmVenta();

                frmVenta.Owner = this;
                frmVenta.Show();
                this.Hide();


                frmVenta venta = new frmVenta();
                venta.Show();

                this.Close();
            }
        }

        private void dvbListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnModicarDefinitivo.Visible = false;
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();


            try
            {
                comboBoxaProveedor.DataSource = proveedorNegocio.ListaProveedores();

                comboBoxaProveedor.DisplayMember = "Nombre";
                comboBoxaProveedor.ValueMember = "idproveedor";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            comboBoxElijeTipoProducto.Items.Add("Producto en Unidades");
            comboBoxElijeTipoProducto.Items.Add("Producto en Gramos");

            lblGramos.Visible = false;

            // Ocultar controles de UNIDADES
            lblProductoporPeso.Visible = false;

            txtStockGramo.Visible = false;
            txtCantidadGramo.Visible = false;

            UIHelper.DataGridViewModerno(dvbListaProducto);
            UIHelper.BotonPrincipal(btnAgregar);
            UIHelper.BotonPeligroPremium(btnEliminar);
            UIHelper.BotonSecundarioPremium(btnModicarDefinitivo);
            UIHelper.BotonSecundarioPremium(btnModificarProducto);
            UIHelper.BotonAmarilloPremium(txtCancelar);
            UIHelper.BotonAmarilloPremium(btnLimpiar);

            UIHelper.LabelPremium(lblBuscarProdu);
            UIHelper.LabelPremium(lblUnidadPaquete);
            UIHelper.LabelPremium(lblCantidadPaquete);
            UIHelper.LabelPremium(lblNombrePro);
            UIHelper.LabelPremium(lblPrecioUnidad);
            UIHelper.LabelPremium(lblProductoporPeso);
            UIHelper.LabelPremium(lblProductosGuardados);
            UIHelper.LabelPremium(lblProvee);
            UIHelper.LabelPremium(lblTipoProdu);
            UIHelper.LabelPremium(lblStockUnidad);
            UIHelper.LabelPremium(Categoria);
            UIHelper.LabelPremium(lblTotal);
            UIHelper.LabelPremium(lblFechaIngre);
            UIHelper.LabelTituloPremium(lblTitulo);
            UIHelper.LabelPremium(lblGramos);
            UIHelper.ComboBoxModerno(comboBoxaProveedor);
            UIHelper.ComboBoxModerno(comboBoxElijeTipoProducto);

            dvbListaProducto.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            Producto selecionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el Producto?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    selecionado = (Producto)dvbListaProducto.CurrentRow.DataBoundItem;

                    productoNegocio.EliminarProducto(selecionado.IDProducto);
                    CargarGrilla();

                    lblTotalPrecioProducto.Text = "Eliminado Correctamente";

                }



            }
            catch (Exception ex)
            {

                throw ex;
            }

            lblTotalPrecioProducto.Visible = false;
            txtNombreProducto.Text = "";

            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";

            txtBucarProducto.Text = "";

            comboBoxaProveedor.Focus();

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnModicarDefinitivo.Visible = true;


            aux = (Producto)dvbListaProducto.CurrentRow.DataBoundItem;

            txtNombreProducto.Text = aux.NombreProducto;
            txtUnidadPaquete.Text = aux.UnidadPaquete.ToString();
            txtCantidadPaquete.Text = aux.CantidadUnidad.ToString();
            txtStock.Text = aux.Stock.ToString();
            txtCategoria.Text = aux.Categoria;
            txtPrecioUnidad.Text = aux.PrecioUnidad.ToString();


            comboBoxaProveedor.SelectedValue = aux.IDProveedor;
        }

        private void btnModicarDefinitivo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto.");
                    txtNombreProducto.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUnidadPaquete.Text) || !int.TryParse(txtUnidadPaquete.Text, out _))
                {
                    MessageBox.Show("Ingrese una unidad de paquete válida.");
                    txtUnidadPaquete.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCantidadPaquete.Text) || !int.TryParse(txtCantidadPaquete.Text, out _))
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    txtCantidadPaquete.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtStock.Text) || !int.TryParse(txtStock.Text, out _))
                {
                    MessageBox.Show("Ingrese un stock válido.");
                    txtStock.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrecioUnidad.Text) || !decimal.TryParse(txtPrecioUnidad.Text, out _))
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    txtPrecioUnidad.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show("Ingrese la categoría.");
                    txtCategoria.Focus();
                    return;
                }

                if (comboBoxaProveedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un proveedor.");
                    comboBoxaProveedor.Focus();
                    return;
                }

                // Confirmar
                DialogResult respuesta = MessageBox.Show("Desea Modificar el Producto?", "Modificado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    aux.NombreProducto = txtNombreProducto.Text;
                    aux.UnidadPaquete = int.Parse(txtUnidadPaquete.Text);
                    aux.CantidadUnidad = int.Parse(txtCantidadPaquete.Text);
                    aux.Stock = int.Parse(txtStock.Text);
                    aux.Categoria = txtCategoria.Text;

                    decimal precio = decimal.Parse(txtPrecioUnidad.Text);
                    aux.PrecioUnidad = precio;

                    aux.IDProveedor = (int)comboBoxaProveedor.SelectedValue;

                    aux.PrecioFinal = aux.UnidadPaquete * aux.CantidadUnidad * aux.PrecioUnidad;

                    ProductoNegocio negocio = new ProductoNegocio();
                    negocio.ModificarProducto(aux);

                    MessageBox.Show("Producto modificado correctamente.");

                    CargarGrilla();

                    btnAgregar.Visible = true;
                    btnEliminar.Visible = true;
                    btnModicarDefinitivo.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Limpieza
            txtNombreProducto.Text = "";
            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";
            txtBucarProducto.Text = "";

            comboBoxaProveedor.Focus();
        }

        private void comboBoxElijeTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = comboBoxElijeTipoProducto.SelectedItem.ToString();

            if (tipo == "Producto en Gramos")
            {
                // Mostrar controles de GRAMOS
                lblGramos.Visible = true;

                // Ocultar controles de UNIDADES
                lblProductoporPeso.Visible = true;

                txtStockGramo.Visible = true;
                txtCantidadGramo.Visible = true;


                lblUnidadPaquete.Visible = false;
                lblStockUnidad.Visible = false;
                lblCantidadPaquete.Visible = false;

                txtUnidadPaquete.Visible = false;
                txtCantidadPaquete.Visible = false;
                txtStock.Visible = false;


            }
            else // Producto en Unidades
            {
                lblGramos.Visible = false;

                // Ocultar controles de UNIDADES
                lblProductoporPeso.Visible = false;

                txtStockGramo.Visible = false;
                txtCantidadGramo.Visible = false;



                lblUnidadPaquete.Visible = true;
                lblStockUnidad.Visible = true;
                lblCantidadPaquete.Visible = true;

                txtUnidadPaquete.Visible = true;
                txtCantidadPaquete.Visible = true;
                txtStock.Visible = true;
            }
        }

        private void lblProductoporPeso_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadGramo_TextChanged(object sender, EventArgs e)
        {
            CalcularStock();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidadPaquete_TextChanged(object sender, EventArgs e)
        {
            CalcularStock();
        }
    }
}
