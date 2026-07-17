<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerCompras
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
        Me.DGV_VerCompras = New System.Windows.Forms.DataGridView()
        Me.TB_RUC = New System.Windows.Forms.TextBox()
        Me.TB_Fecha = New System.Windows.Forms.TextBox()
        Me.TB_Montototal = New System.Windows.Forms.TextBox()
        Me.TB_Prefijo = New System.Windows.Forms.TextBox()
        Me.TB_NumeroFactura = New System.Windows.Forms.TextBox()
        Me.TB_Timbrado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Proveedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_IdCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGV_VerCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_VerCompras
        '
        Me.DGV_VerCompras.AllowUserToAddRows = False
        Me.DGV_VerCompras.AllowUserToDeleteRows = False
        Me.DGV_VerCompras.AllowUserToOrderColumns = True
        Me.DGV_VerCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VerCompras.Location = New System.Drawing.Point(12, 114)
        Me.DGV_VerCompras.Name = "DGV_VerCompras"
        Me.DGV_VerCompras.ReadOnly = True
        Me.DGV_VerCompras.Size = New System.Drawing.Size(776, 302)
        Me.DGV_VerCompras.TabIndex = 1
        '
        'TB_RUC
        '
        Me.TB_RUC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_RUC.Location = New System.Drawing.Point(12, 32)
        Me.TB_RUC.Name = "TB_RUC"
        Me.TB_RUC.Size = New System.Drawing.Size(183, 26)
        Me.TB_RUC.TabIndex = 2
        '
        'TB_Fecha
        '
        Me.TB_Fecha.Location = New System.Drawing.Point(620, 88)
        Me.TB_Fecha.Name = "TB_Fecha"
        Me.TB_Fecha.Size = New System.Drawing.Size(168, 20)
        Me.TB_Fecha.TabIndex = 7
        '
        'TB_Montototal
        '
        Me.TB_Montototal.Location = New System.Drawing.Point(688, 422)
        Me.TB_Montototal.Name = "TB_Montototal"
        Me.TB_Montototal.Size = New System.Drawing.Size(100, 20)
        Me.TB_Montototal.TabIndex = 9
        '
        'TB_Prefijo
        '
        Me.TB_Prefijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Prefijo.Location = New System.Drawing.Point(222, 32)
        Me.TB_Prefijo.Name = "TB_Prefijo"
        Me.TB_Prefijo.Size = New System.Drawing.Size(66, 22)
        Me.TB_Prefijo.TabIndex = 12
        '
        'TB_NumeroFactura
        '
        Me.TB_NumeroFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NumeroFactura.Location = New System.Drawing.Point(222, 82)
        Me.TB_NumeroFactura.Name = "TB_NumeroFactura"
        Me.TB_NumeroFactura.Size = New System.Drawing.Size(211, 22)
        Me.TB_NumeroFactura.TabIndex = 11
        '
        'TB_Timbrado
        '
        Me.TB_Timbrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Timbrado.Location = New System.Drawing.Point(294, 32)
        Me.TB_Timbrado.Name = "TB_Timbrado"
        Me.TB_Timbrado.Size = New System.Drawing.Size(240, 22)
        Me.TB_Timbrado.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(589, 422)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Monto total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(616, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "FECHA DE LA VENTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(218, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(316, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "TIMBRADO Y PREFIJO DE LA FACTURA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(218, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "NUMERO DE LA FACTURA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "RUC DEL PROVEEDOR"
        '
        'TB_Proveedor
        '
        Me.TB_Proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Proveedor.Location = New System.Drawing.Point(12, 82)
        Me.TB_Proveedor.Name = "TB_Proveedor"
        Me.TB_Proveedor.Size = New System.Drawing.Size(183, 26)
        Me.TB_Proveedor.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "NOMBRE DEL PROVEEDOR"
        '
        'TB_IdCompra
        '
        Me.TB_IdCompra.Location = New System.Drawing.Point(711, 32)
        Me.TB_IdCompra.Name = "TB_IdCompra"
        Me.TB_IdCompra.Size = New System.Drawing.Size(77, 20)
        Me.TB_IdCompra.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(608, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "NUMERO DE COMPRA"
        '
        'VerCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TB_Montototal)
        Me.Controls.Add(Me.TB_Proveedor)
        Me.Controls.Add(Me.TB_NumeroFactura)
        Me.Controls.Add(Me.TB_Fecha)
        Me.Controls.Add(Me.TB_IdCompra)
        Me.Controls.Add(Me.TB_Prefijo)
        Me.Controls.Add(Me.TB_Timbrado)
        Me.Controls.Add(Me.TB_RUC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_VerCompras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerCompras"
        CType(Me.DGV_VerCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_VerCompras As DataGridView
    Friend WithEvents TB_RUC As TextBox
    Friend WithEvents TB_Fecha As TextBox
    Friend WithEvents TB_Montototal As TextBox
    Friend WithEvents TB_Prefijo As TextBox
    Friend WithEvents TB_NumeroFactura As TextBox
    Friend WithEvents TB_Timbrado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_Proveedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_IdCompra As TextBox
    Friend WithEvents Label4 As Label
End Class
