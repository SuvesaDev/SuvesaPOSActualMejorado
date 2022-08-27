Imports System.Windows.Forms
Public Class frm_reporte_muertes
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
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ck_general As System.Windows.Forms.CheckBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ck_general = New System.Windows.Forms.CheckBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
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
        Me.VisorReporte.Location = New System.Drawing.Point(8, 64)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ReportSource = Nothing
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(664, 448)
        Me.VisorReporte.TabIndex = 113
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(240, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(128, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Desde"
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaFinal.Location = New System.Drawing.Point(240, 32)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 115
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaInicio.Location = New System.Drawing.Point(128, 32)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 114
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(352, 24)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 24)
        Me.ButtonMostrar.TabIndex = 116
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(8, 32)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.TabIndex = 119
        Me.txtcod.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Codigo"
        '
        'ck_general
        '
        Me.ck_general.Location = New System.Drawing.Point(456, 24)
        Me.ck_general.Name = "ck_general"
        Me.ck_general.TabIndex = 120
        Me.ck_general.Text = "General"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-8M1A70L"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""DESKTOP-8M1A70L"";persist security info=False;initial catalog=seepos"
        '
        'frm_reporte_muertes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 441)
        Me.Controls.Add(Me.ck_general)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FechaFinal)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_reporte_muertes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de muerte de animales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frm_reporte_muertes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New Reporte_muerte_animales
        Dim rpt_general As New Reporte_muerte_animales_general

        If Me.ck_general.Checked = True Then
            rpt_general.SetParameterValue(0, Me.FechaInicio.Value)
            rpt_general.SetParameterValue(1, Me.FechaFinal.Value)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt_general, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        Else
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            rpt.SetParameterValue(2, Me.txtcod.Text)
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        End If

    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged

    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If e.KeyCode = Keys.F1 Then
            consultar()
        End If
    End Sub
    Private Sub consultar()
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.CheckBoxInHabilitados.Enabled = True
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        Me.txtcod.Text = BuscarArt.Codigo
    End Sub
End Class
