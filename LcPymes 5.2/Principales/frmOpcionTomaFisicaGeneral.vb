Imports System.Data
Public Class frmOpcionTomaFisicaGeneral

    Private Sub CargarUbicaciones()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Codigo, Descripcion from Ubicaciones where Activa = 1", dt, CadenaConexionSeePOS)
        Me.cboUbicacion.DataSource = dt
        Me.cboUbicacion.DisplayMember = "Descripcion"
        Me.cboUbicacion.ValueMember = "Codigo"
    End Sub

    Private Sub frmOpcionTomaFisicaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarUbicaciones()
    End Sub

    Private Sub rbUbicacion_CheckedChanged(sender As Object, e As EventArgs) Handles rbUbicacion.CheckedChanged
        Me.cboUbicacion.Enabled = rbUbicacion.Checked
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class