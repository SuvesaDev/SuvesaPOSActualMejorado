Imports System.Data

Namespace Modulos
    Namespace FE
        Public Class Actividad_Economica
            Public db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Public ID_ACTIVIDAD As Integer
            Public CODIGO As String
            Public DESCRIPCION As String
            Public PRINCIPAL As Boolean

            Property GET_ACTIVIDAD_ECONOMICA_PRINCIPAL As DataTable

            Public Function ALL_ACTIVIDAD_ECONOMICA(_DESCRIPCION As String) As DataTable
                db.AddParametro("pDESCRIPCION", _DESCRIPCION)
                Return db.Ejecutar("ALL_ACTIVIDAD_ECONOMICA")
            End Function

            'Public Function GET_ACTIVIDAD_ECONOMICA(_ID As String) As DataTable
            '    db.AddParametro("pID", _ID)
            '    Return db.Ejecutar("GET_ACTIVIDAD_ECONOMICA")
            'End Function

            Public Function GET_LISTA_ACTIVIAD_x_CODIGO(_CODIGO As String) As DataTable
                db.AddParametro("pCODIGO", _CODIGO)
                Return db.Ejecutar("ALL_ACTIVIDAD_ECONOMICA")
            End Function

            Public Function GET_LISTA_ACTIVIAD_x_ACTIVIDAD(_CODIGO As String) As DataTable
                db.AddParametro("pACTIVIDAD", _CODIGO)
                Return db.Ejecutar("GET_LISTA_ACTIVIAD_x_ACTIVIDAD")
            End Function

        End Class

    End Namespace
End Namespace

