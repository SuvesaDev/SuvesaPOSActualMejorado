Imports System.Data
Public Class frmMotivoInactivarCliente
    Public Identificacion As String = ""
    Public Inactivo As Boolean = False

    Private Sub CargarUsuario(_ClaveInterna As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Nombre from Usuarios where Clave_Interna = '" & _ClaveInterna & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtClave.Enabled = False
            Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.Panel1.Enabled = True
        Else
            Me.txtClave.Enabled = True
            Me.txtUsuario.Text = ""
            Me.Panel1.Enabled = False
        End If
    End Sub

    Private Sub RegistrarCambio()
        Dim strSQLInsert As String = "Insert Into BitacoraInactivarCliente(identificacion, fecha, usuario, inactivo, motivo) Values(@identificacion, getdate(), @usuario, @inactivo, @motivo);"
        Dim strSQLUpdate As String = "Update Clientes set anulado = @inactivo where identificacion = @identificacion;"
        Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            db.SetParametro("@identificacion", Me.Identificacion)
            db.SetParametro("@usuario", Me.txtUsuario.Text)
            db.SetParametro("@inactivo", Me.rbInactvio.Checked)
            db.SetParametro("@motivo", Me.txtMotivo.Text)
            db.Ejecutar(strSQLInsert, CommandType.Text)
            db.SetParametro("@identificacion", Me.Identificacion)
            db.SetParametro("@inactivo", Me.rbInactvio.Checked)
            db.Ejecutar(strSQLUpdate, CommandType.Text)
            db.Commit()
            MsgBox("Datos almacenados correctamente.", MsgBoxStyle.Information, Text)
            Me.Close()
        Catch ex As Exception
            db.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub CargarHistoricoCambios()
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Id, Fecha, Usuario, Inactivo, Motivo from BitacoraInactivarCliente Where Identificacion = " & Me.Identificacion & " Order By Fecha Desc", dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("Id").Visible = False
            'Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtClave.Text <> "" Then
                Me.CargarUsuario(Me.txtClave.Text)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If Me.txtMotivo.Text.Trim <> "" Then
            Me.RegistrarCambio()
        End If
    End Sub

    Private Sub frmMotivoInactivarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rbActivo.Checked = Me.Inactivo
        Me.CargarHistoricoCambios()
    End Sub
End Class