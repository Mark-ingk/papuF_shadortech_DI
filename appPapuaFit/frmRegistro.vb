Public Class frmRegistro
    Private Sub iconPesa_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblO_Click(sender As Object, e As EventArgs) Handles lblO.Click

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlRegistro_Paint(sender As Object, e As PaintEventArgs) Handles pnlRegistro.Paint

    End Sub

    Private Sub icbtnGoogle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim pantallaBienvenida As New frmLogin()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub btnINS_Click(sender As Object, e As EventArgs) Handles btnINS.Click
        Dim pantallaBienvenida As New frmAcceso()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub
End Class