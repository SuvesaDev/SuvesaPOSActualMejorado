Imports System.Data
Public Class frmBuscarPretomaGeneral
    Public SoloActivas As Boolean = False

    Private Sub CargarTomas()
        Dim dt As New DataTable
        If Me.SoloActivas = False Then
            cFunciones.Llenar_Tabla_Generico("Select * from pretomageneral Where Encargado like '%" & Me.TextBox1.Text & "%'", dt, CadenaConexionSeePOS)
        Else
            cFunciones.Llenar_Tabla_Generico("Select * from pretomageneral Where Encargado like '%" & Me.TextBox1.Text & "%' And Aplicado = 0 and Anulado = 0", dt, CadenaConexionSeePOS)
        End If
        Me.viewDatos.DataSource = dt
    End Sub
    Private Sub frmBuscarPretomaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarTomas()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.CargarTomas()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class