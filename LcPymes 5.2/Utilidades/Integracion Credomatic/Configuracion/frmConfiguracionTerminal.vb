Imports System.Data

Namespace Credomatic
    Namespace Configuracion
        Public Class frmConfiguracionTerminal
            Private cls As New Terminal

            Private Sub Cargar()
                Me.txtTerminar.Text = cls.Terminal
                Me.txtImpresora.Text = cls.Impresora
                Me.ckDatafono.Checked = cls.Datafono
            End Sub

            Private Sub Guardar()
                Me.cls.Terminal = Me.txtTerminar.Text
                Me.cls.Impresora = Me.txtImpresora.Text
                Me.cls.Datafono = Me.ckDatafono.Checked
                Me.Close()
            End Sub

            Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
                Me.Guardar()
            End Sub

            Private Sub frmConfiguracionTerminal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                Me.Cargar()
            End Sub

            Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
                Me.Close()
            End Sub

            Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarImpresora.Click
                Dim nc As New Windows.Forms.PrintDialog
                If nc.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtImpresora.Text = nc.PrinterSettings.PrinterName
                End If
            End Sub
        End Class
    End Namespace
End Namespace
