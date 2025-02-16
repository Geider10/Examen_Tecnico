﻿Imports BLL
Imports Entity
Public Class frmListaProductos
    Public clienteChild As Cliente = Nothing
    Private Sub frmListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productoBll As Producto_BLL = New Producto_BLL()
        Dim dt As DataTable = productoBll.GetProductos()
        dgvListaProductos.DataSource = dt
    End Sub
    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        If dgvListaProductos.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvListaProductos.SelectedRows(0)
            Dim idProducto As Integer = Convert.ToInt32(row.Cells(0).Value)
            Dim nombre As String = row.Cells(1).Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(row.Cells(2).Value)

            Dim frmVenta As frmVentaDetalles = New frmVentaDetalles()
            frmVenta.idProducto = idProducto
            frmVenta.SetTxt(nombre, precio)
            frmVenta.ShowDialog()
        Else
            MessageBox.Show("Por favor, seleccione una fila antes de editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        frmPerfilCliente.SetCliente(clienteChild)
        frmPerfilCliente.ShowDialog()
    End Sub
    Public Sub SetCliente(cliente As Cliente)
        clienteChild = cliente
    End Sub
End Class