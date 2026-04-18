Public Class frmAcceso
    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        Dim pantallaBienvenida As New frmInicio()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Dim pantallaBienvenida As New frmPerfilPapu()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub
End Class