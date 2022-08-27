Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System
Imports System.Data
Imports System.Windows.Forms

Public Class main
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim Cedula_usuario As String
    Dim Nombre_usuario As String
    Dim porcentaje_descuento As Double
    Dim Existencia, Comision As Double
    Dim perfil_administrador As Boolean
    Dim cliente_cargado As Boolean
    Dim Imp_Conf As Double ' almacena el impuesto d eventa traido de la tabla configuraciones
    Dim vende_existecias_negativas As Boolean
    Dim impuesto_cliente As Double
    Dim variacion_Punit As Double
    Dim Monto_Adeudado As Double
    Dim ayuda As Boolean
    Dim Usua As Object
    Dim Cambio_Cantidad As Boolean
    Dim max_aplicar As Double 'almacena el maximo porcentaje de descuento que se puede aplicar a determinado articulo
    Dim buscando As Boolean = False
    'varibles de articulos
    Dim PrecioBase As Double
    Dim PrecioCosto As Double
    Dim Flete As Double
    Dim OtrosMontos As Double
    Dim PrecioA As Double
    Dim PrecioB As Double
    Dim PrecioC As Double
    Dim PrecioD As Double
    Dim ValorCosto As Double
    Dim ValorVenta As Double
    Dim MonedaCosto As Integer
    Dim MonedaVenta As Integer
    Dim MonedaBase As Integer
    Dim ValorBase As Double
    Dim MontoImpuesto As Double
    Dim precio_unitario As Double
    Dim Max_Descuento_Articulo As Double
    Dim promo_activa_valor As Boolean
    Dim precio_promo_valor As Double
    Dim monto_Perdido As Double
    Dim CConexion As New Conexion
    Dim mensaje As String ' almacena el mensaje de los descuentos
    Dim password_antiguo As String
    Dim logeado As Boolean
    Dim coti As Boolean
    Dim Importando, RequierePrecio As Boolean
    ' Dim Factu_Reporte As New Reporte_FacturaPVEs ' Reporte_Factura
    '    Dim FacturaPVE As New CrystalDecisions.CrystalReports.Engine.ReportDocument 'As New Reporte_FacturaPVEs
    Dim FacturaPVE As New Reporte_FacturaPVEs
    Dim Factura_Generica As New Factura_Generica


    'Dim FacturaPVESug As New Reporte_FacturaPVEs_Sugerido
    Dim FrmVuelto As New vuelto
    Dim Movimiento_Pago_Factura As frmMovimientoCajaPagoAbono
    Dim PMU As New PerfilModulo_Class
    Dim TopBuscador As Integer = 50

#Region " Variable "                 'Definicion de Variable 
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = True
    Private PorcCambiarPrecio As Double
    Private PorcDescuento As Double
    Private Anula As Boolean
    Private abierto As Boolean
    Private impuesto As Double
    Private max_credito As Double
    Private plazo_credito As Integer
    Private descuento As Double
    Private tipoprecio As Integer
    Private sinrestriccion As Boolean
    Private Exento As Double
    Private Gravado As Double
    Private DescuentoCalc As Double
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Ventas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterConfig As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents datalistado As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_apartado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Private ImpuestoCalc As Double
#End Region

