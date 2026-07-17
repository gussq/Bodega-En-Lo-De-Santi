<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV_BuscarProductos = New System.Windows.Forms.DataGridView()
        Me.BTN_Seleccionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_BuscarProducto = New System.Windows.Forms.TextBox()
        CType(Me.DGV_BuscarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_BuscarProductos
        '
        Me.DGV_BuscarProductos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_BuscarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BuscarProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGV_BuscarProductos.Location = New System.Drawing.Point(0, 0)
        Me.DGV_BuscarProductos.Name = "DGV_BuscarProductos"
        Me.DGV_BuscarProductos.Size = New System.Drawing.Size(800, 403)
        Me.DGV_BuscarProductos.TabIndex = 0
        Me.DGV_BuscarProductos.TabStop = False
        '
        'BTN_Seleccionar
        '
        Me.BTN_Seleccionar.Location = New System.Drawing.Point(689, 409)
        Me.BTN_Seleccionar.Name = "BTN_Seleccionar"
        Me.BTN_Seleccionar.Size = New System.Drawing.Size(99, 36)
        Me.BTN_Seleccionar.TabIndex = 1
        Me.BTN_Seleccionar.Text = "SELECCIONAR"
        Me.BTN_Seleccionar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre del producto"
        '
        'TB_BuscarProducto
        '
        Me.TB_BuscarProducto.Location = New System.Drawing.Point(9, 425)
        Me.TB_BuscarProducto.Name = "TB_BuscarProducto"
        Me.TB_BuscarProducto.Size = New System.Drawing.Size(265, 20)
        Me.TB_BuscarProducto.TabIndex = 0
        '
        'BuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TB_BuscarProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Seleccionar)
        Me.Controls.Add(Me.DGV_BuscarProductos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscarProducto"
        Me.Text = "BuscarProducto"
        CType(Me.DGV_BuscarProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_BuscarProductos As DataGridView
    Friend WithEvents BTN_Seleccionar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_BuscarProducto As TextBox
End Class
