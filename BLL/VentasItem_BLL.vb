Imports Entity
Imports DAL
Public Class VentasItem_BLL
    Public Function GeItemsSale() As DataTable
        Dim viDal As VentasItem_DAL = New VentasItem_DAL()
        Return viDal.GeItemsSale()
    End Function
    Public Sub Add(ventaItem As VentasItem)
        Dim viDal As VentasItem_DAL = New VentasItem_DAL()
        viDal.Add(ventaItem)
    End Sub
    Public Sub Update(cantidad As Decimal, total As Decimal, id As Integer)
        Dim viDal As VentasItem_DAL = New VentasItem_DAL()
        viDal.Update(cantidad, total, id)
    End Sub
    Public Sub Delete(idVenta As Integer)
        Dim viDal As VentasItem_DAL = New VentasItem_DAL()
        viDal.Delete(idVenta)
    End Sub
End Class
