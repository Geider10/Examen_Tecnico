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
        Me.components = New System.ComponentModel.Container()
        Me.btnAtrasCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnEditarCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
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
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarCliente.Location = New System.Drawing.Point(65, 401)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(92, 37)
        Me.btnAgregarCliente.TabIndex = 2
        Me.btnAgregarCliente.Text = "Agregar cliente"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
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
        Me.dgvClientes.Size = New System.Drawing.Size(775, 256)
        Me.dgvClientes.TabIndex = 3
        '
        'tbxSearch
        '
        Me.tbxSearch.Location = New System.Drawing.Point(191, 78)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(290, 20)
        Me.tbxSearch.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Location = New System.Drawing.Point(512, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 37)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(Entity.Cliente)
        '
        'btnEditarCliente
        '
        Me.btnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarCliente.Location = New System.Drawing.Point(231, 401)
        Me.btnEditarCliente.Name = "btnEditarCliente"
        Me.btnEditarCliente.Size = New System.Drawing.Size(92, 37)
        Me.btnEditarCliente.TabIndex = 6
        Me.btnEditarCliente.Text = "Editar cliente"
        Me.btnEditarCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarCliente.Location = New System.Drawing.Point(389, 401)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(92, 37)
        Me.btnEliminarCliente.TabIndex = 7
        Me.btnEliminarCliente.Text = "Eliminar cliente"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'frmClientesMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 472)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnEditarCliente)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.btnAtrasCliente)
        Me.Name = "frmClientesMain"
        Me.Text = "frmClientesMain"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAtrasCliente As Button
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents btnEditarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
End Class
