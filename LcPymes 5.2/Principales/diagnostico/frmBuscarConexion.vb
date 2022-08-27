Public Class frmBuscarConexion

    Public RED As Boolean
    Public Servidor As Boolean

    Private Sub Diagnosticar()
        Me.GroupBox1.Enabled = False
        Me.btnInfoServidor.Enabled = False
        Me.btnInfoRED.Enabled = False
        Me.btnCambiarConexion.Enabled = False

        Me.RED = False
        Me.Servidor = False

        If My.Computer.Network.IsAvailable Then
            'Si hay red
            Me.RED = True
            Me.btnInfoRED.Enabled = True
            Me.pbRed.Image = My.Resources.accept_button
            If Me.ProbarConeccionServidor Then
                Me.Servidor = True
                Me.pbServidor.Image = My.Resources.accept_button
                Me.btnInfoServidor.Enabled = True
            Else
                Me.btnInfoServidor.Enabled = True
                Me.btnCambiarConexion.Enabled = True
                Me.pbServidor.Image = My.Resources.delete
            End If
        Else
            Me.pbRed.Image = My.Resources.delete
            Me.pbServidor.Image = My.Resources.delete
        End If
        Me.GroupBox1.Enabled = True
        MsgBox("Diagnostico Terminado", MsgBoxStyle.Information, Text)
    End Sub

    Private Function ProbarConeccionServidor() As Boolean
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Return db.ProbarConexion(CadenaConexionSeePOS)
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDiagnosticar.Click
        Me.Diagnosticar()
    End Sub

    Private Sub btnInfoRED_Click(sender As Object, e As EventArgs) Handles btnInfoRED.Click
        If RED Then
            MsgBox("Correcto", MsgBoxStyle.Information, "Computadora conectada a la red")
        Else
            Dim msg As String = "Error en la red." & vbCrLf _
            & "revise que el cable de red este conectado " & vbCrLf _
            & ""
            MsgBox(msg, MsgBoxStyle.Exclamation, "No hay conexion")
        End If
    End Sub

    Private Sub btnInfoServidor_Click(sender As Object, e As EventArgs) Handles btnInfoServidor.Click
        If Servidor Then
            MsgBox("Correcto", MsgBoxStyle.Information, "Computadora conectada a la servidor")
        Else
            Dim msg As String = "Error en la conexion." & vbCrLf _
            & "puede que el servidor este apagado o cambio de direccion." & vbCrLf _
            & ""
            MsgBox(msg, MsgBoxStyle.Exclamation, "No hay conexion")
        End If
    End Sub

    Private Sub btnCambiarConexion_Click(sender As Object, e As EventArgs) Handles btnCambiarConexion.Click
        Dim frm As New frmCambiarConexion
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Diagnosticar()
        End If
    End Sub
End Class