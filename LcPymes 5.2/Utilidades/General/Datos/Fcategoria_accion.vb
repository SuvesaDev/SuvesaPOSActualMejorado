Imports System.Data.SqlClient
Imports System.Data
Public Class Fcategoria_accion
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function buscar(ByVal texto As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("Consultar_categoria_accion")
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
            cmd = New SqlCommand("Mostrar_categoria_accion")
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

    Public Function insertar(ByVal dts As Vcategoria_accion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Insertar_categoria_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.AddWithValue("@categoria", dts.gnombre)
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

    Public Function editar(ByVal dts As Vcategoria_accion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Modificar_categoria_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.AddWithValue("@id", dts.gid)
            cmd.Parameters.AddWithValue("@categoria", dts.gnombre)
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

    Public Function eliminar(ByVal dts As Vcategoria_accion) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_categoria_accion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
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

