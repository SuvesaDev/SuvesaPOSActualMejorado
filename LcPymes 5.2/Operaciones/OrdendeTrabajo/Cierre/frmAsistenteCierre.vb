Imports System.Data
Public Class frmAsistenteCierre
    Private cls As New CierreOrdenTrabajo
    Public Property IdCierre As Integer = 0
    Public Property IdUsuario As String = "0"
    Private Property Posicion1 As System.Drawing.Point
    Private Property Posicion2 As System.Drawing.Point
    Private Property Posicion As Integer = 0


    Private Sub Siguiente()
        Select Case Me.Posicion
            Case 0
                Me.pPosicion1.Location = Me.Posicion2
                Me.pPosicion2.Location = Me.Posicion1
                Me.Posicion += 1
                Me.txtOT.Text = Me.viewOTAbiertas.Item("IdOrden", Me.viewOTAbiertas.CurrentRow.Index).Value
                Me.txtSerie.Text = Me.viewOTAbiertas.Item("Serie", Me.viewOTAbiertas.CurrentRow.Index).Value
                Me.txtCliente.Text = Me.viewOTAbiertas.Item("Nombre", Me.viewOTAbiertas.CurrentRow.Index).Value
                Me.txtTrabajoSolicitados.Text = Me.viewOTAbiertas.Item("TrabajoSolicitados", Me.viewOTAbiertas.CurrentRow.Index).Value
                Me.btnSiguente.Enabled = False
                Me.btnSiguente.Text = "Cierrar OT"
                Me.btnAtras.Text = "Atras"
            Case 1
                cls.IdCierre = 0
                cls.IdOrden = CInt(Me.txtOT.Text)
                cls.Fecha = Date.Now
                cls.IdUsuario = Me.IdUsuario
                cls.Observaciones = Me.txtObservaciones.Text
                cls.Anulado = False
                If cls.Registrar = True Then
                    Me.IdCierre = cls.IdCierre
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
        End Select
    End Sub

    Private Sub Atras()
        Select Case Me.Posicion
            Case 0
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Case 1
                Me.pPosicion1.Location = Me.Posicion1
                Me.pPosicion2.Location = Me.Posicion2
                Me.Posicion -= 1
                Me.btnSiguente.Enabled = True
                Me.btnSiguente.Text = "Siguiente"
                Me.btnAtras.Text = "Cancelar"
        End Select
    End Sub

    Private Sub CentrarFormulario()
        Me.Width = 442
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - 442) / 2
    End Sub

    Private Sub CargarDatos()
        Dim dt As New DataTable
        dt = cls.OrdenesTrabajoAbiertas
        Me.viewOTAbiertas.DataSource = dt
        Me.viewOTAbiertas.Columns("TrabajoSolicitados").Visible = False
        Me.viewOTAbiertas.Columns("FechaIngreso").DefaultCellStyle.Format = "d"
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtClave.Text <> "" Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select Id_Usuario, Nombre From Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                    Me.txtNombreUsuario.Text = dt.Rows(0).Item("Nombre")
                    Me.btnSiguente.Enabled = True
                Else
                    Me.IdUsuario = "0"
                    Me.txtNombreUsuario.Text = ""
                    Me.btnSiguente.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub frmAsistenteCierre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Posicion1 = Me.pPosicion1.Location
        Me.Posicion2 = Me.pPosicion2.Location
        Me.CentrarFormulario()
        Me.CargarDatos()
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Atras()
    End Sub

    Private Sub btnSiguente_Click(sender As Object, e As EventArgs) Handles btnSiguente.Click
        Me.Siguiente()
    End Sub

End Class