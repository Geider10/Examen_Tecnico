Imports System.Data.SqlClient
Imports Entity
Public Class Venta_DAL
    Private db As DataBase = New DataBase()

    Public Function GetClientes() As DataTable
        Dim query As String = "SELECT ID, Fecha, Total FROM ventas"
        Dim dt As New DataTable()
        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al recuperar las ventas: " & ex.Message)
        Finally
            db.CerrarDB()
        End Try

        Return dt
    End Function
    Public Function Add(venta As Venta) As Integer
        Dim idVenta As Integer = 0
        Dim query As String = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@idCliente, @fecha, @total); SELECT SCOPE_IDENTITY();"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@idCliente", venta.idCliente)
                command.Parameters.AddWithValue("@fecha", venta.fecha)
                command.Parameters.AddWithValue("@total", venta.total)

                idVenta = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al agregar la venta: " & ex.Message)
        Finally
            db.CerrarDB()
        End Try

        Return idVenta
    End Function
    Public Sub Update(id As Integer)
        Dim query = "UPDATE ventas SET Total=(SELECT SUM(PrecioTotal) FROM ventasitems WHERE IDVenta = @id) where ID=@id"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@id", id)
                command.ExecuteNonQuery()
            End Using
            db.ConectarDB()
        Catch ex As Exception
            Console.WriteLine("Error when edited a sale: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
    Public Sub Delete(id As Integer)
        Dim query = "DELETE FROM ventas where ID=@id"
        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@id", id)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when deleted a sale: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
    Public Function ExistsIdClient(idCliente As Integer) As Integer
        Dim isVenta As Integer = 0
        Dim query As String = "SELECT ID FROM ventas WHERE IDCliente=@idCliente"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@idCliente", idCliente)
                isVenta = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when displawing a client: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try

        Return isVenta
    End Function
End Class
