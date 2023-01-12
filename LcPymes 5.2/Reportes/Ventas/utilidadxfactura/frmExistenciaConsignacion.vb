Public Class frmExistenciaConsignacion

    Private Sub cargarBodega()
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("select 0 as Id, 'MOSTRAR TODAS' as Nombre union select Id_Bodega, Nombre_Bodega from bodegas ", dt, CadenaConexionSeePOS)
        Me.cboBodega.DataSource = dt
        Me.cboBodega.DisplayMember = "Nombre"
        Me.cboBodega.ValueMember = "Id"
    End Sub

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        Try
            Dim rpt As New rptBodegaConsignacion
            rpt.Refresh()
            rpt.SetParameterValue(0, Me.cboBodega.SelectedValue)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , CadenaConexionSeePOS)
            VisorReporte.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub frmExistenciaConsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.cargarBodega()
    End Sub

End Class