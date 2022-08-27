Imports System.Data.SqlClient
Imports System.Data
Namespace Prestamos
    Public Class fprestamo_detalle
        Inherits Conexion
        Dim cmd As New SqlCommand

        Public Function buscar(ByVal texto As String, Optional ByVal _SPrestamo As Boolean = True) As DataTable
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Consultar_sdetalle_prestamo")
                Else
                    cmd = New SqlCommand("Consultar_detalle_prestamo")
                End If

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
        Public Function buscar_producto(ByVal texto As String, Optional ByVal _SPrestamo As Boolean = True) As DataTable
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Consultar_sproducto_prestamo")
                Else
                    cmd = New SqlCommand("Consultar_producto_prestamo")
                End If

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
        Public Function mostrar(Optional ByVal _SPrestamo As Boolean = True) As DataTable
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Mostrar_sdetalle_prestamo")
                Else
                    cmd = New SqlCommand("Mostrar_detalle_prestamo")
                End If

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

        Public Function insertar(ByVal dts As vprestamo_detalle, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Insertar_Sdetalle_prestamo")
                Else
                    cmd = New SqlCommand("Insertar_detalle_prestamo")
                End If

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                'cmd.Parameters.AddWithValue("@id", dts.gid)
                cmd.Parameters.AddWithValue("@id_prestamo", dts.gid_prestamo)
                cmd.Parameters.AddWithValue("@codigo", dts.gcodigo)
                cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
                cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
                cmd.Parameters.AddWithValue("@devuelto", dts.gdevuelto)
                cmd.Parameters.AddWithValue("@precio", dts.gprecio)
                cmd.Parameters.AddWithValue("@entregado", dts.gentregado)
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
                Return False
            Finally
                desconectado()
            End Try
        End Function

        Public Function editar(ByVal dts As vprestamo_detalle) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("Modificar_detalle_prestamo")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@id", dts.gid)
                cmd.Parameters.AddWithValue("@id_prestamo", dts.gid_prestamo)
                cmd.Parameters.AddWithValue("@codigo", dts.gcodigo)
                cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
                cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
                cmd.Parameters.AddWithValue("@devuelto", dts.gdevuelto)
                cmd.Parameters.AddWithValue("@precio", dts.gprecio)
                cmd.Parameters.AddWithValue("@entregado", dts.gentregado)
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

        Public Function eliminar(ByVal dts As vprestamo_detalle, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Eliminar_sdetalle_prestamo")
                Else
                    cmd = New SqlCommand("Eliminar_detalle_prestamo")
                End If

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
