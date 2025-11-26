using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int unidades, paquetes;

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
                aux.NombreProducto = txtNombreProducto.Text;

                Proveedores prov = (Proveedores)comboBoxaProveedor.SelectedItem;

                aux.IDProveedor = prov.idproveedor;


               

                aux.CodigoProducto = txtCodigoProducto.Text;

                aux.FechaIngreso = DateTime.Now;



                aux.CantidadUnidad = unidades;      
                aux.UnidadPaquete = paquetes;       
                aux.Stock = int.Parse(txtStock.Text);



                aux.Stock =int.Parse( txtStock.Text);

                aux.Categoria = txtCategoria.Text;

                decimal precio;

                if (!decimal.TryParse(txtPrecioUnidad.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser un número válido.", "Error");
                    return;
                }
                aux.PrecioUnidad = precio;

                aux.PrecioFinal = unidades * paquetes* precio;




                decimal contadorTotal = +aux.PrecioUnidad;

                lblTotalPrecioProducto.Text = contadorTotal.ToString();

                lista.Add(aux);

               productoNegocio.AgregarProducto(aux);

            }
            catch (Exception ex)
            {

                throw ex;
            }

      


            

            txtNombreProducto.Text = "";
            txtCodigoProducto.Text = "";
            txtUnidadPaquete.Text = "";
            txtUnidadPaquete.Text = "";
          
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";

            CargarGrilla();

            txtCodigoProducto.Focus();

   
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";
            txtCodigoProducto.Text = "";
            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";
            txtProveedor.Text = "";
            txtBucarProducto.Text = "";

            txtCodigoProducto.Focus();
        }

        private void txtBucarProducto_TextChanged(object sender, EventArgs e)
        {
            List<Producto> listafiltrada;
            string filtro = txtBucarProducto.Text;

            ProductoNegocio productoNegocio = new ProductoNegocio();


            if(filtro!= "") 
            { 
               listafiltrada = productoNegocio.listaproducto().FindAll(x => x.NombreProducto.ToLower().Contains(filtro));
          


            }

            else
            {
                listafiltrada = productoNegocio.listaproducto();

            }

            dvbListaProducto.DataSource = null;
            dvbListaProducto.DataSource = listafiltrada;

           



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
            else
            {
                txtStock.Text = "";
            }
        }

        private void txtUnidadPaquete_TextChanged(object sender, EventArgs e)
        {
            CalcularStock();
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = "";
            txtCodigoProducto.Text = "";
            txtUnidadPaquete.Text = "";
            txtCantidadPaquete.Text = "";
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";
            txtProveedor.Text = "";
            txtBucarProducto.Text = "";

            


            frmVenta venta = new frmVenta();
            venta.Show();

            this.Close();
        }

        private void dvbListaProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProveedorNegocio proveedorNegocio = new ProveedorNegocio();


            try
            {
                comboBoxaProveedor.DataSource = proveedorNegocio.ListaProveedores();
                  

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtCantidadPaquete_TextChanged(object sender, EventArgs e)
        {
            CalcularStock();
        }
    }
}
