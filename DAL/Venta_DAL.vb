Imports System.Data.SqlClient
Imports Entity
Public Class Venta_DAL
    Private db As DataBase = New DataBase()
    Public Function Add(venta As Venta) As Integer
        Dim idVenta As Integer = 0
        Dim query = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@idCliente, @fecha, @total)"
        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@idcliente", venta.idCliente)
                command.Parameters.AddWithValue("@fecha", venta.fecha)
                command.Parameters.AddWithValue("@total", venta.total)
                idVenta = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when adding a sale: " + ex.Message)
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
End Class
