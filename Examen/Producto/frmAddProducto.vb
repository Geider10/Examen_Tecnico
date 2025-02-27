﻿Imports BLL
Imports Entity
Public Class frmAddProducto
    Public idProducto As Integer = 0
    Private Sub frmAddProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idProducto <> 0 Then
            lblTituloProducto.Text = "Editar Producto"
        Else
            lblTituloProducto.Text = "Crear Producto"
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim productoBll As Producto_BLL = New Producto_BLL()
        Dim producto As Producto = New Producto()
        producto.Nombre = tbxNombre.Text
        producto.Precio = nudPrecio.Value
        producto.Categoria = tbxCategoria.Text

        If idProducto <> 0 Then
            productoBll.Update(producto, idProducto)
            MessageBox.Show("Se edito un producto con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            productoBll.Add(producto)
            MessageBox.Show("Se creo un producto con exito.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
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