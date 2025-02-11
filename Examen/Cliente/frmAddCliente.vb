Public Class frmAddCliente
    Private Sub CleanForm()
        tbxNombre.Text = " "
        tbxTelefono.Text = " "
        tbxCorreo.Text = " "

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CleanForm()
        Close()
    End Sub
End Class