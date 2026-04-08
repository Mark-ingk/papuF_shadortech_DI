<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfil
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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pbxFotoPerfil = New PictureBox()
        lblPerfilUsuario = New Label()
        lblNombre = New Label()
        lblFechaNacimiento = New Label()
        lblCorreoElectronico = New Label()
        lblGenero = New Label()
        lblHistorialEntrenamiento = New Label()
        lblRutinaActualAsignada = New Label()
        lblObjetivosPrincipales = New Label()
        txtFechaNacimiento = New Guna.UI2.WinForms.Guna2TextBox()
        txtGenero = New Guna.UI2.WinForms.Guna2TextBox()
        txtCorreoElectronico = New Guna.UI2.WinForms.Guna2TextBox()
        txtObjetivosPrincipales = New Guna.UI2.WinForms.Guna2TextBox()
        txtRutinaActualAsignada = New Guna.UI2.WinForms.Guna2TextBox()
        txtHistorialEntrenamiento = New Guna.UI2.WinForms.Guna2TextBox()
        btnRegresar = New Button()
        pnlInterfazPerfil = New Panel()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        btnEditarPerfil = New Guna.UI2.WinForms.Guna2Button()
        btnAjustes = New Button()
        CType(pbxFotoPerfil, ComponentModel.ISupportInitialize).BeginInit()
        pnlInterfazPerfil.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbxFotoPerfil
        ' 
        pbxFotoPerfil.Image = My.Resources.Resources._08fb9799f32e6996ef8ff1f2c92666c9
        pbxFotoPerfil.Location = New Point(112, 50)
        pbxFotoPerfil.Name = "pbxFotoPerfil"
        pbxFotoPerfil.Size = New Size(171, 150)
        pbxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbxFotoPerfil.TabIndex = 0
        pbxFotoPerfil.TabStop = False
        ' 
        ' lblPerfilUsuario
        ' 
        lblPerfilUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPerfilUsuario.ForeColor = SystemColors.ButtonFace
        lblPerfilUsuario.Location = New Point(94, 5)
        lblPerfilUsuario.Name = "lblPerfilUsuario"
        lblPerfilUsuario.Size = New Size(206, 33)
        lblPerfilUsuario.TabIndex = 1
        lblPerfilUsuario.Text = "Perfil de Usuario"
        ' 
        ' lblNombre
        ' 
        lblNombre.BackColor = Color.Transparent
        lblNombre.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.ForeColor = SystemColors.ButtonHighlight
        lblNombre.Location = New Point(13, 258)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(366, 31)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Nombre "
        ' 
        ' lblFechaNacimiento
        ' 
        lblFechaNacimiento.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFechaNacimiento.ForeColor = SystemColors.ButtonHighlight
        lblFechaNacimiento.Location = New Point(13, 342)
        lblFechaNacimiento.Name = "lblFechaNacimiento"
        lblFechaNacimiento.Size = New Size(366, 31)
        lblFechaNacimiento.TabIndex = 4
        lblFechaNacimiento.Text = "Fecha de Nacimiento"
        ' 
        ' lblCorreoElectronico
        ' 
        lblCorreoElectronico.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCorreoElectronico.ForeColor = SystemColors.ButtonHighlight
        lblCorreoElectronico.Location = New Point(13, 510)
        lblCorreoElectronico.Name = "lblCorreoElectronico"
        lblCorreoElectronico.Size = New Size(366, 31)
        lblCorreoElectronico.TabIndex = 8
        lblCorreoElectronico.Text = "Correo Electronico"
        ' 
        ' lblGenero
        ' 
        lblGenero.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGenero.ForeColor = SystemColors.ButtonHighlight
        lblGenero.Location = New Point(13, 426)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(366, 31)
        lblGenero.TabIndex = 6
        lblGenero.Text = "Genero"
        ' 
        ' lblHistorialEntrenamiento
        ' 
        lblHistorialEntrenamiento.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHistorialEntrenamiento.ForeColor = SystemColors.ButtonHighlight
        lblHistorialEntrenamiento.Location = New Point(13, 762)
        lblHistorialEntrenamiento.Name = "lblHistorialEntrenamiento"
        lblHistorialEntrenamiento.Size = New Size(366, 31)
        lblHistorialEntrenamiento.TabIndex = 14
        lblHistorialEntrenamiento.Text = "Historial de Entrenamiento"
        ' 
        ' lblRutinaActualAsignada
        ' 
        lblRutinaActualAsignada.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRutinaActualAsignada.ForeColor = SystemColors.ButtonHighlight
        lblRutinaActualAsignada.Location = New Point(13, 678)
        lblRutinaActualAsignada.Name = "lblRutinaActualAsignada"
        lblRutinaActualAsignada.Size = New Size(366, 31)
        lblRutinaActualAsignada.TabIndex = 12
        lblRutinaActualAsignada.Text = "Rutina Actual Asignada"
        ' 
        ' lblObjetivosPrincipales
        ' 
        lblObjetivosPrincipales.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblObjetivosPrincipales.ForeColor = SystemColors.ButtonHighlight
        lblObjetivosPrincipales.Location = New Point(13, 594)
        lblObjetivosPrincipales.Name = "lblObjetivosPrincipales"
        lblObjetivosPrincipales.Size = New Size(366, 31)
        lblObjetivosPrincipales.TabIndex = 10
        lblObjetivosPrincipales.Text = "Objetivos Principales"
        ' 
        ' txtFechaNacimiento
        ' 
        txtFechaNacimiento.Animated = True
        txtFechaNacimiento.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtFechaNacimiento.BorderRadius = 15
        txtFechaNacimiento.CustomizableEdges = CustomizableEdges1
        txtFechaNacimiento.DefaultText = ""
        txtFechaNacimiento.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtFechaNacimiento.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtFechaNacimiento.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFechaNacimiento.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFechaNacimiento.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtFechaNacimiento.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtFechaNacimiento.Font = New Font("Segoe UI", 9F)
        txtFechaNacimiento.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtFechaNacimiento.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtFechaNacimiento.Location = New Point(13, 384)
        txtFechaNacimiento.Margin = New Padding(3, 40, 3, 15)
        txtFechaNacimiento.Name = "txtFechaNacimiento"
        txtFechaNacimiento.PlaceholderText = "10 de Abril de 1995"
        txtFechaNacimiento.ReadOnly = True
        txtFechaNacimiento.SelectedText = ""
        txtFechaNacimiento.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtFechaNacimiento.Size = New Size(366, 31)
        txtFechaNacimiento.TabIndex = 18
        txtFechaNacimiento.TextOffset = New Point(10, 0)
        ' 
        ' txtGenero
        ' 
        txtGenero.Animated = True
        txtGenero.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtGenero.BorderRadius = 15
        txtGenero.CustomizableEdges = CustomizableEdges3
        txtGenero.DefaultText = ""
        txtGenero.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtGenero.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtGenero.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtGenero.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtGenero.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtGenero.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtGenero.Font = New Font("Segoe UI", 9F)
        txtGenero.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtGenero.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtGenero.Location = New Point(13, 468)
        txtGenero.Margin = New Padding(3, 40, 3, 15)
        txtGenero.Name = "txtGenero"
        txtGenero.PlaceholderText = "Masculino"
        txtGenero.ReadOnly = True
        txtGenero.SelectedText = ""
        txtGenero.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtGenero.Size = New Size(366, 31)
        txtGenero.TabIndex = 19
        txtGenero.TextOffset = New Point(10, 0)
        ' 
        ' txtCorreoElectronico
        ' 
        txtCorreoElectronico.Animated = True
        txtCorreoElectronico.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtCorreoElectronico.BorderRadius = 15
        txtCorreoElectronico.CustomizableEdges = CustomizableEdges5
        txtCorreoElectronico.DefaultText = ""
        txtCorreoElectronico.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtCorreoElectronico.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtCorreoElectronico.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCorreoElectronico.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCorreoElectronico.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtCorreoElectronico.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtCorreoElectronico.Font = New Font("Segoe UI", 9F)
        txtCorreoElectronico.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtCorreoElectronico.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtCorreoElectronico.Location = New Point(13, 552)
        txtCorreoElectronico.Margin = New Padding(3, 40, 3, 15)
        txtCorreoElectronico.Name = "txtCorreoElectronico"
        txtCorreoElectronico.PlaceholderText = "Elmaspapulince219@gmail.com"
        txtCorreoElectronico.ReadOnly = True
        txtCorreoElectronico.SelectedText = ""
        txtCorreoElectronico.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtCorreoElectronico.Size = New Size(366, 31)
        txtCorreoElectronico.TabIndex = 20
        txtCorreoElectronico.TextOffset = New Point(10, 0)
        ' 
        ' txtObjetivosPrincipales
        ' 
        txtObjetivosPrincipales.Animated = True
        txtObjetivosPrincipales.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtObjetivosPrincipales.BorderRadius = 15
        txtObjetivosPrincipales.CustomizableEdges = CustomizableEdges7
        txtObjetivosPrincipales.DefaultText = ""
        txtObjetivosPrincipales.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtObjetivosPrincipales.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtObjetivosPrincipales.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtObjetivosPrincipales.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtObjetivosPrincipales.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtObjetivosPrincipales.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtObjetivosPrincipales.Font = New Font("Segoe UI", 9F)
        txtObjetivosPrincipales.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtObjetivosPrincipales.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtObjetivosPrincipales.Location = New Point(13, 636)
        txtObjetivosPrincipales.Margin = New Padding(3, 40, 3, 15)
        txtObjetivosPrincipales.Name = "txtObjetivosPrincipales"
        txtObjetivosPrincipales.PlaceholderText = "Bajar de peso, Subir masa muscular, etc."
        txtObjetivosPrincipales.ReadOnly = True
        txtObjetivosPrincipales.SelectedText = ""
        txtObjetivosPrincipales.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtObjetivosPrincipales.Size = New Size(366, 31)
        txtObjetivosPrincipales.TabIndex = 21
        txtObjetivosPrincipales.TextOffset = New Point(10, 0)
        ' 
        ' txtRutinaActualAsignada
        ' 
        txtRutinaActualAsignada.Animated = True
        txtRutinaActualAsignada.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtRutinaActualAsignada.BorderRadius = 15
        txtRutinaActualAsignada.CustomizableEdges = CustomizableEdges9
        txtRutinaActualAsignada.DefaultText = ""
        txtRutinaActualAsignada.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtRutinaActualAsignada.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtRutinaActualAsignada.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRutinaActualAsignada.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtRutinaActualAsignada.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtRutinaActualAsignada.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtRutinaActualAsignada.Font = New Font("Segoe UI", 9F)
        txtRutinaActualAsignada.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtRutinaActualAsignada.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtRutinaActualAsignada.Location = New Point(13, 720)
        txtRutinaActualAsignada.Margin = New Padding(3, 40, 3, 15)
        txtRutinaActualAsignada.Name = "txtRutinaActualAsignada"
        txtRutinaActualAsignada.PlaceholderText = "Sentadilla bulgara con 5 repeticiones"
        txtRutinaActualAsignada.ReadOnly = True
        txtRutinaActualAsignada.SelectedText = ""
        txtRutinaActualAsignada.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txtRutinaActualAsignada.Size = New Size(366, 31)
        txtRutinaActualAsignada.TabIndex = 22
        txtRutinaActualAsignada.TextOffset = New Point(10, 0)
        ' 
        ' txtHistorialEntrenamiento
        ' 
        txtHistorialEntrenamiento.Animated = True
        txtHistorialEntrenamiento.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        txtHistorialEntrenamiento.BorderRadius = 15
        txtHistorialEntrenamiento.CustomizableEdges = CustomizableEdges11
        txtHistorialEntrenamiento.DefaultText = ""
        txtHistorialEntrenamiento.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtHistorialEntrenamiento.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtHistorialEntrenamiento.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtHistorialEntrenamiento.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtHistorialEntrenamiento.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        txtHistorialEntrenamiento.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtHistorialEntrenamiento.Font = New Font("Segoe UI", 9F)
        txtHistorialEntrenamiento.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        txtHistorialEntrenamiento.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        txtHistorialEntrenamiento.Location = New Point(13, 804)
        txtHistorialEntrenamiento.Margin = New Padding(3, 40, 3, 15)
        txtHistorialEntrenamiento.Name = "txtHistorialEntrenamiento"
        txtHistorialEntrenamiento.PlaceholderText = "3 sesiones tomadas en el ultimo mes"
        txtHistorialEntrenamiento.ReadOnly = True
        txtHistorialEntrenamiento.SelectedText = ""
        txtHistorialEntrenamiento.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txtHistorialEntrenamiento.Size = New Size(366, 31)
        txtHistorialEntrenamiento.TabIndex = 23
        txtHistorialEntrenamiento.TextOffset = New Point(10, 0)
        ' 
        ' btnRegresar
        ' 
        btnRegresar.BackColor = Color.Transparent
        btnRegresar.BackgroundImage = My.Resources.Resources.ic_arrow_back_128_282261
        btnRegresar.BackgroundImageLayout = ImageLayout.Center
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnRegresar.ImageAlign = ContentAlignment.BottomCenter
        btnRegresar.Location = New Point(0, 0)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(65, 66)
        btnRegresar.TabIndex = 24
        btnRegresar.UseVisualStyleBackColor = False
        ' 
        ' pnlInterfazPerfil
        ' 
        pnlInterfazPerfil.Controls.Add(Guna2TextBox1)
        pnlInterfazPerfil.Controls.Add(txtHistorialEntrenamiento)
        pnlInterfazPerfil.Controls.Add(btnRegresar)
        pnlInterfazPerfil.Controls.Add(txtRutinaActualAsignada)
        pnlInterfazPerfil.Controls.Add(btnEditarPerfil)
        pnlInterfazPerfil.Controls.Add(txtObjetivosPrincipales)
        pnlInterfazPerfil.Controls.Add(txtCorreoElectronico)
        pnlInterfazPerfil.Controls.Add(btnAjustes)
        pnlInterfazPerfil.Controls.Add(txtGenero)
        pnlInterfazPerfil.Controls.Add(pbxFotoPerfil)
        pnlInterfazPerfil.Controls.Add(txtFechaNacimiento)
        pnlInterfazPerfil.Controls.Add(lblPerfilUsuario)
        pnlInterfazPerfil.Controls.Add(lblNombre)
        pnlInterfazPerfil.Controls.Add(lblHistorialEntrenamiento)
        pnlInterfazPerfil.Controls.Add(lblFechaNacimiento)
        pnlInterfazPerfil.Controls.Add(lblRutinaActualAsignada)
        pnlInterfazPerfil.Controls.Add(lblGenero)
        pnlInterfazPerfil.Controls.Add(lblObjetivosPrincipales)
        pnlInterfazPerfil.Controls.Add(lblCorreoElectronico)
        pnlInterfazPerfil.Location = New Point(-1, -3)
        pnlInterfazPerfil.Name = "pnlInterfazPerfil"
        pnlInterfazPerfil.Size = New Size(390, 844)
        pnlInterfazPerfil.TabIndex = 26
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.Animated = True
        Guna2TextBox1.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        Guna2TextBox1.BorderRadius = 15
        Guna2TextBox1.CustomizableEdges = CustomizableEdges13
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.Enabled = False
        Guna2TextBox1.FillColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F)
        Guna2TextBox1.ForeColor = Color.FromArgb(CByte(170), CByte(170), CByte(170))
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        Guna2TextBox1.Location = New Point(13, 298)
        Guna2TextBox1.Margin = New Padding(3, 40, 3, 15)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PlaceholderText = "Jose Luis Perez Martinez"
        Guna2TextBox1.ReadOnly = True
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2TextBox1.Size = New Size(366, 31)
        Guna2TextBox1.TabIndex = 29
        Guna2TextBox1.TextOffset = New Point(10, 0)
        ' 
        ' btnEditarPerfil
        ' 
        btnEditarPerfil.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnEditarPerfil.Animated = True
        btnEditarPerfil.BorderRadius = 15
        btnEditarPerfil.CustomizableEdges = CustomizableEdges15
        btnEditarPerfil.DisabledState.BorderColor = Color.DarkGray
        btnEditarPerfil.DisabledState.CustomBorderColor = Color.DarkGray
        btnEditarPerfil.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnEditarPerfil.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnEditarPerfil.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnEditarPerfil.Font = New Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditarPerfil.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnEditarPerfil.Location = New Point(99, 212)
        btnEditarPerfil.Name = "btnEditarPerfil"
        btnEditarPerfil.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnEditarPerfil.Size = New Size(196, 41)
        btnEditarPerfil.TabIndex = 28
        btnEditarPerfil.Text = "Editar Perfil"
        ' 
        ' btnAjustes
        ' 
        btnAjustes.BackColor = Color.Transparent
        btnAjustes.BackgroundImage = My.Resources.Resources.engine_gear_internet_option_security_setting_web_icon_127066
        btnAjustes.BackgroundImageLayout = ImageLayout.Center
        btnAjustes.FlatStyle = FlatStyle.Flat
        btnAjustes.ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnAjustes.ImageAlign = ContentAlignment.BottomCenter
        btnAjustes.Location = New Point(325, 0)
        btnAjustes.Name = "btnAjustes"
        btnAjustes.Size = New Size(65, 63)
        btnAjustes.TabIndex = 27
        btnAjustes.UseVisualStyleBackColor = False
        ' 
        ' frmPerfil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(pnlInterfazPerfil)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(273, 506)
        MinimumSize = New Size(273, 506)
        Name = "frmPerfil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmPerfil"
        CType(pbxFotoPerfil, ComponentModel.ISupportInitialize).EndInit()
        pnlInterfazPerfil.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbxFotoPerfil As PictureBox
    Friend WithEvents lblPerfilUsuario As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents lblCorreoElectronico As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblHistorialEntrenamiento As Label
    Friend WithEvents lblRutinaActualAsignada As Label
    Friend WithEvents lblObjetivosPrincipales As Label
    Friend WithEvents txtFechaNacimiento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGenero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCorreoElectronico As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtObjetivosPrincipales As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRutinaActualAsignada As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtHistorialEntrenamiento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents pnlInterfazPerfil As Panel
    Friend WithEvents btnAjustes As Button
    Friend WithEvents btnEditarPerfil As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
