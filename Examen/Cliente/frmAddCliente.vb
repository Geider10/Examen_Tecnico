﻿Imports BLL
Imports Entity
Public Class frmAddCliente
    Private clienteBll As Cliente_BLL = New Cliente_BLL()
    Public idCliente As Integer = 0

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        idCliente = 0
        CleanForm()
        Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim cliente = New Cliente()
        cliente.cliente = tbxNombre.Text
        cliente.telefono = tbxTelefono.Text
        cliente.correo = tbxCorreo.Text

        If idCliente <> 0 Then
            clienteBll.Update(cliente, idCliente)
            MessageBox.Show("Se edito un cliente, Id: " + idCliente.ToString())
        Else
            clienteBll.Add(cliente)
            MessageBox.Show("Se agrego un cliente")
        End If

        idCliente = 0
        CleanForm()
        Close()
        ActualizarFrmMain()
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

    Private Sub ActualizarFrmMain()
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is frmClientesMain Then
                DirectCast(frm, frmClientesMain).ActualizarDGV()
            End If
        Next
    End Sub

    Private Sub frmAddCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class