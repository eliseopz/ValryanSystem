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
End Class
