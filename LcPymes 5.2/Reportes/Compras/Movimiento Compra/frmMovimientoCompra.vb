Imports System.Data
Public Class frmMovimientoCompra

    Private Id_Compra As String = "0"

    Private Sub BuscarCompra()
        Dim identificador As Double
        Dim Fx As New cFunciones
        identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id_Compra, (convert(Varchar, convert(Bigint,Factura,0),1) + '-' + TipoCompra)as Factura,Proveedores.nombre,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv Order by Fecha DESC", "nombre", "Fecha", "Buscar Factura de Compra"))

        If identificador = 0.0 Then ' si se dio en el boton de cancelar
            Me.Id_Compra = "0"
            Exit Sub
        End If

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select c.Factura, c.TipoCompra, p.Nombre as Proveedor from Compras c inner join Proveedores p on c.CodigoProv = p.CodigoProv where c.Id_Compra = " & identificador, dt, CadenaConexionSeePOS)
        Me.lblCompra.Text = dt.Rows(0).Item("Factura") & " - " & dt.Rows(0).Item("TipoCompra") & " - " & dt.Rows(0).Item("Proveedor")
        Me.Id_Compra = identificador

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If Me.Id_Compra <> "0" Then
            Dim rpt As New rptMovimientoCompra
            rpt.SetParameterValue(0, Me.Id_Compra)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        End If        
    End Sub

    Private Sub btnBuscarCompra_Click(sender As Object, e As EventArgs) Handles btnBuscarCompra.Click
        Me.BuscarCompra()
    End Sub
End Class