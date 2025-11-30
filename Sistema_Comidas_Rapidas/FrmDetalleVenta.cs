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
    }
}
