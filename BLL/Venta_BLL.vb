﻿Imports Entity
Imports DAL
Public Class Venta_BLL
    Public Function Add(venta As Venta) As Integer
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        Return ventaDal.Add(venta)
    End Function
    Public Sub Update(id As Integer)
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        ventaDal.Update(id)
    End Sub
    Public Sub Delete(id As Integer)
        Dim ventaDal As Venta_DAL = New Venta_DAL()
        ventaDal.Delete(id)
    End Sub
End Class
