﻿Imports DAL
Imports Entity
Public Class Cliente_BLL

    Public Function GetClientes() As DataTable
        Dim cliente As ClienteDAL = New ClienteDAL()
        Return cliente.GetClientes()
    End Function

    Public Sub Add(cliente As Cliente)
        Dim clienteDal As ClienteDAL = New ClienteDAL()
        clienteDal.Add(cliente)
    End Sub

    Public Sub Update(cliente As Cliente, id As String)
        Dim clienteDal As ClienteDAL = New ClienteDAL()
        clienteDal.Update(cliente, id)
    End Sub

    Public Sub Delete(id As Integer)
        Dim clienteDal As ClienteDAL = New ClienteDAL()
        clienteDal.Delete(id)
    End Sub

    Public Function GetClienteByEmail(email As String) As Cliente
        Dim clienteDal As ClienteDAL = New ClienteDAL()
        Return clienteDal.GetClienteByEmail(email)
    End Function
    Public Function GetClientesByKey(key As String, value As String) As DataTable
        Dim clienteDal As ClienteDAL = New ClienteDAL()
        Return clienteDal.GetClientesByKey(key, value)
    End Function
End Class
