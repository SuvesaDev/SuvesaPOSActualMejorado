Imports System.Data
Public Class frmIngreseTokenValidacion
    Public Property IdUsuario As String = ""
    Public Property Codigo As String = ""

    Private Sub SolicitarPermisoVentaNegativo()
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@IdUsuarioSolicita", Me.IdUsuario)
        db.AddParametro("@Codigo", Me.Codigo)
        db.Ejecutar("spSolicitarTokenVentaNegativa")
    End Sub

    Private Function ValidaToken() As Boolean
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim dt As New DataTable
        db.AddParametro("@IdUsuarioSolicita", Me.IdUsuario)
        db.AddParametro("@Codigo", Me.Codigo)
        db.AddParametro("@Token", Me.txtClave.Text)
        dt = db.Ejecutar("spConsultaToken")
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        If Me.txtClave.Text <> "" Then Me.btnAceptar.Enabled = Me.ValidaToken
    End Sub

    Private Sub btnSolicitarPermiso_Click(sender As Object, e As EventArgs) Handles btnSolicitarPermiso.Click
        Me.SolicitarPermisoVentaNegativo()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class