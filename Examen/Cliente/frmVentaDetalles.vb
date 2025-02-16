Public Class frmVentaDetalles
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub nudCantidad_ValueChanged(sender As Object, e As EventArgs) Handles nudCantidad.ValueChanged
        nudTotal.Value = nudPrecio.Value * nudCantidad.Value
    End Sub
    Public Sub SetTxt(nombre As String, precio As Decimal, Optional cantidad As Decimal = 1)
        tbxNombre.Text = nombre
        nudPrecio.Value = precio
        nudTotal.Value = precio * cantidad
    End Sub
End Class