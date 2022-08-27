Imports System.Data
Public Class frmCrearLote

    Private Index As Integer = 0

    Public Property Descripcion() As String
        Get
            Return Me.lblDescripcion.Text
        End Get
        Set(ByVal value As String)
            Me.lblDescripcion.Text = value
        End Set
    End Property

    Public Property Barras() As String
        Get
            Return Me.txtBarras.Text
        End Get
        Set(ByVal value As String)
            Me.txtBarras.Text = value
        End Set
    End Property

    Public Property Presentacion As String

    Public Sub Agregar(_Id As Integer, _Lote As String, _Vence As Date, _Cantidad As Decimal, _CantidadImprimir As Decimal, _Barras As String)
        Me.viewDatos.Rows.Add()
        Me.viewDatos.Item("cId", Me.Index).Value = _Id
        Me.viewDatos.Item("cLote", Me.Index).Value = _Lote
        Me.viewDatos.Item("cBarras", Me.Index).Value = _Barras
        Me.viewDatos.Item("cVence", Me.Index).Value = _Vence
        Me.viewDatos.Item("cCantidad", Me.Index).Value = _Cantidad
        Me.viewDatos.Item("cCantidadImprimir", Me.Index).Value = _CantidadImprimir
        Me.Index += 1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.txtCantidad.Text <> "" Then
            If IsNumeric(Me.txtCantidad.Text) = True Then
                If CDec(Me.txtCantidad.Text) > 0 Then
                    If Me.txtLote.Text <> "" Then

                        Dim dt As New DataTable
                        cFunciones.Llenar_Tabla_Generico("select * from ControlLotes where barras = '" & Me.txtBarras.Text & "'", dt, CadenaConexionSeePOS)
                        If dt.Rows.Count > 0 Then
                            MsgBox("Ya existe un lote con el mismo codigo de barras", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                            Exit Sub
                        End If

                        Me.Agregar(0, Me.txtLote.Text, Me.dtpVence.Value, Me.txtCantidad.Text, Me.txtImprimir.Text, Me.txtBarras.Text)
                        Me.txtLote.Text = ""
                        Me.txtBarras.Text = ""
                        Me.dtpVence.Value = Date.Now
                        Me.txtCantidad.Text = "0"
                    End If
                End If
            End If
        End If
    End Sub

    Private Function NumeroRandom() As String
        Dim Generator As System.Random = New System.Random()
        Return CStr(Generator.Next(0, 999999).ToString).PadLeft(6, "0")
    End Function

    Private Function GenerarCodigoBarras() As String
        Dim Codigo As String = ""
        Dim hora, minuto, segundo, Ramdom As String
        hora = Date.Now.Hour.ToString.PadLeft(2, "0")
        minuto = Date.Now.Minute.ToString.PadLeft(2, "0")
        segundo = Date.Now.Second.ToString.PadLeft(2, "0")
        Codigo = "1" + hora + minuto + segundo + Me.NumeroRandom
        Return Codigo
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub viewDatos_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles viewDatos.UserDeletedRow
        Me.Index -= 1
    End Sub

    Private Sub txtBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarras.KeyDown
        If e.KeyCode = Keys.F3 And Me.txtBarras.Text = "" Then
            Me.txtBarras.Text = Me.GenerarCodigoBarras
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Me.txtImprimir.Text = Me.txtCantidad.Text
    End Sub

End Class