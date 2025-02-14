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
    Public Sub Actualizar()

    End Sub
End Class