Imports System.Data.SqlClient
Imports Entity
Public Class Venta_DAL
    Private db As DataBase = New DataBase()
    Public Sub Add(venta As Venta)
        Dim query = "INSERT INTO ventas (IDCliente, Fecha, Total) VALUES (@idCliente, @fecha, @total)"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@idcliente", venta.idCliente)
                command.Parameters.AddWithValue("@fecha", venta.fecha)
                command.Parameters.AddWithValue("@total", venta.total)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when adding a sale: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
    Public Sub Update(total As Decimal, id As Integer)
        Dim query = "UPDATE ventas SET Total=@total where ID=@id"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@id", id)
                command.Parameters.AddWithValue("@total", total)
                command.ExecuteNonQuery()
            End Using
            db.ConectarDB()
        Catch ex As Exception
            Console.WriteLine("Error when edited a client: " + ex.Message)
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
            Console.WriteLine("Error when deleted a client: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
    Public Sub pepe(id As Integer)
        Dim query = ""
        Try
            db.ConectarDB()
        Catch ex As Exception
            Console.WriteLine("Error when deleted a client: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
End Class
