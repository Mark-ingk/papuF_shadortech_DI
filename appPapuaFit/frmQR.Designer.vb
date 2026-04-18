<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQR
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        tmrContador = New Timer(components)
        btnINS = New Guna.UI2.WinForms.Guna2Button()
        pnlQR = New Panel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblTimer = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblEscq = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblDes1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlQR.SuspendLayout()
        SuspendLayout()
        ' 
        ' tmrContador
        ' 
        tmrContador.Interval = 100000
        ' 
        ' btnINS
        ' 
        btnINS.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnINS.Animated = True
        btnINS.BorderRadius = 25
        btnINS.Cursor = Cursors.Hand
        btnINS.CustomizableEdges = CustomizableEdges1
        btnINS.DisabledState.BorderColor = Color.DarkGray
        btnINS.DisabledState.CustomBorderColor = Color.DarkGray
        btnINS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnINS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnINS.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnINS.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnINS.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnINS.Location = New Point(48, 729)
        btnINS.Margin = New Padding(0, 10, 0, 30)
        btnINS.Name = "btnINS"
        btnINS.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnINS.Size = New Size(294, 55)
        btnINS.TabIndex = 13
        btnINS.Text = "REGRESAR"
        ' 
        ' pnlQR
        ' 
        pnlQR.Anchor = AnchorStyles.None
        pnlQR.Controls.Add(Guna2HtmlLabel2)
        pnlQR.Controls.Add(lblTimer)
        pnlQR.Controls.Add(btnINS)
        pnlQR.Controls.Add(lblEscq)
        pnlQR.Controls.Add(lblDes1)
        pnlQR.Controls.Add(Guna2HtmlLabel1)
        pnlQR.Location = New Point(0, 0)
        pnlQR.MaximumSize = New Size(390, 844)
        pnlQR.Name = "pnlQR"
        pnlQR.Padding = New Padding(25, 25, 25, 40)
        pnlQR.Size = New Size(390, 844)
        pnlQR.TabIndex = 9
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Enabled = False
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = SystemColors.Control
        Guna2HtmlLabel2.IsSelectionEnabled = False
        Guna2HtmlLabel2.Location = New Point(129, 298)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(132, 23)
        Guna2HtmlLabel2.TabIndex = 15
        Guna2HtmlLabel2.Text = "El QR esxpirara en:"
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = Color.Transparent
        lblTimer.Enabled = False
        lblTimer.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimer.ForeColor = SystemColors.ButtonFace
        lblTimer.IsSelectionEnabled = False
        lblTimer.Location = New Point(171, 362)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(28, 22)
        lblTimer.TabIndex = 14
        lblTimer.Text = "Seg"
        ' 
        ' lblEscq
        ' 
        lblEscq.BackColor = Color.Transparent
        lblEscq.Enabled = False
        lblEscq.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEscq.ForeColor = Color.White
        lblEscq.IsSelectionEnabled = False
        lblEscq.Location = New Point(16, 60)
        lblEscq.Name = "lblEscq"
        lblEscq.Size = New Size(359, 49)
        lblEscq.TabIndex = 2
        lblEscq.Text = "Escanea el Codigo QR"
        ' 
        ' lblDes1
        ' 
        lblDes1.AutoSize = False
        lblDes1.AutoSizeHeightOnly = True
        lblDes1.BackColor = Color.Transparent
        lblDes1.Enabled = False
        lblDes1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDes1.ForeColor = SystemColors.ActiveBorder
        lblDes1.IsSelectionEnabled = False
        lblDes1.Location = New Point(26, 150)
        lblDes1.Name = "lblDes1"
        lblDes1.Size = New Size(339, 43)
        lblDes1.TabIndex = 4
        lblDes1.Text = "Coloque el codigo QR correctamente dentro del area"
        lblDes1.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Enabled = False
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = SystemColors.ActiveBorder
        Guna2HtmlLabel1.IsSelectionEnabled = False
        Guna2HtmlLabel1.Location = New Point(55, 234)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(280, 23)
        Guna2HtmlLabel1.TabIndex = 5
        Guna2HtmlLabel1.Text = "El escaneo comenzara automaticamente"
        ' 
        ' frmQR
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(pnlQR)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmQR"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmQR"
        pnlQR.ResumeLayout(False)
        pnlQR.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents tmrContador As Timer
    Friend WithEvents btnINS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlQR As Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTimer As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEscq As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDes1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
