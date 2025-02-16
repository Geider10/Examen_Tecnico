Imports BLL

Public Class frmClientesMain
    Private Sub frmClientesMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarDGV()
    End Sub
    Public Sub ActualizarDGV()
        Dim cliente As Cliente_BLL = New Cliente_BLL()
        Dim dt As DataTable = cliente.GetClientes()
        dgvClientes.DataSource = dt
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvClientes.SelectedRows(0)
            Dim id As Integer = Integer.Parse(row.Cells(0).Value)
            Dim clienteBll = New Cliente_BLL()
            clienteBll.Delete(id)
            ActualizarDGV()
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnAtrasCliente_Click(sender As Object, e As EventArgs) Handles btnAtrasCliente.Click
        Close()
    End Sub
End Class