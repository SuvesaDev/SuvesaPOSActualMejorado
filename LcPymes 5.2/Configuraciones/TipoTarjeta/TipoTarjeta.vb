Imports System.data.SqlClient
Imports System.Windows.Forms

Public Class TipoTarjeta
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetTipoTarjeta1 As DataSetTipoTarjeta
    Friend WithEvents AdapterTipoTrajeta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TipoTarjeta))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DataSetTipoTarjeta1 = New LcPymes_5._2.DataSetTipoTarjeta
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterTipoTrajeta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        CType(Me.DataSetTipoTarjeta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Text = "Editar"
        Me.ToolBarExcel.Visible = True
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 283)
        Me.ToolBar1.Size = New System.Drawing.Size(682, 52)
        Me.ToolBar1.TabIndex = 23
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(682, 32)
        Me.TituloModulo.TabIndex = 0
        Me.TituloModulo.Text = "Operadores de Tarjetas"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.Nombre", True))
        Me.TextBox1.Location = New System.Drawing.Point(72, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(376, 20)
        Me.TextBox1.TabIndex = 2
        '
        'DataSetTipoTarjeta1
        '
        Me.DataSetTipoTarjeta1.DataSetName = "DataSetTipoTarjeta"
        Me.DataSetTipoTarjeta1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetTipoTarjeta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(456, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Moneda:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetTipoTarjeta1, "TipoTarjeta.Moneda", True))
        Me.ComboBox1.DataSource = Me.DataSetTipoTarjeta1.Moneda
        Me.ComboBox1.DisplayMember = "MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(520, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "CodMoneda"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.CuentaCXC", True))
        Me.TextBox2.Location = New System.Drawing.Point(112, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(0, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cuenta por Cobrar:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.NombreCXC", True))
        Me.TextBox3.Location = New System.Drawing.Point(288, 83)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(336, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.Observaciones", True))
        Me.TextBox4.Location = New System.Drawing.Point(0, 179)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(624, 80)
        Me.TextBox4.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(0, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(624, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Observaciones"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""(loca" & _
            "l)"";persist security info=False;initial catalog=Hotel"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'AdapterTipoTrajeta
        '
        Me.AdapterTipoTrajeta.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterTipoTrajeta.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterTipoTrajeta.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterTipoTrajeta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("CuentaCXC", "CuentaCXC"), New System.Data.Common.DataColumnMapping("NombreCXC", "NombreCXC"), New System.Data.Common.DataColumnMapping("CuentaIV", "CuentaIV"), New System.Data.Common.DataColumnMapping("NombreIV", "NombreIV"), New System.Data.Common.DataColumnMapping("CuentaComision", "CuentaComision"), New System.Data.Common.DataColumnMapping("NombreComision", "NombreComision"), New System.Data.Common.DataColumnMapping("PorcentajeRetencion", "PorcentajeRetencion"), New System.Data.Common.DataColumnMapping("PorcentajeComision", "PorcentajeComision")})})
        Me.AdapterTipoTrajeta.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaCXC", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaCXC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaComision", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaComision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaIV", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaIV", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCXC", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCXC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreComision", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreComision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreIV", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreIV", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PorcentajeComision", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorcentajeComision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PorcentajeRetencion", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorcentajeRetencion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@CuentaCXC", System.Data.SqlDbType.VarChar, 75, "CuentaCXC"), New System.Data.SqlClient.SqlParameter("@NombreCXC", System.Data.SqlDbType.VarChar, 250, "NombreCXC"), New System.Data.SqlClient.SqlParameter("@CuentaIV", System.Data.SqlDbType.VarChar, 75, "CuentaIV"), New System.Data.SqlClient.SqlParameter("@NombreIV", System.Data.SqlDbType.VarChar, 250, "NombreIV"), New System.Data.SqlClient.SqlParameter("@CuentaComision", System.Data.SqlDbType.VarChar, 75, "CuentaComision"), New System.Data.SqlClient.SqlParameter("@NombreComision", System.Data.SqlDbType.VarChar, 250, "NombreComision"), New System.Data.SqlClient.SqlParameter("@PorcentajeRetencion", System.Data.SqlDbType.Float, 8, "PorcentajeRetencion"), New System.Data.SqlClient.SqlParameter("@PorcentajeComision", System.Data.SqlDbType.Float, 8, "PorcentajeComision")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Nombre, Moneda, Observaciones, CuentaCXC, NombreCXC, CuentaIV, NombreI" & _
            "V, CuentaComision, NombreComision, PorcentajeRetencion, PorcentajeComision FROM " & _
            "TipoTarjeta"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@CuentaCXC", System.Data.SqlDbType.VarChar, 75, "CuentaCXC"), New System.Data.SqlClient.SqlParameter("@NombreCXC", System.Data.SqlDbType.VarChar, 250, "NombreCXC"), New System.Data.SqlClient.SqlParameter("@CuentaIV", System.Data.SqlDbType.VarChar, 75, "CuentaIV"), New System.Data.SqlClient.SqlParameter("@NombreIV", System.Data.SqlDbType.VarChar, 250, "NombreIV"), New System.Data.SqlClient.SqlParameter("@CuentaComision", System.Data.SqlDbType.VarChar, 75, "CuentaComision"), New System.Data.SqlClient.SqlParameter("@NombreComision", System.Data.SqlDbType.VarChar, 250, "NombreComision"), New System.Data.SqlClient.SqlParameter("@PorcentajeRetencion", System.Data.SqlDbType.Float, 8, "PorcentajeRetencion"), New System.Data.SqlClient.SqlParameter("@PorcentajeComision", System.Data.SqlDbType.Float, 8, "PorcentajeComision"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaCXC", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaCXC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaComision", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaComision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaIV", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaIV", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCXC", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCXC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreComision", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreComision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreIV", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreIV", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PorcentajeComision", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorcentajeComision", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PorcentajeRetencion", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PorcentajeRetencion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.NextPage.Visible = False
        Me.DataNavigator1.Buttons.PrevPage.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "TipoTarjeta"
        Me.DataNavigator1.DataSource = Me.DataSetTipoTarjeta1
        Me.DataNavigator1.Location = New System.Drawing.Point(464, 259)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(160, 24)
        Me.DataNavigator1.TabIndex = 22
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(117, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "# Cuenta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(288, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nombre de la Cuenta"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(0, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Retención I.V:"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.NombreIV", True))
        Me.TextBox5.Location = New System.Drawing.Point(288, 107)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(336, 20)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.CuentaIV", True))
        Me.TextBox6.Location = New System.Drawing.Point(112, 107)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(168, 20)
        Me.TextBox6.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(0, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Comisición:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(663, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "%"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.PorcentajeRetencion", True))
        Me.TextBox7.Location = New System.Drawing.Point(631, 105)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(31, 20)
        Me.TextBox7.TabIndex = 13
        '
        'TextBox8
        '
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.PorcentajeComision", True))
        Me.TextBox8.Location = New System.Drawing.Point(632, 131)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(31, 20)
        Me.TextBox8.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(664, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.NombreComision", True))
        Me.TextBox9.Location = New System.Drawing.Point(288, 131)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(336, 20)
        Me.TextBox9.TabIndex = 17
        '
        'TextBox10
        '
        Me.TextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTipoTarjeta1, "TipoTarjeta.CuentaComision", True))
        Me.TextBox10.Location = New System.Drawing.Point(112, 131)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(168, 20)
        Me.TextBox10.TabIndex = 16
        '
        'TipoTarjeta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(682, 335)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TipoTarjeta"
        Me.Text = "Operadores de Tarjetas"
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.TextBox2, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TextBox4, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TextBox6, 0)
        Me.Controls.SetChildIndex(Me.TextBox5, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TextBox7, 0)
        Me.Controls.SetChildIndex(Me.TextBox10, 0)
        Me.Controls.SetChildIndex(Me.TextBox9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TextBox8, 0)
        CType(Me.DataSetTipoTarjeta1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub TipoTarjeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        DataSetTipoTarjeta1.TipoTarjeta.NombreColumn.DefaultValue = " "
        DataSetTipoTarjeta1.TipoTarjeta.MonedaColumn.DefaultValue = "1"
        DataSetTipoTarjeta1.TipoTarjeta.ObservacionesColumn.DefaultValue = " "
        DataSetTipoTarjeta1.TipoTarjeta.CuentaCXCColumn.DefaultValue = 0
        DataSetTipoTarjeta1.TipoTarjeta.NombreCXCColumn.DefaultValue = ""
        DataSetTipoTarjeta1.TipoTarjeta.CuentaIVColumn.DefaultValue = 0
        DataSetTipoTarjeta1.TipoTarjeta.NombreIVColumn.DefaultValue = ""
        DataSetTipoTarjeta1.TipoTarjeta.PorcentajeRetencionColumn.DefaultValue = 0
        DataSetTipoTarjeta1.TipoTarjeta.PorcentajeComisionColumn.DefaultValue = 0
        DataSetTipoTarjeta1.TipoTarjeta.CuentaComisionColumn.DefaultValue = 0
        DataSetTipoTarjeta1.TipoTarjeta.NombreComisionColumn.DefaultValue = ""
        AdapterTipoTrajeta.Fill(DataSetTipoTarjeta1.TipoTarjeta)
        Inabilitar()
        AdapterMoneda.Fill(DataSetTipoTarjeta1, "Moneda")
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()
            Case 4 : Eliminar()
            Case 6 : Editar()
            Case 3 : Registrar()
            Case 7 : Close()
        End Select
    End Sub
#End Region

#Region "Eliminar"
    Function Eliminar()
        Dim resp As Integer
        Try 'se intenta hacer
            If Me.BindingContext(DataSetTipoTarjeta1, "TipoTarjeta").Count > 0 Then   ' si hay Temporadas
                resp = MessageBox.Show("¿Desea eliminar este Operador de tarjeta", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If resp = 6 Then
                    BindingContext(DataSetTipoTarjeta1, "TipoTarjeta").RemoveAt(BindingContext(DataSetTipoTarjeta1, "TipoTarjeta").Position)
                    AdapterTipoTrajeta.Update(DataSetTipoTarjeta1.TipoTarjeta)
                Else
                    BindingContext(DataSetTipoTarjeta1, "TipoTarjeta").CancelCurrentEdit()
                End If
            Else
                MsgBox("No Existen Operadores de  Tarjeta para eliminar", MsgBoxStyle.Information)
            End If
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Function
#End Region

#Region "Nuevo"
    Function Nuevo()
        If DataSetTipoTarjeta1.Moneda.Rows.Count = 0 Then
            MsgBox("No Existen Monedas Disponibles", MsgBoxStyle.Critical)
            Exit Function
        End If
        If ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            Try 'inicia la edicion
                BindingContext(DataSetTipoTarjeta1, "TipoTarjeta").CancelCurrentEdit()
                BindingContext(DataSetTipoTarjeta1, "TipoTarjeta").AddNew()
                ToolBar1.Buttons(0).Text = "Cancelar"
                ToolBar1.Buttons(0).ImageIndex = 8
                TextBox1.Focus()
                Habilitar()
                TextBox1.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                BindingContext(DataSetTipoTarjeta1.TipoTarjeta).CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                Inabilitar()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
#End Region

#Region "Editar"
    Function Editar()
        If ToolBarExcel.ImageIndex = 5 Then
            ToolBarExcel.ImageIndex = 8
            ToolBarExcel.Text = "Cancelar"
            Habilitar()
        Else
            ToolBarExcel.ImageIndex = 5
            ToolBarExcel.Text = "Editar"
            Inabilitar()
        End If
    End Function
#End Region

#Region "Registrar"
    Function Registrar()
        Dim resp As Integer
        If validar() Then
            resp = MessageBox.Show("¿Deseas Guardar los cambios?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Try
                    BindingContext(DataSetTipoTarjeta1, "TipoTarjeta").EndCurrentEdit()
                    AdapterTipoTrajeta.Update(DataSetTipoTarjeta1, "TipoTarjeta")
                    ToolBar1.Buttons(0).Text = "Nuevo"
                    ToolBar1.Buttons(0).ImageIndex = 0
                    ToolBar1.Buttons(3).Enabled = False
                    ToolBarExcel.Text = "Editar"
                    ToolBarExcel.ImageIndex = 5
                    Inabilitar()
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
            Else
                BindingContext(DataSetTipoTarjeta1.TipoTarjeta).CancelCurrentEdit()
                DataSetTipoTarjeta1.RejectChanges()
                'Para boton Nuevo
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                'Para boton Acualizar
                ToolBar1.Buttons(1).ImageIndex = 9
                ToolBarExcel.Text = "Editar"
                ToolBarExcel.ImageIndex = 5
                Inabilitar()
            End If
        Else
            MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
        End If
    End Function
#End Region

#Region "Funciones"
    Function validar()
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Controles"
    Function Habilitar()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
        ComboBox1.Enabled = True
    End Function

    Function Inabilitar()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        ComboBox1.Enabled = False
    End Function
#End Region

#Region "Controles Funciones"
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
                                " where Movimiento=1 "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()
            If busca.codigo Is Nothing Then Exit Sub
            TextBox2.Text = busca.codigo
            TextBox3.Text = busca.descrip
            TextBox6.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = TextBox2.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                TextBox2.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                TextBox3.Text = nombre
                TextBox6.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
                            " where Movimiento=1 "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()
            If busca.codigo Is Nothing Then Exit Sub
            TextBox6.Text = busca.codigo
            TextBox5.Text = busca.descrip
            TextBox7.Focus()
        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = TextBox6.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                TextBox6.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                TextBox5.Text = nombre
                TextBox7.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox10.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
                                " where Movimiento=1 "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()
            If busca.codigo Is Nothing Then Exit Sub
            TextBox10.Text = busca.codigo
            TextBox9.Text = busca.descrip
        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = TextBox2.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                TextBox10.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                TextBox9.Text = nombre
                TextBox8.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox7_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox8_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox8.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub
#End Region

End Class
