<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentaMain
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
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnVentasProducto = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvVentas.Location = New System.Drawing.Point(40, 96)
        Me.dgvVentas.MultiSelect = False
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(539, 256)
        Me.dgvVentas.TabIndex = 14
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.Location = New System.Drawing.Point(40, 43)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(92, 37)
        Me.btnAtras.TabIndex = 13
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnVentasProducto
        '
        Me.btnVentasProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentasProducto.Location = New System.Drawing.Point(448, 43)
        Me.btnVentasProducto.Name = "btnVentasProducto"
        Me.btnVentasProducto.Size = New System.Drawing.Size(131, 37)
        Me.btnVentasProducto.TabIndex = 17
        Me.btnVentasProducto.Text = "Ventas x Producto"
        Me.btnVentasProducto.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(40, 367)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(131, 37)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'frmVentaMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnVentasProducto)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnAtras)
        Me.Name = "frmVentaMain"
        Me.Text = "frmVentaMain"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnVentasProducto As Button
    Friend WithEvents btnEliminar As Button
End Class
