Public Class frmBuscadorCabysMH

    Private Sub BuscarCabys()
        Dim datos As New api.Hacienda.CodCabys
        datos = api.Hacienda.ConsultarCabys_x_Descripcion(Me.txtBuscar.Text)
        Me.viewDatos.DataSource = datos.cabys
        Me.viewDatos.Columns("ListaCategorias").HeaderText = "Categorias"
        Me.viewDatos.Columns("ListaCategorias").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Me.viewDatos.Columns("codigo").HeaderText = "Codigo CABYS"
        Me.viewDatos.Columns("descripcion").HeaderText = "Descripcion"
        Me.viewDatos.Columns("impuesto").HeaderText = "Impuesto"
        Me.viewDatos.Columns("impuesto").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("impuesto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("Uri").Visible = False
        Me.btnAceptar.Enabled = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.BuscarCabys()
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BuscarCabys()
        End If
    End Sub

    Private Sub viewDatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEnter
        Me.txtCodigo.Text = Me.viewDatos.Item("codigo", e.RowIndex).Value
        Me.txtDescripcion.Text = Me.viewDatos.Item("descripcion", e.RowIndex).Value
        Me.txtImpuesto.Text = Me.viewDatos.Item("impuesto", e.RowIndex).Value
        Me.btnAceptar.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class