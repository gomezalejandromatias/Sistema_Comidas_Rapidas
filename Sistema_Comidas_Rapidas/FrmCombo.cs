using Dominio;
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
        public  Combo comboactual = new Combo();
          
        public FrmCombo()
        {
            InitializeComponent();
            dgvComboPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComboPromociones.Font = new Font("Segoe UI", 10);  // tamaño normal
            dgvComboPromociones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            
            cargargrillacombo();

            listViewCombo.View = View.Details;
            listViewCombo.Columns.Add("Ingrediente", 100);
            listViewCombo.FullRowSelect = true;
            listViewCombo.GridLines = true;
            listViewCombo.UseCompatibleStateImageBehavior = false;
            listViewCombo.FullRowSelect = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                Combo aux = new Combo();

                
                if (!string.IsNullOrWhiteSpace(txtCombo.Text))
                {
                    aux.NombrePromocion = txtCombo.Text;

                    decimal precioCombo;
                    if (!decimal.TryParse(txtPrecioCombo.Text, out precioCombo))
                    {
                        MessageBox.Show("El precio del combo no es válido.");
                        return;
                    }
                    aux.PrecioCombo = precioCombo;

                    

                }
                
                else if (!string.IsNullOrWhiteSpace(txtPrecioPromocion.Text))
                {
                    aux.NombrePromocion = txtPromociones.Text;  

                    decimal precioPromo;
                    if (!decimal.TryParse(txtPrecioPromocion.Text, out precioPromo))
                    {
                        MessageBox.Show("El precio de la promoción no es válido.");
                        return;
                    }
                    aux.PrecioPromo = precioPromo;

                    
                }

                listacombo.Add(aux);
                
                 

            }
            catch (Exception)
            {

                throw;
            }


            txtCombo.Text = "";
            txtPrecioCombo.Text = "";
            txtPrecioPromocion.Text = "";
          

            txtCombo.Focus();


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



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnIngredienteCombo_Click(object sender, EventArgs e)
        {



            ListViewItem items = new ListViewItem(txtIngredienteCombo.Text);

            listViewCombo.Items.Add(items);
            try
            {
                 

             comboactual = new Combo();

              comboactual.NombreCombo = txtCombo.Text;

                comboactual.PrecioCombo = decimal.Parse(txtPrecioCombo.Text);

            

                listacombo.Add(comboactual);
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        private void btnAgregarPromo_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txtPromociones.Text);

            listViewPromo.Items.Add(item);
        }

        private void btnAgregarIngredientes_Click(object sender, EventArgs e)
        {
            comboactual = new Combo();

            ListViewItem item = new ListViewItem(txtIngredienteCombo.Text);

            listViewCombo.Items.Add(item);

            comboactual.Ingredientes.Add(txtIngredienteCombo.Text);
            comboactual.Ingrediente = txtIngredienteCombo.Text;

        }
    }
}
