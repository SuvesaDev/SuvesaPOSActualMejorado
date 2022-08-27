Imports System.Data.SqlClient
Imports System.Data
Namespace Prestamos
    Public Class fempresas
        Inherits Conexion
        Dim cmd As New SqlCommand

        Public Function buscar(ByVal texto As String) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("Consultar_empresa")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@id", texto)
                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

        Public Function mostrar() As DataTable
            Try
                conectado()
                cmd = New SqlCommand("Mostrar_empresa")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                If cmd.ExecuteNonQuery Then
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            Finally
                desconectado()
            End Try
        End Function

        Public Function insertar(ByVal dts As vempresa) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("Insertar_empresa")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                'cmd.Parameters.AddWithValue("@id", dts.gid)
                cmd.Parameters.AddWithValue("@empresa", dts.gdescripcion)

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                desconectado()
            End Try
        End Function

        Public Function editar(ByVal dts As vempresa) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("Modificar_empresa")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@id", dts.gid)
                cmd.Parameters.AddWithValue("@empresa", dts.gdescripcion)
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                desconectado()
            End Try
        End Function

        Public Function eliminar(ByVal dts As vempresa) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("Eliminar_empresa")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.gid
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            Finally
                desconectado()
            End Try

        End Function
    End Class

End Namespace
