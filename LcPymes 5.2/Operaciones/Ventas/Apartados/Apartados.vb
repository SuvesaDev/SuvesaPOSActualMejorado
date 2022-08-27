Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class Apartados
    Inherits FrmPlantilla

#Region "Variables"
    Dim FrmVuelto As New Vuelto
    Dim iddebodega As Integer
    Dim clietencon As Boolean
    Dim logeado As Boolean
    Public Usua As Object
    Dim impuesto_cliente As Double = 100
    Dim PMU As New PerfilModulo_Class
    Public Cedula_usuario As Object
    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    Dim PrecioBase As Double
    Dim Max_Descuento_Articulo As Double
    Dim PrecioCosto As Double
    Dim Flete As Double
    Dim OtrosMontos As Double
    Dim Existencia As Integer
    Dim PrecioA As Double
    Dim PrecioB As Double
    Dim PrecioC As Double
    Dim PrecioD As Double
    Private tipoprecio As Integer
    Dim MonedaBase As Integer
    Dim precio_promo_valor As Double
    Dim MonedaCosto As Integer
    Dim ValorCosto As Double
    Dim ValorVenta As Double
    Dim MonedaVenta As Integer
    Dim ValorBase As Double
    Dim MontoImpuesto As Double
    Dim precio_unitario As Double
    Dim promo_activa_valor As Boolean
    Dim monto_Perdido As Double
    Dim Cambio_Cantidad As Boolean
    Dim vende_existecias_negativas As Boolean
    Dim mensaje As String ' almacena el mensaje de los descuentos
    Dim variacion_Punit As Double
    Private Exento As Double
    Private Gravado As Double
    Dim reporte As New Repoteapartado
    'Descuento
    Private DescuentoCalc As Double
    Private descuento As Double
    Dim porcentaje_descuento As Double
    Dim max_aplicar As Double 'almacena el maximo porcentaje de descuento que se puede aplicar a determinado articulo
    Dim tempvuelto As Double = 0
#End Region

#Region "Load"
    Private Sub Apartados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SqlConnection1.ConnectionString = GetSetting("SeeSOFT", "SeePOS", "CONEXION")
        Me.Ad_usuarios.Fill(Me.Ds_Apartado1, "Usuarios")
        Me.Adapter_Moneda.Fill(Ds_Apartado1, "Moneda")
        txtCodigo.Enabled = True
        '-----------------------------------------------------------------------
        'VERIFICA LA BODEGA DE DESCARGA - ORA
        Try
            iddebodega = GetSetting("SeeSOFT", "SeePOS", "Bodega")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePos", "Bodega", "0")
            iddebodega = 0
        End Try
        '-----------------------------------------------------------------------
        valoresdefecto()
        txtUsuario.Text = Usua.clave_interna
        Loggin_Usuario()
        CrystalReportsConexion.LoadReportViewer(Nothing, reporte, True)
        Nuevo_apartado()
    End Sub

#Region "Valores defecto"
    Sub valoresdefecto()
        'Detalle Apartado
        Ds_Apartado1.Apartado_detalle.Id_detalleColumn.AutoIncrement = True
        Ds_Apartado1.Apartado_detalle.Id_detalleColumn.AutoIncrementStep = -1
        Ds_Apartado1.Apartado_detalle.Id_detalleColumn.AutoIncrementSeed = -1
        Ds_Apartado1.Apartado_detalle.Monto_descuentoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.DescripcionColumn.DefaultValue = ""
        Ds_Apartado1.Apartado_detalle.CantidadColumn.DefaultValue = 1
        Ds_Apartado1.Apartado_detalle.Precio_BaseColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Precio_CostoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Precio_OtrosColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Monto_ImpuestoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.SubTotalColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.SubTotalExcentoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.SubtotalGravadoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.DescuentoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Precio_UnitColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Cod_MonedaVentaColumn.DefaultValue = 1
        Ds_Apartado1.Apartado_detalle.Precio_FleteColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.ImpuestoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Tipo_Cambio_ValorCompraColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Total_FicticioColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Tipo_Cambio_ValorCompraColumn.DefaultValue = 1
        Ds_Apartado1.Apartado_detalle.Cod_MonedaVentaColumn.DefaultValue = 1
        Ds_Apartado1.Apartado_detalle.ExistenciaColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.Max_DescuentoColumn.DefaultValue = 0
        Ds_Apartado1.Apartado_detalle.IdBodegaColumn.DefaultValue = iddebodega

        'Apartado
        Ds_Apartado1.Apartados.Id_ApartadoColumn.AutoIncrement = True
        Ds_Apartado1.Apartados.Id_ApartadoColumn.AutoIncrementSeed = -1
        Ds_Apartado1.Apartados.Id_ApartadoColumn.AutoIncrementStep = -1
        Ds_Apartado1.Apartados.Id_ClienteColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.NombreclienteColumn.DefaultValue = ""
        Ds_Apartado1.Apartados.SubTotalColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.SubTotalExentoColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.SubTotalGravadaColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.CanceladoColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.AnuladoColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.DescuentoColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.ObservacionesColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.CedulausuarioColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.FechaColumn.DefaultValue = Now
        Ds_Apartado1.Apartados.VenceColumn.DefaultValue = Now.AddMonths(1)
        Ds_Apartado1.Apartados.Imp_VentaColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.TotalColumn.DefaultValue = 0
        Ds_Apartado1.Apartados.ObservacionesColumn.DefaultValue = ""
        Ds_Apartado1.Apartados.Tipo_CambioColumn.DefaultValue = 1
        Ds_Apartado1.Apartados.Cod_MonedaColumn.DefaultValue = 1
        Ds_Apartado1.Apartados.MontoColumn.DefaultValue = 0

        txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Ds_Apartado1, "Moneda.ValorCompra"))
    End Sub
#End Region

#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo_apartado()
            Case 2 : If PMU.Find Then Buscar_Apartado() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then ImprimirFactura() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el módulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Dispose(True) : Me.Close()
        End Select
    End Sub
#End Region

