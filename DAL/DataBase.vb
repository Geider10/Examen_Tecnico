Imports System.Data.SqlClient
Imports System.Configuration

Public Class DataBase
    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    Public connection As New SqlConnection(connectionString)

    Public Sub ConectDB()
        Try
            connection.Open()
            Console.WriteLine("Conexión exitosa a la base de datos.") ' Mensaje en consola
        Catch ex As Exception
            Console.WriteLine("Error al conectar: " & ex.Message) ' Mensaje en consola
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
                Console.WriteLine("Conexión cerrada correctamente.")
            End If
        End Try
    End Sub
End Class
