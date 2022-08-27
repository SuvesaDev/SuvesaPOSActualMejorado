Imports System.Data
Public Class frmCargarPreTomaGeneral
    Public ListaPretomas As String = ""
    Private Sub CargarTomas()
        Dim dt As New DataTable
        Dim ListaExcluir As String = ""
        If ListaPretomas = "" Then
            ListaExcluir = ""
        Else
            ListaExcluir = "And IdPreToma not in(" & Me.ListaPretomas & ")"
        End If
        cFunciones.Llenar_Tabla_Generico("Select cast(0 as bit) as Usar, * from pretomageneral Where Aplicado = 0 and Anulado = 0 " & ListaExcluir, dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        For Each c As DataGridViewColumn In Me.viewDatos.Columns
            If c.Name <> "Usar" Then
                c.ReadOnly = True
            End If
        Next
    End Sub
    Private Sub frmBuscarPretomaGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarTomas()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class