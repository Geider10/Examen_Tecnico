Imports BLL
Public Class frmVentaItemEdit
    Public id As Integer = 0
    Public idVenta As Integer = 0
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim cantidad = nudCantidad.Value
        Dim total = nudTotal.Value
        'editar la cantidad el venta item
        Dim ventaItemBll As VentasItem_BLL = New VentasItem_BLL()
        ventaItemBll.Update(cantidad, total, id)
        'actualizar el total de venta
        Dim ventaBll As Venta_BLL = New Venta_BLL()
        ventaBll.Update(idVenta)
        frmVentaXProducto.Actualizar()
        frmVentaMain.Actualizar()
        Me.Close()
        MessageBox.Show("Se actualizo una los datos de una venta con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub SetCampos(precio As Decimal, cantidad As Decimal, total As Decimal)
        nudPrecio.Value = precio
        nudCantidad.Value = cantidad
        nudTotal.Value = total
    End Sub
    Private Sub nudCantidad_ValueChanged(sender As Object, e As EventArgs) Handles nudCantidad.ValueChanged
        nudTotal.Value = nudPrecio.Value * nudCantidad.Value
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class