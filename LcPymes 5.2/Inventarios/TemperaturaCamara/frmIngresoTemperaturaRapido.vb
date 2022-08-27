Imports System.Data

Public Class frmIngresoTemperaturaRapido

    Public Id_Usuario As String = ""

    Public Sub Guardar()
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.Ejecutar("Insert into temperaturacamara(Fecha,Id_Usuario,Temperatura, Horario) Values('" & CDate(Me.txtFecha.Text) & "','" & Me.Id_Usuario & "','" & Me.txtTemperatura.Text & "', '" & Me.txtHorario.Text & "')", CommandType.Text)
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Guardar()
    End Sub

End Class