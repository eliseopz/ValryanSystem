Public Class FrmEntrada
    Dim producto As New DProductos
    Dim usuario As New DUsuarios

    Sub LlenarRegistroEntrada()
        Dim dEntrada As New DEntradas
        DgvEntrada.DataSource = dEntrada.MostrarEntradas().Tables(0)
        DgvEntrada.Refresh()
    End Sub

    Sub LlenarProductos()
        Dim ds As New DataSet
        ds = producto.MostrarRegistro()
        cbxProducto.DataSource = ds.Tables(0)
        cbxProducto.Refresh()
        cbxProducto.DisplayMember = "Producto"
        cbxProducto.ValueMember = "Codigo"
    End Sub

    Sub LlenarUsuarios()
        Dim ds As New DataSet
        ds = usuario.MostrarRegistros()
        cbxUsuario.DataSource = ds.Tables(0)
        cbxUsuario.Refresh()
        cbxUsuario.DisplayMember = "Nombre de Usuario"
        cbxUsuario.ValueMember = "Codigo"
    End Sub

    Private Sub FrmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistroEntrada()
        LlenarProductos()
        LlenarUsuarios()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim entrada As New Entrada()
            entrada.IdEntrada = txtCodigo.Text.Trim
            entrada.Unidades = txtUnidades.Text.Trim
            entrada.PrecioEntrada = txtPrecioEntrada.Text.Trim
            entrada.ObservacionesEntrada = txtObservaciones.Text.Trim
            entrada.IdProducto = cbxProducto.SelectedValue
            entrada.IdUsuario = cbxUsuario.SelectedValue
            entrada.FechaEntrada = dtpFechaEntrada.Value
            Dim dEntrada As New DEntradas
            If (dEntrada.GuardarEntradas(entrada)) Then
                MsgBox("Registro guardado exitosamente",
                   MsgBoxStyle.Information, "Entradas")
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistroEntrada()
        LlenarProductos()
        LlenarUsuarios()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim entrada As New Entrada()
            entrada.IdEntrada = txtCodigo.Text.Trim
            entrada.Unidades = txtUnidades.Text.Trim
            entrada.PrecioEntrada = txtPrecioEntrada.Text.Trim
            entrada.ObservacionesEntrada = txtObservaciones.Text.Trim
            entrada.IdProducto = cbxProducto.SelectedValue
            entrada.IdUsuario = cbxUsuario.SelectedValue
            entrada.FechaEntrada = dtpFechaEntrada.Value
            Dim dEntrada As New DEntradas
            If (dEntrada.EditarRegistro(entrada)) Then
                MsgBox("Registro editado exitosamente",
                   MsgBoxStyle.Information, "Entradas")
            End If

        Catch ex As Exception
            MsgBox("No se pudo editar el registro",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistroEntrada()
        LlenarProductos()
        LlenarUsuarios()
    End Sub

    Private Sub DgvEntrada_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEntrada.CellClick
        Dim fila As Integer = DgvEntrada.CurrentRow.Index
        txtCodigo.Text = DgvEntrada.Rows(fila).Cells(0).Value
        txtUnidades.Text = DgvEntrada.Rows(fila).Cells(1).Value
        dtpFechaEntrada.Value = DgvEntrada.Rows(fila).Cells(2).Value
        txtPrecioEntrada.Text = DgvEntrada.Rows(fila).Cells(3).Value
        txtObservaciones.Text = DgvEntrada.Rows(fila).Cells(4).Value
        cbxProducto.SelectedValue = DgvEntrada.Rows(fila).Cells(5).Value
        cbxUsuario.SelectedValue = DgvEntrada.Rows(fila).Cells(6).Value


    End Sub
End Class