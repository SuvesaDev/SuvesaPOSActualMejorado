Module VariablesGlobales

    'Public CadenaConexionSeePOS As String = GetSetting("SeeSOFT", "SeePOS", "Conexion")
    'Public CadenaConexionSeguridad As String = GetSetting("SeeSOFT", "Seguridad", "Conexion")

    Private Clinica As Boolean = False

    Public Sub ObtenerClinica()
        'cargar esta funcion en el inicio del sistema para saber si es o no es clinica
        Dim dt As New System.Data.DataTable
        Try
            cFunciones.Llenar_Tabla_Generico("select clinica from configuraciones", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Clinica = dt.Rows(0).Item("Clinica")
            End If
        Catch ex As Exception
            Clinica = False
        End Try
    End Sub

    Public Function IsClinica() As Boolean
        Return Clinica
    End Function

    Public Function ImpresoraCredito() As String
        'deveria sacarlo de un configuracion.

        Dim PrintDocument1 As New System.Drawing.Printing.PrintDocument
        Dim PrinterDialog As New System.Windows.Forms.PrintDialog
        Dim DocPrint As New System.Drawing.Printing.PrintDocument
        PrinterDialog.Document = DocPrint
        If PrinterDialog.ShowDialog() = DialogResult.OK Then
            Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
        Else
            Return ""
        End If
        Return ""
    End Function

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
