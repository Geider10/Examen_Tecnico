Imports Entity
Public Class frmPerfilCliente
    Dim clienteChild As Cliente = Nothing
    Private Sub frmPerfilCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarPerfil()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmAddCliente.idCliente = clienteChild.id
        frmAddCliente.SetTxt(clienteChild.cliente, clienteChild.telefono, clienteChild.correo)
        frmAddCliente.ShowDialog()
    End Sub
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
        frmListaProductos.Close()
        frmCliente.Close()
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub
    Public Sub SetCliente(cliente As Cliente)
        clienteChild = cliente
    End Sub
    Public Sub ActualizarPerfil()
        tbxNombre.Text = clienteChild.cliente
        tbxTelefono.Text = clienteChild.telefono
        tbxCorreo.Text = clienteChild.correo
    End Sub


End Class