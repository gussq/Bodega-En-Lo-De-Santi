<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Click_Derecho_Inventario = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VERDETALLEDELINVENTARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Click_Derecho_Ventas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DETALLEVENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANULARVENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Click_Derecho_Compras = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VERDETALLEDECOMPRASToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TP_CargarCompras = New System.Windows.Forms.TabPage()
        Me.BTN_CargarCompras = New System.Windows.Forms.Button()
        Me.TB_TotalCompras = New System.Windows.Forms.TextBox()
        Me.DGV_Compras = New System.Windows.Forms.DataGridView()
        Me.Id_ProductoCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_RubroCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreRubroCompras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_FechaCompra = New System.Windows.Forms.TextBox()
        Me.TB_IdCabCompras = New System.Windows.Forms.TextBox()
        Me.TB_CodCompras = New System.Windows.Forms.TextBox()
        Me.TB_CantidadCompras = New System.Windows.Forms.TextBox()
        Me.TB_PrecioCompras = New System.Windows.Forms.TextBox()
        Me.TB_NombreProductoCompras = New System.Windows.Forms.TextBox()
        Me.BTN_CargarProductosCompras = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_PrefijoCompras = New System.Windows.Forms.TextBox()
        Me.TB_TimbradoCompras = New System.Windows.Forms.TextBox()
        Me.TB_NumFacturaCompras = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_NombreProveedor = New System.Windows.Forms.TextBox()
        Me.TB_RucProveedor = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TP_Compras = New System.Windows.Forms.TabPage()
        Me.DTP_FechaVerCompras = New System.Windows.Forms.DateTimePicker()
        Me.BTN_FiltroVerCompras = New System.Windows.Forms.Button()
        Me.TB_FiltroVerCompras = New System.Windows.Forms.TextBox()
        Me.CB_FiltroVerCompras = New System.Windows.Forms.ComboBox()
        Me.DGV_VerCompras = New System.Windows.Forms.DataGridView()
        Me.TP_CargarInventario = New System.Windows.Forms.TabPage()
        Me.TB_TotalCagarInventario = New System.Windows.Forms.TextBox()
        Me.BTN_BuscarCargarInventario = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BTN_EMITIR = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB_CodigoCargarInventario = New System.Windows.Forms.TextBox()
        Me.BTN_CargarProducto = New System.Windows.Forms.Button()
        Me.TB_CantidadCargarInventario = New System.Windows.Forms.TextBox()
        Me.TB_PrecioCargarInventario = New System.Windows.Forms.TextBox()
        Me.TB_NombreCargarInventario = New System.Windows.Forms.TextBox()
        Me.TB_AutorCargarInventario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DTP_FechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.DGV_CargaInventario = New System.Windows.Forms.DataGridView()
        Me.Id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP_Inventario = New System.Windows.Forms.TabPage()
        Me.DTP_FechaInventario = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_FiltrarAutorInventario = New System.Windows.Forms.TextBox()
        Me.BTN_FiltrarInventario = New System.Windows.Forms.Button()
        Me.DGV_VerificarInventario = New System.Windows.Forms.DataGridView()
        Me.TP_Productos = New System.Windows.Forms.TabPage()
        Me.CHKBOX_50R_Productos = New System.Windows.Forms.CheckBox()
        Me.TB_Filtro = New System.Windows.Forms.TextBox()
        Me.BTN_Filtrar = New System.Windows.Forms.Button()
        Me.BTN_GuardarCambios = New System.Windows.Forms.Button()
        Me.GB_Productos = New System.Windows.Forms.GroupBox()
        Me.BTN_GuardarProductos = New System.Windows.Forms.Button()
        Me.CB_Rubros = New System.Windows.Forms.ComboBox()
        Me.TB_Codigo = New System.Windows.Forms.TextBox()
        Me.TB_Precio = New System.Windows.Forms.TextBox()
        Me.TB_NombreProducto = New System.Windows.Forms.TextBox()
        Me.BTN_GuardarRubros = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGV_Rubros = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV_Productos = New System.Windows.Forms.DataGridView()
        Me.TP_VerVentas = New System.Windows.Forms.TabPage()
        Me.DTP_FechaVerVentas = New System.Windows.Forms.DateTimePicker()
        Me.BTN_FiltrarVerificarVentas = New System.Windows.Forms.Button()
        Me.DGV_VerVentas = New System.Windows.Forms.DataGridView()
        Me.TP_ApYCi = New System.Windows.Forms.TabPage()
        Me.TB_TotalVentasHoy = New System.Windows.Forms.TextBox()
        Me.TB_Pago = New System.Windows.Forms.TextBox()
        Me.BTN_EmitirVentaSencillo = New System.Windows.Forms.Button()
        Me.TB_IdProductoCierre = New System.Windows.Forms.TextBox()
        Me.TB_StockCierre = New System.Windows.Forms.TextBox()
        Me.TB_ClienteSencillo = New System.Windows.Forms.TextBox()
        Me.TB_CodigoSencillo = New System.Windows.Forms.TextBox()
        Me.TB_CantidadSencillo = New System.Windows.Forms.TextBox()
        Me.TB_PrecioSencillo = New System.Windows.Forms.TextBox()
        Me.TB_ProductoSencillo = New System.Windows.Forms.TextBox()
        Me.BTN_CargarProductoSencillo = New System.Windows.Forms.Button()
        Me.BTN_Gastos = New System.Windows.Forms.Button()
        Me.TB_AutorCierre = New System.Windows.Forms.TextBox()
        Me.TB_SencilloCierre = New System.Windows.Forms.TextBox()
        Me.TB_SencilloApertura = New System.Windows.Forms.TextBox()
        Me.BTN_VerArqueos = New System.Windows.Forms.Button()
        Me.BTN_GuardarSencillo = New System.Windows.Forms.Button()
        Me.BTN_GuardarCierre = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DGV_ProductosCierre = New System.Windows.Forms.DataGridView()
        Me.Id_Producto_Cierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo_Cierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto_Cierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock_cierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Cierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad_Cierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal_Cierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Menu = New System.Windows.Forms.TabControl()
        Me.REPORTES = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTN_DB = New System.Windows.Forms.Button()
        Me.Click_Derecho_Inventario.SuspendLayout()
        Me.Click_Derecho_Ventas.SuspendLayout()
        Me.Click_Derecho_Compras.SuspendLayout()
        Me.TP_CargarCompras.SuspendLayout()
        CType(Me.DGV_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TP_Compras.SuspendLayout()
        CType(Me.DGV_VerCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_CargarInventario.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_CargaInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_Inventario.SuspendLayout()
        CType(Me.DGV_VerificarInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_Productos.SuspendLayout()
        Me.GB_Productos.SuspendLayout()
        CType(Me.DGV_Rubros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_VerVentas.SuspendLayout()
        CType(Me.DGV_VerVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_ApYCi.SuspendLayout()
        CType(Me.DGV_ProductosCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(383, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BODEGA EN LO DE SANTI "
        '
        'Click_Derecho_Inventario
        '
        Me.Click_Derecho_Inventario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VERDETALLEDELINVENTARIOToolStripMenuItem})
        Me.Click_Derecho_Inventario.Name = "Click_Derecho"
        Me.Click_Derecho_Inventario.Size = New System.Drawing.Size(235, 26)
        '
        'VERDETALLEDELINVENTARIOToolStripMenuItem
        '
        Me.VERDETALLEDELINVENTARIOToolStripMenuItem.Name = "VERDETALLEDELINVENTARIOToolStripMenuItem"
        Me.VERDETALLEDELINVENTARIOToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.VERDETALLEDELINVENTARIOToolStripMenuItem.Text = "VER DETALLE DEL INVENTARIO"
        '
        'Timer1
        '
        '
        'Click_Derecho_Ventas
        '
        Me.Click_Derecho_Ventas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DETALLEVENTAToolStripMenuItem, Me.ANULARVENTAToolStripMenuItem})
        Me.Click_Derecho_Ventas.Name = "Click_Derecho"
        Me.Click_Derecho_Ventas.Size = New System.Drawing.Size(198, 48)
        '
        'DETALLEVENTAToolStripMenuItem
        '
        Me.DETALLEVENTAToolStripMenuItem.Name = "DETALLEVENTAToolStripMenuItem"
        Me.DETALLEVENTAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DETALLEVENTAToolStripMenuItem.Text = "VER DETALLE DE VENTA"
        '
        'ANULARVENTAToolStripMenuItem
        '
        Me.ANULARVENTAToolStripMenuItem.Name = "ANULARVENTAToolStripMenuItem"
        Me.ANULARVENTAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ANULARVENTAToolStripMenuItem.Text = "ANULAR VENTA"
        '
        'Click_Derecho_Compras
        '
        Me.Click_Derecho_Compras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VERDETALLEDECOMPRASToolStripMenuItem1})
        Me.Click_Derecho_Compras.Name = "Click_Derecho"
        Me.Click_Derecho_Compras.Size = New System.Drawing.Size(219, 26)
        '
        'VERDETALLEDECOMPRASToolStripMenuItem1
        '
        Me.VERDETALLEDECOMPRASToolStripMenuItem1.Name = "VERDETALLEDECOMPRASToolStripMenuItem1"
        Me.VERDETALLEDECOMPRASToolStripMenuItem1.Size = New System.Drawing.Size(218, 22)
        Me.VERDETALLEDECOMPRASToolStripMenuItem1.Text = "VER DETALLE DE COMPRAS"
        '
        'TP_CargarCompras
        '
        Me.TP_CargarCompras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TP_CargarCompras.Controls.Add(Me.BTN_CargarCompras)
        Me.TP_CargarCompras.Controls.Add(Me.TB_TotalCompras)
        Me.TP_CargarCompras.Controls.Add(Me.DGV_Compras)
        Me.TP_CargarCompras.Controls.Add(Me.TB_FechaCompra)
        Me.TP_CargarCompras.Controls.Add(Me.TB_IdCabCompras)
        Me.TP_CargarCompras.Controls.Add(Me.TB_CodCompras)
        Me.TP_CargarCompras.Controls.Add(Me.TB_CantidadCompras)
        Me.TP_CargarCompras.Controls.Add(Me.TB_PrecioCompras)
        Me.TP_CargarCompras.Controls.Add(Me.TB_NombreProductoCompras)
        Me.TP_CargarCompras.Controls.Add(Me.BTN_CargarProductosCompras)
        Me.TP_CargarCompras.Controls.Add(Me.Label35)
        Me.TP_CargarCompras.Controls.Add(Me.GroupBox2)
        Me.TP_CargarCompras.Controls.Add(Me.GroupBox1)
        Me.TP_CargarCompras.Controls.Add(Me.Label26)
        Me.TP_CargarCompras.Controls.Add(Me.Label27)
        Me.TP_CargarCompras.Controls.Add(Me.Label28)
        Me.TP_CargarCompras.Controls.Add(Me.Label29)
        Me.TP_CargarCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TP_CargarCompras.Location = New System.Drawing.Point(4, 22)
        Me.TP_CargarCompras.Name = "TP_CargarCompras"
        Me.TP_CargarCompras.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_CargarCompras.Size = New System.Drawing.Size(1313, 571)
        Me.TP_CargarCompras.TabIndex = 4
        Me.TP_CargarCompras.Text = "CAGAR COMPRAS"
        '
        'BTN_CargarCompras
        '
        Me.BTN_CargarCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CargarCompras.Location = New System.Drawing.Point(1094, 527)
        Me.BTN_CargarCompras.Name = "BTN_CargarCompras"
        Me.BTN_CargarCompras.Size = New System.Drawing.Size(204, 38)
        Me.BTN_CargarCompras.TabIndex = 10
        Me.BTN_CargarCompras.Text = "GUARDAR COMPRA"
        Me.BTN_CargarCompras.UseVisualStyleBackColor = True
        '
        'TB_TotalCompras
        '
        Me.TB_TotalCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TotalCompras.Location = New System.Drawing.Point(555, 527)
        Me.TB_TotalCompras.Name = "TB_TotalCompras"
        Me.TB_TotalCompras.Size = New System.Drawing.Size(113, 26)
        Me.TB_TotalCompras.TabIndex = 26
        '
        'DGV_Compras
        '
        Me.DGV_Compras.AllowUserToAddRows = False
        Me.DGV_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_ProductoCompras, Me.ProductoCompras, Me.CodigoCompras, Me.PrecioCompras, Me.CantidadCompras, Me.SubTotalCompras, Me.Id_RubroCompras, Me.NombreRubroCompras})
        Me.DGV_Compras.Location = New System.Drawing.Point(0, 159)
        Me.DGV_Compras.Name = "DGV_Compras"
        Me.DGV_Compras.ReadOnly = True
        Me.DGV_Compras.Size = New System.Drawing.Size(1298, 362)
        Me.DGV_Compras.TabIndex = 8
        '
        'Id_ProductoCompras
        '
        Me.Id_ProductoCompras.HeaderText = "Id Producto"
        Me.Id_ProductoCompras.Name = "Id_ProductoCompras"
        Me.Id_ProductoCompras.ReadOnly = True
        '
        'ProductoCompras
        '
        Me.ProductoCompras.HeaderText = "Producto"
        Me.ProductoCompras.Name = "ProductoCompras"
        Me.ProductoCompras.ReadOnly = True
        '
        'CodigoCompras
        '
        Me.CodigoCompras.HeaderText = "Codigo"
        Me.CodigoCompras.Name = "CodigoCompras"
        Me.CodigoCompras.ReadOnly = True
        '
        'PrecioCompras
        '
        Me.PrecioCompras.HeaderText = "Precio"
        Me.PrecioCompras.Name = "PrecioCompras"
        Me.PrecioCompras.ReadOnly = True
        '
        'CantidadCompras
        '
        Me.CantidadCompras.HeaderText = "Cantidad"
        Me.CantidadCompras.Name = "CantidadCompras"
        Me.CantidadCompras.ReadOnly = True
        '
        'SubTotalCompras
        '
        Me.SubTotalCompras.HeaderText = "SubTotal"
        Me.SubTotalCompras.Name = "SubTotalCompras"
        Me.SubTotalCompras.ReadOnly = True
        '
        'Id_RubroCompras
        '
        Me.Id_RubroCompras.HeaderText = "Rubro"
        Me.Id_RubroCompras.Name = "Id_RubroCompras"
        Me.Id_RubroCompras.ReadOnly = True
        '
        'NombreRubroCompras
        '
        Me.NombreRubroCompras.HeaderText = "Nombre Rubro"
        Me.NombreRubroCompras.Name = "NombreRubroCompras"
        Me.NombreRubroCompras.ReadOnly = True
        '
        'TB_FechaCompra
        '
        Me.TB_FechaCompra.Enabled = False
        Me.TB_FechaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FechaCompra.Location = New System.Drawing.Point(1121, 17)
        Me.TB_FechaCompra.Name = "TB_FechaCompra"
        Me.TB_FechaCompra.Size = New System.Drawing.Size(186, 22)
        Me.TB_FechaCompra.TabIndex = 25
        '
        'TB_IdCabCompras
        '
        Me.TB_IdCabCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_IdCabCompras.Location = New System.Drawing.Point(833, 127)
        Me.TB_IdCabCompras.Name = "TB_IdCabCompras"
        Me.TB_IdCabCompras.ShortcutsEnabled = False
        Me.TB_IdCabCompras.Size = New System.Drawing.Size(97, 26)
        Me.TB_IdCabCompras.TabIndex = 32
        Me.TB_IdCabCompras.TabStop = False
        Me.TB_IdCabCompras.Visible = False
        '
        'TB_CodCompras
        '
        Me.TB_CodCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CodCompras.Location = New System.Drawing.Point(9, 127)
        Me.TB_CodCompras.Name = "TB_CodCompras"
        Me.TB_CodCompras.Size = New System.Drawing.Size(97, 26)
        Me.TB_CodCompras.TabIndex = 5
        '
        'TB_CantidadCompras
        '
        Me.TB_CantidadCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CantidadCompras.Location = New System.Drawing.Point(565, 127)
        Me.TB_CantidadCompras.Name = "TB_CantidadCompras"
        Me.TB_CantidadCompras.Size = New System.Drawing.Size(51, 26)
        Me.TB_CantidadCompras.TabIndex = 8
        '
        'TB_PrecioCompras
        '
        Me.TB_PrecioCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PrecioCompras.Location = New System.Drawing.Point(410, 127)
        Me.TB_PrecioCompras.Name = "TB_PrecioCompras"
        Me.TB_PrecioCompras.Size = New System.Drawing.Size(149, 26)
        Me.TB_PrecioCompras.TabIndex = 7
        '
        'TB_NombreProductoCompras
        '
        Me.TB_NombreProductoCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NombreProductoCompras.Location = New System.Drawing.Point(112, 127)
        Me.TB_NombreProductoCompras.Name = "TB_NombreProductoCompras"
        Me.TB_NombreProductoCompras.Size = New System.Drawing.Size(292, 26)
        Me.TB_NombreProductoCompras.TabIndex = 6
        '
        'BTN_CargarProductosCompras
        '
        Me.BTN_CargarProductosCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CargarProductosCompras.Location = New System.Drawing.Point(622, 127)
        Me.BTN_CargarProductosCompras.Name = "BTN_CargarProductosCompras"
        Me.BTN_CargarProductosCompras.Size = New System.Drawing.Size(205, 26)
        Me.BTN_CargarProductosCompras.TabIndex = 9
        Me.BTN_CargarProductosCompras.Text = "CARGAR PRODUCTO"
        Me.BTN_CargarProductosCompras.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(428, 533)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(121, 16)
        Me.Label35.TabIndex = 27
        Me.Label35.Text = "TOTAL FACTURA:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TB_PrefijoCompras)
        Me.GroupBox2.Controls.Add(Me.TB_TimbradoCompras)
        Me.GroupBox2.Controls.Add(Me.TB_NumFacturaCompras)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(179, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 99)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FACTURA DE COMPRA"
        '
        'TB_PrefijoCompras
        '
        Me.TB_PrefijoCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PrefijoCompras.Location = New System.Drawing.Point(6, 31)
        Me.TB_PrefijoCompras.Name = "TB_PrefijoCompras"
        Me.TB_PrefijoCompras.Size = New System.Drawing.Size(55, 22)
        Me.TB_PrefijoCompras.TabIndex = 2
        '
        'TB_TimbradoCompras
        '
        Me.TB_TimbradoCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TimbradoCompras.Location = New System.Drawing.Point(67, 31)
        Me.TB_TimbradoCompras.Name = "TB_TimbradoCompras"
        Me.TB_TimbradoCompras.Size = New System.Drawing.Size(107, 22)
        Me.TB_TimbradoCompras.TabIndex = 3
        '
        'TB_NumFacturaCompras
        '
        Me.TB_NumFacturaCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NumFacturaCompras.Location = New System.Drawing.Point(6, 71)
        Me.TB_NumFacturaCompras.Name = "TB_NumFacturaCompras"
        Me.TB_NumFacturaCompras.Size = New System.Drawing.Size(168, 22)
        Me.TB_NumFacturaCompras.TabIndex = 4
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(126, 13)
        Me.Label34.TabIndex = 30
        Me.Label34.Text = "NUMERO DE FACTURA"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(64, 15)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 13)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "TIMBRADO"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(6, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 13)
        Me.Label32.TabIndex = 28
        Me.Label32.Text = "PREFIJO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_NombreProveedor)
        Me.GroupBox1.Controls.Add(Me.TB_RucProveedor)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 99)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PROVEEDOR"
        '
        'TB_NombreProveedor
        '
        Me.TB_NombreProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NombreProveedor.Location = New System.Drawing.Point(6, 72)
        Me.TB_NombreProveedor.Name = "TB_NombreProveedor"
        Me.TB_NombreProveedor.Size = New System.Drawing.Size(152, 22)
        Me.TB_NombreProveedor.TabIndex = 1
        '
        'TB_RucProveedor
        '
        Me.TB_RucProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_RucProveedor.Location = New System.Drawing.Point(6, 31)
        Me.TB_RucProveedor.Name = "TB_RucProveedor"
        Me.TB_RucProveedor.Size = New System.Drawing.Size(152, 22)
        Me.TB_RucProveedor.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(6, 56)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(128, 13)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "NOMBRE PROVEEDOR:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 13)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "RUC:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(552, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 16)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "CANTIDAD"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(407, 108)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 16)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "PRECIO:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(109, 108)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(178, 16)
        Me.Label28.TabIndex = 18
        Me.Label28.Text = "NOMBRE DEL PRODUCTO:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(9, 108)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(62, 16)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "CODIGO:"
        '
        'TP_Compras
        '
        Me.TP_Compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TP_Compras.Controls.Add(Me.DTP_FechaVerCompras)
        Me.TP_Compras.Controls.Add(Me.BTN_FiltroVerCompras)
        Me.TP_Compras.Controls.Add(Me.TB_FiltroVerCompras)
        Me.TP_Compras.Controls.Add(Me.CB_FiltroVerCompras)
        Me.TP_Compras.Controls.Add(Me.DGV_VerCompras)
        Me.TP_Compras.Location = New System.Drawing.Point(4, 22)
        Me.TP_Compras.Name = "TP_Compras"
        Me.TP_Compras.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Compras.Size = New System.Drawing.Size(1313, 571)
        Me.TP_Compras.TabIndex = 3
        Me.TP_Compras.Text = "COMPRAS"
        '
        'DTP_FechaVerCompras
        '
        Me.DTP_FechaVerCompras.Checked = False
        Me.DTP_FechaVerCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FechaVerCompras.Location = New System.Drawing.Point(408, 6)
        Me.DTP_FechaVerCompras.Name = "DTP_FechaVerCompras"
        Me.DTP_FechaVerCompras.ShowCheckBox = True
        Me.DTP_FechaVerCompras.Size = New System.Drawing.Size(134, 26)
        Me.DTP_FechaVerCompras.TabIndex = 4
        '
        'BTN_FiltroVerCompras
        '
        Me.BTN_FiltroVerCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FiltroVerCompras.Location = New System.Drawing.Point(548, 6)
        Me.BTN_FiltroVerCompras.Name = "BTN_FiltroVerCompras"
        Me.BTN_FiltroVerCompras.Size = New System.Drawing.Size(89, 30)
        Me.BTN_FiltroVerCompras.TabIndex = 3
        Me.BTN_FiltroVerCompras.Text = "FILTRAR"
        Me.BTN_FiltroVerCompras.UseVisualStyleBackColor = True
        '
        'TB_FiltroVerCompras
        '
        Me.TB_FiltroVerCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FiltroVerCompras.Location = New System.Drawing.Point(203, 6)
        Me.TB_FiltroVerCompras.Name = "TB_FiltroVerCompras"
        Me.TB_FiltroVerCompras.Size = New System.Drawing.Size(199, 26)
        Me.TB_FiltroVerCompras.TabIndex = 2
        '
        'CB_FiltroVerCompras
        '
        Me.CB_FiltroVerCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FiltroVerCompras.FormattingEnabled = True
        Me.CB_FiltroVerCompras.Location = New System.Drawing.Point(6, 6)
        Me.CB_FiltroVerCompras.Name = "CB_FiltroVerCompras"
        Me.CB_FiltroVerCompras.Size = New System.Drawing.Size(191, 28)
        Me.CB_FiltroVerCompras.TabIndex = 1
        '
        'DGV_VerCompras
        '
        Me.DGV_VerCompras.AllowUserToAddRows = False
        Me.DGV_VerCompras.AllowUserToDeleteRows = False
        Me.DGV_VerCompras.AllowUserToOrderColumns = True
        Me.DGV_VerCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VerCompras.Location = New System.Drawing.Point(6, 42)
        Me.DGV_VerCompras.Name = "DGV_VerCompras"
        Me.DGV_VerCompras.ReadOnly = True
        Me.DGV_VerCompras.Size = New System.Drawing.Size(1301, 523)
        Me.DGV_VerCompras.TabIndex = 0
        '
        'TP_CargarInventario
        '
        Me.TP_CargarInventario.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TP_CargarInventario.Controls.Add(Me.TB_TotalCagarInventario)
        Me.TP_CargarInventario.Controls.Add(Me.BTN_BuscarCargarInventario)
        Me.TP_CargarInventario.Controls.Add(Me.Label12)
        Me.TP_CargarInventario.Controls.Add(Me.BTN_EMITIR)
        Me.TP_CargarInventario.Controls.Add(Me.Panel1)
        Me.TP_CargarInventario.Controls.Add(Me.DGV_CargaInventario)
        Me.TP_CargarInventario.Location = New System.Drawing.Point(4, 22)
        Me.TP_CargarInventario.Name = "TP_CargarInventario"
        Me.TP_CargarInventario.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_CargarInventario.Size = New System.Drawing.Size(1313, 571)
        Me.TP_CargarInventario.TabIndex = 2
        Me.TP_CargarInventario.Text = "CARGAR INVENTARIOS"
        '
        'TB_TotalCagarInventario
        '
        Me.TB_TotalCagarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_TotalCagarInventario.Location = New System.Drawing.Point(546, 539)
        Me.TB_TotalCagarInventario.Name = "TB_TotalCagarInventario"
        Me.TB_TotalCagarInventario.Size = New System.Drawing.Size(155, 26)
        Me.TB_TotalCagarInventario.TabIndex = 12
        '
        'BTN_BuscarCargarInventario
        '
        Me.BTN_BuscarCargarInventario.Location = New System.Drawing.Point(6, 542)
        Me.BTN_BuscarCargarInventario.Name = "BTN_BuscarCargarInventario"
        Me.BTN_BuscarCargarInventario.Size = New System.Drawing.Size(168, 23)
        Me.BTN_BuscarCargarInventario.TabIndex = 14
        Me.BTN_BuscarCargarInventario.Text = "BUSCAR PRODUCTO"
        Me.BTN_BuscarCargarInventario.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(486, 545)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "TOTAL:"
        '
        'BTN_EMITIR
        '
        Me.BTN_EMITIR.Location = New System.Drawing.Point(1176, 542)
        Me.BTN_EMITIR.Name = "BTN_EMITIR"
        Me.BTN_EMITIR.Size = New System.Drawing.Size(131, 23)
        Me.BTN_EMITIR.TabIndex = 5
        Me.BTN_EMITIR.Text = "EMITIR INVENTARIO"
        Me.BTN_EMITIR.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.TB_CodigoCargarInventario)
        Me.Panel1.Controls.Add(Me.BTN_CargarProducto)
        Me.Panel1.Controls.Add(Me.TB_CantidadCargarInventario)
        Me.Panel1.Controls.Add(Me.TB_PrecioCargarInventario)
        Me.Panel1.Controls.Add(Me.TB_NombreCargarInventario)
        Me.Panel1.Controls.Add(Me.TB_AutorCargarInventario)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DTP_FechaEmision)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1307, 162)
        Me.Panel1.TabIndex = 3
        '
        'TB_CodigoCargarInventario
        '
        Me.TB_CodigoCargarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CodigoCargarInventario.Location = New System.Drawing.Point(3, 130)
        Me.TB_CodigoCargarInventario.Name = "TB_CodigoCargarInventario"
        Me.TB_CodigoCargarInventario.Size = New System.Drawing.Size(97, 26)
        Me.TB_CodigoCargarInventario.TabIndex = 4
        '
        'BTN_CargarProducto
        '
        Me.BTN_CargarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CargarProducto.Location = New System.Drawing.Point(616, 130)
        Me.BTN_CargarProducto.Name = "BTN_CargarProducto"
        Me.BTN_CargarProducto.Size = New System.Drawing.Size(205, 26)
        Me.BTN_CargarProducto.TabIndex = 3
        Me.BTN_CargarProducto.Text = "CARGAR PRODUCTO"
        Me.BTN_CargarProducto.UseVisualStyleBackColor = True
        '
        'TB_CantidadCargarInventario
        '
        Me.TB_CantidadCargarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CantidadCargarInventario.Location = New System.Drawing.Point(559, 130)
        Me.TB_CantidadCargarInventario.Name = "TB_CantidadCargarInventario"
        Me.TB_CantidadCargarInventario.Size = New System.Drawing.Size(51, 26)
        Me.TB_CantidadCargarInventario.TabIndex = 2
        '
        'TB_PrecioCargarInventario
        '
        Me.TB_PrecioCargarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PrecioCargarInventario.Location = New System.Drawing.Point(404, 130)
        Me.TB_PrecioCargarInventario.Name = "TB_PrecioCargarInventario"
        Me.TB_PrecioCargarInventario.Size = New System.Drawing.Size(149, 26)
        Me.TB_PrecioCargarInventario.TabIndex = 1
        '
        'TB_NombreCargarInventario
        '
        Me.TB_NombreCargarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NombreCargarInventario.Location = New System.Drawing.Point(106, 130)
        Me.TB_NombreCargarInventario.Name = "TB_NombreCargarInventario"
        Me.TB_NombreCargarInventario.Size = New System.Drawing.Size(292, 26)
        Me.TB_NombreCargarInventario.TabIndex = 0
        '
        'TB_AutorCargarInventario
        '
        Me.TB_AutorCargarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AutorCargarInventario.Location = New System.Drawing.Point(6, 31)
        Me.TB_AutorCargarInventario.Name = "TB_AutorCargarInventario"
        Me.TB_AutorCargarInventario.Size = New System.Drawing.Size(237, 26)
        Me.TB_AutorCargarInventario.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(546, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 16)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "CANTIDAD"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(401, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "PRECIO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(103, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "NOMBRE DEL PRODUCTO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "CODIGO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Autor:"
        '
        'DTP_FechaEmision
        '
        Me.DTP_FechaEmision.Enabled = False
        Me.DTP_FechaEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FechaEmision.Location = New System.Drawing.Point(967, 3)
        Me.DTP_FechaEmision.Name = "DTP_FechaEmision"
        Me.DTP_FechaEmision.Size = New System.Drawing.Size(337, 31)
        Me.DTP_FechaEmision.TabIndex = 6
        Me.DTP_FechaEmision.TabStop = False
        '
        'DGV_CargaInventario
        '
        Me.DGV_CargaInventario.AllowUserToAddRows = False
        Me.DGV_CargaInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CargaInventario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Producto, Me.Nombre_Producto, Me.Codigo, Me.Precio, Me.Cantidad, Me.SubTotal, Me.Rubro, Me.Nombre_Rubro})
        Me.DGV_CargaInventario.Location = New System.Drawing.Point(6, 171)
        Me.DGV_CargaInventario.Name = "DGV_CargaInventario"
        Me.DGV_CargaInventario.ReadOnly = True
        Me.DGV_CargaInventario.Size = New System.Drawing.Size(1301, 366)
        Me.DGV_CargaInventario.TabIndex = 2
        '
        'Id_Producto
        '
        Me.Id_Producto.HeaderText = "Id_Producto"
        Me.Id_Producto.Name = "Id_Producto"
        Me.Id_Producto.ReadOnly = True
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.HeaderText = "Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.ReadOnly = True
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'Rubro
        '
        Me.Rubro.HeaderText = "Rubro"
        Me.Rubro.Name = "Rubro"
        Me.Rubro.ReadOnly = True
        '
        'Nombre_Rubro
        '
        Me.Nombre_Rubro.HeaderText = "NombreRubro"
        Me.Nombre_Rubro.Name = "Nombre_Rubro"
        Me.Nombre_Rubro.ReadOnly = True
        '
        'TP_Inventario
        '
        Me.TP_Inventario.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TP_Inventario.Controls.Add(Me.DTP_FechaInventario)
        Me.TP_Inventario.Controls.Add(Me.Label14)
        Me.TP_Inventario.Controls.Add(Me.Label13)
        Me.TP_Inventario.Controls.Add(Me.TB_FiltrarAutorInventario)
        Me.TP_Inventario.Controls.Add(Me.BTN_FiltrarInventario)
        Me.TP_Inventario.Controls.Add(Me.DGV_VerificarInventario)
        Me.TP_Inventario.Location = New System.Drawing.Point(4, 22)
        Me.TP_Inventario.Name = "TP_Inventario"
        Me.TP_Inventario.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Inventario.Size = New System.Drawing.Size(1313, 571)
        Me.TP_Inventario.TabIndex = 1
        Me.TP_Inventario.Text = "INVENTARIOS"
        '
        'DTP_FechaInventario
        '
        Me.DTP_FechaInventario.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FechaInventario.Checked = False
        Me.DTP_FechaInventario.Cursor = System.Windows.Forms.Cursors.Default
        Me.DTP_FechaInventario.CustomFormat = ""
        Me.DTP_FechaInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FechaInventario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FechaInventario.Location = New System.Drawing.Point(256, 36)
        Me.DTP_FechaInventario.Name = "DTP_FechaInventario"
        Me.DTP_FechaInventario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTP_FechaInventario.ShowCheckBox = True
        Me.DTP_FechaInventario.Size = New System.Drawing.Size(250, 26)
        Me.DTP_FechaInventario.TabIndex = 5
        Me.DTP_FechaInventario.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(252, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Fecha:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Autor:"
        '
        'TB_FiltrarAutorInventario
        '
        Me.TB_FiltrarAutorInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FiltrarAutorInventario.Location = New System.Drawing.Point(6, 36)
        Me.TB_FiltrarAutorInventario.Name = "TB_FiltrarAutorInventario"
        Me.TB_FiltrarAutorInventario.Size = New System.Drawing.Size(244, 26)
        Me.TB_FiltrarAutorInventario.TabIndex = 0
        '
        'BTN_FiltrarInventario
        '
        Me.BTN_FiltrarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_FiltrarInventario.Location = New System.Drawing.Point(512, 13)
        Me.BTN_FiltrarInventario.Name = "BTN_FiltrarInventario"
        Me.BTN_FiltrarInventario.Size = New System.Drawing.Size(113, 49)
        Me.BTN_FiltrarInventario.TabIndex = 1
        Me.BTN_FiltrarInventario.Text = "Filtrar"
        Me.BTN_FiltrarInventario.UseVisualStyleBackColor = True
        '
        'DGV_VerificarInventario
        '
        Me.DGV_VerificarInventario.AllowUserToAddRows = False
        Me.DGV_VerificarInventario.AllowUserToDeleteRows = False
        Me.DGV_VerificarInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VerificarInventario.Location = New System.Drawing.Point(6, 68)
        Me.DGV_VerificarInventario.Name = "DGV_VerificarInventario"
        Me.DGV_VerificarInventario.ReadOnly = True
        Me.DGV_VerificarInventario.Size = New System.Drawing.Size(1301, 497)
        Me.DGV_VerificarInventario.StandardTab = True
        Me.DGV_VerificarInventario.TabIndex = 2
        '
        'TP_Productos
        '
        Me.TP_Productos.BackColor = System.Drawing.SystemColors.Info
        Me.TP_Productos.Controls.Add(Me.CHKBOX_50R_Productos)
        Me.TP_Productos.Controls.Add(Me.TB_Filtro)
        Me.TP_Productos.Controls.Add(Me.BTN_Filtrar)
        Me.TP_Productos.Controls.Add(Me.BTN_GuardarCambios)
        Me.TP_Productos.Controls.Add(Me.GB_Productos)
        Me.TP_Productos.Controls.Add(Me.DGV_Productos)
        Me.TP_Productos.Location = New System.Drawing.Point(4, 22)
        Me.TP_Productos.Name = "TP_Productos"
        Me.TP_Productos.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Productos.Size = New System.Drawing.Size(1313, 571)
        Me.TP_Productos.TabIndex = 0
        Me.TP_Productos.Text = "PRODUCTOS"
        '
        'CHKBOX_50R_Productos
        '
        Me.CHKBOX_50R_Productos.AutoSize = True
        Me.CHKBOX_50R_Productos.Checked = True
        Me.CHKBOX_50R_Productos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKBOX_50R_Productos.Location = New System.Drawing.Point(126, 536)
        Me.CHKBOX_50R_Productos.Name = "CHKBOX_50R_Productos"
        Me.CHKBOX_50R_Productos.Size = New System.Drawing.Size(160, 17)
        Me.CHKBOX_50R_Productos.TabIndex = 5
        Me.CHKBOX_50R_Productos.Text = "LIMITAR 50 RESULTADOS"
        Me.CHKBOX_50R_Productos.UseVisualStyleBackColor = True
        '
        'TB_Filtro
        '
        Me.TB_Filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Filtro.Location = New System.Drawing.Point(764, 9)
        Me.TB_Filtro.Name = "TB_Filtro"
        Me.TB_Filtro.Size = New System.Drawing.Size(283, 26)
        Me.TB_Filtro.TabIndex = 4
        '
        'BTN_Filtrar
        '
        Me.BTN_Filtrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Filtrar.Location = New System.Drawing.Point(1053, 6)
        Me.BTN_Filtrar.Name = "BTN_Filtrar"
        Me.BTN_Filtrar.Size = New System.Drawing.Size(88, 32)
        Me.BTN_Filtrar.TabIndex = 3
        Me.BTN_Filtrar.Text = "Filtrar"
        Me.BTN_Filtrar.UseVisualStyleBackColor = True
        '
        'BTN_GuardarCambios
        '
        Me.BTN_GuardarCambios.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_GuardarCambios.FlatAppearance.BorderSize = 0
        Me.BTN_GuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GuardarCambios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTN_GuardarCambios.Location = New System.Drawing.Point(636, 536)
        Me.BTN_GuardarCambios.Name = "BTN_GuardarCambios"
        Me.BTN_GuardarCambios.Size = New System.Drawing.Size(122, 32)
        Me.BTN_GuardarCambios.TabIndex = 2
        Me.BTN_GuardarCambios.Text = "GUARDAR CAMBIOS"
        Me.BTN_GuardarCambios.UseVisualStyleBackColor = False
        '
        'GB_Productos
        '
        Me.GB_Productos.Controls.Add(Me.BTN_GuardarProductos)
        Me.GB_Productos.Controls.Add(Me.CB_Rubros)
        Me.GB_Productos.Controls.Add(Me.TB_Codigo)
        Me.GB_Productos.Controls.Add(Me.TB_Precio)
        Me.GB_Productos.Controls.Add(Me.TB_NombreProducto)
        Me.GB_Productos.Controls.Add(Me.BTN_GuardarRubros)
        Me.GB_Productos.Controls.Add(Me.Label5)
        Me.GB_Productos.Controls.Add(Me.DGV_Rubros)
        Me.GB_Productos.Controls.Add(Me.Label4)
        Me.GB_Productos.Controls.Add(Me.Label1)
        Me.GB_Productos.Controls.Add(Me.Label6)
        Me.GB_Productos.Controls.Add(Me.Label3)
        Me.GB_Productos.Location = New System.Drawing.Point(764, 44)
        Me.GB_Productos.Name = "GB_Productos"
        Me.GB_Productos.Size = New System.Drawing.Size(380, 483)
        Me.GB_Productos.TabIndex = 1
        Me.GB_Productos.TabStop = False
        Me.GB_Productos.Text = "FORMULARIO DE PRODUCTOS"
        '
        'BTN_GuardarProductos
        '
        Me.BTN_GuardarProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_GuardarProductos.FlatAppearance.BorderSize = 0
        Me.BTN_GuardarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GuardarProductos.Location = New System.Drawing.Point(208, 146)
        Me.BTN_GuardarProductos.Name = "BTN_GuardarProductos"
        Me.BTN_GuardarProductos.Size = New System.Drawing.Size(163, 28)
        Me.BTN_GuardarProductos.TabIndex = 6
        Me.BTN_GuardarProductos.Text = "GUARDAR PRODUCTOS"
        Me.BTN_GuardarProductos.UseVisualStyleBackColor = False
        '
        'CB_Rubros
        '
        Me.CB_Rubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Rubros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Rubros.FormattingEnabled = True
        Me.CB_Rubros.Location = New System.Drawing.Point(6, 146)
        Me.CB_Rubros.Name = "CB_Rubros"
        Me.CB_Rubros.Size = New System.Drawing.Size(196, 28)
        Me.CB_Rubros.TabIndex = 5
        '
        'TB_Codigo
        '
        Me.TB_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Codigo.Location = New System.Drawing.Point(212, 94)
        Me.TB_Codigo.Name = "TB_Codigo"
        Me.TB_Codigo.Size = New System.Drawing.Size(159, 26)
        Me.TB_Codigo.TabIndex = 10
        '
        'TB_Precio
        '
        Me.TB_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Precio.Location = New System.Drawing.Point(6, 94)
        Me.TB_Precio.Name = "TB_Precio"
        Me.TB_Precio.Size = New System.Drawing.Size(196, 26)
        Me.TB_Precio.TabIndex = 2
        '
        'TB_NombreProducto
        '
        Me.TB_NombreProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NombreProducto.Location = New System.Drawing.Point(6, 42)
        Me.TB_NombreProducto.Name = "TB_NombreProducto"
        Me.TB_NombreProducto.Size = New System.Drawing.Size(365, 26)
        Me.TB_NombreProducto.TabIndex = 0
        '
        'BTN_GuardarRubros
        '
        Me.BTN_GuardarRubros.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_GuardarRubros.FlatAppearance.BorderSize = 0
        Me.BTN_GuardarRubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_GuardarRubros.Location = New System.Drawing.Point(208, 398)
        Me.BTN_GuardarRubros.Name = "BTN_GuardarRubros"
        Me.BTN_GuardarRubros.Size = New System.Drawing.Size(163, 28)
        Me.BTN_GuardarRubros.TabIndex = 9
        Me.BTN_GuardarRubros.Text = "GUARDAR RUBROS"
        Me.BTN_GuardarRubros.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RUBROS"
        '
        'DGV_Rubros
        '
        Me.DGV_Rubros.AllowUserToDeleteRows = False
        Me.DGV_Rubros.AllowUserToOrderColumns = True
        Me.DGV_Rubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Rubros.Location = New System.Drawing.Point(6, 200)
        Me.DGV_Rubros.Name = "DGV_Rubros"
        Me.DGV_Rubros.ReadOnly = True
        Me.DGV_Rubros.Size = New System.Drawing.Size(365, 192)
        Me.DGV_Rubros.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "RUBRO DEL PRODUCTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE DEL PRODUCTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CODIGO PRODUCTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PRECIO DEL PRODUCTO"
        '
        'DGV_Productos
        '
        Me.DGV_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Productos.Location = New System.Drawing.Point(126, 9)
        Me.DGV_Productos.Name = "DGV_Productos"
        Me.DGV_Productos.Size = New System.Drawing.Size(632, 521)
        Me.DGV_Productos.TabIndex = 0
        '
        'TP_VerVentas
        '
        Me.TP_VerVentas.BackColor = System.Drawing.SystemColors.Info
        Me.TP_VerVentas.Controls.Add(Me.DTP_FechaVerVentas)
        Me.TP_VerVentas.Controls.Add(Me.BTN_FiltrarVerificarVentas)
        Me.TP_VerVentas.Controls.Add(Me.DGV_VerVentas)
        Me.TP_VerVentas.Location = New System.Drawing.Point(4, 22)
        Me.TP_VerVentas.Name = "TP_VerVentas"
        Me.TP_VerVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_VerVentas.Size = New System.Drawing.Size(1313, 571)
        Me.TP_VerVentas.TabIndex = 6
        Me.TP_VerVentas.Text = "VER VENTAS"
        '
        'DTP_FechaVerVentas
        '
        Me.DTP_FechaVerVentas.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FechaVerVentas.Checked = False
        Me.DTP_FechaVerVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FechaVerVentas.Location = New System.Drawing.Point(6, 25)
        Me.DTP_FechaVerVentas.Name = "DTP_FechaVerVentas"
        Me.DTP_FechaVerVentas.ShowCheckBox = True
        Me.DTP_FechaVerVentas.Size = New System.Drawing.Size(321, 26)
        Me.DTP_FechaVerVentas.TabIndex = 19
        '
        'BTN_FiltrarVerificarVentas
        '
        Me.BTN_FiltrarVerificarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_FiltrarVerificarVentas.Location = New System.Drawing.Point(333, 15)
        Me.BTN_FiltrarVerificarVentas.Name = "BTN_FiltrarVerificarVentas"
        Me.BTN_FiltrarVerificarVentas.Size = New System.Drawing.Size(109, 36)
        Me.BTN_FiltrarVerificarVentas.TabIndex = 18
        Me.BTN_FiltrarVerificarVentas.Text = "FILTRAR"
        Me.BTN_FiltrarVerificarVentas.UseVisualStyleBackColor = True
        '
        'DGV_VerVentas
        '
        Me.DGV_VerVentas.AllowUserToAddRows = False
        Me.DGV_VerVentas.AllowUserToDeleteRows = False
        Me.DGV_VerVentas.AllowUserToOrderColumns = True
        Me.DGV_VerVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VerVentas.Location = New System.Drawing.Point(6, 57)
        Me.DGV_VerVentas.Name = "DGV_VerVentas"
        Me.DGV_VerVentas.ReadOnly = True
        Me.DGV_VerVentas.Size = New System.Drawing.Size(1301, 508)
        Me.DGV_VerVentas.TabIndex = 17
        '
        'TP_ApYCi
        '
        Me.TP_ApYCi.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP_ApYCi.Controls.Add(Me.TB_TotalVentasHoy)
        Me.TP_ApYCi.Controls.Add(Me.TB_Pago)
        Me.TP_ApYCi.Controls.Add(Me.BTN_EmitirVentaSencillo)
        Me.TP_ApYCi.Controls.Add(Me.TB_IdProductoCierre)
        Me.TP_ApYCi.Controls.Add(Me.TB_StockCierre)
        Me.TP_ApYCi.Controls.Add(Me.TB_ClienteSencillo)
        Me.TP_ApYCi.Controls.Add(Me.TB_CodigoSencillo)
        Me.TP_ApYCi.Controls.Add(Me.TB_CantidadSencillo)
        Me.TP_ApYCi.Controls.Add(Me.TB_PrecioSencillo)
        Me.TP_ApYCi.Controls.Add(Me.TB_ProductoSencillo)
        Me.TP_ApYCi.Controls.Add(Me.BTN_CargarProductoSencillo)
        Me.TP_ApYCi.Controls.Add(Me.BTN_Gastos)
        Me.TP_ApYCi.Controls.Add(Me.TB_AutorCierre)
        Me.TP_ApYCi.Controls.Add(Me.TB_SencilloCierre)
        Me.TP_ApYCi.Controls.Add(Me.TB_SencilloApertura)
        Me.TP_ApYCi.Controls.Add(Me.BTN_VerArqueos)
        Me.TP_ApYCi.Controls.Add(Me.BTN_GuardarSencillo)
        Me.TP_ApYCi.Controls.Add(Me.BTN_GuardarCierre)
        Me.TP_ApYCi.Controls.Add(Me.Label37)
        Me.TP_ApYCi.Controls.Add(Me.Label36)
        Me.TP_ApYCi.Controls.Add(Me.Label25)
        Me.TP_ApYCi.Controls.Add(Me.Label24)
        Me.TP_ApYCi.Controls.Add(Me.Label23)
        Me.TP_ApYCi.Controls.Add(Me.Label17)
        Me.TP_ApYCi.Controls.Add(Me.Label19)
        Me.TP_ApYCi.Controls.Add(Me.Label20)
        Me.TP_ApYCi.Controls.Add(Me.Label21)
        Me.TP_ApYCi.Controls.Add(Me.Label22)
        Me.TP_ApYCi.Controls.Add(Me.DGV_ProductosCierre)
        Me.TP_ApYCi.Controls.Add(Me.Label18)
        Me.TP_ApYCi.Controls.Add(Me.Label16)
        Me.TP_ApYCi.Controls.Add(Me.Label15)
        Me.TP_ApYCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TP_ApYCi.Location = New System.Drawing.Point(4, 22)
        Me.TP_ApYCi.Name = "TP_ApYCi"
        Me.TP_ApYCi.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_ApYCi.Size = New System.Drawing.Size(1313, 571)
        Me.TP_ApYCi.TabIndex = 5
        Me.TP_ApYCi.Text = "VENTAS Y CIERRE"
        '
        'TB_TotalVentasHoy
        '
        Me.TB_TotalVentasHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.5!)
        Me.TB_TotalVentasHoy.Location = New System.Drawing.Point(623, 525)
        Me.TB_TotalVentasHoy.Name = "TB_TotalVentasHoy"
        Me.TB_TotalVentasHoy.Size = New System.Drawing.Size(203, 38)
        Me.TB_TotalVentasHoy.TabIndex = 9
        Me.TB_TotalVentasHoy.TabStop = False
        '
        'TB_Pago
        '
        Me.TB_Pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.5!)
        Me.TB_Pago.Location = New System.Drawing.Point(889, 525)
        Me.TB_Pago.Name = "TB_Pago"
        Me.TB_Pago.Size = New System.Drawing.Size(203, 38)
        Me.TB_Pago.TabIndex = 36
        Me.TB_Pago.TabStop = False
        '
        'BTN_EmitirVentaSencillo
        '
        Me.BTN_EmitirVentaSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EmitirVentaSencillo.Location = New System.Drawing.Point(1104, 525)
        Me.BTN_EmitirVentaSencillo.Name = "BTN_EmitirVentaSencillo"
        Me.BTN_EmitirVentaSencillo.Size = New System.Drawing.Size(203, 40)
        Me.BTN_EmitirVentaSencillo.TabIndex = 8
        Me.BTN_EmitirVentaSencillo.Text = "EMITIR VENTA"
        Me.BTN_EmitirVentaSencillo.UseVisualStyleBackColor = True
        '
        'TB_IdProductoCierre
        '
        Me.TB_IdProductoCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_IdProductoCierre.Location = New System.Drawing.Point(1104, 126)
        Me.TB_IdProductoCierre.Name = "TB_IdProductoCierre"
        Me.TB_IdProductoCierre.ShortcutsEnabled = False
        Me.TB_IdProductoCierre.Size = New System.Drawing.Size(97, 26)
        Me.TB_IdProductoCierre.TabIndex = 31
        Me.TB_IdProductoCierre.TabStop = False
        Me.TB_IdProductoCierre.Visible = False
        '
        'TB_StockCierre
        '
        Me.TB_StockCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_StockCierre.Location = New System.Drawing.Point(775, 126)
        Me.TB_StockCierre.Name = "TB_StockCierre"
        Me.TB_StockCierre.Size = New System.Drawing.Size(51, 26)
        Me.TB_StockCierre.TabIndex = 29
        Me.TB_StockCierre.TabStop = False
        '
        'TB_ClienteSencillo
        '
        Me.TB_ClienteSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_ClienteSencillo.Location = New System.Drawing.Point(10, 126)
        Me.TB_ClienteSencillo.Name = "TB_ClienteSencillo"
        Me.TB_ClienteSencillo.Size = New System.Drawing.Size(203, 26)
        Me.TB_ClienteSencillo.TabIndex = 3
        '
        'TB_CodigoSencillo
        '
        Me.TB_CodigoSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CodigoSencillo.Location = New System.Drawing.Point(219, 126)
        Me.TB_CodigoSencillo.Name = "TB_CodigoSencillo"
        Me.TB_CodigoSencillo.Size = New System.Drawing.Size(97, 26)
        Me.TB_CodigoSencillo.TabIndex = 4
        '
        'TB_CantidadSencillo
        '
        Me.TB_CantidadSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CantidadSencillo.Location = New System.Drawing.Point(832, 126)
        Me.TB_CantidadSencillo.Name = "TB_CantidadSencillo"
        Me.TB_CantidadSencillo.Size = New System.Drawing.Size(51, 26)
        Me.TB_CantidadSencillo.TabIndex = 7
        Me.TB_CantidadSencillo.TabStop = False
        '
        'TB_PrecioSencillo
        '
        Me.TB_PrecioSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PrecioSencillo.Location = New System.Drawing.Point(620, 126)
        Me.TB_PrecioSencillo.Name = "TB_PrecioSencillo"
        Me.TB_PrecioSencillo.Size = New System.Drawing.Size(149, 26)
        Me.TB_PrecioSencillo.TabIndex = 6
        Me.TB_PrecioSencillo.TabStop = False
        '
        'TB_ProductoSencillo
        '
        Me.TB_ProductoSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_ProductoSencillo.Location = New System.Drawing.Point(322, 126)
        Me.TB_ProductoSencillo.Name = "TB_ProductoSencillo"
        Me.TB_ProductoSencillo.Size = New System.Drawing.Size(292, 26)
        Me.TB_ProductoSencillo.TabIndex = 5
        Me.TB_ProductoSencillo.TabStop = False
        '
        'BTN_CargarProductoSencillo
        '
        Me.BTN_CargarProductoSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CargarProductoSencillo.Location = New System.Drawing.Point(889, 126)
        Me.BTN_CargarProductoSencillo.Name = "BTN_CargarProductoSencillo"
        Me.BTN_CargarProductoSencillo.Size = New System.Drawing.Size(205, 26)
        Me.BTN_CargarProductoSencillo.TabIndex = 8
        Me.BTN_CargarProductoSencillo.Text = "CARGAR PRODUCTO"
        Me.BTN_CargarProductoSencillo.UseVisualStyleBackColor = True
        '
        'BTN_Gastos
        '
        Me.BTN_Gastos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTN_Gastos.FlatAppearance.BorderSize = 0
        Me.BTN_Gastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_Gastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Gastos.Location = New System.Drawing.Point(640, 30)
        Me.BTN_Gastos.Name = "BTN_Gastos"
        Me.BTN_Gastos.Size = New System.Drawing.Size(170, 31)
        Me.BTN_Gastos.TabIndex = 35
        Me.BTN_Gastos.TabStop = False
        Me.BTN_Gastos.Text = "CARGAR GASTOS"
        Me.BTN_Gastos.UseVisualStyleBackColor = False
        '
        'TB_AutorCierre
        '
        Me.TB_AutorCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AutorCierre.Location = New System.Drawing.Point(13, 32)
        Me.TB_AutorCierre.Name = "TB_AutorCierre"
        Me.TB_AutorCierre.Size = New System.Drawing.Size(203, 26)
        Me.TB_AutorCierre.TabIndex = 0
        '
        'TB_SencilloCierre
        '
        Me.TB_SencilloCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SencilloCierre.Location = New System.Drawing.Point(431, 30)
        Me.TB_SencilloCierre.Name = "TB_SencilloCierre"
        Me.TB_SencilloCierre.Size = New System.Drawing.Size(203, 31)
        Me.TB_SencilloCierre.TabIndex = 2
        '
        'TB_SencilloApertura
        '
        Me.TB_SencilloApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_SencilloApertura.Location = New System.Drawing.Point(222, 30)
        Me.TB_SencilloApertura.Name = "TB_SencilloApertura"
        Me.TB_SencilloApertura.Size = New System.Drawing.Size(203, 31)
        Me.TB_SencilloApertura.TabIndex = 1
        '
        'BTN_VerArqueos
        '
        Me.BTN_VerArqueos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_VerArqueos.FlatAppearance.BorderSize = 0
        Me.BTN_VerArqueos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_VerArqueos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VerArqueos.Location = New System.Drawing.Point(13, 69)
        Me.BTN_VerArqueos.Name = "BTN_VerArqueos"
        Me.BTN_VerArqueos.Size = New System.Drawing.Size(203, 31)
        Me.BTN_VerArqueos.TabIndex = 11
        Me.BTN_VerArqueos.Text = "VER CIERRES"
        Me.BTN_VerArqueos.UseVisualStyleBackColor = False
        '
        'BTN_GuardarSencillo
        '
        Me.BTN_GuardarSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GuardarSencillo.Location = New System.Drawing.Point(222, 67)
        Me.BTN_GuardarSencillo.Name = "BTN_GuardarSencillo"
        Me.BTN_GuardarSencillo.Size = New System.Drawing.Size(203, 33)
        Me.BTN_GuardarSencillo.TabIndex = 22
        Me.BTN_GuardarSencillo.Text = "GUARDAR SENCILLO"
        Me.BTN_GuardarSencillo.UseVisualStyleBackColor = True
        '
        'BTN_GuardarCierre
        '
        Me.BTN_GuardarCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_GuardarCierre.Location = New System.Drawing.Point(431, 67)
        Me.BTN_GuardarCierre.Name = "BTN_GuardarCierre"
        Me.BTN_GuardarCierre.Size = New System.Drawing.Size(203, 33)
        Me.BTN_GuardarCierre.TabIndex = 21
        Me.BTN_GuardarCierre.Text = "EMITIR CIERRE "
        Me.BTN_GuardarCierre.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(830, 536)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(55, 20)
        Me.Label37.TabIndex = 37
        Me.Label37.Text = "PAGO"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 8)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(167, 20)
        Me.Label36.TabIndex = 34
        Me.Label36.Text = "AUTOR DEL CIERRE"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(1213, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 24)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Label25"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(772, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 16)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "STOCK"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 108)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 15)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "CLIENTE"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(489, 537)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(131, 20)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "TOTAL VENTAS "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(830, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 16)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "CANTIDAD"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(617, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 16)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "PRECIO:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(319, 107)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(178, 16)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "NOMBRE DEL PRODUCTO:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(219, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 16)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "CODIGO:"
        '
        'DGV_ProductosCierre
        '
        Me.DGV_ProductosCierre.AllowUserToAddRows = False
        Me.DGV_ProductosCierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ProductosCierre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Producto_Cierre, Me.Codigo_Cierre, Me.Producto_Cierre, Me.Stock_cierre, Me.Precio_Cierre, Me.Cantidad_Cierre, Me.Subtotal_Cierre})
        Me.DGV_ProductosCierre.Location = New System.Drawing.Point(10, 162)
        Me.DGV_ProductosCierre.Name = "DGV_ProductosCierre"
        Me.DGV_ProductosCierre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_ProductosCierre.Size = New System.Drawing.Size(1297, 357)
        Me.DGV_ProductosCierre.TabIndex = 7
        '
        'Id_Producto_Cierre
        '
        Me.Id_Producto_Cierre.HeaderText = "Id_Producto"
        Me.Id_Producto_Cierre.Name = "Id_Producto_Cierre"
        Me.Id_Producto_Cierre.ReadOnly = True
        '
        'Codigo_Cierre
        '
        Me.Codigo_Cierre.HeaderText = "Codigo"
        Me.Codigo_Cierre.Name = "Codigo_Cierre"
        Me.Codigo_Cierre.ReadOnly = True
        '
        'Producto_Cierre
        '
        Me.Producto_Cierre.HeaderText = "Producto"
        Me.Producto_Cierre.Name = "Producto_Cierre"
        Me.Producto_Cierre.ReadOnly = True
        '
        'Stock_cierre
        '
        Me.Stock_cierre.HeaderText = "Stock"
        Me.Stock_cierre.Name = "Stock_cierre"
        Me.Stock_cierre.ReadOnly = True
        '
        'Precio_Cierre
        '
        Me.Precio_Cierre.HeaderText = "Precio"
        Me.Precio_Cierre.Name = "Precio_Cierre"
        Me.Precio_Cierre.ReadOnly = True
        '
        'Cantidad_Cierre
        '
        Me.Cantidad_Cierre.HeaderText = "Cantidad"
        Me.Cantidad_Cierre.Name = "Cantidad_Cierre"
        '
        'Subtotal_Cierre
        '
        Me.Subtotal_Cierre.HeaderText = "Subtotal"
        Me.Subtotal_Cierre.Name = "Subtotal_Cierre"
        Me.Subtotal_Cierre.ReadOnly = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1189, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 25)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Label18"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(427, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 20)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "SENCILLO DE CIERRE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(218, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(207, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "SENCILLO DE APERTURA"
        '
        'Menu
        '
        Me.Menu.Controls.Add(Me.TP_ApYCi)
        Me.Menu.Controls.Add(Me.TP_VerVentas)
        Me.Menu.Controls.Add(Me.TP_Productos)
        Me.Menu.Controls.Add(Me.TP_Inventario)
        Me.Menu.Controls.Add(Me.TP_CargarInventario)
        Me.Menu.Controls.Add(Me.TP_Compras)
        Me.Menu.Controls.Add(Me.TP_CargarCompras)
        Me.Menu.Controls.Add(Me.REPORTES)
        Me.Menu.Location = New System.Drawing.Point(12, 83)
        Me.Menu.Name = "Menu"
        Me.Menu.SelectedIndex = 0
        Me.Menu.Size = New System.Drawing.Size(1321, 597)
        Me.Menu.TabIndex = 3
        '
        'REPORTES
        '
        Me.REPORTES.Location = New System.Drawing.Point(4, 22)
        Me.REPORTES.Name = "REPORTES"
        Me.REPORTES.Padding = New System.Windows.Forms.Padding(3)
        Me.REPORTES.Size = New System.Drawing.Size(1313, 571)
        Me.REPORTES.TabIndex = 7
        Me.REPORTES.Text = "REPORTES"
        Me.REPORTES.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EnLoDeSanti.My.Resources.Resources.BODEGA
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(386, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 68)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BTN_DB
        '
        Me.BTN_DB.BackgroundImage = CType(resources.GetObject("BTN_DB.BackgroundImage"), System.Drawing.Image)
        Me.BTN_DB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_DB.FlatAppearance.BorderSize = 0
        Me.BTN_DB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DB.Location = New System.Drawing.Point(1281, 9)
        Me.BTN_DB.Name = "BTN_DB"
        Me.BTN_DB.Size = New System.Drawing.Size(52, 45)
        Me.BTN_DB.TabIndex = 2
        Me.BTN_DB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1345, 692)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Menu)
        Me.Controls.Add(Me.BTN_DB)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BODEGA EN LO DE SANTI"
        Me.Click_Derecho_Inventario.ResumeLayout(False)
        Me.Click_Derecho_Ventas.ResumeLayout(False)
        Me.Click_Derecho_Compras.ResumeLayout(False)
        Me.TP_CargarCompras.ResumeLayout(False)
        Me.TP_CargarCompras.PerformLayout()
        CType(Me.DGV_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TP_Compras.ResumeLayout(False)
        Me.TP_Compras.PerformLayout()
        CType(Me.DGV_VerCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_CargarInventario.ResumeLayout(False)
        Me.TP_CargarInventario.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_CargaInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_Inventario.ResumeLayout(False)
        Me.TP_Inventario.PerformLayout()
        CType(Me.DGV_VerificarInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_Productos.ResumeLayout(False)
        Me.TP_Productos.PerformLayout()
        Me.GB_Productos.ResumeLayout(False)
        Me.GB_Productos.PerformLayout()
        CType(Me.DGV_Rubros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_VerVentas.ResumeLayout(False)
        CType(Me.DGV_VerVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_ApYCi.ResumeLayout(False)
        Me.TP_ApYCi.PerformLayout()
        CType(Me.DGV_ProductosCierre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_DB As Button
    Friend WithEvents Click_Derecho_Inventario As ContextMenuStrip
    Friend WithEvents VERDETALLEDELINVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Click_Derecho_Ventas As ContextMenuStrip
    Friend WithEvents DETALLEVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ANULARVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Click_Derecho_Compras As ContextMenuStrip
    Friend WithEvents VERDETALLEDECOMPRASToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TP_CargarCompras As TabPage
    Friend WithEvents TB_IdCabCompras As TextBox
    Friend WithEvents TB_TotalCompras As TextBox
    Friend WithEvents TB_FechaCompra As TextBox
    Friend WithEvents TB_CodCompras As TextBox
    Friend WithEvents TB_CantidadCompras As TextBox
    Friend WithEvents TB_PrecioCompras As TextBox
    Friend WithEvents TB_NombreProductoCompras As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TB_TimbradoCompras As TextBox
    Friend WithEvents TB_NumFacturaCompras As TextBox
    Friend WithEvents TB_PrefijoCompras As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TB_NombreProveedor As TextBox
    Friend WithEvents TB_RucProveedor As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents BTN_CargarProductosCompras As Button
    Friend WithEvents BTN_CargarCompras As Button
    Friend WithEvents DGV_Compras As DataGridView
    Friend WithEvents Id_ProductoCompras As DataGridViewTextBoxColumn
    Friend WithEvents ProductoCompras As DataGridViewTextBoxColumn
    Friend WithEvents CodigoCompras As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompras As DataGridViewTextBoxColumn
    Friend WithEvents CantidadCompras As DataGridViewTextBoxColumn
    Friend WithEvents SubTotalCompras As DataGridViewTextBoxColumn
    Friend WithEvents Id_RubroCompras As DataGridViewTextBoxColumn
    Friend WithEvents NombreRubroCompras As DataGridViewTextBoxColumn
    Friend WithEvents TP_Compras As TabPage
    Friend WithEvents DTP_FechaVerCompras As DateTimePicker
    Friend WithEvents BTN_FiltroVerCompras As Button
    Friend WithEvents TB_FiltroVerCompras As TextBox
    Friend WithEvents CB_FiltroVerCompras As ComboBox
    Friend WithEvents DGV_VerCompras As DataGridView
    Friend WithEvents TP_CargarInventario As TabPage
    Friend WithEvents BTN_BuscarCargarInventario As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TB_TotalCagarInventario As TextBox
    Friend WithEvents BTN_EMITIR As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DTP_FechaEmision As DateTimePicker
    Friend WithEvents TB_AutorCargarInventario As TextBox
    Friend WithEvents TB_CodigoCargarInventario As TextBox
    Friend WithEvents BTN_CargarProducto As Button
    Friend WithEvents TB_CantidadCargarInventario As TextBox
    Friend WithEvents TB_PrecioCargarInventario As TextBox
    Friend WithEvents TB_NombreCargarInventario As TextBox
    Friend WithEvents DGV_CargaInventario As DataGridView
    Friend WithEvents Id_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents Rubro As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Rubro As DataGridViewTextBoxColumn
    Friend WithEvents TP_Inventario As TabPage
    Friend WithEvents DTP_FechaInventario As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TB_FiltrarAutorInventario As TextBox
    Friend WithEvents BTN_FiltrarInventario As Button
    Friend WithEvents DGV_VerificarInventario As DataGridView
    Friend WithEvents TP_Productos As TabPage
    Friend WithEvents TB_Filtro As TextBox
    Friend WithEvents BTN_Filtrar As Button
    Friend WithEvents BTN_GuardarCambios As Button
    Friend WithEvents GB_Productos As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Codigo As TextBox
    Friend WithEvents BTN_GuardarRubros As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DGV_Rubros As DataGridView
    Friend WithEvents BTN_GuardarProductos As Button
    Friend WithEvents CB_Rubros As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_Precio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_NombreProducto As TextBox
    Friend WithEvents DGV_Productos As DataGridView
    Friend WithEvents TP_VerVentas As TabPage
    Friend WithEvents DTP_FechaVerVentas As DateTimePicker
    Friend WithEvents BTN_FiltrarVerificarVentas As Button
    Friend WithEvents DGV_VerVentas As DataGridView
    Friend WithEvents TP_ApYCi As TabPage
    Friend WithEvents TB_IdProductoCierre As TextBox
    Friend WithEvents TB_StockCierre As TextBox
    Friend WithEvents TB_ClienteSencillo As TextBox
    Friend WithEvents TB_TotalVentasHoy As TextBox
    Friend WithEvents TB_CodigoSencillo As TextBox
    Friend WithEvents TB_CantidadSencillo As TextBox
    Friend WithEvents TB_PrecioSencillo As TextBox
    Friend WithEvents TB_ProductoSencillo As TextBox
    Friend WithEvents TB_SencilloCierre As TextBox
    Friend WithEvents TB_SencilloApertura As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents BTN_VerArqueos As Button
    Friend WithEvents BTN_EmitirVentaSencillo As Button
    Friend WithEvents BTN_GuardarSencillo As Button
    Friend WithEvents BTN_GuardarCierre As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents BTN_CargarProductoSencillo As Button
    Friend WithEvents DGV_ProductosCierre As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Menu As TabControl
    Friend WithEvents Label36 As Label
    Friend WithEvents TB_AutorCierre As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents BTN_Gastos As Button
    Friend WithEvents CHKBOX_50R_Productos As CheckBox
    Friend WithEvents Id_Producto_Cierre As DataGridViewTextBoxColumn
    Friend WithEvents Codigo_Cierre As DataGridViewTextBoxColumn
    Friend WithEvents Producto_Cierre As DataGridViewTextBoxColumn
    Friend WithEvents Stock_cierre As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Cierre As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad_Cierre As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal_Cierre As DataGridViewTextBoxColumn
    Friend WithEvents TB_Pago As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents REPORTES As TabPage
End Class
