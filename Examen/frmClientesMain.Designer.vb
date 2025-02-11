<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientesMain
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
        Me.btnAtrasCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(34, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
        '
        'btnAtrasCliente
        '
        Me.btnAtrasCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtrasCliente.Location = New System.Drawing.Point(205, 27)
        Me.btnAtrasCliente.Name = "btnAtrasCliente"
        Me.btnAtrasCliente.Size = New System.Drawing.Size(92, 37)
        Me.btnAtrasCliente.TabIndex = 1
        Me.btnAtrasCliente.Text = "Atras"
        Me.btnAtrasCliente.UseVisualStyleBackColor = True
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarCliente.Location = New System.Drawing.Point(337, 27)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(92, 37)
        Me.btnAgregarCliente.TabIndex = 2
        Me.btnAgregarCliente.Text = "Agregar nuevo cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(65, 124)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(569, 256)
        Me.dgvClientes.TabIndex = 3
        '
        'frmClientesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.btnAtrasCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmClientesMain"
        Me.Text = "frmClientesMain"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtrasCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents dgvClientes As DataGridView
End Class
