Imports System.Data

Public Class frmMovimientosAnticipos

    Private Sub frmMovimientosAnticipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.dtpDesde.Value = Date.Now
        Me.dtpHasta.Value = Date.Now
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try
            If CodProveedor <> "0" Then
                Dim Reporte As New rptMovimientoAnticipo
                Reporte.Refresh()
                Reporte.SetParameterValue(0, CodProveedor)
                Reporte.SetParameterValue(1, Me.dtpDesde.Value)
                Reporte.SetParameterValue(2, Me.dtpHasta.Value)
                CrystalReportsConexion.LoadReportViewer(Me.VisorReporte, Reporte)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Dim CodProveedor As String = "0"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim Fx As New cFunciones
        Dim valor As String
        valor = Fx.BuscarDatos("Select Identificacion,Nombre from Clientes", "Nombre", "Buscar Proveedor...")
        If valor = "" Then
            Me.CodProveedor = "0"
            Me.lblProveedor.Text = ""
        Else
            cFunciones.Llenar_Tabla_Generico("select Identificacion, Nombre from Clientes where Identificacion = " & valor, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.CodProveedor = dt.Rows(0).Item("Identificacion")
                Me.lblProveedor.Text = dt.Rows(0).Item("Nombre")
            End If
        End If
    End Sub
End Class