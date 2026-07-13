<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerInventario
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
        Me.DGV_DetalleInventario = New System.Windows.Forms.DataGridView()
        Me.TB_AutorDetalleInventario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_NumCabInventario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_FechaEmisionDetalleInventario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGV_DetalleInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_DetalleInventario
        '
        Me.DGV_DetalleInventario.AllowUserToAddRows = False
        Me.DGV_DetalleInventario.AllowUserToDeleteRows = False
        Me.DGV_DetalleInventario.AllowUserToOrderColumns = True
        Me.DGV_DetalleInventario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_DetalleInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_DetalleInventario.Location = New System.Drawing.Point(12, 141)
        Me.DGV_DetalleInventario.Name = "DGV_DetalleInventario"
        Me.DGV_DetalleInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DGV_DetalleInventario.Size = New System.Drawing.Size(776, 297)
        Me.DGV_DetalleInventario.TabIndex = 0
        '
        'TB_AutorDetalleInventario
        '
        Me.TB_AutorDetalleInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AutorDetalleInventario.Location = New System.Drawing.Point(12, 32)
        Me.TB_AutorDetalleInventario.Name = "TB_AutorDetalleInventario"
        Me.TB_AutorDetalleInventario.Size = New System.Drawing.Size(218, 26)
        Me.TB_AutorDetalleInventario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Autor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero de inventario"
        '
        'TB_NumCabInventario
        '
        Me.TB_NumCabInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NumCabInventario.Location = New System.Drawing.Point(12, 89)
        Me.TB_NumCabInventario.Name = "TB_NumCabInventario"
        Me.TB_NumCabInventario.Size = New System.Drawing.Size(218, 26)
        Me.TB_NumCabInventario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(624, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha emision de Inventario"
        '
        'TB_FechaEmisionDetalleInventario
        '
        Me.TB_FechaEmisionDetalleInventario.Location = New System.Drawing.Point(624, 24)
        Me.TB_FechaEmisionDetalleInventario.Name = "TB_FechaEmisionDetalleInventario"
        Me.TB_FechaEmisionDetalleInventario.Size = New System.Drawing.Size(140, 20)
        Me.TB_FechaEmisionDetalleInventario.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Productos del inventario"
        '
        'VerInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TB_FechaEmisionDetalleInventario)
        Me.Controls.Add(Me.DGV_DetalleInventario)
        Me.Controls.Add(Me.TB_NumCabInventario)
        Me.Controls.Add(Me.TB_AutorDetalleInventario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "VerInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Inventario"
        CType(Me.DGV_DetalleInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_DetalleInventario As DataGridView
    Friend WithEvents TB_AutorDetalleInventario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_NumCabInventario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_FechaEmisionDetalleInventario As TextBox
    Friend WithEvents Label5 As Label
End Class
