Imports System.Data
Namespace Modulos
    Namespace FE
        Public Class FACTURA_ELECTRONICA_COMPRA

            Public db As OBSoluciones.SQL.Sentencias


            Public Function GET_IMPUESTOS() As DataTable
                Me.db = New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                Return db.Ejecutar("SELECT * FROM VIEWIMPUESTOS", CommandType.Text)
            End Function

            Public Function Obtener_Provincia() As DataTable
                Dim dt As New DataTable
                Me.db = New OBSoluciones.SQL.Sentencias(CadenaConexionSeguridad)
                dt = db.Ejecutar("SELECT DISTINCT ID_PROVINCIA, PROVINCIA FROM Ubicacion", CommandType.Text)
                Return dt
            End Function

            Public Function Obtener_Canton(_IdProvincia As Integer) As DataTable
                Me.db = New OBSoluciones.SQL.Sentencias(CadenaConexionSeguridad)
                Dim dt As New DataTable
                dt = db.Ejecutar("SELECT DISTINCT ID_CANTON, CANTON FROM Ubicacion WHERE ID_PROVINCIA =" & _IdProvincia, CommandType.Text)
                Return dt
            End Function

            Public Function Obtener_Distrito(_IdProvincia As Integer, _IdCanton As Integer) As DataTable
                Me.db = New OBSoluciones.SQL.Sentencias(CadenaConexionSeguridad)
                Dim dt As New DataTable
                dt = db.Ejecutar("SELECT DISTINCT ID_DISTRITO, DISTRITO FROM Ubicacion WHERE ID_PROVINCIA = " & _IdProvincia & " AND ID_CANTON = " & _IdCanton, CommandType.Text)
                Return dt
            End Function

        End Class
    End Namespace
End Namespace

