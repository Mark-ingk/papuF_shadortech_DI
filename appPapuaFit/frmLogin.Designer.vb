<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlLogin = New Guna.UI2.WinForms.Guna2Panel()
        lblLog = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnINS = New Guna.UI2.WinForms.Guna2Button()
        txtContra = New Guna.UI2.WinForms.Guna2TextBox()
        txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        iconPesa = New FontAwesome.Sharp.IconPictureBox()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        LinkLabel1 = New LinkLabel()
        lblRegistro = New Guna.UI2.WinForms.Guna2HtmlLabel()
        icbtnInstagram = New FontAwesome.Sharp.IconButton()
        icbtnFacebook = New FontAwesome.Sharp.IconButton()
        icbtnGoogle = New FontAwesome.Sharp.IconButton()
        spr2 = New Guna.UI2.WinForms.Guna2Separator()
        pnlLogin.SuspendLayout()
        CType(iconPesa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.Anchor = AnchorStyles.None
        pnlLogin.BorderRadius = 30
        pnlLogin.Controls.Add(lblLog)
        pnlLogin.Controls.Add(btnINS)
        pnlLogin.Controls.Add(txtContra)
        pnlLogin.Controls.Add(txtEmail)
        pnlLogin.Controls.Add(iconPesa)
        pnlLogin.Controls.Add(Guna2Separator1)
        pnlLogin.Controls.Add(LinkLabel1)
        pnlLogin.Controls.Add(lblRegistro)
        pnlLogin.Controls.Add(icbtnInstagram)
        pnlLogin.Controls.Add(icbtnFacebook)
        pnlLogin.Controls.Add(icbtnGoogle)
        pnlLogin.Controls.Add(spr2)
        pnlLogin.CustomizableEdges = CustomizableEdges7
        pnlLogin.Location = New Point(-1, 0)
        pnlLogin.Margin = New Padding(0)
        pnlLogin.MaximumSize = New Size(390, 844)
        pnlLogin.MinimumSize = New Size(390, 844)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Padding = New Padding(25, 25, 25, 40)
        pnlLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlLogin.Size = New Size(390, 844)
        pnlLogin.TabIndex = 0
        ' 
        ' lblLog
        ' 
        lblLog.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblLog.AutoSize = False
        lblLog.BackColor = Color.Transparent
        lblLog.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLog.ForeColor = Color.White
        lblLog.Location = New Point(50, 213)
        lblLog.Margin = New Padding(20, 40, 20, 10)
        lblLog.Name = "lblLog"
        lblLog.Size = New Size(314, 48)
        lblLog.TabIndex = 2
        lblLog.Text = "Iniciar Sesion"
        lblLog.TextAlignment = ContentAlignment.TopCenter
        ' 
        ' btnINS
        ' 
        btnINS.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnINS.Animated = True
        btnINS.BorderRadius = 25
        btnINS.CustomizableEdges = CustomizableEdges1
        btnINS.DisabledState.BorderColor = Color.DarkGray
        btnINS.DisabledState.CustomBorderColor = Color.DarkGray
        btnINS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnINS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnINS.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnINS.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnINS.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnINS.Location = New Point(47, 446)
        btnINS.Margin = New Padding(0, 10, 0, 30)
        btnINS.Name = "btnINS"
        btnINS.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnINS.Size = New Size(310, 55)
        btnINS.TabIndex = 5
        btnINS.Text = "INICIAR"
        ' 
        ' txtContra
        ' 
        txtContra.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtContra.Animated = True
        txtContra.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtContra.BorderRadius = 20
        txtContra.CustomizableEdges = CustomizableEdges3
        txtContra.DefaultText = ""
        txtContra.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtContra.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtContra.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtContra.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtContra.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtContra.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtContra.Font = New Font("Segoe UI", 9F)
        txtContra.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtContra.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtContra.Location = New Point(47, 371)
        txtContra.Margin = New Padding(0, 0, 0, 15)
        txtContra.Name = "txtContra"
        txtContra.PlaceholderText = "Contraseña"
        txtContra.SelectedText = ""
        txtContra.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtContra.Size = New Size(310, 55)
        txtContra.TabIndex = 4
        txtContra.TextOffset = New Point(10, 0)
        txtContra.UseSystemPasswordChar = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmail.Animated = True
        txtEmail.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtEmail.BorderRadius = 20
        txtEmail.CustomizableEdges = CustomizableEdges5
        txtEmail.DefaultText = ""
        txtEmail.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEmail.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEmail.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtEmail.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtEmail.Font = New Font("Segoe UI", 9F)
        txtEmail.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtEmail.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtEmail.Location = New Point(47, 296)
        txtEmail.Margin = New Padding(0, 0, 0, 15)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.SelectedText = ""
        txtEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtEmail.Size = New Size(310, 55)
        txtEmail.TabIndex = 3
        txtEmail.TextOffset = New Point(10, 0)
        ' 
        ' iconPesa
        ' 
        iconPesa.Anchor = AnchorStyles.Top
        iconPesa.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        iconPesa.ForeColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        iconPesa.IconChar = FontAwesome.Sharp.IconChar.Dumbbell
        iconPesa.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        iconPesa.IconFont = FontAwesome.Sharp.IconFont.Auto
        iconPesa.IconSize = 108
        iconPesa.Location = New Point(153, 100)
        iconPesa.Margin = New Padding(20, 40, 20, 10)
        iconPesa.Name = "iconPesa"
        iconPesa.Size = New Size(108, 108)
        iconPesa.TabIndex = 0
        iconPesa.TabStop = False
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(9, 548)
        Guna2Separator1.Margin = New Padding(0, 0, 0, 20)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(172, 18)
        Guna2Separator1.TabIndex = 15
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LinkLabel1.ForeColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        LinkLabel1.LinkColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        LinkLabel1.Location = New Point(226, 771)
        LinkLabel1.Margin = New Padding(10, 0, 0, 10)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Padding = New Padding(10, 0, 0, 0)
        LinkLabel1.Size = New Size(81, 20)
        LinkLabel1.TabIndex = 14
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Registrarte"
        LinkLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblRegistro
        ' 
        lblRegistro.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblRegistro.AutoSize = False
        lblRegistro.BackColor = Color.Transparent
        lblRegistro.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRegistro.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        lblRegistro.Location = New Point(21, 771)
        lblRegistro.Margin = New Padding(0, 0, 10, 10)
        lblRegistro.Name = "lblRegistro"
        lblRegistro.Size = New Size(195, 21)
        lblRegistro.TabIndex = 13
        lblRegistro.Text = "No tienes cuenta?"
        lblRegistro.TextAlignment = ContentAlignment.MiddleRight
        ' 
        ' icbtnInstagram
        ' 
        icbtnInstagram.Anchor = AnchorStyles.Bottom
        icbtnInstagram.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        icbtnInstagram.FlatStyle = FlatStyle.Flat
        icbtnInstagram.ForeColor = Color.Black
        icbtnInstagram.IconChar = FontAwesome.Sharp.IconChar.Instagram
        icbtnInstagram.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        icbtnInstagram.IconFont = FontAwesome.Sharp.IconFont.Auto
        icbtnInstagram.Location = New Point(307, 590)
        icbtnInstagram.Margin = New Padding(10, 0, 10, 0)
        icbtnInstagram.Name = "icbtnInstagram"
        icbtnInstagram.Size = New Size(57, 43)
        icbtnInstagram.TabIndex = 12
        icbtnInstagram.UseVisualStyleBackColor = False
        ' 
        ' icbtnFacebook
        ' 
        icbtnFacebook.Anchor = AnchorStyles.Bottom
        icbtnFacebook.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        icbtnFacebook.FlatStyle = FlatStyle.Flat
        icbtnFacebook.ForeColor = Color.Black
        icbtnFacebook.IconChar = FontAwesome.Sharp.IconChar.FacebookF
        icbtnFacebook.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        icbtnFacebook.IconFont = FontAwesome.Sharp.IconFont.Auto
        icbtnFacebook.Location = New Point(163, 590)
        icbtnFacebook.Margin = New Padding(10, 0, 10, 0)
        icbtnFacebook.Name = "icbtnFacebook"
        icbtnFacebook.Size = New Size(57, 43)
        icbtnFacebook.TabIndex = 11
        icbtnFacebook.UseVisualStyleBackColor = False
        ' 
        ' icbtnGoogle
        ' 
        icbtnGoogle.Anchor = AnchorStyles.Bottom
        icbtnGoogle.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        icbtnGoogle.FlatStyle = FlatStyle.Flat
        icbtnGoogle.ForeColor = Color.Black
        icbtnGoogle.IconChar = FontAwesome.Sharp.IconChar.Google
        icbtnGoogle.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        icbtnGoogle.IconFont = FontAwesome.Sharp.IconFont.Auto
        icbtnGoogle.Location = New Point(30, 590)
        icbtnGoogle.Margin = New Padding(10, 0, 10, 0)
        icbtnGoogle.Name = "icbtnGoogle"
        icbtnGoogle.Size = New Size(57, 43)
        icbtnGoogle.TabIndex = 10
        icbtnGoogle.UseVisualStyleBackColor = False
        ' 
        ' spr2
        ' 
        spr2.Location = New Point(206, 548)
        spr2.Margin = New Padding(0, 0, 0, 20)
        spr2.Name = "spr2"
        spr2.Size = New Size(172, 18)
        spr2.TabIndex = 7
        ' 
        ' frmLogin
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(pnlLogin)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        pnlLogin.ResumeLayout(False)
        CType(iconPesa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents iconPesa As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblLog As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContra As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnINS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents spr2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents icbtnGoogle As FontAwesome.Sharp.IconButton
    Friend WithEvents icbtnInstagram As FontAwesome.Sharp.IconButton
    Friend WithEvents icbtnFacebook As FontAwesome.Sharp.IconButton
    Friend WithEvents lblRegistro As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator

End Class
