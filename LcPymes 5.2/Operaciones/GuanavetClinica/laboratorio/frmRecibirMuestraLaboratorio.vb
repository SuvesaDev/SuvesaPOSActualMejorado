Imports System.Data
Public Class frmRecibirMuestraLaboratorio

    Public IdUsuario As String = "0"

    Private Sub Login(_Clave As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre, Porc_Desc, CambiarPrecio from Usuarios where Clave_Interna = '" & _Clave & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtNombreUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
            Me.txtClave.Enabled = False
            Me.btnAceptar.Enabled = True
        Else
            Me.txtNombreUsuario.Text = ""
            Me.IdUsuario = ""
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtNumFactura.Text = "" Then
            MsgBox("Debe ingresar un numero de factura de compra", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        If IsNumeric(Me.txtCostoUnit.Text) Then
            If CDec(Me.txtCostoUnit.Text) <= 0 Then
                MsgBox("El costo debe ser un valor numerico mayor que cero.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If
        Else
            MsgBox("El costo debe ser un valor numerico mayor que cero.", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        Me.Login(Me.txtClave.Text)
    End Sub

End Class