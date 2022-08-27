Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Data.SqlClient

Public Class frmPedidosBodega

    Private WithEvents cls As New OBSoluciones.Inventario.Solicitud
    Private idsolicitud As Long = 0

    'Private Sub CargarPuntoVenta(_cbo As System.Windows.Forms.ComboBox)
    '    Dim dt As New DataTable
    '    cFunciones.Llenar_Tabla_Generico("select IdPuntoVenta, PuntoVenta from " & TablaSeguridad() & ".dbo.PuntodeVenta", dt, CadenaConexionSeePOS)
    '    _cbo.DataSource = dt
    '    _cbo.DisplayMember = "PuntoVenta"
    '    _cbo.ValueMember = "IdPuntoVenta"
    'End Sub

    Private Sub frmTrasladosDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CargarPuntoVenta(Me.cboPuntoVentaOrigen)
        'Me.CargarPuntoVenta(Me.cboPuntoVentaDestino)
        txt_codigo.Focus()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs)
        Me.guardar()
    End Sub

    Sub limpiar()
        'Me.cboPuntoVentaOrigen.Enabled = True
        'Me.cboPuntoVentaDestino.Enabled = True
        txtnota.Text = ""
        dt_fecha.Text = Date.Now
        gp_2.Enabled = True
        Me.bt_guardar.Enabled = True
        Me.bt_buscar.Enabled = True
        Me.bt_eliminar.Enabled = False
        Me.btnImprimir.Enabled = False
        limpiar_valores()
        limpiar_datagrid()
    End Sub

    Sub limpiar_datagrid()
        Me.viewDatos.Rows.Clear()
    End Sub

    Sub guardar()
        cls = New OBSoluciones.Inventario.Solicitud
        cls.IdSolicitud = Me.idsolicitud
        cls.Fecha = Me.dt_fecha.Value
        cls.descripcion = Me.txtDescripcion.Text
        cls.Anulado = False
        cls.Id_UsuarioCreo = Me.Id_UsuarioCreo
        If cls.Guardar(Me.viewDatos) = True Then
            Me.limpiar()
            Me.limpiar_datagrid()
        End If
    End Sub

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters
            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION" 'FACTURACION
                    If PrinterToSelect = 0 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CONTADO"
                    If PrinterToSelect = 1 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CREDITO"
                    If PrinterToSelect = 2 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA"
                    If PrinterToSelect = 3 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FAX"
                    If PrinterToSelect = 4 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA02"
                    If PrinterToSelect = 5 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FACTURACION02" 'FACTURACION
                    If PrinterToSelect = 6 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
            End Select
        Next

        If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
            Dim PrinterDialog As New PrintDialog
            Dim DocPrint As New PrintDocument
            PrinterDialog.Document = DocPrint
            PrinterDialog.ShowDialog()
            If PrinterDialog.ShowDialog.Yes Then
                Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
            Else
                Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
            End If
        Else
            Return ""
        End If
    End Function

    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Return ""
        End If
        Codigo = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo
    End Function

    Private CodArticulo As String
    Private Sub cargar_datos_inventario()

        Dim codigo As String = Me.BuscarF1
        If codigo <> "" Then
            txt_codigo.Text = ""
            txt_cantidad.Value = 1

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Codigo, Cod_Articulo, Descripcion, Existencia, Precio_A, Prestamo from Inventario where Cod_Articulo = '" & codigo & "' and inhabilitado = 0", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then

                txt_codigo.Text = dt.Rows(0).Item("Codigo")
                Me.CodArticulo = dt.Rows(0).Item("Cod_Articulo")
                txt_descripcion.Text = dt.Rows(0).Item("Descripcion")
                txt_existencia_act.Text = dt.Rows(0).Item("Existencia")
                txt_precio.Text = dt.Rows(0).Item("Precio_A")
                txt_prestamo.Text = dt.Rows(0).Item("Prestamo")
                txt_cantidad.Value = 1
                txt_cantidad.Focus()
                txt_cantidad.BackColor = Color.Bisque

            End If
        End If
    End Sub

    Private Sub txt_codigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_codigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                Me.cargar_datos_inventario()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Sub agregar_producto()

        Try
            Dim codigo, cod_articulo, descripcion, cantidad, precio, nota As String

            codigo = txt_codigo.Text
            descripcion = txt_descripcion.Text
            cantidad = txt_cantidad.Value
            precio = txt_precio.Text
            nota = Me.txtnota.Text
            cod_articulo = Me.CodArticulo

            viewDatos.Rows.Add(codigo, cod_articulo, lb_id.Text, descripcion, cantidad, nota, precio)
            'Me.cboPuntoVentaOrigen.Enabled = False
            'Me.cboPuntoVentaDestino.Enabled = False
            limpiar_valores()
            txt_codigo.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub limpiar_valores()
        Me.CodArticulo = ""
        txt_codigo.Text = ""
        txt_prestamo.Text = ""
        txt_precio.Text = ""
        txt_cantidad.Text = ""
        txt_descripcion.Text = ""
        txt_existencia_act.Text = ""
        txt_cantidad.BackColor = Color.White
    End Sub

    Private Sub bt_agregar_Click(sender As Object, e As EventArgs) Handles bt_agregar.Click
        If txt_codigo.Text <> "" Then
            agregar_producto()
        Else
            MsgBox("Agregar producto", MsgBoxStyle.Information, "Agregar Producto")
            txt_codigo.Focus()
        End If
    End Sub

    Private Sub txt_cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cantidad.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_codigo.Text <> "" Then
                    Me.txtnota.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        guardar()
    End Sub

    Private Sub bt_buscar_Click(sender As Object, e As EventArgs) Handles bt_buscar.Click
        Try
            Dim frm As New frmBuscarSolicitudBodega
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Id As String = frm.viewDatos.Item("idsolicitud", frm.viewDatos.CurrentRow.Index).Value
                cargar_informacion_prestamo(Id)
                Me.idsolicitud = Id
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub cargar_informacion_prestamo(_idsolicitud As String)

        Dim dtEncabezado As New DataTable
        Dim dtDetalle As New DataTable

        Try
            cFunciones.Llenar_Tabla_Generico("select * from Solicitud where idsolicitud = " & _idsolicitud, dtEncabezado, CadenaConexionSeePOS)
            cFunciones.Llenar_Tabla_Generico("select * from solicituddetalle where idsolicitud = " & _idsolicitud, dtDetalle, CadenaConexionSeePOS)

            If dtEncabezado.Rows.Count > 0 Then

                Me.dt_fecha.Value = dtEncabezado.Rows(0).Item("Fecha")
                Me.txtDescripcion.Text = dtEncabezado.Rows(0).Item("Descripcion")

                Me.btnImprimir.Enabled = True
                Me.bt_eliminar.Enabled = True
                Me.bt_guardar.Enabled = False
                Me.lblAnulado.Visible = False

                If dtEncabezado.Rows(0).Item("Anulado") = True Or dtEncabezado.Rows(0).Item("Anulado") = 1 Then
                    Me.bt_eliminar.Enabled = False
                    Me.lblAnulado.Visible = True
                End If

                Me.viewDatos.Rows.Clear()
                Dim codigo, cod_articulo, descripcion, cantidad, nota, precio As String
                For Each r As DataRow In dtDetalle.Rows
                    codigo = r.Item("Codigo")
                    cod_articulo = r.Item("Cod_Articulo")
                    descripcion = r.Item("Descripcion")
                    cantidad = r.Item("Cantidad")
                    nota = r.Item("Nota")
                    precio = 0
                    viewDatos.Rows.Add(codigo, cod_articulo, lb_id.Text, descripcion, cantidad, nota, precio)
                Next

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bt_eliminar_Click(sender As Object, e As EventArgs) Handles bt_eliminar.Click
        If MsgBox("Desea Anular el Traslado ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.Yes Then
            cls.Anular(Me.idsolicitud)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            Dim PrestamoPVE As New rptTrasladoPuntoVentaPVE
            Dim PrinterSettings1 As New Printing.PrinterSettings
            Dim PageSettings1 As New Printing.PageSettings
            PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

            CrystalReportsConexion.LoadReportViewer(Nothing, PrestamoPVE, True)
            PrestamoPVE.SetParameterValue(0, lb_id.Text)
            PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
    Dim usua As Usuario_Logeado
    Private Id_UsuarioCreo As String = ""
    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim cConexion As New LcPymes_5._2.Conexion
            Dim rs As SqlDataReader
            If e.KeyCode = Keys.Enter Then
                If txtUsuario.Text <> "" Then
                    rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                    If rs.HasRows = False Then
                        MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                        txtUsuario.Focus()
                    End If
                    While rs.Read
                        Try
                            Me.ToolStrip1.Enabled = False
                            Me.gp_2.Enabled = False

                            Me.Id_UsuarioCreo = rs("Cedula")
                            Me.txtNombreUsuario.Text = rs("Nombre")
                            PMU = VSM(rs("Cedula"), "PrestamosBodega") 'Carga los privilegios del usuario con el modulo
                            If PMU.Execute Then  Else MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                            Me.ToolStrip1.Enabled = True
                            Me.gp_2.Enabled = True
                            Me.limpiar()

                        Catch ex As SystemException
                            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                        End Try
                    End While
                    rs.Close()
                    cConexion.DesConectar(cConexion.sQlconexion)
                Else
                    MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                    txtUsuario.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub cls_Guardado(_Id As Long) Handles cls.Guardado
        Me.limpiar()
        MsgBox("Guardado correctamente", MsgBoxStyle.Information, Text)
        'imprimir
        Dim PrestamoPVE As New rptTrasladoPuntoVentaPVE
        Dim PrinterSettings1 As New Printing.PrinterSettings
        Dim PageSettings1 As New Printing.PageSettings
        PrinterSettings1.PrinterName = Automatic_Printer_Dialog(3)

        CrystalReportsConexion.LoadReportViewer(Nothing, PrestamoPVE, True)
        PrestamoPVE.SetParameterValue(0, _Id)
        PrestamoPVE.PrintToPrinter(PrinterSettings1, PageSettings1, False)
    End Sub

    Private Sub cls_setError(_msg As String) Handles cls.setError
        MsgBox(_msg, MsgBoxStyle.Critical, Text)
    End Sub

    Private Sub cls_TraladoAnulado(_Id As Long) Handles cls.TraladoAnulado
        Me.limpiar()
        MsgBox("Anulado correctamente", MsgBoxStyle.Information, Text)
    End Sub

    Private Sub txtnota_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnota.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_codigo.Text <> "" Then
                agregar_producto()
            End If
        End If
    End Sub
End Class
