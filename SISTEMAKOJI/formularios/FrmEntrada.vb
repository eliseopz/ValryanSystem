Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmEntrada
    Dim producto As New DProductos
    Dim usuario As New DUsuarios
    Dim strConn As String = My.Settings.strConnectionn.ToString()

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
            Dim idProducto As Integer = Integer.Parse(cbxProducto.SelectedValue)
            Dim unidadesEntrada As Integer = Integer.Parse(txtUnidades.Text)
            Using connection As New SqlConnection(strConn)
                connection.Open()
                Dim query As String = "SELECT unidadesProducto FROM Productos WHERE idProducto = @idProducto"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idProducto", idProducto)
                    Dim unidadesProductos As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Dim nuevasUnidadesProductos As Integer = unidadesProductos + unidadesEntrada
                    query = "UPDATE Productos SET unidadesProducto = @nuevasUnidadesProductos WHERE idProducto = @idProducto"
                    Using updateCommand As New SqlCommand(query, connection)
                        updateCommand.Parameters.AddWithValue("@nuevasUnidadesProductos", nuevasUnidadesProductos)
                        updateCommand.Parameters.AddWithValue("@idProducto", idProducto)
                        updateCommand.ExecuteNonQuery()
                    End Using
                End Using
                connection.Close()
            End Using


                Dim entrada As New Entrada()
            entrada.IdEntrada = txtCodigo.Text.Trim
            entrada.Unidades = txtUnidades.Text.Trim
            entrada.PrecioEntrada = txtPrecioEntrada.Text.Trim
            entrada.ObservacionesEntrada = txtObservaciones.Text.Trim
            entrada.IdProducto = cbxProducto.SelectedValue
            entrada.IdUsuario = cbxUsuario.SelectedValue
            Dim fechaseleccionada As DateTime = dtpFechaEntrada.Value
            Dim fechaformateada As String = fechaseleccionada.ToString("yyyy-MM-dd HH:mm:ss")
            entrada.FechaEntrada = fechaformateada
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
            Dim idProducto As Integer = Integer.Parse(cbxProducto.SelectedValue)
            Dim unidadesEntrada As Integer = Integer.Parse(txtUnidades.Text)
            Using connection As New SqlConnection(strConn)
                connection.Open()
                Dim query As String = "SELECT unidadesProducto FROM Productos WHERE idProducto = @idProducto"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idProducto", idProducto)
                    Dim unidadesProductos As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Dim nuevasUnidadesProductos As Integer = unidadesProductos + unidadesEntrada
                    query = "UPDATE Productos SET unidadesProducto = @nuevasUnidadesProductos WHERE idProducto = @idProducto"
                    Using updateCommand As New SqlCommand(query, connection)
                        updateCommand.Parameters.AddWithValue("@nuevasUnidadesProductos", nuevasUnidadesProductos)
                        updateCommand.Parameters.AddWithValue("@idProducto", idProducto)
                        updateCommand.ExecuteNonQuery()
                    End Using
                End Using
                connection.Close()
            End Using

            Dim entrada As New Entrada()
            entrada.IdEntrada = txtCodigo.Text.Trim
            entrada.Unidades = txtUnidades.Text.Trim
            entrada.PrecioEntrada = txtPrecioEntrada.Text.Trim
            entrada.ObservacionesEntrada = txtObservaciones.Text.Trim
            Dim fila As Integer = DgvEntrada.CurrentRow.Index

            entrada.IdProducto = DgvEntrada.Rows(fila).Cells(5).Value
            entrada.IdUsuario = DgvEntrada.Rows(fila).Cells(6).Value
            Dim fechaseleccionada As DateTime = dtpFechaEntrada.Value
            Dim fechaformateada As String = fechaseleccionada.ToString("yyyy-MM-dd HH:mm:ss")
            entrada.FechaEntrada = fechaformateada
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Clear()
        txtUnidades.Clear()
        txtPrecioEntrada.Clear()
        txtObservaciones.Clear()
        dtpFechaEntrada.ResetText()
        cbxProducto.ResetText()
        cbxUsuario.ResetText()
    End Sub

    Private Sub cbxProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProducto.SelectedIndexChanged

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim codigo As Integer = txtCodigo.Text
        Dim dEntrada As New DEntradas()
        Dim entrada As New Entrada
        entrada = dEntrada.BuscarRegistro(codigo)
        If (entrada.IdEntrada = 0) Then
            MsgBox("El registro no existe",
                   MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If

        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro: " & entrada.IdEntrada, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "ADVERTENCIA"))
        If (resp = vbNo) Then
            MsgBox("Operacion cancelada",
                       MsgBoxStyle.Information, "Entradas")
            Exit Sub
        End If

        Dim eliminado = dEntrada.EliminarRegistro(entrada.IdEntrada)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                      MsgBoxStyle.Information, "Entradas")
        Else
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        LlenarRegistroEntrada()
        LlenarProductos()
        LlenarUsuarios()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dao As New DEntradas
        DgvEntrada.DataSource = dao.buscarRegistros(txtBuscar.Text.Trim).Tables(0)
    End Sub

    Private Sub dtpFechaEntrada_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaEntrada.ValueChanged
        Dim fechaseleccionada As DateTime = dtpFechaEntrada.Value
        Dim fechaformateada As String = fechaseleccionada.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub
End Class