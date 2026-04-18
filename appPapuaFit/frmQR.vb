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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim pantallaBienvenida As New frmAcceso()
        pantallaBienvenida.Show()
        Me.Hide()
    End Sub

    Private Sub btnFlash_Click(sender As Object, e As EventArgs) Handles btnFlash.Click
        Dim pantallaPagos As New frmPagos()
        pantallaPagos.Show()
        Me.Hide()
    End Sub

    Private Sub btnSimAcceso_Click(sender As Object, e As EventArgs) Handles btnSimAcceso.Click
        Dim pantallaInicio As New frmInicio
        pantallaInicio.Show()
        Hide()
    End Sub
End Class