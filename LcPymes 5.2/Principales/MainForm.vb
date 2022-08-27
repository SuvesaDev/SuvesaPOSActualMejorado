Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates


Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim Contador As Integer
    Dim TITULO As String
    Dim usua As Usuario_Logeado
    Public Texto As String
    Friend WithEvents mnPeces As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteTopCliente As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteVentasUnificado As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteClientesmasCompran As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList4 As System.Windows.Forms.ImageList
    Friend WithEvents mnMaquinaria As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents menu_icons As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents mnProductosOrganicos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnInventario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProveedores As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnClientesCredito As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCompras As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnFacturacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPuntoVenta As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblempresa As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteUtilidad As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents mnPrestamosBodega As System.Windows.Forms.MenuItem
    Friend WithEvents mnEmpresaPrestamos As System.Windows.Forms.MenuItem
    Friend WithEvents mnReportePrestamos As System.Windows.Forms.MenuItem
    Friend WithEvents mnPrestamos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents mnMovimientoArticulo As System.Windows.Forms.MenuItem
    Friend WithEvents mnProveedores As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteDescuentosProveedor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents mnVentasPendientes As System.Windows.Forms.MenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuReporteUtilidadArticulos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCambio As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteD151Proveedores As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteD151Clientes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportePanelControl As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteUtilidadFactura As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteUtilidadFechas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportePorcentajeVenta As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents TimerSolicitudes As System.Windows.Forms.Timer
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteCierreCaja As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteSinCabys As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteMovimientoporArticulo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteCreditoRecuperacion As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteDevolucionDetallado As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
    Friend WithEvents sbpTCCompra As System.Windows.Forms.StatusBarPanel
    Friend WithEvents sbpTCVenta As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnuReporteGraficoVentasAnuales As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteCrecimientoCompras As System.Windows.Forms.MenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNegativo As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem184 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents btnAlbaran As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Dim SistemaNormal As Boolean = False
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public Sub New(ByVal Usuario_Parametro)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        usua = Usuario_Parametro
        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents PictureBoxFondo As System.Windows.Forms.PictureBox
    Friend WithEvents HelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents MenuItemInventario_Catalogo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Familias As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Ubicaciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Presentaciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Marcas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Ajustes As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Etiquetas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Aumentos_X_Categoria As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Bodegas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemInventario_Ajuste_Bodegas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemRedondeo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteVentas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteCompras As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteABON_CRE_NDEB As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporte_Inventario As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporte_Kardex As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteABC As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteClientes As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteProveedores As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteGerencial As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAdministracion_Clientes As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAdministracion_Moneda As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAdministracion_Proveedores As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAdministracion_ConfiguracionSistema As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_Facturacion As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_Proformas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_DevolucionesVentas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_AbonosCXC As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_AjustesCXC As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_EstadoCuentaCXC As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_ComprasProveedor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_OrdenCompraAutomatica As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_OrdenCompraManual As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_DevolucionesProveedor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_AbonosCuentaProveedor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_AjusteCuentaProveedor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_EstadoCuentaProveedor As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_Caja_Apertura As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_Caja_Cierre As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_Caja_OpcionesPago As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_Caja_Movimientos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuAdministracion As System.Windows.Forms.MenuItem
    Friend WithEvents MenuOperaciones As System.Windows.Forms.MenuItem
    Friend WithEvents MenuInventarios As System.Windows.Forms.MenuItem
    Friend WithEvents MenuReportes As System.Windows.Forms.MenuItem
    Friend WithEvents MenuInterfaz As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents menuExtender As MenuExtender.MenuExtender
    Friend WithEvents imageList As System.Windows.Forms.ImageList
    Friend WithEvents MenuItemCuentasXCobrar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCompras As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCuentasXPagar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemControlCaja As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemVentas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea01 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea02 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea03 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea04 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea05 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemControlBodega As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea06 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea07 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea09 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAyuda As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMaximizar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemNormal As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMinimizar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemSeguridad As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCalculadora As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemLinea13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCerrar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemPerfilUsuarios As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCambioUsuarios As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemRegistroUsuarios As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemActivarPOS As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemRespaldos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemFullScreenPVE As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteCajas As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItemAdministracion_ConfiguracionMoneda As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemOperacion_Caja_Arqueo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAdministracion_Tarjetas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReportesCXP As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMovimiento As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents mnClinica As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents sbpVersion As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents mnReportePeces As System.Windows.Forms.MenuItem
    Friend WithEvents mnTaller As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteGeneraeIndividualVentas As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteVentas As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReporteArticulosCompradosCliente As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents mnArmamento As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents mnTienda As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuAdministracion = New System.Windows.Forms.MenuItem()
        Me.MenuItemAdministracion_Clientes = New System.Windows.Forms.MenuItem()
        Me.MenuItem83 = New System.Windows.Forms.MenuItem()
        Me.MenuItem92 = New System.Windows.Forms.MenuItem()
        Me.MenuItemAdministracion_Proveedores = New System.Windows.Forms.MenuItem()
        Me.MenuItemAdministracion_Moneda = New System.Windows.Forms.MenuItem()
        Me.MenuItemAdministracion_Tarjetas = New System.Windows.Forms.MenuItem()
        Me.MenuItemAdministracion_ConfiguracionMoneda = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItemAdministracion_ConfiguracionSistema = New System.Windows.Forms.MenuItem()
        Me.MenuItem80 = New System.Windows.Forms.MenuItem()
        Me.MenuItem79 = New System.Windows.Forms.MenuItem()
        Me.MenuItem81 = New System.Windows.Forms.MenuItem()
        Me.MenuItem117 = New System.Windows.Forms.MenuItem()
        Me.MenuItem77 = New System.Windows.Forms.MenuItem()
        Me.MenuItem78 = New System.Windows.Forms.MenuItem()
        Me.MenuItem153 = New System.Windows.Forms.MenuItem()
        Me.MenuItem176 = New System.Windows.Forms.MenuItem()
        Me.MenuItem178 = New System.Windows.Forms.MenuItem()
        Me.MenuItem188 = New System.Windows.Forms.MenuItem()
        Me.MenuOperaciones = New System.Windows.Forms.MenuItem()
        Me.MenuItemVentas = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_Facturacion = New System.Windows.Forms.MenuItem()
        Me.MenuItem112 = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_Proformas = New System.Windows.Forms.MenuItem()
        Me.MenuItem113 = New System.Windows.Forms.MenuItem()
        Me.MenuItem108 = New System.Windows.Forms.MenuItem()
        Me.MenuItem114 = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_DevolucionesVentas = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem70 = New System.Windows.Forms.MenuItem()
        Me.MenuItem86 = New System.Windows.Forms.MenuItem()
        Me.MenuItem87 = New System.Windows.Forms.MenuItem()
        Me.MenuItem88 = New System.Windows.Forms.MenuItem()
        Me.MenuItem89 = New System.Windows.Forms.MenuItem()
        Me.MenuItem90 = New System.Windows.Forms.MenuItem()
        Me.mnMovimientoArticulo = New System.Windows.Forms.MenuItem()
        Me.mnProveedores = New System.Windows.Forms.MenuItem()
        Me.MenuItem120 = New System.Windows.Forms.MenuItem()
        Me.MenuItem121 = New System.Windows.Forms.MenuItem()
        Me.MenuItem118 = New System.Windows.Forms.MenuItem()
        Me.MenuItem127 = New System.Windows.Forms.MenuItem()
        Me.MenuItem129 = New System.Windows.Forms.MenuItem()
        Me.MenuItem128 = New System.Windows.Forms.MenuItem()
        Me.MenuItem130 = New System.Windows.Forms.MenuItem()
        Me.MenuItem131 = New System.Windows.Forms.MenuItem()
        Me.MenuItem132 = New System.Windows.Forms.MenuItem()
        Me.MenuItem151 = New System.Windows.Forms.MenuItem()
        Me.MenuItem154 = New System.Windows.Forms.MenuItem()
        Me.MenuItem155 = New System.Windows.Forms.MenuItem()
        Me.MenuItem156 = New System.Windows.Forms.MenuItem()
        Me.MenuItem157 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea01 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCuentasXCobrar = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_AbonosCXC = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_AjustesCXC = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_EstadoCuentaCXC = New System.Windows.Forms.MenuItem()
        Me.MenuItem122 = New System.Windows.Forms.MenuItem()
        Me.MenuItem107 = New System.Windows.Forms.MenuItem()
        Me.MenuItem149 = New System.Windows.Forms.MenuItem()
        Me.MenuItem192 = New System.Windows.Forms.MenuItem()
        Me.MenuItem185 = New System.Windows.Forms.MenuItem()
        Me.MenuItem186 = New System.Windows.Forms.MenuItem()
        Me.MenuItem187 = New System.Windows.Forms.MenuItem()
        Me.MenuItem189 = New System.Windows.Forms.MenuItem()
        Me.MenuItem190 = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea02 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCompras = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_ComprasProveedor = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_OrdenCompraManual = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_OrdenCompraAutomatica = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_DevolucionesProveedor = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem181 = New System.Windows.Forms.MenuItem()
        Me.MenuItem182 = New System.Windows.Forms.MenuItem()
        Me.MenuItem183 = New System.Windows.Forms.MenuItem()
        Me.MenuItem184 = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea03 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCuentasXPagar = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_AbonosCuentaProveedor = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_AjusteCuentaProveedor = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_EstadoCuentaProveedor = New System.Windows.Forms.MenuItem()
        Me.MenuItem148 = New System.Windows.Forms.MenuItem()
        Me.MenuItem171 = New System.Windows.Forms.MenuItem()
        Me.MenuItem169 = New System.Windows.Forms.MenuItem()
        Me.MenuItem170 = New System.Windows.Forms.MenuItem()
        Me.MenuItem172 = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea04 = New System.Windows.Forms.MenuItem()
        Me.MenuItemControlCaja = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_Caja_Apertura = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_Caja_Arqueo = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_Caja_Cierre = New System.Windows.Forms.MenuItem()
        Me.MenuItem147 = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_Caja_OpcionesPago = New System.Windows.Forms.MenuItem()
        Me.MenuItemOperacion_Caja_Movimientos = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem105 = New System.Windows.Forms.MenuItem()
        Me.mnVentasPendientes = New System.Windows.Forms.MenuItem()
        Me.MenuItem82 = New System.Windows.Forms.MenuItem()
        Me.mnPrestamosBodega = New System.Windows.Forms.MenuItem()
        Me.mnEmpresaPrestamos = New System.Windows.Forms.MenuItem()
        Me.MenuItem165 = New System.Windows.Forms.MenuItem()
        Me.MenuItem161 = New System.Windows.Forms.MenuItem()
        Me.MenuItem164 = New System.Windows.Forms.MenuItem()
        Me.mnPrestamos = New System.Windows.Forms.MenuItem()
        Me.MenuItem162 = New System.Windows.Forms.MenuItem()
        Me.MenuItem163 = New System.Windows.Forms.MenuItem()
        Me.MenuItem110 = New System.Windows.Forms.MenuItem()
        Me.MenuItem116 = New System.Windows.Forms.MenuItem()
        Me.MenuItem84 = New System.Windows.Forms.MenuItem()
        Me.mnReportePrestamos = New System.Windows.Forms.MenuItem()
        Me.MenuItem99 = New System.Windows.Forms.MenuItem()
        Me.MenuItem100 = New System.Windows.Forms.MenuItem()
        Me.MenuItem101 = New System.Windows.Forms.MenuItem()
        Me.MenuItem102 = New System.Windows.Forms.MenuItem()
        Me.MenuItem115 = New System.Windows.Forms.MenuItem()
        Me.MenuItem109 = New System.Windows.Forms.MenuItem()
        Me.MenuItem103 = New System.Windows.Forms.MenuItem()
        Me.MenuItem104 = New System.Windows.Forms.MenuItem()
        Me.MenuItem133 = New System.Windows.Forms.MenuItem()
        Me.MenuItem134 = New System.Windows.Forms.MenuItem()
        Me.MenuItem138 = New System.Windows.Forms.MenuItem()
        Me.MenuItem139 = New System.Windows.Forms.MenuItem()
        Me.MenuItem140 = New System.Windows.Forms.MenuItem()
        Me.MenuItem141 = New System.Windows.Forms.MenuItem()
        Me.MenuItem143 = New System.Windows.Forms.MenuItem()
        Me.MenuItem144 = New System.Windows.Forms.MenuItem()
        Me.MenuItem145 = New System.Windows.Forms.MenuItem()
        Me.MenuItem146 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem67 = New System.Windows.Forms.MenuItem()
        Me.MenuInventarios = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Catalogo = New System.Windows.Forms.MenuItem()
        Me.MenuItem72 = New System.Windows.Forms.MenuItem()
        Me.MenuItem73 = New System.Windows.Forms.MenuItem()
        Me.MenuItem71 = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Familias = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Ubicaciones = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Presentaciones = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Marcas = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Ajustes = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Etiquetas = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Aumentos_X_Categoria = New System.Windows.Forms.MenuItem()
        Me.MenuItemRedondeo = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea05 = New System.Windows.Forms.MenuItem()
        Me.MenuItemControlBodega = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea06 = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Bodegas = New System.Windows.Forms.MenuItem()
        Me.MenuItemInventario_Ajuste_Bodegas = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem160 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem75 = New System.Windows.Forms.MenuItem()
        Me.MenuItem76 = New System.Windows.Forms.MenuItem()
        Me.MenuItem95 = New System.Windows.Forms.MenuItem()
        Me.MenuItem96 = New System.Windows.Forms.MenuItem()
        Me.MenuItem97 = New System.Windows.Forms.MenuItem()
        Me.MenuItem123 = New System.Windows.Forms.MenuItem()
        Me.MenuItem124 = New System.Windows.Forms.MenuItem()
        Me.MenuItem152 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem168 = New System.Windows.Forms.MenuItem()
        Me.MenuItem191 = New System.Windows.Forms.MenuItem()
        Me.MenuReportes = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteVentas = New System.Windows.Forms.MenuItem()
        Me.mnuReporteVentas = New System.Windows.Forms.MenuItem()
        Me.mnuReporteGeneraeIndividualVentas = New System.Windows.Forms.MenuItem()
        Me.mnuReporteArticulosCompradosCliente = New System.Windows.Forms.MenuItem()
        Me.mnuReporteTopCliente = New System.Windows.Forms.MenuItem()
        Me.mnuReporteVentasUnificado = New System.Windows.Forms.MenuItem()
        Me.mnuReporteClientesmasCompran = New System.Windows.Forms.MenuItem()
        Me.MenuItem74 = New System.Windows.Forms.MenuItem()
        Me.mnuReporteUtilidad = New System.Windows.Forms.MenuItem()
        Me.MenuItem93 = New System.Windows.Forms.MenuItem()
        Me.mnuReporteDescuentosProveedor = New System.Windows.Forms.MenuItem()
        Me.mnuReporteUtilidadArticulos = New System.Windows.Forms.MenuItem()
        Me.mnuReporteD151Proveedores = New System.Windows.Forms.MenuItem()
        Me.mnuReporteD151Clientes = New System.Windows.Forms.MenuItem()
        Me.mnuReportePanelControl = New System.Windows.Forms.MenuItem()
        Me.MenuItem135 = New System.Windows.Forms.MenuItem()
        Me.mnuReporteUtilidadFactura = New System.Windows.Forms.MenuItem()
        Me.mnuReporteUtilidadFechas = New System.Windows.Forms.MenuItem()
        Me.mnuReportePorcentajeVenta = New System.Windows.Forms.MenuItem()
        Me.mnuReporteCierreCaja = New System.Windows.Forms.MenuItem()
        Me.MenuItem166 = New System.Windows.Forms.MenuItem()
        Me.mnuReporteSinCabys = New System.Windows.Forms.MenuItem()
        Me.mnuReporteMovimientoporArticulo = New System.Windows.Forms.MenuItem()
        Me.mnuReporteCreditoRecuperacion = New System.Windows.Forms.MenuItem()
        Me.mnuReporteDevolucionDetallado = New System.Windows.Forms.MenuItem()
        Me.mnuReporteGraficoVentasAnuales = New System.Windows.Forms.MenuItem()
        Me.mnuReporteCrecimientoCompras = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteCompras = New System.Windows.Forms.MenuItem()
        Me.MenuItem174 = New System.Windows.Forms.MenuItem()
        Me.MenuItem142 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteABON_CRE_NDEB = New System.Windows.Forms.MenuItem()
        Me.MenuItemReportesCXP = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea07 = New System.Windows.Forms.MenuItem()
        Me.MenuItemMovimiento = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporte_Kardex = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporte_Inventario = New System.Windows.Forms.MenuItem()
        Me.MenuItem69 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem68 = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteABC = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem158 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea09 = New System.Windows.Forms.MenuItem()
        Me.MenuItem66 = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteClientes = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteProveedores = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteGerencial = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteCajas = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem91 = New System.Windows.Forms.MenuItem()
        Me.MenuItem98 = New System.Windows.Forms.MenuItem()
        Me.MenuItem119 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.mnPeces = New System.Windows.Forms.MenuItem()
        Me.mnClinica = New System.Windows.Forms.MenuItem()
        Me.mnReportePeces = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.mnTaller = New System.Windows.Forms.MenuItem()
        Me.mnArmamento = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.mnTienda = New System.Windows.Forms.MenuItem()
        Me.mnMaquinaria = New System.Windows.Forms.MenuItem()
        Me.mnProductosOrganicos = New System.Windows.Forms.MenuItem()
        Me.MenuItem85 = New System.Windows.Forms.MenuItem()
        Me.MenuInterfaz = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItemAyuda = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea10 = New System.Windows.Forms.MenuItem()
        Me.MenuItemMaximizar = New System.Windows.Forms.MenuItem()
        Me.MenuItemNormal = New System.Windows.Forms.MenuItem()
        Me.MenuItemMinimizar = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea11 = New System.Windows.Forms.MenuItem()
        Me.MenuItemSeguridad = New System.Windows.Forms.MenuItem()
        Me.MenuItemPerfilUsuarios = New System.Windows.Forms.MenuItem()
        Me.MenuItemCambioUsuarios = New System.Windows.Forms.MenuItem()
        Me.MenuItemRegistroUsuarios = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItemRespaldos = New System.Windows.Forms.MenuItem()
        Me.MenuItemActivarPOS = New System.Windows.Forms.MenuItem()
        Me.MenuItem = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItemFullScreenPVE = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea12 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCalculadora = New System.Windows.Forms.MenuItem()
        Me.MenuItemLinea13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCerrar = New System.Windows.Forms.MenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        Me.sbpTCCompra = New System.Windows.Forms.StatusBarPanel()
        Me.sbpTCVenta = New System.Windows.Forms.StatusBarPanel()
        Me.sbpVersion = New System.Windows.Forms.StatusBarPanel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.menuExtender = New MenuExtender.MenuExtender(Me.components)
        Me.menu_icons = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList4 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnInventario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProveedores = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClientesCredito = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCompras = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnFacturacion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPuntoVenta = New System.Windows.Forms.ToolStripButton()
        Me.lblempresa = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNegativo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCambio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAlbaran = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TimerSolicitudes = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxFondo = New System.Windows.Forms.PictureBox()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpTCCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpTCVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbpVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuAdministracion, Me.MenuOperaciones, Me.MenuInventarios, Me.MenuReportes, Me.MenuInterfaz})
        '
        'MenuAdministracion
        '
        Me.MenuAdministracion.Enabled = False
        Me.MenuAdministracion.Index = 0
        Me.MenuAdministracion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemAdministracion_Clientes, Me.MenuItem83, Me.MenuItem92, Me.MenuItemAdministracion_Proveedores, Me.MenuItemAdministracion_Moneda, Me.MenuItemAdministracion_Tarjetas, Me.MenuItemAdministracion_ConfiguracionMoneda, Me.MenuItem20, Me.MenuItem62, Me.MenuItem61, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65, Me.MenuItemAdministracion_ConfiguracionSistema, Me.MenuItem80, Me.MenuItem79, Me.MenuItem153, Me.MenuItem176, Me.MenuItem178, Me.MenuItem188})
        Me.MenuAdministracion.Text = "Administración"
        '
        'MenuItemAdministracion_Clientes
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemAdministracion_Clientes, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemAdministracion_Clientes, 10)
        Me.MenuItemAdministracion_Clientes.Index = 0
        Me.MenuItemAdministracion_Clientes.OwnerDraw = True
        Me.MenuItemAdministracion_Clientes.Text = "Registro de Clientes"
        '
        'MenuItem83
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem83, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem83, -1)
        Me.MenuItem83.Index = 1
        Me.MenuItem83.OwnerDraw = True
        Me.MenuItem83.Text = "Carta Exoneracion"
        '
        'MenuItem92
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem92, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem92, -1)
        Me.MenuItem92.Index = 2
        Me.MenuItem92.OwnerDraw = True
        Me.MenuItem92.Text = "Descuentos por Casas Comerciales"
        '
        'MenuItemAdministracion_Proveedores
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemAdministracion_Proveedores, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemAdministracion_Proveedores, 12)
        Me.MenuItemAdministracion_Proveedores.Index = 3
        Me.MenuItemAdministracion_Proveedores.OwnerDraw = True
        Me.MenuItemAdministracion_Proveedores.Text = "Registro de Proveedores"
        '
        'MenuItemAdministracion_Moneda
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemAdministracion_Moneda, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemAdministracion_Moneda, 9)
        Me.MenuItemAdministracion_Moneda.Index = 4
        Me.MenuItemAdministracion_Moneda.OwnerDraw = True
        Me.MenuItemAdministracion_Moneda.Text = "Registro de Moneda"
        '
        'MenuItemAdministracion_Tarjetas
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemAdministracion_Tarjetas, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemAdministracion_Tarjetas, 8)
        Me.MenuItemAdministracion_Tarjetas.Index = 5
        Me.MenuItemAdministracion_Tarjetas.OwnerDraw = True
        Me.MenuItemAdministracion_Tarjetas.Text = "Operadores de Tarjeta"
        '
        'MenuItemAdministracion_ConfiguracionMoneda
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemAdministracion_ConfiguracionMoneda, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemAdministracion_ConfiguracionMoneda, 9)
        Me.MenuItemAdministracion_ConfiguracionMoneda.Index = 6
        Me.MenuItemAdministracion_ConfiguracionMoneda.OwnerDraw = True
        Me.MenuItemAdministracion_ConfiguracionMoneda.Text = "Configuración Moneda"
        '
        'MenuItem20
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem20, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem20, 2)
        Me.MenuItem20.Index = 7
        Me.MenuItem20.OwnerDraw = True
        Me.MenuItem20.Text = "Registro de Clientes frecuentes"
        '
        'MenuItem62
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem62, -1)
        Me.MenuItem62.Index = 8
        Me.MenuItem62.Text = "-"
        '
        'MenuItem61
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem61, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem61, 7)
        Me.MenuItem61.Index = 9
        Me.MenuItem61.OwnerDraw = True
        Me.MenuItem61.Text = "Empleados"
        '
        'MenuItem63
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem63, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem63, 6)
        Me.MenuItem63.Index = 10
        Me.MenuItem63.OwnerDraw = True
        Me.MenuItem63.Text = "Acciones"
        '
        'MenuItem64
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem64, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem64, 5)
        Me.MenuItem64.Index = 11
        Me.MenuItem64.OwnerDraw = True
        Me.MenuItem64.Text = "Categorias de acción"
        '
        'MenuItem65
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem65, -1)
        Me.MenuItem65.Index = 12
        Me.MenuItem65.Text = "-"
        '
        'MenuItemAdministracion_ConfiguracionSistema
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemAdministracion_ConfiguracionSistema, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemAdministracion_ConfiguracionSistema, 11)
        Me.MenuItemAdministracion_ConfiguracionSistema.Index = 13
        Me.MenuItemAdministracion_ConfiguracionSistema.OwnerDraw = True
        Me.MenuItemAdministracion_ConfiguracionSistema.Text = "Configuración Sistema"
        '
        'MenuItem80
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem80, -1)
        Me.MenuItem80.Index = 14
        Me.MenuItem80.Text = "-"
        '
        'MenuItem79
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem79, -1)
        Me.MenuItem79.Index = 15
        Me.MenuItem79.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem81, Me.MenuItem117, Me.MenuItem77, Me.MenuItem78})
        Me.MenuItem79.Text = "Comprobantes Electronicos"
        '
        'MenuItem81
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem81, -1)
        Me.MenuItem81.Index = 0
        Me.MenuItem81.Text = "Mensaje Receptor"
        '
        'MenuItem117
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem117, -1)
        Me.MenuItem117.Index = 1
        Me.MenuItem117.Text = "Consulta Comprobantes Receptor"
        '
        'MenuItem77
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem77, -1)
        Me.MenuItem77.Index = 2
        Me.MenuItem77.Text = "-"
        '
        'MenuItem78
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem78, -1)
        Me.MenuItem78.Index = 3
        Me.MenuItem78.Text = "Reenvio de Correos"
        '
        'MenuItem153
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem153, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem153, -1)
        Me.MenuItem153.Index = 16
        Me.MenuItem153.OwnerDraw = True
        Me.MenuItem153.Text = "Asignar Fichas por Usuario"
        '
        'MenuItem176
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem176, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem176, -1)
        Me.MenuItem176.Index = 17
        Me.MenuItem176.OwnerDraw = True
        Me.MenuItem176.Text = "No MAG"
        '
        'MenuItem178
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem178, -1)
        Me.MenuItem178.Index = 18
        Me.MenuItem178.Text = "Tipo Cambio Compra"
        '
        'MenuItem188
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem188, -1)
        Me.MenuItem188.Index = 19
        Me.MenuItem188.Text = "Condiciones uso Firmado Contado"
        '
        'MenuOperaciones
        '
        Me.MenuOperaciones.Index = 1
        Me.MenuOperaciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemVentas, Me.MenuItemLinea01, Me.MenuItemCuentasXCobrar, Me.MenuItemLinea02, Me.MenuItemCompras, Me.MenuItemLinea03, Me.MenuItemCuentasXPagar, Me.MenuItemLinea04, Me.MenuItemControlCaja, Me.MenuItem82, Me.mnPrestamosBodega, Me.MenuItem99, Me.MenuItem100, Me.MenuItem115, Me.MenuItem109, Me.MenuItem103, Me.MenuItem104, Me.MenuItem133, Me.MenuItem134, Me.MenuItem138, Me.MenuItem139, Me.MenuItem42})
        Me.MenuOperaciones.Text = "Operaciones"
        '
        'MenuItemVentas
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemVentas, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemVentas, -1)
        Me.MenuItemVentas.Index = 0
        Me.MenuItemVentas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemOperacion_Facturacion, Me.MenuItem112, Me.MenuItemOperacion_Proformas, Me.MenuItem113, Me.MenuItem108, Me.MenuItem114, Me.MenuItemOperacion_DevolucionesVentas, Me.MenuItem11, Me.MenuItem27, Me.MenuItem70, Me.MenuItem86, Me.MenuItem87, Me.MenuItem88, Me.mnMovimientoArticulo, Me.mnProveedores, Me.MenuItem120, Me.MenuItem121, Me.MenuItem118, Me.MenuItem127, Me.MenuItem130, Me.MenuItem131, Me.MenuItem132, Me.MenuItem151, Me.MenuItem154, Me.MenuItem155, Me.MenuItem35})
        Me.MenuItemVentas.OwnerDraw = True
        Me.MenuItemVentas.Text = "Ventas"
        '
        'MenuItemOperacion_Facturacion
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemOperacion_Facturacion, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_Facturacion, -1)
        Me.MenuItemOperacion_Facturacion.Index = 0
        Me.MenuItemOperacion_Facturacion.OwnerDraw = True
        Me.MenuItemOperacion_Facturacion.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItemOperacion_Facturacion.Text = "Facturación"
        '
        'MenuItem112
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem112, -1)
        Me.MenuItem112.Index = 1
        Me.MenuItem112.Text = "-"
        '
        'MenuItemOperacion_Proformas
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemOperacion_Proformas, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_Proformas, -1)
        Me.MenuItemOperacion_Proformas.Index = 2
        Me.MenuItemOperacion_Proformas.OwnerDraw = True
        Me.MenuItemOperacion_Proformas.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItemOperacion_Proformas.Text = "Proformas o Cotización"
        '
        'MenuItem113
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem113, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem113, -1)
        Me.MenuItem113.Index = 3
        Me.MenuItem113.OwnerDraw = True
        Me.MenuItem113.Text = "Segimiento Cotizaciones"
        '
        'MenuItem108
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem108, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem108, -1)
        Me.MenuItem108.Index = 4
        Me.MenuItem108.OwnerDraw = True
        Me.MenuItem108.Text = "Promociones Activas"
        '
        'MenuItem114
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem114, -1)
        Me.MenuItem114.Index = 5
        Me.MenuItem114.Text = "-"
        '
        'MenuItemOperacion_DevolucionesVentas
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemOperacion_DevolucionesVentas, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_DevolucionesVentas, -1)
        Me.MenuItemOperacion_DevolucionesVentas.Index = 6
        Me.MenuItemOperacion_DevolucionesVentas.OwnerDraw = True
        Me.MenuItemOperacion_DevolucionesVentas.Text = "Devoluciones"
        '
        'MenuItem11
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem11, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem11, -1)
        Me.MenuItem11.Index = 7
        Me.MenuItem11.OwnerDraw = True
        Me.MenuItem11.Text = "Cambiar Caja Factura"
        '
        'MenuItem27
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem27, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem27, -1)
        Me.MenuItem27.Index = 8
        Me.MenuItem27.OwnerDraw = True
        Me.MenuItem27.Text = "Agentes de ventas"
        '
        'MenuItem70
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem70, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem70, -1)
        Me.MenuItem70.Index = 9
        Me.MenuItem70.OwnerDraw = True
        Me.MenuItem70.Text = "Buscar Producto cotizado por cliente"
        '
        'MenuItem86
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem86, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem86, -1)
        Me.MenuItem86.Index = 10
        Me.MenuItem86.OwnerDraw = True
        Me.MenuItem86.Text = "Reporte de Kardex"
        '
        'MenuItem87
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem87, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem87, -1)
        Me.MenuItem87.Index = 11
        Me.MenuItem87.OwnerDraw = True
        Me.MenuItem87.Text = "Convierte de Sacos a Kilos"
        '
        'MenuItem88
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem88, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem88, -1)
        Me.MenuItem88.Index = 12
        Me.MenuItem88.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem89, Me.MenuItem90})
        Me.MenuItem88.OwnerDraw = True
        Me.MenuItem88.Text = "Pedidos de Bodega"
        '
        'MenuItem89
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem89, -1)
        Me.MenuItem89.Index = 0
        Me.MenuItem89.Text = "Nuevo Pedido"
        '
        'MenuItem90
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem90, -1)
        Me.MenuItem90.Index = 1
        Me.MenuItem90.Text = "Consultar Pedidos"
        '
        'mnMovimientoArticulo
        '
        Me.menuExtender.SetExtEnable(Me.mnMovimientoArticulo, True)
        Me.menuExtender.SetImageIndex(Me.mnMovimientoArticulo, -1)
        Me.mnMovimientoArticulo.Index = 13
        Me.mnMovimientoArticulo.OwnerDraw = True
        Me.mnMovimientoArticulo.Text = "Movimientos de Articulos"
        '
        'mnProveedores
        '
        Me.menuExtender.SetExtEnable(Me.mnProveedores, True)
        Me.menuExtender.SetImageIndex(Me.mnProveedores, -1)
        Me.mnProveedores.Index = 14
        Me.mnProveedores.OwnerDraw = True
        Me.mnProveedores.Text = "Proveedores"
        '
        'MenuItem120
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem120, -1)
        Me.MenuItem120.Index = 15
        Me.MenuItem120.Text = "-"
        '
        'MenuItem121
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem121, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem121, -1)
        Me.MenuItem121.Index = 16
        Me.MenuItem121.OwnerDraw = True
        Me.MenuItem121.Text = "Solicitudes Bodega"
        '
        'MenuItem118
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem118, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem118, -1)
        Me.MenuItem118.Index = 17
        Me.MenuItem118.OwnerDraw = True
        Me.MenuItem118.Text = "Aplicar Cambios"
        '
        'MenuItem127
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem127, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem127, -1)
        Me.MenuItem127.Index = 18
        Me.MenuItem127.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem129, Me.MenuItem128})
        Me.MenuItem127.OwnerDraw = True
        Me.MenuItem127.Text = "Puntos"
        '
        'MenuItem129
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem129, -1)
        Me.MenuItem129.Index = 0
        Me.MenuItem129.Text = "Puntos Acumulados"
        '
        'MenuItem128
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem128, -1)
        Me.MenuItem128.Index = 1
        Me.MenuItem128.Text = "Puntos por Productos"
        '
        'MenuItem130
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem130, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem130, -1)
        Me.MenuItem130.Index = 19
        Me.MenuItem130.OwnerDraw = True
        Me.MenuItem130.Text = "Cupones de Descuento"
        '
        'MenuItem131
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem131, -1)
        Me.MenuItem131.Index = 20
        Me.MenuItem131.Text = "-"
        '
        'MenuItem132
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem132, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem132, -1)
        Me.MenuItem132.Index = 21
        Me.MenuItem132.OwnerDraw = True
        Me.MenuItem132.Text = "Facturas Remplazadas"
        '
        'MenuItem151
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem151, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem151, -1)
        Me.MenuItem151.Index = 22
        Me.MenuItem151.OwnerDraw = True
        Me.MenuItem151.Text = "Solicitud de Pedido"
        '
        'MenuItem154
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem154, -1)
        Me.MenuItem154.Index = 23
        Me.MenuItem154.Text = "-"
        '
        'MenuItem155
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem155, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem155, -1)
        Me.MenuItem155.Index = 24
        Me.MenuItem155.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem156, Me.MenuItem157})
        Me.MenuItem155.OwnerDraw = True
        Me.MenuItem155.Text = "Historial Serie"
        '
        'MenuItem156
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem156, -1)
        Me.MenuItem156.Index = 0
        Me.MenuItem156.Text = "Agregar Historial"
        '
        'MenuItem157
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem157, -1)
        Me.MenuItem157.Index = 1
        Me.MenuItem157.Text = "Ver Historial"
        '
        'MenuItem35
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem35, -1)
        Me.MenuItem35.Index = 25
        Me.MenuItem35.Text = "Albaranes"
        '
        'MenuItemLinea01
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea01, -1)
        Me.MenuItemLinea01.Index = 1
        Me.MenuItemLinea01.Text = "-"
        '
        'MenuItemCuentasXCobrar
        '
        Me.MenuItemCuentasXCobrar.Enabled = False
        Me.menuExtender.SetExtEnable(Me.MenuItemCuentasXCobrar, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemCuentasXCobrar, -1)
        Me.MenuItemCuentasXCobrar.Index = 2
        Me.MenuItemCuentasXCobrar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemOperacion_AbonosCXC, Me.MenuItemOperacion_AjustesCXC, Me.MenuItemOperacion_EstadoCuentaCXC, Me.MenuItem122, Me.MenuItem107, Me.MenuItem149, Me.MenuItem192, Me.MenuItem185, Me.MenuItem186, Me.MenuItem189, Me.MenuItem190})
        Me.MenuItemCuentasXCobrar.OwnerDraw = True
        Me.MenuItemCuentasXCobrar.Text = "Cuentas x Cobrar"
        '
        'MenuItemOperacion_AbonosCXC
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_AbonosCXC, -1)
        Me.MenuItemOperacion_AbonosCXC.Index = 0
        Me.MenuItemOperacion_AbonosCXC.Text = "Abonos a Facturas"
        '
        'MenuItemOperacion_AjustesCXC
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_AjustesCXC, -1)
        Me.MenuItemOperacion_AjustesCXC.Index = 1
        Me.MenuItemOperacion_AjustesCXC.Text = "Ajustes de Cuenta"
        '
        'MenuItemOperacion_EstadoCuentaCXC
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_EstadoCuentaCXC, -1)
        Me.MenuItemOperacion_EstadoCuentaCXC.Index = 2
        Me.MenuItemOperacion_EstadoCuentaCXC.Text = "Estados de  Cuenta"
        '
        'MenuItem122
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem122, -1)
        Me.MenuItem122.Index = 3
        Me.MenuItem122.Text = "Estado de Cuenta Firmado Contado"
        '
        'MenuItem107
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem107, -1)
        Me.MenuItem107.Index = 4
        Me.MenuItem107.Text = "Facturas Archivadas"
        '
        'MenuItem149
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem149, -1)
        Me.MenuItem149.Index = 5
        Me.MenuItem149.Text = "Proximas a Vencer"
        '
        'MenuItem192
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem192, -1)
        Me.MenuItem192.Index = 6
        Me.MenuItem192.Text = "Vencen en X Meses"
        '
        'MenuItem185
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem185, -1)
        Me.MenuItem185.Index = 7
        Me.MenuItem185.Text = "-"
        '
        'MenuItem186
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem186, -1)
        Me.MenuItem186.Index = 8
        Me.MenuItem186.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem187})
        Me.MenuItem186.Text = "Gestion de Cobro"
        '
        'MenuItem187
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem187, -1)
        Me.MenuItem187.Index = 0
        Me.MenuItem187.Text = "Gestion de Cobro"
        '
        'MenuItem189
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem189, -1)
        Me.MenuItem189.Index = 9
        Me.MenuItem189.Text = "Reporte Abonos Incobrables"
        '
        'MenuItem190
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem190, -1)
        Me.MenuItem190.Index = 10
        Me.MenuItem190.Text = "Enviar a Incobrables"
        '
        'MenuItemLinea02
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea02, -1)
        Me.MenuItemLinea02.Index = 3
        Me.MenuItemLinea02.Text = "-"
        '
        'MenuItemCompras
        '
        Me.MenuItemCompras.Enabled = False
        Me.menuExtender.SetExtEnable(Me.MenuItemCompras, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemCompras, -1)
        Me.MenuItemCompras.Index = 4
        Me.MenuItemCompras.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemOperacion_ComprasProveedor, Me.MenuItemOperacion_OrdenCompraManual, Me.MenuItemOperacion_OrdenCompraAutomatica, Me.MenuItemOperacion_DevolucionesProveedor, Me.MenuItem1, Me.MenuItem181})
        Me.MenuItemCompras.OwnerDraw = True
        Me.MenuItemCompras.Text = "Compras"
        '
        'MenuItemOperacion_ComprasProveedor
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_ComprasProveedor, -1)
        Me.MenuItemOperacion_ComprasProveedor.Index = 0
        Me.MenuItemOperacion_ComprasProveedor.Shortcut = System.Windows.Forms.Shortcut.CtrlM
        Me.MenuItemOperacion_ComprasProveedor.Text = "Factura de Compras"
        '
        'MenuItemOperacion_OrdenCompraManual
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_OrdenCompraManual, -1)
        Me.MenuItemOperacion_OrdenCompraManual.Index = 1
        Me.MenuItemOperacion_OrdenCompraManual.Text = "Ordenes de Compra Manual"
        '
        'MenuItemOperacion_OrdenCompraAutomatica
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_OrdenCompraAutomatica, -1)
        Me.MenuItemOperacion_OrdenCompraAutomatica.Index = 2
        Me.MenuItemOperacion_OrdenCompraAutomatica.Text = "Ordenes de Compra Automática"
        '
        'MenuItemOperacion_DevolucionesProveedor
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_DevolucionesProveedor, -1)
        Me.MenuItemOperacion_DevolucionesProveedor.Index = 3
        Me.MenuItemOperacion_DevolucionesProveedor.Text = "Devoluciones de Compra"
        '
        'MenuItem1
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem1, -1)
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "Gastos"
        '
        'MenuItem181
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem181, -1)
        Me.MenuItem181.Index = 5
        Me.MenuItem181.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem182, Me.MenuItem183, Me.MenuItem184})
        Me.MenuItem181.Text = "Metas"
        '
        'MenuItem182
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem182, -1)
        Me.MenuItem182.Index = 0
        Me.MenuItem182.Text = "Registro de Metas"
        '
        'MenuItem183
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem183, -1)
        Me.MenuItem183.Index = 1
        Me.MenuItem183.Text = "-"
        '
        'MenuItem184
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem184, -1)
        Me.MenuItem184.Index = 2
        Me.MenuItem184.Text = "Reportes de Metas General"
        '
        'MenuItemLinea03
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea03, -1)
        Me.MenuItemLinea03.Index = 5
        Me.MenuItemLinea03.Text = "-"
        '
        'MenuItemCuentasXPagar
        '
        Me.MenuItemCuentasXPagar.Enabled = False
        Me.menuExtender.SetExtEnable(Me.MenuItemCuentasXPagar, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemCuentasXPagar, -1)
        Me.MenuItemCuentasXPagar.Index = 6
        Me.MenuItemCuentasXPagar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemOperacion_AbonosCuentaProveedor, Me.MenuItemOperacion_AjusteCuentaProveedor, Me.MenuItemOperacion_EstadoCuentaProveedor, Me.MenuItem148, Me.MenuItem171, Me.MenuItem169, Me.MenuItem170, Me.MenuItem172})
        Me.MenuItemCuentasXPagar.OwnerDraw = True
        Me.MenuItemCuentasXPagar.Text = "Cuentas  x Pagar"
        '
        'MenuItemOperacion_AbonosCuentaProveedor
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_AbonosCuentaProveedor, -1)
        Me.MenuItemOperacion_AbonosCuentaProveedor.Index = 0
        Me.MenuItemOperacion_AbonosCuentaProveedor.Text = "Abonos a Cuenta"
        '
        'MenuItemOperacion_AjusteCuentaProveedor
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_AjusteCuentaProveedor, -1)
        Me.MenuItemOperacion_AjusteCuentaProveedor.Index = 1
        Me.MenuItemOperacion_AjusteCuentaProveedor.Text = "Ajustes a Cuenta"
        '
        'MenuItemOperacion_EstadoCuentaProveedor
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_EstadoCuentaProveedor, -1)
        Me.MenuItemOperacion_EstadoCuentaProveedor.Index = 2
        Me.MenuItemOperacion_EstadoCuentaProveedor.Text = "Estado de Cuenta"
        '
        'MenuItem148
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem148, -1)
        Me.MenuItem148.Index = 3
        Me.MenuItem148.Text = "Proximas a Vencer"
        '
        'MenuItem171
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem171, -1)
        Me.MenuItem171.Index = 4
        Me.MenuItem171.Text = "-"
        '
        'MenuItem169
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem169, -1)
        Me.MenuItem169.Index = 5
        Me.MenuItem169.Text = "Pagos"
        '
        'MenuItem170
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem170, -1)
        Me.MenuItem170.Index = 6
        Me.MenuItem170.Text = "Pagos sin Aplicar"
        '
        'MenuItem172
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem172, -1)
        Me.MenuItem172.Index = 7
        Me.MenuItem172.Text = "-"
        '
        'MenuItemLinea04
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea04, -1)
        Me.MenuItemLinea04.Index = 7
        Me.MenuItemLinea04.Text = "-"
        '
        'MenuItemControlCaja
        '
        Me.MenuItemControlCaja.Enabled = False
        Me.menuExtender.SetExtEnable(Me.MenuItemControlCaja, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemControlCaja, -1)
        Me.MenuItemControlCaja.Index = 8
        Me.MenuItemControlCaja.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemOperacion_Caja_Apertura, Me.MenuItemOperacion_Caja_Arqueo, Me.MenuItemOperacion_Caja_Cierre, Me.MenuItem147, Me.MenuItemOperacion_Caja_OpcionesPago, Me.MenuItemOperacion_Caja_Movimientos, Me.MenuItem12, Me.MenuItem59, Me.MenuItem58, Me.MenuItem105, Me.mnVentasPendientes})
        Me.MenuItemControlCaja.OwnerDraw = True
        Me.MenuItemControlCaja.Text = "Control de Caja"
        '
        'MenuItemOperacion_Caja_Apertura
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_Caja_Apertura, -1)
        Me.MenuItemOperacion_Caja_Apertura.Index = 0
        Me.MenuItemOperacion_Caja_Apertura.Text = "Apertura de Caja"
        '
        'MenuItemOperacion_Caja_Arqueo
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_Caja_Arqueo, -1)
        Me.MenuItemOperacion_Caja_Arqueo.Index = 1
        Me.MenuItemOperacion_Caja_Arqueo.Text = "Arqueo de Caja"
        '
        'MenuItemOperacion_Caja_Cierre
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_Caja_Cierre, -1)
        Me.MenuItemOperacion_Caja_Cierre.Index = 2
        Me.MenuItemOperacion_Caja_Cierre.Text = "Cierre de Caja"
        '
        'MenuItem147
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem147, -1)
        Me.MenuItem147.Index = 3
        Me.MenuItem147.Text = "Editar Depositos"
        '
        'MenuItemOperacion_Caja_OpcionesPago
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_Caja_OpcionesPago, -1)
        Me.MenuItemOperacion_Caja_OpcionesPago.Index = 4
        Me.MenuItemOperacion_Caja_OpcionesPago.Text = "Opciones de Pago"
        '
        'MenuItemOperacion_Caja_Movimientos
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemOperacion_Caja_Movimientos, -1)
        Me.MenuItemOperacion_Caja_Movimientos.Index = 5
        Me.MenuItemOperacion_Caja_Movimientos.Text = "Movimiento de Caja"
        '
        'MenuItem12
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem12, -1)
        Me.MenuItem12.Index = 6
        Me.MenuItem12.Text = "Bloqueo Caja"
        '
        'MenuItem59
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem59, -1)
        Me.MenuItem59.Index = 7
        Me.MenuItem59.Text = "-"
        '
        'MenuItem58
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem58, -1)
        Me.MenuItem58.Index = 8
        Me.MenuItem58.Text = "Reporte Cierre de caja"
        '
        'MenuItem105
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem105, -1)
        Me.MenuItem105.Index = 9
        Me.MenuItem105.Text = "-"
        '
        'mnVentasPendientes
        '
        Me.menuExtender.SetImageIndex(Me.mnVentasPendientes, -1)
        Me.mnVentasPendientes.Index = 10
        Me.mnVentasPendientes.Text = "Reporte Ventas Pendientes"
        '
        'MenuItem82
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem82, -1)
        Me.MenuItem82.Index = 9
        Me.MenuItem82.Text = "-"
        '
        'mnPrestamosBodega
        '
        Me.menuExtender.SetExtEnable(Me.mnPrestamosBodega, True)
        Me.menuExtender.SetImageIndex(Me.mnPrestamosBodega, -1)
        Me.mnPrestamosBodega.Index = 10
        Me.mnPrestamosBodega.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnEmpresaPrestamos, Me.MenuItem165, Me.MenuItem161, Me.MenuItem164, Me.mnPrestamos, Me.MenuItem162, Me.MenuItem163, Me.MenuItem110, Me.MenuItem116, Me.MenuItem84, Me.mnReportePrestamos})
        Me.mnPrestamosBodega.OwnerDraw = True
        Me.mnPrestamosBodega.Text = "Prestamos"
        '
        'mnEmpresaPrestamos
        '
        Me.menuExtender.SetImageIndex(Me.mnEmpresaPrestamos, -1)
        Me.mnEmpresaPrestamos.Index = 0
        Me.mnEmpresaPrestamos.Text = "Empresa"
        '
        'MenuItem165
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem165, -1)
        Me.MenuItem165.Index = 1
        Me.MenuItem165.Text = "Prestamos "
        '
        'MenuItem161
        '
        Me.MenuItem161.Enabled = False
        Me.menuExtender.SetImageIndex(Me.MenuItem161, -1)
        Me.MenuItem161.Index = 2
        Me.MenuItem161.Text = "Relacionar Productos Prestamos"
        '
        'MenuItem164
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem164, -1)
        Me.MenuItem164.Index = 3
        Me.MenuItem164.Text = "-"
        '
        'mnPrestamos
        '
        Me.mnPrestamos.Enabled = False
        Me.menuExtender.SetImageIndex(Me.mnPrestamos, -1)
        Me.mnPrestamos.Index = 4
        Me.mnPrestamos.Text = "Solicitar Prestamos"
        '
        'MenuItem162
        '
        Me.MenuItem162.Enabled = False
        Me.menuExtender.SetImageIndex(Me.MenuItem162, -1)
        Me.MenuItem162.Index = 5
        Me.MenuItem162.Text = "Consultar Solicitudes Pendientes"
        '
        'MenuItem163
        '
        Me.MenuItem163.Enabled = False
        Me.menuExtender.SetImageIndex(Me.MenuItem163, -1)
        Me.MenuItem163.Index = 6
        Me.MenuItem163.Text = "Recibir Prestamo"
        '
        'MenuItem110
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem110, -1)
        Me.MenuItem110.Index = 7
        Me.MenuItem110.Text = "-"
        '
        'MenuItem116
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem116, -1)
        Me.MenuItem116.Index = 8
        Me.MenuItem116.Text = "Devoluciones de Prestamos"
        '
        'MenuItem84
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem84, -1)
        Me.MenuItem84.Index = 9
        Me.MenuItem84.Text = "-"
        '
        'mnReportePrestamos
        '
        Me.menuExtender.SetImageIndex(Me.mnReportePrestamos, -1)
        Me.mnReportePrestamos.Index = 10
        Me.mnReportePrestamos.Text = "Reportes"
        '
        'MenuItem99
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem99, -1)
        Me.MenuItem99.Index = 11
        Me.MenuItem99.Text = "-"
        '
        'MenuItem100
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem100, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem100, -1)
        Me.MenuItem100.Index = 12
        Me.MenuItem100.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem101, Me.MenuItem102})
        Me.MenuItem100.OwnerDraw = True
        Me.MenuItem100.Text = "Toma por Proveedor"
        '
        'MenuItem101
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem101, -1)
        Me.MenuItem101.Index = 0
        Me.MenuItem101.Text = "Pretoma"
        '
        'MenuItem102
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem102, -1)
        Me.MenuItem102.Index = 1
        Me.MenuItem102.Text = "Toma"
        '
        'MenuItem115
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem115, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem115, -1)
        Me.MenuItem115.Index = 13
        Me.MenuItem115.OwnerDraw = True
        Me.MenuItem115.Text = "Pre Toma Fisica General"
        '
        'MenuItem109
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem109, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem109, -1)
        Me.MenuItem109.Index = 14
        Me.MenuItem109.OwnerDraw = True
        Me.MenuItem109.Text = "Toma Fisica General"
        '
        'MenuItem103
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem103, -1)
        Me.MenuItem103.Index = 15
        Me.MenuItem103.Text = "-"
        '
        'MenuItem104
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem104, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem104, -1)
        Me.MenuItem104.Index = 16
        Me.MenuItem104.OwnerDraw = True
        Me.MenuItem104.Text = "Temperatura Camara"
        '
        'MenuItem133
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem133, -1)
        Me.MenuItem133.Index = 17
        Me.MenuItem133.Text = "-"
        '
        'MenuItem134
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem134, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem134, -1)
        Me.MenuItem134.Index = 18
        Me.MenuItem134.OwnerDraw = True
        Me.MenuItem134.Text = "Areas"
        '
        'MenuItem138
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem138, -1)
        Me.MenuItem138.Index = 19
        Me.MenuItem138.Text = "-"
        '
        'MenuItem139
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem139, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem139, -1)
        Me.MenuItem139.Index = 20
        Me.MenuItem139.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem140, Me.MenuItem141, Me.MenuItem143, Me.MenuItem144, Me.MenuItem145, Me.MenuItem146})
        Me.MenuItem139.OwnerDraw = True
        Me.MenuItem139.Text = "Control de Lotes"
        '
        'MenuItem140
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem140, -1)
        Me.MenuItem140.Index = 0
        Me.MenuItem140.Text = "Registro de Lotes"
        '
        'MenuItem141
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem141, -1)
        Me.MenuItem141.Index = 1
        Me.MenuItem141.Text = "Consulta de Lotes"
        '
        'MenuItem143
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem143, -1)
        Me.MenuItem143.Index = 2
        Me.MenuItem143.Text = "-"
        '
        'MenuItem144
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem144, -1)
        Me.MenuItem144.Index = 3
        Me.MenuItem144.Text = "Reporte de proximos a vencer"
        '
        'MenuItem145
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem145, -1)
        Me.MenuItem145.Index = 4
        Me.MenuItem145.Text = "Consultar Lote"
        '
        'MenuItem146
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem146, -1)
        Me.MenuItem146.Index = 5
        Me.MenuItem146.Text = "Imprimir Lotes General"
        '
        'MenuItem42
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem42, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem42, -1)
        Me.MenuItem42.Index = 21
        Me.MenuItem42.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem47, Me.MenuItem57, Me.MenuItem67})
        Me.MenuItem42.OwnerDraw = True
        Me.MenuItem42.Text = "Control de Ordenes de Trabajo"
        '
        'MenuItem47
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem47, -1)
        Me.MenuItem47.Index = 0
        Me.MenuItem47.Text = "Ordenes de Trabajo"
        '
        'MenuItem57
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem57, -1)
        Me.MenuItem57.Index = 1
        Me.MenuItem57.Text = "Cierre de Orden"
        '
        'MenuItem67
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem67, -1)
        Me.MenuItem67.Index = 2
        Me.MenuItem67.Text = "Reportes Ordenes"
        '
        'MenuInventarios
        '
        Me.MenuInventarios.Enabled = False
        Me.MenuInventarios.Index = 2
        Me.MenuInventarios.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemInventario_Catalogo, Me.MenuItem72, Me.MenuItemInventario_Familias, Me.MenuItemInventario_Ubicaciones, Me.MenuItemInventario_Presentaciones, Me.MenuItemInventario_Marcas, Me.MenuItemInventario_Ajustes, Me.MenuItemInventario_Etiquetas, Me.MenuItemInventario_Aumentos_X_Categoria, Me.MenuItemRedondeo, Me.MenuItemLinea05, Me.MenuItemControlBodega, Me.MenuItemLinea06, Me.MenuItemInventario_Bodegas, Me.MenuItemInventario_Ajuste_Bodegas, Me.MenuItem8, Me.MenuItem10, Me.MenuItem160, Me.MenuItem13, Me.MenuItem14, Me.MenuItem43, Me.MenuItem75, Me.MenuItem76, Me.MenuItem95, Me.MenuItem96, Me.MenuItem97, Me.MenuItem123, Me.MenuItem124, Me.MenuItem152, Me.MenuItem17, Me.MenuItem168, Me.MenuItem191})
        Me.MenuInventarios.Text = "Inventario"
        '
        'MenuItemInventario_Catalogo
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Catalogo, -1)
        Me.MenuItemInventario_Catalogo.Index = 0
        Me.MenuItemInventario_Catalogo.Shortcut = System.Windows.Forms.Shortcut.CtrlI
        Me.MenuItemInventario_Catalogo.Text = "Registro de Catálogo Inventario"
        '
        'MenuItem72
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem72, -1)
        Me.MenuItem72.Index = 1
        Me.MenuItem72.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem73, Me.MenuItem71})
        Me.MenuItem72.Text = "Rifa"
        '
        'MenuItem73
        '
        Me.MenuItem73.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItem73, -1)
        Me.MenuItem73.Index = 0
        Me.MenuItem73.Text = "Nueva Rifa"
        '
        'MenuItem71
        '
        Me.MenuItem71.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItem71, -1)
        Me.MenuItem71.Index = 1
        Me.MenuItem71.Text = "Productos patrocinadores"
        '
        'MenuItemInventario_Familias
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Familias, -1)
        Me.MenuItemInventario_Familias.Index = 2
        Me.MenuItemInventario_Familias.Text = "Registro de Familias"
        '
        'MenuItemInventario_Ubicaciones
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Ubicaciones, -1)
        Me.MenuItemInventario_Ubicaciones.Index = 3
        Me.MenuItemInventario_Ubicaciones.Text = "Registro de Ubicaciones"
        '
        'MenuItemInventario_Presentaciones
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Presentaciones, -1)
        Me.MenuItemInventario_Presentaciones.Index = 4
        Me.MenuItemInventario_Presentaciones.Text = "Registro de Presentaciones"
        '
        'MenuItemInventario_Marcas
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Marcas, -1)
        Me.MenuItemInventario_Marcas.Index = 5
        Me.MenuItemInventario_Marcas.Text = "Registro de Pantallas"
        '
        'MenuItemInventario_Ajustes
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Ajustes, -1)
        Me.MenuItemInventario_Ajustes.Index = 6
        Me.MenuItemInventario_Ajustes.Text = "Registro de Ajuste Inventario"
        '
        'MenuItemInventario_Etiquetas
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Etiquetas, -1)
        Me.MenuItemInventario_Etiquetas.Index = 7
        Me.MenuItemInventario_Etiquetas.Text = "Etiquetas de  Artículos"
        '
        'MenuItemInventario_Aumentos_X_Categoria
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Aumentos_X_Categoria, -1)
        Me.MenuItemInventario_Aumentos_X_Categoria.Index = 8
        Me.MenuItemInventario_Aumentos_X_Categoria.Text = "Aumento a Categorías"
        '
        'MenuItemRedondeo
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemRedondeo, -1)
        Me.MenuItemRedondeo.Index = 9
        Me.MenuItemRedondeo.Text = "Redondeo de Inventarios"
        '
        'MenuItemLinea05
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea05, -1)
        Me.MenuItemLinea05.Index = 10
        Me.MenuItemLinea05.Text = "-"
        Me.MenuItemLinea05.Visible = False
        '
        'MenuItemControlBodega
        '
        Me.MenuItemControlBodega.Enabled = False
        Me.menuExtender.SetImageIndex(Me.MenuItemControlBodega, -1)
        Me.MenuItemControlBodega.Index = 11
        Me.MenuItemControlBodega.Text = ">> Control de Bodegas <<"
        Me.MenuItemControlBodega.Visible = False
        '
        'MenuItemLinea06
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea06, -1)
        Me.MenuItemLinea06.Index = 12
        Me.MenuItemLinea06.Text = "-"
        '
        'MenuItemInventario_Bodegas
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Bodegas, -1)
        Me.MenuItemInventario_Bodegas.Index = 13
        Me.MenuItemInventario_Bodegas.Text = "Registro de Bodegas"
        '
        'MenuItemInventario_Ajuste_Bodegas
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemInventario_Ajuste_Bodegas, -1)
        Me.MenuItemInventario_Ajuste_Bodegas.Index = 14
        Me.MenuItemInventario_Ajuste_Bodegas.Text = "Ajuste de Bodegas"
        '
        'MenuItem8
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem8, -1)
        Me.MenuItem8.Index = 15
        Me.MenuItem8.Text = "Actualizar Lote por Articulo "
        '
        'MenuItem10
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem10, -1)
        Me.MenuItem10.Index = 16
        Me.MenuItem10.Text = "Bloquea / Desbloquea Bodegas"
        '
        'MenuItem160
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem160, -1)
        Me.MenuItem160.Index = 17
        Me.MenuItem160.Text = "Bloquea / Desbloquea x Casa Comercial"
        '
        'MenuItem13
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem13, -1)
        Me.MenuItem13.Index = 18
        Me.MenuItem13.Text = "-"
        '
        'MenuItem14
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem14, -1)
        Me.MenuItem14.Index = 19
        Me.MenuItem14.Text = "Igualar Bodega Consignacion al Reporte"
        '
        'MenuItem43
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem43, -1)
        Me.MenuItem43.Index = 20
        Me.MenuItem43.Text = "Traslados "
        '
        'MenuItem75
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem75, -1)
        Me.MenuItem75.Index = 21
        Me.MenuItem75.Text = "-"
        '
        'MenuItem76
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem76, -1)
        Me.MenuItem76.Index = 22
        Me.MenuItem76.Text = "Etiquetador"
        '
        'MenuItem95
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem95, -1)
        Me.MenuItem95.Index = 23
        Me.MenuItem95.Text = "-"
        '
        'MenuItem96
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem96, -1)
        Me.MenuItem96.Index = 24
        Me.MenuItem96.Text = "Unificar Codigos"
        '
        'MenuItem97
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem97, -1)
        Me.MenuItem97.Index = 25
        Me.MenuItem97.Text = "Traslados entre Puntos de Venta"
        '
        'MenuItem123
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem123, -1)
        Me.MenuItem123.Index = 26
        Me.MenuItem123.Text = "-"
        '
        'MenuItem124
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem124, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem124, -1)
        Me.MenuItem124.Index = 27
        Me.MenuItem124.OwnerDraw = True
        Me.MenuItem124.Text = "Movimientos"
        '
        'MenuItem152
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem152, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem152, -1)
        Me.MenuItem152.Index = 28
        Me.MenuItem152.OwnerDraw = True
        Me.MenuItem152.Text = "Lista Articulos MAG"
        '
        'MenuItem17
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem17, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem17, -1)
        Me.MenuItem17.Index = 29
        Me.MenuItem17.OwnerDraw = True
        Me.MenuItem17.Text = "Asignar codigo Cabys"
        '
        'MenuItem168
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem168, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem168, -1)
        Me.MenuItem168.Index = 30
        Me.MenuItem168.OwnerDraw = True
        Me.MenuItem168.Text = "Asigar Codigo Barras"
        '
        'MenuItem191
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem191, -1)
        Me.MenuItem191.Index = 31
        Me.MenuItem191.Text = "Importar Cabys XML"
        '
        'MenuReportes
        '
        Me.MenuReportes.Enabled = False
        Me.MenuReportes.Index = 3
        Me.MenuReportes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemReporteVentas, Me.MenuItemReporteCompras, Me.MenuItem174, Me.MenuItem142, Me.MenuItem2, Me.MenuItemReporteABON_CRE_NDEB, Me.MenuItemReportesCXP, Me.MenuItem28, Me.MenuItem22, Me.MenuItem30, Me.MenuItem31, Me.MenuItemLinea07, Me.MenuItemMovimiento, Me.MenuItem23, Me.MenuItemLinea09, Me.MenuItem66, Me.MenuItemReporteClientes, Me.MenuItemReporteProveedores, Me.MenuItemReporteGerencial, Me.MenuItemReporteCajas, Me.MenuItem3, Me.MenuItem7, Me.MenuItem9, Me.MenuItem15, Me.MenuItem16, Me.MenuItem44, Me.MenuItem45, Me.MenuItem48, Me.MenuItem24, Me.MenuItem29, Me.mnPeces})
        Me.MenuReportes.Text = "Reportes"
        '
        'MenuItemReporteVentas
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteVentas, -1)
        Me.MenuItemReporteVentas.Index = 0
        Me.MenuItemReporteVentas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuReporteVentas, Me.mnuReporteGeneraeIndividualVentas, Me.mnuReporteArticulosCompradosCliente, Me.mnuReporteTopCliente, Me.mnuReporteVentasUnificado, Me.mnuReporteClientesmasCompran, Me.MenuItem74, Me.mnuReporteUtilidad, Me.MenuItem93, Me.mnuReporteDescuentosProveedor, Me.mnuReporteUtilidadArticulos, Me.mnuReporteD151Proveedores, Me.mnuReporteD151Clientes, Me.mnuReportePanelControl, Me.MenuItem135, Me.mnuReporteUtilidadFactura, Me.mnuReporteUtilidadFechas, Me.mnuReportePorcentajeVenta, Me.mnuReporteCierreCaja, Me.MenuItem166, Me.mnuReporteSinCabys, Me.mnuReporteMovimientoporArticulo, Me.mnuReporteCreditoRecuperacion, Me.mnuReporteDevolucionDetallado, Me.mnuReporteGraficoVentasAnuales, Me.mnuReporteCrecimientoCompras})
        Me.MenuItemReporteVentas.Text = "Reportes de Ventas"
        '
        'mnuReporteVentas
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteVentas, -1)
        Me.mnuReporteVentas.Index = 0
        Me.mnuReporteVentas.Text = "Reporte de ventas "
        '
        'mnuReporteGeneraeIndividualVentas
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteGeneraeIndividualVentas, -1)
        Me.mnuReporteGeneraeIndividualVentas.Index = 1
        Me.mnuReporteGeneraeIndividualVentas.Text = "Reporte General y Individual de ventas diarias"
        '
        'mnuReporteArticulosCompradosCliente
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteArticulosCompradosCliente, -1)
        Me.mnuReporteArticulosCompradosCliente.Index = 2
        Me.mnuReporteArticulosCompradosCliente.Text = "Reporte de articulos comprados por cliente"
        '
        'mnuReporteTopCliente
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteTopCliente, -1)
        Me.mnuReporteTopCliente.Index = 3
        Me.mnuReporteTopCliente.Text = "Reporte Top Clientes x Rango de fecha"
        '
        'mnuReporteVentasUnificado
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteVentasUnificado, -1)
        Me.mnuReporteVentasUnificado.Index = 4
        Me.mnuReporteVentasUnificado.Text = "Reporte ventas Unificado"
        '
        'mnuReporteClientesmasCompran
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteClientesmasCompran, -1)
        Me.mnuReporteClientesmasCompran.Index = 5
        Me.mnuReporteClientesmasCompran.Text = "Reporte de Clientes que compran más"
        '
        'MenuItem74
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem74, -1)
        Me.MenuItem74.Index = 6
        Me.MenuItem74.Text = "-"
        '
        'mnuReporteUtilidad
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteUtilidad, -1)
        Me.mnuReporteUtilidad.Index = 7
        Me.mnuReporteUtilidad.Text = "Reporte Utilidad "
        '
        'MenuItem93
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem93, -1)
        Me.MenuItem93.Index = 8
        Me.MenuItem93.Text = "-"
        '
        'mnuReporteDescuentosProveedor
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteDescuentosProveedor, -1)
        Me.mnuReporteDescuentosProveedor.Index = 9
        Me.mnuReporteDescuentosProveedor.Text = "Reporte Descuentos por Proveedor"
        '
        'mnuReporteUtilidadArticulos
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteUtilidadArticulos, -1)
        Me.mnuReporteUtilidadArticulos.Index = 10
        Me.mnuReporteUtilidadArticulos.Text = "Utilidad articulos"
        '
        'mnuReporteD151Proveedores
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteD151Proveedores, -1)
        Me.mnuReporteD151Proveedores.Index = 11
        Me.mnuReporteD151Proveedores.Text = "D151 Proveedores"
        '
        'mnuReporteD151Clientes
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteD151Clientes, -1)
        Me.mnuReporteD151Clientes.Index = 12
        Me.mnuReporteD151Clientes.Text = "D151 Clientes"
        '
        'mnuReportePanelControl
        '
        Me.menuExtender.SetExtEnable(Me.mnuReportePanelControl, True)
        Me.menuExtender.SetImageIndex(Me.mnuReportePanelControl, -1)
        Me.mnuReportePanelControl.Index = 13
        Me.mnuReportePanelControl.OwnerDraw = True
        Me.mnuReportePanelControl.Text = "Panel de Control"
        '
        'MenuItem135
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem135, -1)
        Me.MenuItem135.Index = 14
        Me.MenuItem135.Text = "-"
        '
        'mnuReporteUtilidadFactura
        '
        Me.menuExtender.SetExtEnable(Me.mnuReporteUtilidadFactura, True)
        Me.menuExtender.SetImageIndex(Me.mnuReporteUtilidadFactura, -1)
        Me.mnuReporteUtilidadFactura.Index = 15
        Me.mnuReporteUtilidadFactura.OwnerDraw = True
        Me.mnuReporteUtilidadFactura.Text = "Utilidad por Factura"
        '
        'mnuReporteUtilidadFechas
        '
        Me.menuExtender.SetExtEnable(Me.mnuReporteUtilidadFechas, True)
        Me.menuExtender.SetImageIndex(Me.mnuReporteUtilidadFechas, -1)
        Me.mnuReporteUtilidadFechas.Index = 16
        Me.mnuReporteUtilidadFechas.OwnerDraw = True
        Me.mnuReporteUtilidadFechas.Text = "Utilidad Ventas por Rango de Fecha"
        '
        'mnuReportePorcentajeVenta
        '
        Me.menuExtender.SetExtEnable(Me.mnuReportePorcentajeVenta, True)
        Me.menuExtender.SetImageIndex(Me.mnuReportePorcentajeVenta, -1)
        Me.mnuReportePorcentajeVenta.Index = 17
        Me.mnuReportePorcentajeVenta.OwnerDraw = True
        Me.mnuReportePorcentajeVenta.Text = "Porcentaje de Ventas"
        '
        'mnuReporteCierreCaja
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteCierreCaja, -1)
        Me.mnuReporteCierreCaja.Index = 18
        Me.mnuReporteCierreCaja.Text = "Reporte de Cierres de Caja"
        '
        'MenuItem166
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem166, -1)
        Me.MenuItem166.Index = 19
        Me.MenuItem166.Text = "-"
        '
        'mnuReporteSinCabys
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteSinCabys, -1)
        Me.mnuReporteSinCabys.Index = 20
        Me.mnuReporteSinCabys.Text = "Reporte sin Cabys"
        '
        'mnuReporteMovimientoporArticulo
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteMovimientoporArticulo, -1)
        Me.mnuReporteMovimientoporArticulo.Index = 21
        Me.mnuReporteMovimientoporArticulo.Text = "Reporte Movimiento por Articulo"
        '
        'mnuReporteCreditoRecuperacion
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteCreditoRecuperacion, -1)
        Me.mnuReporteCreditoRecuperacion.Index = 22
        Me.mnuReporteCreditoRecuperacion.Text = "Credito y Recuperacion"
        '
        'mnuReporteDevolucionDetallado
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteDevolucionDetallado, -1)
        Me.mnuReporteDevolucionDetallado.Index = 23
        Me.mnuReporteDevolucionDetallado.Text = "Reporte de Devoluciones Detallado"
        '
        'mnuReporteGraficoVentasAnuales
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteGraficoVentasAnuales, -1)
        Me.mnuReporteGraficoVentasAnuales.Index = 24
        Me.mnuReporteGraficoVentasAnuales.Text = "Grafico de Ventas Anuales"
        '
        'mnuReporteCrecimientoCompras
        '
        Me.menuExtender.SetImageIndex(Me.mnuReporteCrecimientoCompras, -1)
        Me.mnuReporteCrecimientoCompras.Index = 25
        Me.mnuReporteCrecimientoCompras.Text = "Crecimiento de Compras"
        '
        'MenuItemReporteCompras
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteCompras, -1)
        Me.MenuItemReporteCompras.Index = 1
        Me.MenuItemReporteCompras.Text = "Reportes de Compras"
        '
        'MenuItem174
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem174, -1)
        Me.MenuItem174.Index = 2
        Me.MenuItem174.Text = "Reporte Movimiento de Compras"
        '
        'MenuItem142
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem142, -1)
        Me.MenuItem142.Index = 3
        Me.MenuItem142.Text = "Reporte Compras por Proveedor"
        '
        'MenuItem2
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem2, -1)
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Text = "Reportes de Gastos"
        '
        'MenuItemReporteABON_CRE_NDEB
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteABON_CRE_NDEB, -1)
        Me.MenuItemReporteABON_CRE_NDEB.Index = 5
        Me.MenuItemReporteABON_CRE_NDEB.Text = "Reportes CXC (ABO,NCRE,NDEB)"
        '
        'MenuItemReportesCXP
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReportesCXP, -1)
        Me.MenuItemReportesCXP.Index = 6
        Me.MenuItemReportesCXP.Text = "Reportes CXP (ABO,NCRE,NDEB)"
        '
        'MenuItem28
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem28, -1)
        Me.MenuItem28.Index = 7
        Me.MenuItem28.Text = "Reporte de agentes de ventas"
        '
        'MenuItem22
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem22, -1)
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Text = "Reporte compras Vet.Liberia + Mascotas"
        '
        'MenuItem30
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem30, -1)
        Me.MenuItem30.Index = 9
        Me.MenuItem30.Text = "Reporte de Apartados"
        '
        'MenuItem31
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem31, -1)
        Me.MenuItem31.Index = 10
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem33, Me.MenuItem32})
        Me.MenuItem31.Text = "Reporte de prestamos"
        '
        'MenuItem33
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem33, -1)
        Me.MenuItem33.Index = 0
        Me.MenuItem33.Text = "Reporte por Empresa"
        '
        'MenuItem32
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem32, -1)
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "Historial "
        '
        'MenuItemLinea07
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea07, -1)
        Me.MenuItemLinea07.Index = 11
        Me.MenuItemLinea07.Text = "-"
        '
        'MenuItemMovimiento
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemMovimiento, -1)
        Me.MenuItemMovimiento.Index = 12
        Me.MenuItemMovimiento.Text = "Movimiento de Artículos"
        '
        'MenuItem23
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem23, -1)
        Me.MenuItem23.Index = 13
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemReporte_Kardex, Me.MenuItemReporte_Inventario, Me.MenuItem69, Me.MenuItem37, Me.MenuItem68, Me.MenuItemReporteABC, Me.MenuItem40, Me.MenuItem158, Me.MenuItem21})
        Me.MenuItem23.Text = "Reporte de Inventario"
        '
        'MenuItemReporte_Kardex
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporte_Kardex, -1)
        Me.MenuItemReporte_Kardex.Index = 0
        Me.MenuItemReporte_Kardex.Text = "Reporte de Kardex"
        '
        'MenuItemReporte_Inventario
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporte_Inventario, -1)
        Me.MenuItemReporte_Inventario.Index = 1
        Me.MenuItemReporte_Inventario.Text = "Reporte de Inventario"
        '
        'MenuItem69
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem69, -1)
        Me.MenuItem69.Index = 2
        Me.MenuItem69.Text = "Reporte listado de inventario"
        '
        'MenuItem37
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem37, -1)
        Me.MenuItem37.Index = 3
        Me.MenuItem37.Text = "Reporte X Sub Familias"
        '
        'MenuItem68
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem68, -1)
        Me.MenuItem68.Index = 4
        Me.MenuItem68.Text = "Reporte Inventario Costo Real"
        '
        'MenuItemReporteABC
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteABC, -1)
        Me.MenuItemReporteABC.Index = 5
        Me.MenuItemReporteABC.Text = "Reporte ABC"
        Me.MenuItemReporteABC.Visible = False
        '
        'MenuItem40
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem40, -1)
        Me.MenuItem40.Index = 6
        Me.MenuItem40.Text = "Movimiento de Bodega"
        '
        'MenuItem158
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem158, -1)
        Me.MenuItem158.Index = 7
        Me.MenuItem158.Text = "Articulos sin Ventas"
        '
        'MenuItem21
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem21, -1)
        Me.MenuItem21.Index = 8
        Me.MenuItem21.Text = "Compras Vs Ventas"
        '
        'MenuItemLinea09
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea09, -1)
        Me.MenuItemLinea09.Index = 14
        Me.MenuItemLinea09.Text = "-"
        '
        'MenuItem66
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem66, -1)
        Me.MenuItem66.Index = 15
        Me.MenuItem66.Text = "Reporte de Planilla"
        '
        'MenuItemReporteClientes
        '
        Me.MenuItemReporteClientes.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteClientes, -1)
        Me.MenuItemReporteClientes.Index = 16
        Me.MenuItemReporteClientes.RadioCheck = True
        Me.MenuItemReporteClientes.Text = "Reporte de Clientes"
        '
        'MenuItemReporteProveedores
        '
        Me.MenuItemReporteProveedores.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteProveedores, -1)
        Me.MenuItemReporteProveedores.Index = 17
        Me.MenuItemReporteProveedores.RadioCheck = True
        Me.MenuItemReporteProveedores.Text = "Reporte de Proveedores"
        '
        'MenuItemReporteGerencial
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteGerencial, -1)
        Me.MenuItemReporteGerencial.Index = 18
        Me.MenuItemReporteGerencial.Text = "Reporte Gerencial"
        '
        'MenuItemReporteCajas
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemReporteCajas, -1)
        Me.MenuItemReporteCajas.Index = 19
        Me.MenuItemReporteCajas.Text = "Reporte Cajas x Forma de Pago"
        '
        'MenuItem3
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem3, -1)
        Me.MenuItem3.Index = 20
        Me.MenuItem3.Text = "Reporte Facturas Anuladas"
        '
        'MenuItem7
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem7, -1)
        Me.MenuItem7.Index = 21
        Me.MenuItem7.Text = "Reporte de Lotes"
        '
        'MenuItem9
        '
        Me.MenuItem9.DefaultItem = True
        Me.menuExtender.SetImageIndex(Me.MenuItem9, -1)
        Me.MenuItem9.Index = 22
        Me.MenuItem9.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.MenuItem9.OwnerDraw = True
        Me.MenuItem9.RadioCheck = True
        Me.MenuItem9.Text = "Reporte Ajustes Inventario Realizados"
        '
        'MenuItem15
        '
        Me.MenuItem15.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItem15, -1)
        Me.MenuItem15.Index = 23
        Me.MenuItem15.RadioCheck = True
        Me.MenuItem15.Text = "Reporte de Bitacora de Reimpresiones"
        '
        'MenuItem16
        '
        Me.MenuItem16.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItem16, -1)
        Me.MenuItem16.Index = 24
        Me.MenuItem16.RadioCheck = True
        Me.MenuItem16.Text = "Reporte de Empaquetado"
        '
        'MenuItem44
        '
        Me.MenuItem44.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItem44, -1)
        Me.MenuItem44.Index = 25
        Me.MenuItem44.Text = "Reporte Venta de producto (Grafico)"
        '
        'MenuItem45
        '
        Me.MenuItem45.Checked = True
        Me.menuExtender.SetImageIndex(Me.MenuItem45, -1)
        Me.MenuItem45.Index = 26
        Me.MenuItem45.Text = "Reporte Ventas Productos - Cliente (Grafico)"
        '
        'MenuItem48
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem48, -1)
        Me.MenuItem48.Index = 27
        Me.MenuItem48.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.MenuItem50, Me.MenuItem51, Me.MenuItem52, Me.MenuItem53, Me.MenuItem91, Me.MenuItem98, Me.MenuItem119})
        Me.MenuItem48.Text = "Reporte de Productos"
        '
        'MenuItem49
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem49, -1)
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Text = "Reporte Top 25 mas vendidos(Grafico)"
        '
        'MenuItem50
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem50, -1)
        Me.MenuItem50.Index = 1
        Me.MenuItem50.Text = "Reporte Venta de producto (Grafico)"
        '
        'MenuItem51
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem51, -1)
        Me.MenuItem51.Index = 2
        Me.MenuItem51.Text = "Reporte Ventas Productos - Cliente (Grafico)"
        '
        'MenuItem52
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem52, -1)
        Me.MenuItem52.Index = 3
        Me.MenuItem52.Text = "Reporte general cantidad productos vendidos"
        '
        'MenuItem53
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem53, -1)
        Me.MenuItem53.Index = 4
        Me.MenuItem53.Text = "Reporte de productos por casa comercial"
        '
        'MenuItem91
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem91, -1)
        Me.MenuItem91.Index = 5
        Me.MenuItem91.Text = "Reporte de Venta por Casa Comercial"
        '
        'MenuItem98
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem98, -1)
        Me.MenuItem98.Index = 6
        Me.MenuItem98.Text = "Movimiento producto por Compra"
        '
        'MenuItem119
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem119, -1)
        Me.MenuItem119.Index = 7
        Me.MenuItem119.Text = "Articulos Actualizados"
        '
        'MenuItem24
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem24, -1)
        Me.MenuItem24.Index = 28
        Me.MenuItem24.Text = "-"
        '
        'MenuItem29
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem29, -1)
        Me.MenuItem29.Index = 29
        Me.MenuItem29.Text = "Reporte de Bitacora"
        '
        'mnPeces
        '
        Me.menuExtender.SetImageIndex(Me.mnPeces, -1)
        Me.mnPeces.Index = 30
        Me.mnPeces.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnClinica, Me.mnReportePeces, Me.MenuItem18, Me.MenuItem46, Me.mnTaller, Me.mnArmamento, Me.MenuItem34, Me.MenuItem39, Me.MenuItem41, Me.mnTienda, Me.mnMaquinaria, Me.mnProductosOrganicos, Me.MenuItem85})
        Me.mnPeces.Text = "Reportes Varios"
        '
        'mnClinica
        '
        Me.menuExtender.SetImageIndex(Me.mnClinica, -1)
        Me.mnClinica.Index = 0
        Me.mnClinica.Text = "Reporte de clinica"
        '
        'mnReportePeces
        '
        Me.menuExtender.SetImageIndex(Me.mnReportePeces, -1)
        Me.mnReportePeces.Index = 1
        Me.mnReportePeces.Text = "Reporte de Peces"
        '
        'MenuItem18
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem18, -1)
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "Reporte de Maceteras"
        '
        'MenuItem46
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem46, -1)
        Me.MenuItem46.Index = 3
        Me.MenuItem46.Text = "Reporte de muerte de animales"
        '
        'mnTaller
        '
        Me.menuExtender.SetImageIndex(Me.mnTaller, -1)
        Me.mnTaller.Index = 4
        Me.mnTaller.Text = "Reporte de Taller"
        '
        'mnArmamento
        '
        Me.menuExtender.SetImageIndex(Me.mnArmamento, -1)
        Me.mnArmamento.Index = 5
        Me.mnArmamento.Text = "Reporte de Armamento"
        '
        'MenuItem34
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem34, -1)
        Me.MenuItem34.Index = 6
        Me.MenuItem34.Text = "Reporte de Bonificaciones"
        '
        'MenuItem39
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem39, -1)
        Me.MenuItem39.Index = 7
        Me.MenuItem39.Text = "Encargado de inventario"
        '
        'MenuItem41
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem41, -1)
        Me.MenuItem41.Index = 8
        Me.MenuItem41.Text = "Reporte de Compra Peces"
        '
        'mnTienda
        '
        Me.menuExtender.SetImageIndex(Me.mnTienda, -1)
        Me.mnTienda.Index = 9
        Me.mnTienda.Text = "Reporte de tienda"
        '
        'mnMaquinaria
        '
        Me.menuExtender.SetImageIndex(Me.mnMaquinaria, -1)
        Me.mnMaquinaria.Index = 10
        Me.mnMaquinaria.Text = "Reporte de maquinaria"
        '
        'mnProductosOrganicos
        '
        Me.menuExtender.SetImageIndex(Me.mnProductosOrganicos, -1)
        Me.mnProductosOrganicos.Index = 11
        Me.mnProductosOrganicos.Text = "Reportes Productos Organicos"
        '
        'MenuItem85
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem85, -1)
        Me.MenuItem85.Index = 12
        Me.MenuItem85.Text = "Reporte Quimicos"
        '
        'MenuInterfaz
        '
        Me.MenuInterfaz.Enabled = False
        Me.MenuInterfaz.Index = 4
        Me.MenuInterfaz.MdiList = True
        Me.MenuInterfaz.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem60, Me.MenuItemAyuda, Me.MenuItemLinea10, Me.MenuItemMaximizar, Me.MenuItemNormal, Me.MenuItemMinimizar, Me.MenuItemLinea11, Me.MenuItemSeguridad, Me.MenuItemLinea12, Me.MenuItemCalculadora, Me.MenuItemLinea13, Me.MenuItem25, Me.MenuItem26, Me.MenuItemCerrar})
        Me.MenuInterfaz.Text = "Interfaz"
        '
        'MenuItem60
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem60, -1)
        Me.MenuItem60.Index = 0
        Me.MenuItem60.Text = "Dashboard"
        '
        'MenuItemAyuda
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemAyuda, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemAyuda, 10)
        Me.MenuItemAyuda.Index = 1
        Me.MenuItemAyuda.OwnerDraw = True
        Me.MenuItemAyuda.Text = "Ayuda"
        '
        'MenuItemLinea10
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea10, -1)
        Me.MenuItemLinea10.Index = 2
        Me.MenuItemLinea10.Text = "-"
        '
        'MenuItemMaximizar
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemMaximizar, -1)
        Me.MenuItemMaximizar.Index = 3
        Me.MenuItemMaximizar.Text = "Maximizar"
        '
        'MenuItemNormal
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemNormal, -1)
        Me.MenuItemNormal.Index = 4
        Me.MenuItemNormal.Text = "Normal"
        '
        'MenuItemMinimizar
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemMinimizar, -1)
        Me.MenuItemMinimizar.Index = 5
        Me.MenuItemMinimizar.Text = "Minimizar"
        '
        'MenuItemLinea11
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea11, -1)
        Me.MenuItemLinea11.Index = 6
        Me.MenuItemLinea11.Text = "-"
        '
        'MenuItemSeguridad
        '
        Me.menuExtender.SetExtEnable(Me.MenuItemSeguridad, True)
        Me.menuExtender.SetImageIndex(Me.MenuItemSeguridad, 11)
        Me.MenuItemSeguridad.Index = 7
        Me.MenuItemSeguridad.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemPerfilUsuarios, Me.MenuItemCambioUsuarios, Me.MenuItemRegistroUsuarios, Me.MenuItem5, Me.MenuItemRespaldos, Me.MenuItemActivarPOS, Me.MenuItem, Me.MenuItem19, Me.MenuItemFullScreenPVE})
        Me.MenuItemSeguridad.OwnerDraw = True
        Me.MenuItemSeguridad.Text = "Seguridad"
        '
        'MenuItemPerfilUsuarios
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemPerfilUsuarios, -1)
        Me.MenuItemPerfilUsuarios.Index = 0
        Me.MenuItemPerfilUsuarios.Text = "Perfil Usuarios"
        '
        'MenuItemCambioUsuarios
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemCambioUsuarios, -1)
        Me.MenuItemCambioUsuarios.Index = 1
        Me.MenuItemCambioUsuarios.Shortcut = System.Windows.Forms.Shortcut.CtrlU
        Me.MenuItemCambioUsuarios.Text = "Cambio Usuario"
        '
        'MenuItemRegistroUsuarios
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemRegistroUsuarios, -1)
        Me.MenuItemRegistroUsuarios.Index = 2
        Me.MenuItemRegistroUsuarios.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem6})
        Me.MenuItemRegistroUsuarios.Text = "Usuarios"
        '
        'MenuItem4
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem4, -1)
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Usuarios habilitar Ventas"
        '
        'MenuItem6
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem6, -1)
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Usuarios"
        '
        'MenuItem5
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem5, -1)
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'MenuItemRespaldos
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemRespaldos, -1)
        Me.MenuItemRespaldos.Index = 4
        Me.MenuItemRespaldos.Text = "Respaldo B.D."
        '
        'MenuItemActivarPOS
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemActivarPOS, -1)
        Me.MenuItemActivarPOS.Index = 5
        Me.MenuItemActivarPOS.Text = "Sistema POS"
        '
        'MenuItem
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem, -1)
        Me.MenuItem.Index = 6
        Me.MenuItem.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem.Text = "Capturar Pantalla"
        '
        'MenuItem19
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem19, -1)
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Text = "-"
        '
        'MenuItemFullScreenPVE
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemFullScreenPVE, -1)
        Me.MenuItemFullScreenPVE.Index = 8
        Me.MenuItemFullScreenPVE.Text = "Full Screen P.VE"
        '
        'MenuItemLinea12
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea12, -1)
        Me.MenuItemLinea12.Index = 8
        Me.MenuItemLinea12.Text = "-"
        '
        'MenuItemCalculadora
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemCalculadora, -1)
        Me.MenuItemCalculadora.Index = 9
        Me.MenuItemCalculadora.Text = "Calculadora"
        '
        'MenuItemLinea13
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemLinea13, -1)
        Me.MenuItemLinea13.Index = 10
        Me.MenuItemLinea13.Text = "-"
        '
        'MenuItem25
        '
        Me.menuExtender.SetExtEnable(Me.MenuItem25, True)
        Me.menuExtender.SetImageIndex(Me.MenuItem25, 13)
        Me.MenuItem25.Index = 11
        Me.MenuItem25.OwnerDraw = True
        Me.MenuItem25.Text = "Actualizaciones automaticas"
        '
        'MenuItem26
        '
        Me.menuExtender.SetImageIndex(Me.MenuItem26, -1)
        Me.MenuItem26.Index = 12
        Me.MenuItem26.Text = "-"
        '
        'MenuItemCerrar
        '
        Me.menuExtender.SetImageIndex(Me.MenuItemCerrar, -1)
        Me.MenuItemCerrar.Index = 13
        Me.MenuItemCerrar.MdiList = True
        Me.MenuItemCerrar.Text = "Cerrar"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 413)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel4, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel5, Me.sbpTCCompra, Me.sbpTCVenta, Me.sbpVersion})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1136, 15)
        Me.StatusBar1.TabIndex = 9
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 31
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Width = 190
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel2.Icon = CType(resources.GetObject("StatusBarPanel2.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 47
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "XX"
        Me.StatusBarPanel3.Width = 31
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel5.Name = "StatusBarPanel5"
        Me.StatusBarPanel5.Width = 548
        '
        'sbpTCCompra
        '
        Me.sbpTCCompra.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.sbpTCCompra.Name = "sbpTCCompra"
        Me.sbpTCCompra.Text = "0"
        Me.sbpTCCompra.Width = 22
        '
        'sbpTCVenta
        '
        Me.sbpTCVenta.Name = "sbpTCVenta"
        Me.sbpTCVenta.Text = "0"
        '
        'sbpVersion
        '
        Me.sbpVersion.Name = "sbpVersion"
        Me.sbpVersion.Text = "*26Ago2022"
        Me.sbpVersion.Width = 150
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "Ayuda\Ayuda Lcpymes.chm"
        '
        'menuExtender
        '
        Me.menuExtender.Font = Nothing
        Me.menuExtender.ImageList = Me.menu_icons
        Me.menuExtender.SystemFont = CType(configurationAppSettings.GetValue("menuExtender.SystemFont", GetType(Boolean)), Boolean)
        '
        'menu_icons
        '
        Me.menu_icons.ImageStream = CType(resources.GetObject("menu_icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.menu_icons.TransparentColor = System.Drawing.Color.Transparent
        Me.menu_icons.Images.SetKeyName(0, "001-invoice.png")
        Me.menu_icons.Images.SetKeyName(1, "002-basket.png")
        Me.menu_icons.Images.SetKeyName(2, "003-network.png")
        Me.menu_icons.Images.SetKeyName(3, "004-delivery-truck.png")
        Me.menu_icons.Images.SetKeyName(4, "005-food.png")
        Me.menu_icons.Images.SetKeyName(5, "001-price-tag.png")
        Me.menu_icons.Images.SetKeyName(6, "002-sick.png")
        Me.menu_icons.Images.SetKeyName(7, "003-employees.png")
        Me.menu_icons.Images.SetKeyName(8, "004-credit-card.png")
        Me.menu_icons.Images.SetKeyName(9, "005-coins.png")
        Me.menu_icons.Images.SetKeyName(10, "007-student.png")
        Me.menu_icons.Images.SetKeyName(11, "008-cogwheel.png")
        Me.menu_icons.Images.SetKeyName(12, "truck.png")
        '
        'imageList
        '
        Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList.Images.SetKeyName(0, "")
        Me.imageList.Images.SetKeyName(1, "")
        Me.imageList.Images.SetKeyName(2, "")
        Me.imageList.Images.SetKeyName(3, "")
        Me.imageList.Images.SetKeyName(4, "")
        Me.imageList.Images.SetKeyName(5, "")
        Me.imageList.Images.SetKeyName(6, "")
        Me.imageList.Images.SetKeyName(7, "")
        Me.imageList.Images.SetKeyName(8, "")
        Me.imageList.Images.SetKeyName(9, "")
        Me.imageList.Images.SetKeyName(10, "")
        Me.imageList.Images.SetKeyName(11, "")
        Me.imageList.Images.SetKeyName(12, "")
        Me.imageList.Images.SetKeyName(13, "")
        '
        'ImageList4
        '
        Me.ImageList4.ImageStream = CType(resources.GetObject("ImageList4.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList4.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList4.Images.SetKeyName(0, "001-invoice.png")
        Me.ImageList4.Images.SetKeyName(1, "002-basket.png")
        Me.ImageList4.Images.SetKeyName(2, "003-network.png")
        Me.ImageList4.Images.SetKeyName(3, "004-delivery-truck.png")
        Me.ImageList4.Images.SetKeyName(4, "005-food.png")
        Me.ImageList4.Images.SetKeyName(5, "001-price-tag.png")
        Me.ImageList4.Images.SetKeyName(6, "002-sick.png")
        Me.ImageList4.Images.SetKeyName(7, "003-employees.png")
        Me.ImageList4.Images.SetKeyName(8, "004-credit-card.png")
        Me.ImageList4.Images.SetKeyName(9, "005-coins.png")
        Me.ImageList4.Images.SetKeyName(10, "007-student.png")
        Me.ImageList4.Images.SetKeyName(11, "008-cogwheel.png")
        Me.ImageList4.Images.SetKeyName(12, "truck.png")
        Me.ImageList4.Images.SetKeyName(13, "if_18_330400.png")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        Me.ImageList2.Images.SetKeyName(7, "")
        Me.ImageList2.Images.SetKeyName(8, "")
        Me.ImageList2.Images.SetKeyName(9, "")
        Me.ImageList2.Images.SetKeyName(10, "")
        Me.ImageList2.Images.SetKeyName(11, "")
        Me.ImageList2.Images.SetKeyName(12, "")
        Me.ImageList2.Images.SetKeyName(13, "")
        Me.ImageList2.Images.SetKeyName(14, "")
        Me.ImageList2.Images.SetKeyName(15, "")
        Me.ImageList2.Images.SetKeyName(16, "")
        Me.ImageList2.Images.SetKeyName(17, "")
        Me.ImageList2.Images.SetKeyName(18, "")
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "")
        Me.ImageList3.Images.SetKeyName(1, "")
        Me.ImageList3.Images.SetKeyName(2, "")
        Me.ImageList3.Images.SetKeyName(3, "")
        Me.ImageList3.Images.SetKeyName(4, "")
        Me.ImageList3.Images.SetKeyName(5, "")
        Me.ImageList3.Images.SetKeyName(6, "")
        Me.ImageList3.Images.SetKeyName(7, "")
        Me.ImageList3.Images.SetKeyName(8, "")
        Me.ImageList3.Images.SetKeyName(9, "")
        Me.ImageList3.Images.SetKeyName(10, "")
        Me.ImageList3.Images.SetKeyName(11, "")
        Me.ImageList3.Images.SetKeyName(12, "")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInventario, Me.ToolStripSeparator1, Me.btnProveedores, Me.ToolStripSeparator2, Me.btnClientesCredito, Me.ToolStripSeparator3, Me.btnCompras, Me.ToolStripSeparator4, Me.btnFacturacion, Me.ToolStripSeparator5, Me.btnPuntoVenta, Me.lblempresa, Me.ToolStripSeparator9, Me.btnNegativo, Me.ToolStripSeparator8, Me.btnCambio, Me.ToolStripSeparator6, Me.btnAlbaran, Me.ToolStripSeparator7, Me.ToolStripButton1, Me.ToolStripSeparator10, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1136, 48)
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnInventario
        '
        Me.btnInventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(64, 45)
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 48)
        '
        'btnProveedores
        '
        Me.btnProveedores.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(76, 45)
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 48)
        '
        'btnClientesCredito
        '
        Me.btnClientesCredito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClientesCredito.Name = "btnClientesCredito"
        Me.btnClientesCredito.Size = New System.Drawing.Size(77, 45)
        Me.btnClientesCredito.Text = "Clientes Cre."
        Me.btnClientesCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 48)
        '
        'btnCompras
        '
        Me.btnCompras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(59, 45)
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 48)
        '
        'btnFacturacion
        '
        Me.btnFacturacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFacturacion.Name = "btnFacturacion"
        Me.btnFacturacion.Size = New System.Drawing.Size(73, 45)
        Me.btnFacturacion.Text = "Facturacion"
        Me.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 48)
        '
        'btnPuntoVenta
        '
        Me.btnPuntoVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPuntoVenta.Name = "btnPuntoVenta"
        Me.btnPuntoVenta.Size = New System.Drawing.Size(75, 45)
        Me.btnPuntoVenta.Text = "Punto Venta"
        Me.btnPuntoVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lblempresa
        '
        Me.lblempresa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblempresa.BackColor = System.Drawing.Color.Transparent
        Me.lblempresa.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempresa.Name = "lblempresa"
        Me.lblempresa.Size = New System.Drawing.Size(141, 45)
        Me.lblempresa.Text = "Empresa"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 48)
        '
        'btnNegativo
        '
        Me.btnNegativo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNegativo.Name = "btnNegativo"
        Me.btnNegativo.Size = New System.Drawing.Size(104, 45)
        Me.btnNegativo.Text = "Permitir Negativo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 48)
        '
        'btnCambio
        '
        Me.btnCambio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCambio.Image = CType(resources.GetObject("btnCambio.Image"), System.Drawing.Image)
        Me.btnCambio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(102, 45)
        Me.btnCambio.Text = "Registrar Cambio"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 48)
        '
        'btnAlbaran
        '
        Me.btnAlbaran.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlbaran.Name = "btnAlbaran"
        Me.btnAlbaran.Size = New System.Drawing.Size(52, 45)
        Me.btnAlbaran.Text = "Albaran"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(86, 45)
        Me.ToolStripButton1.Text = "Nuevo Cliente"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 48)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(61, 45)
        Me.ToolStripButton2.Text = "Anticipos"
        '
        'TimerSolicitudes
        '
        Me.TimerSolicitudes.Interval = 120000
        '
        'PictureBoxFondo
        '
        Me.PictureBoxFondo.Image = Global.LcPymes_5._2.My.Resources.Resources.fondo2
        Me.PictureBoxFondo.Location = New System.Drawing.Point(35, 75)
        Me.PictureBoxFondo.Name = "PictureBoxFondo"
        Me.PictureBoxFondo.Size = New System.Drawing.Size(299, 175)
        Me.PictureBoxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFondo.TabIndex = 12
        Me.PictureBoxFondo.TabStop = False
        Me.PictureBoxFondo.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1136, 428)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PictureBoxFondo)
        Me.Controls.Add(Me.StatusBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpTCCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpTCVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbpVersion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Controles del Menu Principal"
    Private Sub Puede_ver_reporte_mascotas()
        Dim puede As String
        Try
            puede = GetSetting("SeeSOFT", "SeePOs", "rptmascotas")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOs", "rptmascotas", "NO") : puede = "NO"
        End Try
        If puede.ToUpper <> "NO" And puede.ToUpper <> "SI" Then SaveSetting("SeeSOFT", "SeePOs", "rptmascotas", "NO") : puede = "NO"
        If puede.ToUpper = "SI" Then
            Me.mnClinica.Visible = True
        Else
            Me.mnClinica.Visible = False
        End If
    End Sub
    Private Sub Puede_ver_reporte_clinica()
        Dim puede As String
        Try
            puede = GetSetting("SeeSOFT", "SeePOs", "rptClinica")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOs", "rptClinica", "NO") : puede = "NO"
        End Try
        If puede.ToUpper <> "NO" And puede.ToUpper <> "SI" Then SaveSetting("SeeSOFT", "SeePOs", "rptClinica", "NO") : puede = "NO"
        If puede.ToUpper = "SI" Then
            Me.mnClinica.Visible = True
        Else
            Me.mnClinica.Visible = False
        End If
    End Sub
    Private Sub clave_habilitar()
        Dim clave As String
        Try
            clave = GetSetting("SeeSOFT", "SeePOs", "clave")
            If clave = "" Then
                SaveSetting("SeeSOFT", "SeePOs", "clave", "ninguna")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PuedeSincronizar()
        Dim puede As String
        Try
            puede = GetSetting("SeeSOFT", "SeePOs", "Sincroniza")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOs", "Sincroniza", "NO") : puede = "NO"
        End Try
        If puede.ToUpper <> "NO" And puede.ToUpper <> "SI" Then SaveSetting("SeeSOFT", "SeePOs", "Sincroniza", "NO") : puede = "NO"
        If puede.ToUpper = "SI" Then
            Me.MenuItem14.Visible = True
        Else
            Me.MenuItem14.Visible = False
        End If
    End Sub

    Private ContadorError As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error GoTo Contador
        If Me.ContadorError = 5 Then Exit Sub
        Me.Text = Microsoft.VisualBasic.Mid(TITULO, 1, Contador)
        Contador = Contador + 1
        If Contador = Microsoft.VisualBasic.Len(TITULO) Then
            Contador = 1
        End If
        Me.StatusBarPanel1.Text = Date.Now
        Me.StatusBarPanel2.Text = usua.Nombre
        Me.StatusBarPanel3.Text = usua.Perfil

        'If Me.btnNotificacionSolicitud.BackColor = Drawing.Color.Yellow Then
        '    Me.btnNotificacionSolicitud.BackColor = Me.btnProveedores.BackColor
        'Else
        '    Me.btnNotificacionSolicitud.BackColor = Drawing.Color.Yellow
        'End If
        Exit Sub
Contador:
        Me.ContadorError += 1
    End Sub

    Private Sub PoneTitulo()
        Dim fun As New Conexion
        Dim Nom_Empresa As String = ""
        Nom_Empresa = fun.SlqExecuteScalar(fun.Conectar, "SELECT Empresa FROM configuraciones")
        Me.Text = "Sistema POS - Super Veterinaria Liberia (" & Nom_Empresa & ")   " & fun.sQlconexion.WorkstationId & "  -->  " & fun.sQlconexion.DataSource & "(" & fun.sQlconexion.Database & ")         "
        StatusBarPanel5.Text = Nom_Empresa
        Me.lblempresa.Text = GetSetting("seesoft", "seepos", "empresa")
        PuntoVentaActual.Nombre = Me.lblempresa.Text
        fun.DesConectar(fun.sQlconexion)
        TITULO = Me.Text
    End Sub

    Private BasedeDatos As String = ""
    Private PuntosdeVenta As DataTable

    Private Sub CargarPuntosdeVenta()
        Dim db As New GestioDatos
        Dim SystemNormal As String = GetSetting("SeeSOFT", "SeePOS", "SystemNormal")

        Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
        Me.BasedeDatos = Me.BuscaDatos(Conexion(1))

        If SystemNormal = "True" Then
            'carga todos los pntos de venta
            Me.PuntosdeVenta = db.Ejecuta("Select IdPuntoVenta, PuntoVenta, BasedeDatos, Descripcion From " & TablaSeguridad() & ".dbo.PuntodeVenta order by PuntoVenta")
        Else
            'solo carga los puntos de venta relacionadas
            Me.PuntosdeVenta = db.Ejecuta("Select IdPuntoVenta, PuntoVenta, BasedeDatos, Descripcion From " & TablaSeguridad() & ".dbo.PuntodeVenta Where Relacion In(Select Relacion from " & TablaSeguridad() & ".dbo.PuntodeVenta where BasedeDatos = '" & Me.BasedeDatos & "') order by PuntoVenta")
        End If

        If Not Me.PuntosdeVenta.Rows.Count > 1 Then
            Me.btnPuntoVenta.Enabled = False
        Else
            Me.btnPuntoVenta.Enabled = True
        End If

    End Sub

    Private Function BuscaDatos(ByVal _Texto As String) As String
        Dim Resultado As String = ""
        Dim inicia As Boolean = False
        For Each c As Char In _Texto
            If inicia = True Then
                If c <> ";" Then
                    Resultado += c
                End If
            End If
            If c = "=" Then inicia = True
        Next
        Return Resultado
    End Function

    Private Function AplicaCambioenCaja() As Boolean
        Dim dt As New DataTable
        Dim Modocaja As Boolean = False
        cFunciones.Llenar_Tabla_Generico("Select ModoCaja from Configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Modocaja = dt.Rows(0).Item("ModoCaja")
        End If
        Return Modocaja
    End Function

    Private Sub CambiaTipoVersion(ByVal _tipo As String, Optional ByVal _visible As Boolean = False)

        If _tipo = "1" Then
            Me.btnNegativo.Visible = True
            Me.MenuItem118.Visible = True
            Me.btnClientesCredito.Visible = True
            Me.btnCompras.Visible = True
            Me.btnInventario.Visible = True
            Me.btnProveedores.Visible = True
            Me.btnPuntoVenta.Visible = True

            Me.CargarPuntosdeVenta()

            MenuItemOperacion_DevolucionesVentas.Enabled = True
            MenuAdministracion.Enabled = True
            MenuItemCuentasXCobrar.Enabled = True
            MenuItemCompras.Enabled = True
            MenuItemCuentasXPagar.Enabled = True
            MenuInventarios.Enabled = True
            MenuItemControlCaja.Enabled = True
            MenuReportes.Enabled = True
            MenuInterfaz.Enabled = True
            Me.mnEmpresaPrestamos.Enabled = True
            Me.mnReportePrestamos.Enabled = True
            Me.mnMovimientoArticulo.Enabled = True
            Me.mnProveedores.Enabled = True

        ElseIf GetSetting("SeeSOFT", "SeePOS", regeditSegura) = "2" Then

            Me.btnNegativo.Visible = False
            Me.MenuItem118.Visible = False
            Me.btnClientesCredito.Visible = False
            Me.ToolStripSeparator2.Visible = False
            Me.btnCompras.Visible = False
            Me.ToolStripSeparator3.Visible = False
            Me.btnInventario.Visible = False
            Me.ToolStripSeparator4.Visible = False
            Me.btnProveedores.Visible = False

            Me.CargarPuntosdeVenta()

            MenuItemOperacion_DevolucionesVentas.Enabled = False
            MenuAdministracion.Enabled = False
            MenuItemCuentasXCobrar.Enabled = False
            MenuItemCompras.Enabled = False
            MenuItemCuentasXPagar.Enabled = False
            MenuInventarios.Enabled = False
            MenuItemControlCaja.Enabled = False
            MenuReportes.Enabled = False
            MenuInterfaz.Enabled = False
            Me.mnEmpresaPrestamos.Enabled = False
            Me.mnReportePrestamos.Enabled = False
            Me.mnMovimientoArticulo.Enabled = True
            Me.mnProveedores.Enabled = True

        Else

            Me.btnNegativo.Visible = False
            Me.MenuItem118.Visible = False
            Me.btnClientesCredito.Visible = False
            Me.ToolStripSeparator2.Visible = False
            Me.btnCompras.Visible = False
            Me.ToolStripSeparator3.Visible = False
            Me.btnInventario.Visible = False
            Me.ToolStripSeparator4.Visible = False
            Me.btnProveedores.Visible = False

            Me.CargarPuntosdeVenta()

            MenuItemOperacion_DevolucionesVentas.Enabled = False
            MenuAdministracion.Enabled = False
            MenuItemCuentasXCobrar.Enabled = False
            MenuItemCompras.Enabled = False
            MenuItemCuentasXPagar.Enabled = False
            MenuInventarios.Enabled = False
            MenuItemControlCaja.Enabled = False
            MenuReportes.Enabled = False
            MenuInterfaz.Enabled = False
            Me.mnEmpresaPrestamos.Enabled = False
            Me.mnReportePrestamos.Enabled = False
            Me.mnMovimientoArticulo.Enabled = False
            Me.mnProveedores.Enabled = False
            Me.ToolStripSeparator6.Visible = True
        End If
    End Sub

    Private Sub BuscaContadoFirmadoViejo()
        If GetSetting("SeeSOFT", "SeePOS", regeditSegura) = "1" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from viewDiasContadoFirmado where dias > 7 order by dias desc", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                If MsgBox("Desea ver el Reporte", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hay Contado Firmado con mas de 7 dias") = MsgBoxResult.Yes Then
                    Dim frm As New frmFirmadoContadoViejo
                    frm.MdiParent = Me
                    frm.Show()
                End If
            End If
        End If
    End Sub

    Private Sub esKatty()

        Dim katty As String = ""
        katty = GetSetting("SeeSOFT", "SeePOS", "Katty")

        If katty = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "Katty", "0")
            katty = 0
        End If

        If katty = "1" Then 'si es katty
            'Cambia las descripciones
            Me.mnClinica.Text = "Reportes Peluqueria"
            Me.mnMaquinaria.Text = "Reportes Correas"
            Me.mnTaller.Text = "Reportes Shampoo"
            Me.mnProductosOrganicos.Text = "Reporte Accesorios"
            Me.mnArmamento.Text = "Reporte Alimentos"
            Me.mnTienda.Text = "Reporte Aves"
        Else 'de lo contrario
            'todo queda normal
        End If
    End Sub

    Private Sub CargarTipoCambio()
        Try
            Me.sbpTCCompra.Text = ""
            Me.sbpTCVenta.Text = ""
            Dim tc As New api.Hacienda.TipoCambioDolar
            tc = api.Hacienda.ConsultarTipoCambioDolar
            Me.sbpTCCompra.Text = "Venta: " & tc.venta.valor
            Me.sbpTCVenta.Text = "Compra: " & tc.compra.valor
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Prueba sistema
        'Dim cls As New imprimirCheque
        'cls.Imprimir(New Cheque("123456", "ROLANDO OBANDO ROJAS", 1548963, Date.Now, "SISTEMA", "PAGO FACTURAS: 13132,12346,456789"), "EPSON L3110 Series")


        If GetSetting("SeeSOFT", "SeePOS", regeditSegura) = "" Then
            SaveSetting("SeeSOFT", "SeePOS", regeditSegura, "0")
        End If
        Me.esKatty()
        Me.ToolStrip1.ImageList = Me.ImageList4

        Me.btnPuntoVenta.ImageKey = "if_18_330400.png"
        Me.btnFacturacion.ImageKey = "001-invoice.png"
        Me.btnCompras.ImageKey = "002-basket.png"
        Me.btnClientesCredito.ImageKey = "003-network.png"
        Me.btnProveedores.ImageKey = "004-delivery-truck.png"
        Me.btnInventario.ImageKey = "005-food.png"
        Me.btnAlbaran.Image = My.Resources.albaran

        Puede_ver_reporte_clinica()
        Puede_ver_reporte_mascotas()
        clave_habilitar()
        version()
        rifas_activas()
        Me.PuedeSincronizar()

        Me.PoneTitulo()

        Contador = 1
        Perfil_Usuario()

        MenuItemActivarPOS.Checked = IIf(GetSetting("SeeSOFT", "SeePOS", "PVE", "0") = 0, False, True)
        MenuItemFullScreenPVE.Checked = IIf(GetSetting("SeeSOFT", "SeePOS", "PVEFullScreen", "0") = 0, False, True)

        Me.CambiaTipoVersion(GetSetting("SeeSOFT", "SeePOS", regeditSegura))

        Dim puede As String
        puede = GetSetting("SeeSOFT", "SeePOs", "ver_vencidas")
        If puede = "" Then
            SaveSetting("SeeSOFT", "SeePOs", "ver_vencidas", "SI")
        End If
        If GetSetting("SeeSOFT", "SeePOs", "ver_vencidas") = "SI" Then
            abrir_noti()
        End If

        If Me.Obtener_BasedeDatos.ToLower = "mascotas".ToLower Then
            Me.mnTaller.Text = "Reporte de Groomer"
        End If

        If Me.Obtener_BasedeDatos.ToLower = "seepos".ToLower Then
            Me.mnReportePeces.Text = "Reporte de Poliducto"
        End If

        If Me.Obtener_BasedeDatos.ToLower = "mascotas".ToLower Then
            Me.mnReportePeces.Text = "Reporte de Peces"
        End If

        'Me.Actualizacion()
        Me.BuscaContadoFirmadoViejo()
        Me.CargarCedulaEmisor()
        Me.TimerSolicitudes.Start()
        'Me.CargarTipoCambio()
    End Sub

    Private Function Obtener_BasedeDatos() As String
        Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
        Dim Texto As String = Conexion(1)

        Dim Resultado As String = ""
        Dim inicia As Boolean = False
        For Each c As Char In Texto
            If inicia = True Then
                If c <> ";" Then
                    Resultado += c
                End If
            End If
            If c = "=" Then inicia = True
        Next
        Return Resultado.ToLower
    End Function

    Private Sub Perfil_Usuario()

        'If GetSetting("SeeSOFT", "Seguridad", regeditSegura) = "0" Then
        '    Exit Sub
        'End If

        Dim EnEspera As New DevExpress.Utils.WaitDialogForm
        EnEspera.Caption = "Habilitando accesos a módulos autorizados..."
        EnEspera.Text = "Validando Acceso a LcPymes..."
        EnEspera.Show()
        EnEspera.Caption = "Validando Acceso a LcPymes..."
        Me.Hide()

        '********************************************ADMINISTRACION*******************************************************************
        EnEspera.Caption = "Módulos de Administración..."
        Me.MenuAdministracion.Visible = True
        Application.DoEvents()

        MenuItem20.Enabled = VerificandoAcceso_a_Modulos("Frmcliente_frecuente", "Administrador de Clientes frecuente", usua.Cedula, "Administración")
        Me.MenuItemAdministracion_Clientes.Enabled = VerificandoAcceso_a_Modulos("Frmcliente", "Administrador de Clientes", usua.Cedula, "Administración")
        Me.MenuItemAdministracion_Proveedores.Enabled = VerificandoAcceso_a_Modulos("frmProveedores", "Administrador de Proveedores", usua.Cedula, "Administración")
        Me.MenuItemAdministracion_Moneda.Enabled = VerificandoAcceso_a_Modulos("FrmMoneda", "Moneda", usua.Cedula, "Administración")
        Me.MenuItemAdministracion_Tarjetas.Enabled = VerificandoAcceso_a_Modulos("TipoTarjeta", "Operadores de Tarjetas", usua.Cedula, "Administración")
        Me.MenuItemAdministracion_ConfiguracionMoneda.Enabled = VerificandoAcceso_a_Modulos("ConfiguracionMoneda", "Configuración Moneda", usua.Cedula, "Administración")
        Me.MenuItemAdministracion_ConfiguracionSistema.Enabled = VerificandoAcceso_a_Modulos("FrmConfiguracion", "Configuración", usua.Cedula, "Administración")
        Me.MenuItem15.Enabled = VerificandoAcceso_a_Modulos("Bitacora_reimpresiones", "Reporte Reimpresiones", usua.Cedula, "Administración")
        Me.MenuItem16.Enabled = VerificandoAcceso_a_Modulos("Empaquetar", "Reporte Empaquetado", usua.Cedula, "Administración")
        Me.mnClinica.Enabled = VerificandoAcceso_a_Modulos("Reporte Clinica", "Reporte Clinica", usua.Cedula, "Administración")
        Me.MenuItem18.Enabled = VerificandoAcceso_a_Modulos("Reporte Mascotas", "Reporte Mascotas", usua.Cedula, "Administración")
        Me.mnReportePeces.Enabled = VerificandoAcceso_a_Modulos("Reporte peces", "Reporte peces", usua.Cedula, "Administración")
        Me.mnTaller.Enabled = VerificandoAcceso_a_Modulos("Reporte taller", "Reporte taller", usua.Cedula, "Administración")
        '*******************************************************************************************************

        '********************************************MENU OPERACIONES********************************************
        EnEspera.Caption = "Módulos de Operaciones..."
        Me.MenuOperaciones.Visible = True
        Application.DoEvents()
        '*********************************************************OPERACIONES->VENTAS****************************
        MenuItemOperacion_Facturacion.Enabled = VerificandoAcceso_a_Modulos("Facturacion", "Facturación", usua.Cedula, "Operaciones Ventas")
        MenuItemOperacion_Proformas.Enabled = VerificandoAcceso_a_Modulos("Frm_Cotizacion", "Cotizaciones", usua.Cedula, "Operaciones Ventas")
        MenuItemOperacion_DevolucionesVentas.Enabled = VerificandoAcceso_a_Modulos("FrmDevolucionesVentas", "Devoluciones", usua.Cedula, "Operaciones Ventas")
        MenuItem27.Visible = VerificandoAcceso_a_Modulos("frm_agente_venta", "Agentes de ventas", usua.Cedula, "Operaciones Ventas")
        '*******************************************************************************************************
        '**********************OPERACIONES->CUENTAS POR COBRAR**************************************************
        MenuItemOperacion_AbonosCXC.Enabled = VerificandoAcceso_a_Modulos("frmReciboDinero", "CxC-Recibo de Dinero", usua.Cedula, "Operaciones Cuentas por Cobrar")
        MenuItemOperacion_AjustesCXC.Enabled = VerificandoAcceso_a_Modulos("frmAjustecCobrar", "CxC-Ajuste a Cuentas", usua.Cedula, "Operaciones Cuentas por Cobrar")
        MenuItemOperacion_EstadoCuentaCXC.Enabled = VerificandoAcceso_a_Modulos("frmEstado_CXC", "CxC-Estado de Cuentas", usua.Cedula, "Operaciones Cuentas por Cobrar")
        '********************************************************************************************************
        '**********************OPERACIONES->COMPRAS*************************************************************
        MenuItemOperacion_ComprasProveedor.Enabled = VerificandoAcceso_a_Modulos("frmCompra", "Registro de Compras", usua.Cedula, "Operaciones Compras")
        MenuItemOperacion_OrdenCompraManual.Enabled = VerificandoAcceso_a_Modulos("frmOrdenCompra", "Orden de Compra Manual", usua.Cedula, "Operaciones Compras")
        MenuItemOperacion_OrdenCompraAutomatica.Enabled = VerificandoAcceso_a_Modulos("frmOrdenCompraAutomatica", "Orden de Compra Automática", usua.Cedula, "Operaciones Compras")
        MenuItemOperacion_DevolucionesProveedor.Enabled = VerificandoAcceso_a_Modulos("Devoluciones_Compras", "Devoluciones de Compras", usua.Cedula, "Operaciones Compras")
        '*******************************************************************************************************
        '***********************OPERACIONES->CUENTAS POR PAGAR***************************************************
        MenuItemOperacion_AbonosCuentaProveedor.Enabled = VerificandoAcceso_a_Modulos("Abonos_Proveedor", "Abono a Proveedor", usua.Cedula, "Operaciones Cuentas por Pagar")
        MenuItemOperacion_AjusteCuentaProveedor.Enabled = VerificandoAcceso_a_Modulos("frmAjustePagar", "Ajustes de Cuentas por Pagar", usua.Cedula, "Operaciones Cuentas por Pagar")
        MenuItemOperacion_EstadoCuentaProveedor.Enabled = VerificandoAcceso_a_Modulos("frmEstado_CXP", "Estado de Cuentas por Pagar", usua.Cedula, "Operaciones Cuentas por Pagar")
        '*******************************************************************************************************
        '*************************OPERACIONES->CONTROL DE CAJA***************************************************************
        MenuItemOperacion_Caja_Apertura.Enabled = VerificandoAcceso_a_Modulos("AperturaCaja", "Apertura de Caja", usua.Cedula, "Operaciones Control de Caja")
        MenuItemOperacion_Caja_Arqueo.Enabled = VerificandoAcceso_a_Modulos("ArqueoCaja", "Arqueo de Caja", usua.Cedula, "Operaciones Control de Caja")
        MenuItemOperacion_Caja_Cierre.Enabled = VerificandoAcceso_a_Modulos("CierreCaja", "Cierre Caja", usua.Cedula, "Operaciones Control de Caja")
        MenuItemOperacion_Caja_OpcionesPago.Enabled = VerificandoAcceso_a_Modulos("frmMovimientoCajaPago", "Movimiento Caja de Pago", usua.Cedula, "Operaciones Control de Caja")
        MenuItemOperacion_Caja_Movimientos.Enabled = VerificandoAcceso_a_Modulos("MovimientoCaja", "Movimiento de Caja", usua.Cedula, "Operaciones Control de Caja")
        '*******************************************************************************************************
        '*******************************************************************************************************
        '*************************OPERACIONES->CONTROL DE Prestamos***************************************************************
        mnEmpresaPrestamos.Enabled = VerificandoAcceso_a_Modulos("EmpresasPrestamosBodega", "EmpresasPrestamosBodega", usua.Cedula, "Operaciones Prestamos Bodega")
        mnPrestamos.Enabled = VerificandoAcceso_a_Modulos("PrestamosBodega", "PrestamosBodega", usua.Cedula, "Operaciones Prestamos Bodega")
        'mnDevolucionPrestamos.Enabled = VerificandoAcceso_a_Modulos("DevolucionPrestamosBodega", "DevolucionPrestamosBodega", usua.Cedula, "Operaciones Prestamos Bodega")
        mnReportePrestamos.Enabled = VerificandoAcceso_a_Modulos("ReportesPrestamosBodega", "ReportesPrestamosBodega", usua.Cedula, "Operaciones Prestamos Bodega")
        '*******************************************************************************************************


        '********************************************************MENU INVENTARIOS********************************
        EnEspera.Caption = "Módulos de Inventarios ..."
        Me.MenuInventarios.Visible = True
        Application.DoEvents()

        MenuItemInventario_Ajuste_Bodegas.Enabled = VerificandoAcceso_a_Modulos("FrmAjusteBodega", "Ajuste Bodega Inventario", usua.Cedula, "Inventarios")
        MenuItemInventario_Ajustes.Enabled = VerificandoAcceso_a_Modulos("AjusteInventario", "Ajuste de Inventario", usua.Cedula, "Inventarios")
        MenuItemInventario_Aumentos_X_Categoria.Enabled = VerificandoAcceso_a_Modulos("frmAumento", "Aumentos", usua.Cedula, "Inventarios")
        MenuItemInventario_Bodegas.Enabled = VerificandoAcceso_a_Modulos("FrmBodegas", "Bodegas", usua.Cedula, "Inventarios")
        MenuItemInventario_Catalogo.Enabled = VerificandoAcceso_a_Modulos("FrmInventario", "Inventarios", usua.Cedula, "Inventarios")
        ValidaEtiquetador()
        MenuItemInventario_Familias.Enabled = VerificandoAcceso_a_Modulos("Familia", "Familia", usua.Cedula, "Inventarios")
        MenuItemInventario_Marcas.Enabled = VerificandoAcceso_a_Modulos("FrmMarca", "Marca", usua.Cedula, "Inventarios")
        MenuItemInventario_Presentaciones.Enabled = VerificandoAcceso_a_Modulos("FrmPresentaciones", "Presentaciones", usua.Cedula, "Inventarios")
        MenuItemInventario_Ubicaciones.Enabled = VerificandoAcceso_a_Modulos("frmUbicacion", "Ubicaciones", usua.Cedula, "Inventarios")
        MenuItem43.Enabled = VerificandoAcceso_a_Modulos("frm_traslados", "traslados", usua.Cedula, "Inventarios")
        MenuItem73.Enabled = VerificandoAcceso_a_Modulos("frm_rifas", "Rifa", usua.Cedula, "Administración")
        '***************************************************************************************************************

        '*************************************************** MENU REPORTES******************************************
        EnEspera.Caption = "Acceso a Reportes..."
        Me.MenuReportes.Visible = True
        Application.DoEvents()

        'mnuReporteVentas.Enabled = VerificandoAcceso_a_Modulos(mnuReporteVentas.Text, mnuReporteVentas.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteGeneraeIndividualVentas.Enabled = VerificandoAcceso_a_Modulos(mnuReporteGeneraeIndividualVentas.Text, mnuReporteGeneraeIndividualVentas.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteArticulosCompradosCliente.Enabled = VerificandoAcceso_a_Modulos(mnuReporteArticulosCompradosCliente.Text, mnuReporteArticulosCompradosCliente.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteTopCliente.Enabled = VerificandoAcceso_a_Modulos(mnuReporteTopCliente.Text, mnuReporteTopCliente.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteVentasUnificado.Enabled = VerificandoAcceso_a_Modulos(mnuReporteVentasUnificado.Text, mnuReporteVentasUnificado.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteClientesmasCompran.Enabled = VerificandoAcceso_a_Modulos(mnuReporteClientesmasCompran.Text, mnuReporteClientesmasCompran.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteUtilidad.Enabled = VerificandoAcceso_a_Modulos(mnuReporteUtilidad.Text, mnuReporteUtilidad.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteDescuentosProveedor.Enabled = VerificandoAcceso_a_Modulos(mnuReporteDescuentosProveedor.Text, mnuReporteDescuentosProveedor.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteUtilidadArticulos.Enabled = VerificandoAcceso_a_Modulos(mnuReporteUtilidadArticulos.Text, mnuReporteUtilidadArticulos.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteD151Proveedores.Enabled = VerificandoAcceso_a_Modulos(mnuReporteD151Proveedores.Text, mnuReporteD151Proveedores.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteD151Clientes.Enabled = VerificandoAcceso_a_Modulos(mnuReporteD151Clientes.Text, mnuReporteD151Clientes.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReportePanelControl.Enabled = VerificandoAcceso_a_Modulos(mnuReportePanelControl.Text, mnuReportePanelControl.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteUtilidadFactura.Enabled = VerificandoAcceso_a_Modulos(mnuReporteUtilidadFactura.Text, mnuReporteUtilidadFactura.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteUtilidadFechas.Enabled = VerificandoAcceso_a_Modulos(mnuReporteUtilidadFechas.Text, mnuReporteUtilidadFechas.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReportePorcentajeVenta.Enabled = VerificandoAcceso_a_Modulos(mnuReportePorcentajeVenta.Text, mnuReportePorcentajeVenta.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteCierreCaja.Enabled = VerificandoAcceso_a_Modulos(mnuReporteCierreCaja.Text, mnuReporteCierreCaja.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteSinCabys.Enabled = VerificandoAcceso_a_Modulos(mnuReporteSinCabys.Text, mnuReporteSinCabys.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteMovimientoporArticulo.Enabled = VerificandoAcceso_a_Modulos(mnuReporteMovimientoporArticulo.Text, mnuReporteMovimientoporArticulo.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteCreditoRecuperacion.Enabled = VerificandoAcceso_a_Modulos(mnuReporteCreditoRecuperacion.Text, mnuReporteCreditoRecuperacion.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteDevolucionDetallado.Enabled = VerificandoAcceso_a_Modulos(mnuReporteDevolucionDetallado.Text, mnuReporteDevolucionDetallado.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteGraficoVentasAnuales.Enabled = VerificandoAcceso_a_Modulos(mnuReporteGraficoVentasAnuales.Text, mnuReporteGraficoVentasAnuales.Text, usua.Cedula, "Reportes de Ventas")
        'mnuReporteCrecimientoCompras.Enabled = VerificandoAcceso_a_Modulos(mnuReporteCrecimientoCompras.Text, mnuReporteCrecimientoCompras.Text, usua.Cedula, "Reportes de Ventas")


        MenuItemRedondeo.Enabled = VerificandoAcceso_a_Modulos("FrmRedondeoInventario", "Redondeo Inventario", usua.Cedula, "Reportes")
        MenuItemReporte_Inventario.Enabled = VerificandoAcceso_a_Modulos("frmOpcionesVisualizacion", "Reportes de Inventario", usua.Cedula, "Reportes")
        MenuItemReporte_Kardex.Enabled = VerificandoAcceso_a_Modulos("FrmKardex", "Visualiazdor de Kardex", usua.Cedula, "Reportes")
        MenuItemReporteABON_CRE_NDEB.Enabled = VerificandoAcceso_a_Modulos("frmReciboAbonos", "Recibo Abonos", usua.Cedula, "Reportes")
        MenuItemReportesCXP.Enabled = VerificandoAcceso_a_Modulos("frmReportesCXP", "Reportes CXP (ABO,NCRE,NDEB)", usua.Cedula, "Reportes")
        MenuItemReporteClientes.Enabled = VerificandoAcceso_a_Reportes("Clientes.rpt", "Reporte de Clientes", usua.Cedula, "Reportes")
        MenuItemReporteCompras.Enabled = VerificandoAcceso_a_Modulos("frmReporteCompras", "Reporte Compras", usua.Cedula, "Reportes")
        MenuItemReporteProveedores.Enabled = VerificandoAcceso_a_Reportes("Proveedores.rpt", "Reporte de Proveedores", usua.Cedula, "Reportes")
        MenuItemReporteVentas.Enabled = VerificandoAcceso_a_Modulos("frmReporteVentas", "Reporte Ventas", usua.Cedula, "Reportes")
        MenuItemReporteCajas.Enabled = VerificandoAcceso_a_Modulos("FrmReportesCajas", "Reportes Forma de Pago en Caja", usua.Cedula, "Reportes")
        MenuItemMovimiento.Enabled = VerificandoAcceso_a_Modulos("MovimientoArticulos", "Movimiento de Artículos", usua.Cedula, "Inventarios")
        'mnuReporteUtilidad.Enabled = VerificandoAcceso_a_Modulos("ReporteUtilidad", "ReporteUtilidad", usua.Cedula, "Reportes")
        '***************************************************************************************************************

        '*************************INTERFAZ->SEGURIDAD************************************************************************
        Me.MenuItemRespaldos.Enabled = VerificandoAcceso_a_Modulos("FrmRespaldo", "Respaldo Base Datos", usua.Cedula, "Seguridad")
        Me.MenuItemPerfilUsuarios.Enabled = VerificandoAcceso_a_Modulos("AgregarPerfil", "Crear Perfiles de Usuario", usua.Cedula, "Seguridad")
        Me.MenuItemRegistroUsuarios.Enabled = VerificandoAcceso_a_Modulos("Frmusuario", "Administrador de Usuario", usua.Cedula, "Seguridad")

        '********************************************************************************************************************

        '************************* TOOLBAR ***************************************************************
        Me.btnInventario.Enabled = MenuItemInventario_Catalogo.Enabled
        Me.btnProveedores.Enabled = MenuItemAdministracion_Proveedores.Enabled
        Me.btnClientesCredito.Enabled = MenuItemAdministracion_Clientes.Enabled
        Me.btnCompras.Enabled = MenuItemOperacion_ComprasProveedor.Enabled
        Me.btnFacturacion.Enabled = MenuItemOperacion_Facturacion.Enabled

        VerificandoAcceso_a_Modulos("Permite reimprimir", "Reimprimir", usua.Cedula, "Administración")
        '*************************************************************************************************

        'AgregarPerfil
        If Verificar_Acceso_minimo_modulo("AgregarPerfil") Then
            MsgBox("NO SE ENCUENTRA EN LOS MODULOS DE SEGURIDAD NINGUN USUARIO QUE TENGA ACCESO A PERFILES", MsgBoxStyle.Information, "Alerta..")
            Me.MenuItemPerfilUsuarios.Enabled = True
            Me.MenuItemRegistroUsuarios.Enabled = True
        End If

        Me.MenuInterfaz.Visible = True
        EnEspera.Caption = "Validación Finalizada..."
        Application.DoEvents()
        EnEspera.Caption = ""
        EnEspera.Close()
        EnEspera.Dispose()
        Me.Show()
    End Sub

    Public Function Verificar_Acceso_minimo_modulo(ByVal Modulo As String) As Boolean
        Try
            Dim Reader As System.Data.SqlClient.SqlDataReader
            Dim Cx As New Conexion
            Reader = Cx.GetRecorset(Cx.Conectar("Seguridad"), "SELECT dbo.Usuarios.Id_Usuario, dbo.Modulos.Modulo_Nombre_Interno, dbo.Modulos.Modulo_Nombre, dbo.Perfil_x_Modulo.Accion_Ejecucion,  dbo.Perfil_x_Modulo.Accion_Actualizacion, dbo.Perfil_x_Modulo.Accion_Eliminacion, dbo.Perfil_x_Modulo.Accion_Busqueda,  dbo.Perfil_x_Modulo.Accion_Impresion, dbo.Perfil_x_Modulo.Accion_Opcion FROM dbo.Modulos INNER JOIN  dbo.Perfil_x_Modulo ON dbo.Modulos.Id_modulo = dbo.Perfil_x_Modulo.Id_Modulo INNER JOIN  dbo.Perfil ON dbo.Perfil_x_Modulo.Id_Perfil = dbo.Perfil.Id_Perfil INNER JOIN  dbo.Perfil_x_Usuario ON dbo.Perfil.Id_Perfil = dbo.Perfil_x_Usuario.Id_Perfil INNER JOIN  dbo.Usuarios ON dbo.Perfil_x_Usuario.Id_Usuario = dbo.Usuarios.Id_Usuario WHERE dbo.Modulos.Modulo_Nombre_Interno = '" & Modulo & "'")
            If Reader.Read() Then Return False Else Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Function

    Private Sub ValidaEtiquetador()
        'VALIDA EL ACCESO AL ETIQUETADOR DESDE EL MODULO PRINCIPAL 30042007 JCGA
        Dim f As Boolean = False
        Dim s(50) As Integer
        Dim w(50) As Integer
        Dim z(50) As Integer
        MenuItemInventario_Etiquetas.Enabled = VerificandoAcceso_a_Modulos("frmEtiquetasProductos", "Etiquetas de Artículos", usua.Cedula, "Inventarios")
    End Sub

    Public Function ScrollText(ByVal strText As String) As String
        strText = (Microsoft.VisualBasic.Left(strText, Len(strText) + 1)) & Microsoft.VisualBasic.Right(strText, 1)
        ScrollText = strText
    End Function

    Public Sub fondo_mascotas()
        Dim mascotas As String
        Dim image As Drawing.Image

        Try
            mascotas = GetSetting("SeeSOFT", "SeePOs", "mascotas")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOs", "mascotas", "0") : mascotas = "0"
        End Try
        If mascotas.ToUpper <> "0" And mascotas.ToUpper <> "1" Then SaveSetting("SeeSOFT", "SeePOs", "mascotas", "0") : mascotas = "0"
        If mascotas.ToUpper = "1" Then
            Me.PictureBoxFondo.Image = Me.ImageList2.Images(13)

        End If

    End Sub

    Private TieneImagen As Boolean = False
    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.TieneImagen = False Then
            Dim imagen As New Drawing.Bitmap(Me.PictureBoxFondo.Image, Me.Width, Me.Height)
            Me.BackgroundImage = imagen
            'Me.TieneImagen = True
        End If
    End Sub

