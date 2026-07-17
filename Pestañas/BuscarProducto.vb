Imports Npgsql
Public Class BuscarProducto
    Dim conexion As NpgsqlConnection
    Private Inventario As Form1

    Private Function ObtenerConexion() As NpgsqlConnection
        If String.IsNullOrEmpty(My.Settings.Servidor) OrElse
           String.IsNullOrEmpty(My.Settings.Usuario) OrElse
           String.IsNullOrEmpty(My.Settings.Contraseña) OrElse
           String.IsNullOrEmpty(My.Settings.Basededatos) Then
            Return Nothing
        End If
        Return New NpgsqlConnection("Host=" & My.Settings.Servidor & ";Username=" & My.Settings.Usuario & ";Password=" & My.Settings.Contraseña & ";Database=" & My.Settings.Basededatos)
    End Function

    Public Sub New(Inv As Form1)
        InitializeComponent()
        Inventario = Inv
    End Sub

    Public Sub Mostrar_Productos()
        Try
            Dim consulta As String = "SELECT * FROM Productos"

            Using conexion = ObtenerConexion()
                conexion.Open()
                Dim adaptador As New NpgsqlDataAdapter(consulta, conexion)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                DGV_BuscarProductos.DataSource = tabla
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_Seleccionar_Click(sender As Object, e As EventArgs) Handles BTN_Seleccionar.Click

        Dim Codigo As String = DGV_BuscarProductos.CurrentRow.Cells(1).Value.ToString()
        Dim NombreProducto As String = DGV_BuscarProductos.CurrentRow.Cells(2).Value.ToString()
        Dim Precio As String = DGV_BuscarProductos.CurrentRow.Cells(3).Value.ToString()

        Inventario.TB_CodigoCargarInventario.Text = Codigo
        Inventario.TB_NombreCargarInventario.Text = NombreProducto
        Inventario.TB_PrecioCargarInventario.Text = Precio

        Inventario.TB_CantidadCargarInventario.Focus()

        Me.Close()

    End Sub

    Private Sub BuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar_Productos()
    End Sub

    Private Sub Cerrar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Seleccionar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If DGV_BuscarProductos.Focused And e.KeyCode = Keys.Enter Then

            Dim Codigo As String = DGV_BuscarProductos.CurrentRow.Cells(1).Value.ToString()
            Dim NombreProducto As String = DGV_BuscarProductos.CurrentRow.Cells(2).Value.ToString()
            Dim Precio As String = DGV_BuscarProductos.CurrentRow.Cells(3).Value.ToString()

            Inventario.TB_CodigoCargarInventario.Text = Codigo
            Inventario.TB_NombreCargarInventario.Text = NombreProducto
            Inventario.TB_PrecioCargarInventario.Text = Precio
            Inventario.TB_CantidadCargarInventario.Focus()
            Me.Close()

        End If
    End Sub

    Private Sub DGV_Productos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_BuscarProductos.CellDoubleClick
        Dim Codigo As String = DGV_BuscarProductos.CurrentRow.Cells(1).Value.ToString()
        Dim NombreProducto As String = DGV_BuscarProductos.CurrentRow.Cells(2).Value.ToString()
        Dim Precio As String = DGV_BuscarProductos.CurrentRow.Cells(3).Value.ToString()

        Inventario.TB_CodigoCargarInventario.Text = Codigo
        Inventario.TB_NombreCargarInventario.Text = NombreProducto
        Inventario.TB_PrecioCargarInventario.Text = Precio
        Inventario.TB_CantidadCargarInventario.Focus()
        Me.Close()
    End Sub

    Private Sub FiltrarProductos(ByVal filtro As String)
        'Filtrar los clientes segun el tb de busqueda

        Dim Consulta As String = "SELECT * FROM productos WHERE nombre_productos ILIKE @busqueda"
        conexion = ObtenerConexion()
        conexion.Open()
        Try
            Using comando As New NpgsqlCommand(Consulta, conexion)
                comando.Parameters.AddWithValue("@busqueda", "%" & TB_BuscarProducto.Text & "%")
                Dim da As New NpgsqlDataAdapter(comando)
                Dim dt As New DataTable
                da.Fill(dt)
                DGV_BuscarProductos.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error al filtrar los productos: " & ex.Message)
        End Try
    End Sub

    Private Sub TB_Filtrar_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_BuscarProducto.KeyDown
        If e.KeyCode = Keys.Enter Then
            FiltrarProductos(TB_BuscarProducto.Text)
        End If
    End Sub

End Class