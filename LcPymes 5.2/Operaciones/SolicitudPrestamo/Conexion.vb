
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Collections.Generic

Namespace OBSoluciones
    '@utor 
    'Ing. Rolando Obnado Rojas
    'TI OBSoluciones 
    Namespace MySql
        Public Class Sentencias
            Private Conexion As New MySqlConnection
            Private Adapter As MySqlDataAdapter
            Private Parametros As New List(Of MySqlParameter)

            Sub New(ByVal _Cadena As String)
                Me.Conexion = New MySqlConnection(_Cadena)
            End Sub

            Public Sub AddParametro(ByVal _nombre As String, ByVal _valor As Object)
                Parametros.Add(New MySqlParameter(_nombre, _valor))
            End Sub
            Public Sub AddParametrosSalida(ByVal _nombre As String, ByVal _valor As String)
                Dim parametro As New MySqlParameter(_nombre, MySqlDbType.String)
                parametro.Value = _valor
                parametro.Direction = ParameterDirection.InputOutput
                Parametros.Add(parametro)
            End Sub
            Public Sub AddParametroSalida(ByVal _nombre As String, ByVal _valor As Integer)
                Dim parametro As New MySqlParameter(_nombre, MySqlDbType.Int64)
                parametro.Value = _valor
                parametro.Direction = ParameterDirection.InputOutput
                Parametros.Add(parametro)
            End Sub

            Public Function ProbarConexion(_Con As String) As String
                Try
                    Me.Conexion = New MySqlConnection(_Con)
                    Me.Conexion.Open()
                    Me.Conexion.Close()
                    Return "Correcto!!!"
                Catch ex As Exception
                    Return ex.Message
                End Try
            End Function

            Public Function Ejecutar(ByVal _strSQL As String, Optional ByVal _Tipo As CommandType = CommandType.StoredProcedure) As DataTable
                Try
                    Dim dt As New DataTable
                    Me.Conexion.Open()
                    Me.Adapter = New MySqlDataAdapter(_strSQL, Me.Conexion)
                    Me.Adapter.SelectCommand.CommandType = _Tipo
                    Me.Adapter.SelectCommand.Parameters.AddRange(Me.Parametros.ToArray)
                    Me.Adapter.Fill(dt)
                    Me.Conexion.Close()
                    Me.Parametros.Clear()
                    Return dt
                Catch ex As Exception
                    Conexion.Close()
                    Me.Parametros.Clear()
                    Return Nothing
                End Try
            End Function
            Public Function Ejecutar(ByRef _ID As String, ByVal _index As Int16, ByVal _strSQL As String) As DataTable
                Try
                    Dim dt As New DataTable
                    Me.Conexion.Open()
                    Me.Adapter = New MySqlDataAdapter(_strSQL, Me.Conexion)
                    Me.Adapter.SelectCommand.CommandType = CommandType.StoredProcedure
                    Me.Adapter.SelectCommand.Parameters.AddRange(Me.Parametros.ToArray)
                    Me.Adapter.Fill(dt)
                    Me.Conexion.Close()
                    _ID = Parametros.Item(_index).Value
                    Me.Parametros.Clear()
                    Return dt
                Catch ex As Exception
                    Conexion.Close()
                    Me.Parametros.Clear()
                    Return Nothing
                End Try
            End Function
        End Class
        Public Class Transaccion
            Private Conexion As MySqlConnection
            Private Comando As MySqlCommand
            Private Transaccion As MySqlTransaction
            Private Parametros As New List(Of MySqlParameter)
            Sub New(ByVal _Cadena As String)
                Me.Conexion = New MySqlConnection(_Cadena)
                Me.Conexion.Open()
                Me.Transaccion = Me.Conexion.BeginTransaction()
            End Sub
            Public Sub ParametroEntrada(ByVal _nombre As String, ByVal _valor As Object)
                Parametros.Add(New MySqlParameter(_nombre.Replace(" ", ""), _valor))
            End Sub
            Public Sub ParametroSalida(ByVal _nombre As String, ByVal _valor As Integer)
                Dim parametro As New MySqlParameter(_nombre, MySqlDbType.Int64)
                parametro.Value = _valor
                parametro.Direction = ParameterDirection.InputOutput
                Parametros.Add(parametro)
            End Sub
            Public Sub ParametroSalida(ByVal _nombre As String, ByVal _valor As Decimal)
                Dim parametro As New MySqlParameter(_nombre, MySqlDbType.Decimal)
                parametro.Value = _valor
                parametro.Direction = ParameterDirection.InputOutput
                Parametros.Add(parametro)
            End Sub
            Public Sub ParametroSalida(ByVal _nombre As String, ByVal _valor As Long)
                Dim parametro As New MySqlParameter(_nombre, MySqlDbType.Int64)
                parametro.Value = _valor
                parametro.Direction = ParameterDirection.InputOutput
                Parametros.Add(parametro)
            End Sub
            Public Sub ParametroSalida(ByVal _nombre As String, ByVal _valor As String)
                Dim parametro As New MySqlParameter(_nombre, MySqlDbType.Text)
                parametro.Value = _valor
                parametro.Direction = ParameterDirection.InputOutput
                Parametros.Add(parametro)
            End Sub
            Public Sub Commit()
                Me.Transaccion.Commit()
                Me.Transaccion.Dispose()
                Me.Conexion.Close()
            End Sub
            Public Sub Rollback()
                Try
                    Me.Transaccion.Rollback()
                Catch ex As Exception
                End Try
                Try
                    Me.Transaccion.Dispose()
                Catch ex As Exception
                End Try
                Try
                    Me.Conexion.Close()
                Catch ex As Exception
                End Try
            End Sub
            Public Sub Ejecutar(ByVal _strSQL As String, Optional ByVal _Tipo As CommandType = CommandType.StoredProcedure)
                Me.Comando = New MySqlCommand(_strSQL, Me.Conexion)
                Me.Comando.CommandType = _Tipo
                Me.Comando.Parameters.AddRange(Me.Parametros.ToArray)
                Me.Comando.Transaction = Me.Transaccion
                Me.Comando.ExecuteNonQuery()
                Me.Parametros.Clear()
            End Sub
            Public Sub Ejecutar(ByVal _strSQL As String, ByRef _ID1 As String, ByVal _index1 As Int16, Optional ByRef _ID2 As String = "", Optional ByVal _index2 As Int16 = 0)
                Me.Comando = New MySqlCommand(_strSQL, Me.Conexion)
                Me.Comando.CommandType = CommandType.StoredProcedure
                Me.Comando.Parameters.AddRange(Me.Parametros.ToArray)
                Me.Comando.Transaction = Me.Transaccion
                Me.Comando.ExecuteNonQuery()
                _ID1 = Parametros.Item(_index1).Value
                _ID2 = Parametros.Item(_index2).Value
                Me.Parametros.Clear()
            End Sub
        End Class
    End Namespace
End Namespace


