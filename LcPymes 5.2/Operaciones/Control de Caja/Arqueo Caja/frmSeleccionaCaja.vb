Imports System.Data
Public Class frmSeleccionaCaja
    Public CedulaUsuario As String = ""
    Private Sub CargarCajas()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT Napertura, Fecha, Nombre as Usuario, Estado, Num_Caja FROM AperturaCaja WHERE (Anulado = 0) AND (Estado = 'A' or Estado = 'B') and cedula= '" & Me.CedulaUsuario & "' ", dt, CadenaConexionSeePOS)
        Me.viewCajas.DataSource = dt
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmSeleccionaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCajas()
    End Sub

End Class