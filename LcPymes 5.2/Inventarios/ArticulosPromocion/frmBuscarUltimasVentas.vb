Imports System.Data

Public Class frmBuscarUltimasVentas

    Public Codigo As String = ""

    Private Sub CargarVentas()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select top 50 v.Num_Factura, v.Tipo, v.Nombre_Cliente, v.Fecha, vd.Cantidad  from Ventas v inner join ventas_detalle vd on v.id = vd.id_factura where vd.codigo = " & Me.Codigo & " and dbo.dateonly(v.Fecha) >= dbo.dateonly('" & Me.dtpDesde.Value & "') and dbo.dateonly(v.Fecha) <= dbo.dateonly('" & Me.dtpHasta.Value & "') order by v.fecha desc", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.CargarVentas()
    End Sub
End Class