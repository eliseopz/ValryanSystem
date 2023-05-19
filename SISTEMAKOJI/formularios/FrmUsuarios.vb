Public Class FrmUsuarios
    Sub LlenarRegistros()
        Dim dUsuarios As New DUsuarios
        DgvUsuarios.DataSource = dUsuarios.MostrarRegistros().Tables(0)
        DgvUsuarios.Refresh()
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub
End Class
