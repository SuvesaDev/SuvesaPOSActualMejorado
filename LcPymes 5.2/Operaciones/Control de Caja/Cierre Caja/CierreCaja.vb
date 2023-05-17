Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class CierreCaja
    Inherits FrmPlantilla

#Region "Variables"
    Public Usuario As String
    Public Cedula_Usuario As String
    Dim PMU As PerfilModulo_Class
    Public tabla As New DataTable
    Public tablaresumen As New DataTable
    Public tablacierre As New DataTable
    Public SubTotal As Double
    Public Total As Double
    Public Devolucion As Double
    Public TipoCambioDolar As Double
    Public TipoCambioD As Double
    Dim Apertura As Double = "0"
    Friend WithEvents txtanuladas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents btnSuvesa As System.Windows.Forms.Button
    Friend WithEvents txtPrepagosAplicados As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Dim AperturaNumero As String
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

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
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetCierreCaja1 As DataSetCierreCaja
    Friend WithEvents AdapterCierre As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterApertura As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterOpciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TimeEdit2 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeEdit1 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents DTPFechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFechainicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfechaapertura As System.Windows.Forms.Label
    Friend WithEvents txtcodaperturacajero As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgResumen As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterTotalTope As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterArqueo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterTarjeta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdapterTipoTarjeta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdapterDetallePago As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterVentasContado As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextEdit18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents AdapterCierreMonto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterCierreTarjeta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents lblanulado As System.Windows.Forms.Label
    Friend WithEvents AdapterVentasCredito As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtFondoCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonBuscarCajero As System.Windows.Forms.Button
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtnomcajero As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtcodcajero As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TimeEdit3 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeEdit4 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtEntradas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtSalidas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtChequesCajero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChequesSistema As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtDepositar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtChequesDolSistema As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChequesDolCajero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TxtDepoColSistena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepoColCajero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtDepDolSistema As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDepDolCajero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtDevoluciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CierreCaja))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterUsuarios = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DataSetCierreCaja1 = New LcPymes_5._2.DataSetCierreCaja()
        Me.AdapterCierre = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterApertura = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterOpciones = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TimeEdit2 = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeEdit1 = New DevExpress.XtraEditors.TimeEdit()
        Me.DTPFechafinal = New System.Windows.Forms.DateTimePicker()
        Me.DTPFechainicial = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btndone = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtfechaapertura = New System.Windows.Forms.Label()
        Me.txtcodaperturacajero = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgResumen = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterTotalTope = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterArqueo = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterTarjeta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSuvesa = New System.Windows.Forms.Button()
        Me.txtanuladas = New DevExpress.XtraEditors.TextEdit()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDevoluciones = New DevExpress.XtraEditors.TextEdit()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtDepositar = New DevExpress.XtraEditors.TextEdit()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtSalidas = New DevExpress.XtraEditors.TextEdit()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtEntradas = New DevExpress.XtraEditors.TextEdit()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextEdit20 = New DevExpress.XtraEditors.TextEdit()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TxtFondoCaja = New DevExpress.XtraEditors.TextEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.AdapterTipoTarjeta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtDepDolSistema = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepDolCajero = New DevExpress.XtraEditors.TextEdit()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TxtDepoColSistena = New DevExpress.XtraEditors.TextEdit()
        Me.txtDepoColCajero = New DevExpress.XtraEditors.TextEdit()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtChequesDolSistema = New DevExpress.XtraEditors.TextEdit()
        Me.txtChequesDolCajero = New DevExpress.XtraEditors.TextEdit()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtChequesSistema = New DevExpress.XtraEditors.TextEdit()
        Me.txtChequesCajero = New DevExpress.XtraEditors.TextEdit()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextEdit18 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit19 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.AdapterDetallePago = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterVentasContado = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterCierreMonto = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterCierreTarjeta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.lblanulado = New System.Windows.Forms.Label()
        Me.AdapterVentasCredito = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonBuscarCajero = New System.Windows.Forms.Button()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.txtnomcajero = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtcodcajero = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TimeEdit3 = New DevExpress.XtraEditors.TimeEdit()
        Me.TimeEdit4 = New DevExpress.XtraEditors.TimeEdit()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPrepagosAplicados = New DevExpress.XtraEditors.TextEdit()
        Me.Label40 = New System.Windows.Forms.Label()
        CType(Me.DataSetCierreCaja1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtanuladas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDevoluciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepositar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalidas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntradas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFondoCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.txtDepDolSistema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepDolCajero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDepoColSistena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepoColCajero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequesDolSistema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequesDolCajero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequesSistema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChequesCajero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrepagosAplicados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 635)
        Me.ToolBar1.Size = New System.Drawing.Size(778, 56)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(856, 491)
        '
        'TituloModulo
        '
        Me.TituloModulo.Text = "Cierre de Caja"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(568, 616)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 60
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(568, 632)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(208, 13)
        Me.txtNombreUsuario.TabIndex = 61
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.ForeColor = System.Drawing.Color.Blue
        Me.TextBox6.Location = New System.Drawing.Point(648, 616)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox6.Size = New System.Drawing.Size(128, 13)
        Me.TextBox6.TabIndex = 59
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
    "persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterUsuarios
        '
        Me.AdapterUsuarios.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Perfil", "Perfil")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Id_Usuario, Nombre, Clave_Entrada, Clave_Interna, Perfil FROM Usua" & _
    "rios"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'DataSetCierreCaja1
        '
        Me.DataSetCierreCaja1.DataSetName = "DataSetCierreCaja"
        Me.DataSetCierreCaja1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetCierreCaja1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdapterCierre
        '
        Me.AdapterCierre.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterCierre.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterCierre.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterCierre.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cierrecaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumeroCierre", "NumeroCierre"), New System.Data.Common.DataColumnMapping("Cajera", "Cajera"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Apertura", "Apertura"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Devoluciones", "Devoluciones"), New System.Data.Common.DataColumnMapping("Subtotal", "Subtotal"), New System.Data.Common.DataColumnMapping("TotalSistema", "TotalSistema"), New System.Data.Common.DataColumnMapping("Equivalencia", "Equivalencia"), New System.Data.Common.DataColumnMapping("EfectivoColones", "EfectivoColones"), New System.Data.Common.DataColumnMapping("EfectivoDolares", "EfectivoDolares"), New System.Data.Common.DataColumnMapping("TarjetaColones", "TarjetaColones"), New System.Data.Common.DataColumnMapping("TarjetaDolares", "TarjetaDolares"), New System.Data.Common.DataColumnMapping("Cheques", "Cheques"), New System.Data.Common.DataColumnMapping("ChequeDol", "ChequeDol"), New System.Data.Common.DataColumnMapping("DepositosCol", "DepositosCol"), New System.Data.Common.DataColumnMapping("DepositosDol", "DepositosDol")})})
        Me.AdapterCierre.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumeroCierre", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCierre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Apertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajera", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajera", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequeDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequeDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cheques", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cheques", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositosCol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositosCol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositosDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositosDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Equivalencia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Equivalencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Subtotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subtotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalSistema", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalSistema", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cajera", System.Data.SqlDbType.VarChar, 255, "Cajera"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Apertura", System.Data.SqlDbType.Int, 4, "Apertura"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Subtotal", System.Data.SqlDbType.Float, 8, "Subtotal"), New System.Data.SqlClient.SqlParameter("@TotalSistema", System.Data.SqlDbType.Float, 8, "TotalSistema"), New System.Data.SqlClient.SqlParameter("@Equivalencia", System.Data.SqlDbType.Float, 8, "Equivalencia"), New System.Data.SqlClient.SqlParameter("@EfectivoColones", System.Data.SqlDbType.Float, 8, "EfectivoColones"), New System.Data.SqlClient.SqlParameter("@EfectivoDolares", System.Data.SqlDbType.Float, 8, "EfectivoDolares"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@Cheques", System.Data.SqlDbType.Float, 8, "Cheques"), New System.Data.SqlClient.SqlParameter("@ChequeDol", System.Data.SqlDbType.Float, 8, "ChequeDol"), New System.Data.SqlClient.SqlParameter("@DepositosCol", System.Data.SqlDbType.Float, 8, "DepositosCol"), New System.Data.SqlClient.SqlParameter("@DepositosDol", System.Data.SqlDbType.Float, 8, "DepositosDol")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cajera", System.Data.SqlDbType.VarChar, 255, "Cajera"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Apertura", System.Data.SqlDbType.Int, 4, "Apertura"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Devoluciones", System.Data.SqlDbType.Float, 8, "Devoluciones"), New System.Data.SqlClient.SqlParameter("@Subtotal", System.Data.SqlDbType.Float, 8, "Subtotal"), New System.Data.SqlClient.SqlParameter("@TotalSistema", System.Data.SqlDbType.Float, 8, "TotalSistema"), New System.Data.SqlClient.SqlParameter("@Equivalencia", System.Data.SqlDbType.Float, 8, "Equivalencia"), New System.Data.SqlClient.SqlParameter("@EfectivoColones", System.Data.SqlDbType.Float, 8, "EfectivoColones"), New System.Data.SqlClient.SqlParameter("@EfectivoDolares", System.Data.SqlDbType.Float, 8, "EfectivoDolares"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@Cheques", System.Data.SqlDbType.Float, 8, "Cheques"), New System.Data.SqlClient.SqlParameter("@ChequeDol", System.Data.SqlDbType.Float, 8, "ChequeDol"), New System.Data.SqlClient.SqlParameter("@DepositosCol", System.Data.SqlDbType.Float, 8, "DepositosCol"), New System.Data.SqlClient.SqlParameter("@DepositosDol", System.Data.SqlDbType.Float, 8, "DepositosDol"), New System.Data.SqlClient.SqlParameter("@Original_NumeroCierre", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroCierre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Apertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Apertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajera", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajera", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequeDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequeDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cheques", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cheques", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositosCol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositosCol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DepositosDol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DepositosDol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Devoluciones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Devoluciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Equivalencia", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Equivalencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Subtotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Subtotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalSistema", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalSistema", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@NumeroCierre", System.Data.SqlDbType.Int, 4, "NumeroCierre")})
        '
        'AdapterApertura
        '
        Me.AdapterApertura.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterApertura.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "aperturacaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Estado", "Estado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT NApertura, Fecha, Nombre, Estado, Observaciones, Anulado, Cedula FROM aper" & _
    "turacaja"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'AdapterOpciones
        '
        Me.AdapterOpciones.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterOpciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OpcionesDePago", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("TipoDocumento", "TipoDocumento"), New System.Data.Common.DataColumnMapping("MontoPago", "MontoPago"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Denominacion", "Denominacion"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Nombremoneda", "Nombremoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Numapertura", "Numapertura")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id, Documento, TipoDocumento, MontoPago, FormaPago, Denominacion, Usuario," & _
    " Nombre, CodMoneda, Nombremoneda, TipoCambio, Fecha, Numapertura FROM OpcionesDe" & _
    "Pago"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label25.Location = New System.Drawing.Point(155, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Fecha Cierre"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(8, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Código Cajero"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(8, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nombre"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeEdit2
        '
        Me.TimeEdit2.EditValue = New Date(2006, 3, 15, 11, 33, 32, 375)
        Me.TimeEdit2.Location = New System.Drawing.Point(496, 56)
        Me.TimeEdit2.Name = "TimeEdit2"
        '
        '
        '
        Me.TimeEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEdit2.Properties.UseCtrlIncrement = False
        Me.TimeEdit2.Size = New System.Drawing.Size(96, 19)
        Me.TimeEdit2.TabIndex = 12
        '
        'TimeEdit1
        '
        Me.TimeEdit1.EditValue = New Date(2006, 3, 15, 11, 33, 32, 375)
        Me.TimeEdit1.Location = New System.Drawing.Point(496, 32)
        Me.TimeEdit1.Name = "TimeEdit1"
        '
        '
        '
        Me.TimeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEdit1.Properties.UseCtrlIncrement = False
        Me.TimeEdit1.Size = New System.Drawing.Size(96, 19)
        Me.TimeEdit1.TabIndex = 8
        '
        'DTPFechafinal
        '
        Me.DTPFechafinal.Enabled = False
        Me.DTPFechafinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechafinal.Location = New System.Drawing.Point(360, 56)
        Me.DTPFechafinal.MaxDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DTPFechafinal.MinDate = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.DTPFechafinal.Name = "DTPFechafinal"
        Me.DTPFechafinal.Size = New System.Drawing.Size(104, 20)
        Me.DTPFechafinal.TabIndex = 11
        Me.DTPFechafinal.Value = New Date(2006, 1, 1, 0, 0, 0, 0)
        '
        'DTPFechainicial
        '
        Me.DTPFechainicial.Enabled = False
        Me.DTPFechainicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechainicial.Location = New System.Drawing.Point(360, 32)
        Me.DTPFechainicial.MaxDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DTPFechainicial.MinDate = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.DTPFechainicial.Name = "DTPFechainicial"
        Me.DTPFechainicial.Size = New System.Drawing.Size(104, 20)
        Me.DTPFechainicial.TabIndex = 7
        Me.DTPFechainicial.Value = New Date(2006, 1, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(304, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Final"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(304, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Inicial"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(496, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Hora"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(368, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndone
        '
        Me.btndone.Enabled = False
        Me.btndone.Location = New System.Drawing.Point(624, 24)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(32, 56)
        Me.btndone.TabIndex = 13
        Me.btndone.Text = "OK"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtfechaapertura)
        Me.GroupBox2.Controls.Add(Me.txtcodaperturacajero)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(8, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 53)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apertura"
        '
        'txtfechaapertura
        '
        Me.txtfechaapertura.BackColor = System.Drawing.SystemColors.Control
        Me.txtfechaapertura.Location = New System.Drawing.Point(80, 28)
        Me.txtfechaapertura.Name = "txtfechaapertura"
        Me.txtfechaapertura.Size = New System.Drawing.Size(168, 16)
        Me.txtfechaapertura.TabIndex = 3
        Me.txtfechaapertura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcodaperturacajero
        '
        Me.txtcodaperturacajero.BackColor = System.Drawing.SystemColors.Control
        Me.txtcodaperturacajero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCierreCaja1, "cierrecaja.Apertura", True))
        Me.txtcodaperturacajero.Location = New System.Drawing.Point(8, 31)
        Me.txtcodaperturacajero.Name = "txtcodaperturacajero"
        Me.txtcodaperturacajero.Size = New System.Drawing.Size(64, 16)
        Me.txtcodaperturacajero.TabIndex = 2
        Me.txtcodaperturacajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(80, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha / Hora"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.dgResumen)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox4.Location = New System.Drawing.Point(280, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(488, 192)
        Me.GroupBox4.TabIndex = 64
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle Operaciones"
        '
        'dgResumen
        '
        Me.dgResumen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dgResumen.EmbeddedNavigator.Name = ""
        Me.dgResumen.Location = New System.Drawing.Point(8, 16)
        Me.dgResumen.MainView = Me.GridView2
        Me.dgResumen.Name = "dgResumen"
        Me.dgResumen.Size = New System.Drawing.Size(472, 168)
        Me.dgResumen.TabIndex = 1
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn5, Me.GridColumn4, Me.GridColumn3, Me.GridColumn2, Me.GridColumn1})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFilterPanel = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Factura"
        Me.GridColumn6.FieldName = "Factura"
        Me.GridColumn6.FilterInfo = ColumnFilterInfo1
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 55
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Tipo"
        Me.GridColumn5.FieldName = "Tipo"
        Me.GridColumn5.FilterInfo = ColumnFilterInfo2
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 46
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Moneda"
        Me.GridColumn4.FieldName = "Moneda"
        Me.GridColumn4.FilterInfo = ColumnFilterInfo3
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 69
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Pago"
        Me.GridColumn3.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Pago"
        Me.GridColumn3.FilterInfo = ColumnFilterInfo4
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.StyleName = "Style1"
        Me.GridColumn3.VisibleIndex = 4
        Me.GridColumn3.Width = 69
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Forma Pago"
        Me.GridColumn2.FieldName = "Forma Pago"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo5
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 76
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Equivalencia"
        Me.GridColumn1.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Equivalencia"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo6
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.StyleName = "Style1"
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 79
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'AdapterTotalTope
        '
        Me.AdapterTotalTope.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterTotalTope.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Apertura_Total_Tope", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_total_tope", "id_total_tope"), New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Monto_Tope", "Monto_Tope"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT id_total_tope, NApertura, CodMoneda, Monto_Tope, MonedaNombre FROM Apertur" & _
    "a_Total_Tope"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'AdapterArqueo
        '
        Me.AdapterArqueo.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterArqueo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArqueoCajas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("EfectivoColones", "EfectivoColones"), New System.Data.Common.DataColumnMapping("EfectivoDolares", "EfectivoDolares"), New System.Data.Common.DataColumnMapping("TarjetaColones", "TarjetaColones"), New System.Data.Common.DataColumnMapping("TarjetaDolares", "TarjetaDolares"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("IdApertura", "IdApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Cajero", "Cajero"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("TipoCambioD", "TipoCambioD"), New System.Data.Common.DataColumnMapping("Cheques", "Cheques"), New System.Data.Common.DataColumnMapping("ChequesDol", "ChequesDol"), New System.Data.Common.DataColumnMapping("DepositoCol", "DepositoCol"), New System.Data.Common.DataColumnMapping("DepositoDol", "DepositoDol")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Id, EfectivoColones, EfectivoDolares, TarjetaColones, TarjetaDolares, Tota" & _
    "l, IdApertura, Fecha, Cajero, Anulado, TipoCambioD, Cheques, ChequesDol, Deposit" & _
    "oCol, DepositoDol FROM ArqueoCajas"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'AdapterTarjeta
        '
        Me.AdapterTarjeta.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterTarjeta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArqueoTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Arqueo", "Id_Arqueo"), New System.Data.Common.DataColumnMapping("Id_Tarjeta", "Id_Tarjeta"), New System.Data.Common.DataColumnMapping("Monto", "Monto")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Id, Id_Arqueo, Id_Tarjeta, Monto FROM ArqueoTarjeta"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(24, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 16)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Fondo Caja"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtPrepagosAplicados)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.btnSuvesa)
        Me.GroupBox3.Controls.Add(Me.txtanuladas)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.TextEdit14)
        Me.GroupBox3.Controls.Add(Me.txtDevoluciones)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.txtDepositar)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.txtSalidas)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txtEntradas)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.TextEdit20)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.TextEdit16)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TextEdit6)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextEdit4)
        Me.GroupBox3.Controls.Add(Me.TxtFondoCaja)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextEdit17)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Location = New System.Drawing.Point(280, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 256)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cierre Caja"
        '
        'btnSuvesa
        '
        Me.btnSuvesa.Location = New System.Drawing.Point(158, 203)
        Me.btnSuvesa.Name = "btnSuvesa"
        Me.btnSuvesa.Size = New System.Drawing.Size(67, 21)
        Me.btnSuvesa.TabIndex = 97
        Me.btnSuvesa.Text = "SUVESA"
        Me.btnSuvesa.UseVisualStyleBackColor = True
        '
        'txtanuladas
        '
        Me.txtanuladas.EditValue = "0.00"
        Me.txtanuladas.Location = New System.Drawing.Point(24, 147)
        Me.txtanuladas.Name = "txtanuladas"
        '
        '
        '
        Me.txtanuladas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtanuladas.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtanuladas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtanuladas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtanuladas.Properties.ReadOnly = True
        Me.txtanuladas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Red)
        Me.txtanuladas.Size = New System.Drawing.Size(200, 19)
        Me.txtanuladas.TabIndex = 96
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label39.Location = New System.Drawing.Point(24, 134)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(200, 12)
        Me.Label39.TabIndex = 95
        Me.Label39.Text = "Anulaciones"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit14
        '
        Me.TextEdit14.EditValue = "0.00"
        Me.TextEdit14.Location = New System.Drawing.Point(264, 32)
        Me.TextEdit14.Name = "TextEdit14"
        '
        '
        '
        Me.TextEdit14.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit14.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit14.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit14.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit14.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit14.Properties.ReadOnly = True
        Me.TextEdit14.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit14.Size = New System.Drawing.Size(200, 19)
        Me.TextEdit14.TabIndex = 94
        '
        'txtDevoluciones
        '
        Me.txtDevoluciones.EditValue = "0.00"
        Me.txtDevoluciones.Location = New System.Drawing.Point(24, 112)
        Me.txtDevoluciones.Name = "txtDevoluciones"
        '
        '
        '
        Me.txtDevoluciones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDevoluciones.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDevoluciones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevoluciones.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDevoluciones.Properties.ReadOnly = True
        Me.txtDevoluciones.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDevoluciones.Size = New System.Drawing.Size(200, 19)
        Me.txtDevoluciones.TabIndex = 93
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label38.Location = New System.Drawing.Point(24, 96)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(200, 16)
        Me.Label38.TabIndex = 92
        Me.Label38.Text = "Devoluciones"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDepositar
        '
        Me.txtDepositar.EditValue = "0.00"
        Me.txtDepositar.Location = New System.Drawing.Point(264, 224)
        Me.txtDepositar.Name = "txtDepositar"
        '
        '
        '
        Me.txtDepositar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDepositar.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDepositar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepositar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepositar.Properties.ReadOnly = True
        Me.txtDepositar.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDepositar.Size = New System.Drawing.Size(200, 19)
        Me.txtDepositar.TabIndex = 91
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label33.Location = New System.Drawing.Point(264, 208)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(208, 16)
        Me.Label33.TabIndex = 90
        Me.Label33.Text = "Monto a Depositar"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalidas
        '
        Me.txtSalidas.EditValue = "0.00"
        Me.txtSalidas.Location = New System.Drawing.Point(368, 112)
        Me.txtSalidas.Name = "txtSalidas"
        '
        '
        '
        Me.txtSalidas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtSalidas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSalidas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSalidas.Properties.ReadOnly = True
        Me.txtSalidas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtSalidas.Size = New System.Drawing.Size(96, 19)
        Me.txtSalidas.TabIndex = 89
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label31.Location = New System.Drawing.Point(368, 96)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 16)
        Me.Label31.TabIndex = 88
        Me.Label31.Text = "Salidas"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEntradas
        '
        Me.txtEntradas.EditValue = "0.00"
        Me.txtEntradas.Location = New System.Drawing.Point(264, 112)
        Me.txtEntradas.Name = "txtEntradas"
        '
        '
        '
        Me.txtEntradas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtEntradas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEntradas.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEntradas.Properties.ReadOnly = True
        Me.txtEntradas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtEntradas.Size = New System.Drawing.Size(96, 19)
        Me.txtEntradas.TabIndex = 87
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label30.Location = New System.Drawing.Point(264, 96)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 86
        Me.Label30.Text = "Entradas"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit20
        '
        Me.TextEdit20.EditValue = "0.00"
        Me.TextEdit20.Location = New System.Drawing.Point(264, 72)
        Me.TextEdit20.Name = "TextEdit20"
        '
        '
        '
        Me.TextEdit20.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit20.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit20.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit20.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit20.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit20.Properties.ReadOnly = True
        Me.TextEdit20.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit20.Size = New System.Drawing.Size(200, 19)
        Me.TextEdit20.TabIndex = 85
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label23.Location = New System.Drawing.Point(264, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(208, 16)
        Me.Label23.TabIndex = 84
        Me.Label23.Text = "Ventas Crédito"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit16
        '
        Me.TextEdit16.EditValue = "0.00"
        Me.TextEdit16.Location = New System.Drawing.Point(264, 184)
        Me.TextEdit16.Name = "TextEdit16"
        '
        '
        '
        Me.TextEdit16.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit16.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit16.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit16.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit16.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit16.Properties.ReadOnly = True
        Me.TextEdit16.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit16.Size = New System.Drawing.Size(200, 19)
        Me.TextEdit16.TabIndex = 83
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label20.Location = New System.Drawing.Point(264, 168)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(200, 16)
        Me.Label20.TabIndex = 82
        Me.Label20.Text = "Total Cajero"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit6
        '
        Me.TextEdit6.EditValue = "0.00"
        Me.TextEdit6.Location = New System.Drawing.Point(24, 184)
        Me.TextEdit6.Name = "TextEdit6"
        '
        '
        '
        Me.TextEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit6.Size = New System.Drawing.Size(200, 19)
        Me.TextEdit6.TabIndex = 81
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(24, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(200, 16)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Total Sistema"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit4
        '
        Me.TextEdit4.EditValue = "0.00"
        Me.TextEdit4.Location = New System.Drawing.Point(24, 72)
        Me.TextEdit4.Name = "TextEdit4"
        '
        '
        '
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit4.Size = New System.Drawing.Size(200, 19)
        Me.TextEdit4.TabIndex = 77
        '
        'TxtFondoCaja
        '
        Me.TxtFondoCaja.EditValue = "0.00"
        Me.TxtFondoCaja.Location = New System.Drawing.Point(24, 32)
        Me.TxtFondoCaja.Name = "TxtFondoCaja"
        '
        '
        '
        Me.TxtFondoCaja.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtFondoCaja.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtFondoCaja.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFondoCaja.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtFondoCaja.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFondoCaja.Properties.ReadOnly = True
        Me.TxtFondoCaja.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TxtFondoCaja.Size = New System.Drawing.Size(200, 19)
        Me.TxtFondoCaja.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(24, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 16)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Abonos"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(272, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 16)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Ventas Contado"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit17
        '
        Me.TextEdit17.EditValue = "0.00"
        Me.TextEdit17.Location = New System.Drawing.Point(24, 224)
        Me.TextEdit17.Name = "TextEdit17"
        '
        '
        '
        Me.TextEdit17.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit17.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit17.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit17.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit17.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit17.Properties.ReadOnly = True
        Me.TextEdit17.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit17.Size = New System.Drawing.Size(200, 19)
        Me.TextEdit17.TabIndex = 83
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label21.Location = New System.Drawing.Point(24, 208)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(156, 16)
        Me.Label21.TabIndex = 82
        Me.Label21.Text = "Diferencial Caja"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = "0.00"
        Me.TextEdit2.Location = New System.Drawing.Point(8, 88)
        Me.TextEdit2.Name = "TextEdit2"
        '
        '
        '
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit2.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit2.TabIndex = 71
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = "0.00"
        Me.TextEdit1.Location = New System.Drawing.Point(8, 48)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit1.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit1.TabIndex = 70
        '
        'AdapterTipoTarjeta
        '
        Me.AdapterTipoTarjeta.SelectCommand = Me.SqlSelectCommand9
        Me.AdapterTipoTarjeta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Id, Nombre, Moneda FROM TipoTarjeta"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.GridControl2)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox5.Location = New System.Drawing.Point(280, 304)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(488, 104)
        Me.GroupBox5.TabIndex = 67
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalles Trajetas de Crédito"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.DataMember = "TipoTarjeta"
        Me.GridControl2.DataSource = Me.DataSetCierreCaja1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 16)
        Me.GridControl2.MainView = Me.GridView1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(472, 80)
        Me.GridControl2.TabIndex = 12
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.GridView1.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tarjeta"
        Me.GridColumn7.FieldName = "Nombre"
        Me.GridColumn7.FilterInfo = ColumnFilterInfo7
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 125
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Total Cajero"
        Me.GridColumn8.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Total"
        Me.GridColumn8.FilterInfo = ColumnFilterInfo8
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 118
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Moneda"
        Me.GridColumn9.FieldName = "Monedas"
        Me.GridColumn9.FilterInfo = ColumnFilterInfo9
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 102
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Total Sistema"
        Me.GridColumn10.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "TotalS"
        Me.GridColumn10.FilterInfo = ColumnFilterInfo10
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 113
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txtDepDolSistema)
        Me.GroupBox6.Controls.Add(Me.txtDepDolCajero)
        Me.GroupBox6.Controls.Add(Me.Label37)
        Me.GroupBox6.Controls.Add(Me.TxtDepoColSistena)
        Me.GroupBox6.Controls.Add(Me.txtDepoColCajero)
        Me.GroupBox6.Controls.Add(Me.Label35)
        Me.GroupBox6.Controls.Add(Me.txtChequesDolSistema)
        Me.GroupBox6.Controls.Add(Me.txtChequesDolCajero)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Controls.Add(Me.txtChequesSistema)
        Me.GroupBox6.Controls.Add(Me.txtChequesCajero)
        Me.GroupBox6.Controls.Add(Me.Label32)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.TextEdit18)
        Me.GroupBox6.Controls.Add(Me.TextEdit19)
        Me.GroupBox6.Controls.Add(Me.TextEdit10)
        Me.GroupBox6.Controls.Add(Me.TextEdit11)
        Me.GroupBox6.Controls.Add(Me.TextEdit8)
        Me.GroupBox6.Controls.Add(Me.TextEdit9)
        Me.GroupBox6.Controls.Add(Me.TextEdit7)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.TextEdit5)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.TextEdit1)
        Me.GroupBox6.Controls.Add(Me.TextEdit2)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox6.Location = New System.Drawing.Point(8, 224)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(256, 400)
        Me.GroupBox6.TabIndex = 68
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "General"
        '
        'txtDepDolSistema
        '
        Me.txtDepDolSistema.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.DepositosDol", True))
        Me.txtDepDolSistema.EditValue = "0.00"
        Me.txtDepDolSistema.Location = New System.Drawing.Point(128, 328)
        Me.txtDepDolSistema.Name = "txtDepDolSistema"
        '
        '
        '
        Me.txtDepDolSistema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDepDolSistema.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDepDolSistema.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepDolSistema.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepDolSistema.Properties.ReadOnly = True
        Me.txtDepDolSistema.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDepDolSistema.Size = New System.Drawing.Size(120, 19)
        Me.txtDepDolSistema.TabIndex = 105
        '
        'txtDepDolCajero
        '
        Me.txtDepDolCajero.EditValue = "0.00"
        Me.txtDepDolCajero.Location = New System.Drawing.Point(8, 328)
        Me.txtDepDolCajero.Name = "txtDepDolCajero"
        '
        '
        '
        Me.txtDepDolCajero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDepDolCajero.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDepDolCajero.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepDolCajero.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepDolCajero.Properties.ReadOnly = True
        Me.txtDepDolCajero.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDepDolCajero.Size = New System.Drawing.Size(120, 19)
        Me.txtDepDolCajero.TabIndex = 104
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label37.Location = New System.Drawing.Point(8, 312)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(240, 16)
        Me.Label37.TabIndex = 103
        Me.Label37.Text = "Depositos Dolares"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDepoColSistena
        '
        Me.TxtDepoColSistena.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.DepositosCol", True))
        Me.TxtDepoColSistena.EditValue = "0.00"
        Me.TxtDepoColSistena.Location = New System.Drawing.Point(128, 288)
        Me.TxtDepoColSistena.Name = "TxtDepoColSistena"
        '
        '
        '
        Me.TxtDepoColSistena.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TxtDepoColSistena.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtDepoColSistena.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDepoColSistena.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDepoColSistena.Properties.ReadOnly = True
        Me.TxtDepoColSistena.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TxtDepoColSistena.Size = New System.Drawing.Size(120, 19)
        Me.TxtDepoColSistena.TabIndex = 102
        '
        'txtDepoColCajero
        '
        Me.txtDepoColCajero.EditValue = "0.00"
        Me.txtDepoColCajero.Location = New System.Drawing.Point(8, 288)
        Me.txtDepoColCajero.Name = "txtDepoColCajero"
        '
        '
        '
        Me.txtDepoColCajero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDepoColCajero.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDepoColCajero.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepoColCajero.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDepoColCajero.Properties.ReadOnly = True
        Me.txtDepoColCajero.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDepoColCajero.Size = New System.Drawing.Size(120, 19)
        Me.txtDepoColCajero.TabIndex = 101
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label35.Location = New System.Drawing.Point(8, 272)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(240, 16)
        Me.Label35.TabIndex = 100
        Me.Label35.Text = "Depositos Colones"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtChequesDolSistema
        '
        Me.txtChequesDolSistema.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.ChequeDol", True))
        Me.txtChequesDolSistema.EditValue = "0.00"
        Me.txtChequesDolSistema.Location = New System.Drawing.Point(128, 248)
        Me.txtChequesDolSistema.Name = "txtChequesDolSistema"
        '
        '
        '
        Me.txtChequesDolSistema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtChequesDolSistema.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtChequesDolSistema.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesDolSistema.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesDolSistema.Properties.ReadOnly = True
        Me.txtChequesDolSistema.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtChequesDolSistema.Size = New System.Drawing.Size(120, 19)
        Me.txtChequesDolSistema.TabIndex = 99
        '
        'txtChequesDolCajero
        '
        Me.txtChequesDolCajero.EditValue = "0.00"
        Me.txtChequesDolCajero.Location = New System.Drawing.Point(8, 248)
        Me.txtChequesDolCajero.Name = "txtChequesDolCajero"
        '
        '
        '
        Me.txtChequesDolCajero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtChequesDolCajero.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtChequesDolCajero.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesDolCajero.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesDolCajero.Properties.ReadOnly = True
        Me.txtChequesDolCajero.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtChequesDolCajero.Size = New System.Drawing.Size(120, 19)
        Me.txtChequesDolCajero.TabIndex = 98
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label34.Location = New System.Drawing.Point(8, 232)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(240, 16)
        Me.Label34.TabIndex = 97
        Me.Label34.Text = "Cheques Dolares"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtChequesSistema
        '
        Me.txtChequesSistema.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.Cheques", True))
        Me.txtChequesSistema.EditValue = "0.00"
        Me.txtChequesSistema.Location = New System.Drawing.Point(128, 208)
        Me.txtChequesSistema.Name = "txtChequesSistema"
        '
        '
        '
        Me.txtChequesSistema.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtChequesSistema.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtChequesSistema.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesSistema.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesSistema.Properties.ReadOnly = True
        Me.txtChequesSistema.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtChequesSistema.Size = New System.Drawing.Size(120, 19)
        Me.txtChequesSistema.TabIndex = 96
        '
        'txtChequesCajero
        '
        Me.txtChequesCajero.EditValue = "0.00"
        Me.txtChequesCajero.Location = New System.Drawing.Point(8, 208)
        Me.txtChequesCajero.Name = "txtChequesCajero"
        '
        '
        '
        Me.txtChequesCajero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtChequesCajero.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtChequesCajero.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesCajero.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtChequesCajero.Properties.ReadOnly = True
        Me.txtChequesCajero.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtChequesCajero.Size = New System.Drawing.Size(120, 19)
        Me.txtChequesCajero.TabIndex = 95
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label32.Location = New System.Drawing.Point(8, 192)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(240, 16)
        Me.Label32.TabIndex = 94
        Me.Label32.Text = "Cheques Colones"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 352)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(248, 16)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "      Total Cajero      /      Total Sistema"
        '
        'TextEdit18
        '
        Me.TextEdit18.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.TotalSistema", True))
        Me.TextEdit18.EditValue = "0.00"
        Me.TextEdit18.Location = New System.Drawing.Point(128, 376)
        Me.TextEdit18.Name = "TextEdit18"
        '
        '
        '
        Me.TextEdit18.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit18.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit18.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit18.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit18.Properties.ReadOnly = True
        Me.TextEdit18.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit18.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit18.TabIndex = 92
        '
        'TextEdit19
        '
        Me.TextEdit19.EditValue = "0.00"
        Me.TextEdit19.Location = New System.Drawing.Point(8, 376)
        Me.TextEdit19.Name = "TextEdit19"
        '
        '
        '
        Me.TextEdit19.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit19.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit19.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit19.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit19.Properties.ReadOnly = True
        Me.TextEdit19.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit19.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit19.TabIndex = 91
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.TarjetaDolares", True))
        Me.TextEdit10.EditValue = "0.00"
        Me.TextEdit10.Location = New System.Drawing.Point(128, 168)
        Me.TextEdit10.Name = "TextEdit10"
        '
        '
        '
        Me.TextEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit10.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit10.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit10.TabIndex = 87
        '
        'TextEdit11
        '
        Me.TextEdit11.EditValue = "0.00"
        Me.TextEdit11.Location = New System.Drawing.Point(8, 168)
        Me.TextEdit11.Name = "TextEdit11"
        '
        '
        '
        Me.TextEdit11.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit11.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit11.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit11.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit11.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit11.Properties.ReadOnly = True
        Me.TextEdit11.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit11.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit11.TabIndex = 86
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.TarjetaColones", True))
        Me.TextEdit8.EditValue = "0.00"
        Me.TextEdit8.Location = New System.Drawing.Point(128, 128)
        Me.TextEdit8.Name = "TextEdit8"
        '
        '
        '
        Me.TextEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit8.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit8.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit8.TabIndex = 85
        '
        'TextEdit9
        '
        Me.TextEdit9.EditValue = "0.00"
        Me.TextEdit9.Location = New System.Drawing.Point(8, 128)
        Me.TextEdit9.Name = "TextEdit9"
        '
        '
        '
        Me.TextEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit9.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit9.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit9.TabIndex = 84
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.EfectivoDolares", True))
        Me.TextEdit7.EditValue = "0.00"
        Me.TextEdit7.Location = New System.Drawing.Point(128, 88)
        Me.TextEdit7.Name = "TextEdit7"
        '
        '
        '
        Me.TextEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit7.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit7.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit7.TabIndex = 83
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Location = New System.Drawing.Point(8, 152)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(240, 16)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = "Tarjeta Dolares"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Location = New System.Drawing.Point(8, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(240, 16)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = "Tarjeta Colones"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.EfectivoColones", True))
        Me.TextEdit5.EditValue = "0.00"
        Me.TextEdit5.Location = New System.Drawing.Point(128, 48)
        Me.TextEdit5.Name = "TextEdit5"
        '
        '
        '
        Me.TextEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TextEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit5.Size = New System.Drawing.Size(120, 19)
        Me.TextEdit5.TabIndex = 79
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Location = New System.Drawing.Point(8, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(240, 16)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "Efectivo Dolares"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(3, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(248, 18)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "           Cajero          /          Sistema"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(8, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(240, 16)
        Me.Label14.TabIndex = 76
        Me.Label14.Text = "Efectivo Colones"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdapterDetallePago
        '
        Me.AdapterDetallePago.SelectCommand = Me.SqlSelectCommand10
        Me.AdapterDetallePago.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Detalle_pago_caja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumeroFactura", "NumeroFactura"), New System.Data.Common.DataColumnMapping("TipoFactura", "TipoFactura"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("Referencia", "Referencia"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("ReferenciaTipo", "ReferenciaTipo"), New System.Data.Common.DataColumnMapping("ReferenciaDoc", "ReferenciaDoc"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_ODP", "Id_ODP")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT NumeroFactura, TipoFactura, FormaPago, Referencia, Documento, ReferenciaTi" & _
    "po, ReferenciaDoc, Moneda, TipoCambio, Id, Id_ODP FROM Detalle_pago_caja"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'AdapterVentasContado
        '
        Me.AdapterVentasContado.SelectCommand = Me.SqlSelectCommand11
        Me.AdapterVentasContado.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VentasContado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Num_Factura, Total, Num_Apertura, Anulado, Tipo, Cod_Moneda FROM VentasCon" & _
    "tado"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        '
        'AdapterCierreMonto
        '
        Me.AdapterCierreMonto.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterCierreMonto.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterCierreMonto.SelectCommand = Me.SqlSelectCommand14
        Me.AdapterCierreMonto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CierreCaja_DetMon", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_DetaMoneda", "Id_DetaMoneda"), New System.Data.Common.DataColumnMapping("Id_CierreCaja", "Id_CierreCaja"), New System.Data.Common.DataColumnMapping("Id_Moneda", "Id_Moneda"), New System.Data.Common.DataColumnMapping("MontoSistema", "MontoSistema"), New System.Data.Common.DataColumnMapping("MontoCajero", "MontoCajero")})})
        Me.AdapterCierreMonto.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_DetaMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetaMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreCaja", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreCaja", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCajero", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoSistema", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoSistema", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreCaja", System.Data.SqlDbType.Int, 4, "Id_CierreCaja"), New System.Data.SqlClient.SqlParameter("@Id_Moneda", System.Data.SqlDbType.Int, 4, "Id_Moneda"), New System.Data.SqlClient.SqlParameter("@MontoSistema", System.Data.SqlDbType.Float, 8, "MontoSistema"), New System.Data.SqlClient.SqlParameter("@MontoCajero", System.Data.SqlDbType.Float, 8, "MontoCajero")})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT Id_DetaMoneda, Id_CierreCaja, Id_Moneda, MontoSistema, MontoCajero FROM Ci" & _
    "erreCaja_DetMon"
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreCaja", System.Data.SqlDbType.Int, 4, "Id_CierreCaja"), New System.Data.SqlClient.SqlParameter("@Id_Moneda", System.Data.SqlDbType.Int, 4, "Id_Moneda"), New System.Data.SqlClient.SqlParameter("@MontoSistema", System.Data.SqlDbType.Float, 8, "MontoSistema"), New System.Data.SqlClient.SqlParameter("@MontoCajero", System.Data.SqlDbType.Float, 8, "MontoCajero"), New System.Data.SqlClient.SqlParameter("@Original_Id_DetaMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetaMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreCaja", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreCaja", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCajero", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoSistema", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoSistema", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_DetaMoneda", System.Data.SqlDbType.Int, 4, "Id_DetaMoneda")})
        '
        'AdapterCierreTarjeta
        '
        Me.AdapterCierreTarjeta.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterCierreTarjeta.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterCierreTarjeta.SelectCommand = Me.SqlSelectCommand15
        Me.AdapterCierreTarjeta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CierreCaja_DetTarj", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_DetalleTarjeta", "Id_DetalleTarjeta"), New System.Data.Common.DataColumnMapping("Id_CierreCaja", "Id_CierreCaja"), New System.Data.Common.DataColumnMapping("Id_TipoTarjeta", "Id_TipoTarjeta"), New System.Data.Common.DataColumnMapping("MontoSistema", "MontoSistema"), New System.Data.Common.DataColumnMapping("MontoCajero", "MontoCajero")})})
        Me.AdapterCierreTarjeta.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleTarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleTarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreCaja", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreCaja", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_TipoTarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_TipoTarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCajero", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoSistema", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoSistema", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreCaja", System.Data.SqlDbType.Int, 4, "Id_CierreCaja"), New System.Data.SqlClient.SqlParameter("@Id_TipoTarjeta", System.Data.SqlDbType.Int, 4, "Id_TipoTarjeta"), New System.Data.SqlClient.SqlParameter("@MontoSistema", System.Data.SqlDbType.Float, 8, "MontoSistema"), New System.Data.SqlClient.SqlParameter("@MontoCajero", System.Data.SqlDbType.Float, 8, "MontoCajero")})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT Id_DetalleTarjeta, Id_CierreCaja, Id_TipoTarjeta, MontoSistema, MontoCajer" & _
    "o FROM CierreCaja_DetTarj"
        Me.SqlSelectCommand15.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreCaja", System.Data.SqlDbType.Int, 4, "Id_CierreCaja"), New System.Data.SqlClient.SqlParameter("@Id_TipoTarjeta", System.Data.SqlDbType.Int, 4, "Id_TipoTarjeta"), New System.Data.SqlClient.SqlParameter("@MontoSistema", System.Data.SqlDbType.Float, 8, "MontoSistema"), New System.Data.SqlClient.SqlParameter("@MontoCajero", System.Data.SqlDbType.Float, 8, "MontoCajero"), New System.Data.SqlClient.SqlParameter("@Original_Id_DetalleTarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DetalleTarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreCaja", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreCaja", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_TipoTarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_TipoTarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoCajero", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoCajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MontoSistema", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MontoSistema", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_DetalleTarjeta", System.Data.SqlDbType.Int, 4, "Id_DetalleTarjeta")})
        '
        'lblanulado
        '
        Me.lblanulado.BackColor = System.Drawing.Color.Transparent
        Me.lblanulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanulado.ForeColor = System.Drawing.Color.Red
        Me.lblanulado.Location = New System.Drawing.Point(352, 352)
        Me.lblanulado.Name = "lblanulado"
        Me.lblanulado.Size = New System.Drawing.Size(320, 96)
        Me.lblanulado.TabIndex = 69
        Me.lblanulado.Text = "Anulado"
        Me.lblanulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblanulado.Visible = False
        '
        'AdapterVentasCredito
        '
        Me.AdapterVentasCredito.SelectCommand = Me.SqlSelectCommand12
        Me.AdapterVentasCredito.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VentasCredito", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Num_Factura", "Num_Factura"), New System.Data.Common.DataColumnMapping("Num_Apertura", "Num_Apertura"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Cod_Cliente", "Cod_Cliente")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT Expr1, SubTotal, Total, Num_Factura, Num_Apertura, Id, Cod_Moneda, Cod_Cli" & _
    "ente FROM VentasCredito"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonBuscarCajero)
        Me.GroupBox1.Controls.Add(Me.DateEdit1)
        Me.GroupBox1.Controls.Add(Me.txtnomcajero)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtcodcajero)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.TimeEdit3)
        Me.GroupBox1.Controls.Add(Me.TimeEdit4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 88)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período Cierre"
        '
        'ButtonBuscarCajero
        '
        Me.ButtonBuscarCajero.Location = New System.Drawing.Point(119, 30)
        Me.ButtonBuscarCajero.Name = "ButtonBuscarCajero"
        Me.ButtonBuscarCajero.Size = New System.Drawing.Size(29, 19)
        Me.ButtonBuscarCajero.TabIndex = 15
        Me.ButtonBuscarCajero.Text = "F1"
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreCaja1, "cierrecaja.Fecha", True))
        Me.DateEdit1.EditValue = New Date(2006, 5, 10, 0, 0, 0, 0)
        Me.DateEdit1.Location = New System.Drawing.Point(155, 30)
        Me.DateEdit1.Name = "DateEdit1"
        '
        '
        '
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.Enabled = False
        Me.DateEdit1.Size = New System.Drawing.Size(88, 23)
        Me.DateEdit1.TabIndex = 5
        '
        'txtnomcajero
        '
        Me.txtnomcajero.BackColor = System.Drawing.SystemColors.Control
        Me.txtnomcajero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCierreCaja1, "cierrecaja.Nombre", True))
        Me.txtnomcajero.Location = New System.Drawing.Point(8, 67)
        Me.txtnomcajero.Name = "txtnomcajero"
        Me.txtnomcajero.Size = New System.Drawing.Size(240, 16)
        Me.txtnomcajero.TabIndex = 14
        Me.txtnomcajero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(155, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fecha Cierre"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Location = New System.Drawing.Point(8, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Código Cajero"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcodcajero
        '
        Me.txtcodcajero.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcodcajero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcodcajero.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCierreCaja1, "cierrecaja.Cajera", True))
        Me.txtcodcajero.ForeColor = System.Drawing.Color.Blue
        Me.txtcodcajero.Location = New System.Drawing.Point(8, 30)
        Me.txtcodcajero.Multiline = True
        Me.txtcodcajero.Name = "txtcodcajero"
        Me.txtcodcajero.ReadOnly = True
        Me.txtcodcajero.Size = New System.Drawing.Size(104, 16)
        Me.txtcodcajero.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label24.Location = New System.Drawing.Point(8, 51)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(240, 16)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Nombre"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeEdit3
        '
        Me.TimeEdit3.EditValue = New Date(2006, 3, 15, 11, 33, 32, 375)
        Me.TimeEdit3.Location = New System.Drawing.Point(496, 56)
        Me.TimeEdit3.Name = "TimeEdit3"
        '
        '
        '
        Me.TimeEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEdit3.Properties.UseCtrlIncrement = False
        Me.TimeEdit3.Size = New System.Drawing.Size(96, 19)
        Me.TimeEdit3.TabIndex = 12
        '
        'TimeEdit4
        '
        Me.TimeEdit4.EditValue = New Date(2006, 3, 15, 11, 33, 32, 375)
        Me.TimeEdit4.Location = New System.Drawing.Point(496, 32)
        Me.TimeEdit4.Name = "TimeEdit4"
        '
        '
        '
        Me.TimeEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEdit4.Properties.UseCtrlIncrement = False
        Me.TimeEdit4.Size = New System.Drawing.Size(96, 19)
        Me.TimeEdit4.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(360, 56)
        Me.DateTimePicker1.MaxDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 11
        Me.DateTimePicker1.Value = New Date(2006, 1, 1, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(360, 32)
        Me.DateTimePicker2.MaxDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(2006, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 7
        Me.DateTimePicker2.Value = New Date(2006, 1, 1, 0, 0, 0, 0)
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(304, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 16)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Final"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Location = New System.Drawing.Point(304, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 16)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Inicial"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.Location = New System.Drawing.Point(496, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 16)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Hora"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.Location = New System.Drawing.Point(368, 16)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 16)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Fecha"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(624, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 56)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "OK"
        '
        'txtPrepagosAplicados
        '
        Me.txtPrepagosAplicados.EditValue = "0.00"
        Me.txtPrepagosAplicados.Location = New System.Drawing.Point(264, 147)
        Me.txtPrepagosAplicados.Name = "txtPrepagosAplicados"
        '
        '
        '
        Me.txtPrepagosAplicados.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPrepagosAplicados.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtPrepagosAplicados.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrepagosAplicados.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrepagosAplicados.Properties.ReadOnly = True
        Me.txtPrepagosAplicados.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtPrepagosAplicados.Size = New System.Drawing.Size(200, 19)
        Me.txtPrepagosAplicados.TabIndex = 99
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label40.Location = New System.Drawing.Point(264, 131)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(200, 16)
        Me.Label40.TabIndex = 98
        Me.Label40.Text = "Prepagos Aplicados"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CierreCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(778, 691)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblanulado)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.TextBox6)
        Me.Name = "CierreCaja"
        Me.Text = "Cierre Caja"
        Me.Controls.SetChildIndex(Me.TextBox6, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Controls.SetChildIndex(Me.lblanulado, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        CType(Me.DataSetCierreCaja1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txtanuladas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDevoluciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepositar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalidas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntradas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit20.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFondoCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit17.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.txtDepDolSistema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepDolCajero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDepoColSistena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepoColCajero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequesDolSistema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequesDolCajero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequesSistema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChequesCajero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit18.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit19.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrepagosAplicados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Function AplicaCambioenCaja() As Boolean
        Dim dt As New DataTable
        Dim Modocaja As Boolean = False
        cFunciones.Llenar_Tabla_Generico("Select ModoCaja from Configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Modocaja = dt.Rows(0).Item("ModoCaja")
        End If
        Return Modocaja
    End Function
    Private Sub CierreCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.AplicaCambioenCaja = True Then
            'si es el servidor de liberia
            Me.btnSuvesa.Visible = True
        Else
            Me.btnSuvesa.Visible = False
        End If

        SqlConnection1.ConnectionString = CadenaConexionSeePOS()
        AdapterMoneda.Fill(Me.DataSetCierreCaja1.Moneda)
        AdapterUsuarios.Fill(Me.DataSetCierreCaja1.Usuarios)
        AdapterTipoTarjeta.Fill(Me.DataSetCierreCaja1.TipoTarjeta)
        AdapterDetallePago.Fill(Me.DataSetCierreCaja1.Detalle_pago_caja)
        FormatoTablas()
        defaultvalue()
    End Sub

    Private Sub defaultvalue()
        Dim i, j As Integer
        DataSetCierreCaja1.cierrecaja.AperturaColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.CajeraColumn.DefaultValue = ""
        DataSetCierreCaja1.cierrecaja.NombreColumn.DefaultValue = ""
        DataSetCierreCaja1.cierrecaja.AnuladoColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.FechaColumn.DefaultValue = Now
        DataSetCierreCaja1.cierrecaja.SubtotalColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.DevolucionesColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.TotalSistemaColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.EquivalenciaColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.EfectivoColonesColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.EfectivoDolaresColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.TarjetaColonesColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.TarjetaDolaresColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.ChequesColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.ChequeDolColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.DepositosColColumn.DefaultValue = 0
        DataSetCierreCaja1.cierrecaja.DepositosDolColumn.DefaultValue = 0

        DataSetCierreCaja1.CierreCaja_DetMon.Id_DetaMonedaColumn.AutoIncrement = True
        DataSetCierreCaja1.CierreCaja_DetMon.Id_DetaMonedaColumn.AutoIncrementSeed = -1
        DataSetCierreCaja1.CierreCaja_DetMon.Id_DetaMonedaColumn.AutoIncrementStep = -1
        DataSetCierreCaja1.CierreCaja_DetMon.Id_MonedaColumn.DefaultValue = 1
        DataSetCierreCaja1.CierreCaja_DetMon.MontoCajeroColumn.DefaultValue = 0
        DataSetCierreCaja1.CierreCaja_DetMon.MontoSistemaColumn.DefaultValue = 0

        DataSetCierreCaja1.CierreCaja_DetTarj.Id_DetalleTarjetaColumn.AutoIncrement = True
        DataSetCierreCaja1.CierreCaja_DetTarj.Id_DetalleTarjetaColumn.AutoIncrementSeed = -1
        DataSetCierreCaja1.CierreCaja_DetTarj.Id_DetalleTarjetaColumn.AutoIncrementStep = -1
        DataSetCierreCaja1.CierreCaja_DetTarj.Id_TipoTarjetaColumn.DefaultValue = 0
        DataSetCierreCaja1.CierreCaja_DetTarj.MontoCajeroColumn.DefaultValue = 0
        DataSetCierreCaja1.CierreCaja_DetTarj.MontoSistemaColumn.DefaultValue = 0

        For i = 0 To DataSetCierreCaja1.TipoTarjeta.Rows.Count - 1
            DataSetCierreCaja1.TipoTarjeta.Rows(i).Item("Total") = 0
            DataSetCierreCaja1.TipoTarjeta.Rows(i).Item("TotalS") = 0
            For j = 0 To DataSetCierreCaja1.Moneda.Rows.Count - 1
                If DataSetCierreCaja1.TipoTarjeta.Rows(i).Item("Moneda") = DataSetCierreCaja1.Moneda.Rows(j).Item("CodMoneda") Then
                    DataSetCierreCaja1.TipoTarjeta.Rows(i).Item("Monedas") = DataSetCierreCaja1.Moneda.Rows(j).Item("MonedaNombre")
                End If
            Next
        Next
    End Sub

    Public Function FormatoTablas()
        'Declara de columnas
        Dim dtfact, dttipo, dtcoin, dtpago, dtformapago, dtmonto As System.Data.DataColumn
        Dim dtmoneda, dtefectivo, dttarjeta, dtcheque, dttransferencia, dtdevolucion, dttotal As System.Data.DataColumn
        Dim dtMonto_cierre, dtmoneda_cierre, dtequivalencia_cierre As System.Data.DataColumn
        'Creacion de las columnas  
        '*******************************************Tabla
        dtmoneda = New System.Data.DataColumn("Moneda")
        dtefectivo = New System.Data.DataColumn("Efectivo")
        dttarjeta = New System.Data.DataColumn("Tarjeta")
        dtcheque = New System.Data.DataColumn("Cheque")
        dttransferencia = New System.Data.DataColumn("Transferencia")
        dtdevolucion = New System.Data.DataColumn("Devoluciones")
        dttotal = New System.Data.DataColumn("Total")
        '********************************************************Tabla Resumen
        dtfact = New System.Data.DataColumn("Factura")
        dttipo = New System.Data.DataColumn("Tipo")
        dtcoin = New System.Data.DataColumn("Moneda")
        dtpago = New System.Data.DataColumn("Pago")
        dtformapago = New System.Data.DataColumn("Forma Pago")
        dtmonto = New System.Data.DataColumn("Equivalencia")
        '**********************************************************Tabla Cierre
        dtMonto_cierre = New System.Data.DataColumn("Monto")
        dtmoneda_cierre = New System.Data.DataColumn("Moneda")
        dtequivalencia_cierre = New System.Data.DataColumn("Equivalencia")
        'Me.chkAnulado.Checked = False

        'Agregar columnas a la data tabla
        '*********************************************************Tabla
        tabla.Columns.Add(dtmoneda)
        tabla.Columns.Add(dtefectivo)
        tabla.Columns.Add(dttarjeta)
        tabla.Columns.Add(dtcheque)
        tabla.Columns.Add(dttransferencia)
        tabla.Columns.Add(dtdevolucion)
        tabla.Columns.Add(dttotal)
        '*********************************************************Tabla Resumen
        tablaresumen.Columns.Add(dtfact)
        tablaresumen.Columns.Add(dttipo)
        tablaresumen.Columns.Add(dtcoin)
        tablaresumen.Columns.Add(dtpago)
        tablaresumen.Columns.Add(dtformapago)
        tablaresumen.Columns.Add(dtmonto)
        '*********************************************************Tabla Cierre
        tablacierre.Columns.Add(dtMonto_cierre)
        tablacierre.Columns.Add(dtmoneda_cierre)
        tablacierre.Columns.Add(dtequivalencia_cierre)
    End Function
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevos()
            Case 2 : If PMU.Find Then Consultar_Cierre() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then Anular() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : Cerrar()
        End Select
    End Sub
#End Region

#Region "Nuevo"
    Private Sub Nuevos()
        Try
            If ToolBar1.Buttons(0).Text = "Nuevo" Then
                'Restricción botones
                lblanulado.Visible = False
                ToolBar1.Buttons(0).Text = "Cancelar"
                ToolBar1.Buttons(0).ImageIndex = 8
                ToolBar1.Buttons(1).Enabled = False
                ToolBar1.Buttons(2).Enabled = True
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(4).Enabled = False
                txtcodcajero.Enabled = True
                txtcodcajero.Focus()
                'Limpia los campos
                ButtonBuscarCajero.Enabled = True
                dgResumen.DataSource = Nothing

                tabla.Clear()
                tablacierre.Clear()
                tablaresumen.Clear()
                DataSetCierreCaja1.aperturacaja.Clear()
                DataSetCierreCaja1.CierreCaja_DetMon.Clear()
                DataSetCierreCaja1.CierreCaja_DetTarj.Clear()
                DataSetCierreCaja1.cierrecaja.Clear()
                DataSetCierreCaja1.ArqueoCajas.Clear()
                DataSetCierreCaja1.Apertura_Total_Tope.Clear()

                BindingContext(Me.DataSetCierreCaja1, "cierrecaja").EndCurrentEdit()
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja").AddNew()

                TextEdit17.EditValue = 0
                TextEdit5.EditValue = 0
                TextEdit18.EditValue = 0
                TextEdit6.EditValue = 0
                TextEdit1.EditValue = 0
                TextEdit2.EditValue = 0
                TextEdit9.EditValue = 0
                TextEdit11.EditValue = 0
                TextEdit16.EditValue = 0
                TxtFondoCaja.EditValue = 0
                TextEdit19.EditValue = 0
                txtChequesCajero.EditValue = 0
                txtChequesSistema.EditValue = 0
                txtChequesDolCajero.EditValue = 0
                txtChequesDolSistema.EditValue = 0
                txtDepoColCajero.EditValue = 0
                TxtDepoColSistena.EditValue = 0
                txtDepDolCajero.EditValue = 0
                txtDepDolSistema.EditValue = 0
                TipoCambioDolar = 0

            Else
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                ToolBar1.Buttons(0).Enabled = True
                ToolBar1.Buttons(1).Enabled = True
                ToolBar1.Buttons(2).Enabled = False
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(4).Enabled = False
                ToolBar1.Buttons(5).Enabled = True
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja").CancelCurrentEdit()
                tabla.Clear()
                tablacierre.Clear()
                tablaresumen.Clear()
                DataSetCierreCaja1.aperturacaja.Clear()
                DataSetCierreCaja1.CierreCaja_DetMon.Clear()
                DataSetCierreCaja1.CierreCaja_DetTarj.Clear()
                DataSetCierreCaja1.cierrecaja.Clear()
                txtcodcajero.Enabled = False
                ButtonBuscarCajero.Enabled = False
                txtfechaapertura.Text = ""

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Anular"
    Private Sub Anular()
        Dim resp As Integer
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Dim myCommand1 As SqlCommand = SqlConnection1.CreateCommand()
        Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()

        resp = MessageBox.Show("¿Deseas Anular este Cierre?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If resp = 6 Then
            myCommand1.CommandText = "UPDATE CierreCaja SET Anulado =  1 WHERE NumeroCierre = " & BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("NumeroCierre")
            myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "M" & "' WHERE NApertura = " & BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("Apertura")
            myCommand1.Transaction = Trans
            myCommand2.Transaction = Trans
            myCommand1.ExecuteNonQuery()
            myCommand2.ExecuteNonQuery()
            Trans.Commit()
            MsgBox("Datos Anulados Correctamente....", MsgBoxStyle.Information, "Atención...")
            lblanulado.Visible = True
        End If
    End Sub
#End Region

#Region "Guardar"
    Private Sub Guardar()

        Dim dif As String = Me.TextEdit17.EditValue
        If IsNumeric(dif) Then
            If Math.Abs(CDec(dif)) > 1500 Then
                MsgBox("La diferencia de caja es mayor que lo permitido", MsgBoxStyle.Exclamation, Me.Text)
                Exit Sub
            End If
        End If

        If MsgBox("Desea Guardar El cierre de caja", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        CargarDetalleCierreCaja()
        If Registar() Then
            CambiarEstadoApertura()
            DataSetCierreCaja1.AcceptChanges()
            If MsgBox("Desea imprimir el cierre de Caja", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Imprimir()
            End If

            tabla.Clear()
            tablacierre.Clear()
            tablaresumen.Clear()
            DataSetCierreCaja1.aperturacaja.Clear()
            DataSetCierreCaja1.CierreCaja_DetMon.Clear()
            DataSetCierreCaja1.CierreCaja_DetTarj.Clear()
            DataSetCierreCaja1.ArqueoTarjeta.Clear()
            DataSetCierreCaja1.cierrecaja.Clear()
            txtcodcajero.Enabled = False
            MessageBox.Show("El cierre de caja ha sido registrado", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            ToolBar1.Buttons(0).Enabled = True
            ToolBar1.Buttons(1).Enabled = True
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = False
            ToolBar1.Buttons(5).Enabled = True
            txtfechaapertura.Text = ""
        Else
            MessageBox.Show("Problemas al tratar de registrar el  Cierre, Intente de nuevo, si el problema persiste pongase en contacto con el adminstrador del sistema", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CargarDetalleCierreCaja()
        Dim I As Integer
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Usuario") = TextBox6.Text
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("NombreUsuario") = txtNombreUsuario.Text
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Anulado") = 0
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Devoluciones") = txtDevoluciones.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Cheques") = txtChequesSistema.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("ChequeDol") = txtChequesDolSistema.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("DepositosCol") = TxtDepoColSistena.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("DepositosDol") = txtDepDolSistema.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Subtotal") = TextEdit6.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("TotalSistema") = TextEdit6.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Equivalencia") = 0
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").EndCurrentEdit()

        '-----------------------------------------------------------------------------------------------
        'TARJETAS - ORA
        For I = 0 To DataSetCierreCaja1.TipoTarjeta.Rows.Count - 1
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetTarj").EndCurrentEdit()
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetTarj").AddNew()
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetTarj").Current("Id_TipoTarjeta") = DataSetCierreCaja1.TipoTarjeta.Rows(I).Item("Id")
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetTarj").Current("MontoSistema") = DataSetCierreCaja1.TipoTarjeta.Rows(I).Item("TotalS")
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetTarj").Current("MontoCajero") = DataSetCierreCaja1.TipoTarjeta.Rows(I).Item("Total")
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetTarj").EndCurrentEdit()
        Next
        '-----------------------------------------------------------------------------------------------

        '-----------------------------------------------------------------------------------------------
        'DENOMINACIÓN - ORA
        For I = 0 To DataSetCierreCaja1.Moneda.Rows.Count - 1
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").EndCurrentEdit()
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").AddNew()
            If DataSetCierreCaja1.Moneda.Rows(I).Item("Simbolo") = "$" Then
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").Current("Id_Moneda") = DataSetCierreCaja1.Moneda.Rows(I).Item("CodMoneda")
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").Current("MontoSistema") = TextEdit7.EditValue
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").Current("MontoCajero") = TextEdit2.EditValue
            Else
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").Current("Id_Moneda") = DataSetCierreCaja1.Moneda.Rows(I).Item("CodMoneda")
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").Current("MontoSistema") = TextEdit5.EditValue
                BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").Current("MontoCajero") = TextEdit1.EditValue
            End If
            BindingContext(Me.DataSetCierreCaja1, "cierrecaja.cierrecajaCierreCaja_DetMon").EndCurrentEdit()
        Next
        '-----------------------------------------------------------------------------------------------
    End Sub

    Private Function CambiarEstadoApertura() As Boolean
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction

        Try
            Dim myCommand2 As SqlCommand = SqlConnection1.CreateCommand()
            myCommand2.CommandText = "UPDATE aperturacaja SET Estado = '" & "C" & "' WHERE NApertura = " & BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Apertura")
            myCommand2.Transaction = Trans
            myCommand2.ExecuteNonQuery()
            Trans.Commit()
            Return True

        Catch eEndEdit As System.Exception
            Trans.Rollback()
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            Return False
        End Try
    End Function

    Private Function Registar() As Boolean
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Try
            SqlInsertCommand1.Transaction = Trans
            SqlUpdateCommand1.Transaction = Trans
            SqlInsertCommand2.Transaction = Trans
            SqlUpdateCommand2.Transaction = Trans
            SqlInsertCommand3.Transaction = Trans
            SqlUpdateCommand3.Transaction = Trans
            AdapterCierre.Update(Me.DataSetCierreCaja1.cierrecaja)
            Apertura = Me.DataSetCierreCaja1.cierrecaja.Rows(0).Item("Apertura")
            AdapterCierreTarjeta.Update(Me.DataSetCierreCaja1.CierreCaja_DetTarj)
            AdapterCierreMonto.Update(Me.DataSetCierreCaja1.CierreCaja_DetMon)
            Trans.Commit()
            Return True

        Catch eEndEdit As System.Exception
            Trans.Rollback()
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            Return False
        End Try
    End Function
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Try
            If Me.AplicaCambioenCaja = True Then

                'si es el servidor de liberia
                Dim rptCierreCaja As New ReporteCierreControlNuevo
                Dim visor As New frmVisorReportes
                visor.MdiParent = Me.ParentForm
                CrystalReportsConexion.LoadReportViewer(visor.rptViewer, rptCierreCaja)
                rptCierreCaja.SetParameterValue(0, Me.BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("NumeroCierre"))
                rptCierreCaja.SetParameterValue(1, Me.BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("Apertura"))
                rptCierreCaja.SetParameterValue(2, txtEntradas.EditValue)
                rptCierreCaja.SetParameterValue(3, txtPrepagosAplicados.EditValue)
                visor.Show()
            Else
                Dim rptCierreCaja As New ReporteCierreControl
                Dim visor As New frmVisorReportes
                visor.MdiParent = Me.ParentForm
                CrystalReportsConexion.LoadReportViewer(visor.rptViewer, rptCierreCaja)
                rptCierreCaja.SetParameterValue(0, Me.BindingContext(Me.DataSetCierreCaja1, "CierreCaja").Current("NumeroCierre"))
                rptCierreCaja.SetParameterValue(1, TextEdit14.EditValue)
                rptCierreCaja.SetParameterValue(2, TextEdit20.EditValue)
                rptCierreCaja.SetParameterValue(3, TextEdit4.EditValue)
                visor.Show()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    ''Sub cargarDetalleOperaciones()
    ''    Dim i As Integer = 0
    ''    For i = 0 To tablaresumen.Rows.Count - 1
    ''        DataSetCierreCaja1.Imprimir.ImportRow(Me.tablaresumen.Rows(i))
    ''        DataSetCierreCaja1.Imprimir(i).FormaPago = tablaresumen.Rows(i).Item(4)
    ''    Next

    ''End Sub
#End Region

#Region "Buscar"
    Private Sub Consultar_Cierre()
        Dim cFunciones As New cFunciones
        Apertura = "0"
        Dim CierreNumero As String = cFunciones.Buscar_X_Descripcion_Fecha("SELECT CAST(NumeroCierre AS varchar) AS Cierre, Nombre, Fecha FROM cierrecaja Order by NumeroCierre Desc", "Nombre", "Fecha", "Buscando Cierre de Caja...")

        If CierreNumero = Nothing Then
            Exit Sub
        End If

        dgResumen.DataSource = Nothing
        tabla.Clear()
        tablacierre.Clear()
        tablaresumen.Clear()
        DataSetCierreCaja1.aperturacaja.Clear()
        DataSetCierreCaja1.cierrecaja.Clear()

        If CierreNumero <> Nothing Then
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM  cierrecaja where NumeroCierre = '" & CierreNumero & "'", DataSetCierreCaja1.cierrecaja)
            Apertura = DataSetCierreCaja1.cierrecaja.Rows(0).Item("Apertura")
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM aperturacaja where  NApertura = " & Apertura, DataSetCierreCaja1.aperturacaja)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM OpcionesDePago WHERE Numapertura = " & Apertura & " AND FormaPago <> 'ANU'", DataSetCierreCaja1.OpcionesDePago)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM Apertura_Total_Tope where NApertura  = " & Apertura, DataSetCierreCaja1.Apertura_Total_Tope)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM ArqueoCajas where IdApertura  = " & Apertura & " AND Anulado = 0", DataSetCierreCaja1.ArqueoCajas)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM VentasContado where Num_Apertura  = " & Apertura, DataSetCierreCaja1.VentasContado)
            If DataSetCierreCaja1.ArqueoCajas.Rows.Count <> 0 Then CargarArqueoTarjeta(Me.DataSetCierreCaja1.ArqueoCajas.Rows(0).Item("Id"))
            AperturaNumero = Apertura
            Cargando()
            CargarCierre()
            txtcodaperturacajero.Text = DataSetCierreCaja1.aperturacaja.Rows(0).Item("NApertura").ToString
            txtfechaapertura.Text = CDate(Me.DataSetCierreCaja1.aperturacaja.Rows(0).Item("Fecha")).ToString
            ToolBar1.Buttons(3).Enabled = True
            ToolBar1.Buttons(4).Enabled = True
            If DataSetCierreCaja1.cierrecaja.Rows(0).Item("Anulado") = True Then
                lblanulado.Visible = True
            Else
                lblanulado.Visible = False
            End If
        Else
            MsgBox("No se obtuvieron resultados", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub CargarArqueoTarjeta(ByVal Numapertura As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = CadenaConexionSeePOS()
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM ArqueoTarjeta where Id_Arqueo  = @Numapertura "
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            cmd.Parameters.Add(New SqlParameter("@Numapertura", SqlDbType.Int))
            cmd.Parameters("@Numapertura").Value = Numapertura
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DataSetCierreCaja1.ArqueoTarjeta)
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Sub
#End Region

#Region "Buscar Arqueo"
    Private Sub consultarcajero()
        Dim dts_anuladas As DataTable
        Dim cFunciones As New cFunciones
        AperturaNumero = cFunciones.Buscar_X_Descripcion_Fecha("SELECT CAST(NApertura AS Varchar) as Apertura,Nombre,Fecha FROM aperturacaja where estado =  '" & "M" & "'", "Nombre", "Fecha", "Aperturas de caja sin cerrar...")

        If AperturaNumero = Nothing Then
            MsgBox("Debes selecionar un usuario para realizar el cierre de Caja", MsgBoxStyle.Exclamation)
            Exit Sub
        Else
            DataSetCierreCaja1.aperturacaja.Clear()
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM aperturacaja where Napertura = '" & AperturaNumero & "' AND Estado = 'M'", DataSetCierreCaja1.aperturacaja)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM Apertura_Total_Tope where NApertura  = " & AperturaNumero, DataSetCierreCaja1.Apertura_Total_Tope)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM ArqueoCajas where IdApertura  = " & AperturaNumero & " AND Anulado = 0", DataSetCierreCaja1.ArqueoCajas)

            If DataSetCierreCaja1.ArqueoCajas.Count > 0 Then
            Else
                MsgBox("Es Necesario Ingresar Un Arqueo De Caja")
                Exit Sub
            End If

            cFunciones.Llenar_Tabla_Generico("SELECT * FROM VentasContado where Num_Apertura  = " & AperturaNumero, DataSetCierreCaja1.VentasContado)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM VentasCredito where dbo.Dateonly(Fecha) = dbo.DateOnly('" & Format(BindingContext(Me.DataSetCierreCaja1, "aperturacaja").Current("Fecha"), "dd/MM/yyyy H:mm:ss") & "')", DataSetCierreCaja1.VentasCredito)
            cFunciones.Llenar_Tabla_Generico("SELECT * FROM ArqueoTarjeta where Id_Arqueo  = " & BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("Id"), DataSetCierreCaja1.ArqueoTarjeta)

            Cargando()

            If DataSetCierreCaja1.aperturacaja.Count > 0 Then
                tabla.Clear()
                tablacierre.Clear()
                tablaresumen.Clear()
                DataSetCierreCaja1.OpcionesDePago.Clear()
                CargarOpcionesPago(AperturaNumero)
                txtcodaperturacajero.Text = AperturaNumero
                txtfechaapertura.Text = CDate(Me.DataSetCierreCaja1.aperturacaja.Rows(0).Item("Fecha")).ToString
                CargarCierre()
            Else
                MsgBox("Este Usuario no tiene una caja abierta")
            End If
        End If
    End Sub
    Sub ver_nulas()
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select isnull(sum(montopago),0) from opcionesdepago where numapertura = " & txtcodaperturacajero.Text & " AND FormaPago = 'ANU'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.txtanuladas.Text = dt.Rows(0).Item(0)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub CargarOpcionesPago(ByVal Numapertura As String)
        Dim cnnv As SqlConnection = Nothing
        Try
            Dim sConn As String = CadenaConexionSeePOS()
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM OpcionesDePago WHERE Numapertura = @Numapertura AND FormaPago <> 'ANU' "
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Numapertura", SqlDbType.Int))
            cmdv.Parameters("@Numapertura").Value = Numapertura
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSetCierreCaja1, "OpcionesDePago")
        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Sub
#End Region

#Region "Cargar Cierre"
    Private Sub CargarCierre()
        Dim I, J, K As Integer
        Dim Dr As System.Data.DataRow
        Dim Dr1 As System.Data.DataRow
        Dim Dr2 As System.Data.DataRow

        'Valores Vacios a los grid
        dgResumen.DataSource = Nothing
        txtcodcajero.Text = DataSetCierreCaja1.aperturacaja.Rows(0).Item("Cedula")
        txtnomcajero.Text = DataSetCierreCaja1.aperturacaja.Rows(0).Item("Nombre")
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Cajera") = DataSetCierreCaja1.aperturacaja.Rows(0).Item("Cedula")
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Nombre") = DataSetCierreCaja1.aperturacaja.Rows(0).Item("Nombre")
        txtcodaperturacajero.Text = DataSetCierreCaja1.aperturacaja.Rows(0).Item("NApertura").ToString
        txtfechaapertura.Text = CDate(Me.DataSetCierreCaja1.aperturacaja.Rows(0).Item("Fecha")).ToString
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Apertura") = DataSetCierreCaja1.aperturacaja.Rows(0).Item("NApertura").ToString
        SubTotal = 0
        Devolucion = 0
        TextEdit5.EditValue = 0 : TextEdit8.EditValue = 0
        TextEdit7.EditValue = 0 : TextEdit10.EditValue = 0
        TextEdit4.EditValue = 0 : txtDevoluciones.EditValue = 0
        txtEntradas.EditValue = 0 : txtSalidas.EditValue = 0
        TextEdit14.EditValue = 0
        txtChequesDolSistema.EditValue = 0 : txtChequesSistema.EditValue = 0
        TxtDepoColSistena.EditValue = 0 : txtDepDolSistema.EditValue = 0

        'LLenar Los Totales Por monedas
        For I = 0 To (Me.DataSetCierreCaja1.Moneda.Count - 1)
            Dr2 = tablacierre.NewRow
            Dr = tabla.NewRow
            Dr(0) = DataSetCierreCaja1.Moneda.Rows(I).Item("MonedaNombre")
            TotalesPorMonedas(Dr, Dr2, DataSetCierreCaja1.Moneda.Rows(I).Item("CodMoneda"), DataSetCierreCaja1.Moneda.Rows(I).Item("ValorCompra"), DataSetCierreCaja1.Moneda.Rows(I).Item("MonedaNombre"))
            Select Case DataSetCierreCaja1.Moneda.Rows(I).Item("Simbolo")
                Case "¢"
                    TextEdit5.EditValue = Dr(1)
                    TextEdit8.EditValue = Dr(2)
                Case "$"
                    TextEdit7.EditValue = Dr(1)
                    TextEdit10.EditValue = Dr(2)
            End Select
            tabla.Rows.Add(Dr)
            tablacierre.Rows.Add(Dr2)
        Next
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        For I = 0 To (Me.DataSetCierreCaja1.VentasContado.Count - 1)
            If DataSetCierreCaja1.VentasContado.Rows(I).Item("Cod_Moneda") = 2 Then
                TextEdit14.EditValue += (Me.DataSetCierreCaja1.VentasContado.Rows(I).Item("Total") * TipoCambioDolar)
            Else
                nc()
            End If
        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Llenar las Operaciones
        For I = 0 To (Me.DataSetCierreCaja1.OpcionesDePago.Count - 1)
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("FormaPago") = "TAR" Then
                For K = 0 To (Me.DataSetCierreCaja1.Detalle_pago_caja.Count - 1)
                    If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("Id") = DataSetCierreCaja1.Detalle_pago_caja.Rows(K).Item("Id_ODP") Then
                        'For J = 0 To (Me.DataSetCierreCaja1.TipoTarjeta.Count - 1)
                        'If DataSetCierreCaja1.TipoTarjeta.Rows(J).Item("Id") = DataSetCierreCaja1.Detalle_pago_caja.Rows(K).Item("ReferenciaTipo") Then
                        DataSetCierreCaja1.TipoTarjeta.Rows(0).Item("TotalS") += DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
                        'End If
                        'Next
                    End If
                Next
            End If

            '------------------------------------------------------------------------------------------
            'MONTO TOTAL DE CHEQUES - ORA
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("FormaPago") = "CHE" Then
                If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("CodMoneda") = 1 Then
                    txtChequesSistema.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
                Else
                    txtChequesDolSistema.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
                End If
            End If
            '------------------------------------------------------------------------------------------

            '------------------------------------------------------------------------------------------
            'MONTO TOTAL DE TRANSFERENCIAS - ORA
            'TRA = TRANSFERENCIAS
            'SIN = SINPE
            'PARA MAS FACIL VOY A SUMAR LOS SINPE A LAS TRANSFERENCIAS
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("FormaPago") = "TRA" Or DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("FormaPago") = "SIN" Then
                If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("CodMoneda") = 1 Then
                    TxtDepoColSistena.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
                Else
                    txtDepDolSistema.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
                End If
            End If

            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("FormaPago") = "PRE" Then
                txtPrepagosAplicados.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
            End If
            '------------------------------------------------------------------------------------------

            '------------------------------------------------------------------------------------------
            'MONTO TOTAL DE ABONOS - ORA
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoDocumento") = "ABO" Or DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoDocumento") = "ABA" Then
                If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("CodMoneda") = 1 Then
                    TextEdit4.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
                Else
                    TextEdit4.EditValue += (Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago") * TipoCambioDolar)
                End If
            End If
            '------------------------------------------------------------------------------------------

            'MONTO TOTAL DE ENTRADAS DE LA CAJA - ORA
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoDocumento") = "MCE" Then
                txtEntradas.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
            End If

            '------------------------------------------------------------------------------------------

            '------------------------------------------------------------------------------------------
            '------------------------------------------------------------------------------------------
            'MONTO TOTAL DE SALIDAS DE LA CAJA - ORA
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoDocumento") = "MCS" Then
                txtSalidas.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
            End If
            '------------------------------------------------------------------------------------------

            '------------------------------------------------------------------------------------------
            'MONTO TOTAL DE DEVOLUCIONES - ORA
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoDocumento") = "DVE" Then
                txtDevoluciones.EditValue += Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
            End If

            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoDocumento") = "DVA" Then
                TextEdit5.EditValue -= Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
                txtDevoluciones.EditValue -= Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago")
            End If
            '------------------------------------------------------------------------------------------

            '------------------------------------------------------------------------------------------


            Dr1 = tablaresumen.NewRow
            Dr1(0) = DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("Documento")
            Dr1(1) = DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoDocumento")
            Dr1(2) = DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("Nombremoneda")
            Dr1(3) = Format(Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago"), "#,#0.00")
            'Si es una devolución
            If DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("FormaPago") = "DVE" Then
                Dr1(4) = "DVE"
            Else 'Si no es una devolución
                Select Case DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("FormaPago")
                    Case "EFE"
                        Dr1(4) = "EFE"
                    Case "MCS"
                        Dr1(4) = "MCS"
                    Case "MCE"
                        Dr1(4) = "MCE"
                    Case "TAR"
                        Dr1(4) = "TAR"
                    Case "CHE"
                        Dr1(4) = "CHE"
                    Case "TRA"
                        Dr1(4) = "TRA"
                    Case "SIN"
                        Dr1(4) = "SIN"
                    Case "PRE"
                        Dr1(4) = "PRE"
                End Select
            End If
            Dr1(5) = Format((Me.DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("MontoPago") * DataSetCierreCaja1.OpcionesDePago.Rows(I).Item("TipoCambio")), "#,#0.00")
            tablaresumen.Rows.Add(Dr1)
        Next

        DescontarVuelto()
        dgResumen.DataSource = tablaresumen

        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Subtotal") = (SubTotal + txtDevoluciones.EditValue)
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").Current("Devoluciones") = txtDevoluciones.EditValue

        TextEdit5.EditValue = TextEdit5.EditValue + TxtFondoCaja.EditValue - txtDevoluciones.EditValue '+ txtEntradas.EditValue - txtSalidas.EditValue
        TextEdit18.EditValue = (TextEdit5.EditValue + (TextEdit7.EditValue * TipoCambioDolar) + TextEdit8.EditValue + (TextEdit10.EditValue * TipoCambioDolar) + txtChequesSistema.EditValue + (txtChequesDolSistema.EditValue * TipoCambioDolar) + TxtDepoColSistena.EditValue + (txtDepDolSistema.EditValue * TipoCambioDolar))

        TextEdit6.EditValue = TextEdit18.Text
        TextEdit17.EditValue = TextEdit16.EditValue - TextEdit6.EditValue
        TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        TextEdit5.Properties.DisplayFormat.FormatString = "#,#0.00"
        txtDepositar.EditValue = TextEdit5.EditValue + (TextEdit7.EditValue * TipoCambioDolar) + txtChequesSistema.EditValue + (txtChequesDolSistema.EditValue * TipoCambioDolar) - TxtFondoCaja.EditValue
        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").EndCurrentEdit()
    End Sub

    Private Function TotalesPorMonedas(ByRef Dr As DataRow, ByRef Dr1 As DataRow, ByVal CodigoMoneda As String, ByVal ValorCompra As Double, ByVal NombreMoneda As String) As DataRow
        Try
            Dim OperacionesMoneda() As DataRow
            Dim DenominacionesApertura() As DataRow
            Dim Operacion As DataRow
            Dim Denominacion As DataRow
            Dim J As Integer = 0
            Dim Vueltos As Double
            Dim Efectivo, Targeta, Cheque, Transferencia, devoluciones As Double
            Dim Denominaciones As Double
            OperacionesMoneda = DataSetCierreCaja1.OpcionesDePago.Select("CodMoneda = '" & CodigoMoneda & "'")

            'Cargar opciones de pago
            While J < OperacionesMoneda.Length
                Operacion = OperacionesMoneda(J)
                If Operacion("FormaPago") = "DVE" Then
                    devoluciones += Operacion("MontoPago")
                    Devolucion += (Operacion("MontoPago") * ValorCompra)
                ElseIf Operacion("FormaPago") = "DVA" Then
                    devoluciones -= Operacion("MontoPago")
                    Devolucion -= (Operacion("MontoPago") * ValorCompra)
                Else
                    Select Case Operacion("FormaPago")
                        Case "EFE", "MCE"
                            Efectivo += Operacion("MontoPago")
                        Case "MCS"
                            Efectivo -= Operacion("MontoPago")
                        Case "TAR"
                            Targeta += Operacion("MontoPago")
                        Case "CHE"
                            Cheque += Operacion("MontoPago")
                        Case "TRA"
                            Transferencia += Operacion("MontoPago")
                    End Select
                End If
                J += 1
            End While
            J = 0
            Dr(1) = (Efectivo)
            Dr(2) = Targeta
            Dr(3) = Cheque
            Dr(4) = Transferencia
            Dr(5) = devoluciones
            Dr(6) = ((Efectivo) + Targeta + Cheque + Transferencia - devoluciones) * ValorCompra
            Dr1(0) = ((Efectivo) + Targeta + Cheque + Transferencia - devoluciones)
            Dr1(1) = NombreMoneda
            Dr1(2) = ((Efectivo) + Targeta + Cheque + Transferencia - devoluciones) * ValorCompra

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub DescontarVuelto()
        Dim i As Integer
        'Efectivo Colones se le resta Los Vueltos
        ' tabla.Rows(0).Item(1) = (tabla.Rows(0).Item(1) - Vuelto)
        'Total Colones se le resta Los vueltos
        'tabla.Rows(0).Item(6) = (tabla.Rows(0).Item(6) - Vuelto)
        'tablacierre.Rows(0).Item(0) = tabla.Rows(0).Item(6)
        'tablacierre.Rows(0).Item(2) = tabla.Rows(0).Item(6)
        For i = 0 To (tabla.Rows.Count - 1)
            SubTotal += tabla.Rows(i).Item(6)
        Next
    End Sub

    Private Sub Cargando()
        Dim I As Integer

        Try
            txtChequesCajero.EditValue = 0 : txtChequesDolCajero.EditValue = 0 : txtDepoColCajero.EditValue = 0 : txtDepDolCajero.EditValue = 0
            CagarFacturasCredito(Me.DataSetCierreCaja1.aperturacaja.Rows(0).Item("Fecha"), DataSetCierreCaja1.aperturacaja.Rows(0).Item("Cedula"))
            TextEdit1.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("EfectivoColones")
            TextEdit2.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("EfectivoDolares")
            TextEdit9.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("TarjetaColones")
            TextEdit11.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("TarjetaDolares")
            txtChequesCajero.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("Cheques")
            txtChequesDolCajero.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("ChequesDol")
            txtDepoColCajero.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("DepositoCol")
            txtDepDolCajero.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("DepositoDol")
            TextEdit16.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("Total")
            TxtFondoCaja.EditValue = BindingContext(Me.DataSetCierreCaja1, "Apertura_Total_Tope").Current("Monto_Tope")
            TextEdit19.EditValue = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("Total")
            TipoCambioDolar = BindingContext(Me.DataSetCierreCaja1, "ArqueoCajas").Current("TipoCambioD")

            For I = 0 To DataSetCierreCaja1.TipoTarjeta.Count - 1
                Try
                    DataSetCierreCaja1.TipoTarjeta.Rows(I).Item("Total") = DataSetCierreCaja1.ArqueoTarjeta.Rows(I).Item("Monto")
                Catch ex As Exception

                End Try
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function CagarFacturasCredito(ByVal Fecha As Date, ByVal Cedula As String)
        Dim cnn As SqlConnection = Nothing
        Dim i As Integer
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = CadenaConexionSeePOS()
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM dbo.VentasCredito WHERE dbo.dateonly(Fecha)  = dbo.dateonly(@Fecha)"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            cmd.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            cmd.Parameters("@Fecha").Value = Format(CDate(Fecha), "dd/MM/yyyy H:mm:ss")
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DataSetCierreCaja1, "VENTASCREDITO")
            Dim numero As Integer
            TextEdit20.EditValue = 0
            For i = 0 To DataSetCierreCaja1.VentasCredito.Count - 1
                If DataSetCierreCaja1.VentasCredito.Rows(i).Item("Cod_Moneda") = 2 Then
                    TextEdit20.EditValue += (Me.DataSetCierreCaja1.VentasCredito.Rows(i).Item("Total") * TipoCambioDolar)
                Else
                    TextEdit20.EditValue += DataSetCierreCaja1.VentasCredito.Rows(i).Item("Total")
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function
#End Region

#Region "Controles"
    Private Sub Limpiar()
        TextEdit1.EditValue = 0 : TextEdit2.EditValue = 0 : TextEdit9.EditValue = 0
        TextEdit11.EditValue = 0 : TextEdit19.EditValue = 0 : TextEdit17.EditValue = 0
        TxtFondoCaja.EditValue = 0 : TextEdit4.EditValue = 0 : TextEdit6.EditValue = 0
        TextEdit16.EditValue = 0 : TextEdit20.EditValue = 0 : TextEdit18.EditValue = 0
        TextEdit14.EditValue = 0 : txtEntradas.EditValue = 0 : txtSalidas.EditValue = 0
        txtChequesCajero.EditValue = 0 : txtChequesSistema.EditValue = 0
        txtChequesDolCajero.EditValue = 0 : txtChequesDolSistema.EditValue = 0
        txtDepoColCajero.EditValue = 0 : TxtDepoColSistena.EditValue = 0
        txtDepDolCajero.EditValue = 0 : txtDepDolSistema.EditValue = 0
    End Sub

    Private Sub IniciarEdicion()
        ToolBar1.Buttons(0).Text = "Cancelar"
        ToolBar1.Buttons(0).ImageIndex = 8
        ToolBar1.Buttons(0).Enabled = True
        ToolBar1.Buttons(1).Enabled = False
        ToolBar1.Buttons(2).Enabled = True
        ToolBar1.Buttons(3).Enabled = False
        ToolBar1.Buttons(4).Enabled = False
    End Sub
#End Region

#Region "Controles Funciones"
    Private Sub txtcodcajero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodcajero.KeyDown
        If e.KeyCode = Keys.F1 Then
            Limpiar()
            consultarcajero()
        End If
    End Sub

    Private Sub ButtonBuscarCajero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscarCajero.Click
        Limpiar()
        consultarcajero()
        verifica_anuladas()
    End Sub
#End Region

#Region "Validar Usuario"
    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim clave As String
                Dim usuarios() As System.Data.DataRow 'almacena temporalmente los datos de un artículo
                Dim usuario As System.Data.DataRow 'almacena temporalmente los datos de un artículo

                clave = TextBox6.Text
                usuarios = DataSetCierreCaja1.Usuarios.Select("clave_interna= '" & CStr(clave) & "'")

                If usuarios.Length <> 0 Then
                    usuario = usuarios(0) 'se almacena la info del usuario
                    If usuario!nombre <> "" Then
                        DataSetCierreCaja1.cierrecaja.UsuarioColumn.DefaultValue = usuario!cedula
                        DataSetCierreCaja1.cierrecaja.NombreUsuarioColumn.DefaultValue = usuario!nombre
                        txtNombreUsuario.Text = usuario!nombre
                        Cedula_Usuario = usuario!Cedula
                        PMU = VSM(Me.Cedula_Usuario, Name) 'Carga los privilegios del usuario con el modulo 
                        If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Text, MsgBoxStyle.Information, "Atención...") : Exit Sub
                        txtcodcajero.Enabled = True
                        ToolBar1.Buttons(1).Enabled = True
                        IniciarEdicion()
                        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").EndCurrentEdit()
                        BindingContext(Me.DataSetCierreCaja1, "cierrecaja").AddNew()
                        txtcodcajero.Focus()
                    Else
                        MsgBox("El Usuario no Existe", MsgBoxStyle.Information)
                        TextBox6.Text = ""
                        TextBox6.Focus()
                    End If
                Else
                    MsgBox("El Usuario no Existe", MsgBoxStyle.Information)
                    TextBox6.Text = ""
                    TextBox6.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
#End Region

    Public Sub nc()
        Try
            TextEdit14.Text = 0
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select sum(montopago * TipoCambio) from opcionesdepago where id <> 1326244 and  numapertura = " & txtcodaperturacajero.Text & " AND TipoDocumento <> 'ABO' AND TipoDocumento <> 'ABA' AND TipoDocumento <> 'DVE' and FormaPago <> 'ANU' and TipoDocumento <> 'RFC' ", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then Me.TextEdit14.EditValue = dt.Rows(0).Item(0)
        Catch ex As Exception
            TextEdit14.Text = TextEdit19.Text
        End Try
    End Sub

    Sub verifica_anuladas()
        Try
            Dim dts_ventas As New DataTable
            Dim dts_apertura As New DataTable
            Dim Cx As New Conexion
            Dim tipo As String
            Dim documento As Long
            Dim id As Long

            cFunciones.Llenar_Tabla_Generico("select * from ventas where Anulado = 1 and Num_Apertura  = " & txtcodaperturacajero.Text, dts_ventas, CadenaConexionSeePOS)



            For i As Integer = 0 To dts_ventas.Rows.Count - 1

                documento = dts_ventas.Rows(i).Item("Num_Factura")

                cFunciones.Llenar_Tabla_Generico("select * from OpcionesDePago where TipoDocumento <> 'ABO' and TipoDocumento <> 'DVE' and TipoDocumento <> 'DVA' and TipoDocumento <> 'ABA' and Numapertura  = " & txtcodaperturacajero.Text & " and documento = " & documento, dts_apertura, CadenaConexionSeePOS)
                id = dts_apertura.Rows(0).Item("id")

                If dts_apertura.Rows(0).Item("FormaPago") <> "ANU" Then
                    Cx.UpdateRecords("opcionesdepago", "Formapago = 'ANU'", "id = " & id, "SeePos")
                End If
            Next
            ver_nulas()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnSuvesa_Click(sender As Object, e As EventArgs) Handles btnSuvesa.Click
        If Me.txtcodaperturacajero.Text <> "" Then
            Dim ReporteDocumento As New rtpResumenCaja
            ReporteDocumento.SetParameterValue(0, Me.txtcodaperturacajero.Text)
            CrystalReportsConexion.LoadShow(ReporteDocumento, MdiParent)
        End If
    End Sub

    Private Sub TextEdit17_TextChanged(sender As Object, e As EventArgs) Handles TextEdit17.TextChanged
        Try
            Dim dif As String = Me.TextEdit17.EditValue
            If IsNumeric(dif) Then
                If CDec(dif) < 0 Then
                    Me.TextEdit17.ForeColor = Drawing.Color.Red
                Else
                    Me.TextEdit17.ForeColor = Drawing.Color.Blue
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
