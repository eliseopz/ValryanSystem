﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmSalidas
    Dim producto As New DProductos
    Dim usuario As New DUsuarios
    Dim strConn As String = My.Settings.strConnectionn.ToString()

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
            Dim idProducto As Integer = Integer.Parse(cbxProducto.SelectedValue)
            Dim unidadesSalida As Integer = Integer.Parse(txtUnidades.Text)
            Using connection As New SqlConnection(strConn)
                connection.Open()
                Dim query As String = "SELECT unidadesProducto FROM Productos WHERE idProducto = @idProducto"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idProducto", idProducto)
                    Dim unidadesProductos As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Dim nuevasUnidadesProductos As Integer
                    If unidadesSalida >= unidadesProductos Then
                        MsgBox("Error al restar Stock, La Cantidad que selecciono es mayor o igual a la que hay en Stock",
                  MsgBoxStyle.Critical, "ERROR")
                        nuevasUnidadesProductos = unidadesProductos
                    ElseIf unidadesSalida < unidadesProductos Then
                        nuevasUnidadesProductos = unidadesProductos - unidadesSalida
                        Dim salida As New Salidas()
                        salida.IdSalida = txtCodigo.Text.Trim
                        salida.UnidadesSalida = txtUnidades.Text.Trim
                        salida.PrecioSalida = txtPrecio.Text.Trim
                        salida.ObservacionesSalida = txtObservaciones.Text.Trim
                        Dim fechaseleccionada As DateTime = dtpFecha.Value
                        Dim fechaformateada As String = fechaseleccionada.ToString("yyyy-MM-dd HH:mm:ss")
                        salida.FechaSalida = fechaformateada
                        salida.IdProducto = cbxProducto.SelectedValue
                        salida.IdUsuario = cbxUsuario.SelectedValue
                        Dim dSalidas As New DSalidas
                        If (dSalidas.GuardarSalidas(salida)) Then
                            MsgBox("Registro guardado exitosamente",
                            MsgBoxStyle.Information, "Salidas")
                        End If

                    End If
                    query = "UPDATE Productos SET unidadesProducto = @nuevasUnidadesProductos WHERE idProducto = @idProducto"
                    Using updateCommand As New SqlCommand(query, connection)
                        updateCommand.Parameters.AddWithValue("@nuevasUnidadesProductos", nuevasUnidadesProductos)
                        updateCommand.Parameters.AddWithValue("@idProducto", idProducto)
                        updateCommand.ExecuteNonQuery()
                    End Using
                End Using
                connection.Close()
            End Using

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
            Dim idProducto As Integer = Integer.Parse(cbxProducto.SelectedValue)
            Dim unidadesSalida As Integer = Integer.Parse(txtUnidades.Text)
            Using connection As New SqlConnection(strConn)
                connection.Open()
                Dim query As String = "SELECT unidadesProducto FROM Productos WHERE idProducto = @idProducto"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@idProducto", idProducto)
                    Dim unidadesProductos As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Dim nuevasUnidadesProductos As Integer
                    If unidadesSalida >= unidadesProductos Then
                        MsgBox("Error al restar Stock, La Cantidad que selecciono es mayor o igual a la que hay en Stock",
                  MsgBoxStyle.Critical, "ERROR")
                        nuevasUnidadesProductos = unidadesProductos
                    ElseIf unidadesSalida < unidadesProductos Then
                        nuevasUnidadesProductos = unidadesProductos - unidadesSalida
                        Dim salida As New Salidas()
                        salida.IdSalida = txtCodigo.Text.Trim
                        salida.UnidadesSalida = txtUnidades.Text.Trim
                        salida.PrecioSalida = txtPrecio.Text.Trim
                        salida.ObservacionesSalida = txtObservaciones.Text.Trim
                        Dim fechaseleccionada As DateTime = dtpFecha.Value
                        Dim fechaformateada As String = fechaseleccionada.ToString("yyyy-MM-dd HH:mm:ss")
                        salida.FechaSalida = fechaformateada
                        Dim fila As Integer = DgvSalidas.CurrentRow.Index
                        salida.IdProducto = DgvSalidas.Rows(fila).Cells(5).Value
                        salida.IdUsuario = DgvSalidas.Rows(fila).Cells(6).Value
                        Dim dSalidas As New DSalidas
                        If (dSalidas.EditarSalidas(salida)) Then
                            MsgBox("Registro editado exitosamente",
                            MsgBoxStyle.Information, "Entradas")
                        End If

                    End If
                    query = "UPDATE Productos SET unidadesProducto = @nuevasUnidadesProductos WHERE idProducto = @idProducto"
                    Using updateCommand As New SqlCommand(query, connection)
                        updateCommand.Parameters.AddWithValue("@nuevasUnidadesProductos", nuevasUnidadesProductos)
                        updateCommand.Parameters.AddWithValue("@idProducto", idProducto)
                        updateCommand.ExecuteNonQuery()
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox("No se pudo editar el registro",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistroSalidas()
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

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim codigo As Integer = txtCodigo.Text
        Dim dSalida As New DSalidas()
        Dim salidas As New Salidas
        salidas = dSalida.BuscarSalidaId(codigo)
        If (salidas.IdSalida = 0) Then
            MsgBox("El registro no existe",
                  MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If

        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro: " & salidas.IdSalida, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "ADVERTENCIA"))
        If (resp = vbNo) Then
            MsgBox("Operacion cancelada",
                       MsgBoxStyle.Information, "Entradas")
            Exit Sub
        End If
        Dim eliminado = dSalida.EliminarSalidas(salidas.IdSalida)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                      MsgBoxStyle.Information, "Entradas")
        Else
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        LlenarRegistroSalidas()
        LlenarUsuarios()
        LLenarProductos()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPrecio.Clear()
        txtObservaciones.Clear()
        txtUnidades.Clear()
        txtCodigo.Clear()
        dtpFecha.ResetText()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dao As New DSalidas
        DgvSalidas.DataSource = dao.BuscarRegistro(txtBuscar.Text.Trim).Tables(0)
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Dim fechaseleccionada As DateTime = dtpFecha.Value
        Dim fechaformateada As String = fechaseleccionada.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub
End Class