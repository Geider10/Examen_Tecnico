<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.tbxEmailIniciar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCrearCliente = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.Location = New System.Drawing.Point(28, 21)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(107, 44)
        Me.btnAtras.TabIndex = 17
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'tbxEmailIniciar
        '
        Me.tbxEmailIniciar.Location = New System.Drawing.Point(260, 200)
        Me.tbxEmailIniciar.Name = "tbxEmailIniciar"
        Me.tbxEmailIniciar.Size = New System.Drawing.Size(209, 20)
        Me.tbxEmailIniciar.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(256, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Email*"
        '
        'btnIniciar
        '
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Location = New System.Drawing.Point(329, 295)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(107, 44)
        Me.btnIniciar.TabIndex = 14
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(297, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 29)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Inciar Sesion"
        '
        'lblCrearCliente
        '
        Me.lblCrearCliente.AutoSize = True
        Me.lblCrearCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCrearCliente.LinkVisited = True
        Me.lblCrearCliente.Location = New System.Drawing.Point(311, 363)
        Me.lblCrearCliente.Name = "lblCrearCliente"
        Me.lblCrearCliente.Size = New System.Drawing.Size(138, 13)
        Me.lblCrearCliente.TabIndex = 18
        Me.lblCrearCliente.TabStop = True
        Me.lblCrearCliente.Text = "No tienes cuenta. Has click"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCrearCliente)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.tbxEmailIniciar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCliente"
        Me.Text = "frmCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents tbxEmailIniciar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCrearCliente As LinkLabel
End Class
