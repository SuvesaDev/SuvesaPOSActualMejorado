Imports System.Data
Public Class frmBloqueaBodega
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DtsBloqueBodega1 As LcPymes_5._2.dtsBloqueBodega
    Friend WithEvents AdvBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBloquea As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DtsBloqueBodega1 = New LcPymes_5._2.dtsBloqueBodega
        Me.AdvBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colObservaciones = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colBloquea = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblNombre = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsBloqueBodega1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Bodegas"
        Me.GridControl1.DataSource = Me.DtsBloqueBodega1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Enabled = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.AdvBandedGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(760, 368)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.Text = "GridControl1"
        '
        'DtsBloqueBodega1
        '
        Me.DtsBloqueBodega1.DataSetName = "dtsBloqueBodega"
        Me.DtsBloqueBodega1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'AdvBandedGridView1
        '
        Me.AdvBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.AdvBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colDescripcion, Me.colObservaciones, Me.colBloquea})
        Me.AdvBandedGridView1.GroupPanelText = ""
        Me.AdvBandedGridView1.Name = "AdvBandedGridView1"
        Me.AdvBandedGridView1.OptionsView.ColumnAutoWidth = False
        Me.AdvBandedGridView1.OptionsView.ShowFilterPanel = False
        Me.AdvBandedGridView1.OptionsView.ShowGroupedColumns = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Listado de Inventario"
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Columns.Add(Me.colObservaciones)
        Me.GridBand1.Columns.Add(Me.colBloquea)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 735
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Bodega"
        Me.colDescripcion.FieldName = "Nombre_Bodega"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 211
        '
        'colObservaciones
        '
        Me.colObservaciones.Caption = "Observaciones"
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.Options = CType((((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colObservaciones.Visible = True
        Me.colObservaciones.Width = 369
        '
        'colBloquea
        '
        Me.colBloquea.Caption = "Bloquea"
        Me.colBloquea.FieldName = "bloqueada"
        Me.colBloquea.Name = "colBloquea"
        Me.colBloquea.Visible = True
        Me.colBloquea.Width = 155
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Bodegas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Bodega", "ID_Bodega"), New System.Data.Common.DataColumnMapping("Nombre_Bodega", "Nombre_Bodega"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("bloqueada", "bloqueada")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID_Bodega, Nombre_Bodega, Observaciones, bloqueada FROM Bodegas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""ROLANDO-PC"";packet size=4096;integrated security=SSPI;data source" & _
        "=""192.168.0.2"";persist security info=False;initial catalog=SeePos"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(424, 64)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guardar Cambios"
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(440, 416)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(312, 23)
        Me.lblNombre.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(600, 392)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(440, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Digite su Contraseña"
        '
        'frmBloqueaBodega
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 445)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmBloqueaBodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BloqueaBodega"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsBloqueBodega1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dts As New DataTable
    Private Sub frmBloqueaBodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS
        Me.SqlDataAdapter1.Fill(Me.DtsBloqueBodega1.Bodegas)
        Me.dts = Me.DtsBloqueBodega1.Bodegas.Copy
    End Sub
    Private usuario As String = ""
    Private Sub Valida(ByVal _pas As String)
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Cedula, Nombre from Usuarios where Clave_Interna = '" & _pas & "'", dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Me.lblNombre.Text = dts.Rows(0).Item("Nombre")
            Me.usuario = dts.Rows(0).Item("Cedula")
            If VerificandoAcceso_a_Modulos("Bloquea Bodegas", "Bloquea Bodegas", dts.Rows(0).Item("Cedula"), "Administración") = False Then
                Me.Button1.Enabled = False
                Me.GridControl1.Enabled = False
                MsgBox("El usuario no tiene el permiso para realizar esta operacion", MsgBoxStyle.Exclamation, Text)
            Else
                Me.Button1.Enabled = True
                Me.GridControl1.Enabled = True
            End If
        Else
            Me.Button1.Enabled = False
            Me.GridControl1.Enabled = False
            Me.lblNombre.Text = " -  -  -  -  -"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim db As New GestioDatos
            For X As Integer = 0 To Me.DtsBloqueBodega1.Bodegas.Rows.Count - 1
                If Me.DtsBloqueBodega1.Bodegas(X).bloqueada = True Then
                    db.Ejecuta("update bodegas set bloqueada = 1 where ID_Bodega = " & Me.DtsBloqueBodega1.Bodegas(X).ID_Bodega)
                    db.Ejecuta("insert into bitacora_bloqueos(ini, obs, usuario) values(getdate(), 'bloqueo bodega " & Me.DtsBloqueBodega1.Bodegas(X).Nombre_Bodega & "', '" & usuario & "')")
                    db.Ejecuta("update inventario set bloqueado = 1 where id_bodega = " & Me.DtsBloqueBodega1.Bodegas(X).ID_Bodega)
                Else
                    db.Ejecuta("update bodegas set bloqueada = 0 where ID_Bodega = " & Me.DtsBloqueBodega1.Bodegas(X).ID_Bodega)
                    db.Ejecuta("insert into bitacora_bloqueos(ini, obs, usuario) values(getdate(), 'desbloqueo bodega " & Me.DtsBloqueBodega1.Bodegas(X).Nombre_Bodega & "', '" & usuario & "')")
                    db.Ejecuta("update inventario set bloqueado = 0 where id_bodega = " & Me.DtsBloqueBodega1.Bodegas(X).ID_Bodega)
                End If
            Next
            MsgBox("Datos almacenados Correctamente", MsgBoxStyle.Information, Text)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Me.Valida(Me.TextBox1.Text)
        End If        
    End Sub

End Class
