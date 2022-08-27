Imports System.Data
Public Class frmConsultarToken

    Private Sub CargarDatos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from viewTokenSolicitados order by Fecha Desc", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Id").Visible = False
        Me.viewDatos.Columns("IdUsuarioSolicita").Visible = False
        Me.viewDatos.Columns("Codigo").Visible = False
        Me.viewDatos.Columns("fecha").DefaultCellStyle.Format = "t"
    End Sub

    Private Sub frmConsultarToken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

    Private Sub frmConsultarToken_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Me.CargarDatos()
    End Sub
End Class