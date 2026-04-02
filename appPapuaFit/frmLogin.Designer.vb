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
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlLogin = New Guna.UI2.WinForms.Guna2Panel()
        LinkLabel1 = New LinkLabel()
        lblRegistro = New Guna.UI2.WinForms.Guna2HtmlLabel()
        icbtnInstagram = New FontAwesome.Sharp.IconButton()
        icbtnFacebook = New FontAwesome.Sharp.IconButton()
        icbtnGoogle = New FontAwesome.Sharp.IconButton()
        lblO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        spr1 = New Guna.UI2.WinForms.Guna2Separator()
        spr2 = New Guna.UI2.WinForms.Guna2Separator()
        btnINS = New Guna.UI2.WinForms.Guna2Button()
        txtContra = New Guna.UI2.WinForms.Guna2TextBox()
        txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        lblLog = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        iconPesa = New FontAwesome.Sharp.IconPictureBox()
        pnlLogin.SuspendLayout()
        CType(iconPesa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.AutoSize = True
        pnlLogin.BorderRadius = 30
        pnlLogin.Controls.Add(LinkLabel1)
        pnlLogin.Controls.Add(lblRegistro)
        pnlLogin.Controls.Add(icbtnInstagram)
        pnlLogin.Controls.Add(icbtnFacebook)
        pnlLogin.Controls.Add(icbtnGoogle)
        pnlLogin.Controls.Add(lblO)
        pnlLogin.Controls.Add(spr1)
        pnlLogin.Controls.Add(spr2)
        pnlLogin.Controls.Add(btnINS)
        pnlLogin.Controls.Add(txtContra)
        pnlLogin.Controls.Add(txtEmail)
        pnlLogin.Controls.Add(lblLog)
        pnlLogin.Controls.Add(Guna2HtmlLabel1)
        pnlLogin.Controls.Add(iconPesa)
        pnlLogin.CustomizableEdges = CustomizableEdges15
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(0, 0)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        pnlLogin.Size = New Size(390, 844)
        pnlLogin.TabIndex = 0
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.ForeColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        LinkLabel1.LinkColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        LinkLabel1.Location = New Point(211, 785)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(81, 20)
        LinkLabel1.TabIndex = 14
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Registrarte"
        ' 
        ' lblRegistro
        ' 
        lblRegistro.BackColor = Color.Transparent
        lblRegistro.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRegistro.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        lblRegistro.Location = New Point(53, 785)
        lblRegistro.Name = "lblRegistro"
        lblRegistro.Size = New Size(141, 25)
        lblRegistro.TabIndex = 13
        lblRegistro.Text = "No tienes cuenta?"
        ' 
        ' icbtnInstagram
        ' 
        icbtnInstagram.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        icbtnInstagram.FlatStyle = FlatStyle.Flat
        icbtnInstagram.ForeColor = Color.Black
        icbtnInstagram.IconChar = FontAwesome.Sharp.IconChar.Instagram
        icbtnInstagram.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        icbtnInstagram.IconFont = FontAwesome.Sharp.IconFont.Auto
        icbtnInstagram.Location = New Point(275, 641)
        icbtnInstagram.Name = "icbtnInstagram"
        icbtnInstagram.Size = New Size(57, 43)
        icbtnInstagram.TabIndex = 12
        icbtnInstagram.UseVisualStyleBackColor = False
        ' 
        ' icbtnFacebook
        ' 
        icbtnFacebook.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        icbtnFacebook.FlatStyle = FlatStyle.Flat
        icbtnFacebook.ForeColor = Color.Black
        icbtnFacebook.IconChar = FontAwesome.Sharp.IconChar.FacebookF
        icbtnFacebook.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        icbtnFacebook.IconFont = FontAwesome.Sharp.IconFont.Auto
        icbtnFacebook.Location = New Point(160, 641)
        icbtnFacebook.Name = "icbtnFacebook"
        icbtnFacebook.Size = New Size(57, 43)
        icbtnFacebook.TabIndex = 11
        icbtnFacebook.UseVisualStyleBackColor = False
        ' 
        ' icbtnGoogle
        ' 
        icbtnGoogle.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        icbtnGoogle.FlatStyle = FlatStyle.Flat
        icbtnGoogle.ForeColor = Color.Black
        icbtnGoogle.IconChar = FontAwesome.Sharp.IconChar.Google
        icbtnGoogle.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        icbtnGoogle.IconFont = FontAwesome.Sharp.IconFont.Auto
        icbtnGoogle.Location = New Point(40, 641)
        icbtnGoogle.Name = "icbtnGoogle"
        icbtnGoogle.Size = New Size(57, 43)
        icbtnGoogle.TabIndex = 10
        icbtnGoogle.UseVisualStyleBackColor = False
        ' 
        ' lblO
        ' 
        lblO.BackColor = Color.Transparent
        lblO.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblO.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        lblO.Location = New Point(180, 550)
        lblO.Name = "lblO"
        lblO.Size = New Size(23, 39)
        lblO.TabIndex = 9
        lblO.Text = "O"
        ' 
        ' spr1
        ' 
        spr1.Location = New Point(12, 559)
        spr1.Name = "spr1"
        spr1.Size = New Size(154, 18)
        spr1.TabIndex = 8
        ' 
        ' spr2
        ' 
        spr2.Location = New Point(224, 559)
        spr2.Name = "spr2"
        spr2.Size = New Size(154, 18)
        spr2.TabIndex = 7
        ' 
        ' btnINS
        ' 
        btnINS.Animated = True
        btnINS.BorderRadius = 25
        btnINS.CustomizableEdges = CustomizableEdges9
        btnINS.DisabledState.BorderColor = Color.DarkGray
        btnINS.DisabledState.CustomBorderColor = Color.DarkGray
        btnINS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnINS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnINS.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnINS.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnINS.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnINS.Location = New Point(40, 443)
        btnINS.Name = "btnINS"
        btnINS.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnINS.Size = New Size(310, 52)
        btnINS.TabIndex = 5
        btnINS.Text = "INICIAR -->"
        ' 
        ' txtContra
        ' 
        txtContra.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtContra.BorderRadius = 20
        txtContra.CustomizableEdges = CustomizableEdges11
        txtContra.DefaultText = ""
        txtContra.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtContra.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtContra.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtContra.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtContra.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtContra.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtContra.Font = New Font("Segoe UI", 9F)
        txtContra.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtContra.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtContra.Location = New Point(40, 364)
        txtContra.Margin = New Padding(3, 4, 3, 4)
        txtContra.Name = "txtContra"
        txtContra.PlaceholderText = "Contraseña"
        txtContra.SelectedText = ""
        txtContra.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txtContra.Size = New Size(310, 50)
        txtContra.TabIndex = 4
        txtContra.UseSystemPasswordChar = True
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtEmail.BorderRadius = 20
        txtEmail.CustomizableEdges = CustomizableEdges13
        txtEmail.DefaultText = ""
        txtEmail.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEmail.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEmail.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEmail.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtEmail.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Font = New Font("Segoe UI", 9F)
        txtEmail.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtEmail.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEmail.Location = New Point(40, 292)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.SelectedText = ""
        txtEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        txtEmail.Size = New Size(310, 50)
        txtEmail.TabIndex = 3
        ' 
        ' lblLog
        ' 
        lblLog.BackColor = Color.Transparent
        lblLog.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLog.ForeColor = Color.White
        lblLog.Location = New Point(53, 197)
        lblLog.Name = "lblLog"
        lblLog.Size = New Size(270, 61)
        lblLog.TabIndex = 2
        lblLog.Text = "Iniciar Sesion"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Location = New Point(53, 218)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(3, 2)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = Nothing
        ' 
        ' iconPesa
        ' 
        iconPesa.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        iconPesa.ForeColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        iconPesa.IconChar = FontAwesome.Sharp.IconChar.Dumbbell
        iconPesa.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        iconPesa.IconFont = FontAwesome.Sharp.IconFont.Auto
        iconPesa.IconSize = 108
        iconPesa.Location = New Point(137, 73)
        iconPesa.Name = "iconPesa"
        iconPesa.Size = New Size(108, 108)
        iconPesa.TabIndex = 0
        iconPesa.TabStop = False
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
        pnlLogin.PerformLayout()
        CType(iconPesa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlLogin As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents iconPesa As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblLog As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContra As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnINS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents spr2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents spr1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents icbtnGoogle As FontAwesome.Sharp.IconButton
    Friend WithEvents icbtnInstagram As FontAwesome.Sharp.IconButton
    Friend WithEvents icbtnFacebook As FontAwesome.Sharp.IconButton
    Friend WithEvents lblRegistro As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
