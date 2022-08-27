Imports System.Data.SqlClient
Imports System.Data
Namespace Prestamos
    Public Class fprestamo
        Inherits Conexion
        Dim cmd As New SqlCommand

        Public Function buscar(ByVal texto As String, Optional ByVal _ConsultaBoleta As Boolean = False, Optional ByVal _SPrestamo As Boolean = True) As DataTable
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Consultar_SPrestamo")
                Else
                    cmd = New SqlCommand("Consultar_Prestamo")
                End If

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@id", texto)
                cmd.Parameters.AddWithValue("@ConsultaBoleta", _ConsultaBoleta)
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
        Public Function mostrar_productos() As DataTable
            Try
                conectado()
                cmd = New SqlCommand("Mostrar_Productos")
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
        Public Function mostrar(Optional ByVal _SPrestamos As Boolean = True) As DataTable
            Try
                conectado()

                If _SPrestamos = True Then
                    cmd = New SqlCommand("Mostrar_SPrestamo")
                Else
                    cmd = New SqlCommand("Mostrar_Prestamo")
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

        Public Function insertar(ByVal dts As vprestamo, _IdUsuarioCreo As String, _BoletaProveedor As String, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            Try
                conectado()
                If _SPrestamo = True Then
                    cmd = New SqlCommand("Insertar_SPrestamo")
                Else
                    cmd = New SqlCommand("Insertar_Prestamo")
                End If
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                'cmd.Parameters.AddWithValue("@id", dts.gid)
                cmd.Parameters.AddWithValue("@boleta", dts.gboleta)
                cmd.Parameters.AddWithValue("@destinatario", dts.gdestinatario)
                cmd.Parameters.AddWithValue("@nombre_destinatario", dts.gnombre_destinatario)
                cmd.Parameters.AddWithValue("@destino", dts.gdestino)
                cmd.Parameters.AddWithValue("@nombre_destino", dts.gnombre_destino)
                cmd.Parameters.AddWithValue("@transportista", dts.gtransportista)
                cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
                cmd.Parameters.AddWithValue("@estado", dts.gestado)
                cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
                cmd.Parameters.AddWithValue("@entrada", dts.gentrada)
                cmd.Parameters.AddWithValue("@salida", dts.gsalida)
                cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
                cmd.Parameters.AddWithValue("@Id_UsuariCreo", _IdUsuarioCreo)
                cmd.Parameters.AddWithValue("@BoletaProveedor", _BoletaProveedor)
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

        Public Function editar(ByVal dts As vprestamo, _IdUsuarioCreo As String, _BoletaProveedor As String, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Modificar_SPrestamo")
                Else
                    cmd = New SqlCommand("Modificar_Prestamo")
                End If

                cmd.CommandType = CommandType.StoredProcedure
                cmd.Connection = cnn
                cmd.Parameters.AddWithValue("@boleta", dts.gboleta)
                cmd.Parameters.AddWithValue("@destinatario", dts.gdestinatario)
                cmd.Parameters.AddWithValue("@nombre_destinatario", dts.gnombre_destinatario)
                cmd.Parameters.AddWithValue("@destino", dts.gdestino)
                cmd.Parameters.AddWithValue("@nombre_destino", dts.gnombre_destino)
                cmd.Parameters.AddWithValue("@transportista", dts.gtransportista)
                cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
                cmd.Parameters.AddWithValue("@estado", dts.gestado)
                cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
                cmd.Parameters.AddWithValue("@entrada", dts.gentrada)
                cmd.Parameters.AddWithValue("@salida", dts.gsalida)
                cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
                cmd.Parameters.AddWithValue("@Id_UsuariCreo", _IdUsuarioCreo)
                cmd.Parameters.AddWithValue("@BoletaProveedor", _BoletaProveedor)
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

        Public Function eliminar(ByVal dts As vprestamo, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            Try
                conectado()

                If _SPrestamo = True Then
                    cmd = New SqlCommand("Eliminar_SPrestamo")
                Else
                    cmd = New SqlCommand("Eliminar_Prestamo")
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
        Public Function cambiar_estado(ByVal dts As vprestamo) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("prestamo_entregado")
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
        Public Function entregado(ByVal dts As vprestamo) As Boolean
            Try
                conectado()
                cmd = New SqlCommand("entregado_prestamo")
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
