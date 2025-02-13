Imports BLL
Imports Entity
Public Class frmAddCliente
    Private clienteBll As Cliente_BLL = New Cliente_BLL()

    Private Sub CleanForm()
        tbxNombre.Text = " "
        tbxTelefono.Text = " "
        tbxCorreo.Text = " "

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CleanForm()
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cliente As Cliente = New Cliente()
        Dim frmMain As frmClientesMain = New frmClientesMain()
        Dim idCliente As Integer = frmMain.GetClienteID()

        If idCliente Then
            'editar
            cliente.cliente = tbxNombre.Text
            cliente.telefono = tbxTelefono.Text
            cliente.correo = tbxCorreo.Text
            clienteBll.Update(cliente, idCliente)
        Else
            'crear
            cliente.cliente = tbxNombre.Text
            cliente.telefono = tbxTelefono.Text
            cliente.correo = tbxCorreo.Text
            clienteBll.Add(cliente)
        End If

        CleanForm()
        Close()
        frmMain.ActualizarDGV()
    End Sub
End Class