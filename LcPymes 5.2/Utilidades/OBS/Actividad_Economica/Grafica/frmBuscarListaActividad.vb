Imports System.Windows.Forms
Imports System.Data

Namespace Modulos
    Namespace FE
        Public Class frmBuscarListaActividad
            Private cls As New FE.Actividad_Economica

            Private Sub Buscar_ListaActividad()
                Dim dt As New DataTable
                dt = cls.GET_LISTA_ACTIVIAD_x_ACTIVIDAD(Me.txtBuscar.Text)
                Me.viewDatos.DataSource = dt
                For Each c As DataGridViewColumn In Me.viewDatos.Columns
                    If c.Name <> "CODIGO" And c.Name <> "ACTIVIDAD" Then
                        c.Visible = False
                    End If
                Next
            End Sub

            Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End Sub

            Private Sub frmBuscarListaActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Buscar_ListaActividad()
            End Sub

            Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
                If e.KeyCode = Keys.Enter And Me.viewDatos.RowCount > 0 Then
                    Me.viewDatos.Focus()
                End If
            End Sub

            Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
                Buscar_ListaActividad()
            End Sub

            Private Sub viewDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDatos.KeyDown
                If e.KeyCode = Keys.Enter And Me.viewDatos.RowCount > 0 Then
                    e.SuppressKeyPress = True
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End Sub

            Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
                If Me.viewDatos.RowCount > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End Sub
        End Class
    End Namespace
End Namespace
