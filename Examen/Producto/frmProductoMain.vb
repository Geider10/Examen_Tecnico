Imports BLL
Public Class frmProductoMain
    Private Sub frmProductoMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAddProducto.ShowDialog()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvProductos.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(row.Cells(0).Value)
            Dim nombre As String = row.Cells(1).Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(row.Cells(2).Value)
            Dim categoria As String = row.Cells(3).Value.ToString()

            Dim frmAdd As frmAddProducto = New frmAddProducto()
            frmAdd.idProducto = id
            frmAdd.SetCampos(nombre, precio, categoria)
            frmAdd.ShowDialog()
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvProductos.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvProductos.SelectedRows(0)
            Dim id As Integer = Convert.ToInt32(row.Cells(0).Value)
            Dim productoBll As Producto_BLL = New Producto_BLL()
            productoBll.Delete(id)
            Actualizar()
            MessageBox.Show("Se elimino un producto con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub Actualizar()
        Dim productDAL As New Producto_BLL()
        Dim dt As DataTable = productDAL.GetProductos()
        dgvProductos.DataSource = dt
    End Sub

End Class