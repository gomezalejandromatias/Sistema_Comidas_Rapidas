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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNombreProv = new System.Windows.Forms.TextBox();
            this.txtDireccionProv = new System.Windows.Forms.TextBox();
            this.txtEmailProv = new System.Windows.Forms.TextBox();
            this.txtTelProv = new System.Windows.Forms.TextBox();
            this.rtbProv = new System.Windows.Forms.RichTextBox();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnModificarDefinitivoProv = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVoverVentas = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnCncelarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(424, 21);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(169, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Proveedores";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 116);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(187, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Proveedor/Empresa";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 172);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(54, 15);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 250);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 385);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(127, 15);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción (Opcional)";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 316);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direccion";
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.Location = new System.Drawing.Point(255, 116);
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.Size = new System.Drawing.Size(279, 23);
            this.txtNombreProv.TabIndex = 6;
            // 
            // txtDireccionProv
            // 
            this.txtDireccionProv.Location = new System.Drawing.Point(255, 313);
            this.txtDireccionProv.Name = "txtDireccionProv";
            this.txtDireccionProv.Size = new System.Drawing.Size(279, 23);
            this.txtDireccionProv.TabIndex = 7;
            // 
            // txtEmailProv
            // 
            this.txtEmailProv.Location = new System.Drawing.Point(255, 242);
            this.txtEmailProv.Name = "txtEmailProv";
            this.txtEmailProv.Size = new System.Drawing.Size(279, 23);
            this.txtEmailProv.TabIndex = 8;
            // 
            // txtTelProv
            // 
            this.txtTelProv.Location = new System.Drawing.Point(255, 164);
            this.txtTelProv.Name = "txtTelProv";
            this.txtTelProv.Size = new System.Drawing.Size(279, 23);
            this.txtTelProv.TabIndex = 9;
            // 
            // rtbProv
            // 
            this.rtbProv.Location = new System.Drawing.Point(255, 382);
            this.rtbProv.Name = "rtbProv";
            this.rtbProv.Size = new System.Drawing.Size(279, 163);
            this.rtbProv.TabIndex = 10;
            this.rtbProv.Text = "";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgProveedor.Location = new System.Drawing.Point(901, 116);
            this.dtgProveedor.MultiSelect = false;
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedor.Size = new System.Drawing.Size(509, 285);
            this.dtgProveedor.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(697, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Proveedor";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(697, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 32);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar Proveedor";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1235, 427);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 33);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar Proveedor ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(1028, 75);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(122, 19);
            this.lblSubtitulo.TabIndex = 15;
            this.lblSubtitulo.Text = "Sus Proveedores";
            // 
            // btnModificarDefinitivoProv
            // 
            this.btnModificarDefinitivoProv.Location = new System.Drawing.Point(697, 260);
            this.btnModificarDefinitivoProv.Name = "btnModificarDefinitivoProv";
            this.btnModificarDefinitivoProv.Size = new System.Drawing.Size(136, 41);
            this.btnModificarDefinitivoProv.TabIndex = 16;
            this.btnModificarDefinitivoProv.Text = "Guardar Cambios";
            this.btnModificarDefinitivoProv.UseVisualStyleBackColor = true;
            this.btnModificarDefinitivoProv.Click += new System.EventHandler(this.btnModificarDefinitivoProv_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(901, 427);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 31);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVoverVentas
            // 
            this.btnVoverVentas.Location = new System.Drawing.Point(28, 586);
            this.btnVoverVentas.Name = "btnVoverVentas";
            this.btnVoverVentas.Size = new System.Drawing.Size(175, 31);
            this.btnVoverVentas.TabIndex = 18;
            this.btnVoverVentas.Text = "Volver a  ventas";
            this.btnVoverVentas.UseVisualStyleBackColor = true;
            this.btnVoverVentas.Click += new System.EventHandler(this.btnVoverVentas_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 620);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1430, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnCncelarCambios
            // 
            this.btnCncelarCambios.Location = new System.Drawing.Point(697, 333);
            this.btnCncelarCambios.Name = "btnCncelarCambios";
            this.btnCncelarCambios.Size = new System.Drawing.Size(136, 36);
            this.btnCncelarCambios.TabIndex = 20;
            this.btnCncelarCambios.Text = "Cancelar Cambios";
            this.btnCncelarCambios.UseVisualStyleBackColor = true;
            this.btnCncelarCambios.Click += new System.EventHandler(this.btnCncelarCambios_Click);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 642);
            this.Controls.Add(this.btnCncelarCambios);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnVoverVentas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificarDefinitivoProv);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.rtbProv);
            this.Controls.Add(this.txtTelProv);
            this.Controls.Add(this.txtEmailProv);
            this.Controls.Add(this.txtDireccionProv);
            this.Controls.Add(this.txtNombreProv);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
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

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtNombreProv;
        private System.Windows.Forms.TextBox txtDireccionProv;
        private System.Windows.Forms.TextBox txtEmailProv;
        private System.Windows.Forms.TextBox txtTelProv;
        private System.Windows.Forms.RichTextBox rtbProv;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnModificarDefinitivoProv;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVoverVentas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnCncelarCambios;
    }
}