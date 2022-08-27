Public Class frm_dashboard

    Private Sub frm_dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = GetSetting("SeeSOFT", "Seepos", "Conexion")
        Me.AdapterAperturaCaja.Fill(Me.DataSet_dasboard1.dasboard_aperturas)
    End Sub
End Class