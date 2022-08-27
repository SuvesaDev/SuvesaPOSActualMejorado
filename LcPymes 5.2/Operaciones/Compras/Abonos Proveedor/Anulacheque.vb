Imports System.Data
Imports System.Data.SqlClient
Public Class Anulacheque

    Private Conn As New SqlConnection
    Private Adap As SqlDataAdapter

    Private BANCOS As String = GetSetting("SeeSoft", "Bancos", "Conexion")
    Private CONTABILIDAD As String = GetSetting("SeeSoft", "Contabilidad", "Conexion")
    Private SEEPOS As String = CadenaConexionSeePOS

    Private Function ejecuta(ByVal _strSQL As String, ByVal _db As String) As DataTable
        Try
            Dim dt As New DataTable
            Conn = New SqlConnection(_db)
            Conn.Open()
            Adap = New SqlDataAdapter(_strSQL, Conn)
            Adap.SelectCommand.CommandType = CommandType.Text
            Adap.Fill(dt)
            Conn.Close()
            Return dt
        Catch ex As Exception
            Conn.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return Nothing
        End Try
    End Function

    Private Function Existe(ByVal _tabla As String, ByVal _culumna As String, ByVal _valor As String, ByVal _bd As String) As Boolean
        Return IIf(ejecuta("select * from " & _tabla & " where " & _culumna & " = '" & _valor & "'", _bd).Rows.Count > 0, True, False)
    End Function

    Public Sub EliminarCheque(ByVal _num_cheque As String, ByVal cheque As Boolean, ByVal _cuenta As String, ByVal _id_cuenta As Integer)
        Dim dt As New DataTable

        Try
            If cheque = True Then

                cFunciones.Llenar_Tabla_Generico("select * from Cheques where Num_Cheque = " & _num_cheque, dt, BANCOS)
                If Existe("Cheques_Detalle", "Id_Cheque", dt.Rows(0).Item("Id_Cheque"), BANCOS) Then
                    ejecuta("delete from  Cheques_Detalle where Id_Cheque = " & dt.Rows(0).Item("Id_Cheque"), BANCOS)
                End If
                If dt.Rows(0).Item("Asiento") = "0" Then
                    ejecuta("delete from cheques  where num_cheque = '" & _num_cheque & "' and Id_CuentaBancaria = " & _id_cuenta, BANCOS)
                    ejecuta("delete abonocpagar  where documento = " & _num_cheque & " and TipoDocumento = 'CHEQUE' or TipoDocumento = 'TRANFERENCIA'  and CuentaBancaria = '" & _cuenta & "'", SEEPOS)
                Else
                    ejecuta("delete from DetallesAsientosContable where NumAsiento = '" & dt.Rows(0).Item("Asiento") & "'", CONTABILIDAD)
                    ejecuta("delete from dbo.AsientosContables where NumAsiento = '" & dt.Rows(0).Item("Asiento") & "'", CONTABILIDAD)
                    ejecuta("delete from cheques  where num_cheque = '" & _num_cheque & "' and Id_CuentaBancaria = " & _id_cuenta, BANCOS)
                    ejecuta("delete abonocpagar  where documento = " & _num_cheque & " and TipoDocumento = 'CHEQUE' and CuentaBancaria = '" & _cuenta & "'", SEEPOS)
                End If

            Else
                'cFunciones.Llenar_Tabla_Generico("select * from TransferenciasBancarias where Num_Transferencia = " & _num_cheque, dt, BANCOS)
                'If dt.Rows(0).Item("Num_Asiento") = "0" Then
                'ejecuta("update TransferenciasBancarias set Num_Transferencia = 0, anula = 1" & _num_cheque & "'", BANCOS)
                ' Else
                ' ejecuta("delete from DetallesAsientosContable where NumAsiento = '" & dt.Rows(0).Item("Num_Asiento") & "'", CONTABILIDAD)
                ' ejecuta("delete from dbo.AsientosContables where NumAsiento = '" & dt.Rows(0).Item("Num_Asiento") & "'", CONTABILIDAD)
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "No se pudo aliminar el documento")
        End Try
    End Sub

End Class
