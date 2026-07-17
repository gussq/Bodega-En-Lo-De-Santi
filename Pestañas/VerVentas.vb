Imports Npgsql

Public Class VerVentas
    Dim conexion As NpgsqlConnection
    Private Id_CabVentas As Integer

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
        Id_CabVentas = Inventario
    End Sub

    Private Sub VerVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVenta()
        BloquearCampos(False)
    End Sub

    Private Sub BloquearCampos(Bloquear As Boolean)

        TB_FechaArqueo.Enabled = Bloquear
        TB_FechaVenta.Enabled = Bloquear
        TB_NumArqueo.Enabled = Bloquear
        TB_NumVenta.Enabled = Bloquear

        RB_Anulado.Enabled = Bloquear
        RB_NoAnulado.Enabled = Bloquear

        TB_Montototal.Enabled = Bloquear

    End Sub

    Private Sub CargarVenta()
        Try
            conexion = ObtenerConexion()
            conexion.Open()

            Dim Consulta As String = "select * from vista_ventas_completa WHERE Id_CabVentas = @Id_CabVentas"
            Dim comando As New NpgsqlCommand(Consulta, conexion)
            comando.Parameters.AddWithValue("@Id_CabVentas", Id_CabVentas)

            Dim reader As NpgsqlDataReader = comando.ExecuteReader()

            If reader.Read() Then

                TB_NumVenta.Text = reader("Id_CabVentas").ToString()
                TB_FechaVenta.Text = reader("fecha_venta").ToString()
                TB_NumArqueo.Text = reader("Id_arqueo").ToString()
                TB_FechaArqueo.Text = reader("FechaArqueo").ToString()
                TB_Montototal.Text = reader("Montototal").ToString()

                If Not IsDBNull(reader("Anulado")) AndAlso CBool(reader("Anulado")) Then
                    RB_Anulado.Checked = True
                Else
                    RB_NoAnulado.Checked = True
                End If

                BloquearCampos(True)

            Else
                MessageBox.Show("No se encontraron datos para esta venta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close()
            conexion.Close()

            ' Llamamos a la función para cargar los detalles en el DataGridView
            CargarDetalleVentas()


        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarDetalleVentas()
        Try
            conexion = ObtenerConexion()
            conexion.Open()

            ' 🔹 Consulta para obtener los productos o servicios de la factura
            Dim Consulta As String = "select * from detalle_ventas WHERE Id_CabVentas = @Id_CabVentas ORDER BY id_producto"

            Dim comando As New NpgsqlCommand(Consulta, conexion)
            comando.Parameters.AddWithValue("@Id_CabVentas", Id_CabVentas)

            Dim adapter As New NpgsqlDataAdapter(comando)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Asignamos los datos al DataGridView
            DGV_VerVentas.DataSource = dt

            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los detalles de la factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class