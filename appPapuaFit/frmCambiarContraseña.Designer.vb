<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarContraseña
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
        pnlCambiarContraseña = New Panel()
        pnlTopCambiarContraseña = New Guna.UI2.WinForms.Guna2Panel()
        btnRegresarCambiarContraseña = New Button()
        lblCambiarContraseña = New Label()
        btnCancelarCambios = New Guna.UI2.WinForms.Guna2Button()
        btnGuardarCambios = New Guna.UI2.WinForms.Guna2Button()
        pnlPreferenciasAplicacion = New Guna.UI2.WinForms.Guna2Panel()
        lblContraseñaActual = New Label()
        srp4EditarPerfil = New Guna.UI2.WinForms.Guna2Separator()
        spr2CambiarContraseña = New Guna.UI2.WinForms.Guna2Separator()
        tbxContraseñaActual = New TextBox()
        tbxConfimarContraseña = New TextBox()
        lblNuevaContraseña = New Label()
        tbxNuevaContraseña = New TextBox()
        lblConfirmarContraseña = New Label()
        srp3CambiarContraseña = New Guna.UI2.WinForms.Guna2Separator()
        pnlCambiarContraseña.SuspendLayout()
        pnlTopCambiarContraseña.SuspendLayout()
        pnlPreferenciasAplicacion.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCambiarContraseña
        ' 
        pnlCambiarContraseña.Controls.Add(pnlTopCambiarContraseña)
        pnlCambiarContraseña.Controls.Add(btnCancelarCambios)
        pnlCambiarContraseña.Controls.Add(btnGuardarCambios)
        pnlCambiarContraseña.Controls.Add(pnlPreferenciasAplicacion)
        pnlCambiarContraseña.Location = New Point(0, 0)
        pnlCambiarContraseña.MaximumSize = New Size(390, 844)
        pnlCambiarContraseña.MinimumSize = New Size(390, 844)
        pnlCambiarContraseña.Name = "pnlCambiarContraseña"
        pnlCambiarContraseña.Padding = New Padding(25)
        pnlCambiarContraseña.Size = New Size(390, 844)
        pnlCambiarContraseña.TabIndex = 0
        ' 
        ' pnlTopCambiarContraseña
        ' 
        pnlTopCambiarContraseña.BorderRadius = 40
        pnlTopCambiarContraseña.Controls.Add(btnRegresarCambiarContraseña)
        pnlTopCambiarContraseña.Controls.Add(lblCambiarContraseña)
        CustomizableEdges1.TopLeft = False
        CustomizableEdges1.TopRight = False
        pnlTopCambiarContraseña.CustomizableEdges = CustomizableEdges1
        pnlTopCambiarContraseña.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlTopCambiarContraseña.Location = New Point(0, 0)
        pnlTopCambiarContraseña.Margin = New Padding(0, 0, 0, 10)
        pnlTopCambiarContraseña.Name = "pnlTopCambiarContraseña"
        pnlTopCambiarContraseña.Padding = New Padding(25, 25, 25, 10)
        pnlTopCambiarContraseña.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlTopCambiarContraseña.Size = New Size(390, 77)
        pnlTopCambiarContraseña.TabIndex = 63
        ' 
        ' btnRegresarCambiarContraseña
        ' 
        btnRegresarCambiarContraseña.BackColor = Color.Transparent
        btnRegresarCambiarContraseña.BackgroundImage = My.Resources.Resources.ic_arrow_back_128_282261
        btnRegresarCambiarContraseña.BackgroundImageLayout = ImageLayout.Center
        btnRegresarCambiarContraseña.Cursor = Cursors.Hand
        btnRegresarCambiarContraseña.FlatStyle = FlatStyle.Flat
        btnRegresarCambiarContraseña.ForeColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        btnRegresarCambiarContraseña.ImageAlign = ContentAlignment.BottomCenter
        btnRegresarCambiarContraseña.Location = New Point(0, 2)
        btnRegresarCambiarContraseña.Margin = New Padding(4, 5, 4, 5)
        btnRegresarCambiarContraseña.Name = "btnRegresarCambiarContraseña"
        btnRegresarCambiarContraseña.Size = New Size(67, 73)
        btnRegresarCambiarContraseña.TabIndex = 50
        btnRegresarCambiarContraseña.UseVisualStyleBackColor = False
        ' 
        ' lblCambiarContraseña
        ' 
        lblCambiarContraseña.BackColor = Color.Transparent
        lblCambiarContraseña.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCambiarContraseña.ForeColor = SystemColors.ButtonFace
        lblCambiarContraseña.Location = New Point(75, 19)
        lblCambiarContraseña.Margin = New Padding(4, 0, 4, 0)
        lblCambiarContraseña.Name = "lblCambiarContraseña"
        lblCambiarContraseña.Size = New Size(210, 34)
        lblCambiarContraseña.TabIndex = 33
        lblCambiarContraseña.Text = "Cambiar Contraseña"
        ' 
        ' btnCancelarCambios
        ' 
        btnCancelarCambios.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnCancelarCambios.Animated = True
        btnCancelarCambios.BorderRadius = 15
        btnCancelarCambios.Cursor = Cursors.Hand
        btnCancelarCambios.CustomizableEdges = CustomizableEdges3
        btnCancelarCambios.DisabledState.BorderColor = Color.DarkGray
        btnCancelarCambios.DisabledState.CustomBorderColor = Color.DarkGray
        btnCancelarCambios.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCancelarCambios.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCancelarCambios.FillColor = Color.Red
        btnCancelarCambios.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelarCambios.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnCancelarCambios.Location = New Point(21, 422)
        btnCancelarCambios.Margin = New Padding(4, 5, 4, 5)
        btnCancelarCambios.Name = "btnCancelarCambios"
        btnCancelarCambios.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnCancelarCambios.Size = New Size(159, 61)
        btnCancelarCambios.TabIndex = 49
        btnCancelarCambios.Text = "Cancelar Cambios"
        ' 
        ' btnGuardarCambios
        ' 
        btnGuardarCambios.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnGuardarCambios.Animated = True
        btnGuardarCambios.BorderRadius = 15
        btnGuardarCambios.Cursor = Cursors.Hand
        btnGuardarCambios.CustomizableEdges = CustomizableEdges5
        btnGuardarCambios.DisabledState.BorderColor = Color.DarkGray
        btnGuardarCambios.DisabledState.CustomBorderColor = Color.DarkGray
        btnGuardarCambios.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnGuardarCambios.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnGuardarCambios.FillColor = Color.FromArgb(CByte(198), CByte(241), CByte(53))
        btnGuardarCambios.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardarCambios.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(26))
        btnGuardarCambios.Location = New Point(210, 422)
        btnGuardarCambios.Margin = New Padding(4, 5, 4, 5)
        btnGuardarCambios.Name = "btnGuardarCambios"
        btnGuardarCambios.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnGuardarCambios.Size = New Size(159, 61)
        btnGuardarCambios.TabIndex = 48
        btnGuardarCambios.Text = "Guardar Cambios"
        ' 
        ' pnlPreferenciasAplicacion
        ' 
        pnlPreferenciasAplicacion.BackColor = Color.Transparent
        pnlPreferenciasAplicacion.BorderRadius = 40
        pnlPreferenciasAplicacion.Controls.Add(lblContraseñaActual)
        pnlPreferenciasAplicacion.Controls.Add(srp4EditarPerfil)
        pnlPreferenciasAplicacion.Controls.Add(spr2CambiarContraseña)
        pnlPreferenciasAplicacion.Controls.Add(tbxContraseñaActual)
        pnlPreferenciasAplicacion.Controls.Add(tbxConfimarContraseña)
        pnlPreferenciasAplicacion.Controls.Add(lblNuevaContraseña)
        pnlPreferenciasAplicacion.Controls.Add(tbxNuevaContraseña)
        pnlPreferenciasAplicacion.Controls.Add(lblConfirmarContraseña)
        pnlPreferenciasAplicacion.Controls.Add(srp3CambiarContraseña)
        pnlPreferenciasAplicacion.CustomizableEdges = CustomizableEdges7
        pnlPreferenciasAplicacion.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        pnlPreferenciasAplicacion.Location = New Point(0, 99)
        pnlPreferenciasAplicacion.Margin = New Padding(5, 0, 5, 10)
        pnlPreferenciasAplicacion.Name = "pnlPreferenciasAplicacion"
        pnlPreferenciasAplicacion.Padding = New Padding(20, 15, 20, 15)
        pnlPreferenciasAplicacion.ShadowDecoration.Color = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        pnlPreferenciasAplicacion.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlPreferenciasAplicacion.Size = New Size(390, 292)
        pnlPreferenciasAplicacion.TabIndex = 64
        ' 
        ' lblContraseñaActual
        ' 
        lblContraseñaActual.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContraseñaActual.ForeColor = SystemColors.ButtonFace
        lblContraseñaActual.Location = New Point(24, 15)
        lblContraseñaActual.Margin = New Padding(4, 0, 4, 0)
        lblContraseñaActual.Name = "lblContraseñaActual"
        lblContraseñaActual.Size = New Size(174, 34)
        lblContraseñaActual.TabIndex = 44
        lblContraseñaActual.Text = "Contraseña Actual"
        lblContraseñaActual.TextAlign = ContentAlignment.TopCenter
        ' 
        ' srp4EditarPerfil
        ' 
        srp4EditarPerfil.BackColor = Color.Transparent
        srp4EditarPerfil.BackgroundImageLayout = ImageLayout.None
        srp4EditarPerfil.Location = New Point(27, 263)
        srp4EditarPerfil.Margin = New Padding(0, 0, 0, 20)
        srp4EditarPerfil.Name = "srp4EditarPerfil"
        srp4EditarPerfil.Size = New Size(345, 13)
        srp4EditarPerfil.TabIndex = 52
        ' 
        ' spr2CambiarContraseña
        ' 
        spr2CambiarContraseña.BackColor = Color.Transparent
        spr2CambiarContraseña.BackgroundImageLayout = ImageLayout.None
        spr2CambiarContraseña.Location = New Point(27, 83)
        spr2CambiarContraseña.Margin = New Padding(0, 0, 0, 20)
        spr2CambiarContraseña.Name = "spr2CambiarContraseña"
        spr2CambiarContraseña.Size = New Size(345, 13)
        spr2CambiarContraseña.TabIndex = 46
        ' 
        ' tbxContraseñaActual
        ' 
        tbxContraseñaActual.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        tbxContraseñaActual.BorderStyle = BorderStyle.None
        tbxContraseñaActual.Cursor = Cursors.IBeam
        tbxContraseñaActual.ForeColor = SystemColors.ButtonFace
        tbxContraseñaActual.Location = New Point(27, 58)
        tbxContraseñaActual.Name = "tbxContraseñaActual"
        tbxContraseñaActual.PasswordChar = "*"c
        tbxContraseñaActual.Size = New Size(345, 16)
        tbxContraseñaActual.TabIndex = 45
        ' 
        ' tbxConfimarContraseña
        ' 
        tbxConfimarContraseña.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        tbxConfimarContraseña.BorderStyle = BorderStyle.None
        tbxConfimarContraseña.Cursor = Cursors.IBeam
        tbxConfimarContraseña.ForeColor = SystemColors.ButtonFace
        tbxConfimarContraseña.Location = New Point(27, 238)
        tbxConfimarContraseña.Name = "tbxConfimarContraseña"
        tbxConfimarContraseña.PasswordChar = "*"c
        tbxConfimarContraseña.Size = New Size(345, 16)
        tbxConfimarContraseña.TabIndex = 51
        ' 
        ' lblNuevaContraseña
        ' 
        lblNuevaContraseña.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNuevaContraseña.ForeColor = SystemColors.ButtonFace
        lblNuevaContraseña.Location = New Point(24, 105)
        lblNuevaContraseña.Margin = New Padding(4, 0, 4, 0)
        lblNuevaContraseña.Name = "lblNuevaContraseña"
        lblNuevaContraseña.Size = New Size(181, 34)
        lblNuevaContraseña.TabIndex = 47
        lblNuevaContraseña.Text = "Nueva Contraseña"
        lblNuevaContraseña.TextAlign = ContentAlignment.TopCenter
        ' 
        ' tbxNuevaContraseña
        ' 
        tbxNuevaContraseña.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        tbxNuevaContraseña.BorderStyle = BorderStyle.None
        tbxNuevaContraseña.Cursor = Cursors.IBeam
        tbxNuevaContraseña.ForeColor = SystemColors.ButtonFace
        tbxNuevaContraseña.Location = New Point(27, 148)
        tbxNuevaContraseña.Name = "tbxNuevaContraseña"
        tbxNuevaContraseña.PasswordChar = "*"c
        tbxNuevaContraseña.Size = New Size(345, 16)
        tbxNuevaContraseña.TabIndex = 48
        ' 
        ' lblConfirmarContraseña
        ' 
        lblConfirmarContraseña.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblConfirmarContraseña.ForeColor = SystemColors.ButtonFace
        lblConfirmarContraseña.Location = New Point(24, 195)
        lblConfirmarContraseña.Margin = New Padding(4, 0, 4, 0)
        lblConfirmarContraseña.Name = "lblConfirmarContraseña"
        lblConfirmarContraseña.Size = New Size(212, 34)
        lblConfirmarContraseña.TabIndex = 50
        lblConfirmarContraseña.Text = "Confirmar Contraseña"
        lblConfirmarContraseña.TextAlign = ContentAlignment.TopCenter
        ' 
        ' srp3CambiarContraseña
        ' 
        srp3CambiarContraseña.BackColor = Color.Transparent
        srp3CambiarContraseña.BackgroundImageLayout = ImageLayout.None
        srp3CambiarContraseña.Location = New Point(27, 173)
        srp3CambiarContraseña.Margin = New Padding(0, 0, 0, 20)
        srp3CambiarContraseña.Name = "srp3CambiarContraseña"
        srp3CambiarContraseña.Size = New Size(345, 13)
        srp3CambiarContraseña.TabIndex = 49
        ' 
        ' frmCambiarContraseña
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(390, 844)
        Controls.Add(pnlCambiarContraseña)
        FormBorderStyle = FormBorderStyle.None
        MaximumSize = New Size(390, 844)
        MinimumSize = New Size(390, 844)
        Name = "frmCambiarContraseña"
        Padding = New Padding(25)
        StartPosition = FormStartPosition.CenterScreen
        pnlCambiarContraseña.ResumeLayout(False)
        pnlTopCambiarContraseña.ResumeLayout(False)
        pnlPreferenciasAplicacion.ResumeLayout(False)
        pnlPreferenciasAplicacion.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCambiarContraseña As Panel
    Friend WithEvents btnGuardarCambios As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelarCambios As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents srp4EditarPerfil As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents tbxConfimarContraseña As TextBox
    Friend WithEvents lblConfirmarContraseña As Label
    Friend WithEvents srp3CambiarContraseña As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents tbxNuevaContraseña As TextBox
    Friend WithEvents lblContraseñaActual As Label
    Friend WithEvents lblNuevaContraseña As Label
    Friend WithEvents tbxContraseñaActual As TextBox
    Friend WithEvents spr2CambiarContraseña As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents pnlTopCambiarContraseña As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnRegresarCambiarContraseña As Button
    Friend WithEvents lblCambiarContraseña As Label
    Friend WithEvents pnlPreferenciasAplicacion As Guna.UI2.WinForms.Guna2Panel
End Class
