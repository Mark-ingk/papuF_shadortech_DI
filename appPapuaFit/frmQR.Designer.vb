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
        Dim btnCerrar As FontAwesome.Sharp.IconButton
        Dim btnFlash As FontAwesome.Sharp.IconButton
        Dim btnRecargar As FontAwesome.Sharp.IconButton
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlEsq1 = New Guna.UI2.WinForms.Guna2Panel()
        Panel1 = New Panel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblTimer = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnINS = New Guna.UI2.WinForms.Guna2Button()
        pnlCntQR = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        lblEscq = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblDes1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        tmrContador = New Timer(components)
        btnCerrar = New FontAwesome.Sharp.IconButton()
        btnFlash = New FontAwesome.Sharp.IconButton()
        btnRecargar = New FontAwesome.Sharp.IconButton()
        Panel1.SuspendLayout()
        pnlCntQR.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.ForeColor = SystemColors.ActiveCaptionText
        btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close
        btnCerrar.IconColor = Color.White
        btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCerrar.Location = New Point(34, 39)
        btnCerrar.Margin = New Padding(25, 30, 10, 15)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(34, 34)
        btnCerrar.TabIndex = 0
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnFlash
        ' 
        btnFlash.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnFlash.FlatStyle = FlatStyle.Flat
        btnFlash.ForeColor = SystemColors.ActiveCaptionText
        btnFlash.IconChar = FontAwesome.Sharp.IconChar.Bolt
        btnFlash.IconColor = Color.White
        btnFlash.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFlash.Location = New Point(281, 39)
        btnFlash.Margin = New Padding(10, 30, 10, 15)
        btnFlash.Name = "btnFlash"
        btnFlash.Size = New Size(34, 34)
        btnFlash.TabIndex = 1
        btnFlash.UseVisualStyleBackColor = False
        ' 
        ' btnRecargar
        ' 
        btnRecargar.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnRecargar.FlatStyle = FlatStyle.Flat
        btnRecargar.ForeColor = SystemColors.ActiveCaptionText
        btnRecargar.IconChar = FontAwesome.Sharp.IconChar.Refresh
        btnRecargar.IconColor = Color.White
        btnRecargar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRecargar.Location = New Point(322, 39)
        btnRecargar.Margin = New Padding(10, 30, 25, 15)
        btnRecargar.Name = "btnRecargar"
        btnRecargar.Size = New Size(34, 34)
        btnRecargar.TabIndex = 3
        btnRecargar.UseVisualStyleBackColor = False
        ' 
        ' pnlEsq1
        ' 
        pnlEsq1.BackColor = Color.Transparent
        pnlEsq1.BorderRadius = 20
        pnlEsq1.CustomizableEdges = CustomizableEdges1
        pnlEsq1.FillColor = Color.IndianRed
        pnlEsq1.Location = New Point(48, 346)
        pnlEsq1.Name = "pnlEsq1"
        pnlEsq1.ShadowDecoration.BorderRadius = 30
        pnlEsq1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlEsq1.ShadowDecoration.Shadow = New Padding(10)
        pnlEsq1.Size = New Size(92, 91)
        pnlEsq1.TabIndex = 8
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Guna2HtmlLabel2)
        Panel1.Controls.Add(lblTimer)
        Panel1.Controls.Add(btnINS)
        Panel1.Controls.Add(pnlCntQR)
        Panel1.Controls.Add(pnlEsq1)
        Panel1.Controls.Add(btnCerrar)
        Panel1.Controls.Add(btnFlash)
        Panel1.Controls.Add(lblEscq)
        Panel1.Controls.Add(btnRecargar)
        Panel1.Controls.Add(lblDes1)
        Panel1.Controls.Add(Guna2HtmlLabel1)
        Panel1.Controls.Add(Guna2Panel1)
        Panel1.Controls.Add(Guna2Panel2)
        Panel1.Controls.Add(Guna2Panel3)
        Panel1.Location = New Point(0, 0)
        Panel1.MaximumSize = New Size(390, 844)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(25, 25, 25, 40)
        Panel1.Size = New Size(390, 844)
        Panel1.TabIndex = 9
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.ForeColor = SystemColors.Control
        Guna2HtmlLabel2.Location = New Point(143, 252)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(100, 17)
        Guna2HtmlLabel2.TabIndex = 15
        Guna2HtmlLabel2.Text = "El QR esxpirara en:"
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = Color.Transparent
        lblTimer.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimer.ForeColor = SystemColors.ButtonFace
        lblTimer.Location = New Point(179, 302)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(28, 22)
        lblTimer.TabIndex = 14
        lblTimer.Text = "Seg"
        ' 
        ' btnINS
        ' 
        btnINS.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnINS.Animated = True
        btnINS.BorderRadius = 25
        btnINS.CustomizableEdges = CustomizableEdges3
        btnINS.DisabledState.BorderColor = Color.DarkGray
        btnINS.DisabledState.CustomBorderColor = Color.DarkGray
        btnINS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnINS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnINS.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnINS.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnINS.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnINS.Location = New Point(46, 732)
        btnINS.Margin = New Padding(0, 10, 0, 30)
        btnINS.Name = "btnINS"
        btnINS.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnINS.Size = New Size(310, 55)
        btnINS.TabIndex = 13
        btnINS.Text = "REGRESAR"
        ' 
        ' pnlCntQR
        ' 
        pnlCntQR.BackColor = Color.Transparent
        pnlCntQR.BorderRadius = 20
        pnlCntQR.Controls.Add(Guna2PictureBox1)
        pnlCntQR.CustomizableEdges = CustomizableEdges7
        pnlCntQR.Location = New Point(64, 361)
        pnlCntQR.Name = "pnlCntQR"
        pnlCntQR.ShadowDecoration.BorderRadius = 20
        pnlCntQR.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlCntQR.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlCntQR.ShadowDecoration.Enabled = True
        pnlCntQR.Size = New Size(260, 260)
        pnlCntQR.TabIndex = 6
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.BackColor = Color.White
        Guna2PictureBox1.BackgroundImage = My.Resources.Resources.qrcodehd_1061112
        Guna2PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges5
        Guna2PictureBox1.FillColor = Color.Transparent
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(27, 37)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.Color = Color.White
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2PictureBox1.Size = New Size(205, 191)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' lblEscq
        ' 
        lblEscq.BackColor = Color.Transparent
        lblEscq.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEscq.ForeColor = Color.White
        lblEscq.Location = New Point(100, 51)
        lblEscq.Name = "lblEscq"
        lblEscq.Size = New Size(152, 22)
        lblEscq.TabIndex = 2
        lblEscq.Text = "Escanea el Codigo QR"
        ' 
        ' lblDes1
        ' 
        lblDes1.BackColor = Color.Transparent
        lblDes1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDes1.ForeColor = SystemColors.ActiveBorder
        lblDes1.Location = New Point(34, 122)
        lblDes1.Name = "lblDes1"
        lblDes1.Size = New Size(319, 19)
        lblDes1.TabIndex = 4
        lblDes1.Text = "Coloque el codigo QR correctamente dentro del area."
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = SystemColors.ActiveBorder
        Guna2HtmlLabel1.Location = New Point(73, 169)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(240, 19)
        Guna2HtmlLabel1.TabIndex = 5
        Guna2HtmlLabel1.Text = "El escaneo comenzara automaticamente."
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 20
        Guna2Panel1.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.FillColor = Color.IndianRed
        Guna2Panel1.Location = New Point(48, 550)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.BorderRadius = 30
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel1.ShadowDecoration.Shadow = New Padding(10)
        Guna2Panel1.Size = New Size(92, 91)
        Guna2Panel1.TabIndex = 9
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.Transparent
        Guna2Panel2.BorderRadius = 20
        Guna2Panel2.CustomizableEdges = CustomizableEdges11
        Guna2Panel2.FillColor = Color.IndianRed
        Guna2Panel2.Location = New Point(250, 346)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.BorderRadius = 30
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel2.ShadowDecoration.Shadow = New Padding(10)
        Guna2Panel2.Size = New Size(92, 91)
        Guna2Panel2.TabIndex = 10
        ' 
        ' Guna2Panel3
        ' 
        Guna2Panel3.BackColor = Color.Transparent
        Guna2Panel3.BorderRadius = 20
        Guna2Panel3.CustomizableEdges = CustomizableEdges13
        Guna2Panel3.FillColor = Color.IndianRed
        Guna2Panel3.Location = New Point(250, 550)
        Guna2Panel3.Name = "Guna2Panel3"
        Guna2Panel3.ShadowDecoration.BorderRadius = 30
        Guna2Panel3.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2Panel3.ShadowDecoration.Shadow = New Padding(10)
        Guna2Panel3.Size = New Size(92, 91)
        Guna2Panel3.TabIndex = 12
        ' 
        ' tmrContador
        ' 
        tmrContador.Interval = 100000
        ' 
        ' frmQR
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmQR"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmQR"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnlCntQR.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlEsq1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlCntQR As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblEscq As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDes1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnINS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTimer As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents tmrContador As Timer
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
