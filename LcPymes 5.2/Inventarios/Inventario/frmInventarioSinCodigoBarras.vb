Imports System.Data
Public Class frmInventarioSinCodigoBarras

    Private Sub Buscar()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select i.Codigo, i.Cod_Articulo, i.Barras, i.Descripcion + ' (' + CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones + ' )' as Descripcion from Inventario i inner join Presentaciones p on i.CodPresentacion = p.CodPres where i.Servicio = 0 and i.Mascotas = 0 and i.Clinica = 0 and i.Peces = 0 and  i.Inhabilitado = 0 and i.Barras = '' and i.barras2 = '' and i.barras3 = '' and i.Descripcion like '%" & Me.txtDescripcion.Text & "%' order by i.Descripcion", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Codigo").Visible = False
        Me.Text = "Buscar articulos sin codigo de barras (" & dt.Rows.Count() & ")"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Buscar()
    End Sub

    Private Sub frmInventarioSinCodigoBarras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Buscar()
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then Me.Buscar()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Dim frm As New frmAsigarCodigoBarras
        frm.Codigo = Me.viewDatos.Item("Codigo", Me.viewDatos.CurrentRow.Index).Value
        frm.Descripcion = Me.viewDatos.Item("Descripcion", Me.viewDatos.CurrentRow.Index).Value
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Buscar()
        End If
    End Sub

End Class