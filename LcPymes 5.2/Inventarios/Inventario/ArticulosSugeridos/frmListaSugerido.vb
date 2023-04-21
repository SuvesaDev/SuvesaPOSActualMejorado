Public Class frmListaSugerido


    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class