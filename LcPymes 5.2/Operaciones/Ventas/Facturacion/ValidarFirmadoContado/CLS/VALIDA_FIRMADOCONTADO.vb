'@utor: 
'ing.Rolando Obando Rojas.
'SysScript 2015
Imports System.Data
Public Class VALIDA_FIRMADOCONTADO
    Public TRANS As OBSoluciones.SQL.Transaccion
    Public ID_VALIDA_FIRMADOCONTADO As Integer
    Public CONTADO As Object
    Public PVE As Object
    Public MONTO_MAXIMO As Integer
    Public EXIGE_NOMBRE As Object
    Public MAXIMO_CLIENTE As Integer
    Public MAXIMO_AUTORIZA As Integer
    Public MAXIMO_RETIRA As Integer
    Public ID_USUARIO As String = "0"
    Public ANTES_DTS As New DataTable
    Public DESPUES_DTS As New DataTable

    Public Event AlertaError(ByVal msg As String)
    Public Event AlertaGuardado()
    Private db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)

    Private Sub Inicia()
        Me.TRANS = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
    End Sub

    Private Sub Termina()
        Me.TRANS.Commit()
    End Sub

    Private Sub Cancelar()
        Me.TRANS.Rollback()
    End Sub

    Private Sub CAPTURAR_VALOR(ByVal _ID As String, ByRef _DTS As DataTable)
        Try
            db.AddParametro("@pID_VALIDA_FIRMADOCONTADO", _ID)
            _DTS = db.Ejecutar("GET_VALIDACION")
        Catch ex As Exception
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Sub

    Private Function COMPARAR_ANTESvsDESPUES(ByRef _strSQL As String, ByVal _ID As String)
        Dim TieneBitacora As Boolean = False
        Dim cmd As String = "INSERT INTO BITACORA(TIPO, MODULO, ID_DOCUMENTO, ID_USUARIO, FECHA, OBSERVACIONES) VALUES('@TIPO', '@MODULO', @ID_DOCUMENTO, @ID_USUARIO, CURRENT_TIMESTAMP(), '@OBSERVACIONES')"
        Dim Cambios As String = ""
        Dim Tipo As String = ""
        If Me.ANTES_DTS.Rows.Count = 0 And Me.DESPUES_DTS.Rows.Count > 0 Then
            TieneBitacora = True : Tipo = "CREACION"
            For f As Integer = 0 To Me.DESPUES_DTS.Rows.Count - 1
                For c As Integer = 0 To Me.DESPUES_DTS.Columns.Count - 1
                    If Me.DESPUES_DTS.Columns(c).ColumnName.Substring(0, 3).ToUpper <> "ID_" Then
                        If Cambios = "" Then
                            Cambios += " " & Me.DESPUES_DTS.Columns(c).ColumnName.Replace("_", " ") & " : " & Me.DESPUES_DTS.Rows(f).Item(c)
                        Else
                            Cambios += " | " & Me.DESPUES_DTS.Columns(c).ColumnName.Replace("_", " ") & " : " & Me.DESPUES_DTS.Rows(f).Item(c)
                        End If
                    End If
                Next
            Next
        Else
            Tipo = "EDICION"
            For f As Integer = 0 To Me.DESPUES_DTS.Rows.Count - 1
                For c As Integer = 0 To Me.DESPUES_DTS.Columns.Count - 1
                    If Me.ANTES_DTS.Rows(f).Item(c) <> Me.DESPUES_DTS.Rows(f).Item(c) Then
                        TieneBitacora = True
                        If Me.DESPUES_DTS.Columns(c).ColumnName.Substring(0, 3).ToUpper <> "ID_" Then
                            If Cambios = "" Then
                                Cambios += " " & Me.DESPUES_DTS.Columns(c).ColumnName.Replace("_", " ") & " :  de """ & Me.ANTES_DTS.Rows(f).Item(c) & """ a """ & Me.DESPUES_DTS.Rows(f).Item(c) & """"
                            Else
                                Cambios += " | " & Me.DESPUES_DTS.Columns(c).ColumnName.Replace("_", " ") & " :  de """ & Me.ANTES_DTS.Rows(f).Item(c) & """ a """ & Me.DESPUES_DTS.Rows(f).Item(c) & """"
                            End If
                        End If
                    End If
                Next
            Next
        End If
        cmd = cmd.Replace("@TIPO", Tipo)
        cmd = cmd.Replace("@MODULO", "VALIDA_FIRMADOCONTADO")
        cmd = cmd.Replace("@ID_DOCUMENTO", _ID)
        cmd = cmd.Replace("@ID_USUARIO", Me.ID_USUARIO)
        cmd = cmd.Replace("@OBSERVACIONES", Cambios)
        _strSQL = cmd
        Return TieneBitacora
    End Function

    Public Sub SAVE_VALIDA_FIRMADOCONTADO(viewEXEPCION_FIRMADOCONTADO As DataGridView)
        Try
            Dim strSQL As String = ""
            Me.CAPTURAR_VALOR(Me.ID_VALIDA_FIRMADOCONTADO, Me.ANTES_DTS)
            Me.Inicia()
            Me.TRANS.AddParametroSalida("@pID_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO)
            Me.TRANS.SetParametro("@pCONTADO", Me.CONTADO)
            Me.TRANS.SetParametro("@pPVE", Me.PVE)
            Me.TRANS.SetParametro("@pMONTO_MAXIMO", Me.MONTO_MAXIMO)
            Me.TRANS.SetParametro("@pEXIGE_NOMBRE", Me.EXIGE_NOMBRE)
            Me.TRANS.SetParametro("@pMAXIMO_CLIENTE", Me.MAXIMO_CLIENTE)
            Me.TRANS.SetParametro("@pMAXIMO_AUTORIZA", Me.MAXIMO_AUTORIZA)
            Me.TRANS.SetParametro("@pMAXIMO_RETIRA", Me.MAXIMO_RETIRA)
            Me.TRANS.Ejecutar("SAVE_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO, 0)

            For Each X As DataGridViewRow In viewEXEPCION_FIRMADOCONTADO.Rows
                Me.TRANS.SetParametro("@pID_EXEPCION_FIRMADOCONTADO", X.Cells("cEFID_EXEPCION_FIRMADOCONTADO").Value)
                Me.TRANS.SetParametro("@pID_VALIDA_FIRMADOCONTADO", Me.ID_VALIDA_FIRMADOCONTADO)
                Me.TRANS.SetParametro("@pCEDULA", X.Cells("cEFCEDULA").Value)
                Me.TRANS.SetParametro("@pNOMBRE", X.Cells("cEFNOMBRE").Value)
                Me.TRANS.Ejecutar("SAVE_EXEPCION_FIRMADOCONTADO", CommandType.StoredProcedure)
            Next

            Me.Termina()
            Me.CAPTURAR_VALOR(Me.ID_VALIDA_FIRMADOCONTADO, Me.DESPUES_DTS)
            If Me.COMPARAR_ANTESvsDESPUES(strSQL, Me.ID_VALIDA_FIRMADOCONTADO) = True Then db.Ejecutar(strSQL, CommandType.Text)
            RaiseEvent AlertaGuardado()
        Catch ex As Exception
            Me.Cancelar()
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Sub

    Public Function ALL_VALIDACION(_ID_VALIDA_FIRMADOCONTADO As Integer) As DataTable
        Try
            db.AddParametro("@pID_VALIDA_FIRMADOCONTADO", _ID_VALIDA_FIRMADOCONTADO)
            Return db.Ejecutar("ALL_VALIDACION")
        Catch ex As Exception
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Function

    Public Function GET_VALIDACION(_ID_VALIDA_FIRMADOCONTADO As Integer) As DataTable
        Try
            db.AddParametro("@pID_VALIDA_FIRMADOCONTADO", _ID_VALIDA_FIRMADOCONTADO)
            Return db.Ejecutar("GET_VALIDACION")
        Catch ex As Exception
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Function

    Public Function CARGAR_EXEPCION_FIRMADOCONTADO(_ID_VALIDA_FIRMADOCONTADO As Integer) As DataTable
        Try
            db.AddParametro("@pID_VALIDA_FIRMADOCONTADO", _ID_VALIDA_FIRMADOCONTADO)
            Return db.Ejecutar("CARGAR_EXEPCION_FIRMADOCONTADO")
        Catch ex As Exception
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Function

End Class
