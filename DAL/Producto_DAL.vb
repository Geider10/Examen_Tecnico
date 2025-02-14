Imports System.Data.SqlClient
Imports Entity

Public Class Producto_DAL
    Private db As DataBase = New DataBase()

    Public Function GetProductos() As DataTable
        Dim query As String = "SELECT * FROM productos"
        Dim dt As DataTable = New DataTable()

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            Console.WriteLine("Error when retreving products: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try

        Return dt
    End Function

    Public Sub Add(product As Producto)
        Dim query As String = "INSERT INTO productos (nombre, precio, categoria) VALUES (@nombre, @precio, @categoria)"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@nombre", product.Nombre)
                command.Parameters.AddWithValue("@precio", product.Precio)
                command.Parameters.AddWithValue("@categoria", product.Categoria)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when adding products: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub

    Public Sub Update(product As Producto, id As Integer)
        Dim query As String = "UPDATE productos SET nombre=@nombre, precio=@precio, categoria=@categoria where ID=@ID"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@ID", id)
                command.Parameters.AddWithValue("@nombre", product.Nombre)
                command.Parameters.AddWithValue("@precio", product.Precio)
                command.Parameters.AddWithValue("@categoria", product.Categoria)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when editing products: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub

    Public Sub Delete(id As Integer)
        Dim query As String = "DELETE FROM productos where ID=@ID"

        Try
            db.ConectarDB()
            Using command As New SqlCommand(query, db.connection)
                command.Parameters.AddWithValue("@ID", id)
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Console.WriteLine("Error when deleting products: " + ex.Message)
        Finally
            db.CerrarDB()
        End Try
    End Sub
End Class
