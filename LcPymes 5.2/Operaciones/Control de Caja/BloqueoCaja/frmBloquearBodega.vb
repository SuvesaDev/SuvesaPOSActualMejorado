Imports System.Data
Imports System.Data.SqlClient
Public Class frmBloquearBodega
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsBloqueaCaja1 As LcPymes_5._2.DsBloqueaCaja
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumApertura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsuario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBloqueada As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DsBloqueaCaja1 = New LcPymes_5._2.DsBloqueaCaja
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNumApertura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUsuario = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumCaja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBloqueada = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBloqueaCaja1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(272, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Digite su Contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(392, 248)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = ""
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(272, 272)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(240, 23)
        Me.lblNombre.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 56)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Guardar Cambios"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "viewCajasBloqueadas"
        Me.GridControl1.DataSource = Me.DsBloqueaCaja1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Top
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Enabled = False
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(522, 232)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.Text = "GridControl1"
        '
        'DsBloqueaCaja1
        '
        Me.DsBloqueaCaja1.DataSetName = "DsBloqueaCaja"
        Me.DsBloqueaCaja1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumApertura, Me.colFecha, Me.colUsuario, Me.colNumCaja, Me.colBloqueada})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNumApertura
        '
        Me.colNumApertura.Caption = "NumApertura"
        Me.colNumApertura.FieldName = "NApertura"
        Me.colNumApertura.Name = "colNumApertura"
        Me.colNumApertura.VisibleIndex = 0
        Me.colNumApertura.Width = 96
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 71
        '
        'colUsuario
        '
        Me.colUsuario.Caption = "Usuario"
        Me.colUsuario.FieldName = "Nombre"
        Me.colUsuario.Name = "colUsuario"
        Me.colUsuario.VisibleIndex = 2
        Me.colUsuario.Width = 172
        '
        'colNumCaja
        '
        Me.colNumCaja.Caption = "NumCaja"
        Me.colNumCaja.FieldName = "Num_Caja"
        Me.colNumCaja.Name = "colNumCaja"
        Me.colNumCaja.VisibleIndex = 3
        Me.colNumCaja.Width = 81
        '
        'colBloqueada
        '
        Me.colBloqueada.Caption = "Bloqueada"
        Me.colBloqueada.FieldName = "Bloqueada"
        Me.colBloqueada.Name = "colBloqueada"
        Me.colBloqueada.VisibleIndex = 4
        Me.colBloqueada.Width = 85
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "viewCajasBloqueadas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NApertura", "NApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Num_Caja", "Num_Caja"), New System.Data.Common.DataColumnMapping("Bloqueada", "Bloqueada")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO viewCajasBloqueadas(Fecha, Nombre, Num_Caja, Bloqueada) VALUES (@Fech" & _
        "a, @Nombre, @Num_Caja, @Bloqueada); SELECT NApertura, Fecha, Nombre, Num_Caja, B" & _
        "loqueada FROM viewCajasBloqueadas"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Caja", System.Data.SqlDbType.BigInt, 8, "Num_Caja"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Bloqueada", System.Data.SqlDbType.Bit, 1, "Bloqueada"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""ROLANDO-PC"";packet size=4096;integrated security=SSPI;data source" & _
        "=""ROLANDO-PC\SQL2008R2"";persist security info=False;initial catalog=SeePOS"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NApertura, Fecha, Nombre, Num_Caja, Bloqueada FROM viewCajasBloqueadas"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'frmBloquearBodega
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(522, 303)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBloquearBodega"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bloquear Caja"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBloqueaCaja1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim dts As New DataTable
    Private Sub frmBloqueaBodega_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = CadenaConexionSeePOS
        Me.SqlDataAdapter1.Fill(Me.DsBloqueaCaja1.viewCajasBloqueadas)
        Me.dts = Me.DsBloqueaCaja1.viewCajasBloqueadas.Copy
    End Sub
    Private usuario As String = ""
    Private Sub Valida(ByVal _pas As String)
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Cedula, Nombre from Usuarios where Clave_Interna = '" & _pas & "'", dts, CadenaConexionSeePOS)
        If dts.Rows.Count > 0 Then
            Me.lblNombre.Text = dts.Rows(0).Item("Nombre")
            Me.usuario = dts.Rows(0).Item("Cedula")
            If VerificandoAcceso_a_Modulos("Bloquea Caja", "Bloquea Caja", dts.Rows(0).Item("Cedula"), "Administración") = False Then
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
            For X As Integer = 0 To Me.DsBloqueaCaja1.viewCajasBloqueadas.Rows.Count - 1
                If Me.DsBloqueaCaja1.viewCajasBloqueadas(X).Bloqueada = True Then
                    db.Ejecuta("update aperturacaja set Estado = 'B' where NApertura = " & Me.DsBloqueaCaja1.viewCajasBloqueadas(X).NApertura)
                    'If dts.Rows(X).Item("Bloqueada") = False Then 'por aqui
                    'db.Ejecuta("insert into bitacora_bloqueos(ini, obs, usuario) values(getdate(), 'bloqueo bodega " & Me.DtsBloqueBodega1.Bodegas(X).Nombre_Bodega & "', '" & usuario & "')")
                    'db.Ejecuta("update inventario set bloqueado = 1 where id_bodega = " & Me.DtsBloqueBodega1.Bodegas(X).ID_Bodega)
                    'End If
                Else
                    db.Ejecuta("update aperturacaja set Estado = 'A' where NApertura = " & Me.DsBloqueaCaja1.viewCajasBloqueadas(X).NApertura)
                    'If dts.Rows(X).Item("bloqueada") = True Then
                    'db.Ejecuta("insert into bitacora_bloqueos(ini, obs, usuario) values(getdate(), 'desbloqueo bodega " & Me.DtsBloqueBodega1.Bodegas(X).Nombre_Bodega & "', '" & usuario & "')")
                    'db.Ejecuta("update inventario set bloqueado = 0 where id_bodega = " & Me.DtsBloqueBodega1.Bodegas(X).ID_Bodega)
                    'End If
                End If
            Next
            MsgBox("Datos almacenados Correctamente", MsgBoxStyle.Information, Text)
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
