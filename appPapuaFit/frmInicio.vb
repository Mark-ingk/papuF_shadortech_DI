Public Class frmInicio
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Dim pantallaPerfilPapu As New frmPerfilPapu()
        pantallaPerfilPapu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRutinas_Click(sender As Object, e As EventArgs) Handles btnRutinas.Click
        Dim pantallaRutinas As New frmRutinas()
        pantallaRutinas.Show()
        Me.Hide()
    End Sub

    Private Sub btnQr_Click(sender As Object, e As EventArgs) Handles btnQr.Click
        Dim pantallaQR As New frmQR()
        pantallaQR.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim pantallaInicio As New frmInicio()
        pantallaInicio.Show()
        Me.Hide()
    End Sub
End Class