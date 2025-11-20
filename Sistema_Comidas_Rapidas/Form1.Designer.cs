namespace Sistema_Comidas_Rapidas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dvbListaProducto = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBucarProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvbListaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Negocio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo Del Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(33, 592);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 31);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dvbListaProducto
            // 
            this.dvbListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvbListaProducto.Location = new System.Drawing.Point(745, 82);
            this.dvbListaProducto.Name = "dvbListaProducto";
            this.dvbListaProducto.Size = new System.Drawing.Size(1025, 472);
            this.dvbListaProducto.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(203, 592);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 31);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCancelar
            // 
            this.txtCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelar.Location = new System.Drawing.Point(380, 596);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(117, 27);
            this.txtCancelar.TabIndex = 8;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1049, 587);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(198, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(319, 130);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(178, 26);
            this.txtCodigoProducto.TabIndex = 12;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(319, 188);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(178, 26);
            this.txtNombreProducto.TabIndex = 13;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.Location = new System.Drawing.Point(319, 254);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(178, 27);
            this.txtFechaIngreso.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(319, 326);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(178, 26);
            this.txtStock.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(319, 392);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(178, 26);
            this.txtPrecio.TabIndex = 16;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.Location = new System.Drawing.Point(42, 450);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(83, 19);
            this.Categoria.TabIndex = 17;
            this.Categoria.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(319, 450);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(178, 26);
            this.txtCategoria.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(929, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Productos Guardadosen el sistema";
            // 
            // txtBucarProducto
            // 
            this.txtBucarProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBucarProducto.Location = new System.Drawing.Point(894, 45);
            this.txtBucarProducto.Name = "txtBucarProducto";
            this.txtBucarProducto.Size = new System.Drawing.Size(196, 27);
            this.txtBucarProducto.TabIndex = 21;
            this.txtBucarProducto.TextChanged += new System.EventHandler(this.txtBucarProducto_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(741, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Buscar Productos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBucarProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dvbListaProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.Text = "Agregar Productos";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dvbListaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dvbListaProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBucarProducto;
        private System.Windows.Forms.Label label9;
    }
}

