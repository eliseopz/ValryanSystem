Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class DUsuarios
    Dim strConn As String = My.Settings.strConnectionn.ToString()

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select idUsuario as N'Codigo', username as N'Nombre de Usuario', primerNomUsuario as N'Primer Nombre', segundoNomUsuario as N'Segundo Nombre', primerApeUsuario as N'Primer Apellido', segundoApeUsuario as N'Segundo Apellido', fechaNacimiento as N'Fecha Nacimiento', telefonoUsuario as N'Telefono', emailUsuario as N'Nombre Usuario', cedula as N'DNI', rol as N'Rol Usuario', sexo as N'Genero' from Usuarios"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function

    Public Function GuardarRegistros(ByVal usuario As Usuarios) As Boolean
        Dim resultado As Boolean = False
        Try
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            Dim tSql = "insert into Usuarios(idUsuario, username, passwordUsuario, primerNomUsuario, segundoNomUsuario, primerApeUsuario, segundoApeUsuario, fechaNacimiento, telefonoUsuario, emailUsuario, cedula, rol, sexo) values(@idUsuario, @username, @passwordUsuario, @primerNomUsuario, @segundoNomUsuario, @primerApeUsuario, @segundoApeUsuario, @fechaNacimiento, @telefonoUsuario, @emailUsuario, @cedula, @rol, @sexo)"
            cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario)
            cmd.Parameters.AddWithValue("@username", usuario.Username)
            cmd.Parameters.AddWithValue("@passwordUsuario", usuario.PasswordUsuario)
            cmd.Parameters.AddWithValue("@primerNomUsuario", usuario.PrimerNomUsuario)
            cmd.Parameters.AddWithValue("@segundoNomUsuario", usuario.SegundoNomUsuario)
            cmd.Parameters.AddWithValue("@primerApeUsuario", usuario.PrimerApeUsuario)
            cmd.Parameters.AddWithValue("@segundoApeUsuario", usuario.SegundoApeUsuario)
            cmd.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento)
            cmd.Parameters.AddWithValue("@telefonoUsuario", usuario.TelefonoUsuario)
            cmd.Parameters.AddWithValue("@emailUsuario", usuario.EmailUsuario)
            cmd.Parameters.AddWithValue("@cedula", usuario.Cedula)
            cmd.Parameters.AddWithValue("@rol", usuario.Rol)
            cmd.Parameters.AddWithValue("@sexo", usuario.Sexo)
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

    Public Function EditarRegistros(ByVal usuario As Usuarios) As Boolean
        Dim flag = False
        Try
            Dim tSql = "UPDATE Usuarios SET username = @username, passwordUsuario = @passwordUsuario where idUsuario = @idUsuario"
            Dim conn As New SqlConnection(My.Settings.strConnection)
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.Parameters.AddWithValue("@username", usuario.Username)
            cmd.Parameters.AddWithValue("@passwordUsuario", usuario.PasswordUsuario)
            cmd.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario)
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

    Public Function EliminarRegistros(ByVal idUsuario As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tSql As String = "delete from Usuarios where idUsuario = @idUsuario"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tSql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()

        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function BuscarRegistro(ByVal idUsuario As Integer) As Usuarios
        Dim usuario As New Usuarios
        Try
            Dim tSql As String = "select * from Usuarios where idUsuario = @idUSuario"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuario)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                usuario.IdUsuario = tbl.Rows(0).Item("idUsuario")
                usuario.PasswordUsuario = tbl.Rows(0).Item("passwordUsuario")
                usuario.PrimerNomUsuario = tbl.Rows(0).Item("primerNomUsuario")
                usuario.SegundoNomUsuario = tbl.Rows(0).ItemArray("segundoNomUsuario")
                usuario.PrimerApeUsuario = tbl.Rows(0).Item("primerApeUsuario")
                usuario.SegundoApeUsuario = tbl.Rows(0).Item("segundoApeUsuario")
                usuario.FechaNacimiento = tbl.Rows(0).Item("fechaNacimiento")
                usuario.TelefonoUsuario = tbl.Rows(0).Item("telefonoUsuario")
                usuario.EmailUsuario = tbl.Rows(0).Item("emailUsuario")
                usuario.Cedula = tbl.Rows(0).Item("cedula")
                usuario.Rol = tbl.Rows(0).Item("rol")
                usuario.Sexo = tbl.Rows(0).Item("sexo")
            End If

        Catch ex As Exception

        End Try
        Return usuario
    End Function

    Public Function buscarRegistro(ByVal username As String) As DataSet
        Dim ds As New DataSet
        username = username + "%"
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select idUsuario as N'Codigo', username as N'Nombre Usuario' from Usuarios where username like @username"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.SelectCommand.Parameters.AddWithValue("@username", username)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
