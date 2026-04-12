<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventos
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        pnlEventos = New Panel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        pbxEventoDia = New PictureBox()
        lblTiempoEventoDia = New Label()
        lblEventoDia = New Label()
        pbxTiempoEventoDia = New PictureBox()
        lblEventoDelDia = New Label()
        pbrEventoDia = New Guna.UI2.WinForms.Guna2ProgressBar()
        pnlMiddleEventoSemana = New Guna.UI2.WinForms.Guna2Panel()
        pbxEventoSemana = New PictureBox()
        lblTiempoEventoSemana = New Label()
        lblEventoSemana = New Label()
        pbxTiempoEventoSemana = New PictureBox()
        lblEventoDeLaSemana = New Label()
        pbrEventoSemana = New Guna.UI2.WinForms.Guna2ProgressBar()
        pnlTopEventos = New Guna.UI2.WinForms.Guna2Panel()
        lblTiempoEventoMes = New Label()
        pbx2EventoMes = New PictureBox()
        pbxEventoMes = New PictureBox()
        pbrEventoMes = New Guna.UI2.WinForms.Guna2ProgressBar()
        lblEventoDelMes = New Label()
        lblEventoMes = New Label()
        pnlEventos.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        CType(pbxEventoDia, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxTiempoEventoDia, ComponentModel.ISupportInitialize).BeginInit()
        pnlMiddleEventoSemana.SuspendLayout()
        CType(pbxEventoSemana, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxTiempoEventoSemana, ComponentModel.ISupportInitialize).BeginInit()
        pnlTopEventos.SuspendLayout()
        CType(pbx2EventoMes, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbxEventoMes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlEventos
        ' 
        pnlEventos.Controls.Add(Guna2Panel1)
        pnlEventos.Controls.Add(pnlMiddleEventoSemana)
        pnlEventos.Controls.Add(pnlTopEventos)
        pnlEventos.Location = New Point(0, 0)
        pnlEventos.MaximumSize = New Size(390, 844)
        pnlEventos.MinimumSize = New Size(390, 844)
        pnlEventos.Name = "pnlEventos"
        pnlEventos.Padding = New Padding(25)
        pnlEventos.Size = New Size(390, 844)
        pnlEventos.TabIndex = 0
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.Transparent
        Guna2Panel1.BorderRadius = 50
        Guna2Panel1.Controls.Add(pbxEventoDia)
        Guna2Panel1.Controls.Add(lblTiempoEventoDia)
        Guna2Panel1.Controls.Add(lblEventoDia)
        Guna2Panel1.Controls.Add(pbxTiempoEventoDia)
        Guna2Panel1.Controls.Add(lblEventoDelDia)
        Guna2Panel1.Controls.Add(pbrEventoDia)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Guna2Panel1.Location = New Point(0, 460)
        Guna2Panel1.Margin = New Padding(5, 0, 5, 10)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.Padding = New Padding(20, 15, 20, 15)
        Guna2Panel1.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(390, 192)
        Guna2Panel1.TabIndex = 47
        ' 
        ' pbxEventoDia
        ' 
        pbxEventoDia.BackColor = Color.Transparent
        pbxEventoDia.BackgroundImageLayout = ImageLayout.None
        pbxEventoDia.Cursor = Cursors.No
        pbxEventoDia.Image = My.Resources.Resources.time_running1
        pbxEventoDia.InitialImage = Nothing
        pbxEventoDia.Location = New Point(270, 0)
        pbxEventoDia.Name = "pbxEventoDia"
        pbxEventoDia.Size = New Size(98, 94)
        pbxEventoDia.SizeMode = PictureBoxSizeMode.StretchImage
        pbxEventoDia.TabIndex = 42
        pbxEventoDia.TabStop = False
        ' 
        ' lblTiempoEventoDia
        ' 
        lblTiempoEventoDia.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblTiempoEventoDia.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTiempoEventoDia.ForeColor = SystemColors.ButtonFace
        lblTiempoEventoDia.Location = New Point(68, 61)
        lblTiempoEventoDia.Margin = New Padding(4, 0, 4, 0)
        lblTiempoEventoDia.Name = "lblTiempoEventoDia"
        lblTiempoEventoDia.Size = New Size(155, 27)
        lblTiempoEventoDia.TabIndex = 46
        lblTiempoEventoDia.Text = "10 Horas Restantes"
        lblTiempoEventoDia.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEventoDia
        ' 
        lblEventoDia.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblEventoDia.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventoDia.ForeColor = SystemColors.ButtonFace
        lblEventoDia.Location = New Point(38, 15)
        lblEventoDia.Margin = New Padding(4, 0, 4, 0)
        lblEventoDia.Name = "lblEventoDia"
        lblEventoDia.Size = New Size(152, 34)
        lblEventoDia.TabIndex = 42
        lblEventoDia.Text = "Evento del dia"
        ' 
        ' pbxTiempoEventoDia
        ' 
        pbxTiempoEventoDia.BackColor = Color.Transparent
        pbxTiempoEventoDia.BackgroundImageLayout = ImageLayout.None
        pbxTiempoEventoDia.Cursor = Cursors.No
        pbxTiempoEventoDia.Image = My.Resources.Resources.timer
        pbxTiempoEventoDia.InitialImage = Nothing
        pbxTiempoEventoDia.Location = New Point(38, 61)
        pbxTiempoEventoDia.Name = "pbxTiempoEventoDia"
        pbxTiempoEventoDia.Size = New Size(29, 27)
        pbxTiempoEventoDia.SizeMode = PictureBoxSizeMode.StretchImage
        pbxTiempoEventoDia.TabIndex = 45
        pbxTiempoEventoDia.TabStop = False
        ' 
        ' lblEventoDelDia
        ' 
        lblEventoDelDia.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblEventoDelDia.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventoDelDia.ForeColor = SystemColors.ButtonFace
        lblEventoDelDia.Location = New Point(0, 93)
        lblEventoDelDia.Margin = New Padding(4, 0, 4, 0)
        lblEventoDelDia.Name = "lblEventoDelDia"
        lblEventoDelDia.Size = New Size(390, 34)
        lblEventoDelDia.TabIndex = 43
        lblEventoDelDia.Text = "Completa dos lecciones en un dia"
        lblEventoDelDia.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbrEventoDia
        ' 
        pbrEventoDia.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pbrEventoDia.BorderColor = Color.Transparent
        pbrEventoDia.BorderRadius = 15
        pbrEventoDia.CustomizableEdges = CustomizableEdges1
        pbrEventoDia.FillColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pbrEventoDia.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pbrEventoDia.ForeColor = SystemColors.ButtonFace
        pbrEventoDia.Location = New Point(25, 137)
        pbrEventoDia.Maximum = 2
        pbrEventoDia.Name = "pbrEventoDia"
        pbrEventoDia.ProgressColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrEventoDia.ProgressColor2 = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrEventoDia.ShadowDecoration.BorderRadius = 0
        pbrEventoDia.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pbrEventoDia.ShowText = True
        pbrEventoDia.Size = New Size(340, 30)
        pbrEventoDia.TabIndex = 44
        pbrEventoDia.Text = "0/2"
        pbrEventoDia.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        pbrEventoDia.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        pbrEventoDia.Value = 1
        ' 
        ' pnlMiddleEventoSemana
        ' 
        pnlMiddleEventoSemana.BackColor = Color.Transparent
        pnlMiddleEventoSemana.BorderRadius = 50
        pnlMiddleEventoSemana.Controls.Add(pbxEventoSemana)
        pnlMiddleEventoSemana.Controls.Add(lblTiempoEventoSemana)
        pnlMiddleEventoSemana.Controls.Add(lblEventoSemana)
        pnlMiddleEventoSemana.Controls.Add(pbxTiempoEventoSemana)
        pnlMiddleEventoSemana.Controls.Add(lblEventoDeLaSemana)
        pnlMiddleEventoSemana.Controls.Add(pbrEventoSemana)
        pnlMiddleEventoSemana.CustomizableEdges = CustomizableEdges7
        pnlMiddleEventoSemana.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlMiddleEventoSemana.Location = New Point(0, 230)
        pnlMiddleEventoSemana.Margin = New Padding(5, 0, 5, 10)
        pnlMiddleEventoSemana.Name = "pnlMiddleEventoSemana"
        pnlMiddleEventoSemana.Padding = New Padding(20, 15, 20, 15)
        pnlMiddleEventoSemana.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlMiddleEventoSemana.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlMiddleEventoSemana.Size = New Size(390, 192)
        pnlMiddleEventoSemana.TabIndex = 39
        ' 
        ' pbxEventoSemana
        ' 
        pbxEventoSemana.BackColor = Color.Transparent
        pbxEventoSemana.BackgroundImageLayout = ImageLayout.None
        pbxEventoSemana.Cursor = Cursors.No
        pbxEventoSemana.Image = My.Resources.Resources.excercise
        pbxEventoSemana.InitialImage = Nothing
        pbxEventoSemana.Location = New Point(270, 0)
        pbxEventoSemana.Name = "pbxEventoSemana"
        pbxEventoSemana.Size = New Size(98, 92)
        pbxEventoSemana.SizeMode = PictureBoxSizeMode.StretchImage
        pbxEventoSemana.TabIndex = 47
        pbxEventoSemana.TabStop = False
        ' 
        ' lblTiempoEventoSemana
        ' 
        lblTiempoEventoSemana.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblTiempoEventoSemana.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTiempoEventoSemana.ForeColor = SystemColors.ButtonFace
        lblTiempoEventoSemana.Location = New Point(68, 61)
        lblTiempoEventoSemana.Margin = New Padding(4, 0, 4, 0)
        lblTiempoEventoSemana.Name = "lblTiempoEventoSemana"
        lblTiempoEventoSemana.Size = New Size(135, 27)
        lblTiempoEventoSemana.TabIndex = 46
        lblTiempoEventoSemana.Text = "7 Dias Restantes"
        lblTiempoEventoSemana.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEventoSemana
        ' 
        lblEventoSemana.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblEventoSemana.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventoSemana.ForeColor = SystemColors.ButtonFace
        lblEventoSemana.Location = New Point(38, 15)
        lblEventoSemana.Margin = New Padding(4, 0, 4, 0)
        lblEventoSemana.Name = "lblEventoSemana"
        lblEventoSemana.Size = New Size(226, 34)
        lblEventoSemana.TabIndex = 42
        lblEventoSemana.Text = "Eventos de la semana"
        ' 
        ' pbxTiempoEventoSemana
        ' 
        pbxTiempoEventoSemana.BackColor = Color.Transparent
        pbxTiempoEventoSemana.BackgroundImageLayout = ImageLayout.None
        pbxTiempoEventoSemana.Cursor = Cursors.No
        pbxTiempoEventoSemana.Image = My.Resources.Resources.timer
        pbxTiempoEventoSemana.InitialImage = Nothing
        pbxTiempoEventoSemana.Location = New Point(38, 61)
        pbxTiempoEventoSemana.Name = "pbxTiempoEventoSemana"
        pbxTiempoEventoSemana.Size = New Size(29, 27)
        pbxTiempoEventoSemana.SizeMode = PictureBoxSizeMode.StretchImage
        pbxTiempoEventoSemana.TabIndex = 45
        pbxTiempoEventoSemana.TabStop = False
        ' 
        ' lblEventoDeLaSemana
        ' 
        lblEventoDeLaSemana.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblEventoDeLaSemana.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventoDeLaSemana.ForeColor = SystemColors.ButtonFace
        lblEventoDeLaSemana.Location = New Point(0, 95)
        lblEventoDeLaSemana.Margin = New Padding(4, 0, 4, 0)
        lblEventoDeLaSemana.Name = "lblEventoDeLaSemana"
        lblEventoDeLaSemana.Size = New Size(390, 34)
        lblEventoDeLaSemana.TabIndex = 43
        lblEventoDeLaSemana.Text = "Completa una leccion al dia por 7 dias "
        lblEventoDeLaSemana.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbrEventoSemana
        ' 
        pbrEventoSemana.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pbrEventoSemana.BorderColor = Color.Transparent
        pbrEventoSemana.BorderRadius = 15
        pbrEventoSemana.CustomizableEdges = CustomizableEdges5
        pbrEventoSemana.FillColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pbrEventoSemana.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pbrEventoSemana.ForeColor = SystemColors.ButtonFace
        pbrEventoSemana.Location = New Point(25, 137)
        pbrEventoSemana.Maximum = 7
        pbrEventoSemana.Name = "pbrEventoSemana"
        pbrEventoSemana.ProgressColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrEventoSemana.ProgressColor2 = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrEventoSemana.ShadowDecoration.BorderRadius = 0
        pbrEventoSemana.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pbrEventoSemana.ShowText = True
        pbrEventoSemana.Size = New Size(340, 30)
        pbrEventoSemana.TabIndex = 44
        pbrEventoSemana.Text = "0/7"
        pbrEventoSemana.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        pbrEventoSemana.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        pbrEventoSemana.Value = 3
        ' 
        ' pnlTopEventos
        ' 
        pnlTopEventos.BorderRadius = 40
        pnlTopEventos.Controls.Add(lblTiempoEventoMes)
        pnlTopEventos.Controls.Add(pbx2EventoMes)
        pnlTopEventos.Controls.Add(pbxEventoMes)
        pnlTopEventos.Controls.Add(pbrEventoMes)
        pnlTopEventos.Controls.Add(lblEventoDelMes)
        pnlTopEventos.Controls.Add(lblEventoMes)
        CustomizableEdges11.TopLeft = False
        CustomizableEdges11.TopRight = False
        pnlTopEventos.CustomizableEdges = CustomizableEdges11
        pnlTopEventos.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlTopEventos.Location = New Point(0, 0)
        pnlTopEventos.Margin = New Padding(0, 0, 0, 10)
        pnlTopEventos.Name = "pnlTopEventos"
        pnlTopEventos.Padding = New Padding(25, 25, 25, 10)
        pnlTopEventos.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        pnlTopEventos.Size = New Size(390, 192)
        pnlTopEventos.TabIndex = 38
        ' 
        ' lblTiempoEventoMes
        ' 
        lblTiempoEventoMes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblTiempoEventoMes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTiempoEventoMes.ForeColor = SystemColors.ButtonFace
        lblTiempoEventoMes.Location = New Point(68, 65)
        lblTiempoEventoMes.Margin = New Padding(4, 0, 4, 0)
        lblTiempoEventoMes.Name = "lblTiempoEventoMes"
        lblTiempoEventoMes.Size = New Size(145, 27)
        lblTiempoEventoMes.TabIndex = 41
        lblTiempoEventoMes.Text = "18 Dias Restantes"
        lblTiempoEventoMes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pbx2EventoMes
        ' 
        pbx2EventoMes.BackColor = Color.Transparent
        pbx2EventoMes.BackgroundImageLayout = ImageLayout.None
        pbx2EventoMes.Cursor = Cursors.No
        pbx2EventoMes.Image = My.Resources.Resources.timer
        pbx2EventoMes.InitialImage = Nothing
        pbx2EventoMes.Location = New Point(38, 65)
        pbx2EventoMes.Name = "pbx2EventoMes"
        pbx2EventoMes.Size = New Size(29, 27)
        pbx2EventoMes.SizeMode = PictureBoxSizeMode.StretchImage
        pbx2EventoMes.TabIndex = 40
        pbx2EventoMes.TabStop = False
        ' 
        ' pbxEventoMes
        ' 
        pbxEventoMes.BackColor = Color.Transparent
        pbxEventoMes.BackgroundImageLayout = ImageLayout.None
        pbxEventoMes.Cursor = Cursors.No
        pbxEventoMes.Image = My.Resources.Resources.ar3ww
        pbxEventoMes.InitialImage = Nothing
        pbxEventoMes.Location = New Point(270, -2)
        pbxEventoMes.Name = "pbxEventoMes"
        pbxEventoMes.Size = New Size(98, 94)
        pbxEventoMes.SizeMode = PictureBoxSizeMode.StretchImage
        pbxEventoMes.TabIndex = 39
        pbxEventoMes.TabStop = False
        ' 
        ' pbrEventoMes
        ' 
        pbrEventoMes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pbrEventoMes.BorderColor = Color.Transparent
        pbrEventoMes.BorderRadius = 15
        pbrEventoMes.CustomizableEdges = CustomizableEdges9
        pbrEventoMes.FillColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pbrEventoMes.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pbrEventoMes.ForeColor = SystemColors.ButtonFace
        pbrEventoMes.Location = New Point(25, 141)
        pbrEventoMes.Maximum = 15
        pbrEventoMes.Name = "pbrEventoMes"
        pbrEventoMes.ProgressColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrEventoMes.ProgressColor2 = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrEventoMes.ShadowDecoration.BorderRadius = 0
        pbrEventoMes.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pbrEventoMes.ShowText = True
        pbrEventoMes.Size = New Size(340, 30)
        pbrEventoMes.TabIndex = 37
        pbrEventoMes.Text = "0/15"
        pbrEventoMes.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        pbrEventoMes.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        pbrEventoMes.Value = 10
        ' 
        ' lblEventoDelMes
        ' 
        lblEventoDelMes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblEventoDelMes.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventoDelMes.ForeColor = SystemColors.ButtonFace
        lblEventoDelMes.Location = New Point(0, 97)
        lblEventoDelMes.Margin = New Padding(4, 0, 4, 0)
        lblEventoDelMes.Name = "lblEventoDelMes"
        lblEventoDelMes.Size = New Size(390, 34)
        lblEventoDelMes.TabIndex = 36
        lblEventoDelMes.Text = "Completa 15 lecciones en el mes"
        lblEventoDelMes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEventoMes
        ' 
        lblEventoMes.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        lblEventoMes.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEventoMes.ForeColor = SystemColors.ButtonFace
        lblEventoMes.Location = New Point(38, 15)
        lblEventoMes.Margin = New Padding(4, 0, 4, 0)
        lblEventoMes.Name = "lblEventoMes"
        lblEventoMes.Size = New Size(170, 34)
        lblEventoMes.TabIndex = 34
        lblEventoMes.Text = "Eventos del mes"
        ' 
        ' frmEventos
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(390, 844)
        Controls.Add(pnlEventos)
        ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmEventos"
        Padding = New Padding(25)
        StartPosition = FormStartPosition.CenterScreen
        pnlEventos.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        CType(pbxEventoDia, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxTiempoEventoDia, ComponentModel.ISupportInitialize).EndInit()
        pnlMiddleEventoSemana.ResumeLayout(False)
        CType(pbxEventoSemana, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxTiempoEventoSemana, ComponentModel.ISupportInitialize).EndInit()
        pnlTopEventos.ResumeLayout(False)
        CType(pbx2EventoMes, ComponentModel.ISupportInitialize).EndInit()
        CType(pbxEventoMes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEventos As Panel
    Friend WithEvents pnlTopEventos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pbrEventoMes As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lblEventoDelMes As Label
    Friend WithEvents lblEventoMes As Label
    Friend WithEvents pbxEventoMes As PictureBox
    Friend WithEvents lblTiempoEventoMes As Label
    Friend WithEvents pbx2EventoMes As PictureBox
    Friend WithEvents pnlMiddleEventoSemana As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTiempoEventoSemana As Label
    Friend WithEvents lblEventoSemana As Label
    Friend WithEvents pbxTiempoEventoSemana As PictureBox
    Friend WithEvents lblEventoDeLaSemana As Label
    Friend WithEvents pbrEventoSemana As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTiempoEventoDia As Label
    Friend WithEvents lblEventoDia As Label
    Friend WithEvents pbxTiempoEventoDia As PictureBox
    Friend WithEvents lblEventoDelDia As Label
    Friend WithEvents pbrEventoDia As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents pbxEventoDia As PictureBox
    Friend WithEvents pbxEventoSemana As PictureBox
End Class
