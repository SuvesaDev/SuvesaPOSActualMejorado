Imports System.Data
Public Class frmFirmaNuevaCedula

    Private Function GetNombre(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select NOMBRECOMPLETO2 from ENTIDADES_FISICAS where cedula2 = '" & _Cedula & "'", dt, CadenaConexionCedulas)
        If dt.Rows.Count > 0 Then

            Return dt.Rows(0).Item("NOMBRECOMPLETO2")
        Else

            Dim dt2 As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select NOMBRE from ENTIDADES_FIRMA where CEDULA = '" & _Cedula & "'", dt2, CadenaConexionCedulas)
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
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionCedulas)
                db.Ejecutar("Insert into ENTIDADES_FIRMA values('" & Cedula & "', '" & Nombre & "')", CommandType.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("La cedula ya existe, no se puede registrar")
            End If
        Else
            MsgBox("la cedula debe tener almenos 9 numeros")
        End If

    End Sub

    Private Sub txtCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCedula.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(Me.txtCedula.Text)
                Me.txtNombre.Text = ObtenerDatosCliente.nombre
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            End Try
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