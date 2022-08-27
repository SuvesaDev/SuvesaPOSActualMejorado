Imports System.Windows.Forms
Imports System.Data
Imports System.ComponentModel

Public Class frm_cliente_rapido
    Public cedula As String
    Public tipo As Double
    Public nombre As String
    Public bandera As Boolean = False
    Public Frecuente As Boolean = False

    Public BanderaActualizar As Boolean = False
    Public Cod_Cliente As String = ""

    Private Sub frm_cliente_rapido_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If BanderaActualizar = False Then
            txtNombre.Text = nombre
            txtCodigo.Text = cedula
            cbo_tipo_cliente.SelectedIndex = tipo
            txtTelefono.Focus()
            Me.Text = "Agregar Cliente"
        Else
            Me.Text = "Actualizar Cliente"
        End If
    End Sub

    Private Sub btn_guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_guardar.Click
        Dim Pasa As Boolean = False
        Select Case Me.cbo_tipo_cliente.Text
            Case "FISICA" 'formato de cedula fisica
                Pasa = IIf(Me.txtCodigo.Text.ToString.Length = 9, True, False)
            Case "JURIDICA" 'formato de cedula juridica
                Pasa = IIf(Me.txtCodigo.Text.ToString.Length = 10, True, False)
            Case "DIMEX" 'formato de cedula extrangera
                If Me.txtCodigo.Text.ToString.Length = 11 Or Me.txtCodigo.Text.ToString.Length = 12 Then
                    Pasa = True
                Else
                    Pasa = False
                End If
        End Select

        If Pasa = False Then
            MsgBox("Formato de Cedula incorrecto", MsgBoxStyle.Critical, Text)
            Exit Sub
        End If

        If BanderaActualizar = True Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Clientes set Actualizado = 1, TipoCliente = '" & Me.cbo_tipo_cliente.Text & "', Cedula = '" & Me.txtCodigo.Text & "', Nombre = '" & Me.txtNombre.Text & "', Telefono_01 = '" & Me.txtTelefono.Text & "', CorreoComprobante = '" & Me.txt_email.Text & "', Direccion = '" & Me.Txtdireccion.Text & "' Where Identificacion = '" & Me.Cod_Cliente & "'", CommandType.Text)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            If txtCodigo.Text = 0 Then
                MsgBox("No puede guardar un Registro con cliente 0", MsgBoxStyle.Critical, "Guardar Cliente")
                Exit Sub
            End If
            If existe_cedula(txtCodigo.Text) = False Then
                If MsgBox("Desea guardar los datos?", vbYesNo, "Registrar Cliente") = MsgBoxResult.Yes Then
                    guardar()
                    bandera = True
                Else
                    Me.Close()
                    bandera = False
                End If
            Else
                MsgBox("El Número de Cedula ya existe", vbCritical, "Guardar Cliente")
            End If
        End If
    End Sub

    Private Function toTexto(_texto As String) As String
        Return _texto.Replace("'", "")
    End Function

    Sub guardar()
        Try
            Dim cn As New Conexion
            Dim resultado As String = ""

            If Me.Frecuente = False Then
                resultado = cn.SlqExecute(cn.Conectar, "exec Insertar_Cliente_rapido '" & Me.toTexto(txtCodigo.Text) & "','" & Me.toTexto(txtNombre.Text) & "','" & Me.toTexto(txtTelefono.Text) & "','" & Me.toTexto(txt_email.Text) & "','" & Me.toTexto(Txtdireccion.Text) & "','" & cbo_tipo_cliente.Text & "'")
            Else
                resultado = cn.SlqExecute(cn.Conectar, "exec Insertar_ClienteFrecuente_rapido '" & Me.toTexto(txtCodigo.Text) & "','" & Me.toTexto(txtNombre.Text) & "','" & Me.toTexto(txtTelefono.Text) & "','" & Me.toTexto(txt_email.Text) & "','" & Me.toTexto(Txtdireccion.Text) & "','" & cbo_tipo_cliente.Text & "'")
            End If

            If resultado = "" Then
                MsgBox("Cliente Registrado correctamente, puede continuar con la venta", MsgBoxStyle.Information, "Registro de cliente")
                bandera = True
                Me.Close()
            Else
                MsgBox(resultado, MsgBoxStyle.Exclamation, "No se pudo realizar la operacion.")
            End If
            
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub txtTelefono_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_email.Focus()
        End If
    End Sub

    Private Sub txt_email_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Txtdireccion.Focus()
        End If
    End Sub
    Function existe_cedula(ByVal cedula As String)
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from " & IIf(Me.Frecuente = False, "Clientes", "Clientes_frecuentes") & " where cedula = '" & cedula & "'", dts, CadenaConexionSeePOS)
            If dts.Rows.Count > 0 Then
                txtCodigo.Text = dts.Rows(0).Item("identificacion")
                Return True
            End If
            Return False

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTelefono.KeyDown, txtNombre.KeyDown, Txtdireccion.KeyDown, txtCodigo.KeyDown, txt_email.KeyDown, cbo_tipo_cliente.KeyDown
        If e.KeyCode = Keys.Enter And sender.text <> "" Then SendKeys.Send("{tab}")
    End Sub

End Class
