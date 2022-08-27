Imports System.data.SqlClient
Imports System.IO
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports System.Data

Public Class FrmLotes
    Inherits FrmPlantilla


#Region "Variables"

    Dim Usua As New Object
    Dim PMU As New PerfilModulo_Class
 
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodArticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LNumero As System.Windows.Forms.Label
    Friend WithEvents LVencimiento As System.Windows.Forms.Label
    Friend WithEvents DTPVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtCantidad As ValidText.ValidText
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents AdapterLote As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterInventario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetActualizaLotes1 As LcPymes_5._2.DataSetActualizaLotes
    Friend WithEvents TxtCodArt As System.Windows.Forms.TextBox
    Friend WithEvents AdapterArticulosComprados As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLotes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtCantidad = New ValidText.ValidText
        Me.Label25 = New System.Windows.Forms.Label
        Me.LNumero = New System.Windows.Forms.Label
        Me.TxtNumero = New System.Windows.Forms.TextBox
        Me.LVencimiento = New System.Windows.Forms.Label
        Me.DTPVencimiento = New System.Windows.Forms.DateTimePicker
        Me.txtCodArticulo = New System.Windows.Forms.TextBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DataSetActualizaLotes1 = New LcPymes_5._2.DataSetActualizaLotes
        Me.AdapterLote = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterInventario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.TxtCodArt = New System.Windows.Forms.TextBox
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetActualizaLotes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 6
        Me.ToolBarEliminar.Text = "Cerrar"
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(570, 32)
        Me.TituloModulo.Text = "                                Actualización de Lote por Articulo Existente "
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 168)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(570, 52)
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(1002, 198)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.LNumero)
        Me.GroupBox1.Controls.Add(Me.TxtNumero)
        Me.GroupBox1.Controls.Add(Me.LVencimiento)
        Me.GroupBox1.Controls.Add(Me.DTPVencimiento)
        Me.GroupBox1.Controls.Add(Me.txtCodArticulo)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 96)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dato del Lote"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(17, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(502, 15)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Artículos en Detalle "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCantidad.FieldReference = Nothing
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.ForeColor = System.Drawing.Color.Blue
        Me.TxtCantidad.Location = New System.Drawing.Point(96, 56)
        Me.TxtCantidad.MaskEdit = ""
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCantidad.Required = True
        Me.TxtCantidad.ShowErrorIcon = True
        Me.TxtCantidad.Size = New System.Drawing.Size(64, 13)
        Me.TxtCantidad.TabIndex = 93
        Me.TxtCantidad.Text = "0.00"
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCantidad.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCantidad.ValidText = "#0.00"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label25.Location = New System.Drawing.Point(16, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 94
        Me.Label25.Text = "Cantidad"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LNumero
        '
        Me.LNumero.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNumero.ForeColor = System.Drawing.Color.White
        Me.LNumero.Location = New System.Drawing.Point(168, 56)
        Me.LNumero.Name = "LNumero"
        Me.LNumero.Size = New System.Drawing.Size(64, 12)
        Me.LNumero.TabIndex = 92
        Me.LNumero.Text = "Número"
        Me.LNumero.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TxtNumero
        '
        Me.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumero.Location = New System.Drawing.Point(240, 56)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(82, 13)
        Me.TxtNumero.TabIndex = 91
        Me.TxtNumero.Text = ""
        '
        'LVencimiento
        '
        Me.LVencimiento.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVencimiento.ForeColor = System.Drawing.Color.White
        Me.LVencimiento.Location = New System.Drawing.Point(328, 56)
        Me.LVencimiento.Name = "LVencimiento"
        Me.LVencimiento.Size = New System.Drawing.Size(84, 12)
        Me.LVencimiento.TabIndex = 90
        Me.LVencimiento.Text = "Vencimiento"
        Me.LVencimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DTPVencimiento
        '
        Me.DTPVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DTPVencimiento.Location = New System.Drawing.Point(416, 56)
        Me.DTPVencimiento.Name = "DTPVencimiento"
        Me.DTPVencimiento.Size = New System.Drawing.Size(94, 20)
        Me.DTPVencimiento.TabIndex = 89
        Me.DTPVencimiento.Value = New Date(2008, 9, 30, 0, 0, 0, 0)
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodArticulo.Location = New System.Drawing.Point(96, 40)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.Size = New System.Drawing.Size(86, 13)
        Me.txtCodArticulo.TabIndex = 12
        Me.txtCodArticulo.Text = ""
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(184, 40)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(334, 13)
        Me.txtdescripcion.TabIndex = 14
        Me.txtdescripcion.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(16, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Código ->"
        '
        'DataSetActualizaLotes1
        '
        Me.DataSetActualizaLotes1.DataSetName = "DataSetActualizaLotes"
        Me.DataSetActualizaLotes1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'AdapterLote
        '
        Me.AdapterLote.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterLote.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterLote.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterLote.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lotes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Numero", "Numero"), New System.Data.Common.DataColumnMapping("Vencimiento", "Vencimiento"), New System.Data.Common.DataColumnMapping("Cant_Inicial", "Cant_Inicial"), New System.Data.Common.DataColumnMapping("Cant_Actual", "Cant_Actual"), New System.Data.Common.DataColumnMapping("Fecha_Entrada", "Fecha_Entrada"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterLote.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Lotes WHERE (Id = @Original_Id)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""ERMIS-PC"";packet size=4096;integrated security=SSPI;data source=""" & _
        "ERMIS-PC\SQL2000"";persist security info=False;initial catalog=Seepos"
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Lotes(Numero, Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, " & _
        "Cod_Articulo, Documento, Tipo) VALUES (@Numero, @Vencimiento, @Cant_Inicial, @Ca" & _
        "nt_Actual, @Fecha_Entrada, @Cod_Articulo, @Documento, @Tipo); SELECT Id, Numero," & _
        " Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, Cod_Articulo, Documento," & _
        " Tipo FROM Lotes WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Numero, Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, Cod_Art" & _
        "iculo, Documento, Tipo FROM Lotes"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Lotes SET Numero = @Numero, Vencimiento = @Vencimiento, Cant_Inicial = @Ca" & _
        "nt_Inicial, Cant_Actual = @Cant_Actual, Fecha_Entrada = @Fecha_Entrada, Cod_Arti" & _
        "culo = @Cod_Articulo, Documento = @Documento, Tipo = @Tipo WHERE (Id = @Original" & _
        "_Id); SELECT Id, Numero, Vencimiento, Cant_Inicial, Cant_Actual, Fecha_Entrada, " & _
        "Cod_Articulo, Documento, Tipo FROM Lotes WHERE (Id = @Id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Numero", System.Data.SqlDbType.VarChar, 250, "Numero"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vencimiento", System.Data.SqlDbType.DateTime, 8, "Vencimiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cant_Inicial", System.Data.SqlDbType.Float, 8, "Cant_Inicial"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cant_Actual", System.Data.SqlDbType.Float, 8, "Cant_Actual"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha_Entrada", System.Data.SqlDbType.DateTime, 8, "Fecha_Entrada"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.BigInt, 8, "Cod_Articulo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.BigInt, 8, "Documento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 3, "Tipo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'AdapterInventario
        '
        Me.AdapterInventario.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterInventario.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterInventario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CatalogoInventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Cod_Articulo", "Cod_Articulo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO CatalogoInventario(Codigo, Cod_Articulo, Descripcion) VALUES (@Codigo" & _
        ", @Cod_Articulo, @Descripcion); SELECT Codigo, Cod_Articulo, Descripcion FROM Ca" & _
        "talogoInventario"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Articulo", System.Data.SqlDbType.VarChar, 255, "Cod_Articulo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 341, "Descripcion"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Cod_Articulo, Descripcion FROM CatalogoInventario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'TxtCodArt
        '
        Me.TxtCodArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodArt.Location = New System.Drawing.Point(296, 176)
        Me.TxtCodArt.Name = "TxtCodArt"
        Me.TxtCodArt.Size = New System.Drawing.Size(86, 13)
        Me.TxtCodArt.TabIndex = 72
        Me.TxtCodArt.Text = ""
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM articulos_comprados WHERE (Id_ArticuloComprados = @Original_Id_Articu" & _
        "loComprados)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ArticuloComprados", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO articulos_comprados(Codigo, CodArticulo, Descripcion, Lote) VALUES (@" & _
        "Codigo, @CodArticulo, @Descripcion, @Lote); SELECT Codigo, CodArticulo, Descripc" & _
        "ion, Lote, Id_ArticuloComprados FROM articulos_comprados WHERE (Id_ArticuloCompr" & _
        "ados = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 250, "Lote"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Codigo, CodArticulo, Descripcion, Lote, Id_ArticuloComprados FROM articulo" & _
        "s_comprados"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE articulos_comprados SET Codigo = @Codigo, CodArticulo = @CodArticulo, Desc" & _
        "ripcion = @Descripcion, Lote = @Lote WHERE (Id_ArticuloComprados = @Original_Id_" & _
        "ArticuloComprados); SELECT Codigo, CodArticulo, Descripcion, Lote, Id_ArticuloCo" & _
        "mprados FROM articulos_comprados WHERE (Id_ArticuloComprados = @Id_ArticuloCompr" & _
        "ados)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodArticulo", System.Data.SqlDbType.VarChar, 250, "CodArticulo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Lote", System.Data.SqlDbType.VarChar, 250, "Lote"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ArticuloComprados", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_ArticuloComprados", System.Data.SqlDbType.BigInt, 8, "Id_ArticuloComprados"))
        '
        'FrmLotes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(570, 220)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtCodArt)
        Me.Name = "FrmLotes"
        Me.Text = "Actualización de Lote por articulo Existentes"
        Me.Controls.SetChildIndex(Me.TxtCodArt, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSetActualizaLotes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            AsignandoBinding()
            CargarAdaptadores()
            Valores_Defecto()
            Me.txtCodArticulo.Text = 0
            Me.TxtNumero.Text = 0
            If BindingContext(Me.DataSetActualizaLotes1, "lotes").Count = 0 Then nueva_compra()
            DataSetActualizaLotes1.Clear()
            ToolBar1.Buttons(2).Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub CargarAdaptadores()
        Try

            Me.AdapterInventario.Fill(Me.DataSetActualizaLotes1, "CatalogoInventario")
            Me.AdapterLote.Fill(Me.DataSetActualizaLotes1, "Lotes")

            Me.DataSetActualizaLotes1.Lotes.IdColumn.AutoIncrement = True
            Me.DataSetActualizaLotes1.Lotes.IdColumn.AutoIncrementSeed = -1
            Me.DataSetActualizaLotes1.Lotes.IdColumn.AutoIncrementStep = -1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub AsignandoBinding()
        Try



            TxtCodArt.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetActualizaLotes1, "catalogoinventario.codigo"))
            txtCodArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetActualizaLotes1, "catalogoinventario.cod_articulo"))
            txtdescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetActualizaLotes1, "catalogoinventario.Descripcion"))
            TxtCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetActualizaLotes1, "lotes.Cant_Inicial"))
            Me.TxtNumero.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetActualizaLotes1, "lotes.Numero"))
            Me.DTPVencimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetActualizaLotes1, "lotes.Vencimiento"))

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub txtCodArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodArticulo.KeyDown
        Try

            Select Case e.KeyCode
                Case Keys.F1
                    Try
                        BindingContext(Me.DataSetActualizaLotes1, "Lotes").CancelCurrentEdit()
                        BindingContext(Me.DataSetActualizaLotes1, "Lotes").AddNew()
                        Dim BuscarArt As New FrmBuscarArticulo2
                        BuscarArt.StartPosition = FormStartPosition.CenterParent
                        BuscarArt.Cod_Articulo = True
                        BuscarArt.ShowDialog()
                        If BuscarArt.Cancelado Then Exit Sub
                        txtCodArticulo.Text = BuscarArt.Codigo
                        BuscarArt.Dispose()
                        sender.SelectionStart = 0
                        sender.SelectionLength = Len(sender.Text)
                        CargarInformacion_articulos(txtCodArticulo.Text)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
                    End Try

                Case Keys.F2

                    Registrar()

                Case Keys.Enter

                    Me.TxtCantidad.Focus()

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub


    Private Sub CargarInformacion_articulos(ByVal codigo As String)
        Dim Link As New Conexion
        Dim Articulo As SqlDataReader
        Dim FactorConversion As Decimal
        Dim encontrado As Boolean = False
        If codigo = "" Then
            txtCodArticulo.Focus()
            Exit Sub
        End If

        Articulo = Link.GetRecorset(Link.Conectar, "SELECT Inventario.Codigo, Inventario.Cod_Articulo, Inventario.Barras, Inventario.Descripcion, Inventario.PrecioBase, Inventario.Fletes, Inventario.OtrosCargos, Inventario.Costo,  Inventario.MonedaVenta, Inventario.IVenta, Inventario.Precio_A, Inventario.Precio_B, Inventario.Precio_C, Inventario.Precio_D, Moneda.ValorCompra AS TipoCambio, Inventario.Lote FROM Inventario INNER JOIN Moneda ON Inventario.MonedaVenta = Moneda.CodMoneda where (cast(Cod_Articulo as varchar) = '" & codigo & "' or  Barras = '" & codigo & "')" & "and Inhabilitado = 0 and Servicio = 0")

        Try

            If Articulo.Read Then

                TxtCodArt.Text = Articulo!codigo
                txtCodArticulo.Text = Articulo!Cod_Articulo
                txtdescripcion.Text = Articulo!Descripcion
                txtCodArticulo.Focus()
            Else
                MsgBox("No existe un artículo con ese código o está inhabilitado", MsgBoxStyle.Exclamation)
                txtCodArticulo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Link.DesConectar(Link.sQlconexion)
        End Try
        Link.DesConectar(Link.sQlconexion)
    End Sub
    Private Sub Valores_Defecto()
        Try


            'VALORES POR DEFECTO PARA LA TABLA ARTICULOS LOTES
            Me.DataSetActualizaLotes1.Lotes.IdColumn.AutoIncrement = True
            Me.DataSetActualizaLotes1.Lotes.IdColumn.AutoIncrementStep = 1
            Me.DataSetActualizaLotes1.Lotes.NumeroColumn.DefaultValue = 0
            Me.DataSetActualizaLotes1.Lotes.VencimientoColumn.DefaultValue = Now.Date
            Me.DataSetActualizaLotes1.Lotes.Fecha_EntradaColumn.DefaultValue = Date.Now
            Me.DataSetActualizaLotes1.Lotes.Cant_InicialColumn.DefaultValue = 0
            Me.DataSetActualizaLotes1.Lotes.Cant_ActualColumn.DefaultValue = 0
            Me.DataSetActualizaLotes1.Lotes.Cod_ArticuloColumn.DefaultValue = 0
            Me.DataSetActualizaLotes1.Lotes.DocumentoColumn.DefaultValue = 0
            Me.DataSetActualizaLotes1.Lotes.TipoColumn.DefaultValue = "COM"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub TxtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantidad.TextChanged

    End Sub

    Private Sub TxtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCantidad.KeyDown
        Try

            Select Case e.KeyCode

                Case Keys.Enter

                    Me.TxtNumero.Focus()

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Mensaje")
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : nueva_compra()
                'Case 2 : If PMU.Find Then BuscarFactura_Compra() Else MsgBox("No tiene permiso para buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : Registrar()
                'Case 4 : If PMU.Delete Then Eliminar_Factura_Compra() Else MsgBox("No tiene permiso para eliminar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                'Case 5 : If PMU.Print Then imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If MessageBox.Show("¿Desea Cerrar el módulo " & Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Close()
        End Select
    End Sub


#Region "Metodos"

    Private Sub Registrar()

        Try

            If MsgBox("Desea Proceder a registrar el Lote...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.No Then Exit Sub

            If IsNumeric(TxtCantidad.Text) And txtCodArticulo.Text <> "" Then

                BindingContext(Me.DataSetActualizaLotes1, "Lotes").EndCurrentEdit()

                ToolBar1.Buttons(2).Enabled = False
                If Not ResgistrarDb() Then
                    Exit Sub
                End If


                DataSetActualizaLotes1.Lotes.AcceptChanges()
                DataSetActualizaLotes1.Lotes.Clear()

                nueva_compra()

            Else
                MsgBox("Existen valores no numéricos , debe corregirlos", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            ToolBar1.Buttons(2).Enabled = True
        End Try


    End Sub



    Function ResgistrarDb() As Boolean
        Dim Transaccion As SqlTransaction
        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()


            Transaccion = SqlConnection1.BeginTransaction

            BindingContext(DataSetActualizaLotes1, "Lotes").EndCurrentEdit()


            AdapterLote.UpdateCommand.Transaction = Transaccion
            AdapterLote.DeleteCommand.Transaction = Transaccion
            AdapterLote.InsertCommand.Transaction = Transaccion

            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Numero") = TxtNumero.Text
            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Vencimiento") = DTPVencimiento.Value.Date
            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Cant_Inicial") = TxtCantidad.Text
            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Cant_Actual") = TxtCantidad.Text
            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Fecha_Entrada") = Now
            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Cod_Articulo") = TxtCodArt.Text
            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Documento") = 0
            BindingContext(DataSetActualizaLotes1, "Lotes").Current("Tipo") = "ACT"
            BindingContext(DataSetActualizaLotes1, "Lotes").EndCurrentEdit()
            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterLote.Update(DataSetActualizaLotes1.Lotes)

            '-----------------------------------------------------------------------------------
            Transaccion.Commit()
            MsgBox("Los datos se actualiazaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
            Return True
        Catch ex As Exception
            Transaccion.Rollback()
            If Err.Number = 5 Then
                MsgBox(ex, MsgBoxStyle.Information)
                ToolBar1.Buttons(2).Enabled = True
                Return False
                Exit Try
            End If
            MsgBox(ex.Message, MsgBoxStyle.Information)
            ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try

    End Function


    Private Sub nueva_compra()
        Try

            DataSetActualizaLotes1.Lotes.Clear()
            DTPVencimiento.Value = Now.Date

            If ToolBar1.Buttons(0).Text = "Nuevo" Then
                GroupBox1.Enabled = True
                Valores_Defecto()
                BindingContext(DataSetActualizaLotes1, "Lotes").EndCurrentEdit()
                BindingContext(DataSetActualizaLotes1, "Lotes").AddNew()
                ToolBar1.Buttons(0).Text = "Cancelar"
                ToolBar1.Buttons(0).ImageIndex = 8
                ToolBar1.Buttons(2).Enabled = True
            Else
                GroupBox1.Enabled = False
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                ToolBar1.Buttons(2).Enabled = False
                BindingContext(DataSetActualizaLotes1, "Lotes").CancelCurrentEdit()

                DataSetActualizaLotes1.Clear()
               
            End If

        Catch ex As SystemException
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

#End Region
End Class
