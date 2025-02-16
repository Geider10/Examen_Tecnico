Imports BLL
Imports System.Data.SqlClient
Public Class frmVentaMain
    Private Sub frmVentaMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub

    Private Sub btnVentasProducto_Click(sender As Object, e As EventArgs) Handles btnVentasProducto.Click
        frmVentaXProducto.ShowDialog()
    End Sub
    Public Sub Actualizar()

    End Sub
End Class