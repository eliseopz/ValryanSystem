Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class DCategoria
    Dim strConn As String = My.Settings.strConnectionn.ToString()

    Public Function MostrarCategoria() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "select idCategoria as N'Codigo', nombreCategoria as N'Nombre', descripcionCategoria as N'Descripcion' from Categoria "
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds

    End Function

    Public Function GuardarRegistros(ByVal categoria As Categoria) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            Dim tSql = "insert into Categoria(idCategoria, nombreCategoria, descripcionCategoria) values(@idCategoria, @nombreCategoria, @descripcionCategoria)"
            cmd.Parameters.AddWithValue("@idCategoria", categoria.IdCategoria)
            cmd.Parameters.AddWithValue("@nombreCategoria", categoria.NombreCategoria)
            cmd.Parameters.AddWithValue("@descripcionCategoria", categoria.DescripcionCategoria)
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

    Public Function EditarRegistros(ByVal categoria As Categoria) As Boolean
        Dim flag = False
        Try
            Dim tSql = "UPDATE Categoria Set nombreCategoria = @nombreCategoria, descripcionCategoria = @descripcionCategoria where idCategoria = @idCategoria"
            Dim conn As New SqlConnection(My.Settings.strConnectionn)
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.Parameters.AddWithValue("@nombreCategoria", categoria.NombreCategoria)
            cmd.Parameters.AddWithValue("@descripcionCategoria", categoria.DescripcionCategoria)
            cmd.Parameters.AddWithValue("@idCategoria", categoria.IdCategoria)
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

    Public Function EliminarRegistros(ByVal idCategoria As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tSql As String = "delete from Categoria where idCategoria = @idCategoria"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idCategoria", idCategoria)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarRegistroId(ByVal idCategoria As Integer) As Categoria
        Dim categoria As New Categoria
        Try
            Dim tSql As String = "select * from Categoria where idCategoria = @idCategoria"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idCategoria", idCategoria)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                categoria.IdCategoria = tbl.Rows(0).Item("idCategoria")
                categoria.NombreCategoria = tbl.Rows(0).Item("nombreCategoria")
                categoria.DescripcionCategoria = tbl.Rows(0).Item("descripcionCategoria")

            End If
        Catch ex As Exception

        End Try
        Return categoria
    End Function

    Public Function BuscarRegistroNombre(ByVal nombreCategoria As String) As DataSet
        Dim ds As New DataSet
        nombreCategoria = nombreCategoria + "%"
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "select idCategoria as N'Codigo', nombreCategoria as N'Nombre', descripcionCategoria as N'Descripcion' from Categoria where nombreCategoria like @nombreCategoria"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombreCategoria", nombreCategoria)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
