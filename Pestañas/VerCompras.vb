Imports Npgsql
Public Class VerCompras
    Dim conexion As NpgsqlConnection
    Private Id_CabCompras As Integer

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
        Id_CabCompras = Inventario
    End Sub

    Private Sub VerCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCompra()
        BloquearCampos(False)
    End Sub

    Private Sub BloquearCampos(Bloquear As Boolean)

        TB_Fecha.Enabled = Bloquear
        TB_IdCompra.Enabled = Bloquear
        TB_NumeroFactura.Enabled = Bloquear
        TB_Montototal.Enabled = Bloquear
        TB_Proveedor.Enabled = Bloquear
        TB_RUC.Enabled = Bloquear
        TB_Timbrado.Enabled = Bloquear
        TB_Prefijo.Enabled = Bloquear

    End Sub

    Private Sub CargarCompra()
        Try
            conexion = ObtenerConexion()
            conexion.Open()

            Dim Consulta As String = "select * from cabecera_compras WHERE Id_CabCompras = @Id_CabCompras"
            Dim comando As New NpgsqlCommand(Consulta, conexion)
            comando.Parameters.AddWithValue("@Id_CabCompras", Id_CabCompras)

            Dim reader As NpgsqlDataReader = comando.ExecuteReader()

            If reader.Read() Then

                TB_RUC.Text = reader("Ruc").ToString()
                TB_Proveedor.Text = reader("Proveedor").ToString()
                TB_NumeroFactura.Text = reader("Numfactura").ToString()
                TB_Prefijo.Text = reader("Prefijo").ToString()
                TB_Timbrado.Text = reader("Timbrado").ToString()
                TB_Fecha.Text = reader("FechaCompra").ToString()
                TB_IdCompra.Text = reader("Id_CabCompras").ToString()
                TB_Montototal.Text = reader("Montototal").ToString()

                BloquearCampos(True)

            Else
                MessageBox.Show("No se encontraron datos para esta compras.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close()
            conexion.Close()

            ' Llamamos a la función para cargar los detalles en el DataGridView
            CargarDetalleCompras()


        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDetalleCompras()
        Try
            conexion = ObtenerConexion()
            conexion.Open()

            ' 🔹 Consulta para obtener los productos o servicios de la factura
            Dim Consulta As String = "select * from detalle_compras WHERE Id_CabCompras = @Id_CabCompras ORDER BY id_producto"

            Dim comando As New NpgsqlCommand(Consulta, conexion)
            comando.Parameters.AddWithValue("@Id_CabCompras", Id_CabCompras)

            Dim adapter As New NpgsqlDataAdapter(comando)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Asignamos los datos al DataGridView
            DGV_VerCompras.DataSource = dt

            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles de la factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class