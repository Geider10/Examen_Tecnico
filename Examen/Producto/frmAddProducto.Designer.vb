﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProducto
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
        Me.tbxCategoria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.nudPrecio = New System.Windows.Forms.NumericUpDown()
        Me.lblTituloProducto = New System.Windows.Forms.Label()
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbxCategoria
        '
        Me.tbxCategoria.Location = New System.Drawing.Point(163, 237)
        Me.tbxCategoria.Name = "tbxCategoria"
        Me.tbxCategoria.Size = New System.Drawing.Size(232, 20)
        Me.tbxCategoria.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(80, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(80, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Precio"
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(163, 144)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(232, 20)
        Me.tbxNombre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(80, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre"
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(303, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 37)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Location = New System.Drawing.Point(163, 293)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(92, 37)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'nudPrecio
        '
        Me.nudPrecio.DecimalPlaces = 2
        Me.nudPrecio.Location = New System.Drawing.Point(163, 187)
        Me.nudPrecio.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudPrecio.Name = "nudPrecio"
        Me.nudPrecio.Size = New System.Drawing.Size(232, 20)
        Me.nudPrecio.TabIndex = 18
        '
        'lblTituloProducto
        '
        Me.lblTituloProducto.AutoSize = True
        Me.lblTituloProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblTituloProducto.Location = New System.Drawing.Point(78, 81)
        Me.lblTituloProducto.Name = "lblTituloProducto"
        Me.lblTituloProducto.Size = New System.Drawing.Size(175, 29)
        Me.lblTituloProducto.TabIndex = 20
        Me.lblTituloProducto.Text = "Titulo producto"
        '
        'frmAddProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(530, 450)
        Me.Controls.Add(Me.lblTituloProducto)
        Me.Controls.Add(Me.nudPrecio)
        Me.Controls.Add(Me.tbxCategoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "frmAddProducto"
        Me.Text = "frmAddProducto"
        CType(Me.nudPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbxCategoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents nudPrecio As NumericUpDown
    Friend WithEvents lblTituloProducto As Label
End Class
