<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustes
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlAjustes = New Panel()
        pnlConfiguracionCuenta = New Guna.UI2.WinForms.Guna2Panel()
        lblConfiguracionCuentaAjustes = New Label()
        tbxContraseñaActualAjustes = New TextBox()
        spr2Ajustes = New Guna.UI2.WinForms.Guna2Separator()
        lblCorreVinculadoAjustes = New Label()
        pnlPreferenciasAplicacion = New Guna.UI2.WinForms.Guna2Panel()
        lblPreferenciaAplicacionAjustes = New Label()
        btnCerrarSesionAjustes = New Guna.UI2.WinForms.Guna2Button()
        cbxNotifiacionesActivdadasAjustes = New Guna.UI2.WinForms.Guna2CheckBox()
        lblNotificacionesActivadasAjustes = New Label()
        IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        pnlInformacionSistema = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        lblInformacionSistema = New Label()
        spr3Ajustes = New Guna.UI2.WinForms.Guna2Separator()
        tbxVersionAppAjustes = New TextBox()
        lblUltimaActualizacionAjustes = New Label()
        lblVersionAppAjustes = New Label()
        tbxUltimaActualizacionAjustes = New TextBox()
        spr3 = New Guna.UI2.WinForms.Guna2Separator()
        pnlTopinicio = New Guna.UI2.WinForms.Guna2Panel()
        btnRango = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        lblAjustes = New Label()
        pnlAjustes.SuspendLayout()
        pnlConfiguracionCuenta.SuspendLayout()
        pnlPreferenciasAplicacion.SuspendLayout()
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlInformacionSistema.SuspendLayout()
        pnlTopinicio.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlAjustes
        ' 
        pnlAjustes.Controls.Add(pnlConfiguracionCuenta)
        pnlAjustes.Controls.Add(pnlPreferenciasAplicacion)
        pnlAjustes.Controls.Add(pnlInformacionSistema)
        pnlAjustes.Controls.Add(pnlTopinicio)
        pnlAjustes.Location = New Point(0, 0)
        pnlAjustes.MaximumSize = New Size(390, 844)
        pnlAjustes.MinimumSize = New Size(390, 844)
        pnlAjustes.Name = "pnlAjustes"
        pnlAjustes.Padding = New Padding(0, 0, 0, 40)
        pnlAjustes.Size = New Size(390, 844)
        pnlAjustes.TabIndex = 0
        ' 
        ' pnlConfiguracionCuenta
        ' 
        pnlConfiguracionCuenta.BackColor = Color.Transparent
        pnlConfiguracionCuenta.BorderRadius = 50
        pnlConfiguracionCuenta.Controls.Add(lblConfiguracionCuentaAjustes)
        pnlConfiguracionCuenta.Controls.Add(tbxContraseñaActualAjustes)
        pnlConfiguracionCuenta.Controls.Add(spr2Ajustes)
        pnlConfiguracionCuenta.Controls.Add(lblCorreVinculadoAjustes)
        pnlConfiguracionCuenta.CustomizableEdges = CustomizableEdges1
        pnlConfiguracionCuenta.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlConfiguracionCuenta.Location = New Point(10, 110)
        pnlConfiguracionCuenta.Margin = New Padding(10, 0, 10, 10)
        pnlConfiguracionCuenta.Name = "pnlConfiguracionCuenta"
        pnlConfiguracionCuenta.Padding = New Padding(20, 15, 20, 15)
        pnlConfiguracionCuenta.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlConfiguracionCuenta.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlConfiguracionCuenta.Size = New Size(370, 185)
        pnlConfiguracionCuenta.TabIndex = 6
        ' 
        ' lblConfiguracionCuentaAjustes
        ' 
        lblConfiguracionCuentaAjustes.BackColor = Color.Transparent
        lblConfiguracionCuentaAjustes.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfiguracionCuentaAjustes.ForeColor = SystemColors.ButtonFace
        lblConfiguracionCuentaAjustes.Location = New Point(51, 15)
        lblConfiguracionCuentaAjustes.Margin = New Padding(4, 0, 4, 0)
        lblConfiguracionCuentaAjustes.Name = "lblConfiguracionCuentaAjustes"
        lblConfiguracionCuentaAjustes.Size = New Size(254, 34)
        lblConfiguracionCuentaAjustes.TabIndex = 39
        lblConfiguracionCuentaAjustes.Text = "Configuracion de la cuenta"
        ' 
        ' tbxContraseñaActualAjustes
        ' 
        tbxContraseñaActualAjustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        tbxContraseñaActualAjustes.BorderStyle = BorderStyle.None
        tbxContraseñaActualAjustes.Cursor = Cursors.IBeam
        tbxContraseñaActualAjustes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxContraseñaActualAjustes.ForeColor = SystemColors.ButtonFace
        tbxContraseñaActualAjustes.Location = New Point(25, 111)
        tbxContraseñaActualAjustes.Name = "tbxContraseñaActualAjustes"
        tbxContraseñaActualAjustes.Size = New Size(327, 22)
        tbxContraseñaActualAjustes.TabIndex = 53
        tbxContraseñaActualAjustes.Text = "Elpapugod123@gmail.com"
        ' 
        ' spr2Ajustes
        ' 
        spr2Ajustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        spr2Ajustes.BackgroundImageLayout = ImageLayout.None
        spr2Ajustes.Location = New Point(24, 136)
        spr2Ajustes.Margin = New Padding(0, 0, 0, 20)
        spr2Ajustes.Name = "spr2Ajustes"
        spr2Ajustes.Size = New Size(326, 13)
        spr2Ajustes.TabIndex = 54
        ' 
        ' lblCorreVinculadoAjustes
        ' 
        lblCorreVinculadoAjustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblCorreVinculadoAjustes.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCorreVinculadoAjustes.ForeColor = SystemColors.ButtonFace
        lblCorreVinculadoAjustes.Location = New Point(16, 70)
        lblCorreVinculadoAjustes.Margin = New Padding(4, 0, 4, 0)
        lblCorreVinculadoAjustes.Name = "lblCorreVinculadoAjustes"
        lblCorreVinculadoAjustes.Size = New Size(151, 28)
        lblCorreVinculadoAjustes.TabIndex = 52
        lblCorreVinculadoAjustes.Text = "Correo Vinculado"
        lblCorreVinculadoAjustes.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlPreferenciasAplicacion
        ' 
        pnlPreferenciasAplicacion.BackColor = Color.Transparent
        pnlPreferenciasAplicacion.BorderRadius = 50
        pnlPreferenciasAplicacion.Controls.Add(lblPreferenciaAplicacionAjustes)
        pnlPreferenciasAplicacion.Controls.Add(btnCerrarSesionAjustes)
        pnlPreferenciasAplicacion.Controls.Add(cbxNotifiacionesActivdadasAjustes)
        pnlPreferenciasAplicacion.Controls.Add(lblNotificacionesActivadasAjustes)
        pnlPreferenciasAplicacion.Controls.Add(IconPictureBox4)
        pnlPreferenciasAplicacion.CustomizableEdges = CustomizableEdges5
        pnlPreferenciasAplicacion.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pnlPreferenciasAplicacion.Location = New Point(10, 557)
        pnlPreferenciasAplicacion.Margin = New Padding(5, 0, 5, 10)
        pnlPreferenciasAplicacion.Name = "pnlPreferenciasAplicacion"
        pnlPreferenciasAplicacion.Padding = New Padding(20, 15, 20, 15)
        pnlPreferenciasAplicacion.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlPreferenciasAplicacion.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlPreferenciasAplicacion.Size = New Size(370, 237)
        pnlPreferenciasAplicacion.TabIndex = 55
        ' 
        ' lblPreferenciaAplicacionAjustes
        ' 
        lblPreferenciaAplicacionAjustes.BackColor = Color.Transparent
        lblPreferenciaAplicacionAjustes.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPreferenciaAplicacionAjustes.ForeColor = Color.Black
        lblPreferenciaAplicacionAjustes.Location = New Point(16, 45)
        lblPreferenciaAplicacionAjustes.Margin = New Padding(4, 0, 4, 0)
        lblPreferenciaAplicacionAjustes.Name = "lblPreferenciaAplicacionAjustes"
        lblPreferenciaAplicacionAjustes.Size = New Size(247, 34)
        lblPreferenciaAplicacionAjustes.TabIndex = 44
        lblPreferenciaAplicacionAjustes.Text = "Preferencias de Aplicacion"
        ' 
        ' btnCerrarSesionAjustes
        ' 
        btnCerrarSesionAjustes.Animated = True
        btnCerrarSesionAjustes.BackColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnCerrarSesionAjustes.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        btnCerrarSesionAjustes.BorderRadius = 25
        btnCerrarSesionAjustes.Cursor = Cursors.Hand
        btnCerrarSesionAjustes.CustomizableEdges = CustomizableEdges3
        btnCerrarSesionAjustes.DisabledState.BorderColor = Color.DarkGray
        btnCerrarSesionAjustes.DisabledState.CustomBorderColor = Color.DarkGray
        btnCerrarSesionAjustes.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCerrarSesionAjustes.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCerrarSesionAjustes.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        btnCerrarSesionAjustes.FocusedColor = Color.FromArgb(CByte(1), CByte(63), CByte(53))
        btnCerrarSesionAjustes.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrarSesionAjustes.ForeColor = Color.White
        btnCerrarSesionAjustes.HoverState.FillColor = Color.FromArgb(CByte(1), CByte(63), CByte(53))
        btnCerrarSesionAjustes.HoverState.ForeColor = Color.FromArgb(CByte(231), CByte(254), CByte(37))
        btnCerrarSesionAjustes.Location = New Point(25, 155)
        btnCerrarSesionAjustes.Name = "btnCerrarSesionAjustes"
        btnCerrarSesionAjustes.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCerrarSesionAjustes.Size = New Size(159, 64)
        btnCerrarSesionAjustes.TabIndex = 61
        btnCerrarSesionAjustes.Text = "Cerrar Sesion"
        ' 
        ' cbxNotifiacionesActivdadasAjustes
        ' 
        cbxNotifiacionesActivdadasAjustes.BackColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        cbxNotifiacionesActivdadasAjustes.Checked = True
        cbxNotifiacionesActivdadasAjustes.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxNotifiacionesActivdadasAjustes.CheckedState.BorderRadius = 0
        cbxNotifiacionesActivdadasAjustes.CheckedState.BorderThickness = 0
        cbxNotifiacionesActivdadasAjustes.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxNotifiacionesActivdadasAjustes.CheckState = CheckState.Indeterminate
        cbxNotifiacionesActivdadasAjustes.Cursor = Cursors.Hand
        cbxNotifiacionesActivdadasAjustes.Location = New Point(192, 91)
        cbxNotifiacionesActivdadasAjustes.Name = "cbxNotifiacionesActivdadasAjustes"
        cbxNotifiacionesActivdadasAjustes.Size = New Size(22, 28)
        cbxNotifiacionesActivdadasAjustes.TabIndex = 38
        cbxNotifiacionesActivdadasAjustes.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        cbxNotifiacionesActivdadasAjustes.UncheckedState.BorderRadius = 0
        cbxNotifiacionesActivdadasAjustes.UncheckedState.BorderThickness = 0
        cbxNotifiacionesActivdadasAjustes.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        cbxNotifiacionesActivdadasAjustes.UseVisualStyleBackColor = False
        ' 
        ' lblNotificacionesActivadasAjustes
        ' 
        lblNotificacionesActivadasAjustes.BackColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        lblNotificacionesActivadasAjustes.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNotificacionesActivadasAjustes.ForeColor = Color.Black
        lblNotificacionesActivadasAjustes.Location = New Point(5, 91)
        lblNotificacionesActivadasAjustes.Margin = New Padding(4, 0, 4, 0)
        lblNotificacionesActivadasAjustes.Name = "lblNotificacionesActivadasAjustes"
        lblNotificacionesActivadasAjustes.Size = New Size(209, 28)
        lblNotificacionesActivadasAjustes.TabIndex = 37
        lblNotificacionesActivadasAjustes.Text = "Notificaciones activadas"
        ' 
        ' IconPictureBox4
        ' 
        IconPictureBox4.BackColor = Color.Transparent
        IconPictureBox4.BackgroundImageLayout = ImageLayout.None
        IconPictureBox4.ForeColor = Color.YellowGreen
        IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        IconPictureBox4.IconColor = Color.YellowGreen
        IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox4.IconSize = 227
        IconPictureBox4.Location = New Point(177, -25)
        IconPictureBox4.Name = "IconPictureBox4"
        IconPictureBox4.Rotation = 320R
        IconPictureBox4.Size = New Size(227, 244)
        IconPictureBox4.TabIndex = 81
        IconPictureBox4.TabStop = False
        ' 
        ' pnlInformacionSistema
        ' 
        pnlInformacionSistema.BackColor = Color.Transparent
        pnlInformacionSistema.BorderRadius = 50
        pnlInformacionSistema.Controls.Add(Guna2Button1)
        pnlInformacionSistema.Controls.Add(lblInformacionSistema)
        pnlInformacionSistema.Controls.Add(spr3Ajustes)
        pnlInformacionSistema.Controls.Add(tbxVersionAppAjustes)
        pnlInformacionSistema.Controls.Add(lblUltimaActualizacionAjustes)
        pnlInformacionSistema.Controls.Add(lblVersionAppAjustes)
        pnlInformacionSistema.Controls.Add(tbxUltimaActualizacionAjustes)
        pnlInformacionSistema.Controls.Add(spr3)
        pnlInformacionSistema.CustomizableEdges = CustomizableEdges9
        pnlInformacionSistema.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlInformacionSistema.Location = New Point(10, 305)
        pnlInformacionSistema.Margin = New Padding(5, 0, 5, 10)
        pnlInformacionSistema.Name = "pnlInformacionSistema"
        pnlInformacionSistema.Padding = New Padding(20, 15, 20, 15)
        pnlInformacionSistema.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlInformacionSistema.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlInformacionSistema.Size = New Size(370, 242)
        pnlInformacionSistema.TabIndex = 56
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        Guna2Button1.BorderRadius = 15
        Guna2Button1.CustomizableEdges = CustomizableEdges7
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Red
        Guna2Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        Guna2Button1.Location = New Point(28, 265)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button1.Size = New Size(351, 47)
        Guna2Button1.TabIndex = 61
        Guna2Button1.Text = "Cerrar Sesion"
        ' 
        ' lblInformacionSistema
        ' 
        lblInformacionSistema.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblInformacionSistema.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInformacionSistema.ForeColor = SystemColors.ButtonFace
        lblInformacionSistema.Location = New Point(51, 18)
        lblInformacionSistema.Margin = New Padding(4, 0, 4, 0)
        lblInformacionSistema.Name = "lblInformacionSistema"
        lblInformacionSistema.Size = New Size(227, 34)
        lblInformacionSistema.TabIndex = 45
        lblInformacionSistema.Text = "Informacion del sistema"
        ' 
        ' spr3Ajustes
        ' 
        spr3Ajustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        spr3Ajustes.BackgroundImageLayout = ImageLayout.None
        spr3Ajustes.Location = New Point(25, 114)
        spr3Ajustes.Margin = New Padding(0, 0, 0, 20)
        spr3Ajustes.Name = "spr3Ajustes"
        spr3Ajustes.Size = New Size(325, 13)
        spr3Ajustes.TabIndex = 58
        ' 
        ' tbxVersionAppAjustes
        ' 
        tbxVersionAppAjustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        tbxVersionAppAjustes.BorderStyle = BorderStyle.None
        tbxVersionAppAjustes.Cursor = Cursors.No
        tbxVersionAppAjustes.Enabled = False
        tbxVersionAppAjustes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxVersionAppAjustes.ForeColor = SystemColors.ButtonFace
        tbxVersionAppAjustes.Location = New Point(25, 89)
        tbxVersionAppAjustes.Name = "tbxVersionAppAjustes"
        tbxVersionAppAjustes.ReadOnly = True
        tbxVersionAppAjustes.Size = New Size(321, 22)
        tbxVersionAppAjustes.TabIndex = 58
        tbxVersionAppAjustes.Text = "1.0"
        ' 
        ' lblUltimaActualizacionAjustes
        ' 
        lblUltimaActualizacionAjustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblUltimaActualizacionAjustes.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUltimaActualizacionAjustes.ForeColor = SystemColors.ButtonFace
        lblUltimaActualizacionAjustes.Location = New Point(24, 147)
        lblUltimaActualizacionAjustes.Margin = New Padding(4, 0, 4, 0)
        lblUltimaActualizacionAjustes.Name = "lblUltimaActualizacionAjustes"
        lblUltimaActualizacionAjustes.Size = New Size(158, 24)
        lblUltimaActualizacionAjustes.TabIndex = 58
        lblUltimaActualizacionAjustes.Text = "Ultima Actualizacion"
        lblUltimaActualizacionAjustes.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblVersionAppAjustes
        ' 
        lblVersionAppAjustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblVersionAppAjustes.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVersionAppAjustes.ForeColor = SystemColors.ButtonFace
        lblVersionAppAjustes.Location = New Point(24, 61)
        lblVersionAppAjustes.Margin = New Padding(4, 0, 4, 0)
        lblVersionAppAjustes.Name = "lblVersionAppAjustes"
        lblVersionAppAjustes.Size = New Size(142, 34)
        lblVersionAppAjustes.TabIndex = 55
        lblVersionAppAjustes.Text = "Version de la App"
        lblVersionAppAjustes.TextAlign = ContentAlignment.TopCenter
        ' 
        ' tbxUltimaActualizacionAjustes
        ' 
        tbxUltimaActualizacionAjustes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        tbxUltimaActualizacionAjustes.BorderStyle = BorderStyle.None
        tbxUltimaActualizacionAjustes.Cursor = Cursors.No
        tbxUltimaActualizacionAjustes.Enabled = False
        tbxUltimaActualizacionAjustes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbxUltimaActualizacionAjustes.ForeColor = SystemColors.ButtonFace
        tbxUltimaActualizacionAjustes.Location = New Point(25, 176)
        tbxUltimaActualizacionAjustes.Name = "tbxUltimaActualizacionAjustes"
        tbxUltimaActualizacionAjustes.ReadOnly = True
        tbxUltimaActualizacionAjustes.Size = New Size(321, 22)
        tbxUltimaActualizacionAjustes.TabIndex = 59
        tbxUltimaActualizacionAjustes.Text = "12 de abril de 2026"
        ' 
        ' spr3
        ' 
        spr3.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        spr3.BackgroundImageLayout = ImageLayout.None
        spr3.Location = New Point(25, 201)
        spr3.Margin = New Padding(0, 0, 0, 20)
        spr3.Name = "spr3"
        spr3.Size = New Size(327, 13)
        spr3.TabIndex = 60
        ' 
        ' pnlTopinicio
        ' 
        pnlTopinicio.BorderRadius = 40
        pnlTopinicio.Controls.Add(btnRango)
        pnlTopinicio.Controls.Add(IconButton1)
        pnlTopinicio.Controls.Add(lblAjustes)
        CustomizableEdges11.TopLeft = False
        CustomizableEdges11.TopRight = False
        pnlTopinicio.CustomizableEdges = CustomizableEdges11
        pnlTopinicio.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlTopinicio.Location = New Point(0, 0)
        pnlTopinicio.Margin = New Padding(0, 0, 0, 10)
        pnlTopinicio.Name = "pnlTopinicio"
        pnlTopinicio.Padding = New Padding(25, 25, 25, 10)
        pnlTopinicio.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        pnlTopinicio.Size = New Size(390, 100)
        pnlTopinicio.TabIndex = 62
        ' 
        ' btnRango
        ' 
        btnRango.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRango.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        btnRango.FlatAppearance.BorderColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        btnRango.FlatStyle = FlatStyle.Flat
        btnRango.IconChar = FontAwesome.Sharp.IconChar.Key
        btnRango.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnRango.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRango.Location = New Point(308, 17)
        btnRango.Name = "btnRango"
        btnRango.Size = New Size(54, 58)
        btnRango.TabIndex = 36
        btnRango.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        IconButton1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        IconButton1.FlatAppearance.BorderColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        IconButton1.IconColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(0, 10)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(69, 73)
        IconButton1.TabIndex = 35
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' lblAjustes
        ' 
        lblAjustes.BackColor = Color.Transparent
        lblAjustes.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAjustes.ForeColor = SystemColors.ButtonFace
        lblAjustes.Location = New Point(92, 27)
        lblAjustes.Margin = New Padding(4, 0, 4, 0)
        lblAjustes.Name = "lblAjustes"
        lblAjustes.Size = New Size(88, 34)
        lblAjustes.TabIndex = 33
        lblAjustes.Text = "Ajustes"
        ' 
        ' frmAjustes
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(pnlAjustes)
        ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmAjustes"
        Padding = New Padding(25)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        pnlAjustes.ResumeLayout(False)
        pnlConfiguracionCuenta.ResumeLayout(False)
        pnlConfiguracionCuenta.PerformLayout()
        pnlPreferenciasAplicacion.ResumeLayout(False)
        CType(IconPictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnlInformacionSistema.ResumeLayout(False)
        pnlInformacionSistema.PerformLayout()
        pnlTopinicio.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlAjustes As Panel
    Friend WithEvents lblAjustes As Label
    Friend WithEvents lblNotificacionesActivadasAjustes As Label
    Friend WithEvents cbxNotifiacionesActivdadasAjustes As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblConfiguracionCuentaAjustes As Label
    Friend WithEvents lblPreferenciaAplicacionAjustes As Label
    Friend WithEvents lblInformacionSistema As Label
    Friend WithEvents lblCorreVinculadoAjustes As Label
    Friend WithEvents tbxContraseñaActualAjustes As TextBox
    Friend WithEvents lblVersionAppAjustes As Label
    Friend WithEvents lblUltimaActualizacionAjustes As Label
    Friend WithEvents tbxUltimaActualizacionAjustes As TextBox
    Friend WithEvents pnlConfiguracionCuenta As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlPreferenciasAplicacion As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlInformacionSistema As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tbxVersionAppAjustes As TextBox
    Friend WithEvents spr2Ajustes As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents spr3Ajustes As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents spr3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents pnlTopinicio As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnCerrarSesionAjustes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnRango As FontAwesome.Sharp.IconButton
End Class
