Public Class frmCambiarContraseña

    Private Sub pnlCambiarContraseña_Paint(sender As Object, e As PaintEventArgs) Handles pnlCambiarContraseña.Paint

    End Sub

    Private Sub tbxConfirmarContraseña_TextChanged(sender As Object, e As EventArgs) Handles tbxConfimarContraseña.TextChanged
        tbxConfimarContraseña.MaxLength = 20
    End Sub

    Private Sub tbxContraseñaActual_TextChanged(sender As Object, e As EventArgs) Handles tbxContraseñaActual.TextChanged
        tbxContraseñaActual.MaxLength = 20
    End Sub

    Private Sub tbxNuevaContraseña_Enter(sender As Object, e As EventArgs) Handles tbxNuevaContraseña.Enter
        tbxNuevaContraseña.MaxLength = 20
    End Sub

    Private Sub btnGuardarCambios_Click(sender As Object, e As EventArgs) Handles btnGuardarCambios.Click
        ' Verificar que las contraseñas coincidan
        If tbxNuevaContraseña.Text <> tbxConfimarContraseña.Text Then
            MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Verificar que no estén vacías
        If tbxNuevaContraseña.Text.Trim() = "" Or tbxConfimarContraseña.Text.Trim() = "" Then
            MessageBox.Show("Debes ingresar una nueva contraseña y confirmarla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Si todo está correcto
        MessageBox.Show("Contraseña actualizada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tbxNuevaContraseña_TextChanged(sender As Object, e As EventArgs) Handles tbxNuevaContraseña.TextChanged

    End Sub

    Private Sub btnCancelarCambios_Click(sender As Object, e As EventArgs) Handles btnCancelarCambios.Click

    End Sub
End Class