<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarPerfil
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        dtpFechaNacimientoEditarPerfil = New Guna.UI2.WinForms.Guna2DateTimePicker()
        lblFechaNacimientoEditarPerfil = New Label()
        txtNombreEditarPerfil = New Guna.UI2.WinForms.Guna2TextBox()
        lblNombreEditarPerfil = New Label()
        btnEditarFotoPerfil = New Guna.UI2.WinForms.Guna2Button()
        pbxEditarFotoPerfil = New PictureBox()
        lblEditarPerfilDeUsuario = New Label()
        btnAjustesEditarPerfil = New Button()
        btnRegresarEditarPerfil = New Button()
        Panel1.SuspendLayout()
        CType(pbxEditarFotoPerfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(dtpFechaNacimientoEditarPerfil)
        Panel1.Controls.Add(lblFechaNacimientoEditarPerfil)
        Panel1.Controls.Add(txtNombreEditarPerfil)
        Panel1.Controls.Add(lblNombreEditarPerfil)
        Panel1.Controls.Add(btnEditarFotoPerfil)
        Panel1.Controls.Add(pbxEditarFotoPerfil)
        Panel1.Controls.Add(lblEditarPerfilDeUsuario)
        Panel1.Controls.Add(btnAjustesEditarPerfil)
        Panel1.Controls.Add(btnRegresarEditarPerfil)
        Panel1.Location = New Point(0, 0)
        Panel1.MaximumSize = New Size(390, 844)
        Panel1.MinimumSize = New Size(390, 844)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(25)
        Panel1.Size = New Size(390, 844)
        Panel1.TabIndex = 0
        ' 
        ' dtpFechaNacimientoEditarPerfil
        ' 
        dtpFechaNacimientoEditarPerfil.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        dtpFechaNacimientoEditarPerfil.BorderRadius = 15
        dtpFechaNacimientoEditarPerfil.Checked = True
        dtpFechaNacimientoEditarPerfil.CustomizableEdges = CustomizableEdges7
        dtpFechaNacimientoEditarPerfil.FillColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dtpFechaNacimientoEditarPerfil.Font = New Font("Segoe UI", 9F)
        dtpFechaNacimientoEditarPerfil.Format = DateTimePickerFormat.Long
        dtpFechaNacimientoEditarPerfil.Location = New Point(13, 380)
        dtpFechaNacimientoEditarPerfil.MaxDate = New Date(2026, 12, 31, 0, 0, 0, 0)
        dtpFechaNacimientoEditarPerfil.MinDate = New Date(1970, 12, 31, 0, 0, 0, 0)
        dtpFechaNacimientoEditarPerfil.Name = "dtpFechaNacimientoEditarPerfil"
        dtpFechaNacimientoEditarPerfil.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        dtpFechaNacimientoEditarPerfil.Size = New Size(364, 37)
        dtpFechaNacimientoEditarPerfil.TabIndex = 40
        dtpFechaNacimientoEditarPerfil.Value = New Date(2026, 4, 8, 18, 56, 16, 229)
        ' 
        ' lblFechaNacimientoEditarPerfil
        ' 
        lblFechaNacimientoEditarPerfil.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFechaNacimientoEditarPerfil.ForeColor = SystemColors.ButtonHighlight
        lblFechaNacimientoEditarPerfil.Location = New Point(13, 349)
        lblFechaNacimientoEditarPerfil.Margin = New Padding(4, 0, 4, 0)
        lblFechaNacimientoEditarPerfil.Name = "lblFechaNacimientoEditarPerfil"
        lblFechaNacimientoEditarPerfil.Size = New Size(364, 36)
        lblFechaNacimientoEditarPerfil.TabIndex = 37
        lblFechaNacimientoEditarPerfil.Text = "Fecha de Nacimiento"
        ' 
        ' txtNombreEditarPerfil
        ' 
        txtNombreEditarPerfil.Animated = True
        txtNombreEditarPerfil.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtNombreEditarPerfil.BorderRadius = 15
        txtNombreEditarPerfil.CustomizableEdges = CustomizableEdges9
        txtNombreEditarPerfil.DefaultText = ""
        txtNombreEditarPerfil.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtNombreEditarPerfil.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtNombreEditarPerfil.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNombreEditarPerfil.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtNombreEditarPerfil.FillColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNombreEditarPerfil.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtNombreEditarPerfil.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNombreEditarPerfil.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtNombreEditarPerfil.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtNombreEditarPerfil.Location = New Point(13, 300)
        txtNombreEditarPerfil.Margin = New Padding(4, 67, 4, 25)
        txtNombreEditarPerfil.Name = "txtNombreEditarPerfil"
        txtNombreEditarPerfil.PlaceholderForeColor = Color.Black
        txtNombreEditarPerfil.PlaceholderText = "Jose Luis Perez Martinez"
        txtNombreEditarPerfil.SelectedText = ""
        txtNombreEditarPerfil.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtNombreEditarPerfil.Size = New Size(364, 36)
        txtNombreEditarPerfil.TabIndex = 36
        txtNombreEditarPerfil.TextOffset = New Point(10, 0)
        ' 
        ' lblNombreEditarPerfil
        ' 
        lblNombreEditarPerfil.BackColor = Color.Transparent
        lblNombreEditarPerfil.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombreEditarPerfil.ForeColor = SystemColors.ButtonHighlight
        lblNombreEditarPerfil.Location = New Point(13, 269)
        lblNombreEditarPerfil.Margin = New Padding(4, 0, 4, 0)
        lblNombreEditarPerfil.Name = "lblNombreEditarPerfil"
        lblNombreEditarPerfil.Size = New Size(364, 36)
        lblNombreEditarPerfil.TabIndex = 35
        lblNombreEditarPerfil.Text = "Nombre "
        ' 
        ' btnEditarFotoPerfil
        ' 
        btnEditarFotoPerfil.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnEditarFotoPerfil.Animated = True
        btnEditarFotoPerfil.BorderRadius = 15
        btnEditarFotoPerfil.CustomizableEdges = CustomizableEdges11
        btnEditarFotoPerfil.DisabledState.BorderColor = Color.DarkGray
        btnEditarFotoPerfil.DisabledState.CustomBorderColor = Color.DarkGray
        btnEditarFotoPerfil.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEditarFotoPerfil.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEditarFotoPerfil.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnEditarFotoPerfil.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditarFotoPerfil.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnEditarFotoPerfil.Location = New Point(91, 211)
        btnEditarFotoPerfil.Margin = New Padding(4, 5, 4, 5)
        btnEditarFotoPerfil.Name = "btnEditarFotoPerfil"
        btnEditarFotoPerfil.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btnEditarFotoPerfil.Size = New Size(209, 53)
        btnEditarFotoPerfil.TabIndex = 34
        btnEditarFotoPerfil.Text = "Editar Foto de Perfil"
        ' 
        ' pbxEditarFotoPerfil
        ' 
        pbxEditarFotoPerfil.Image = My.Resources.Resources._08fb9799f32e6996ef8ff1f2c92666c9
        pbxEditarFotoPerfil.Location = New Point(107, 50)
        pbxEditarFotoPerfil.Margin = New Padding(4, 5, 4, 5)
        pbxEditarFotoPerfil.Name = "pbxEditarFotoPerfil"
        pbxEditarFotoPerfil.Size = New Size(177, 151)
        pbxEditarFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbxEditarFotoPerfil.TabIndex = 33
        pbxEditarFotoPerfil.TabStop = False
        ' 
        ' lblEditarPerfilDeUsuario
        ' 
        lblEditarPerfilDeUsuario.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEditarPerfilDeUsuario.ForeColor = SystemColors.ButtonFace
        lblEditarPerfilDeUsuario.Location = New Point(87, 10)
        lblEditarPerfilDeUsuario.Margin = New Padding(4, 0, 4, 0)
        lblEditarPerfilDeUsuario.Name = "lblEditarPerfilDeUsuario"
        lblEditarPerfilDeUsuario.Size = New Size(216, 34)
        lblEditarPerfilDeUsuario.TabIndex = 32
        lblEditarPerfilDeUsuario.Text = "Editar Perfil de Usuario"
        ' 
        ' btnAjustesEditarPerfil
        ' 
        btnAjustesEditarPerfil.BackColor = Color.Transparent
        btnAjustesEditarPerfil.BackgroundImage = My.Resources.Resources.engine_gear_internet_option_security_setting_web_icon_127066
        btnAjustesEditarPerfil.BackgroundImageLayout = ImageLayout.Center
        btnAjustesEditarPerfil.FlatStyle = FlatStyle.Flat
        btnAjustesEditarPerfil.ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnAjustesEditarPerfil.ImageAlign = ContentAlignment.BottomCenter
        btnAjustesEditarPerfil.Location = New Point(323, 0)
        btnAjustesEditarPerfil.Margin = New Padding(4, 5, 4, 5)
        btnAjustesEditarPerfil.Name = "btnAjustesEditarPerfil"
        btnAjustesEditarPerfil.Size = New Size(67, 73)
        btnAjustesEditarPerfil.TabIndex = 31
        btnAjustesEditarPerfil.UseVisualStyleBackColor = False
        ' 
        ' btnRegresarEditarPerfil
        ' 
        btnRegresarEditarPerfil.BackColor = Color.Transparent
        btnRegresarEditarPerfil.BackgroundImage = My.Resources.Resources.ic_arrow_back_128_282261
        btnRegresarEditarPerfil.BackgroundImageLayout = ImageLayout.Center
        btnRegresarEditarPerfil.FlatStyle = FlatStyle.Flat
        btnRegresarEditarPerfil.ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnRegresarEditarPerfil.ImageAlign = ContentAlignment.BottomCenter
        btnRegresarEditarPerfil.Location = New Point(0, 0)
        btnRegresarEditarPerfil.Margin = New Padding(4, 5, 4, 5)
        btnRegresarEditarPerfil.Name = "btnRegresarEditarPerfil"
        btnRegresarEditarPerfil.Size = New Size(67, 73)
        btnRegresarEditarPerfil.TabIndex = 25
        btnRegresarEditarPerfil.UseVisualStyleBackColor = False
        ' 
        ' frmEditarPerfil
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(Panel1)
        ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmEditarPerfil"
        Padding = New Padding(25)
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        CType(pbxEditarFotoPerfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresarEditarPerfil As Button
    Friend WithEvents btnAjustesEditarPerfil As Button
    Friend WithEvents lblEditarPerfilDeUsuario As Label
    Friend WithEvents pbxEditarFotoPerfil As PictureBox
    Friend WithEvents btnEditarFotoPerfil As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNombreEditarPerfil As Label
    Friend WithEvents txtNombreEditarPerfil As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFechaNacimientoEditarPerfil As Label
    Friend WithEvents dtpFechaNacimientoEditarPerfil As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
