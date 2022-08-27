Imports System.Data.SqlClient
Imports System.data

Public Class BuscarCierreCaja
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Numapertura As System.Windows.Forms.Label
    Friend WithEvents CkeckBuscaFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dscierrecaja1 As Dscierrecaja
    Friend WithEvents colCajera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Numapertura = New System.Windows.Forms.Label
        Me.Dscierrecaja1 = New Dscierrecaja
        Me.CkeckBuscaFecha = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox
        Me.ButtonCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCajera = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker
        Me.ButtonAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker
        CType(Me.Dscierrecaja1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numapertura
        '
        Me.Numapertura.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Numapertura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dscierrecaja1, "cierrecaja.NumeroCierre"))
        Me.Numapertura.Location = New System.Drawing.Point(488, 232)
        Me.Numapertura.Name = "Numapertura"
        Me.Numapertura.Size = New System.Drawing.Size(72, 16)
        Me.Numapertura.TabIndex = 18
        '
        'Dscierrecaja1
        '
        Me.Dscierrecaja1.DataSetName = "Dscierrecaja"
        Me.Dscierrecaja1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'CkeckBuscaFecha
        '
        Me.CkeckBuscaFecha.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.CkeckBuscaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkeckBuscaFecha.ForeColor = System.Drawing.Color.White
        Me.CkeckBuscaFecha.Location = New System.Drawing.Point(8, 232)
        Me.CkeckBuscaFecha.Name = "CkeckBuscaFecha"
        Me.CkeckBuscaFecha.Size = New System.Drawing.Size(176, 14)
        Me.CkeckBuscaFecha.TabIndex = 14
        Me.CkeckBuscaFecha.Text = "Buscar entre las Fechas"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(424, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "# Cierre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nombre Cajero(a)...."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBuscar.Location = New System.Drawing.Point(192, 216)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(369, 13)
        Me.TextBoxBuscar.TabIndex = 13
        Me.TextBoxBuscar.Text = ""
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(632, 216)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(64, 32)
        Me.ButtonCancelar.TabIndex = 17
        Me.ButtonCancelar.Text = "Cancelar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "cierrecaja"
        Me.GridControl1.DataSource = Me.Dscierrecaja1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(696, 208)
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.SystemColors.HotTrack, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 9
        Me.GridControl1.Text = "GridControl"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCajera, Me.colNombre, Me.colFecha})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'colCajera
        '
        Me.colCajera.Caption = "Cajera"
        Me.colCajera.FieldName = "Cajera"
        Me.colCajera.Name = "colCajera"
        Me.colCajera.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCajera.VisibleIndex = 0
        Me.colCajera.Width = 135
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 419
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFecha.VisibleIndex = 2
        Me.colFecha.Width = 120
        '
        'Fecha2
        '
        Me.Fecha2.CustomFormat = "dd/MM/yyyy"
        Me.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha2.Location = New System.Drawing.Point(312, 232)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(88, 20)
        Me.Fecha2.TabIndex = 12
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(568, 216)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(64, 32)
        Me.ButtonAceptar.TabIndex = 16
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'Fecha1
        '
        Me.Fecha1.CustomFormat = "dd/MM/yyyy"
        Me.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha1.Location = New System.Drawing.Point(192, 232)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(88, 20)
        Me.Fecha1.TabIndex = 10
        '
        'BuscarCierreCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 254)
        Me.Controls.Add(Me.Numapertura)
        Me.Controls.Add(Me.CkeckBuscaFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Fecha2)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Fecha1)
        Me.Name = "BuscarCierreCaja"
        Me.Text = "Buscar Cierre Caja"
        CType(Me.Dscierrecaja1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        If TextBoxBuscar.Text.Length > 2 Then
            If Me.CkeckBuscaFecha.Checked = False Then
                BuscarApertura(Me.TextBoxBuscar.Text)
            End If
        Else
            Me.Dscierrecaja1.cierrecaja.Clear()
        End If
    End Sub

    Function BuscarApertura(ByVal Descripcion As String)
        Dim cnn As SqlConnection = Nothing
        Dim sel As String

        Me.Dscierrecaja1.cierrecaja.Clear()

        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Hotel", "Hotel", "CONEXION")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "select * from cierrecaja WHERE Nombre like '%" & Descripcion & "%'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            cmd.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar))
            cmd.Parameters("@Descripcion").Value = Descripcion
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.Dscierrecaja1.cierrecaja)
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally

            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function

    Private Sub CkeckBuscaFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkeckBuscaFecha.CheckedChanged
        If CkeckBuscaFecha.Checked = True Then
            'Panel1.Enabled = True
            TextBoxBuscar.Text = ""
            TextBoxBuscar.Enabled = False
            Me.Dscierrecaja1.cierrecaja.Clear()
        Else
            'Panel1.Enabled = False
            TextBoxBuscar.Enabled = True
            Me.Dscierrecaja1.cierrecaja.Clear()
        End If
    End Sub

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        If Me.Dscierrecaja1.cierrecaja.Count > 0 Then
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("No se obtuvieron resultados")
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub BuscarCierreCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
