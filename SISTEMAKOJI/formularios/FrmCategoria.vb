Public Class FrmCategoria
    Sub LlenarRegistrosCategoria()
        Dim dCategoria As New DCategoria
        DgvCategoria.DataSource = dCategoria.MostrarCategoria().Tables(0)
        DgvCategoria.Refresh()
    End Sub

    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistrosCategoria()
    End Sub
End Class