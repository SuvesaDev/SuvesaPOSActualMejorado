Imports System.Windows.Forms
Public Class frmCambiarCorreo

    Private Index As Integer = 0

    Public Sub CargarCorreos(_Correos As String)

        Dim Correo() As String = _Correos.Split(";")

        For Each c As String In Correo

            Me.viewCorreos.Rows.Add()
            Me.viewCorreos.Item("cCorreo", Me.Index).Value = c
            Me.Index += 1

        Next

    End Sub

    Public Function CreaCorreos() As String
        Dim Resultado As String = ""

        For Each r As DataGridViewRow In Me.viewCorreos.Rows
            If Resultado = "" Then
                Resultado += r.Cells("cCorreo").Value
            Else
                Resultado += ";" & r.Cells("cCorreo").Value.ToString.Trim
            End If
        Next
        Return Resultado
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.txtCorreoElectronico.Text <> "" Then
            Me.viewCorreos.Rows.Add()
            Me.viewCorreos.Item("cCorreo", Me.Index).Value = Me.txtCorreoElectronico.Text
            Me.Index += 1
            Me.txtCorreos.Text = Me.CreaCorreos
        End If
    End Sub

    Private Sub viewCorreos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles viewCorreos.RowsRemoved
        Me.txtCorreos.Text = Me.CreaCorreos
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.viewCorreos.Rows.Clear()
        Me.Index = 0
        Me.txtCorreos.Text = Me.CreaCorreos
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmCambiarCorreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtCorreos.Text = Me.CreaCorreos
    End Sub

End Class

