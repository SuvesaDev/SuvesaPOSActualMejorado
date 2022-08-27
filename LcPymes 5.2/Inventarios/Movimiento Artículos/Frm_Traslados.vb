Imports System.data.SqlClient
Imports System.Windows.Forms
Public Class Frm_Traslados
    Inherits FrmPlantilla


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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Text_Destino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Text_Destinatario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Descri_Articulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCodigo_art As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioUni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents daordencompra As System.Windows.Forms.Label
    Friend WithEvents Txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_Tipo_Cambio As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Traslados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet_Traslados_Inv1 As DataSet_Traslados_Inv
    Friend WithEvents Adapter_Traslados_Detalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Adapter_Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCosto_Unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label_NumT As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Adapter_Usuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Txt_cedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Tex_Clave As System.Windows.Forms.TextBox
    Friend WithEvents Text_Transportista As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Check_Anulado As System.Windows.Forms.CheckBox
    Friend WithEvents Label_Anulado As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtboleta As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolBardevolver As System.Windows.Forms.ToolBarButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtnombre As System.Windows.Forms.Label
    Friend WithEvents txtnombre_user As System.Windows.Forms.Label
    Friend WithEvents ck_anulad As System.Windows.Forms.CheckBox
    Friend WithEvents ck_devuelto As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Traslados))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Text_Transportista = New DevExpress.XtraEditors.TextEdit
        Me.DataSet_Traslados_Inv1 = New LcPymes_5._2.DataSet_Traslados_Inv
        Me.Label4 = New System.Windows.Forms.Label
        Me.Text_Destinatario = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Text_Destino = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label_Tipo_Cambio = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txt_Descri_Articulo = New DevExpress.XtraEditors.TextEdit
        Me.TxtCodigo_art = New DevExpress.XtraEditors.TextEdit
        Me.TxtTotal = New DevExpress.XtraEditors.TextEdit
        Me.TxtCant = New DevExpress.XtraEditors.TextEdit
        Me.TxtPrecioUni = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label_Anulado = New System.Windows.Forms.Label
        Me.TxtMonto = New DevExpress.XtraEditors.TextEdit
        Me.daordencompra = New System.Windows.Forms.Label
        Me.Check_Anulado = New System.Windows.Forms.CheckBox
        Me.Label_NumT = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCosto_Unit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Adapter_Traslados = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Traslados_Detalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Moneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Tex_Clave = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Adapter_Usuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Txt_cedulaUsuario = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtboleta = New System.Windows.Forms.TextBox
        Me.ToolBardevolver = New System.Windows.Forms.ToolBarButton
        Me.txtnombre_user = New System.Windows.Forms.Label
        Me.ck_anulad = New System.Windows.Forms.CheckBox
        Me.ck_devuelto = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.Text_Transportista.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Traslados_Inv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text_Destinatario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text_Destino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioUni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBardevolver})
        Me.ToolBar1.Location = New System.Drawing.Point(0, 419)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(618, 52)
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(656, 446)
        Me.DataNavigator.Name = "DataNavigator"
        Me.DataNavigator.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(618, 32)
        Me.TituloModulo.Text = "Formulario Traslados de productos"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Text_Transportista)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Text_Destinatario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Text_Destino)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 128)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(8, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 11)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Transportista"
        '
        'Text_Transportista
        '
        Me.Text_Transportista.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Transportista"))
        Me.Text_Transportista.EditValue = ""
        Me.Text_Transportista.Location = New System.Drawing.Point(8, 104)
        Me.Text_Transportista.Name = "Text_Transportista"
        '
        'Text_Transportista.Properties
        '
        Me.Text_Transportista.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Text_Transportista.Size = New System.Drawing.Size(264, 19)
        Me.Text_Transportista.TabIndex = 4
        '
        'DataSet_Traslados_Inv1
        '
        Me.DataSet_Traslados_Inv1.DataSetName = "DataSet_Traslados_Inv"
        Me.DataSet_Traslados_Inv1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(8, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 11)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Destinatario"
        '
        'Text_Destinatario
        '
        Me.Text_Destinatario.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Destinatario"))
        Me.Text_Destinatario.EditValue = ""
        Me.Text_Destinatario.Location = New System.Drawing.Point(8, 67)
        Me.Text_Destinatario.Name = "Text_Destinatario"
        '
        'Text_Destinatario.Properties
        '
        Me.Text_Destinatario.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Text_Destinatario.Size = New System.Drawing.Size(264, 19)
        Me.Text_Destinatario.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 11)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Destino"
        '
        'Text_Destino
        '
        Me.Text_Destino.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Destino"))
        Me.Text_Destino.EditValue = ""
        Me.Text_Destino.Location = New System.Drawing.Point(8, 27)
        Me.Text_Destino.Name = "Text_Destino"
        '
        'Text_Destino.Properties
        '
        Me.Text_Destino.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Text_Destino.Size = New System.Drawing.Size(264, 19)
        Me.Text_Destino.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(520, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 64)
        Me.GroupBox2.TabIndex = 203
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'RadioButton2
        '
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Salida"))
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(8, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "Salida"
        '
        'RadioButton1
        '
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Entrada"))
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Entrada"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(408, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 14)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Tipo Cambio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label_Tipo_Cambio
        '
        Me.Label_Tipo_Cambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Traslados_Inv1, "Moneda.ValorCompra"))
        Me.Label_Tipo_Cambio.Location = New System.Drawing.Point(408, 96)
        Me.Label_Tipo_Cambio.Name = "Label_Tipo_Cambio"
        Me.Label_Tipo_Cambio.Size = New System.Drawing.Size(96, 14)
        Me.Label_Tipo_Cambio.TabIndex = 201
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.CodMoneda"))
        Me.ComboBox1.DataSource = Me.DataSet_Traslados_Inv1
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Blue
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(304, 96)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Moneda.CodMoneda"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(304, 80)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(92, 15)
        Me.Label30.TabIndex = 200
        Me.Label30.Text = "Moneda"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Fecha"))
        Me.Label3.Location = New System.Drawing.Point(304, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(304, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Traslado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Txt_Descri_Articulo)
        Me.GroupBox3.Controls.Add(Me.TxtCodigo_art)
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Controls.Add(Me.TxtCant)
        Me.GroupBox3.Controls.Add(Me.TxtPrecioUni)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label_Anulado)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 163)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(608, 97)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Articulo"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(168, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(224, 40)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "DEVUELTO"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label13.Visible = False
        '
        'Txt_Descri_Articulo
        '
        Me.Txt_Descri_Articulo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle.Descripcion"))
        Me.Txt_Descri_Articulo.EditValue = ""
        Me.Txt_Descri_Articulo.Location = New System.Drawing.Point(110, 32)
        Me.Txt_Descri_Articulo.Name = "Txt_Descri_Articulo"
        '
        'Txt_Descri_Articulo.Properties
        '
        Me.Txt_Descri_Articulo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Descri_Articulo.Properties.ReadOnly = True
        Me.Txt_Descri_Articulo.Size = New System.Drawing.Size(464, 19)
        Me.Txt_Descri_Articulo.TabIndex = 1
        '
        'TxtCodigo_art
        '
        Me.TxtCodigo_art.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle.Codigo"))
        Me.TxtCodigo_art.EditValue = ""
        Me.TxtCodigo_art.Location = New System.Drawing.Point(8, 32)
        Me.TxtCodigo_art.Name = "TxtCodigo_art"
        Me.TxtCodigo_art.Size = New System.Drawing.Size(80, 19)
        Me.TxtCodigo_art.TabIndex = 5
        '
        'TxtTotal
        '
        Me.TxtTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle.Total"))
        Me.TxtTotal.EditValue = ""
        Me.TxtTotal.Location = New System.Drawing.Point(192, 72)
        Me.TxtTotal.Name = "TxtTotal"
        '
        'TxtTotal.Properties
        '
        Me.TxtTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtTotal.Properties.ReadOnly = True
        Me.TxtTotal.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtTotal.Size = New System.Drawing.Size(104, 19)
        Me.TxtTotal.TabIndex = 3
        '
        'TxtCant
        '
        Me.TxtCant.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle.Cantidad"))
        Me.TxtCant.EditValue = ""
        Me.TxtCant.Location = New System.Drawing.Point(112, 72)
        Me.TxtCant.Name = "TxtCant"
        '
        'TxtCant.Properties
        '
        Me.TxtCant.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtCant.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.White, System.Drawing.SystemColors.Highlight)
        Me.TxtCant.Size = New System.Drawing.Size(64, 19)
        Me.TxtCant.TabIndex = 6
        '
        'TxtPrecioUni
        '
        Me.TxtPrecioUni.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle.Costo_Unit"))
        Me.TxtPrecioUni.EditValue = ""
        Me.TxtPrecioUni.Location = New System.Drawing.Point(8, 70)
        Me.TxtPrecioUni.Name = "TxtPrecioUni"
        '
        'TxtPrecioUni.Properties
        '
        Me.TxtPrecioUni.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUni.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioUni.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TxtPrecioUni.Size = New System.Drawing.Size(88, 19)
        Me.TxtPrecioUni.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(110, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(464, 14)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(192, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 14)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Total"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(8, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 14)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Precio Unit"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Código"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(112, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 14)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Cantidad:"
        '
        'Label_Anulado
        '
        Me.Label_Anulado.BackColor = System.Drawing.Color.White
        Me.Label_Anulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Anulado.ForeColor = System.Drawing.Color.Red
        Me.Label_Anulado.Location = New System.Drawing.Point(384, 56)
        Me.Label_Anulado.Name = "Label_Anulado"
        Me.Label_Anulado.Size = New System.Drawing.Size(192, 40)
        Me.Label_Anulado.TabIndex = 204
        Me.Label_Anulado.Text = "ANULADO"
        Me.Label_Anulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Anulado.Visible = False
        '
        'TxtMonto
        '
        Me.TxtMonto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Total"))
        Me.TxtMonto.EditValue = ""
        Me.TxtMonto.Location = New System.Drawing.Point(640, 192)
        Me.TxtMonto.Name = "TxtMonto"
        '
        'TxtMonto.Properties
        '
        Me.TxtMonto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TxtMonto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtMonto.Properties.ReadOnly = True
        Me.TxtMonto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.LightSteelBlue, System.Drawing.Color.RoyalBlue)
        Me.TxtMonto.Size = New System.Drawing.Size(96, 19)
        Me.TxtMonto.TabIndex = 186
        '
        'daordencompra
        '
        Me.daordencompra.BackColor = System.Drawing.SystemColors.ControlLight
        Me.daordencompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daordencompra.ForeColor = System.Drawing.Color.RoyalBlue
        Me.daordencompra.Location = New System.Drawing.Point(640, 176)
        Me.daordencompra.Name = "daordencompra"
        Me.daordencompra.Size = New System.Drawing.Size(96, 17)
        Me.daordencompra.TabIndex = 185
        Me.daordencompra.Text = "Total"
        '
        'Check_Anulado
        '
        Me.Check_Anulado.Location = New System.Drawing.Point(208, 112)
        Me.Check_Anulado.Name = "Check_Anulado"
        Me.Check_Anulado.Size = New System.Drawing.Size(80, 16)
        Me.Check_Anulado.TabIndex = 187
        Me.Check_Anulado.Text = "Anulado"
        '
        'Label_NumT
        '
        Me.Label_NumT.BackColor = System.Drawing.Color.White
        Me.Label_NumT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Num_Traslado"))
        Me.Label_NumT.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label_NumT.Location = New System.Drawing.Point(24, 16)
        Me.Label_NumT.Name = "Label_NumT"
        Me.Label_NumT.Size = New System.Drawing.Size(64, 14)
        Me.Label_NumT.TabIndex = 187
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle"
        Me.GridControl1.DataSource = Me.DataSet_Traslados_Inv1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Enabled = False
        Me.GridControl1.Location = New System.Drawing.Point(8, 264)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(608, 112)
        Me.GridControl1.Styles.AddReplace("Preview", New DevExpress.Utils.ViewStyleEx("Preview", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, True, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Top, Nothing, System.Drawing.Color.FromArgb(CType(217, Byte), CType(245, Byte), CType(255, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FooterPanel", New DevExpress.Utils.ViewStyleEx("FooterPanel", "Grid", New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupButton", New DevExpress.Utils.ViewStyleEx("GroupButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterCloseButton", New DevExpress.Utils.ViewStyleEx("FilterCloseButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(125, Byte), CType(125, Byte), CType(125, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("EvenRow", New DevExpress.Utils.ViewStyleEx("EvenRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.GhostWhite, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("HideSelectionRow", New DevExpress.Utils.ViewStyleEx("HideSelectionRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FixedLine", New DevExpress.Utils.ViewStyleEx("FixedLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(15, Byte), CType(58, Byte), CType(81, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyleEx("HeaderPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupPanel", New DevExpress.Utils.ViewStyleEx("GroupPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaption, System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Empty", New DevExpress.Utils.ViewStyleEx("Empty", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupFooter", New DevExpress.Utils.ViewStyleEx("GroupFooter", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(167, Byte), CType(195, Byte), CType(210, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupRow", New DevExpress.Utils.ViewStyleEx("GroupRow", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Silver, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HorzLine", New DevExpress.Utils.ViewStyleEx("HorzLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButton", New DevExpress.Utils.ViewStyleEx("ColumnFilterButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedRow", New DevExpress.Utils.ViewStyleEx("FocusedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(135, Byte), CType(178, Byte), CType(201, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("VertLine", New DevExpress.Utils.ViewStyleEx("VertLine", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedCell", New DevExpress.Utils.ViewStyleEx("FocusedCell", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("OddRow", New DevExpress.Utils.ViewStyleEx("OddRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(206, Byte), CType(220, Byte), CType(227, Byte)), System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal))
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(95, Byte), CType(138, Byte), CType(161, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Row", New DevExpress.Utils.ViewStyleEx("Row", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterPanel", New DevExpress.Utils.ViewStyleEx("FilterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(35, Byte), CType(35, Byte), CType(35, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("RowSeparator", New DevExpress.Utils.ViewStyleEx("RowSeparator", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.LightGray, System.Drawing.Color.Blue, System.Drawing.Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("DetailTip", New DevExpress.Utils.ViewStyleEx("DetailTip", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCantidad, Me.colCosto_Unit, Me.colTotal})
        Me.GridView1.GroupPanelText = "Detalle de Cotización"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubtotalGravado", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 74
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 188
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 101
        '
        'colCosto_Unit
        '
        Me.colCosto_Unit.Caption = "Costo Unit."
        Me.colCosto_Unit.DisplayFormat.FormatString = "#,#0.00"
        Me.colCosto_Unit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCosto_Unit.FieldName = "Costo_Unit"
        Me.colCosto_Unit.Name = "colCosto_Unit"
        Me.colCosto_Unit.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCosto_Unit.VisibleIndex = 3
        Me.colCosto_Unit.Width = 101
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "#,#0.00"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colTotal.VisibleIndex = 4
        Me.colTotal.Width = 106
        '
        'Txtobservaciones
        '
        Me.Txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtobservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtobservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Observaciones"))
        Me.Txtobservaciones.Enabled = False
        Me.Txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtobservaciones.ForeColor = System.Drawing.Color.Blue
        Me.Txtobservaciones.Location = New System.Drawing.Point(8, 392)
        Me.Txtobservaciones.Multiline = True
        Me.Txtobservaciones.Name = "Txtobservaciones"
        Me.Txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtobservaciones.Size = New System.Drawing.Size(608, 16)
        Me.Txtobservaciones.TabIndex = 3
        Me.Txtobservaciones.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.Location = New System.Drawing.Point(8, 378)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(608, 14)
        Me.Label20.TabIndex = 188
        Me.Label20.Text = "Observaciones"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-8M1A70L"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""DESKTOP-8M1A70L"";persist security info=False;initial catalog=seepos"
        '
        'Adapter_Traslados
        '
        Me.Adapter_Traslados.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adapter_Traslados.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Traslados.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Traslados.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Traslado_Inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Num_Traslado", "Num_Traslado"), New System.Data.Common.DataColumnMapping("Destino", "Destino"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Transportista", "Transportista"), New System.Data.Common.DataColumnMapping("Cedula_Usuario", "Cedula_Usuario"), New System.Data.Common.DataColumnMapping("Destinatario", "Destinatario"), New System.Data.Common.DataColumnMapping("Entrada", "Entrada"), New System.Data.Common.DataColumnMapping("Salida", "Salida"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("numero_boleta", "numero_boleta"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("devuelto", "devuelto")})})
        Me.Adapter_Traslados.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Traslado_Inventario WHERE (Num_Traslado = @Original_Num_Traslado)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Traslado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Traslado", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Traslado_Inventario(Destino, Fecha, Transportista, Cedula_Usuario, De" & _
        "stinatario, Entrada, Salida, Total, Observaciones, CodMoneda, numero_boleta, Anu" & _
        "lado, devuelto) VALUES (@Destino, @Fecha, @Transportista, @Cedula_Usuario, @Dest" & _
        "inatario, @Entrada, @Salida, @Total, @Observaciones, @CodMoneda, @numero_boleta," & _
        " @Anulado, @devuelto); SELECT Num_Traslado, Destino, Fecha, Transportista, Cedul" & _
        "a_Usuario, Destinatario, Entrada, Salida, Total, Observaciones, CodMoneda, numer" & _
        "o_boleta, Anulado, devuelto FROM Traslado_Inventario WHERE (Num_Traslado = @@IDE" & _
        "NTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Destino", System.Data.SqlDbType.VarChar, 50, "Destino"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Transportista", System.Data.SqlDbType.VarChar, 50, "Transportista"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 10, "Cedula_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Destinatario", System.Data.SqlDbType.VarChar, 50, "Destinatario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 1, "Entrada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@numero_boleta", System.Data.SqlDbType.NVarChar, 50, "numero_boleta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@devuelto", System.Data.SqlDbType.Bit, 1, "devuelto"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Num_Traslado, Destino, Fecha, Transportista, Cedula_Usuario, Destinatario," & _
        " Entrada, Salida, Total, Observaciones, CodMoneda, numero_boleta, Anulado, devue" & _
        "lto FROM Traslado_Inventario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Traslado_Inventario SET Destino = @Destino, Fecha = @Fecha, Transportista " & _
        "= @Transportista, Cedula_Usuario = @Cedula_Usuario, Destinatario = @Destinatario" & _
        ", Entrada = @Entrada, Salida = @Salida, Total = @Total, Observaciones = @Observa" & _
        "ciones, CodMoneda = @CodMoneda, numero_boleta = @numero_boleta, Anulado = @Anula" & _
        "do, devuelto = @devuelto WHERE (Num_Traslado = @Original_Num_Traslado); SELECT N" & _
        "um_Traslado, Destino, Fecha, Transportista, Cedula_Usuario, Destinatario, Entrad" & _
        "a, Salida, Total, Observaciones, CodMoneda, numero_boleta, Anulado, devuelto FRO" & _
        "M Traslado_Inventario WHERE (Num_Traslado = @Num_Traslado)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Destino", System.Data.SqlDbType.VarChar, 50, "Destino"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Transportista", System.Data.SqlDbType.VarChar, 50, "Transportista"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula_Usuario", System.Data.SqlDbType.VarChar, 10, "Cedula_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Destinatario", System.Data.SqlDbType.VarChar, 50, "Destinatario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Entrada", System.Data.SqlDbType.Bit, 1, "Entrada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Salida", System.Data.SqlDbType.Bit, 1, "Salida"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 50, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@numero_boleta", System.Data.SqlDbType.NVarChar, 50, "numero_boleta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@devuelto", System.Data.SqlDbType.Bit, 1, "devuelto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Traslado", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Traslado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Traslado", System.Data.SqlDbType.BigInt, 8, "Num_Traslado"))
        '
        'Adapter_Traslados_Detalle
        '
        Me.Adapter_Traslados_Detalle.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adapter_Traslados_Detalle.InsertCommand = Me.SqlInsertCommand2
        Me.Adapter_Traslados_Detalle.SelectCommand = Me.SqlSelectCommand2
        Me.Adapter_Traslados_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Traslado_Inv_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Detalle", "Id_Detalle"), New System.Data.Common.DataColumnMapping("Num_Traslado", "Num_Traslado"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Cantidad", "Cantidad"), New System.Data.Common.DataColumnMapping("Costo_unit", "Costo_unit"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("devueltos", "devueltos")})})
        Me.Adapter_Traslados_Detalle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Traslado_Inv_Detalle WHERE (Id_Detalle = @Original_Id_Detalle)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Traslado_Inv_Detalle(Num_Traslado, Codigo, Descripcion, Cantidad, Cos" & _
        "to_unit, Total, devueltos) VALUES (@Num_Traslado, @Codigo, @Descripcion, @Cantid" & _
        "ad, @Costo_unit, @Total, @devueltos); SELECT Id_Detalle, Num_Traslado, Codigo, D" & _
        "escripcion, Cantidad, Costo_unit, Total, devueltos FROM Traslado_Inv_Detalle WHE" & _
        "RE (Id_Detalle = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Traslado", System.Data.SqlDbType.BigInt, 8, "Num_Traslado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo_unit", System.Data.SqlDbType.Float, 8, "Costo_unit"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@devueltos", System.Data.SqlDbType.VarChar, 50, "devueltos"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_Detalle, Num_Traslado, Codigo, Descripcion, Cantidad, Costo_unit, Total" & _
        ", devueltos FROM Traslado_Inv_Detalle"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Traslado_Inv_Detalle SET Num_Traslado = @Num_Traslado, Codigo = @Codigo, D" & _
        "escripcion = @Descripcion, Cantidad = @Cantidad, Costo_unit = @Costo_unit, Total" & _
        " = @Total, devueltos = @devueltos WHERE (Id_Detalle = @Original_Id_Detalle); SEL" & _
        "ECT Id_Detalle, Num_Traslado, Codigo, Descripcion, Cantidad, Costo_unit, Total, " & _
        "devueltos FROM Traslado_Inv_Detalle WHERE (Id_Detalle = @Id_Detalle)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Traslado", System.Data.SqlDbType.BigInt, 8, "Num_Traslado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cantidad", System.Data.SqlDbType.Float, 8, "Cantidad"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo_unit", System.Data.SqlDbType.Float, 8, "Costo_unit"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@devueltos", System.Data.SqlDbType.VarChar, 50, "devueltos"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Detalle", System.Data.SqlDbType.BigInt, 8, "Id_Detalle"))
        '
        'Adapter_Moneda
        '
        Me.Adapter_Moneda.SelectCommand = Me.SqlSelectCommand3
        Me.Adapter_Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(216, 424)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 190
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(312, 448)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(56, 13)
        Me.txtUsuario.TabIndex = 189
        Me.txtUsuario.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(5, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 14)
        Me.Label7.TabIndex = 187
        Me.Label7.Text = "Nº"
        '
        'Tex_Clave
        '
        Me.Tex_Clave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tex_Clave.ForeColor = System.Drawing.Color.Blue
        Me.Tex_Clave.Location = New System.Drawing.Point(520, 432)
        Me.Tex_Clave.Name = "Tex_Clave"
        Me.Tex_Clave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.Tex_Clave.Size = New System.Drawing.Size(88, 13)
        Me.Tex_Clave.TabIndex = 0
        Me.Tex_Clave.Text = ""
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(448, 432)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 13)
        Me.Label48.TabIndex = 194
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Adapter_Usuarios
        '
        Me.Adapter_Usuarios.InsertCommand = Me.SqlInsertCommand3
        Me.Adapter_Usuarios.SelectCommand = Me.SqlSelectCommand4
        Me.Adapter_Usuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("CambiarPrecio", "CambiarPrecio"), New System.Data.Common.DataColumnMapping("Aplicar_Desc", "Aplicar_Desc"), New System.Data.Common.DataColumnMapping("Exist_Negativa", "Exist_Negativa"), New System.Data.Common.DataColumnMapping("Porc_Desc", "Porc_Desc"), New System.Data.Common.DataColumnMapping("Porc_Precio", "Porc_Precio")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Usuarios(Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio," & _
        " Aplicar_Desc, Exist_Negativa, Porc_Desc, Porc_Precio) VALUES (@Cedula, @Nombre," & _
        " @Clave_Entrada, @Clave_Interna, @CambiarPrecio, @Aplicar_Desc, @Exist_Negativa," & _
        " @Porc_Desc, @Porc_Precio); SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna," & _
        " CambiarPrecio, Aplicar_Desc, Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuari" & _
        "os"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 50, "Cedula"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Entrada", System.Data.SqlDbType.VarChar, 30, "Clave_Entrada"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CambiarPrecio", System.Data.SqlDbType.Bit, 1, "CambiarPrecio"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Aplicar_Desc", System.Data.SqlDbType.Bit, 1, "Aplicar_Desc"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Exist_Negativa", System.Data.SqlDbType.Bit, 1, "Exist_Negativa"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Desc", System.Data.SqlDbType.Float, 8, "Porc_Desc"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Porc_Precio", System.Data.SqlDbType.Float, 8, "Porc_Precio"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna, CambiarPrecio, Aplicar_Desc," & _
        " Exist_Negativa, Porc_Desc, Porc_Precio FROM Usuarios"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'Txt_cedulaUsuario
        '
        Me.Txt_cedulaUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Cedula_Usuario"))
        Me.Txt_cedulaUsuario.Location = New System.Drawing.Point(344, 448)
        Me.Txt_cedulaUsuario.Name = "Txt_cedulaUsuario"
        Me.Txt_cedulaUsuario.Size = New System.Drawing.Size(80, 20)
        Me.Txt_cedulaUsuario.TabIndex = 187
        Me.Txt_cedulaUsuario.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(304, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 14)
        Me.Label11.TabIndex = 205
        Me.Label11.Text = "N° de Boleta"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtboleta
        '
        Me.txtboleta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.numero_boleta"))
        Me.txtboleta.Enabled = False
        Me.txtboleta.Location = New System.Drawing.Point(304, 136)
        Me.txtboleta.Name = "txtboleta"
        Me.txtboleta.Size = New System.Drawing.Size(96, 20)
        Me.txtboleta.TabIndex = 206
        Me.txtboleta.Text = ""
        '
        'ToolBardevolver
        '
        Me.ToolBardevolver.Enabled = False
        Me.ToolBardevolver.ImageIndex = 9
        Me.ToolBardevolver.Text = "Devolver"
        '
        'txtnombre_user
        '
        Me.txtnombre_user.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.txtnombre_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre_user.ForeColor = System.Drawing.Color.Gray
        Me.txtnombre_user.Location = New System.Drawing.Point(448, 448)
        Me.txtnombre_user.Name = "txtnombre_user"
        Me.txtnombre_user.Size = New System.Drawing.Size(160, 13)
        Me.txtnombre_user.TabIndex = 194
        Me.txtnombre_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ck_anulad
        '
        Me.ck_anulad.Enabled = False
        Me.ck_anulad.Location = New System.Drawing.Point(544, 136)
        Me.ck_anulad.Name = "ck_anulad"
        Me.ck_anulad.Size = New System.Drawing.Size(72, 24)
        Me.ck_anulad.TabIndex = 208
        Me.ck_anulad.Text = "Anulado"
        '
        'ck_devuelto
        '
        Me.ck_devuelto.Enabled = False
        Me.ck_devuelto.Location = New System.Drawing.Point(472, 136)
        Me.ck_devuelto.Name = "ck_devuelto"
        Me.ck_devuelto.Size = New System.Drawing.Size(72, 24)
        Me.ck_devuelto.TabIndex = 208
        Me.ck_devuelto.Text = "Devuelo"
        '
        'Frm_Traslados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(618, 471)
        Me.Controls.Add(Me.ck_anulad)
        Me.Controls.Add(Me.txtnombre_user)
        Me.Controls.Add(Me.txtboleta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label_Tipo_Cambio)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Tex_Clave)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label_NumT)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Txtobservaciones)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Txt_cedulaUsuario)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.daordencompra)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Check_Anulado)
        Me.Controls.Add(Me.ck_devuelto)
        Me.MaximumSize = New System.Drawing.Size(624, 500)
        Me.MinimumSize = New System.Drawing.Size(624, 500)
        Me.Name = "Frm_Traslados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslados de productos"
        Me.Controls.SetChildIndex(Me.ck_devuelto, 0)
        Me.Controls.SetChildIndex(Me.Check_Anulado, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.daordencompra, 0)
        Me.Controls.SetChildIndex(Me.TxtMonto, 0)
        Me.Controls.SetChildIndex(Me.Txt_cedulaUsuario, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.Controls.SetChildIndex(Me.Label20, 0)
        Me.Controls.SetChildIndex(Me.Txtobservaciones, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.Label_NumT, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label48, 0)
        Me.Controls.SetChildIndex(Me.Tex_Clave, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Label30, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.Label_Tipo_Cambio, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.txtboleta, 0)
        Me.Controls.SetChildIndex(Me.txtnombre_user, 0)
        Me.Controls.SetChildIndex(Me.ck_anulad, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Text_Transportista.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Traslados_Inv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text_Destinatario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text_Destino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Txt_Descri_Articulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCodigo_art.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioUni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private sqlConexion As SqlConnection
    Dim CConexion As New Conexion
    Dim PrecioBase As Double
    Dim ValorCosto As Double
    Dim PMU As New PerfilModulo_Class
    Dim usua As Usuario_Logeado


    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()
            Case 1 : Me.Consultar_Traslado()
            Case 2 : Registrar()
            Case 3 : Anular()
            Case 4 : Me.imprimir()
            Case 7 : devolver()
        End Select
    End Sub
    Private Sub devolver()
        Try

            Dim resp As Integer

            If Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").Count > 0 Then


                resp = MessageBox.Show("¿Desea Marcar este Traslado de Inventario como devuelto?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Me.ck_devuelto.Checked = True
                    Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").EndCurrentEdit()

                    If Me.registrar_orden() Then
                        Me.DataSet_Traslados_Inv1.AcceptChanges()
                        MsgBox("El traslado se a registrado como devuelto", MsgBoxStyle.Information)

                        Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Clear()
                        Me.DataSet_Traslados_Inv1.Traslado_Inventario.Clear()


                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                        Me.GroupBox1.Enabled = False
                        Me.GroupBox2.Enabled = False
                        Me.GroupBox3.Enabled = False
                        Me.ComboBox1.Enabled = False


                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtnombre_user.Text = ""
                        Me.txtUsuario.Focus()


                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                    End If

                Else : Exit Sub

                End If

            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Nuevo()
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
            Me.Tex_Clave.Focus()
        Else
            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            'Me.Tex_Clave.Text = ""
            'Me.txtnombre_user.Text = 0
            'Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Clear()
            'Me.DataSet_Traslados_Inv1.Traslado_Inventario.Clear()
            Me.GroupBox1.Enabled = False
            Me.GroupBox2.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.ComboBox1.Enabled = False
            Me.Tex_Clave.Focus()
            Label13.Visible = False
            Label_Anulado.Visible = False
        End If

    End Sub
    Private Sub imprimir()
        Try

            Me.ToolBar1.Buttons(4).Enabled = False
            Dim OrdenC_Reporte As New Reporte_Traslado_Inventario
            Dim visor As New frmVisorReportes
            OrdenC_Reporte.SetParameterValue(0, CDbl(Me.Label_NumT.Text))
            CrystalReportsConexion.LoadReportViewer(visor.rptViewer, OrdenC_Reporte)
            visor.rptViewer.Visible = True
            OrdenC_Reporte = Nothing
            visor.ShowDialog()
            Me.ToolBar1.Buttons(4).Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Anular()
        Try

            Dim resp As Integer

            If Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").Count > 0 Then


                resp = MessageBox.Show("¿Desea Anular este Traslado de Inventario?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    Me.ck_anulad.Checked = True
                    Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").EndCurrentEdit()

                    If Me.registrar_orden() Then
                        Me.DataSet_Traslados_Inv1.AcceptChanges()
                        MsgBox("El traslado ha sido anulado correctamente", MsgBoxStyle.Information)

                        Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Clear()
                        Me.DataSet_Traslados_Inv1.Traslado_Inventario.Clear()


                        Me.ToolBar1.Buttons(4).Enabled = True
                        Me.ToolBar1.Buttons(1).Enabled = True

                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(2).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                        Me.GroupBox1.Enabled = False
                        Me.GroupBox2.Enabled = False
                        Me.GroupBox3.Enabled = False
                        Me.ComboBox1.Enabled = False


                        Me.txtUsuario.Enabled = True
                        Me.txtUsuario.Text = ""
                        Me.txtnombre_user.Text = ""
                        Me.txtUsuario.Focus()


                        Me.ToolBar1.Buttons(3).Enabled = False
                        Me.ToolBar1.Buttons(4).Enabled = False

                    End If

                Else : Exit Sub

                End If

            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Consultar_Traslado()
        Try

            'If Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").Count > 0 Then
            '    If (MsgBox("Actualmente se está realizando una Orden de Compra, si continúa se perderan los datos de la orden actual, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
            '        Exit Sub
            '    End If
            'End If

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Me.ToolBar1.Buttons(0).Enabled = True

            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Clear()
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.Clear()

            Me.GroupBox1.Enabled = False
            Me.GroupBox2.Enabled = False
            Me.GroupBox3.Enabled = False
            Me.ComboBox1.Enabled = False

            Dim identificador As Double

            Dim Fx As New cFunciones

            identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("SELECT Num_Traslado, Destino, Fecha FROM Traslado_Inventario Order by Fecha DESC", "Destino", "Fecha", "Buscar Traslado de Inventario"))

            If identificador = 0.0 Then ' si se dio en el boton de cancelar

                Exit Sub
            End If

            Fx.Llenar_Tabla_Generico("SELECT * FROM Traslado_Inventario WHERE Num_Traslado = " & identificador, Me.DataSet_Traslados_Inv1.Traslado_Inventario)
            Fx.Llenar_Tabla_Generico("SELECT * FROM Traslado_Inv_Detalle WHERE Num_Traslado = " & identificador, Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle)

            Me.ToolBar1.Buttons(2).Enabled = True
            ToolBardevolver.Enabled = True
            If Me.Check_Anulado.Checked = False Then Me.ToolBar1.Buttons(3).Enabled = True
            Me.ToolBar1.Buttons(4).Enabled = True

            If Me.ck_anulad.Checked = True Then
                Label_Anulado.Visible = True
            Else
                Label_Anulado.Visible = False
            End If

            If Me.ck_devuelto.Checked = True Then
                Label13.Visible = True
            Else
                Label13.Visible = False
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Registrar()
        Try


            Me.ToolBar1.Buttons(2).Enabled = False

            If Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").Count = 0 Then 'Si la factura no tiene detalle
                MsgBox("No se Puede Registrar un Traslado si no contiene artículos", MsgBoxStyle.Critical)
                Me.ToolBar1.Buttons(2).Enabled = False
                Exit Sub
            End If

            If MessageBox.Show("¿Desea Registrar este Traslado?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then 'si no desea guardar la facturacion
                Me.ToolBar1.Buttons(2).Enabled = True
                Exit Sub
            End If
            Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").EndCurrentEdit()

            If Me.registrar_orden Then   'se registra en la base de datos then

                Me.DataSet_Traslados_Inv1.AcceptChanges()


                Me.ToolBar1.Buttons(4).Enabled = True
                Me.ToolBar1.Buttons(1).Enabled = True

                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBar1.Buttons(3).Enabled = False
                Me.ToolBar1.Buttons(2).Enabled = False
                Me.ToolBar1.Buttons(4).Enabled = False


                Me.Tex_Clave.Enabled = True
                Me.Tex_Clave.Text = ""
                Me.txtnombre_user.Text = ""
                Me.Tex_Clave.Focus()


                MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)

                If MsgBox("Desea imprimir la boleta del Traslado de Inventario", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    imprimir()
                End If

                Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Clear()
                Me.DataSet_Traslados_Inv1.Traslado_Inventario.Clear()


                Me.ToolBar1.Buttons(2).Enabled = True
                Me.ToolBar1.Buttons(5).Enabled = False

                Me.GroupBox1.Enabled = False
                Me.GroupBox2.Enabled = False
                Me.GroupBox3.Enabled = False
                Me.Txtobservaciones.Enabled = False

            Else
                MsgBox("Error al Registrar", MsgBoxStyle.Critical)

                Me.ToolBar1.Buttons(2).Enabled = True

            End If

        Catch ex As System.Exception
            Me.ToolBar1.Buttons(2).Enabled = True
            MsgBox(ex.Message)
        End Try

    End Sub
    Function registrar_orden() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction

        Try

            Me.Adapter_Traslados.InsertCommand.Transaction = Trans
            Me.Adapter_Traslados.UpdateCommand.Transaction = Trans
            Me.Adapter_Traslados.SelectCommand.Transaction = Trans
            Me.Adapter_Traslados.DeleteCommand.Transaction = Trans


            Me.Adapter_Traslados_Detalle.InsertCommand.Transaction = Trans
            Me.Adapter_Traslados_Detalle.UpdateCommand.Transaction = Trans
            Me.Adapter_Traslados_Detalle.SelectCommand.Transaction = Trans
            Me.Adapter_Traslados_Detalle.DeleteCommand.Transaction = Trans


            Me.Adapter_Traslados.Update(Me.DataSet_Traslados_Inv1, "Traslado_Inventario")
            Me.Adapter_Traslados_Detalle.Update(Me.DataSet_Traslados_Inv1, "Traslado_Inv_Detalle")
            Trans.Commit()
            Return True


        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.ToString)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try

    End Function
    Private Sub Frm_Traslados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            Me.Adapter_Moneda.Fill(Me.DataSet_Traslados_Inv1, "Moneda")
            Me.Adapter_Usuarios.Fill(Me.DataSet_Traslados_Inv1, "Usuarios")

            ' Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Clear()


            Me.DataSet_Traslados_Inv1.Traslado_Inventario.Num_TrasladoColumn.AutoIncrement = True
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.Num_TrasladoColumn.AutoIncrementSeed = -1
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.Num_TrasladoColumn.AutoIncrementStep = -1

            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Id_DetalleColumn.AutoIncrement = True
            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Id_DetalleColumn.AutoIncrementSeed = -1
            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Id_DetalleColumn.AutoIncrementStep = -1
            defaul_value()
            Me.ck_anulad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.anulado"))
            Me.ck_devuelto.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet_Traslados_Inv1, "Traslado_Inventario.devuelto"))
            Me.Tex_Clave.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tex_Clave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Loggin_Usuario()
        End If
    End Sub
    Public Sub Loggin_Usuario()
        Try
            If BindingContext(Me.DataSet_Traslados_Inv1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSet_Traslados_Inv1.Usuarios.Select("Clave_Interna ='" & Tex_Clave.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    PMU = VSM(Usua("Cedula"), Name) 'Carga los privilegios del usuario con el modulo 
                    If Not PMU.Execute Then
                        MsgBox("Usted no tiene permisos para realizar prestamos..", MsgBoxStyle.Exclamation)
                        txtUsuario.Text = ""
                        txtUsuario.Focus()
                        Exit Sub
                    End If
                    'Dim tipo As String = Usua("Perfil")
                    'If tipo <> "INVENTARIO" And tipo <> "ADMINISTRADOR" And tipo <> "ADMINISTRATIVO" Then
                    '    MsgBox("Usted no tiene permisos para realizar Traslados de Mercadería", MsgBoxStyle.Exclamation)
                    '    Me.txtUsuario.Text = ""
                    '    Me.txtUsuario.Focus()
                    '    Exit Sub
                    'End If
                    ' Me.logeado = True
                    txtUsuario.Enabled = False ' se inabilita el campo de la contraseña
                    Me.txtboleta.Enabled = True
                    Me.ToolBar1.Buttons(0).Text = "Cancelar"
                    Me.ToolBar1.Buttons(0).ImageIndex = 8
                    Me.ToolBar1.Buttons(3).Enabled = False

                    Me.ToolBar1.Buttons(0).Enabled = True
                    Me.ToolBar1.Buttons(1).Enabled = True
                    Me.ToolBar1.Buttons(5).Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = False

                    Me.ComboBox1.Enabled = True

                    Me.Nuevo_Traslado()
                    Me.Txt_cedulaUsuario.Text = Usua("Cedula")
                    txtnombre_user.Text = Usua("Nombre")
                    Me.ComboBox1.Focus()
                    'inicializar()

                Else ' si no existe una contraseñla como esta
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                    Tex_Clave.Text = ""
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")

            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub defaul_value()
        Try
            'padre
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.ObservacionesColumn.DefaultValue = "-"
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.DestinoColumn.DefaultValue = "-"
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.FechaColumn.DefaultValue = Now
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.DestinatarioColumn.DefaultValue = "-"
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.EntradaColumn.DefaultValue = False
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.SalidaColumn.DefaultValue = True
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.TotalColumn.DefaultValue = 0
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.AnuladoColumn.DefaultValue = False
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.devueltoColumn.DefaultValue = False
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.numero_boletaColumn.DefaultValue = 0
            Me.DataSet_Traslados_Inv1.Traslado_Inventario.TransportistaColumn.DefaultValue = ""

            'Hijo
            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.CantidadColumn.DefaultValue = 1
            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.TotalColumn.DefaultValue = 0
            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.Costo_unitColumn.DefaultValue = 0
            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.devueltosColumn.DefaultValue = 0
            Me.DataSet_Traslados_Inv1.Traslado_Inv_Detalle.DescripcionColumn.DefaultValue = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Nuevo_Traslado()
        Try

            Me.defaul_value()
            Label13.Visible = False
            Label_Anulado.Visible = False
            Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").EndCurrentEdit()
            Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").AddNew()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Me.ComboBox1.SelectedIndex = -1 Then
                MsgBox("Debe Selecionar una moneda", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Me.ComboBox1.Enabled = False
            GroupBox1.Enabled = True
            Me.GroupBox2.Enabled = True
            Me.txtboleta.Focus()
        End If
    End Sub
    Private Sub Text_Transportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Text_Transportista.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").EndCurrentEdit()
                Me.GroupBox3.Enabled = True
                Me.TxtCodigo_art.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub TxtCodigo_art_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo_art.KeyDown

        If e.KeyCode = Keys.F1 Then
            Dim BuscarArt As New FrmBuscarArticulo2
            Try
                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").EndCurrentEdit()
                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").AddNew()

                BuscarArt.StartPosition = FormStartPosition.CenterParent
                BuscarArt.ShowDialog()

                If BuscarArt.Cancelado Then
                    Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").CancelCurrentEdit()
                    Exit Sub
                End If

                TxtCodigo_art.Text = BuscarArt.Codigo
                BuscarArt.Dispose()


                CargarInformacionArticulo(TxtCodigo_art.Text)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        If e.KeyCode = Keys.Enter Then
            Try
                If Me.TxtCodigo_art.Text = "" Then Exit Sub
                Dim cod_art As String
                cod_art = Me.TxtCodigo_art.Text

                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").CancelCurrentEdit()
                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").EndCurrentEdit()
                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").AddNew()

                CargarInformacionArticulo(cod_art)

            Catch ex As SystemException
                MsgBox(ex.Message)
            End Try

        End If

    End Sub
    Private Sub CargarInformacionArticulo(ByVal codigo As String)
        Dim rs As SqlDataReader
        Dim Encontrado As Boolean
        Dim MonedaCosto As Integer
        Dim Consignacion As Boolean


        If codigo <> Nothing Then
            sqlConexion = CConexion.Conectar
            rs = CConexion.GetRecorset(sqlConexion, "SELECT  Codigo, Barras,Consignacion, dbo.Inventario.Descripcion + ' (' + Presentaciones.Presentaciones + ') ' AS Descripcion , PrecioBase,MonedaCosto, MonedaVenta from Inventario INNER JOIN Presentaciones ON Presentaciones.CodPres = Inventario.CodPresentacion AND (Inhabilitado = 0) and Codigo ='" & codigo & "' or Barras = '" & codigo & "'")

            Encontrado = False

            While rs.Read
                Try

                    Encontrado = True
                    Consignacion = rs("Consignacion")
                    If Consignacion Then
                        MsgBox("No puede agregar un producto consignado", MsgBoxStyle.Exclamation)
                        CConexion.DesConectar(CConexion.Conectar)
                        Exit Sub
                    End If

                    TxtCodigo_art.Text = rs("Codigo")
                    Txt_Descri_Articulo.Text = rs("Descripcion")
                    PrecioBase = rs("PrecioBase")
                    MonedaCosto = rs("MonedaCosto")


                    'MonedaVenta = Me.BindingContext(Me.DataSet_Facturaciones, "Moneda").Current("CodMoneda")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    CConexion.DesConectar(CConexion.Conectar)
                End Try
            End While
            rs.Close()

            If Not Encontrado Then
                MsgBox("No existe o está inhabilitado un artìculo con este código", MsgBoxStyle.Exclamation)
                'Me.txtCodArticulo.Text = ""
                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").CancelCurrentEdit()
                Me.TxtCodigo_art.Focus()
                CConexion.DesConectar(CConexion.Conectar)
                Exit Sub
            End If

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

            TxtPrecioUni.Text = Math.Round((Me.PrecioBase * (ValorCosto / CDbl(Me.Label_Tipo_Cambio.Text))), 2)



        Else ' si no se recupero ningun articulo, se termina la edicion

            Try

                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").CancelCurrentEdit()
                Me.TxtCodigo_art.Focus()

            Catch ex As SystemException
                MsgBox(ex.Message)
                CConexion.DesConectar(CConexion.Conectar)
            End Try

            CConexion.DesConectar(CConexion.Conectar)
        End If

    End Sub
    Private Sub TxtCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If Me.TxtCant.Text = "" Then Exit Sub
                If Me.TxtCant.Text = "0" Then
                    MsgBox("No se pueden Trasladar 0 artículos", MsgBoxStyle.Information)
                    Me.TxtCant.Text = "1"
                    Exit Sub
                End If
                meter_al_detalle()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Function meter_al_detalle()
        Try
            Dim resp As Integer

            resp = MessageBox.Show("¿Desea agregar este artículo al Traslado?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

            If resp <> 6 Then
                Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").CancelCurrentEdit()
                Me.GridControl1.Enabled = True
                Me.TxtCodigo_art.Focus()
                Exit Function
            End If

            Me.TxtTotal.Text = CDbl(Me.TxtPrecioUni.Text) * CDbl(Me.TxtCant.Text)

            Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario.Traslado_InventarioTraslado_Inv_Detalle").EndCurrentEdit()

            Me.TxtMonto.Text = Me.colTotal.SummaryItem.SummaryValue

            Me.BindingContext(Me.DataSet_Traslados_Inv1, "Traslado_Inventario").EndCurrentEdit()

            Me.TxtCodigo_art.Focus()
            Me.GridControl1.Enabled = True
            Me.ToolBarRegistrar.Enabled = True

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Private Sub Check_Anulado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Anulado.CheckedChanged
        If Me.Check_Anulado.Checked = True Then
            Me.Label_Anulado.Visible = True
        Else
            Me.Label_Anulado.Visible = False
        End If
    End Sub

    Private Sub Tex_Clave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tex_Clave.TextChanged

    End Sub

    Private Sub Text_Transportista_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Transportista.EditValueChanged

    End Sub

    Private Sub txtboleta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtboleta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Try
                Me.GroupBox3.Enabled = True
                Me.Text_Destino.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Text_Destino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Text_Destino.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Me.Text_Destinatario.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Text_Destinatario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Text_Destinatario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Me.Text_Transportista.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtboleta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtboleta.TextChanged

    End Sub

    Private Sub txtboleta_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtboleta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Me.GroupBox3.Enabled = True
                Me.Text_Destino.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Frm_Traslados_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Dim Tiempo As Integer
        For Tiempo = 100 To 0 Step -1
            Me.Opacity = Tiempo
            Application.DoEvents()
        Next
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Frm_Traslados_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim Tiempo As Integer
        For Tiempo = 100 To 0 Step -1
            Me.Opacity = Tiempo
            Application.DoEvents()
        Next
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TxtCodigo_art_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo_art.EditValueChanged

    End Sub
End Class
