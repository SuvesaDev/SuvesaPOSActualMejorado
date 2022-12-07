Imports System.Data

Public Class frmPaneldeControl


    Private Sub TopArticulos(_Desde As DateTime, _Hasta As DateTime)
        Dim dtsVendidos As New DataTable
        Dim dtsUtilidad As New DataTable
        Dim dtsRentabilidad As New DataTable

        Dim Desde As DateTime
        Dim Hasta As DateTime

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Try
            Desde = Date.Now
            db.AddParametro("@Desde", Me.dtpDesde.Value)
            db.AddParametro("@Hasta", Me.dtpHasta.Value)
            db.Ejecutar("usp_TopArticulos_Vendidos", dtsVendidos)
            Hasta = Date.Now
            Me.lbl01.Text = label1 & " (segundos:" & DateDiff(DateInterval.Second, Desde, Hasta).ToString & ") "

            Me.viewArticulosVendidos.DataSource = dtsVendidos
            Me.viewArticulosVendidos.Columns("CodArticulo").Visible = False
            Me.viewArticulosVendidos.Columns("Vendidos").DefaultCellStyle.Format = "N2"
            Me.viewArticulosVendidos.Columns("Vendidos").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewArticulosVendidos.Columns("Vendidos").Width = 85
            Me.viewArticulosVendidos.Columns("Descripcion").Width = 200
        Catch ex As Exception
        End Try

        Try
            Desde = Date.Now
            db.AddParametro("@Desde", Me.dtpDesde.Value)
            db.AddParametro("@Hasta", Me.dtpHasta.Value)
            db.Ejecutar("usp_TopArticulos_Utilidad", dtsUtilidad)
            Hasta = Date.Now
            Me.lbl02.Text = label2 & " (segundos:" & DateDiff(DateInterval.Second, Desde, Hasta).ToString & ") "
            Me.viewArticulosUtilidad.DataSource = dtsUtilidad
            Me.viewArticulosUtilidad.Columns("CodArticulo").Visible = False
            Me.viewArticulosUtilidad.Columns("Utilidad").DefaultCellStyle.Format = "N2"
            Me.viewArticulosUtilidad.Columns("Utilidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewArticulosUtilidad.Columns("Utilidad").Width = 85
            Me.viewArticulosUtilidad.Columns("Descripcion").Width = 200
        Catch ex As Exception
        End Try

        Try
            Desde = Date.Now
            db.AddParametro("@Desde", Me.dtpDesde.Value)
            db.AddParametro("@Hasta", Me.dtpHasta.Value)
            db.Ejecutar("usp_TopArticulos_Rentabilidad", dtsRentabilidad)

            'cFunciones.Llenar_Tabla_Generico("exec usp_TopArticulos_Rentabilidad '" & Me.dtpDesde.Value.ToShortDateString & "','" & Me.dtpHasta.Value.ToShortDateString & "'", dtsRentabilidad, CadenaConexionSeePOS)

            Hasta = Date.Now
            Me.lbl03.Text = label3 & " (segundos:" & DateDiff(DateInterval.Second, Desde, Hasta).ToString & ") "
            Me.viewArticulosRentabilidad.DataSource = dtsRentabilidad
            Me.viewArticulosRentabilidad.Columns("CodArticulo").Visible = False
            Me.viewArticulosRentabilidad.Columns("Rentabilidad").DefaultCellStyle.Format = "N2"
            Me.viewArticulosRentabilidad.Columns("Rentabilidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewArticulosRentabilidad.Columns("Rentabilidad").Width = 85
            Me.viewArticulosRentabilidad.Columns("Descripcion").Width = 200
        Catch ex As Exception
        End Try

    End Sub

    Private Sub TopClientes(_Desde As DateTime, _Hasta As DateTime)
        Dim dtsVentas As New DataTable
        Dim dtsVisitas As New DataTable
        Dim dtsRentabilidad As New DataTable

        Dim Desde As DateTime
        Dim Hasta As DateTime

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS, 200)
        Try
            Desde = Date.Now
            db.AddParametro("@Desde", Me.dtpDesde.Value)
            db.AddParametro("@Hasta", Me.dtpHasta.Value)
            dtsVentas = db.Ejecutar("usp_TopClientes_Ventas")
            Hasta = Date.Now
            Me.lbl04.Text = label4 & " (segundos:" & DateDiff(DateInterval.Second, Desde, Hasta).ToString & ") "
            Me.viewClientesVentas.DataSource = dtsVentas
            Me.viewClientesVentas.Columns("Cod_Cliente").Visible = False
            Me.viewClientesVentas.Columns("Ventas").DefaultCellStyle.Format = "N2"
            Me.viewClientesVentas.Columns("Ventas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewClientesVentas.Columns("Ventas").Width = 85
            Me.viewClientesVentas.Columns("Nombre_Cliente").Width = 200
            Me.viewClientesVentas.Columns("Nombre_Cliente").HeaderText = "Cliente"
        Catch ex As Exception
        End Try

        Try
            Desde = Date.Now
            db.AddParametro("@Desde", Me.dtpDesde.Value)
            db.AddParametro("@Hasta", Me.dtpHasta.Value)
            dtsVisitas = db.Ejecutar("usp_TopClientes_Visitas")
            Hasta = Date.Now
            Me.lbl05.Text = label5 & " (segundos:" & DateDiff(DateInterval.Second, Desde, Hasta).ToString & ") "
            Me.viewClientesVisitas.DataSource = dtsVisitas
            Me.viewClientesVisitas.Columns("Cod_Cliente").Visible = False
            Me.viewClientesVisitas.Columns("Visitas").DefaultCellStyle.Format = "N2"
            Me.viewClientesVisitas.Columns("Visitas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewClientesVisitas.Columns("Visitas").Width = 85
            Me.viewClientesVisitas.Columns("Nombre_Cliente").Width = 200
            Me.viewClientesVisitas.Columns("Nombre_Cliente").HeaderText = "Cliente"
        Catch ex As Exception
        End Try

        Try
            Desde = Date.Now
            db.AddParametro("@Desde", Me.dtpDesde.Value)
            db.AddParametro("@Hasta", Me.dtpHasta.Value)
            dtsRentabilidad = db.Ejecutar("usp_TopClientes_Rentabilidad")
            Hasta = Date.Now
            Me.lbl06.Text = label6 & " (segundos:" & DateDiff(DateInterval.Second, Desde, Hasta).ToString & ") "
            Me.viewClienteRentabilidad.DataSource = dtsRentabilidad
            Me.viewClienteRentabilidad.Columns("Cod_Cliente").Visible = False
            Me.viewClienteRentabilidad.Columns("Rentabilidad").DefaultCellStyle.Format = "N2"
            Me.viewClienteRentabilidad.Columns("Rentabilidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.viewClienteRentabilidad.Columns("Rentabilidad").Width = 85
            Me.viewClienteRentabilidad.Columns("Nombre_Cliente").Width = 200
            Me.viewClienteRentabilidad.Columns("Nombre_Cliente").HeaderText = "Cliente"
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.viewArticulosVendidos.DataSource = Nothing
        Me.viewArticulosUtilidad.DataSource = Nothing
        Me.viewArticulosRentabilidad.DataSource = Nothing

        Me.viewClienteRentabilidad.DataSource = Nothing
        Me.viewClientesVentas.DataSource = Nothing
        Me.viewClientesVisitas.DataSource = Nothing


        Me.TopArticulos(Me.dtpDesde.Value, Me.dtpHasta.Value)
        Me.TopClientes(Me.dtpDesde.Value, Me.dtpHasta.Value)

    End Sub

    Private label1 As String
    Private label2 As String
    Private label3 As String
    Private label4 As String
    Private label5 As String
    Private label6 As String
    Private Sub frmPaneldeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.label1 = Me.lbl01.Text
        Me.label2 = Me.lbl02.Text
        Me.label3 = Me.lbl03.Text
        Me.label4 = Me.lbl04.Text
        Me.label5 = Me.lbl05.Text
        Me.label6 = Me.lbl06.Text
    End Sub
End Class

Public Class ReporteTop
    Public Property Descripcion As String = ""
    Public Property Valor As Long = 0
    Sub New(_descripcion As String, _valor As Long)
        Me.Descripcion = _descripcion
        Me.Valor = _valor
    End Sub
End Class