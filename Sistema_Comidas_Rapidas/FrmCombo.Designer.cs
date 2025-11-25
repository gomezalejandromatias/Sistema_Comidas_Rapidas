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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listViewCombo = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIngredienteCombo = new System.Windows.Forms.TextBox();
            this.btnIngredienteCombo = new System.Windows.Forms.Button();
            this.listViewPromo = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIngredientePromociones = new System.Windows.Forms.TextBox();
            this.btnAgregarPromo = new System.Windows.Forms.Button();
            this.btnAgregarIngredientes = new System.Windows.Forms.Button();
            this.btnAgregarPromocion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboPromociones)).BeginInit();
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
            this.label4.Location = new System.Drawing.Point(60, 269);
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
            this.dgvComboPromociones.Location = new System.Drawing.Point(959, 140);
            this.dgvComboPromociones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvComboPromociones.Name = "dgvComboPromociones";
            this.dgvComboPromociones.Size = new System.Drawing.Size(670, 437);
            this.dgvComboPromociones.TabIndex = 11;
            this.dgvComboPromociones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComboPromociones_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1046, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Combos y Promociones Activas";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(120, 684);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(977, 601);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listViewCombo
            // 
            this.listViewCombo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCombo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listViewCombo.HideSelection = false;
            this.listViewCombo.Location = new System.Drawing.Point(64, 466);
            this.listViewCombo.Name = "listViewCombo";
            this.listViewCombo.Size = new System.Drawing.Size(189, 176);
            this.listViewCombo.TabIndex = 16;
            this.listViewCombo.UseCompatibleStateImageBehavior = false;
            this.listViewCombo.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ingredientes del combo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtIngredienteCombo
            // 
            this.txtIngredienteCombo.BackColor = System.Drawing.SystemColors.Window;
            this.txtIngredienteCombo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteCombo.Location = new System.Drawing.Point(64, 423);
            this.txtIngredienteCombo.Name = "txtIngredienteCombo";
            this.txtIngredienteCombo.Size = new System.Drawing.Size(189, 27);
            this.txtIngredienteCombo.TabIndex = 18;
            // 
            // btnIngredienteCombo
            // 
            this.btnIngredienteCombo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredienteCombo.Location = new System.Drawing.Point(274, 329);
            this.btnIngredienteCombo.Name = "btnIngredienteCombo";
            this.btnIngredienteCombo.Size = new System.Drawing.Size(116, 23);
            this.btnIngredienteCombo.TabIndex = 19;
            this.btnIngredienteCombo.Text = "Agregrar Combo";
            this.btnIngredienteCombo.UseVisualStyleBackColor = true;
            this.btnIngredienteCombo.Click += new System.EventHandler(this.btnIngredienteCombo_Click);
            // 
            // listViewPromo
            // 
            this.listViewPromo.BackColor = System.Drawing.SystemColors.Window;
            this.listViewPromo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPromo.HideSelection = false;
            this.listViewPromo.Location = new System.Drawing.Point(472, 466);
            this.listViewPromo.Name = "listViewPromo";
            this.listViewPromo.Size = new System.Drawing.Size(228, 176);
            this.listViewPromo.TabIndex = 20;
            this.listViewPromo.UseCompatibleStateImageBehavior = false;
            this.listViewPromo.View = System.Windows.Forms.View.Details;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(468, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ingredientes de la promocion";
            // 
            // txtIngredientePromociones
            // 
            this.txtIngredientePromociones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientePromociones.Location = new System.Drawing.Point(472, 423);
            this.txtIngredientePromociones.Name = "txtIngredientePromociones";
            this.txtIngredientePromociones.Size = new System.Drawing.Size(228, 27);
            this.txtIngredientePromociones.TabIndex = 22;
            // 
            // btnAgregarPromo
            // 
            this.btnAgregarPromo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPromo.Location = new System.Drawing.Point(734, 426);
            this.btnAgregarPromo.Name = "btnAgregarPromo";
            this.btnAgregarPromo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPromo.TabIndex = 23;
            this.btnAgregarPromo.Text = "+";
            this.btnAgregarPromo.UseVisualStyleBackColor = true;
            this.btnAgregarPromo.Click += new System.EventHandler(this.btnAgregarPromo_Click);
            // 
            // btnAgregarIngredientes
            // 
            this.btnAgregarIngredientes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngredientes.Location = new System.Drawing.Point(274, 425);
            this.btnAgregarIngredientes.Name = "btnAgregarIngredientes";
            this.btnAgregarIngredientes.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIngredientes.TabIndex = 24;
            this.btnAgregarIngredientes.Text = "+";
            this.btnAgregarIngredientes.UseVisualStyleBackColor = true;
            this.btnAgregarIngredientes.Click += new System.EventHandler(this.btnAgregarIngredientes_Click);
            // 
            // btnAgregarPromocion
            // 
            this.btnAgregarPromocion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPromocion.Location = new System.Drawing.Point(708, 326);
            this.btnAgregarPromocion.Name = "btnAgregarPromocion";
            this.btnAgregarPromocion.Size = new System.Drawing.Size(162, 26);
            this.btnAgregarPromocion.TabIndex = 25;
            this.btnAgregarPromocion.Text = "Agregar Poromocion";
            this.btnAgregarPromocion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarPromocion.UseVisualStyleBackColor = true;
            this.btnAgregarPromocion.Click += new System.EventHandler(this.btnAgregarPromocion_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(532, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(1120, 108);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(164, 23);
            this.txtFiltro.TabIndex = 27;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(956, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Buscar Combos o Promos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(453, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "$";
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1061);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarPromocion);
            this.Controls.Add(this.btnAgregarIngredientes);
            this.Controls.Add(this.btnAgregarPromo);
            this.Controls.Add(this.txtIngredientePromociones);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listViewPromo);
            this.Controls.Add(this.btnIngredienteCombo);
            this.Controls.Add(this.txtIngredienteCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listViewCombo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView listViewCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIngredienteCombo;
        private System.Windows.Forms.Button btnIngredienteCombo;
        private System.Windows.Forms.ListView listViewPromo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIngredientePromociones;
        private System.Windows.Forms.Button btnAgregarPromo;
        private System.Windows.Forms.Button btnAgregarIngredientes;
        private System.Windows.Forms.Button btnAgregarPromocion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}