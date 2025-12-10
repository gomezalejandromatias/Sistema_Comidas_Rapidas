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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombrePro = new System.Windows.Forms.Label();
            this.lblFechaIngre = new System.Windows.Forms.Label();
            this.lblStockUnidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dvbListaProducto = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtFechaIngreso = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProductosGuardados = new System.Windows.Forms.Label();
            this.txtBucarProducto = new System.Windows.Forms.TextBox();
            this.lblBuscarProdu = new System.Windows.Forms.Label();
            this.lblCantidadPaquete = new System.Windows.Forms.Label();
            this.txtCantidadPaquete = new System.Windows.Forms.TextBox();
            this.lblUnidadPaquete = new System.Windows.Forms.Label();
            this.txtUnidadPaquete = new System.Windows.Forms.TextBox();
            this.lblTotalPrecioProducto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblProvee = new System.Windows.Forms.Label();
            this.comboBoxaProveedor = new System.Windows.Forms.ComboBox();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnModicarDefinitivo = new System.Windows.Forms.Button();
            this.comboBoxElijeTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblTipoProdu = new System.Windows.Forms.Label();
            this.txtCantidadGramo = new System.Windows.Forms.TextBox();
            this.lblProductoporPeso = new System.Windows.Forms.Label();
            this.txtStockGramo = new System.Windows.Forms.TextBox();
            this.lblGramos = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dvbListaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(263, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema Negocio";
            // 
            // lblNombrePro
            // 
            this.lblNombrePro.AutoSize = true;
            this.lblNombrePro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePro.Location = new System.Drawing.Point(43, 157);
            this.lblNombrePro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePro.Name = "lblNombrePro";
            this.lblNombrePro.Size = new System.Drawing.Size(126, 15);
            this.lblNombrePro.TabIndex = 2;
            this.lblNombrePro.Text = "Nombre del Producto";
            // 
            // lblFechaIngre
            // 
            this.lblFechaIngre.AutoSize = true;
            this.lblFechaIngre.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngre.Location = new System.Drawing.Point(43, 204);
            this.lblFechaIngre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIngre.Name = "lblFechaIngre";
            this.lblFechaIngre.Size = new System.Drawing.Size(98, 15);
            this.lblFechaIngre.TabIndex = 3;
            this.lblFechaIngre.Text = "Fecha de Ingreso";
            // 
            // lblStockUnidad
            // 
            this.lblStockUnidad.AutoSize = true;
            this.lblStockUnidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockUnidad.Location = new System.Drawing.Point(43, 388);
            this.lblStockUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockUnidad.Name = "lblStockUnidad";
            this.lblStockUnidad.Size = new System.Drawing.Size(36, 15);
            this.lblStockUnidad.TabIndex = 4;
            this.lblStockUnidad.Text = "Stock";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(549, 186);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(139, 33);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dvbListaProducto
            // 
            this.dvbListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvbListaProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dvbListaProducto.Location = new System.Drawing.Point(745, 82);
            this.dvbListaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dvbListaProducto.Name = "dvbListaProducto";
            this.dvbListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvbListaProducto.Size = new System.Drawing.Size(1024, 472);
            this.dvbListaProducto.TabIndex = 6;
            this.dvbListaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvbListaProducto_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(46, 588);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 34);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCancelar
            // 
            this.txtCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancelar.Location = new System.Drawing.Point(219, 588);
            this.txtCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCancelar.Name = "txtCancelar";
            this.txtCancelar.Size = new System.Drawing.Size(107, 34);
            this.txtCancelar.TabIndex = 8;
            this.txtCancelar.Text = "Cancelar";
            this.txtCancelar.UseVisualStyleBackColor = true;
            this.txtCancelar.Click += new System.EventHandler(this.txtCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(549, 242);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(139, 36);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnidad.Location = new System.Drawing.Point(43, 502);
            this.lblPrecioUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(104, 15);
            this.lblPrecioUnidad.TabIndex = 11;
            this.lblPrecioUnidad.Text = "Precio Por Unidad";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(319, 146);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(179, 26);
            this.txtNombreProducto.TabIndex = 13;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaIngreso.Location = new System.Drawing.Point(319, 192);
            this.txtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(179, 27);
            this.txtFechaIngreso.TabIndex = 14;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(319, 388);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(179, 26);
            this.txtStock.TabIndex = 15;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnidad.Location = new System.Drawing.Point(319, 492);
            this.txtPrecioUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(179, 26);
            this.txtPrecioUnidad.TabIndex = 16;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.Location = new System.Drawing.Point(43, 450);
            this.Categoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(59, 15);
            this.Categoria.TabIndex = 17;
            this.Categoria.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(319, 439);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(179, 26);
            this.txtCategoria.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 499);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "$";
            // 
            // lblProductosGuardados
            // 
            this.lblProductosGuardados.AutoSize = true;
            this.lblProductosGuardados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosGuardados.Location = new System.Drawing.Point(929, 9);
            this.lblProductosGuardados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductosGuardados.Name = "lblProductosGuardados";
            this.lblProductosGuardados.Size = new System.Drawing.Size(249, 19);
            this.lblProductosGuardados.TabIndex = 20;
            this.lblProductosGuardados.Text = "Productos Guardados en el sistema";
            // 
            // txtBucarProducto
            // 
            this.txtBucarProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBucarProducto.Location = new System.Drawing.Point(895, 45);
            this.txtBucarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBucarProducto.Name = "txtBucarProducto";
            this.txtBucarProducto.Size = new System.Drawing.Size(197, 27);
            this.txtBucarProducto.TabIndex = 21;
            this.txtBucarProducto.TextChanged += new System.EventHandler(this.txtBucarProducto_TextChanged);
            // 
            // lblBuscarProdu
            // 
            this.lblBuscarProdu.AutoSize = true;
            this.lblBuscarProdu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProdu.Location = new System.Drawing.Point(742, 48);
            this.lblBuscarProdu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarProdu.Name = "lblBuscarProdu";
            this.lblBuscarProdu.Size = new System.Drawing.Size(128, 19);
            this.lblBuscarProdu.TabIndex = 22;
            this.lblBuscarProdu.Text = "Buscar Productos";
            // 
            // lblCantidadPaquete
            // 
            this.lblCantidadPaquete.AutoSize = true;
            this.lblCantidadPaquete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPaquete.Location = new System.Drawing.Point(43, 352);
            this.lblCantidadPaquete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPaquete.Name = "lblCantidadPaquete";
            this.lblCantidadPaquete.Size = new System.Drawing.Size(122, 15);
            this.lblCantidadPaquete.TabIndex = 23;
            this.lblCantidadPaquete.Text = "Canidad De Paquetes";
            // 
            // txtCantidadPaquete
            // 
            this.txtCantidadPaquete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadPaquete.Location = new System.Drawing.Point(319, 340);
            this.txtCantidadPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadPaquete.Name = "txtCantidadPaquete";
            this.txtCantidadPaquete.Size = new System.Drawing.Size(179, 27);
            this.txtCantidadPaquete.TabIndex = 24;
            this.txtCantidadPaquete.TextChanged += new System.EventHandler(this.txtCantidadPaquete_TextChanged);
            // 
            // lblUnidadPaquete
            // 
            this.lblUnidadPaquete.AutoSize = true;
            this.lblUnidadPaquete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadPaquete.Location = new System.Drawing.Point(43, 305);
            this.lblUnidadPaquete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadPaquete.Name = "lblUnidadPaquete";
            this.lblUnidadPaquete.Size = new System.Drawing.Size(133, 15);
            this.lblUnidadPaquete.TabIndex = 25;
            this.lblUnidadPaquete.Text = "Unidades Por Paquetes";
            // 
            // txtUnidadPaquete
            // 
            this.txtUnidadPaquete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidadPaquete.Location = new System.Drawing.Point(319, 299);
            this.txtUnidadPaquete.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnidadPaquete.Name = "txtUnidadPaquete";
            this.txtUnidadPaquete.Size = new System.Drawing.Size(179, 27);
            this.txtUnidadPaquete.TabIndex = 26;
            this.txtUnidadPaquete.TextChanged += new System.EventHandler(this.txtUnidadPaquete_TextChanged);
            // 
            // lblTotalPrecioProducto
            // 
            this.lblTotalPrecioProducto.AutoSize = true;
            this.lblTotalPrecioProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrecioProducto.Location = new System.Drawing.Point(947, 603);
            this.lblTotalPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrecioProducto.Name = "lblTotalPrecioProducto";
            this.lblTotalPrecioProducto.Size = new System.Drawing.Size(58, 19);
            this.lblTotalPrecioProducto.TabIndex = 27;
            this.lblTotalPrecioProducto.Text = "label12";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(664, 599);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 19);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total";
            // 
            // lblProvee
            // 
            this.lblProvee.AutoSize = true;
            this.lblProvee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvee.Location = new System.Drawing.Point(43, 105);
            this.lblProvee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvee.Name = "lblProvee";
            this.lblProvee.Size = new System.Drawing.Size(65, 15);
            this.lblProvee.TabIndex = 29;
            this.lblProvee.Text = "Proveedor";
            this.lblProvee.Click += new System.EventHandler(this.label13_Click);
            // 
            // comboBoxaProveedor
            // 
            this.comboBoxaProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxaProveedor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxaProveedor.FormattingEnabled = true;
            this.comboBoxaProveedor.Location = new System.Drawing.Point(319, 97);
            this.comboBoxaProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxaProveedor.Name = "comboBoxaProveedor";
            this.comboBoxaProveedor.Size = new System.Drawing.Size(179, 23);
            this.comboBoxaProveedor.TabIndex = 31;
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Location = new System.Drawing.Point(549, 286);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(139, 34);
            this.btnModificarProducto.TabIndex = 32;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnModicarDefinitivo
            // 
            this.btnModicarDefinitivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModicarDefinitivo.Location = new System.Drawing.Point(549, 340);
            this.btnModicarDefinitivo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModicarDefinitivo.Name = "btnModicarDefinitivo";
            this.btnModicarDefinitivo.Size = new System.Drawing.Size(139, 27);
            this.btnModicarDefinitivo.TabIndex = 33;
            this.btnModicarDefinitivo.Text = "Guardar Cambios";
            this.btnModicarDefinitivo.UseVisualStyleBackColor = true;
            this.btnModicarDefinitivo.Click += new System.EventHandler(this.btnModicarDefinitivo_Click);
            // 
            // comboBoxElijeTipoProducto
            // 
            this.comboBoxElijeTipoProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxElijeTipoProducto.FormattingEnabled = true;
            this.comboBoxElijeTipoProducto.Location = new System.Drawing.Point(319, 250);
            this.comboBoxElijeTipoProducto.Name = "comboBoxElijeTipoProducto";
            this.comboBoxElijeTipoProducto.Size = new System.Drawing.Size(179, 24);
            this.comboBoxElijeTipoProducto.TabIndex = 34;
            this.comboBoxElijeTipoProducto.SelectedIndexChanged += new System.EventHandler(this.comboBoxElijeTipoProducto_SelectedIndexChanged);
            // 
            // lblTipoProdu
            // 
            this.lblTipoProdu.AutoSize = true;
            this.lblTipoProdu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProdu.Location = new System.Drawing.Point(43, 254);
            this.lblTipoProdu.Name = "lblTipoProdu";
            this.lblTipoProdu.Size = new System.Drawing.Size(100, 15);
            this.lblTipoProdu.TabIndex = 35;
            this.lblTipoProdu.Text = "Tipo de Producto";
            // 
            // txtCantidadGramo
            // 
            this.txtCantidadGramo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadGramo.Location = new System.Drawing.Point(319, 303);
            this.txtCantidadGramo.Name = "txtCantidadGramo";
            this.txtCantidadGramo.Size = new System.Drawing.Size(179, 23);
            this.txtCantidadGramo.TabIndex = 38;
            this.txtCantidadGramo.TextChanged += new System.EventHandler(this.txtCantidadGramo_TextChanged);
            // 
            // lblProductoporPeso
            // 
            this.lblProductoporPeso.AutoSize = true;
            this.lblProductoporPeso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoporPeso.Location = new System.Drawing.Point(43, 305);
            this.lblProductoporPeso.Name = "lblProductoporPeso";
            this.lblProductoporPeso.Size = new System.Drawing.Size(108, 15);
            this.lblProductoporPeso.TabIndex = 41;
            this.lblProductoporPeso.Text = "Producto por Peso";
            this.lblProductoporPeso.Click += new System.EventHandler(this.lblProductoporPeso_Click);
            // 
            // txtStockGramo
            // 
            this.txtStockGramo.AcceptsReturn = true;
            this.txtStockGramo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockGramo.Location = new System.Drawing.Point(319, 391);
            this.txtStockGramo.Name = "txtStockGramo";
            this.txtStockGramo.Size = new System.Drawing.Size(179, 23);
            this.txtStockGramo.TabIndex = 42;
            // 
            // lblGramos
            // 
            this.lblGramos.AutoSize = true;
            this.lblGramos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramos.Location = new System.Drawing.Point(45, 391);
            this.lblGramos.Name = "lblGramos";
            this.lblGramos.Size = new System.Drawing.Size(106, 15);
            this.lblGramos.TabIndex = 43;
            this.lblGramos.Text = "Stock (en Gramos)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 1039);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1924, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblGramos);
            this.Controls.Add(this.txtStockGramo);
            this.Controls.Add(this.lblProductoporPeso);
            this.Controls.Add(this.txtCantidadGramo);
            this.Controls.Add(this.lblTipoProdu);
            this.Controls.Add(this.comboBoxElijeTipoProducto);
            this.Controls.Add(this.btnModicarDefinitivo);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.comboBoxaProveedor);
            this.Controls.Add(this.lblProvee);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalPrecioProducto);
            this.Controls.Add(this.txtUnidadPaquete);
            this.Controls.Add(this.lblUnidadPaquete);
            this.Controls.Add(this.txtCantidadPaquete);
            this.Controls.Add(this.lblCantidadPaquete);
            this.Controls.Add(this.lblBuscarProdu);
            this.Controls.Add(this.txtBucarProducto);
            this.Controls.Add(this.lblProductosGuardados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtFechaIngreso);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblPrecioUnidad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCancelar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dvbListaProducto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblStockUnidad);
            this.Controls.Add(this.lblFechaIngre);
            this.Controls.Add(this.lblNombrePro);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.Name = "Form1";
            this.Text = "Agregar Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvbListaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombrePro;
        private System.Windows.Forms.Label lblFechaIngre;
        private System.Windows.Forms.Label lblStockUnidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dvbListaProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button txtCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtFechaIngreso;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProductosGuardados;
        private System.Windows.Forms.TextBox txtBucarProducto;
        private System.Windows.Forms.Label lblBuscarProdu;
        private System.Windows.Forms.Label lblCantidadPaquete;
        private System.Windows.Forms.TextBox txtCantidadPaquete;
        private System.Windows.Forms.Label lblUnidadPaquete;
        private System.Windows.Forms.TextBox txtUnidadPaquete;
        private System.Windows.Forms.Label lblTotalPrecioProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblProvee;
        private System.Windows.Forms.ComboBox comboBoxaProveedor;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnModicarDefinitivo;
        private System.Windows.Forms.ComboBox comboBoxElijeTipoProducto;
        private System.Windows.Forms.Label lblTipoProdu;
        private System.Windows.Forms.TextBox txtCantidadGramo;
        private System.Windows.Forms.Label lblProductoporPeso;
        private System.Windows.Forms.TextBox txtStockGramo;
        private System.Windows.Forms.Label lblGramos;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

