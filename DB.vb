Imports Npgsql

Public Class DB
    Private conexion As NpgsqlConnection

    ' Función para inicializar la conexión
    Private Function ObtenerConexion() As NpgsqlConnection
        ' Verificar si los valores de configuración son válidos antes de crear la conexión
        If String.IsNullOrEmpty(My.Settings.Servidor) OrElse String.IsNullOrEmpty(My.Settings.Usuario) OrElse String.IsNullOrEmpty(My.Settings.Contraseña) OrElse String.IsNullOrEmpty(My.Settings.Basededatos) Then
            Return Nothing
        End If

        ' Si todos los valores son válidos, crear y devolver la conexión
        Return New NpgsqlConnection("Host=" & My.Settings.Servidor & ";Username=" & My.Settings.Usuario & ";Password=" & My.Settings.Contraseña & ";Database=" & My.Settings.Basededatos)
    End Function

    ' Cargar los datos de configuración desde My.Settings
    Private Sub CargarDatos()
        TB_Servidor.Text = My.Settings.Servidor
        TB_Basededatos.Text = My.Settings.Basededatos
        TB_Usuario.Text = My.Settings.Usuario
        TB_Contraseña.Text = My.Settings.Contraseña

        ' Solo crear la conexión cuando sea necesario
        If conexion Is Nothing Then
            conexion = ObtenerConexion()
        End If
    End Sub

    ' Se llama al cargar el formulario para asegurar que la conexión esté inicializada
    Private Sub FRM_Server_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Asegurarse de que la conexión esté inicializada al cargar el formulario
        conexion = ObtenerConexion()
        CargarDatos() ' Cargar los datos de configuración
    End Sub

    ' Guardar la configuración y actualizar la conexión
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        Try
            ' Guardar la configuración en My.Settings
            My.Settings.Servidor = TB_Servidor.Text
            My.Settings.Basededatos = TB_Basededatos.Text
            My.Settings.Usuario = TB_Usuario.Text
            My.Settings.Contraseña = TB_Contraseña.Text
            My.Settings.Save()

            ' Crear una nueva conexión con los valores guardados
            conexion = ObtenerConexion()

            ' Verificar si la conexión es válida antes de continuar
            If conexion IsNot Nothing Then
                MsgBox("Configuración guardada correctamente.")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar la configuración: " & ex.Message)
        End Try
    End Sub

End Class