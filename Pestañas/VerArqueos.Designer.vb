<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerArqueos
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
        Me.DGV_Cierre = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TB_Autor = New System.Windows.Forms.TextBox()
        Me.DTP_Filtro = New System.Windows.Forms.DateTimePicker()
        Me.BTN_Filtrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_Cierre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Cierre
        '
        Me.DGV_Cierre.AllowUserToAddRows = False
        Me.DGV_Cierre.AllowUserToDeleteRows = False
        Me.DGV_Cierre.AllowUserToOrderColumns = True
        Me.DGV_Cierre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_Cierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Cierre.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV_Cierre.Location = New System.Drawing.Point(0, 60)
        Me.DGV_Cierre.Name = "DGV_Cierre"
        Me.DGV_Cierre.ReadOnly = True
        Me.DGV_Cierre.Size = New System.Drawing.Size(913, 390)
        Me.DGV_Cierre.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TB_Autor
        '
        Me.TB_Autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Autor.Location = New System.Drawing.Point(12, 32)
        Me.TB_Autor.Name = "TB_Autor"
        Me.TB_Autor.Size = New System.Drawing.Size(172, 22)
        Me.TB_Autor.TabIndex = 1
        '
        'DTP_Filtro
        '
        Me.DTP_Filtro.Checked = False
        Me.DTP_Filtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_Filtro.Location = New System.Drawing.Point(190, 32)
        Me.DTP_Filtro.Name = "DTP_Filtro"
        Me.DTP_Filtro.ShowCheckBox = True
        Me.DTP_Filtro.Size = New System.Drawing.Size(264, 22)
        Me.DTP_Filtro.TabIndex = 4
        Me.DTP_Filtro.TabStop = False
        '
        'BTN_Filtrar
        '
        Me.BTN_Filtrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Filtrar.Location = New System.Drawing.Point(460, 8)
        Me.BTN_Filtrar.Name = "BTN_Filtrar"
        Me.BTN_Filtrar.Size = New System.Drawing.Size(87, 46)
        Me.BTN_Filtrar.TabIndex = 5
        Me.BTN_Filtrar.Text = "Filtrar"
        Me.BTN_Filtrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Autor del cierre"
        '
        'VerArqueos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(913, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Filtrar)
        Me.Controls.Add(Me.DTP_Filtro)
        Me.Controls.Add(Me.TB_Autor)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DGV_Cierre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerArqueos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Arqueos"
        CType(Me.DGV_Cierre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Cierre As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TB_Autor As TextBox
    Friend WithEvents DTP_Filtro As DateTimePicker
    Friend WithEvents BTN_Filtrar As Button
    Friend WithEvents Label1 As Label
End Class
