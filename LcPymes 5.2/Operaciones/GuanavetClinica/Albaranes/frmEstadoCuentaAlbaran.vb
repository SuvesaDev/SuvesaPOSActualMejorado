Imports System.Data
Public Class frmEstadoCuentaAlbaran

    Private Identificacion As String = "0"

    Private Function CargarSaldoPrepago(_Identificacion As String) As Decimal
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select IsNull(Sum(debitos - creditos),0) as Saldo from viewMovimientosPrepagos where identificacion = " & _Identificacion, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Saldo")
        Else
            Return 0
        End If
    End Function


    Private Sub txtIdentificacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdentificacion.KeyDown
        Dim dt As New DataTable

        Select Case e.KeyCode

            Case Windows.Forms.Keys.Enter

                cFunciones.Llenar_Tabla_Generico("select Identificacion, Nombre from Clientes where Identificacion = " & Me.txtIdentificacion.Text & " or Cedula = '" & Me.txtIdentificacion.Text & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.Identificacion = dt.Rows(0).Item("Identificacion")
                    Me.txtIdentificacion.Text = dt.Rows(0).Item("Identificacion")
                    Me.lblNombre.Text = dt.Rows(0).Item("Nombre")
                    Me.lblAnticipos.Text = Me.CargarSaldoPrepago(Me.Identificacion)
                End If

            Case Windows.Forms.Keys.F1
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("select Identificacion, Nombre from Clientes", "Nombre", "Buscar Cliente...")
                If valor = "" Then
                    Me.Identificacion = "0"
                    Me.txtIdentificacion.Text = ""
                    Me.lblNombre.Text = ""
                Else
                    cFunciones.Llenar_Tabla_Generico("select Identificacion, Nombre from Clientes where Identificacion = " & valor & " or Cedula = '" & valor & "'", dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.Identificacion = dt.Rows(0).Item("Identificacion")
                        Me.txtIdentificacion.Text = dt.Rows(0).Item("Identificacion")
                        Me.lblNombre.Text = dt.Rows(0).Item("Nombre")
                        Me.lblAnticipos.Text = Me.CargarSaldoPrepago(Me.Identificacion)
                    End If
                End If
        End Select
    End Sub

    Private Sub frmEstadoCuentaAlbaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New rptCuentaAlbaran
        rpt.SetParameterValue(0, Me.txtIdentificacion.Text)
        rpt.SetParameterValue(1, Me.lblAnticipos.Text)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
        VisorReporte.Show()
    End Sub

End Class