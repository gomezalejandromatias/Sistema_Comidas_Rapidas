namespace Sistema_Comidas_Rapidas
{
    partial class frmVenta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combosdeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.lblFiltar = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.listViewCarrito = new System.Windows.Forms.ListView();
            this.lblProductos = new System.Windows.Forms.Label();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVentaExitosa = new System.Windows.Forms.Label();
            this.lblTotalCobro = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.statusStripFechaHora = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.statusStripFechaHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeProductosToolStripMenuItem,
            this.registrosDeVentasToolStripMenuItem,
            this.movimientosDeStockToolStripMenuItem,
            this.combosdeVentasToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1398, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargaDeProductosToolStripMenuItem
            // 
            this.cargaDeProductosToolStripMenuItem.Name = "cargaDeProductosToolStripMenuItem";
            this.cargaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.cargaDeProductosToolStripMenuItem.Text = "Productos";
            this.cargaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.cargaDeProductosToolStripMenuItem_Click);
            // 
            // registrosDeVentasToolStripMenuItem
            // 
            this.registrosDeVentasToolStripMenuItem.Name = "registrosDeVentasToolStripMenuItem";
            this.registrosDeVentasToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.registrosDeVentasToolStripMenuItem.Text = "Registros de ventas ";
            this.registrosDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registrosDeVentasToolStripMenuItem_Click);
            // 
            // movimientosDeStockToolStripMenuItem
            // 
            this.movimientosDeStockToolStripMenuItem.Name = "movimientosDeStockToolStripMenuItem";
            this.movimientosDeStockToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.movimientosDeStockToolStripMenuItem.Text = "Agregar Stock";
            this.movimientosDeStockToolStripMenuItem.Click += new System.EventHandler(this.movimientosDeStockToolStripMenuItem_Click);
            // 
            // combosdeVentasToolStripMenuItem
            // 
            this.combosdeVentasToolStripMenuItem.Name = "combosdeVentasToolStripMenuItem";
            this.combosdeVentasToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.combosdeVentasToolStripMenuItem.Text = "Combos y Promociones";
            this.combosdeVentasToolStripMenuItem.Click += new System.EventHandler(this.combosdeVentasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(254, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(311, 34);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Exitos con las Ventas";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(206, 115);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(278, 23);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvVenta
            // 
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenta.Location = new System.Drawing.Point(12, 144);
            this.dgvVenta.MultiSelect = false;
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(636, 383);
            this.dgvVenta.TabIndex = 3;
            this.dgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellClick);
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // lblFiltar
            // 
            this.lblFiltar.AutoSize = true;
            this.lblFiltar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltar.Location = new System.Drawing.Point(30, 115);
            this.lblFiltar.Name = "lblFiltar";
            this.lblFiltar.Size = new System.Drawing.Size(111, 15);
            this.lblFiltar.TabIndex = 4;
            this.lblFiltar.Text = "Filtro de Productos";
            // 
            // btnVender
            // 
            this.btnVender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.Location = new System.Drawing.Point(88, 533);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(140, 32);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Realizar Venta";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.Location = new System.Drawing.Point(274, 533);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(125, 32);
            this.btnCancelarVenta.TabIndex = 6;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // listViewCarrito
            // 
            this.listViewCarrito.HideSelection = false;
            this.listViewCarrito.Location = new System.Drawing.Point(928, 144);
            this.listViewCarrito.Name = "listViewCarrito";
            this.listViewCarrito.Size = new System.Drawing.Size(427, 315);
            this.listViewCarrito.TabIndex = 7;
            this.listViewCarrito.UseCompatibleStateImageBehavior = false;
            this.listViewCarrito.SelectedIndexChanged += new System.EventHandler(this.listViewCarrito_SelectedIndexChanged);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(1062, 117);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(179, 19);
            this.lblProductos.TabIndex = 8;
            this.lblProductos.Text = "Productos Seleccionados";
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(679, 156);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(180, 29);
            this.btnSeleccionarProducto.TabIndex = 9;
            this.btnSeleccionarProducto.Text = "Seleccionar Producto";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = true;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1182, 488);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // lblVentaExitosa
            // 
            this.lblVentaExitosa.AutoSize = true;
            this.lblVentaExitosa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaExitosa.Location = new System.Drawing.Point(1076, 46);
            this.lblVentaExitosa.Name = "lblVentaExitosa";
            this.lblVentaExitosa.Size = new System.Drawing.Size(50, 19);
            this.lblVentaExitosa.TabIndex = 11;
            this.lblVentaExitosa.Text = "label4";
            // 
            // lblTotalCobro
            // 
            this.lblTotalCobro.AutoSize = true;
            this.lblTotalCobro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCobro.Location = new System.Drawing.Point(1234, 484);
            this.lblTotalCobro.Name = "lblTotalCobro";
            this.lblTotalCobro.Size = new System.Drawing.Size(50, 19);
            this.lblTotalCobro.TabIndex = 12;
            this.lblTotalCobro.Text = "label4";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(468, 533);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 32);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Pantalla ";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Location = new System.Drawing.Point(679, 333);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(190, 23);
            this.comboBoxFormaPago.TabIndex = 14;
            this.comboBoxFormaPago.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaPago_SelectedIndexChanged);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago.Location = new System.Drawing.Point(708, 294);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(89, 15);
            this.lblFormaPago.TabIndex = 15;
            this.lblFormaPago.Text = "Forma De Pago";
            // 
            // statusStripFechaHora
            // 
            this.statusStripFechaHora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha,
            this.lblHora,
            this.lblVersion});
            this.statusStripFechaHora.Location = new System.Drawing.Point(0, 583);
            this.statusStripFechaHora.Name = "statusStripFechaHora";
            this.statusStripFechaHora.Size = new System.Drawing.Size(1398, 22);
            this.statusStripFechaHora.TabIndex = 16;
            this.statusStripFechaHora.Text = "statusStrip1";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 17);
            this.lblFecha.Text = "toolStripStatusLabel1";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(118, 17);
            this.lblHora.Text = "toolStripStatusLabel1";
            // 
            // lblVersion
            // 
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(118, 17);
            this.lblVersion.Text = "toolStripStatusLabel1";
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 605);
            this.Controls.Add(this.statusStripFechaHora);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.comboBoxFormaPago);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotalCobro);
            this.Controls.Add(this.lblVentaExitosa);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.listViewCarrito);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblFiltar);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVenta";
            this.Text = "Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.statusStripFechaHora.ResumeLayout(false);
            this.statusStripFechaHora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combosdeVentasToolStripMenuItem;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Label lblFiltar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.ListView listViewCarrito;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVentaExitosa;
        private System.Windows.Forms.Label lblTotalCobro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripFechaHora;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel lblVersion;
    }
}