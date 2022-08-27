'@utor: 
'ing.Rolando Obando Rojas.
'SysScript 2015
Imports System.Data
Public Class PROVEEDOR_META
    Public TRANS As OBSoluciones.SQL.Transaccion
    Public ID_PROVEEDOR_META As Integer
    Public CODIGOPROV As Integer
    Public MENSUAL As Long
    Public FECHA As Date
    Public ANULADO As Integer
    Public ID_USUARIO As String = "0"
    Public ANTES_DTS As New DataTable
    Public DESPUES_DTS As New DataTable

    Public Event AlertaError(ByVal msg As String)
    Public Event AlertaGuardado()

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
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.AddParametro("@ID_PROVEEDOR_META", _ID)
            _DTS = db.Ejecutar("GET_PROVEEDOR_META")
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
        cmd = cmd.Replace("@MODULO", "PROVEEDOR_META")
        cmd = cmd.Replace("@ID_DOCUMENTO", _ID)
        cmd = cmd.Replace("@ID_USUARIO", Me.ID_USUARIO)
        cmd = cmd.Replace("@OBSERVACIONES", Cambios)
        _strSQL = cmd
        Return TieneBitacora
    End Function

    Public Sub SAVE_PROVEEDOR_META()
        Try            
            Me.Inicia()
            Me.TRANS.SetParametro("@ID_PROVEEDOR_META", Me.ID_PROVEEDOR_META)
            Me.TRANS.SetParametro("@CODIGOPROV", Me.CODIGOPROV)
            Me.TRANS.SetParametro("@MENSUAL", Me.MENSUAL)
            Me.TRANS.SetParametro("@FECHA", Me.FECHA)
            Me.TRANS.SetParametro("@ANULADO", Me.ANULADO)
            Me.TRANS.Ejecutar("SAVE_PROVEEDOR_META")
            Me.Termina()           
            RaiseEvent AlertaGuardado()
        Catch ex As Exception
            Me.Cancelar()
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Sub

    Public Function ALL_PROVEEDOR_META(_NOMBRE As String) As DataTable
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.AddParametro("@NOMBRE", _NOMBRE)
            Return db.Ejecutar("ALL_PROVEEDOR_META")
        Catch ex As Exception
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Function

    Public Function GET_PROVEEDOR_META(_ID_PROVEEDOR_META As Integer) As DataTable
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.AddParametro("@ID_PROVEEDOR_META", _ID_PROVEEDOR_META)
            Return db.Ejecutar("GET_PROVEEDOR_META")
        Catch ex As Exception
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Function

    Public Sub ANULAR_PROVEEDOR_META(_ID_PROVEEDOR_META As Integer, _ANULADO As Integer)
        Try
            Me.Inicia()
            Me.TRANS.SetParametro("@ID_PROVEEDOR_META", _ID_PROVEEDOR_META)
            Me.TRANS.SetParametro("@ANULADO", _ANULADO)
            Me.TRANS.Ejecutar("ANULAR_PROVEEDOR_META")
            Me.Termina()
            RaiseEvent AlertaGuardado()
        Catch ex As Exception
            Me.Cancelar()
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Sub

End Class
