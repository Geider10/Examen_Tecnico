﻿Public Class frmClientesMain
    Private Sub btnAtrasCliente_Click(sender As Object, e As EventArgs) Handles btnAtrasCliente.Click
        Close()
    End Sub

    Private Sub frmClientesMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        frmAddCliente.ShowDialog()
    End Sub

End Class