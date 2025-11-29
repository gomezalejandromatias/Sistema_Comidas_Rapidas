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
            ComboNegocio comboNegocio = new ComboNegocio();

            dgvComboPromociones.DataSource = null;
            dgvComboPromociones.DataSource = comboNegocio.listacombo();

            dgvComboPromociones.Columns["IdCombo"].Visible = false;
            dgvComboPromociones.Columns["Activo"].Visible = false;
          

            dgvComboPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar peso de cada columna
            dgvComboPromociones.Columns["Nombre"].FillWeight = 70;             // más chica
            dgvComboPromociones.Columns["Precio"].FillWeight = 40;             // más chica
            dgvComboPromociones.Columns["Ingredientes"].FillWeight = 200; // MUCHO más grande
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

             

                // Refrescar la grilla
                comboNegocio.AgregarCombo(comboactual);

                cargargrillacombo();

                MessageBox.Show(" Combo Agregado con exito  ");
                  


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
                comboNegocio.AgregarCombo(comboactual);

                cargargrillacombo();

                MessageBox.Show(" Promocion Agregado con exito  ");



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
