Imports System.data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmOrdenCompra
    'Inherits System.Windows.Forms.Form
    Inherits FrmPlantilla
    Dim PMU As New PerfilModulo_Class
    Dim strCedula As String = ""


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents OpCredito As System.Windows.Forms.RadioButton
    Friend WithEvents OpContado As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrecioUnit As System.Windows.Forms.TextBox

    Friend WithEvents txtDescArt As System.Windows.Forms.TextBox
    Friend WithEvents txtCodArt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    'Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents daordencompra As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    'Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dausuario As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents Adapter_Orden_Compra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Detalle_Orden_Compras As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescuentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtImpuestoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioUni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPorcDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtDias_Entrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtEntrega As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtNombre_Proveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCodigo_art As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataSetOrden_Compras1 As DataSetOrden_Compras
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Txt_Descri_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtFletes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtOtros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label_Tipo_Cambio As System.Windows.Forms.Label
    Friend WithEvents txtMontoImpuesto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtmontodescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Tex_Porc_Imp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtSGravado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSExcento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostoUnitario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colimpuesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCompra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGravado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtSubGravadoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtSubExentoT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtSubtotalT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenCompra))
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo12 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo13 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo14 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo15 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo16 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo17 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo18 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDias = New DevExpress.XtraEditors.TextEdit
        Me.DataSetOrden_Compras1 = New LcPymes_5._2.DataSetOrden_Compras
        Me.Label21 = New System.Windows.Forms.Label
        Me.OpContado = New System.Windows.Forms.RadioButton
        Me.OpCredito = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtCosto = New DevExpress.XtraEditors.TextEdit
        Me.Label24 = New System.Windows.Forms.Label
        Me.TxtOtros = New DevExpress.XtraEditors.TextEdit
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtFletes = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.Tex_Porc_Imp = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_Descri_Articulo = New DevExpress.XtraEditors.TextEdit
        Me.TxtCodigo_art = New DevExpress.XtraEditors.TextEdit
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit
        Me.TxtPorcDesc = New DevExpress.XtraEditors.TextEdit
        Me.TxtCant = New DevExpress.XtraEditors.TextEdit
        Me.TxtPrecioUni = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TxtEntrega = New DevExpress.XtraEditors.TextEdit
        Me.TxtDias_Entrega = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.daordencompra = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtNombre_Proveedor = New DevExpress.XtraEditors.TextEdit
        Me.TxtCodigo = New DevExpress.XtraEditors.TextEdit
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dausuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Orden_Compra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Detalle_Orden_Compras = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.TxtDescuentoT = New DevExpress.XtraEditors.TextEdit
        Me.TxtImpuestoT = New DevExpress.XtraEditors.TextEdit
        Me.TxtMonto = New DevExpress.XtraEditors.TextEdit
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label_Tipo_Cambio = New System.Windows.Forms.Label
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Txt_cedulaUsuario = New System.Windows.Forms.TextBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCostoUnitario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGravado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colimpuesto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotalCompra = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtMontoImpuesto = New DevExpress.XtraEditors.TextEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtmontodescuento = New DevExpress.XtraEditors.TextEdit
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtSGravado = New DevExpress.XtraEditors.TextEdit
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtSExcento = New DevExpress.XtraEditors.TextEdit
        Me.TxtSubGravadoT = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtSubExentoT = New DevExpress.XtraEditors.TextEdit
        Me.Label28 = New System.Windows.Forms.Label
        Me.TxtSubtotalT = New DevExpress.XtraEditors.TextEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtDias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetOrden_Compras1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOtros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFletes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tex_Porc_Imp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPorcDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioUni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TxtEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDias_Entrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtNombre_Proveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtImpuestoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoImpuesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmontodescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSGravado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSExcento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubGravadoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubExentoT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 421)
        Me.ToolBar1.Size = New System.Drawing.Size(658, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(728, 588)
        Me.DataNavigator.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(658, 32)
        Me.TituloModulo.Text = "Orden de Compra Manual"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Orden #"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(72, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "día(s)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = " Entrega "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtDias)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.OpContado)
        Me.GroupBox1.Controls.Add(Me.OpCredito)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(472, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 53)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forma de Pago"
        '
        'TxtDias
        '
        Me.TxtDias.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetOrden_Compras1, "ordencompra.diascredito", True))
        Me.TxtDias.EditValue = ""
        Me.TxtDias.Location = New System.Drawing.Point(89, 29)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.Size = New System.Drawing.Size(32, 19)
        Me.TxtDias.TabIndex = 2
        '
        'DataSetOrden_Compras1
        '
        Me.DataSetOrden_Compras1.DataSetName = "DataSetOrden_Compras"
        Me.DataSetOrden_Compras1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetOrden_Compras1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.Location = New System.Drawing.Point(126, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 14)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "día(s)"
        '
        'OpContado
        '
        Me.OpContado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetOrden_Compras1, "ordencompra.contado", True))
        Me.OpContado.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OpContado.Location = New System.Drawing.Point(8, 16)
        Me.OpContado.Name = "OpContado"
        Me.OpContado.Size = New System.Drawing.Size(80, 16)
        Me.OpContado.TabIndex = 0
        Me.OpContado.Text = "Contado"
        '
        'OpCredito
        '
        Me.OpCredito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetOrden_Compras1, "ordencompra.credito", True))
        Me.OpCredito.ForeColor = System.Drawing.Color.RoyalBlue
        Me.OpCredito.Location = New System.Drawing.Point(8, 32)
        Me.OpCredito.Name = "OpCredito"
        Me.OpCredito.Size = New System.Drawing.Size(72, 16)
        Me.OpCredito.TabIndex = 1
        Me.OpCredito.Text = "Crédito"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtCosto)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TxtOtros)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.TxtFletes)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Tex_Porc_Imp)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Txt_Descri_Articulo)
        Me.GroupBox3.Controls.Add(Me.TxtCodigo_art)
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Controls.Add(Me.TxtPorcDesc)
        Me.GroupBox3.Controls.Add(Me.TxtCant)
        Me.GroupBox3.Controls.Add(Me.TxtPrecioUni)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 97)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Articulo"
        '
        'TxtCosto
        '
        Me.TxtCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.Costo", True))
        Me.TxtCosto.EditValue = ""
        Me.TxtCosto.Location = New System.Drawing.Point(256, 72)
        Me.TxtCosto.Name = "TxtCosto"
        '
        '
        '
        Me.TxtCosto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtCosto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCosto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCosto.Properties.ReadOnly = True
        Me.TxtCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtCosto.Size = New System.Drawing.Size(64, 19)
        Me.TxtCosto.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label24.Location = New System.Drawing.Point(256, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 95
        Me.Label24.Text = "Costo"
        '
        'TxtOtros
        '
        Me.TxtOtros.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.OtrosCargos", True))
        Me.TxtOtros.EditValue = ""
        Me.TxtOtros.Location = New System.Drawing.Point(186, 72)
        Me.TxtOtros.Name = "TxtOtros"
        '
        '
        '
        Me.TxtOtros.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtOtros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtOtros.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtOtros.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtOtros.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtOtros.Size = New System.Drawing.Size(64, 19)
        Me.TxtOtros.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.Location = New System.Drawing.Point(186, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "Otros"
        '
        'TxtFletes
        '
        Me.TxtFletes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.Monto_Flete", True))
        Me.TxtFletes.EditValue = ""
        Me.TxtFletes.Location = New System.Drawing.Point(110, 72)
        Me.TxtFletes.Name = "TxtFletes"
        '
        '
        '
        Me.TxtFletes.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtFletes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFletes.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtFletes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtFletes.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtFletes.Size = New System.Drawing.Size(64, 19)
        Me.TxtFletes.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Location = New System.Drawing.Point(110, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 91
        Me.Label22.Text = "Fletes"
        '
        'Tex_Porc_Imp
        '
        Me.Tex_Porc_Imp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.Porc_Impuesto", True))
        Me.Tex_Porc_Imp.EditValue = ""
        Me.Tex_Porc_Imp.Location = New System.Drawing.Point(392, 72)
        Me.Tex_Porc_Imp.Name = "Tex_Porc_Imp"
        '
        '
        '
        Me.Tex_Porc_Imp.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.Tex_Porc_Imp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tex_Porc_Imp.Properties.EditFormat.FormatString = "#,#0.00"
        Me.Tex_Porc_Imp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Tex_Porc_Imp.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.Tex_Porc_Imp.Size = New System.Drawing.Size(45, 19)
        Me.Tex_Porc_Imp.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(392, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "% Imp."
        '
        'Txt_Descri_Articulo
        '
        Me.Txt_Descri_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.Descripcion", True))
        Me.Txt_Descri_Articulo.EditValue = ""
        Me.Txt_Descri_Articulo.Location = New System.Drawing.Point(112, 32)
        Me.Txt_Descri_Articulo.Name = "Txt_Descri_Articulo"
        '
        '
        '
        Me.Txt_Descri_Articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Descri_Articulo.Properties.ReadOnly = True
        Me.Txt_Descri_Articulo.Size = New System.Drawing.Size(528, 19)
        Me.Txt_Descri_Articulo.TabIndex = 1
        '
        'TxtCodigo_art
        '
        Me.TxtCodigo_art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.Codigo", True))
        Me.TxtCodigo_art.EditValue = ""
        Me.TxtCodigo_art.Location = New System.Drawing.Point(8, 32)
        Me.TxtCodigo_art.Name = "TxtCodigo_art"
        Me.TxtCodigo_art.Size = New System.Drawing.Size(80, 19)
        Me.TxtCodigo_art.TabIndex = 0
        '
        'TxtTotal
        '
        Me.TxtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.TotalCompra", True))
        Me.TxtTotal.EditValue = ""
        Me.TxtTotal.Location = New System.Drawing.Point(536, 72)
        Me.TxtTotal.Name = "TxtTotal"
        '
        '
        '
        Me.TxtTotal.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtTotal.Size = New System.Drawing.Size(104, 19)
        Me.TxtTotal.TabIndex = 9
        '
        'TxtPorcDesc
        '
        Me.TxtPorcDesc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.Porc_Descuento", True))
        Me.TxtPorcDesc.EditValue = ""
        Me.TxtPorcDesc.Location = New System.Drawing.Point(336, 72)
        Me.TxtPorcDesc.Name = "TxtPorcDesc"
        '
        '
        '
        Me.TxtPorcDesc.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPorcDesc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPorcDesc.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPorcDesc.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPorcDesc.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtPorcDesc.Size = New System.Drawing.Size(45, 19)
        Me.TxtPorcDesc.TabIndex = 6
        '
        'TxtCant
        '
        Me.TxtCant.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.Cantidad", True))
        Me.TxtCant.EditValue = ""
        Me.TxtCant.Location = New System.Drawing.Point(456, 72)
        Me.TxtCant.Name = "TxtCant"
        '
        '
        '
        Me.TxtCant.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtCant.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtCant.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtCant.Size = New System.Drawing.Size(64, 19)
        Me.TxtCant.TabIndex = 8
        '
        'TxtPrecioUni
        '
        Me.TxtPrecioUni.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra.CostoUnitario", True))
        Me.TxtPrecioUni.EditValue = ""
        Me.TxtPrecioUni.Location = New System.Drawing.Point(8, 70)
        Me.TxtPrecioUni.Name = "TxtPrecioUni"
        '
        '
        '
        Me.TxtPrecioUni.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioUni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUni.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioUni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUni.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtPrecioUni.Size = New System.Drawing.Size(88, 19)
        Me.TxtPrecioUni.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(112, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(528, 16)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(536, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Subtotal"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(336, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 16)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "%Desc"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(8, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Precio Unit"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(7, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Código"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(456, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cantidad:"
        '
        'Txtobservaciones
        '
        Me.Txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtobservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtobservaciones.Enabled = False
        Me.Txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobservaciones.ForeColor = System.Drawing.Color.Blue
        Me.Txtobservaciones.Location = New System.Drawing.Point(8, 256)
        Me.Txtobservaciones.Name = "Txtobservaciones"
        Me.Txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtobservaciones.Size = New System.Drawing.Size(632, 13)
        Me.Txtobservaciones.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.Location = New System.Drawing.Point(8, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(632, 16)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Observaciones"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtEntrega)
        Me.GroupBox4.Controls.Add(Me.TxtDias_Entrega)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox4.Location = New System.Drawing.Point(8, 87)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(456, 56)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones de Orden"
        '
        'TxtEntrega
        '
        Me.TxtEntrega.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetOrden_Compras1, "ordencompra.entregar", True))
        Me.TxtEntrega.EditValue = ""
        Me.TxtEntrega.Location = New System.Drawing.Point(121, 32)
        Me.TxtEntrega.Name = "TxtEntrega"
        '
        '
        '
        Me.TxtEntrega.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtEntrega.Size = New System.Drawing.Size(327, 19)
        Me.TxtEntrega.TabIndex = 1
        '
        'TxtDias_Entrega
        '
        Me.TxtDias_Entrega.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetOrden_Compras1, "ordencompra.Plazo", True))
        Me.TxtDias_Entrega.EditValue = ""
        Me.TxtDias_Entrega.Location = New System.Drawing.Point(8, 32)
        Me.TxtDias_Entrega.Name = "TxtDias_Entrega"
        '
        '
        '
        Me.TxtDias_Entrega.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDias_Entrega.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDias_Entrega.Size = New System.Drawing.Size(64, 19)
        Me.TxtDias_Entrega.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(121, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(327, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Entregar a:"
        '
        'daordencompra
        '
        Me.daordencompra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.daordencompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daordencompra.ForeColor = System.Drawing.Color.RoyalBlue
        Me.daordencompra.Location = New System.Drawing.Point(544, 380)
        Me.daordencompra.Name = "daordencompra"
        Me.daordencompra.Size = New System.Drawing.Size(96, 17)
        Me.daordencompra.TabIndex = 84
        Me.daordencompra.Text = "Total"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.Location = New System.Drawing.Point(440, 380)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 17)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "Impuesto"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Location = New System.Drawing.Point(336, 380)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 17)
        Me.Label17.TabIndex = 82
        Me.Label17.Text = "Descuento"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(120, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Nombre Proveedor"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(16, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtNombre_Proveedor)
        Me.GroupBox2.Controls.Add(Me.TxtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 56)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Proveedor"
        '
        'TxtNombre_Proveedor
        '
        Me.TxtNombre_Proveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetOrden_Compras1, "ordencompra.Nombre", True))
        Me.TxtNombre_Proveedor.EditValue = ""
        Me.TxtNombre_Proveedor.Location = New System.Drawing.Point(120, 32)
        Me.TxtNombre_Proveedor.Name = "TxtNombre_Proveedor"
        '
        '
        '
        Me.TxtNombre_Proveedor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre_Proveedor.Size = New System.Drawing.Size(328, 19)
        Me.TxtNombre_Proveedor.TabIndex = 1
        '
        'TxtCodigo
        '
        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetOrden_Compras1, "ordencompra.Proveedor", True))
        Me.TxtCodigo.EditValue = ""
        Me.TxtCodigo.Location = New System.Drawing.Point(16, 32)
        Me.TxtCodigo.Name = "TxtCodigo"
        '
        '
        '
        Me.TxtCodigo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCodigo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCodigo.Size = New System.Drawing.Size(96, 19)
        Me.TxtCodigo.TabIndex = 0
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=PI3E;packet size=4096;integrated security=SSPI;data source=PI3E;pe" & _
            "rsist security info=False;initial catalog=SeePOS"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
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
        'dausuario
        '
        Me.dausuario.SelectCommand = Me.SqlSelectCommand3
        Me.dausuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna FROM Usuarios"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Adapter_Orden_Compra
        '
        Me.Adapter_Orden_Compra.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Orden_Compra.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Orden_Compra.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Orden_Compra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ordencompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Proveedor", "Proveedor"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("contado", "contado"), New System.Data.Common.DataColumnMapping("credito", "credito"), New System.Data.Common.DataColumnMapping("diascredito", "diascredito"), New System.Data.Common.DataColumnMapping("Plazo", "Plazo"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Impuesto", "Impuesto"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Usuario", "Usuario"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("entregar", "entregar"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("SubTotalGravado", "SubTotalGravado"), New System.Data.Common.DataColumnMapping("SubTotalExento", "SubTotalExento"), New System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado")})})
        Me.Adapter_Orden_Compra.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_diascredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diascredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_entregar", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregar", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"), New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"), New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Proveedor", System.Data.SqlDbType.Int, 4, "Proveedor"), New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@contado", System.Data.SqlDbType.Bit, 1, "contado"), New System.Data.SqlClient.SqlParameter("@credito", System.Data.SqlDbType.Bit, 1, "credito"), New System.Data.SqlClient.SqlParameter("@diascredito", System.Data.SqlDbType.Float, 8, "diascredito"), New System.Data.SqlClient.SqlParameter("@Plazo", System.Data.SqlDbType.Int, 4, "Plazo"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Impuesto", System.Data.SqlDbType.Float, 8, "Impuesto"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar, 255, "Usuario"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@entregar", System.Data.SqlDbType.VarChar, 255, "entregar"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@SubTotalGravado", System.Data.SqlDbType.Float, 8, "SubTotalGravado"), New System.Data.SqlClient.SqlParameter("@SubTotalExento", System.Data.SqlDbType.Float, 8, "SubTotalExento"), New System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Float, 8, "SubTotal"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Proveedor", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Proveedor", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalExento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalExento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SubTotalGravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubTotalGravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_contado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "contado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_diascredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "diascredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_entregar", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "entregar", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden")})
        '
        'Adapter_Detalle_Orden_Compras
        '
        Me.Adapter_Detalle_Orden_Compras.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Detalle_Orden_Compras.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Detalle_Orden_Compras.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Detalle_Orden_Compras.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "detalle_ordencompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Orden", "Orden"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CostoUnitario", "CostoUnitario"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("TotalCompra", "TotalCompra"), New System.Data.Common.DataColumnMapping("Porc_Descuento", "Porc_Descuento"), New System.Data.Common.DataColumnMapping("Descuento", "Descuento"), New System.Data.Common.DataColumnMapping("Porc_Impuesto", "Porc_Impuesto"), New System.Data.Common.DataColumnMapping("impuesto", "impuesto"), New System.Data.Common.DataColumnMapping("OtrosCargos", "OtrosCargos"), New System.Data.Common.DataColumnMapping("Monto_Flete", "Monto_Flete"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Gravado", "Gravado"), New System.Data.Common.DataColumnMapping("Exento", "Exento"), New System.Data.Common.DataColumnMapping("Vendidos", "Vendidos"), New System.Data.Common.DataColumnMapping("Exist_Actual", "Exist_Actual")})})
        Me.Adapter_Detalle_Orden_Compras.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cantidad", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cantidad", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CostoUnitario", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CostoUnitario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Exist_Actual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Exist_Actual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Gravado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Gravado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Flete", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Flete", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Orden", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Orden", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OtrosCargos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OtrosCargos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porc_Descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Porc_Impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Porc_Impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vendidos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vendidos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"), New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"), New System.Data.SqlClient.SqlParameter("@Vendidos", System.Data.SqlDbType.Float, 8, "Vendidos"), New System.Data.SqlClient.SqlParameter("@Exist_Actual", System.Data.SqlDbType.Float, 8, "Exist_Actual")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Orden", System.Data.SqlDbType.BigInt, 8, "Orden"), New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CostoUnitario", System.Data.SqlDbType.Float, 8, "CostoUnitario"), New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"), New System.Data.SqlClient.SqlParameter("@TotalCompra", System.Data.SqlDbType.Float, 8, "TotalCompra"), New System.Data.SqlClient.SqlParameter("@Porc_Descuento", System.Data.SqlDbType.Float, 8, "Porc_Descuento"), New System.Data.SqlClient.SqlParameter("@Descuento", System.Data.SqlDbType.Float, 8, "Descuento"), New System.Data.SqlClient.SqlParameter("@Porc_Impuesto", System.Data.SqlDbType.Float, 8, "Porc_Impuesto"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"), New System.Data.SqlClient.SqlParameter("@OtrosCargos", System.Data.SqlDbType.Float, 8, "OtrosCargos"), New System.Data.SqlClient.SqlParameter("@Monto_Flete", System.Data.SqlDbType.Float, 8, "Monto_Flete"), New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"), New System.Data.SqlClient.SqlParameter("@Gravado", System.Data.SqlDbType.Float, 8, "Gravado"), New System.Data.SqlClient.SqlParameter("@Exento", System.Data.SqlDbType.Float, 8, "Exento"), New System.Data.SqlClient.SqlParameter("@Vendidos", System.Data.SqlDbType.Float, 8, "Vendidos"), New System.Data.SqlClient.SqlParameter("@Exist_Actual", System.Data.SqlDbType.Float, 8, "Exist_Actual"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(360, 450)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 13)
        Me.Label48.TabIndex = 193
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(432, 450)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 0
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(488, 450)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 192
        '
        'TxtDescuentoT
        '
        Me.TxtDescuentoT.EditValue = ""
        Me.TxtDescuentoT.Location = New System.Drawing.Point(336, 396)
        Me.TxtDescuentoT.Name = "TxtDescuentoT"
        '
        '
        '
        Me.TxtDescuentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtDescuentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtDescuentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDescuentoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtDescuentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtDescuentoT.Properties.ReadOnly = True
        Me.TxtDescuentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.RoyalBlue)
        Me.TxtDescuentoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtDescuentoT.TabIndex = 86
        '
        'TxtImpuestoT
        '
        Me.TxtImpuestoT.EditValue = ""
        Me.TxtImpuestoT.Location = New System.Drawing.Point(440, 396)
        Me.TxtImpuestoT.Name = "TxtImpuestoT"
        '
        '
        '
        Me.TxtImpuestoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtImpuestoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtImpuestoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtImpuestoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtImpuestoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtImpuestoT.Properties.ReadOnly = True
        Me.TxtImpuestoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.RoyalBlue)
        Me.TxtImpuestoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtImpuestoT.TabIndex = 87
        '
        'TxtMonto
        '
        Me.TxtMonto.EditValue = ""
        Me.TxtMonto.Location = New System.Drawing.Point(544, 396)
        Me.TxtMonto.Name = "TxtMonto"
        '
        '
        '
        Me.TxtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtMonto.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.Properties.ReadOnly = True
        Me.TxtMonto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.RoyalBlue)
        Me.TxtMonto.Size = New System.Drawing.Size(96, 19)
        Me.TxtMonto.TabIndex = 88
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetOrden_Compras1, "ordencompra.Cod_Moneda", True))
        Me.ComboBox1.DataSource = Me.DataSetOrden_Compras1
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(476, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(84, 21)
        Me.ComboBox1.TabIndex = 195
        Me.ComboBox1.ValueMember = "Moneda.CodMoneda"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(476, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(84, 15)
        Me.Label30.TabIndex = 196
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Tipo_Cambio
        '
        Me.Label_Tipo_Cambio.BackColor = System.Drawing.Color.Transparent
        Me.Label_Tipo_Cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "Moneda.ValorCompra", True))
        Me.Label_Tipo_Cambio.Location = New System.Drawing.Point(568, 107)
        Me.Label_Tipo_Cambio.Name = "Label_Tipo_Cambio"
        Me.Label_Tipo_Cambio.Size = New System.Drawing.Size(72, 16)
        Me.Label_Tipo_Cambio.TabIndex = 197
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetOrden_Compras1, "ordencompra.Orden", True))
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(64, 8)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(60, 17)
        Me.TextEdit1.TabIndex = 89
        '
        'Txt_cedulaUsuario
        '
        Me.Txt_cedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_cedulaUsuario.Location = New System.Drawing.Point(552, 432)
        Me.Txt_cedulaUsuario.Name = "Txt_cedulaUsuario"
        Me.Txt_cedulaUsuario.Size = New System.Drawing.Size(88, 13)
        Me.Txt_cedulaUsuario.TabIndex = 199
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "ordencompra.ordencompradetalle_ordencompra"
        Me.GridControl1.DataSource = Me.DataSetOrden_Compras1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(8, 280)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(632, 96)
        Me.GridControl1.TabIndex = 200
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCostoUnitario, Me.colCantidad, Me.colGravado, Me.colExento, Me.colDescuento, Me.colimpuesto, Me.colTotalCompra})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.FilterInfo = ColumnFilterInfo10
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 69
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo11
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 151
        '
        'colCostoUnitario
        '
        Me.colCostoUnitario.Caption = "Precio Unit."
        Me.colCostoUnitario.FieldName = "CostoUnitario"
        Me.colCostoUnitario.FilterInfo = ColumnFilterInfo12
        Me.colCostoUnitario.Name = "colCostoUnitario"
        Me.colCostoUnitario.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCostoUnitario.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colCostoUnitario.VisibleIndex = 2
        Me.colCostoUnitario.Width = 100
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cant."
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.FilterInfo = ColumnFilterInfo13
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 3
        '
        'colGravado
        '
        Me.colGravado.Caption = "Gravado"
        Me.colGravado.FieldName = "Gravado"
        Me.colGravado.FilterInfo = ColumnFilterInfo14
        Me.colGravado.Name = "colGravado"
        Me.colGravado.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colGravado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colGravado.VisibleIndex = 6
        '
        'colExento
        '
        Me.colExento.Caption = "Exento"
        Me.colExento.FieldName = "Exento"
        Me.colExento.FilterInfo = ColumnFilterInfo15
        Me.colExento.Name = "colExento"
        Me.colExento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colExento.VisibleIndex = 7
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "% Desc."
        Me.colDescuento.FieldName = "Porc_Descuento"
        Me.colDescuento.FilterInfo = ColumnFilterInfo16
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescuento.SummaryItem.FieldName = "Descuento"
        Me.colDescuento.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colDescuento.VisibleIndex = 5
        '
        'colimpuesto
        '
        Me.colimpuesto.Caption = "% I.V."
        Me.colimpuesto.FieldName = "Porc_Impuesto"
        Me.colimpuesto.FilterInfo = ColumnFilterInfo17
        Me.colimpuesto.Name = "colimpuesto"
        Me.colimpuesto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colimpuesto.SummaryItem.FieldName = "impuesto"
        Me.colimpuesto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colimpuesto.VisibleIndex = 4
        '
        'colTotalCompra
        '
        Me.colTotalCompra.Caption = "Subtotal"
        Me.colTotalCompra.FieldName = "TotalCompra"
        Me.colTotalCompra.FilterInfo = ColumnFilterInfo18
        Me.colTotalCompra.Name = "colTotalCompra"
        Me.colTotalCompra.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotalCompra.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotalCompra.VisibleIndex = 8
        '
        'txtMontoImpuesto
        '
        Me.txtMontoImpuesto.EditValue = ""
        Me.txtMontoImpuesto.Location = New System.Drawing.Point(672, 40)
        Me.txtMontoImpuesto.Name = "txtMontoImpuesto"
        '
        '
        '
        Me.txtMontoImpuesto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoImpuesto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoImpuesto.Size = New System.Drawing.Size(104, 19)
        Me.txtMontoImpuesto.TabIndex = 201
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.Location = New System.Drawing.Point(672, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 16)
        Me.Label19.TabIndex = 202
        Me.Label19.Text = "Monto impuesto"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(672, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 16)
        Me.Label25.TabIndex = 204
        Me.Label25.Text = "Monto Descuento"
        '
        'txtmontodescuento
        '
        Me.txtmontodescuento.EditValue = ""
        Me.txtmontodescuento.Location = New System.Drawing.Point(672, 88)
        Me.txtmontodescuento.Name = "txtmontodescuento"
        '
        '
        '
        Me.txtmontodescuento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmontodescuento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtmontodescuento.Size = New System.Drawing.Size(104, 19)
        Me.txtmontodescuento.TabIndex = 203
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label26.Location = New System.Drawing.Point(672, 152)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 16)
        Me.Label26.TabIndex = 206
        Me.Label26.Text = "Sub Gravado"
        '
        'txtSGravado
        '
        Me.txtSGravado.EditValue = ""
        Me.txtSGravado.Location = New System.Drawing.Point(672, 168)
        Me.txtSGravado.Name = "txtSGravado"
        '
        '
        '
        Me.txtSGravado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSGravado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSGravado.Size = New System.Drawing.Size(104, 19)
        Me.txtSGravado.TabIndex = 205
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Location = New System.Drawing.Point(672, 208)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(104, 16)
        Me.Label27.TabIndex = 208
        Me.Label27.Text = "Sub. Exento"
        '
        'txtSExcento
        '
        Me.txtSExcento.EditValue = ""
        Me.txtSExcento.Location = New System.Drawing.Point(672, 224)
        Me.txtSExcento.Name = "txtSExcento"
        '
        '
        '
        Me.txtSExcento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSExcento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSExcento.Size = New System.Drawing.Size(104, 19)
        Me.txtSExcento.TabIndex = 207
        '
        'TxtSubGravadoT
        '
        Me.TxtSubGravadoT.EditValue = ""
        Me.TxtSubGravadoT.Location = New System.Drawing.Point(24, 396)
        Me.TxtSubGravadoT.Name = "TxtSubGravadoT"
        '
        '
        '
        Me.TxtSubGravadoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtSubGravadoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtSubGravadoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubGravadoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtSubGravadoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubGravadoT.Properties.ReadOnly = True
        Me.TxtSubGravadoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.RoyalBlue)
        Me.TxtSubGravadoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtSubGravadoT.TabIndex = 210
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(24, 380)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 17)
        Me.Label16.TabIndex = 209
        Me.Label16.Text = "Sub. Gravado"
        '
        'TxtSubExentoT
        '
        Me.TxtSubExentoT.EditValue = ""
        Me.TxtSubExentoT.Location = New System.Drawing.Point(128, 396)
        Me.TxtSubExentoT.Name = "TxtSubExentoT"
        '
        '
        '
        Me.TxtSubExentoT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtSubExentoT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtSubExentoT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubExentoT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtSubExentoT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubExentoT.Properties.ReadOnly = True
        Me.TxtSubExentoT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.RoyalBlue)
        Me.TxtSubExentoT.Size = New System.Drawing.Size(96, 19)
        Me.TxtSubExentoT.TabIndex = 212
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.Location = New System.Drawing.Point(128, 380)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 17)
        Me.Label28.TabIndex = 211
        Me.Label28.Text = "Sub. Exento"
        '
        'TxtSubtotalT
        '
        Me.TxtSubtotalT.EditValue = ""
        Me.TxtSubtotalT.Location = New System.Drawing.Point(232, 396)
        Me.TxtSubtotalT.Name = "TxtSubtotalT"
        '
        '
        '
        Me.TxtSubtotalT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtSubtotalT.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtSubtotalT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubtotalT.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtSubtotalT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtSubtotalT.Properties.ReadOnly = True
        Me.TxtSubtotalT.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.RoyalBlue)
        Me.TxtSubtotalT.Size = New System.Drawing.Size(96, 19)
        Me.TxtSubtotalT.TabIndex = 214
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.Location = New System.Drawing.Point(232, 380)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 17)
        Me.Label29.TabIndex = 213
        Me.Label29.Text = "Subtotal"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(568, 107)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 16)
        Me.Label31.TabIndex = 197
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(568, 91)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(76, 18)
        Me.Label32.TabIndex = 198
        Me.Label32.Text = "Tipo Cambio"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetOrden_Compras1, "ordencompra.Anulado", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(560, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox1.TabIndex = 215
        Me.CheckBox1.Text = "ANULADA"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'frmOrdenCompra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(658, 473)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtSubtotalT)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtSubExentoT)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TxtSubGravadoT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtSExcento)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtSGravado)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtmontodescuento)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtMontoImpuesto)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.Txtobservaciones)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.Label_Tipo_Cambio)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtImpuestoT)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.TxtDescuentoT)
        Me.Controls.Add(Me.daordencompra)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Txt_cedulaUsuario)
        Me.MaximumSize = New System.Drawing.Size(664, 502)
        Me.MinimumSize = New System.Drawing.Size(664, 502)
        Me.Name = "frmOrdenCompra"
        Me.Text = "Orden de Compra Manual"
        Me.Controls.SetChildIndex(Me.Txt_cedulaUsuario, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label32, 0)
        Me.Controls.SetChildIndex(Me.Label31, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.daordencompra, 0)
        Me.Controls.SetChildIndex(Me.TxtDescuentoT, 0)
        Me.Controls.SetChildIndex(Me.TxtMonto, 0)
        Me.Controls.SetChildIndex(Me.TxtImpuestoT, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.Label48, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.Label_Tipo_Cambio, 0)
        Me.Controls.SetChildIndex(Me.TextEdit1, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.Txtobservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.txtMontoImpuesto, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.txtmontodescuento, 0)
        Me.Controls.SetChildIndex(Me.Label25, 0)
        Me.Controls.SetChildIndex(Me.txtSGravado, 0)
        Me.Controls.SetChildIndex(Me.Label26, 0)
        Me.Controls.SetChildIndex(Me.txtSExcento, 0)
        Me.Controls.SetChildIndex(Me.Label27, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.TxtSubGravadoT, 0)
        Me.Controls.SetChildIndex(Me.Label28, 0)
        Me.Controls.SetChildIndex(Me.TxtSubExentoT, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.TxtSubtotalT, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TxtDias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetOrden_Compras1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TxtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOtros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFletes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tex_Porc_Imp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPorcDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioUni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TxtEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDias_Entrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TxtNombre_Proveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDescuentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtImpuestoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoImpuesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmontodescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSGravado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSExcento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubGravadoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubExentoT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubtotalT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region " Variable "             'Definicion de Variable /Albert Estrada\
    Private cConexion As New Conexion
    Private sqlConexion As SqlConnection
    Private nuevo As Boolean = True
    'Dim perfil_administrador As Boolean
    Dim MonedaCosto As Integer
    Dim MonedaOrdenCompra As Integer
    Dim ValorCompra_OrdenCompra As Double
    Dim ValorCosto As Double
    Dim Gravado As Double
    Dim Exento As Double
    Dim buscando As Boolean

#End Region
    'Private Sub binding()

    '    'Me.TxtTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Facturaciones, "Ventas.Tipo"))
    '    TxtCodigo_art.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetOrden_Compras1, "detalle_ordencompra.codigo"))
    '    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Codigo") = TxtCodigo_art.Text
    '    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Descripcion") = Txt_Descri_Articulo.Text
    '    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("CostoUnitario") = TxtPrecioUni.Text
    '    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Cantidad") = TxtCant.Text
    '    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Costo") = TxtCant.Text
    'End Sub

    Private Sub frmOrdenCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            defaultvalue_orden()
            defaultvalue_detalle()

            Me.dausuario.Fill(Me.DataSetOrden_Compras1, "Usuarios")
            Me.Adapter_Moneda.Fill(Me.DataSetOrden_Compras1, "Moneda")

            Me.DataSetOrden_Compras1.ordencompra.OrdenColumn.AutoIncrement = True
            Me.DataSetOrden_Compras1.ordencompra.OrdenColumn.AutoIncrementSeed = -1
            Me.DataSetOrden_Compras1.ordencompra.OrdenColumn.AutoIncrementStep = -1

            Me.DataSetOrden_Compras1.detalle_ordencompra.IdColumn.AutoIncrement = True
            Me.DataSetOrden_Compras1.detalle_ordencompra.IdColumn.AutoIncrementSeed = -1
            Me.DataSetOrden_Compras1.detalle_ordencompra.IdColumn.AutoIncrementStep = -1

            Me.DataSetOrden_Compras1.detalle_ordencompra.VendidosColumn.DefaultValue = 1
            Me.DataSetOrden_Compras1.detalle_ordencompra.Exist_ActualColumn.DefaultValue = 1


            'Me.DataSet_Facturaciones.Ventas.PagoImpuestoColumn.DefaultValue
            Me.DataSetOrden_Compras1.detalle_ordencompra.IdColumn.AutoIncrementStep = -1

            Me.txtUsuario.Focus()


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub defaultvalue_detalle()
        Try
            Me.DataSetOrden_Compras1.detalle_ordencompra.CostoUnitarioColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.CantidadColumn.DefaultValue = 1
            Me.DataSetOrden_Compras1.detalle_ordencompra.impuestoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.Porc_ImpuestoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.Porc_DescuentoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.DescuentoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.TotalCompraColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.OtrosCargosColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.Monto_FleteColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.GravadoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.detalle_ordencompra.ExentoColumn.DefaultValue = 0

        Catch ex As SystemException
            MsgBox(ex.Message)

        End Try


    End Sub

    Private Sub defaultvalue_orden()
        Try
            Me.DataSetOrden_Compras1.ordencompra.ObservacionesColumn.DefaultValue = ""
            Me.DataSetOrden_Compras1.ordencompra.FechaColumn.DefaultValue = Now
            Me.DataSetOrden_Compras1.ordencompra.contadoColumn.DefaultValue = False
            Me.DataSetOrden_Compras1.ordencompra.creditoColumn.DefaultValue = True
            Me.DataSetOrden_Compras1.ordencompra.diascreditoColumn.DefaultValue = 30
            Me.DataSetOrden_Compras1.ordencompra.PlazoColumn.DefaultValue = 1
            Me.DataSetOrden_Compras1.ordencompra.TotalColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.ordencompra.DescuentoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.ordencompra.ImpuestoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.ordencompra.entregarColumn.DefaultValue = ""
            Me.DataSetOrden_Compras1.ordencompra.Cod_MonedaColumn.DefaultValue = 1
            Me.DataSetOrden_Compras1.ordencompra.ProveedorColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.ordencompra.NombreColumn.DefaultValue = ""
            Me.DataSetOrden_Compras1.ordencompra.UsuarioColumn.DefaultValue = ""
            Me.DataSetOrden_Compras1.ordencompra.NombreUsuarioColumn.DefaultValue = ""
            Me.DataSetOrden_Compras1.ordencompra.SubTotalExentoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.ordencompra.SubTotalGravadoColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.ordencompra.SubTotalColumn.DefaultValue = 0
            Me.DataSetOrden_Compras1.ordencompra.AnuladoColumn.DefaultValue = False
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Nueva_Orden_Compra()
        Try
            'Me.defaultvalue_orden()
            Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").CancelCurrentEdit()
            Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()
            Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").AddNew()
            Me.GroupBox1.Enabled = False
            Me.GroupBox2.Enabled = False
            Me.GroupBox4.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.Txtobservaciones.Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Loggin_Usuario()
        Try

            If Me.BindingContext(Me.DataSetOrden_Compras1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSetOrden_Compras1.Usuarios.Select("Clave_Interna ='" & txtUsuario.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    strCedula = Usua("Cedula")
                    PMU = VSM(Usua("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 

                    If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub


                    'Dim tipo As String = Usua("Perfil")

                    'If tipo <> "INVENTARIO" And tipo <> "ADMINISTRADOR" And tipo <> "ADMINISTRATIVO" Then
                    'If PMU.Others Then
                    '    MsgBox("Usted no tiene permisos para realizar Ordenes de Compras", MsgBoxStyle.Exclamation)
                    '    Me.txtUsuario.Text = ""
                    '    Me.txtUsuario.Focus()
                    '    Exit Sub
                    'End If

                    ' Me.logeado = True


                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña

                    Me.ToolBar1.Buttons(0).Text = "Cancelar"
                    Me.ToolBar1.Buttons(0).ImageIndex = 8
                    Me.ToolBar1.Buttons(3).Enabled = False

                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(5).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = False

                    'If Usua("Perfil") = "ADMINISTRADOR" Then ' si el usuario tiene perfil de administrador
                    'Me.perfil_administrador = True
                    'Else
                    'perfil_administrador = False
                    'End If




                    Me.ComboBox1.Enabled = True
                    'Me.txtorden.Enabled = True

                    Me.Nueva_Orden_Compra()
                    Me.Txt_cedulaUsuario.Text = Usua("Cedula")
                    txtNombreUsuario.Text = Usua("Nombre")
                    Me.ComboBox1.Focus()
                    'inicializar()

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

    Private Sub consultarorden()
        Try
            'If usua.Perfil <> "ADMINISTRADOR" And usua.Perfil <> "ADMINISTRATIVO" And usua.Perfil <> "CAJA" Then
            '    MsgBox("Usted no puede buscar facturas", MsgBoxStyle.Information)
            '    Exit Sub
            'End If

            If Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Count > 0 Then
                If (MsgBox("Actualmente se está realizando una Orden de Compra, si continúa se perderan los datos de la orden actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.ToolBar1.Buttons(0).Enabled = True

            Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
            Me.DataSetOrden_Compras1.ordencompra.Clear()

            Dim identificador As Double

            Dim Fx As New cFunciones

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Orden, Nombre,Fecha from ordencompra Order by Fecha DESC", "Nombre", "Fecha", "Buscar Orden de Compra"))
            buscando = True
            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                Me.buscando = False
                Exit Sub
            End If

            Me.LlenarOrden(identificador)
            '*******************************************************************************************

            TxtCodigo_art.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Codigo")
            Txt_Descri_Articulo.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Descripcion")
            TxtPrecioUni.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("CostoUnitario")
            TxtCant.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Cantidad")
            TxtCosto.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Costo")
            TxtFletes.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Monto_Flete")
            TxtPorcDesc.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Descuento")
            Tex_Porc_Imp.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Impuesto")
            TxtOtros.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("OtrosCargos")

            TextEdit1.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("orden")
            TxtCodigo.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Proveedor")
            'TxtNombre_Proveedor = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Nombre")
            OpContado.Checked = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Contado")
            OpCredito.Checked = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Credito")
            TxtDias.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("DiasCredito")
            TxtDias_Entrega.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Plazo")
            TxtEntrega.Text = Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Entregar")

            '*******************************************************************************************
            Me.Calculos_Articulo()
            Calcular_Totales_Orden_Compra()

            Me.GroupBox1.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.GroupBox4.Enabled = True
            Me.GroupBox3.Enabled = True
            Me.Txtobservaciones.Enabled = True

            Me.ComboBox1.Enabled = False

            Me.ToolBar1.Buttons(2).Enabled = True
            Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Function LlenarOrden(ByVal Id As Double)

        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        '
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ''''''''' ORDEN ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = CadenaConexionSeePOS
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM ordencompra WHERE (Orden = @Id_Factura) "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            cmdv.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(Me.DataSetOrden_Compras1, "ordencompra")


            '''''''''ORDEN DETALLE''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM detalle_ordencompra WHERE (Orden = @Id_Factura) "

            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id_Factura", SqlDbType.BigInt))

            cmd.Parameters("@Id_Factura").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(Me.DataSetOrden_Compras1.detalle_ordencompra)


        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function




    Private Sub consultarproveedor()
        Try
            Dim cFunciones As New cFunciones
            cFunciones.BuscarDatos("select codigoprov as Código, nombre as Proveedor from proveedores", "nombre", "Proveedores")
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub consultaarticulos()
        Try

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub



    Function Registrar()
        Try
            Me.ToolBar1.Buttons(2).Enabled = False

            If Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Count = 0 Then 'Si la factura no tiene detalle
                MsgBox("No se Puede Registrar una Orden sin artículos", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = True
                Exit Function
            End If

            If MessageBox.Show("¿Desea Registrar esta Orden?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Me.ToolBar1.Buttons(2).Enabled = True
                Exit Function
            End If
            '   Me.ToolBar1.Buttons(3).Enabled = False


            Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()


            If Me.RegistrarOrden() Then  'se registra en la base de datos then

                Me.DataSetOrden_Compras1.AcceptChanges()

                Me.TxtNombre_Proveedor.Enabled = True
                'Dim id As Long = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas").Current("Id")

                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True


                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False



                Me.GroupBox3.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox1.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.Txtobservaciones.Enabled = False
                Me.Label10.Visible = False
                Me.Label11.Visible = False



                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
                Me.txtUsuario.Focus()

                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)
                imprimir()


                Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
                Me.DataSetOrden_Compras1.ordencompra.Clear()

                Me.ToolBar1.Buttons(2).Enabled = False


            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)

                Me.ToolBar1.Buttons(2).Enabled = True
                'Me.txtUsuario.Enabled = True

            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message)
        End Try

    End Function

    Function imprimir()
        Try
            Dim OrdenC_Reporte As New Reporte_Orden_Compra
            Dim visor As New frmVisorReportes
            OrdenC_Reporte.SetParameterValue(0, CDbl(TextEdit1.Text))
            CrystalReportsConexion.LoadReportViewer(visor.rptViewer, OrdenC_Reporte)
            visor.rptViewer.Visible = True
            OrdenC_Reporte = Nothing
            visor.ShowDialog()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

    Function RegistrarOrden() As Boolean

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try

            Me.Adapter_Orden_Compra.InsertCommand.Transaction = Trans
            Me.Adapter_Detalle_Orden_Compras.InsertCommand.Transaction = Trans

            Me.Adapter_Orden_Compra.UpdateCommand.Transaction = Trans
            Me.Adapter_Detalle_Orden_Compras.UpdateCommand.Transaction = Trans

            Me.Adapter_Orden_Compra.DeleteCommand.Transaction = Trans
            Me.Adapter_Detalle_Orden_Compras.DeleteCommand.Transaction = Trans

            Me.Adapter_Orden_Compra.Update(Me.DataSetOrden_Compras1, "ordencompra")
            Me.Adapter_Detalle_Orden_Compras.Update(Me.DataSetOrden_Compras1, "detalle_ordencompra")
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try


    End Function
    Function AnularOrden()
        Try
            Dim resp As Integer
            If Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Count > 0 Then
                If Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Count > 0 Then

                    resp = MessageBox.Show("¿Desea Anular esta Orden de Compra...?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                    If resp = 6 Then
                        CheckBox1.Checked = True
                        Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()

                        Me.DataSetOrden_Compras1.AcceptChanges()
                        MsgBox("La Orden de Compra ha sido anulada correctamente", MsgBoxStyle.Information)
                        Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
                        Me.DataSetOrden_Compras1.ordencompra.Clear()

                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False


                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtNombreUsuario.Text = ""
                        Me.txtUsuario.Focus()
                    Else : Exit Function

                    End If
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Function



    Sub boton_nuevo()
        Try
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.ToolBar1.Buttons(3).Enabled = False


                Me.GroupBox1.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox3.Enabled = False
                Me.GroupBox4.Enabled = False
                Me.Txtobservaciones.Enabled = False



                Me.txtUsuario.Enabled = True
                Me.txtUsuario.Text = ""
                Me.txtNombreUsuario.Text = ""
                Me.txtUsuario.Focus()


                Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
                Me.DataSetOrden_Compras1.ordencompra.Clear()
                '*********************************************************************
                'jcga 03/05/2007 2:46 pm
                TxtCodigo_art.Text = ""
                Txt_Descri_Articulo.Text = ""
                TxtPrecioUni.Text = ""
                TxtFletes.Text = ""
                TxtOtros.Text = ""
                TxtCosto.Text = ""
                TxtPorcDesc.Text = ""
                Tex_Porc_Imp.Text = ""
                TxtCant.Text = ""
                TxtTotal.Text = ""
                '*********************************************************************




            Else
                If Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Count = 0 Then 'Si la factura no tiene detalle
                    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").CancelCurrentEdit()

                    Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
                    Me.DataSetOrden_Compras1.ordencompra.Clear()

                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    'Me.ToolBar1.Buttons(3).Enabled = True
                    Me.TxtNombre_Proveedor.Enabled = True

                    Me.GroupBox1.Enabled = False
                    Me.GroupBox2.Enabled = False
                    Me.GroupBox3.Enabled = False
                    Me.GroupBox4.Enabled = False
                    Me.Txtobservaciones.Enabled = False


                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""

                    Me.txtUsuario.Focus()
                    Exit Sub
                End If

                If MessageBox.Show("Desea Guardar esta Factura", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                    Me.Registrar() ' se guarda en la base de datos
                    'Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
                    'Me.ToolBar1.Buttons(0).ImageIndex = 0
                    'Me.ToolBar1.Buttons(3).Enabled = True

                Else

                    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").CancelCurrentEdit()

                    Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
                    Me.DataSetOrden_Compras1.ordencompra.Clear()

                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    Me.ToolBar1.Buttons(3).Enabled = True

                    Me.GroupBox1.Enabled = False
                    Me.GroupBox2.Enabled = False
                    Me.GroupBox3.Enabled = False
                    Me.GroupBox4.Enabled = False
                    Me.Txtobservaciones.Enabled = False

                    Me.txtUsuario.Enabled = True
                    Me.txtUsuario.Text = ""
                    Me.txtNombreUsuario.Text = ""
                    Me.txtUsuario.Focus()


                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub OpContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpContado.CheckedChanged
        If Me.OpContado.Checked = True Then
            Me.TxtDias.Visible = False
            Me.TxtDias.Text = 0
            Label21.Visible = False
        End If
    End Sub

    Private Sub OpCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpCredito.CheckedChanged
        If Me.OpCredito.Checked = True Then
            Me.TxtDias.Visible = True
            Me.TxtDias.Text = 0
            Label21.Visible = True
        End If
    End Sub


    Private Sub TxtCodigo_art_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo_art.KeyDown

        If e.KeyCode = Keys.F1 Then
            Dim BuscarArt As New FrmBuscarArticulo2
            Try
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").AddNew()


                BuscarArt.StartPosition = FormStartPosition.CenterParent
                BuscarArt.ShowDialog()

                If BuscarArt.Cancelado Then
                    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                    Exit Sub
                End If

                Me.TxtCodigo_art.Text = BuscarArt.Codigo
                BuscarArt.Dispose()


                CargarInformacionArticulo(Me.TxtCodigo_art.Text)
                Calcular_Totales_Orden_Compra()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


        If e.KeyCode = Keys.Enter Then
            Try
                If Me.TxtCodigo_art.Text = "" Then Exit Sub
                Dim cod_art As String
                cod_art = Me.TxtCodigo_art.Text
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").AddNew()

                CargarInformacionArticulo(cod_art)
                Calcular_Totales_Orden_Compra()

            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub CargarInformacionArticulo(ByVal codigo As String)
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean
        If codigo <> Nothing Then
            If Me.SqlConnection1.State = ConnectionState.Closed Then SqlConnection1.Open()
            rs = cConexion.GetRecorset(SqlConnection1, "SELECT Codigo, Barras, dbo.Inventario.Descripcion + ' (' + Presentaciones.Presentaciones + ') ' AS Descripcion ,PrecioBase, Fletes, OtrosCargos, Costo, MonedaCosto, IVenta from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion AND (Inhabilitado = 0) and Codigo ='" & codigo & "' or Barras = '" & codigo & "'")

            Encontrado = False
            While rs.Read
                Try

                    Encontrado = True
                    Me.TxtCodigo_art.Text = rs("Codigo")
                    Me.Txt_Descri_Articulo.Text = rs("Descripcion")
                    Me.Tex_Porc_Imp.Text = rs("IVenta") 'Format(rs("IVenta"), "#,#0.00").ToString
                    Me.TxtPrecioUni.Text = rs("PrecioBase")
                    'Me.TxtCosto.Text = rs("Costo")
                    Me.TxtFletes.Text = rs("Fletes")
                    Me.TxtOtros.Text = rs("OtrosCargos")

                    MonedaCosto = rs("MonedaCosto") 'rs("MonedaCosto")

                    MonedaOrdenCompra = Me.BindingContext(Me.DataSetOrden_Compras1, "Moneda").Current("CodMoneda")


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End While
            rs.Close()

            If Not Encontrado Then
                MsgBox("No existe un artículo con este código", MsgBoxStyle.Exclamation)
                'Me.txtCodArticulo.Text = ""
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                Me.TxtCodigo_art.Focus()
                Exit Sub
            End If

            rs = cConexion.GetRecorset(Me.SqlConnection1, "Select ValorCompra from Moneda where CodMoneda = " & MonedaCosto)
            While rs.Read
                Try
                    ValorCosto = rs("ValorCompra")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Me.SqlConnection1.Close()
                End Try
            End While
            rs.Close()


            ValorCompra_OrdenCompra = CDbl(Me.Label_Tipo_Cambio.Text)


            'rs = cConexion.GetRecorset(sqlConexion, "Select ValorCompra from Moneda where CodMoneda = " & MonedaOrdenCompra)
            'While rs.Read
            '    Try
            '        ValorOrden_Compra = rs("ValorCompra")
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message)
            '        cConexion.DesConectar(cConexion.Conectar)
            '    End Try
            'End While
            rs.Close()

            Calculo_precio_unitario()

            If Me.Txt_Descri_Articulo.Text <> "" Then 'si se recuperaron los datos de un articulo
                Me.GridControl1.Enabled = False
                Me.TxtPrecioUni.Focus()

            Else ' si no se recupero ningun articulo, se termina la edicion

                Try

                    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                    Me.txtCodArt.Focus()

                Catch ex As SystemException
                    MsgBox(ex.Message)
                    Me.SqlConnection1.Close()
                End Try

                Me.SqlConnection1.Close()

            End If
        End If
    End Sub

    Function Calculo_precio_unitario()
        Try

            'Calculo de Costo

            Me.TxtPrecioUni.Text = Math.Round((Me.TxtPrecioUni.Text * (ValorCosto / ValorCompra_OrdenCompra)), 2)
            Me.TxtFletes.Text = (CDbl(Me.TxtFletes.Text) * (ValorCosto / ValorCompra_OrdenCompra))
            Me.TxtOtros.Text = (CDbl(TxtOtros.Text) * (ValorCosto / ValorCompra_OrdenCompra))
            Me.TxtCosto.Text = Me.TxtPrecioUni.Text + Me.TxtFletes.Text + Me.TxtOtros.Text
            'Me.precio_unitario = txtPrecioUnit.Text

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try


    End Function

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Loggin_Usuario()
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            inicializar()
        End If
    End Sub

    Function inicializar()
        Try

            If Me.ComboBox1.SelectedIndex = -1 Then
                MsgBox("Debe Seleccionar la Moneda en la que va a realizar la orden de compra", MsgBoxStyle.Exclamation)
                Exit Function
            End If

            Me.GroupBox1.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.GroupBox4.Enabled = True
            Me.Txtobservaciones.Enabled = True

            Me.ComboBox1.Enabled = False
            TxtCodigo.Focus()


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try



    End Function


    Private Sub TxtCodigo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.EditValueChanged

    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                Dim Fx As New cFunciones
                Dim valor As String
                valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
                If valor <> "" Then
                    Me.TxtCodigo.Text = valor
                    Cargar_info_proveedor(valor)
                End If
            Case Keys.Enter
                If Me.TxtCodigo.Text <> "" Then Cargar_info_proveedor(Me.TxtCodigo.Text)
                'Me.TxtNombre_Proveedor.Enabled = False
                'Me.TxtDias.Focus()
                'Me.TxtNombre_Proveedor.Focus()
        End Select

    End Sub

    Sub Cargar_info_proveedor(ByVal cod As String)
        Try
            Dim func As New Conexion
            Dim Proveedor As SqlDataReader
            If Me.SqlConnection1.State = ConnectionState.Closed Then Me.SqlConnection1.Open()
            Proveedor = func.GetRecorset(Me.SqlConnection1, "Select CodigoProv, Nombre, Plazo from Proveedores where CodigoProv =" & CInt(cod))

            While Proveedor.Read <> 0
                Me.TxtNombre_Proveedor.Text = Proveedor("Nombre")
                TxtDias.Text = Proveedor("Plazo")
                Me.TxtNombre_Proveedor.Enabled = False
                Me.TxtDias.Focus()
            End While
            Me.SqlConnection1.Close()

        Catch ex As SystemException
            MsgBox(ex.Message)
            Me.SqlConnection1.Close()
        End Try
    End Sub


    Private Sub TxtEntrega_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEntrega.EditValueChanged

    End Sub

    Private Sub TxtEntrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEntrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()
                Me.GroupBox3.Enabled = True
                Me.TxtCodigo_art.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Tex_PorcDesc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tex_Porc_Imp.EditValueChanged

    End Sub

    Private Sub TxtCant_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCant.EditValueChanged

    End Sub

    Private Sub TxtCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCant.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then ' se guarda la cotización en el dataset

                If Me.TxtCant.Text = "" Then Exit Sub
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Codigo") = TxtCodigo_art.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Descripcion") = Txt_Descri_Articulo.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("CostoUnitario") = TxtPrecioUni.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Cantidad") = TxtCant.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Costo") = TxtCant.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Vendidos") = 0
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Exist_Actual") = 0
                ''<<<<
                'Calculos_Articulo()
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Gravado") = CDbl(Me.TxtSubGravadoT.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Exento") = CDbl(Me.TxtSubExentoT.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("impuesto") = CDbl(Me.TxtImpuestoT.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Impuesto") = CDbl(Me.Tex_Porc_Imp.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Porc_Descuento") = CDbl(Me.TxtPorcDesc.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Descuento") = CDbl(Me.TxtDescuentoT.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("TotalCompra") = CDbl(Me.TxtMonto.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("OtrosCargos") = CDbl(Me.TxtOtros.Text)
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Current("Monto_Flete") = CDbl(Me.TxtFletes.Text)

                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("subTotalGravado") = TxtSubGravadoT.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("subTotalExento") = TxtSubExentoT.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("subTotal") = TxtSubtotalT.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Total") = TxtMonto.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Impuesto") = TxtImpuestoT.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Descuento") = TxtDescuentoT.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("NombreUsuario") = txtNombreUsuario.Text
                'Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Current("Usuario") = strCedula

                '<<<<

                meter_al_detalle()
                TxtCodigo_art.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub
    Function meter_al_detalle()
        Try
            Dim resp As Integer
            If Me.TxtCant.Text = "" Or Me.TxtCant.Text = "0" Then
                MsgBox("La Cantidad de artículos no es válida", MsgBoxStyle.Exclamation)
                Me.TxtCant.Text = "1"
                Exit Function
            End If
            resp = MessageBox.Show("¿Desea agregar este artículo a la Orden?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                Me.GridControl1.Enabled = True
                Me.TxtCodigo_art.Focus()
                Exit Function
            End If

            Me.Calculos_Articulo()

            BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()

            Calcular_totales()
            'Me.txtCodArt.Focus()
            Me.GridControl1.Enabled = True
            Me.ToolBarRegistrar.Enabled = True
            'Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Position = Me.BindingContext(Me.DataSet_Facturaciones, "Ventas.VentasVentas_Detalle").Count
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Function Calcular_totales()
        Try

            BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
            Calcular_Totales_Orden_Compra()

            BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()
            BindingContext(Me.DataSetOrden_Compras1, "ordencompra").AddNew()
            BindingContext(Me.DataSetOrden_Compras1, "ordencompra").CancelCurrentEdit()
            BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Position = BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Count

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Function Calcular_Totales_Orden_Compra() ' calcula el monto Total de la cotización
        Try

            TxtSubtotalT.Text = Math.Round(Me.colTotalCompra.SummaryItem.SummaryValue, 2)
            Me.TxtSubGravadoT.Text = Math.Round(Me.colGravado.SummaryItem.SummaryValue, 2)
            Me.TxtSubExentoT.Text = Math.Round(Me.colExento.SummaryItem.SummaryValue, 2)
            TxtDescuentoT.Text = Math.Round(Me.colDescuento.SummaryItem.SummaryValue, 2)
            TxtImpuestoT.Text = Math.Round(Me.colimpuesto.SummaryItem.SummaryValue, 2)
            TxtMonto.Text = Math.Round(CDbl(TxtSubtotalT.Text) - CDbl(Me.TxtDescuentoT.Text) + CDbl(Me.TxtImpuestoT.Text), 2)

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try


    End Function




    Private Sub Calculos_Articulo()

        Try
            Dim DescuentoCalc As Double

            'Me.Tex_PorcDesc.Text = Me.impuesto_cliente * CDbl(Me.txtImpVenta.Text) / 100


            DescuentoCalc = (CDbl(TxtPrecioUni.Text) * CDbl(Me.TxtCant.Text)) * (CDbl(Me.TxtPorcDesc.Text) / 100)
            'Me.txtmontodescuento.Text = DescuentoCalc  ' pone el monto de descuento
            Me.TxtDescuentoT.Text = DescuentoCalc  ' pone el monto de descuento

            If Me.Tex_Porc_Imp.Text <> 0 Then 'si tiene impuesto de venta
                If (CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text)) > CDbl(TxtPrecioUni.Text) Then
                    TxtFletes.Text = 0
                    TxtOtros.Text = 0
                End If

                Gravado = ((CDbl(TxtPrecioUni.Text)) * CDbl(Me.TxtCant.Text))
                'txtMontoImpuesto.Text = (Gravado - CDbl(Me.txtmontodescuento.Text)) * (CDbl(Tex_Porc_Imp.Text) / 100)
                Me.TxtImpuestoT.Text = (Gravado - CDbl(Me.TxtDescuentoT.Text)) * (CDbl(Tex_Porc_Imp.Text) / 100)
                TxtSubGravadoT.Text = Gravado
                Exento = 0

            Else 'si no tiene impuesto de venta
                Exento = ((CDbl(TxtPrecioUni.Text) - CDbl(TxtFletes.Text) - CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
                Gravado = 0
                txtMontoImpuesto.Text = 0
                TxtSubGravadoT.Text = 0
                TxtSubExentoT.Text = Exento
            End If

            Exento = Exento + ((CDbl(TxtFletes.Text) + CDbl(TxtOtros.Text)) * CDbl(Me.TxtCant.Text))
            TxtSubExentoT.Text = Exento
            TxtTotal.Text = CDbl(TxtSubGravadoT.Text) + CDbl(TxtSubExentoT.Text) '+ CDbl(Me.txtmontodescuento.Text)
            'Me.TxtMonto.Text = CDbl(TxtSubGravadoT.Text) + CDbl(TxtSubExentoT.Text) '+ CDbl(Me.txtmontodescuento.Text)


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Registrar()


    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Eliminar_Ariculo_Detalle()
        End If
    End Sub

    Private Sub Eliminar_Ariculo_Detalle()
        Dim resp As Integer
        Try 'se intenta hacer
            If BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Count > 0 Then  ' si hay ubicaciones

                resp = MessageBox.Show("¿Desea eliminar este artículo de la Orden de Compra?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

                If resp = 6 Then
                    BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").RemoveAt(Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Position)
                    BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                    Me.Calcular_totales()
                    BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").EndCurrentEdit()
                Else
                    BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Artículos para eliminar en la Orden de Compra", MsgBoxStyle.Information)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Eliminar_Orden()
    '    Dim resp As Integer
    '    Try 'se intenta hacer
    '        If BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Count > 0 Then  ' si hay ubicaciones

    '            resp = MessageBox.Show("¿Desea eliminar esta orden de compra?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

    '            If resp = 6 Then
    '                BindingContext(Me.DataSetOrden_Compras1, "ordencompra").RemoveAt(Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Position)
    '                BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()

    '                If Me.RegistrarOrden() Then
    '                    Me.DataSetOrden_Compras1.AcceptChanges()
    '                    Me.ToolBar1.Buttons(4).Enabled = True
    '                    Me.ToolBar1.Buttons(1).Enabled = True

    '                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
    '                    Me.ToolBar1.Buttons(0).ImageIndex = 0
    '                    Me.ToolBar1.Buttons(3).Enabled = False
    '                    Me.ToolBar1.Buttons(2).Enabled = False
    '                    Me.ToolBar1.Buttons(4).Enabled = False

    '                    Me.GroupBox3.Enabled = False
    '                    Me.GroupBox2.Enabled = False
    '                    Me.GroupBox1.Enabled = False
    '                    Me.GroupBox4.Enabled = False
    '                    Me.Txtobservaciones.Enabled = False
    '                    Me.Label10.Visible = False
    '                    Me.Label11.Visible = False

    '                    Me.txtUsuario.Enabled = True
    '                    Me.txtUsuario.Text = ""
    '                    Me.txtNombreUsuario.Text = ""
    '                    Me.txtUsuario.Focus()


    '                    Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
    '                    Me.DataSetOrden_Compras1.ordencompra.Clear()

    '                    Me.ToolBar1.Buttons(2).Enabled = False

    '                    MsgBox("Los datos fueron eliminados satisfactoriamente", MsgBoxStyle.Information)
    '                Else
    '                    Me.ToolBar1.Buttons(2).Enabled = True
    '                    MsgBox("Error al eliminar la orden ", MsgBoxStyle.Exclamation)
    '                    Exit Sub
    '                End If
    '            Else
    '                BindingContext(Me.DataSetOrden_Compras1, "ordencompra").CancelCurrentEdit()
    '            End If
    '        Else
    '            MsgBox("No Existe Orden de compra que eliminar", MsgBoxStyle.Information)
    '        End If
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub TxtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtDias_Entrega_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDias_Entrega.EditValueChanged

    End Sub

    Private Sub TxtDias_Entrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDias_Entrega.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtCodigo_art_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo_art.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtPrecioUni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioUni.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtFletes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFletes.EditValueChanged

    End Sub

    Private Sub TxtFletes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFletes.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtOtros_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOtros.EditValueChanged

    End Sub

    Private Sub TxtOtros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOtros.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtCosto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCosto.EditValueChanged

    End Sub

    Private Sub TxtCosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCosto.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtPorcDesc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPorcDesc.EditValueChanged

    End Sub

    Private Sub TxtPorcDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPorcDesc.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub Tex_Porc_Imp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Tex_Porc_Imp.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCant.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtDias_Entrega_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDias_Entrega.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtEntrega.Focus()
        End If
    End Sub

    Private Sub TxtPrecioUni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrecioUni.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtCosto.Text = CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text) + CDbl(Me.TxtPrecioUni.Text)
            TxtFletes.Focus()
        End If
    End Sub

    Private Sub TxtOtros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOtros.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtCosto.Text = CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text) + CDbl(Me.TxtPrecioUni.Text)
            Me.TxtCosto.Focus()
        End If
    End Sub

    Private Sub TxtCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPorcDesc.Focus()
        End If
    End Sub

    Private Sub TxtPorcDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPorcDesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Tex_Porc_Imp.Focus()
        End If
    End Sub


    Private Sub Tex_Porc_Imp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tex_Porc_Imp.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtCant.Focus()
        End If
    End Sub

    Private Sub TxtFletes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFletes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtCosto.Text = CDbl(Me.TxtFletes.Text) + CDbl(Me.TxtOtros.Text) + CDbl(Me.TxtPrecioUni.Text)
            Me.TxtOtros.Focus()
        End If
    End Sub


    Private Sub TxtNombre_Proveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNombre_Proveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtDias.Focus()
        End If
    End Sub

    Private Sub TxtDias_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDias.EditValueChanged

    End Sub

    Private Sub TxtDias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDias.KeyPress
        If Not IsNumeric(sender.text & e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub TxtDias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDias.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtDias_Entrega.Focus()
        End If
    End Sub

    Private Sub TxtCodigo_art_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_art.EditValueChanged

    End Sub
    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : boton_nuevo()
            Case 2 : If PMU.Find Then Me.consultarorden() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Delete Then AnularOrden() Else MsgBox("No tiene permiso para anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 6 : If MessageBox.Show("¿Desea Cerrar el módulo " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub

    Private Sub TxtTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotal.EditValueChanged

    End Sub



    Private Sub GridControl1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.GotFocus

    End Sub

    Private Sub GridControl1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.TabIndexChanged

    End Sub

    Private Sub GridControl1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles GridControl1.DragOver

    End Sub

    Private Sub GridControl1_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.ContextMenuChanged
        MessageBox.Show("hola")
    End Sub

    Private Sub TxtNombre_Proveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNombre_Proveedor.EditValueChanged

    End Sub

    Private Sub TxtSubGravadoT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSubGravadoT.EditValueChanged

    End Sub
End Class
