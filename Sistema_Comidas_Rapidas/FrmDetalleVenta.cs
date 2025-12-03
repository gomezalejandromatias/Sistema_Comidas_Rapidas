using Dominio;
using Negocio;
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
    public partial class FrmDetalleVenta : Form
    {
        public FrmDetalleVenta()
        {
            InitializeComponent();
            cargargrilla();
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
          
        }

        public void cargargrilla()
        {

            VentaNegocio ventaNegocio = new VentaNegocio();

            dataGridViewDetallaVenta.DataSource = null;
            dataGridViewDetallaVenta.DataSource = ventaNegocio.listaventa();

         
            dataGridViewDetallaVenta.Columns["IDVenta"].Visible = false;

            dataGridViewDetallaVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajustar peso de cada columna
            dataGridViewDetallaVenta.Columns["FechaVenta"].FillWeight = 70;             // más chica
            dataGridViewDetallaVenta.Columns["TotalPrecio"].FillWeight = 40;             // más chica
           




        }



        private void btnVolverVenta_Click(object sender, EventArgs e)
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

        private void btnElegirFechaFiltrada_Click(object sender, EventArgs e)
        {
            VentaNegocio ventaNegocio = new VentaNegocio();

            string elegir = dtmFiltarFecha.Value.ToString("dd/MM/yyyy");

                var lista = ventaNegocio.listaventa(elegir);

            dataGridViewDetallaVenta.DataSource = null;
            dataGridViewDetallaVenta.DataSource = lista;
            dataGridViewDetallaVenta.Columns["IDVenta"].Visible = false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargargrilla();
        }
    }
}
