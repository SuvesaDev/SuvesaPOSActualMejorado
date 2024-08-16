Imports System.Data

Public Class frmGenerarFichaPedidoWeb

    Public IdUsuario As String = ""

    Private Sub Login(_Clave As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre, Porc_Desc, CambiarPrecio from Usuarios where Clave_Interna = '" & _Clave & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtNombreUsuario.Text = dt.Rows(0).Item("Nombre")
            Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
            Me.txtClave.Enabled = False
            Me.btnGenerarPreventa.Enabled = True
        Else
            Me.txtNombreUsuario.Text = ""
            Me.IdUsuario = ""
        End If
    End Sub

    Private Function ValidarCajaAbierta(_NumCaja As Integer)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from aperturacaja where Estado = 'A' and Num_Caja = " & _NumCaja, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnGenerarPreventa_Click(sender As Object, e As EventArgs) Handles btnGenerarPreventa.Click
        If ValidarCajaAbierta(Me.cboNumeroCaja.Text) = False Then
            MsgBox("Caja #" & Me.cboNumeroCaja.Text & " no esta abierta" & vbCrLf _
                   & "No se puede registrar la Preventa.", MsgBoxStyle.Exclamation, Text)
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Login(Me.txtClave.Text)
        End If
    End Sub

    Private Sub frmGenerarFichaPedidoWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboNumeroCaja.SelectedIndex = 0
    End Sub

End Class