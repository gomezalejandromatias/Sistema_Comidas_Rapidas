using Dominio;
using Negocio;
using Sistema_Comidas_Rapidas.Helpers;
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
        bool seleccionandoDesde = true;
        DateTime fechaDesde;
        public FrmDetalleVenta()
        {
            InitializeComponent();
            cargargrilla();
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            UIHelper.DataGridViewModerno(dataGridViewDetallaVenta);
            UIHelper.LabelPremium(lblTotalEfectivo);
            UIHelper.LabelPremium(lblTotalTransferencia);
            UIHelper.LabelTituloPremium(lblTitulo);
            UIHelper.LabelPremium(lblObservacion);

            UIHelper.BotonPrincipal(btnElegirFechaFiltrada);
            UIHelper.BotonAmarilloPremium(btnLimpiar);
            UIHelper.BotonPeligroPremium(btnVolverVenta);













            dataGridViewDetallaVenta.ClearSelection();
        }

        public void cargargrilla()
        {

            VentaNegocio ventaNegocio = new VentaNegocio();

            dataGridViewDetallaVenta.DataSource = null;
            dataGridViewDetallaVenta.DataSource = ventaNegocio.listaventa();

         
            dataGridViewDetallaVenta.Columns["IDVenta"].Visible = false;
            dataGridViewDetallaVenta.Columns["Empleado"].Visible = false;
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

            if (seleccionandoDesde)
            {
                // 1) Primera selección: FECHA DESDE
                fechaDesde = dtmFiltarFecha.Value.Date;
                seleccionandoDesde = false;

                MessageBox.Show(
                    "Fecha DESDE seleccionada: " + fechaDesde.ToShortDateString() +
                    "\nAhora elegí la FECHA HASTA en el calendario."
                );
            }
            else
            {
                // 2) Segunda selección: FECHA HASTA
                DateTime fechaHasta = dtmFiltarFecha.Value.Date;

                // Si el usuario eligió al revés, las acomodo
                if (fechaHasta < fechaDesde)
                {
                    DateTime aux = fechaHasta;
                    fechaHasta = fechaDesde;
                    fechaDesde = aux;
                }

                // ✅ CLAVE: incluir TODO el día "fechaHasta"
                DateTime desde = fechaDesde.Date;                 // 00:00 del día desde
                DateTime hastaExclusivo = fechaHasta.Date.AddDays(1); // 00:00 del día siguiente

                // Traigo las ventas del rango (desde inclusive, hasta exclusivo)
                var lista = ventaNegocio.listaventaFiltrada(desde, hastaExclusivo);

                dataGridViewDetallaVenta.DataSource = null;
                dataGridViewDetallaVenta.DataSource = lista;
                dataGridViewDetallaVenta.Columns["IDVenta"].Visible = false;

                // Totales
                decimal totalGeneral = 0;
                decimal totalEfectivo = 0;
                decimal totalTransferencia = 0;

                foreach (Venta v in lista)
                {
                    totalGeneral += v.TotalPrecio;

                    if (v.FormaPago == "Efectivo")
                    {
                        totalEfectivo += v.TotalPrecio;
                    }
                    else if (v.FormaPago == "Transferencia")
                    {
                        totalTransferencia += v.TotalPrecio;
                    }
                }

                lblTotalGeneral.Text = "Total general: $" + totalGeneral.ToString("0.00");
                lblTotalEfectivo.Text = "Total en efectivo: $" + totalEfectivo.ToString("0.00");
                lblTotalTransferencia.Text = "Total en transferencia: $" + totalTransferencia.ToString("0.00");

                // Vuelvo al estado inicial para la próxima
                seleccionandoDesde = true;

                MessageBox.Show(
                    "Mostrando ventas desde " +
                    fechaDesde.ToShortDateString() +
                    " hasta " +
                    fechaHasta.ToShortDateString()
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargargrilla();
            seleccionandoDesde = true;
            lblTotalEfectivo.Visible = false;
            lblTotalGeneral.Visible = false;
            lblTotalTransferencia.Visible = false;

        }

        private void dtmFiltarFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
