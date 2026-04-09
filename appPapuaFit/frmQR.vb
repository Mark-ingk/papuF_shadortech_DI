Public Class frmQR

    Dim segundos As Integer = 0

    Private Sub frmQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuramos el Timer para que se active cada segundo (1000 ms)
        tmrContador.Interval = 1000

        ' Lo encendemos
        tmrContador.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrContador.Tick
        ' Este código se ejecuta automáticamente cada segundo
        segundos += 1

        ' Actualizamos el texto en la pantalla
        lblTimer.Text = "Seg: " & segundos
    End Sub

End Class