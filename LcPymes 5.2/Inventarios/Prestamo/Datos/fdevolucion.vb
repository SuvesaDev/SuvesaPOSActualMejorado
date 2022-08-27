Imports System.Data.SqlClient
Imports System.Data
Namespace Prestamos
    Public Class fdevolucion
        Inherits Conexion
        Dim cmd As New SqlCommand

        Public Function buscar(ByVal texto As String) As DataTable
            Try
                conectado()
                cmd = New SqlCommand("Consultar_Devolucion_prestamo")
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
                cmd = New SqlCommand("Mostrar_Devolucion_prestamo")
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

        Public Function insertar(ByVal dts As vdevolucion) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("Insertar_Devolucion_prestamo")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                'cmd.Parameters.AddWithValue("@id", dts.gid)
                cmd.Parameters.AddWithValue("@id_detalle_prestamo", dts.gdetalleprestamo)
                cmd.Parameters.AddWithValue("@id_prestamo", dts.gprestamo)
                cmd.Parameters.AddWithValue("@codigo", dts.gcodigo)
                cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
                cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
                cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
                cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
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

        Public Function editar(ByVal dts As vdevolucion) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("Modificar_Devolucion_prestamo")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@id", dts.gid)
                cmd.Parameters.AddWithValue("@id_detalle_prestamo", dts.gdetalleprestamo)
                cmd.Parameters.AddWithValue("@id_prestamo", dts.gprestamo)
                cmd.Parameters.AddWithValue("@codigo", dts.gcodigo)
                cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
                cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
                cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
                cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
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

        Public Function eliminar(ByVal dts As vdevolucion) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("Eliminar_Devolucion_prestamo")
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
