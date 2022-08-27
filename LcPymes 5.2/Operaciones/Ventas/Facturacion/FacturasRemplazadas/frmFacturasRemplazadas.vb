Imports System.Data
Public Class frmFacturasRemplazadas

    Private Sub CargarDatos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select v.Fecha as FechaOriginal, v.Tipo as TipoOriginal, v.Num_Factura as FacturaOriginal, v.Nombre_Cliente as ClienteOriginal, v.Total as TotalOriginal, r.Fecha, r.Tipo, r.Num_Factura as Factura, r.Nombre_Cliente as Cliente, r.Total from ventas v inner join ventas r on v.id = r.Id_FacturaRemplaza where dbo.DateOnly(r.fecha) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.DateOnly(r.fecha) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt

        Me.viewDatos.Columns("FechaOriginal").HeaderText = "Fecha Original"
        Me.viewDatos.Columns("Fecha").HeaderText = "Fecha Remplazo"

        Me.viewDatos.Columns("TipoOriginal").HeaderText = "Tipo Original"
        Me.viewDatos.Columns("Tipo").HeaderText = "Tipo Remplazo"

        Me.viewDatos.Columns("FacturaOriginal").HeaderText = "Factura Original"
        Me.viewDatos.Columns("Factura").HeaderText = "Factura Remplazo"

        Me.viewDatos.Columns("ClienteOriginal").HeaderText = "Cliente Original"
        Me.viewDatos.Columns("Cliente").HeaderText = "Cliente Remplazo"

        Me.viewDatos.Columns("TotalOriginal").HeaderText = "Total Original"
        Me.viewDatos.Columns("Total").HeaderText = "Total Remplazo"

        Me.viewDatos.Columns("FechaOriginal").DefaultCellStyle.Format = "d"
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"

        Me.viewDatos.Columns("TotalOriginal").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("Total").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("TotalOriginal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.CargarDatos()
    End Sub
End Class