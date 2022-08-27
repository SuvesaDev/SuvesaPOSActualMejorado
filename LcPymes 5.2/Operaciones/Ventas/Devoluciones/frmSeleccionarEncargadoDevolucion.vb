Imports System.Data
Public Class frmSeleccionarEncargadoDevolucion

    Private Sub CargarUsuarios()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select cedula, nombre from usuarios order by nombre", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.cboEncargado.DataSource = dt
            Me.cboEncargado.DisplayMember = "Nombre"
        End If
    End Sub

    Private Sub frmSeleccionarEncargadoDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarUsuarios()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtNotasDevolucion.Text.Trim <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Debe ingresar una Observacion.", MsgBoxStyle.Exclamation, Text)
        End If
    End Sub

    Private Sub btnRefacturacion_Click(sender As Object, e As EventArgs) Handles btnRefacturacion.Click
        Me.txtNotasDevolucion.Text += "Devolucion por Refacturacion." & vbNewLine
    End Sub

    Private Sub btnSinExistencia_Click(sender As Object, e As EventArgs) Handles btnSinExistencia.Click
        Me.txtNotasDevolucion.Text += "Devolucion por Falta de Existencias." & vbNewLine
    End Sub

    Private Sub btnCambio_Click(sender As Object, e As EventArgs) Handles btnCambio.Click
        Me.txtNotasDevolucion.Text += "Devolucion por Cambio de producto." & vbNewLine
    End Sub
End Class