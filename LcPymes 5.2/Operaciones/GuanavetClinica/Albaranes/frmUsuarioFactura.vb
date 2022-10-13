Public Class frmUsuarioFactura


    Public IdUsuario As String = "0"
    Private Sub Login()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select Cedula, Nombre from Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.IdUsuario = dt.Rows(0).Item("Cedula")
            Me.txtNombre.Text = dt.Rows(0).Item("Nombre")
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtNombre.Text <> "" Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub frmUsuarioFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnAceptar.Enabled = False
    End Sub


    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter And sender.text <> "" Then
            Me.Login()
        End If
    End Sub
End Class