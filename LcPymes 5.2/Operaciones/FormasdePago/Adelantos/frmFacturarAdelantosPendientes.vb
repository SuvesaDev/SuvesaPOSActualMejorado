Imports System.Windows.Forms
Imports System.Data

Public Class frmFacturarAdelantosPendientes

    Public Id_Adelanto As Long = 0
    Public Tipo As String = ""
    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As Integer = 0
    Public BanderaesCliente As Boolean = False

    Public NumCuenta As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmNumeroFicha
        frm.CargarPrimerUsuario(Me.Id_Usuario)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscarFacturaPendiente_Click(sender As Object, e As EventArgs) Handles btnBuscarFacturaPendiente.Click
        Me.txtTotalCobro.Text = ""
        Dim frm As New frmBuscarAdelantoPendiente
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from viewAdelantosAutorizados Where Id = " & frm.viewDatos("Id_Adelanto", frm.viewDatos.CurrentRow.Index).Value & "", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then

                Dim dtCliente As New DataTable
                Dim esCliente As Boolean
                Dim cedula, correo As String
                cFunciones.Llenar_Tabla_Generico("select cedula, CorreoComprobante from Clientes where identificacion = " & dt.Rows(0).Item("Cod_Cliente"), dtCliente, CadenaConexionSeePOS)
                If dtCliente.Rows.Count > 0 Then
                    esCliente = True
                    cedula = dtCliente.Rows(0).Item("cedula")
                    correo = dtCliente.Rows(0).Item("CorreoComprobante")
                Else
                    cedula = ""
                    correo = ""
                    esCliente = False
                End If

                Id_Adelanto = dt.Rows(0).Item("Id")
                Tipo = dt.Rows(0).Item("Tipo")
                txtPuntoVenta.Text = dt.Rows(0).Item("BasedeDatos")
                Id_Usuario = Me.Id_Usuario
                NombreUsuario = Me.NombreUsuario
                Numero_Caja = Me.Numero_Caja
                txtCliente.Text = dt.Rows(0).Item("Nombre_Cliente")
                txtCedula.Text = cedula
                txtCorreo.Text = correo
                BanderaesCliente = esCliente

                Me.txtTotalCobro.Text = CDec(dt.Rows(0).Item("Total")).ToString("N2")

                Me.txtNumeroFactura.Text = dt.Rows(0).Item("Num_Factura")
                Dim dtdetalle As New DataTable
                cFunciones.Llenar_Tabla_Generico("select CodArticulo, Descripcion, Cantidad, Precio_Unit, SubTotal from AdelantoVentas_Detalle Where Id_Factura = " & dt.Rows(0).Item("Id"), dtdetalle, CadenaConexionSeePOS)
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


        End If

    End Sub
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
    Private Sub frmFacturarAdelantosPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridViewxDefecto(Me.viewDatos)
    End Sub

    Private Sub Cobrar(_Tipo As String)
        Dim frm As New frmIngresarFomasdePago
        frm.EsAdelanto = True
        frm.PuntodeVenta = Me.txtPuntoVenta.Text
        frm.Id_Adelanto = Me.Id_Adelanto
        frm.TipoFactura = _Tipo
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.TotalCobro = CDec(Me.txtTotalCobro.Text)
        frm.MdiParent = Me.MdiParent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Me.Cobrar(Me.Tipo)
    End Sub

End Class