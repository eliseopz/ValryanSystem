Public Class FrmUsuarios
    Sub LlenarRegistros()
        Dim dUsuarios As New DUsuarios
        DgvUsuarios.DataSource = dUsuarios.MostrarRegistros().Tables(0)
        DgvUsuarios.Refresh()
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCodigo.Clear()
        txtUsername.Clear()
        txtContra.Clear()
        txtPrimerNom.Clear()
        txtSegundoNom.Clear()
        txtPrimerApe.Clear()
        txtSegundoApe.Clear()
        txtTelefono.Clear()
        txtEmail.Clear()
        txtCedula.Clear()

    End Sub

    Private Sub btmAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim usuario As New Usuarios()
            usuario.IdUsuario = txtCodigo.Text.Trim
            usuario.Username = txtUsername.Text.Trim
            usuario.PasswordUsuario = txtContra.Text.Trim
            usuario.PrimerNomUsuario = txtPrimerNom.Text.Trim
            usuario.SegundoNomUsuario = txtSegundoNom.Text.Trim
            usuario.PrimerApeUsuario = txtPrimerApe.Text.Trim
            usuario.SegundoApeUsuario = txtSegundoApe.Text.Trim
            usuario.TelefonoUsuario = txtTelefono.Text.Trim
            usuario.EmailUsuario = txtEmail.Text.Trim
            usuario.Cedula = txtCedula.Text.Trim
            If cbxRol.Text = "Bodeguero" Then
                Dim rol As Boolean = True
                usuario.Rol = rol
            End If
            If cbxRol.Text = "Gerente" Then
                Dim rol As Boolean = False
                usuario.Rol = rol
            End If
            If cbxSexo.Text = "Hombre" Then
                Dim sexo As Boolean = True
                usuario.Sexo = sexo
            End If
            If cbxSexo.Text = "Mujer" Then
                Dim sexo As Boolean = False
                usuario.Sexo = sexo
            End If
            usuario.FechaNacimiento = FechaNacPicker.Value
            Dim dUsuario As New DUsuarios
            If (dUsuario.GuardarRegistros(usuario)) Then
                MsgBox("Registro guardado exitosamente",
                   MsgBoxStyle.Information, "Ciudades")
            End If
        Catch ex As Exception
            MsgBox("No se pudo guardar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistros()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim codigo As Integer = txtCodigo.Text
        Dim dUsuario As New DUsuarios()
        Dim usuario As New Usuarios
        usuario = dUsuario.BuscarRegistro(codigo)
        If (usuario.IdUsuario = 0) Then
            MsgBox("El registro no existe",
                   MsgBoxStyle.Exclamation, "ADVERTENCIA")
            Exit Sub
        End If

        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar este registro " & usuario.IdUsuario, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "ADVERTENCIA"))
        If (resp = vbNo) Then
            MsgBox("Operacion cancelada",
                       MsgBoxStyle.Information, "Ciudades")
            Exit Sub
        End If
        Dim eliminado = dUsuario.EliminarRegistros(usuario.IdUsuario)
        If (eliminado) Then
            MsgBox("Registro eliminado exitosamente",
                       MsgBoxStyle.Information, "Ciudades")
        Else
            MsgBox("No se pudo eliminar el registro",
                   MsgBoxStyle.Critical, "ERROR")
        End If
        LlenarRegistros()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim usuario As New Usuarios(CInt(txtCodigo.Text), txtUsername.Text, txtPrimerNom.Text, txtSegundoNom.Text, txtPrimerApe.Text, txtSegundoApe.Text, CDate(FechaNacPicker.Text), txtEmail.Text, txtTelefono.Text, txtCedula.Text, CBool(cbxRol.Text), CBool(cbxSexo.Text), True)
            Dim dao As New DUsuarios
            If (dao.EditarRegistros(usuario)) Then
                MsgBox("Registro editado exitosamente",
                       MsgBoxStyle.Information, "Ciudades")
            End If
        Catch ex As Exception
            MsgBox("No se pudo editar el registro",
                  MsgBoxStyle.Critical, "ERROR")
        End Try
        LlenarRegistros()
    End Sub

    Private Sub DgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuarios.CellClick
        Dim fila As Integer = DgvUsuarios.CurrentRow.Index
        txtCodigo.Text = DgvUsuarios.Rows(fila).Cells(0).Value
        txtUsername.Text = DgvUsuarios.Rows(fila).Cells(1).Value
        txtContra.Text = DgvUsuarios.Rows(fila).Cells(2).Value
        txtPrimerNom.Text = DgvUsuarios.Rows(fila).Cells(3).Value
        txtSegundoNom.Text = DgvUsuarios.Rows(fila).Cells(4).Value
        txtPrimerApe.Text = DgvUsuarios.Rows(fila).Cells(5).Value
        txtSegundoApe.Text = DgvUsuarios.Rows(fila).Cells(6).Value
        FechaNacPicker.Text = DgvUsuarios.Rows(fila).Cells(7).Value
        txtEmail.Text = DgvUsuarios.Rows(fila).Cells(8).Value
        txtTelefono.Text = DgvUsuarios.Rows(fila).Cells(9).Value
        txtCedula.Text = DgvUsuarios.Rows(fila).Cells(10).Value
        cbxRol.Text = DgvUsuarios.Rows(fila).Cells(11).Value
        cbxSexo.Text = DgvUsuarios.Rows(fila).Cells(12).Value

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dao As New DUsuarios
        DgvUsuarios.DataSource = dao.buscarRegistro(txtBuscar.Text.Trim).Tables(0)
        DgvUsuarios.Refresh()
    End Sub
End Class
