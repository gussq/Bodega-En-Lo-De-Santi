<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DB
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Servidor = New System.Windows.Forms.TextBox()
        Me.TB_Usuario = New System.Windows.Forms.TextBox()
        Me.TB_Basededatos = New System.Windows.Forms.TextBox()
        Me.TB_Contraseña = New System.Windows.Forms.TextBox()
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SERVIDOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BASE DE DATOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USUARIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CONTRASEÑA"
        '
        'TB_Servidor
        '
        Me.TB_Servidor.Location = New System.Drawing.Point(15, 25)
        Me.TB_Servidor.Name = "TB_Servidor"
        Me.TB_Servidor.Size = New System.Drawing.Size(258, 20)
        Me.TB_Servidor.TabIndex = 4
        '
        'TB_Usuario
        '
        Me.TB_Usuario.Location = New System.Drawing.Point(15, 103)
        Me.TB_Usuario.Name = "TB_Usuario"
        Me.TB_Usuario.Size = New System.Drawing.Size(258, 20)
        Me.TB_Usuario.TabIndex = 5
        '
        'TB_Basededatos
        '
        Me.TB_Basededatos.Location = New System.Drawing.Point(15, 64)
        Me.TB_Basededatos.Name = "TB_Basededatos"
        Me.TB_Basededatos.Size = New System.Drawing.Size(258, 20)
        Me.TB_Basededatos.TabIndex = 5
        '
        'TB_Contraseña
        '
        Me.TB_Contraseña.Location = New System.Drawing.Point(15, 142)
        Me.TB_Contraseña.Name = "TB_Contraseña"
        Me.TB_Contraseña.Size = New System.Drawing.Size(256, 20)
        Me.TB_Contraseña.TabIndex = 6
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.Location = New System.Drawing.Point(141, 168)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.Size = New System.Drawing.Size(130, 25)
        Me.BTN_Guardar.TabIndex = 7
        Me.BTN_Guardar.Text = "GUARDAR CONEXION"
        Me.BTN_Guardar.UseVisualStyleBackColor = True
        '
        'DB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 205)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Controls.Add(Me.TB_Contraseña)
        Me.Controls.Add(Me.TB_Basededatos)
        Me.Controls.Add(Me.TB_Usuario)
        Me.Controls.Add(Me.TB_Servidor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_Servidor As TextBox
    Friend WithEvents TB_Usuario As TextBox
    Friend WithEvents TB_Basededatos As TextBox
    Friend WithEvents TB_Contraseña As TextBox
    Friend WithEvents BTN_Guardar As Button
End Class
