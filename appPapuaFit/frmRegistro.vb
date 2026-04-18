Public Class frmRegistro
    Private Sub btnINS_Click(sender As Object, e As EventArgs) Handles btnINS.Click
        Dim pantallaBienvenida As New frmAcceso()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub lkbIsesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkbIsesion.LinkClicked
        Dim pantallaBienvenida As New frmLogin()
        pantallaBienvenida.Show()
        Me.Hide()

    End Sub
End Class