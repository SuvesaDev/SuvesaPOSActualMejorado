Public Class frmFacturaElectronica
    Public Identificacion As String = "0"
    Private Tipo As String = ""
    Public Crear As Boolean = False

    Private Sub BuscarCliente(_Identificacion As String)
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select identificacion, cedula, nombre, Telefono_01, CorreoComprobante, TipoCliente from Clientes where cedula = '" & _Identificacion & "' and Anulado = 0", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.Identificacion = dt.Rows(0).Item("identificacion")
            Me.txtNombre.Text = dt.Rows(0).Item("nombre")
            Me.txtCorreo.Text = dt.Rows(0).Item("CorreoComprobante")
            Me.txtTelefono.Text = dt.Rows(0).Item("Telefono_01")
            Me.Tipo = dt.Rows(0).Item("TipoCliente")
            Me.Crear = False
        Else
            Try
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(_Identificacion)
                Me.Tipo = ObtenerDatosCliente.tipoIdentificacion
                Me.txtNombre.Text = ObtenerDatosCliente.nombre
                Select Case ObtenerDatosCliente.tipoIdentificacion
                    Case "01" : Me.Tipo = "FISICA"
                    Case "02" : Me.Tipo = "JURIDICA"
                    Case "03" : Me.Tipo = "DIMEX"
                End Select
                Me.Crear = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            End Try
        End If
    End Sub

    Private Sub txtIdentificacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdentificacion.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtIdentificacion.Text <> "" Then
            Me.BuscarCliente(Me.txtIdentificacion.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.txtIdentificacion.Text <> "" And Me.txtNombre.Text <> "" And Me.txtTelefono.Text <> "" Then

            If Me.Crear = True Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.AddParametro("@cedula", Me.txtIdentificacion.Text)
                db.AddParametro("@nombre", Me.txtNombre.Text)
                db.AddParametro("@Telefono_01", Me.txtTelefono.Text)
                db.AddParametro("@e_mail", Me.txtCorreo.Text)
                db.AddParametro("@direccion", "")
                db.AddParametro("@tipo", Me.Tipo)
                db.Ejecutar("Insertar_Cliente_rapido @cedula, @nombre, @Telefono_01, @e_mail, @direccion, @tipo")
                Me.BuscarCliente(Me.txtIdentificacion.Text)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class