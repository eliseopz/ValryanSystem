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
End Class
