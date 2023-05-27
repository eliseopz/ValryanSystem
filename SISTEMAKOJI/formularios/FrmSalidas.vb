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

    Sub LLenarProductos()
        Dim ds As New DataSet
        ds = producto.MostrarRegistro()
        cbxProducto.DataSource = ds.Tables(0)
        cbxProducto.Refresh()
        cbxProducto.DisplayMember = "Producto"
        cbxProducto.ValueMember = "Codigo"
    End Sub

    Private Sub FrmSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistroSalidas()
        LlenarUsuarios()
        LLenarProductos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim salida As New Salidas()
            salida.IdSalida = txtCodigo.Text.Trim
            salida.UnidadesSalida = txtUnidades.Text.Trim
            salida.PrecioSalida = txtPrecio.Text.Trim
            salida.ObservacionesSalida = txtObservaciones.Text.Trim
            salida.FechaSalida = dtpFecha.Value
            salida.IdProducto = cbxProducto.SelectedValue
            salida.IdUsuario = cbxUsuario.SelectedValue
            Dim dSalidas As New DSalidas
            If (dSalidas.GuardarSalidas(salida)) Then
                MsgBox("Registro guardado exitosamente",
                   MsgBoxStyle.Information, "Salidas")
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro",
                 MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistroSalidas()
        LlenarUsuarios()
        LLenarProductos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim salida As New Salidas()
            salida.IdSalida = txtCodigo.Text.Trim
            salida.UnidadesSalida = txtUnidades.Text.Trim
            salida.PrecioSalida = txtPrecio.Text.Trim
            salida.ObservacionesSalida = txtObservaciones.Text.Trim
            salida.FechaSalida = dtpFecha.Value
            Dim fila As Integer = DgvSalidas.CurrentRow.Index
            salida.IdProducto = DgvSalidas.Rows(fila).Cells(5).Value
            salida.IdUsuario = DgvSalidas.Rows(fila).Cells(6).Value
            Dim dSalidas As New DSalidas
            If (dSalidas.EditarSalidas(salida)) Then
                MsgBox("Registro editado exitosamente",
                   MsgBoxStyle.Information, "Entradas")
            End If
        Catch ex As Exception
            MsgBox("No se pudo editar el registro",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistroSalidas()
        LlenarUsuarios()
        LLenarProductos()
    End Sub

    Private Sub DgvSalidas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSalidas.CellClick
        Dim fila As Integer = DgvSalidas.CurrentRow.Index
        txtCodigo.Text = DgvSalidas.Rows(fila).Cells(0).Value
        txtUnidades.Text = DgvSalidas.Rows(fila).Cells(1).Value
        dtpFecha.Value = DgvSalidas.Rows(fila).Cells(2).Value
        txtPrecio.Text = DgvSalidas.Rows(fila).Cells(3).Value
        txtObservaciones.Text = DgvSalidas.Rows(fila).Cells(4).Value
        cbxProducto.SelectedValue = DgvSalidas.Rows(fila).Cells(5).Value
        cbxUsuario.SelectedValue = DgvSalidas.Rows(fila).Cells(6).Value
    End Sub
End Class