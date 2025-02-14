Imports BLL
Imports Entity
Public Class frmAddProducto
    Public idProducto As Integer = 0
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim productoBll As Producto_BLL = New Producto_BLL()
        Dim producto As Producto = New Producto()
        producto.Nombre = tbxNombre.Text
        producto.Precio = nudPrecio.Value
        producto.Categoria = tbxCategoria.Text

        If idProducto <> 0 Then
            productoBll.Update(producto, idProducto)

        Else
            productoBll.Add(producto)
        End If

        idProducto = 0
        Close()
        CleanForm()
        frmProductoMain.Actualizar()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        idProducto = 0
        Close()
        CleanForm()
    End Sub
    Public Sub SetCampos(nombre As String, precio As Decimal, categoria As String)
        tbxNombre.Text = nombre
        nudPrecio.Value = precio
        tbxCategoria.Text = categoria
    End Sub
    Private Sub CleanForm()
        tbxNombre.Text = " "
        nudPrecio.Value = 0
        tbxCategoria.Text = " "
    End Sub


End Class