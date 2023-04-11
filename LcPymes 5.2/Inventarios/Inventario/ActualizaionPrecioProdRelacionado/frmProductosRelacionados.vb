Public Class frmProductosRelacionados

    Public Codigo As String = "0"
    Public PrecioUnit As Decimal = 0

    Private Sub CargarProductosRelacionados(_Cod As String)
        Dim dt As New System.Data.DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Codigo", _Cod)
        db.AddParametro("@NuevoPrecioUnit", Me.PrecioUnit)
        dt = db.Ejecutar("usp_GetArticulosRelaccionados")

        Dim Index As Integer = 0
        Me.viewDatos.Rows.Clear()
        For Each row As System.Data.DataRow In dt.Rows            
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cCodigo", Index).Value = row.Item("Codigo")
            Me.viewDatos.Item("cCodArticulo", Index).Value = row.Item("Cod_Articulo")
            Me.viewDatos.Item("cDescripccion", Index).Value = row.Item("Descripcion")
            Me.viewDatos.Item("cPrecioAntes", Index).Value = Math.Round(row.Item("PrecioActual"), 2)
            Me.viewDatos.Item("cNuevoCosto", Index).Value = Math.Round(row.Item("Costo") + row.Item("Cambio"), 2)
            Me.viewDatos.Item("cNuevoPrecio", Index).Value = Math.Round(row.Item("PrecioNuevo"), 2)
            Me.viewDatos.Item("cUtilidad", Index).Value = 0
            Me.viewDatos.Item("cAplicar", Index).Value = True
            Index += 1
        Next

    End Sub

    Private Sub frmProductosRelacionados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Codigo <> "0" Then Me.CargarProductosRelacionados(Me.Codigo)        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function CalcularUtilidad(_Precio As Decimal, _Costo As Decimal) As Decimal
        Dim Utilidad As Decimal
        Utilidad = (_Precio / _Costo) - 1
        Utilidad = Utilidad * 100
        Return Utilidad
    End Function

    Private Sub viewDatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEnter
        On Error Resume Next
        Me.txtDescripcionSelecionado.Text = Me.viewDatos.Item("cDescripccion", Me.viewDatos.CurrentRow.Index).Value
        Me.txtCostoSeleccionado.Text = CDec(Me.viewDatos.Item("cNuevoCosto", Me.viewDatos.CurrentRow.Index).Value)
        Me.txtPrecioSeleccionado.Text = Me.viewDatos.Item("cNuevoPrecio", Me.viewDatos.CurrentRow.Index).Value
        Me.txtUtilidadSeleccionado.Text = Me.CalcularUtilidad(Me.txtPrecioSeleccionado.Text, Me.txtCostoSeleccionado.Text)
    End Sub

    Private Sub viewDatos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellValueChanged
        On Error Resume Next
        Me.txtDescripcionSelecionado.Text = Me.viewDatos.Item("cDescripccion", e.RowIndex).Value
        Me.txtCostoSeleccionado.Text = CDec(Me.viewDatos.Item("cNuevoCosto", e.RowIndex).Value).ToString("N2")
        Me.txtPrecioSeleccionado.Text = CDec(Me.viewDatos.Item("cNuevoPrecio", e.RowIndex).Value).ToString("N2")
        Me.txtUtilidadSeleccionado.Text = Me.CalcularUtilidad(Me.txtPrecioSeleccionado.Text, Me.txtCostoSeleccionado.Text).ToString("N2")
    End Sub

End Class