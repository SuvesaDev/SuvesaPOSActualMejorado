Imports System.Data
Public Class frmUtilidadxFactura

    Private IdFactura As Long = 0


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            If Me.lblFactura.Text <> "" Then
                Dim rpt As New rptDesmenuzarFactura
                rpt.SetParameterValue(0, Me.IdFactura)
                CrystalReportsConexion.LoadReportViewer(CrystalReportViewer1, rpt, , CadenaConexionSeePOS)
                CrystalReportViewer1.Show()
            End If
        Catch ex As Exception
        End Try        
    End Sub

    Private Sub frmReporteInventarioxProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub btnBuscarFactura_Click(sender As Object, e As EventArgs) Handles btnBuscarFactura.Click
        Dim Codigo As String
        Dim Codigos() As String
        Dim identificador As Double

        Dim Fx As New cFunciones

        Codigo = (Fx.BuscarFactura("Select Id, convert(Varchar, convert(bigint,Num_Factura,0),1) + '-' + TIPO As Factura,Nombre_Cliente AS [Nombre del Cliente],Fecha, Total as Monto  from Ventas where dbo.dateonly(fecha) = dbo.dateonly(getdate()) Order by Id DESC ", "[Nombre del Cliente]", "Fecha", "Buscar Factura de Venta", CadenaConexionSeePOS, True, True))
        If Codigo <> "" Then
            Codigos = Codigo.Split(";")
            identificador = Codigos(0)
        Else
            identificador = 0.0
            Me.IdFactura = 0
            Me.lblFactura.Text = ""
            Exit Sub
        End If

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Tipo + ' ' + (case Num_Caja when 1 then 'A' when 2 then 'B' else '' end) + CAST(Num_Factura as varchar) + '   Cliente:' + Nombre_Cliente as Factura from ventas where id = " & identificador, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.IdFactura = identificador
            Me.lblFactura.Text = dt.Rows(0).Item(0)
        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class