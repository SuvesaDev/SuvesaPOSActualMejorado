Imports System.Data
Public Class frmGUARDAR_VALIDA_FIRMADOCONTADO
    Private seterror As New ErrorProvider
    Public ID_VALIDA_FIRMADOCONTADO As Integer

    Private Sub CargarDatos(ByVal _id As String)
        Try
            Dim cls As New VALIDA_FIRMADOCONTADO
            Dim dt As New DataTable

            dt = cls.GET_VALIDACION(_id)
            If dt.Rows.Count > 0 Then
                Me.ID_VALIDA_FIRMADOCONTADO = dt.Rows(0).Item("ID_VALIDA_FIRMADOCONTADO")
                Me.ckCONTADO.Checked = dt.Rows(0).Item("CONTADO")
                Me.ckPVE.Checked = dt.Rows(0).Item("PVE")
                Me.txtMONTO_MAXIMO.Text = dt.Rows(0).Item("MONTO_MAXIMO")
                Me.ckEXIGE_NOMBRE.Checked = dt.Rows(0).Item("EXIGE_NOMBRE")
                Me.txtMAXIMO_CLIENTE.Text = dt.Rows(0).Item("MAXIMO_CLIENTE")
                Me.txtMAXIMO_AUTORIZA.Text = dt.Rows(0).Item("MAXIMO_AUTORIZA")
                Me.txtMAXIMO_RETIRA.Text = dt.Rows(0).Item("MAXIMO_RETIRA")

                Me.CARGAR_EXEPCION_FIRMADOCONTADO()
            Else
                Me.ID_VALIDA_FIRMADOCONTADO = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Function PasaValidacion() As Boolean
        Dim pasa As Boolean = True
        If Me.txtMONTO_MAXIMO.Text = "" Then
            seterror.SetError(Me.txtMONTO_MAXIMO, "Debe ingresar un valor para este campo!!!")
            pasa = False
        Else
            seterror.SetError(Me.txtMONTO_MAXIMO, "")
        End If
        If Me.txtMAXIMO_CLIENTE.Text = "" Then
            seterror.SetError(Me.txtMAXIMO_CLIENTE, "Debe ingresar un valor para este campo!!!")
            pasa = False
        Else
            seterror.SetError(Me.txtMAXIMO_CLIENTE, "")
        End If
        If Me.txtMAXIMO_AUTORIZA.Text = "" Then
            seterror.SetError(Me.txtMAXIMO_AUTORIZA, "Debe ingresar un valor para este campo!!!")
            pasa = False
        Else
            seterror.SetError(Me.txtMAXIMO_AUTORIZA, "")
        End If
        If Me.txtMAXIMO_RETIRA.Text = "" Then
            seterror.SetError(Me.txtMAXIMO_RETIRA, "Debe ingresar un valor para este campo!!!")
            pasa = False
        Else
            seterror.SetError(Me.txtMAXIMO_RETIRA, "")
        End If
        Return pasa
    End Function


    Private EF_COUNT As Integer = 0
    Private Sub btnAGREGAR_EXEPCION_FIRMADOCONTADO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGREGAR_EXEPCION_FIRMADOCONTADO.Click
        Me.viewEXEPCION_FIRMADOCONTADO.Rows.Add()
        Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFID_EXEPCION_FIRMADOCONTADO", EF_COUNT).Value = 0
        Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFID_VALIDA_FIRMADOCONTADO", EF_COUNT).Value = 0
        Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFCEDULA", EF_COUNT).Value = Me.txtEFCEDULA.Text
        Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFNOMBRE", EF_COUNT).Value = Me.txtEFNOMBRE.Text
        Me.EF_COUNT += 1
        Me.txtEFCEDULA.Text = ""
        Me.txtEFNOMBRE.Text = ""
    End Sub

    Private Sub CARGAR_EXEPCION_FIRMADOCONTADO()
        Dim dt As New DataTable
        Dim cls As New VALIDA_FIRMADOCONTADO
        dt = cls.CARGAR_EXEPCION_FIRMADOCONTADO(Me.ID_VALIDA_FIRMADOCONTADO)
        Me.EF_COUNT = 0
        For Each X As DataRow In dt.Rows
            Me.viewEXEPCION_FIRMADOCONTADO.Rows.Add()
            Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFID_EXEPCION_FIRMADOCONTADO", EF_COUNT).Value = X.Item("ID_EXEPCION_FIRMADOCONTADO")
            Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFID_VALIDA_FIRMADOCONTADO", EF_COUNT).Value = X.Item("ID_VALIDA_FIRMADOCONTADO")
            Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFCEDULA", EF_COUNT).Value = X.Item("CEDULA")
            Me.viewEXEPCION_FIRMADOCONTADO.Item("cEFNOMBRE", EF_COUNT).Value = X.Item("NOMBRE")
            Me.EF_COUNT += 1
        Next
    End Sub

    Private Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ID_VALIDA_FIRMADOCONTADO = 1
        If Me.ID_VALIDA_FIRMADOCONTADO > 0 Then Me.CargarDatos(ID_VALIDA_FIRMADOCONTADO)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Siguiente(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ckCONTADO.KeyDown, ckPVE.KeyDown, txtMONTO_MAXIMO.KeyDown, ckEXIGE_NOMBRE.KeyDown, txtMAXIMO_CLIENTE.KeyDown, txtMAXIMO_AUTORIZA.KeyDown, txtMAXIMO_RETIRA.KeyDown
        If e.KeyCode = Keys.Enter And sender.Text <> "" Then SendKeys.Send("{Tab}")
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.PasaValidacion = False Then
            MsgBox("Faltan datos por ingresar!!!", MsgBoxStyle.Exclamation, Text)
            Exit Sub
        End If

        Dim cls As New VALIDA_FIRMADOCONTADO
        cls.ID_VALIDA_FIRMADOCONTADO = Me.ID_VALIDA_FIRMADOCONTADO
        cls.CONTADO = IIf(ckCONTADO.Checked = True, 1, 0)
        cls.PVE = IIf(ckPVE.Checked = True, 1, 0)
        cls.MONTO_MAXIMO = txtMONTO_MAXIMO.Text
        cls.EXIGE_NOMBRE = IIf(ckEXIGE_NOMBRE.Checked = True, 1, 0)
        cls.MAXIMO_CLIENTE = txtMAXIMO_CLIENTE.Text
        cls.MAXIMO_AUTORIZA = txtMAXIMO_AUTORIZA.Text
        cls.MAXIMO_RETIRA = txtMAXIMO_RETIRA.Text
        cls.SAVE_VALIDA_FIRMADOCONTADO(viewEXEPCION_FIRMADOCONTADO)
        Me.Close()
    End Sub

    Private Sub BuscarIdentificacion()
        Try
            If Me.txtEFCEDULA.Text.Length >= 9 And Me.txtEFCEDULA.Text.Length <= 12 Then
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(Me.txtEFCEDULA.Text)
                Me.txtEFNOMBRE.Text = ObtenerDatosCliente.nombre
            Else
                Me.txtEFNOMBRE.Text = ""
            End If
        Catch ex As Exception
            Me.txtEFNOMBRE.Text = ""
        End Try
    End Sub

    Private Sub txtEFCEDULA_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEFCEDULA.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BuscarIdentificacion()
        End If
    End Sub
End Class
