Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReciboAbonos
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daMonedas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsReciboAbonos As DsReciboAbonos
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxOpciones As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbo_caja As System.Windows.Forms.ComboBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReciboAbonos))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.lblTipoCambio = New System.Windows.Forms.Label()
        Me.DsReciboAbonos = New LcPymes_5._2.dsReciboAbonos()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_caja = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxOpciones = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboMonedas = New System.Windows.Forms.ComboBox()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.daMonedas = New System.Data.SqlClient.SqlDataAdapter()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsReciboAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsReciboAbonos, "Moneda.ValorCompra", True))
        Me.lblTipoCambio.Location = New System.Drawing.Point(496, 176)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(100, 23)
        Me.lblTipoCambio.TabIndex = 80
        '
        'DsReciboAbonos
        '
        Me.DsReciboAbonos.DataSetName = "dsReciboAbonos"
        Me.DsReciboAbonos.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsReciboAbonos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisorReporte
        '
        Me.VisorReporte.ActiveViewIndex = -1
        Me.VisorReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorReporte.AutoScroll = True
        Me.VisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.VisorReporte.Location = New System.Drawing.Point(0, 112)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(1020, 428)
        Me.VisorReporte.TabIndex = 82
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 8, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 8, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 8, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 8, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.VarChar, 2, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 8, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 4, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 8, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 2, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.VarChar, 2, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 50, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 4, "CodMonedaCredito"), New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"), New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"), New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"), New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"), New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 8, "Telefono_01"), New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 8, "telefono_02"), New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 8, "fax_01"), New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 8, "fax_02"), New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"), New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.VarChar, 2, "abierto"), New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"), New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"), New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 8, "max_credito"), New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 4, "Plazo_credito"), New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 8, "descuento"), New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 2, "empresa"), New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"), New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.VarChar, 2, "sinrestriccion"), New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"), New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"), New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 50, "agente"), New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 4, "CodMonedaCredito")})
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbo_caja)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbxOpciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMonedas)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1020, 104)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(600, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Caja"
        Me.Label6.Visible = False
        '
        'cbo_caja
        '
        Me.cbo_caja.Items.AddRange(New Object() {"1", "2", "3", "General", "General Mensual"})
        Me.cbo_caja.Location = New System.Drawing.Point(600, 32)
        Me.cbo_caja.Name = "cbo_caja"
        Me.cbo_caja.Size = New System.Drawing.Size(96, 21)
        Me.cbo_caja.TabIndex = 163
        Me.cbo_caja.Text = "General"
        Me.cbo_caja.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.txtCodigo.Location = New System.Drawing.Point(384, 80)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(59, 13)
        Me.txtCodigo.TabIndex = 162
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(456, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 12)
        Me.Label5.TabIndex = 161
        Me.Label5.Text = "Nombre del Cliente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(384, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 12)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Enabled = False
        Me.txtNombre.ForeColor = System.Drawing.Color.Blue
        Me.txtNombre.Location = New System.Drawing.Point(456, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(272, 13)
        Me.txtNombre.TabIndex = 160
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Ver Reporte Según"
        '
        'cbxOpciones
        '
        Me.cbxOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOpciones.Items.AddRange(New Object() {"Recibo de dinero", "Notas de débito", "Notas de crédito"})
        Me.cbxOpciones.Location = New System.Drawing.Point(8, 32)
        Me.cbxOpciones.Name = "cbxOpciones"
        Me.cbxOpciones.Size = New System.Drawing.Size(208, 21)
        Me.cbxOpciones.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(496, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(384, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Desde"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(240, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Moneda"
        '
        'cboMonedas
        '
        Me.cboMonedas.DataSource = Me.DsReciboAbonos
        Me.cboMonedas.DisplayMember = "Moneda.MonedaNombre"
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.Location = New System.Drawing.Point(240, 32)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(128, 21)
        Me.cboMonedas.TabIndex = 1
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinal.Location = New System.Drawing.Point(496, 32)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 3
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(384, 32)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 2
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(752, 24)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 24)
        Me.ButtonMostrar.TabIndex = 4
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESERVER;packet size=4096;integrated security=SSPI;data source=SE" & _
    "ESERVER;persist security info=False;initial catalog=Seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'daMonedas
        '
        Me.daMonedas.DeleteCommand = Me.SqlDeleteCommand3
        Me.daMonedas.InsertCommand = Me.SqlInsertCommand3
        Me.daMonedas.SelectCommand = Me.SqlSelectCommand3
        Me.daMonedas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.daMonedas.UpdateCommand = Me.SqlUpdateCommand3
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.AutoScroll = True
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 104)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1020, 428)
        Me.CrystalReportViewer1.TabIndex = 82
        '
        'frmReciboAbonos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1020, 538)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.lblTipoCambio)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmReciboAbonos"
        Me.Text = "Recibo Abonos"
        CType(Me.DsReciboAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"

    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
#End Region

#Region "Load"
    Private Sub frmReciboAbonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            cConexion = New Conexion
            sqlConexion = cConexion.Conectar
            SqlConnection1.ConnectionString = CadenaConexionSeePOS()
            daMonedas.Fill(Me.DsReciboAbonos, "Moneda")
            FechaInicio.Value = Date.Today
            FechaFinal.Value = Date.Today

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region


#Region "Mostrar"
    Private Sub Mostrar()
        Try
            Select Case Me.cbxOpciones.SelectedIndex
                Case 0
                    Dim Abono_Mensual As New RecibosdeAbonoMes
                    Dim Abono As New Recibos_de_Abono
                    Dim Abono_Caja As New Recibos_de_Abono_cajas
                    If Me.cbo_caja.Text = "General" Then
                        Abono.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        Abono.SetParameterValue(1, CDate(Me.FechaInicio.Value))
                        Abono.SetParameterValue(2, CDate(Me.FechaFinal.Value))
                        Abono.SetParameterValue(3, cboMonedas.Text)
                        Abono.SetParameterValue(4, txtCodigo.Text)
                        CrystalReportsConexion.LoadReportViewer(VisorReporte, Abono)
                        VisorReporte.Show()
                    ElseIf Me.cbo_caja.Text = "General Mensual" Then
                        Abono_Mensual.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        Abono_Mensual.SetParameterValue(1, CDate(Me.FechaInicio.Value))
                        Abono_Mensual.SetParameterValue(2, CDate(Me.FechaFinal.Value))
                        Abono_Mensual.SetParameterValue(3, cboMonedas.Text)
                        Abono_Mensual.SetParameterValue(4, txtCodigo.Text)
                        CrystalReportsConexion.LoadReportViewer(VisorReporte, Abono_Mensual)
                        VisorReporte.Show()
                    Else
                        Abono_Caja.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                        Abono_Caja.SetParameterValue(1, CDate(Me.FechaInicio.Value))
                        Abono_Caja.SetParameterValue(2, CDate(Me.FechaFinal.Value))
                        Abono_Caja.SetParameterValue(3, cboMonedas.Text)
                        Abono_Caja.SetParameterValue(4, txtCodigo.Text)
                        Abono_Caja.SetParameterValue(5, CInt(cbo_caja.Text))
                        CrystalReportsConexion.LoadReportViewer(VisorReporte, Abono_Caja)
                        VisorReporte.Show()
                    End If
                Case 1
                    Dim RptNotaDeb As New NotaDébito
                    RptNotaDeb.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                    RptNotaDeb.SetParameterValue(1, CDate(Me.FechaInicio.Value))
                    RptNotaDeb.SetParameterValue(2, CDate(Me.FechaFinal.Value))
                    RptNotaDeb.SetParameterValue(3, cboMonedas.Text)
                    CrystalReportsConexion.LoadReportViewer(VisorReporte, RptNotaDeb)
                    VisorReporte.Show()

                Case 2
                    Dim RptNotaCre As New NotaCrédito
                    RptNotaCre.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                    RptNotaCre.SetParameterValue(1, CDate(Me.FechaInicio.Value))
                    RptNotaCre.SetParameterValue(2, CDate(Me.FechaFinal.Value))
                    RptNotaCre.SetParameterValue(3, cboMonedas.Text)
                    CrystalReportsConexion.LoadReportViewer(VisorReporte, RptNotaCre)
                    VisorReporte.Show()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Funciones Controles"
    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        If cbxOpciones.SelectedIndex = 0 And txtCodigo.Text = "" Then Exit Sub
        Mostrar()
    End Sub

    Private Sub cbxOpciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbxOpciones.KeyDown, cboMonedas.KeyDown, FechaInicio.KeyDown, FechaFinal.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ButtonMostrar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ButtonMostrar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mostrar()
        End If
    End Sub
#End Region

    Private Sub cbxOpciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOpciones.SelectedIndexChanged
        If cbxOpciones.SelectedIndex <> 0 Then
            Label2.Enabled = False
            Label5.Enabled = False
            txtCodigo.Enabled = False
            txtNombre.Enabled = False
            Me.Label6.Visible = False
            Me.cbo_caja.Visible = False
        Else
            Label2.Enabled = True
            Label5.Enabled = True
            txtCodigo.Enabled = True
            txtNombre.Enabled = True
            Me.Label6.Visible = True
            Me.cbo_caja.Visible = True
        End If
        'If Me.cbxOpciones.Text = "Recibo de dinero" Then
        '    Me.Label6.Visible = True
        '    Me.cbo_caja.Visible = True
        'End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            txtCodigo.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")
            CargarInformacionCliente(txtCodigo.Text)
            Mostrar()
        End If
        If e.KeyCode = Keys.Enter Then
            If txtCodigo.Text = 0 Then
                Mostrar()
            Else
                CargarInformacionCliente(txtCodigo.Text)
                Mostrar()
            End If

        End If
    End Sub

    Private Sub CargarInformacionCliente(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Identificacion, Nombre from Clientes where Identificacion ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigo.Text = rs("Identificacion")
                    txtNombre.Text = rs("Nombre")                   
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
        End If
    End Sub

End Class
