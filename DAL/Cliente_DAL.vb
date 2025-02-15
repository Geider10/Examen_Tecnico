Imports System.Data.SqlClient
Imports Entity
Public Class ClienteDAL
    Private db As DataBase = New DataBase()
    Public Function GetClientes() As DataTable
        Dim query As String = "SELECT * FROM clientes"
        Dim dt As New DataTable()

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt) ' Llena el DataTable con los datos
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when retreving clients: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try

        Return dt
    End Function

    Public Sub Add(cliente As Cliente)
        Dim query As String = "INSERT INTO clientes (cliente, telefono, correo) values (@cliente,@telefono,@correo)"
        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@cliente", cliente.cliente)
                command.Parameters.AddWithValue("@telefono", cliente.telefono)
                command.Parameters.AddWithValue("@correo", cliente.correo)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when adding a client: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub

    Public Sub Update(cliente As Cliente, id As String)
        Dim query As String = "UPDATE clientes SET cliente=@cliente,telefono=@telefono,correo=@correo where ID=@id"
        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@id", Integer.Parse(id))
                command.Parameters.AddWithValue("@cliente", cliente.cliente)
                command.Parameters.AddWithValue("@telefono", cliente.telefono)
                command.Parameters.AddWithValue("@correo", cliente.correo)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when editing a client: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub

    Public Sub Delete(id As Integer)
        Dim query = "DELETE FROM clientes where ID=@ID"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@ID", id)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when deleting a client: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub

    Public Function GetClienteByEmail(email As String) As Cliente
        Dim query As String = "SELECT ID, Cliente, Telefono, Correo from clientes where Correo=@Correo"
        Dim cliente As Cliente = Nothing

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@Correo", email)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        cliente = New Cliente With {
                            .cliente = reader.GetString(1),
                            .telefono = reader.GetString(2),
                            .correo = reader.GetString(3)
                            }
                    End If
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine("Error when get client by email: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
        Return cliente
    End Function
End Class
