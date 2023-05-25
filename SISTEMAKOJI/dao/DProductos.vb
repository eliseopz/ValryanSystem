Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class DProductos
    Dim strConn As String = My.Settings.strConnectionn.ToString()

    Public Function MostrarRegistro() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "select idProducto as N'Codigo', nombreProducto as N'Producto', precioProducto as N'Precio', unidadesProducto as N'Unidades', unidadMedidaProducto as N'Tipo Unidades', descripcionProducto as N'Descripcion', idCategoria as N'Categoria' from Productos"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    Public Function GuardarProductos(ByVal producto As Producto) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            Dim tSql = "insert into Productos(idProducto, nombreProducto, precioProducto, unidadesProducto, unidadMedidaProducto, descripcionProducto, idCategoria) values(@idProducto, @nombreProducto, @precioProducto, @unidadesProducto, @unidadMedidaProducto, @descripcionProducto, @idCategoria)"
            cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto)
            cmd.Parameters.AddWithValue("@nombreProducto", producto.NombreProducto)
            cmd.Parameters.AddWithValue("@precioProducto", producto.PrecioProducto)
            cmd.Parameters.AddWithValue("@unidadesProducto", producto.UnidadesProducto)
            cmd.Parameters.AddWithValue("@unidadMedidaProducto", producto.UnidadMedidaProducto)
            cmd.Parameters.AddWithValue("@descripcionProducto", producto.DescripcionProducto)
            cmd.Parameters.AddWithValue("@idCategoria", producto.IdCategoria)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tSql
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resultado = True
            End If
            cmd.Connection.Close()

        Catch ex As Exception
            MsgBox("Error al intentar guardar los datos",
                   MsgBoxStyle.Critical, "ERROR")

        End Try
        Return resultado
    End Function

    Public Function EditarProductos(ByVal producto As Producto) As Boolean
        Dim flag = False
        Try
            Dim tSql = "UPDATE Productos SET nombreProducto = @nombreProducto, precioProducto = @precioProducto, unidadesProducto = @unidadesProducto, unidadMedidaProducto = @unidadMedidaProducto, descripcionProducto = @descripcionProducto, idCategoria = @idCategoria where idProducto = @idProducto "
            Dim conn As New SqlConnection(My.Settings.strConnectionn)
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.Parameters.AddWithValue("@idProducto", producto.IdProducto)
            cmd.Parameters.AddWithValue("@nombreProducto", producto.NombreProducto)
            cmd.Parameters.AddWithValue("@precioProducto", producto.PrecioProducto)
            cmd.Parameters.AddWithValue("@unidadesProducto", producto.UnidadesProducto)
            cmd.Parameters.AddWithValue("@unidadMedidaProducto", producto.UnidadMedidaProducto)
            cmd.Parameters.AddWithValue("@descripcionProducto", producto.DescripcionProducto)
            cmd.Parameters.AddWithValue("@idCategoria", producto.IdCategoria)
            'cmd.CommandText = tSql'
            'cmd.Connection = conn'
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                flag = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Error al intentar modificar los datos",
                  MsgBoxStyle.Critical, "ERROR")
        End Try

        Return False
    End Function

    Public Function EliminarProducto(ByVal idProducto As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tSql As String = "delete from Productos where idProducto = @idProducto"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idProducto", idProducto)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarProductoId(ByVal idProducto As Integer) As Producto
        Dim producto As New Producto
        Try
            Dim tSql As String = "select * from Productos where idProducto = @idProducto"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idProducto", idProducto)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                producto.IdProducto = tbl.Rows(0).Item("idProducto")
                producto.NombreProducto = tbl.Rows(0).Item("nombreProducto")
                producto.PrecioProducto = tbl.Rows(0).Item("precioProducto")
                producto.UnidadesProducto = tbl.Rows(0).Item("unidadesProducto")
                producto.UnidadMedidaProducto = tbl.Rows(0).Item("unidadMedidaProducto")
                producto.DescripcionProducto = tbl.Rows(0).Item("descripcionProducto")
                producto.IdCategoria = tbl.Rows(0).Item("idCategoria")
            End If
        Catch ex As Exception

        End Try
        Return producto
    End Function

    Public Function BuscarProductoNombre(ByVal nombreProducto As String) As DataSet
        Dim ds As New DataSet
        nombreProducto = nombreProducto + "%"
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "select idProducto as N'Codigo', nombreProducto as N'Producto', precioProducto as N'Precio', unidadesProducto as N'Unidades', unidadMedidaProducto as N'Tipo Unidades', descripcionProducto as N'Descripcion', idCategoria as N'Categoria' from Productos where nombreProducto like @nombreProducto"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreProducto", nombreProducto)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
