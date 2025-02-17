<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientesMain
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
        Me.components = New System.ComponentModel.Container()
        Me.btnAtrasCliente = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCliente = New System.Windows.Forms.ComboBox()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtrasCliente
        '
        Me.btnAtrasCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtrasCliente.Location = New System.Drawing.Point(65, 69)
        Me.btnAtrasCliente.Name = "btnAtrasCliente"
        Me.btnAtrasCliente.Size = New System.Drawing.Size(92, 37)
        Me.btnAtrasCliente.TabIndex = 1
        Me.btnAtrasCliente.Text = "Atras"
        Me.btnAtrasCliente.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(65, 401)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 37)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar cliente"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.Location = New System.Drawing.Point(65, 122)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(539, 256)
        Me.dgvClientes.TabIndex = 3
        '
        'tbxSearch
        '
        Me.tbxSearch.Location = New System.Drawing.Point(318, 78)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(167, 20)
        Me.tbxSearch.TabIndex = 4
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(Entity.Cliente)
        '
        'cbxCliente
        '
        Me.cbxCliente.FormattingEnabled = True
        Me.cbxCliente.Location = New System.Drawing.Point(501, 78)
        Me.cbxCliente.Name = "cbxCliente"
        Me.cbxCliente.Size = New System.Drawing.Size(103, 21)
        Me.cbxCliente.TabIndex = 5
        '
        'frmClientesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 472)
        Me.Controls.Add(Me.cbxCliente)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAtrasCliente)
        Me.Name = "frmClientesMain"
        Me.Text = "frmClientesMain"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAtrasCliente As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents cbxCliente As ComboBox
End Class