#End Region

#Region "Menu ADMINISTRACIÓN"
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdministracion_Clientes.Click
        Me.CargarForm(New Frmcliente(usua))
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdministracion_Proveedores.Click
        CargarForm(New frmProveedores(usua))
    End Sub

    Private Sub MenuItemAdministracion_Moneda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdministracion_Moneda.Click
        CargarForm(New FrmMoneda(usua))
    End Sub

    Private Sub MenuItemAdministracion_Tarjetas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdministracion_Tarjetas.Click
        CargarForm(New TipoTarjeta)
    End Sub

    Private Sub MenuItemAdministracion_ConfiguracionMoneda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdministracion_ConfiguracionMoneda.Click
        CargarForm(New ConfiguracionMoneda)
    End Sub

    Private Sub MenuItemAdministracion_ConfiguracionSistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdministracion_ConfiguracionSistema.Click
        Dim frm As New FrmConfiguracion
        frm.usuario = Me.usua.Nombre
        frm.ShowDialog()
    End Sub
#End Region

#Region "Menu OPERACIONES"
    '---------------------------------------------------------------------------------- 
    '       VENTAS Y CUENTAS POR COBRAR
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_Facturacion.Click
        Facturacion()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_Proformas.Click
        CargarForm(New Frm_Cotizacion(usua))
    End Sub
    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_DevolucionesVentas.Click
        CargarForm(New FrmDevolucionesVentas)
    End Sub

    Private Sub MenuItemModificafactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New ModificaFacturacion(usua))
    End Sub

    '---------------------------------------------------------------------------------- 
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_AbonosCXC.Click
        CargarForm(New frmReciboDinero(usua))
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_AjustesCXC.Click
        CargarForm(New frmAjustecCobrar)
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_EstadoCuentaCXC.Click
        CargarForm(New frmEstado_CXC)
    End Sub

    '---------------------------------------------------------------------------------- 
    '       COMPRAS
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_ComprasProveedor.Click
        CargarForm(New frmCompra(usua))
    End Sub

    Private Sub MenuItem76_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_OrdenCompraAutomatica.Click
        CargarForm(New frmOrdenCompraAutomatica(usua))
    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_OrdenCompraManual.Click
        CargarForm(New frmOrdenCompra)
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_DevolucionesProveedor.Click
        CargarForm(New Devoluciones_Compras(usua))
    End Sub

    '---------------------------------------------------------------------------------- 
    '       CUENTAS POR PAGAR
    Private Sub MenuItem55_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_AbonosCuentaProveedor.Click
        CargarForm(New Abonos_Proveedor(usua))
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_AjusteCuentaProveedor.Click
        CargarForm(New frmAjustePagar(usua))
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_EstadoCuentaProveedor.Click
        CargarForm(New frmEstado_CXP)
    End Sub

    '---------------------------------------------------------------------------------- 
    '       CONTROL DE CAJAS
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_Caja_Apertura.Click
        CargarForm(New AperturaCaja(usua))
    End Sub

    Private Sub MenuItemOperacion_Caja_Arqueo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_Caja_Arqueo.Click
        CargarForm(New ArqueoCaja)
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_Caja_Cierre.Click
        CargarForm(New CierreCaja)
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_Caja_OpcionesPago.Click
        CargarForm(New frmMovimientoCajaPago(usua))
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemOperacion_Caja_Movimientos.Click
        CargarForm(New MovimientoCaja(usua))
    End Sub
