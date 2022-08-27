Public Class Conecta_Frm

    Public Overloads Sub Show(ByVal Message As String, ByVal Titulo As String)
        Me.Text = Titulo
        Mensaje_Lab.Text = Message
        Me.Show()
        Application.DoEvents()
    End Sub

End Class