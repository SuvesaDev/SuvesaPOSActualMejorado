Module VariablesGlobales

    'Public CadenaConexionSeePOS As String = GetSetting("SeeSOFT", "SeePOS", "Conexion")
    'Public CadenaConexionSeguridad As String = GetSetting("SeeSOFT", "Seguridad", "Conexion")

    Public Function GetRegistroSeePOS(_Registro As String, Optional ByVal _Crear As Boolean = True, Optional ByVal _ValorDefecto As String = "0") As String
        Dim resultado As String = GetSetting("SeeSOFT", "SeePOS", _Registro)
        If resultado = "" And _Crear = True Then
            SaveSetting("SeeSOFT", "SeePOS", _Registro, _ValorDefecto)
            resultado = _ValorDefecto
        End If
        Return resultado
    End Function

    Public Function CadenaConexionSeePOS() As String
        Return GetSetting("SeeSOFT", "SeePOS", "Conexion")
    End Function

    Public Function CadenaConexionTaller() As String
        Dim cadena As String = GetSetting("SeeSOFT", "SeePOS", "ConexionTaller")
        If cadena = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "ConexionTaller", CadenaConexionSeePOS.Replace("SeePOS", "Taller"))
            cadena = GetSetting("SeeSOFT", "SeePOS", "ConexionTaller")
        End If
        Return cadena
    End Function

    Public Function CadenaConexionMascotas() As String
        Dim cadena As String = GetSetting("SeeSOFT", "SeePOS", "ConexionMascotas")
        If cadena = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "ConexionMascotas", CadenaConexionSeePOS.Replace("SeePOS", "Mascotas"))
            cadena = GetSetting("SeeSOFT", "SeePOS", "ConexionMascotas")
        End If
        Return cadena
    End Function

    Public Function CadenaConexionCedulas() As String
        Return GetSetting("SeeSOFT", "SeePOS", "datos_cedulas")
    End Function

    Public Function CadenaConexionSeguridad() As String
        Return GetSetting("SeeSOFT", "Seguridad", "Conexion")
    End Function

    Public Function TablaSeguridad() As String
        Return "Seguridad"
    End Function

End Module
