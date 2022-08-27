Imports System.Data.SqlClient
Imports System.Data
Namespace Prestamos
    Public Class Conexion
        Protected cnn As New SqlConnection
        Public sQlconexion As New SqlConnection
        Public SQLStringConexion As String
        Public Function conectado()
            Try
                If CadenaConexionSeePOS = "" Then
                    SaveSetting("seesoft", "seepos", "conexion", "Data Source=.; Initial Catalog=seepos; Integrated Security=true;")
                End If
                cnn = New SqlConnection(CadenaConexionSeePOS)
                cnn.Open()
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function desconectado()
            Try
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
        Public Function guardar(ByRef Table As Object, ByRef Campos As Object, ByRef Datos As Object) As String

            Dim Command As SqlCommand
            Dim Mensaje As String
            conectado()

            Command = New SqlCommand("INSERT INTO " & Table & " (" & Campos & ") VALUES (" & Datos & ")", cnn)
            Try
                Command.ExecuteNonQuery()
            Catch ex As Exception
                Mensaje = ex.Message
            Finally
                Command.Dispose()
                Command = Nothing
                cnn.Close()
                cnn.Dispose()

            End Try
            Return Mensaje
        End Function
        Public Function actualizar(ByRef Table As String, ByRef Datos As String, ByRef Condicion As String) As String
            Dim Command As SqlCommand
            Dim Mensaje As String

            conectado()

            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos & " WHERE " & Condicion, cnn)

            Try
                Command.ExecuteNonQuery()
            Catch ex As Exception
                Mensaje = ex.Message
                MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
            Finally
                Command.Dispose()
                Command = Nothing
                cnn.Close()
                cnn.Dispose()
            End Try
            Return Mensaje
        End Function
    End Class
End Namespace
