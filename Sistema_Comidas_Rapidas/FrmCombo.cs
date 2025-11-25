using Dominio;
using Negocio;
using System;
using System.Collections;
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
    public partial class FrmCombo : Form
    {
      public  List<Combo> listacombo = new List<Combo>();
        public  Combo comboactual;
          
        public FrmCombo()
        {
            InitializeComponent();
            listViewCombo.View = View.Details;
            listViewCombo.Columns.Add("Ingrediente", 100);
            listViewCombo.FullRowSelect = true;
            listViewCombo.GridLines = true;
            listViewCombo.UseCompatibleStateImageBehavior = false;
            listViewCombo.FullRowSelect = true;

            
            listViewPromo.View = View.Details;
          
            listViewPromo.Columns.Add("Ingrediente", 100);
            
            listViewPromo.FullRowSelect = true;
          
            listViewPromo.GridLines = true;
           
            listViewPromo.UseCompatibleStateImageBehavior = false;
           
            listViewPromo.FullRowSelect = true;

            dgvComboPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComboPromociones.Font = new Font("Segoe UI", 10);  // tamaño normal
            dgvComboPromociones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            
            cargargrillacombo();

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void dgvComboPromociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void cargargrillacombo()
        {


            dgvComboPromociones.DataSource = null;
            dgvComboPromociones.DataSource = listacombo;

            dgvComboPromociones.Columns["IdCombo"].Visible = false;
            dgvComboPromociones.Columns["Activo"].Visible = false;
            dgvComboPromociones.Columns["CodigoCombo"].Visible = false;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnIngredienteCombo_Click(object sender, EventArgs e)
        {




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

                listacombo.Add(comboactual);

                // Si querés, podrías limpiar los ingredientes visuales del ListView acá:
                listViewCombo.Items.Clear();

                // Refrescar la grilla
                cargargrillacombo();

              
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
            string promo = txtIngredientePromociones.Text.Trim();
            if (promo.Length == 0)
            {
                MessageBox.Show("Ingresá un texto para la promoción o ingrediente.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPromociones.Focus();
                return;
            }

            // 3) Evitar duplicados
            bool repetido = false;
            for (int i = 0; i < comboactual.Ingredientes.Count; i++)
            {
                if (comboactual.Ingredientes[i] == promo)
                {
                    repetido = true;
                }
            }

            if (repetido == true)
            {
                MessageBox.Show("Ese ingrediente/promoción ya fue agregado.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPromociones.Focus();
                return;
            }

            // 4) Agregar al ListView (vista visual)
            ListViewItem item = new ListViewItem(promo);
            listViewPromo.Items.Add(item);

            // 5) Agregar a la lista lógica
            comboactual.Ingredientes.Add(promo);

            // 6) Limpiar y dejar el foco listo
            txtIngredientePromociones.Text = "";
            txtIngredientePromociones.Focus();



        }

        private void btnAgregarIngredientes_Click(object sender, EventArgs e)
        {

            if (comboactual == null)
            {
                MessageBox.Show("Primero creá un combo antes de agregar ingredientes.");
                return;
            }

            // 2) Validar que se escribió algo
            string ing = txtIngredienteCombo.Text.Trim();
            if (ing.Length == 0)
            {
                MessageBox.Show("Ingresá un ingrediente.");
                txtIngredienteCombo.Focus();
                return;
            }

            // 3) Agregar al ListView
            ListViewItem item = new ListViewItem(ing);
            listViewCombo.Items.Add(item);

            // 4) Agregar a la lista del combo
            comboactual.Ingredientes.Add(ing);

            // 5) Limpiar el textbox y poner el foco
            txtIngredienteCombo.Text = "";
            txtIngredienteCombo.Focus();


        }

        private void btnAgregarPromocion_Click(object sender, EventArgs e)
        {
            string nombre = txtPromociones.Text.Trim();
            if (nombre.Length == 0)
            {
                MessageBox.Show("Ingresá un nombre para la promoción o combo.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPromociones.Focus();
                return;
            }

            // 2) Validar precio vacío
       

            // 3) Validar precio numérico
            decimal precio;
            bool esNumero = decimal.TryParse(txtPrecioPromocion.Text, out precio);
            if (esNumero == false)
            {
                MessageBox.Show("El precio debe ser un número válido.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 4) Validar precio positivo
            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCombo.Focus();
                return;
            }

            // 5) Validar que NO se repita el nombre del combo
            bool nombreExiste = false;
            for (int i = 0; i < listacombo.Count; i++)
            {
                if (listacombo[i].Nombre == nombre)
                {
                    nombreExiste = true;
                }
            }

            if (nombreExiste == true)
            {
                MessageBox.Show("Ya existe un combo con ese nombre. Elegí otro.",
                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPromociones.Focus();
                return;
            }

            // 6) Crear combo dentro de un try/catch seguro
            try
            {
                comboactual = new Combo();
                comboactual.Nombre = nombre;
                comboactual.Precio = precio;

                listacombo.Add(comboactual);

                // Si querés limpiar el ListView o el form:
               

          

                cargargrillacombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el combo: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCombo.Text = "";
            txtPrecioCombo.Text = "";
            txtIngredienteCombo.Text = "";

            // 2) Limpiar los listview visuales
            listViewPromo.Items.Clear();
            listViewCombo.Items.Clear();

            // 3) Si querés empezar un combo nuevo, borrar comboactual
            comboactual = null;

            // 4) Dejar el foco donde quieras (primer campo)
            txtCombo.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Limpiar lo que corresponde a Promociones
            txtPromociones.Text = "";
            listViewPromo.Items.Clear();
            txtPrecioPromocion.Text = "";

            // Foco en el textbox de promociones
            txtPromociones.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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




        }
    }
}
