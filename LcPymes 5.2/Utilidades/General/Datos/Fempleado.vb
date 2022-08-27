Imports System.Data.SqlClient
Imports System.Data
Public Class Fempleado
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function buscar(ByVal texto As String) As DataTable
        Try
            Conectar()
            cmd = New SqlCommand("Consultar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.AddWithValue("@cedula", texto)
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
            cmd = New SqlCommand("Mostrar_empleados")
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

    Public Function insertar(ByVal dts As Vempleado) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Insertar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.AddWithValue("@cedula", dts.gcedula)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellido)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@puesto", dts.gpuesto)
            cmd.Parameters.AddWithValue("@salario", dts.gsalario)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gfecha_ingreso)
            cmd.Parameters.AddWithValue("@fecha_salida", dts.gfecha_salida)
            cmd.Parameters.AddWithValue("@activo", dts.gactivo)
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

    Public Function editar(ByVal dts As Vempleado) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Modificar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.AddWithValue("@cedula", dts.gcedula)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellidos", dts.gapellido)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@puesto", dts.gpuesto)
            cmd.Parameters.AddWithValue("@salario", dts.gsalario)
            cmd.Parameters.AddWithValue("@fecha_ingreso", dts.gfecha_ingreso)
            cmd.Parameters.AddWithValue("@fecha_salida", dts.gfecha_salida)
            cmd.Parameters.AddWithValue("@activo", dts.gactivo)
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

    Public Function eliminar(ByVal dts As Vempleado) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_empleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = sQlconexion
            cmd.Parameters.Add("@cedula", SqlDbType.NVarChar, 50).Value = dts.gcedula
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
