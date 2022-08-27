Imports System.Data
Public Class frmFacturaPendiente

    Public Id_Admin As String = ""

    Private Sub CargarAdmin(_Clave As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & _Clave & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.Id_Admin = dt.Rows(0).Item("Id_Usuario")
            Me.txtNombreAdmin.Text = dt.Rows(0).Item("Nombre")
        End If
    End Sub

    Private Sub CargarCajera(_Id_Usuario As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Id_Usuario = '" & _Id_Usuario & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.Id_Admin = dt.Rows(0).Item("Id_Usuario")
            Me.txtCajero.Text = dt.Rows(0).Item("Nombre")
        End If
    End Sub

    Private Function GetNombre(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select NOMBRECOMPLETO2 from Cedula.dbo.ENTIDADES_FISICAS where cedula2 = '" & _Cedula & "'", dt, CadenaConexionCedulas)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("NOMBRECOMPLETO2")
        Else
            Dim dt2 As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select NOMBRE from Cedula.dbo.ENTIDADES_FIRMA where CEDULA = '" & _Cedula & "'", dt2, CadenaConexionCedulas)
            If dt2.Rows.Count > 0 Then
                Return dt2.Rows(0).Item("NOMBRE")
            Else
                Return "0"
            End If
        End If
    End Function

    Private Sub CargarClienteRetira()
        Dim nombre As String = Me.GetNombre(Me.txtCedulaCliente.Text)
        If nombre = "0" Then
            If MsgBox("La cedula no se encontro desea registrarla", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then
                Dim frm As New frmFirmaNuevaCedula
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.CargarClienteRetira()
                End If
            End If            
        Else
            Me.txtNombreCliente.Text = nombre
        End If
    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtCajero.Text <> "" And Me.txtNombreAdmin.Text <> "" And Me.txtNombreCliente.Text <> "" Then
            If Me.txtTelefono_Retira.Text <> "" Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtAdmin_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtAdmin.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter And Me.txtAdmin.Text <> "" Then Me.CargarAdmin(Me.txtAdmin.Text)
    End Sub

    Private Sub txtCedulaCliente_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCedulaCliente.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter And Me.txtCedulaCliente.Text <> "" Then Me.CargarClienteRetira()
    End Sub
    Public Id_Usuario As String = ""
    Private Sub frmFacturaPendiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCajera(Me.Id_Usuario)
    End Sub
End Class