Imports System.data.SqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class frmAumento
    Inherits FrmPlantilla
    Dim PMU As New PerfilModulo_Class


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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsAumento As DsAumento
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daSubFamilia As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daFamilia As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedulaUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripciónFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripciónSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents gbOpcionAumento As System.Windows.Forms.GroupBox
    Friend WithEvents gbFamilia As System.Windows.Forms.GroupBox
    Friend WithEvents gbSubFamilia As System.Windows.Forms.GroupBox
    Friend WithEvents gbAumentosFamilia As System.Windows.Forms.GroupBox
    Friend WithEvents gbAumentosSubFamilia As System.Windows.Forms.GroupBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents opPorSubFamilia As System.Windows.Forms.RadioButton
    Friend WithEvents opPorFamilia As System.Windows.Forms.RadioButton
    Friend WithEvents txtCostoFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtDFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtBFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtAFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtDSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtBSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtASubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseSubFamilia As System.Windows.Forms.TextBox
    Friend WithEvents daInventario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dgInventario As DevExpress.XtraGrid.GridControl
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_C As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioBase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAumento))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsAumento = New DsAumento
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daSubFamilia = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daFamilia = New System.Data.SqlClient.SqlDataAdapter
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.txtCodigoFamilia = New System.Windows.Forms.TextBox
        Me.txtDescripciónFamilia = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtCedulaUsuario = New System.Windows.Forms.TextBox
        Me.gbFamilia = New System.Windows.Forms.GroupBox
        Me.gbAumentosSubFamilia = New System.Windows.Forms.GroupBox
        Me.txtDSubFamilia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCSubFamilia = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBSubFamilia = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtASubFamilia = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCostoSubFamilia = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtBaseSubFamilia = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCostoFamilia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBaseFamilia = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbSubFamilia = New System.Windows.Forms.GroupBox
        Me.txtDescripciónSubFamilia = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCodSubFamilia = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.gbAumentosFamilia = New System.Windows.Forms.GroupBox
        Me.txtDFamilia = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCFamilia = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBFamilia = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAFamilia = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbOpcionAumento = New System.Windows.Forms.GroupBox
        Me.opPorSubFamilia = New System.Windows.Forms.RadioButton
        Me.opPorFamilia = New System.Windows.Forms.RadioButton
        Me.Label19 = New System.Windows.Forms.Label
        Me.daInventario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.dgInventario = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecioBase = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCosto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_A = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_B = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_C = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio_D = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.DsAumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbFamilia.SuspendLayout()
        Me.gbAumentosSubFamilia.SuspendLayout()
        Me.gbSubFamilia.SuspendLayout()
        Me.gbAumentosFamilia.SuspendLayout()
        Me.gbOpcionAumento.SuspendLayout()
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 412)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(738, 52)
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(738, 32)
        Me.TituloModulo.TabIndex = 52
        Me.TituloModulo.Text = "Aumentos a Categorías"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(610, 506)
        Me.DataNavigator.Name = "DataNavigator"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESERVER;packet size=4096;integrated security=SSPI;data source=SE" & _
        "ESERVER;persist security info=False;initial catalog=Seepos"
        '
        'DsAumento
        '
        Me.DsAumento.DataSetName = "dsAumento"
        Me.DsAumento.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodigoFamilia, SubCodigo, Codigo, Descripcion, Observaciones FROM SubFamil" & _
        "ias"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO SubFamilias(CodigoFamilia, SubCodigo, Codigo, Descripcion, Observacio" & _
        "nes) VALUES (@CodigoFamilia, @SubCodigo, @Codigo, @Descripcion, @Observaciones);" & _
        " SELECT CodigoFamilia, SubCodigo, Codigo, Descripcion, Observaciones FROM SubFam" & _
        "ilias WHERE (Codigo = @Codigo)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoFamilia", System.Data.SqlDbType.Int, 4, "CodigoFamilia"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubCodigo", System.Data.SqlDbType.Int, 4, "SubCodigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 10, "Codigo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE SubFamilias SET CodigoFamilia = @CodigoFamilia, SubCodigo = @SubCodigo, Co" & _
        "digo = @Codigo, Descripcion = @Descripcion, Observaciones = @Observaciones WHERE" & _
        " (Codigo = @Original_Codigo) AND (CodigoFamilia = @Original_CodigoFamilia) AND (" & _
        "Descripcion = @Original_Descripcion) AND (Observaciones = @Original_Observacione" & _
        "s) AND (SubCodigo = @Original_SubCodigo); SELECT CodigoFamilia, SubCodigo, Codig" & _
        "o, Descripcion, Observaciones FROM SubFamilias WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoFamilia", System.Data.SqlDbType.Int, 4, "CodigoFamilia"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SubCodigo", System.Data.SqlDbType.Int, 4, "SubCodigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 10, "Codigo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoFamilia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubCodigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubCodigo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM SubFamilias WHERE (Codigo = @Original_Codigo) AND (CodigoFamilia = @O" & _
        "riginal_CodigoFamilia) AND (Descripcion = @Original_Descripcion) AND (Observacio" & _
        "nes = @Original_Observaciones) AND (SubCodigo = @Original_SubCodigo)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoFamilia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoFamilia", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SubCodigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SubCodigo", System.Data.DataRowVersion.Original, Nothing))
        '
        'daSubFamilia
        '
        Me.daSubFamilia.DeleteCommand = Me.SqlDeleteCommand2
        Me.daSubFamilia.InsertCommand = Me.SqlInsertCommand2
        Me.daSubFamilia.SelectCommand = Me.SqlSelectCommand2
        Me.daSubFamilia.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SubFamilias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoFamilia", "CodigoFamilia"), New System.Data.Common.DataColumnMapping("SubCodigo", "SubCodigo"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.daSubFamilia.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Codigo, Descripcion, Observaciones FROM Familia"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Familia(Codigo, Descripcion, Observaciones) VALUES (@Codigo, @Descrip" & _
        "cion, @Observaciones); SELECT Codigo, Descripcion, Observaciones FROM Familia WH" & _
        "ERE (Codigo = @Codigo)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Familia SET Codigo = @Codigo, Descripcion = @Descripcion, Observaciones = " & _
        "@Observaciones WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Original_De" & _
        "scripcion) AND (Observaciones = @Original_Observaciones); SELECT Codigo, Descrip" & _
        "cion, Observaciones FROM Familia WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 150, "Descripcion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Familia WHERE (Codigo = @Original_Codigo) AND (Descripcion = @Origina" & _
        "l_Descripcion) AND (Observaciones = @Original_Observaciones)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'daFamilia
        '
        Me.daFamilia.DeleteCommand = Me.SqlDeleteCommand3
        Me.daFamilia.InsertCommand = Me.SqlInsertCommand3
        Me.daFamilia.SelectCommand = Me.SqlSelectCommand3
        Me.daFamilia.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Familia", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.daFamilia.UpdateCommand = Me.SqlUpdateCommand3
        '
        'lblCodigo
        '
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCodigo.Location = New System.Drawing.Point(8, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(96, 16)
        Me.lblCodigo.TabIndex = 50
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtCodigoFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(8, 32)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.ReadOnly = True
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(96, 13)
        Me.txtCodigoFamilia.TabIndex = 50
        Me.txtCodigoFamilia.Text = ""
        '
        'txtDescripciónFamilia
        '
        Me.txtDescripciónFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripciónFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Descripcion"))
        Me.txtDescripciónFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripciónFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtDescripciónFamilia.Location = New System.Drawing.Point(120, 32)
        Me.txtDescripciónFamilia.Name = "txtDescripciónFamilia"
        Me.txtDescripciónFamilia.ReadOnly = True
        Me.txtDescripciónFamilia.Size = New System.Drawing.Size(424, 13)
        Me.txtDescripciónFamilia.TabIndex = 50
        Me.txtDescripciónFamilia.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(120, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Descripción"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.txtClave)
        Me.Panel1.Controls.Add(Me.txtNombreUsuario)
        Me.Panel1.Controls.Add(Me.txtCedulaUsuario)
        Me.Panel1.Location = New System.Drawing.Point(445, 447)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(291, 16)
        Me.Panel1.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(-8, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.ForeColor = System.Drawing.Color.Blue
        Me.txtClave.Location = New System.Drawing.Point(64, 0)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(56, 13)
        Me.txtClave.TabIndex = 1
        Me.txtClave.Text = ""
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(121, 0)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.txtNombreUsuario.TabIndex = 170
        Me.txtNombreUsuario.Text = ""
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtCedulaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCedulaUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCedulaUsuario.Enabled = False
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(216, 16)
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(72, 13)
        Me.txtCedulaUsuario.TabIndex = 170
        Me.txtCedulaUsuario.Text = ""
        '
        'gbFamilia
        '
        Me.gbFamilia.Controls.Add(Me.lblCodigo)
        Me.gbFamilia.Controls.Add(Me.Label1)
        Me.gbFamilia.Controls.Add(Me.txtDescripciónFamilia)
        Me.gbFamilia.Controls.Add(Me.txtCodigoFamilia)
        Me.gbFamilia.Enabled = False
        Me.gbFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbFamilia.Location = New System.Drawing.Point(8, 40)
        Me.gbFamilia.Name = "gbFamilia"
        Me.gbFamilia.Size = New System.Drawing.Size(552, 88)
        Me.gbFamilia.TabIndex = 50
        Me.gbFamilia.TabStop = False
        Me.gbFamilia.Text = "Familia"
        Me.gbFamilia.Visible = False
        '
        'gbAumentosSubFamilia
        '
        Me.gbAumentosSubFamilia.BackColor = System.Drawing.Color.Transparent
        Me.gbAumentosSubFamilia.Controls.Add(Me.txtDSubFamilia)
        Me.gbAumentosSubFamilia.Controls.Add(Me.Label3)
        Me.gbAumentosSubFamilia.Controls.Add(Me.txtCSubFamilia)
        Me.gbAumentosSubFamilia.Controls.Add(Me.Label7)
        Me.gbAumentosSubFamilia.Controls.Add(Me.txtBSubFamilia)
        Me.gbAumentosSubFamilia.Controls.Add(Me.Label12)
        Me.gbAumentosSubFamilia.Controls.Add(Me.txtASubFamilia)
        Me.gbAumentosSubFamilia.Controls.Add(Me.Label13)
        Me.gbAumentosSubFamilia.Controls.Add(Me.txtCostoSubFamilia)
        Me.gbAumentosSubFamilia.Controls.Add(Me.Label14)
        Me.gbAumentosSubFamilia.Controls.Add(Me.txtBaseSubFamilia)
        Me.gbAumentosSubFamilia.Controls.Add(Me.Label15)
        Me.gbAumentosSubFamilia.Enabled = False
        Me.gbAumentosSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAumentosSubFamilia.Location = New System.Drawing.Point(19, 104)
        Me.gbAumentosSubFamilia.Name = "gbAumentosSubFamilia"
        Me.gbAumentosSubFamilia.Size = New System.Drawing.Size(536, 64)
        Me.gbAumentosSubFamilia.TabIndex = 0
        Me.gbAumentosSubFamilia.TabStop = False
        Me.gbAumentosSubFamilia.Text = "Aumento Porcentual"
        Me.gbAumentosSubFamilia.Visible = False
        '
        'txtDSubFamilia
        '
        Me.txtDSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtDSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtDSubFamilia.Location = New System.Drawing.Point(456, 32)
        Me.txtDSubFamilia.Name = "txtDSubFamilia"
        Me.txtDSubFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtDSubFamilia.TabIndex = 6
        Me.txtDSubFamilia.Text = "0.00"
        Me.txtDSubFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(456, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "% Precio D"
        '
        'txtCSubFamilia
        '
        Me.txtCSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtCSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtCSubFamilia.Location = New System.Drawing.Point(376, 32)
        Me.txtCSubFamilia.Name = "txtCSubFamilia"
        Me.txtCSubFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtCSubFamilia.TabIndex = 5
        Me.txtCSubFamilia.Text = "0.00"
        Me.txtCSubFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(376, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "% Precio C"
        '
        'txtBSubFamilia
        '
        Me.txtBSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtBSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtBSubFamilia.Location = New System.Drawing.Point(296, 32)
        Me.txtBSubFamilia.Name = "txtBSubFamilia"
        Me.txtBSubFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtBSubFamilia.TabIndex = 4
        Me.txtBSubFamilia.Text = "0.00"
        Me.txtBSubFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(296, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "% Precio B"
        '
        'txtASubFamilia
        '
        Me.txtASubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtASubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtASubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtASubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtASubFamilia.Location = New System.Drawing.Point(216, 32)
        Me.txtASubFamilia.Name = "txtASubFamilia"
        Me.txtASubFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtASubFamilia.TabIndex = 3
        Me.txtASubFamilia.Text = "0.00"
        Me.txtASubFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(216, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "% Precio A"
        '
        'txtCostoSubFamilia
        '
        Me.txtCostoSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtCostoSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtCostoSubFamilia.Location = New System.Drawing.Point(16, 32)
        Me.txtCostoSubFamilia.Name = "txtCostoSubFamilia"
        Me.txtCostoSubFamilia.Size = New System.Drawing.Size(88, 13)
        Me.txtCostoSubFamilia.TabIndex = 1
        Me.txtCostoSubFamilia.Text = "0.00"
        Me.txtCostoSubFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(16, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "% Precio Costo "
        '
        'txtBaseSubFamilia
        '
        Me.txtBaseSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBaseSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtBaseSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtBaseSubFamilia.Location = New System.Drawing.Point(112, 32)
        Me.txtBaseSubFamilia.Name = "txtBaseSubFamilia"
        Me.txtBaseSubFamilia.Size = New System.Drawing.Size(96, 13)
        Me.txtBaseSubFamilia.TabIndex = 2
        Me.txtBaseSubFamilia.Text = "0.00"
        Me.txtBaseSubFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Location = New System.Drawing.Point(112, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "% Precio Base"
        '
        'txtCostoFamilia
        '
        Me.txtCostoFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCostoFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtCostoFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtCostoFamilia.Location = New System.Drawing.Point(16, 32)
        Me.txtCostoFamilia.Name = "txtCostoFamilia"
        Me.txtCostoFamilia.Size = New System.Drawing.Size(88, 13)
        Me.txtCostoFamilia.TabIndex = 0
        Me.txtCostoFamilia.Text = "0.00"
        Me.txtCostoFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(16, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "% Precio Costo "
        '
        'txtBaseFamilia
        '
        Me.txtBaseFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBaseFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtBaseFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtBaseFamilia.Location = New System.Drawing.Point(112, 32)
        Me.txtBaseFamilia.Name = "txtBaseFamilia"
        Me.txtBaseFamilia.Size = New System.Drawing.Size(96, 13)
        Me.txtBaseFamilia.TabIndex = 1
        Me.txtBaseFamilia.Text = "0.00"
        Me.txtBaseFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(112, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "% Precio Base"
        '
        'gbSubFamilia
        '
        Me.gbSubFamilia.BackColor = System.Drawing.Color.Transparent
        Me.gbSubFamilia.Controls.Add(Me.txtDescripciónSubFamilia)
        Me.gbSubFamilia.Controls.Add(Me.Label4)
        Me.gbSubFamilia.Controls.Add(Me.txtCodSubFamilia)
        Me.gbSubFamilia.Controls.Add(Me.Label5)
        Me.gbSubFamilia.Enabled = False
        Me.gbSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSubFamilia.ForeColor = System.Drawing.Color.MidnightBlue
        Me.gbSubFamilia.Location = New System.Drawing.Point(8, 40)
        Me.gbSubFamilia.Name = "gbSubFamilia"
        Me.gbSubFamilia.Size = New System.Drawing.Size(551, 88)
        Me.gbSubFamilia.TabIndex = 52
        Me.gbSubFamilia.TabStop = False
        Me.gbSubFamilia.Text = "Sub-Familia"
        '
        'txtDescripciónSubFamilia
        '
        Me.txtDescripciónSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripciónSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "SubFamilias.Descripcion"))
        Me.txtDescripciónSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripciónSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtDescripciónSubFamilia.Location = New System.Drawing.Point(120, 32)
        Me.txtDescripciónSubFamilia.Name = "txtDescripciónSubFamilia"
        Me.txtDescripciónSubFamilia.ReadOnly = True
        Me.txtDescripciónSubFamilia.Size = New System.Drawing.Size(424, 13)
        Me.txtDescripciónSubFamilia.TabIndex = 52
        Me.txtDescripciónSubFamilia.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(120, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(424, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Descripción"
        '
        'txtCodSubFamilia
        '
        Me.txtCodSubFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodSubFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "SubFamilias.Codigo"))
        Me.txtCodSubFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodSubFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtCodSubFamilia.Location = New System.Drawing.Point(8, 32)
        Me.txtCodSubFamilia.Name = "txtCodSubFamilia"
        Me.txtCodSubFamilia.ReadOnly = True
        Me.txtCodSubFamilia.Size = New System.Drawing.Size(96, 13)
        Me.txtCodSubFamilia.TabIndex = 52
        Me.txtCodSubFamilia.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Código"
        '
        'gbAumentosFamilia
        '
        Me.gbAumentosFamilia.Controls.Add(Me.txtDFamilia)
        Me.gbAumentosFamilia.Controls.Add(Me.Label11)
        Me.gbAumentosFamilia.Controls.Add(Me.txtCFamilia)
        Me.gbAumentosFamilia.Controls.Add(Me.Label10)
        Me.gbAumentosFamilia.Controls.Add(Me.txtBFamilia)
        Me.gbAumentosFamilia.Controls.Add(Me.Label9)
        Me.gbAumentosFamilia.Controls.Add(Me.txtAFamilia)
        Me.gbAumentosFamilia.Controls.Add(Me.Label8)
        Me.gbAumentosFamilia.Controls.Add(Me.txtCostoFamilia)
        Me.gbAumentosFamilia.Controls.Add(Me.Label6)
        Me.gbAumentosFamilia.Controls.Add(Me.txtBaseFamilia)
        Me.gbAumentosFamilia.Controls.Add(Me.Label2)
        Me.gbAumentosFamilia.Enabled = False
        Me.gbAumentosFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAumentosFamilia.Location = New System.Drawing.Point(19, 104)
        Me.gbAumentosFamilia.Name = "gbAumentosFamilia"
        Me.gbAumentosFamilia.Size = New System.Drawing.Size(536, 64)
        Me.gbAumentosFamilia.TabIndex = 0
        Me.gbAumentosFamilia.TabStop = False
        Me.gbAumentosFamilia.Text = "Aumento Porcentual"
        '
        'txtDFamilia
        '
        Me.txtDFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtDFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtDFamilia.Location = New System.Drawing.Point(456, 32)
        Me.txtDFamilia.Name = "txtDFamilia"
        Me.txtDFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtDFamilia.TabIndex = 5
        Me.txtDFamilia.Text = "0.00"
        Me.txtDFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(456, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "% Precio D"
        '
        'txtCFamilia
        '
        Me.txtCFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtCFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtCFamilia.Location = New System.Drawing.Point(376, 32)
        Me.txtCFamilia.Name = "txtCFamilia"
        Me.txtCFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtCFamilia.TabIndex = 4
        Me.txtCFamilia.Text = "0.00"
        Me.txtCFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(376, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "% Precio C"
        '
        'txtBFamilia
        '
        Me.txtBFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtBFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtBFamilia.Location = New System.Drawing.Point(296, 32)
        Me.txtBFamilia.Name = "txtBFamilia"
        Me.txtBFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtBFamilia.TabIndex = 3
        Me.txtBFamilia.Text = "0.00"
        Me.txtBFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(296, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "% Precio B"
        '
        'txtAFamilia
        '
        Me.txtAFamilia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAFamilia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAumento, "Familia.Codigo"))
        Me.txtAFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAFamilia.ForeColor = System.Drawing.Color.Blue
        Me.txtAFamilia.Location = New System.Drawing.Point(216, 32)
        Me.txtAFamilia.Name = "txtAFamilia"
        Me.txtAFamilia.Size = New System.Drawing.Size(72, 13)
        Me.txtAFamilia.TabIndex = 2
        Me.txtAFamilia.Text = "0.00"
        Me.txtAFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(216, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "% Precio A"
        '
        'gbOpcionAumento
        '
        Me.gbOpcionAumento.BackColor = System.Drawing.Color.Transparent
        Me.gbOpcionAumento.Controls.Add(Me.opPorSubFamilia)
        Me.gbOpcionAumento.Controls.Add(Me.opPorFamilia)
        Me.gbOpcionAumento.Controls.Add(Me.Label19)
        Me.gbOpcionAumento.Enabled = False
        Me.gbOpcionAumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOpcionAumento.ForeColor = System.Drawing.Color.RoyalBlue
        Me.gbOpcionAumento.Location = New System.Drawing.Point(568, 48)
        Me.gbOpcionAumento.Name = "gbOpcionAumento"
        Me.gbOpcionAumento.Size = New System.Drawing.Size(160, 72)
        Me.gbOpcionAumento.TabIndex = 52
        Me.gbOpcionAumento.TabStop = False
        '
        'opPorSubFamilia
        '
        Me.opPorSubFamilia.Location = New System.Drawing.Point(4, 44)
        Me.opPorSubFamilia.Name = "opPorSubFamilia"
        Me.opPorSubFamilia.Size = New System.Drawing.Size(108, 16)
        Me.opPorSubFamilia.TabIndex = 52
        Me.opPorSubFamilia.Text = "Por Sub-Familia"
        '
        'opPorFamilia
        '
        Me.opPorFamilia.Location = New System.Drawing.Point(4, 21)
        Me.opPorFamilia.Name = "opPorFamilia"
        Me.opPorFamilia.Size = New System.Drawing.Size(124, 16)
        Me.opPorFamilia.TabIndex = 52
        Me.opPorFamilia.Text = "Por Familia"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(16, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 16)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Tipo de Aumento"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'daInventario
        '
        Me.daInventario.DeleteCommand = Me.SqlDeleteCommand1
        Me.daInventario.InsertCommand = Me.SqlInsertCommand1
        Me.daInventario.SelectCommand = Me.SqlSelectCommand1
        Me.daInventario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inventario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Costo", "Costo"), New System.Data.Common.DataColumnMapping("Precio_A", "Precio_A"), New System.Data.Common.DataColumnMapping("Precio_B", "Precio_B"), New System.Data.Common.DataColumnMapping("Precio_C", "Precio_C"), New System.Data.Common.DataColumnMapping("Precio_D", "Precio_D"), New System.Data.Common.DataColumnMapping("PrecioBase", "PrecioBase"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.daInventario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Inventario WHERE (Codigo = @Original_Codigo) AND (Costo = @Original_C" & _
        "osto) AND (Descripcion = @Original_Descripcion) AND (PrecioBase = @Original_Prec" & _
        "ioBase) AND (Precio_A = @Original_Precio_A) AND (Precio_B = @Original_Precio_B) " & _
        "AND (Precio_C = @Original_Precio_C) AND (Precio_D = @Original_Precio_D)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrecioBase", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrecioBase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_A", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_A", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_B", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_B", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_C", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_C", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_D", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_D", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Inventario(Codigo, Costo, Precio_A, Precio_B, Precio_C, Precio_D, Pre" & _
        "cioBase, Descripcion) VALUES (@Codigo, @Costo, @Precio_A, @Precio_B, @Precio_C, " & _
        "@Precio_D, @PrecioBase, @Descripcion); SELECT Codigo, Costo, Precio_A, Precio_B," & _
        " Precio_C, Precio_D, PrecioBase, Descripcion FROM Inventario WHERE (Codigo = @Co" & _
        "digo)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrecioBase", System.Data.SqlDbType.Float, 8, "PrecioBase"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Codigo, Costo, Precio_A, Precio_B, Precio_C, Precio_D, PrecioBase, Descrip" & _
        "cion FROM Inventario"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Inventario SET Codigo = @Codigo, Costo = @Costo, Precio_A = @Precio_A, Pre" & _
        "cio_B = @Precio_B, Precio_C = @Precio_C, Precio_D = @Precio_D, PrecioBase = @Pre" & _
        "cioBase, Descripcion = @Descripcion WHERE (Codigo = @Original_Codigo) AND (Costo" & _
        " = @Original_Costo) AND (Descripcion = @Original_Descripcion) AND (PrecioBase = " & _
        "@Original_PrecioBase) AND (Precio_A = @Original_Precio_A) AND (Precio_B = @Origi" & _
        "nal_Precio_B) AND (Precio_C = @Original_Precio_C) AND (Precio_D = @Original_Prec" & _
        "io_D); SELECT Codigo, Costo, Precio_A, Precio_B, Precio_C, Precio_D, PrecioBase," & _
        " Descripcion FROM Inventario WHERE (Codigo = @Codigo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.BigInt, 8, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Costo", System.Data.SqlDbType.Float, 8, "Costo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_A", System.Data.SqlDbType.Float, 8, "Precio_A"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_B", System.Data.SqlDbType.Float, 8, "Precio_B"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_C", System.Data.SqlDbType.Float, 8, "Precio_C"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Precio_D", System.Data.SqlDbType.Float, 8, "Precio_D"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PrecioBase", System.Data.SqlDbType.Float, 8, "PrecioBase"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 255, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Costo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Costo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PrecioBase", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PrecioBase", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_A", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_A", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_B", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_B", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_C", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_C", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Precio_D", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Precio_D", System.Data.DataRowVersion.Original, Nothing))
        '
        'dgInventario
        '
        Me.dgInventario.BackColor = System.Drawing.Color.Transparent
        Me.dgInventario.DataMember = "Inventario"
        Me.dgInventario.DataSource = Me.DsAumento
        '
        'dgInventario.EmbeddedNavigator
        '
        Me.dgInventario.EmbeddedNavigator.Name = ""
        Me.dgInventario.Location = New System.Drawing.Point(8, 176)
        Me.dgInventario.MainView = Me.GridView1
        Me.dgInventario.Name = "dgInventario"
        Me.dgInventario.Size = New System.Drawing.Size(720, 232)
        Me.dgInventario.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.dgInventario.TabIndex = 70
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colPrecioBase, Me.colCosto, Me.colPrecio_A, Me.colPrecio_B, Me.colPrecio_C, Me.colPrecio_D})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
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
        Me.colCodigo.Width = 88
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
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
        Me.colDescripcion.Width = 180
        '
        'colPrecioBase
        '
        Me.colPrecioBase.Caption = "PrecioBase"
        Me.colPrecioBase.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecioBase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioBase.FieldName = "PrecioBase"
        Me.colPrecioBase.Name = "colPrecioBase"
        Me.colPrecioBase.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecioBase.VisibleIndex = 2
        Me.colPrecioBase.Width = 72
        '
        'colCosto
        '
        Me.colCosto.Caption = "Costo"
        Me.colCosto.DisplayFormat.FormatString = "#,#0.00"
        Me.colCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCosto.FieldName = "Costo"
        Me.colCosto.Name = "colCosto"
        Me.colCosto.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCosto.VisibleIndex = 3
        Me.colCosto.Width = 72
        '
        'colPrecio_A
        '
        Me.colPrecio_A.Caption = "Precio_A"
        Me.colPrecio_A.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_A.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_A.FieldName = "Precio_A"
        Me.colPrecio_A.Name = "colPrecio_A"
        Me.colPrecio_A.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_A.VisibleIndex = 4
        Me.colPrecio_A.Width = 72
        '
        'colPrecio_B
        '
        Me.colPrecio_B.Caption = "Precio_B"
        Me.colPrecio_B.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_B.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_B.FieldName = "Precio_B"
        Me.colPrecio_B.Name = "colPrecio_B"
        Me.colPrecio_B.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_B.VisibleIndex = 5
        Me.colPrecio_B.Width = 72
        '
        'colPrecio_C
        '
        Me.colPrecio_C.Caption = "Precio_C"
        Me.colPrecio_C.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_C.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_C.FieldName = "Precio_C"
        Me.colPrecio_C.Name = "colPrecio_C"
        Me.colPrecio_C.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_C.VisibleIndex = 6
        Me.colPrecio_C.Width = 72
        '
        'colPrecio_D
        '
        Me.colPrecio_D.Caption = "Precio_D"
        Me.colPrecio_D.DisplayFormat.FormatString = "#,#0.00"
        Me.colPrecio_D.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio_D.FieldName = "Precio_D"
        Me.colPrecio_D.Name = "colPrecio_D"
        Me.colPrecio_D.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colPrecio_D.VisibleIndex = 7
        Me.colPrecio_D.Width = 78
        '
        'frmAumento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(738, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgInventario)
        Me.Controls.Add(Me.gbOpcionAumento)
        Me.Controls.Add(Me.gbAumentosSubFamilia)
        Me.Controls.Add(Me.gbAumentosFamilia)
        Me.Controls.Add(Me.gbSubFamilia)
        Me.Controls.Add(Me.gbFamilia)
        Me.Name = "frmAumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aumentos"
        Me.Controls.SetChildIndex(Me.gbFamilia, 0)
        Me.Controls.SetChildIndex(Me.gbSubFamilia, 0)
        Me.Controls.SetChildIndex(Me.gbAumentosFamilia, 0)
        Me.Controls.SetChildIndex(Me.gbAumentosSubFamilia, 0)
        Me.Controls.SetChildIndex(Me.gbOpcionAumento, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.dgInventario, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.DsAumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gbFamilia.ResumeLayout(False)
        Me.gbAumentosSubFamilia.ResumeLayout(False)
        Me.gbSubFamilia.ResumeLayout(False)
        Me.gbAumentosFamilia.ResumeLayout(False)
        Me.gbOpcionAumento.ResumeLayout(False)
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable "                     'Definicion de Variable /Albert Estrada\
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Dim usua As Usuario_Logeado
#End Region

    Private Sub frmAumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS

            cConexion = New Conexion
            sqlConexion = cConexion.Conectar

        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If e.KeyCode = Keys.Enter Then
            If txtClave.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Cedula, Nombre from Usuarios where Clave_Interna ='" & txtClave.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    Me.txtClave.Text = ""
                    txtClave.Focus()
                End If
                While rs.Read
                    Try
                        Me.txtNombreUsuario.Text = rs!nombre
                        Me.txtCedulaUsuario.Text = rs!cedula

                        PMU = VSM(rs!cedula, Me.Name) 'Carga los privilegios del usuario con el modulo 

                        Me.txtClave.Enabled = False
                        Me.gbOpcionAumento.Enabled = True
                        Me.opPorFamilia.Checked = True
                        Me.opPorFamilia.Focus()

                    Catch eEndEdit As System.Data.NoNullAllowedException
                        System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtClave.Focus()
            End If
        End If
    End Sub

    Private Sub opPorFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opPorFamilia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.gbFamilia.Visible = True
            Me.gbFamilia.Enabled = True
            Me.gbSubFamilia.Enabled = False
            Me.gbSubFamilia.Visible = False
            Me.gbAumentosSubFamilia.Enabled = False
            Me.gbAumentosSubFamilia.Visible = False
            Me.gbAumentosFamilia.Visible = True
            Me.gbOpcionAumento.Enabled = False

            Me.txtCodigoFamilia.Focus()
        End If
    End Sub

    Private Sub opPorSubFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opPorSubFamilia.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.gbFamilia.Enabled = False
            Me.gbFamilia.Visible = False
            Me.gbAumentosFamilia.Enabled = False
            Me.gbAumentosFamilia.Visible = False
            Me.gbSubFamilia.Visible = True
            Me.gbSubFamilia.Enabled = True
            Me.gbAumentosSubFamilia.Visible = True
            Me.gbOpcionAumento.Enabled = False

            Me.txtCodSubFamilia.Focus()
        End If
    End Sub

    Private Sub txtCodigoFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoFamilia.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.txtCodigoFamilia.Text = cFunciones.BuscarDatos("SELECT codigo as Código, descripcion as Familia FROM Familia", "descripcion")
            CargarInformacionFamilia(txtCodigoFamilia.Text)
        End If
        If e.KeyCode = Keys.Enter Then
            CargarInformacionFamilia(txtCodigoFamilia.Text)
        End If
    End Sub

    Private Sub CargarInformacionFamilia(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Codigo, Descripcion from Familia where Codigo ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigoFamilia.Text = rs!Codigo
                    txtDescripciónFamilia.Text = rs!descripcion
                    Me.gbAumentosFamilia.Enabled = True
                    llenarGrid()
                    Me.ToolBar1.Buttons(2).Enabled = True
                    txtCostoFamilia.Focus()
                Else
                    MsgBox("La identificación de la familia no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCodigoFamilia.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.sQlconexion)
        End If
    End Sub

    Private Sub llenarGrid()
        Dim rs As SqlDataReader
        Dim familia, i, tam As Integer
        Dim subfamilia As String
        Dim costo As Double

        If txtCodigoFamilia.Text <> "" Then
            familia = Trim(Me.txtCodigoFamilia.Text)

            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Codigo from subfamilias where Codigofamilia =" & familia)
            Try
                If rs.Read Then
                    subfamilia = rs!Codigo
                    LlenarInventario(subfamilia)
                Else
                    MsgBox("La identificación de la familia no se encuentra", MsgBoxStyle.Information, "Atención...")
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As SystemException
                            MsgBox(EX.Message ,MsgBoxStyle.Information ,"Atención...")
            End Try
        Else
            subfamilia = Trim(Me.txtCodSubFamilia.Text)
            LlenarInventario(subfamilia)
        End If
    End Sub

    Private Sub registrar()
        Try
            recorrer()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function LlenarInventario(ByVal Id As String)
        Dim cnnv As SqlConnection = Nothing

        ' Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR INVENTARIO''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Me.SqlConnection1.ConnectionString
            cnnv = New SqlConnection(sConn)
            cnnv.Open()

            ' Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT Codigo, Descripcion, Costo, PrecioBase, Precio_A, Precio_B, Precio_C, Precio_D FROM Inventario WHERE SubFamilia = @Id"

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90

            ' Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
            cmdv.Parameters("@Id").Value = Id

            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmdv

            ' Llenamos la tabla
            Me.DsAumento.Inventario.Clear()
            da.Fill(Me.DsAumento, "Inventario")

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

    Function recorrer()
        Dim codigo, i As Integer
        Dim PCosto, PBase, PA, PB, PC, PD, Costo, Base, A, B, C, D, Acosto, Abase, AA, AB, AC, AD As Double

        i = 0

        Try
            If Me.opPorFamilia.Checked = True Then
                Costo = CDbl(Me.txtCostoFamilia.Text)
                Base = CDbl(Me.txtBaseFamilia.Text)
                A = CDbl(Me.txtAFamilia.Text)
                B = CDbl(Me.txtBFamilia.Text)
                C = CDbl(Me.txtCFamilia.Text)
                D = CDbl(Me.txtDFamilia.Text)
            ElseIf opPorSubFamilia.Checked = True Then
                Costo = CDbl(Me.txtCostoSubFamilia.Text)
                Base = CDbl(Me.txtBaseSubFamilia.Text)
                A = CDbl(Me.txtASubFamilia.Text)
                B = CDbl(Me.txtBSubFamilia.Text)
                C = CDbl(Me.txtCSubFamilia.Text)
                D = CDbl(Me.txtDSubFamilia.Text)
            End If

            For i = 0 To Me.BindingContext(Me.DsAumento.Inventario).Count - 1

                Me.BindingContext(Me.DsAumento.Inventario).Position = i

                codigo = Me.DsAumento.Inventario.Rows(i).Item("Codigo")
                PCosto = Me.DsAumento.Inventario.Rows(i).Item("Costo")
                PBase = Me.DsAumento.Inventario.Rows(i).Item("PrecioBase")
                PA = Me.DsAumento.Inventario.Rows(i).Item("Precio_A")
                PB = Me.DsAumento.Inventario.Rows(i).Item("Precio_B")
                PC = Me.DsAumento.Inventario.Rows(i).Item("Precio_C")
                PD = Me.DsAumento.Inventario.Rows(i).Item("Precio_D")

                Acosto = PCosto + (PCosto * (Costo / 100))
                Abase = PBase + (PBase * (Base / 100))
                AA = PA + (PA * (A / 100))
                AB = PB + (PB * (B / 100))
                AC = PC + (PC * (C / 100))
                AD = PD + (PD * (D / 100))

                Me.DsAumento.Inventario.Rows(i).Item("costo") = Acosto
                Me.DsAumento.Inventario.Rows(i).Item("PrecioBase") = Abase
                Me.DsAumento.Inventario.Rows(i).Item("Precio_A") = AA
                Me.DsAumento.Inventario.Rows(i).Item("Precio_B") = AB
                Me.DsAumento.Inventario.Rows(i).Item("Precio_C") = AC
                Me.DsAumento.Inventario.Rows(i).Item("Precio_D") = AD

                Me.BindingContext(Me.DsAumento, "Inventario").EndCurrentEdit()
            Next i

            Me.daInventario.Update(Me.DsAumento, "Inventario")

            MsgBox("Aumentos Registrados Satisfactoriamente", MsgBoxStyle.Information)

            Me.ToolBar1.Buttons(2).Enabled = False
        Catch ex As SystemException
                        MsgBox(EX.Message ,MsgBoxStyle.Information ,"Atención...")
        End Try
    End Function

    Private Sub txtCodSubFamilia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodSubFamilia.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.txtCodSubFamilia.Text = cFunciones.BuscarDatos("SELECT codigo as Código, descripcion as Familia FROM subFamilias", "descripcion")
            CargarInformacionSubFamilia(txtCodSubFamilia.Text)
        End If
        If e.KeyCode = Keys.Enter Then
            CargarInformacionSubFamilia(txtCodSubFamilia.Text)
        End If
    End Sub

    Private Sub CargarInformacionSubFamilia(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Codigo, Descripcion from SubFamilias where Codigo ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodSubFamilia.Text = rs!Codigo
                    txtDescripciónSubFamilia.Text = rs!descripcion
                    Me.gbAumentosSubFamilia.Enabled = True
                    Me.ToolBar1.Buttons(2).Enabled = True
                    llenarGrid()
                    Me.txtCostoSubFamilia.Focus()
                Else
                    MsgBox("La identificación de la Sub-Familia no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCodigoFamilia.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.sQlconexion)
        End If
    End Sub

    Private Sub txtCostoFamilia_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCostoFamilia.GotFocus, txtBaseFamilia.GotFocus, txtAFamilia.GotFocus, txtBFamilia.GotFocus, txtCFamilia.GotFocus, txtDFamilia.GotFocus, txtCodSubFamilia.GotFocus, txtBaseSubFamilia.GotFocus, txtASubFamilia.GotFocus, txtBSubFamilia.GotFocus, txtCSubFamilia.GotFocus, txtDSubFamilia.GotFocus
        sender.SelectAll()
    End Sub

    Private Sub txtCostoFamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoFamilia.KeyPress, txtBaseFamilia.KeyPress, txtAFamilia.KeyPress, txtBFamilia.KeyPress, txtCFamilia.KeyPress, txtDFamilia.KeyPress, txtCostoSubFamilia.KeyPress, txtBaseSubFamilia.KeyPress, txtASubFamilia.KeyPress, txtBSubFamilia.KeyPress, txtCSubFamilia.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then SendKeys.Send("{TAB}")

        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : If PMU.Execute Then nuevos() Else MsgBox("No tiene permiso para ejecutar esta acción...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Update Then registrar() Else MsgBox("No tiene permiso para registrar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 7 : If MessageBox.Show("¿Desea Cerrar el modulo actual..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
        End Select
    End Sub

    Private Sub nuevos()
        Me.gbFamilia.Enabled = False
        Me.gbAumentosFamilia.Enabled = False

        Me.DsAumento.Inventario.Clear()
        Me.dgInventario.RefreshDataSource()
        Me.txtCodigoFamilia.Text = ""
        Me.txtDescripciónFamilia.Text = ""
        Me.txtCostoFamilia.Text = 0.0
        Me.txtBaseFamilia.Text = 0.0
        Me.txtAFamilia.Text = 0.0
        Me.txtBFamilia.Text = 0.0
        Me.txtCFamilia.Text = 0.0
        Me.txtDFamilia.Text = 0.0

        Me.gbSubFamilia.Enabled = False
        Me.gbAumentosSubFamilia.Enabled = False

        Me.txtCodSubFamilia.Text = ""
        Me.txtDescripciónSubFamilia.Text = ""
        Me.txtCostoSubFamilia.Text = 0.0
        Me.txtBaseSubFamilia.Text = 0.0
        Me.txtASubFamilia.Text = 0.0
        Me.txtBSubFamilia.Text = 0.0
        Me.txtCSubFamilia.Text = 0.0
        Me.txtDSubFamilia.Text = 0.0
        Me.txtClave.Enabled = True
        Me.txtClave.Text = ""
        Me.txtNombreUsuario.Text = ""
        Me.txtCedulaUsuario.Text = ""
        Me.txtClave.Focus()
    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub
End Class
