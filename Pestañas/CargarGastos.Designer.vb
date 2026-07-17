<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CargarGastos
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Autor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_FechaCarga = New System.Windows.Forms.TextBox()
        Me.BTN_CargarGasto = New System.Windows.Forms.Button()
        Me.TB_Monto = New System.Windows.Forms.TextBox()
        Me.TB_Motivo = New System.Windows.Forms.TextBox()
        Me.TB_AperturaSencillo = New System.Windows.Forms.TextBox()
        Me.DGV_Gastos = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BTN_Filtrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_FiltroAutor = New System.Windows.Forms.TextBox()
        Me.DTP_VerGastos = New System.Windows.Forms.DateTimePicker()
        Me.DGV_VerGastos = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV_Gastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_VerGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 467)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TabPage1.Controls.Add(Me.TB_FechaCarga)
        Me.TabPage1.Controls.Add(Me.TB_Autor)
        Me.TabPage1.Controls.Add(Me.TB_AperturaSencillo)
        Me.TabPage1.Controls.Add(Me.BTN_CargarGasto)
        Me.TabPage1.Controls.Add(Me.TB_Monto)
        Me.TabPage1.Controls.Add(Me.TB_Motivo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DGV_Gastos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(639, 441)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CARGAR GASTOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "AUTOR ARQUEO"
        '
        'TB_Autor
        '
        Me.TB_Autor.Enabled = False
        Me.TB_Autor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Autor.Location = New System.Drawing.Point(183, 22)
        Me.TB_Autor.Name = "TB_Autor"
        Me.TB_Autor.ReadOnly = True
        Me.TB_Autor.Size = New System.Drawing.Size(169, 29)
        Me.TB_Autor.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "MONTO DEL GASTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "MOTIVO DEL GASTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SENCILLO DE APERTURA"
        '
        'TB_FechaCarga
        '
        Me.TB_FechaCarga.Enabled = False
        Me.TB_FechaCarga.Location = New System.Drawing.Point(511, 6)
        Me.TB_FechaCarga.Name = "TB_FechaCarga"
        Me.TB_FechaCarga.ReadOnly = True
        Me.TB_FechaCarga.Size = New System.Drawing.Size(120, 20)
        Me.TB_FechaCarga.TabIndex = 6
        Me.TB_FechaCarga.TabStop = False
        '
        'BTN_CargarGasto
        '
        Me.BTN_CargarGasto.Location = New System.Drawing.Point(358, 77)
        Me.BTN_CargarGasto.Name = "BTN_CargarGasto"
        Me.BTN_CargarGasto.Size = New System.Drawing.Size(114, 23)
        Me.BTN_CargarGasto.TabIndex = 5
        Me.BTN_CargarGasto.Text = "CARGAR GASTOS"
        Me.BTN_CargarGasto.UseVisualStyleBackColor = True
        '
        'TB_Monto
        '
        Me.TB_Monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Monto.Location = New System.Drawing.Point(183, 77)
        Me.TB_Monto.Name = "TB_Monto"
        Me.TB_Monto.Size = New System.Drawing.Size(169, 22)
        Me.TB_Monto.TabIndex = 4
        '
        'TB_Motivo
        '
        Me.TB_Motivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Motivo.Location = New System.Drawing.Point(8, 77)
        Me.TB_Motivo.Name = "TB_Motivo"
        Me.TB_Motivo.Size = New System.Drawing.Size(169, 22)
        Me.TB_Motivo.TabIndex = 3
        '
        'TB_AperturaSencillo
        '
        Me.TB_AperturaSencillo.Enabled = False
        Me.TB_AperturaSencillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_AperturaSencillo.Location = New System.Drawing.Point(8, 22)
        Me.TB_AperturaSencillo.Name = "TB_AperturaSencillo"
        Me.TB_AperturaSencillo.ReadOnly = True
        Me.TB_AperturaSencillo.Size = New System.Drawing.Size(169, 29)
        Me.TB_AperturaSencillo.TabIndex = 1
        '
        'DGV_Gastos
        '
        Me.DGV_Gastos.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.DGV_Gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Gastos.Location = New System.Drawing.Point(8, 105)
        Me.DGV_Gastos.Name = "DGV_Gastos"
        Me.DGV_Gastos.Size = New System.Drawing.Size(623, 328)
        Me.DGV_Gastos.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TabPage2.Controls.Add(Me.BTN_Filtrar)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TB_FiltroAutor)
        Me.TabPage2.Controls.Add(Me.DTP_VerGastos)
        Me.TabPage2.Controls.Add(Me.DGV_VerGastos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(639, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "VER GASTOS"
        '
        'BTN_Filtrar
        '
        Me.BTN_Filtrar.Location = New System.Drawing.Point(369, 23)
        Me.BTN_Filtrar.Name = "BTN_Filtrar"
        Me.BTN_Filtrar.Size = New System.Drawing.Size(99, 28)
        Me.BTN_Filtrar.TabIndex = 6
        Me.BTN_Filtrar.Text = "FILTRAR"
        Me.BTN_Filtrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "AUTOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "FECHA"
        '
        'TB_FiltroAutor
        '
        Me.TB_FiltroAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FiltroAutor.Location = New System.Drawing.Point(144, 23)
        Me.TB_FiltroAutor.Name = "TB_FiltroAutor"
        Me.TB_FiltroAutor.Size = New System.Drawing.Size(219, 26)
        Me.TB_FiltroAutor.TabIndex = 3
        '
        'DTP_VerGastos
        '
        Me.DTP_VerGastos.Checked = False
        Me.DTP_VerGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_VerGastos.Location = New System.Drawing.Point(11, 23)
        Me.DTP_VerGastos.Name = "DTP_VerGastos"
        Me.DTP_VerGastos.ShowCheckBox = True
        Me.DTP_VerGastos.Size = New System.Drawing.Size(127, 26)
        Me.DTP_VerGastos.TabIndex = 2
        '
        'DGV_VerGastos
        '
        Me.DGV_VerGastos.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.DGV_VerGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VerGastos.Location = New System.Drawing.Point(8, 55)
        Me.DGV_VerGastos.Name = "DGV_VerGastos"
        Me.DGV_VerGastos.Size = New System.Drawing.Size(625, 378)
        Me.DGV_VerGastos.TabIndex = 1
        '
        'Timer1
        '
        '
        'CargarGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 467)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CargarGastos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GASTOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGV_Gastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGV_VerGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TB_AperturaSencillo As TextBox
    Friend WithEvents BTN_CargarGasto As Button
    Friend WithEvents TB_Monto As TextBox
    Friend WithEvents TB_Motivo As TextBox
    Friend WithEvents TB_FechaCarga As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGV_Gastos As DataGridView
    Friend WithEvents TB_Autor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGV_VerGastos As DataGridView
    Friend WithEvents DTP_VerGastos As DateTimePicker
    Friend WithEvents TB_FiltroAutor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTN_Filtrar As Button
End Class
