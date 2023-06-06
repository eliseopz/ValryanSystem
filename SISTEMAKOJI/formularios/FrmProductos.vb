Public Class FrmProductos
    Dim categoria As New DCategoria
    Sub LlenarRegistroProductos()
        Dim dProductos As New DProductos
        DgvProductos.DataSource = dProductos.MostrarRegistro().Tables(0)
        DgvProductos.Refresh()
    End Sub
    Sub LlenarCategorias()

        Dim ds As New DataSet
        ds = categoria.MostrarCategoria
        cbxCategoria.DataSource = ds.Tables(0)
        cbxCategoria.Refresh()
        cbxCategoria.DisplayMember = "Nombre"
        cbxCategoria.ValueMember = "Codigo"

    End Sub

    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistroProductos()
        LlenarCategorias()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        txtDescripcion.Clear()
        txtUnidades.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim producto As New Producto()
            producto.IdProducto = txtCodigo.Text.Trim
            producto.NombreProducto = txtNombre.Text.Trim
            producto.PrecioProducto = txtPrecio.Text.Trim
            producto.UnidadesProducto = txtUnidades.Text.Trim
            producto.DescripcionProducto = txtDescripcion.Text.Trim
            producto.UnidadMedidaProducto = cbxUnidadMedida.SelectedItem.ToString()
            producto.IdCategoria = cbxCategoria.SelectedValue
            Dim dProductos As New DProductos
            If (dProductos.GuardarProductos(producto)) Then
                MsgBox("Registro guardado exitosamente",
                   MsgBoxStyle.Information, "Ciudades")
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistroProductos()
        LlenarCategorias()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim producto As New Producto()
            producto.IdProducto = txtCodigo.Text.Trim
            producto.NombreProducto = txtNombre.Text.Trim
            producto.PrecioProducto = txtPrecio.Text.Trim
            producto.UnidadesProducto = txtUnidades.Text.Trim
            producto.DescripcionProducto = txtDescripcion.Text.Trim
            producto.UnidadMedidaProducto = cbxUnidadMedida.SelectedItem.ToString()
            producto.IdCategoria = cbxCategoria.SelectedValue
            Dim dProductos As New DProductos
            If (dProductos.EditarProductos(producto) = True) Then
                MsgBox("Registro editado exitosamente",
                    MsgBoxStyle.Information, "Productos")
            End If

        Catch ex As Exception
            MsgBox("No se pudo editar el registro",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistroProductos()
        LlenarCategorias()
    End Sub

    Private Sub DgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProductos.CellClick
        Dim fila As Integer = DgvProductos.CurrentRow.Index
        txtCodigo.Text = DgvProductos.Rows(fila).Cells(0).Value
        txtNombre.Text = DgvProductos.Rows(fila).Cells(1).Value
        txtPrecio.Text = DgvProductos.Rows(fila).Cells(2).Value
        txtUnidades.Text = DgvProductos.Rows(fila).Cells(3).Value
        cbxUnidadMedida.Text = DgvProductos.Rows(fila).Cells(4).Value
        txtDescripcion.Text = DgvProductos.Rows(fila).Cells(5).Value
        cbxCategoria.SelectedValue = DgvProductos.Rows(fila).Cells(6).Value
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim milidel As Integer = txtCodigo.Text
        Dim dProducto As New DProductos()
        Dim producto As New Producto
        producto = dProducto.BuscarProductoId(milidel)
        If (producto.IdProducto = 0) Then
            MsgBox("El registro no existe",
                  MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If
        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro: " & producto.IdProducto, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "ADVERTENCIA"))
        If (resp = vbNo) Then
            MsgBox("Operacion cancelada",
                       MsgBoxStyle.Information, "Ciudades")
            Exit Sub
        End If
        Dim eliminado = dProducto.EliminarProducto(producto.IdProducto)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                       MsgBoxStyle.Information, "Ciudades")
        Else
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        LlenarRegistroProductos()
        LlenarCategorias()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dao As New DProductos
        DgvProductos.DataSource = dao.BuscarProductoNombre(txtBuscar.Text.Trim).Tables(0)
        DgvProductos.Refresh()
    End Sub
End Class