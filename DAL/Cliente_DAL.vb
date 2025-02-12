Imports System.Data.SqlClient
Imports Entity
Public Class ClienteDAL
    Private db As DataBase = New DataBase()
    Public Function GetClientes() As DataTable
        Dim query As String = "SELECT * FROM clientes"
        Dim dt As New DataTable()

        Try
            Using command As New SqlCommand(query, db.connection)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt) ' Llena el DataTable con los datos
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when retreving clients: " + ex.Message)
        End Try

        Return dt
    End Function

    Public Sub Add(cliente As Cliente)
        Dim query As String = "INSERT INTO clientes (cliente, telefono, correo) values (@cliente,@telefono,@correo)"
        Try
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@cliente", cliente.cliente)
                command.Parameters.AddWithValue("@telefono", cliente.telefono)
                command.Parameters.AddWithValue("@correo", cliente.correo)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when adding a client: " + ex.Message)
        End Try
    End Sub
End Class