#End Region

#Region "Menu INVENTARIOS"
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Catalogo.Click
        CargarForm(New FrmInventario(usua))
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Familias.Click
        CargarForm(New Familia(usua))
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Ubicaciones.Click
        CargarForm(New frmUbicacion(usua))
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Presentaciones.Click
        CargarForm(New FrmPresentaciones(usua))
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Marcas.Click
        CargarForm(New FrmMarca(usua))
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Ajustes.Click
        CargarForm(New AjusteInventario(usua))
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Etiquetas.Click
        Try
            Dim f As Boolean = False
            Dim s(50) As Integer
            Dim w(50) As Integer
            Dim z(50) As Integer
            CargarForm(New frmEtiquetasProductos(f, s, w, z))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Aumentos_X_Categoria.Click
        CargarForm(New frmAumento)
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemRedondeo.Click
        CargarForm(New FrmRedondeoInventario(usua))
    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Bodegas.Click
        CargarForm(New FrmBodegas(usua))
    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemInventario_Ajuste_Bodegas.Click
        CargarForm(New FrmAjusteBodega(usua))
    End Sub
#End Region

#Region "Menu REPORTES"
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteVentas.Click

    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteCompras.Click
        CargarForm(New frmReporteCompras)
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteABON_CRE_NDEB.Click
        CargarForm(New frmReciboAbonos)
    End Sub

    Private Sub MenuItemReportesCXP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReportesCXP.Click
        CargarForm(New frmReportesCXP)
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporte_Inventario.Click
        CargarForm(New frmOpcionesVisualizacion)
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporte_Kardex.Click
        CargarForm(New FrmKardex)
    End Sub

    Private Sub MenuItemMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemMovimiento.Click
        Dim frm As New MovimientoArticulos
        frm.usua = usua
        CargarForm(frm)
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteABC.Click
        CargarForm(New frmReporte_ABC)
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteClientes.Click
        Try
            Dim RptClientes As New Clientes
            CrystalReportsConexion.LoadShow(RptClientes, Me)

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteProveedores.Click
        Try
            Dim RptProveedores As New Proveedores
            CrystalReportsConexion.LoadShow(RptProveedores, Me)

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub MenuItemReporteCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteCajas.Click
        CargarForm(New FrmReportesCajas)
    End Sub
