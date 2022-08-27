Imports System.Windows.Forms
Public Class frm_reporte_agentes
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_agente As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_agente = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(128, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(16, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Desde"
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaFinal.Location = New System.Drawing.Point(128, 16)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 97
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaInicio.Location = New System.Drawing.Point(16, 16)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 96
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(560, 8)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 24)
        Me.ButtonMostrar.TabIndex = 98
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'VisorReporte
        '
        Me.VisorReporte.ActiveViewIndex = -1
        Me.VisorReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorReporte.AutoScroll = True
        Me.VisorReporte.DisplayGroupTree = False
        Me.VisorReporte.Location = New System.Drawing.Point(8, 48)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ReportSource = Nothing
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(832, 400)
        Me.VisorReporte.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "identificación Agente:"
        '
        'txt_agente
        '
        Me.txt_agente.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_agente.Location = New System.Drawing.Point(400, 8)
        Me.txt_agente.Name = "txt_agente"
        Me.txt_agente.Size = New System.Drawing.Size(56, 23)
        Me.txt_agente.TabIndex = 102
        Me.txt_agente.Text = ""
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=192.168.0.2;packet size=4096;integrated security=SSPI;data source=" & _
        "192.168.0.2;persist security info=False;initial catalog=Seepos"
        '
        'frm_reporte_agentes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 450)
        Me.Controls.Add(Me.txt_agente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FechaFinal)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.VisorReporte)
        Me.Name = "frm_reporte_agentes"
        Me.Text = "Reporte de ventas de Agentes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub txt_agente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_agente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            Dim c As String

            c = cFunciones.BuscarDatos("select id as id,nombre as Nombre from agente_ventas where anulado = 0", "Nombre")
            If c <> "" Then
                Me.txt_agente.Text = c
            Else
                Exit Sub
            End If
        End If
    End Sub


    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Dim rpt As New Ventas_Detalladas_agentes
        rpt.SetParameterValue(0, 1)
        rpt.SetParameterValue(1, Me.FechaInicio.Value)
        rpt.SetParameterValue(2, Me.FechaFinal.Value)
        rpt.SetParameterValue(3, Me.txt_agente.Text)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
        VisorReporte.Show()
    End Sub
    Private Sub frm_reporte_agentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date
    End Sub
End Class
