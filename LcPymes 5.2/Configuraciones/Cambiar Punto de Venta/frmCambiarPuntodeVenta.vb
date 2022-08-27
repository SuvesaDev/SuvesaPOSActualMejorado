Imports System.Data
Public Class frmCambiarPuntodeVenta

    Private PuntosdeVenta As DataTable
    Private Servidor As String = ""
    Public BasedeDatos As String = ""
    Private CadenaConexion As String = ""
    Public Descripcion As String = ""
    Private UsuarioDB As String = ""
    Private ClaveDB As String = ""


    Private Sub CargarPuntosdeVenta()

        If GetSetting("SeeSOFT", "SeePOS", regeditSegura) = "" Then
            SaveSetting("SeeSOFT", "SeePOS", regeditSegura, "0")
        End If

        Dim db As New GestioDatos
        Dim SystemNormal As String = GetSetting("SeeSOFT", "SeePOS", regeditSegura)

        Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
        Me.Servidor = Me.BuscaDatos(Conexion(0))
        Me.BasedeDatos = Me.BuscaDatos(Conexion(1))
        Try
            If CadenaConexionSeePOS.Contains("Integrated Security=true") = False Then
                Me.UsuarioDB = Me.BuscaDatos(Conexion(2))
                Me.ClaveDB = Me.BuscaDatos(Conexion(3))
            Else
                Me.UsuarioDB = ""
                Me.ClaveDB = ""
            End If
        Catch ex As Exception
        End Try

        'If SystemNormal = "1" Then
        'carga todos los pntos de venta
        'Me.PuntosdeVenta = db.Ejecuta("Select IdPuntoVenta, PuntoVenta, BasedeDatos, Descripcion, Mascota, Taller From " & TablaSeguridad() & ".dbo.PuntodeVenta order by PuntoVenta")
        'Else
        'solo carga los puntos de venta relacionadas
        Me.PuntosdeVenta = db.Ejecuta("Select IdPuntoVenta, PuntoVenta, BasedeDatos, Descripcion, Mascota, Taller From " & TablaSeguridad() & ".dbo.PuntodeVenta Where Relacion In(Select Relacion from " & TablaSeguridad() & ".dbo.PuntodeVenta where BasedeDatos = '" & Me.BasedeDatos & "') order by PuntoVenta")
        'End If

        Me.cboPuntoVenta.DataSource = Me.PuntosdeVenta
        Me.cboPuntoVenta.ValueMember = "IdPuntoVenta"
        Me.cboPuntoVenta.DisplayMember = "PuntoVenta"

        Dim Fila() As DataRow
        Fila = Me.PuntosdeVenta.Select("BasedeDatos = '" & Me.BasedeDatos & "'")
        Me.cboPuntoVenta.Text = Fila(0).Item("PuntoVenta")
    End Sub

    Private Sub CambiarPuntodeVenta()
        Dim Fila() As DataRow
        Fila = Me.PuntosdeVenta.Select("IdPuntoVenta = " & Me.cboPuntoVenta.SelectedValue)
        Me.BasedeDatos = Fila(0).Item("BasedeDatos")
        Me.Descripcion = Fila(0).Item("Descripcion")

        If Me.UsuarioDB = "" Then
            Me.CadenaConexion = "Data Source=" & Me.Servidor & "; Initial Catalog=" & BasedeDatos & "; Integrated Security=true;"
        Else
            Me.CadenaConexion = "Data Source=" & Me.Servidor & "; Initial Catalog=" & BasedeDatos & "; User Id=" & Me.UsuarioDB & ";Password=" & Me.ClaveDB & ";"
        End If

        SaveSetting("SeeSOFT", "SeePOs", "Conexion", CadenaConexion)
        SaveSetting("Hotel", "Hotel", "Conexion", CadenaConexion)
        SaveSetting("SeeSOFT", "SeePOs", "empresa", Me.Descripcion)
        SaveSetting("SeeSOFT", "SeePOs", "sistema_mascotas", Fila(0).Item("Mascota"))
        SaveSetting("SeeSOFT", "SeePOs", "sistema_taller", Fila(0).Item("Taller"))
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function BuscaDatos(ByVal _Texto As String) As String
        Dim Resultado As String = ""
        Dim inicia As Boolean = False
        For Each c As Char In _Texto
            If inicia = True Then
                If c <> ";" Then
                    Resultado += c
                End If
            End If
            If c = "=" Then inicia = True
        Next
        Return Resultado
    End Function

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        Me.CambiarPuntodeVenta()
    End Sub

    Private Sub frmCambiarPuntodeVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CargarPuntosdeVenta()
    End Sub

    Private Sub cboPuntoVenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPuntoVenta.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then Me.CambiarPuntodeVenta()
    End Sub

End Class
