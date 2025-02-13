Imports BLL

Public Class frmClientesMain
    Private Sub btnAtrasCliente_Click(sender As Object, e As EventArgs) Handles btnAtrasCliente.Click
        Close()
    End Sub

    Private Sub frmClientesMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDGV()
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        frmAddCliente.ShowDialog()
    End Sub
    Public Sub ActualizarDGV()
        Dim cliente As Cliente_BLL = New Cliente_BLL()
        dgvClientes.DataSource = cliente.GetClientes()
    End Sub
    Public Function GetClienteID() As Integer
        Dim id As Integer


        Return id
    End Function
End Class