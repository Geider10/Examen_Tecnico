Imports DAL

Public Class Cliente_BLL

    Public Function GetClientes() As DataTable
        Dim cliente As ClienteDAL = New ClienteDAL()
        Return cliente.GetClientes()
    End Function
End Class
