Imports Entity
Imports BLL
Public Class frmCliente
    Public clienteGlobal As Cliente = Nothing
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim email As String = tbxEmailIniciar.Text.Trim()
        Dim clienteBll As Cliente_BLL = New Cliente_BLL()
        clienteGlobal = clienteBll.GetClienteByEmail(email)
        If clienteGlobal IsNot Nothing Then
            'MessageBox.Show("nombre: " + clienteGlobal.cliente + " correo: " + clienteGlobal.correo)
            frmListaProductos.SetCliente(clienteGlobal)
            frmListaProductos.ShowDialog()
            tbxEmailIniciar.Text = " "
        Else
            MessageBox.Show("Error al iniciar sesión, el email no coincide.")
        End If
        'obtener un cliente por email
        'si hay mathc abrit ventana y si no tirrar error
        'almacenar el cliente de manera global
    End Sub
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        tbxEmailIniciar.Text = ""
        Close()
    End Sub
    Private Sub lblCrearCliente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCrearCliente.LinkClicked
        frmAddCliente.ShowDialog()
    End Sub
End Class