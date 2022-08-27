Imports System.Data

Namespace Credomatic
    Namespace Operaciones
        Public Class frmConsultaVoucher
            Private ImprimeCredomatic As Boolean = False

            Private Sub AnularLog(_Autorizacion As String, _Referencia As String)
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update Log set Anulado = 1 Where TipoTransaccion = 'SALE' And Autorizacion = '" & _Autorizacion & "' and Referencia = '" & _Referencia & "'", CommandType.Text)
                General.LimpiarLogAnulacion()
            End Sub

            Private Function PuedeAnular(_Autorizacion As String, _Referencia As String) As Boolean
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select Anulado From Log Where TipoTransaccion = 'SALE' And Autorizacion = '" & _Autorizacion & "' and Referencia = '" & _Referencia & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("Anulado") = False Then
                        Return True
                    Else
                        Return False
                    End If
                End If
                Return False
            End Function

            Private Sub AnularOperacion()
                Dim Autorizacion As String = Me.ViewDatos.Item("Autorizacion", Me.ViewDatos.CurrentRow.Index).Value
                Dim Referencia As String = Me.ViewDatos.Item("Referencia", Me.ViewDatos.CurrentRow.Index).Value

                If Me.PuedeAnular(Autorizacion, Referencia) = True Then
                    Dim frm As New frmVersionCompleta
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim cls As New Credomatic.Operaciones.Operaciones
                        Dim respuesta As Credomatic.Operaciones.Respuesta = cls.Anulacion(Autorizacion, Referencia)
                        If respuesta.Codigo = "00" Then
                            Me.AnularLog(Autorizacion, Referencia)
                        End If
                    End If
                End If
            End Sub

            Private Sub ReimprimirOperacion()
                Dim cls As New Credomatic.Operaciones.Operaciones
                Dim IdTransaccion As String = Me.ViewDatos.Item("IdTransaccion", Me.ViewDatos.CurrentRow.Index).Value
                If Me.ImprimeCredomatic = True Then
                    Dim respuesta As Credomatic.Operaciones.Respuesta = cls.Reimprecion(IdTransaccion)
                Else
                    Dim dt As New DataTable
                    cFunciones.Llenar_Tabla_Generico("Select Id,IdTerminal,Fecha,TipoTransaccion,Factura,Monto,CodigoRespueta,DescripcionRespuesta,Autorizacion,Referencia,IdTransaccion,TituloTag,Tags, NumeroTarjeta from Log where IdTransaccion = '" & IdTransaccion & "'", dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Dim log As Credomatic.Operaciones.Log
                        log = New Credomatic.Operaciones.Log(dt.Rows(0).Item("IdTerminal"), CDate(dt.Rows(0).Item("Fecha")), dt.Rows(0).Item("TipoTransaccion"), dt.Rows(0).Item("Factura"), dt.Rows(0).Item("Monto"), dt.Rows(0).Item("CodigoRespueta"), dt.Rows(0).Item("DescripcionRespuesta"), dt.Rows(0).Item("Autorizacion"), dt.Rows(0).Item("Referencia"), dt.Rows(0).Item("IdTransaccion"), dt.Rows(0).Item("TituloTag"), dt.Rows(0).Item("Tags"), dt.Rows(0).Item("NumeroTarjeta"))
                        cls.ImprimirVoucher(log)
                    End If
                End If
            End Sub
            Private Sub CargarOperaciones()
                Try
                    Dim terminal As New Credomatic.Configuracion.Terminal
                    Dim strSQL As String = "select IdTransaccion, IdTerminal, Fecha, TipoTransaccion, Monto, Autorizacion, Referencia from log"
                    Dim strWhere As String = " Where IdTerminal = '" & terminal.Terminal & "' And dbo.DateOnly(fecha) >= '" & Me.dtpDesde.Value.ToShortDateString & "' And dbo.DateOnly(Fecha) <= '" & Me.dtpHasta.Value.ToShortDateString & "'  And (Autorizacion like '%" & Me.txtBuscar.Text & "%' or Referencia = '%" & Me.txtBuscar.Text & "%')"
                    Dim dt As New DataTable
                    cFunciones.Llenar_Tabla_Generico(strSQL & strWhere, dt, CadenaConexionSeePOS)
                    Me.ViewDatos.DataSource = dt
                    Me.ViewDatos.Columns("Monto").DefaultCellStyle.Format = "N2"
                    Me.ViewDatos.Columns("Monto").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                Catch ex As Exception
                End Try
            End Sub
            Private Sub frmConsultaVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Me.CargarOperaciones()
            End Sub
            Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
                Me.CargarOperaciones()
            End Sub
            Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
                Me.ReimprimirOperacion()
            End Sub
            Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
                Me.AnularOperacion()
            End Sub
        End Class
    End Namespace
End Namespace
