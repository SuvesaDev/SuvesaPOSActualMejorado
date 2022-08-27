Public Class frmEligeCosto

    Public Eligio As Boolean = False
    Public CualEligio As CostoEligio

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Eligio = True
        CualEligio = CostoEligio.Costo
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Eligio = True
        CualEligio = CostoEligio.CostoReal
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class

Public Enum CostoEligio
    Costo
    CostoReal
End Enum