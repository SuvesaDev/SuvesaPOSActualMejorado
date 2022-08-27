Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Public Module Principal

    Dim usua As Usuario_Logeado
    Public GetSettingConexion As String
    Dim Usuario As New Frm_login
    Private Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal pVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer 'MLHIDE
    Public Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long) 'MLHIDE

    Private Sub Command1_Click()
        Dim Pantalla As New DevExpress.XtraEditors.PictureEdit
        'Captura la ventana activa
        keybd_event(44, 0, 0&, 0&)
    End Sub

    Private Sub Command2_Click()
        'Captura toda la pantalla
        keybd_event(44, 1, 0&, 0&)
    End Sub

    Sub Main()
        ModuleXP.InitXP()
        Try
            If GetSetting("SeeSOFT", "SeePOS", "PVE") = "" Then SaveSetting("SeeSOFT", "SeePOS", "PVE", 0) 'MLHIDE

            If GetSetting("SeeSOFT", "SeePOS", "ModoCaja") = "" Then SaveSetting("SeeSOFT", "SeePOS", "ModoCaja", "0")

            If GetSetting("SeeSOFT", "SeePOS", "ModoCaja") = "1" Then
                Dim frm As New frmIniciodeSeccion
                frm.ShowDialog()
                If frm.AccesoConsedido = True Then
                    Dim Principal As New frmPrincipalCaja
                    Principal.Id_Usuario = frm.Id_Usuario
                    Principal.NombreUsuario = frm.NombreUsuario
                    Application.Run(Principal)
                End If
            Else
                Usuario.ShowDialog()
                If Usuario.conectado Then
                    Loggin_Usuario()
                    usua = Usuario.Usuario
                    Application.Run(New MainForm(Usuario.Usuario))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CapturaPantallaVisual()
        Try
            Dim Pantalla As New DevExpress.XtraEditors.PictureEdit


            keybd_event(44, 0, 0&, 0&)
            Dim iData As IDataObject = Clipboard.GetDataObject()
            Pantalla.Image = CType(iData.GetData(DataFormats.Bitmap), Bitmap)
            Pantalla.Image.Save(Application.StartupPath & "\Capturas\Captura" & Now.Day & "-" & Now.Month & "-" & Now.Year & " " & Format(Now.Hour, "00") & "" & Format(Now.Minute, "00") & "" & Format(Now.Second, "00") & ".JPG") 'MLHIDE

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub
    Function Loggin_Usuario() As Boolean
        Try
            Dim Usuario_autorizadores() As System.Data.DataRow
            Dim Usua As System.Data.DataRow
            Dim Fx As cFunciones
            Dim TablaUsuario As New DataTable
            Fx.Llenar_Tabla_Generico("Select * from usuarios where Id_Usuario ='" & Usuario.Usuario.Cedula & "'", TablaUsuario, CadenaConexionSeguridad) 'MLHIDE
            Usuario_autorizadores = TablaUsuario.Select()
            If Usuario_autorizadores.Length <> 0 Then
                Usua = Usuario_autorizadores(0)

                Usuario.Usuario.Cedula = Usua("Id_Usuario")               'MLHIDE
                Usuario.Usuario.Nombre = Usua("Nombre")               'MLHIDE
                Usuario.Usuario.Clave_Entrada = Usua("Clave_Entrada") 'MLHIDE
                Usuario.Usuario.Clave_Interna = Usua("Clave_Interna") 'MLHIDE
                Usuario.Usuario.Perfil = Usua("Perfil")               'MLHIDE



                Usuario.Usuario.Anu_Venta = Seguridad.VSMA(Usuario.Usuario.Cedula, "Facturacion", Secure.Delete) 'MLHIDE
                Usuario.Usuario.Anu_Cotizacion = Seguridad.VSMA(Usuario.Usuario.Cedula, "Frm_Cotizacion", Secure.Delete)  'MLHIDE

                'Usuario.Usuario.RecibosDinero = Usua("RecibosDinero")
                'Usuario.Usuario.AnuRecibos = Usua("AnuRecibos")

                '-------------
                'VENTAS SAJ:26033007
                '-------------
                Usuario.Usuario.CambiarPrecio = 0   'Usua("CambiarPrecio")
                Usuario.Usuario.Aplicar_Desc = 0   'Usua("Aplicar_Desc")
                Usuario.Usuario.Exist_Negativa = 0 'Usua("Exist_Negativa")
                '-------------
                'CUENTAS POR COBRAR
                '-------------
                Usuario.Usuario.Abrir_Credito = 0  'Usuario.Usuario.Abrir_Credito = Usua("Abrir_Credito")
                'Usuario.Usuario.VariarIntereses = Usua("VariarIntereses")

                'Usuario.Usuario.Porc_Desc = Usua("Porc_Desc")
                'Usuario.Usuario.Porc_Precio = Usua("Porc_Precio")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Function



    Private Function LeadingZeros(ByRef ExpectedLen As Short, ByRef ActualLen As Short) As String
        LeadingZeros = New String("0", ExpectedLen - ActualLen)       'MLHIDE
    End Function

