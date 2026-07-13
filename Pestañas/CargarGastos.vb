Imports Npgsql
Public Class CargarGastos
    Private IdArqueoActual As Integer

    Private Function ObtenerConexion() As NpgsqlConnection
        If String.IsNullOrEmpty(My.Settings.Servidor) OrElse
           String.IsNullOrEmpty(My.Settings.Usuario) OrElse
           String.IsNullOrEmpty(My.Settings.Contraseña) OrElse
           String.IsNullOrEmpty(My.Settings.Basededatos) Then
            Return Nothing
        End If
        Return New NpgsqlConnection("Host=" & My.Settings.Servidor & ";Username=" & My.Settings.Usuario & ";Password=" & My.Settings.Contraseña & ";Database=" & My.Settings.Basededatos)
    End Function

    'Pestaña de cargar gastos
    Private Sub CargarGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()

        CargarSencilloAbierto()
        MostrarGastos()
        VerificarGastos()

        DTP_VerGastos.Format = DateTimePickerFormat.Custom
        DTP_VerGastos.CustomFormat = "dd:MM:yyyy"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TB_FechaCarga.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

    End Sub

    Private Sub CargarSencilloAbierto()
        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()
                Dim query As String = "SELECT Id_Arqueo, AutorCierre ,SencilloApertura FROM Arqueo 
                                   WHERE SencilloCierre = 0 
                                   ORDER BY FechaArqueo DESC LIMIT 1"

                Using cmd As New NpgsqlCommand(query, conexion)
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Hay una caja abierta sin cierre
                            TB_AperturaSencillo.Text = Convert.ToInt32(reader("sencilloapertura"))
                            TB_Autor.Text = reader("AutorCierre").ToString()
                            IdArqueoActual = Convert.ToInt32(reader("Id_Arqueo"))
                            Dim apertura As Decimal = Convert.ToDecimal(reader("SencilloApertura"))
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar sencillo abierto: " & ex.Message)
        End Try
    End Sub

    Private Sub MostrarGastos()
        Try

            Dim consulta As String = "SELECT autor, motivo, monto FROM Gastos where id_arqueo = @arqueo"


            Using conexion = ObtenerConexion()
                conexion.Open()
                Dim comando As New NpgsqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@arqueo", IdArqueoActual)
                Dim adapter As New NpgsqlDataAdapter(comando)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                If dt.Rows.Count > 0 Then
                    ' Llenar el DataGridView con los datos de la consulta
                    DGV_Gastos.DataSource = dt
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_CargarGasto_Click(sender As Object, e As EventArgs) Handles BTN_CargarGasto.Click
        If String.IsNullOrWhiteSpace(TB_AperturaSencillo.Text) Then
            MessageBox.Show("No hay un sencillo abierto.")
        Else
            Try
                Dim consulta As String = "INSERT INTO Gastos (id_arqueo, autor, motivo, monto, fechagasto) VALUES (@id_arqueo, @autor, @motivo, @monto, @fechagasto)"
                Using conexion = ObtenerConexion()
                    conexion.Open()
                    Dim comando As New NpgsqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@id_arqueo", IdArqueoActual)
                    comando.Parameters.AddWithValue("@autor", TB_Autor.Text)
                    comando.Parameters.AddWithValue("@motivo", TB_Motivo.Text)
                    comando.Parameters.AddWithValue("@monto", Convert.ToDecimal(TB_Monto.Text))
                    comando.Parameters.AddWithValue("@fechagasto", DateTime.Now)
                    comando.ExecuteNonQuery()

                    MessageBox.Show("Gasto cargado correctamente.")

                    TB_Motivo.Clear()
                    TB_Monto.Clear()

                    MostrarGastos()
                    VerificarGastos()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar el gasto: " & ex.Message)
            End Try
        End If
    End Sub

    'Pestaña de verificar gastos

    Private Sub VerificarGastos()
        Dim Consulta As String = "Select * from Gastos"
        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Dim adaptador As New NpgsqlDataAdapter(Consulta, conexion)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                DGV_VerGastos.DataSource = tabla
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los gastos: " & ex.Message)
        End Try
    End Sub

    Private Sub FiltrarGastos()
        Dim consulta As String
        Dim autorFiltro As String = TB_FiltroAutor.Text.Trim()

        If DTP_VerGastos.Checked Then
            consulta = "SELECT * FROM gastos WHERE autor ILIKE @busqueda AND fechagasto = @fecha"
        Else
            consulta = "SELECT * FROM gastos WHERE autor ILIKE @busqueda"
        End If

        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Using comando As New NpgsqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@busqueda", "%" & autorFiltro & "%")

                    If DTP_VerGastos.Checked Then
                        comando.Parameters.AddWithValue("@fecha", DTP_VerGastos.Value.Date)
                    End If

                    Dim da As New NpgsqlDataAdapter(comando)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_VerGastos.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar los gastos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BTN_Filtrar_Click(sender As Object, e As EventArgs) Handles BTN_Filtrar.Click
        FiltrarGastos()
    End Sub

    Private Sub DTP_VerGastos_ValueChanged(sender As Object, e As EventArgs) Handles DTP_VerGastos.ValueChanged
        FiltrarGastos()
    End Sub

    Private Sub TB_Autor_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_Autor.KeyDown
        If e.KeyCode = Keys.Enter Then
            FiltrarGastos()
        End If
    End Sub
End Class