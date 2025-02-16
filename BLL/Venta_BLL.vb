Imports Entity
Imports DAL
Public Class Venta_BLL
    Public Sub Add(venta As Venta)
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        ventaDal.Add(venta)
    End Sub
    Public Sub Update(total As Decimal, id As Integer)
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        ventaDal.Update(total, id)
    End Sub
    Public Sub Delete(id As Integer)
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        ventaDal.Delete(id)
    End Sub
End Class
