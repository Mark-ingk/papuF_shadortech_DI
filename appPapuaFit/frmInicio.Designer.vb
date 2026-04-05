<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        lblinicio = New Guna.UI2.WinForms.Guna2HtmlLabel()
        SuspendLayout()
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.BorderRadius = 25
        Guna2ShadowForm1.ShadowColor = Color.Red
        ' 
        ' lblinicio
        ' 
        lblinicio.BackColor = Color.Transparent
        lblinicio.Font = New Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblinicio.ForeColor = SystemColors.Control
        lblinicio.Location = New Point(12, 136)
        lblinicio.Name = "lblinicio"
        lblinicio.Size = New Size(295, 52)
        lblinicio.TabIndex = 0
        lblinicio.Text = "Guna2HtmlLabel1"
        ' 
        ' frmInicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(341, 633)
        Controls.Add(lblinicio)
        ForeColor = SystemColors.ButtonFace
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(341, 633)
        MinimumSize = New Size(341, 633)
        Name = "frmInicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmInicio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents lblinicio As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
