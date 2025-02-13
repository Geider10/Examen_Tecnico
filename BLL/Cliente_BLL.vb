Imports DAL
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
End Class
