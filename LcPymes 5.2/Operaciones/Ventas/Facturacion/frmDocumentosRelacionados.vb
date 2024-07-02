Imports System.Data
Public Class frmDocumentosRelacionados

    Public Property IdFactura As Long

    Public Property IdCompra As Long


    Private Sub CargarDatos()
        If Me.IdFactura > 0 Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("exec GetDocumentosVenta " & Me.IdFactura, dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt

            Me.viewDatos.Columns("Abono").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Abono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Else

            If Me.IdCompra > 0 Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("exec GetDocumentosCompras2 " & Me.IdCompra, dt, CadenaConexionSeePOS)
                Me.viewDatos.DataSource = dt
                Me.viewDatos.Columns("Abono").DefaultCellStyle.Format = "N2"
                Me.viewDatos.Columns("Abono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmDocumentosRelacionados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

End Class