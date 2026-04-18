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
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        tmrContador = New Timer(components)
        pnlQR = New Panel()
        btnSimAcceso = New Guna.UI2.WinForms.Guna2CircleButton()
        icpbStatus = New FontAwesome.Sharp.IconPictureBox()
        lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnCerrar = New FontAwesome.Sharp.IconButton()
        btnFlash = New FontAwesome.Sharp.IconButton()
        btnRecargar = New FontAwesome.Sharp.IconButton()
        pnlCntQR = New Guna.UI2.WinForms.Guna2Panel()
        pbxQr = New Guna.UI2.WinForms.Guna2PictureBox()
        pnlEsq1 = New Guna.UI2.WinForms.Guna2Panel()
        pnlEsq2 = New Guna.UI2.WinForms.Guna2Panel()
        pnlEsq4 = New Guna.UI2.WinForms.Guna2Panel()
        pnlEsq3 = New Guna.UI2.WinForms.Guna2Panel()
        lblMxpr = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblTimer = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblEscq = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblDes1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblM2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        ErrorProvider1 = New ErrorProvider(components)
        pnlQR.SuspendLayout()
        CType(icpbStatus, ComponentModel.ISupportInitialize).BeginInit()
        pnlCntQR.SuspendLayout()
        CType(pbxQr, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tmrContador
        ' 
        tmrContador.Interval = 100000
        ' 
        ' pnlQR
        ' 
        pnlQR.Anchor = AnchorStyles.None
        pnlQR.Controls.Add(btnSimAcceso)
        pnlQR.Controls.Add(icpbStatus)
        pnlQR.Controls.Add(lblStatus)
        pnlQR.Controls.Add(btnCerrar)
        pnlQR.Controls.Add(btnFlash)
        pnlQR.Controls.Add(btnRecargar)
        pnlQR.Controls.Add(pnlCntQR)
        pnlQR.Controls.Add(pnlEsq1)
        pnlQR.Controls.Add(pnlEsq2)
        pnlQR.Controls.Add(pnlEsq4)
        pnlQR.Controls.Add(pnlEsq3)
        pnlQR.Controls.Add(lblMxpr)
        pnlQR.Controls.Add(lblTimer)
        pnlQR.Controls.Add(lblEscq)
        pnlQR.Controls.Add(lblDes1)
        pnlQR.Controls.Add(lblM2)
        pnlQR.Location = New Point(0, 0)
        pnlQR.MaximumSize = New Size(390, 844)
        pnlQR.Name = "pnlQR"
        pnlQR.Padding = New Padding(25, 25, 25, 40)
        pnlQR.Size = New Size(390, 844)
        pnlQR.TabIndex = 9
        ' 
        ' btnSimAcceso
        ' 
        btnSimAcceso.BackColor = Color.FromArgb(CByte(13), CByte(13), CByte(13))
        btnSimAcceso.BackgroundImageLayout = ImageLayout.Stretch
        btnSimAcceso.BorderColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        btnSimAcceso.DisabledState.BorderColor = Color.DarkGray
        btnSimAcceso.DisabledState.CustomBorderColor = Color.DarkGray
        btnSimAcceso.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSimAcceso.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSimAcceso.FillColor = Color.FromArgb(CByte(13), CByte(13), CByte(13))
        btnSimAcceso.Font = New Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimAcceso.ForeColor = Color.Gray
        btnSimAcceso.Location = New Point(349, 806)
        btnSimAcceso.Name = "btnSimAcceso"
        btnSimAcceso.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        btnSimAcceso.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btnSimAcceso.Size = New Size(41, 38)
        btnSimAcceso.TabIndex = 27
        btnSimAcceso.Text = "+"
        btnSimAcceso.TextOffset = New Point(4, -4)
        ' 
        ' icpbStatus
        ' 
        icpbStatus.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        icpbStatus.BackgroundImageLayout = ImageLayout.None
        icpbStatus.ForeColor = Color.Gold
        icpbStatus.IconChar = FontAwesome.Sharp.IconChar.Circle
        icpbStatus.IconColor = Color.Gold
        icpbStatus.IconFont = FontAwesome.Sharp.IconFont.Solid
        icpbStatus.IconSize = 30
        icpbStatus.Location = New Point(129, 39)
        icpbStatus.Name = "icpbStatus"
        icpbStatus.Size = New Size(30, 30)
        icpbStatus.TabIndex = 26
        icpbStatus.TabStop = False
        ' 
        ' lblStatus
        ' 
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.White
        lblStatus.Location = New Point(28, 39)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(99, 27)
        lblStatus.TabIndex = 25
        lblStatus.Text = "Por vencer:"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnCerrar.FlatStyle = FlatStyle.Flat
        btnCerrar.ForeColor = SystemColors.ActiveCaptionText
        btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close
        btnCerrar.IconColor = Color.White
        btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnCerrar.Location = New Point(321, 39)
        btnCerrar.Margin = New Padding(0, 30, 25, 15)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(34, 34)
        btnCerrar.TabIndex = 21
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' btnFlash
        ' 
        btnFlash.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnFlash.FlatStyle = FlatStyle.Flat
        btnFlash.ForeColor = SystemColors.ActiveCaptionText
        btnFlash.IconChar = FontAwesome.Sharp.IconChar.CreditCard
        btnFlash.IconColor = Color.White
        btnFlash.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFlash.Location = New Point(223, 39)
        btnFlash.Margin = New Padding(10, 30, 0, 15)
        btnFlash.Name = "btnFlash"
        btnFlash.Size = New Size(34, 34)
        btnFlash.TabIndex = 22
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
        btnRecargar.Location = New Point(272, 39)
        btnRecargar.Margin = New Padding(15, 30, 15, 15)
        btnRecargar.Name = "btnRecargar"
        btnRecargar.Size = New Size(34, 34)
        btnRecargar.TabIndex = 24
        btnRecargar.UseVisualStyleBackColor = False
        ' 
        ' pnlCntQR
        ' 
        pnlCntQR.BackColor = Color.Transparent
        pnlCntQR.BorderRadius = 20
        pnlCntQR.Controls.Add(pbxQr)
        pnlCntQR.CustomizableEdges = CustomizableEdges4
        pnlCntQR.Location = New Point(64, 427)
        pnlCntQR.Name = "pnlCntQR"
        pnlCntQR.ShadowDecoration.BorderRadius = 20
        pnlCntQR.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlCntQR.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        pnlCntQR.ShadowDecoration.Enabled = True
        pnlCntQR.Size = New Size(260, 260)
        pnlCntQR.TabIndex = 16
        ' 
        ' pbxQr
        ' 
        pbxQr.BackColor = Color.White
        pbxQr.BackgroundImage = My.Resources.Resources.qrcodehd_1061112
        pbxQr.BackgroundImageLayout = ImageLayout.Stretch
        pbxQr.CustomizableEdges = CustomizableEdges2
        pbxQr.FillColor = Color.Transparent
        pbxQr.ImageRotate = 0F
        pbxQr.Location = New Point(27, 37)
        pbxQr.Name = "pbxQr"
        pbxQr.ShadowDecoration.Color = Color.White
        pbxQr.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        pbxQr.Size = New Size(205, 191)
        pbxQr.TabIndex = 0
        pbxQr.TabStop = False
        ' 
        ' pnlEsq1
        ' 
        pnlEsq1.BackColor = Color.Transparent
        pnlEsq1.BorderRadius = 20
        pnlEsq1.CustomizableEdges = CustomizableEdges6
        pnlEsq1.FillColor = Color.IndianRed
        pnlEsq1.Location = New Point(48, 412)
        pnlEsq1.Name = "pnlEsq1"
        pnlEsq1.ShadowDecoration.BorderRadius = 30
        pnlEsq1.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        pnlEsq1.ShadowDecoration.Shadow = New Padding(10)
        pnlEsq1.Size = New Size(92, 91)
        pnlEsq1.TabIndex = 17
        ' 
        ' pnlEsq2
        ' 
        pnlEsq2.BackColor = Color.Transparent
        pnlEsq2.BorderRadius = 20
        pnlEsq2.CustomizableEdges = CustomizableEdges8
        pnlEsq2.FillColor = Color.IndianRed
        pnlEsq2.Location = New Point(48, 616)
        pnlEsq2.Name = "pnlEsq2"
        pnlEsq2.ShadowDecoration.BorderRadius = 30
        pnlEsq2.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        pnlEsq2.ShadowDecoration.Shadow = New Padding(10)
        pnlEsq2.Size = New Size(92, 91)
        pnlEsq2.TabIndex = 18
        ' 
        ' pnlEsq4
        ' 
        pnlEsq4.BackColor = Color.Transparent
        pnlEsq4.BorderRadius = 20
        pnlEsq4.CustomizableEdges = CustomizableEdges10
        pnlEsq4.FillColor = Color.IndianRed
        pnlEsq4.Location = New Point(250, 412)
        pnlEsq4.Name = "pnlEsq4"
        pnlEsq4.ShadowDecoration.BorderRadius = 30
        pnlEsq4.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        pnlEsq4.ShadowDecoration.Shadow = New Padding(10)
        pnlEsq4.Size = New Size(92, 91)
        pnlEsq4.TabIndex = 19
        ' 
        ' pnlEsq3
        ' 
        pnlEsq3.BackColor = Color.Transparent
        pnlEsq3.BorderRadius = 20
        pnlEsq3.CustomizableEdges = CustomizableEdges12
        pnlEsq3.FillColor = Color.IndianRed
        pnlEsq3.Location = New Point(250, 616)
        pnlEsq3.Name = "pnlEsq3"
        pnlEsq3.ShadowDecoration.BorderRadius = 30
        pnlEsq3.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        pnlEsq3.ShadowDecoration.Shadow = New Padding(10)
        pnlEsq3.Size = New Size(92, 91)
        pnlEsq3.TabIndex = 20
        ' 
        ' lblMxpr
        ' 
        lblMxpr.BackColor = Color.Transparent
        lblMxpr.Enabled = False
        lblMxpr.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMxpr.ForeColor = SystemColors.Control
        lblMxpr.IsSelectionEnabled = False
        lblMxpr.Location = New Point(129, 281)
        lblMxpr.Name = "lblMxpr"
        lblMxpr.Size = New Size(132, 23)
        lblMxpr.TabIndex = 15
        lblMxpr.Text = "El QR esxpirara en:"
        ' 
        ' lblTimer
        ' 
        lblTimer.BackColor = Color.Transparent
        lblTimer.Enabled = False
        lblTimer.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimer.ForeColor = SystemColors.ButtonFace
        lblTimer.IsSelectionEnabled = False
        lblTimer.Location = New Point(153, 343)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(50, 39)
        lblTimer.TabIndex = 14
        lblTimer.Text = "Seg"
        ' 
        ' lblEscq
        ' 
        lblEscq.BackColor = Color.Transparent
        lblEscq.Enabled = False
        lblEscq.Font = New Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEscq.ForeColor = Color.White
        lblEscq.IsSelectionEnabled = False
        lblEscq.Location = New Point(21, 91)
        lblEscq.Name = "lblEscq"
        lblEscq.Size = New Size(348, 49)
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
        lblDes1.Location = New Point(26, 170)
        lblDes1.Name = "lblDes1"
        lblDes1.Size = New Size(339, 43)
        lblDes1.TabIndex = 4
        lblDes1.Text = "Coloque el codigo QR correctamente dentro del area"
        lblDes1.TextAlignment = ContentAlignment.MiddleCenter
        ' 
        ' lblM2
        ' 
        lblM2.BackColor = Color.Transparent
        lblM2.Enabled = False
        lblM2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblM2.ForeColor = SystemColors.ActiveBorder
        lblM2.IsSelectionEnabled = False
        lblM2.Location = New Point(55, 219)
        lblM2.Name = "lblM2"
        lblM2.Size = New Size(280, 23)
        lblM2.TabIndex = 5
        lblM2.Text = "El escaneo comenzara automaticamente"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
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
        CType(icpbStatus, ComponentModel.ISupportInitialize).EndInit()
        pnlCntQR.ResumeLayout(False)
        CType(pbxQr, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents tmrContador As Timer
    Friend WithEvents pnlQR As Panel
    Friend WithEvents pnlCntQR As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pbxQr As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlEsq1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlEsq2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlEsq4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlEsq3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMxpr As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTimer As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEscq As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDes1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblM2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFlash As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRecargar As FontAwesome.Sharp.IconButton
    Friend WithEvents icpbStatus As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSimAcceso As Guna.UI2.WinForms.Guna2CircleButton
End Class
