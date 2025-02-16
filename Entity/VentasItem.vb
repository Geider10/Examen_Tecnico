Public Class VentasItem
    Public Property id As Integer
    Public Property idVenta As Integer
    Public Property idProducto As Integer
    Public Property precioUnitario As Decimal
    Public Property cantidad As Decimal
    Public Property precioTotal As Decimal

    Public Function CreateVentaItem(idVenta As Integer, idProducto As Integer, precioU As Decimal, cantidad As Decimal, precioT As Decimal) As VentasItem
        Dim venta As VentasItem = New VentasItem With {
            .idVenta = idVenta,
            .idProducto = idProducto,
            .precioUnitario = precioU,
            .cantidad = cantidad,
            .precioTotal = precioT
        }
        Return venta
    End Function

End Class
