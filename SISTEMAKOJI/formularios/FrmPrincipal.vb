Public Class FrmPrincipal
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim frm As New FrmUsuarios
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Dim frm As New FrmCategoria
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim frm As New FrmProductos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaToolStripMenuItem.Click
        Dim frm As New FrmEntrada
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaToolStripMenuItem.Click
        Dim frm As New FrmSalidas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Dim frm As New frmRptProdCategoria
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class