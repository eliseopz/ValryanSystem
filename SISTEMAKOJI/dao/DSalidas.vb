Imports System.Data.SqlClient
Public Class DSalidas
    Dim strConn As String = My.Settings.strConnectionn.ToString()

    Public Function MostrarSalidas() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select idSalida as N'Codigo', unidadesSalida as N'Unidades', fechaSalida as N'Fecha de Salida', precioSalida as N'Precio de Salida', observacionesSalida as N'Observaciones', idProducto as N'Producto', idUsuario as N'Usuario' from Salida"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    Public Function GuardarSalidas(ByVal salida As Salidas) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            Dim tSql = "insert into Salida(idSalida, unidadesSalida, fechaSalida, precioSalida, observacionesSalida, idProducto, idUsuario) values(@idSalida, @unidadesSalida, @fechaSalida, @precioSalida, @observacionesSalida, @idProducto, @idUsuario)"
            cmd.Parameters.AddWithValue("@idSalida", salida.IdSalida)
            cmd.Parameters.AddWithValue("@unidadesSalida", salida.UnidadesSalida)
            cmd.Parameters.AddWithValue("@fechaSalida", salida.FechaSalida)
            cmd.Parameters.AddWithValue("@precioSalida", salida.PrecioSalida)
            cmd.Parameters.AddWithValue("@observacionesSalida", salida.ObservacionesSalida)
            cmd.Parameters.AddWithValue("@idProducto", salida.IdProducto)
            cmd.Parameters.AddWithValue("@idUsuario", salida.IdUsuario)
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

    Public Function EditarSalidas(ByVal salida As Salidas) As Boolean
        Dim flag = False
        Try
            Dim tSql = "UPDATE Salida set unidadesSalida = @unidadesSalida, fechaSalida = @fechaSalida, precioSalida = @precioSalida, observacionesSalida = @observacionesSalida, idProducto = @idProducto, idUsuario = @idUsuario where idSalida = @idSalida"
            Dim conn As New SqlConnection(My.Settings.strConnectionn)
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.Parameters.AddWithValue("@idSalida", salida.IdSalida)
            cmd.Parameters.AddWithValue("@unidadesSalida", salida.UnidadesSalida)
            cmd.Parameters.AddWithValue("@fechaSalida", salida.FechaSalida)
            cmd.Parameters.AddWithValue("@precioSalida", salida.PrecioSalida)
            cmd.Parameters.AddWithValue("@observacionesSalida", salida.ObservacionesSalida)
            cmd.Parameters.AddWithValue("@idProducto", salida.IdProducto)
            cmd.Parameters.AddWithValue("@idUsuario", salida.IdUsuario)
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

    Public Function EliminarSalidas(ByVal idSalida As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tSql As String = "delete from Salida where idSalida = @idSalida"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idSalida", idSalida)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarSalidaId(ByVal idSalida As Integer) As Salidas
        Dim salida As New Salidas
        Try
            Dim tSql As String = "Select * from Salida where idSalida = @idSalida"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idSalida", idSalida)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                salida.IdSalida = tbl.Rows(0).Item("idSalida")
                salida.UnidadesSalida = tbl.Rows(0).Item("unidadesSalida")
                salida.FechaSalida = tbl.Rows(0).Item("fechaSalida")
                salida.PrecioSalida = tbl.Rows(0).Item("precioSalida")
                salida.ObservacionesSalida = tbl.Rows(0).Item("observacionesSalida")
                salida.IdProducto = tbl.Rows(0).Item("idProducto")
                salida.IdUsuario = tbl.Rows(0).Item("idUsuario")

            End If
        Catch ex As Exception
            MsgBox("Error al intentar encontrar los datos",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        Return salida
    End Function
End Class
