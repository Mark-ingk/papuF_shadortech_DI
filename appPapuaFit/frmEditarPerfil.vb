Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmEditarPerfil
    Private Sub cbxGeneroEditarPerfil_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpFechaNacimientoEditarPerfil_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancelarCambiosEditarPerfil_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEditarFotoPerfil_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAjustesEditarPerfil_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardarEditarPerfil_Click(sender As Object, e As EventArgs) Handles btnGuardarEditarPerfil.Click

    End Sub

    Private Sub btnCancelarEditarPerfil_Click(sender As Object, e As EventArgs) Handles btnCancelarEditarPerfil.Click

    End Sub

    Private Sub txbNumeroContactoEditarPerfil_TextChanged(sender As Object, e As EventArgs) Handles tbxNumeroContactoEditarPerfil.TextChanged
        tbxNumeroContactoEditarPerfil.MaxLength = 10

        Dim limite As Integer = tbxNumeroContactoEditarPerfil.MaxLength

        If tbxNumeroContactoEditarPerfil.Text.Length >= limite Then
            lblAviso.Text = "Máximo de caracteres alcanzado"
            lblAviso.ForeColor = Color.Red
            lblAviso.Visible = True
        Else
            lblAviso.Visible = False
        End If
    End Sub

    Private Sub pnlEditarPerfil_Paint(sender As Object, e As PaintEventArgs) Handles pnlEditarPerfil.Paint

    End Sub

    Private Sub lblEditarPerfilDeUsuario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbxMetas_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub spr5EditarPerfil_Click(sender As Object, e As EventArgs) Handles spr5EditarPerfil.Click

    End Sub

    Private Sub lblCiudadEditarPerfil_Click(sender As Object, e As EventArgs) Handles lblCiudadEditarPerfil.Click

    End Sub

    Private Sub tbxMetas_TextChanged(sender As Object, e As EventArgs) Handles tbxMetas.Enter
        tbxMetas.Clear()

    End Sub

    Private Sub pbxFotoPerfilEditarPerfil_Click(sender As Object, e As EventArgs) Handles pbxFotoPerfilEditarPerfil.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If ofd.ShowDialog() = DialogResult.OK Then
            pbxFotoPerfilEditarPerfil.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub pnlCuerpoEditarPerfil_Paint(sender As Object, e As PaintEventArgs) Handles pnlCuerpoEditarPerfil.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblClickEditarPerfilPapu_Click(sender As Object, e As EventArgs) Handles lblClickEditarPerfilPapu.Click

    End Sub

    Private Sub lblAviso_Click(sender As Object, e As EventArgs) Handles lblAviso.Click

    End Sub

    Private Sub tbxMetas_TextChanged_1(sender As Object, e As EventArgs) Handles tbxMetas.TextChanged

    End Sub
End Class