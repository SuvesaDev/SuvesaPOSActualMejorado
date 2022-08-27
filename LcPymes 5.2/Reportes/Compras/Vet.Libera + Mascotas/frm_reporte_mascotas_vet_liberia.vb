Imports System.Data.SqlClient
Imports System.Data
Public Class frm_reporte_mascotas_vet_liberia
    Inherits System.Windows.Forms.Form
    Dim NuevaConexion As String
    Dim strModulos As String = ""
    Dim tipo As Integer
#Region "variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
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
    Friend WithEvents CBTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoCompra As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxOpcionesdeCompra As System.Windows.Forms.ComboBox
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsReporteCompras As LcPymes_5._2.dsReporteCompras
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CBTipo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbxTipoCompra = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbxOpcionesdeCompra = New System.Windows.Forms.ComboBox
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboMonedas = New System.Windows.Forms.ComboBox
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lblTipoCambio = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsReporteCompras = New LcPymes_5._2.dsReporteCompras
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsReporteCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.CBTipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxTipoCompra)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbxOpcionesdeCompra)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMonedas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(832, 96)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'CBTipo
        '
        Me.CBTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipo.ForeColor = System.Drawing.Color.Blue
        Me.CBTipo.Items.AddRange(New Object() {"TODAS", "CON", "CRE"})
        Me.CBTipo.Location = New System.Drawing.Point(16, 64)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(168, 21)
        Me.CBTipo.TabIndex = 67
        Me.CBTipo.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Tipo"
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
        'cbxOpcionesdeCompra
        '
        Me.cbxOpcionesdeCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOpcionesdeCompra.Items.AddRange(New Object() {"Entre Fechas"})
        Me.cbxOpcionesdeCompra.Location = New System.Drawing.Point(12, 24)
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
        Me.ButtonMostrar.Location = New System.Drawing.Point(696, 16)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 72)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(408, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Moneda"
        '
        'cboMonedas
        '
        Me.cboMonedas.DataSource = Me.DsReporteCompras
        Me.cboMonedas.DisplayMember = "Moneda.MonedaNombre"
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.Location = New System.Drawing.Point(408, 24)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(128, 21)
        Me.cboMonedas.TabIndex = 68
        Me.cboMonedas.ValueMember = "ValorCompra"
        '
        'VisorReporte
        '
        Me.VisorReporte.ActiveViewIndex = -1
        Me.VisorReporte.AutoScroll = True
        Me.VisorReporte.DisplayGroupTree = False
        Me.VisorReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisorReporte.Location = New System.Drawing.Point(0, 96)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ReportSource = Nothing
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(832, 410)
        Me.VisorReporte.TabIndex = 85
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsReporteCompras, "Moneda.ValorCompra"))
        Me.lblTipoCambio.Location = New System.Drawing.Point(552, 181)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.TabIndex = 83
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=.;packet size=4096;user id=SeeSOFT;integrated security=SSPI;data s" & _
        "ource=ZEUS;persist security info=False;initial catalog=SeePOS"
        '
        'daMoneda
        '
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'DsReporteCompras
        '
        Me.DsReporteCompras.DataSetName = "dsReporteCompras"
        Me.DsReporteCompras.Locale = New System.Globalization.CultureInfo("es")
        '
        'frm_reporte_mascotas_vet_liberia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 506)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTipoCambio)
        Me.Name = "frm_reporte_mascotas_vet_liberia"
        Me.Text = "frm_reporte_mascotas_vet_liberia"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsReporteCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim RptComprasxFecha As New compras_vete_mascotas
        RptComprasxFecha.SetParameterValue(0, CDbl(lblTipoCambio.Text))
        RptComprasxFecha.SetParameterValue(1, cboMonedas.Text)
        RptComprasxFecha.SetParameterValue(2, CDate(Me.FechaInicio.Value))
        RptComprasxFecha.SetParameterValue(3, CDate(Me.FechaFinal.Value))
        RptComprasxFecha.SetParameterValue(4, CBool(tipo))
        CrystalReportsConexion.LoadReportViewer(VisorReporte, RptComprasxFecha, , SqlConnection1.ConnectionString)
        VisorReporte.Show()
    End Sub

    Private Sub frm_reporte_mascotas_vet_liberia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dtsmonedas As New DataTable

            SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion) 'JCGA
            strModulos = IIf(NuevaConexion = "", "SeePOS", "SeePos")

            cConexion = New Conexion
            sqlConexion = cConexion.Conectar(strModulos)

            daMoneda.Fill(Me.DsReporteCompras, "Moneda")


            If tipo = 0 Then
                Text = "Reporte de Compras"
            Else
                Text = "Reporte de Gastos"
            End If

            FechaInicio.Text = Date.Today

            FechaFinal.Text = Date.Today
            Label2.Visible = False
            CBTipo.SelectedIndex = 0

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
