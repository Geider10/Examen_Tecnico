<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTituloCliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Location = New System.Drawing.Point(224, 276)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 37)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(364, 276)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 37)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(141, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(224, 127)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(232, 20)
        Me.tbxNombre.TabIndex = 5
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Location = New System.Drawing.Point(224, 170)
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.Size = New System.Drawing.Size(232, 20)
        Me.tbxTelefono.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(141, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Telefono"
        '
        'tbxCorreo
        '
        Me.tbxCorreo.Location = New System.Drawing.Point(224, 220)
        Me.tbxCorreo.Name = "tbxCorreo"
        Me.tbxCorreo.Size = New System.Drawing.Size(232, 20)
        Me.tbxCorreo.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(141, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Correo"
        '
        'lblTituloCliente
        '
        Me.lblTituloCliente.AutoSize = True
        Me.lblTituloCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblTituloCliente.Location = New System.Drawing.Point(139, 62)
        Me.lblTituloCliente.Name = "lblTituloCliente"
        Me.lblTituloCliente.Size = New System.Drawing.Size(151, 29)
        Me.lblTituloCliente.TabIndex = 19
        Me.lblTituloCliente.Text = "Titulo cliente"
        '
        'frmAddCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(662, 450)
        Me.Controls.Add(Me.lblTituloCliente)
        Me.Controls.Add(Me.tbxCorreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmAddCliente"
        Me.Text = "frmAddCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents tbxTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTituloCliente As Label
End Class
