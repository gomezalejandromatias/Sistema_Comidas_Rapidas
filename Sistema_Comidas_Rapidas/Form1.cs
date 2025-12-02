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
        Producto aux;

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


                
                aux.CodigoProducto = "C" + new Random().Next(1000, 9999);

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
            
            txtUnidadPaquete.Text = "";
            txtUnidadPaquete.Text = "";
          
            txtStock.Text = "";
            txtPrecioUnidad.Text = "";
            txtCategoria.Text = "";

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
            btnModicarDefinitivo.Visible=false;
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
             ProductoNegocio productoNegocio = new ProductoNegocio();
            Producto selecionado;

             
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el Producto?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

               if( respuesta == DialogResult.Yes)
               {
                  selecionado = (Producto)dvbListaProducto.CurrentRow.DataBoundItem;
                      
                  productoNegocio.EliminarProducto(selecionado.IDProducto);
                    CargarGrilla();

                   lblTotalPrecioProducto.Text= "Eliminado Correctamente";
                   
               }
                


            }
            catch (Exception ex)
            {

                throw ex;
            }

            lblTotalPrecioProducto.Visible= false;
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
            btnAgregar.Visible=false;
            btnEliminar.Visible=false;
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

        private void txtCantidadPaquete_TextChanged(object sender, EventArgs e)
        {
            CalcularStock();
        }
    }
}
