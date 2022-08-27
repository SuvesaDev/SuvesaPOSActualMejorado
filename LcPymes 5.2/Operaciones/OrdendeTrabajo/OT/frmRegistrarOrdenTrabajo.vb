Imports System.Data
Public Class frmRegistrarOrdenTrabajo
    Public Property IdOrden As Integer = 0
    Public Property IdUsuario As String = "0"

    Private Sub CargarOrden()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select ot.*, u.Nombre as Usuario from OrdenTrabajo ot inner join Usuarios u on ot.IdUsuario = u.Id_Usuario Where ot.IdOrden = " & Me.IdOrden, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.dtpFecha.Value = dt.Rows(0).Item("FechaIngreso")
            Me.txtSerie.Text = dt.Rows(0).Item("Serie")
            Me.txtIdentificacion.Text = dt.Rows(0).Item("Identificacion")
            Me.txtNombreCliente.Text = dt.Rows(0).Item("Nombre")
            Me.txtTelefono.Text = dt.Rows(0).Item("Telefono")
            Me.txtCorreo.Text = dt.Rows(0).Item("Correo")
            Me.txtDireccion.Text = dt.Rows(0).Item("Direccion")
            Me.txtDetalleServicio.Text = dt.Rows(0).Item("TrabajoSolicitados")
            Me.txtObservaciones.Text = dt.Rows(0).Item("Observaciones")
            Me.IdUsuario = dt.Rows(0).Item("IdUsuario")
            Me.txtNombreUsuario.Text = dt.Rows(0).Item("Usuario")
            Me.txtClave.Enabled = False
            Me.btnAceptar.Enabled = True
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtSerie.Text <> "" Then
            If IsNumeric(Me.txtSerie.Text) Then
                If Me.txtNombreCliente.Text <> "" Then
                    If Me.txtDetalleServicio.Text <> "" Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If                    
                End If
            End If
        End If        
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtClave.Text <> "" Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select Id_Usuario, Nombre From Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                    Me.txtNombreUsuario.Text = dt.Rows(0).Item("Nombre")
                    Me.btnAceptar.Enabled = True
                Else
                    Me.IdUsuario = "0"
                    Me.txtNombreUsuario.Text = ""
                    Me.btnAceptar.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub frmRegistrarOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.IdOrden > 0 Then
            Me.CargarOrden()
        End If
    End Sub
End Class