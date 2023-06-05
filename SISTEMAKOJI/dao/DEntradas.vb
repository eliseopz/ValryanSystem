Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class DEntradas
    Dim strConn As String = My.Settings.strConnectionn.ToString()

    Public Function MostrarEntradas() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "select idEntrada as N'Codigo', unidades as N'Unidades Entrantes', fechaEntrada as N'Fecha', precioEntrada as N'Precio de Entrada', observacionesEntrada as N'Observaciones',idProducto as N'Producto', idUsuario as N'Usuario' from Entradas"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    Public Function GuardarEntradas(ByVal entrada As Entrada) As Boolean
        Dim resultado As Boolean = False
        Try

            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            Dim tSql = "insert into Entradas(idEntrada, unidades, fechaEntrada, precioEntrada, observacionesEntrada, idProducto, idUsuario) values(@idEntrada, @unidades, @fechaEntrada, @precioEntrada, @observacionesEntrada, @idProducto, @idUsuario)"
            cmd.Parameters.AddWithValue("@idEntrada", entrada.IdEntrada)
            cmd.Parameters.AddWithValue("@unidades", entrada.Unidades)
            cmd.Parameters.AddWithValue("@fechaEntrada", entrada.FechaEntrada)
            cmd.Parameters.AddWithValue("@precioEntrada", entrada.PrecioEntrada)
            cmd.Parameters.AddWithValue("@observacionesEntrada", entrada.ObservacionesEntrada)
            cmd.Parameters.AddWithValue("@idProducto", entrada.IdProducto)
            cmd.Parameters.AddWithValue("@idUsuario", entrada.IdUsuario)
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

    Public Function EditarRegistro(ByVal entrada As Entrada) As Boolean
        Dim flag = False
        Try
            Dim tSql = "UPDATE Entradas SET unidades = @unidades, fechaEntrada = @fechaEntrada, precioEntrada = @precioEntrada, observacionesEntrada = @observacionesEntrada, idProducto = @idProducto, idUsuario = @idUsuario where idEntrada = @idEntrada"
            Dim conn As New SqlConnection(My.Settings.strConnectionn)
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.Parameters.AddWithValue("@idEntrada", entrada.IdEntrada)
            cmd.Parameters.AddWithValue("@unidades", entrada.Unidades)
            cmd.Parameters.AddWithValue("@fechaEntrada", entrada.FechaEntrada)
            cmd.Parameters.AddWithValue("@precioEntrada", entrada.PrecioEntrada)
            cmd.Parameters.AddWithValue("@observacionesEntrada", entrada.ObservacionesEntrada)
            cmd.Parameters.AddWithValue("@idProducto", entrada.IdProducto)
            cmd.Parameters.AddWithValue("@idUsuario", entrada.IdUsuario)
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                flag = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Error al intentar modificar los datos",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        Return flag
    End Function

    Public Function EliminarRegistro(ByVal idEntrada As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tSql As String = "delete from Entradas where idEntrada = @idEntrada"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idEntrada", idEntrada)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarRegistro(ByVal idEntrada As Integer) As Entrada
        Dim entrada As New Entrada
        Try
            Dim tSql As String = "select * from Entradas where idEntrada = @idEntrada"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idEntrada", idEntrada)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                entrada.IdEntrada = tbl.Rows(0).Item("idEntrada")
                entrada.Unidades = tbl.Rows(0).Item("unidades")
                entrada.FechaEntrada = tbl.Rows(0).Item("fechaEntrada")
                entrada.PrecioEntrada = tbl.Rows(0).Item("precioEntrada")
                entrada.ObservacionesEntrada = tbl.Rows(0).Item("observacionesEntrada")
                entrada.IdProducto = tbl.Rows(0).Item("idProducto")
                entrada.IdUsuario = tbl.Rows(0).Item("idUsuario")
            End If

        Catch ex As Exception

        End Try
        Return entrada
    End Function

    Public Function buscarRegistros(ByVal idEntrada As Integer) As DataSet
        Dim ds As New DataSet
        idEntrada = idEntrada + 0
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "select idEntrada as N'Codigo', unidades as N'Unidades Entrantes', fechaEntrada as N'Fecha', precioEntrada as N'Precio de Entrada', observacionesEntrada as N'Observaciones',idProducto as N'Producto', idUsuario as N'Usuario' from Entradas where idEntrada like @idEntrada"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idEntrada", idEntrada)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function


End Class

