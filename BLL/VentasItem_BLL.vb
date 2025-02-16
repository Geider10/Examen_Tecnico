Imports Entity
Imports DAL
Public Class VentasItem_BLL
    Public Sub Add(ventaItem As VentasItem)
        Dim viDal As VentasItem_DAL = New VentasItem_DAL()
        viDal.Add(ventaItem)
    End Sub
    Public Sub Update(ventaItem As VentasItem, idVenta As Integer)
        Dim viDal As VentasItem_DAL = New VentasItem_DAL()
        viDal.Update(ventaItem, idVenta)
    End Sub
    Public Sub Delete(idVenta As Integer)
        Dim viDal As VentasItem_DAL = New VentasItem_DAL()
        viDal.Delete(idVenta)
    End Sub
End Class
