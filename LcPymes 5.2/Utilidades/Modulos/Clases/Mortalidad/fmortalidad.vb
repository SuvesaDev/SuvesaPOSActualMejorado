Imports System.data.SqlClient
Imports System.Data
Public Class fmortalidad
    Inherits Conexion
    Protected cnn As New SqlConnection
    Dim cmd As New SqlCommand
    Public Function buscar(ByVal texto As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("Consultar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id", texto)
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

        End Try
    End Function

    Public Function mostrar() As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("Mostrar_accion")
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

        End Try
    End Function

    Public Function insertar(ByVal dts As vmortalidad) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Insertar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@codigo", dts.gcodigo)
            cmd.Parameters.Add("@descripcion", dts.gdescripcion)
            cmd.Parameters.Add("@cantidad", dts.gcantidad)
            cmd.Parameters.Add("@fecha", dts.gfecha)
            cmd.Parameters.Add("@observacion", dts.gobservacion)
            cmd.Parameters.Add("@anulada", dts.ganulado)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally

        End Try
    End Function

    Public Function editar(ByVal dts As vmortalidad) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Modificar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id", dts.gid)
            cmd.Parameters.Add("@codigo", dts.gcodigo)
            cmd.Parameters.Add("@descripcion", dts.gdescripcion)
            cmd.Parameters.Add("@cantidad", dts.gcantidad)
            cmd.Parameters.Add("@fecha", dts.gfecha)
            cmd.Parameters.Add("@observacion", dts.gobservacion)
            cmd.Parameters.Add("@anulada", dts.ganulado)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally

        End Try
    End Function

    Public Function eliminar(ByVal dts As vmortalidad) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
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

        End Try

    End Function
End Class
