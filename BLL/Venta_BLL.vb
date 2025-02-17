Imports Entity
Imports DAL
Public Class Venta_BLL
    Public Function GetVentas() As DataTable
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        Return ventaDal.GetClientes()
    End Function
    Public Function Add(venta As Venta) As Integer
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        Return ventaDal.Add(venta)
    End Function

    Public Function GetVentasClientes() As DataTable
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        Return ventaDal.GetVentasClientes()
    End Function

    Public Sub Update(id As Integer)
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        ventaDal.Update(id)
    End Sub
    Public Sub Delete(id As Integer)
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        ventaDal.Delete(id)
    End Sub
    Public Function ExistsIdClient(idCliente As Integer) As Integer
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        Return ventaDal.ExistsIdClient(idCliente)
    End Function
End Class
