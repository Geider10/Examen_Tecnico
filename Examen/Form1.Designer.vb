<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(46, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar como cliente"
        '
        'btnCliente
        '
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.Location = New System.Drawing.Point(104, 227)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(107, 44)
        Me.btnCliente.TabIndex = 1
        Me.btnCliente.Text = "Ingresar"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdmin.Location = New System.Drawing.Point(527, 227)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(107, 44)
        Me.btnAdmin.TabIndex = 2
        Me.btnAdmin.Text = "Ingresar"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(464, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingresar como admin"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Label2 As Label
End Class
