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
            this.label7 = new System.Windows.Forms.Label();
            this.btnIngredienteCombo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarPromocion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBoxCombo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPromocion = new System.Windows.Forms.RichTextBox();
            this.btnEliminarCombo = new System.Windows.Forms.Button();
            this.lblEliminado = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnCancelarModficacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboPromociones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Combos y Promociones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 140);
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
            this.label3.Location = new System.Drawing.Point(469, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de las Promociones";
            // 
            // txtCombo
            // 
            this.txtCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCombo.Location = new System.Drawing.Point(63, 192);
            this.txtCombo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(189, 31);
            this.txtCombo.TabIndex = 3;
            // 
            // txtPromociones
            // 
            this.txtPromociones.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromociones.Location = new System.Drawing.Point(471, 192);
            this.txtPromociones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPromociones.Name = "txtPromociones";
            this.txtPromociones.Size = new System.Drawing.Size(215, 31);
            this.txtPromociones.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 268);
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
            this.label5.Location = new System.Drawing.Point(469, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio de la Promocion";
            // 
            // txtPrecioCombo
            // 
            this.txtPrecioCombo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCombo.Location = new System.Drawing.Point(63, 325);
            this.txtPrecioCombo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrecioCombo.Name = "txtPrecioCombo";
            this.txtPrecioCombo.Size = new System.Drawing.Size(189, 31);
            this.txtPrecioCombo.TabIndex = 9;
            // 
            // txtPrecioPromocion
            // 
            this.txtPrecioPromocion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPromocion.Location = new System.Drawing.Point(471, 325);
            this.txtPrecioPromocion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrecioPromocion.Name = "txtPrecioPromocion";
            this.txtPrecioPromocion.Size = new System.Drawing.Size(215, 31);
            this.txtPrecioPromocion.TabIndex = 10;
            // 
            // dgvComboPromociones
            // 
            this.dgvComboPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComboPromociones.Location = new System.Drawing.Point(799, 151);
            this.dgvComboPromociones.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvComboPromociones.Name = "dgvComboPromociones";
            this.dgvComboPromociones.Size = new System.Drawing.Size(952, 437);
            this.dgvComboPromociones.TabIndex = 11;
            this.dgvComboPromociones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComboPromociones_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1047, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Combos y Promociones Activas";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(63, 684);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1361, 684);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 34);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 390);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ingredientes del combo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnIngredienteCombo
            // 
            this.btnIngredienteCombo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredienteCombo.Location = new System.Drawing.Point(192, 684);
            this.btnIngredienteCombo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIngredienteCombo.Name = "btnIngredienteCombo";
            this.btnIngredienteCombo.Size = new System.Drawing.Size(117, 23);
            this.btnIngredienteCombo.TabIndex = 19;
            this.btnIngredienteCombo.Text = "Agregrar Combo";
            this.btnIngredienteCombo.UseVisualStyleBackColor = true;
            this.btnIngredienteCombo.Click += new System.EventHandler(this.btnIngredienteCombo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ingredientes de la promocion";
            // 
            // btnAgregarPromocion
            // 
            this.btnAgregarPromocion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPromocion.Location = new System.Drawing.Point(593, 684);
            this.btnAgregarPromocion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarPromocion.Name = "btnAgregarPromocion";
            this.btnAgregarPromocion.Size = new System.Drawing.Size(163, 23);
            this.btnAgregarPromocion.TabIndex = 25;
            this.btnAgregarPromocion.Text = "Agregar Poromocion";
            this.btnAgregarPromocion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarPromocion.UseVisualStyleBackColor = true;
            this.btnAgregarPromocion.Click += new System.EventHandler(this.btnAgregarPromocion_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 684);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(1120, 109);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(164, 23);
            this.txtFiltro.TabIndex = 27;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(957, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Buscar Combos o Promos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 333);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(454, 333);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "$";
            // 
            // richTextBoxCombo
            // 
            this.richTextBoxCombo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCombo.Location = new System.Drawing.Point(63, 450);
            this.richTextBoxCombo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxCombo.Name = "richTextBoxCombo";
            this.richTextBoxCombo.Size = new System.Drawing.Size(244, 137);
            this.richTextBoxCombo.TabIndex = 31;
            this.richTextBoxCombo.Text = "";
            // 
            // richTextBoxPromocion
            // 
            this.richTextBoxPromocion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPromocion.Location = new System.Drawing.Point(471, 450);
            this.richTextBoxPromocion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBoxPromocion.Name = "richTextBoxPromocion";
            this.richTextBoxPromocion.Size = new System.Drawing.Size(266, 137);
            this.richTextBoxPromocion.TabIndex = 32;
            this.richTextBoxPromocion.Text = "";
            // 
            // btnEliminarCombo
            // 
            this.btnEliminarCombo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCombo.Location = new System.Drawing.Point(960, 684);
            this.btnEliminarCombo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarCombo.Name = "btnEliminarCombo";
            this.btnEliminarCombo.Size = new System.Drawing.Size(175, 34);
            this.btnEliminarCombo.TabIndex = 33;
            this.btnEliminarCombo.Text = "Eliminar Combo/Promo";
            this.btnEliminarCombo.UseVisualStyleBackColor = true;
            this.btnEliminarCombo.Click += new System.EventHandler(this.btnEliminarCombo_Click);
            // 
            // lblEliminado
            // 
            this.lblEliminado.AutoSize = true;
            this.lblEliminado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminado.Location = new System.Drawing.Point(1311, 112);
            this.lblEliminado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEliminado.Name = "lblEliminado";
            this.lblEliminado.Size = new System.Drawing.Size(317, 19);
            this.lblEliminado.TabIndex = 34;
            this.lblEliminado.Text = "Combo/Promocion eliminado Correctamente";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1161, 684);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 34);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar combo/Promo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(1361, 684);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(124, 34);
            this.btnGuardarCambios.TabIndex = 36;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnCancelarModficacion
            // 
            this.btnCancelarModficacion.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModficacion.Location = new System.Drawing.Point(1516, 687);
            this.btnCancelarModficacion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelarModficacion.Name = "btnCancelarModficacion";
            this.btnCancelarModficacion.Size = new System.Drawing.Size(162, 31);
            this.btnCancelarModficacion.TabIndex = 37;
            this.btnCancelarModficacion.Text = "Cancelar Modificacion";
            this.btnCancelarModficacion.UseVisualStyleBackColor = true;
            this.btnCancelarModficacion.Click += new System.EventHandler(this.btnCancelarModficacion_Click);
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1923, 1061);
            this.Controls.Add(this.btnCancelarModficacion);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblEliminado);
            this.Controls.Add(this.btnEliminarCombo);
            this.Controls.Add(this.richTextBoxPromocion);
            this.Controls.Add(this.richTextBoxCombo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarPromocion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnIngredienteCombo);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCombo_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnIngredienteCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarPromocion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBoxCombo;
        private System.Windows.Forms.RichTextBox richTextBoxPromocion;
        private System.Windows.Forms.Button btnEliminarCombo;
        private System.Windows.Forms.Label lblEliminado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnCancelarModficacion;
    }
}