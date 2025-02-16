<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentaXProducto
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
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.tbxBuscar = New System.Windows.Forms.TextBox()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(35, 367)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(131, 37)
        Me.btnEditar.TabIndex = 24
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Location = New System.Drawing.Point(482, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 37)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'tbxBuscar
        '
        Me.tbxBuscar.Location = New System.Drawing.Point(243, 40)
        Me.tbxBuscar.Name = "tbxBuscar"
        Me.tbxBuscar.Size = New System.Drawing.Size(233, 20)
        Me.tbxBuscar.TabIndex = 21
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVentas.Location = New System.Drawing.Point(35, 84)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(539, 256)
        Me.dgvVentas.TabIndex = 20
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.Location = New System.Drawing.Point(35, 31)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(92, 37)
        Me.btnAtras.TabIndex = 19
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmVentaXProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 450)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.tbxBuscar)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "frmVentaXProducto"
        Me.Text = "frmVentaXProducto"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents tbxBuscar As TextBox
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnAtras As Button
End Class
