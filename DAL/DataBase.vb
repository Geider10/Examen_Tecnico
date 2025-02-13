Imports System.Data.SqlClient
Imports System.Configuration

Public Class DataBase

    Private connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    Public connection As New SqlConnection(connectionString)

    Public Sub ConectarDB()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
                Console.WriteLine("Conexión exitosa a la base de datos.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al conectar: " & ex.Message)
        End Try
    End Sub

    Public Sub CerrarDB()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
                Console.WriteLine("Conexión cerrada correctamente.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub

End Class
