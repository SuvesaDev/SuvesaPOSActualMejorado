Imports CrystalDecisions.Shared
Imports System.Diagnostics
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class frmEstado_CXC
    Inherits System.Windows.Forms.Form
    Dim Contador As Byte

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
    Friend WithEvents ToolBarGeneral As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarVencidas As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarPagadas As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarAntiguedad As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarSaldos As System.Windows.Forms.ToolBarButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolBarMovFac As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarMovCuenta As System.Windows.Forms.ToolBarButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Estado_CxC As DataSet_Estado_CxC
    Friend WithEvents ToolBarVencidasFecha As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolGeneralFecha As System.Windows.Forms.ToolBarButton
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents btnEnviarxOutlook As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ckTodos As System.Windows.Forms.CheckBox
    Friend WithEvents ck_rango_fechas As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Moneda = New System.Windows.Forms.ComboBox()
        Me.DataSet_Estado_CxC = New LcPymes_5._2.DataSet_Estado_CxC()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarGeneral = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarVencidas = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarPagadas = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarMovFac = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarMovCuenta = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarAntiguedad = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarSaldos = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarVencidasFecha = New System.Windows.Forms.ToolBarButton()
        Me.ToolGeneralFecha = New System.Windows.Forms.ToolBarButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEnviarxOutlook = New DevExpress.XtraEditors.SimpleButton()
        Me.ck_rango_fechas = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ckTodos = New System.Windows.Forms.CheckBox()
        CType(Me.DataSet_Estado_CxC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.AutoScroll = True
        Me.rptViewer.BackColor = System.Drawing.SystemColors.Control
        Me.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptViewer.Location = New System.Drawing.Point(112, 32)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.SelectionFormula = ""
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.Size = New System.Drawing.Size(802, 436)
        Me.rptViewer.TabIndex = 75
        Me.rptViewer.ViewTimeSelectionFormula = ""
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SERVER;packet size=4096;integrated security=SSPI;data source=SERVE" & _
    "R;persist security info=False;initial catalog=seepos"
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
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox1.Location = New System.Drawing.Point(8, 192)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 32)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.Text = "Filtrar Incobrables"
        Me.CheckBox1.UseVisualStyleBackColor = False
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
        Me.Label1.Text = "ID Cliente"
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
        Me.Label3.Location = New System.Drawing.Point(8, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 12)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha Corte"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 160)
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
        Me.Label2.Location = New System.Drawing.Point(8, 232)
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
        Me.Moneda.Location = New System.Drawing.Point(8, 248)
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
        Me.ButtonMostrar.Location = New System.Drawing.Point(16, 280)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(80, 24)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarGeneral, Me.ToolBarVencidas, Me.ToolBarPagadas, Me.ToolBarMovFac, Me.ToolBarMovCuenta, Me.ToolBarAntiguedad, Me.ToolBarSaldos, Me.ToolBarVencidasFecha, Me.ToolGeneralFecha})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(64, 30)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(920, 30)
        Me.ToolBar1.TabIndex = 80
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'ToolBarGeneral
        '
        Me.ToolBarGeneral.Name = "ToolBarGeneral"
        Me.ToolBarGeneral.Pushed = True
        Me.ToolBarGeneral.Text = "Por Cliente"
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
        '
        'ToolBarVencidasFecha
        '
        Me.ToolBarVencidasFecha.Name = "ToolBarVencidasFecha"
        Me.ToolBarVencidasFecha.Text = "Facturas Venc."
        '
        'ToolGeneralFecha
        '
        Me.ToolGeneralFecha.Name = "ToolGeneralFecha"
        Me.ToolGeneralFecha.Text = "General"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.ckTodos)
        Me.Panel1.Controls.Add(Me.btnEnviarxOutlook)
        Me.Panel1.Controls.Add(Me.ck_rango_fechas)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Moneda)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ButtonMostrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 436)
        Me.Panel1.TabIndex = 81
        '
        'btnEnviarxOutlook
        '
        Me.btnEnviarxOutlook.Location = New System.Drawing.Point(16, 348)
        Me.btnEnviarxOutlook.Name = "btnEnviarxOutlook"
        Me.btnEnviarxOutlook.Size = New System.Drawing.Size(80, 33)
        Me.btnEnviarxOutlook.TabIndex = 34
        Me.btnEnviarxOutlook.Text = "Correo"
        '
        'ck_rango_fechas
        '
        Me.ck_rango_fechas.Location = New System.Drawing.Point(5, 310)
        Me.ck_rango_fechas.Name = "ck_rango_fechas"
        Me.ck_rango_fechas.Size = New System.Drawing.Size(104, 32)
        Me.ck_rango_fechas.TabIndex = 33
        Me.ck_rango_fechas.Text = "Rango de fechas"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(8, 72)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(104, 32)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.Text = "Seleccionar Fecha"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(8, 120)
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
        Me.Label4.Location = New System.Drawing.Point(8, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 12)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Fecha Inicio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Estado_CxC, "Moneda.ValorCompra", True))
        Me.Label5.Location = New System.Drawing.Point(120, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 23)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Label5"
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(492, 40)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        '
        '
        '
        Me.ProgressBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ProgressBarControl1.Properties.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid
        Me.ProgressBarControl1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.WindowText)
        Me.ProgressBarControl1.Size = New System.Drawing.Size(298, 16)
        Me.ProgressBarControl1.TabIndex = 32
        Me.ProgressBarControl1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'ckTodos
        '
        Me.ckTodos.AutoSize = True
        Me.ckTodos.Location = New System.Drawing.Point(8, 387)
        Me.ckTodos.Name = "ckTodos"
        Me.ckTodos.Size = New System.Drawing.Size(56, 17)
        Me.ckTodos.TabIndex = 35
        Me.ckTodos.Text = "Todos"
        Me.ckTodos.UseVisualStyleBackColor = True
        '
        'frmEstado_CXC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(920, 466)
        Me.Controls.Add(Me.ProgressBarControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmEstado_CXC"
        Me.Text = "CxC-Estado de Cuentas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet_Estado_CxC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        CargarReporteTresEstados()
    End Sub

    Private Sub CargarReporteTresEstados()
        Dim X As Byte
        Dim Link As New Conexion
        Try
            For X = 0 To ToolBar1.Buttons.Count - 1
                If ToolBar1.Buttons(X).Pushed = True Then Exit For
            Next
            Select Case X
                Case 0 To 3
                    If Not IsNumeric(Me.TextBox1.Text) Then
                        MsgBox("La Id del Cliente Suministrada no es Válida...", MsgBoxStyle.Exclamation, "Atención...")
                        Exit Sub
                    End If
                Case 4, 5, 6

            End Select
            Link.Conectar()
            Me.ButtonMostrar.Enabled = False

            Me.ProgressBarControl1.Text = 0
            Me.Timer1.Enabled = True

            Select Case X
                Case 0 To 2 'Estado de Cuenta General,Vencidas,Pagadas. 
                    If Me.CheckBox2.Checked = True Then
                        Dim otro As New ESTADO_DE_CUENA_POR_CLIENTE
                        otro.SetParameterValue(0, CDbl(CDbl(Label5.Text)))      ' TIPO DE CAMBIO $ - c
                        otro.SetParameterValue(1, CStr("FACTURAS " & ToolBar1.Buttons(X).Text & " - " & Moneda.Text))
                        otro.SetParameterValue(2, X) 'TIPO DE REPORTE.
                        otro.SetParameterValue(3, Me.DateTimePicker1.Value.Date)  'DateAdd(DateInterval.Day, 1, Me.DateTimePicker1.Value))
                        otro.SetParameterValue(4, CDbl(TextBox1.Text))
                        otro.SetParameterValue(5, Me.DateTimePicker2.Value.Date)
                        otro.SetParameterValue(6, Me.CheckBox1.Checked)
                        CrystalReportsConexion.LoadReportViewer(Me.rptViewer, otro)
                    Else
                        Dim Reporte As New Estado_Actual_FechaCorte
                        Reporte.SetParameterValue(0, CDbl(CDbl(Label5.Text)))      ' TIPO DE CAMBIO $ - c
                        Reporte.SetParameterValue(1, CStr("FACTURAS " & ToolBar1.Buttons(X).Text & " - " & Moneda.Text))
                        Reporte.SetParameterValue(2, X)    'TIPO D EREPORTE
                        Reporte.SetParameterValue(3, Me.DateTimePicker1.Value.Date)  'DateAdd(DateInterval.Day, 1, Me.DateTimePicker1.Value))
                        Reporte.SetParameterValue(4, CDbl(TextBox1.Text))
                        Reporte.SetParameterValue(5, Me.CheckBox1.Checked)
                        CrystalReportsConexion.LoadReportViewer(Me.rptViewer, reporte)
                    End If

                Case 3 ' REPORTE DE MOV DE LA CUENTA POR FACTURA  
                    Dim Reporte As New MovimientoCliente
                    Reporte.SetParameterValue(0, CDbl(TextBox1.Text))              ' Codigo de cliente
                    Reporte.SetParameterValue(1, CDbl(Label5.Text))          ' TIPO DE CAMBIO $ - c
                    Reporte.SetParameterValue(2, Me.DateTimePicker2.Value)         ' Fecha Desde
                    Reporte.SetParameterValue(3, Me.DateTimePicker1.Value)         ' Fecha hasta
                    Reporte.SetParameterValue(4, Me.Moneda.Text)          ' Nombre Moneda
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)

                Case 4 'MOVIMIENTO POR CUENTA (DIAS EN QUE SE EFECTUA LOS MOVIMIENTO)
                    Dim reporte As New MovimientoSaldoCliente
                    reporte.SetParameterValue(0, CDbl(TextBox1.Text))
                    reporte.SetParameterValue(1, Me.DateTimePicker2.Value)
                    reporte.SetParameterValue(2, DateAdd(DateInterval.Day, 1, Me.DateTimePicker1.Value))
                    reporte.SetParameterValue(3, CDbl(Label5.Text))
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, reporte)

                Case 5 ' REPORTE DE ANTIGUEDAD DE SALDO 
                    'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM
                    'ya se aplico el cambio para filtrar incobrables
                    'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM

                    Dim Reporte As New Reporte_CXC_x_Cliente
                    Reporte.SetParameterValue(0, CDbl(Moneda.SelectedValue))
                    Reporte.SetParameterValue(1, Me.CheckBox1.Checked)
                    Reporte.SetParameterValue(2, Me.DateTimePicker1.Value)
                    Reporte.SetParameterValue(3, Me.ckTodos.Checked)
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)
                    Me.Timer1.Enabled = True

                Case 6

                    'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM
                    'ya se aplico el cambio para filtrar incobrables
                    'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM
                    Dim Reporte As New Estado_CXC_Saldo_General_Clientes
                    Reporte.SetParameterValue(0, CDbl(Moneda.SelectedValue))      ' TIPO DE CAMBIO $ - c
                    Reporte.SetParameterValue(1, CStr("GENERAL x CLIENTE EN " & Moneda.Text))
                    Reporte.SetParameterValue(2, Me.CheckBox1.Checked)
                    Reporte.SetParameterValue(3, Me.DateTimePicker1.Value)
                    Reporte.SetParameterValue(4, Me.DateTimePicker2.Value)
                    Reporte.SetParameterValue(5, Me.ck_rango_fechas.Checked)
                    Reporte.SetParameterValue(6, Me.ckTodos.Checked)
                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)

                Case 7
                    Dim Reporte As New Reporte_Facturas_Vencidas
                    Reporte.SetParameterValue(0, CDbl(Label5.Text))      ' TIPO DE CAMBIO $ - c
                    Reporte.SetParameterValue(1, Moneda.Text)
                    Reporte.SetParameterValue(2, Me.DateTimePicker2.Value)
                    Reporte.SetParameterValue(3, Me.DateTimePicker1.Value)
                    Reporte.SetParameterValue(4, Me.CheckBox1.Checked)

                    CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)
                Case 8

                    If CheckBox2.Checked = True Then
                        'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM
                        'ya se aplico el cambio para filtrar incobrables
                        'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM
                        Dim Reporte As New Estado_Actual_FechaCorteGeneral_rango
                        Reporte.SetParameterValue(0, CDbl(CDbl(Label5.Text)))      ' TIPO DE CAMBIO $ - c
                        Reporte.SetParameterValue(1, CStr("TODOS LOS CLIENTES-RANGO DE FECHA"))
                        Reporte.SetParameterValue(2, 0)
                        Reporte.SetParameterValue(3, Me.DateTimePicker1.Value.Date)
                        Reporte.SetParameterValue(4, Me.DateTimePicker2.Value.Date)
                        Reporte.SetParameterValue(5, Me.CheckBox1.Checked)
                        CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)
                    Else
                        'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM
                        'ya se aplico el cambio para filtrar incobrables
                        'MWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWM
                        Dim Reporte As New Estado_Actual_FechaCorteGeneral
                        Reporte.SetParameterValue(0, CDbl(CDbl(Label5.Text)))      ' TIPO DE CAMBIO $ - c
                        Reporte.SetParameterValue(1, CStr("TODOS LOS CLIENTES"))
                        Reporte.SetParameterValue(2, 0)
                        Reporte.SetParameterValue(3, Me.DateTimePicker1.Value.Date)
                        Reporte.SetParameterValue(4, Me.CheckBox1.Checked)
                        Reporte.SetParameterValue(5, Me.ckTodos.Checked)
                        CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)
                    End If


            End Select
            Me.rptViewer.Show()
            Me.ProgressBarControl1.Text = 0
            Me.Timer1.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.ButtonMostrar.Enabled = True
    End Sub

    Private Sub frmEstado_CXC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS
        Me.AdapterMoneda.Fill(Me.DataSet_Estado_CxC, "Moneda")
        Me.DateTimePicker1.Value = Now.Date
        Me.DateTimePicker2.Value = Now.Date
        Me.CheckBox1.Checked = True
        Me.CheckBox1.Enabled = True
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Me.TextBox1.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")
            cFunciones = Nothing
        ElseIf e.KeyCode = Keys.Enter Then
            CargarReporteTresEstados()
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
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Text = "Filtrar Incobrables"

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 To 2
                Me.CheckBox1.Checked = True
                Me.CheckBox1.Enabled = True
                CargarReporteTresEstados()
            Case 3
                Me.DateTimePicker1.Enabled = True
                Me.DateTimePicker2.Enabled = True
                Me.DateTimePicker2.Value = DateAdd(DateInterval.Day, -Me.DateTimePicker2.Value.Day + 1, Me.DateTimePicker2.Value) 'pone la fecha en 1 del mes actual
                Me.TextBox1.Focus()
                CargarReporteTresEstados()
            Case 4 : Me.DateTimePicker2.Enabled = True : CargarReporteTresEstados()
            Case 5, 6
                Me.CheckBox1.Checked = True
                Me.CheckBox1.Enabled = True
                Me.TextBox1.Enabled = False
                CargarReporteTresEstados()
            Case 7
                Me.CheckBox1.Enabled = True
                Me.CheckBox1.Text = "Clientes Relacionados"
                Me.TextBox1.Enabled = False
                CargarReporteTresEstados()
            Case 8
                Me.CheckBox1.Checked = True
                Me.CheckBox1.Enabled = True
                Me.TextBox1.Enabled = False
                CargarReporteTresEstados()
            Case Else
        End Select
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ProgressBarControl1.Text = Me.ProgressBarControl1.Text + 1
        If Me.ProgressBarControl1.Text = 100 Then Me.ProgressBarControl1.Text = 0
        rptViewer.Visible = True
        Application.DoEvents()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Me.DateTimePicker2.Enabled = Me.CheckBox2.Checked
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub ck_rango_fechas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_rango_fechas.CheckedChanged
        If Me.ck_rango_fechas.Checked = True Then
            Me.DateTimePicker2.Enabled = True
        Else
            Me.DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub btnEnviarxOutlook_Click(sender As Object, e As EventArgs) Handles btnEnviarxOutlook.Click
        Try
            Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim Carpeta As String = "C:\temporales"
            Dim Archivo As String = Carpeta & "\" & "adjunto" & ".pdf"

            rpt = Me.rptViewer.ReportSource

            If IO.File.Exists(Archivo) Then
                IO.File.Delete(Archivo)
            End If

            If IO.Directory.Exists(Carpeta) = False Then
                IO.Directory.CreateDirectory(Carpeta)
            End If

            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Archivo)
            If IO.File.Exists(Archivo) Then
                Me.Enviar("", "", "", Archivo, "")
            Else
                Me.Enviar("", "", "", Archivo, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try        
    End Sub

    Private Sub Enviar(_Subject As String, _Body As String, _To As String, _Filename As String, _Displayname As String)
        If _Body = "" Then _Body = "  "
        Try
            Dim oApp As Microsoft.Office.Interop.Outlook._Application
            oApp = New Microsoft.Office.Interop.Outlook.Application

            Dim oMsg As Microsoft.Office.Interop.Outlook._MailItem
            oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

            oMsg.Subject = _Subject
            oMsg.Body = _Body
            oMsg.To = _To

            Dim strS As String = _Filename
            Dim strN As String = _Displayname

            Dim sBodyLen As Integer = Int(_Body.Length)
            Dim oAttachs As Microsoft.Office.Interop.Outlook.Attachments = oMsg.Attachments
            Dim oAttach As Microsoft.Office.Interop.Outlook.Attachment
            oAttach = oAttachs.Add(strS, , sBodyLen, strN)
            oMsg.Display()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class
