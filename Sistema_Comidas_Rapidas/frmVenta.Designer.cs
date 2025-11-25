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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.listViewCarrito = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVentaExitosa = new System.Windows.Forms.Label();
            this.lblTotalCobro = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeProductosToolStripMenuItem,
            this.registrosDeVentasToolStripMenuItem,
            this.movimientosDeStockToolStripMenuItem,
            this.combosdeVentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargaDeProductosToolStripMenuItem
            // 
            this.cargaDeProductosToolStripMenuItem.Name = "cargaDeProductosToolStripMenuItem";
            this.cargaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.cargaDeProductosToolStripMenuItem.Text = "Carga de Productos";
            this.cargaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.cargaDeProductosToolStripMenuItem_Click);
            // 
            // registrosDeVentasToolStripMenuItem
            // 
            this.registrosDeVentasToolStripMenuItem.Name = "registrosDeVentasToolStripMenuItem";
            this.registrosDeVentasToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.registrosDeVentasToolStripMenuItem.Text = "Registros de ventas ";
            // 
            // movimientosDeStockToolStripMenuItem
            // 
            this.movimientosDeStockToolStripMenuItem.Name = "movimientosDeStockToolStripMenuItem";
            this.movimientosDeStockToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.movimientosDeStockToolStripMenuItem.Text = "Movimientos de Stock";
            // 
            // combosdeVentasToolStripMenuItem
            // 
            this.combosdeVentasToolStripMenuItem.Name = "combosdeVentasToolStripMenuItem";
            this.combosdeVentasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.combosdeVentasToolStripMenuItem.Text = "Combos de ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exitos con las Ventas";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(206, 115);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(278, 21);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro de Productos";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(88, 533);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(140, 23);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Realizar Venta";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(307, 533);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(125, 23);
            this.btnCancelarVenta.TabIndex = 6;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // listViewCarrito
            // 
            this.listViewCarrito.HideSelection = false;
            this.listViewCarrito.Location = new System.Drawing.Point(924, 144);
            this.listViewCarrito.Name = "listViewCarrito";
            this.listViewCarrito.Size = new System.Drawing.Size(432, 279);
            this.listViewCarrito.TabIndex = 7;
            this.listViewCarrito.UseCompatibleStateImageBehavior = false;
            this.listViewCarrito.SelectedIndexChanged += new System.EventHandler(this.listViewCarrito_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1062, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Productos Seleccionados";
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLimpiar.Location = new System.Drawing.Point(498, 533);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Pantalla ";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 578);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotalCobro);
            this.Controls.Add(this.lblVentaExitosa);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSeleccionarProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewCarrito);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmVenta";
            this.Text = "Ventas";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combosdeVentasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.ListView listViewCarrito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVentaExitosa;
        private System.Windows.Forms.Label lblTotalCobro;
        private System.Windows.Forms.Button btnLimpiar;
    }
}