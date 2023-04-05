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
            Me.viewDatos.Item("cNuevoPrecio", Index).Value = Math.Round(row.Item("PrecioNuevo"), 2)
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

End Class