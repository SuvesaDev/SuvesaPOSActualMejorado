Public Class frmDetalleArticulosRelacionados

    Public Codigo As String = "0"

    Private Sub CargarProductosRelacionados(_Cod As String)
        Dim dt As New System.Data.DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        dt = db.Ejecutar("select i.Codigo, i.Cod_Articulo, i.Descripcion from ArticulosRelacionados a inner join Inventario i on i.Codigo = a.CodigoPrincipal where a.Codigo = " & _Cod, Data.CommandType.Text)

        Dim Index As Integer = 0
        Me.viewDatos.Rows.Clear()
        For Each row As System.Data.DataRow In dt.Rows
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cCodigo", Index).Value = row.Item("Codigo")
            Me.viewDatos.Item("cCodArticulo", Index).Value = row.Item("Cod_Articulo")
            Me.viewDatos.Item("cDescripccion", Index).Value = row.Item("Descripcion")
            Index += 1
        Next

    End Sub

    Private Sub frmDetalleArticulosRelacionados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarProductosRelacionados(Me.Codigo)
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Try
            Dim frm As New frmDetalleArticulosRelacionados
            frm.Codigo = Me.viewDatos.Item("cCodigo", Me.viewDatos.CurrentRow.Index).Value
            frm.txtDescripcion.Text = Me.viewDatos.Item("cDescripccion", Me.viewDatos.CurrentRow.Index).Value
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
End Class