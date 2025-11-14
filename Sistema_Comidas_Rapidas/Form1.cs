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
    public partial class Form1 : Form
    {
          List<Producto> lista = new List<Producto>();
          
        public Form1()
        {
            InitializeComponent();

            dvbListaProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvbListaProducto.Font = new Font("Segoe UI", 10);  // tamaño normal
            dvbListaProducto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            txtFechaIngreso.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtFechaIngreso.ReadOnly = true;



            Producto producto = new Producto();
            


            CargarGrilla(); 
        }


   

        private void CargarGrilla()
        {
            dvbListaProducto.DataSource = null;          
            dvbListaProducto.DataSource = lista;
            
            dvbListaProducto.Columns["IDProducto"].Visible = false;
             dvbListaProducto.Columns["Activo"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto aux = new Producto();

            aux.Nombre = txtNombreProducto.Text;
            aux.CodigoProducto = txtCodigoProducto.Text;
            
            aux.FechaIngreso = DateTime.Now;
            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error");
                return;
            }
            aux.Stock = int.Parse(txtStock.Text);

            aux.Precio = precio;

            aux.Categoria = txtCategoria.Text;  

            lista.Add(aux);

            txtNombreProducto.Text = "";
            txtCodigoProducto.Text = "";
            txtFechaIngreso.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            txtCategoria.Text = "";

            CargarGrilla();

            txtCodigoProducto.Focus();
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";
            txtCodigoProducto.Text = "";
            txtFechaIngreso.Text = "";
            txtPrecio.Text = "";
            txtCategoria.Text = "";
        }
    }
}
