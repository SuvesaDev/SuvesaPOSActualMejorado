Imports System.Data
Public Class frmAsignarFichaUsuario

    Private Sub CargarUsuario()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre as Usuario from Usuarios", dt, CadenaConexionSeePOS)
        Me.cboUsuario.DataSource = dt
        Me.cboUsuario.DisplayMember = "Usuario"
        Me.cboUsuario.ValueMember = "Id_Usuario"
    End Sub

    Private Function PuedePasar() As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from fichasxusuario where desde between " & Me.txtDesde.Text & " and " & Me.txtHasta.Text & " or hasta between " & Me.txtDesde.Text & " and " & Me.txtHasta.Text & "", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function esNumero(_Texto As String) As Boolean
        If _Texto <> "" Then
            If IsNumeric(_Texto) Then
                If CDec(_Texto) > 0 Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function

    Private Sub frmAsignarFichaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarUsuario()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If esNumero(Me.txtDesde.Text) And esNumero(Me.txtHasta.Text) And esNumero(Me.txtMostrador.Text) Then
            If Me.PuedePasar() Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtDesde_TextChanged(sender As Object, e As EventArgs) Handles txtHasta.TextChanged, txtDesde.TextChanged
        If esNumero(Me.txtDesde.Text) And esNumero(Me.txtHasta.Text) Then
            Dim desde As Integer = Me.txtDesde.Text
            Dim hasta As Integer = Me.txtHasta.Text
            Me.txtMostrador.Text = hasta - desde + 1
        End If
    End Sub

End Class