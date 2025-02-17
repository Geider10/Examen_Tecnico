<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListaProductos = New System.Windows.Forms.DataGridView()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.tbxBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Productos"
        '
        'dgvListaProductos
        '
        Me.dgvListaProductos.AllowUserToAddRows = False
        Me.dgvListaProductos.AllowUserToDeleteRows = False
        Me.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvListaProductos.Location = New System.Drawing.Point(32, 84)
        Me.dgvListaProductos.MultiSelect = False
        Me.dgvListaProductos.Name = "dgvListaProductos"
        Me.dgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaProductos.Size = New System.Drawing.Size(528, 256)
        Me.dgvListaProductos.TabIndex = 15
        '
        'btnComprar
        '
        Me.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComprar.Location = New System.Drawing.Point(453, 365)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(107, 44)
        Me.btnComprar.TabIndex = 16
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerfil.Location = New System.Drawing.Point(453, 34)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(107, 44)
        Me.btnPerfil.TabIndex = 17
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'tbxBuscar
        '
        Me.tbxBuscar.Location = New System.Drawing.Point(155, 47)
        Me.tbxBuscar.Name = "tbxBuscar"
        Me.tbxBuscar.Size = New System.Drawing.Size(161, 20)
        Me.tbxBuscar.TabIndex = 19
        '
        'frmListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 450)
        Me.Controls.Add(Me.tbxBuscar)
        Me.Controls.Add(Me.btnPerfil)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.dgvListaProductos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListaProductos"
        Me.Text = "frmListaProductos"
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListaProductos As DataGridView
    Friend WithEvents btnComprar As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents tbxBuscar As TextBox
End Class
