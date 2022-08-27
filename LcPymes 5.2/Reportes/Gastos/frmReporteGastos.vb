Imports System.Data.SqlClient
'Imports Utilidades


Public Class frmReporteGastos
    Inherits System.Windows.Forms.Form
    Dim NuevaConexion As String
    Dim strModulos As String = ""
    Dim tipo As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(Optional ByVal Conexion As String = "", Optional ByVal STipo As Integer = 0)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        tipo = STipo
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents cbxOpcionesdeCompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoCompra As System.Windows.Forms.ComboBox
    Friend WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    ' Friend WithEvents DsReporteCompras As Reportes_Compras.dsReporteCompras
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsReporteGastos1 As LcPymes_5._2.dsReporteGastos

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboProveedores = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbxTipoCompra = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboMonedas = New System.Windows.Forms.ComboBox
        Me.DsReporteGastos1 = New LcPymes_5._2.dsReporteGastos
        Me.cbxOpcionesdeCompra = New System.Windows.Forms.ComboBox
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.lblTipoCambio = New System.Windows.Forms.Label
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsReporteGastos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisorReporte
        '
        Me.VisorReporte.ActiveViewIndex = -1
        Me.VisorReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorReporte.AutoScroll = True
        Me.VisorReporte.DisplayGroupTree = False
        Me.VisorReporte.Location = New System.Drawing.Point(0, 96)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ReportSource = Nothing
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(798, 464)
        Me.VisorReporte.TabIndex = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboProveedores)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxTipoCompra)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMonedas)
        Me.GroupBox1.Controls.Add(Me.cbxOpcionesdeCompra)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 96)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(396, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Monto >="
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(396, 64)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(128, 20)
        Me.txtMonto.TabIndex = 62
        Me.txtMonto.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Proveedores"
        '
        'cboProveedores
        '
        Me.cboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedores.Location = New System.Drawing.Point(13, 64)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(240, 21)
        Me.cboProveedores.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(-134, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Tipo Compra"
        '
        'cbxTipoCompra
        '
        Me.cbxTipoCompra.DisplayMember = "ValorCompra"
        Me.cbxTipoCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoCompra.Enabled = False
        Me.cbxTipoCompra.Items.AddRange(New Object() {"Contado", "Crédito"})
        Me.cbxTipoCompra.Location = New System.Drawing.Point(-134, 64)
        Me.cbxTipoCompra.Name = "cbxTipoCompra"
        Me.cbxTipoCompra.Size = New System.Drawing.Size(134, 21)
        Me.cbxTipoCompra.TabIndex = 58
        Me.cbxTipoCompra.ValueMember = "ValorCompra"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(276, 48)
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
        Me.Label3.Location = New System.Drawing.Point(276, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Desde"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Ver Reporte Según"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(396, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Moneda"
        '
        'cboMonedas
        '
        Me.cboMonedas.DataSource = Me.DsReporteGastos1.Moneda
        Me.cboMonedas.DisplayMember = "MonedaNombre"
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.Location = New System.Drawing.Point(396, 24)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(128, 21)
        Me.cboMonedas.TabIndex = 41
        Me.cboMonedas.ValueMember = "ValorCompra"
        '
        'DsReporteGastos1
        '
        Me.DsReporteGastos1.DataSetName = "dsReporteGastos"
        Me.DsReporteGastos1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'cbxOpcionesdeCompra
        '
        Me.cbxOpcionesdeCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOpcionesdeCompra.Items.AddRange(New Object() {"Entre Fechas", "Por Proveedores", "Por Seguimiento de Proveedor", "Mayores por Proveedor", "Por Tipo Operación"})
        Me.cbxOpcionesdeCompra.Location = New System.Drawing.Point(8, 24)
        Me.cbxOpcionesdeCompra.Name = "cbxOpcionesdeCompra"
        Me.cbxOpcionesdeCompra.Size = New System.Drawing.Size(240, 21)
        Me.cbxOpcionesdeCompra.TabIndex = 38
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaFinal.Location = New System.Drawing.Point(276, 64)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 37
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaInicio.Location = New System.Drawing.Point(276, 24)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 36
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(696, 8)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 72)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsReporteGastos1, "Moneda.ValorCompra"))
        Me.lblTipoCambio.Location = New System.Drawing.Point(552, 208)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.TabIndex = 80
        '
        'daMoneda
        '
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand1
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=SeePos"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        '
        'frmReporteGastos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 566)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.lblTipoCambio)
        Me.Name = "frmReporteGastos"
        Me.Text = "Reporte Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsReporteGastos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"

    Private cConexion As Conexion
    Private sqlConexion As SqlConnection

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Select Case Me.cbxOpcionesdeCompra.SelectedIndex
            Case 0
                Dim RptComprasxFecha As New GastosxFechas
                RptComprasxFecha.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                RptComprasxFecha.SetParameterValue(1, cboMonedas.Text)
                RptComprasxFecha.SetParameterValue(2, CDate(FechaInicio.Value))
                RptComprasxFecha.SetParameterValue(3, CDate(FechaFinal.Value))
                RptComprasxFecha.SetParameterValue(4, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxFecha, , SqlConnection1.ConnectionString)
                VisorReporte.Show()

            Case 1
                Dim RptComprasxProveedor As New GastosxProveedor
                RptComprasxProveedor.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                RptComprasxProveedor.SetParameterValue(1, cboMonedas.Text)
                RptComprasxProveedor.SetParameterValue(2, CDate(FechaInicio.Value))
                RptComprasxProveedor.SetParameterValue(3, CDate(FechaFinal.Value))
                RptComprasxProveedor.SetParameterValue(4, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxProveedor, , SqlConnection1.ConnectionString)
                VisorReporte.Show()
            Case 2
                Dim RptComprasxProveedor As New GastosxProveedorX
                RptComprasxProveedor.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                RptComprasxProveedor.SetParameterValue(1, Me.cboMonedas.Text)
                RptComprasxProveedor.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                RptComprasxProveedor.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                RptComprasxProveedor.SetParameterValue(4, Me.cboProveedores.Text)
                RptComprasxProveedor.SetParameterValue(5, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxProveedor, , Me.SqlConnection1.ConnectionString)
                VisorReporte.Show()
            Case 3
                Dim RptComprasMayores As New GastosMayores
                RptComprasMayores.SetParameterValue(0, CDbl(txtMonto.Text))
                RptComprasMayores.SetParameterValue(1, CDate(FechaInicio.Value))
                RptComprasMayores.SetParameterValue(2, CDate(FechaFinal.Value))
                RptComprasMayores.SetParameterValue(3, lblTipoCambio.Text)
                RptComprasMayores.SetParameterValue(4, cboMonedas.Text)
                RptComprasMayores.SetParameterValue(5, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasMayores, , SqlConnection1.ConnectionString)
                VisorReporte.Show()
            Case 4
                Dim rptGastosxTipo As New GastosxTipo
                rptGastosxTipo.SetParameterValue(0, CDbl(lblTipoCambio.Text))
                rptGastosxTipo.SetParameterValue(1, cboMonedas.Text)
                rptGastosxTipo.SetParameterValue(2, CDate(FechaInicio.Value))
                rptGastosxTipo.SetParameterValue(3, CDate(FechaFinal.Value))
                rptGastosxTipo.SetParameterValue(4, CBool(tipo))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rptGastosxTipo, , SqlConnection1.ConnectionString)
                VisorReporte.Show()
        End Select
    End Sub

    Private Sub cbxOpcionesdeVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOpcionesdeCompra.SelectedIndexChanged
        Me.txtMonto.Visible = False
        Me.Label6.Visible = False
        Me.cboProveedores.Visible = False
        Me.Label2.Visible = False

        Select Case Me.cbxOpcionesdeCompra.SelectedIndex
            Case 0
                Me.cbxTipoCompra.Enabled = False
                Me.cboProveedores.Enabled = False
                Me.FechaInicio.Focus()
            Case 1
                Me.cbxTipoCompra.Enabled = False
                Me.cboProveedores.Enabled = False
            Case 2
                Me.cbxTipoCompra.Enabled = False
                Me.cboProveedores.Enabled = True
                Me.cboProveedores.Visible = True
                Me.Label2.Visible = True

                Dim rs As SqlDataReader
                rs = cConexion.GetRecorset(cConexion.sQlconexion, "SELECT distinct(nombre) from proveedores order by nombre")
                While rs.Read
                    Try
                        Me.cboProveedores.Items.Add(rs!nombre)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()

            Case 3
                Me.cbxTipoCompra.Enabled = False
                Me.cboProveedores.Enabled = False
                Me.FechaInicio.Focus()
                Me.txtMonto.Visible = True
                Me.Label6.Visible = True
            Case 4
                Me.cbxTipoCompra.Enabled = False
                Me.cboProveedores.Enabled = False
                Me.FechaInicio.Focus()

            Case 5
                Me.cbxTipoCompra.Enabled = False
                Me.cboProveedores.Enabled = False
                Me.FechaInicio.Focus()


        End Select
    End Sub

    Private Sub frmReporteCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            strModulos = "SeePos"

            cConexion = New Conexion
            sqlConexion = cConexion.Conectar(strModulos)
            'SqlConnection1.ConnectionString = CadenaConexionSeePOS

            Me.daMoneda.Fill(Me.DsReporteGastos1, "Moneda")
            tipo = 1
            If tipo = 0 Then
                Me.Text = "Reporte de Compras"
            Else
                Me.Text = "Reporte de Gastos"
            End If

            Me.FechaInicio.Text = Date.Today

            Me.FechaFinal.Text = Date.Today
            Me.txtMonto.Visible = False
            Me.Label6.Visible = False

            Me.cboProveedores.Visible = False
            Me.Label2.Visible = False

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Windows.Forms.Keys.Back)) Then e.Handled = True ' esto invalida la tecla pulsada         End If

        End If
    End Sub

    Private Sub FechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaInicio.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            FechaFinal.Focus()
        End If
    End Sub

    Private Sub FechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaFinal.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            cboMonedas.Focus()
        End If
    End Sub

    Private Sub cboMonedas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMonedas.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtMonto.Visible = True Then
                txtMonto.Focus()
            Else
                ButtonMostrar.Focus()
            End If
        End If
    End Sub
End Class
