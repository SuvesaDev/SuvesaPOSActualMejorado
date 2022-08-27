Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing

Public Class frmPaneldeControl

    Private colorseleccionado As System.Drawing.Color = System.Drawing.Color.Orange

    Private Sub ProcesarBoton(ByRef btn As Button)
        Dim Desde, Hasta As Date

        Me.btnHoy.BackColor = System.Drawing.SystemColors.Control
        Me.btnSemana.BackColor = System.Drawing.SystemColors.Control
        Me.btnMes.BackColor = System.Drawing.SystemColors.Control
        btn.BackColor = Me.colorseleccionado

        Select Case btn.Name
            Case Me.btnHoy.Name
                Desde = Date.Now
                Hasta = Date.Now
                Me.CargarTops(Desde, Hasta)
            Case Me.btnSemana.Name
                Dim today As Date = Date.Today
                Dim dayDiff As Integer = today.DayOfWeek - DayOfWeek.Monday
                Desde = today.AddDays(-dayDiff)
                Hasta = Date.Now
                Me.CargarTops(Desde, Hasta)
            Case Me.btnMes.Name
                Desde = DateSerial(Date.Now.Year, Date.Now.Month, 1)
                Hasta = Date.Now
                Me.CargarTops(Desde, Hasta)
        End Select

    End Sub

    Private Sub CargarTops(_Desde As Date, _Hasta As Date)
        Dim dtsTopArticulo As New System.Data.DataTable
        Dim dtsTopClientes As New System.Data.DataTable
        Dim dtsTopVendedores As New System.Data.DataTable
        Dim dtsTopProveedores As New System.Data.DataTable

        Dim topArticulo As Integer = Me.txtTopArticulos.Value
        Dim topCliente As Integer = Me.txtTopCliente.Value
        Dim topVendedor As Integer = Me.txtTopVendedores.Value
        Dim topProveedor As Integer = Me.txtTopProveedores.Value

        Dim frm As New Conecta_Frm
        frm.Show("Espere porfavor", "Obteniendo datos...")

        cFunciones.Llenar_Tabla_Generico("exec spTopArticulos '" & _Desde.ToShortDateString & "', '" & _Hasta.ToShortDateString & "', " & topArticulo, dtsTopArticulo, CadenaConexionSeePOS)
        cFunciones.Llenar_Tabla_Generico("exec spTopClientes '" & _Desde.ToShortDateString & "', '" & _Hasta.ToShortDateString & "', " & topCliente, dtsTopClientes, CadenaConexionSeePOS)
        cFunciones.Llenar_Tabla_Generico("exec spTopVendedores '" & _Desde.ToShortDateString & "', '" & _Hasta.ToShortDateString & "', " & topVendedor, dtsTopVendedores, CadenaConexionSeePOS)
        cFunciones.Llenar_Tabla_Generico("exec spTopProveedores '" & _Desde.ToShortDateString & "', '" & _Hasta.ToShortDateString & "', " & topProveedor, dtsTopProveedores, CadenaConexionSeePOS)

        Me.viewTopArticulos.DataSource = dtsTopArticulo
        'Me.viewTopArticulos.Columns("Descripcion").Width = 235
        'Me.viewTopArticulos.Columns("Ventas").Width = 60
        Me.viewTopArticulos.Columns("Ventas").DefaultCellStyle.Format = "N2"
        Me.viewTopArticulos.Columns("Ventas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewTopClientes.DataSource = dtsTopClientes
        'Me.viewTopClientes.Columns("Cliente").Width = 210
        'Me.viewTopClientes.Columns("Ventas").Width = 85
        Me.viewTopClientes.Columns("Ventas").DefaultCellStyle.Format = "N2"
        Me.viewTopClientes.Columns("Ventas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewTopVendedores.DataSource = dtsTopVendedores
        'Me.viewTopVendedores.Columns("Vendedor").Width = 150
        'Me.viewTopVendedores.Columns("Facturas").Width = 60
        Me.viewTopVendedores.Columns("Facturas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'Me.viewTopVendedores.Columns("Ventas").Width = 85
        Me.viewTopVendedores.Columns("Ventas").DefaultCellStyle.Format = "N2"
        Me.viewTopVendedores.Columns("Ventas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewTopProveedores.DataSource = dtsTopProveedores
        'Me.viewTopProveedores.Columns("Proveedor").Width = 210
        'Me.viewTopProveedores.Columns("Compras").Width = 85
        Me.viewTopProveedores.Columns("Compras").DefaultCellStyle.Format = "N2"
        Me.viewTopProveedores.Columns("Compras").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        frm.Close()
    End Sub

    Private Sub CargarGrafico()
        Dim frm As New Conecta_Frm
        frm.Show("Espere porfavor", "Obteniendo datos...")

        Dim dt As New System.Data.DataTable
        Dim strSQL As String = "select year(v.Fecha) as anyo, MONTH(v.fecha) as mes, cast(month(v.fecha) as nvarchar) + '/' + cast(year(v.fecha) as nvarchar) as Fecha, sum(v.Total) as Total from ventas v where dbo.DateOnly(fecha) >=  Dateadd(MM,-10,Getdate()) group by year(v.Fecha), MONTH(v.fecha) order by anyo, mes"
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)

        For i As Integer = 0 To dt.Rows.Count - 1
            Chart1.Series(0).Points.AddXY(dt.Rows(i).Item("Fecha"), CDec(dt.Rows(i).Item("Total")))
            Chart1.Series(1).Points.AddXY(dt.Rows(i).Item("Fecha"), CDec(dt.Rows(i).Item("Total")))
            Chart1.Series(2).Points.AddXY(dt.Rows(i).Item("Fecha"), CDec(dt.Rows(i).Item("Total")))
        Next

        frm.Close()
    End Sub

    Private Sub chart1_GetToolTipText(sender As Object, e As ToolTipEventArgs) Handles Chart1.GetToolTipText
        ' Check selected chart element and set tooltip text for it
        Select Case e.HitTestResult.ChartElementType
            Case ChartElementType.DataPoint
                Dim dataPoint = e.HitTestResult.Series.Points(e.HitTestResult.PointIndex)
                e.Text = CDec(dataPoint.YValues(0)).ToString("N2")
                Exit Select
        End Select
    End Sub

    Private Sub btnMes_Click(sender As Object, e As EventArgs) Handles btnSemana.Click, btnMes.Click, btnHoy.Click
        Me.ProcesarBoton(sender)
    End Sub

    Private Sub frmPaneldeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProcesarBoton(Me.btnHoy)
        Me.CargarGrafico()
    End Sub

End Class