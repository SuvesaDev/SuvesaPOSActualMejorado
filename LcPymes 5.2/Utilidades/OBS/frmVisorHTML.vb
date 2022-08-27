Public Class frmVisorHTML

    Public URL As String = ""
    Private Sub frmVisorHTML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Url = New System.Uri(Me.URL)
    End Sub
End Class