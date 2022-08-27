Imports System.Data
Imports System.Data.SqlClient
Public Class Faccion
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function buscar(ByVal texto As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("Consultar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
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
            Conectar()
            cmd = New SqlCommand("Mostrar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
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

    Public Function insertar(ByVal dts As Vaccion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Insertar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.AddWithValue("@id_empleado", dts.gid_empleado)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@id_categoria", dts.gid_categoria)
            cmd.Parameters.AddWithValue("@fecha_inicio", dts.gfecha_inicio)
            cmd.Parameters.AddWithValue("@fecha_fin", dts.gfecha_fin)
            cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            cmd.Parameters.AddWithValue("@anulada", dts.ganulado)
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

    Public Function editar(ByVal dts As Vaccion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Modificar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.AddWithValue("@id", dts.gid)
            cmd.Parameters.AddWithValue("@id_empleado", dts.gid_empleado)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@id_categoria", dts.gid_categoria)
            cmd.Parameters.AddWithValue("@fecha_inicio", dts.gfecha_inicio)
            cmd.Parameters.AddWithValue("@fecha_fin", dts.gfecha_fin)
            cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            cmd.Parameters.AddWithValue("@anulada", dts.ganulado)
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

    Public Function eliminar(ByVal dts As Vaccion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.Add("@cedula", SqlDbType.NVarChar, 50).Value = dts.gid
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

