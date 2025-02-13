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
    Private Sub btnEditarCliente_Click(sender As Object, e As EventArgs) Handles btnEditarCliente.Click
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvClientes.SelectedRows(0)

            Dim id As Integer = Convert.ToInt32(row.Cells(0).Value)
            Dim nombre As String = row.Cells(1).Value.ToString()
            Dim telefono As String = row.Cells(2).Value.ToString()
            Dim correo As String = row.Cells(3).Value.ToString()

            Dim frmAdd = New frmAddCliente()
            frmAdd.SetTxt(nombre, telefono, correo)
            frmAdd.idCliente = id
            frmAdd.ShowDialog()
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
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
    Public Sub ActualizarDGV()
        Dim cliente As Cliente_BLL = New Cliente_BLL()
        Dim dt As DataTable = cliente.GetClientes()
        dgvClientes.DataSource = dt
    End Sub

End Class