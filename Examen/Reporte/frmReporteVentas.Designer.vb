<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteVentas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvVentaClientes = New System.Windows.Forms.DataGridView()
        CType(Me.dgvVentaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.Location = New System.Drawing.Point(24, 25)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(107, 44)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(199, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Venta de los clientes"
        '
        'dgvVentaClientes
        '
        Me.dgvVentaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentaClientes.Location = New System.Drawing.Point(24, 114)
        Me.dgvVentaClientes.Name = "dgvVentaClientes"
        Me.dgvVentaClientes.Size = New System.Drawing.Size(742, 230)
        Me.dgvVentaClientes.TabIndex = 9
        '
        'frmReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvVentaClientes)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReporteVentas"
        Me.Text = "frmReporteVentas"
        CType(Me.dgvVentaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAtras As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvVentaClientes As DataGridView
End Class
