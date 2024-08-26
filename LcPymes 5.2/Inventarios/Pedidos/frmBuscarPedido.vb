Public Class frmBuscarPedido

    Public Consecutivo As String = "0"

    Private Sub CargarMovimientos(Optional ByVal _Descripcion As String = "")
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select consecutivo, Cod_Articulo, Descripcion, Observaciones, CantidadSolicitud, FechaSolicitud from viewPedidosBodega where Descripcion like '%" & _Descripcion & "%' or Observaciones like '%" & _Descripcion & "%'", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
    End Sub

    Private Sub frmBuscarPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarMovimientos("%%")
        Me.txtDescripcion.Focus()
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        Me.CargarMovimientos(Me.txtDescripcion.Text)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.viewDatos.Rows.Count > 0 Then
            Me.Consecutivo = Me.viewDatos.Item("Consecutivo", Me.viewDatos.CurrentRow.Index).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class