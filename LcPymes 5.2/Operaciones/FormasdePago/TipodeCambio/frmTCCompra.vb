Imports System.Data
Public Class frmTCCompra
    Private Function getTipocambio() As Decimal
        Dim TipoCambio As Decimal = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select TCCompra from moneda where codmoneda = 2", dt, CadenaConexionSeguridad)
        If dt.Rows.Count > 0 Then
            TipoCambio = dt.Rows(0).Item("TCCompra")
        End If
        Return TipoCambio
    End Function

    Private Sub SalvarTipoCambio()
        If Me.txtTipoCambio.Text <> "" Then
            If IsNumeric(Me.txtTipoCambio.Text) = True Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.AddParametro("@TCCompraNew", CDec(Me.txtTipoCambio.Text))
                db.Ejecutar("spCambiaTCCompra", CommandType.StoredProcedure)
                'db.Ejecutar("Update moneda set TCCompra = " & Me.txtTipoCambio.Text & " Where CodMoneda = 2", CommandType.Text)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmTipoCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtTipoCambio.Text = Me.getTipocambio
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.SalvarTipoCambio()
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        Try
            If e.KeyCode = Windows.Forms.Keys.Enter And Me.txtClave.Text <> "" Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("select Nombre from SeePOS.dbo.Usuarios where Clave_Interna ='" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
                    Me.btnAceptar.Enabled = True
                Else
                    Me.btnAceptar.Enabled = False
                    Me.txtUsuario.Text = ""
                End If
            End If
        Catch ex As Exception
            Me.btnAceptar.Enabled = False
            Me.txtUsuario.Text = ""
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.close()
    End Sub
End Class