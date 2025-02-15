Public Class frmAdmin
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmClientesMain.ShowDialog()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        frmProductoMain.ShowDialog()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Close()
    End Sub
End Class