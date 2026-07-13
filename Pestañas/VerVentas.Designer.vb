<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerVentas
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
        Me.components = New System.ComponentModel.Container()
        Me.DGV_VerVentas = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ANULARVENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VERDETALLEDEVENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GB_EstFactura = New System.Windows.Forms.GroupBox()
        Me.RB_Anulado = New System.Windows.Forms.RadioButton()
        Me.RB_NoAnulado = New System.Windows.Forms.RadioButton()
        Me.TB_NumVenta = New System.Windows.Forms.TextBox()
        Me.TB_NumArqueo = New System.Windows.Forms.TextBox()
        Me.TB_FechaVenta = New System.Windows.Forms.TextBox()
        Me.TB_FechaArqueo = New System.Windows.Forms.TextBox()
        Me.TB_Montototal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGV_VerVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GB_EstFactura.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_VerVentas
        '
        Me.DGV_VerVentas.AllowUserToAddRows = False
        Me.DGV_VerVentas.AllowUserToDeleteRows = False
        Me.DGV_VerVentas.AllowUserToOrderColumns = True
        Me.DGV_VerVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_VerVentas.Location = New System.Drawing.Point(12, 114)
        Me.DGV_VerVentas.Name = "DGV_VerVentas"
        Me.DGV_VerVentas.ReadOnly = True
        Me.DGV_VerVentas.Size = New System.Drawing.Size(776, 324)
        Me.DGV_VerVentas.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ANULARVENTAToolStripMenuItem, Me.VERDETALLEDEVENTAToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(198, 48)
        '
        'ANULARVENTAToolStripMenuItem
        '
        Me.ANULARVENTAToolStripMenuItem.Name = "ANULARVENTAToolStripMenuItem"
        Me.ANULARVENTAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ANULARVENTAToolStripMenuItem.Text = "ANULAR VENTA"
        '
        'VERDETALLEDEVENTAToolStripMenuItem
        '
        Me.VERDETALLEDEVENTAToolStripMenuItem.Name = "VERDETALLEDEVENTAToolStripMenuItem"
        Me.VERDETALLEDEVENTAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.VERDETALLEDEVENTAToolStripMenuItem.Text = "VER DETALLE DE VENTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMERO DE VENTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PRODUCTOS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(689, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "FECHA DE VENTA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "NUMERO Y FECHA DE ARQUEO DE LA VENTA"
        '
        'GB_EstFactura
        '
        Me.GB_EstFactura.Controls.Add(Me.RB_Anulado)
        Me.GB_EstFactura.Controls.Add(Me.RB_NoAnulado)
        Me.GB_EstFactura.Location = New System.Drawing.Point(660, 51)
        Me.GB_EstFactura.Name = "GB_EstFactura"
        Me.GB_EstFactura.Size = New System.Drawing.Size(128, 57)
        Me.GB_EstFactura.TabIndex = 5
        Me.GB_EstFactura.TabStop = False
        Me.GB_EstFactura.Text = "ESTADODE VENTA"
        '
        'RB_Anulado
        '
        Me.RB_Anulado.AutoSize = True
        Me.RB_Anulado.Location = New System.Drawing.Point(6, 37)
        Me.RB_Anulado.Name = "RB_Anulado"
        Me.RB_Anulado.Size = New System.Drawing.Size(64, 17)
        Me.RB_Anulado.TabIndex = 1
        Me.RB_Anulado.TabStop = True
        Me.RB_Anulado.Text = "Anulado"
        Me.RB_Anulado.UseVisualStyleBackColor = True
        '
        'RB_NoAnulado
        '
        Me.RB_NoAnulado.AutoSize = True
        Me.RB_NoAnulado.Location = New System.Drawing.Point(6, 19)
        Me.RB_NoAnulado.Name = "RB_NoAnulado"
        Me.RB_NoAnulado.Size = New System.Drawing.Size(81, 17)
        Me.RB_NoAnulado.TabIndex = 0
        Me.RB_NoAnulado.TabStop = True
        Me.RB_NoAnulado.Text = "No Anulado"
        Me.RB_NoAnulado.UseVisualStyleBackColor = True
        '
        'TB_NumVenta
        '
        Me.TB_NumVenta.Location = New System.Drawing.Point(12, 25)
        Me.TB_NumVenta.Name = "TB_NumVenta"
        Me.TB_NumVenta.Size = New System.Drawing.Size(243, 20)
        Me.TB_NumVenta.TabIndex = 6
        '
        'TB_NumArqueo
        '
        Me.TB_NumArqueo.Location = New System.Drawing.Point(12, 75)
        Me.TB_NumArqueo.Name = "TB_NumArqueo"
        Me.TB_NumArqueo.Size = New System.Drawing.Size(54, 20)
        Me.TB_NumArqueo.TabIndex = 7
        '
        'TB_FechaVenta
        '
        Me.TB_FechaVenta.Location = New System.Drawing.Point(660, 25)
        Me.TB_FechaVenta.Name = "TB_FechaVenta"
        Me.TB_FechaVenta.Size = New System.Drawing.Size(128, 20)
        Me.TB_FechaVenta.TabIndex = 8
        '
        'TB_FechaArqueo
        '
        Me.TB_FechaArqueo.Location = New System.Drawing.Point(72, 75)
        Me.TB_FechaArqueo.Name = "TB_FechaArqueo"
        Me.TB_FechaArqueo.Size = New System.Drawing.Size(183, 20)
        Me.TB_FechaArqueo.TabIndex = 9
        '
        'TB_Montototal
        '
        Me.TB_Montototal.Location = New System.Drawing.Point(605, 446)
        Me.TB_Montototal.Name = "TB_Montototal"
        Me.TB_Montototal.Size = New System.Drawing.Size(183, 20)
        Me.TB_Montototal.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(475, 446)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "MONTO TOTAL:"
        '
        'VerVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_Montototal)
        Me.Controls.Add(Me.TB_FechaArqueo)
        Me.Controls.Add(Me.TB_FechaVenta)
        Me.Controls.Add(Me.TB_NumArqueo)
        Me.Controls.Add(Me.TB_NumVenta)
        Me.Controls.Add(Me.GB_EstFactura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_VerVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VerVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerVentas"
        CType(Me.DGV_VerVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GB_EstFactura.ResumeLayout(False)
        Me.GB_EstFactura.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_VerVentas As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ANULARVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VERDETALLEDEVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GB_EstFactura As GroupBox
    Friend WithEvents RB_Anulado As RadioButton
    Friend WithEvents RB_NoAnulado As RadioButton
    Friend WithEvents TB_NumVenta As TextBox
    Friend WithEvents TB_NumArqueo As TextBox
    Friend WithEvents TB_FechaVenta As TextBox
    Friend WithEvents TB_FechaArqueo As TextBox
    Friend WithEvents TB_Montototal As TextBox
    Friend WithEvents Label5 As Label
End Class
