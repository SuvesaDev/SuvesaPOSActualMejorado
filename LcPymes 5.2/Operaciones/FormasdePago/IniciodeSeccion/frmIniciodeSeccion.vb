Imports System.Data
Public Class frmIniciodeSeccion

    Public AccesoConsedido As Boolean = False
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""

    Private Sub CargaDatosUsuarios()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select u.Id_Usuario, u.Nombre from Usuarios u where u.Clave_Interna = '" & Me.txtNumCuenta.Text & "' ", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then

            AccesoConsedido = True
            Id_Usuario = dt.Rows(0).Item("Id_Usuario")
            NombreUsuario = dt.Rows(0).Item("Nombre")
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            AccesoConsedido = False
            Id_Usuario = ""
            NombreUsuario = ""

            MsgBox("No se encontraron datos" & vbCrLf _
                   & "Clave incorrecta ", MsgBoxStyle.Exclamation, "No se puede realizar la operacion!!!")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        Me.txtNumCuenta.Text += sender.text.ToString
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.CargaDatosUsuarios()
    End Sub

    Private Sub txtNumCuenta_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtNumCuenta.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Me.CargaDatosUsuarios()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.txtNumCuenta.Text = ""
    End Sub

End Class