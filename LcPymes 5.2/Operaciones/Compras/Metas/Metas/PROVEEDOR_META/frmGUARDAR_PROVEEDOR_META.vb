Imports System.Data
Public Class frmGUARDAR_PROVEEDOR_META
    Private seterror As New ErrorProvider
    Public ID_PROVEEDOR_META As Integer
    Public vCODIGOPROV As Integer
    Public ANULADO As Integer

    Private Sub CargarDatos(ByVal _id As String)
        Try
            Dim cls As New PROVEEDOR_META
            Dim dt As New DataTable

            dt = cls.GET_PROVEEDOR_META(_id)
            Me.ID_PROVEEDOR_META = dt.Rows(0).Item("ID_PROVEEDOR_META")
            Me.vCODIGOPROV = dt.Rows(0).Item("CODIGOPROV")
            Me.txtCODIGOPROV.Text = dt.Rows(0).Item("CODIGOPROV")
            Me.txtMENSUAL.Text = dt.Rows(0).Item("MENSUAL")
            Me.dtpFECHA.Value = dt.Rows(0).Item("FECHA")
            Me.ANULADO = dt.Rows(0).Item("ANULADO")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Function PasaValidacion() As Boolean
        Dim pasa As Boolean = True
        If Me.txtMENSUAL.Text = "" Then
            seterror.SetError(Me.txtMENSUAL, "Debe ingresar un valor para este campo!!!")
            pasa = False
        Else
            seterror.SetError(Me.txtMENSUAL, "")
        End If
        Return pasa
    End Function

    Private Sub Buscar_CODIGOPROV()
        Dim frm As New frmBUSCAR_PROVEEDOR
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.vCODIGOPROV = frm.viewDatos("CODIGOPROV", frm.viewDatos.CurrentRow.Index).Value
            Me.txtCODIGOPROV.Text = frm.viewDatos("NOMBRE", frm.viewDatos.CurrentRow.Index).Value
            Me.ErrorProvider1.SetError(Me.txtCODIGOPROV, "")
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Me.Buscar_CODIGOPROV()
    End Sub
    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.ID_PROVEEDOR_META > 0 Then Me.CargarDatos(ID_PROVEEDOR_META)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Siguiente(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCODIGOPROV.KeyDown, txtMENSUAL.KeyDown, dtpFECHA.KeyDown
        If e.KeyCode = Keys.Enter And sender.Text <> "" Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.PasaValidacion = False Then
            MsgBox("Faltan datos por ingresar!!!", MsgBoxStyle.Exclamation, Text)
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class
