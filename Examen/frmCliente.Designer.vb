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
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.DirectorySearcher2 = New System.DirectoryServices.DirectorySearcher()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxEmailIniciar = New System.Windows.Forms.TextBox()
        Me.tbxTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxEmailCrear = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'DirectorySearcher2
        '
        Me.DirectorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAtras)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbxEmailIniciar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnIniciar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbxEmailCrear)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbxNombre)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCrear)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbxTelefono)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 370
        Me.SplitContainer1.TabIndex = 0
        '
        'btnIniciar
        '
        Me.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciar.Location = New System.Drawing.Point(124, 327)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(107, 44)
        Me.btnIniciar.TabIndex = 3
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(107, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inciar Sesion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(136, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Crear cuenta"
        '
        'btnCrear
        '
        Me.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrear.Location = New System.Drawing.Point(155, 327)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(107, 44)
        Me.btnCrear.TabIndex = 4
        Me.btnCrear.Text = "Crear"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(66, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email*"
        '
        'tbxEmailIniciar
        '
        Me.tbxEmailIniciar.Location = New System.Drawing.Point(70, 177)
        Me.tbxEmailIniciar.Name = "tbxEmailIniciar"
        Me.tbxEmailIniciar.Size = New System.Drawing.Size(209, 20)
        Me.tbxEmailIniciar.TabIndex = 5
        '
        'tbxTelefono
        '
        Me.tbxTelefono.Location = New System.Drawing.Point(90, 230)
        Me.tbxTelefono.Name = "tbxTelefono"
        Me.tbxTelefono.Size = New System.Drawing.Size(209, 20)
        Me.tbxTelefono.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(86, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telefono*"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(90, 177)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(209, 20)
        Me.tbxNombre.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(86, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombre*"
        '
        'tbxEmailCrear
        '
        Me.tbxEmailCrear.Location = New System.Drawing.Point(90, 285)
        Me.tbxEmailCrear.Name = "tbxEmailCrear"
        Me.tbxEmailCrear.Size = New System.Drawing.Size(209, 20)
        Me.tbxEmailCrear.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(86, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email*"
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.Location = New System.Drawing.Point(22, 21)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(107, 44)
        Me.btnAtras.TabIndex = 12
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmCliente"
        Me.Text = "frmCliente"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents DirectorySearcher2 As DirectoryServices.DirectorySearcher
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxEmailIniciar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxEmailCrear As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbxTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAtras As Button
End Class