End Module

'Public Sub VerificacionRegistrosSistema()  'JSA 20072006
'    GetSettingConexion = CadenaConexionSeePOS
'    If GetSettingConexion = "" Then
'        'Dim     FormConexion As New EnlaceServidor.FormConexion
'        'FormConexion.Left = (Screen.PrimaryScreen.WorkingArea.Width - FormConexion.Width) \ 2
'        'FormConexion.Top = (Screen.PrimaryScreen.WorkingArea.Height - FormConexion.Height) \ 2
'        'FormConexion.ShowDialog()
'    End If
'End Sub
'    Public Function EstadoSevidor_Enlace()  'JSA 20072006
'        Dim Conexiones As New Conexion
'        Dim ReintestoFallidos As Int16
'Reintentos:
'        Try
'            '            Espera.Caption = "Establecer Conexión con el servidor..."
'            ReintestoFallidos += 1
'            Conexiones.Conectar()
'            '          Espera.Caption = "Conexion establecida con [" & Conexiones.sQlconexion.DataSource & "]"
'        Catch ex As Exception
'            '           Espera.Caption = "Conexión NO establecida con el servidor..."
'            If ReintestoFallidos < 3 Then
'                If MsgBox("Conexión no estabecida con el Servidor..." & vbCrLf & "Desea intentar establecer conexion nuevamente...", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "") = MsgBoxResult.Yes Then GoTo Reintentos
'            Else
'                'Dim FormConexion As New EnlaceServidor.FormConexion
'                'FormConexion.Left = (Screen.PrimaryScreen.WorkingArea.Width - FormConexion.Width) \ 2
'                'FormConexion.Top = (Screen.PrimaryScreen.WorkingArea.Height - FormConexion.Height) \ 2
'                'FormConexion.ShowDialog()
'            End If

'        End Try
'    End Function
'End Module
'Public Class CambiarEstiloXP
'    ' Al estar declarado como Shared, podemos usarlo sin crear
'    ' una instancia de la clase
'    Public Shared Sub CambiarEstilo(ByVal tControl As Control)
'        ' Cambiar el estilo del control...
'        ' sólo si es uno de los indicados
'        Select Case tControl.GetType.Name
'            Case "Label"
'                CType(tControl, Label).FlatStyle = FlatStyle.System
'            Case "CheckBox"
'                CType(tControl, CheckBox).FlatStyle = FlatStyle.System
'            Case "RadioButton"
'                CType(tControl, RadioButton).FlatStyle = FlatStyle.System
'            Case "Button"
'                ' Si el botón tiene asignada la propiedad Image     (11/Oct/02)
'                ' no cambiarlo...
'                Dim tButton As Button = CType(tControl, Button)
'                If tButton.Image Is Nothing Then
'                    tButton.FlatStyle = FlatStyle.System
'                End If
'            Case "GroupBox"
'                CType(tControl, GroupBox).FlatStyle = FlatStyle.System
'        End Select
'        '
'        ' Cambiar también los controles contenidos en cada control...
'        If tControl.Controls.Count > 0 Then
'            Dim tControl2 As Control
'            '
'            For Each tControl2 In tControl.Controls
'                CambiarEstilo(tControl2)
'            Next
'        End If
'    End Sub
'End Class
