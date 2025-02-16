Imports Entity
Imports BLL
Public Class frmVentaDetalles
    Public idProducto As Integer = 0
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim idCliente As Integer = frmListaProductos.clienteChild.id
        Dim ventaBll As Venta_BLL = New Venta_BLL()
        Dim isVenta As Integer = ventaBll.ExistsIdClient(idCliente)
        Dim ventaItemBll As VentasItem_BLL = New VentasItem_BLL()
        If isVenta >= 1 Then
            'regitrar ventaitem y actualizar las ventas
            Dim ventaItem As VentasItem = New VentasItem().CreateVentaItem(isVenta, idProducto, nudPrecio.Value, nudCantidad.Value, nudTotal.Value)
            ventaItemBll.Add(ventaItem)
            ventaBll.Update(isVenta)
            MessageBox.Show("Se creo una ventaItem y se actualizo el total de la venta con exito.")
        Else
            'crear venta y registrar venta
            Dim venta As Venta = New Venta With {
                .idCliente = idCliente,
                .fecha = New DateTime().Now(),
                .total = 0
            }
            Dim idVenta As Integer = ventaBll.Add(venta)
            'crear ventaItem y registrar ventaitem,
            Dim ventaItem As VentasItem = New VentasItem().CreateVentaItem(idVenta, idProducto, nudPrecio.Value, nudCantidad.Value, nudTotal.Value)
            ventaItemBll.Add(ventaItem)
            'actualizar el total de la venta por IDCliente
            ventaBll.Update(idVenta)
            MessageBox.Show("Se creo una venta y una ventaItem con exito.")
        End If
        idProducto = 0
        Me.Close()
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