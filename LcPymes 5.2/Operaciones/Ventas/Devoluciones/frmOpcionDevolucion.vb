Public Class frmOpcionDevolucion

    Private vFormaDevolucion As Tipo = Tipo.Efectivo

    Public Property FormaDevolucion As Tipo
        Get
            Return Me.vFormaDevolucion
        End Get
        Set(value As Tipo)
            Me.vFormaDevolucion = value
            Me.txtCedula.Text = ""
            Me.txtNombre.Text = ""
            Me.txtCuenta.Text = ""
            Select Case value
                Case Tipo.Efectivo
                    Me.CambiarColor(btnEfectivo, True)
                    Me.CambiarColor(btnDeposito)
                    Me.CambiarColor(btnAnticipo)
                    pDeposito.Visible = False
                    pAnticipo.Visible = False
                Case Tipo.Deposito
                    Me.CambiarColor(btnEfectivo)
                    Me.CambiarColor(btnDeposito, True)
                    Me.CambiarColor(btnAnticipo)
                    pDeposito.Visible = True
                    pAnticipo.Visible = False
                Case Tipo.Anticipo
                    Me.CambiarColor(btnEfectivo)
                    Me.CambiarColor(btnDeposito)
                    Me.CambiarColor(btnAnticipo, True)
                    pDeposito.Visible = False
                    pAnticipo.Visible = True
            End Select
        End Set
    End Property

    Private Sub CambiarColor(ByRef btn As Button, Optional Seleccionado As Boolean = False)
        If Seleccionado = True Then
            btn.BackColor = Drawing.Color.RoyalBlue
            btn.ForeColor = Drawing.Color.White
        Else
            btn.BackColor = System.Drawing.SystemColors.Control
            btn.ForeColor = Drawing.Color.Black
        End If
    End Sub

    Private Sub btnEfectivo_Click(sender As Object, e As EventArgs) Handles btnEfectivo.Click
        Me.FormaDevolucion = Tipo.Efectivo
    End Sub

    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        Me.FormaDevolucion = Tipo.Deposito
    End Sub

    Private Sub btnAnticipo_Click(sender As Object, e As EventArgs) Handles btnAnticipo.Click
        Me.FormaDevolucion = Tipo.Anticipo
    End Sub

    Private Sub frmOpcionDevolucion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsClinica() = True Then
            Me.btnEfectivo.Enabled = False
            Me.FormaDevolucion = Tipo.Deposito
            Me.ckDevolverAlbaran.Enabled = True
            Me.ckDevolverAlbaran.Visible = True
            Me.ckDevolverAlbaran.Checked = False
        Else
            Me.FormaDevolucion = Tipo.Efectivo
            Me.ckDevolverAlbaran.Checked = False
            Me.ckDevolverAlbaran.Enabled = False
            Me.ckDevolverAlbaran.Visible = False
        End If
        Me.pDeposito.Enabled = True
        Me.pAnticipo.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsClinica() = True And Me.ckDevolverAlbaran.Checked = False Then
            If MsgBox("Desea habilitar los albaranes para volver a facturar.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion.") = MsgBoxResult.Yes Then
                Me.ckDevolverAlbaran.Checked = True
            End If
        End If

        If Me.FormaDevolucion = Tipo.Deposito Then
            If Me.txtCedula.Text = "" Or Me.txtNombre.Text = "" Or Me.txtCuenta.Text = "" Then
                MsgBox("Debe llenar la informacion del cliente y cuenta", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                Exit Sub
            End If
        End If
        If Me.FormaDevolucion = Tipo.Anticipo Then
            If Me.txtNombreAnticcipo.Text = "" Then
                MsgBox("Debe seleccionar un cliente", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
                Exit Sub
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Public CodCliente As Long = 0
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim Fx As New cFunciones
        Dim dt As New System.Data.DataTable
        Dim valor As String
        valor = Fx.BuscarDatos("Select Identificacion,Nombre from Clientes", "Nombre", "Buscar Cliente...")
        If valor = "" Then
            Me.CodCliente = 0
            Me.txtNombreAnticcipo.Text = ""
        Else
            cFunciones.Llenar_Tabla_Generico("select Identificacion,Nombre from Clientes where Identificacion = " & valor, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.CodCliente = dt.Rows(0).Item("Identificacion")
                Me.txtNombreAnticcipo.Text = dt.Rows(0).Item("Nombre")
            End If
        End If
    End Sub
End Class

Public Enum Tipo
    Efectivo
    Deposito
    Anticipo
End Enum