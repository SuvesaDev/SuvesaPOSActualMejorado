Public Class frmSetting

    Private Sub Cargar()
        Try
            Me.txtUsuario.Text = GetSetting("SeeSOFT", "Seguridad", "UsuarioApiTienda")
            Me.txtClave.Text = GetSetting("SeeSOFT", "Seguridad", "ClaveApiTienda")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "Seguridad", "UsuarioApiTienda", "ck_60c995c24899da765280530086acae76c56997d4")
            SaveSetting("SeeSOFT", "Seguridad", "ClaveApiTienda", "cs_a2f3adcf4899b0cc7259a4c2604f231e9a14d19b")
        End Try
    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Me.txtClave.Text = "" And Me.txtUsuario.Text = "" Then
            Me.txtUsuario.Text = "ck_60c995c24899da765280530086acae76c56997d4"
            Me.txtClave.Text = "cs_a2f3adcf4899b0cc7259a4c2604f231e9a14d19b"
        End If

        SaveSetting("SeeSOFT", "Seguridad", "UsuarioApiTienda", Me.txtUsuario.Text)
        SaveSetting("SeeSOFT", "Seguridad", "ClaveApiTienda", Me.txtClave.Text)

        Me.Close()
    End Sub
End Class