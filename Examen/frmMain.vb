Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration

Public Class frmMain
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmClientesMain.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        frmProductoMain.ShowDialog()
    End Sub
End Class
