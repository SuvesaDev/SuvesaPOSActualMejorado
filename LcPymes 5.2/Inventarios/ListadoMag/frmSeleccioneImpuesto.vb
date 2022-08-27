Imports System.Data
Public Class frmSeleccioneImpuesto

    Private Sub CargarImpuestos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Impuesto, Impuesto from viewimpuestos", dt, CadenaConexionSeePOS)
        Me.cboImpuesto.DataSource = dt
        Me.cboImpuesto.DisplayMember = "Impuesto"
        Me.cboImpuesto.ValueMember = "Id_Impuesto"
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmSeleccioneImpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarImpuestos()
    End Sub

End Class
