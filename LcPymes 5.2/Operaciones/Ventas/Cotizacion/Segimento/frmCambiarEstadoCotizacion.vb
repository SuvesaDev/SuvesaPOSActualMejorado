Imports System.Data
Public Class frmCambiarEstadoCotizacion

    Private Sub AutoLogin()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Id_Usuario = '" & Me.IdUsuario & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
            Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.Panel1.Enabled = True
            Me.cboNuevoEstado.Focus()
        Else
            Me.IdUsuario = ""
            Me.txtUsuario.Text = ""
            Me.Panel1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public IdUsuario As String = ""
    Private Sub txtClave_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If Me.txtClave.Text <> "" Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                    Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
                    Me.Panel1.Enabled = True
                Else
                    Me.IdUsuario = ""
                    Me.txtUsuario.Text = ""
                    Me.Panel1.Enabled = False
                End If
            End If
        End If
    End Sub

    Public Llamar As Boolean = False
    Private Sub frmCambiarEstadoCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboNuevoEstado.Items.Clear()
        If Llamar = True Then
            Me.cboNuevoEstado.Items.Add(ESTADOS.Confirmado)
            Me.cboNuevoEstado.Items.Add(ESTADOS.Revision)
            Me.cboNuevoEstado.Items.Add(ESTADOS.Perdida)
            Me.AutoLogin()
        Else
            Me.cboNuevoEstado.DataSource = ESTADOS.ListaEstado
        End If
        Me.cboNuevoEstado.SelectedIndex = 0
    End Sub

End Class