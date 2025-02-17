Imports BLL

Public Class frmClientesMain
    Private Sub frmClientesMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxCliente.Items.Add("Cliente")
        cbxCliente.Items.Add("Telefono")
        cbxCliente.Items.Add("Correo")
        cbxCliente.SelectedIndex = 0

        ActualizarDGV()
    End Sub
    Public Sub ActualizarDGV()
        Dim key As String = cbxCliente.SelectedItem.ToString()
        Dim value As String = tbxSearch.Text.Trim()
        Dim cliente As Cliente_BLL = New Cliente_BLL()
        If value.Length > 0 Then
            Dim dt As DataTable = cliente.GetClientesByKey(key, value)
            dgvClientes.DataSource = dt
        Else
            Dim dt As DataTable = cliente.GetClientes()
            dgvClientes.DataSource = dt
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvClientes.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvClientes.SelectedRows(0)
            Dim id As Integer = Integer.Parse(row.Cells(0).Value)
            Dim clienteBll = New Cliente_BLL()
            clienteBll.Delete(id)
            ActualizarDGV()
            MessageBox.Show("Se elimino un cliente con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnAtrasCliente_Click(sender As Object, e As EventArgs) Handles btnAtrasCliente.Click
        Close()
    End Sub

    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged
        ActualizarDGV()
    End Sub
End Class