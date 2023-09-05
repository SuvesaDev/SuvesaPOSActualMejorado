Imports System.Data
Public Class frmComprasPrepagadas

    Private Sub CargarComprasPagadassinAplicar()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select p.Nombre AS Proveedor, c.Factura, c.Fecha, case Preabono when 0 then TotalFactura else PreAbono end as TotalFactura, FechaPreabono as FechaRecibo, DocumentoPreabono as Documento from Compras c   INNER JOIN Proveedores p ON c.CodigoProv = p.CodigoProv   where c.FacturaCancelado = 0 and c.Prepagada = 1", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"
        Me.viewDatos.Columns("FechaRecibo").DefaultCellStyle.Format = "d"
        Me.viewDatos.Columns("TotalFactura").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("TotalFactura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub


    Private Sub frmComprasPrepagadas_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        Me.CargarComprasPagadassinAplicar()
    End Sub

    Private Sub frmComprasPrepagadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarComprasPagadassinAplicar()
    End Sub

End Class