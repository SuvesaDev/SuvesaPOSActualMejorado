Imports System.Data
Imports System.Data.SqlClient

Public Class GestioDatos
    Private conexion As New SqlClient.SqlConnection(CadenaConexionSeePOS)
    Private adaptador As SqlClient.SqlDataAdapter
    Private comando As SqlClient.SqlCommand
    Public Function Ejecuta(ByVal sql As String) As DataTable
        Try
            Dim dts As New DataTable
            conexion.Open()
            adaptador = New SqlClient.SqlDataAdapter(sql, conexion)
            adaptador.SelectCommand.CommandType = CommandType.Text
            adaptador.Fill(dts)
            conexion.Close()
            Return dts
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub Comando_Trans(ByVal sql As String)
        Me.conexion.Open()
        Me.comando = New SqlClient.SqlCommand(sql, Me.conexion)
        Me.comando.CommandType = CommandType.StoredProcedure
        Me.comando.ExecuteNonQuery()
        Me.conexion.Close()
    End Sub
End Class
