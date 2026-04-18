Public Class frmQR

    Dim segundos As Integer = 46

    Private Sub frmQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuramos el Timer para que se active cada segundo (1000 ms)
        tmrContador.Interval = 1000

        ' Lo encendemos
        tmrContador.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrContador.Tick
        ' Este código se ejecuta automáticamente cada segundo
        segundos -= 1

        ' Actualizamos el texto en la pantalla
        lblTimer.Text = "Seg: " & segundos

        If segundos <= 0 Then
            segundos = 46
        End If
    End Sub

    Private Sub lblTimer_Click(sender As Object, e As EventArgs) Handles lblTimer.Click

    End Sub

    Private Sub pnlQR_Paint(sender As Object, e As PaintEventArgs) Handles pnlQR.Paint

    End Sub

    Private Sub lblDes1_Click(sender As Object, e As EventArgs) Handles lblDes1.Click

    End Sub

    Private Sub btnINS_Click(sender As Object, e As EventArgs) Handles btnINS.Click
        Dim pantallaBienvenida As New frmInicio()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub lblEscq_Click(sender As Object, e As EventArgs) Handles lblEscq.Click

    End Sub
End Class