﻿Imports System.Data
Public Class frmBuscarTomaGeneral
    Private Sub CargarTomas()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from tomageneral", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("NumeroAjuste").Visible = False
    End Sub
    Private Sub frmBuscarPretomaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarTomas()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Me.CargarTomas()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class