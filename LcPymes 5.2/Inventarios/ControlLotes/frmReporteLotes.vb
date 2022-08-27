Imports System.Data
Public Class frmReporteLotes

    Private Sub CargarDatos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
    End Sub



End Class