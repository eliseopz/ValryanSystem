Public Class FrmSalidas
    Dim producto As New DProductos
    Dim usuario As New DUsuarios

    Sub LlenarRegistroSalidas()
        Dim dSalidas As New DSalidas
        DgvSalidas.DataSource = dSalidas.MostrarSalidas().Tables(0)
        DgvSalidas.Refresh()
    End Sub

    Private Sub FrmSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistroSalidas()
    End Sub
End Class