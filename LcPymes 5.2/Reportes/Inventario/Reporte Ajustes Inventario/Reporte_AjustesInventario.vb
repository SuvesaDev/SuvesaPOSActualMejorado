Imports System.Data
Imports System.Data.SqlClient
Public Class Reporte_AjustesInventario
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fecha_1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents fecha_2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv_anulados As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.fecha_1 = New System.Windows.Forms.DateTimePicker
        Me.fecha_2 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgv_anulados = New System.Windows.Forms.DataGrid
        CType(Me.dgv_anulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(264, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Final:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'fecha_1
        '
        Me.fecha_1.Location = New System.Drawing.Point(96, 16)
        Me.fecha_1.Name = "fecha_1"
        Me.fecha_1.Size = New System.Drawing.Size(104, 20)
        Me.fecha_1.TabIndex = 1
        '
        'fecha_2
        '
        Me.fecha_2.Location = New System.Drawing.Point(344, 16)
        Me.fecha_2.Name = "fecha_2"
        Me.fecha_2.Size = New System.Drawing.Size(104, 20)
        Me.fecha_2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Buscar"
        '
        'dgv_anulados
        '
        Me.dgv_anulados.DataMember = ""
        Me.dgv_anulados.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgv_anulados.Location = New System.Drawing.Point(24, 64)
        Me.dgv_anulados.Name = "dgv_anulados"
        Me.dgv_anulados.Size = New System.Drawing.Size(616, 232)
        Me.dgv_anulados.TabIndex = 7
        '
        'Reporte_AjustesInventario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 333)
        Me.Controls.Add(Me.dgv_anulados)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fecha_2)
        Me.Controls.Add(Me.fecha_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Reporte_AjustesInventario"
        Me.Text = "Reporte Ajustes Inventario "
        CType(Me.dgv_anulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub rellenar_grid(ByVal ini As Date, ByVal fin As Date)

        Dim SQL As New GestioDatos
        Dim sentencia As String = "Select CONSECUTIVO AS AJUSTE,ANULA AS [ANULADA] ,fecha AS [FECHA REGISTRO] ,descripcion AS DESCRIPCION,nombre as NOMBRE, ADMINISTRADOR as ADMINISTRADOR from dbo.Vw_Registro_AjustesInventario where fecha between '" & ini & "' and '" & fin & "' "

        dgv_anulados.DataSource = SQL.Ejecuta(sentencia)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim ini As Date = fecha_1.Text
        Dim fin As Date = fecha_2.Text
        rellenar_grid(ini, fin)
    End Sub

End Class
