Imports System.Collections
Imports System.Data

Namespace GestionCobro
    Public Structure Cliente
        Public Identificacion As String
        Public Cedula As String
        Public Nombre As String
        Public Telefono As String
        Public Correo As String
    End Structure

    Public Structure Factura
        Public Property PV As String
        Public Property Id As Long
        Public Property Num_Factura As String
        Public Property Tipo As String
        Public Property Fecha As Date
        Public Property Vence As Date
        Public Property Etapa As String
        Public Property FechaEtapa As Date
        Public Property Saldo As Decimal
    End Structure
End Namespace

Public Class frmGestionCobro
    Private IdUsuario As String = "0"
    Private GestionCobrodt As New DataTable
    Private rptEstadoCuenta As String

    Private Sub PrepararCorreo(_Identificacion As String, _Nombre As String, _Correo As String)
        Dim correo As New Correo
        correo.EnviarEstadoCxC(_Identificacion, _Nombre, _Correo, "Cobro de facturas vencidas", "Un gusto saludarle, Adjunto Factura(s) Pendiente(s) de Pago, por favor comunicarse con nosotros para poner al día el saldo. Si ya cancelo por favor enviar los comprobantes para su verificación.") '"Hola, continuación adjunto facturas pendientes de pago favor ayudar con el pago de estas, si ya cancelo favor adjuntar comprobante para poner el estado de cuenta al dia")
    End Sub

    Private Sub CargarDatos()
        cFunciones.Llenar_Tabla_Generico("exec spObtenerGestionCobro '" & Me.dtpFecha.Value.ToShortDateString & "'", Me.GestionCobrodt, CadenaConexionSeePOS)
        Me.MostrarDatos()
    End Sub

    Private Sub CargarBitacora(_Cod_Cliente As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("exec spConsultaBitacora '" & _Cod_Cliente & "'", dt, CadenaConexionSeePOS)
        Me.viewBitacora.DataSource = dt
        Me.viewBitacora.Columns("Fecha").DefaultCellStyle.Format = "d"        
    End Sub

    Private Sub MostrarDatos()
        If Me.GestionCobrodt.Rows.Count > 0 Then
            Dim Clientes As Collections.Generic.List(Of GestionCobro.Cliente) = (From x As DataRow In Me.GestionCobrodt.Rows
                                                                    Where x.Item("Saldo") > 0
                                                                    Select New GestionCobro.Cliente() With {.Identificacion = x.Item("identificacion"),
                                                                                                 .Cedula = x.Item("cedula"),
                                                                                                 .Nombre = x.Item("nombre"),
                                                                                                 .Telefono = x.Item("Telefono_01"),
                                                                                                 .Correo = x.Item("e_mail")}).ToList

            Dim Index As Integer = 0
            Me.viewDatos.Rows.Clear()
            For Each c As GestionCobro.Cliente In Clientes.Distinct
                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cIdentificacion", Index).Value = c.Identificacion
                Me.viewDatos.Item("cCedula", Index).Value = c.Cedula
                Me.viewDatos.Item("cNombre", Index).Value = c.Nombre
                Me.viewDatos.Item("cTelefono", Index).Value = c.Telefono
                Me.viewDatos.Item("cCorreo", Index).Value = c.Correo
                Index += 1
            Next
            Me.Text = "Gestion de Cobros (" & Index + 1 & ")"
            Me.btnGuardar.Enabled = True

        End If
    End Sub

    Private Sub GuardarBitacora(_ViewRow As DataGridViewRow)
        Dim strSQL As String = "Insert into GestionCobro_Bitacora(IdUsuario, Usuario, Fecha, Id_Factura, Contesto, Mensaje, EnvioMensaje, EnvioCarta, etapa, PV)" & vbCrLf _
        & "Values (@IdUsuario, @Usuario, GetDate(), @Id_Factura, @Contesto, @Mensaje, @EnvioMensaje, @EnvioCarta, @Etapa, @PV);"

        Dim Identificacion As String = _ViewRow.Cells("cIdentificacion").Value
        Dim Contesto As Boolean = _ViewRow.Cells("cContesto").Value
        Dim Mensaje As String = _ViewRow.Cells("cDetalleLlamada").Value
        Dim EnvioMensaje As Boolean = _ViewRow.Cells("cEnvioMensaje").Value
        Dim EnvioCarta As Boolean = _ViewRow.Cells("cEnvioCarta").Value
        Dim Facturas As Collections.Generic.List(Of GestionCobro.Factura) = (From x As DataRow In Me.GestionCobrodt.Rows
                                                                       Where x.Item("Saldo") > 0 And x.Item("Identificacion") = Identificacion
                                                                       Select New GestionCobro.Factura() With {
                                                                                                        .PV = x.Item("PV"), .Id = x.Item("Id"),
                                                                                                        .Num_Factura = x.Item("Num_Factura"),
                                                                                                        .Tipo = x.Item("Tipo"),
                                                                                                        .Fecha = x.Item("Fecha"),
                                                                                                        .Vence = x.Item("Vence"),
                                                                                                        .Etapa = x.Item("Etapa"),
                                                                                                        .FechaEtapa = x.Item("FechaEtapa"),
                                                                                                        .Saldo = x.Item("Saldo")}).ToList
        Dim Trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            For Each F As GestionCobro.Factura In Facturas
                Trans.SetParametro("@IdUsuario", Me.IdUsuario)
                Trans.SetParametro("@Usuario", Me.txtNombreUsuario.Text)
                Trans.SetParametro("@Id_Factura", F.Id)
                Trans.SetParametro("@Contesto", Contesto)
                Trans.SetParametro("@Mensaje", IIf(Mensaje = "", " ", Mensaje))
                Trans.SetParametro("@EnvioMensaje", EnvioMensaje)
                Trans.SetParametro("@EnvioCarta", EnvioCarta)
                Trans.SetParametro("@Etapa", F.Etapa)
                Trans.SetParametro("@PV", F.PV)
                Trans.Ejecutar(strSQL, CommandType.Text)
                Trans.Ejecutar("Update " & F.PV & ".dbo.Ventas Set Etapa = Etapa + 1, FechaEtapa = GetDate() Where Id = " & F.Id, CommandType.Text)
            Next
            Trans.Commit()
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)

            If dt.Rows.Count > 0 Then
                Me.btnCargarDatos.Enabled = True
                Me.txtClave.Enabled = False
                Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                Me.txtNombreUsuario.Text = dt.Rows(0).Item("Nombre")
            End If
        End If
    End Sub

    Private Sub btnCargarDatos_Click(sender As Object, e As EventArgs) Handles btnCargarDatos.Click
        Me.CargarDatos()
    End Sub

    Private Sub frmGestionCobro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub viewDatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEnter
        'On Error Resume Next
        Dim Identificacion As String = Me.viewDatos.Item("cIdentificacion", e.RowIndex).Value
        Dim Facturas As Collections.Generic.List(Of GestionCobro.Factura) = (From x As DataRow In Me.GestionCobrodt.Rows
                                                                       Where x.Item("Saldo") > 0 And x.Item("Identificacion") = Identificacion
                                                                       Select New GestionCobro.Factura() With {
                                                                                                        .PV = x.Item("PV"),
                                                                                                        .Id = x.Item("Id"),
                                                                                                        .Num_Factura = x.Item("Num_Factura"),
                                                                                                        .Tipo = x.Item("Tipo"),
                                                                                                        .Fecha = x.Item("Fecha"),
                                                                                                        .Vence = x.Item("Vence"),
                                                                                                        .Etapa = x.Item("Etapa"),
                                                                                                        .FechaEtapa = x.Item("FechaEtapa"),
                                                                                                        .Saldo = x.Item("Saldo")}).ToList
        Me.viewFacturas.DataSource = Facturas
        Me.viewFacturas.Columns("pv").Visible = False
        Me.viewFacturas.Columns("Saldo").DefaultCellStyle.Format = "N2"
        Me.viewFacturas.Columns("Num_Factura").HeaderText = "Factura"
        Me.viewFacturas.Columns("Id").Visible = False
        Me.viewFacturas.Columns("FechaEtapa").Visible = False
        Me.viewFacturas.Columns("Etapa").Visible = False
        Me.viewFacturas.Columns("Fecha").DefaultCellStyle.Format = "d"
        Me.viewFacturas.Columns("Vence").DefaultCellStyle.Format = "d"
        Me.lblTotalFacturas.Text = "Total: " & (From x As GestionCobro.Factura In Facturas Select x.Saldo).Sum().ToString("N2")
        Me.CargarBitacora(Identificacion)
        For Each r As DataGridViewRow In Me.viewFacturas.Rows
            Select Case CInt(r.Cells("Etapa").Value)
                Case 0
                    r.DefaultCellStyle.BackColor = Drawing.Color.Yellow
                    r.DefaultCellStyle.SelectionBackColor = Drawing.Color.Yellow
                    r.DefaultCellStyle.SelectionForeColor = Drawing.Color.Black
                Case 1
                    r.DefaultCellStyle.BackColor = Drawing.Color.Green
                    r.DefaultCellStyle.SelectionBackColor = Drawing.Color.Green
                    r.DefaultCellStyle.SelectionForeColor = Drawing.Color.Black
                Case 2
                    r.DefaultCellStyle.BackColor = Drawing.Color.Red
                    r.DefaultCellStyle.SelectionBackColor = Drawing.Color.Red
                    r.DefaultCellStyle.SelectionForeColor = Drawing.Color.Black
            End Select
        Next
    End Sub

    Private Sub viewDatos_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatos.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = Me.cEnviarCorreo.Index Then
                
            ElseIf e.ColumnIndex = Me.cEnviarCarta.Index Then
               
            ElseIf e.ColumnIndex = Me.cEditar.Index Then
                Dim frm As New Frmcliente
                If frm.ShowDialog Then

                End If
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        For Each r As DataGridViewRow In Me.viewDatos.Rows
            If r.Cells("cListo").Value = True Then
                Me.GuardarBitacora(r)            
            End If
        Next
        Me.CargarDatos()
        MsgBox("Listo", MsgBoxStyle.Information, Me.Text)
    End Sub

    Private Sub btnCorreo_Click(sender As Object, e As EventArgs) Handles btnCorreo.Click
        If Me.viewFacturas.RowCount > 0 Then
            Me.viewDatos.Item("cEnvioMensaje", Me.viewDatos.CurrentRow.Index).Value = True
            PrepararCorreo(Me.viewDatos.Item("cIdentificacion", Me.viewDatos.CurrentRow.Index).Value, Me.viewDatos.Item("cNombre", Me.viewDatos.CurrentRow.Index).Value, Me.viewDatos.Item("cCorreo", Me.viewDatos.CurrentRow.Index).Value)
        End If        
    End Sub

    Private Sub btnCarta_Click(sender As Object, e As EventArgs) Handles btnCarta.Click
        If Me.viewFacturas.RowCount > 0 Then
            Me.viewDatos.Item("cEnvioCarta", Me.viewDatos.CurrentRow.Index).Value = True
            MsgBox("Enviar Carta")
        End If
    End Sub

    Private Sub btnEdiarCliente_Click(sender As Object, e As EventArgs) Handles btnEdiarCliente.Click
        Dim frm As New Frmcliente
        frm.txtUsuario.Text = Me.txtClave.Text
        frm.Cod_Cliente_Buscar = Me.viewDatos.Item("cIdentificacion", Me.viewDatos.CurrentRow.Index).Value

        Dim Tipo As String = ""
        Dim Facturas As Collections.Generic.List(Of GestionCobro.Factura) = (From x As DataRow In Me.GestionCobrodt.Rows
                                                               Where x.Item("Saldo") > 0 And x.Item("Identificacion") = frm.Cod_Cliente_Buscar
                                                               Select New GestionCobro.Factura() With {
                                                                                                .PV = x.Item("PV"),
                                                                                                .Id = x.Item("Id"),
                                                                                                .Num_Factura = x.Item("Num_Factura"),
                                                                                                .Tipo = x.Item("Tipo"),
                                                                                                .Fecha = x.Item("Fecha"),
                                                                                                .Vence = x.Item("Vence"),
                                                                                                .Etapa = x.Item("Etapa"),
                                                                                                .FechaEtapa = x.Item("FechaEtapa"),
                                                                                                .Saldo = x.Item("Saldo")}).ToList
        For Each f As GestionCobro.Factura In Facturas
            Tipo = f.Tipo
        Next
        frm.CadenaConexionTemp = Tipo
        frm.ShowDialog()
    End Sub
End Class