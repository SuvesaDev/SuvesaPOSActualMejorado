Imports System.Data
Namespace Modulos
    Namespace FE
        Public Class Cabys
            Private db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Public Function GetCabys(_id As String, _nivel As Integer, _texto As String) As DataTable
                db.AddParametro("@ID", _id)
                db.AddParametro("@NIVEL", _nivel)
                db.AddParametro("@TEXTO", _texto)
                Return db.Ejecutar("GETCABYS")
            End Function

            Public Function NAVEGADOR_CABYS(_descripcion As String, _opcion As Integer) As DataTable
                db.AddParametro("@Descripcion", _descripcion)
                db.AddParametro("@OPCION", _opcion)
                Return db.Ejecutar("NAVEGADOR_CABYS")
            End Function

        End Class
    End Namespace
End Namespace
