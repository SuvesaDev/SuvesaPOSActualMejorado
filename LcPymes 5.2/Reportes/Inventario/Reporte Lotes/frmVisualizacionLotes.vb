Imports System.Data.SqlClient
Imports system.Data
Imports System.Windows.Forms

Public Class frmVisualizacionLotes
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LbTipoCambio As System.Windows.Forms.Label
    Friend WithEvents SqlDataAdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetReporteInventario As DataSetReporteInventario
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents lblgeneral As System.Windows.Forms.Label
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblhasta As System.Windows.Forms.Label
    Friend WithEvents AdapterProveedor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterBodegas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVisualizacionLotes))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker
        Me.lblhasta = New System.Windows.Forms.Label
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.lblgeneral = New System.Windows.Forms.Label
        Me.DataSetReporteInventario = New LcPymes_5._2.DataSetReporteInventario
        Me.LbTipoCambio = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterProveedor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterBodegas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.lblhasta)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.lblgeneral)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1072, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'FechaFinal
        '
        Me.FechaFinal.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaFinal.Location = New System.Drawing.Point(104, 24)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(131, 20)
        Me.FechaFinal.TabIndex = 59
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'lblhasta
        '
        Me.lblhasta.BackColor = System.Drawing.Color.Transparent
        Me.lblhasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhasta.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblhasta.Location = New System.Drawing.Point(8, 24)
        Me.lblhasta.Name = "lblhasta"
        Me.lblhasta.Size = New System.Drawing.Size(96, 16)
        Me.lblhasta.TabIndex = 61
        Me.lblhasta.Text = "Fecha"
        Me.lblhasta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblhasta.Visible = False
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.Location = New System.Drawing.Point(888, 16)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 32)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'lblgeneral
        '
        Me.lblgeneral.BackColor = System.Drawing.Color.Transparent
        Me.lblgeneral.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblgeneral.Location = New System.Drawing.Point(264, 8)
        Me.lblgeneral.Name = "lblgeneral"
        Me.lblgeneral.Size = New System.Drawing.Size(256, 16)
        Me.lblgeneral.TabIndex = 22
        Me.lblgeneral.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblgeneral.Visible = False
        '
        'DataSetReporteInventario
        '
        Me.DataSetReporteInventario.DataSetName = "DataSetReporteInventario"
        Me.DataSetReporteInventario.Locale = New System.Globalization.CultureInfo("")
        '
        'LbTipoCambio
        '
        Me.LbTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetReporteInventario, "Moneda.ValorCompra"))
        Me.LbTipoCambio.Location = New System.Drawing.Point(616, 104)
        Me.LbTipoCambio.Name = "LbTipoCambio"
        Me.LbTipoCambio.TabIndex = 22
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.AutoScroll = True
        Me.rptViewer.BackColor = System.Drawing.SystemColors.Control
        Me.rptViewer.DisplayGroupTree = False
        Me.rptViewer.Location = New System.Drawing.Point(0, 64)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ReportSource = Nothing
        Me.rptViewer.Size = New System.Drawing.Size(1072, 504)
        Me.rptViewer.TabIndex = 73
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=SeePos"
        '
        'SqlDataAdapterMoneda
        '
        Me.SqlDataAdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT MonedaNombre, ValorCompra, CodMoneda FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'AdapterProveedor
        '
        Me.AdapterProveedor.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterProveedor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Proveedores", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodigoProv", "CodigoProv"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodigoProv, Nombre FROM Proveedores"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection
        '
        'AdapterBodegas
        '
        Me.AdapterBodegas.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterBodegas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bodegas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Bodega", "ID_Bodega"), New System.Data.Common.DataColumnMapping("Nombre_Bodega", "Nombre_Bodega")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT ID_Bodega, Nombre_Bodega FROM Bodegas ORDER BY Nombre_Bodega"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection
        '
        'frmVisualizacionLotes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1072, 566)
        Me.Controls.Add(Me.rptViewer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbTipoCambio)
        Me.Name = "frmVisualizacionLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes de Inventario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSetReporteInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
#End Region

#Region "Load"
    Private Sub frmOpcionesVisualizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.SqlConnection.ConnectionString = CadenaConexionSeePOS
        cConexion = New Conexion
        sqlConexion = cConexion.Conectar
        FechaFinal.Value = Now

    End Sub

 
#End Region

#Region "Mostrar"

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim Reporte As New ConsultaInventario2
        Dim SQLConexion As New Conexion
        Dim EnEspera As New DevExpress.Utils.WaitDialogForm

        Try
            SQLConexion.SQLStringConexion = Me.SqlConnection.ConnectionString
            SQLConexion.Conectar()
            Reporte.RecordSelectionFormula = ""
            EnEspera.Text = "Reporte de Lotes por Vencer"
            EnEspera.Show()

            Application.DoEvents()
            Dim RptLotes As New ReporteLotes
            RptLotes.SetParameterValue(0, Me.FechaFinal.Value)
            ''''''Bodegas.SetParameterValue(1, Me.FechaFinal.Value)
            ''''''Bodegas.SetParameterValue(2, Me.Cb_Bodegas.SelectedValue)
            CrystalReportsConexion.LoadReportViewer(rptViewer, RptLotes)

            rptViewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            EnEspera.Close()
            cConexion.DesConectar(SQLConexion.sQlconexion)
        End Try
    End Sub
#End Region

End Class
