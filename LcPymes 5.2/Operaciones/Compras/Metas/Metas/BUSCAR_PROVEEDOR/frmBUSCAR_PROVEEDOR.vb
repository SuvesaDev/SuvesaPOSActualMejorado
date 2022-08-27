
'@utor :
'ing.Rolando Obando Rojas
'Syscript 2015

Public Class frmBUSCAR_PROVEEDOR
    Private WithEvents cls As New PROVEEDOR

    Private Sub Cargar_Datos(_tex As String)
        Me.viewDatos.DataSource = cls.BUSCAR_PROVEEDOR(_tex)

        For Each C As DataGridViewColumn In Me.viewDatos.Columns
            If C.Name = "CODIGOPROV" Then
                C.Visible = False
            End If
        Next
    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar_Datos("%%%")
        On Error Resume Next
        'Me.viewDatos.Item("ID_PROVEEDOR", 0).Selected = True
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then Me.viewDatos.Focus()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Me.Cargar_Datos(Me.txtNombre.Text)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub viewDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDatos.KeyDown
        If e.KeyCode = Keys.Enter Then e.Handled = True : Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class