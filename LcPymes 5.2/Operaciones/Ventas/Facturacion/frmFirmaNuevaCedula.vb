Imports System.Data
Public Class frmFirmaNuevaCedula

    Private Function GetNombre(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select NOMBRECOMPLETO2 from Cedula.dbo.ENTIDADES_FISICAS where cedula2 = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then

            Return dt.Rows(0).Item("NOMBRECOMPLETO2")
        Else

            Dim dt2 As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select NOMBRE from Cedula.dbo.ENTIDADES_FIRMA where CEDULA = '" & _Cedula & "'", dt2, CadenaConexionSeePOS)
            If dt2.Rows.Count > 0 Then
                Return dt2.Rows(0).Item("NOMBRE")
            Else
                Return "0"
            End If
        End If
    End Function

    Private Sub Guardar()
        Dim Cedula As String = Me.txtCedula.Text.ToString
        Dim Nombre As String = Me.txtNombre.Text.ToString

        If Len(Cedula) > 9 Then
            If Me.GetNombre(Cedula) = "0" Then
                Dim db As New OBSoluciones.SQL.Sentencias(GetSetting("seesoft", "seepos", "datos_Cedulas"))
                db.Ejecutar("Insert into ENTIDADES_FIRMA values('" & Cedula & "', '" & Nombre & "')", CommandType.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("La cedula ya existe, no se puede registrar")
            End If
        Else
            MsgBox("la cedula debe tener almenos 9 numeros")
        End If

    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
         e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Me.Guardar()
    End Sub

End Class