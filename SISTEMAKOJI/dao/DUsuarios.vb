Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class DUsuarios
    Dim strConn As String = My.Settings.strConnection.ToString()

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tSql As String = "Select idUsuario as N'Codigo', passwordUsuario as N'Contraseña', primerNomUsuario as N'Primer Nombre', segundoNomUsuario as N'Segundo Nombre', primerApeUsuario as N'Primer Apellido', segundoApeUsuario as N'Segundo Apellido', fechaNacimiento as N'Fecha Nacimiento', telefonoUsuario as N'Telefono', cedula as N'DNI', rol as N'Rol De Trabajo', sexo as N'Genero' from Usuarios"
            Dim da As New SqlDataAdapter(tSql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        Return ds
    End Function
End Class
