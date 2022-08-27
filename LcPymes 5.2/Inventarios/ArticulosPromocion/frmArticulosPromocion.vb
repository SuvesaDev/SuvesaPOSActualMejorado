Imports System.Data

Public Class frmArticulosPromocion

    Private Sub CargarPromociones()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from viewArticulosPromocion", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Try
            Me.viewDatos.Columns("Codigo").Visible = False
            Me.viewDatos.Columns("Existencia").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("Precio_A").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Precio_A").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("Precio_Promo").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Precio_Promo").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.viewDatos.Columns("FechaLimite").DefaultCellStyle.Format = "d"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Me.CargarPromociones()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Dim codigo As String = Me.viewDatos.Item("codigo", Me.viewDatos.CurrentRow.Index).Value
        Dim frm As New frmBuscarUltimasVentas
        frm.Codigo = codigo
        frm.ShowDialog()

    End Sub
End Class