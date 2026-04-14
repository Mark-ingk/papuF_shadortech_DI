<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeccionCompletada
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
        pnlLeccionCompletada = New Panel()
        pbrLeccionCompletada = New Guna.UI2.WinForms.Guna2ProgressBar()
        lblProgresoCurso = New Label()
        btnCambiarContraseñaContinuar = New Guna.UI2.WinForms.Guna2Button()
        pbxLeccionCompletada = New PictureBox()
        Label1 = New Label()
        lblFelicidades = New Label()
        pnlTopinicio = New Guna.UI2.WinForms.Guna2Panel()
        pnlLeccionCompletada.SuspendLayout()
        CType(pbxLeccionCompletada, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlLeccionCompletada
        ' 
        pnlLeccionCompletada.Controls.Add(pbrLeccionCompletada)
        pnlLeccionCompletada.Controls.Add(lblProgresoCurso)
        pnlLeccionCompletada.Controls.Add(btnCambiarContraseñaContinuar)
        pnlLeccionCompletada.Controls.Add(pbxLeccionCompletada)
        pnlLeccionCompletada.Controls.Add(Label1)
        pnlLeccionCompletada.Controls.Add(lblFelicidades)
        pnlLeccionCompletada.Controls.Add(pnlTopinicio)
        pnlLeccionCompletada.Location = New Point(0, 0)
        pnlLeccionCompletada.MaximumSize = New Size(390, 844)
        pnlLeccionCompletada.MinimumSize = New Size(390, 844)
        pnlLeccionCompletada.Name = "pnlLeccionCompletada"
        pnlLeccionCompletada.Padding = New Padding(25)
        pnlLeccionCompletada.Size = New Size(390, 844)
        pnlLeccionCompletada.TabIndex = 0
        ' 
        ' pbrLeccionCompletada
        ' 
        pbrLeccionCompletada.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pbrLeccionCompletada.BorderColor = Color.Transparent
        pbrLeccionCompletada.BorderRadius = 15
        pbrLeccionCompletada.CustomizableEdges = CustomizableEdges1
        pbrLeccionCompletada.FillColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pbrLeccionCompletada.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pbrLeccionCompletada.ForeColor = SystemColors.ButtonFace
        pbrLeccionCompletada.Location = New Point(40, 587)
        pbrLeccionCompletada.Name = "pbrLeccionCompletada"
        pbrLeccionCompletada.ProgressColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrLeccionCompletada.ProgressColor2 = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        pbrLeccionCompletada.ShadowDecoration.BorderRadius = 0
        pbrLeccionCompletada.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pbrLeccionCompletada.ShowText = True
        pbrLeccionCompletada.Size = New Size(310, 29)
        pbrLeccionCompletada.TabIndex = 45
        pbrLeccionCompletada.Text = "0%"
        pbrLeccionCompletada.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom
        pbrLeccionCompletada.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        pbrLeccionCompletada.Value = 1
        ' 
        ' lblProgresoCurso
        ' 
        lblProgresoCurso.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProgresoCurso.ForeColor = SystemColors.ButtonFace
        lblProgresoCurso.Location = New Point(40, 535)
        lblProgresoCurso.Margin = New Padding(4, 0, 4, 0)
        lblProgresoCurso.Name = "lblProgresoCurso"
        lblProgresoCurso.Size = New Size(199, 34)
        lblProgresoCurso.TabIndex = 44
        lblProgresoCurso.Text = "Progreso del Curso"
        ' 
        ' btnCambiarContraseñaContinuar
        ' 
        btnCambiarContraseñaContinuar.BorderColor = Color.FromArgb(CByte(58), CByte(58), CByte(58))
        btnCambiarContraseñaContinuar.BorderRadius = 15
        btnCambiarContraseñaContinuar.CustomizableEdges = CustomizableEdges3
        btnCambiarContraseñaContinuar.DisabledState.BorderColor = Color.DarkGray
        btnCambiarContraseñaContinuar.DisabledState.CustomBorderColor = Color.DarkGray
        btnCambiarContraseñaContinuar.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCambiarContraseñaContinuar.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCambiarContraseñaContinuar.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnCambiarContraseñaContinuar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCambiarContraseñaContinuar.ForeColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        btnCambiarContraseñaContinuar.Location = New Point(28, 729)
        btnCambiarContraseñaContinuar.Name = "btnCambiarContraseñaContinuar"
        btnCambiarContraseñaContinuar.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCambiarContraseñaContinuar.Size = New Size(348, 47)
        btnCambiarContraseñaContinuar.TabIndex = 43
        btnCambiarContraseñaContinuar.Text = "Continuar"
        ' 
        ' pbxLeccionCompletada
        ' 
        pbxLeccionCompletada.Image = My.Resources.Resources.ejercicio1
        pbxLeccionCompletada.Location = New Point(99, 266)
        pbxLeccionCompletada.Name = "pbxLeccionCompletada"
        pbxLeccionCompletada.Size = New Size(193, 236)
        pbxLeccionCompletada.SizeMode = PictureBoxSizeMode.StretchImage
        pbxLeccionCompletada.TabIndex = 36
        pbxLeccionCompletada.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(40, 167)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 70)
        Label1.TabIndex = 35
        Label1.Text = "Has Completado una Leccion Exitosamente"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblFelicidades
        ' 
        lblFelicidades.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFelicidades.ForeColor = SystemColors.ButtonFace
        lblFelicidades.Location = New Point(125, 133)
        lblFelicidades.Margin = New Padding(4, 0, 4, 0)
        lblFelicidades.Name = "lblFelicidades"
        lblFelicidades.Size = New Size(141, 34)
        lblFelicidades.TabIndex = 34
        lblFelicidades.Text = "Felicidades!!!"
        ' 
        ' pnlTopinicio
        ' 
        pnlTopinicio.BorderRadius = 40
        CustomizableEdges5.TopLeft = False
        CustomizableEdges5.TopRight = False
        pnlTopinicio.CustomizableEdges = CustomizableEdges5
        pnlTopinicio.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlTopinicio.Location = New Point(0, 0)
        pnlTopinicio.Margin = New Padding(0, 0, 0, 10)
        pnlTopinicio.Name = "pnlTopinicio"
        pnlTopinicio.Padding = New Padding(25, 25, 25, 10)
        pnlTopinicio.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlTopinicio.Size = New Size(390, 73)
        pnlTopinicio.TabIndex = 27
        ' 
        ' frmLeccionCompletada
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(390, 844)
        Controls.Add(pnlLeccionCompletada)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmLeccionCompletada"
        Padding = New Padding(25)
        StartPosition = FormStartPosition.CenterScreen
        pnlLeccionCompletada.ResumeLayout(False)
        CType(pbxLeccionCompletada, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeccionCompletada As Panel
    Friend WithEvents pnlTopinicio As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFelicidades As Label
    Friend WithEvents pbxLeccionCompletada As PictureBox
    Friend WithEvents lblProgresoCurso As Label
    Friend WithEvents btnCambiarContraseñaContinuar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pbrLeccionCompletada As Guna.UI2.WinForms.Guna2ProgressBar
End Class
