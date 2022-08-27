Imports System.Data
Imports System.Windows.Forms
Imports System.Collections.Generic

Public Class FrmBuscarArticulo3
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Public IdPuntoVenta As Integer = 0
    Public Codigo As String
    Public Cancelado As Boolean
    Public Cod_Articulo As Boolean = False
    Public CodigoArticulo As String = "0"
    Public TCodigo As TipoCodigo = TipoCodigo.CodArticulo
    Dim CadenaWhere As String
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents CodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodArticuloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarrasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrestamoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BodegaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioFinalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbicacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecetaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SimboloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorCompraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InhabilitadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Public NuevaConexion As String

    Enum TipoCodigo
        Codigo
        CodArticulo
    End Enum

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
    Friend WithEvents SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetCatalogoInventario As DataSetCatalogoInventario
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtCodigo As ValidText.ValidText
    Friend WithEvents ButtonAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Filtro_Inicio_del_Campo As System.Windows.Forms.RadioButton
    Friend WithEvents Filtro_Cualquier_Parte_del_Campo As System.Windows.Forms.RadioButton
    Public WithEvents CheckBoxInHabilitados As System.Windows.Forms.CheckBox
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents RB_Codigo As System.Windows.Forms.RadioButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarArticulo2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.DataSetCatalogoInventario = New LcPymes_5._2.DataSetCatalogoInventario()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RB_Codigo = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Filtro_Inicio_del_Campo = New System.Windows.Forms.RadioButton()
        Me.Filtro_Cualquier_Parte_del_Campo = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtonCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.TxtCodigo = New ValidText.ValidText()
        Me.CheckBoxInHabilitados = New System.Windows.Forms.CheckBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarrasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrestamoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BodegaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioFinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbicacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecetaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SimboloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InhabilitadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataSetCatalogoInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlDataAdapter
        '
        Me.SqlDataAdapter.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CatalogoInventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Barras", "Barras"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Marca", "Marca"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("Precio_A", "Precio_A"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("PrecioFinal", "PrecioFinal"), New System.Data.Common.DataColumnMapping("Existencia", "Existencia"), New System.Data.Common.DataColumnMapping("Ubicacion", "Ubicacion"), New System.Data.Common.DataColumnMapping("Inhabilitado", "Inhabilitado"), New System.Data.Common.DataColumnMapping("Bodega", "Bodega"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("receta", "receta"), New System.Data.Common.DataColumnMapping("prestamo", "prestamo")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"), New System.Data.SqlClient.SqlParameter("@Barras", System.Data.SqlDbType.VarChar, 255, "Barras"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 341, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Marca", System.Data.SqlDbType.VarChar, 50, "Marca"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@PrecioFinal", System.Data.SqlDbType.Float, 8, "PrecioFinal"), New System.Data.SqlClient.SqlParameter("@Existencia", System.Data.SqlDbType.Float, 8, "Existencia"), New System.Data.SqlClient.SqlParameter("@Ubicacion", System.Data.SqlDbType.VarChar, 150, "Ubicacion"), New System.Data.SqlClient.SqlParameter("@Inhabilitado", System.Data.SqlDbType.Bit, 1, "Inhabilitado"), New System.Data.SqlClient.SqlParameter("@Bodega", System.Data.SqlDbType.Float, 8, "Bodega"), New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.VarChar, 255, "Cod_Articulo"), New System.Data.SqlClient.SqlParameter("@receta", System.Data.SqlDbType.Bit, 1, "receta"), New System.Data.SqlClient.SqlParameter("@prestamo", System.Data.SqlDbType.Float, 8, "prestamo")})
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=""DESKTOP-8M1A70L"";packet size=4096;integrated security=SSPI;data s" & _
    "ource=""DESKTOP-8M1A70L"";persist security info=False;initial catalog=seepos"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Barras, Descripcion, Marca, Simbolo, Precio_A, ValorCompra, Precio" & _
    "Final, Existencia, Ubicacion, Inhabilitado, Bodega, Cod_Articulo, receta, presta" & _
    "mo FROM CatalogoInventario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'DataSetCatalogoInventario
        '
        Me.DataSetCatalogoInventario.DataSetName = "DataSetCatalogoInventario"
        Me.DataSetCatalogoInventario.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSetCatalogoInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBuscar.Location = New System.Drawing.Point(10, 326)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(853, 13)
        Me.TextBoxBuscar.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.White
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton1.Location = New System.Drawing.Point(136, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descripción"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.BackColor = System.Drawing.Color.White
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton2.Location = New System.Drawing.Point(232, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ubicación"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.BackColor = System.Drawing.Color.White
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RadioButton3.Location = New System.Drawing.Point(320, 0)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Barras"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda en -->"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RB_Codigo)
        Me.Panel1.Location = New System.Drawing.Point(10, 341)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 16)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'RB_Codigo
        '
        Me.RB_Codigo.BackColor = System.Drawing.Color.White
        Me.RB_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Codigo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.RB_Codigo.Location = New System.Drawing.Point(400, 0)
        Me.RB_Codigo.Name = "RB_Codigo"
        Me.RB_Codigo.Size = New System.Drawing.Size(64, 16)
        Me.RB_Codigo.TabIndex = 4
        Me.RB_Codigo.TabStop = True
        Me.RB_Codigo.Text = "Código"
        Me.RB_Codigo.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Filtro_Inicio_del_Campo)
        Me.Panel2.Controls.Add(Me.Filtro_Cualquier_Parte_del_Campo)
        Me.Panel2.Location = New System.Drawing.Point(9, 360)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(471, 16)
        Me.Panel2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Coincidir  -->"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Filtro_Inicio_del_Campo
        '
        Me.Filtro_Inicio_del_Campo.BackColor = System.Drawing.Color.White
        Me.Filtro_Inicio_del_Campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro_Inicio_del_Campo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Filtro_Inicio_del_Campo.Location = New System.Drawing.Point(140, 2)
        Me.Filtro_Inicio_del_Campo.Name = "Filtro_Inicio_del_Campo"
        Me.Filtro_Inicio_del_Campo.Size = New System.Drawing.Size(116, 13)
        Me.Filtro_Inicio_del_Campo.TabIndex = 0
        Me.Filtro_Inicio_del_Campo.TabStop = True
        Me.Filtro_Inicio_del_Campo.Text = "Inicio del Campo"
        Me.Filtro_Inicio_del_Campo.UseVisualStyleBackColor = False
        '
        'Filtro_Cualquier_Parte_del_Campo
        '
        Me.Filtro_Cualquier_Parte_del_Campo.BackColor = System.Drawing.Color.White
        Me.Filtro_Cualquier_Parte_del_Campo.Checked = True
        Me.Filtro_Cualquier_Parte_del_Campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filtro_Cualquier_Parte_del_Campo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Filtro_Cualquier_Parte_del_Campo.Location = New System.Drawing.Point(285, 0)
        Me.Filtro_Cualquier_Parte_del_Campo.Name = "Filtro_Cualquier_Parte_del_Campo"
        Me.Filtro_Cualquier_Parte_del_Campo.Size = New System.Drawing.Size(112, 16)
        Me.Filtro_Cualquier_Parte_del_Campo.TabIndex = 1
        Me.Filtro_Cualquier_Parte_del_Campo.TabStop = True
        Me.Filtro_Cualquier_Parte_del_Campo.Text = "Cualquier Parte"
        Me.Filtro_Cualquier_Parte_del_Campo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(488, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Cód. Seleccionado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(673, 341)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(91, 35)
        Me.ButtonAceptar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonAceptar.TabIndex = 4
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(772, 341)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(91, 35)
        Me.ButtonCancelar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonCancelar.TabIndex = 5
        Me.ButtonCancelar.Text = "Cancelar"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 575
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.FieldReference = Nothing
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodigo.Location = New System.Drawing.Point(488, 360)
        Me.TxtCodigo.MaskEdit = ""
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCodigo.Required = False
        Me.TxtCodigo.ShowErrorIcon = False
        Me.TxtCodigo.Size = New System.Drawing.Size(112, 13)
        Me.TxtCodigo.TabIndex = 3
        Me.TxtCodigo.Text = "0.00"
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.None
        Me.TxtCodigo.ValidText = "0"
        '
        'CheckBoxInHabilitados
        '
        Me.CheckBoxInHabilitados.Enabled = False
        Me.CheckBoxInHabilitados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxInHabilitados.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CheckBoxInHabilitados.Location = New System.Drawing.Point(672, 5)
        Me.CheckBoxInHabilitados.Name = "CheckBoxInHabilitados"
        Me.CheckBoxInHabilitados.Size = New System.Drawing.Size(136, 16)
        Me.CheckBoxInHabilitados.TabIndex = 78
        Me.CheckBoxInHabilitados.Text = "Mostrar Inhabilitados"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-8M1A70L"";packet size=4096;integrated security=SSPI;data s" & _
    "ource=""DESKTOP-8M1A70L"";persist security info=False;initial catalog=seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.AutoGenerateColumns = False
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.CodArticuloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.BarrasDataGridViewTextBoxColumn, Me.PrestamoDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.BodegaDataGridViewTextBoxColumn, Me.PrecioFinalDataGridViewTextBoxColumn, Me.UbicacionDataGridViewTextBoxColumn, Me.RecetaDataGridViewCheckBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.SimboloDataGridViewTextBoxColumn, Me.PrecioADataGridViewTextBoxColumn, Me.ValorCompraDataGridViewTextBoxColumn, Me.InhabilitadoDataGridViewCheckBoxColumn})
        Me.viewDatos.DataMember = "CatalogoInventario"
        Me.viewDatos.DataSource = Me.DataSetCatalogoInventario
        Me.viewDatos.Location = New System.Drawing.Point(3, 24)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewDatos.RowTemplate.Height = 28
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(860, 300)
        Me.viewDatos.TabIndex = 1
        Me.viewDatos.TabStop = False
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoDataGridViewTextBoxColumn.Visible = False
        Me.CodigoDataGridViewTextBoxColumn.Width = 80
        '
        'CodArticuloDataGridViewTextBoxColumn
        '
        Me.CodArticuloDataGridViewTextBoxColumn.DataPropertyName = "Cod_Articulo"
        Me.CodArticuloDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodArticuloDataGridViewTextBoxColumn.Name = "CodArticuloDataGridViewTextBoxColumn"
        Me.CodArticuloDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodArticuloDataGridViewTextBoxColumn.Width = 85
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 250
        '
        'BarrasDataGridViewTextBoxColumn
        '
        Me.BarrasDataGridViewTextBoxColumn.DataPropertyName = "Barras"
        Me.BarrasDataGridViewTextBoxColumn.HeaderText = "Barras"
        Me.BarrasDataGridViewTextBoxColumn.Name = "BarrasDataGridViewTextBoxColumn"
        Me.BarrasDataGridViewTextBoxColumn.ReadOnly = True
        Me.BarrasDataGridViewTextBoxColumn.Width = 140
        '
        'PrestamoDataGridViewTextBoxColumn
        '
        Me.PrestamoDataGridViewTextBoxColumn.DataPropertyName = "prestamo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.PrestamoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PrestamoDataGridViewTextBoxColumn.HeaderText = "Prestamo"
        Me.PrestamoDataGridViewTextBoxColumn.Name = "PrestamoDataGridViewTextBoxColumn"
        Me.PrestamoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrestamoDataGridViewTextBoxColumn.Width = 50
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.ExistenciaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        Me.ExistenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExistenciaDataGridViewTextBoxColumn.Width = 50
        '
        'BodegaDataGridViewTextBoxColumn
        '
        Me.BodegaDataGridViewTextBoxColumn.DataPropertyName = "Bodega"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.BodegaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.BodegaDataGridViewTextBoxColumn.HeaderText = "Bodega"
        Me.BodegaDataGridViewTextBoxColumn.Name = "BodegaDataGridViewTextBoxColumn"
        Me.BodegaDataGridViewTextBoxColumn.ReadOnly = True
        Me.BodegaDataGridViewTextBoxColumn.Width = 50
        '
        'PrecioFinalDataGridViewTextBoxColumn
        '
        Me.PrecioFinalDataGridViewTextBoxColumn.DataPropertyName = "PrecioFinal"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.PrecioFinalDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PrecioFinalDataGridViewTextBoxColumn.HeaderText = "PrecioFinal"
        Me.PrecioFinalDataGridViewTextBoxColumn.Name = "PrecioFinalDataGridViewTextBoxColumn"
        Me.PrecioFinalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioFinalDataGridViewTextBoxColumn.Width = 75
        '
        'UbicacionDataGridViewTextBoxColumn
        '
        Me.UbicacionDataGridViewTextBoxColumn.DataPropertyName = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.HeaderText = "Ubicacion"
        Me.UbicacionDataGridViewTextBoxColumn.Name = "UbicacionDataGridViewTextBoxColumn"
        Me.UbicacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecetaDataGridViewCheckBoxColumn
        '
        Me.RecetaDataGridViewCheckBoxColumn.DataPropertyName = "receta"
        Me.RecetaDataGridViewCheckBoxColumn.HeaderText = "receta"
        Me.RecetaDataGridViewCheckBoxColumn.Name = "RecetaDataGridViewCheckBoxColumn"
        Me.RecetaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.RecetaDataGridViewCheckBoxColumn.Width = 50
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcaDataGridViewTextBoxColumn.Visible = False
        '
        'SimboloDataGridViewTextBoxColumn
        '
        Me.SimboloDataGridViewTextBoxColumn.DataPropertyName = "Simbolo"
        Me.SimboloDataGridViewTextBoxColumn.HeaderText = "Simbolo"
        Me.SimboloDataGridViewTextBoxColumn.Name = "SimboloDataGridViewTextBoxColumn"
        Me.SimboloDataGridViewTextBoxColumn.ReadOnly = True
        Me.SimboloDataGridViewTextBoxColumn.Visible = False
        '
        'PrecioADataGridViewTextBoxColumn
        '
        Me.PrecioADataGridViewTextBoxColumn.DataPropertyName = "Precio_A"
        Me.PrecioADataGridViewTextBoxColumn.HeaderText = "Precio_A"
        Me.PrecioADataGridViewTextBoxColumn.Name = "PrecioADataGridViewTextBoxColumn"
        Me.PrecioADataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioADataGridViewTextBoxColumn.Visible = False
        '
        'ValorCompraDataGridViewTextBoxColumn
        '
        Me.ValorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra"
        Me.ValorCompraDataGridViewTextBoxColumn.HeaderText = "ValorCompra"
        Me.ValorCompraDataGridViewTextBoxColumn.Name = "ValorCompraDataGridViewTextBoxColumn"
        Me.ValorCompraDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorCompraDataGridViewTextBoxColumn.Visible = False
        '
        'InhabilitadoDataGridViewCheckBoxColumn
        '
        Me.InhabilitadoDataGridViewCheckBoxColumn.DataPropertyName = "Inhabilitado"
        Me.InhabilitadoDataGridViewCheckBoxColumn.HeaderText = "Inhabilitado"
        Me.InhabilitadoDataGridViewCheckBoxColumn.Name = "InhabilitadoDataGridViewCheckBoxColumn"
        Me.InhabilitadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.InhabilitadoDataGridViewCheckBoxColumn.Visible = False
        '
        'FrmBuscarArticulo2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.ButtonCancelar
        Me.ClientSize = New System.Drawing.Size(866, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.CheckBoxInHabilitados)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBuscarArticulo2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Artículo"
        CType(Me.DataSetCatalogoInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Servidor As String = ""

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

    Private Sub FrmBuscarArticulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)

        Dim Conexion() As String = Me.SqlConnection.ConnectionString.Split(";")
        Me.Servidor = Me.BuscaDatos(Conexion(0))

        Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView.AllowDelete = False
        Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView.AllowEdit = False
        Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView.AllowNew = False
        'Me.GridControl.DataSource = Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView

        'If Cod_Articulo Then
        '    'colCodigo.FieldName = "Cod_Articulo"
        '    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView, "Cod_Articulo"))
        'Else
        '    Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView, "Codigo"))
        'End If

        If Me.BindingContext(Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView).Count Then
            Me.BindingContext(Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView).Position = 0
        End If
    End Sub
