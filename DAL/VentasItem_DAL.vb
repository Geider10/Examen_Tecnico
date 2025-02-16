Imports System.Data.SqlClient
Imports Entity
Public Class VentasItem_DAL
    Private db As DataBase = New DataBase()

    Public Sub Add(ventasItem As VentasItem)
        Dim query = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@idVenta, @idProducto, @precioUnitario, @cantidad, @precioTotal)"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@idVenta", ventasItem.idVenta)
                command.Parameters.AddWithValue("@idProducto", ventasItem.idProducto)
                command.Parameters.AddWithValue("@precioUnitario", ventasItem.precioUnitario)
                command.Parameters.AddWithValue("@cantidad", ventasItem.cantidad)
                command.Parameters.AddWithValue("@precioTotal", ventasItem.precioTotal)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when adding itemSale: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
    Public Sub Update(ventasItem As VentasItem, idVenta As Integer)
        Dim query = "UPDATE ventasitems SET PrecioUnitario=@precioUnitario, Cantidad=@cantidad, PrecioTotal=@precioTotal where IDVenta=@idVenta"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@idVenta", idVenta)
                command.Parameters.AddWithValue("@precioUnitario", ventasItem.precioUnitario)
                command.Parameters.AddWithValue("@cantidad", ventasItem.cantidad)
                command.Parameters.AddWithValue("@precioTotal", ventasItem.precioTotal)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when refresh itemSale: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
    Public Sub Delete(idVenta As Integer)
        Dim query = "DELETE FROM ventasitems where IDVenta=@idVenta"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@idVenta", idVenta)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when deleted itemSale: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
End Class
