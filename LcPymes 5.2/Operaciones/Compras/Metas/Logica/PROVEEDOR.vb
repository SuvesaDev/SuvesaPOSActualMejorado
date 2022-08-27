'@utor: 
'ing.Rolando Obando Rojas.
'SysScript 2015
Imports System.Data
Public Class PROVEEDOR
    Public TRANS As OBSoluciones.SQL.Transaccion
    Public ID_PROVEEDOR As Integer
    Public NOMBRE As String

    Public Event AlertaError(ByVal msg As String)
    Public Event AlertaGuardado()

    Private Sub Inicia()
        Me.TRANS = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
    End Sub

    Private Sub Termina()
        Me.TRANS.Commit()
    End Sub

    Private Sub Cancelar()
        Me.TRANS.Rollback()
    End Sub


    Public Function BUSCAR_PROVEEDOR(_NOMBRE As String) As DataTable
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.AddParametro("@NOMBRE", _NOMBRE)
            Return db.Ejecutar("BUSCAR_PROVEEDOR")
        Catch ex As Exception
            RaiseEvent AlertaError(ex.Message)
        End Try
    End Function

End Class
