Imports DAL
Imports Entity

Public Class Producto_BLL
    Public Function GetProductos() As DataTable
        Dim productoDal As Producto_DAL = New Producto_DAL()
        Return productoDal.GetProductos()
    End Function

    Public Sub Add(producto As Producto)
        Dim productoDAL As Producto_DAL = New Producto_DAL()
        productoDAL.Add(producto)
    End Sub

    Public Sub Update(producto As Producto, id As Integer)
        Dim productoDAL As Producto_DAL = New Producto_DAL()
        productoDAL.Update(producto, id)
    End Sub

    Public Sub Delete(id As Integer)
        Dim productoDAL As Producto_DAL = New Producto_DAL()
        productoDAL.Delete(id)
    End Sub
End Class
