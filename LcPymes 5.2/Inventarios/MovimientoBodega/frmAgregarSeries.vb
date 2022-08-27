Public Class frmAgregarSeries
    Private Index As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.TextBox1.Text <> "" Then
            Me.viewSerie.Rows.Add()
            Me.viewSerie.Item("cSerie", Me.Index).Value = Me.TextBox1.Text
            Me.Index += 1
            Me.TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.viewSerie.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

End Class