Imports System.Data
Imports System.Data.Sql
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmTemperaturaCamara
    Private Id_RegistroTemperaturaCamara As Long = 0
    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
    Dim usua As Usuario_Logeado
    Private Id_UsuarioCreo As String = ""

    Public Sub DataGridViewxDefecto(ByRef _view As DataGridView, Optional ByVal _readonly As Boolean = True)
        With _view
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ReadOnly = _readonly
            .MultiSelect = False
            .BackgroundColor = Drawing.Color.White
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub CargarRegistrosTemperatura()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from viewTemperaturaCamara order by fecha desc", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Id").Visible = False
        Me.viewDatos.Columns("Id_Usuario").Visible = False
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "dd/MM/yyyy"
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.viewDatos.Columns("Temperatura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub

    Private Function PasaValidaRegistro() As Boolean
        Dim resultado As Boolean = True
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from temperaturacamara where dbo.dateonly(Fecha) = dbo.dateonly('" & Me.dtpFecha.Value & "') and horario = '" & Me.cboHorario.Text & "'", dt, CadenaConexionSeePOS)

        If dt.Rows.Count > 0 Then
            MsgBox("ya existe un registro para este dia con este horario", MsgBoxStyle.Exclamation, Text)
            resultado = False
        End If

        Return resultado
    End Function

    Private Sub AgregarNuevoRegistro()
        Dim Fecha As Date
        Dim Id_Usuario As String
        Dim Temperatura As String

        Fecha = Me.dtpFecha.Value
        Id_Usuario = Me.Id_UsuarioCreo
        Temperatura = Me.txtTemperatura.Text

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        If Me.Id_RegistroTemperaturaCamara = 0 Then
            If Me.PasaValidaRegistro = True Then
                db.Ejecutar("Insert into temperaturacamara(Fecha,Id_Usuario,Temperatura, Horario) Values('" & Fecha & "','" & Id_Usuario & "','" & Temperatura & "', '" & Me.cboHorario.Text & "')", CommandType.Text)
            End If            
        Else
            db.Ejecutar("Update temperaturacamara set fecha = '" & Fecha & "', Temperatura = '" & Temperatura & "' Where Id = " & Me.Id_RegistroTemperaturaCamara, CommandType.Text)
        End If
        Me.CargarRegistrosTemperatura()
    End Sub

    Private Sub frmTemperaturaCamara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboHorario.SelectedIndex = 0
        Me.DataGridViewxDefecto(Me.viewDatos)
        Me.CargarRegistrosTemperatura()
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cConexion As New LcPymes_5._2.Conexion
            Dim rs As SqlDataReader
            If e.KeyCode = Keys.Enter Then
                If txtUsuario.Text <> "" Then
                    rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                    If rs.HasRows = False Then
                        MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                        txtUsuario.Focus()
                    End If
                    While rs.Read
                        Try
                            Me.btnAgregar.Enabled = True
                            Me.Id_UsuarioCreo = rs("Cedula")
                            Me.txtNombreUsuario.Text = rs("Nombre")
                            PMU = VSM(rs("Cedula"), "PrestamosBodega") 'Carga los privilegios del usuario con el modulo
                            If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub
                        Catch ex As SystemException
                            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                        End Try
                    End While
                    rs.Close()
                    cConexion.DesConectar(cConexion.sQlconexion)
                Else
                    MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                    txtUsuario.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AgregarNuevoRegistro()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmReporteTemperaturaCamara
        frm.ShowDialog()
    End Sub

End Class