#End Region

#Region "Menu INTERFAZ"
    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAyuda.Click
        Help.ShowHelp(Me, HelpProvider.HelpNamespace)
    End Sub

    Private Sub MenuItemMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemNormal.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MenuItemPerfilUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemPerfilUsuarios.Click
        CargarForm(New AgregarPerfil(0, usua))
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCambioUsuarios.Click
        Dim Form As New Frm_login
        Form.ShowDialog()
        usua = Form.Usuario
        If Form.conectado = True Then
            Perfil_Usuario()
        End If
    End Sub

    Private Sub MenuItemRegistroUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemRegistroUsuarios.Click

    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemRespaldos.Click
        CargarForm(New FrmRespaldo)
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemActivarPOS.Click
        If MenuItemActivarPOS.Checked = True Then
            MenuItemActivarPOS.Checked = False
            SaveSetting("SeeSOFT", "SeePOS", "PVE", "0")
        Else
            MenuItemActivarPOS.Checked = True
            SaveSetting("SeeSOFT", "SeePOS", "PVE", "1")
        End If
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem.Click
        CapturaPantallaVisual()
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemFullScreenPVE.Click
        Try
            If MenuItemFullScreenPVE.Checked = True Then
                MenuItemFullScreenPVE.Checked = False
                SaveSetting("SeeSOFT", "SeePOS", "PVEFullScreen", "0")
            Else
                MenuItemFullScreenPVE.Checked = True
                SaveSetting("SeeSOFT", "SeePOS", "PVEFullScreen", "1")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Mensaje")
        End Try
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCalculadora.Click
        Dim hWndNotepad
        Dim proc As New System.Diagnostics.Process
        proc.StartInfo.FileName = "CALC.EXE"
        proc.Start()

        hWndNotepad = WinApi.FindWindow(Nothing, proc.MainWindowTitle)

        If hWndNotepad.ToInt32 > 0 Then
            WinApi.SetParent(hWndNotepad, Me.Handle)
        Else
            proc.Close()
            hWndNotepad = IntPtr.Zero
        End If
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCerrar.Click
        Me.Dispose(True)
        Me.Close()
    End Sub
