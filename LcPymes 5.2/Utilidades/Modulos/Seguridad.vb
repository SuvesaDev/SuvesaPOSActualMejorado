Imports CrystalDecisions.CrystalReports
Imports System.Windows.Forms
Imports System.Data
Public Module Seguridad
    Public Enum Secure
        Execute = 1
        Update = 2
        Delete = 3
        Find = 4
        Print = 5
        Others = 6
    End Enum
    Public Class PerfilModulo_Class
        Public Modulo As String
        Public Execute As Boolean
        Public Update As Boolean
        Public Delete As Boolean
        Public Find As Boolean
        Public Print As Boolean
        Public Others As Boolean
    End Class
    'VERIFICA LA SEGURIDAD POR MODULO, DEVOLVIENDO EL CONJUNTO DE PERMISOS DEL MODULO SAJ:12032007
    'Verificacion de Seguridad por Modulo.
    Public Function VSM(ByVal UsuarioID As String, ByVal Modulo As String) As PerfilModulo_Class
        Dim Cx As New Conexion
        Dim PerfilModulo As New PerfilModulo_Class
        Dim Reader As SqlClient.SqlDataReader
        Try
            Reader = Cx.GetRecorset(Cx.Conectar("Seguridad"), "SELECT dbo.Usuarios.Id_Usuario, dbo.Modulos.Modulo_Nombre_Interno, dbo.Modulos.Modulo_Nombre, dbo.Perfil_x_Modulo.Accion_Ejecucion,  dbo.Perfil_x_Modulo.Accion_Actualizacion, dbo.Perfil_x_Modulo.Accion_Eliminacion, dbo.Perfil_x_Modulo.Accion_Busqueda,  dbo.Perfil_x_Modulo.Accion_Impresion, dbo.Perfil_x_Modulo.Accion_Opcion FROM dbo.Modulos INNER JOIN  dbo.Perfil_x_Modulo ON dbo.Modulos.Id_modulo = dbo.Perfil_x_Modulo.Id_Modulo INNER JOIN  dbo.Perfil ON dbo.Perfil_x_Modulo.Id_Perfil = dbo.Perfil.Id_Perfil INNER JOIN  dbo.Perfil_x_Usuario ON dbo.Perfil.Id_Perfil = dbo.Perfil_x_Usuario.Id_Perfil INNER JOIN  dbo.Usuarios ON dbo.Perfil_x_Usuario.Id_Usuario = dbo.Usuarios.Id_Usuario WHERE (dbo.Usuarios.Id_Usuario = '" & UsuarioID & "') AND (dbo.Modulos.Modulo_Nombre_Interno = '" & Modulo & "')")
            If Reader.Read() Then
                PerfilModulo.Execute = Reader("Accion_Ejecucion")
                PerfilModulo.Update = Reader("Accion_Actualizacion")
                PerfilModulo.Delete = Reader("Accion_Eliminacion")
                PerfilModulo.Find = Reader("Accion_Busqueda")
                PerfilModulo.Print = Reader("Accion_Impresion")
                PerfilModulo.Others = Reader("Accion_Opcion")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención..")
        End Try
        Cx.DesConectar(Cx.sQlconexion)
        Return PerfilModulo
    End Function
    'VERIFICA LA SEGURIDAD POR ACCION SAJ:12032007
    'Verificacion de Seguridad por Modulo y Accion.
    Public Function VSMA(ByVal UsuarioID As String, ByVal Modulo As String, ByVal Nivel As Byte) As Boolean

        Dim Cx As New Conexion
        Dim Reader As System.Data.SqlClient.SqlDataReader
        Try
            Reader = Cx.GetRecorset(Cx.Conectar("Seguridad"), "SELECT dbo.Usuarios.Id_Usuario, dbo.Modulos.Modulo_Nombre_Interno, dbo.Modulos.Modulo_Nombre, dbo.Perfil_x_Modulo.Accion_Ejecucion,  dbo.Perfil_x_Modulo.Accion_Actualizacion, dbo.Perfil_x_Modulo.Accion_Eliminacion, dbo.Perfil_x_Modulo.Accion_Busqueda,  dbo.Perfil_x_Modulo.Accion_Impresion, dbo.Perfil_x_Modulo.Accion_Opcion FROM dbo.Modulos INNER JOIN  dbo.Perfil_x_Modulo ON dbo.Modulos.Id_modulo = dbo.Perfil_x_Modulo.Id_Modulo INNER JOIN  dbo.Perfil ON dbo.Perfil_x_Modulo.Id_Perfil = dbo.Perfil.Id_Perfil INNER JOIN  dbo.Perfil_x_Usuario ON dbo.Perfil.Id_Perfil = dbo.Perfil_x_Usuario.Id_Perfil INNER JOIN  dbo.Usuarios ON dbo.Perfil_x_Usuario.Id_Usuario = dbo.Usuarios.Id_Usuario WHERE (dbo.Usuarios.Id_Usuario = '" & UsuarioID & "') AND (dbo.Modulos.Modulo_Nombre_Interno = '" & Modulo & "')")
            If Reader.Read() Then
                Select Case Nivel
                    Case Secure.Execute : Return Reader("Accion_Ejecucion")
                    Case Secure.Delete : Return Reader("Accion_Eliminacion")
                    Case Secure.Find : Return Reader("Accion_Busqueda")
                    Case Secure.Update : Return Reader("Accion_Actualizacion")
                    Case Secure.Others : Return Reader("Accion_Opcion")
                    Case Secure.Print : Return Reader("Accion_Impresion")
                    Case Else : Return 0
                End Select
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención..")
        End Try
        Cx.DesConectar(Cx.sQlconexion)
    End Function

    'Verificacion y registros de modulos en seguridad y acceso.
    Public Function RSM(ByVal Modulo As String, ByVal Nombre As String, Optional ByVal Menu As String = "") As Boolean

        Dim Cx As New Conexion
        Dim Reader As SqlClient.SqlDataReader
        Try
            Reader = Cx.GetRecorset(Cx.Conectar("Seguridad"), "SELECT Id_modulo,Grupo FROM Modulos WHERE Modulo_Nombre_Interno = '" & Modulo & "'")
            If Reader.Read() Then
                If Reader("Grupo") = "" Then
                    Dim Cx1 As New Conexion
                    Cx1.UpdateRecords("Modulos", "Grupo = '" & Menu & "'", "Id_modulo = " & Reader("Id_modulo"), "Seguridad")
                    Cx1.DesConectar(Cx1.sQlconexion)
                End If
                Return True
            Else
                'MsgBox("El módulo no se encuentra registrado, se procede a registrar...", MsgBoxStyle.Information, "Atención..")
                Dim R As String
                Cx.DesConectar(Cx.sQlconexion)
                If Menu <> "" Then
                    R = Cx.AddNewRecord("Modulos", "Modulo_Nombre_Interno, Modulo_Nombre, Grupo", "'" & Modulo & "','" & Nombre & "','" & Menu & "'", "Seguridad")
                    If R <> "" Then MsgBox(R, MsgBoxStyle.Information, "Atención...")
                    Return False
                Else
                    R = Cx.AddNewRecord("Modulos", "Modulo_Nombre_Interno, Modulo_Nombre", "'" & Modulo & "','" & Nombre & "'", "Seguridad")
                    If R <> "" Then MsgBox(R, MsgBoxStyle.Information, "Atención...")
                    Return False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención..")
        End Try
        Cx.DesConectar(Cx.sQlconexion)
    End Function

    Public Function VerificandoAcceso_a_Modulos(ByVal Interno As String, ByVal Titulo As String, ByVal Usuario As String, Optional ByVal Menu As String = "") As Boolean
        Dim Nombre As String = Interno
        Dim NombreExternos As String = Titulo

        If RSM(Nombre, NombreExternos, Menu) = False Then
            MsgBox("El módulo <" & NombreExternos & "> no se encuentra registrado dentro del sistema...", MsgBoxStyle.Information, "Atención...")
        Else
            Return VSMA(Usuario, Nombre, Seguridad.Secure.Execute)
        End If
    End Function

    Public Function VerificandoAcceso_a_Reportes(ByVal Interno As String, ByVal Externo As String, ByVal Usuario As String, Optional ByVal Menu As String = "") As Boolean
        Dim Nombre As String = Interno
        Dim NombreExternos As String = Externo

        If RSM(Nombre, NombreExternos, Menu) = False Then
            MsgBox("El módulo <" & NombreExternos & "> no se encuentra registrado dentro del sistema...", MsgBoxStyle.Information, "Atención...")
        Else
            Return VSMA(Usuario, Nombre, Seguridad.Secure.Execute)
        End If
    End Function


End Module

