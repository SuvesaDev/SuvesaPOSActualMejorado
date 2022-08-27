Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports System.Windows.Forms
Imports System.Data

Public Class frmEstado_CXP
    Inherits System.Windows.Forms.Form
    Dim Contador As Byte
    Dim NuevaConexion As String
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckActualizado As System.Windows.Forms.CheckBox
    Dim Modulo As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(Optional ByVal Conexion = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        NuevaConexion = Conexion
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
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarVencidas As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarPagadas As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarAntiguedad As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarSaldos As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarMovFac As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarMovCuenta As System.Windows.Forms.ToolBarButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Estado_CxC As DataSet_Estado_CxC
    Friend WithEvents ToolBarVencidasG As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarProveedor As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarGeneral As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Moneda = New System.Windows.Forms.ComboBox()
        Me.DataSet_Estado_CxC = New LcPymes_5._2.DataSet_Estado_CxC()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarProveedor = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarVencidas = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarPagadas = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarMovFac = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarMovCuenta = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarAntiguedad = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarSaldos = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarVencidasG = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarGeneral = New System.Windows.Forms.ToolBarButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckActualizado = New System.Windows.Forms.CheckBox()
        Me.btnAplicar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.DataSet_Estado_CxC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.AutoScroll = True
        Me.rptViewer.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.Location = New System.Drawing.Point(112, 24)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ShowGroupTreeButton = False
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.Size = New System.Drawing.Size(792, 440)
        Me.rptViewer.TabIndex = 75
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "connect timeout =60;workstation id=SERVER;packet size=4096;integrated security=SS" & _
    "PI;data source=SERVER;persist security info=False;initial catalog=seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 12)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.ForeColor = System.Drawing.Color.Blue
        Me.TextBox1.Location = New System.Drawing.Point(8, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 13)
        Me.TextBox1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(8, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 12)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha Corte"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 23
        Me.DateTimePicker1.Value = New Date(2006, 5, 31, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 12)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Ver en Moneda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Moneda
        '
        Me.Moneda.DataSource = Me.DataSet_Estado_CxC
        Me.Moneda.DisplayMember = "Moneda.MonedaNombre"
        Me.Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Moneda.Location = New System.Drawing.Point(8, 152)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Size = New System.Drawing.Size(96, 21)
        Me.Moneda.TabIndex = 21
        Me.Moneda.ValueMember = "Moneda.ValorCompra"
        '
        'DataSet_Estado_CxC
        '
        Me.DataSet_Estado_CxC.DataSetName = "DataSet_Estado_CxC"
        Me.DataSet_Estado_CxC.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSet_Estado_CxC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(16, 204)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(80, 36)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarProveedor, Me.ToolBarVencidas, Me.ToolBarPagadas, Me.ToolBarMovFac, Me.ToolBarMovCuenta, Me.ToolBarAntiguedad, Me.ToolBarSaldos, Me.ToolBarVencidasG, Me.ToolBarGeneral})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(64, 28)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(904, 28)
        Me.ToolBar1.TabIndex = 80
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarProveedor
        '
        Me.ToolBarProveedor.Name = "ToolBarProveedor"
        Me.ToolBarProveedor.Pushed = True
        Me.ToolBarProveedor.Text = "Por Proveedor"
        '
        'ToolBarVencidas
        '
        Me.ToolBarVencidas.Name = "ToolBarVencidas"
        Me.ToolBarVencidas.Text = "Vencidas"
        '
        'ToolBarPagadas
        '
        Me.ToolBarPagadas.Name = "ToolBarPagadas"
        Me.ToolBarPagadas.Text = "Pagadas"
        '
        'ToolBarMovFac
        '
        Me.ToolBarMovFac.Name = "ToolBarMovFac"
        Me.ToolBarMovFac.Text = "Mov. Fac"
        '
        'ToolBarMovCuenta
        '
        Me.ToolBarMovCuenta.Name = "ToolBarMovCuenta"
        Me.ToolBarMovCuenta.Text = "Mov. Ctas"
        '
        'ToolBarAntiguedad
        '
        Me.ToolBarAntiguedad.Name = "ToolBarAntiguedad"
        Me.ToolBarAntiguedad.Text = "Anti. Saldos"
        '
        'ToolBarSaldos
        '
        Me.ToolBarSaldos.Name = "ToolBarSaldos"
        Me.ToolBarSaldos.Text = "Saldos Gen."
        Me.ToolBarSaldos.Visible = False
        '
        'ToolBarVencidasG
        '
        Me.ToolBarVencidasG.Name = "ToolBarVencidasG"
        Me.ToolBarVencidasG.Text = "Vencidas General"
        '
        'ToolBarGeneral
        '
        Me.ToolBarGeneral.Name = "ToolBarGeneral"
        Me.ToolBarGeneral.Text = "General"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Moneda)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonMostrar)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 433)
        Me.Panel1.TabIndex = 81
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(8, 70)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 30
        Me.DateTimePicker2.Value = New Date(2006, 5, 2, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(8, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 12)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Fecha Inicio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Estado_CxC, "Moneda.ValorCompra", True))
        Me.Label5.Location = New System.Drawing.Point(8, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Label5"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(534, 32)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        '
        '
        '
        Me.ProgressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ProgressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.ProgressBarControl1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.DarkSeaGreen, System.Drawing.SystemColors.WindowText)
        Me.ProgressBarControl1.Size = New System.Drawing.Size(368, 16)
        Me.ProgressBarControl1.TabIndex = 32
        Me.ProgressBarControl1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAplicar)
        Me.GroupBox1.Controls.Add(Me.ckActualizado)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(3, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 91)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'ckActualizado
        '
        Me.ckActualizado.AutoSize = True
        Me.ckActualizado.Location = New System.Drawing.Point(9, 19)
        Me.ckActualizado.Name = "ckActualizado"
        Me.ckActualizado.Size = New System.Drawing.Size(81, 17)
        Me.ckActualizado.TabIndex = 29
        Me.ckActualizado.Text = "Actualizado"
        Me.ckActualizado.UseVisualStyleBackColor = True
        '
        'btnAplicar
        '
        Me.btnAplicar.Location = New System.Drawing.Point(10, 42)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(80, 36)
        Me.btnAplicar.TabIndex = 30
        Me.btnAplicar.Text = "Aplicar"
        '
        'frmEstado_CXP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(904, 461)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.rptViewer)
        Me.Name = "frmEstado_CXP"
        Me.Text = "Estado de Cuentas por Pagar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet_Estado_CxC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmEstado_CXC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS
        Modulo = IIf(NuevaConexion = "", "SeePos", "SeePos")
        Me.AdapterMoneda.Fill(Me.DataSet_Estado_CxC, "Moneda")
        Me.DateTimePicker1.Value = Now.Date
        Me.DateTimePicker2.Value = Now.Date
    End Sub

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        CargarReporteTresEstados()
        Me.GroupBox1.Enabled = True
    End Sub

    Private Sub CargarReporteTresEstados()
        Dim X As Byte
        Dim Link As New Conexion
        Dim conex As SqlConnection = Me.SqlConnection1
        Try
            For X = 0 To ToolBar1.Buttons.Count - 1
                If ToolBar1.Buttons(X).Pushed = True Then Exit For
            Next
            Select Case X
                Case 0 To 3
                    If Not IsNumeric(Me.TextBox1.Text) Then
                        MsgBox("La Id del Proveedor Suministrada no es Válida...", MsgBoxStyle.Exclamation, "Atención...")
                        Exit Sub
                    End If
                Case 4, 5, 6
                    'Revisar:  Agregar los reportes de C.X.P, Movimiento por facturas Saldo(General)


            End Select
            Link.Conectar(Modulo)

            Me.ProgressBarControl1.Text = 0
            Me.Timer1.Enabled = True




            Select Case X

                Case 0 To 2 'Estado de Cuenta General,Vencidas,Pagadas. 
                    Dim Reporte As New Reporte_Estado_CXP_FechaCorte_Proveedor
                    Dim xx As Double = 2
                    Reporte.SetParameterValue("TipoCambio", CDbl(CDbl(Label5.Text)))      ' TIPO DE CAMBIO $ - c
                    Reporte.SetParameterValue("NombreReporte", CStr("FACTURAS " & ToolBar1.Buttons(X).Text & " - " & Moneda.Text))
                    Reporte.SetParameterValue("TipoReporte", X)
                    Reporte.SetParameterValue("@FechaCorte", Me.DateTimePicker1.Value.Date)
                    Reporte.SetParameterValue("@Cod_Cli", CDbl(TextBox1.Text))
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte, , conex.ConnectionString)
                    rptViewer.Show()

                Case 3 ' REPORTE DE MOV DE LA CUENTA POR FACTURA  
                    Dim Reporte As New Estado_CXP_Movimiento_Cuenta_Proveedor_x_Factura
                    Reporte.SetParameterValue(0, TextBox1.Text) 'codigo deproveedor
                    Reporte.SetParameterValue(1, CDbl(CDbl(Label5.Text)))  ' TIPO DE CAMBIO $ - c
                    Reporte.SetParameterValue(2, Me.DateTimePicker2.Text)   'Fecha desde
                    Reporte.SetParameterValue(3, Me.DateTimePicker1.Text)   'Fecha hasta
                    Reporte.SetParameterValue(4, Me.Moneda.Text)            'nombre de la moneda
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte, , conex.ConnectionString)
                    rptViewer.Show()

                Case 4
                    Dim reporte As New Movimiento_Cuenta_Proveedor_x_Fecha
                    reporte.SetParameterValue(0, TextBox1.Text) 'codigo deproveedor
                    reporte.SetParameterValue(1, Me.DateTimePicker2.Text)   'Fecha desde
                    reporte.SetParameterValue(2, Me.DateTimePicker1.Text)   'Fecha hasta
                    reporte.SetParameterValue(3, CDbl(CDbl(Label5.Text)))  ' TIPO DE CAMBIO $ - c
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, reporte, , conex.ConnectionString)
                    Me.rptViewer.Show()

                Case 5 ' REPORTE DE ANTIGUEDAD DE SALDO 
                    Dim Reporte As New Reporte_CXP_Antiguedad_Saldos_Proveedor_Proveeduria
                    Reporte.SetParameterValue(0, CDbl(Label5.Text))
                    Reporte.SetParameterValue(1, Me.DateTimePicker1.Value.Date)
                    Reporte.SetParameterValue(2, Me.DateTimePicker1.Value.Date)
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte, , conex.ConnectionString)
                    Me.rptViewer.Show()

                Case 6
                    'Dim Reporte As New Estado_Actual_General_Clientes
                    'Reporte.SetParameterValue(0, CDbl(Moneda.SelectedValue))      ' TIPO DE CAMBIO $ - c
                    'Reporte.SetParameterValue(1, CStr("GENERAL x CLIENTE EN " & Moneda.Text))
                    'Inventario.CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)
                    'Me.rptViewer.Show()
                Case 7
                    Dim Reporte As New Estado_CXP_FechaCorte_General
                    Dim xx As Double = 0
                    Reporte.SetParameterValue("TipoCambio", CDbl(CDbl(Label5.Text)))      ' TIPO DE CAMBIO $ - c
                    Reporte.SetParameterValue("NombreReporte", CStr("Reporte Facturas Vencidas por Pagar " & " - " & Moneda.Text))
                    Reporte.SetParameterValue("TipoReporte", X)
                    Reporte.SetParameterValue("@FechaCorte", Me.DateTimePicker1.Value)
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte, , conex.ConnectionString)
                    rptViewer.Show()

                Case 8
                    Dim Reporte As New Reporte_Estado_CXP_FechaCorteGeneral
                    Reporte.SetParameterValue("TipoCambio", CDbl(CDbl(Label5.Text)))      ' TIPO DE CAMBIO $ - c
                    Reporte.SetParameterValue("NombreReporte", CStr("TODOS LOS PROVEEDORES"))
                    Reporte.SetParameterValue("TipoReporte", 0)
                    Reporte.SetParameterValue("@FechaCorte", Me.DateTimePicker1.Value.Date)
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte, , conex.ConnectionString)
                    rptViewer.Show()

            End Select
            Me.ProgressBarControl1.Text = 0
            Me.Timer1.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargarActualizado()
        If Me.TextBox1.Text <> "" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Actualizado from Proveedores where CodigoProv = " & Me.TextBox1.Text, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.ckActualizado.Checked = CBool(dt.Rows(0).Item(0))
            End If
        End If        
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.TextBox1.Text = cFunciones.BuscarDatos("select CodigoProv as Identificación,nombre as Nombre from Proveedores", "Nombre", "Buscar..", Me.SqlConnection1.ConnectionString)
            Me.CargarActualizado()
            cFunciones = Nothing
            Me.GroupBox1.Enabled = False
        ElseIf e.KeyCode = Keys.Enter Then
            Me.CargarActualizado()
            CargarReporteTresEstados()
            Me.GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim X As Byte
        For X = 0 To ToolBar1.Buttons.Count - 1
            ToolBar1.Buttons(X).Pushed = False
        Next
        ToolBar1.Buttons(ToolBar1.Buttons.IndexOf(e.Button)).Pushed = True

        Me.DateTimePicker2.Enabled = False
        Me.TextBox1.Enabled = True
        '        Me.CheckBox1.Enabled = False

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 To 2 : CargarReporteTresEstados()
            Case 3, 4
                DateTimePicker2.Enabled = True
                DateTimePicker1.Enabled = True
                CargarReporteTresEstados()

            Case 5, 6
                TextBox1.Enabled = False
                CargarReporteTresEstados()
            Case 7
                TextBox1.Enabled = False
                DateTimePicker1.Enabled = True
                CargarReporteTresEstados()
            Case 8
                TextBox1.Enabled = False
                CargarReporteTresEstados()
            Case Else
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ProgressBarControl1.Text = Me.ProgressBarControl1.Text + 1
        If Me.ProgressBarControl1.Text = 100 Then Me.ProgressBarControl1.Text = 0
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        If TextBox1.Text <> "" Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Proveedores Set Actualizado = " & IIf(Me.ckActualizado.Checked = True, 1, 0) & " Where CodigoProv = " & Me.TextBox1.Text, CommandType.Text)
        End If
    End Sub
End Class

