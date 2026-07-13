Imports Npgsql
Public Class Form1
    Dim conexion As NpgsqlConnection

    Dim dtProductos As New DataTable()
    Dim daProductos As NpgsqlDataAdapter

    Dim dtRubros As New DataTable()
    Dim daRubros As NpgsqlDataAdapter

    Private Function ObtenerConexion() As NpgsqlConnection
        If String.IsNullOrEmpty(My.Settings.Servidor) OrElse
           String.IsNullOrEmpty(My.Settings.Usuario) OrElse
           String.IsNullOrEmpty(My.Settings.Contraseña) OrElse
           String.IsNullOrEmpty(My.Settings.Basededatos) Then
            Return Nothing
        End If
        Return New NpgsqlConnection("Host=" & My.Settings.Servidor & ";Username=" & My.Settings.Usuario & ";Password=" & My.Settings.Contraseña & ";Database=" & My.Settings.Basededatos)
    End Function

    Private Sub BloquearCampos(Bloquear As Boolean)
        TB_NombreCargarInventario.Enabled = Not Bloquear
        TB_PrecioCargarInventario.Enabled = Not Bloquear
        TB_TotalCagarInventario.Enabled = Not Bloquear

        TB_ProductoSencillo.Enabled = Not Bloquear
        TB_PrecioSencillo.Enabled = Not Bloquear

        TB_TotalVentasHoy.Enabled = Not Bloquear

        TB_StockCierre.Enabled = Not Bloquear

        TB_NombreProductoCompras.Enabled = Not Bloquear

        TB_TotalCompras.Enabled = Not Bloquear

    End Sub

    Private Sub BTN_DB_Click(sender As Object, e As EventArgs) Handles BTN_DB.Click
        Dim DB As New DB
        DB.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ObtenerConexion() Is Nothing Then
            MessageBox.Show("Faltan datos de conexión en la configuración.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Mostrar_Productos()
        Mostrar_Rubros()
        MostrarVentas()
        ComboBox_Rubro()
        BloquearCampos(True)
        DetalleInv()
        CargarSencilloAbierto()
        MostrarCompras()

        If CB_Rubros.Items.Count > 0 Then
            CB_Rubros.SelectedIndex = 0
        End If

        DTP_FechaEmision.Format = DateTimePickerFormat.Custom
        DTP_FechaEmision.CustomFormat = "dd:MM:yyyy"

        DTP_FechaInventario.Format = DateTimePickerFormat.Custom
        DTP_FechaInventario.CustomFormat = "dd:MM:yyyy"

        Label18.Text = DateTime.Today.ToString("dd/MM/yyyy")

        Timer1.Interval = 1000
        Timer1.Start()

        TB_FechaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm")

        CB_FiltroVerCompras.Items.Add("numfactura")
        CB_FiltroVerCompras.Items.Add("timbrado")
        CB_FiltroVerCompras.Items.Add("ruc")
        CB_FiltroVerCompras.Items.Add("proveedor")
        CB_FiltroVerCompras.SelectedIndex = 0

        DTP_FechaVerCompras.Format = DateTimePickerFormat.Custom
        DTP_FechaVerCompras.CustomFormat = "dd:MM:yyyy"

        CHKBOX_50R_Productos.Checked = True

    End Sub

    'Inicio Pestaña Productos
    Public Sub Mostrar_Productos()
        If CHKBOX_50R_Productos.Checked = True Then
            Try

                Dim consulta As String = "SELECT * FROM Productos where id_producto < 51 order by id_producto "

                Using conexion = ObtenerConexion()
                    conexion.Open()
                    daProductos = New NpgsqlDataAdapter(consulta, conexion)

                    ' Generar comandos para UPDATE automáticos
                    Dim cb As New NpgsqlCommandBuilder(daProductos)

                    dtProductos.Clear()
                    daProductos.Fill(dtProductos)
                    DGV_Productos.DataSource = dtProductos

                    DGV_Productos.ReadOnly = False
                    DGV_Productos.AllowUserToAddRows = True

                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar los productos: " & ex.Message)
            End Try
        Else
            Try
                Dim consulta As String = "SELECT * FROM Productos ORDER BY Id_producto"
                Using conexion = ObtenerConexion()
                    conexion.Open()
                    daProductos = New NpgsqlDataAdapter(consulta, conexion)
                    ' Generar comandos para UPDATE automáticos
                    Dim cb As New NpgsqlCommandBuilder(daProductos)
                    dtProductos.Clear()
                    daProductos.Fill(dtProductos)
                    DGV_Productos.DataSource = dtProductos

                    DGV_Productos.ReadOnly = False
                    DGV_Productos.AllowUserToAddRows = True
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar los productos: " & ex.Message)
            End Try

        End If



    End Sub

    Private Sub CHKBOX_50RESULTADOSPRODUCTOS_CheckedChanged(sender As Object, e As EventArgs) Handles CHKBOX_50R_Productos.CheckedChanged
        Mostrar_Productos()
    End Sub

    Public Sub Mostrar_Rubros()
        Try
            Dim consulta As String = "SELECT * FROM Rubros"

            Using conexion = ObtenerConexion()
                conexion.Open()
                daRubros = New NpgsqlDataAdapter(consulta, conexion)

                ' Generar comandos para UPDATE automáticos
                Dim cb As New NpgsqlCommandBuilder(daRubros)

                dtRubros.Clear()
                daRubros.Fill(dtRubros)
                DGV_Rubros.DataSource = dtRubros

                DGV_Rubros.ReadOnly = False
                DGV_Rubros.AllowUserToAddRows = True

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los rubros: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox_Rubro()
        ' Inicializamos la conexión
        conexion = ObtenerConexion()
        Try
            ' Abrir la conexión
            conexion.Open()

            ' Crear el comando para obtener los usuarios
            Dim cmd As New NpgsqlCommand("SELECT Nombre_Rubro FROM rubros", conexion)
            Dim reader As NpgsqlDataReader = cmd.ExecuteReader()

            CB_Rubros.Items.Clear()

            While reader.Read()
                CB_Rubros.Items.Add(reader("nombre_rubro").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MsgBox("Error al cargar los rubros: " & ex.Message)
        Finally
            ' Cerrar la conexión
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Private Sub BTN_GuardarProductos_Click(sender As Object, e As EventArgs) Handles BTN_GuardarProductos.Click
        If String.IsNullOrWhiteSpace(TB_NombreProducto.Text) OrElse
           String.IsNullOrWhiteSpace(TB_Precio.Text) Then
            MessageBox.Show("Nombre del producto y precios son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim Id_Rubro As Integer = ObtenerIdRubro(CB_Rubros.SelectedItem.ToString())

        Dim Consulta As String = "INSERT INTO PRODUCTOS (Codigo, Nombre_productos, Precio,  Id_Rubro) 
                          VALUES (@codigo, @nombre_producto, @precio, @rubro)"

        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Using comando As New NpgsqlCommand(Consulta, conexion)
                    comando.Parameters.AddWithValue("@codigo", If(String.IsNullOrEmpty(TB_Codigo.Text), DBNull.Value, TB_Codigo.Text))
                    comando.Parameters.AddWithValue("@nombre_producto", TB_NombreProducto.Text)
                    comando.Parameters.AddWithValue("@precio", Convert.ToInt32(TB_Precio.Text))
                    comando.Parameters.AddWithValue("@rubro", Id_Rubro)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Mostrar_Productos()
                    LimpiarCampos()
                End Using
                conexion.Close()
            End Using
        Catch ex As FormatException
            MessageBox.Show("Error: Verificá el formato de los datos (precio o stock).", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al agregar el producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        TB_Codigo.Clear()
        TB_NombreProducto.Clear()
        TB_Precio.Clear()
        CB_Rubros.SelectedIndex = 0
    End Sub

    Public Function ObtenerIdRubro(nombreRubro As String) As Integer
        Dim idRubro As Integer = 1 ' Valor por defecto en caso de error

        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Using cmd As New NpgsqlCommand("SELECT id_rubro FROM Rubros WHERE nombre_rubro = @nombre_rubro", conexion)
                    cmd.Parameters.AddWithValue("@nombre_rubro", nombreRubro)
                    Dim resultado = cmd.ExecuteScalar()

                    If resultado IsNot Nothing Then
                        idRubro = Convert.ToInt32(resultado)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID del rubro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return idRubro
    End Function

    Private Sub BTN_GuardarRubros_Click(sender As Object, e As EventArgs) Handles BTN_GuardarRubros.Click
        If DGV_Rubros.Rows.Cast(Of DataGridViewRow).All(Function(r) r.IsNewRow) Then
            MessageBox.Show("No hay rubros para guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conexion = ObtenerConexion()
                conexion.Open()

                For Each row As DataGridViewRow In DGV_Rubros.Rows
                    If row.IsNewRow Then Continue For

                    Dim nombreRubro As String = row.Cells("nombre_rubro").Value?.ToString()

                    If String.IsNullOrWhiteSpace(nombreRubro) Then Continue For

                    If row.Cells("id_rubro").Value Is Nothing OrElse IsDBNull(row.Cells("id_rubro").Value) Then
                        ' INSERTAR nuevo rubro
                        Using cmd As New NpgsqlCommand("INSERT INTO rubros (nombre_rubro) VALUES (@nombre_rubro)", conexion)
                            cmd.Parameters.AddWithValue("@nombre_rubro", nombreRubro)
                            cmd.ExecuteNonQuery()
                        End Using

                        CB_Rubros.Items.Add(nombreRubro)
                    Else
                        ' ACTUALIZAR rubro existente
                        Dim idRubro As Integer = Convert.ToInt32(row.Cells("id_rubro").Value)
                        Using cmd As New NpgsqlCommand("UPDATE rubros SET nombre_rubro = @nombre_rubro WHERE id_rubro = @id_rubro", conexion)
                            cmd.Parameters.AddWithValue("@id_rubro", idRubro)
                            cmd.Parameters.AddWithValue("@nombre_rubro", nombreRubro)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next

                MessageBox.Show("Rubros guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Mostrar_Rubros()

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar rubros: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FiltrarProductos(ByVal filtro As String)
        'Filtrar los clientes segun el tb de busqueda

        Dim Consulta As String = "SELECT * FROM productos WHERE nombre_productos ILIKE @busqueda"
        conexion = ObtenerConexion()
        conexion.Open()
        Try
            Using comando As New NpgsqlCommand(Consulta, conexion)
                comando.Parameters.AddWithValue("@busqueda", "%" & TB_Filtro.Text & "%")
                Dim da As New NpgsqlDataAdapter(comando)
                Dim dt As New DataTable
                da.Fill(dt)
                DGV_Productos.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox("Error al filtrar los productos: " & ex.Message)
        End Try
    End Sub

    Private Sub TB_Filtro_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_Filtro.KeyDown
        If e.KeyCode = Keys.Enter Then
            FiltrarProductos(TB_Filtro.Text)
            e.SuppressKeyPress = True ' Evita el sonido de la tecla Enter
        End If
    End Sub

    Private Sub BTN_Filtrar_Click(sender As Object, e As EventArgs) Handles BTN_Filtrar.Click
        FiltrarProductos(TB_Filtro.Text)
    End Sub

    Private Sub BTN_GuardarCambios_Click(sender As Object, e As EventArgs) Handles BTN_GuardarCambios.Click
        Try
            Using conexion = ObtenerConexion()
                conexion.Open()

                ' Verificar y reemplazar valores nulos de stock por 0 ANTES de guardar
                For Each fila As DataGridViewRow In DGV_Productos.Rows
                    If Not fila.IsNewRow Then
                        Try
                            Dim stock = fila.Cells("stock").Value

                            If stock Is Nothing OrElse IsDBNull(stock) OrElse String.IsNullOrWhiteSpace(stock.ToString()) Then
                                fila.Cells("stock").Value = 0
                            End If

                            Dim Rubro = fila.Cells("Id_rubro").Value

                            If Rubro Is Nothing OrElse IsDBNull(Rubro) OrElse String.IsNullOrWhiteSpace(Rubro.ToString()) Then
                                fila.Cells("Id_rubro").Value = 1
                            End If

                        Catch ex As Exception
                            MessageBox.Show("Error al procesar fila: " & ex.Message)
                        End Try
                    End If
                Next

                ' Guardar cambios de productos
                If dtProductos.GetChanges() IsNot Nothing Then
                    daProductos.SelectCommand.Connection = conexion
                    Dim cbProd As New NpgsqlCommandBuilder(daProductos)
                    daProductos.UpdateCommand = cbProd.GetUpdateCommand()
                    daProductos.Update(dtProductos)
                    dtProductos.AcceptChanges()
                    Mostrar_Productos()
                End If

                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar cambios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Mostrar_Productos()
        End Try
    End Sub

    Private Sub DGV_Productos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV_Productos.CellFormatting
        If DGV_Productos.Columns(e.ColumnIndex).Name = "stock" Then

            If Not IsDBNull(e.Value) AndAlso CInt(e.Value) <= 10 Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            End If
            If Not IsDBNull(e.Value) AndAlso CInt(e.Value) > 10 AndAlso CInt(e.Value) <= 20 Then
                e.CellStyle.BackColor = Color.Orange
                e.CellStyle.ForeColor = Color.White
            End If
            If Not IsDBNull(e.Value) AndAlso CInt(e.Value) > 20 Then
                e.CellStyle.BackColor = Color.Green
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub

    'Final pestaña productos

    'Inicio pestaña Verificar Inventario

    Private Sub DetalleInv()
        Try
            Dim consulta As String = "select * from Vista_Inventario_Cabecera order by id_cabinventario"
            Dim dt As New DataTable()
            Dim da As New NpgsqlDataAdapter(consulta, conexion)
            da.Fill(dt)
            DGV_VerificarInventario.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al cargar el inventario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FiltrarInventario()
        If DTP_FechaInventario.Checked Then
            Dim consulta As String = "SELECT * FROM vista_inventario_cabecera WHERE autor ILIKE @autor AND Fecha_Inventario::date = @Fecha_Inventario"

            Try
                Using conexion As NpgsqlConnection = ObtenerConexion()
                    conexion.Open()
                    Using comando As New NpgsqlCommand(consulta, conexion)
                        comando.Parameters.AddWithValue("@autor", "%" & TB_FiltrarAutorInventario.Text.Trim() & "%")
                        comando.Parameters.AddWithValue("@Fecha_Inventario", DTP_FechaInventario.Value.Date)

                        Dim da As New NpgsqlDataAdapter(comando)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        DGV_VerificarInventario.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al filtrar los productos: " & ex.Message)
            End Try

        Else
            Dim consulta As String = "SELECT * FROM vista_inventario_cabecera WHERE autor ILIKE @autor"

            Try
                Using conexion As NpgsqlConnection = ObtenerConexion()
                    conexion.Open()
                    Using comando As New NpgsqlCommand(consulta, conexion)
                        comando.Parameters.AddWithValue("@autor", "%" & TB_FiltrarAutorInventario.Text.Trim() & "%")

                        Dim da As New NpgsqlDataAdapter(comando)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        DGV_VerificarInventario.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error al filtrar los productos: " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub DataGridViewInventario_MouseDown(sender As Object, e As MouseEventArgs) Handles DGV_VerificarInventario.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DGV_VerificarInventario.HitTest(e.X, e.Y)

            ' Verificar si se hizo clic en una fila válida
            If hit.RowIndex >= 0 Then
                DGV_VerificarInventario.ClearSelection()
                DGV_VerificarInventario.Rows(hit.RowIndex).Selected = True
                Click_Derecho_Inventario.Show(DGV_VerificarInventario, e.Location)
            End If
        End If
    End Sub

    Private Sub BTN_FiltrarInventario_Click(sender As Object, e As EventArgs) Handles BTN_FiltrarInventario.Click
        FiltrarInventario()
    End Sub

    Private Sub DTP_FechaInventario_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechaInventario.ValueChanged
        FiltrarInventario()
    End Sub

    Private Sub TB_Autor_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_FiltrarAutorInventario.KeyDown
        If e.KeyCode = Keys.Enter Then
            FiltrarInventario()
            e.SuppressKeyPress = True ' Evita el sonido de la tecla Enter
        End If
    End Sub

    Private Sub VERDETALLEDELINVENTARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERDETALLEDELINVENTARIOToolStripMenuItem.Click
        If DGV_VerificarInventario.SelectedRows.Count > 0 Then
            ' Obtener el Id_Cabecera_Ven de la fila seleccionada
            Dim IdInventario As Integer = Convert.ToInt32(DGV_VerificarInventario.SelectedRows(0).Cells("Id_CabInventario").Value)

            ' Abrir el formulario de detalles con el ID de la factura
            Dim DetInventario As New VerInventario(IdInventario)
            DetInventario.ShowDialog()
        Else
            MessageBox.Show("Seleccione una factura para ver el detalle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Final pestaña Verificar Inventario

    'Inicio pestaña Inventario

    Private Sub TB_CodigoCargarInventario_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CodigoCargarInventario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_CodigoCargarInventario.Text) Then
                MessageBox.Show("Ingrese el código del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CodigoCargarInventario.Focus()
                Return
            End If
            BuscarProductosPorCodigoInventario(TB_CodigoCargarInventario.Text)
        End If
    End Sub

    Private Sub BuscarProductosPorCodigoInventario(codigo As String)
        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                Dim consulta As String = "SELECT nombre_productos, precio FROM productos WHERE codigo = @codigo"
                Using cmd As New NpgsqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@codigo", codigo)

                    conexion.Open()
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TB_NombreCargarInventario.Text = reader("nombre_productos").ToString()
                            TB_PrecioCargarInventario.Text = reader("precio").ToString()
                            TB_CantidadCargarInventario.Focus()
                        Else
                            MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            TB_CodigoCargarInventario.Focus()
                            TB_NombreCargarInventario.Clear()
                            TB_PrecioCargarInventario.Clear()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TB_CantidadCargarInventario_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CantidadCargarInventario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_CantidadCargarInventario.Text) Then
                MessageBox.Show("Ingrese la cantidad del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CantidadCargarInventario.Focus()
                Return
            End If

            Dim codigoBuscado As String = TB_CodigoCargarInventario.Text.Trim()

            Dim consulta As String = "SELECT id_producto, nombre_productos, precio, Id_rubro, Nombre_Rubro FROM productos WHERE codigo = @codigo"

            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()

                Using cmd As New NpgsqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@codigo", codigoBuscado)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then

                            Dim idProducto As Integer = Convert.ToInt32(reader("id_producto"))
                            Dim Producto As String = reader("nombre_productos").ToString()


                            Dim precio As Decimal
                            If Not Decimal.TryParse(reader("precio").ToString(), precio) Then
                                MessageBox.Show("Error al leer el precio del producto.")
                                Return
                            End If

                            Dim cantidad As Integer
                            If Not Integer.TryParse(TB_CantidadCargarInventario.Text, cantidad) Then
                                MessageBox.Show("La cantidad ingresada no es válida.")
                                Return
                            End If

                            Dim subtotal As Decimal = precio * cantidad

                            Dim Rubro As String = reader("Id_rubro").ToString()
                            Dim Nombre_Rubro As String = reader("Nombre_Rubro").ToString()


                            ' Agregamos la fila al DataGridView
                            DGV_CargaInventario.Rows.Add(idProducto, Producto, codigoBuscado, precio, cantidad, subtotal, Rubro, Nombre_Rubro)

                            ' Limpiamos campos
                            TB_CantidadCargarInventario.Clear()
                            TB_NombreCargarInventario.Clear()
                            TB_PrecioCargarInventario.Clear()
                            TB_CodigoCargarInventario.Clear()


                            TB_CodigoCargarInventario.Focus()
                            CalcularTotalesCargarInventario()

                        Else
                            MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TB_CodigoCargarInventario.Focus()
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub CalcularTotalesCargarInventario()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DGV_CargaInventario.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("Subtotal").Value)
            End If
        Next

        TB_TotalCagarInventario.Text = total.ToString("N0") & " GS"  ' Visual
        TB_TotalCagarInventario.Tag = total                         ' Real valor
    End Sub

    Private Sub DGV_Inventario_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV_CargaInventario.RowsAdded
        CalcularTotalesCargarInventario()
    End Sub

    Private Sub DGV_Inventario_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV_CargaInventario.RowsRemoved
        CalcularTotalesCargarInventario()
    End Sub

    Private Sub BTN_BuscarCargarInventario_Click(sender As Object, e As EventArgs) Handles BTN_BuscarCargarInventario.Click
        Dim BuscarProductoInventario As New BuscarProducto(Me)
        BuscarProductoInventario.ShowDialog()
    End Sub

    Private Sub BTN_EMITIR_Click(sender As Object, e As EventArgs) Handles BTN_EMITIR.Click
        Try
            conexion = ObtenerConexion()
            conexion.Open()

            ' Insertar cabecera y devolver el ID generado
            Dim CabInventario As String = "INSERT INTO Cabecera_Inventario (Autor, Total_Monto, Fecha_Inventario) 
                                       VALUES (@Autor, @Total_Monto, @Fecha_Inventario) 
                                       RETURNING Id_CabInventario"
            Dim ComandoCab As New NpgsqlCommand(CabInventario, conexion)

            ComandoCab.Parameters.AddWithValue("@Autor", TB_AutorCargarInventario.Text)
            ComandoCab.Parameters.AddWithValue("@Total_Monto", Convert.ToDecimal(TB_TotalCagarInventario.Tag))
            ComandoCab.Parameters.AddWithValue("@Fecha_Inventario", DTP_FechaEmision.Value)

            Dim Id_CabInventario As Integer = Convert.ToInt32(ComandoCab.ExecuteScalar())

            For Each row As DataGridViewRow In DGV_CargaInventario.Rows
                If Not row.IsNewRow Then
                    Dim idProducto As Integer = Convert.ToInt32(row.Cells("Id_Producto").Value)
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("Cantidad").Value)
                    Dim subtotal As Decimal = Convert.ToDecimal(row.Cells("Subtotal").Value)

                    ' Insertar detalle de inventario
                    Dim DetInventario As String = "INSERT INTO Detalle_Inventario 
                                               (Id_CabInventario, Id_Producto, Cantidad, Subtotal) 
                                               VALUES (@Id_CabInventario, @Id_Producto, @Cantidad, @Subtotal)"
                    Dim ComandoDet As New NpgsqlCommand(DetInventario, conexion)
                    ComandoDet.Parameters.AddWithValue("@Id_CabInventario", Id_CabInventario)
                    ComandoDet.Parameters.AddWithValue("@Id_Producto", idProducto)
                    ComandoDet.Parameters.AddWithValue("@Cantidad", cantidad)
                    ComandoDet.Parameters.AddWithValue("@Subtotal", subtotal)
                    ComandoDet.ExecuteNonQuery()

                    ' Reemplazar el stock del producto con la nueva cantidad
                    Dim UpdateStock As String = "UPDATE productos SET stock = @Cantidad WHERE id_producto = @Id_Producto"
                    Dim ComandoUpdate As New NpgsqlCommand(UpdateStock, conexion)
                    ComandoUpdate.Parameters.AddWithValue("@Cantidad", cantidad)  ' Reemplaza el stock por la nueva cantidad
                    ComandoUpdate.Parameters.AddWithValue("@Id_Producto", idProducto)
                    ComandoUpdate.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Inventario emitido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DGV_CargaInventario.Rows.Clear()
            Mostrar_Productos()
            DetalleInv()

        Catch ex As Exception
            MessageBox.Show("Error al emitir el inventario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    'Final pestaña Inventario

    'Inicio pestaña Ventas

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label25.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub limpiarcamposventas()
        TB_CantidadSencillo.Clear()
        TB_ProductoSencillo.Clear()
        TB_PrecioSencillo.Clear()
        TB_ClienteSencillo.Clear()
        TB_TotalVentasHoy.Clear()
        TB_Pago.Clear()

        DGV_ProductosCierre.Rows.Clear()

        TB_CodigoSencillo.Focus()

    End Sub

    Private Sub BTN_GuardarSencillo_Click(sender As Object, e As EventArgs) Handles BTN_GuardarSencillo.Click
        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()

                Dim apertura As Decimal = Convert.ToDecimal(TB_SencilloApertura.Text)
                Dim autor As String = TB_AutorCierre.Text
                Dim query As String = "INSERT INTO Arqueo (AutorCierre, SencilloApertura, SencilloCierre, Sobrante, Faltante, FechaArqueo)
                                   VALUES (@AutorCierre ,@apertura, 0, 0, 0, now()) RETURNING Id_Arqueo"
                Dim cmd As New NpgsqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@AutorCierre", autor)
                cmd.Parameters.AddWithValue("@apertura", apertura)

                Dim idArqueo As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                MessageBox.Show("Sencillo guardado correctamente. Id_Arqueo generado: " & idArqueo)
                TB_AutorCierre.Enabled = False
                TB_SencilloApertura.Enabled = False
                BTN_GuardarSencillo.Enabled = False

                ' Guardamos el Id_Arqueo para futuras operaciones
                IdArqueoActual = idArqueo
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar sencillo: " & ex.Message)
        End Try
    End Sub

    Private AutorCierre As String
    Private IdArqueoActual As Integer

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
                            TB_AutorCierre.Text = reader("AutorCierre").ToString()
                            IdArqueoActual = Convert.ToInt32(reader("Id_Arqueo"))
                            Dim apertura As Decimal = Convert.ToDecimal(reader("SencilloApertura"))

                            TB_SencilloApertura.Text = apertura.ToString("N0")
                            TB_AutorCierre.Enabled = False
                            TB_SencilloApertura.Enabled = False
                            BTN_GuardarSencillo.Enabled = False
                        Else
                            ' No hay arqueo activo, habilitamos para nuevo sencillo
                            TB_AutorCierre.Enabled = True
                            TB_SencilloApertura.Enabled = True
                            BTN_GuardarSencillo.Enabled = True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar sencillo abierto: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_GuardarCierre_Click(sender As Object, e As EventArgs) Handles BTN_GuardarCierre.Click
        Try
            Dim cierre As Decimal = Convert.ToDecimal(TB_SencilloCierre.Text)
            Dim query As String = "UPDATE Arqueo SET SencilloCierre = @cierre, 
                               Sobrante = CASE WHEN @cierre - Ventas > 0 THEN (@cierre - Ventas) ELSE 0 END,
                               Faltante = CASE WHEN @cierre - Ventas < 0 THEN ABS(@cierre - Ventas) ELSE 0 END
                               WHERE Id_Arqueo = @id"

            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()
                Dim cmd As New NpgsqlCommand(query, conexion)
                cmd.Parameters.AddWithValue("@cierre", cierre)
                cmd.Parameters.AddWithValue("@id", IdArqueoActual)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cierre de caja actualizado correctamente.")
                TB_AutorCierre.Enabled = True
                TB_SencilloApertura.Enabled = True
                BTN_GuardarSencillo.Enabled = True
                TB_AutorCierre.Clear()
                TB_SencilloApertura.Clear()
                TB_SencilloCierre.Clear()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al emitir cierre: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_CargarProducto_Click(sender As Object, e As EventArgs) Handles BTN_CargarProductoSencillo.Click
        Try
            Dim Id_Producto_Cierre As Integer = Convert.ToInt32(TB_IdProductoCierre.Text)
            Dim Codigo_Cierre As Integer = Convert.ToInt32(TB_CodigoSencillo.Text)
            Dim Producto_Cierre As String = TB_ProductoSencillo.Text
            Dim Stock_cierre As Integer = Convert.ToInt32(TB_StockCierre.Text)
            Dim Precio_Cierre As Decimal = Convert.ToDecimal(TB_PrecioSencillo.Text)
            Dim Cantidad_Cierre As Integer = Convert.ToInt32(TB_CantidadSencillo.Text)

            ' Validación de stock
            If Cantidad_Cierre > Stock_cierre Then
                MessageBox.Show("No hay suficiente stock disponible para este producto.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CantidadSencillo.Focus()
                Return
            ElseIf Stock_cierre = 0 Then
                MessageBox.Show("El producto no tiene stock disponible.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CodigoSencillo.Focus()
                Return
            End If

            Dim subtotal_cierre As Decimal = Precio_Cierre * Cantidad_Cierre
            DGV_ProductosCierre.Rows.Add(Id_Producto_Cierre, Codigo_Cierre, Producto_Cierre, Stock_cierre, Precio_Cierre, Cantidad_Cierre, subtotal_cierre)
            CalcularTotalesCierre()
        Catch ex As Exception
            MessageBox.Show("Error al cargar producto: " & ex.Message)
        End Try
    End Sub

    Private Sub BuscarProductosPorCodigoVentas(codigo As String)
        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                Dim consulta As String = "SELECT id_producto,nombre_productos, precio, stock FROM productos WHERE codigo = @codigo"
                Using cmd As New NpgsqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@codigo", codigo)

                    conexion.Open()
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TB_IdProductoCierre.Text = reader("id_producto").ToString()
                            TB_ProductoSencillo.Text = reader("nombre_productos").ToString()
                            TB_StockCierre.Text = reader("stock").ToString()
                            TB_PrecioSencillo.Text = reader("precio").ToString()
                            TB_CantidadSencillo.Focus()
                        Else
                            MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            TB_CodigoSencillo.Focus()
                            TB_ProductoSencillo.Clear()
                            TB_PrecioSencillo.Clear()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TB_CodigoCargarVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CodigoSencillo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_CodigoSencillo.Text) Then
                MessageBox.Show("Ingrese el código del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CodigoSencillo.Focus()
                Return
            End If
            BuscarProductosPorCodigoVentas(TB_CodigoSencillo.Text)
        End If

        If e.KeyCode = Keys.F5 Then
            TB_Pago.Focus()
        End If

    End Sub

    Private Sub TB_CodigoCantidadSencillo_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CantidadSencillo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_CantidadSencillo.Text) Then
                MessageBox.Show("Ingrese la cantidad del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CantidadSencillo.Focus()
                Return
            End If

            Try
                Dim Id_Producto_Cierre As Integer = Convert.ToInt32(TB_IdProductoCierre.Text)
                Dim Codigo_Cierre As Integer = Convert.ToInt32(TB_CodigoSencillo.Text)
                Dim Producto_Cierre As String = TB_ProductoSencillo.Text
                Dim Stock_cierre As Integer = Convert.ToInt32(TB_StockCierre.Text)
                Dim Precio_Cierre As Decimal = Convert.ToDecimal(TB_PrecioSencillo.Text)
                Dim Cantidad_Cierre As Integer = Convert.ToInt32(TB_CantidadSencillo.Text)


                ' Validación de stock
                If Cantidad_Cierre > Stock_cierre Then
                    MessageBox.Show("No hay suficiente stock disponible para este producto.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TB_CantidadSencillo.Focus()
                    Return
                ElseIf Stock_cierre = 0 Then
                    MessageBox.Show("El producto no tiene stock disponible.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TB_CodigoSencillo.Focus()
                    Return
                End If

                Dim subtotal_cierre As Decimal = Precio_Cierre * Cantidad_Cierre
                DGV_ProductosCierre.Rows.Add(Id_Producto_Cierre, Codigo_Cierre, Producto_Cierre, Stock_cierre, Precio_Cierre, Cantidad_Cierre, subtotal_cierre)
                TB_CodigoSencillo.Focus()
                TB_CodigoSencillo.Clear()
                TB_CantidadSencillo.Clear()
                TB_PrecioSencillo.Clear()
                TB_ProductoSencillo.Clear()
                TB_StockCierre.Clear()
                CalcularTotalesCierre()
            Catch ex As Exception
                MessageBox.Show("Error al cargar producto: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub CalcularTotalesCierre()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DGV_ProductosCierre.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("Subtotal_cierre").Value)
            End If
        Next

        TB_TotalVentasHoy.Text = total.ToString("N0") & " GS"  ' Visual
        TB_TotalVentasHoy.Tag = total                         ' Real valor
    End Sub


    Private Sub BTN_EmitirVenta_Click(sender As Object, e As EventArgs) Handles BTN_EmitirVentaSencillo.Click
        Dim total As Decimal
        Dim pago As Decimal


        ' Validar valores numéricos ingresados
        If Not Decimal.TryParse(TB_TotalVentasHoy.Tag.ToString(), total) Then
            MessageBox.Show("El total de la venta no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Decimal.TryParse(TB_Pago.Text, pago) Then
            MessageBox.Show("El pago ingresado no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_Pago.Focus()
            Exit Sub
        End If

        If pago < total Then
            MessageBox.Show("El pago no puede ser menor al total de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TB_Pago.Focus()
            Exit Sub
        End If

        Dim vuelto As Decimal = pago - total

        ' PROCESO DE VENTA
        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()

                ' 1. Insertar cabecera de venta
                Dim queryCab As String = "
                INSERT INTO Cabecera_Ventas (Id_Arqueo, Cliente, Fecha_venta, Pago, Montototal, Vuelto)
                VALUES (@arqueo, @cliente, NOW(), @Pago, @Montototal, @Vuelto) 
                RETURNING Id_CabVentas"
                Dim cmdCab As New NpgsqlCommand(queryCab, conexion)
                cmdCab.Parameters.AddWithValue("@arqueo", IdArqueoActual)
                cmdCab.Parameters.AddWithValue("@cliente", TB_ClienteSencillo.Text)
                cmdCab.Parameters.AddWithValue("@Pago", Convert.ToDecimal(TB_Pago.Text))
                cmdCab.Parameters.AddWithValue("@Montototal", total)
                cmdCab.Parameters.AddWithValue("@Vuelto", vuelto)
                Dim idCabecera As Integer = Convert.ToInt32(cmdCab.ExecuteScalar())

                ' 2. Insertar detalles desde el DataGridView
                For Each row As DataGridViewRow In DGV_ProductosCierre.Rows
                    If row.IsNewRow Then Continue For

                    Dim idProducto As Integer = Convert.ToInt32(row.Cells("id_producto_cierre").Value)
                    Dim codigo As Integer = Convert.ToInt32(row.Cells("codigo_cierre").Value)
                    Dim nombreProd As String = row.Cells("producto_cierre").Value.ToString()
                    Dim cantidad As Integer = Convert.ToInt32(row.Cells("cantidad_cierre").Value)
                    Dim precio As Decimal = Convert.ToDecimal(row.Cells("precio_cierre").Value)
                    Dim subtotal As Decimal = cantidad * precio

                    ' Insertar detalle de venta
                    Dim cmdDet As New NpgsqlCommand("
                    INSERT INTO detalle_ventas 
                    (Id_CabVentas, Id_producto, Codigo, Nombre_productos, Cantidad, Precio, SubTotal)
                    VALUES (@cab, @prod, @codigo, @nombre, @cant, @precio, @subtotal)", conexion)

                    cmdDet.Parameters.AddWithValue("@cab", idCabecera)
                    cmdDet.Parameters.AddWithValue("@prod", idProducto)
                    cmdDet.Parameters.AddWithValue("@codigo", codigo)
                    cmdDet.Parameters.AddWithValue("@nombre", nombreProd)
                    cmdDet.Parameters.AddWithValue("@cant", cantidad)
                    cmdDet.Parameters.AddWithValue("@precio", precio)
                    cmdDet.Parameters.AddWithValue("@subtotal", subtotal)
                    cmdDet.ExecuteNonQuery()

                    ' 3. Actualizar stock del producto
                    Dim updateStock As String = "UPDATE productos SET stock = stock - @Cantidad WHERE id_producto = @Id_Producto"
                    Dim cmdUpdate As New NpgsqlCommand(updateStock, conexion)
                    cmdUpdate.Parameters.AddWithValue("@Cantidad", cantidad)
                    cmdUpdate.Parameters.AddWithValue("@Id_Producto", idProducto)
                    cmdUpdate.ExecuteNonQuery()
                Next

                ' 4. Mostrar vuelto
                MessageBox.Show("Venta registrada correctamente." & vbCrLf & "VUELTO DEL CLIENTE: " & vuelto.ToString("N0") & " Gs.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 5. Limpiar campos y actualizar vista
                limpiarcamposventas()
                Mostrar_Productos()
                MostrarVentas()
            End Using

        Catch ex As PostgresException When ex.SqlState = "23503"
            MessageBox.Show("Abre una caja para poder emitir una venta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show("Error al emitir venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TB_Pago_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_Pago.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_Pago.Text) Then
                MessageBox.Show("Ingrese el pago del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_Pago.Focus()
                Return
            End If
            BTN_EmitirVentaSencillo.Focus()
        End If
    End Sub

    Private Sub DGV_ProductosCierre_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV_ProductosCierre.RowsAdded
        CalcularTotalesCierre()
    End Sub

    Private Sub DGV_ProductosCierre_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV_ProductosCierre.RowsRemoved
        CalcularTotalesCierre()
    End Sub

    Private Sub DGV_ProductosCierre_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ProductosCierre.CellEndEdit
        If DGV_ProductosCierre.Columns(e.ColumnIndex).Name = "Cantidad_Cierre" Then
            Dim fila As DataGridViewRow = DGV_ProductosCierre.Rows(e.RowIndex)

            Try
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad_Cierre").Value)
                Dim stock As Integer = Convert.ToInt32(fila.Cells("Stock_Cierre").Value)

                If cantidad > stock Then
                    MessageBox.Show("La cantidad no puede ser mayor al stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    fila.Cells("Cantidad_Cierre").Value = stock ' Revertir al máximo permitido
                    cantidad = stock
                End If

                ' Cálculo del subtotal
                Dim precio As Decimal = Convert.ToDecimal(fila.Cells("Precio_Cierre").Value)
                Dim subtotal As Decimal = cantidad * precio
                fila.Cells("Subtotal_Cierre").Value = subtotal
                CalcularTotalesCierre()

            Catch ex As Exception
                MessageBox.Show("Verifica que los valores ingresados sean válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'Inicio pestaña de verificar ventas

    Private Sub MostrarVentas()
        Dim Consulta As String = "Select * from cabecera_ventas order by Id_CabVentas"
        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Dim adaptador As New NpgsqlDataAdapter(Consulta, conexion)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                DGV_VerVentas.DataSource = tabla
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas: " & ex.Message)
        End Try
    End Sub

    Private Sub FiltroVerVentas()
        Dim consulta As String = "SELECT * FROM Cabecera_ventas WHERE 1=1" ' base de la consulta

        ' Filtro por fecha (solo si está activado)
        If DTP_FechaVerVentas.Checked Then
            consulta &= " AND Fecha_venta::date = @Fecha_venta"
        End If

        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()
                Using comando As New NpgsqlCommand(consulta, conexion)

                    ' Solo agrega el parámetro si el filtro de fecha está activo
                    If DTP_FechaVerVentas.Checked Then
                        comando.Parameters.AddWithValue("@Fecha_venta", DTP_FechaVerVentas.Value.Date)
                    End If

                    Dim da As New NpgsqlDataAdapter(comando)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    DGV_VerVentas.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al filtrar los productos: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_FiltrarVerificarVentas_Click(sender As Object, e As EventArgs) Handles BTN_FiltrarVerificarVentas.Click
        FiltroVerVentas()
    End Sub

    Private Sub DGV_VerVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles DGV_VerVentas.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DGV_VerVentas.HitTest(e.X, e.Y)

            ' Verificar si se hizo clic en una fila válida
            If hit.RowIndex >= 0 Then
                DGV_VerVentas.ClearSelection()
                DGV_VerVentas.Rows(hit.RowIndex).Selected = True
                Click_Derecho_Ventas.Show(DGV_VerVentas, e.Location)
            End If
        End If
    End Sub

    Private Sub DTP_FechaVerVentas_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechaVerVentas.ValueChanged
        FiltroVerVentas()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DETALLEVENTAToolStripMenuItem.Click
        If DGV_VerVentas.SelectedRows.Count > 0 Then
            ' Obtener el Id_Cabecera_Ven de la fila seleccionada
            Dim Id_CabVentas As Integer = Convert.ToInt32(DGV_VerVentas.SelectedRows(0).Cells("Id_CabVentas").Value)

            ' Abrir el formulario de detalles con el ID de la factura
            Dim DetVentas As New VerVentas(Id_CabVentas)
            DetVentas.ShowDialog()
        Else
            MessageBox.Show("Seleccione una factura para ver el detalle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ANULARVENTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ANULARVENTAToolStripMenuItem.Click

        Dim idVenta As Integer = CInt(DGV_VerVentas.CurrentRow.Cells("Id_CabVentas").Value)

        Try
            conexion.Open()

            ' Verificar si la venta ya está anulada
            Dim cmdVerificar As New NpgsqlCommand("SELECT Anulado FROM Cabecera_Ventas WHERE Id_CabVentas = @IdVenta", conexion)
            cmdVerificar.Parameters.AddWithValue("@IdVenta", idVenta)

            Dim yaAnulada As Boolean = CBool(cmdVerificar.ExecuteScalar())

            If yaAnulada Then
                MessageBox.Show("Esta venta ya fue anulada anteriormente.", "Venta ya anulada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Confirmar anulación
            Dim result As DialogResult = MessageBox.Show("¿Estás seguro de anular esta venta?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim transaccion As NpgsqlTransaction = conexion.BeginTransaction()

                ' Obtener productos vendidos
                Dim cmdDetalle As New NpgsqlCommand("SELECT id_producto, cantidad FROM detalle_ventas WHERE id_cabventas = @IdVenta", conexion, transaccion)
                cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta)

                Dim productos As New List(Of (Integer, Integer))
                Using lector As NpgsqlDataReader = cmdDetalle.ExecuteReader()
                    While lector.Read()
                        productos.Add((lector.GetInt32(0), lector.GetInt32(1)))
                    End While
                    lector.Close()
                End Using

                ' Devolver stock
                For Each prod In productos
                    Dim cmdStock As New NpgsqlCommand("UPDATE productos SET stock = stock + @Cantidad WHERE id_producto = @Id_Producto", conexion, transaccion)
                    cmdStock.Parameters.AddWithValue("@Cantidad", prod.Item2)
                    cmdStock.Parameters.AddWithValue("@Id_Producto", prod.Item1)
                    cmdStock.ExecuteNonQuery()
                Next

                ' Obtener el MontoTotal original desde la base de datos
                Dim cmdMontoOriginal As New NpgsqlCommand("SELECT Montototal FROM Cabecera_Ventas WHERE Id_CabVentas = @IdVenta", conexion, transaccion)
                cmdMontoOriginal.Parameters.AddWithValue("@IdVenta", idVenta)
                Dim montoOriginal As Decimal = Convert.ToDecimal(cmdMontoOriginal.ExecuteScalar())

                ' Montototal a 0
                Dim cmdMonto As New NpgsqlCommand("UPDATE cabecera_ventas SET Montototal = 0 WHERE Id_CabVentas = @Id_CabVentas", conexion, transaccion)
                cmdMonto.Parameters.AddWithValue("@Id_CabVentas", idVenta)
                cmdMonto.ExecuteNonQuery()

                ' Anular venta
                Dim cmdAnular As New NpgsqlCommand("UPDATE Cabecera_Ventas SET Anulado = TRUE WHERE Id_CabVentas = @Id_CabVentas", conexion, transaccion)
                cmdAnular.Parameters.AddWithValue("@Id_CabVentas", idVenta)
                cmdAnular.ExecuteNonQuery()

                ' Reducir el monto al arqueo
                Dim cmdReducirMonto As New NpgsqlCommand("
                UPDATE Arqueo 
                SET Ventas = Ventas - @Montototal 
                WHERE Id_Arqueo = (SELECT Id_Arqueo FROM Cabecera_Ventas WHERE Id_CabVentas = @Id_CabVentas)", conexion, transaccion)
                cmdReducirMonto.Parameters.AddWithValue("@Montototal", montoOriginal)
                cmdReducirMonto.Parameters.AddWithValue("@Id_CabVentas", idVenta)
                cmdReducirMonto.ExecuteNonQuery()

                transaccion.Commit()

                MessageBox.Show("Venta anulada correctamente.")
                MostrarVentas()
            Else
                MessageBox.Show("Operación cancelada.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al anular la venta: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try

    End Sub



    'Fin pestaña de verificar ventas

    'Inicio pestaña de cargar compras

    Private Sub TB_CodCompras_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CodCompras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_CodCompras.Text) Then
                MessageBox.Show("Ingrese el código del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CodCompras.Focus()
                Return
            End If
            BuscarProductosPorCodigoCompras(TB_CodCompras.Text)
        End If
    End Sub

    Private Sub TB_PrecioCompras_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_PrecioCompras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_PrecioCompras.Text) Then
                MessageBox.Show("Ingrese el precio de compra del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_PrecioCompras.Focus()
                Return
            End If
            TB_CantidadCompras.Focus()
        End If
    End Sub

    Private Sub TB_CantidadCompras_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CantidadCompras.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrWhiteSpace(TB_CantidadCompras.Text) Then
                MessageBox.Show("Ingrese la cantidad del producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TB_CantidadCompras.Focus()
                Return
            End If

            Dim codigoBuscado As String = TB_CodCompras.Text.Trim()

            Dim consulta As String = "SELECT id_producto, nombre_productos, Id_rubro, Nombre_Rubro FROM productos WHERE codigo = @codigo"

            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()

                Using cmd As New NpgsqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@codigo", codigoBuscado)

                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then

                            Dim idProducto As Integer = Convert.ToInt32(reader("id_producto"))
                            Dim Producto As String = reader("nombre_productos").ToString()


                            Dim precio As Decimal
                            If Not Integer.TryParse(TB_PrecioCompras.Text, precio) Then
                                MessageBox.Show("El precio ingresado no es válido.")
                                Return
                            End If

                            Dim cantidad As Integer
                            If Not Integer.TryParse(TB_CantidadCompras.Text, cantidad) Then
                                MessageBox.Show("La cantidad ingresada no es válida.")
                                Return
                            End If

                            Dim subtotal As Decimal = precio * cantidad

                            Dim Rubro As String = reader("Id_rubro").ToString()
                            Dim Nombre_Rubro As String = reader("Nombre_Rubro").ToString()


                            ' Agregamos la fila al DataGridView
                            DGV_Compras.Rows.Add(idProducto, Producto, codigoBuscado, precio, cantidad, subtotal, Rubro, Nombre_Rubro)

                            ' Limpiamos campos
                            TB_CodCompras.Clear()
                            TB_NombreProductoCompras.Clear()
                            TB_PrecioCompras.Clear()
                            TB_CantidadCompras.Clear()

                            TB_CodCompras.Focus()
                            CalcularTotalesCargarCompras()

                        Else
                            MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            TB_CodCompras.Focus()
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub CalcularTotalesCargarCompras()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DGV_Compras.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells("SubtotalCompras").Value)
            End If
        Next

        TB_TotalCompras.Text = total.ToString("N0") ' solo el número formateado
        TB_TotalCompras.Tag = total ' guardás el valor original aquí
    End Sub

    Private Sub BuscarProductosPorCodigoCompras(codigo As String)
        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                Dim consulta As String = "SELECT nombre_productos FROM productos WHERE codigo = @codigo"
                Using cmd As New NpgsqlCommand(consulta, conexion)
                    cmd.Parameters.AddWithValue("@codigo", codigo)

                    conexion.Open()
                    Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TB_NombreProductoCompras.Text = reader("nombre_productos").ToString()
                            TB_PrecioCompras.Focus()
                        Else
                            MessageBox.Show("Producto no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            TB_CodCompras.Focus()
                            TB_NombreProductoCompras.Clear()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DGV_Compras_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV_Compras.RowsAdded
        CalcularTotalesCargarCompras()
    End Sub

    Private Sub DGV_Compras_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGV_Compras.RowsRemoved
        CalcularTotalesCargarCompras()
    End Sub

    Private Sub BTN_CargarCompras_Click(sender As Object, e As EventArgs) Handles BTN_CargarCompras.Click
        Try
            Using conexion As NpgsqlConnection = ObtenerConexion()
                conexion.Open()

                ' Validaciones
                Dim total As Decimal = Convert.ToDecimal(TB_TotalCompras.Tag)

                Dim numFactura As Integer
                If Not Integer.TryParse(TB_NumFacturaCompras.Text, numFactura) Then
                    MessageBox.Show("Número de factura inválido.")
                    Exit Sub
                End If

                Dim Timbrado As Integer
                If Not Integer.TryParse(TB_TimbradoCompras.Text, Timbrado) Then
                    MessageBox.Show("Número de timbrado inválido.")
                    Exit Sub
                End If

                ' Insertar cabecera de compra
                Dim queryCabCompras As String = "INSERT INTO Cabecera_Compras 
                (Proveedor, RUC, NumFactura, Timbrado, Prefijo, Montototal) 
                VALUES 
                (@Proveedor, @RUC, @NumFactura, @Timbrado, @Prefijo, @Montototal) 
                RETURNING Id_CabCompras"

                Dim cmdCabCompras As New NpgsqlCommand(queryCabCompras, conexion)
                cmdCabCompras.Parameters.AddWithValue("@Proveedor", TB_NombreProveedor.Text)
                cmdCabCompras.Parameters.AddWithValue("@RUC", TB_RucProveedor.Text)
                cmdCabCompras.Parameters.AddWithValue("@NumFactura", numFactura)
                cmdCabCompras.Parameters.AddWithValue("@Timbrado", Timbrado)
                cmdCabCompras.Parameters.AddWithValue("@Prefijo", TB_PrefijoCompras.Text)
                cmdCabCompras.Parameters.AddWithValue("@Montototal", total)

                Dim idCabCompras As Integer = Convert.ToInt32(cmdCabCompras.ExecuteScalar())

                ' Insertar detalles
                For Each row As DataGridViewRow In DGV_Compras.Rows
                    If row.IsNewRow Then Continue For

                    Dim idProductoCompras As Integer
                    If Not Integer.TryParse(row.Cells("Id_productocompras").Value.ToString(), idProductoCompras) Then Continue For

                    Dim codigoCompras As String = row.Cells("CodigoCompras").Value.ToString()
                    Dim nombreProdCompras As String = row.Cells("ProductoCompras").Value.ToString()
                    Dim cantidadCompras As Integer
                    If Not Integer.TryParse(row.Cells("CantidadCompras").Value.ToString(), cantidadCompras) Then Continue For

                    Dim precioCompras As Decimal
                    If Not Decimal.TryParse(row.Cells("PrecioCompras").Value.ToString().Replace(".", ","), precioCompras) Then Continue For

                    Dim subtotalCompras As Decimal = cantidadCompras * precioCompras

                    Dim cmdDetCompras As New NpgsqlCommand("INSERT INTO Detalle_Compras 
                    (Id_CabCompras, Id_producto, Codigo, Nombre_productos, Cantidad, Compra, SubTotal) 
                    VALUES (@Id_CabCompras, @Id_producto, @Codigo, @Nombre_productos, @Cantidad, @Compra, @SubTotal)", conexion)

                    cmdDetCompras.Parameters.AddWithValue("@Id_CabCompras", idCabCompras)
                    cmdDetCompras.Parameters.AddWithValue("@Id_producto", idProductoCompras)
                    cmdDetCompras.Parameters.AddWithValue("@Codigo", codigoCompras)
                    cmdDetCompras.Parameters.AddWithValue("@Nombre_productos", nombreProdCompras)
                    cmdDetCompras.Parameters.AddWithValue("@Cantidad", cantidadCompras)
                    cmdDetCompras.Parameters.AddWithValue("@Compra", precioCompras)
                    cmdDetCompras.Parameters.AddWithValue("@SubTotal", subtotalCompras)
                    cmdDetCompras.ExecuteNonQuery()

                    ' Actualizar producto
                    Dim updateCompra As New NpgsqlCommand("UPDATE productos SET compra = @Compra WHERE id_producto = @Id_Producto", conexion)
                    updateCompra.Parameters.AddWithValue("@Compra", precioCompras)
                    updateCompra.Parameters.AddWithValue("@Id_Producto", idProductoCompras)
                    updateCompra.ExecuteNonQuery()

                    Dim updateStock As New NpgsqlCommand("UPDATE productos SET stock = stock + @Cantidad WHERE id_producto = @Id_Producto", conexion)
                    updateStock.Parameters.AddWithValue("@Cantidad", cantidadCompras)
                    updateStock.Parameters.AddWithValue("@Id_Producto", idProductoCompras)
                    updateStock.ExecuteNonQuery()
                Next

                MessageBox.Show("Compra registrada correctamente.")
                limpiarcamposcompras()
                Mostrar_Productos()
                MostrarVentas()
                MostrarCompras()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al emitir la compra: " & ex.Message)
        End Try
    End Sub

    Private Sub limpiarcamposcompras()

        TB_CantidadCompras.Clear()
        TB_CodCompras.Clear()
        TB_NombreProductoCompras.Clear()
        TB_PrecioCompras.Clear()
        TB_NombreProveedor.Clear()
        TB_RucProveedor.Clear()
        TB_TimbradoCompras.Clear()
        TB_PrefijoCompras.Clear()
        TB_NumFacturaCompras.Clear()
        TB_TotalCompras.Clear()
        DGV_Compras.Rows.Clear()

    End Sub

    'Fin pestaña de cargar compras

    'Inicio pestaña de verificar compras

    Private Sub MostrarCompras()
        Dim Consulta As String = "Select * from Cabecera_Compras order by Id_CabCompras"
        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Dim adaptador As New NpgsqlDataAdapter(Consulta, conexion)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                DGV_VerCompras.DataSource = tabla
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las compras: " & ex.Message)
        End Try
    End Sub

    Private Sub FiltrarCompras()

        Dim filtro As String = CB_FiltroVerCompras.SelectedItem.ToString()
        Dim columnasValidas As String() = {"numfactura", "timbrado", "ruc", "proveedor"}

        If Not columnasValidas.Contains(filtro) Then
            MessageBox.Show("Filtro no válido seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Columnas que no son de tipo texto
        Dim columnasNoTexto As String() = {"numfactura", "timbrado"}
        Dim necesitaCast As Boolean = columnasNoTexto.Contains(filtro)

        ' Armar la consulta
        Dim consulta As String

        If DTP_FechaVerCompras.Checked Then
            consulta = If(necesitaCast,
                $"SELECT * FROM cabecera_compras WHERE CAST({filtro} AS TEXT) ILIKE @busqueda AND fechacompra = @fecha",
                $"SELECT * FROM cabecera_compras WHERE {filtro} ILIKE @busqueda AND fechacompra = @fecha")
        Else
            consulta = If(necesitaCast,
                $"SELECT * FROM cabecera_compras WHERE CAST({filtro} AS TEXT) ILIKE @busqueda",
                $"SELECT * FROM cabecera_compras WHERE {filtro} ILIKE @busqueda")
        End If

        Try
            Using conexion = ObtenerConexion()
                conexion.Open()
                Using comando As New NpgsqlCommand(consulta, conexion)
                    comando.Parameters.AddWithValue("@busqueda", "%" & TB_FiltroVerCompras.Text & "%")

                    If DTP_FechaVerCompras.Checked Then
                        comando.Parameters.AddWithValue("@fecha", DTP_FechaVerCompras.Value.Date)
                    End If

                    Dim da As New NpgsqlDataAdapter(comando)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DGV_VerCompras.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al filtrar las compras: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DTP_FechaVerCompras_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FechaVerCompras.ValueChanged
        FiltrarCompras()
    End Sub

    Private Sub BTN_FiltroVerCompras_Click(sender As Object, e As EventArgs) Handles BTN_FiltroVerCompras.Click
        FiltrarCompras()
    End Sub

    Private Sub DGV_VerCompras_MouseDown(sender As Object, e As MouseEventArgs) Handles DGV_VerCompras.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DGV_VerCompras.HitTest(e.X, e.Y)
            ' Verificar si se hizo clic en una fila válida
            If hit.RowIndex >= 0 Then
                DGV_VerCompras.ClearSelection()
                DGV_VerCompras.Rows(hit.RowIndex).Selected = True
                Click_Derecho_Compras.Show(DGV_VerCompras, e.Location)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles VERDETALLEDECOMPRASToolStripMenuItem1.Click
        If DGV_VerCompras.SelectedRows.Count > 0 Then
            Dim Id_CabCompras As Integer = Convert.ToInt32(DGV_VerCompras.SelectedRows(0).Cells("Id_CabCompras").Value)
            Dim DetCompras As New VerCompras(Id_CabCompras)
            DetCompras.ShowDialog()
        Else
            MessageBox.Show("Seleccione una compra para ver el detalle.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Fin pestaña de cargar compras

    'Inicio pestaña de verificar cierres

    Private Sub BTN_VerArqueos_Click(sender As Object, e As EventArgs) Handles BTN_VerArqueos.Click
        Dim VerCierre As New VerArqueos()
        VerCierre.ShowDialog()
    End Sub

    'Fin pestaña de verificar cierres

    'Inicio pestaña de gastos

    Private Sub BTN_Gastos_Click(sender As Object, e As EventArgs) Handles BTN_Gastos.Click
        Dim Gastos As New CargarGastos()
        Gastos.ShowDialog()
    End Sub

    'Fin pestaña de gastos

End Class