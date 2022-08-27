Imports CrystalDecisions.Shared
Imports System.Windows.Forms
Public Class frm_reporte_apartado
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
    Friend WithEvents CBCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeList As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents AdapterCliente As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsReportesApartados1 As LcPymes_5._2.DsReportesApartados
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_reporte_apartado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CBCliente = New System.Windows.Forms.ComboBox
        Me.lblCliente = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboMonedas = New System.Windows.Forms.ComboBox
        Me.lblTipoCambio = New System.Windows.Forms.Label
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.TreeList = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AdapterCliente = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsReportesApartados1 = New LcPymes_5._2.DsReportesApartados
        Me.GroupBox1.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsReportesApartados1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.CBCliente)
        Me.GroupBox1.Controls.Add(Me.lblCliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMonedas)
        Me.GroupBox1.Controls.Add(Me.lblTipoCambio)
        Me.GroupBox1.Controls.Add(Me.TreeList1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 520)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'CBCliente
        '
        Me.CBCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CBCliente.DisplayMember = "nombre"
        Me.CBCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCliente.Enabled = False
        Me.CBCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCliente.ForeColor = System.Drawing.Color.Blue
        Me.CBCliente.ItemHeight = 13
        Me.CBCliente.Location = New System.Drawing.Point(224, 318)
        Me.CBCliente.Name = "CBCliente"
        Me.CBCliente.Size = New System.Drawing.Size(186, 21)
        Me.CBCliente.TabIndex = 70
        Me.CBCliente.ValueMember = "identificacion"
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCliente.Location = New System.Drawing.Point(224, 302)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(188, 16)
        Me.lblCliente.TabIndex = 71
        Me.lblCliente.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label4.Location = New System.Drawing.Point(8, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Hasta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(8, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FechaFinal
        '
        Me.FechaFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FechaFinal.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        Me.FechaFinal.Enabled = False
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaFinal.Location = New System.Drawing.Point(8, 414)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(184, 20)
        Me.FechaFinal.TabIndex = 67
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FechaInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss tt"
        Me.FechaInicio.Enabled = False
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaInicio.Location = New System.Drawing.Point(8, 366)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(184, 20)
        Me.FechaInicio.TabIndex = 66
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        Me.FechaInicio.Visible = False
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonMostrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ButtonMostrar.ImageIndex = 0
        Me.ButtonMostrar.Location = New System.Drawing.Point(8, 470)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(184, 48)
        Me.ButtonMostrar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.InactiveCaptionText, System.Drawing.Color.RoyalBlue)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar Reporte"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(8, 438)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 20)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Moneda"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMonedas
        '
        Me.cboMonedas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboMonedas.DisplayMember = "MonedaNombre"
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.Location = New System.Drawing.Point(96, 438)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(96, 21)
        Me.cboMonedas.TabIndex = 41
        Me.cboMonedas.ValueMember = "ValorCompra"
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.Location = New System.Drawing.Point(624, 88)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(100, 8)
        Me.lblTipoCambio.TabIndex = 42
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeList})
        Me.TreeList1.Location = New System.Drawing.Point(2, 8)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.BeginUnboundLoad()
        Me.TreeList1.AppendNode(New Object() {"Generales"}, -1, 2, 3, -1)
        Me.TreeList1.AppendNode(New Object() {"Pendientes"}, 0, 1, 0, 0)
        Me.TreeList1.AppendNode(New Object() {"Vencidos"}, 0, 1, 0, -1)
        Me.TreeList1.EndUnboundLoad()
        Me.TreeList1.PrintOptions = CType((((((DevExpress.XtraTreeList.PrintOptionsFlags.PrintPageHeader Or DevExpress.XtraTreeList.PrintOptionsFlags.PrintTree) _
                    Or DevExpress.XtraTreeList.PrintOptionsFlags.PrintTreeButtons) _
                    Or DevExpress.XtraTreeList.PrintOptionsFlags.PrintImages) _
                    Or DevExpress.XtraTreeList.PrintOptionsFlags.AutoWidth) _
                    Or DevExpress.XtraTreeList.PrintOptionsFlags.AutoRowHeight), DevExpress.XtraTreeList.PrintOptionsFlags)
        Me.TreeList1.RootValue = "0"
        Me.TreeList1.Size = New System.Drawing.Size(195, 286)
        Me.TreeList1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyle("SelectedRow", "TreeList", New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType(((((DevExpress.Utils.StyleOptions.UseBackColor Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText))
        Me.TreeList1.TabIndex = 65
        Me.TreeList1.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None
        '
        'TreeList
        '
        Me.TreeList.Caption = "Tipos Reporte"
        Me.TreeList.FieldName = "TreeListColumn1"
        Me.TreeList.Name = "TreeList"
        Me.TreeList.Options = CType(((((((DevExpress.XtraTreeList.Columns.ColumnOptions.CanMoved Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanMovedToCustomizationForm), DevExpress.XtraTreeList.Columns.ColumnOptions)
        Me.TreeList.visibleIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(208, 8)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(576, 520)
        Me.CrystalReportViewer1.TabIndex = 80
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-T96OM6J"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""DESKTOP-T96OM6J\DESARROLLO"";persist security info=False;initial catalog=s" & _
        "eepos"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(48, 48)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'AdapterCliente
        '
        Me.AdapterCliente.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterCliente.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterCliente.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterCliente.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Clientes_frecuentes", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("identificacion", "identificacion"), New System.Data.Common.DataColumnMapping("nombre", "nombre")})})
        Me.AdapterCliente.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Clientes_frecuentes WHERE (identificacion = @Original_identificacion)" & _
        " AND (nombre = @Original_nombre)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Clientes_frecuentes(identificacion, nombre) VALUES (@identificacion, " & _
        "@nombre); SELECT identificacion, nombre FROM Clientes_frecuentes WHERE (identifi" & _
        "cacion = @identificacion)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT identificacion, nombre FROM Clientes_frecuentes"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Clientes_frecuentes SET identificacion = @identificacion, nombre = @nombre" & _
        " WHERE (identificacion = @Original_identificacion) AND (nombre = @Original_nombr" & _
        "e); SELECT identificacion, nombre FROM Clientes_frecuentes WHERE (identificacion" & _
        " = @identificacion)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'daMoneda
        '
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand2
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'DsReportesApartados1
        '
        Me.DsReportesApartados1.DataSetName = "DsReportesApartados"
        Me.DsReportesApartados1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'frm_reporte_apartado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frm_reporte_apartado"
        Me.Text = "frm_reporte_apartado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsReportesApartados1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frm_reporte_apartado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            daMoneda.Fill(DsReportesApartados1, "moneda")
            AdapterCliente.Fill(DsReportesApartados1, "Clientes")
            FechaInicio.Value = Now
            FechaFinal.Value = Now
            TreeList1.FullExpand()

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "variables"
    Dim Reporte_ID As Byte
#End Region

#Region "Controles Funciones"
    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Mostrar()
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        Reporte_ID = e.Node.Id
        Reporte_Seleccionado()
    End Sub

    Private Sub FechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            FechaFinal.Focus()
        End If
    End Sub

    Private Sub FechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mostrar()
        End If
    End Sub

    Private Sub cboMonedas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMonedas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mostrar()
        End If
    End Sub


    Private Sub CBCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBCliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Fx As New cFunciones
            Dim valor As String

            AdapterCliente.Fill(DsReportesApartados1, "Clientes")
            valor = Fx.BuscarDatos("Select Identificacion,Nombre from Clientes", "Nombre", "Buscar cliente...")

            If valor = "" Then
                CBCliente.SelectedIndex = -1
            Else
                CBCliente.SelectedValue = CInt(valor)
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            FechaFinal.Focus()
        End If
    End Sub
#End Region

#Region "Funciones"
    Private Sub Mostrar()
        '0	-	1	Pendientes Generales
        '1	-	2	Vencidos Generales
        '3	-	4	Pendientes por Cliente
        '4	-	5	Vencidos por Cliente

        Try
            Select Case Reporte_ID
                Case 1 '0 'Pendientes Generales
                    Dim rpt As New ReporteapartadosSaldos
                    rpt.SetParameterValue(0, Me.FechaInicio.Value)
                    rpt.SetParameterValue(1, Me.FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, rpt)

                Case 2 '1 'Vencidos Generales
                    Dim rpt As New Reporteapartados
                    rpt.SetParameterValue(0, Me.FechaFinal.Value)
                    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, rpt)

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Reporte_Seleccionado()
        '0	-	1	Pendientes Generales
        '1	-	2	Vencidos Generales
        '3	-	4	Pendientes por Cliente
        '4	-	5	Vencidos por Cliente

        FechaInicio.Visible = True
        FechaFinal.Visible = True
        FechaInicio.Enabled = True
        FechaFinal.Enabled = True
        CBCliente.Enabled = False

        Select Case Reporte_ID
            Case 1 '0 'Pendientes Generales
                ButtonMostrar.Focus()

            Case 2 '1 'Vencidos Generales                
                FechaInicio.Enabled = False
                ButtonMostrar.Focus()
        End Select
    End Sub
#End Region

    Private Sub FechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaInicio.ValueChanged

    End Sub
End Class
