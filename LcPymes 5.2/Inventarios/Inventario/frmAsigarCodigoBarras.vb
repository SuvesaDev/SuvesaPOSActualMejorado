Public Class frmAsigarCodigoBarras

    Public Property Codigo As String
    Public Property Descripcion As String


    Private Sub frmAsigarCodigoBarras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblDescripcion.Text = Me.Descripcion
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.Ejecutar("Update inventario set Barras = '" & Me.txtBarras.Text & "' Where Codigo =" & Me.Codigo, Data.CommandType.Text)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class