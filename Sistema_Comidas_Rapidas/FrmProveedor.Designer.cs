namespace Sistema_Comidas_Rapidas
{
    partial class FrmProveedor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreProv = new System.Windows.Forms.TextBox();
            this.txtDireccionProv = new System.Windows.Forms.TextBox();
            this.txtEmailProv = new System.Windows.Forms.TextBox();
            this.txtTelProv = new System.Windows.Forms.TextBox();
            this.rtbProv = new System.Windows.Forms.RichTextBox();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModificarDefinitivoProv = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVoverVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Proveedor/Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción (Opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.Location = new System.Drawing.Point(383, 116);
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.Size = new System.Drawing.Size(279, 23);
            this.txtNombreProv.TabIndex = 6;
            // 
            // txtDireccionProv
            // 
            this.txtDireccionProv.Location = new System.Drawing.Point(383, 313);
            this.txtDireccionProv.Name = "txtDireccionProv";
            this.txtDireccionProv.Size = new System.Drawing.Size(279, 23);
            this.txtDireccionProv.TabIndex = 7;
            // 
            // txtEmailProv
            // 
            this.txtEmailProv.Location = new System.Drawing.Point(383, 250);
            this.txtEmailProv.Name = "txtEmailProv";
            this.txtEmailProv.Size = new System.Drawing.Size(279, 23);
            this.txtEmailProv.TabIndex = 8;
            // 
            // txtTelProv
            // 
            this.txtTelProv.Location = new System.Drawing.Point(383, 172);
            this.txtTelProv.Name = "txtTelProv";
            this.txtTelProv.Size = new System.Drawing.Size(279, 23);
            this.txtTelProv.TabIndex = 9;
            // 
            // rtbProv
            // 
            this.rtbProv.Location = new System.Drawing.Point(383, 385);
            this.rtbProv.Name = "rtbProv";
            this.rtbProv.Size = new System.Drawing.Size(279, 163);
            this.rtbProv.TabIndex = 10;
            this.rtbProv.Text = "";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(901, 116);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.Size = new System.Drawing.Size(489, 285);
            this.dtgProveedor.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(749, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 23);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Proveedor";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(749, 191);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar Proveedor";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(749, 249);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Proveedor ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1028, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Proveedores";
            // 
            // btnModificarDefinitivoProv
            // 
            this.btnModificarDefinitivoProv.Location = new System.Drawing.Point(749, 305);
            this.btnModificarDefinitivoProv.Name = "btnModificarDefinitivoProv";
            this.btnModificarDefinitivoProv.Size = new System.Drawing.Size(136, 23);
            this.btnModificarDefinitivoProv.TabIndex = 16;
            this.btnModificarDefinitivoProv.Text = "Guardar Cambios";
            this.btnModificarDefinitivoProv.UseVisualStyleBackColor = true;
            this.btnModificarDefinitivoProv.Click += new System.EventHandler(this.btnModificarDefinitivoProv_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(779, 517);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVoverVentas
            // 
            this.btnVoverVentas.Location = new System.Drawing.Point(923, 517);
            this.btnVoverVentas.Name = "btnVoverVentas";
            this.btnVoverVentas.Size = new System.Drawing.Size(116, 23);
            this.btnVoverVentas.TabIndex = 18;
            this.btnVoverVentas.Text = "Volver a  ventas";
            this.btnVoverVentas.UseVisualStyleBackColor = true;
            this.btnVoverVentas.Click += new System.EventHandler(this.btnVoverVentas_Click);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 588);
            this.Controls.Add(this.btnVoverVentas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificarDefinitivoProv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.rtbProv);
            this.Controls.Add(this.txtTelProv);
            this.Controls.Add(this.txtEmailProv);
            this.Controls.Add(this.txtDireccionProv);
            this.Controls.Add(this.txtNombreProv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreProv;
        private System.Windows.Forms.TextBox txtDireccionProv;
        private System.Windows.Forms.TextBox txtEmailProv;
        private System.Windows.Forms.TextBox txtTelProv;
        private System.Windows.Forms.RichTextBox rtbProv;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModificarDefinitivoProv;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVoverVentas;
    }
}