Imports System.Data
Public Class frmMovimientoInventario

    Private Sub Antes()
        Dim dt As New DataTable
        Dim Codigo As String = Me.CodigoInterno
        cFunciones.Llenar_Tabla_Generico("select Fecha, Tipo, Descripcion, Documento, Cantidad, Observaciones from kardex where Codigo = " & Codigo & " and dbo.dateonly(fecha) >= '" & Me.dtpDesde.Value.ToShortDateString & "' and dbo.dateonly(fecha) <= '" & Me.dtpHasta.Value.ToShortDateString & "' Order by Fecha", dt, CadenaConexionSeePOS)
        Me.viewMovimientos.DataSource = dt
        Me.viewMovimientos.Columns("Fecha").DefaultCellStyle.Format = "d"
        Me.viewMovimientos.Columns("Cantidad").DefaultCellStyle.Format = "N2"
        Me.viewMovimientos.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewMovimientos.Columns("Documento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.Cuenta()
    End Sub

    Private Sub btnBuscarMovimientos_Click(sender As Object, e As EventArgs) Handles btnBuscarMovimientos.Click
        Dim dt As New DataTable
        Dim Codigo As String = Me.CodigoInterno
        cFunciones.Llenar_Tabla_Generico("select devolucion, FechaDevolucion, Num_Factura, Descripcion, Cantidad, CantVet, CantBod from viewReporteDevoluciones where Codigo = " & Codigo & " and dbo.dateonly(FechaDevolucion) >= '" & Me.dtpDesde.Value.ToShortDateString & "' and dbo.dateonly(FechaDevolucion) <= '" & Me.dtpHasta.Value.ToShortDateString & "' Order by FechaDevolucion", dt, CadenaConexionSeePOS)
        Me.viewMovimientos.DataSource = dt
        Me.viewMovimientos.Columns("FechaDevolucion").DefaultCellStyle.Format = "d"
        Me.viewMovimientos.Columns("Cantidad").DefaultCellStyle.Format = "N2"
        Me.viewMovimientos.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewMovimientos.Columns("CantVet").DefaultCellStyle.Format = "N2"
        Me.viewMovimientos.Columns("CantVet").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewMovimientos.Columns("CantBod").DefaultCellStyle.Format = "N2"
        Me.viewMovimientos.Columns("CantBod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewMovimientos.Columns("devolucion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewMovimientos.Columns("Num_Factura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub Cuenta()
        Me.TextBox1.Text = ""
        Dim Resultado As String = ""
        Dim diccionario As New Collections.Generic.Dictionary(Of String, String)
        diccionario.Add("ADC", "Devolucion Compra Anulada")
        diccionario.Add("AFV", "Venta Anulada")
        diccionario.Add("AIA", "Ajuste Anulado")
        diccionario.Add("AIE", "Ajuste Entrada")
        diccionario.Add("AIS", "Ajuste Salida")
        diccionario.Add("APT", "Apartado")
        diccionario.Add("APR", "Prestamo Anulado")
        diccionario.Add("COM", "Compra")
        diccionario.Add("CON", "Venta")
        diccionario.Add("CRE", "Venta")
        diccionario.Add("PVE", "Venta")
        diccionario.Add("DFV", "Venta Desanulada")
        diccionario.Add("DP", "Devolucion Prestamo")
        diccionario.Add("DVA", "Devolucion Venta Anulada")
        diccionario.Add("DVE", "Devolucion Venta")
        diccionario.Add("EFC", "Compra Eliminacion")
        diccionario.Add("PE", "Prestamo Entrada")
        diccionario.Add("PS", "Prestamo Salida")
        diccionario.Add("TPE", "Traslado Entrada")
        diccionario.Add("TPS", "Traslado Salida")

        'diccionario.Add("ICI", "")
        'diccionario.Add("MCO", "")
        'diccionario.Add("MCR", "")
        'diccionario.Add("TCO", "")
        'diccionario.Add("TCR", "")
        'diccionario.Add("APA", "")
        'diccionario.Add("DVC", "")

        Dim conteo As New Collections.Generic.Dictionary(Of String, Integer)
        Dim cuantos As Decimal = 0
        For Each item As Collections.Generic.KeyValuePair(Of String, String) In diccionario
            cuantos = 0
            cuantos = (From x As DataGridViewRow In Me.viewMovimientos.Rows Where x.Cells("Tipo").Value = item.Key Select CDec(x.Cells("Cantidad").Value)).Sum
            If cuantos > 0 Then
                If conteo.ContainsKey(item.Value) = False Then
                    conteo.Add(item.Value, cuantos)
                Else
                    conteo(item.Value) += cuantos
                End If
            End If
        Next

        Me.TextBox1.Text = ""
        For Each item As Collections.Generic.KeyValuePair(Of String, Integer) In conteo
            If Me.TextBox1.Text = "" Then
                Me.TextBox1.Text = item.Key & " " & item.Value
            Else
                Me.TextBox1.Text += ", " & item.Key & " " & item.Value
            End If
        Next
    End Sub

    Private CodigoInterno As String = "0"
    Private Sub BuacarEnter(_CodArticulo As String)
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Codigo", _CodArticulo)
        dt = db.Ejecutar("select Codigo, Cod_Articulo, Barras, Costo, Descripcion, Existencia, Consignacion from Inventario where Inhabilitado = 0 and (Cod_Articulo = @Codigo or Barras = @Codigo or Barras2 = @Codigo)", CommandType.Text)
        If dt.Rows.Count > 0 Then
            Me.CodigoInterno = dt.Rows(0).Item("Codigo")
            Me.txtCodArticulo.Text = dt.Rows(0).Item("Cod_Articulo")
            Me.txtDescripcion.Text = dt.Rows(0).Item("Descripcion")
        Else
            Me.CodigoInterno = "0"
            Me.txtDescripcion.Text = ""
        End If
    End Sub

    Private Sub BuscarF1()
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Exit Sub
        End If
        Codigo = BuscarArt.Codigo
        Me.BuacarEnter(Codigo)
    End Sub

    Private Sub txtCodArticulo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodArticulo.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtCodArticulo.Text <> "" Then
            Me.BuacarEnter(Me.txtCodArticulo.Text)
        End If
        If e.KeyCode = Keys.F1 Then
            Me.BuscarF1()
        End If
    End Sub

    Private Sub frmMovimientoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class