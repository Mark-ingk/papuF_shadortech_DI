Public Class frmLogin
    Private Sub btnINS_Click(sender As Object, e As EventArgs) Handles btnINS.Click
        Dim pantallaBienvenida As New frmAcceso()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim pantallaBienvenida As New frmRegistro()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub lblRegistro_Click(sender As Object, e As EventArgs) Handles lblRegistro.Click

    End Sub

    Private Sub icbtnInstagram_Click(sender As Object, e As EventArgs) Handles icbtnInstagram.Click

    End Sub

    Private Sub spr2_Click(sender As Object, e As EventArgs) Handles spr2.Click

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class
