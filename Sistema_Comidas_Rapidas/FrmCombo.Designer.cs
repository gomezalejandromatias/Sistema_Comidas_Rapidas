namespace Sistema_Comidas_Rapidas
{
    partial class FrmCombo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.txtPromociones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioCombo = new System.Windows.Forms.TextBox();
            this.txtPrecioPromocion = new System.Windows.Forms.TextBox();
            this.dgvComboPromociones = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarComboPromocion = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvIngredientePromo = new System.Windows.Forms.DataGridView();
            this.dvbIngredienteCombo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboPromociones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientePromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvbIngredienteCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combos y Promociones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de los Combos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de las Promociones";
            // 
            // txtCombo
            // 
            this.txtCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo.Location = new System.Drawing.Point(64, 193);
            this.txtCombo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(189, 31);
            this.txtCombo.TabIndex = 3;
            // 
            // txtPromociones
            // 
            this.txtPromociones.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromociones.Location = new System.Drawing.Point(472, 193);
            this.txtPromociones.Margin = new System.Windows.Forms.Padding(2);
            this.txtPromociones.Name = "txtPromociones";
            this.txtPromociones.Size = new System.Drawing.Size(216, 31);
            this.txtPromociones.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio del combo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio de la Promocion";
            // 
            // txtPrecioCombo
            // 
            this.txtPrecioCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCombo.Location = new System.Drawing.Point(64, 324);
            this.txtPrecioCombo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCombo.Name = "txtPrecioCombo";
            this.txtPrecioCombo.Size = new System.Drawing.Size(189, 31);
            this.txtPrecioCombo.TabIndex = 9;
            // 
            // txtPrecioPromocion
            // 
            this.txtPrecioPromocion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPromocion.Location = new System.Drawing.Point(472, 324);
            this.txtPrecioPromocion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioPromocion.Name = "txtPrecioPromocion";
            this.txtPrecioPromocion.Size = new System.Drawing.Size(216, 31);
            this.txtPrecioPromocion.TabIndex = 10;
            // 
            // dgvComboPromociones
            // 
            this.dgvComboPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComboPromociones.Location = new System.Drawing.Point(818, 92);
            this.dgvComboPromociones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvComboPromociones.Name = "dgvComboPromociones";
            this.dgvComboPromociones.Size = new System.Drawing.Size(512, 437);
            this.dgvComboPromociones.TabIndex = 11;
            this.dgvComboPromociones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComboPromociones_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(937, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Combos y Promociones Activas";
            // 
            // btnAgregarComboPromocion
            // 
            this.btnAgregarComboPromocion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarComboPromocion.Location = new System.Drawing.Point(818, 554);
            this.btnAgregarComboPromocion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarComboPromocion.Name = "btnAgregarComboPromocion";
            this.btnAgregarComboPromocion.Size = new System.Drawing.Size(240, 47);
            this.btnAgregarComboPromocion.TabIndex = 13;
            this.btnAgregarComboPromocion.Text = "Agregar Promocion o Combo";
            this.btnAgregarComboPromocion.UseVisualStyleBackColor = true;
            this.btnAgregarComboPromocion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1075, 560);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 35);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1226, 554);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvIngredientePromo
            // 
            this.dgvIngredientePromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientePromo.Location = new System.Drawing.Point(482, 445);
            this.dgvIngredientePromo.Name = "dgvIngredientePromo";
            this.dgvIngredientePromo.Size = new System.Drawing.Size(240, 150);
            this.dgvIngredientePromo.TabIndex = 16;
            // 
            // dvbIngredienteCombo
            // 
            this.dvbIngredienteCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvbIngredienteCombo.Location = new System.Drawing.Point(64, 445);
            this.dvbIngredienteCombo.Name = "dvbIngredienteCombo";
            this.dvbIngredienteCombo.Size = new System.Drawing.Size(240, 150);
            this.dvbIngredienteCombo.TabIndex = 17;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1061);
            this.Controls.Add(this.dvbIngredienteCombo);
            this.Controls.Add(this.dgvIngredientePromo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregarComboPromocion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvComboPromociones);
            this.Controls.Add(this.txtPrecioPromocion);
            this.Controls.Add(this.txtPrecioCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPromociones);
            this.Controls.Add(this.txtCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboPromociones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientePromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvbIngredienteCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCombo;
        private System.Windows.Forms.TextBox txtPromociones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioCombo;
        private System.Windows.Forms.TextBox txtPrecioPromocion;
        private System.Windows.Forms.DataGridView dgvComboPromociones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarComboPromocion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvIngredientePromo;
        private System.Windows.Forms.DataGridView dvbIngredienteCombo;
    }
}