Imports BLL
Imports Entity
Public Class frmAddCliente
    Public idCliente As Integer = 0
    Private Sub frmAddCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idCliente <> 0 Then
            tbxCorreo.ReadOnly = True
            lblTituloCliente.Text = "Editar Perfil"
        Else
            lblTituloCliente.Text = "Crear Cuenta"
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim clienteBll As Cliente_BLL = New Cliente_BLL()
        Dim cliente As New Cliente()
        cliente.cliente = tbxNombre.Text
        cliente.telefono = tbxTelefono.Text
        cliente.correo = tbxCorreo.Text

        If idCliente <> 0 Then
            clienteBll.Update(cliente, idCliente)
            frmPerfilCliente.SetCliente(cliente)
            frmListaProductos.SetCliente(cliente)
            frmPerfilCliente.ActualizarPerfil()
            MessageBox.Show("Se edito un cliente con exito")
        Else
            clienteBll.Add(cliente)
            MessageBox.Show("Se agrego un cliente con exito")
        End If

        idCliente = 0
        CleanForm()
        Close()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        idCliente = 0
        CleanForm()
        Close()
    End Sub
    Public Sub SetTxt(nombre As String, telefono As String, correo As String)
        tbxNombre.Text = nombre
        tbxTelefono.Text = telefono
        tbxCorreo.Text = correo
    End Sub

    Private Sub CleanForm()
        tbxNombre.Text = " "
        tbxTelefono.Text = " "
        tbxCorreo.Text = " "
    End Sub

End Class