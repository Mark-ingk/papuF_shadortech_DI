Public Class frmLogin
    Private Sub btnINS_Click(sender As Object, e As EventArgs) Handles btnINS.Click

        Dim pantallaBienvenida As New frmAcceso()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub lblRegistro_Click(sender As Object, e As EventArgs) Handles lblRegistro.Click

    End Sub
End Class
