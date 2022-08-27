Public Class frm_reporte_taller
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
    Friend WithEvents cboOpcion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.cboOpcion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.VisorReporte.Location = New System.Drawing.Point(0, 64)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(664, 448)
        Me.VisorReporte.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(152, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(40, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Desde"
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinal.Location = New System.Drawing.Point(152, 32)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 109
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(40, 32)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 108
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(435, 28)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 24)
        Me.ButtonMostrar.TabIndex = 110
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=192.168.0.2;packet size=4096;integrated security=SSPI;data source=" & _
    "192.168.0.2;persist security info=False;initial catalog=Seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'cboOpcion
        '
        Me.cboOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOpcion.FormattingEnabled = True
        Me.cboOpcion.Items.AddRange(New Object() {"Reporte de Ventas Taller", "Reporte de Series Disponibles"})
        Me.cboOpcion.Location = New System.Drawing.Point(254, 31)
        Me.cboOpcion.Name = "cboOpcion"
        Me.cboOpcion.Size = New System.Drawing.Size(161, 21)
        Me.cboOpcion.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(254, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 16)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Opcion"
        '
        'frm_reporte_taller
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 426)
        Me.Controls.Add(Me.cboOpcion)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FechaFinal)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_reporte_taller"
        Me.Text = "Reporte de ventas taller"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Katty As Boolean = False
    Private Sub esKatty()

        Dim katty As String = ""
        katty = GetSetting("SeeSOFT", "SeePOS", "Katty")

        If katty = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "Katty", "0")
            katty = 0
        End If

        If katty = "1" Then 'si es katty
            'Cambia las descripciones
            Me.Katty = True
            Me.Text = "Reporte de Ventas de Shampoo"
        Else 'de lo contrario
            'todo queda normal
            Me.Katty = False
        End If
    End Sub


    Private Sub frm_reporte_taller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.esKatty()
        Me.cboOpcion.SelectedIndex = 0
        SqlConnection1.ConnectionString = CadenaConexionSeePOS()
        FechaInicio.Value = Now.Date
        FechaFinal.Value = Now.Date

        If Me.Obtener_BasedeDatos.ToLower = "mascotas".ToLower Then
            Me.Text = "Reporte de ventas Groomer"
        End If

    End Sub

    Private Function Obtener_BasedeDatos() As String
        Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
        Dim Texto As String = Conexion(1)

        Dim Resultado As String = ""
        Dim inicia As Boolean = False
        For Each c As Char In Texto
            If inicia = True Then
                If c <> ";" Then
                    Resultado += c
                End If
            End If
            If c = "=" Then inicia = True
        Next
        Return Resultado.ToLower
    End Function

    '3101299973
    'grupo inversionista rems
    '868
    '83742544
    'marlent
    '*******************************************
    '
    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        If Me.cboOpcion.SelectedIndex = 0 Then
            Dim rpt As New Reporte_ventas_taller
            rpt.SetParameterValue(0, Me.FechaInicio.Value)
            rpt.SetParameterValue(1, Me.FechaFinal.Value)
            If Me.Katty = False Then
                rpt.SetParameterValue(2, IIf(Obtener_BasedeDatos() = "mascotas", "Groomer".ToUpper, "Taller".ToUpper))
            Else
                rpt.SetParameterValue(2, "Shampoo")
            End If
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        Else
            Dim rpt As New rptSerie
            rpt.Refresh()
            CrystalReportsConexion.LoadReportViewer(VisorReporte, rpt, , SqlConnection1.ConnectionString)
            VisorReporte.Show()
        End If
    End Sub

    Private Sub cboOpcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpcion.SelectedIndexChanged
        If Me.cboOpcion.SelectedIndex = 0 Then
            Me.FechaInicio.Enabled = True
            Me.FechaFinal.Enabled = True
        Else
            Me.FechaInicio.Enabled = False
            Me.FechaFinal.Enabled = False
        End If
    End Sub
End Class

