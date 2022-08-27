Imports System.Windows.Forms
Imports System.Data


Public Class frmReintegroFacturaPendiente

    Public Id_PreVenta As Long = 0
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As Integer = 0
    Public BanderaesCliente As Boolean = False

    Public NumCuenta As Integer = 0

    Private Sub Cobrar(_Tipo As String)
        Dim frm As New frmIngresarFomasdePago
        frm.btnPendientes.Enabled = False
        frm.SoloCobrar = True
        frm.PuntodeVenta = Me.txtPuntoVenta.Text
        frm.Id_PreVenta = Me.Id_PreVenta
        frm.Num_Factura = Me.txtNumeroFactura.Text
        frm.Id_Factura = Me.Id_PreVenta
        frm.TipoFactura = _Tipo
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.TotalCobro = CDec(Me.txtTotalCobro.Text)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Function TipoTiquete() As String
        Return "PVE"
    End Function

    Private Function TipoFactura() As String
        Dim Tipo As String = ""
        'Puede ser CON (parte Agro)
        'Puede ser TCO (parte Taller)
        Tipo = "CON" 'solo para pruebas, despues hay que agregar validacion
        Return Tipo
    End Function

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

    Private Sub CargarDatosPreventa()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewPreventasActivas Where NumCuenta = " & Me.NumCuenta, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then

        End If
    End Sub

    Private Sub frmDatosPreVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridViewxDefecto(Me.viewDatos)
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        If Me.txtTotalCobro.Text <> "" Then
            If IsNumeric(Me.txtTotalCobro.Text) = True Then
                If CDec(Me.txtTotalCobro.Text) > 0 Then
                    If sender.Name = Me.btnCobrar.Name Then
                        Dim Tipo As String = ""
                        Tipo = Me.TipoTiquete
                        Me.Cobrar(Tipo)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmDatosPreVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                Me.Cobrar(Me.TipoFactura)
            Case Keys.F3
                Me.Cobrar(Me.TipoTiquete)
            Case Keys.F4
        End Select
    End Sub

    Private Sub btnBuscarFacturaPendiente_Click(sender As Object, e As EventArgs) Handles btnBuscarFacturaPendiente.Click
        Me.txtTotalCobro.Text = ""
        Dim frm As New frmBuscarFacturaPendiente
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim filas As System.Collections.Generic.List(Of DataGridViewRow) = (From r As DataGridViewRow In frm.viewDatos.Rows Where r.Cells("Usar").Value = True Select r).ToList()

            For Each r As DataGridViewRow In filas
                Dim BasedeDatos As String = r.Cells("Basededatos").Value 'frm.viewDatos("Basededatos", frm.viewDatos.CurrentRow.Index).Value
                Dim Id_Factura As String = r.Cells("Id_Factura").Value 'frm.viewDatos("Id_Factura", frm.viewDatos.CurrentRow.Index).Value

                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("select * from viewfacturasautorizadas Where BasedeDatos = '" & BasedeDatos & "' and Id = " & Id_Factura & "", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then

                    Dim dtCliente As New DataTable
                    Dim esCliente As Boolean
                    Dim cedula, correo As String
                    cFunciones.Llenar_Tabla_Generico("select cedula, CorreoComprobante from " & txtPuntoVenta.Text & ".dbo.Clientes where identificacion = " & dt.Rows(0).Item("Cod_Cliente"), dtCliente, CadenaConexionSeePOS)
                    If dtCliente.Rows.Count > 0 Then
                        esCliente = True
                        cedula = dtCliente.Rows(0).Item("cedula")
                        correo = dtCliente.Rows(0).Item("CorreoComprobante")
                    Else
                        cedula = ""
                        correo = ""
                        esCliente = False
                    End If

                    Id_PreVenta = dt.Rows(0).Item("Id")
                    txtPuntoVenta.Text = dt.Rows(0).Item("BasedeDatos")
                    Id_Usuario = Me.Id_Usuario
                    NombreUsuario = Me.NombreUsuario
                    Numero_Caja = Me.Numero_Caja
                    txtCliente.Text = dt.Rows(0).Item("Nombre_Cliente")
                    txtCedula.Text = cedula
                    txtCorreo.Text = correo
                    BanderaesCliente = esCliente

                    Me.txtTotalFactura.Text = CDec(dt.Rows(0).Item("Total")).ToString("N2")
                    Me.CalcularTotalCobro()

                    Me.txtNumeroFactura.Text = dt.Rows(0).Item("Num_Factura")
                    Dim dtdetalle As New DataTable
                    cFunciones.Llenar_Tabla_Generico("select CodArticulo, Descripcion, Cantidad, Precio_Unit, SubTotal from " & txtPuntoVenta.Text & ".dbo.Ventas_Detalle Where Id_Factura = " & dt.Rows(0).Item("Id"), dtdetalle, CadenaConexionSeePOS)
                    viewDatos.DataSource = dtdetalle
                    Try
                        viewDatos.Columns("Cantidad").DefaultCellStyle.Format = "N2"
                        viewDatos.Columns("Cantidad").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                        viewDatos.Columns("Precio_Unit").DefaultCellStyle.Format = "N2"
                        viewDatos.Columns("Precio_Unit").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                        viewDatos.Columns("SubTotal").DefaultCellStyle.Format = "N2"
                        viewDatos.Columns("SubTotal").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                    Catch ex As Exception
                    End Try
                End If

            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmNumeroFicha
        frm.CargarPrimerUsuario(Me.Id_Usuario)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Function GetAbono() As Decimal
        If Me.Id_PreVenta > 0 Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select isnull(sum(Monto),0) as Abono from abonoreintegro Where Anulado = 0 and Id_Factura = " & Me.Id_PreVenta, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Abono")
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    Private Sub CalcularTotalCobro()
        Dim Abono As Decimal = Me.GetAbono
        Me.txtTotalAbono.Text = Abono.ToString("N2")
        Me.txtTotalCobro.Text = (CDec(Me.txtTotalFactura.Text) - Abono).ToString("N2")
    End Sub

    Private Sub btnAbonar_Click(sender As Object, e As EventArgs) Handles btnAbonar.Click
        If Me.Id_PreVenta > 0 Then
            Dim frm As New frmControlAbono
            frm.Id_Usuario = Me.Id_Usuario
            frm.NombreUsuario = Me.NombreUsuario
            frm.Numero_Caja = Me.Numero_Caja
            frm.IdFactura = Me.Id_PreVenta
            frm.IdFactura = Me.Id_PreVenta
            frm.txtTotalFactura.Text = Me.txtTotalFactura.Text
            frm.ShowDialog()
            Me.CalcularTotalCobro()
        End If        
    End Sub

    Private Sub btnVarias_Click(sender As Object, e As EventArgs) Handles btnVarias.Click
        Dim frm As New frmPagarVariasJuntas
        frm.Id_Usuario = Me.Id_Usuario
        frm.Numero_Caja = Me.NumCuenta
        frm.NombreUsuario = Me.NombreUsuario
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub
End Class