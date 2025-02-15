﻿Imports BLL
Public Class frmListaProductos
    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        If dgvListaProductos.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvListaProductos.SelectedRows(0)
            Dim idProducto As Integer = Convert.ToInt32(row.Cells(0).Value)
            Dim nombre As String = row.Cells(1).Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(row.Cells(2).Value)

            Dim frmVenta As frmVentaDetalles = New frmVentaDetalles()
            frmVenta.SetTxt(nombre, precio)
            frmVenta.ShowDialog()
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        'seleccionar un producto de la tabla
        'levantar una ventana (ventaDetalles) y definir nombre, precio unitario, cantidad, precio total. Boton confirmar y cancelar
        'registar un venta en BD  (idccliente, fecha, precio total)
        'registrat una ventaitem en BD (idproducto, idventa, precio unitario, cantidad, total)

    End Sub

    Private Sub frmListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productoBll As Producto_BLL = New Producto_BLL()
        Dim dt As DataTable = productoBll.GetProductos()
        dgvListaProductos.DataSource = dt
    End Sub
End Class