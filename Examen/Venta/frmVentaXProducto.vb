Imports BLL
Public Class frmVentaXProducto
    Private Sub frmVentaXProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub
    Public Sub Actualizar()
        Dim ventaItemBll As VentasItem_BLL = New VentasItem_BLL()
        Dim dt As DataTable = ventaItemBll.GeItemsSale()
        dgvVentaItems.DataSource = dt
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvVentaItems.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvVentaItems.SelectedRows(0)
            Dim precio As Decimal = Convert.ToDecimal(row.Cells(3).Value)
            Dim cantidad As Decimal = Convert.ToDecimal(row.Cells(4).Value)
            Dim total As Decimal = Convert.ToDecimal(row.Cells(5).Value)

            frmVentaItemEdit.id = Convert.ToInt32(row.Cells(0).Value)
            frmVentaItemEdit.idVenta = Convert.ToInt32(row.Cells(1).Value)
            frmVentaItemEdit.SetCampos(precio, cantidad, total)
            frmVentaItemEdit.ShowDialog()
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class