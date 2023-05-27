Public Class FrmSalidas
    Dim producto As New DProductos
    Dim usuario As New DUsuarios

    Sub LlenarRegistroSalidas()
        Dim dSalidas As New DSalidas
        DgvSalidas.DataSource = dSalidas.MostrarSalidas().Tables(0)
        DgvSalidas.Refresh()
    End Sub

    Sub LlenarUsuarios()
        Dim ds As New DataSet
        ds = usuario.MostrarRegistros()
        cbxUsuario.DataSource = ds.Tables(0)
        cbxUsuario.Refresh()
        cbxUsuario.DisplayMember = "Nombre de Usuario"
        cbxUsuario.ValueMember = "Codigo"
    End Sub

    Private Sub FrmSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistroSalidas()
        LlenarUsuarios()
    End Sub
End Class