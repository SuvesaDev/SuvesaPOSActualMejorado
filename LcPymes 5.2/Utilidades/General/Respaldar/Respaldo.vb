Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class FrmRespaldo
    Inherits System.Windows.Forms.Form
    Public Sistema As String = "Seepos"
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal pSistemas As String)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Sistema = pSistemas
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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(8, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Respaldar Base de Datos"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=LUIFER;packet size=4096;integrated security=SSPI;initial catalog=H" & _
        "otel;persist security info=False"
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "dbo.[RespaldoBaseDatos]"
        Me.SqlCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ruta", System.Data.SqlDbType.VarChar, 255))
        '
        'FrmRespaldo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(248, 70)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(254, 102)
        Me.MinimumSize = New System.Drawing.Size(254, 102)
        Me.Name = "FrmRespaldo"
        Me.Text = "Respaldo Base Datos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Respaldo de Base Datos"
    Function Respaldo(ByVal Ruta As String) As Double
        Dim cnn As SqlConnection = Nothing
        Dim sele As String
        'Dim s As String
        's = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = GetSetting("SeeSOFT", Sistema, "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sele = "EXEC dbo.RespaldoBaseDatos @Ruta"
            cmd.CommandText = sele
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Ruta", SqlDbType.VarChar))
            'cmd.Parameters.Add(New SqlParameter("@FechaSalida", SqlDbType.DateTime))
            cmd.Parameters("@Ruta").Value = Ruta

            'cmd.Parameters("@FechaSalida").Value = FechaSalida.Date.ToUniversalTime.ToString(s)
            cmd.ExecuteNonQuery()

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd

            MsgBox("El respaldo de la Base de Datos fue realizado satisfactoriamente", MsgBoxStyle.Information)

            ' Llenamos la tabla
            'Tabla.Clear()
            'da.Fill(Me.DataSetAsignacionHabitaciones1.HabitacionesLibres)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
        'Return Tabla.Rows(0).Item("Total")
    End Function
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Displays a SaveFileDialog so the user can save the Image
        'd to Button2.
        Dim Ruta As String
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "*.Bak|"
        saveFileDialog1.Title = "Save an Image File"
        saveFileDialog1.ShowDialog()

        If saveFileDialog1.FileName <> "" Then ' If the file name is not an empty string open it for saving.
            Ruta = saveFileDialog1.FileName
            Me.Respaldo(Ruta)
        End If
    End Sub
End Class
