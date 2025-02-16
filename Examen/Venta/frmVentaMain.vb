Imports BLL
Imports System.Data.SqlClient
Public Class frmVentaMain
    Private Sub frmVentaMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If dgvVentas.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvVentas.SelectedRows(0)
            Dim idVenta As Integer = Convert.ToInt32(row.Cells(0).Value)
            Dim ventaBll As Venta_BLL = New Venta_BLL()
            Dim ventaItemBll As VentasItem_BLL = New VentasItem_BLL()
            ventaItemBll.Delete(idVenta)
            ventaBll.Delete(idVenta)
            Actualizar()
            'actualizar frmventaxproducto
            MessageBox.Show("Se elimino una venta con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub

    Private Sub btnVentasProducto_Click(sender As Object, e As EventArgs) Handles btnVentasProducto.Click
        frmVentaXProducto.ShowDialog()
    End Sub
    Public Sub Actualizar()
        Dim ventalBll As Venta_BLL = New Venta_BLL()
        Dim dt As DataTable = ventalBll.GetVentas()
        dgvVentas.DataSource = dt
    End Sub


End Class