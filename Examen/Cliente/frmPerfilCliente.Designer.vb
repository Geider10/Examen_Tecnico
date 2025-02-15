<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfilCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Location = New System.Drawing.Point(176, 214)
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.ReadOnly = True
        Me.tbxCorreo.Size = New System.Drawing.Size(232, 20)
        Me.tbxCorreo.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(93, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Correo"
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Location = New System.Drawing.Point(176, 164)
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.ReadOnly = True
        Me.tbxTelefono.Size = New System.Drawing.Size(232, 20)
        Me.tbxTelefono.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(93, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Telefono"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(176, 121)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.ReadOnly = True
        Me.tbxNombre.Size = New System.Drawing.Size(232, 20)
        Me.tbxNombre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(93, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(316, 64)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(92, 37)
        Me.btnEditar.TabIndex = 11
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.Location = New System.Drawing.Point(256, 285)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(92, 37)
        Me.btnCerrarSesion.TabIndex = 10
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(91, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 29)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Perfil"
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.Location = New System.Drawing.Point(146, 285)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(92, 37)
        Me.btnAtras.TabIndex = 19
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmPerfilCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 450)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Name = "frmPerfilCliente"
        Me.Text = "frmPerfilCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAtras As Button
End Class
