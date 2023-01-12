Imports System.Data
Imports System.Data.SqlClient
Public Class reporte_ventas_diarias
    Inherits System.Windows.Forms.Form
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection

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
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbooption As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbooption = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(144, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(10, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Desde"
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(442, 28)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(105, 37)
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
        Me.VisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VisorReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.VisorReporte.Location = New System.Drawing.Point(0, 74)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.SelectionFormula = ""
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(744, 424)
        Me.VisorReporte.TabIndex = 95
        Me.VisorReporte.ToolPanelWidth = 240
        Me.VisorReporte.ViewTimeSelectionFormula = ""
        '
        'cbooption
        '
        Me.cbooption.Items.AddRange(New Object() {"1", "2", "3 ", "General", "General Mensual"})
        Me.cbooption.Location = New System.Drawing.Point(278, 37)
        Me.cbooption.Name = "cbooption"
        Me.cbooption.Size = New System.Drawing.Size(144, 24)
        Me.cbooption.TabIndex = 101
        Me.cbooption.Text = "Seleccione..."
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(278, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 19)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Opción"
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""DESKTOP-T96OM6J"";packet size=4096;integrated security=SSPI;data s" & _
    "ource=""DESKTOP-T96OM6J\DESARROLLO"";persist security info=False;initial catalog=s" & _
    "eepos"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaFinal.Location = New System.Drawing.Point(144, 37)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(115, 22)
        Me.FechaFinal.TabIndex = 103
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaInicio.Location = New System.Drawing.Point(10, 37)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(115, 22)
        Me.FechaInicio.TabIndex = 102
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'reporte_ventas_diarias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(744, 497)
        Me.Controls.Add(Me.FechaFinal)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.cbooption)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.Label2)
        Me.Name = "reporte_ventas_diarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "reporte_ventas_diarias"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Try
            Dim rptdiarias As New Reporte_ventas_diarias_cajas

            Dim rptgeneral As New Reporte_ventas_diarias_general
            Dim rptgeneral_mensual As New Reporte_ventas_diarias_cajas_mensual

            If cbooption.Text = "Seleccione..." Then
                MsgBox("Seleccione una opcion para poder continuar.", MsgBoxStyle.Information, "Validación")
                Exit Sub
            End If
            If cbooption.Text = "General" Then
                rptgeneral.SetParameterValue(0, 1)
                rptgeneral.SetParameterValue(1, "REPORTE DE VENTAS GENERAL DIARIO DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "'")
                rptgeneral.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                rptgeneral.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                rptgeneral.SetParameterValue(4, 1)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rptgeneral, , SqlConnection2.ConnectionString)
                VisorReporte.Show()
            ElseIf cbooption.Text = "General Mensual" Then
                rptgeneral_mensual.SetParameterValue(0, 1)
                rptgeneral_mensual.SetParameterValue(1, "REPORTE DE VENTAS GENERAL MENSUAL DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "'")
                rptgeneral_mensual.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                rptgeneral_mensual.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                rptgeneral_mensual.SetParameterValue(4, 1)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rptgeneral_mensual, , SqlConnection2.ConnectionString)
                VisorReporte.Show()
            Else
                rptdiarias.SetParameterValue(0, 1)
                rptdiarias.SetParameterValue(1, "REPORTE DE VENTAS DIARIAS POR CAJA DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "'")
                rptdiarias.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                rptdiarias.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                rptdiarias.SetParameterValue(4, 1)
                rptdiarias.SetParameterValue(5, CInt(cbooption.Text))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rptdiarias, , SqlConnection2.ConnectionString)
                VisorReporte.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub reporte_ventas_diarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection2.ConnectionString = CadenaConexionSeePOS
        Me.FechaInicio.Text = Date.Today
        Me.FechaFinal.Text = Date.Today
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim rptdiarias As New Reporte_ventas_diarias_cajas
            Dim rptgeneral As New Reporte_ventas_diarias_general

            If cbooption.Text = "Seleccione..." Then
                MsgBox("Seleccione una opcion para poder continuar.", MsgBoxStyle.Information, "Validación")
                Exit Sub
            End If
            If cbooption.Text = "General" Then
                rptgeneral.SetParameterValue(0, 1)
                rptgeneral.SetParameterValue(1, "REPORTE DE VENTAS GENERAL DIARIO DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "'")
                rptgeneral.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                rptgeneral.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                rptgeneral.SetParameterValue(4, 1)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rptgeneral, , SqlConnection2.ConnectionString)
                VisorReporte.Show()
            Else
                rptdiarias.SetParameterValue(0, 1)
                rptdiarias.SetParameterValue(1, "REPORTE DE VENTAS DIARIAS POR CAJA DESDE EL '" & Me.FechaInicio.Text & "' HASTA EL '" & Me.FechaFinal.Text & "'")
                rptdiarias.SetParameterValue(2, CDate(Me.FechaInicio.Value))
                rptdiarias.SetParameterValue(3, CDate(Me.FechaFinal.Value))
                rptdiarias.SetParameterValue(4, 1)
                rptdiarias.SetParameterValue(5, CInt(cbooption.Text))
                CrystalReportsConexion.LoadReportViewer(VisorReporte, rptdiarias, , SqlConnection2.ConnectionString)
                VisorReporte.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class
