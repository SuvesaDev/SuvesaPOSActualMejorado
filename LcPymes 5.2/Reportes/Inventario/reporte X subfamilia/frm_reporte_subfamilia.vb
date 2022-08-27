Imports System.data
Public Class frm_reporte_subfamilia

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbxFamilia As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.cbxFamilia = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
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
        Me.VisorReporte.Location = New System.Drawing.Point(0, 64)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ReportSource = Nothing
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(736, 440)
        Me.VisorReporte.TabIndex = 96
        '
        'cbxFamilia
        '
        Me.cbxFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFamilia.Items.AddRange(New Object() {"GENERAL", "ENTREGADOS", "PENDIENTES"})
        Me.cbxFamilia.Location = New System.Drawing.Point(8, 24)
        Me.cbxFamilia.Name = "cbxFamilia"
        Me.cbxFamilia.Size = New System.Drawing.Size(296, 21)
        Me.cbxFamilia.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 16)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Sub Familia "
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=192.168.0.2;packet size=4096;integrated security=SSPI;data source=" & _
        "192.168.0.2;persist security info=False;initial catalog=Seepos"
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(312, 8)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 40)
        Me.ButtonMostrar.TabIndex = 119
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'frm_reporte_subfamilia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 505)
        Me.Controls.Add(Me.cbxFamilia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.ButtonMostrar)
        Me.Name = "frm_reporte_subfamilia"
        Me.Text = "Reporte Subfamilia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click

        Dim Reporte As New ConsultaInventario_subfamilia

        Reporte.SetParameterValue(0, "Reporte de Artículos por Sub Familia " & Me.cbxFamilia.Text & "")
        Reporte.SetParameterValue(1, 1)
        Reporte.SetParameterValue(2, 1)
        Reporte.SetParameterValue(3, Me.cbxFamilia.SelectedValue)
        CrystalReportsConexion.LoadReportViewer(VisorReporte, Reporte, , SqlConnection1.ConnectionString)
        VisorReporte.Show()

    End Sub

    Private Sub frm_reporte_subfamilia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dts As New DataTable
        Dim funciones As New cFunciones
        funciones.Llenar_Tabla_Generico("select codigo,descripcion from subfamilias order by descripcion asc", dts, CadenaConexionSeePOS)
        Me.cbxFamilia.DataSource = dts
        Me.cbxFamilia.DisplayMember = "descripcion"
        Me.cbxFamilia.ValueMember = "codigo"
    End Sub
End Class