#End Region

#Region "Funciones"
    Public Sub Facturacion()
        Try
            btnFacturacion.Enabled = False
            If GetSetting("SeeSOFT", "SeePOS", "PVE") = 0 Then
                CargarForm(New Facturacion(usua))
            Else
                If System.IO.File.Exists(Application.StartupPath & "\PVE\SeePOS-PVE.exe") = True Then
                    Dim proc As New System.Diagnostics.Process
                    Dim hWndNotepad
                    proc.StartInfo.FileName = Application.StartupPath & "\PVE\SeePOS-PVE.exe"
                    proc.StartInfo.Arguments = usua.Cedula
                    proc.Start()

                    ' INICIA EL EJECUTABLE DENTRO DE LA APLICACION
                    hWndNotepad = WinApi.FindWindow(Nothing, proc.MainWindowTitle)
                    If hWndNotepad.ToInt32 > 0 Then
                        WinApi.SetParent(hWndNotepad, Me.Handle)
                    Else
                        proc.Close()
                        hWndNotepad = IntPtr.Zero
                    End If
                Else
                    MsgBox("El sistema de Facturación PVE no se encuentra Instalado." & vbCrLf & "Verifique su Instalación y su ruta...." & vbCrLf & Application.StartupPath & "\PVE\SeePOS-PVE.exe", MsgBoxStyle.Critical, "Atención...")
                End If
            End If
            Me.btnFacturacion.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Problemas al cargar el formulario Punto de Venta")
        End Try
    End Sub

    Private Sub CargarForm(ByRef Form As Form)
        Try
            Form.MdiParent = Me
            'Form.Left = (Screen.PrimaryScreen.WorkingArea.Width - Form.Width) \ 2
            'Form.Top = (Screen.PrimaryScreen.WorkingArea.Height - Form.Height) \ 2
            'Form.StartPosition = FormStartPosition.CenterScreen
            Form.Show()
        Catch ex As SystemException
            MsgBox(ex.ToString, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Public Sub HabilitarMenu(ByVal tControl As Control)
        tControl.Enabled = True
        Texto = Texto & tControl.Name & vbCrLf
        If tControl.Controls.Count > 0 Then
            Dim tControl2 As Control
            For Each tControl2 In tControl.Controls
                HabilitarMenu(tControl2)
            Next
        End If
    End Sub
#End Region


    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        CargarForm(New frmGasto(usua))
    End Sub

    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        CargarForm(New frmReporteGastos(1))
    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        CargarForm(New Reporte_Anulados)
    End Sub

    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        CargarForm(New UsuariosHabilitarVentas)
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        CargarForm(New Frmusuario)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        CargarForm(New frmVisualizacionLotes)
    End Sub

    Private Sub MenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        CargarForm(New FrmLotes)
    End Sub

    Private Sub MenuItem9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        'CargarForm(New Reporte_AjustesInventario)
        Dim frm As New frmReporteAjuste
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        CargarForm(New frmBloqueaBodega)
    End Sub

    Private Sub MenuItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        CargarForm(New frmCambiaCaja)
    End Sub

    Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        CargarForm(New frmBloquearBodega)
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dbo As New GestioDatos
        dbo.Ejecuta("exec dbo.spSincronizaDatos")
        MsgBox("Sincronización completada", MsgBoxStyle.Information, "Sincronización")
    End Sub

    Private Sub MenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim frm As New frmSincronizaDatos
        frm.ShowDialog()
    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Try
            Dim RptBitacora As New Bitacora_reimpresiones
            CrystalReportsConexion.LoadShow(RptBitacora, Me)
        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        CargarForm(New reporteEmpaquetado)
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnClinica.Click
        CargarForm(New FrmReporte_clinica)
    End Sub

    Private Sub MenuItem18_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        CargarForm(New frmReporte_Mascotas)
    End Sub

    Private Sub MenuItem20_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Me.CargarForm(New frmCliente_frecuente(usua))
    End Sub

    Private Sub MenuInterfaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuInterfaz.Click

    End Sub
    Sub abrir_noti()
        Try
            Dim ruta As String
            ruta = GetSetting("seesoft", "seepos", "rutaNotificaciones")
            If ruta = "" Then
                SaveSetting("seesoft", "seepos", "rutaNotificaciones", "C:\Program Files (x86)\SEESOFT\LcPymes 5.2\Notificación factura vencidas.exe")
                ruta = GetSetting("seesoft", "seepos", "rutaNotificaciones")
            End If
            Dim proces As New System.Diagnostics.Process
            proces.StartInfo.FileName = ruta
            proces.Start()
        Catch ex As Exception

        End Try
    End Sub
    Sub version()
        Try
            Dim version As String
            version = GetSetting("seesoft", "seepos", "version")
            If version = "" Then
                SaveSetting("seesoft", "seepos", "version", sbpVersion.Text)
            End If
            SaveSetting("seesoft", "seepos", "version", sbpVersion.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnReportePeces.Click
        CargarForm(New frm_reporte_peces)
    End Sub

    Private Sub MenuItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnTaller.Click
        CargarForm(New frm_reporte_taller)
    End Sub

    Private Sub MenuItem25_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Try
            Dim ruta As String
            ruta = GetSetting("seesoft", "seepos", "rutaactualizador")
            If ruta = "" Then
                SaveSetting("seesoft", "seepos", "rutaactualizador", "C:\Program Files (x86)\SEESOFT\LcPymes 5.2\Actualizador_LcPYMES.exe")
                ruta = GetSetting("seesoft", "seepos", "rutaactualizador")
            End If
            Dim proces As New System.Diagnostics.Process
            proces.StartInfo.FileName = ruta
            proces.Start()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuItem27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        CargarForm(New frm_agente_venta(usua))
    End Sub

    Private Sub MenuItem28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        CargarForm(New frm_reporte_agentes)
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        CargarForm(New frm_reporte_mascotas_vet_liberia)
    End Sub

    Private Sub MenuItem29_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        CargarForm(New frm_bitacora)
    End Sub

    Private Sub MenuItem30_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        CargarForm(New frm_reporte_apartado)
    End Sub

    Private Sub MenuAdministracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdministracion.Click

    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click

    End Sub

    Private Sub MenuItem32_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'CargarForm(New frm_reporte_opcionespago)
    End Sub

    Private Sub MenuItem32_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        CargarForm(New frm_historial)
    End Sub

    Private Sub MenuItem33_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        CargarForm(New frm_reporteprestamos)
    End Sub

    Private Sub MenuItem34_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        CargarForm(New reporte_bonificacion)
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReporteGeneraeIndividualVentas.Click
        CargarForm(New reporte_ventas_diarias)
    End Sub

    Private Sub MenuItem36_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReporteVentas.Click
        CargarForm(New frmReporteVentas)
    End Sub

    Private Sub MenuItem37_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        CargarForm(New frm_reporte_subfamilia)
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReporteArticulosCompradosCliente.Click
        CargarForm(New frm_reporte_ventasXarticulo)
    End Sub

    Private Sub MenuItem39_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        CargarForm(New frmencargado_inventario)
    End Sub

    Private Sub MenuItem40_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnArmamento.Click
        CargarForm(New frmReporteArmamento)
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        CargarForm(New reporte_compra_peces)
    End Sub

    Private Sub MenuItem42_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnTienda.Click
        CargarForm(New frm_reporteTienda)
    End Sub

    Private Sub MenuItem43_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        Try
            Dim frm As New Frm_Traslados
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        CargarForm(New frm_reporte_grafico_productos)
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        CargarForm(New frm_reporte_producto_cliente)
    End Sub

    Private Sub MenuItem46_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        CargarForm(New frm_reporte_muertes)
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        CargarForm(New frm_productos_top)
    End Sub

    Private Sub MenuItem50_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        CargarForm(New frm_reporte_grafico_productos)
    End Sub

    Private Sub MenuItem51_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        CargarForm(New frm_reporte_producto_cliente)
    End Sub

    Private Sub MenuItem52_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        CargarForm(New frm_productos_menos_vendidos)
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        'CargarForm(New frm_reporte_cierre_cajas)
        CargarForm(New frmReporteInventarioxProveedor)
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReporteVentasUnificado.Click
        CargarForm(New frm_ventas_unificadas)
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReporteTopCliente.Click
        CargarForm(New frm_top_clientes)
    End Sub

    Private Sub MenuItem57_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnMaquinaria.Click
        CargarForm(New frm_reporte_maquinaria)
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReporteClientesmasCompran.Click
        CargarForm(New frm_mejores_compradores)
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        CargarForm(New frm_reporte_cierre_cajas)
    End Sub

    Private Sub MenuItem60_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        'CargarForm(New frm_dashboard)
    End Sub

    Private Sub MenuItem61_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        CargarForm(New frm_empleados)
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        CargarForm(New frm_accion)
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        CargarForm(New frm_categoria_accion)
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        CargarForm(New frm_reportes_planilla)
    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnProductosOrganicos.Click
        CargarForm(New frm_reporte_productos_organicos)
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        CargarForm(New frm_reporte_costo_real)
    End Sub

    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        CargarForm(New frm_reporte_listado_productos)
    End Sub

    Private Sub MenuItem70_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
        CargarForm(New frm_buscar_cotizacion)
    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        CargarForm(New frm_productos_patrocinadores)
    End Sub

    Private Sub MenuItem73_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        CargarForm(New frm_rifas(usua))
    End Sub
    Sub rifas_activas()
        Dim dts As New DataTable
        Dim fi As Date
        Dim ff As Date
        Dim gd As New GestioDatos
        cFunciones.Llenar_Tabla_Generico("select * from rifa where anulada = 0 and finalizada = 0 ", dts)
        For i As Integer = 0 To dts.Rows.Count - 1
            fi = dts.Rows(i).Item("fecha_inicio")
            ff = dts.Rows(i).Item("fecha_fin")

            If fi <= Date.Today And Date.Today >= ff Then
                gd.Ejecuta("update rifa set finalizada = 1 where id = " & dts.Rows(i).Item("id"))
            End If
        Next
    End Sub

#Region "TOOLBAR"
    Private Sub btnInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventario.Click
        CargarForm(New FrmInventario(usua))
    End Sub

    Private Sub btnProveedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProveedores.Click
        CargarForm(New frmProveedores(usua))
    End Sub

    Private Sub btnClientesCredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientesCredito.Click
        Me.CargarForm(New Frmcliente(usua))
    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click
        CargarForm(New frmCompra(usua))
    End Sub

    Private Sub btnFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturacion.Click
        Facturacion()
    End Sub

    Private Sub btnPuntoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPuntoVenta.Click
        If Me.MdiChildren.Count > 0 Then
            MsgBox("Debe cerrar las ventanas abiertas.", MsgBoxStyle.Exclamation, "Cambiar Punto de Venta")
            Exit Sub
        End If

        Dim frm As New frmCambiarPuntodeVenta
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.PoneTitulo()
            If Me.Obtener_BasedeDatos.ToLower = "mascotas".ToLower Then
                Me.mnTaller.Text = "Reporte de Groomer"
            Else
                Me.mnTaller.Text = "Reporte de Taller"
            End If

            If Me.Obtener_BasedeDatos.ToLower = "seepos".ToLower Then
                Me.mnReportePeces.Text = "Reporte de Poliducto"
            End If

            If Me.Obtener_BasedeDatos.ToLower = "mascotas".ToLower Then
                Me.mnReportePeces.Text = "Reporte de Peces"
            End If

        End If
    End Sub

#End Region

    Private Sub mnReporteUtilidad_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReporteUtilidad.Click
        Dim frm As New frmReportesdeVenta
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem76_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem76.Click
        If GetRegistroSeePOS("EtiquetasGuanavet") = 1 Then
            Dim frm As New frmEtiquetarGuanavet
            frm.MdiParent = Me
            frm.Show()
            Exit Sub
        End If
        If GetRegistroSeePOS("EtiquetasLiberia") = 1 Then
            Dim frm As New frmEtiquetarLiberia
            frm.MdiParent = Me
            frm.Show()
            Exit Sub
        End If
        MsgBox("No hay etiquetador configurado", MsgBoxStyle.Information, Text)
    End Sub

    Private Sub MenuItem81_Click(sender As Object, e As EventArgs) Handles MenuItem81.Click
        'Aqui MensajeReceptor
        'agregar validacion formulario 1 o 2
        'uno con pdf y el otro normal

        Dim frm As New frmMensajeReceptor
        frm.MdiParent = Me
        frm.Show()


    End Sub

    Private Sub mnEmpresaPrestamos_Click(sender As Object, e As EventArgs) Handles mnEmpresaPrestamos.Click
        Dim frm As New Prestamos.frm_empresa
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub mnDevolucionPrestamos_Click(sender As Object, e As EventArgs)
        Dim frm As New Prestamos.frm_devolucion
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem84_Click(sender As Object, e As EventArgs) Handles mnReportePrestamos.Click
        Prestamos.frm_reporte.Show()
    End Sub

    Private Sub mnPrestamos_Click(sender As Object, e As EventArgs) Handles mnPrestamos.Click
        Dim frm As New Prestamos.frm_prestamos
        frm.SPrestamo = True
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem83_Click(sender As Object, e As EventArgs) Handles MenuItem83.Click
        Dim frm As New frmCartaExoneracion
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem85_Click(sender As Object, e As EventArgs) Handles MenuItem85.Click
        Dim frm As New frmReporteQuimicos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem86_Click(sender As Object, e As EventArgs) Handles MenuItem86.Click
        CargarForm(New FrmKardex)
    End Sub

    Private MyVersion As Integer = 3
    Private Sub Actualizacion()
        Try
            Dim Version As Integer = 0
            Dim Ubicacion As String = ""
            Dim Directorio As String = My.Application.Info.DirectoryPath
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * from " & TablaSeguridad() & ".dbo.Actualizacion where Visible = 1", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Version = dt.Rows(0).Item("Version")
                Ubicacion = dt.Rows(0).Item("Ubicacion")


                If Version > Me.MyVersion Then
                    Dim frm As New frmNuevaActualizacion
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        'si hay una nueva version del sistema
                        Dim archivorar As String = Directorio & "\pruebasistema.zip"
                        If IO.File.Exists(archivorar) Then
                            'si existe, eliminelo
                            IO.File.Delete(archivorar)
                        End If
                        'desarga la nueva version
                        My.Computer.Network.DownloadFile(Ubicacion, archivorar)
                        If IO.File.Exists(archivorar) Then
                            'si se descargo

                            Dim minombre As String = My.Application.Info.DirectoryPath & "\" & My.Application.Info.AssemblyName & ".exe"
                            Dim minuevonombre As String = My.Application.Info.AssemblyName & Format(Date.Now, "ddMMyyhhmmss") & ".exe"
                            My.Computer.FileSystem.RenameFile(minombre, minuevonombre)

                            Me.UnZip(Directorio & "\", archivorar)
                            IO.File.Delete(archivorar)
                        End If
                        End
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Sub UnZip(ByVal WorkingDirectory As String, ByVal filepath As String)
        Dim sc As New Shell32.Shell()
        Dim output As Shell32.Folder = sc.NameSpace(WorkingDirectory)
        Dim input As Shell32.Folder = sc.NameSpace(filepath)
        output.CopyHere(input.Items, 4)
    End Sub

    Private Sub MenuItem87_Click(sender As Object, e As EventArgs) Handles MenuItem87.Click
        Dim frm As New frmAumentarOtro
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem89_Click(sender As Object, e As EventArgs) Handles MenuItem89.Click
        Dim frm As New frmNuevoPedido
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem90_Click(sender As Object, e As EventArgs) Handles MenuItem90.Click
        Dim frm As New frmConsultaPedidosBodega
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem77_Click_1(sender As Object, e As EventArgs) Handles mnMovimientoArticulo.Click
        CargarForm(New MovimientoArticulos)
    End Sub

    Private Sub MenuItem78_Click_1(sender As Object, e As EventArgs) Handles mnProveedores.Click
        CargarForm(New frmProveedores(usua))
    End Sub

    Private Sub MenuItem78_Click_2(sender As Object, e As EventArgs) Handles MenuItem78.Click
        Dim frm As New frmReenvioCorreo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem91_Click(sender As Object, e As EventArgs) Handles MenuItem91.Click
        Dim frm As New frmVentasxProveedor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem92_Click(sender As Object, e As EventArgs) Handles MenuItem92.Click
        Dim frm As New frmDescuentosporCasaComercial
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem94_Click(sender As Object, e As EventArgs) Handles mnuReporteDescuentosProveedor.Click
        Dim frm As New frmReporteDescuentosxProveedor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem96_Click(sender As Object, e As EventArgs) Handles MenuItem96.Click
        Dim frm As New frmUnirCodigosPuntoVenta
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem97_Click(sender As Object, e As EventArgs) Handles MenuItem97.Click
        Dim frm As New frmTrasladosDepartamentos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem98_Click(sender As Object, e As EventArgs) Handles MenuItem98.Click
        Dim frm As New frmMovimientoCompra
        frm.ShowDialog()
    End Sub

    Private Sub MenuItem101_Click(sender As Object, e As EventArgs) Handles MenuItem101.Click
        Dim frm As New frmPretomaProveedor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem104_Click(sender As Object, e As EventArgs) Handles MenuItem104.Click
        Dim frm As New frmTemperaturaCamara
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem102_Click(sender As Object, e As EventArgs) Handles MenuItem102.Click
        Dim frm As New frmTomaProveedor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem106_Click(sender As Object, e As EventArgs)
        Dim frm As New frmNumeroFicha
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem107_Click(sender As Object, e As EventArgs) Handles mnVentasPendientes.Click
        Dim frm As New frmReporteFacturasPendientes
        frm.WindowState = FormWindowState.Maximized
        frm.ShowDialog()
    End Sub

    Private Sub mnApartados_Click(sender As Object, e As EventArgs)
        Dim frm As New main(usua)
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub RegistraBitacora(_IdUsuario As String, _Nombre As String)
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.Ejecutar("Insert into BitacoraVersion(IdUsuario, Nombre,Fecha,PC) Values('" & _IdUsuario & "', '" & _Nombre & "', getdate(), '" & My.Computer.Name & "')", CommandType.Text)
    End Sub

    Private Sub MenuItem109_Click(sender As Object, e As EventArgs)
        Dim frm As New frmVisitaClinica
        frm.ShowDialog()

    End Sub

    Private Sub MenuItem110_Click(sender As Object, e As EventArgs)
        Dim frm As New frmArqueoCaja
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem111_Click(sender As Object, e As EventArgs) Handles mnuReporteUtilidadArticulos.Click
        Dim frm As New frmMargenInventario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem113_Click(sender As Object, e As EventArgs) Handles MenuItem113.Click
        Dim frm As New frmSegimientoCotizaciones
        frm.IdUsuario = usua.Cedula
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem108_Click(sender As Object, e As EventArgs) Handles MenuItem108.Click
        Dim frm As New frmArticulosPromocion
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem109_Click_1(sender As Object, e As EventArgs)
        Dim frm As New Credomatic.Configuracion.frmConfiguracionTerminal
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem116_Click(sender As Object, e As EventArgs)
        Dim frm As New Credomatic.Configuracion.frmConfiguracionTerminal
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem117_Click(sender As Object, e As EventArgs)
        Dim frm As New Credomatic.Operaciones.frmConsultaVoucher
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem118_Click(sender As Object, e As EventArgs)
        Dim frm As New frmFormaPagoTranferencia
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem119_Click(sender As Object, e As EventArgs) Handles MenuItem119.Click
        Dim frm As New frmArticulosActualizados
        frm.MdiParent = Me
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MenuItem121_Click(sender As Object, e As EventArgs) Handles MenuItem121.Click
        Dim frm As New frmPedidosBodega
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem122_Click(sender As Object, e As EventArgs) Handles MenuItem122.Click
        Dim frm As New frmEstadoFirmadoContado
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem116_Click_1(sender As Object, e As EventArgs) Handles MenuItem116.Click
        Dim frm As New Prestamos.frm_devolucion
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem117_Click_1(sender As Object, e As EventArgs) Handles MenuItem117.Click
        Dim frm As New frmConsultasComprobantesReceptor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem107_Click_1(sender As Object, e As EventArgs) Handles MenuItem107.Click
        Dim frm As New frmArchivarCredito
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem109_Click_2(sender As Object, e As EventArgs) Handles MenuItem109.Click
        Dim frm As New frmTomaFisicaGeneral
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem115_Click(sender As Object, e As EventArgs) Handles MenuItem115.Click
        Dim frm As New frmPreTomaFisicaGeneral
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnCambio_Click(sender As Object, e As EventArgs) Handles btnCambio.Click
        Dim frm As New frmCambio
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem118_Click_1(sender As Object, e As EventArgs) Handles MenuItem118.Click
        Dim frm As New frmAplicarCambiosInventario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem124_Click(sender As Object, e As EventArgs) Handles MenuItem124.Click
        Dim frm As New frmMovimientoInventario
        frm.MdiParent = Me
        frm.Show()
    End Sub



    Private Sub MenuItem126_Click(sender As Object, e As EventArgs) Handles mnuReporteD151Proveedores.Click
        Dim rpt As New ojoCompra
        rpt.Refresh()
        CrystalReportsConexion.LoadShow(rpt, MdiParent, CadenaConexionSeePOS)
    End Sub

    Private Sub MenuItem106_Click_1(sender As Object, e As EventArgs) Handles mnuReporteD151Clientes.Click
        Dim rpt As New ojoCliente
        rpt.Refresh()
        CrystalReportsConexion.LoadShow(rpt, MdiParent, CadenaConexionSeePOS)
    End Sub

    Private Sub MenuItem125_Click(sender As Object, e As EventArgs) Handles mnuReportePanelControl.Click
        Dim frm As New frmPaneldeControl
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem129_Click(sender As Object, e As EventArgs) Handles MenuItem129.Click
        Dim frm As New frmPuntosporEmpleado
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem128_Click(sender As Object, e As EventArgs) Handles MenuItem128.Click
        Dim frm As New frmPuntosxProductos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem130_Click(sender As Object, e As EventArgs) Handles MenuItem130.Click
        Dim frm As New frmGenerarCuponDescuento
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem132_Click(sender As Object, e As EventArgs) Handles MenuItem132.Click
        Dim frm As New frmFacturasRemplazadas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem134_Click(sender As Object, e As EventArgs) Handles MenuItem134.Click
        Dim frm As New frmAreasme
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem136_Click(sender As Object, e As EventArgs) Handles mnuReporteUtilidadFactura.Click
        Dim frm As New frmUtilidadxFactura
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem137_Click(sender As Object, e As EventArgs) Handles mnuReporteUtilidadFechas.Click
        Dim frm As New frmUtilidadVentasxRangoFechas
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub MenuItem140_Click(sender As Object, e As EventArgs) Handles MenuItem140.Click
        Dim frm As New frmControlLote
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem142_Click(sender As Object, e As EventArgs) Handles MenuItem142.Click
        Dim frm As New frmComprasxProveedor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem144_Click(sender As Object, e As EventArgs) Handles MenuItem144.Click
        Dim frm As New frmArticulosxVencer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem145_Click(sender As Object, e As EventArgs) Handles MenuItem145.Click
        Dim frm As New frmConsultaLotes
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem146_Click(sender As Object, e As EventArgs) Handles MenuItem146.Click
        Dim frm As New frmImprimirLoteGeneral
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem147_Click(sender As Object, e As EventArgs) Handles MenuItem147.Click
        Dim frm As New frmEditarDepositos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem148_Click(sender As Object, e As EventArgs) Handles MenuItem148.Click
        Dim frm As New frmCxPVencer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem149_Click(sender As Object, e As EventArgs) Handles MenuItem149.Click
        Dim frm As New frmCxCVencer
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem150_Click(sender As Object, e As EventArgs) Handles mnuReportePorcentajeVenta.Click
        Dim frm As New frmReportePorcentajeVenta
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem151_Click(sender As Object, e As EventArgs) Handles MenuItem151.Click
        Dim frm As New frmSolicitudPrestamo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private CeduaEmisor As String = ""
    Private Sub CargarCedulaEmisor()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Identificacion from Seguridad.dbo.Emisor", dt, CadenaConexionSeguridad)
        Me.CeduaEmisor = dt.Rows(0).Item("Identificacion")
    End Sub

    Private Sub BuscarSolicitudesNuevas()
        'Try
        '    Dim dt As New DataTable
        '    OBSoluciones.db.AddParametro("pCedula", Me.CeduaEmisor)
        '    dt = OBSoluciones.db.Ejecutar("Obtener_Pedidos_Pendientes")
        '    If dt.Rows.Count > 0 Then
        '        Me.btnNotificacionSolicitud.Visible = True
        '        Me.btnNotificacionSolicitud.Text = "( " & dt.Rows.Count.ToString & " )"
        '    Else
        '        Me.btnNotificacionSolicitud.Visible = False
        '    End If
        'Catch ex As Exception
        '    Me.btnNotificacionSolicitud.Visible = False
        'End Try
    End Sub

    Private Sub TimerSolicitudes_Tick(sender As Object, e As EventArgs) Handles TimerSolicitudes.Tick
        Me.BuscarSolicitudesNuevas()
    End Sub

    Private Sub btnNotificacionSolicitud_Click(sender As Object, e As EventArgs)
        Dim frm As New frmSolicitudesPendientes
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem152_Click(sender As Object, e As EventArgs) Handles MenuItem152.Click
        Dim frm As New frmListadoMag
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem153_Click(sender As Object, e As EventArgs) Handles MenuItem153.Click
        Dim frm As New frmFichasporUsuario
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem156_Click(sender As Object, e As EventArgs) Handles MenuItem156.Click
        Dim frm As New frmAgregarGarantiaSerie
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem157_Click(sender As Object, e As EventArgs) Handles MenuItem157.Click
        Dim frm As New frmHistoricoSerie
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem17_Click_1(sender As Object, e As EventArgs) Handles MenuItem17.Click
        Dim frm As New frmAsignarCabys
        frm.ShowDialog()
    End Sub

    Private Sub MenuItem40_Click_2(sender As Object, e As EventArgs) Handles MenuItem40.Click
        Dim frm As New frmReporteMovimietoBodega
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem47_Click_1(sender As Object, e As EventArgs) Handles MenuItem47.Click
        Dim frm As New frmOrdendeTrabajo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem57_Click_2(sender As Object, e As EventArgs) Handles MenuItem57.Click
        Dim frm As New frmCierreOrden
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem67_Click_1(sender As Object, e As EventArgs) Handles MenuItem67.Click
        Dim frm As New frmReportesOT
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuItem158_Click(sender As Object, e As EventArgs) Handles MenuItem158.Click
        Dim frm As New frmReporteSinVenta
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuItem159_Click(sender As Object, e As EventArgs) Handles mnuReporteCierreCaja.Click
        Dim frm As New frmDiferenciasCaja
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuItem160_Click(sender As Object, e As EventArgs) Handles MenuItem160.Click
        Dim frm As New frmBloqueoxProveedor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem161_Click(sender As Object, e As EventArgs) Handles MenuItem161.Click
        Dim frm As New frmRelacionarProductos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem162_Click(sender As Object, e As EventArgs) Handles MenuItem162.Click
        Dim frm As New frmMostrarSolicitudes
        frm.TipodeOperacion = TipoOperacion.ConsultarPendientes
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem163_Click(sender As Object, e As EventArgs) Handles MenuItem163.Click
        Dim frm As New frmMostrarSolicitudes
        frm.TipodeOperacion = TipoOperacion.RecibirPrestamo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem165_Click(sender As Object, e As EventArgs) Handles MenuItem165.Click
        Dim frm As New Prestamos.frm_prestamos
        frm.SPrestamo = False
        frm.IdSPrestamo = 0
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem167_Click(sender As Object, e As EventArgs) Handles mnuReporteSinCabys.Click
        Dim frm As New frmVentasSinCabys
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem168_Click(sender As Object, e As EventArgs) Handles MenuItem168.Click
        Dim frm As New frmInventarioSinCodigoBarras
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem169_Click(sender As Object, e As EventArgs) Handles MenuItem169.Click
        Dim frm As New frmPrepagoCxP
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem170_Click(sender As Object, e As EventArgs) Handles MenuItem170.Click
        Dim frm As New frmComprasPrepagadas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem173_Click(sender As Object, e As EventArgs) Handles mnuReporteMovimientoporArticulo.Click
        Dim frm As New frmMovimientoxCodigo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem174_Click(sender As Object, e As EventArgs) Handles MenuItem174.Click
        Dim frm As New frmMovimientoCompras
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem175_Click(sender As Object, e As EventArgs) Handles mnuReporteCreditoRecuperacion.Click
        Dim frm As New frmReporteContadoRecuperacion
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem176_Click(sender As Object, e As EventArgs) Handles MenuItem176.Click
        Dim frm As New frmNoMAG
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub MenuItem177_Click(sender As Object, e As EventArgs) Handles mnuReporteDevolucionDetallado.Click
        Dim frm As New frmReporteDevoluciones
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem178_Click(sender As Object, e As EventArgs) Handles MenuItem178.Click
        Dim frm As New frmTCCompra
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem179_Click(sender As Object, e As EventArgs) Handles mnuReporteGraficoVentasAnuales.Click
        Dim frm As New frmGraficoVentasAnuales
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem180_Click(sender As Object, e As EventArgs) Handles mnuReporteCrecimientoCompras.Click
        Dim frm As New frmCrecimientoCompras
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnNegativo_Click(sender As Object, e As EventArgs) Handles btnNegativo.Click
        Dim frm As New frmConsultarToken
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem182_Click(sender As Object, e As EventArgs) Handles MenuItem182.Click
        Dim frm As New frmCONTROL_PROVEEDOR_META
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem184_Click(sender As Object, e As EventArgs) Handles MenuItem184.Click
        Dim frm As New frmMetasGeneral
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuItem187_Click(sender As Object, e As EventArgs) Handles MenuItem187.Click
        Dim frm As New frmGestionCobro
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem188_Click(sender As Object, e As EventArgs) Handles MenuItem188.Click
        Dim frm As New frmGUARDAR_VALIDA_FIRMADOCONTADO
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem189_Click(sender As Object, e As EventArgs) Handles MenuItem189.Click
        Dim frm As New frmReporteAbonoIncobrable
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
    End Sub

    Private Sub MenuItem190_Click(sender As Object, e As EventArgs) Handles MenuItem190.Click
        Dim frm As New frmEnviarCobroJudicial
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem191_Click(sender As Object, e As EventArgs) Handles MenuItem191.Click
        Dim frm As New frmMigradorCabys
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub MenuItem21_Click_1(sender As Object, e As EventArgs) Handles MenuItem21.Click
        Dim frm As New frmReporteCompravsVentas
        frm.ShowDialog()
    End Sub

    Private Sub MenuItem192_Click(sender As Object, e As EventArgs) Handles MenuItem192.Click
        Dim frm As New frmReporteCxCMeses
        frm.ShowDialog()
    End Sub

    Private Sub MenuItem35_Click_1(sender As Object, e As EventArgs) Handles MenuItem35.Click
        Dim frm As New frmConsultaAlbaran
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnAlbaran_Click(sender As Object, e As EventArgs) Handles btnAlbaran.Click
        Dim frm As New frmConsultaAlbaran
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frm_cliente As New frm_cliente_rapido
        frm_cliente.Frecuente = False
        frm_cliente.txtCodigo.Enabled = True
        frm_cliente.txtNombre.Enabled = True
        frm_cliente.cbo_tipo_cliente.Enabled = True
        frm_cliente.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim frm As New frmPrepagos
        frm.MdiParent = Me
        frm.Show()
    End Sub

End Class

Public Module PuntoVentaActual
    Public Property Nombre As String = ""
    ''' <summary>
    ''' nombre de la propiedad en el regedit para activar el modo full del sistema
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property regeditSegura As String = "config"
End Module

#Region "LLamados de archivos externos"



Public Class WinApi
    ' Hace que una ventana sea hija (o esté contenida) en otra
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, _
    ByVal hWndNewParent As IntPtr) As IntPtr
    End Function
    ' Devuelve el Handle (hWnd) de una ventana de la que sabemos el título
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function FindWindow(ByVal lpClassName As String, _
    ByVal lpWindowName As String) As IntPtr
    End Function
    ' Cambia el tamaño y la posición de una ventana
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Public Shared Function MoveWindow(ByVal hWnd As IntPtr, _
    ByVal x As Integer, ByVal y As Integer, _
                                ByVal nWidth As Integer, ByVal nHeight As Integer, _
                                ByVal bRepaint As Integer) As Integer
    End Function
End Class
#End Region