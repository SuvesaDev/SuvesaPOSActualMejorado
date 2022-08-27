Imports System.Data.SqlClient
Imports System.Data
Namespace Prestamos
    Public Class cFunciones
        Public Shared Descripcion As String
        Public Shared Function Cargar_Tabla_Generico(ByRef DataAdapter As SqlDataAdapter, ByVal SQLCommand As String, Optional ByVal NuevaConexionStr As String = "") As DataTable
            Dim StringConexion As String = IIf(NuevaConexionStr = "", CadenaConexionSeePOS, NuevaConexionStr) 'JCGA 19032007
            Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
            Dim Tabla As New DataTable
            Dim Comando As SqlCommand = New SqlCommand
            Try
                ConexionX.Open()
                Comando.CommandText = SQLCommand
                Comando.Connection = ConexionX
                Comando.CommandType = CommandType.Text
                Comando.CommandTimeout = 90
                DataAdapter.SelectCommand = Comando
                DataAdapter.Fill(Tabla)
            Catch ex As System.Exception
                MsgBox(ex.ToString) ' Si hay error, devolvemos un valor nulo.
                Return Nothing
            Finally
                If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                    ConexionX.Close()
                End If
            End Try
            Return Tabla ' Devolvemos el objeto DataTable con los datos de la consulta
        End Function

        Public Shared Function Llenar_Tabla_Generico(ByVal SQLCommand As String, ByRef Tabla As DataTable, Optional ByVal NuevaConexionStr As String = "")
            Dim StringConexion As String
            StringConexion = IIf(NuevaConexionStr = "", CadenaConexionSeePOS, NuevaConexionStr)

            Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
            Dim Comando As SqlCommand = New SqlCommand
            Try
                ConexionX.Open()
                Comando.CommandText = SQLCommand
                Comando.Connection = ConexionX
                Comando.CommandType = CommandType.Text
                Comando.CommandTimeout = 90
                Dim da As New SqlDataAdapter
                da.SelectCommand = Comando
                Tabla.Clear()
                da.Fill(Tabla)
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta..") ' Si hay error, devolvemos un valor nulo.
                Return Nothing
            Finally
                If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                    ConexionX.Close()
                End If
            End Try
        End Function
    End Class
End Namespace
