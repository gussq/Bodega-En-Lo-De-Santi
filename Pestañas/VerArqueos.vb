Imports Npgsql

Public Class VerArqueos
    Dim conexion As NpgsqlConnection

    Private Function ObtenerConexion() As NpgsqlConnection
        If String.IsNullOrEmpty(My.Settings.Servidor) OrElse
           String.IsNullOrEmpty(My.Settings.Usuario) OrElse
           String.IsNullOrEmpty(My.Settings.Contraseña) OrElse
           String.IsNullOrEmpty(My.Settings.Basededatos) Then
            Return Nothing
        End If
        Return New NpgsqlConnection("Host=" & My.Settings.Servidor & ";Username=" & My.Settings.Usuario & ";Password=" & My.Settings.Contraseña & ";Database=" & My.Settings.Basededatos)
    End Function

    Private Sub MostrarArqueos()
        Dim Consulta As String = "Select * from Arqueo order by Id_arqueo"
        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Dim adaptador As New NpgsqlDataAdapter(Consulta, conexion)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                DGV_Cierre.DataSource = tabla
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas: " & ex.Message)
        End Try
    End Sub

    Private Sub VerArqueos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarArqueos()
    End Sub

    Private Sub FiltrarArqueo()
        If DTP_Filtro.Checked Then
            Dim consulta As String = "SELECT * FROM Arqueo WHERE autorcierre ILIKE @autorcierre AND FechaArqueo::date = @FechaArqueo"

            Try
                Using conexion As NpgsqlConnection = ObtenerConexion()
                    conexion.Open()
                    Using comando As New NpgsqlCommand(consulta, conexion)
                        comando.Parameters.AddWithValue("@autorcierre", "%" & TB_Autor.Text.Trim() & "%")
                        comando.Parameters.AddWithValue("@FechaArqueo", DTP_Filtro.Value.Date)

                        Dim da As New NpgsqlDataAdapter(comando)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        DGV_Cierre.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al filtrar los arqueos: " & ex.Message)
            End Try

        Else
            Dim consulta As String = "SELECT * FROM Arqueo WHERE autorcierre ILIKE @autorcierre"

            Try
                Using conexion As NpgsqlConnection = ObtenerConexion()
                    conexion.Open()
                    Using comando As New NpgsqlCommand(consulta, conexion)
                        comando.Parameters.AddWithValue("@autorcierre", "%" & TB_Autor.Text.Trim() & "%")

                        Dim da As New NpgsqlDataAdapter(comando)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        DGV_Cierre.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al filtrar los arqueos: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub BTN_Filtrar_Click(sender As Object, e As EventArgs) Handles BTN_Filtrar.Click
        FiltrarArqueo()
    End Sub

    Private Sub TB_Autor_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_Autor.KeyDown
        If e.KeyValue = Keys.Enter Then
            FiltrarArqueo()
        End If
    End Sub

    Private Sub DTP_Filtro_ValueChanged(sender As Object, e As EventArgs) Handles DTP_Filtro.ValueChanged
        FiltrarArqueo()
    End Sub
End Class