Public Class frmLogin
    Private Sub btnINS_Click(sender As Object, e As EventArgs) Handles btnINS.Click

        Dim pantallaBienvenida As New frmAcceso()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub
End Class