#End Region

    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        If TextBoxBuscar.Text.Length > 1 Then
            If Me.RadioButton1.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
            ElseIf Me.RadioButton2.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
            ElseIf RadioButton3.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
            Else
                BuscarDatos(Me.TextBoxBuscar.Text, "Cod_Articulo")
            End If
        End If
    End Sub

    Private Sub BuscarDatos(ByVal Descripcion As String, ByVal CampoFiltro As String)

        If Me.Filtro_Inicio_del_Campo.Checked = True Then
            If CampoFiltro = "Barras" Then
                CadenaWhere = " and " & CampoFiltro & " lIKE '" & Descripcion & "%' or barras2 LIKE '" & Descripcion & "%' or barras3 LIKE '" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            Else
                CadenaWhere = " and " & CampoFiltro & " lIKE '" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            End If

        ElseIf Me.Filtro_Cualquier_Parte_del_Campo.Checked = True Then
            If CampoFiltro = "Barras" Then
                CadenaWhere = " and " & CampoFiltro & " lIKE '%" & Descripcion & "%' or barras2 LIKE '%" & Descripcion & "%' or barras3 LIKE '%" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            Else
                CadenaWhere = " and " & CampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " and Inhabilitado = 0")
            End If
        Else
            CadenaWhere = "" & IIf(Me.CheckBoxInHabilitados.Checked = True, "", " Inhabilitado = 0")
        End If
        Try

            If Me.IdPuntoVenta > 0 Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("select * from PuntodeVenta where IdPuntoVenta = " & Me.IdPuntoVenta, dt, CadenaConexionSeguridad)
                Me.SqlConnection.ConnectionString = "Data Source=" & Me.Servidor & "; Initial Catalog=" & dt.Rows(0).Item("BasedeDatos") & "; Integrated Security=true;"
            End If

            Me.DataSetCatalogoInventario.Clear()
            Me.SqlDataAdapter.SelectCommand.CommandText = "SELECT Codigo, Cod_Articulo, Barras, Descripcion, Marca, Simbolo, Precio_A, ValorCompra, PrecioFinal, Existencia, Bodega, Ubicacion, Inhabilitado, receta,prestamo FROM CatalogoInventario2 where Codigo in(select Codigo1 from Codigos Where (IdPuntoVenta1 = " & Me.IdPuntoVenta1 & " and IdPuntoVenta2 = " & Me.IdPuntoVenta2 & ") or (IdPuntoVenta2 = " & Me.IdPuntoVenta1 & " and IdPuntoVenta1 = " & Me.IdPuntoVenta2 & ")) " & CadenaWhere
            Me.SqlDataAdapter.Fill(Me.DataSetCatalogoInventario, "CatalogoInventario")
            Me.pone_color()
            'Me.GridControl.DataSource = Me.DataSetCatalogoInventario.CatalogoInventario.DefaultView
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public IdPuntoVenta1, IdPuntoVenta2 As Integer
    Private Sub pone_color()
        Dim Negativo As Drawing.Color = Drawing.Color.Red
        Dim MeDeben As Drawing.Color = Drawing.Color.Green
        Dim YoDebo As Drawing.Color = Drawing.Color.Orange
        Dim EnCero As Drawing.Color = Drawing.Color.LightBlue

        Dim t As List(Of DataGridViewRow)

        t = (From x As DataGridViewRow In Me.viewDatos.Rows Where CDec(x.Cells("PrestamoDataGridViewTextBoxColumn").Value) < 0 Select x).ToList

        For Each r As DataGridViewRow In t
            r.DefaultCellStyle.BackColor = MeDeben
            r.DefaultCellStyle.SelectionBackColor = MeDeben
            r.DefaultCellStyle.SelectionForeColor = Drawing.Color.White
        Next

        t = (From x As DataGridViewRow In Me.viewDatos.Rows Where CDec(x.Cells("PrestamoDataGridViewTextBoxColumn").Value) > 0 Select x).ToList

        For Each r As DataGridViewRow In t
            r.DefaultCellStyle.BackColor = YoDebo
            r.DefaultCellStyle.SelectionBackColor = YoDebo
            r.DefaultCellStyle.SelectionForeColor = Drawing.Color.White
        Next

        t = (From x As DataGridViewRow In Me.viewDatos.Rows Where CDec(x.Cells("ExistenciaDataGridViewTextBoxColumn").Value) < 0 Select x).ToList

        For Each r As DataGridViewRow In t
            r.DefaultCellStyle.BackColor = Negativo
            r.DefaultCellStyle.SelectionBackColor = Negativo
            r.DefaultCellStyle.SelectionForeColor = Drawing.Color.White
        Next

        t = (From x As DataGridViewRow In Me.viewDatos.Rows Where CDec(x.Cells("ExistenciaDataGridViewTextBoxColumn").Value) = 0 Select x).ToList

        For Each r As DataGridViewRow In t
            r.DefaultCellStyle.BackColor = EnCero
            r.DefaultCellStyle.SelectionBackColor = EnCero
            r.DefaultCellStyle.SelectionForeColor = Drawing.Color.White
        Next

    End Sub

    Private Sub TextBoxBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxBuscar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            'GridControl.Focus()
            Me.viewDatos.Focus()
        End If
    End Sub

    'Private Sub GridControl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridControl.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        SeleccionarCodigo()
    '        Cancelado = False
    '        Codigo = TxtCodigo.Text
    '        Close()
    '    End If
    'End Sub

    Sub SeleccionarCodigo()
        'Dim hi As DevExpress.XtraGrid.Views.BandedGrid.ViewInfo.BandedGridHitInfo = AdvBandedGridView1.CalcHitInfo(CType(GridControl, Control).PointToClient(Control.MousePosition))
        'If hi.RowHandle >= 0 Then
        '    CodigoArticulo = AdvBandedGridView1.GetDataRow(AdvBandedGridView1.FocusedRowHandle).ItemArray(0)
        'ElseIf AdvBandedGridView1.FocusedRowHandle >= 0 Then
        '    CodigoArticulo = AdvBandedGridView1.GetDataRow(AdvBandedGridView1.FocusedRowHandle).ItemArray(0)
        'Else
        '    CodigoArticulo = 0
        'End If
        If Me.viewDatos.RowCount > 0 Then
            If TCodigo = TipoCodigo.CodArticulo Then
                Me.CodigoArticulo = Me.viewDatos.Item("CodArticuloDataGridViewTextBoxColumn", Me.viewDatos.CurrentRow.Index).Value
            Else
                Me.CodigoArticulo = Me.viewDatos.Item("CodigoDataGridViewTextBoxColumn", Me.viewDatos.CurrentRow.Index).Value
            End If
        Else
            Me.CodigoArticulo = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If TextBoxBuscar.Text.Length > 1 Then BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
        TextBoxBuscar.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If TextBoxBuscar.Text.Length > 1 Then BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
        TextBoxBuscar.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If TextBoxBuscar.Text.Length > 1 Then BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
        TextBoxBuscar.Focus()
    End Sub

    Private Sub RB_Codigo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Codigo.CheckedChanged
        If TextBoxBuscar.Text.Length > 1 Then BuscarDatos(Me.TextBoxBuscar.Text, "Cod_Articulo")
        TextBoxBuscar.Focus()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        SeleccionarCodigo()
        Cancelado = False
        Codigo = TxtCodigo.Text
        Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Cancelado = True
        Codigo = 0
        Close()
    End Sub

    'Private Sub GridControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl.DoubleClick
    '    SeleccionarCodigo()
    '    Cancelado = False
    '    Codigo = TxtCodigo.Text
    '    Close()
    'End Sub

    Private Sub Filtro_Inicio_del_Campo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filtro_Inicio_del_Campo.CheckedChanged, Filtro_Cualquier_Parte_del_Campo.CheckedChanged
        If RadioButton1.Checked = True Then
            If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
        ElseIf RadioButton2.Checked = True Then
            If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
        ElseIf RadioButton3.Checked = True Then
            If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
        ElseIf RB_Codigo.Checked = True Then
            If TextBoxBuscar.Text.Length > 2 Then BuscarDatos(Me.TextBoxBuscar.Text, "Cod_Articulo")
        End If
    End Sub

    Private Sub CheckBoxInHabilitados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxInHabilitados.CheckedChanged
        If TextBoxBuscar.Text.Length > 1 Then
            If Me.RadioButton1.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Descripcion")
            ElseIf Me.RadioButton2.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Ubicacion")
            ElseIf RadioButton3.Checked = True Then
                BuscarDatos(Me.TextBoxBuscar.Text, "Barras")
            Else
                BuscarDatos(Me.TextBoxBuscar.Text, "Cod_Articulo")
            End If
        End If
        TextBoxBuscar.Focus()
    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SeleccionarCodigo()
            Cancelado = False
            Codigo = TxtCodigo.Text
            Close()
        End If
    End Sub

    Private Sub viewDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDatos.KeyDown
        If e.KeyCode = Keys.Enter Then
            SeleccionarCodigo()
            Cancelado = False
            Codigo = TxtCodigo.Text
            Close()
        End If
    End Sub

    Private Sub viewDatos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellContentDoubleClick
        SeleccionarCodigo()
        Cancelado = False
        Codigo = TxtCodigo.Text
        Close()
    End Sub

    Private Sub viewDatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEnter
        Dim cod As String = ""
        If Me.Cod_Articulo = True Then
            cod = Me.viewDatos.Item("CodArticuloDataGridViewTextBoxColumn", e.RowIndex).Value
        Else
            cod = Me.viewDatos.Item("CodigoDataGridViewTextBoxColumn", e.RowIndex).Value
        End If
        Me.TxtCodigo.Text = cod
    End Sub

    Private Sub viewDatos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles viewDatos.ColumnHeaderMouseClick
        Me.pone_color()
    End Sub

End Class