#Region "Cargar Informacion del cliente"
    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        clietencon = False
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New Apartado.cFunciones

            txtCodigo.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes_frecuentes", "Nombre")

            CargarInformacionCliente(txtCodigo.Text)
            If clietencon Then
                Dt_Vence.Focus()
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If txtCodigo.Text <> "" Then
                CargarInformacionCliente(txtCodigo.Text)
                If clietencon Then
                    Dt_Vence.Focus()

                End If
            End If
        End If

        If e.KeyCode = Keys.F2 Then
            Me.registrar()
        End If

        If e.KeyCode = Keys.F3 Then
            Buscar_Apartado()
        End If

        If e.KeyCode = Keys.F6 Then
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            Me.GridControl1.Enabled = True
            GridControl1.Focus()
        End If

        If e.KeyCode = Keys.F11 Then
            abonos()
        End If

        If e.KeyCode = Keys.Escape Then
            If MessageBox.Show("¿Desea cancelar esta factura?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If MessageBox.Show("¿Desea cancelar esta factura?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados").CancelCurrentEdit()
                    Me.SimpleButton1.Enabled = False
                    Ds_Apartado1.Apartado_detalle.Clear()
                    Ds_Apartado1.Apartados.Clear()
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True
                    Me.GroupBox3.Enabled = False
                    Me.dtFecha.Enabled = False
                    Me.logeado = False
                    Me.SimpleButton3.Enabled = False
                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()
                    Me.Loggin_Usuario()
                End If
            End If
        End If

        If e.KeyCode = Keys.Insert Then
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
            txtExistencia.EditValue = 0
            'GridControl1.Enabled = False
            txt_articulo.Focus()
        End If
    End Sub

#Region "Consecutivo Interfaz"
    Sub consecutivointerfaz()
        Dim func As New Conexion
        Dim numfact As String = ""
        Try
            numfact = func.SQLExeScalar("SELECT ISNULL(MAX(Id_Apartado), 0) + 1 AS Num_Apartado FROM Apartados")
            lbconsecutivo.Text = numfact
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub CargarInformacionCliente(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New Apartado.cFunciones
        Dim rs As SqlDataReader

        rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Identificacion, Nombre from Clientes_frecuentes where Identificacion ='" & codigo & "'")

        Try
            If rs.Read Then
                txtCodigo.Text = rs("Identificacion")
                txtNombre.Text = rs("Nombre")
                impuesto_cliente = 100 'rs("impuesto")
                clietencon = True
            Else
                MsgBox("La identificación del Cliente no se encuentra", MsgBoxStyle.Information, "Atención...")
                txtCodigo.Focus()
                rs.Close()
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        rs.Close()
        cConexion.DesConectar(cConexion.Conectar)

    End Sub

#End Region

#Region "Nuevo"
    Private Sub Nuevo_apartado()
        ToolBarRegistrar.Enabled = False
        ToolBarEliminar.Enabled = False
        ToolBarImprimir.Enabled = False
        LAnulado.Visible = False
        LCancelado.Visible = False

        If ToolBarNuevo.Text = "Cancelar" Then
            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            BindingContext(Ds_Apartado1, "Apartados").CancelCurrentEdit()
            BindingContext(Ds_Apartado1, "Apartados").EndCurrentEdit()
            Ds_Apartado1.Apartado_detalle.Clear()
            Ds_Apartado1.Apartados.Clear()
            ToolBarNuevo.Text = "Nuevo"
            inhabilitar()
            ToolBarNuevo.ImageIndex = 0
            txtCodigo.Focus()
            Exit Sub
        End If
        If ToolBarNuevo.Text = "Nuevo" Then
            ToolBarNuevo.ImageIndex = 8
            ToolBarNuevo.Text = "Cancelar"
            habilitar()
            Try
                Me.Ds_Apartado1.Apartado_detalle.Clear()
                Ds_Apartado1.Apartados.Clear()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados").EndCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados").AddNew()
                iniciar_factura()

            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub iniciar_factura()
        Try
            Dim nom As String = Me.txtNombre.Text


            BindingContext(Ds_Apartado1, "Apartados").Current("Cedulausuario") = Me.Cedula_usuario


            Me.BindingContext(Me.Ds_Apartado1, "Apartados").Current("Cedulausuario") = Me.Cedula_usuario

            txtNombre.Text = nom

            If Me.txtCodigo.Text = "" Then
                Me.txtCodigo.Text = "0"
            End If
            If Me.BindingContext(Me.Ds_Apartado1, "Apartados").Count = 1 Then
                Me.BindingContext(Me.Ds_Apartado1, "Apartados").EndCurrentEdit()
                ' dias_credito()
            End If

            Me.GridControl1.Enabled = True
            Me.SimpleButton1.Enabled = True

            Me.ToolBar1.Buttons(2).Enabled = True 'se activa el botond e guardar

            Me.GroupBox3.Enabled = True
            If Me.txtDescuento.Properties.ReadOnly = True Then Me.txtDescuento.Properties.Enabled = False
            If Me.txtPrecioUnit.Properties.ReadOnly = True Then Me.txtPrecioUnit.Properties.Enabled = False

            Me.txtCantidad.Text = 1

            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
            txtExistencia.EditValue = 0
            consecutivointerfaz()
            txtCodigo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Buscar Apartado"
    Sub Buscar_Apartado()
        If GroupBox6.Enabled Then
            If MsgBox("Actualmente se esta creando un apartado, desea cancelar esta edicion y hacer la busqueda", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Ds_Apartado1.Apartado_detalle.Clear()
                Ds_Apartado1.Apartados.Clear()
                BindingContext(Ds_Apartado1, "Apartados").CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                ToolBar1.Buttons(0).Enabled = True
                ToolBar1.Buttons(1).Enabled = True
                ToolBar1.Buttons(2).Enabled = False
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(4).Enabled = False
                LAnulado.Visible = False
                LCancelado.Visible = False
                inhabilitar()
            Else
                Exit Sub
            End If
        End If
        Try
            Dim Fx As New Apartado.cFunciones
            Dim valor As String

            valor = Fx.BuscarDatos("SELECT Apartados.Id_Apartado, Clientes_frecuentes.nombre FROM Clientes_frecuentes INNER JOIN Apartados ON Clientes_frecuentes.identificacion = Apartados.Id_Cliente", "Clientes.nombre", "Buscar Apartados...", GetSetting("Seesoft", "SeePos", "Conexion"))
            If valor = "" Then
                Exit Sub
            Else
                Ds_Apartado1.Apartado_detalle.Clear()
                Ds_Apartado1.Apartados.Clear()
                Cargarapartado(CInt(valor))
                CargarInformacionCliente(CInt(txtCodigo.Text))
                Dim i As Integer

                For i = 0 To Me.BindingContext(Ds_Apartado1.Apartado_detalle).Count - 1 ' busca si en el detalle de la factura existen devolucines
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Position = i
                    Me.Ds_Apartado1.Apartado_detalle.Rows(i).Item("Total_Ficticio") = Ds_Apartado1.Apartado_detalle.Rows(i).Item("SubTotal") + Ds_Apartado1.Apartado_detalle.Rows(i).Item("Monto_Impuesto") - Ds_Apartado1.Apartado_detalle.Rows(i).Item("Monto_Descuento")
                Next

                ToolBarImprimir.Enabled = True
                Dt_Vence.Enabled = False
                DT_actual.Enabled = False
                If CheckBox1.Checked Then
                    ToolBarEliminar.Enabled = False
                    LAnulado.Visible = True
                Else
                    ToolBarEliminar.Enabled = True
                    LAnulado.Visible = False
                End If

                If BindingContext(Ds_Apartado1, "Apartados").Current("Cancelado") Then
                    LCancelado.Visible = True
                Else
                    LCancelado.Visible = False
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Sub Cargarapartado(ByVal codigo As Integer)
        Dim Ven As Date
        Dim cx As New Apartado.cFunciones
        Dim Funciones As New Conexion
        If Ds_Apartado1.Apartados.Rows.Count > -1 Then
            cFunciones.Llenar_Tabla_Generico("Select * from Apartados where Id_Apartado = " & codigo, Ds_Apartado1.Apartados, GetSetting("Seesoft", "SeePos", "Conexion"))
            cFunciones.Llenar_Tabla_Generico("Select * from Apartado_detalle where Id_Apartado=" & codigo & "", Ds_Apartado1.Apartado_detalle, GetSetting("Seesoft", "SeePos", "Conexion"))

            Ven = Format("dd/MM/yyyy", Dt_Vence.Text)
            If BindingContext(Ds_Apartado1, "Apartados").Current("Vence") < Now.Date Then
                MsgBox("Este apartado esta vencido", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "Registrar"

    Function _Buscar_Apertura(ByVal usuario As String) As Boolean
        Try
            Dim conex As New Conexion
            Dim i As Integer
            i = conex.SQLExeScalar("SELECT COUNT(NApertura) FROM AperturaCaja WHERE (Anulado = 0) AND (Estado = 'A') AND (Cedula = '" & usuario & "')")
            Select Case i
                Case 1
                    Return True
                Case 0
                    MsgBox(Usua.Nombre & " " & "No tiene una apertura de caja abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
                Case Else
                    MsgBox(Usua.Nombre & " " & "tiene mas de una abierta, digite la constraseña de la caja", MsgBoxStyle.Exclamation)
                    Return False
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Sub registrar()
        ' If _Buscar_Apertura(Usua.Cedula) Then
        Try
            ToolBar1.Buttons(2).Enabled = False
            If PMU.Update Then  Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            If MessageBox.Show("¿Desea guardar el apartado?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                ToolBar1.Buttons(2).Enabled = True
                Exit Sub
            End If

            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()

            If BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Count = 0 Then 'Si el apartado no tiene detalle
                MsgBox("No se puede Registrar un apartado si no contiene artículos!", MsgBoxStyle.Critical)
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                txtExistencia.EditValue = 0
                ToolBar1.Buttons(2).Enabled = True
                Exit Sub
            End If

            If txtCodigo.Text = "0" Or txtCodigo.Text = "" Then
                MsgBox("No se puede Registrar un apartado si no se ha seleccionado el cliente!", MsgBoxStyle.Critical)
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                txtExistencia.EditValue = 0
                ToolBar1.Buttons(2).Enabled = True
                Exit Sub
            End If

            '===================================================
            'PIDE EL MONTO INICIAL DEL APARTADO - ORA
            '===================================================
            Dim Precio As New Monto_Transporte_Ventas
            Precio.Text = "Establecer Monto de Apartado"
            Precio.GroupBox1.Text = "Digite el Monto de Apartado"
            Precio.ShowDialog()

            If Precio.DialogResult = Windows.Forms.DialogResult.OK Then
                BindingContext(Ds_Apartado1, "Apartados").Current("Monto") = Precio.Monto
            Else
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                txtExistencia.EditValue = 0
                ToolBar1.Buttons(2).Enabled = True
                Precio.Dispose()
                Exit Sub
            End If
            Precio.Dispose()
            '===================================================

            If BindingContext(Ds_Apartado1, "Apartados").Current("Monto") >= BindingContext(Ds_Apartado1, "Apartados").Current("Total") Then
                MsgBox("El monto de Abono sobrepasa el monto de apartado!", MsgBoxStyle.Exclamation, "SeeSoft")
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                txtExistencia.EditValue = 0
                ToolBar1.Buttons(2).Enabled = True
                Precio.Dispose()
                Exit Sub
            End If

            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()


            BindingContext(Ds_Apartado1, "Apartados").Current("Fecha") = Me.DT_actual.Value
            BindingContext(Ds_Apartado1, "Apartados").Current("Vence") = Me.Dt_Vence.Value

            BindingContext(Ds_Apartado1, "Apartados").EndCurrentEdit()

            If Guardar() Then 'se registra en la base de datos then
                If CInt(Precio.Monto) = 0 Then
                    ToolBar1.Buttons(1).Enabled = True
                    ToolBar1.Buttons(0).Text = "Nuevo"
                    ToolBar1.Buttons(0).ImageIndex = 0
                    'open_cashdrawer()
                    'FrmVuelto.ShowDialog()
                    ToolBarRegistrar.Enabled = False
                    ToolBarEliminar.Enabled = False
                    ToolBarImprimir.Enabled = False

                    ImprimirFactura()

                    Ds_Apartado1.Apartado_detalle.Clear()
                    Ds_Apartado1.Apartados.Clear()
                    LAnulado.Visible = False
                    LCancelado.Visible = False
                    Me.Close()

                Else
                    If MovimientoCaja() Then
                        ToolBar1.Buttons(1).Enabled = True
                        ToolBar1.Buttons(0).Text = "Nuevo"
                        ToolBar1.Buttons(0).ImageIndex = 0

                        open_cashdrawer()
                        'FrmVuelto.MontoVuelto = tempvuelto
                        FrmVuelto.ShowDialog()
                        ToolBarRegistrar.Enabled = False
                        ToolBarEliminar.Enabled = False
                        ToolBarImprimir.Enabled = False

                        'For i As Integer = 0 To 1
                        ImprimirFactura()
                        If CInt(Precio.Monto) <> 0 Then
                            imprimir_abono()
                        End If
                        Ds_Apartado1.Apartado_detalle.Clear()
                        Ds_Apartado1.Apartados.Clear()
                        LAnulado.Visible = False
                        LCancelado.Visible = False
                        Me.Close()
                    Else
                        MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                        Me.ToolBar1.Buttons(2).Enabled = True
                    End If

                End If
            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True
            End If

        Catch ex As System.Exception
            ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
        'Else
        'Exit Sub
        'End If


    End Sub
#Region "Abrir Caja"
    Public Sub open_cashdrawer()
        Exit Sub
        Dim Puerto As String

        '------------------------------------------------------------------------------
        'VALIDA SI DESEA ABRIR CAJA O NO - ORA
        If GetSetting("SeeSoft", "SeePos", "PuertoImp") <> "NO" Then
            Dim intFileNo As Integer = FreeFile()
            FileOpen(1, "c:\escapes.txt", OpenMode.Output)
            PrintLine(1, Chr(27) & "p" & Chr(0) & Chr(25) & Chr(250))
            FileClose(1)

            '------------------------------------------------------------------------------
            'VALIDA EL PUERTO DE LA IMPRESORA - ORA
            Try
                Puerto = GetSetting("SeeSoft", "SeePos", "PuertoImp")
                If Puerto = "" Then
                    SaveSetting("SeeSoft", "SeePos", "PuertoImp", "COM1")
                    Puerto = "COM1"
                End If
            Catch ex As Exception
                SaveSetting("SeeSoft", "SeePos", "PuertoImp", "COM1")
                Puerto = "COM1"
            End Try
            '------------------------------------------------------------------------------

            Shell("print /d:" & Puerto & " c:\escapes.txt", AppWinStyle.NormalFocus)
        End If
        '------------------------------------------------------------------------------
    End Sub
#End Region
    Function MovimientoCaja() As Boolean
        Try
            'llamar al formulario de opciones de pago
            Dim Movimiento_Pago_Abonos As New frmMovimientoCajaPagoAbono(Usua)
            Movimiento_Pago_Abonos.Factura = Numero_de_Recibo()
            Movimiento_Pago_Abonos.fecha = Now
            Movimiento_Pago_Abonos.Total = CDbl(BindingContext(Ds_Apartado1, "Apartados").Current("Monto"))
            Movimiento_Pago_Abonos.Tipo = "ABA"
            Movimiento_Pago_Abonos.codmod = BindingContext(Ds_Apartado1, "Apartados").Current("Cod_Moneda")
            Movimiento_Pago_Abonos.ShowDialog()
            FrmVuelto.MontoVuelto = Movimiento_Pago_Abonos.vuelto

            If Movimiento_Pago_Abonos.Registra Then
                If Movimiento_Pago_Abonos.RegistrarOpcionesPago() Then
                    Return True
                Else
                    MsgBox("Problemas al registrar el abono y/o pagos, intentelo de nuevo! ", MsgBoxStyle.Critical)
                    Movimiento_Pago_Abonos.Trans.Rollback()
                    Return False
                End If
            Else
                MovimientoCaja()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Function Numero_de_Recibo() As Double
        Dim cConexion As New Conexion
        Dim Num_Recibo As Double = 0
        Try
            Num_Recibo = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT ISNULL(Max(Num_Recibo),0) FROM Abono_Apartados"))
            Return Num_Recibo
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cConexion.DesConectar(cConexion.Conectar)
        End Try
        Return Num_Recibo

    End Function
    'Sub registrar()
    '    Try
    '        ToolBar1.Buttons(2).Enabled = False
    '        If PMU.Update Then  Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

    '        If MessageBox.Show("¿Desea guardar  el apartado?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
    '            ToolBar1.Buttons(2).Enabled = True
    '            Exit Sub
    '        End If

    '        BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()

    '        If BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Count = 0 Then 'Si el apartado no tiene detalle
    '            MsgBox("No se puede Registrar un apartado si no contiene artículos!", MsgBoxStyle.Critical)
    '            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
    '            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
    '            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
    '            txtExistencia.EditValue = 0
    '            ToolBar1.Buttons(2).Enabled = True
    '            Exit Sub
    '        End If

    '        If txtCodigo.Text = "0" Or txtCodigo.Text = "" Then
    '            MsgBox("No se puede Registrar un apartado si no se ha seleccionado el cliente!", MsgBoxStyle.Critical)
    '            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
    '            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
    '            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
    '            txtExistencia.EditValue = 0
    '            ToolBar1.Buttons(2).Enabled = True
    '            Exit Sub
    '        End If

    '        BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
    '        BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
    '        BindingContext(Ds_Apartado1, "Apartados").EndCurrentEdit()

    '        If Guardar() Then 'se registra en la base de datos then
    '            ToolBar1.Buttons(1).Enabled = True
    '            ToolBar1.Buttons(0).Text = "Nuevo"
    '            ToolBar1.Buttons(0).ImageIndex = 0

    '            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
    '            ToolBarRegistrar.Enabled = False
    '            ToolBarEliminar.Enabled = False
    '            ToolBarImprimir.Enabled = False
    '            ImprimirFactura()
    '            Dim abono As New Abono_Apartados
    '            abono.valoresdefecto()
    '            abono.Nuevo_abono()
    '            abono.txtCodigo.Text = Me.txtCodigo.Text
    '            abono.tipo = txtTipoCambio.Text
    '            abono.load2()
    '            abono.CargarInformacionCliente(CInt(abono.txtCodigo.Text))
    '            abono.codigoclie = CInt(txtCodigo.Text)
    '            abono.nombrecli = txtNombre.Text
    '            abono.primerabono = True
    '            abono.general = CDbl(abono.txtSaldoAntGen.Text)
    '            abono.usua = Me.Usua
    '            abono.ShowDialog()

    '            Ds_Apartado1.Apartado_detalle.Clear()
    '            Ds_Apartado1.Apartados.Clear()
    '            LAnulado.Visible = False
    '            LCancelado.Visible = False
    '            Me.Close()
    '        Else
    '            MsgBox("Error al Registrar", MsgBoxStyle.Critical)
    '            Me.ToolBar1.Buttons(2).Enabled = True
    '        End If

    '    Catch ex As System.Exception
    '        ToolBar1.Buttons(2).Enabled = True
    '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
    '    End Try
    'End Sub
    Function Guardar() As Boolean
        If SqlConnection1.State <> ConnectionState.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Try
            SqlInsertCommand1.CommandText = "INSERT INTO [Apartados] ([Id_Cliente], [Nombrecliente], [Cedulausuario], [SubTotal], [Imp_Venta], [Total], [Fecha], [Vence], [Anulado], [Cancelado], [SubTotalGravada], [SubTotalExento], [Observaciones], [Descuento], [Tipo_Cambio], [Cod_Moneda], [Monto]) VALUES (@Id_Cliente, @Nombrecliente, @Cedulausuario, @SubTotal, @Imp_Venta, @Total, @Fecha, @Vence, @Anulado, @Cancelado, @SubTotalGravada, @SubTotalExento, @Observaciones, @Descuento, @Tipo_Cambio, @Cod_Moneda, @Monto);" & _
                                    "SELECT Id_Apartado, Id_Cliente, Nombrecliente, Cedulausuario, SubTotal, Imp_Venta, Total, Fecha, Vence, Anulado, Cancelado, SubTotalGravada, SubTotalExento, Observaciones, Descuento, Tipo_Cambio, Cod_Moneda, Monto FROM Apartados WHERE (Id_Apartado = SCOPE_IDENTITY())"
            Ad_Apartados.InsertCommand.Transaction = Trans
            Ad_Apartados.SelectCommand.Transaction = Trans
            Ad_Apartados.DeleteCommand.Transaction = Trans
            Ad_Apartados.UpdateCommand.Transaction = Trans

            SqlInsertCommand2.CommandText = "INSERT INTO [Apartado_detalle] ([Id_Apartado], [Codigo], [Descripcion], [Cantidad], [Precio_Costo], [Precio_Base], [Precio_Flete], [Precio_Otros], [Precio_Unit], [Impuesto], [Monto_Impuesto], [SubtotalGravado], [SubTotalExcento], [SubTotal], [Monto_descuento], [Descuento], [Tipo_Cambio_ValorCompra], [Cod_MonedaVenta], [Max_Descuento], [cod_articulo]) VALUES (@Id_Apartado, @Codigo, @Descripcion, @Cantidad, @Precio_Costo, @Precio_Base, @Precio_Flete, @Precio_Otros, @Precio_Unit, @Impuesto, @Monto_Impuesto, @SubtotalGravado, @SubTotalExcento, @SubTotal, @Monto_descuento, @Descuento, @Tipo_Cambio_ValorCompra, @Cod_MonedaVenta, @Max_Descuento, @cod_articulo);" & _
                                    "SELECT Id_detalle, Id_Apartado, Codigo, Descripcion, Cantidad, Precio_Costo, Precio_Base, Precio_Flete, Precio_Otros, Precio_Unit, Impuesto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, Monto_descuento, Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, Max_Descuento FROM Apartado_detalle WHERE (Id_detalle = SCOPE_IDENTITY())"

            ad_detalleapartado.SelectCommand.Transaction = Trans
            ad_detalleapartado.InsertCommand.Transaction = Trans
            ad_detalleapartado.DeleteCommand.Transaction = Trans
            ad_detalleapartado.UpdateCommand.Transaction = Trans

            Ad_Apartados.Update(Ds_Apartado1, "Apartados")
            ad_detalleapartado.Update(Ds_Apartado1, "Apartado_detalle")
            Trans.Commit()
            Ds_Apartado1.AcceptChanges()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message & vbCrLf & "Posible Causa un error de Red")
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

    'Function Guardar() As Boolean
    '    If SqlConnection1.State <> ConnectionState.Open Then SqlConnection1.Open()
    '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
    '    Try
    '        SqlInsertCommand1.CommandText = "INSERT INTO [Apartados] ([Id_Cliente], [Nombrecliente], [Cedulausuario], [SubTotal], [Imp_Venta], [Total], [Fecha], [Vence], [Anulado], [Cancelado], [SubTotalGravada], [SubTotalExento], [Observaciones], [Descuento], [Tipo_Cambio], [Cod_Moneda]) VALUES (@Id_Cliente, @Nombrecliente, @Cedulausuario, @SubTotal, @Imp_Venta, @Total, @Fecha, @Vence, @Anulado, @Cancelado, @SubTotalGravada, @SubTotalExento, @Observaciones, @Descuento, @Tipo_Cambio, @Cod_Moneda);" & _
    '                                "SELECT Id_Apartado, Id_Cliente, Nombrecliente, Cedulausuario, SubTotal, Imp_Venta, Total, Fecha, Vence, Anulado, Cancelado, SubTotalGravada, SubTotalExento, Observaciones, Descuento, Tipo_Cambio, Cod_Moneda FROM Apartados WHERE (Id_Apartado = SCOPE_IDENTITY())"
    '        Ad_Apartados.InsertCommand.Transaction = Trans
    '        Ad_Apartados.SelectCommand.Transaction = Trans
    '        Ad_Apartados.DeleteCommand.Transaction = Trans
    '        Ad_Apartados.UpdateCommand.Transaction = Trans

    '        SqlInsertCommand2.CommandText = "INSERT INTO [Apartado_detalle] ([Id_Apartado], [Codigo], [Descripcion], [Cantidad], [Precio_Costo], [Precio_Base], [Precio_Flete], [Precio_Otros], [Precio_Unit], [Impuesto], [Monto_Impuesto], [SubtotalGravado], [SubTotalExcento], [SubTotal], [Monto_descuento], [Descuento], [Tipo_Cambio_ValorCompra], [Cod_MonedaVenta], [IdBodega], [Max_Descuento]) VALUES (@Id_Apartado, @Codigo, @Descripcion, @Cantidad, @Precio_Costo, @Precio_Base, @Precio_Flete, @Precio_Otros, @Precio_Unit, @Impuesto, @Monto_Impuesto, @SubtotalGravado, @SubTotalExcento, @SubTotal, @Monto_descuento, @Descuento, @Tipo_Cambio_ValorCompra, @Cod_MonedaVenta, @IdBodega, @Max_Descuento);" & _
    '                                "SELECT Id_detalle, Id_Apartado, Codigo, Descripcion, Cantidad, Precio_Costo, Precio_Base, Precio_Flete, Precio_Otros, Precio_Unit, Impuesto, Monto_Impuesto, SubtotalGravado, SubTotalExcento, SubTotal, Monto_descuento, Descuento, Tipo_Cambio_ValorCompra, Cod_MonedaVenta, IdBodega, Max_Descuento FROM Apartado_detalle WHERE (Id_detalle = SCOPE_IDENTITY())"

    '        ad_detalleapartado.SelectCommand.Transaction = Trans
    '        ad_detalleapartado.InsertCommand.Transaction = Trans
    '        ad_detalleapartado.DeleteCommand.Transaction = Trans
    '        ad_detalleapartado.UpdateCommand.Transaction = Trans

    '        Ad_Apartados.Update(Ds_Apartado1, "Apartados")
    '        ad_detalleapartado.Update(Ds_Apartado1, "Apartado_detalle")
    '        Trans.Commit()
    '        Ds_Apartado1.AcceptChanges()
    '        Return True

    '    Catch ex As Exception
    '        Trans.Rollback()
    '        MsgBox(ex.Message & vbCrLf & "Posible Causa un error de Red")
    '        Me.ToolBar1.Buttons(2).Enabled = True
    '        Return False
    '    End Try
    'End Function
#End Region

#Region "Anular"
    Private Sub Anular()
        Try
            If PMU.Delete = False Then
                MsgBox("Usted no tiene permisos de anular apartados!", MsgBoxStyle.Information)
                Exit Sub
            End If

            If BindingContext(Ds_Apartado1, "Apartados").Current("Cancelado") Then
                MsgBox("No se puede anular el apartado porque ya fue cancelado!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim resp As Integer
            If Me.BindingContext(Ds_Apartado1, "Apartados").Count > 0 Then
                resp = MessageBox.Show("¿Desea Anular este apartado?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    CheckBox1.Checked = True
                    BindingContext(Ds_Apartado1, "Apartados").EndCurrentEdit()

                    If Me.insertar_bitacora() And Registrar_Anulacion_Apartado() Then
                        Ds_Apartado1.AcceptChanges()
                        MsgBox("El apartado ha sido anulado correctamente!", MsgBoxStyle.Information)
                        Me.Ds_Apartado1.Apartado_detalle.Clear()
                        Me.Ds_Apartado1.Apartados.Clear()
                        txtTotalArt.Text = 0
                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True
                        Me.SimpleButton1.Enabled = False
                        LAnulado.Visible = False
                        LCancelado.Visible = False

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                        Me.GroupBox3.Enabled = False
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False
                    End If
                Else
                    MsgBox("Error al Anular!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function insertar_bitacora() As Boolean
        Dim funciones As New Conexion
        Dim datos As String
        datos = "'APARTADOS','" & Me.lbconsecutivo.Text & "','" & Me.txtNombre.Text & "','APARTADO ANULADO','" & Usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
        If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" Then
            MsgBox("Problemas al Anular el apartado!", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function Registrar_Anulacion_Apartado() As Boolean
        If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            'SqlUpdateCommand1.CommandText = "UPDATE [Apartados] SET [Id_Cliente] = @Id_Cliente, [Nombrecliente] = @Nombrecliente, [Cedulausuario] = @Cedulausuario, [SubTotal] = @SubTotal, [Imp_Venta] = @Imp_Venta, [Total] = @Total, [Fecha] = @Fecha, [Vence] = @Vence, [Anulado] = @Anulado, [Cancelado] = @Cancelado, [SubTotalGravada] = @SubTotalGravada, [SubTotalExento] = @SubTotalExento, [Observaciones] = @Observaciones, [Descuento] = @Descuento, [Tipo_Cambio] = @Tipo_Cambio, [Cod_Moneda] = @Cod_Moneda WHERE (([Id_Apartado] = @Id_Apartado) AND ([Id_Cliente] = @Id_Cliente) AND ([Nombrecliente] = @Nombrecliente) AND ([Cedulausuario] = @Cedulausuario) AND ([SubTotal] = @SubTotal) AND ([Imp_Venta] = @Imp_Venta) AND ([Total] = @Total) AND ([Fecha] = @Fecha) AND ([Vence] = @Vence) AND ([Anulado] = @Anulado) AND ([Cancelado] = Cancelado) AND ([SubTotalGravada] = @SubTotalGravada) AND ([SubTotalExento] = @SubTotalExento) AND ([Observaciones] = @Observaciones) AND ([Descuento] = @Descuento) AND ([Tipo_Cambio] = @Tipo_Cambio) AND ([Cod_Moneda] = @Cod_Moneda));" & _
            '                "SELECT Id_Apartado, Id_Cliente, Nombrecliente, Cedulausuario, SubTotal, Imp_Venta, Total, Fecha, Vence, Anulado, Cancelado, SubTotalGravada, SubTotalExento, Observaciones, Descuento, Tipo_Cambio, Cod_Moneda FROM Apartados WHERE (Id_Apartado = @Id_Apartado)"
            Me.SqlUpdateCommand1.Transaction = Trans

            Me.Ad_Apartados.Update(Me.Ds_Apartado1, "Apartados")

            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(3).Enabled = True
            Return False
        End Try
    End Function
#End Region

#Region "Calculos sobre articulo"
    Private Sub Calculos_Articulo()
        Try
            calculo_descuento_articulo()
            Me.txtImpVenta.Text = Math.Round(Me.impuesto_cliente * CDbl(Me.txtImpVenta.Text) / 100, 2)
            If txtImpVenta.Text <> 0 Then 'si tiene impuesto de venta
                If (CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) > CDbl(txtPrecioUnit.Text) Then
                    txtFlete.Text = 0
                    txtOtros.Text = 0
                End If
                Gravado = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
                Gravado = Math.Round(((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)), 2)
                txtMontoImpuesto.Text = Math.Round((Gravado - CDbl(Me.txtmontodescuento.Text)) * (CDbl(txtImpVenta.Text) / 100), 2)
                txtSGravado.Text = Gravado
                Exento = 0

            Else 'si no tiene impuesto de venta
                'Exento = ((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)) - CDbl(Me.txtmontodescuento.Text)
                Exento = Math.Round(((CDbl(txtPrecioUnit.Text) - CDbl(txtFlete.Text) - CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)), 2)
                Gravado = 0
                txtMontoImpuesto.Text = 0
                txtSGravado.Text = 0
                txtSExcento.Text = Exento
            End If

            Exento = Math.Round(Exento + ((CDbl(txtFlete.Text) + CDbl(txtOtros.Text)) * CDbl(txtCantidad.Text)), 2)
            txtSExcento.Text = Exento
            txtSubtotal.Text = Math.Round(CDbl(txtSGravado.Text) + CDbl(txtSExcento.Text), 2)
            Me.Text_Ficticio.Text = Math.Round(CDbl(txtSubtotal.Text) + CDbl(txtMontoImpuesto.Text) - CDbl(Me.txtmontodescuento.Text), 0)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "Calculo de descuento"
    Private Sub calculo_descuento_articulo()
        Try
            If CDbl(Me.txtDescuento.Text) > 0 Then 'si el articulo tiene un descuento

                '''''''''''''''''''''''''''''PROMO'''''''''''''''''''''' ACTIVA''''''''''''''''''''''''''''''''''''''''''
                If Me.promo_activa_valor Then 'si el articulo esta en promocion 
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo está en promoción" + vbCrLf
                    Exit Sub
                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                'SI EL ARTICULO NO PERMITE DESCUENTO
                If CDbl(TxtMaxdescuento.Text) = 0 Then
                    'Si el articulo  no permite que se le realize un descuento
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + ") El artículo no permite descuento" + vbCrLf
                    Exit Sub
                End If


                'SI EL USUARIO NO PUEDE DAR DESCUENTO

                If Me.porcentaje_descuento = 0 Then
                    MsgBox("Usted no puede realizar descuentos", MsgBoxStyle.Critical)
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    Exit Sub
                End If


                ' validar si el descuento se puede aplicar o no el descuento

                ''''''''''''''''''''''''''''''''''''''''''''''''''''
                max_aplicar = CDbl(Me.TxtMaxdescuento.Text) * Me.porcentaje_descuento / 100



                'SI EL DESCUENTO DESEADO ES TOTALMENTE APLICABLE AL ARTICULO
                If CDbl(Me.txtDescuento.Text) <= max_aplicar Then
                    'si el descuento que se desea aplicar, el usuario lo puede aplicar
                    'es aplicable al cliente
                    'se asigna el maximo porcentaje que el usuaio puede dar
                    If perdiendo() Then
                        Exit Sub
                    End If

                    If Me.descuento = 0 Then ' si el cliente no tiene predefinido un descuento
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        Exit Sub
                    End If

                    If Me.descuento <> 0 And Me.txtDescuento.Text <= descuento Then
                        'si el Cliente tiene un descuento predefinido, y lo que se desea aplicar es <= que lo permitido por el cliente
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        Exit Sub
                    End If

                End If


                'SI NO LO PUEDE APLICAR EL USUARIO, PERO SI EL CLIENTE
                If CDbl(Me.txtDescuento.Text) > max_aplicar Then
                    'si el descuento que se desea aplicar
                    'es mayor que el que el usuario puede aplicar

                    If perdiendo() Then
                        Exit Sub
                    End If

                    If descuento = 0 Then ' si el cliente no tiene predefinido un descuento
                        Me.txtDescuento.Text = max_aplicar
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Máximo permitido por el usuario" + vbCrLf
                        Exit Sub
                    End If

                    If Me.descuento <> 0 And Me.txtDescuento.Text <= descuento Then
                        Me.txtDescuento.Text = descuento 'aplico el descuento del cliente
                        DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                        Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                        mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Máximo permitido para el cliente" + vbCrLf
                        Exit Sub
                    End If

                End If

            Else 'si el campo de descuento esta en cero
                DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function perdiendo() As Boolean
        Try
            Dim pre_unit As Double
            pre_unit = CDbl(Me.txtPrecioUnit.Text) - CDbl(Me.txtPrecioUnit.Text) * CDbl(Me.txtDescuento.Text) / 100
            If pre_unit < CDbl(Me.TxtprecioCosto.Text) Then
                Me.monto_Perdido = CDbl(Me.TxtprecioCosto.Text) - pre_unit
                'Me.perfil_administrador
                If (PMU.Others) Then  'si es un administrador, quien está haciedo la facturacion
                    DescuentoCalc = (CDbl(txtPrecioUnit.Text) * CDbl(txtCantidad.Text)) * (CDbl(txtDescuento.Text) / 100)
                    Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Con esta venta se está perdiendo " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf
                Else
                    Me.txtDescuento.Text = 0.0
                    DescuentoCalc = 0
                    Me.txtmontodescuento.Text = DescuentoCalc ' p one el monto de descuento
                    mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Se Aplicó un: (" + Me.txtDescuento.Text + " %) Usted no puede vender perdiendo, +con esta venta se estaria perdiendo " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf
                End If
                Return True
            Else
                Return False

            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Function


#End Region


#End Region

#Region "Controles"
    Sub habilitar()
        GroupBox6.Enabled = True
        GridControl1.Enabled = True
        GroupBox3.Enabled = True
        GroupBox1.Enabled = True
        DT_actual.Enabled = False
        Dt_Vence.Enabled = True
    End Sub

    Sub inhabilitar()
        Dt_Vence.Enabled = False
        GroupBox6.Enabled = False
        GridControl1.Enabled = False
        GroupBox3.Enabled = False
        GroupBox1.Enabled = False
    End Sub
#End Region

#Region "Controles Funciones"
    Private Sub TxtCodArticulo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodArticulo.GotFocus
        'txtCodigo.SelectAll()
    End Sub

    Private Function BuscarF1() As String
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2

        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()

        If BuscarArt.Cancelado Then
            Codigo = BuscarArt.Codigo
            Exit Function
        End If

        Codigo = BuscarArt.Codigo
        BuscarArt.Close()
        BuscarArt.Dispose()
        BuscarArt = Nothing
        Return Codigo

    End Function
    Private Sub TxtCodArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodArticulo.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Try

                    Dim CodigoBuscador As String = BuscarF1()
                    If Not IsNothing(CodigoBuscador) And CodigoBuscador <> "0" And CodigoBuscador <> "0.00" Then
                        CargarInformacionArticulo(CodigoBuscador)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                End Try

            Case Keys.Enter
                buscararticulo()
            Case Keys.F2
                Me.registrar()
            Case Keys.F3
                Buscar_Apartado()

            Case Keys.F6
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                GridControl1.Focus()

            Case Keys.F9
                txtCodigo.Focus()

            Case Keys.F11
                abonos()

            Case Keys.Escape
                If MessageBox.Show("¿Desea cancelar este apartado?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If MessageBox.Show("¿Desea cancelar este apartado?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Me.BindingContext(Me.Ds_Apartado1, "Apartados").CancelCurrentEdit()
                        Me.SimpleButton1.Enabled = False
                        Ds_Apartado1.Apartado_detalle.Clear()
                        Ds_Apartado1.Apartados.Clear()
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = True
                        Me.GroupBox3.Enabled = False
                        Me.dtFecha.Enabled = False
                        Me.logeado = False
                        Me.SimpleButton3.Enabled = False
                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtUsuario.Focus()
                        Me.Loggin_Usuario()
                    End If
                End If

            Case Keys.Insert
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                'GridControl1.Enabled = False
                txtExistencia.EditValue = 0

            Case Keys.Multiply
                Me.BindingContext(Me.Ds_Apartado1, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Ventas.VentasVentas_Detalle").AddNew()
                txtExistencia.EditValue = 0
                'GridControl1.Enabled = False
                Me.Cambio_Cantidad = True
                txt_articulo.EditValue = ""
                txt_articulo.Text = ""
                Me.txtCantidad.Focus()

        End Select
    End Sub

    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If Me.txtNombreArt.Text = "" Then ' si aun no se ha agregado el articulo
                    Me.txt_articulo.Text = ""
                    Me.txt_articulo.Focus()
                Else
                    meter_al_detalle()
                    Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                    Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                    Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                    'GridControl1.Enabled = False
                    txtExistencia.EditValue = 0
                    txt_articulo.Focus()
                End If

            Case Keys.F2
                Me.registrar()

            Case Keys.F3
                Buscar_Apartado()

            Case Keys.F6
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.GridControl1.Enabled = True
                GridControl1.Focus()

            Case Keys.F9
                txtCodigo.Focus()

            Case Keys.F11
                abonos()

            Case Keys.Escape
                If MessageBox.Show("¿Desea cancelar esta factura?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If MessageBox.Show("¿Desea cancelar esta factura?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Me.BindingContext(Me.Ds_Apartado1, "Apartados").CancelCurrentEdit()
                        Me.SimpleButton1.Enabled = False
                        Ds_Apartado1.Apartado_detalle.Clear()
                        Ds_Apartado1.Apartados.Clear()
                        ToolBar1.Buttons(0).Text = "Nuevo"
                        ToolBar1.Buttons(0).ImageIndex = 0
                        ToolBar1.Buttons(3).Enabled = True
                        Me.GroupBox3.Enabled = False
                        Me.dtFecha.Enabled = False
                        Me.logeado = False
                        Me.SimpleButton3.Enabled = False
                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtUsuario.Focus()
                        Me.Loggin_Usuario()
                    End If
                End If

            Case Keys.Insert
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                txtExistencia.EditValue = 0
                'GridControl1.Enabled = False
                txt_articulo.Focus()
        End Select
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not logeado Then ' si es la primera vez que se logea un usuario
                Loggin_Usuario()
            Else
                'Me.Reloggin_Usuario()
            End If
        End If
    End Sub

    Private Sub txtDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescuento.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If Me.txtDescuento.Text = "" Then
                        MsgBox("No puede estar vacío", MsgBoxStyle.Exclamation)
                        Me.txtDescuento.Text = "0"
                        Exit Sub
                    Else
                        If (CDbl(Me.txtDescuento.Text) > 100) Then Me.txtDescuento.Text = 100
                    End If

                    Me.Calculos_Articulo()
                    If mensaje <> "" Then
                        MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                        mensaje = ""
                    End If

                    If Not IsDBNull(Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Current("Descripcion")) Then
                        Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                        Calcular_totales()
                    End If
                    Me.txtCantidad.Focus()

            End Select
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()

            If Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Count = 0 Then
                MsgBox("No se puede aplicar descuento, aún no hay artículos", MsgBoxStyle.Critical)
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                txt_articulo.Focus()
                Exit Sub
            End If

            Dim maximo_descuento As Double = Me.porcentaje_descuento
            Dim ajustar_descuento_general_objero As New Ajuste_Descuento_Factura(maximo_descuento, Me.descuento)
            ajustar_descuento_general_objero.ShowDialog()

            If ajustar_descuento_general_objero.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim nuevo_descuento As Double = ajustar_descuento_general_objero.nuevo_porc_descuento
                If nuevo_descuento < 0 Then txt_articulo.Focus() : Exit Sub ' si se digito 0 en el descuento 

                BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.GridControl1.Enabled = True
                GridControl1.Focus()

                recalcular_cotizacion(nuevo_descuento)
                Me.Calcular_totales()

                If mensaje <> "" Then
                    MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                    mensaje = ""
                End If
            End If

            Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
            txt_articulo.Focus()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseClick
        BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        If MessageBox.Show("¿Desea Cerrar el módulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Dispose(True) : Me.Close()
    End Sub

#Region "Focus"
    Private Sub DT_actual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DT_actual.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dt_Vence.Focus()
        End Select

    End Sub

    Private Sub Dt_Vence_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dt_Vence.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txt_articulo.Focus()
        End Select

    End Sub
#End Region

#End Region

#Region "Calcular Totales cotizacion"
    Private Sub Calcular_Totales_Cotizacion() ' calcula el monto Total de la cotización
        Try
            txtSubtotalT.Properties.DisplayFormat.FormatString = Me.Label31.Text & " #,#0.00"
            Lb_Subgravado.Properties.DisplayFormat.FormatString = Me.Label31.Text & " #,#0.00"
            Lb_SubExento.Properties.DisplayFormat.FormatString = Me.Label31.Text & " #,#0.00"
            txtDescuentoT.Properties.DisplayFormat.FormatString = Me.Label31.Text & " #,#0.00"
            txtImpVentaT.Properties.DisplayFormat.FormatString = Me.Label31.Text & " #,#0.00"
            TxtTotal.Properties.DisplayFormat.FormatString = Me.Label31.Text & " #,#0.00"

            txtSubtotalT.Text = Math.Round(colSubTotal.SummaryItem.SummaryValue, 2)
            Lb_Subgravado.Text = Math.Round(Me.colSubtotalGravado.SummaryItem.SummaryValue, 2)
            Lb_SubExento.Text = Math.Round(Me.colSubTotalExcento.SummaryItem.SummaryValue, 2)
            txtDescuentoT.Text = Math.Round(Me.colMonto_Descuento.SummaryItem.SummaryValue, 2)
            txtImpVentaT.Text = Math.Round(Me.colMonto_Impuesto.SummaryItem.SummaryValue, 2)
            TxtTotal.Text = Math.Round(CDbl(txtSubtotalT.Text) - CDbl(Me.txtDescuentoT.Text) + CDbl(Me.txtImpVentaT.Text) + CDbl(Me.Label46.Text), 0)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
    Sub buscarinterno()
        Dim dts As New DataTable
        Apartado.cFunciones.Llenar_Tabla_Generico("select codigo from inventario where cod_articulo = '" & txt_articulo.Text & "'", dts, GetSetting("SeeSoft", "SeePOS", "Conexion"))
        If dts.Rows.Count > 0 Then
            TxtCodArticulo.Text = dts.Rows(0).Item("codigo")
        End If
    End Sub
#Region "Buscar articulo"
    Sub buscararticulo()
        Try
            If Me.txt_articulo.Text = "" Then
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                txtExistencia.EditValue = 0
                GridControl1.Enabled = False
                'Me.Cambio_Cantidad = True
                'Me.txtCantidad.Focus()
                Exit Sub
            End If

            buscarinterno()

            Dim cod_art As String
            Dim cant As Double
            cod_art = Me.TxtCodArticulo.Text
            cant = CDbl(Me.txtCantidad.Text)
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
            txtExistencia.EditValue = 0
            'GridControl1.Enabled = False
            If Cambio_Cantidad Then Me.txtCantidad.Text = cant
            Dim sB As String = GetSetting("SeeSoft", "SeePOS", "SoloBarras")
            If sB.Equals("1") Then
                Dim dt As New DataTable
                Apartado.cFunciones.Llenar_Tabla_Generico("Select codigo From Inventario Where codigo = '" & cod_art & "'", dt)
                If dt.Rows.Count > 0 Then
                    cod_art = dt.Rows(0).Item(0)
                End If
            End If
            If CargarInformacionArticulo(cod_art) Then
                If txt_articulo.Text = "" Then Exit Sub
                If txtCantidad.Text = "" Then Exit Sub

                If Me.txtPrecioUnit.EditValue = 0 Then
                    txtPrecioUnit.Enabled = True
                    txtPrecioUnit.Visible = True
                    txtPrecioUnit.Focus()
                    Exit Sub
                End If

                meter_al_detalle()

                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                ' GridControl1.Enabled = False
                txtExistencia.EditValue = 0
            Else
                txtExistencia.EditValue = 0
                If Me.txtCantidad.Text = "" Then Me.txtCantidad.Text = "1"
                Me.txt_articulo.Focus()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "Buscar Saldo cliente"
    Function BuscaSaldoCliente(ByVal Codigo As Double) As Double
        Dim ConexionLocal As New Conexion
        Dim rs As SqlDataReader
        Dim id_Factura As Long
        Dim num_Fac, monto_Fact, TCambio As Double
        Dim Monto As Double = 0
        Try
            rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT id, Num_Factura, Total, Tipo_Cambio from Ventas where Tipo = 'CRE' and FacturaCancelado = 0 and Anulado = 0 and Cod_Cliente =" & Codigo)

            While rs.Read
                id_Factura = rs("Id")
                num_Fac = rs("Num_Factura")
                monto_Fact = rs("Total")
                TCambio = rs("Tipo_Cambio")
                ' Monto += (num_Fac, monto_Fact, TCambio, id_Factura)
            End While

            Return Monto

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        Finally
            If rs.IsClosed = False Then rs.Close()
            ConexionLocal.DesConectar(ConexionLocal.sQlconexion)
        End Try
    End Function

    Public Function Saldo_Facturas(ByVal FacturaNo As Long, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal id As Long) As Double
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim MontoAbonos As Double
        Dim MontoNCredito As Double
        Dim MontoNDebito As Double
        Dim Saldo_de_Factura As Double

        Try
            sqlConexion = cConexion.Conectar

            'Cálcula los Abonos
            MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "select  ISNULL(SUM(detalle_abonoccobrar.Abono_SuMoneda),0) AS TotalAbono FROM detalle_abonoccobrar INNER JOIN  abonoccobrar ON detalle_abonoccobrar.Id_Recibo = abonoccobrar.Id_Recibo WHERE (detalle_abonoccobrar.Tipo = 'CRE') AND Factura =" & FacturaNo & " AND abonoccobrar.Anula = 0")

            'NOTAS DE CREDITO
            MontoNCredito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  ISNULL(SUM(detalle_ajustesccobrar.Ajuste),0) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE (detalle_ajustesccobrar.Tipo = 'CRE') AND Factura =" & FacturaNo & " AND (detalle_ajustesccobrar.Tipo = 'CRE')")

            'NOTAS DE DEBITO
            MontoNDebito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  ISNULL(SUM(detalle_ajustesccobrar.Ajuste),0) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE (detalle_ajustesccobrar.Tipo = 'CRE') AND Factura =" & FacturaNo & " AND (detalle_ajustesccobrar.Tipo = 'DEB')")
            'Obtener el saldo final de la factura
            Saldo_de_Factura = MontoFactura + ((MontoNDebito - MontoNCredito - MontoAbonos) * TipoCambFact)
            'Saldo_de_Factura = ((MontoFactura - MontoDevoluciones) + InteresCob + MontoNDebito) - (MontoNCredito + MontoAbonos)
            cConexion.DesConectar(sqlConexion)

            Return Saldo_de_Factura

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

#End Region

#Region "Imprimir"
    Private Function _Id_abonoapartado() As Integer
        Dim cConexion As New Conexion
        Dim id As Integer
        Try
            id = CDbl(cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT MAX(Id_abonoapartado) FROM Abono_Apartados"))
            Return id
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cConexion.DesConectar(cConexion.Conectar)
        End Try
    End Function

    Sub imprimir_abono()

        Dim reporteabo As New AbonoApartado
        reporteabo.PrintOptions.PrinterName = Automatic_Printer_Dialog(3) 'FACTURACION
        reporteabo.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        reporteabo.SetParameterValue(0, _Id_abonoapartado)
        CrystalReportsConexion.LoadReportViewer(Nothing, reporteabo, True)
        reporteabo.PrintToPrinter(1, True, 0, 0)
    End Sub
    Private Sub ImprimirFactura()
        Try
            Dim id As Long = Me.BindingContext(Ds_Apartado1, "Apartados").Current("Id_Apartado") ' se envia  aimprimir la factura actual
            ToolBar1.Buttons(4).Enabled = False
            Me.Imprimir(id)

        Catch ex As SystemException
            MsgBox(ex.Message)
        Finally
            ToolBar1.Buttons(4).Enabled = True
        End Try
    End Sub

    Private Sub Imprimir(ByVal Id_Factura As Double)
        Try
            reporte.PrintOptions.PrinterName = Automatic_Printer_Dialog(3) 'FACTURACION
            reporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
            reporte.SetParameterValue(0, Id_Factura)
            reporte.PrintToPrinter(1, True, 0, 0)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters
            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION"
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
            End Select
        Next
        If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
            Dim PrinterDialog As New PrintDialog
            Dim DocPrint As New PrintDocument
            PrinterDialog.Document = DocPrint
            PrinterDialog.ShowDialog()
            If Windows.Forms.DialogResult.Yes Then
                Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
            Else
                Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
            End If
        End If
    End Function
#End Region



    Private Function InformacionArticulo(ByVal codigo As String) As SqlDataReader
        Dim ConexionX As New Conexion
        Dim RS As SqlDataReader

        Try
            'If Not IsNumeric(codigo) Then
            '    RS = CConexion.GetRecorset(sqlConexion, "SELECT Inventario.Max_Descuento, Inventario.Precio_Promo, Inventario.Promo_Activa, Inventario.Codigo, Inventario.Barras, Inventario.Descripcion, Inventario.SubFamilia, ArticulosXBodega.Existencia, Inventario.PrecioBase, Inventario.Fletes, Inventario.OtrosCargos, Inventario.Costo, Inventario.MonedaCosto, Inventario.MonedaVenta, Inventario.Precio_A, Inventario.Precio_B, Inventario.Precio_C, Inventario.Precio_D, Inventario.IVenta, Inventario.PreguntaPrecio, Inventario.Servicio, Familia.Comision, Familia.SobrePrecio FROM Inventario INNER JOIN  Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion INNER JOIN SubFamilias ON Inventario.SubFamilia = SubFamilias.Codigo INNER JOIN  Familia ON SubFamilias.CodigoFamilia = Familia.Codigo INNER JOIN  ArticulosXBodega ON Inventario.Codigo = ArticulosXBodega.Codigo WHERE (Inhabilitado = 0) and (ArticulosXBodega.Idbodega=" & iddebodega & ") and Barras = '" & codigo & "'")
            'Else
            '    RS = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, ExistenciaBodega, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote, Consignacion , Id_Bodega, ExistenciaBodega, bloqueado,pantalla from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Cod_articulo ='" & codigo & "' or (Inhabilitado = 0) and Barras = '" & codigo & "'")
            'End If

            'If RS.Read Then
            'sqlConexion.Close()
            'sqlConexion = CConexion.Conectar
            Return CConexion.GetRecorset(sqlConexion, "SELECT ValidaExistencia, Max_Descuento, Precio_Promo, Promo_Activa, PromoCRE, PromoCON, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, ExistenciaBodega, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote, Consignacion , Id_Bodega, ExistenciaBodega, bloqueado,pantalla,rifa from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Cod_Articulo ='" & codigo & "' or (Inhabilitado = 0) and Barras = '" & codigo & "' or barras2 = '" & codigo & "' or barras3 = '" & codigo & "'")

            If Not IsNumeric(codigo) Then
                Return CConexion.GetRecorset(sqlConexion, "SELECT Inventario.Max_Descuento, Inventario.Precio_Promo, Inventario.Promo_Activa, Inventario.Codigo, Inventario.Barras, Inventario.Descripcion, Inventario.SubFamilia, ArticulosXBodega.Existencia, Inventario.PrecioBase, Inventario.Fletes, Inventario.OtrosCargos, Inventario.Costo, Inventario.MonedaCosto, Inventario.MonedaVenta, Inventario.Precio_A, Inventario.Precio_B, Inventario.Precio_C, Inventario.Precio_D, Inventario.IVenta, Inventario.PreguntaPrecio, Inventario.Servicio, Familia.Comision, Familia.SobrePrecio FROM Inventario INNER JOIN  Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion INNER JOIN SubFamilias ON Inventario.SubFamilia = SubFamilias.Codigo INNER JOIN  Familia ON SubFamilias.CodigoFamilia = Familia.Codigo INNER JOIN  ArticulosXBodega ON Inventario.Codigo = ArticulosXBodega.Codigo WHERE (Inhabilitado = 0) and (ArticulosXBodega.Idbodega=" & iddebodega & ") and Barras = '" & codigo & "'")
            Else
                'RS = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, ExistenciaBodega, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote, Consignacion , Id_Bodega, ExistenciaBodega, bloqueado,pantalla from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Cod_articulo ='" & codigo & "' or (Inhabilitado = 0) and Barras = '" & codigo & "'")
                RS = CConexion.GetRecorset(sqlConexion, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras,promo3x1, dbo.Inventario.Descripcion + '( ' + Cast(dbo.Inventario.PresentaCant AS VARCHAR) + ' ' + dbo.Presentaciones.Presentaciones + ') ' AS Descripcion , SubFamilia, ExistenciaBodega, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio, Servicio, Minima, Cod_Articulo, Lote, Consignacion , Id_Bodega, ExistenciaBodega, bloqueado,pantalla from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Codigo ='" & codigo & "' or (Inhabilitado = 0) and Barras = '" & codigo & "' or barras2 = '" & codigo & "' or barras3 = '" & codigo & "'")
            End If
            'Else
            '    For X = Len(codigo) - 1 To 1 Step -1
            '        DatoX = ConexionX.GetRecorset(ConexionX.Conectar, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion AS Descripcion , SubFamilia, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & codigo.Substring(0, X) & "'")
            '        If DatoX.Read Then
            '            Cantidad = Cantidad / 1000
            '            Me.txtCantidad.Text = Cantidad
            '            Me.TxtCodArticulo.Text = CodigoExtra
            '            ConexionX.DesConectar(ConexionX.sQlconexion)
            '            Return ConexionX.GetRecorset(ConexionX.Conectar, "SELECT Max_Descuento, Precio_Promo, Promo_Activa, Codigo, Barras, dbo.Inventario.Descripcion AS Descripcion , SubFamilia, Existencia, PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, MonedaVenta, Precio_A, Precio_B, Precio_C, Precio_D, IVenta, PreguntaPrecio from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion WHERE (Inhabilitado = 0) and Barras = '" & CodigoExtra & "'")
            '            Exit For
            '        End If
            '        DatoX.Close()
            '    Next
            'End If
            Return RS

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'RS.Close()
        End Try
    End Function


    Private Function CargarInformacionArticulo(ByVal codigo As String, Optional ByVal recargar As Boolean = False) As Boolean
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean
        If codigo <> Nothing Then
            sqlConexion = CConexion.Conectar
            rs = InformacionArticulo(codigo)
            Encontrado = False
            While rs.Read
                Try
                    Encontrado = True
                    TxtCodArticulo.Text = rs("codigo")
                    txt_articulo.Text = rs("cod_articulo")
                    txtNombreArt.Text = rs("Descripcion")
                    txtImpVenta.Text = Format(rs("IVenta"), "#,#0.00")
                    PrecioBase = rs("PrecioBase")
                    Me.txtCostoBase.Text = PrecioBase
                    Max_Descuento_Articulo = rs("Max_Descuento")
                    Me.TxtMaxdescuento.Text = Me.Max_Descuento_Articulo
                    PrecioCosto = rs("Costo")
                    Me.TxtprecioCosto.Text = rs("Costo")
                    Flete = rs("Fletes")
                    Me.txtFlete.Text = Flete
                    OtrosMontos = rs("OtrosCargos")
                    Me.txtOtros.Text = OtrosMontos
                    Me.Existencia = rs("Existencia")
                    txtExistencia.EditValue = rs("Existencia")

                    If rs("PreguntaPrecio") Then
                        If recargar = False Then
                            Dim Precio As New Monto_Transporte_Ventas
                            Precio.Text = "Establecer Precio"
                            Precio.GroupBox1.Text = "Digite el precio del articulo"
                            If tipoprecio = 1 Then
                                Precio.TextNumero.Text = rs("Precio_A") * (1 + (CDbl(txtImpVentaT.Text) / 100))
                            ElseIf tipoprecio = 2 Then
                                Precio.TextNumero.Text = rs("Precio_B") * (1 + (CDbl(txtImpVentaT.Text) / 100))
                            ElseIf tipoprecio = 3 Then
                                Precio.TextNumero.Text = rs("Precio_C") * (1 + (CDbl(txtImpVentaT.Text) / 100))
                            ElseIf tipoprecio = 4 Then
                                Precio.TextNumero.Text = rs("Precio_D") * (1 + (CDbl(txtImpVentaT.Text) / 100))
                            End If
                            Precio.ShowDialog()

                            If Precio.DialogResult = Windows.Forms.DialogResult.OK Then
                                PrecioA = (Precio.Monto / (1 + (CDbl(txtImpVentaT.Text) / 100)))
                                PrecioB = (Precio.Monto / (1 + (CDbl(txtImpVentaT.Text) / 100)))
                                PrecioC = (Precio.Monto / (1 + (CDbl(txtImpVentaT.Text) / 100)))
                                PrecioD = (Precio.Monto / (1 + (CDbl(txtImpVentaT.Text) / 100)))
                            Else
                                Precio.Dispose()
                                rs.Close()
                                ' GridControl1.Enabled = False
                                Me.txt_articulo.Focus()
                                CConexion.DesConectar(CConexion.Conectar)
                                ' Cambio_Cantidad = False
                                Return False
                            End If
                            Precio.Dispose()
                        Else
                            'PrecioA = BindingContext(Ds_Apartado1, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                            'PrecioB = BindingContext(Ds_Apartado1, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                            'PrecioC = BindingContext(Ds_Apartado1, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                            'PrecioD = BindingContext(Ds_Apartado1, "Ventas.VentasVentas_Detalle").Current("Precio_Unit")
                        End If
                    Else
                        PrecioA = rs("Precio_A")
                        PrecioB = rs("Precio_B")
                        PrecioC = rs("Precio_C")
                        PrecioD = rs("Precio_D")
                    End If


                    Me.precio_promo_valor = rs("Precio_Promo")
                    MonedaCosto = rs("MonedaVenta") 'rs("MonedaCosto")
                    Txtcodmoneda_Venta.Text = rs("MonedaVenta")

                    Me.MonedaBase = rs("MonedaCosto")
                    MonedaVenta = Me.BindingContext(Ds_Apartado1, "Moneda").Current("CodMoneda")

                    If rs("Promo_Activa") = True Then ' si el articulo esta en promocion
                        Me.promo_activa_valor = True
                        Me.txtDescuento.Enabled = False
                    Else
                        Me.promo_activa_valor = False ' se habilita el text
                        If Me.txtDescuento.Properties.ReadOnly = False Then Me.txtDescuento.Enabled = True
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()
            If Not Encontrado Then
                'MsgBox("No existe o está inhabilitado un artículo con este código", MsgBoxStyle.Critical)
n:
                If MessageBox.Show("No existe o está inhabilitado un artículo con este código" & vbCrLf & "Desea Continuar?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    '' GridControl1.Enabled = False
                    Me.txt_articulo.Focus()
                    CConexion.DesConectar(CConexion.Conectar)
                    'Cambio_Cantidad = False
                    txtExistencia.EditValue = 0
                    Return False
                Else
                    GoTo n
                End If
            End If

            CConexion.DesConectar(sqlConexion)
            sqlConexion = CConexion.Conectar

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaCosto)
            While rs.Read
                Try
                    ValorCosto = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()
            'Consulta el Tipo de Cambio de la Moneda usada para la Venta
            CConexion.DesConectar(sqlConexion)
            sqlConexion = CConexion.Conectar

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & CInt(Me.Txtcodmoneda_Venta.Text))
            While rs.Read
                Try
                    'Txt_TipoCambio_Valor_Compra.Text = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()
            ValorVenta = CDbl(Me.txtTipoCambio.Text)

            CConexion.DesConectar(sqlConexion)
            sqlConexion = CConexion.Conectar

            rs = CConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaBase)
            While rs.Read
                Try
                    ValorBase = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()

            Calculo_precio_unitario()

            If Me.txtNombreArt.Text <> "" Then 'si se recuperaron los datos de un articulo

                If Me.txtPrecioUnit.Enabled = True Then 'si el usuario puede disminuir o aumentar el costo del articulo
                    Me.txtPrecioUnit.Focus()
                Else
                    If Me.txtDescuento.Enabled = True Then
                        txtDescuento.Focus()
                    Else
                        Me.txtCantidad.Focus()
                    End If
                End If

                ''Me.GridControl1.Enabled = False
                Cambio_Cantidad = False
                Return True
            End If
        Else ' si no se recupero ningun articulo, se termina la edicion

            Try

                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.txt_articulo.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message)
                CConexion.DesConectar(CConexion.Conectar)
            End Try
            CConexion.DesConectar(CConexion.Conectar)
        End If
        Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
    End Function

    Private Function Utilidad(ByVal Costo As Double, ByVal Precio As Double) As Double
        Utilidad = ((Precio / Costo) - 1) * 100
        Return Utilidad
    End Function

#End Region

#Region "Precio Unitario"
    Private Sub Calculo_precio_unitario()
        Try
            If Me.promo_activa_valor Then ' si el articulo esta actualmente en promoción 
                txtPrecioUnit.Text = Math.Round((Me.precio_promo_valor * (ValorCosto / ValorVenta)), 2)

                'Calculo de Costo
                txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
                PrecioBase = txtCostoBase.Text
                txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
                txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
                Me.precio_unitario = txtPrecioUnit.Text
                'Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
                Exit Sub
            End If

            If Me.tipoprecio = 0 Then
                Me.tipoprecio = 1
            End If

            'Calculos para el Precio Unitario
            Select Case tipoprecio

                Case 1 : txtPrecioUnit.Text = Math.Round((PrecioA * (ValorCosto / ValorVenta)), 2)
                Case 2 : txtPrecioUnit.Text = Math.Round((PrecioB * (ValorCosto / ValorVenta)), 2)
                Case 3 : txtPrecioUnit.Text = Math.Round((PrecioC * (ValorCosto / ValorVenta)), 2)
                Case 4 : txtPrecioUnit.Text = Math.Round((PrecioD * (ValorCosto / ValorVenta)), 2)
            End Select
            'Calculo de Costo
            txtCostoBase.Text = (CDbl(txtCostoBase.Text) * (ValorBase / ValorVenta))
            PrecioBase = txtCostoBase.Text
            txtFlete.Text = (CDbl(txtFlete.Text) * (ValorBase / ValorVenta))
            txtOtros.Text = (CDbl(txtOtros.Text) * (ValorBase / ValorVenta))
            Me.TxtprecioCosto.Text = (CDbl(Me.TxtprecioCosto.Text) * (ValorBase / ValorVenta))
            Me.precio_unitario = txtPrecioUnit.Text
            'Me.TxtUtilidad.Text = Utilidad(Me.txtCostoBase.Text, (Me.txtPrecioUnit.Text - txtFlete.Text - txtOtros.Text))
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Meter Detalle"
    Private Sub meter_al_detalle()
        Try
            If Me.txtCantidad.Text = "" Or Me.txtCantidad.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.txtCantidad.Text = "1"
                Exit Sub
            End If

            If CDbl(Me.txtCantidad.Text) > Me.Existencia Then 'si la cantidad digitada es mayor que la existencia
                If Not Me.vende_existecias_negativas Then
                    MsgBox("Usted no puede vender con existencias negativas", MsgBoxStyle.Critical)
                    If Me.Existencia <= 0 Then  ' si en el inventario ese articulo tiene existencias negativas
                        Me.txtCantidad.Text = 0 ' se vende solo lo que hay en el inventario
                    Else
                        Me.txtCantidad.Text = Me.Existencia '' se vende solo lo que hay en el inventario
                    End If

                    If Existencia = 0 Then ' si no hay articulos de ese tipo en el inventario
                        Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                        Exit Sub
                    End If

                End If

            ElseIf CDbl(Me.txtCantidad.Text) = Me.Existencia Then 'si con esta venta el inventario la existencia sera 0
                MsgBox("Con esta Venta, la existencia de este artículo será 0, se debe hacer un pedido", MsgBoxStyle.Information)
            End If
            Calculos_Articulo()
            Validar_Punitario()

            If mensaje <> "" Then
                MsgBox(mensaje, MsgBoxStyle.Information, "Seepos")
                mensaje = ""
            End If

            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()

            Calcular_totales()
            Me.txt_articulo.Focus()
            Me.GridControl1.Enabled = True

            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count - 1
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eliminar detalle"
    Private Sub Eliminar_Ariculo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este artículo de la Factura?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").RemoveAt(Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Position)
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                    Me.Calcular_totales()
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()

                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                    txtExistencia.EditValue = 0
                    '' GridControl1.Enabled = False
                    txt_articulo.Focus()
                Else
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Artìculos para eliminar en la Factura", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "GridControl"
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        GridControl1.Enabled = True
    End Sub

    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus
        BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Ariculo_Detalle()
        End If

        If e.KeyCode = Keys.F2 Then
            '     If buscando = True Then Exit Sub
            '  Me.Registrar()
        End If

        If e.KeyCode = Keys.Escape Then
            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
            'GridControl1.Enabled = False
            txtExistencia.EditValue = 0
            txt_articulo.Focus()
        End If

        If e.KeyCode = Keys.F6 Then
            txtCantidad.Focus()
        End If

        If e.KeyCode = Keys.Insert Then
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
            txtExistencia.EditValue = 0
            ' GridControl1.Enabled = False
            txt_articulo.Focus()
        End If
    End Sub
#End Region

#Region "Calcular Totales"
    Private Sub Calcular_totales()
        Try
            Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            Calcular_Totales_Cotizacion()
            Me.txtTotalArt.Text = Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Count

            Me.BindingContext(Me.Ds_Apartado1, "Apartados").EndCurrentEdit()
            Me.BindingContext(Me.Ds_Apartado1, "Apartados").AddNew()
            Me.BindingContext(Me.Ds_Apartado1, "Apartados").CancelCurrentEdit()
            Me.BindingContext(Me.Ds_Apartado1, "Apartados").Position = Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Count

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Validar Precio Unitario"
    Private Sub Validar_Punitario()
        Try
            Dim max_precio_unit As Double

            max_precio_unit = ((Me.variacion_Punit / 100) * Me.precio_unitario)    ' se calcula la variacioon maxima que se puede hacer sobre ese articulo

            If CDbl(Me.txtPrecioUnit.Text) < Me.precio_unitario Then
                If perdiendo_PUnit() Then
                    Exit Sub
                End If

                If (Me.precio_unitario - CDbl(Me.txtPrecioUnit.Text)) > (max_precio_unit) Then ' si se bajo el precio mas de lo posible
                    MsgBox("Precio unitario inválido, solo puede variar el precio en un " + variacion_Punit.ToString + "% = " + Me.Label31.Text.ToString + " " + max_precio_unit.ToString, MsgBoxStyle.Exclamation)
                    txtPrecioUnit.Text = Me.precio_unitario
                    Exit Sub
                End If
            End If

        Catch ex As SystemException
            txtPrecioUnit.Text = Me.precio_unitario
            'MsgBox(ex.Message)
        End Try
    End Sub

    Function perdiendo_PUnit() As Boolean
        Try
            If (CDbl(Me.txtPrecioUnit.Text) < CDbl(Me.TxtprecioCosto.Text)) Then
                Me.monto_Perdido = CDbl(Me.TxtprecioCosto.Text) - CDbl(Me.txtPrecioUnit.Text)
                'Me.perfil_administrador
                If (PMU.Others) Then  'si es un administrador, quien está haciedo la facturacion

                    mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Se disminuyó el P.unit. en " + Label31.Text + (CDbl(Me.precio_unitario - Me.txtPrecioUnit.Text)).ToString + " ,Con esta venta se está perdiendo " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf
                Else
                    mensaje = mensaje + "Cod: " + Me.txt_articulo.Text + " Usted no puede vender perdiendo, la disminución del P.unit. en " + Label31.Text + (CDbl(Me.precio_unitario - Me.txtPrecioUnit.Text)) + " provocaria una perdida de " + Me.Label31.Text + Me.monto_Perdido.ToString + vbCrLf
                End If
                Return True
            Else
                Return False
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Function


#End Region

#Region "Login"
    Private Sub Loggin_Usuario()
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader

        If txtUsuario.Text <> "" Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
            If rs.HasRows = False Then
                MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                txtUsuario.Focus()
            End If

            While rs.Read
                Try
                    PMU = VSM(rs("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Text, MsgBoxStyle.Information, "Atención...") : Me.Close()
                    Me.Ds_Apartado1.Apartado_detalle.Clear()
                    Ds_Apartado1.Apartados.Clear()

                    Me.BindingContext(Me.Ds_Apartado1, "Apartados").EndCurrentEdit()
                    Me.BindingContext(Me.Ds_Apartado1, "Apartados").AddNew()

                    txtNombreUsuario.Text = rs("Nombre")
                    txtCedulaUsuario.Text = rs("Cedula")

                    txtPrecioUnit.Enabled = Usua.CambiarPrecio
                    txtPrecioUnit.Properties.ReadOnly = Not Usua.CambiarPrecio
                    variacion_Punit = IIf(Usua.CambiarPrecio, Usua.Porc_Precio, 0)
                    porcentaje_descuento = Usua.Porc_Desc

                    'si el usuario no puede dar descuento
                    SimpleButton2.Enabled = Usua.Aplicar_Desc
                    txtDescuento.Enabled = Usua.Aplicar_Desc
                    txtDescuento.Properties.ReadOnly = IIf(Usua.Porc_Desc > 0, False, True)

                    TxtUtilidad.Visible = PMU.Others
                    Label49.Visible = PMU.Others
                    Me.vende_existecias_negativas = Usua.Exist_Negativa ' si el vendedor puede vender con existencias negativas
                    'Me.ComboBox1.Enabled = True

                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        Else
            MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
            txtUsuario.Focus()
        End If
    End Sub
#End Region

#Region "Recalcular Cotizacion"
    Private Sub recalcular_cotizacion(ByVal nuev_des As Double)
        Dim i As Integer
        Try

            For i = 0 To Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Count - 1
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").Position = i
                Me.txtDescuento.Text = nuev_des
                Calculos_Articulo() ' se calcula de nuevo los datos del articulo cotizado
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
            Next

            Calcular_Totales_Cotizacion()
            MsgBox("Descuentos sobre artìculos han sido Actualizados", MsgBoxStyle.Information)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Abonos Apartados"
    Private Sub abonos()
        Dim abono As New Abono_Apartados
        abono.usua = Me.Usua
        abono.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        abonos()
    End Sub
#End Region


    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Usua = Usuario_Parametro
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()        
    End Sub
   
    Private Sub txt_articulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_articulo.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Try

                    Dim CodigoBuscador As String = BuscarF1()
                    If Not IsNothing(CodigoBuscador) And CodigoBuscador <> "0" And CodigoBuscador <> "0.00" Then
                        CargarInformacionArticulo(CodigoBuscador)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                End Try

            Case Keys.Enter
                buscararticulo()
            Case Keys.F2
                Me.registrar()
            Case Keys.F3
                Buscar_Apartado()

            Case Keys.F6
                Me.BindingContext(Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                GridControl1.Focus()

            Case Keys.F9
                txtCodigo.Focus()

            Case Keys.F11
                abonos()

            Case Keys.Escape
                If MessageBox.Show("¿Desea cancelar este apartado?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If MessageBox.Show("¿Desea cancelar este apartado?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Me.BindingContext(Me.Ds_Apartado1, "Apartados").CancelCurrentEdit()
                        Me.SimpleButton1.Enabled = False
                        Ds_Apartado1.Apartado_detalle.Clear()
                        Ds_Apartado1.Apartados.Clear()
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = True
                        Me.GroupBox3.Enabled = False
                        Me.dtFecha.Enabled = False
                        Me.logeado = False
                        Me.SimpleButton3.Enabled = False
                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtUsuario.Focus()
                        Me.Loggin_Usuario()
                    End If
                End If

            Case Keys.Insert
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").CancelCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").EndCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Apartados.Apartados_Apartado_detalle").AddNew()
                'GridControl1.Enabled = False
                txtExistencia.EditValue = 0

            Case Keys.Multiply
                Me.BindingContext(Me.Ds_Apartado1, "Ventas.VentasVentas_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Ventas.VentasVentas_Detalle").EndCurrentEdit()
                Me.BindingContext(Me.Ds_Apartado1, "Ventas.VentasVentas_Detalle").AddNew()
                txtExistencia.EditValue = 0
                'GridControl1.Enabled = False
                Me.Cambio_Cantidad = True
                txt_articulo.EditValue = ""
                txt_articulo.Text = ""
                Me.txtCantidad.Focus()

        End Select
    End Sub

    Private Sub txt_articulo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_articulo.EditValueChanged

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class