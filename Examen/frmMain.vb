Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration

Public Class frmMain
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frmAdmin.ShowDialog()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        frmCliente.ShowDialog()
    End Sub
End Class
