Public Class frmAcceso
    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        Dim pantallaBienvenida As New frmQR()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

End Class