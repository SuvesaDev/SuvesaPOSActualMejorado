Imports System.Data
Public Class frm_productos_patrocinadores

    Private Sub frm_productos_patrocinadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = Windows.Forms.FormWindowState.Maximized
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from rifa where anulada = 0 and finalizada = 0", dts)
            cbo_rifa.DataSource = dts
            cbo_rifa.DisplayMember = "descripcion"
            cbo_rifa.ValueMember = "id"
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btn_mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mostrar.Click
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select i.codigo,i.cod_articulo,i.barras,i.Descripcion, p.Nombre as Proveedor From rifa r Inner Join Rifa_Detalle rd on r.id = rd.idrifa Inner Join Inventario i on rd.IdProveedor = i.Proveedor inner join Proveedores p on i.Proveedor = p.CodigoProv where finalizada = 0 and anulada = 0 and r.id = " & cbo_rifa.SelectedValue, dts)
            datalistado.DataSource = dts
        Catch ex As Exception

        End Try

    End Sub

End Class