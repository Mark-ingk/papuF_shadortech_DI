Public Class frmEventos

    ' Valores máximos
    Private progresoMaximoMes As Integer = 15
    Private progresoMaximoSemana As Integer = 7
    Private progresoMaximoDia As Integer = 2

    Private Sub frmEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial del ProgressBar mensual
        pbrEventoMes.Minimum = 0
        pbrEventoMes.Maximum = progresoMaximoMes
        ActualizarTextoMes()

        ' Configuración inicial del ProgressBar semanal
        pbrEventoSemana.Minimum = 0
        pbrEventoSemana.Maximum = progresoMaximoSemana
        ActualizarTextoSemana()

        ' Configuración inicial del ProgressBar diario
        pbrEventoDia.Minimum = 0
        pbrEventoDia.Maximum = progresoMaximoDia
        ActualizarTextoDia()
    End Sub

    ' ----------------- Mensual -----------------
    Private Sub pbrEventoMes_ValueChanged(sender As Object, e As EventArgs) Handles pbrEventoMes.ValueChanged
        ActualizarTextoMes()
    End Sub

    Private Sub ActualizarTextoMes()
        pbrEventoMes.Text = pbrEventoMes.Value.ToString() & " / " & progresoMaximoMes.ToString()
    End Sub

    ' ----------------- Semanal -----------------
    Private Sub pbrEventoSemana_ValueChanged(sender As Object, e As EventArgs) Handles pbrEventoSemana.ValueChanged
        ActualizarTextoSemana()
    End Sub

    Private Sub ActualizarTextoSemana()
        pbrEventoSemana.Text = pbrEventoSemana.Value.ToString() & " / " & progresoMaximoSemana.ToString()
    End Sub

    ' ----------------- Diario -----------------
    Private Sub pbrEventoDia_ValueChanged(sender As Object, e As EventArgs) Handles pbrEventoDia.ValueChanged
        ActualizarTextoDia()
    End Sub

    Private Sub ActualizarTextoDia()
        pbrEventoDia.Text = pbrEventoDia.Value.ToString() & " / " & progresoMaximoDia.ToString()
    End Sub

    Private Sub lblEventoMes_Click(sender As Object, e As EventArgs) Handles lblEventoMes.Click

    End Sub
End Class
