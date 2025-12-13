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

            btnCancelarcambio.Visible = false;
            lblPrecioKilos.Visible = false;





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
            UIHelper.BotonAmarilloPremium(btnModicarDefinitivo);
            UIHelper.BotonAmarilloPremium(btnModificarProducto);
            UIHelper.BotonAmarilloPremium(txtCancelar);
            UIHelper.BotonAmarilloPremium(btnLimpiar);
            UIHelper.BotonAmarilloPremium(btnCancelarcambio);

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
     
            UIHelper.LabelPremium(lblFechaIngre);
            UIHelper.LabelTituloPremium(lblTitulo);
            UIHelper.LabelPremium(lblGramos);
            UIHelper.ComboBoxModerno(comboBoxaProveedor);
            UIHelper.ComboBoxModerno(comboBoxElijeTipoProducto);
            UIHelper.LabelPremium(lblPrecioKilos);

            dvbListaProducto.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();

            try
            {
                // 1) Validar que haya productos en la grilla
                if (dvbListaProducto.Rows.Count == 0)
                {
                    MessageBox.Show("No hay productos para eliminar.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2) Validar que haya una fila seleccionada
                if (dvbListaProducto.CurrentRow == null)
                {
                    MessageBox.Show("Seleccioná un producto de la lista.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dvbListaProducto.Focus();
                    return;
                }

                // 3) Validar que el DataBoundItem exista
                Producto seleccionado = dvbListaProducto.CurrentRow.DataBoundItem as Producto;
                if (seleccionado == null)
                {
                    MessageBox.Show("No se pudo obtener el producto seleccionado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 4) Validar ID
                if (seleccionado.IDProducto <= 0)
                {
                    MessageBox.Show("El producto seleccionado tiene un ID inválido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 5) Confirmación (mensaje más lindo)
                DialogResult respuesta = MessageBox.Show(
                    $"¿Querés eliminar el producto \"{seleccionado.NombreProducto}\"?\n\nEsta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    productoNegocio.EliminarProducto(seleccionado.IDProducto);
                    CargarGrilla();

                    MessageBox.Show("Producto eliminado correctamente ✅", "Listo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpieza SOLO si se eliminó
                    txtNombreProducto.Text = "";
                    txtUnidadPaquete.Text = "";
                    txtCantidadPaquete.Text = "";
                    txtStock.Text = "";
                    txtPrecioUnidad.Text = "";
                    txtCategoria.Text = "";
                    txtBucarProducto.Text = "";

                    comboBoxaProveedor.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnModicarDefinitivo.Visible = true;
            btnCancelarcambio.Visible = true;

            aux = (Producto)dvbListaProducto.CurrentRow.DataBoundItem;

            txtNombreProducto.Text = aux.NombreProducto;
            txtCategoria.Text = aux.Categoria;
            txtPrecioUnidad.Text = aux.PrecioUnidad.ToString();
            comboBoxaProveedor.SelectedValue = aux.IDProveedor;

            // ✅ Detectar tipo
            bool esPorGramos = (aux.CantidadUnidad == 1000);

            // ✅ Setear el ComboBox automáticamente (GRAMOS / UNIDADES)
            if (esPorGramos == true)
            {
                comboBoxElijeTipoProducto.SelectedItem = "Producto en Gramos";
                // Mostrar controles de GRAMOS
                lblGramos.Visible = true;
                lblPrecioKilos.Visible = true;

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
            else
            {
                comboBoxElijeTipoProducto.SelectedItem = "Producto en Unidades";
            }

            // 🔒 Recomendado: bloquear cambio de tipo al modificar
      

            // ✅ Mostrar/ocultar controles según tipo
            if (esPorGramos == true)
            {
                // Mostrar GRAMOS
                lblGramos.Visible = true;
                lblProductoporPeso.Visible = true;
                txtCantidadGramo.Visible = true;
                txtStockGramo.Visible = true;

                // Ocultar UNIDADES
                lblUnidadPaquete.Visible = false;
                lblStockUnidad.Visible = false;
                lblCantidadPaquete.Visible = false;
                txtUnidadPaquete.Visible = false;
                txtCantidadPaquete.Visible = false;
                txtStock.Visible = false;

                // Cargar datos
                txtCantidadGramo.Text = aux.UnidadPaquete.ToString(); // kilos
                txtStockGramo.Text = aux.Stock.ToString();           // gramos
            }
            else
            {
                // Mostrar UNIDADES
                lblUnidadPaquete.Visible = true;
                lblStockUnidad.Visible = true;
                lblCantidadPaquete.Visible = true;
                txtUnidadPaquete.Visible = true;
                txtCantidadPaquete.Visible = true;
                txtStock.Visible = true;

                // Ocultar GRAMOS
                lblGramos.Visible = false;
                lblProductoporPeso.Visible = false;
                txtCantidadGramo.Visible = false;
                txtStockGramo.Visible = false;

                // Cargar datos
                txtUnidadPaquete.Text = aux.CantidadUnidad.ToString();   // unidades por paquete
                txtCantidadPaquete.Text = aux.UnidadPaquete.ToString();  // cantidad de paquetes
                txtStock.Text = aux.Stock.ToString();                    // stock total unidades
            }
        }

        private void btnModicarDefinitivo_Click(object sender, EventArgs e)
        {
            try
            {
                // Nombre obligatorio
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("Ingrese el nombre del producto.");
                    txtNombreProducto.Focus();
                    return;
                }

                // Precio obligatorio
                decimal precio;
                if (!decimal.TryParse(txtPrecioUnidad.Text, out precio) || precio <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido.");
                    txtPrecioUnidad.Focus();
                    return;
                }

                // Categoría obligatoria (si vos la querés obligatoria)
                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show("Ingrese la categoría.");
                    txtCategoria.Focus();
                    return;
                }

                // Proveedor obligatorio
                if (comboBoxaProveedor.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un proveedor.");
                    comboBoxaProveedor.Focus();
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "Desea Modificar el Producto?", "Modificado",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    aux.NombreProducto = txtNombreProducto.Text.Trim();
                    aux.Categoria = txtCategoria.Text.Trim();
                    aux.PrecioUnidad = precio;
                    aux.IDProveedor = (int)comboBoxaProveedor.SelectedValue;

                    bool esPorGramos = (aux.CantidadUnidad == 1000);

                    if (esPorGramos == true)
                    {
                        // ✅ MODIFICAR POR GRAMOS (kilos -> gramos)
                        int kilos;
                        if (!int.TryParse(txtCantidadGramo.Text, out kilos) || kilos <= 0)
                        {
                            MessageBox.Show("Ingresá la cantidad de kilos válida.", "Error");
                            txtCantidadGramo.Focus();
                            return;
                        }

                        int stockGramos = kilos * 1000;
                        txtStockGramo.Text = stockGramos.ToString();

                        aux.UnidadPaquete = kilos;   // kilos
                        aux.CantidadUnidad = 1000;   // 1000 g por unidad lógica
                        aux.Stock = stockGramos;     // gramos
                        aux.PrecioFinal = kilos * precio; // precio por kilo
                    }
                    else
                    {
                        // ✅ MODIFICAR POR UNIDADES
                        int unidadesPorPaquete;
                        int cantidadPaquetes;

                        if (!int.TryParse(txtUnidadPaquete.Text, out unidadesPorPaquete) || unidadesPorPaquete <= 0)
                        {
                            MessageBox.Show("Ingrese una unidad de paquete válida.");
                            txtUnidadPaquete.Focus();
                            return;
                        }

                        if (!int.TryParse(txtCantidadPaquete.Text, out cantidadPaquetes) || cantidadPaquetes <= 0)
                        {
                            MessageBox.Show("Ingrese una cantidad de paquetes válida.");
                            txtCantidadPaquete.Focus();
                            return;
                        }

                        int stockUnidades = unidadesPorPaquete * cantidadPaquetes;
                        txtStock.Text = stockUnidades.ToString();

                        aux.CantidadUnidad = unidadesPorPaquete; // unidades por paquete
                        aux.UnidadPaquete = cantidadPaquetes;    // paquetes
                        aux.Stock = stockUnidades;               // unidades totales
                        aux.PrecioFinal = stockUnidades * precio;
                    }

                    ProductoNegocio negocio = new ProductoNegocio();
                    negocio.ModificarProducto(aux);

                    MessageBox.Show("Producto modificado correctamente.");
                    CargarGrilla();

                    btnAgregar.Visible = true;
                    btnEliminar.Visible = true;
                    btnModicarDefinitivo.Visible = false;
                    btnCancelarcambio.Visible = false;
                    txtNombreProducto.Text = "";
                    txtUnidadPaquete.Text = "";
                    txtCantidadPaquete.Text = "";
                    txtStock.Text = "";
                    txtPrecioUnidad.Text = "";
                    txtCategoria.Text = "";
                    txtCantidadGramo.Text = "";
                    txtStockGramo.Text = "";
                    txtBucarProducto.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBoxElijeTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = comboBoxElijeTipoProducto.SelectedItem.ToString();

            if (tipo == "Producto en Gramos")
            {
                // Mostrar controles de GRAMOS
                lblGramos.Visible = true;
                lblPrecioKilos.Visible = true;

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
                lblPrecioKilos.Visible = false;

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

        private void btnCancelarcambio_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";
            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";
            txtCantidadGramo.Text = "";
            txtStockGramo.Text = "";
            txtBucarProducto.Text = "";

            // 🔹 Restaurar botones
            btnCancelarcambio.Visible = false;
            btnModicarDefinitivo.Visible = false;
            btnAgregar.Visible = true;
            btnEliminar.Visible = true;
            btnModificarProducto.Visible = true;

    

            // 🔹 Ocultar GRAMOS
            lblGramos.Visible = false;
            lblProductoporPeso.Visible = false;
            txtCantidadGramo.Visible = false;
            txtStockGramo.Visible = false;

            // 🔹 Ocultar UNIDADES (o dejarlas visibles si preferís)
            lblUnidadPaquete.Visible = true;
            lblStockUnidad.Visible = true;
            lblCantidadPaquete.Visible = true;
            txtUnidadPaquete.Visible = true;
            txtCantidadPaquete.Visible = true;
            txtStock.Visible = true;

            comboBoxaProveedor.Focus();
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
