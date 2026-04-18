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
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        tmrContador = New Timer(components)
        pnlQR = New Panel()
        btnINS = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        pnlCntQR = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        pnlEsq1 = New Guna.UI2.WinForms.Guna2Panel()
        lblTimer = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblDes1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblEscq = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlQR.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlCntQR.SuspendLayout()
        SuspendLayout()
        ' 
        ' tmrContador
        ' 
        tmrContador.Interval = 100000
        ' 
        ' pnlQR
        ' 
        pnlQR.Anchor = AnchorStyles.None
        pnlQR.Controls.Add(pnlCntQR)
        pnlQR.Controls.Add(pnlEsq1)
        pnlQR.Controls.Add(Guna2Panel1)
        pnlQR.Controls.Add(Guna2Panel2)
        pnlQR.Controls.Add(Guna2Panel3)
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
        ' btnINS
        ' 
        btnINS.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnINS.Animated = True
        btnINS.BorderRadius = 25
        btnINS.Cursor = Cursors.Hand
        btnINS.CustomizableEdges = CustomizableEdges13
        btnINS.DisabledState.BorderColor = Color.DarkGray
        btnINS.DisabledState.CustomBorderColor = Color.DarkGray
        btnINS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnINS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnINS.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnINS.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnINS.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnINS.Location = New Point(48, 750)
        btnINS.Margin = New Padding(0, 10, 0, 30)
        btnINS.Name = "btnINS"
        btnINS.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnINS.Size = New Size(294, 55)
        btnINS.TabIndex = 13
        btnINS.Text = "REGRESAR"
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.Transparent
        Guna2Panel3.BorderRadius = 20
        Guna2Panel3.CustomizableEdges = CustomizableEdges11
        Guna2Panel3.FillColor = Color.IndianRed
        Guna2Panel3.Location = New Point(250, 616)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.BorderRadius = 30
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel3.ShadowDecoration.Shadow = New Padding(10)
        Guna2Panel3.Size = New Size(92, 91)
        Guna2Panel3.TabIndex = 20
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.CustomizableEdges = CustomizableEdges7
        Guna2Panel1.FillColor = Color.IndianRed
        Guna2Panel1.Location = New Point(48, 616)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.BorderRadius = 30
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.ShadowDecoration.Shadow = New Padding(10)
        Guna2Panel1.Size = New Size(92, 91)
        Guna2Panel1.TabIndex = 18
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.White
        Guna2PictureBox1.BackgroundImage = My.Resources.Resources.qrcodehd_1061112
        Guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.FillColor = Color.Transparent
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(27, 37)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.Color = Color.White
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(205, 191)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' pnlCntQR
        ' 
        pnlCntQR.BackColor = Color.Transparent
        pnlCntQR.BorderRadius = 20
        pnlCntQR.Controls.Add(Guna2PictureBox1)
        pnlCntQR.CustomizableEdges = CustomizableEdges3
        pnlCntQR.Location = New Point(64, 427)
        pnlCntQR.Name = "pnlCntQR"
        pnlCntQR.ShadowDecoration.BorderRadius = 20
        pnlCntQR.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlCntQR.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlCntQR.ShadowDecoration.Enabled = True
        pnlCntQR.Size = New Size(260, 260)
        pnlCntQR.TabIndex = 16
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.CustomizableEdges = CustomizableEdges9
        Guna2Panel2.FillColor = Color.IndianRed
        Guna2Panel2.Location = New Point(250, 412)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.BorderRadius = 30
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel2.ShadowDecoration.Shadow = New Padding(10)
        Guna2Panel2.Size = New Size(92, 91)
        Guna2Panel2.TabIndex = 19
        ' 
        ' pnlEsq1
        ' 
        pnlEsq1.BackColor = Color.Transparent
        pnlEsq1.BorderRadius = 20
        pnlEsq1.CustomizableEdges = CustomizableEdges5
        pnlEsq1.FillColor = Color.IndianRed
        pnlEsq1.Location = New Point(48, 412)
        pnlEsq1.Name = "pnlEsq1"
        pnlEsq1.ShadowDecoration.BorderRadius = 30
        pnlEsq1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlEsq1.ShadowDecoration.Shadow = New Padding(10)
        pnlEsq1.Size = New Size(92, 91)
        pnlEsq1.TabIndex = 17
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = Color.Transparent
        lblTimer.Enabled = False
        lblTimer.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimer.ForeColor = SystemColors.ButtonFace
        lblTimer.IsSelectionEnabled = False
        lblTimer.Location = New Point(177, 350)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(28, 22)
        lblTimer.TabIndex = 14
        lblTimer.Text = "Seg"
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Enabled = False
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.ForeColor = SystemColors.Control
        Guna2HtmlLabel2.IsSelectionEnabled = False
        Guna2HtmlLabel2.Location = New Point(129, 281)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(132, 23)
        Guna2HtmlLabel2.TabIndex = 15
        Guna2HtmlLabel2.Text = "El QR esxpirara en:"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Enabled = False
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = SystemColors.ActiveBorder
        Guna2HtmlLabel1.IsSelectionEnabled = False
        Guna2HtmlLabel1.Location = New Point(55, 212)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(280, 23)
        Guna2HtmlLabel1.TabIndex = 5
        Guna2HtmlLabel1.Text = "El escaneo comenzara automaticamente"
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
        lblDes1.Location = New Point(26, 123)
        lblDes1.Name = "lblDes1"
        lblDes1.Size = New Size(339, 43)
        lblDes1.TabIndex = 4
        lblDes1.Text = "Coloque el codigo QR correctamente dentro del area"
        lblDes1.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' lblEscq
        ' 
        lblEscq.BackColor = Color.Transparent
        lblEscq.Enabled = False
        lblEscq.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEscq.ForeColor = Color.White
        lblEscq.IsSelectionEnabled = False
        lblEscq.Location = New Point(16, 28)
        lblEscq.Name = "lblEscq"
        lblEscq.Size = New Size(359, 49)
        lblEscq.TabIndex = 2
        lblEscq.Text = "Escanea el Codigo QR"
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
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlCntQR.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents tmrContador As Timer
    Friend WithEvents pnlQR As Panel
    Friend WithEvents pnlCntQR As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlEsq1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTimer As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnINS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblEscq As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDes1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
