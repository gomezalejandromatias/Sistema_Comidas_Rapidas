namespace Sistema_Comidas_Rapidas
{
    partial class FrmDetalleVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDetallaVenta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolverVenta = new System.Windows.Forms.Button();
            this.dtmFiltarFecha = new System.Windows.Forms.DateTimePicker();
            this.btnElegirFechaFiltrada = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotalGeneral = new System.Windows.Forms.Label();
            this.lblTotalEfectivo = new System.Windows.Forms.Label();
            this.lblTotalTransferencia = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallaVenta)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle de Ventas";
            // 
            // dataGridViewDetallaVenta
            // 
            this.dataGridViewDetallaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetallaVenta.Location = new System.Drawing.Point(38, 124);
            this.dataGridViewDetallaVenta.Name = "dataGridViewDetallaVenta";
            this.dataGridViewDetallaVenta.Size = new System.Drawing.Size(639, 278);
            this.dataGridViewDetallaVenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(859, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtro de Venta por Fecha";
            // 
            // btnVolverVenta
            // 
            this.btnVolverVenta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverVenta.Location = new System.Drawing.Point(1150, 415);
            this.btnVolverVenta.Name = "btnVolverVenta";
            this.btnVolverVenta.Size = new System.Drawing.Size(168, 23);
            this.btnVolverVenta.TabIndex = 4;
            this.btnVolverVenta.Text = "Volver  pantalla De Venta";
            this.btnVolverVenta.UseVisualStyleBackColor = true;
            this.btnVolverVenta.Click += new System.EventHandler(this.btnVolverVenta_Click);
            // 
            // dtmFiltarFecha
            // 
            this.dtmFiltarFecha.Location = new System.Drawing.Point(848, 162);
            this.dtmFiltarFecha.Name = "dtmFiltarFecha";
            this.dtmFiltarFecha.Size = new System.Drawing.Size(201, 20);
            this.dtmFiltarFecha.TabIndex = 5;
            this.dtmFiltarFecha.ValueChanged += new System.EventHandler(this.dtmFiltarFecha_ValueChanged);
            // 
            // btnElegirFechaFiltrada
            // 
            this.btnElegirFechaFiltrada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirFechaFiltrada.Location = new System.Drawing.Point(848, 317);
            this.btnElegirFechaFiltrada.Name = "btnElegirFechaFiltrada";
            this.btnElegirFechaFiltrada.Size = new System.Drawing.Size(201, 23);
            this.btnElegirFechaFiltrada.TabIndex = 6;
            this.btnElegirFechaFiltrada.Text = "Presione Para Elegir La Fecha";
            this.btnElegirFechaFiltrada.UseVisualStyleBackColor = true;
            this.btnElegirFechaFiltrada.Click += new System.EventHandler(this.btnElegirFechaFiltrada_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(974, 415);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar Grilla";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTotalGeneral
            // 
            this.lblTotalGeneral.AutoSize = true;
            this.lblTotalGeneral.Location = new System.Drawing.Point(35, 420);
            this.lblTotalGeneral.Name = "lblTotalGeneral";
            this.lblTotalGeneral.Size = new System.Drawing.Size(35, 13);
            this.lblTotalGeneral.TabIndex = 8;
            this.lblTotalGeneral.Text = "label3";
            // 
            // lblTotalEfectivo
            // 
            this.lblTotalEfectivo.AutoSize = true;
            this.lblTotalEfectivo.Location = new System.Drawing.Point(162, 420);
            this.lblTotalEfectivo.Name = "lblTotalEfectivo";
            this.lblTotalEfectivo.Size = new System.Drawing.Size(35, 13);
            this.lblTotalEfectivo.TabIndex = 9;
            this.lblTotalEfectivo.Text = "label4";
            // 
            // lblTotalTransferencia
            // 
            this.lblTotalTransferencia.AutoSize = true;
            this.lblTotalTransferencia.Location = new System.Drawing.Point(307, 420);
            this.lblTotalTransferencia.Name = "lblTotalTransferencia";
            this.lblTotalTransferencia.Size = new System.Drawing.Size(35, 13);
            this.lblTotalTransferencia.TabIndex = 10;
            this.lblTotalTransferencia.Text = "label5";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1330, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // FrmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTotalTransferencia);
            this.Controls.Add(this.lblTotalEfectivo);
            this.Controls.Add(this.lblTotalGeneral);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnElegirFechaFiltrada);
            this.Controls.Add(this.dtmFiltarFecha);
            this.Controls.Add(this.btnVolverVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDetallaVenta);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleVenta";
            this.Text = "FrmDetalleVenta";
            this.Load += new System.EventHandler(this.FrmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallaVenta)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDetallaVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolverVenta;
        private System.Windows.Forms.DateTimePicker dtmFiltarFecha;
        private System.Windows.Forms.Button btnElegirFechaFiltrada;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotalGeneral;
        private System.Windows.Forms.Label lblTotalEfectivo;
        private System.Windows.Forms.Label lblTotalTransferencia;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}