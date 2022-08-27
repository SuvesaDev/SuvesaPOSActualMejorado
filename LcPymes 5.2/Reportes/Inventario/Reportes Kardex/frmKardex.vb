Imports System.Windows.Forms

Public Class FrmKardex
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
    Friend WithEvents LbTipoCambio As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents daMonedas As System.Data.SqlClient.SqlDataAdapter

    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Combo_Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet_Kardex1 As DataSet_Kardex
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label_TipoCambio As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ButtonMostrar As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ckConsignacion As System.Windows.Forms.CheckBox
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKardex))
        Me.LbTipoCambio = New System.Windows.Forms.Label()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonMostrar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label_TipoCambio = New System.Windows.Forms.Label()
        Me.DataSet_Kardex1 = New LcPymes_5._2.DataSet_Kardex()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combo_Moneda = New System.Windows.Forms.ComboBox()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.daMonedas = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ckConsignacion = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet_Kardex1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbTipoCambio
        '
        Me.LbTipoCambio.Location = New System.Drawing.Point(512, 120)
        Me.LbTipoCambio.Name = "LbTipoCambio"
        Me.LbTipoCambio.Size = New System.Drawing.Size(100, 23)
        Me.LbTipoCambio.TabIndex = 75
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
        Me.VisorReporte.Location = New System.Drawing.Point(0, 96)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(790, 464)
        Me.VisorReporte.TabIndex = 76
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.ckConsignacion)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.Label_TipoCambio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Combo_Moneda)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lblFechaInicio)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(790, 88)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMostrar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonMostrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonMostrar.ImageIndex = 0
        Me.ButtonMostrar.ImageList = Me.ImageList1
        Me.ButtonMostrar.Location = New System.Drawing.Point(528, 10)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(65, 72)
        Me.ButtonMostrar.TabIndex = 42
        Me.ButtonMostrar.Text = "Mostrar"
        Me.ButtonMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonMostrar.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'Label_TipoCambio
        '
        Me.Label_TipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Kardex1, "Moneda.ValorCompra", True))
        Me.Label_TipoCambio.Location = New System.Drawing.Point(400, 32)
        Me.Label_TipoCambio.Name = "Label_TipoCambio"
        Me.Label_TipoCambio.Size = New System.Drawing.Size(72, 16)
        Me.Label_TipoCambio.TabIndex = 40
        '
        'DataSet_Kardex1
        '
        Me.DataSet_Kardex1.DataSetName = "DataSet_Kardex"
        Me.DataSet_Kardex1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSet_Kardex1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(280, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Moneda"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Combo_Moneda
        '
        Me.Combo_Moneda.DataSource = Me.DataSet_Kardex1
        Me.Combo_Moneda.DisplayMember = "Moneda.MonedaNombre"
        Me.Combo_Moneda.Location = New System.Drawing.Point(280, 32)
        Me.Combo_Moneda.Name = "Combo_Moneda"
        Me.Combo_Moneda.Size = New System.Drawing.Size(112, 21)
        Me.Combo_Moneda.TabIndex = 38
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinal.Location = New System.Drawing.Point(72, 35)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 37
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(72, 16)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 36
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'lblCodigo
        '
        Me.lblCodigo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCodigo.Location = New System.Drawing.Point(184, 24)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(64, 13)
        Me.lblCodigo.TabIndex = 32
        Me.lblCodigo.Text = "Código"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(184, 40)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(64, 13)
        Me.txtCodigo.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Consultar por:"
        '
        'lblHasta
        '
        Me.lblHasta.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblHasta.Location = New System.Drawing.Point(8, 38)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(56, 16)
        Me.lblHasta.TabIndex = 25
        Me.lblHasta.Text = "Hasta"
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFechaInicio.Location = New System.Drawing.Point(8, 19)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(56, 16)
        Me.lblFechaInicio.TabIndex = 24
        Me.lblFechaInicio.Text = "Desde"
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=(local);packet size=4096;integrated security=SSPI;data source=(loc" & _
    "al);persist security info=False;initial catalog=Proveeduria"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'daMonedas
        '
        Me.daMonedas.DeleteCommand = Me.SqlDeleteCommand1
        Me.daMonedas.InsertCommand = Me.SqlInsertCommand1
        Me.daMonedas.SelectCommand = Me.SqlSelectCommand1
        Me.daMonedas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra")})})
        Me.daMonedas.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
    "riginal_MonedaNombre) AND (ValorCompra = @Original_ValorCompra)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra) VALUES (@CodMoneda, @Mon" & _
    "edaNombre, @ValorCompra); SELECT CodMoneda, MonedaNombre, ValorCompra FROM Moned" & _
    "a WHERE (CodMoneda = @CodMoneda)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ckConsignacion
        '
        Me.ckConsignacion.AutoSize = True
        Me.ckConsignacion.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ckConsignacion.Location = New System.Drawing.Point(6, 57)
        Me.ckConsignacion.Name = "ckConsignacion"
        Me.ckConsignacion.Size = New System.Drawing.Size(209, 17)
        Me.ckConsignacion.TabIndex = 43
        Me.ckConsignacion.Text = "Mostrar Kardex de Consignacion"
        Me.ckConsignacion.UseVisualStyleBackColor = False
        '
        'FrmKardex
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 564)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbTipoCambio)
        Me.Name = "FrmKardex"
        Me.Text = "Visualiazdor de Kardex"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet_Kardex1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub consultar()
        Dim BuscarArticulo As New FrmBuscarArticulo2
        BuscarArticulo.ShowDialog()
        If BuscarArticulo.Cancelado Then
            Me.txtCodigo.Focus()
        Else
            Me.txtCodigo.Text = BuscarArticulo.Codigo
            'Me.cbxMoneda.Focus()
        End If
    End Sub
    Private Sub Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SqlConnection.ConnectionString = CadenaConexionSeePOS
            Me.daMonedas.Fill(Me.DataSet_Kardex1.Moneda)

            Me.FechaInicio.Text = Date.Today
            Me.FechaFinal.Text = Date.Today
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            consultar()
        End If
    End Sub

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Try
            Me.ButtonMostrar.Enabled = False
            Dim Reporte As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim Titulo As String = ""
            If Me.ckConsignacion.Checked = False Then
                Reporte = New Rpt_Kardex
                Titulo = "Reporte KARDEX desde el '" & Me.FechaInicio.Text & "' hasta el '" & Me.FechaFinal.Text & "' MONEDA: " & Me.Combo_Moneda.Text
            Else
                Reporte = New Rpt_KardexConsignacion
                Titulo = "Reporte KARDEX de Consignacion desde el '" & Me.FechaInicio.Text & "' hasta el '" & Me.FechaFinal.Text & "' MONEDA: " & Me.Combo_Moneda.Text
            End If
            Reporte.SetParameterValue(0, Titulo)
            Reporte.SetParameterValue(1, CDbl(Me.Label_TipoCambio.Text))
            Reporte.SetParameterValue(2, CDate(Me.FechaInicio.Value))
            Reporte.SetParameterValue(3, CDate(Me.FechaFinal.Value))
            Reporte.SetParameterValue(4, CDbl(Me.txtCodigo.Text))
            CrystalReportsConexion.LoadReportViewer(VisorReporte, Reporte)
            VisorReporte.Show()
            Me.ButtonMostrar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.ButtonMostrar.Enabled = True
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If

        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class
