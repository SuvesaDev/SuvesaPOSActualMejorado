Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data

Public Class Buscar
    Inherits System.Windows.Forms.Form
    Public Shared NuevaConexion As String



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
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    Friend WithEvents btnAceptar As DevExpress.XtraEditors.SimpleButton     'System.Windows.Forms.Button
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton  'System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dg = New System.Windows.Forms.DataGrid
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.btnAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.Color.CornflowerBlue
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.White
        Me.dg.CaptionText = "Resultado de la Búsqueda"
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dg.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.dg.LinkColor = System.Drawing.Color.Teal
        Me.dg.Location = New System.Drawing.Point(0, 0)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.PreferredColumnWidth = 150
        Me.dg.ReadOnly = True
        Me.dg.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dg.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.Size = New System.Drawing.Size(464, 288)
        Me.dg.TabIndex = 1
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtBusqueda.Location = New System.Drawing.Point(88, 290)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(376, 16)
        Me.txtBusqueda.TabIndex = 0
        Me.txtBusqueda.Text = ""
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(304, 312)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 24)
        Me.btnAceptar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.MidnightBlue)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(384, 312)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.MidnightBlue)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 290)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Busqueda  -->"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Buscar
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(464, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Buscar"
        Me.Opacity = 0.95
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda..."
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Public codigo As String
    Public descrip As String
    Public campo As String
    Public sqlstring As String
    Dim ds As DataSet
    Dim bandera As Boolean = False
#End Region

    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cConexion = New Conexion
        sqlConexion = New SqlConnection

        If NuevaConexion = "" Then
            sqlConexion = cConexion.Conectar
        Else
            sqlConexion.ConnectionString = NuevaConexion
            sqlConexion.Open()
        End If

        cargarInformacion("")
        Me.txtBusqueda.Focus()
    End Sub

    Private Sub cargarInformacion(ByVal sWhere As String)
        Try

        
            Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(sqlstring & sWhere, sqlConexion)
            Dim ds As New DataSet

            myCommand1.Fill(ds, "Informacion")

            If bandera = False Then
                Dim tbl As New DataGridTableStyle
                tbl.MappingName = "Informacion"

                Dim Column As New DataGridTextBoxColumn
                Column.MappingName = ds.Tables(0).Columns(0).Caption()
                Column.HeaderText = ds.Tables(0).Columns(0).Caption()
                Column.Width = 100
                Column.ReadOnly = True
                Column.Alignment = HorizontalAlignment.Center
                tbl.GridColumnStyles.Add(Column)


                Column = New DataGridTextBoxColumn
                Column.MappingName = ds.Tables(0).Columns(1).Caption()
                Column.HeaderText = ds.Tables(0).Columns(1).Caption()
                Column.Width = Me.dg.Width - tbl.GridColumnStyles(0).Width - 60
                Column.ReadOnly = True

                tbl.GridColumnStyles.Add(Column)
                dg.TableStyles.Add(tbl)
                tbl = Nothing
                bandera = True
            End If

            dg.DataSource = ds.Tables(0)
            ds = Nothing
            dg.AllowSorting = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click, dg.DoubleClick
        If dg.VisibleRowCount > 0 Then
            codigo = CStr(dg(dg.CurrentRowIndex, 0))
            descrip = CStr(dg(dg.CurrentRowIndex, 1))
        End If
        Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        If Len(txtBusqueda.Text) > 2 Then
            If sqlstring.IndexOf("where") > 0 Then

                cargarInformacion(" and " & campo & " like '%" & txtBusqueda.Text & "%'")
                txtBusqueda.Focus()
            Else

                cargarInformacion(" WHERE " & campo & " like '%" & txtBusqueda.Text & "%'")
                txtBusqueda.Focus()
            End If

        ElseIf Trim(txtBusqueda.Text) = vbNullString Then
            cargarInformacion("")
        End If
    End Sub

    Private Sub Buscar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        cConexion.DesConectar(sqlConexion)
        sqlConexion = Nothing
        cConexion = Nothing
    End Sub

    Private Sub txtBusqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            dg.Focus()
        End If
    End Sub

    Private Sub btnAceptar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnAceptar.KeyDown, dg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dg.VisibleRowCount > 0 Then
                codigo = CStr(dg(dg.CurrentRowIndex, 0))
                descrip = CStr(dg(dg.CurrentRowIndex, 1))
            End If
            Close()
        End If
    End Sub
End Class
