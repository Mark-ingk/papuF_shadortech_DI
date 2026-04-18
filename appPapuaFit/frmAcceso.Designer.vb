<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceso
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
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcceso))
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlGqr = New Guna.UI2.WinForms.Guna2Panel()
        lblTmot = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblTmot1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnGen = New Guna.UI2.WinForms.Guna2Button()
        lblTextoqr = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblGenerar = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblNombre = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cbtnPerfil = New Guna.UI2.WinForms.Guna2CircleButton()
        pcbxPesa = New Guna.UI2.WinForms.Guna2PictureBox()
        lblSaludo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        pnlAcceso = New Panel()
        pnlGqr.SuspendLayout()
        CType(pcbxPesa, ComponentModel.ISupportInitialize).BeginInit()
        pnlAcceso.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlGqr
        ' 
        pnlGqr.BackColor = Color.FromArgb(CByte(13), CByte(13), CByte(13))
        pnlGqr.BorderRadius = 60
        pnlGqr.Controls.Add(lblTmot)
        pnlGqr.Controls.Add(lblTmot1)
        pnlGqr.Controls.Add(btnGen)
        pnlGqr.Controls.Add(lblTextoqr)
        pnlGqr.Controls.Add(lblGenerar)
        CustomizableEdges10.BottomLeft = False
        CustomizableEdges10.BottomRight = False
        pnlGqr.CustomizableEdges = CustomizableEdges10
        pnlGqr.Dock = DockStyle.Bottom
        pnlGqr.FillColor = Color.FromArgb(CByte(1), CByte(63), CByte(50))
        pnlGqr.Font = New Font("Segoe UI", 9.75F)
        pnlGqr.Location = New Point(0, 497)
        pnlGqr.MaximumSize = New Size(390, 0)
        pnlGqr.MinimumSize = New Size(390, 0)
        pnlGqr.Name = "pnlGqr"
        pnlGqr.Padding = New Padding(25, 25, 25, 30)
        pnlGqr.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        pnlGqr.Size = New Size(390, 347)
        pnlGqr.TabIndex = 0
        ' 
        ' lblTmot
        ' 
        lblTmot.BackColor = Color.Transparent
        lblTmot.Enabled = False
        lblTmot.Font = New Font("Segoe UI", 12F)
        lblTmot.ForeColor = SystemColors.AppWorkspace
        lblTmot.IsSelectionEnabled = False
        lblTmot.Location = New Point(52, 172)
        lblTmot.Name = "lblTmot"
        lblTmot.Size = New Size(170, 23)
        lblTmot.TabIndex = 9
        lblTmot.Text = "Muevete, Mejora, Repite"
        ' 
        ' lblTmot1
        ' 
        lblTmot1.BackColor = Color.Transparent
        lblTmot1.Enabled = False
        lblTmot1.Font = New Font("Segoe UI", 12F)
        lblTmot1.ForeColor = SystemColors.AppWorkspace
        lblTmot1.IsSelectionEnabled = False
        lblTmot1.Location = New Point(52, 147)
        lblTmot1.Name = "lblTmot1"
        lblTmot1.Size = New Size(276, 23)
        lblTmot1.TabIndex = 8
        lblTmot1.Text = "Registra tu progreso. Supera tus limites"
        ' 
        ' btnGen
        ' 
        btnGen.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnGen.Animated = True
        btnGen.BackColor = Color.FromArgb(CByte(1), CByte(63), CByte(50))
        btnGen.BorderRadius = 30
        btnGen.Cursor = Cursors.Hand
        btnGen.CustomizableEdges = CustomizableEdges8
        btnGen.DisabledState.BorderColor = Color.DarkGray
        btnGen.DisabledState.CustomBorderColor = Color.DarkGray
        btnGen.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnGen.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnGen.FillColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        btnGen.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGen.ForeColor = Color.FromArgb(CByte(1), CByte(63), CByte(50))
        btnGen.Location = New Point(12, 245)
        btnGen.Margin = New Padding(25, 25, 25, 30)
        btnGen.Name = "btnGen"
        btnGen.PressedColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnGen.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        btnGen.Size = New Size(366, 81)
        btnGen.TabIndex = 6
        btnGen.Text = "ACCESO"
        ' 
        ' lblTextoqr
        ' 
        lblTextoqr.BackColor = Color.Transparent
        lblTextoqr.Enabled = False
        lblTextoqr.Font = New Font("Segoe UI Variable Display", 41.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTextoqr.ForeColor = SystemColors.ActiveBorder
        lblTextoqr.IsSelectionEnabled = False
        lblTextoqr.Location = New Point(237, 53)
        lblTextoqr.Name = "lblTextoqr"
        lblTextoqr.Size = New Size(76, 75)
        lblTextoqr.TabIndex = 2
        lblTextoqr.Text = "QR"
        ' 
        ' lblGenerar
        ' 
        lblGenerar.BackColor = Color.Transparent
        lblGenerar.Enabled = False
        lblGenerar.Font = New Font("Segoe UI", 41.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenerar.ForeColor = Color.FromArgb(CByte(253), CByte(253), CByte(253))
        lblGenerar.IsSelectionEnabled = False
        lblGenerar.Location = New Point(25, 52)
        lblGenerar.Margin = New Padding(0)
        lblGenerar.Name = "lblGenerar"
        lblGenerar.Size = New Size(209, 76)
        lblGenerar.TabIndex = 1
        lblGenerar.Text = "Generar"
        ' 
        ' lblNombre
        ' 
        lblNombre.BackColor = Color.Transparent
        lblNombre.Enabled = False
        lblNombre.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombre.ForeColor = Color.White
        lblNombre.IsSelectionEnabled = False
        lblNombre.Location = New Point(273, 26)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(65, 34)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Mario"
        ' 
        ' cbtnPerfil
        ' 
        cbtnPerfil.BorderColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        cbtnPerfil.Cursor = Cursors.Hand
        cbtnPerfil.DisabledState.BorderColor = Color.DarkGray
        cbtnPerfil.DisabledState.CustomBorderColor = Color.DarkGray
        cbtnPerfil.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        cbtnPerfil.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        cbtnPerfil.FillColor = Color.Orange
        cbtnPerfil.Font = New Font("Segoe UI", 9F)
        cbtnPerfil.ForeColor = Color.White
        cbtnPerfil.Image = My.Resources.Resources.round_account_button_with_user_inside_icon_icons_com_72596
        cbtnPerfil.ImageSize = New Size(35, 35)
        cbtnPerfil.Location = New Point(53, 25)
        cbtnPerfil.Name = "cbtnPerfil"
        cbtnPerfil.PressedColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        cbtnPerfil.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cbtnPerfil.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        cbtnPerfil.Size = New Size(39, 35)
        cbtnPerfil.TabIndex = 3
        ' 
        ' pcbxPesa
        ' 
        pcbxPesa.Anchor = AnchorStyles.Top
        pcbxPesa.BackColor = Color.Transparent
        pcbxPesa.BackgroundImageLayout = ImageLayout.None
        pcbxPesa.CustomizableEdges = CustomizableEdges13
        pcbxPesa.FillColor = Color.Transparent
        pcbxPesa.Image = CType(resources.GetObject("pcbxPesa.Image"), Image)
        pcbxPesa.ImageRotate = 0F
        pcbxPesa.Location = New Point(12, 112)
        pcbxPesa.Margin = New Padding(25, 40, 25, 30)
        pcbxPesa.Name = "pcbxPesa"
        pcbxPesa.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        pcbxPesa.Size = New Size(366, 426)
        pcbxPesa.SizeMode = PictureBoxSizeMode.Zoom
        pcbxPesa.TabIndex = 4
        pcbxPesa.TabStop = False
        pcbxPesa.UseTransparentBackground = True
        ' 
        ' lblSaludo
        ' 
        lblSaludo.BackColor = Color.Transparent
        lblSaludo.Enabled = False
        lblSaludo.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSaludo.ForeColor = Color.White
        lblSaludo.IsSelectionEnabled = False
        lblSaludo.Location = New Point(99, 25)
        lblSaludo.Name = "lblSaludo"
        lblSaludo.Size = New Size(171, 34)
        lblSaludo.TabIndex = 1
        lblSaludo.Text = "Hola de Nuevo!"
        ' 
        ' pnlAcceso
        ' 
        pnlAcceso.BackColor = Color.FromArgb(CByte(13), CByte(13), CByte(13))
        pnlAcceso.Controls.Add(pcbxPesa)
        pnlAcceso.Controls.Add(cbtnPerfil)
        pnlAcceso.Controls.Add(pnlGqr)
        pnlAcceso.Controls.Add(lblNombre)
        pnlAcceso.Controls.Add(lblSaludo)
        pnlAcceso.Location = New Point(0, 0)
        pnlAcceso.MaximumSize = New Size(390, 844)
        pnlAcceso.MinimumSize = New Size(390, 844)
        pnlAcceso.Name = "pnlAcceso"
        pnlAcceso.Size = New Size(390, 844)
        pnlAcceso.TabIndex = 5
        ' 
        ' frmAcceso
        ' 
        AutoScaleMode = AutoScaleMode.None
        AutoSize = True
        BackColor = SystemColors.Control
        ClientSize = New Size(390, 844)
        Controls.Add(pnlAcceso)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmAcceso"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmAcceso"
        pnlGqr.ResumeLayout(False)
        pnlGqr.PerformLayout()
        CType(pcbxPesa, ComponentModel.ISupportInitialize).EndInit()
        pnlAcceso.ResumeLayout(False)
        pnlAcceso.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlGqr As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTextoqr As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGenerar As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnGen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTmot As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTmot1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNombre As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbtnPerfil As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents pcbxPesa As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblSaludo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlAcceso As Panel
End Class