#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Usua = Usuario_Parametro
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()       
    End Sub


    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox

    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection



    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Encargados_Compra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Ventas_Detalles As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton

    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Configuraciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet_Facturaciones As DataSet_Facturaciones
    Friend WithEvents Adapter_Coti As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_CotiDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    'System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adapter_Apertura As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.DataSet_Facturaciones = New LcPymes_5._2.DataSet_Facturaciones()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Encargados_Compra = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Ventas_Detalles = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Configuraciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Coti = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_CotiDetalle = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Adapter_Apertura = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Adapter_Ventas = New System.Data.SqlClient.SqlDataAdapter()
        Me.AdapterConfig = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datalistado = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id_apartado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLiente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.saldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.DataSet_Facturaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet_Facturaciones
        '
        Me.DataSet_Facturaciones.DataSetName = "DataSet_Facturaciones"
        Me.DataSet_Facturaciones.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_Facturaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(529, 300)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(467, 300)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 0
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=192.168.0.2;Initial Catalog=SeePOS;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplicar_Desc," & _
    " Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuarios"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Adapter_Encargados_Compra
        '
        Me.Adapter_Encargados_Compra.SelectCommand = Me.SqlSelectCommand11
        Me.Adapter_Encargados_Compra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "encargadocompras", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Identificacion", "Identificacion"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Identificacion, Cliente, Nombre FROM encargadocompras"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'Adapter_Ventas_Detalles
        '
        Me.Adapter_Ventas_Detalles.DeleteCommand = Me.SqlDeleteCommand
        Me.Adapter_Ventas_Detalles.InsertCommand = Me.SqlInsertCommand
        Me.Adapter_Ventas_Detalles.SelectCommand = Me.SqlSelectCommand10
        Me.Adapter_Ventas_Detalles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_venta_detalle", "id_venta_detalle"), New System.Data.Common.DataColumnMapping("Id_Factura", "Id_Factura"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Devoluciones", "Devoluciones"), New System.Data.Common.DataColumnMapping("Numero_Entrega", "Numero_Entrega"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio_ValorCompra", "Tipo_Cambio_ValorCompra"), New System.Data.Common.DataColumnMapping("Cod_MonedaVenta", "Cod_MonedaVenta"), New System.Data.Common.DataColumnMapping("Id_bodega", "Id_bodega"), New System.Data.Common.DataColumnMapping("Comision", "Comision"), New System.Data.Common.DataColumnMapping("MontoComision", "MontoComision")})})
        Me.Adapter_Ventas_Detalles.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Factura", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero_Entrega", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Entrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_bodega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_bodega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Comision", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoComision", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoComision", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 0, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 0, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 0, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 0, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 0, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 0, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 0, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 0, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 0, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 0, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 0, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 0, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 0, "Numero_Entrega"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 0, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@Id_bodega", System.Data.SqlDbType.Int, 0, "Id_bodega"), New System.Data.SqlClient.SqlParameter("@Comision", System.Data.SqlDbType.Float, 0, "Comision"), New System.Data.SqlClient.SqlParameter("@MontoComision", System.Data.SqlDbType.Float, 0, "MontoComision")})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Factura", System.Data.SqlDbType.BigInt, 0, "Id_Factura"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 0, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 0, "Cantidad"), New System.Data.SqlClient.SqlParameter("@Precio_Costo", System.Data.SqlDbType.Float, 0, "Precio_Costo"), New System.Data.SqlClient.SqlParameter("@Precio_Base", System.Data.SqlDbType.Float, 0, "Precio_Base"), New System.Data.SqlClient.SqlParameter("@Precio_Flete", System.Data.SqlDbType.Float, 0, "Precio_Flete"), New System.Data.SqlClient.SqlParameter("@Precio_Otros", System.Data.SqlDbType.Float, 0, "Precio_Otros"), New System.Data.SqlClient.SqlParameter("@Precio_Unit", System.Data.SqlDbType.Float, 0, "Precio_Unit"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Monto_Descuento", System.Data.SqlDbType.Float, 0, "Monto_Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 0, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Monto_Impuesto", System.Data.SqlDbType.Float, 0, "Monto_Impuesto"), New System.Data.SqlClient.SqlParameter("@SubtotalGravado", System.Data.SqlDbType.Float, 0, "SubtotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExcento", System.Data.SqlDbType.Float, 0, "SubTotalExcento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 0, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Numero_Entrega", System.Data.SqlDbType.Float, 0, "Numero_Entrega"), New System.Data.SqlClient.SqlParameter("@Max_Descuento", System.Data.SqlDbType.Float, 0, "Max_Descuento"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, "Tipo_Cambio_ValorCompra"), New System.Data.SqlClient.SqlParameter("@Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, "Cod_MonedaVenta"), New System.Data.SqlClient.SqlParameter("@Id_bodega", System.Data.SqlDbType.Int, 0, "Id_bodega"), New System.Data.SqlClient.SqlParameter("@Comision", System.Data.SqlDbType.Float, 0, "Comision"), New System.Data.SqlClient.SqlParameter("@MontoComision", System.Data.SqlDbType.Float, 0, "MontoComision"), New System.Data.SqlClient.SqlParameter("@Original_id_venta_detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_venta_detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Factura", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Factura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Costo", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Base", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Base", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Flete", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Otros", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Otros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Precio_Unit", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_Unit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Impuesto", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubtotalGravado", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubtotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExcento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExcento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero_Entrega", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Entrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Max_Descuento", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Max_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio_ValorCompra", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio_ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_MonedaVenta", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_MonedaVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_bodega", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_bodega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Comision", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoComision", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoComision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id_venta_detalle", System.Data.SqlDbType.BigInt, 8, "id_venta_detalle")})
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Importar Cotización"
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        '
        'Adapter_Configuraciones
        '
        Me.Adapter_Configuraciones.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Configuraciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "configuraciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Intereses", "Intereses"), New System.Data.Common.DataColumnMapping("UnicoConsecutivo", "UnicoConsecutivo"), New System.Data.Common.DataColumnMapping("NumeroConsecutivo", "NumeroConsecutivo"), New System.Data.Common.DataColumnMapping("ConsContado", "ConsContado"), New System.Data.Common.DataColumnMapping("NumeroContado", "NumeroContado"), New System.Data.Common.DataColumnMapping("ConsCredito", "ConsCredito"), New System.Data.Common.DataColumnMapping("NumeroCredito", "NumeroCredito"), New System.Data.Common.DataColumnMapping("ConsPuntoVenta", "ConsPuntoVenta"), New System.Data.Common.DataColumnMapping("NumeroPuntoVenta", "NumeroPuntoVenta"), New System.Data.Common.DataColumnMapping("Logo", "Logo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Intereses, UnicoConsecutivo, NumeroConsecutivo, ConsContado, Numer" & _
    "oContado, ConsCredito, NumeroCredito, ConsPuntoVenta, NumeroPuntoVenta, Logo FRO" & _
    "M configuraciones"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Adapter_Coti
        '
        Me.Adapter_Coti.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Coti.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Coti.SelectCommand = Me.SqlSelectCommand13
        Me.Adapter_Coti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cotizacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cotizacion", "Cotizacion"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Contacto", "Contacto"), New System.Data.Common.DataColumnMapping("Validez", "Validez"), New System.Data.Common.DataColumnMapping("TiempoEntrega", "TiempoEntrega"), New System.Data.Common.DataColumnMapping("Contado", "Contado"), New System.Data.Common.DataColumnMapping("Credito", "Credito"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Dias", "Dias"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte"), New System.Data.Common.DataColumnMapping("Venta", "Venta")})})
        Me.Adapter_Coti.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 4, "Validez"), New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 4, "TiempoEntrega"), New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 1, "Contado"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 4, "Dias"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 8, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"), New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 1, "Venta")})
        '
        'SqlSelectCommand13
        '
        Me.SqlSelectCommand13.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 4, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Contacto", System.Data.SqlDbType.VarChar, 250, "Contacto"), New System.Data.SqlClient.SqlParameter("@Validez", System.Data.SqlDbType.Int, 4, "Validez"), New System.Data.SqlClient.SqlParameter("@TiempoEntrega", System.Data.SqlDbType.Int, 4, "TiempoEntrega"), New System.Data.SqlClient.SqlParameter("@Contado", System.Data.SqlDbType.Bit, 1, "Contado"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Dias", System.Data.SqlDbType.Int, 4, "Dias"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 8, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Float, 8, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 8, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 8, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 8, "Transporte"), New System.Data.SqlClient.SqlParameter("@Venta", System.Data.SqlDbType.Bit, 1, "Venta"), New System.Data.SqlClient.SqlParameter("@Original_Cotizacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cotizacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contacto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contacto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dias", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dias", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Imp_Venta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Imp_Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cliente", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PagoImpuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PagoImpuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravada", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TiempoEntrega", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TiempoEntrega", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Cambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Cambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Transporte", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Transporte", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Validez", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Validez", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Venta", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Venta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Cotizacion", System.Data.SqlDbType.BigInt, 8, "Cotizacion")})
        '
        'Adapter_CotiDetalle
        '
        Me.Adapter_CotiDetalle.SelectCommand = Me.SqlSelectCommand14
        Me.Adapter_CotiDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cotizacion_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Cotizacion", "Cotizacion"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Precio_Costo", "Precio_Costo"), New System.Data.Common.DataColumnMapping("Precio_Base", "Precio_Base"), New System.Data.Common.DataColumnMapping("Precio_Flete", "Precio_Flete"), New System.Data.Common.DataColumnMapping("Precio_Otros", "Precio_Otros"), New System.Data.Common.DataColumnMapping("Precio_Unit", "Precio_Unit"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Monto_Descuento", "Monto_Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Monto_Impuesto", "Monto_Impuesto"), New System.Data.Common.DataColumnMapping("SubtotalGravado", "SubtotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExcento", "SubTotalExcento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("SubFamilia", "SubFamilia"), New System.Data.Common.DataColumnMapping("Max_Descuento", "Max_Descuento"), New System.Data.Common.DataColumnMapping("Tipo_Cambio_ValorCompra", "Tipo_Cambio_ValorCompra"), New System.Data.Common.DataColumnMapping("Cod_MonedaVenta", "Cod_MonedaVenta")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(337, 298)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(141, 16)
        Me.Label48.TabIndex = 190
        Me.Label48.Text = "Usuario Logeado->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Adapter_Apertura
        '
        Me.Adapter_Apertura.SelectCommand = Me.SqlSelectCommand5
        Me.Adapter_Apertura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "aperturacaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NApertura", "NApertura")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT NApertura FROM aperturacaja"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT     Ventas.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Ventas"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 0, "Num_Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 0, "Orden"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 0, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.NVarChar, 0, "Nombre_Usuario"), New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 0, "Pago_Comision"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.SmallDateTime, 0, "Vence"), New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 0, "Cod_Encargado_Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 0, "AsientoVenta"), New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 0, "ContabilizadoCVenta"), New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 0, "AsientoCosto"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 0, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 0, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.Int, 0, "Num_Apertura"), New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 0, "Entregado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 0, "Moneda_Nombre"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 0, "Transporte"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 0, "Exonerar"), New System.Data.SqlClient.SqlParameter("@CodComisionista", System.Data.SqlDbType.BigInt, 0, "CodComisionista"), New System.Data.SqlClient.SqlParameter("@NombreComisionista", System.Data.SqlDbType.VarChar, 0, "NombreComisionista"), New System.Data.SqlClient.SqlParameter("@PagoComision", System.Data.SqlDbType.Float, 0, "PagoComision"), New System.Data.SqlClient.SqlParameter("@Apartado", System.Data.SqlDbType.BigInt, 0, "Apartado")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Factura", System.Data.SqlDbType.Float, 0, "Num_Factura"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@Cod_Cliente", System.Data.SqlDbType.Int, 0, "Cod_Cliente"), New System.Data.SqlClient.SqlParameter("@Nombre_Cliente", System.Data.SqlDbType.VarChar, 0, "Nombre_Cliente"), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 0, "Orden"), New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 0, "Cedula_Usuario"), New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.NVarChar, 0, "Nombre_Usuario"), New System.Data.SqlClient.SqlParameter("@Pago_Comision", System.Data.SqlDbType.Bit, 0, "Pago_Comision"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 0, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 0, "Descuento"), New System.Data.SqlClient.SqlParameter("@Imp_Venta", System.Data.SqlDbType.Float, 0, "Imp_Venta"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 0, "Total"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@Vence", System.Data.SqlDbType.SmallDateTime, 0, "Vence"), New System.Data.SqlClient.SqlParameter("@Cod_Encargado_Compra", System.Data.SqlDbType.VarChar, 0, "Cod_Encargado_Compra"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 0, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@AsientoVenta", System.Data.SqlDbType.BigInt, 0, "AsientoVenta"), New System.Data.SqlClient.SqlParameter("@ContabilizadoCVenta", System.Data.SqlDbType.Bit, 0, "ContabilizadoCVenta"), New System.Data.SqlClient.SqlParameter("@AsientoCosto", System.Data.SqlDbType.BigInt, 0, "AsientoCosto"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 0, "Anulado"), New System.Data.SqlClient.SqlParameter("@PagoImpuesto", System.Data.SqlDbType.Int, 0, "PagoImpuesto"), New System.Data.SqlClient.SqlParameter("@FacturaCancelado", System.Data.SqlDbType.Bit, 0, "FacturaCancelado"), New System.Data.SqlClient.SqlParameter("@Num_Apertura", System.Data.SqlDbType.Int, 0, "Num_Apertura"), New System.Data.SqlClient.SqlParameter("@Entregado", System.Data.SqlDbType.Bit, 0, "Entregado"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 0, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@Moneda_Nombre", System.Data.SqlDbType.VarChar, 0, "Moneda_Nombre"), New System.Data.SqlClient.SqlParameter("@Direccion", System.Data.SqlDbType.VarChar, 0, "Direccion"), New System.Data.SqlClient.SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 0, "Telefono"), New System.Data.SqlClient.SqlParameter("@SubTotalGravada", System.Data.SqlDbType.Float, 0, "SubTotalGravada"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 0, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@Transporte", System.Data.SqlDbType.Float, 0, "Transporte"), New System.Data.SqlClient.SqlParameter("@Tipo_Cambio", System.Data.SqlDbType.Float, 0, "Tipo_Cambio"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Exonerar", System.Data.SqlDbType.Bit, 0, "Exonerar"), New System.Data.SqlClient.SqlParameter("@CodComisionista", System.Data.SqlDbType.BigInt, 0, "CodComisionista"), New System.Data.SqlClient.SqlParameter("@NombreComisionista", System.Data.SqlDbType.VarChar, 0, "NombreComisionista"), New System.Data.SqlClient.SqlParameter("@PagoComision", System.Data.SqlDbType.Float, 0, "PagoComision"), New System.Data.SqlClient.SqlParameter("@Apartado", System.Data.SqlDbType.BigInt, 0, "Apartado"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM [Ventas] WHERE (([Id] = @Original_Id))"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adapter_Ventas
        '
        Me.Adapter_Ventas.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adapter_Ventas.InsertCommand = Me.SqlInsertCommand4
        Me.Adapter_Ventas.SelectCommand = Me.SqlSelectCommand6
        Me.Adapter_Ventas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Ventas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente"), New System.Data.Common.DataColumnMapping("Nombre_Cliente", "Nombre_Cliente"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Nombre_Usuario", "Nombre_Usuario"), New System.Data.Common.DataColumnMapping("Pago_Comision", "Pago_Comision"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Imp_Venta", "Imp_Venta"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Vence", "Vence"), New System.Data.Common.DataColumnMapping("Cod_Encargado_Compra", "Cod_Encargado_Compra"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("AsientoVenta", "AsientoVenta"), New System.Data.Common.DataColumnMapping("ContabilizadoCVenta", "ContabilizadoCVenta"), New System.Data.Common.DataColumnMapping("AsientoCosto", "AsientoCosto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("PagoImpuesto", "PagoImpuesto"), New System.Data.Common.DataColumnMapping("FacturaCancelado", "FacturaCancelado"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura"), New System.Data.Common.DataColumnMapping("Entregado", "Entregado"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Moneda_Nombre", "Moneda_Nombre"), New System.Data.Common.DataColumnMapping("Direccion", "Direccion"), New System.Data.Common.DataColumnMapping("Telefono", "Telefono"), New System.Data.Common.DataColumnMapping("SubTotalGravada", "SubTotalGravada"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("Transporte", "Transporte"), New System.Data.Common.DataColumnMapping("Tipo_Cambio", "Tipo_Cambio"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Exonerar", "Exonerar"), New System.Data.Common.DataColumnMapping("CodComisionista", "CodComisionista"), New System.Data.Common.DataColumnMapping("NombreComisionista", "NombreComisionista"), New System.Data.Common.DataColumnMapping("PagoComision", "PagoComision"), New System.Data.Common.DataColumnMapping("Apartado", "Apartado")})})
        Me.Adapter_Ventas.UpdateCommand = Me.SqlUpdateCommand4
        '
        'AdapterConfig
        '
        Me.AdapterConfig.SelectCommand = Me.SqlCommand1
        Me.AdapterConfig.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Config", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PreguntaImprimir", "PreguntaImprimir"), New System.Data.Common.DataColumnMapping("Comisionista", "Comisionista")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT     PreguntaImprimir, Comisionista" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         """
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 87)
        Me.Button1.TabIndex = 219
        Me.Button1.Text = "Apartados"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(12, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 87)
        Me.Button2.TabIndex = 220
        Me.Button2.Text = "Abonos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(12, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 87)
        Me.Button4.TabIndex = 222
        Me.Button4.Text = "Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(10, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Ver. 22.3.2016"
        '
        'datalistado
        '
        Me.datalistado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.datalistado.EmbeddedNavigator.Name = ""
        Me.datalistado.EmbeddedNavigator.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText)
        Me.datalistado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datalistado.Location = New System.Drawing.Point(179, 39)
        Me.datalistado.MainView = Me.GridView1
        Me.datalistado.Name = "datalistado"
        Me.datalistado.Size = New System.Drawing.Size(499, 246)
        Me.datalistado.TabIndex = 224
        Me.datalistado.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id_apartado, Me.CLiente, Me.Total, Me.saldo, Me.Vence})
        Me.GridView1.GroupPanelText = "Detalle de Cotización"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        Me.GridView1.ViewCaption = "Lista de Artículos Facturados"
        '
        'id_apartado
        '
        Me.id_apartado.Caption = "Apartado"
        Me.id_apartado.FieldName = "id_apartado"
        Me.id_apartado.FilterInfo = ColumnFilterInfo1
        Me.id_apartado.Name = "id_apartado"
        Me.id_apartado.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.id_apartado.VisibleIndex = 0
        '
        'CLiente
        '
        Me.CLiente.Caption = "Cliente"
        Me.CLiente.FieldName = "nombrecliente"
        Me.CLiente.FilterInfo = ColumnFilterInfo2
        Me.CLiente.Name = "CLiente"
        Me.CLiente.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.CLiente.VisibleIndex = 1
        '
        'Total
        '
        Me.Total.Caption = "Total"
        Me.Total.FieldName = "total"
        Me.Total.FilterInfo = ColumnFilterInfo3
        Me.Total.Name = "Total"
        Me.Total.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Total.VisibleIndex = 2
        '
        'saldo
        '
        Me.saldo.Caption = "Saldo"
        Me.saldo.FieldName = "saldo"
        Me.saldo.FilterInfo = ColumnFilterInfo4
        Me.saldo.Name = "saldo"
        Me.saldo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.saldo.VisibleIndex = 3
        '
        'Vence
        '
        Me.Vence.Caption = "Vence"
        Me.Vence.FieldName = "vence"
        Me.Vence.FilterInfo = ColumnFilterInfo5
        Me.Vence.Name = "Vence"
        Me.Vence.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Vence.VisibleIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(338, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 24)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "APARTADOS VENCIDOS"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "Notificación de apartados"
        Me.NotifyIcon1.Visible = True
        '
        'main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 320)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label48)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(703, 429)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal "
        CType(Me.DataSet_Facturaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            Me.Adapter_Configuraciones.SelectCommand.CommandText = "SELECT Cedula, Empresa, Tel_01, Tel_02, Fax_01, Fax_02, Direccion, Imp_Venta, Frase, Cajeros, Logo, Intereses, UnicoConsecutivo, NumeroConsecutivo, ConsContado, NumeroContado, ConsCredito, NumeroCredito, ConsPuntoVenta, NumeroPuntoVenta, Taller, TallerContado, TallerCredito, Imprimir_en_Factura_Personalizada, FormatoCheck, Contabilidad, CambiaPrecioCredito, Mascotas, MascotasContado, MascotasCredito, regalias FROM dbo.configuraciones"
            Adapter_Configuraciones.Fill(DataSet_Facturaciones, "configuraciones")
            Adapter_Usuarios.Fill(DataSet_Facturaciones, "Usuarios")
            logeado = False
            Loggin_Usuario()
            Application.DoEvents()

            Dim dts As New DataTable
            Apartado.cFunciones.Llenar_Tabla_Generico("select id_apartado,nombrecliente,total,saldo,vence from reporteapartados where GETDATE() > Vence and Cancelado = 0", dts, CadenaConexionSeePOS)
            Me.datalistado.DataSource = dts
            If dts.Rows.Count > 0 Then
                Me.NotifyIcon1.ShowBalloonTip(5000, "Apartados", "Tiene " & dts.Rows.Count & " Apartados Vencidos", ToolTipIcon.Warning)
            End If
        Catch ex As SystemException
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Loggin_Usuario()
        Try
            If Me.BindingContext(Me.DataSet_Facturaciones.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Usuario_autorizadores = Me.DataSet_Facturaciones.Usuarios.Select("Cedula ='" & Me.Usua.Cedula & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar ventas...", MsgBoxStyle.Exclamation)
                        Me.txtUsuario.Text = ""
                        Me.txtUsuario.Focus()
                        Exit Sub
                    End If

                    Me.logeado = True
                    txtNombreUsuario.Text = Usua.Nombre
                    Me.Cedula_usuario = Usua.Cedula
                    Me.Nombre_usuario = Usua.Nombre
                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña


                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    Me.logeado = False
                    txtUsuario.Text = ""
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
            End If

        Catch ex As SystemException
            MsgBox(ex.ToString & " punto 32")
        End Try
    End Sub
    Sub apartados()
        Dim formapartados As New Apartados
        formapartados.Cedula_usuario = Me.Cedula_usuario
        formapartados.Usua = Me.Usua
        formapartados.ShowDialog()
    End Sub

#Region "Validar Usuario"
    Private Sub Reloggin_Usuario()
        Try

            If Me.BindingContext(Me.DataSet_Facturaciones.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSet_Facturaciones.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then

                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                    'Dim tipo As String = Usua("Perfil")

                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar ventas realizar ventas", MsgBoxStyle.Exclamation)
                        Me.txtUsuario.Text = ""
                        Me.txtUsuario.Focus()
                        Exit Sub
                    End If
                    txtNombreUsuario.Text = Usua("Nombre")


                    Me.porcentaje_descuento = Usua("Porc_Desc")

                    Me.vende_existecias_negativas = Usua("Exist_Negativa") ' si el vendedor puede vender con existencias negativas

                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    txtUsuario.Text = ""
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not logeado Then ' si es la primera vez que se logea un usuario
                Loggin_Usuario()
            Else
                Me.Reloggin_Usuario()
            End If
        End If
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        apartados()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim abono As New Abono_Apartados
        abono.usua = Me.Usua
        abono.ShowDialog()

    End Sub
    Private Sub CargarForm(ByRef Form As Form)
        Try
            Form.StartPosition = FormStartPosition.CenterScreen
            Form.Show()
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CargarForm(New frmgastos(Usua))
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

End Class

