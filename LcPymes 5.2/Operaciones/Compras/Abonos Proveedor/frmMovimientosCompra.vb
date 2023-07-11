Public Class frmMovimientosCompra

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim identificador As Double

        Dim Fx As New cFunciones

        identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id_Compra, (convert(Varchar, convert(Bigint,Factura,0),1) + '-' + TipoCompra)as Factura,Proveedores.nombre,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv Order by Fecha DESC", "nombre", "Fecha", "Buscar Factura de Compra"))

        If identificador = 0.0 Then

        Else
            Dim rpt As New rptMovimientosCompra
            rpt.SetParameterValue(0, identificador)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If

    End Sub

    Private Sub frmMovimientosCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class