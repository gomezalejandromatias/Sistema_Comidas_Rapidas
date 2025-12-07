using Dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Comidas_Rapidas
{
    public partial class FrmCombo : Form
    {
      public  List<Combo> listacombo = new List<Combo>();
        public  Combo comboactual;
        public Combo aux;
        public List<ComboProductoLinea> comboProductoLineas = new List<ComboProductoLinea>();
        public FrmCombo()
        {
            InitializeComponent();

            dgvComboPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComboPromociones.Font = new Font("Segoe UI", 10);  // tamaño normal
            dgvComboPromociones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            
            cargargrillacombo();

            lblEliminado.Visible = false;
            btnCancelarModficacion.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void dgvComboPromociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargargrillacombo()
        {
            ComboNegocio comboNegocio = new ComboNegocio();

            dgvComboPromociones.DataSource = null;
            dgvComboPromociones.DataSource = comboNegocio.listacombo();

            dgvComboPromociones.Columns["IdCombo"].Visible = false;
            dgvComboPromociones.Columns["Activo"].Visible = false;
          

            dgvComboPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar peso de cada columna
            dgvComboPromociones.Columns["Nombre"].FillWeight = 400;             // más chica
            dgvComboPromociones.Columns["Precio"].FillWeight = 100;             // más chica
            dgvComboPromociones.Columns["Ingredientes"].FillWeight = 400; // MUCHO más grande
            dgvComboPromociones.Columns["FechaAlta"].FillWeight = 200;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnIngredienteCombo_Click(object sender, EventArgs e)
        {

            ComboNegocio comboNegocio = new ComboNegocio();


            // 1) Validar nombre del combo
            string nombreCombo = txtCombo.Text.Trim();
            if (nombreCombo.Length == 0)
            {
                MessageBox.Show("Ingresá un nombre para el combo.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCombo.Focus();
                return;
            }

            // 2) Validar que se ingresó algo en el precio
            string textoPrecio = txtPrecioCombo.Text.Trim();
            if (textoPrecio.Length == 0)
            {
                MessageBox.Show("Ingresá un precio para el combo.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 3) Validar que el precio sea numérico
            decimal precio;
            bool esDecimal = decimal.TryParse(textoPrecio, out precio);
            if (esDecimal == false)
            {
                MessageBox.Show("El precio debe ser un número válido.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 4) Validar que el precio sea mayor a 0
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 5) Validar que no exista otro combo con el mismo nombre
            bool nombreRepetido = false;
            for (int i = 0; i < listacombo.Count; i++)
            {
                if (listacombo[i].Nombre == nombreCombo)
                {
                    nombreRepetido = true;
                }
            }

            if (nombreRepetido == true)
            {
                MessageBox.Show("Ya existe un combo con ese nombre. Elegí otro.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCombo.Focus();
                return;
            }

            // 6) Si todo está bien, recién acá creo el combo y lo agrego a la lista
            try
            {
                comboactual = new Combo();
                comboactual.Nombre = nombreCombo;
                comboactual.Precio = precio;
                comboactual.Ingredientes = richTextBoxCombo.Text;
                comboactual.CodigoCombo = "C" + new Random().Next(1000, 9999);
                comboactual.Activo = true;

                listacombo.Add(comboactual);



        
                int idComboNuevo = comboNegocio.AgregarCombo(comboactual);

                // 2️⃣ Guardar cada producto de la receta en ComboProducto
                foreach (var linea in comboProductoLineas)
                {
                    comboNegocio.AgregarComboProducto(
                        idComboNuevo,
                        linea.IdProducto,
                        linea.Cantidad
                    );
                }

                cargargrillacombo();

                MessageBox.Show(" Combo Agregado con exito  ");
                  


            }
            catch (SqlException sqlEx)
            {
                // ERROR POR CLAVE ÚNICA DUPLICADA
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show("Ya existe un combo con ese nombre. Elegí otro.",
                        "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtCombo.Focus();
                }
                else
                {
                    // Otros errores SQL
                    MessageBox.Show("Error SQL: " + sqlEx.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el combo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            cargargrillacombo();

            



        }

        private void btnAgregarPromo_Click(object sender, EventArgs e)
        {
            // 1) Verificar que exista un combo actual
            if (comboactual == null)
            {
                MessageBox.Show("Primero creá un combo antes de agregar promociones o ingredientes.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPromociones.Focus();
                return;
            }

            // 2) Validar texto ingresado

            // 3) Evitar duplicados
     



        }



        private void btnAgregarPromocion_Click(object sender, EventArgs e)
        {

            ComboNegocio comboNegocio = new ComboNegocio();


            // 1) Validar nombre del combo
            string nombrePromocion =txtPromociones.Text.Trim();
            if (nombrePromocion.Length == 0)
            {
                MessageBox.Show("Ingresá un nombre para el combo.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCombo.Focus();
                return;
            }

            // 2) Validar que se ingresó algo en el precio
            string textoPrecio = txtPrecioPromocion.Text.Trim();
            if (textoPrecio.Length == 0)
            {
                MessageBox.Show("Ingresá un precio para el combo.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 3) Validar que el precio sea numérico
            decimal precio;
            bool esDecimal = decimal.TryParse(textoPrecio, out precio);
            if (esDecimal == false)
            {
                MessageBox.Show("El precio debe ser un número válido.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 4) Validar que el precio sea mayor a 0
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 5) Validar que no exista otro combo con el mismo nombre
            bool nombreRepetido = false;
            for (int i = 0; i < listacombo.Count; i++)
            {
                if (listacombo[i].Nombre == nombrePromocion)
                {
                    nombreRepetido = true;
                }
            }

            if (nombreRepetido == true)
            {
                MessageBox.Show("Ya existe un combo con ese nombre. Elegí otro.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCombo.Focus();
                return;
            }

            // 6) Si todo está bien, recién acá creo el combo y lo agrego a la lista
            try
            {
                comboactual = new Combo();
                comboactual.Nombre = nombrePromocion;
                comboactual.Precio = precio;
                comboactual.Ingredientes = richTextBoxPromocion.Text;
                comboactual.CodigoCombo = "C" + new Random().Next(1000, 9999);
                comboactual.Activo = true;

                listacombo.Add(comboactual);



                // Refrescar la grilla
                int idComboNuevo = comboNegocio.AgregarCombo(comboactual);

                // 2️⃣ Guardar cada producto de la receta en ComboProducto
                foreach (var linea in comboProductoLineas)
                {
                    comboNegocio.AgregarComboProducto(
                        idComboNuevo,
                        linea.IdProducto,
                        linea.Cantidad
                    );
                }

                cargargrillacombo();

                MessageBox.Show(" Promocion Agregado con exito  ");



            }
            catch (SqlException sqlEx)
            {
                // ERROR POR CLAVE ÚNICA DUPLICADA
                if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                {
                    MessageBox.Show("Ya existe la Promocion con ese nombre. Elegí otro.",
                        "Nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtCombo.Focus();
                }
                else
                {
                    // Otros errores SQL
                    MessageBox.Show("Error SQL: " + sqlEx.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear La Promocion : " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            cargargrillacombo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtCombo.Text = "";
            txtPrecioCombo.Text = "";
            txtPromociones.Text = "";
            txtPrecioPromocion.Text = "";
            richTextBoxCombo.Text = "";

            // Limpiar listas
            richTextBoxCombo.Text = "";

            // Reiniciar combo actual
            comboactual = null;

            // Volver el foco al primer campo
            txtCombo.Focus();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPrecioPromocion.Text = "";
            txtPromociones.Text = "";
            richTextBoxPromocion.Text = "";
            comboactual = null;
            txtPromociones.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
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

            dgvComboPromociones.DataSource = null;
            dgvComboPromociones.DataSource = listrafiltrada;

                dgvComboPromociones.Columns["IdCombo"].Visible = false;
                dgvComboPromociones.Columns["Activo"].Visible = false;



        }

        private void btnEliminarCombo_Click(object sender, EventArgs e)
        {
            ComboNegocio comboNegocio = new ComboNegocio();
            Combo selecionado;


            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el Producto?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    selecionado = (Combo)dgvComboPromociones.CurrentRow.DataBoundItem;

                    comboNegocio.EliminarCombo(selecionado.IdCombo);
                    cargargrillacombo();

                    lblEliminado.Visible = true;

                }



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            aux = (Combo)dgvComboPromociones.CurrentRow.DataBoundItem;

        

            try
            {
                if (aux.Nombre.Replace(" ", "").Contains("+"))
                {
                    txtPromociones.Text = aux.Nombre;
                    txtPrecioPromocion.Text = aux.Precio.ToString();
                    richTextBoxPromocion.Text = aux.Ingredientes;

                }

                else
                {
                    txtCombo.Text = aux.Nombre;
                    txtPrecioCombo.Text = aux.Precio.ToString();
                    richTextBoxCombo.Text = aux.Ingredientes;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


            btnEliminarCombo.Visible = false;
            btnCancelar.Visible = false;
            btnGuardarCambios.Visible = true;
            btnCancelarModficacion.Visible = true;

        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {
            btnGuardarCambios.Visible = false;  


            ProductoNegocio productoNegocio = new ProductoNegocio();

           

            try
            {
                List<Producto> listaProductos = productoNegocio.listaproducto();

                comboBoxProducto.DataSource = listaProductos;

                comboBoxProducto.DisplayMember = "NombreProducto";
                comboBoxProducto.ValueMember = "IDProducto";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            try
            {
                List<Producto> listaProductos = productoNegocio.listaproducto();

                comboBoxPromocion.DataSource = listaProductos;

                comboBoxPromocion.DisplayMember = "NombreProducto";
                comboBoxPromocion.ValueMember = "IDProducto";
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Modificar el Producto?", "Modificado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (respuesta == DialogResult.Yes)
                {
                    bool esPromo = aux.Nombre.Contains("+");  // 🔍 Detectamos promo o combo

                    if (esPromo)
                    {
                        // ⭐ ES PROMO → modificar los textbox de PROMO
                        aux.Nombre = txtPromociones.Text;
                        aux.Precio = decimal.Parse(txtPrecioPromocion.Text);
                        aux.Ingredientes = richTextBoxPromocion.Text;
                    }
                    else
                    {
                        // ⭐ ES COMBO → modificar los textbox de COMBO
                        aux.Nombre = txtCombo.Text;
                        aux.Precio = decimal.Parse(txtPrecioCombo.Text);
                        aux.Ingredientes = richTextBoxCombo.Text;
                    }

                    aux.FechaAlta = DateTime.Now;

                    ComboNegocio comboNegocio = new ComboNegocio();
                    comboNegocio.ModificarCombo(aux);

                    cargargrillacombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

            // LIMPIEZA
            txtCombo.Text = "";
            txtPrecioCombo.Text = "";
            txtPromociones.Text = "";
            txtPrecioPromocion.Text = "";
            richTextBoxCombo.Text = "";
            richTextBoxPromocion.Text = "";
            txtCombo.Focus();
        }

        private void btnCancelarModficacion_Click(object sender, EventArgs e)
        {
            txtCombo.Text = "";
            txtPrecioCombo.Text = "";
            txtPromociones.Text = "";
            txtPrecioPromocion.Text = "";
            richTextBoxCombo.Text = "";


            richTextBoxPromocion.Text = "";

            btnEliminarCombo.Visible = true;
            btnCancelar.Visible = true;
            btnGuardarCambios.Visible = false;
            btnCancelarModficacion.Visible = false;
        }

        private void btnAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            if (comboBoxProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidadProducto.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresá una cantidad válida.");
                return;
            }

            // Producto elegido
            Producto prod = (Producto)comboBoxProducto.SelectedItem;
            comboProductoLineas.Add(new ComboProductoLinea
            {
                IdProducto = prod.IDProducto,
                NombreProducto = prod.NombreProducto,
                Cantidad = cantidad
            });

            // Agregar a la receta

            // Mostrarlo en el RichTextBox
            richTextBoxCombo.AppendText($"{prod.NombreProducto} x {cantidad}\n");
        }

        private void btnAgregarPromo_Click_1(object sender, EventArgs e)
        {
            if (comboBoxPromocion.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidadPromo.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingresá una cantidad válida.");
                return;
            }

            // Producto elegido
            Producto prod = (Producto)comboBoxProducto.SelectedItem;
            comboProductoLineas.Add(new ComboProductoLinea
            {
                IdProducto = prod.IDProducto,
                NombreProducto = prod.NombreProducto,
                Cantidad = cantidad
            });

            // Agregar a la receta

            // Mostrarlo en el RichTextBox
            richTextBoxPromocion.AppendText($"{prod.NombreProducto} x {cantidad}\n");
        }
    }
}
