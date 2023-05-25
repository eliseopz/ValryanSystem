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
            Dim tSql = "UPDATE Entradas SET unidades = @unidades, fechaEntrada = @fechaEntrada, precioEntrada = @precioEntrada, observacionesEntrada = @observacionesEntrada, idProducto = @idProducto, idCategoria = @idCategoria where idEntrada = @idEntrada"
            Dim conn As New SqlConnection(My.Settings.strConnectionn)
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.Parameters.AddWithValue("@idEntrada", entrada.IdEntrada)
            cmd.Parameters.AddWithValue("@unidades", entrada.Unidades)
            cmd.Parameters.AddWithValue("@fechaEntrada", entrada.FechaEntrada)
            cmd.Parameters.AddWithValue("@precioEntrada", entrada.PrecioEntrada)
            cmd.Parameters.AddWithValue("@observacionesEntrada", entrada.ObservacionesEntrada)
            cmd.Parameters.AddWithValue("@idProducto", entrada.IdProducto)
            cmd.Parameters.AddWithValue("@idUsuario", entrada.IdUsuario)
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
        Return flag
    End Function
End Class
