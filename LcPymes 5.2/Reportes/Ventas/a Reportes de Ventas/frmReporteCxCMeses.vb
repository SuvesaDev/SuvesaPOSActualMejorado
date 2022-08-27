Public Class frmReporteCxCMeses

    Private Sub ButtonMostrar_Click(sender As Object, e As EventArgs) Handles ButtonMostrar.Click
        If IsNumeric(Me.txtMeses.Text) Then
            Dim Reporte As New cxcVencidas
            Reporte.SetParameterValue(0, 1) 'Colones
            Reporte.SetParameterValue(1, True) 'Filtrar Incobrables
            Reporte.SetParameterValue(2, Me.FechaFinal.Value)
            Reporte.SetParameterValue(3, CInt(Me.txtMeses.Text))
            CrystalReportsConexion.LoadReportViewer(Me.VisorReporte, Reporte)
        Else
            MsgBox("El campo meses debe ser un valor numerico", MsgBoxStyle.Exclamation, Text)
            Me.txtMeses.Focus()
        End If        
    End Sub

    Private Sub frmReporteCxCMeses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FechaFinal.Value = Date.Now
        Me.WindowState = FormWindowState.Maximized
    End Sub

End Class