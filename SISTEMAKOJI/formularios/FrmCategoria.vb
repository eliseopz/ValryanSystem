Public Class FrmCategoria
    Sub LlenarRegistrosCategoria()
        Dim dCategoria As New DCategoria
        DgvCategoria.DataSource = dCategoria.MostrarCategoria().Tables(0)
        DgvCategoria.Refresh()
    End Sub

    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistrosCategoria()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim categoria As New Categoria
            categoria.IdCategoria = txtCodigo.Text.Trim
            categoria.NombreCategoria = txtNombre.Text.Trim
            categoria.DescripcionCategoria = txtDescripcion.Text.Trim
            Dim dCategoria As New DCategoria
            If (dCategoria.GuardarRegistros(categoria)) Then
                MsgBox("Registro guardado exitosamente",
                   MsgBoxStyle.Information, "Categoria")
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistrosCategoria()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim categoria As New Categoria(CInt(txtCodigo.Text), txtNombre.Text, txtDescripcion.Text)
            Dim dao As New DCategoria
            If (dao.EditarRegistros(categoria)) Then
                MsgBox("Registro editado exitosamente",
                      MsgBoxStyle.Information, "Ciudades")
            End If
        Catch ex As Exception
            MsgBox("No se pudo editar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistrosCategoria()
    End Sub

    Private Sub DgvCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellClick
        Dim fila As Integer = DgvCategoria.CurrentRow.Index
        txtCodigo.Text = DgvCategoria.Rows(fila).Cells(0).Value
        txtNombre.Text = DgvCategoria.Rows(fila).Cells(1).Value
        txtDescripcion.Text = DgvCategoria.Rows(fila).Cells(2).Value


    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim codigo As Integer = txtCodigo.Text
        Dim dCategoria As New DCategoria()
        Dim categoria As New Categoria
        categoria = dCategoria.BuscarRegistroId(codigo)
        If (categoria.IdCategoria = 0) Then
            MsgBox("El registro no existe",
                  MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If
        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro: " & categoria.IdCategoria, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "ADVERTENCIA"))
        If (resp = vbNo) Then
            MsgBox("Operacion cancelada",
                       MsgBoxStyle.Information, "Ciudades")
            Exit Sub
        End If
        Dim eliminado = dCategoria.EliminarRegistros(categoria.IdCategoria)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                       MsgBoxStyle.Information, "Ciudades")
        Else
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        LlenarRegistrosCategoria()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dao As New DCategoria
        DgvCategoria.DataSource = dao.BuscarRegistroNombre(txtBuscar.Text.Trim).Tables(0)
        DgvCategoria.Refresh()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
    End Sub
End Class