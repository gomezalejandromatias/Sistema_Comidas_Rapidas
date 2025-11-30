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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallaVenta)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 2;
            // 
            // FrmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewDetallaVenta);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleVenta";
            this.Text = "FrmDetalleVenta";
            this.Load += new System.EventHandler(this.FrmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetallaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDetallaVenta;
        private System.Windows.Forms.TextBox textBox1;
    }
}