namespace Sistema_Comidas_Rapidas
{
    partial class FrmAgregarStock
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
            this.dgvAgregarStock = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeleccionar = new System.Windows.Forms.Button();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.lblModificarStock = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtStockModificado = new System.Windows.Forms.TextBox();
            this.btnGuardarStock = new System.Windows.Forms.Button();
            this.lblStockGramos = new System.Windows.Forms.Label();
            this.lblStockActualGramos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantidadPaquetes = new System.Windows.Forms.TextBox();
            this.lblCantidadPaquetes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarStock)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgregarStock
            // 
            this.dgvAgregarStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAgregarStock.Location = new System.Drawing.Point(12, 48);
            this.dgvAgregarStock.MultiSelect = false;
            this.dgvAgregarStock.Name = "dgvAgregarStock";
            this.dgvAgregarStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgregarStock.Size = new System.Drawing.Size(667, 324);
            this.dgvAgregarStock.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 22);
            this.statusStrip1.TabIndex = 1;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(291, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(771, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Stock al producto";
            // 
            // txtSeleccionar
            // 
            this.txtSeleccionar.Location = new System.Drawing.Point(691, 119);
            this.txtSeleccionar.Name = "txtSeleccionar";
            this.txtSeleccionar.Size = new System.Drawing.Size(172, 23);
            this.txtSeleccionar.TabIndex = 4;
            this.txtSeleccionar.Text = "Seleccione el Producto";
            this.txtSeleccionar.UseVisualStyleBackColor = true;
            this.txtSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(726, 214);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(107, 13);
            this.lblNombreProducto.TabIndex = 5;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(733, 265);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(68, 13);
            this.lblStockActual.TabIndex = 6;
            this.lblStockActual.Text = "Stock Actual";
            // 
            // lblModificarStock
            // 
            this.lblModificarStock.AutoSize = true;
            this.lblModificarStock.Location = new System.Drawing.Point(726, 317);
            this.lblModificarStock.Name = "lblModificarStock";
            this.lblModificarStock.Size = new System.Drawing.Size(118, 13);
            this.lblModificarStock.TabIndex = 7;
            this.lblModificarStock.Text = "Unidades por Paquetes";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(859, 211);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(140, 20);
            this.txtNombreProd.TabIndex = 8;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(859, 262);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(140, 20);
            this.txtStockActual.TabIndex = 9;
            // 
            // txtStockModificado
            // 
            this.txtStockModificado.Location = new System.Drawing.Point(859, 314);
            this.txtStockModificado.Name = "txtStockModificado";
            this.txtStockModificado.Size = new System.Drawing.Size(140, 20);
            this.txtStockModificado.TabIndex = 10;
            // 
            // btnGuardarStock
            // 
            this.btnGuardarStock.Location = new System.Drawing.Point(1056, 467);
            this.btnGuardarStock.Name = "btnGuardarStock";
            this.btnGuardarStock.Size = new System.Drawing.Size(124, 23);
            this.btnGuardarStock.TabIndex = 11;
            this.btnGuardarStock.Text = "Guardar Stock";
            this.btnGuardarStock.UseVisualStyleBackColor = true;
            this.btnGuardarStock.Click += new System.EventHandler(this.btnGuardarStock_Click);
            // 
            // lblStockGramos
            // 
            this.lblStockGramos.AutoSize = true;
            this.lblStockGramos.Location = new System.Drawing.Point(726, 265);
            this.lblStockGramos.Name = "lblStockGramos";
            this.lblStockGramos.Size = new System.Drawing.Size(122, 13);
            this.lblStockGramos.TabIndex = 12;
            this.lblStockGramos.Text = "Stock Actual en Gramos";
            // 
            // lblStockActualGramos
            // 
            this.lblStockActualGramos.AutoSize = true;
            this.lblStockActualGramos.Location = new System.Drawing.Point(730, 317);
            this.lblStockActualGramos.Name = "lblStockActualGramos";
            this.lblStockActualGramos.Size = new System.Drawing.Size(115, 13);
            this.lblStockActualGramos.TabIndex = 13;
            this.lblStockActualGramos.Text = "Actualizar Stock (Kilos)";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 393);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantidadPaquetes
            // 
            this.txtCantidadPaquetes.Location = new System.Drawing.Point(859, 370);
            this.txtCantidadPaquetes.Name = "txtCantidadPaquetes";
            this.txtCantidadPaquetes.Size = new System.Drawing.Size(140, 20);
            this.txtCantidadPaquetes.TabIndex = 17;
            // 
            // lblCantidadPaquetes
            // 
            this.lblCantidadPaquetes.AutoSize = true;
            this.lblCantidadPaquetes.Location = new System.Drawing.Point(730, 377);
            this.lblCantidadPaquetes.Name = "lblCantidadPaquetes";
            this.lblCantidadPaquetes.Size = new System.Drawing.Size(123, 13);
            this.lblCantidadPaquetes.TabIndex = 18;
            this.lblCantidadPaquetes.Text = "Cantidades de Paquetes";
            // 
            // FrmAgregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 547);
            this.Controls.Add(this.lblCantidadPaquetes);
            this.Controls.Add(this.txtCantidadPaquetes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblStockActualGramos);
            this.Controls.Add(this.lblStockGramos);
            this.Controls.Add(this.btnGuardarStock);
            this.Controls.Add(this.txtStockModificado);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.lblModificarStock);
            this.Controls.Add(this.lblStockActual);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtSeleccionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvAgregarStock);
            this.Name = "FrmAgregarStock";
            this.Text = "Guardar Stock";
            this.Load += new System.EventHandler(this.FrmAgregarStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarStock)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgregarStock;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtSeleccionar;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Label lblModificarStock;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtStockModificado;
        private System.Windows.Forms.Button btnGuardarStock;
        private System.Windows.Forms.Label lblStockGramos;
        private System.Windows.Forms.Label lblStockActualGramos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCantidadPaquetes;
        private System.Windows.Forms.Label lblCantidadPaquetes;
    }
}