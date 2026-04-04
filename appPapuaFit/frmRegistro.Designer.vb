<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlRegistro = New Guna.UI2.WinForms.Guna2Panel()
        textUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        txtNtel = New Guna.UI2.WinForms.Guna2TextBox()
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
        iconPesa = New FontAwesome.Sharp.IconPictureBox()
        pnlRegistro.SuspendLayout()
        CType(iconPesa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlRegistro
        ' 
        pnlRegistro.AutoSize = True
        pnlRegistro.BorderRadius = 30
        pnlRegistro.Controls.Add(textUsuario)
        pnlRegistro.Controls.Add(txtNtel)
        pnlRegistro.Controls.Add(LinkLabel1)
        pnlRegistro.Controls.Add(lblRegistro)
        pnlRegistro.Controls.Add(icbtnInstagram)
        pnlRegistro.Controls.Add(icbtnFacebook)
        pnlRegistro.Controls.Add(icbtnGoogle)
        pnlRegistro.Controls.Add(lblO)
        pnlRegistro.Controls.Add(spr1)
        pnlRegistro.Controls.Add(spr2)
        pnlRegistro.Controls.Add(btnINS)
        pnlRegistro.Controls.Add(txtContra)
        pnlRegistro.Controls.Add(txtEmail)
        pnlRegistro.Controls.Add(lblLog)
        pnlRegistro.Controls.Add(iconPesa)
        pnlRegistro.CustomizableEdges = CustomizableEdges11
        pnlRegistro.Dock = DockStyle.Fill
        pnlRegistro.Location = New Point(0, 0)
        pnlRegistro.MaximumSize = New Size(390, 844)
        pnlRegistro.MinimumSize = New Size(390, 844)
        pnlRegistro.Name = "pnlRegistro"
        pnlRegistro.Padding = New Padding(20)
        pnlRegistro.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        pnlRegistro.Size = New Size(390, 844)
        pnlRegistro.TabIndex = 1
        ' 
        ' textUsuario
        ' 
        textUsuario.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        textUsuario.BorderRadius = 20
        textUsuario.CustomizableEdges = CustomizableEdges1
        textUsuario.DefaultText = ""
        textUsuario.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textUsuario.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textUsuario.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textUsuario.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        textUsuario.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textUsuario.Font = New Font("Segoe UI", 9F)
        textUsuario.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        textUsuario.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textUsuario.Location = New Point(40, 211)
        textUsuario.Margin = New Padding(3, 4, 3, 4)
        textUsuario.Name = "textUsuario"
        textUsuario.PlaceholderText = "Nombre de usuario"
        textUsuario.SelectedText = ""
        textUsuario.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        textUsuario.Size = New Size(310, 50)
        textUsuario.TabIndex = 16
        ' 
        ' txtNtel
        ' 
        txtNtel.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtNtel.BorderRadius = 20
        txtNtel.CustomizableEdges = CustomizableEdges3
        txtNtel.DefaultText = ""
        txtNtel.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtNtel.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtNtel.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNtel.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNtel.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtNtel.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNtel.Font = New Font("Segoe UI", 9F)
        txtNtel.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtNtel.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtNtel.Location = New Point(40, 295)
        txtNtel.Margin = New Padding(3, 4, 3, 4)
        txtNtel.Name = "txtNtel"
        txtNtel.PlaceholderText = "Numero celular"
        txtNtel.SelectedText = ""
        txtNtel.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtNtel.Size = New Size(310, 50)
        txtNtel.TabIndex = 15
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.ForeColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        LinkLabel1.LinkColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        LinkLabel1.Location = New Point(231, 805)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(63, 15)
        LinkLabel1.TabIndex = 14
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Registrarte"
        ' 
        ' lblRegistro
        ' 
        lblRegistro.BackColor = Color.Transparent
        lblRegistro.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRegistro.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        lblRegistro.Location = New Point(73, 805)
        lblRegistro.Name = "lblRegistro"
        lblRegistro.Size = New Size(112, 21)
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
        icbtnInstagram.Location = New Point(269, 690)
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
        icbtnFacebook.Location = New Point(143, 681)
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
        icbtnGoogle.Location = New Point(31, 681)
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
        lblO.Location = New Point(200, 625)
        lblO.Name = "lblO"
        lblO.Size = New Size(20, 32)
        lblO.TabIndex = 9
        lblO.Text = "O"
        ' 
        ' spr1
        ' 
        spr1.Location = New Point(3, 605)
        spr1.Name = "spr1"
        spr1.Size = New Size(154, 18)
        spr1.TabIndex = 8
        ' 
        ' spr2
        ' 
        spr2.Location = New Point(224, 605)
        spr2.Name = "spr2"
        spr2.Size = New Size(154, 18)
        spr2.TabIndex = 7
        ' 
        ' btnINS
        ' 
        btnINS.Animated = True
        btnINS.BorderRadius = 25
        btnINS.CustomizableEdges = CustomizableEdges5
        btnINS.DisabledState.BorderColor = Color.DarkGray
        btnINS.DisabledState.CustomBorderColor = Color.DarkGray
        btnINS.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnINS.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnINS.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnINS.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnINS.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnINS.Location = New Point(40, 519)
        btnINS.Name = "btnINS"
        btnINS.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnINS.Size = New Size(310, 52)
        btnINS.TabIndex = 5
        btnINS.Text = "INICIAR"
        ' 
        ' txtContra
        ' 
        txtContra.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtContra.BorderRadius = 20
        txtContra.CustomizableEdges = CustomizableEdges7
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
        txtContra.Location = New Point(40, 421)
        txtContra.Margin = New Padding(3, 4, 3, 4)
        txtContra.Name = "txtContra"
        txtContra.PlaceholderText = "Contraseña"
        txtContra.SelectedText = ""
        txtContra.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtContra.Size = New Size(310, 50)
        txtContra.TabIndex = 4
        txtContra.UseSystemPasswordChar = True
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtEmail.BorderRadius = 20
        txtEmail.CustomizableEdges = CustomizableEdges9
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
        txtEmail.Location = New Point(40, 363)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.SelectedText = ""
        txtEmail.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtEmail.Size = New Size(310, 50)
        txtEmail.TabIndex = 3
        ' 
        ' lblLog
        ' 
        lblLog.BackColor = Color.Transparent
        lblLog.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLog.ForeColor = Color.White
        lblLog.Location = New Point(106, 168)
        lblLog.Name = "lblLog"
        lblLog.Size = New Size(181, 48)
        lblLog.TabIndex = 2
        lblLog.Text = "Registrarse"
        ' 
        ' iconPesa
        ' 
        iconPesa.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        iconPesa.ForeColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        iconPesa.IconChar = FontAwesome.Sharp.IconChar.Dumbbell
        iconPesa.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        iconPesa.IconFont = FontAwesome.Sharp.IconFont.Auto
        iconPesa.IconSize = 108
        iconPesa.Location = New Point(143, 34)
        iconPesa.Name = "iconPesa"
        iconPesa.Size = New Size(108, 108)
        iconPesa.TabIndex = 0
        iconPesa.TabStop = False
        ' 
        ' frmRegistro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(pnlRegistro)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmRegistro"
        StartPosition = FormStartPosition.CenterScreen
        pnlRegistro.ResumeLayout(False)
        pnlRegistro.PerformLayout()
        CType(iconPesa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlRegistro As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblRegistro As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents icbtnInstagram As FontAwesome.Sharp.IconButton
    Friend WithEvents icbtnFacebook As FontAwesome.Sharp.IconButton
    Friend WithEvents icbtnGoogle As FontAwesome.Sharp.IconButton
    Friend WithEvents lblO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents spr1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents spr2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents btnINS As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtContra As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLog As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents iconPesa As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents textUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNtel As Guna.UI2.WinForms.Guna2TextBox
End Class
