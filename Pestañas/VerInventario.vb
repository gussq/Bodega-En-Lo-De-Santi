Imports Npgsql

Public Class VerInventario
    Dim conexion As NpgsqlConnection
    Private Id_Inventario As Integer

    Private Function ObtenerConexion() As NpgsqlConnection
        If String.IsNullOrEmpty(My.Settings.Servidor) OrElse
           String.IsNullOrEmpty(My.Settings.Usuario) OrElse
           String.IsNullOrEmpty(My.Settings.Contraseña) OrElse
           String.IsNullOrEmpty(My.Settings.Basededatos) Then
            Return Nothing
        End If
        Return New NpgsqlConnection("Host=" & My.Settings.Servidor & ";Username=" & My.Settings.Usuario & ";Password=" & My.Settings.Contraseña & ";Database=" & My.Settings.Basededatos)
    End Function

    Public Sub New(Inventario As Integer)
        InitializeComponent()
        Id_Inventario = Inventario
    End Sub

    Private Sub VerInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarInventario()
        BloquearCampos(False)
    End Sub

    Private Sub CargarInventario()
        Try
            conexion = ObtenerConexion()
            conexion.Open()

            Dim Consulta As String = "select * from Cabecera_inventario WHERE Id_CabInventario = @Id_CabInventario"
            Dim comando As New NpgsqlCommand(Consulta, conexion)
            comando.Parameters.AddWithValue("@Id_CabInventario", Id_Inventario)

            Dim reader As NpgsqlDataReader = comando.ExecuteReader()

            If reader.Read() Then

                TB_AutorDetalleInventario.Text = reader("autor").ToString()
                TB_FechaEmisionDetalleInventario.Text = reader("fecha_inventario").ToString()
                TB_NumCabInventario.Text = reader("id_cabinventario").ToString()

                BloquearCampos(True)

            Else
                MessageBox.Show("No se encontraron datos para este inventario.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close()
            conexion.Close()

            ' Llamamos a la función para cargar los detalles en el DataGridView
            CargarDetalleInventario()


        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDetalleInventario()
        Try
            conexion = ObtenerConexion()
            conexion.Open()

            ' 🔹 Consulta para obtener los productos o servicios de la factura
            Dim Consulta As String = "select * from Detalle_inventario WHERE Id_CabInventario = @Id_CabInventario ORDER BY id_producto"

            Dim comando As New NpgsqlCommand(Consulta, conexion)
            comando.Parameters.AddWithValue("@Id_CabInventario", Id_Inventario)

            Dim adapter As New NpgsqlDataAdapter(comando)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Asignamos los datos al DataGridView
            DGV_DetalleInventario.DataSource = dt

            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles de la factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub BloquearCampos(bloquear As Boolean)

        TB_AutorDetalleInventario.Enabled = bloquear
        TB_FechaEmisionDetalleInventario.Enabled = bloquear
        TB_NumCabInventario.Enabled = bloquear

    End Sub

End Class