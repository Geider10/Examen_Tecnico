Imports BLL
Public Class frmReporteVentas
    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
    End Sub
    Private Sub Actualizar()
        Dim ventasBll As Venta_BLL = New Venta_BLL()
        Dim dt As DataTable = ventasBll.GetVentasClientes()
        dgvVentaClientes.DataSource = dt
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub
End Class