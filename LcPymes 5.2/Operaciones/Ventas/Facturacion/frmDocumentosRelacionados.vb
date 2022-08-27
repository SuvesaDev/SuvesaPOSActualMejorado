Imports System.Data
Public Class frmDocumentosRelacionados

    Public Property IdFactura As Long

    Private Sub CargarDatos()
        If Me.IdFactura > 0 Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("exec GetDocumentosVenta " & Me.IdFactura, dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmDocumentosRelacionados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

End Class