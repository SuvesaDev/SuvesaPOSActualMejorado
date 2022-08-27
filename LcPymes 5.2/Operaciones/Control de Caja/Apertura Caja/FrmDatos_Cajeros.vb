Imports System.Windows.Forms

Public Class FrmDatos_Cajeros
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Public nombre_cajero As String
    Public cedula_cajero As String
#End Region

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
    Friend WithEvents TxtIdentificacion As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adapter_Cajeros_disponibles As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Combo_nom_cajero As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Aper_Caja1 As DataSet_Aper_Caja
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Combo_nom_cajero = New System.Windows.Forms.ComboBox
        Me.DataSet_Aper_Caja1 = New LcPymes_5._2.DataSet_Aper_Caja
        Me.TxtIdentificacion = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adapter_Cajeros_disponibles = New System.Data.SqlClient.SqlDataAdapter
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.DataSet_Aper_Caja1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(9, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cédula"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(9, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Combo_nom_cajero
        '
        Me.Combo_nom_cajero.DataSource = Me.DataSet_Aper_Caja1
        Me.Combo_nom_cajero.DisplayMember = "Vista_Cajeros_Disponibles_Abrir_Caja.Nombre"
        Me.Combo_nom_cajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_nom_cajero.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Combo_nom_cajero.Location = New System.Drawing.Point(73, 24)
        Me.Combo_nom_cajero.Name = "Combo_nom_cajero"
        Me.Combo_nom_cajero.Size = New System.Drawing.Size(360, 21)
        Me.Combo_nom_cajero.TabIndex = 0
        Me.Combo_nom_cajero.ValueMember = "Usuarios.Nombre"
        '
        'DataSet_Aper_Caja1
        '
        Me.DataSet_Aper_Caja1.DataSetName = "DataSet_Aper_Caja"
        Me.DataSet_Aper_Caja1.Locale = New System.Globalization.CultureInfo("es")
        '
        'TxtIdentificacion
        '
        Me.TxtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdentificacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet_Aper_Caja1, "Vista_Cajeros_Disponibles_Abrir_Caja.Cedula"))
        Me.TxtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentificacion.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtIdentificacion.Location = New System.Drawing.Point(73, 8)
        Me.TxtIdentificacion.Name = "TxtIdentificacion"
        Me.TxtIdentificacion.Size = New System.Drawing.Size(360, 16)
        Me.TxtIdentificacion.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(441, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(72, 21)
        Me.SimpleButton1.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Aceptar"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cedula, Nombre FROM Vista_Cajeros_Disponibles_Abrir_Caja"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SERVER;packet size=4096;user id=sa;data source=SERVER;persist secu" & _
        "rity info=False;initial catalog=Hotel"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Vista_Cajeros_Disponibles_Abrir_Caja(Cedula, Nombre) VALUES (@Cedula," & _
        " @Nombre); SELECT Cedula, Nombre FROM Vista_Cajeros_Disponibles_Abrir_Caja"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        '
        'Adapter_Cajeros_disponibles
        '
        Me.Adapter_Cajeros_disponibles.InsertCommand = Me.SqlInsertCommand1
        Me.Adapter_Cajeros_disponibles.SelectCommand = Me.SqlSelectCommand1
        Me.Adapter_Cajeros_disponibles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Vista_Cajeros_Disponibles_Abrir_Caja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(441, 28)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(72, 21)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Cancelar"
        '
        'FrmDatos_Cajeros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 54)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Combo_nom_cajero)
        Me.Controls.Add(Me.TxtIdentificacion)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(528, 88)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(528, 88)
        Me.Name = "FrmDatos_Cajeros"
        Me.Text = "Seleccione un Cajero(a)"
        CType(Me.DataSet_Aper_Caja1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub FrmDatos_Cajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Adapter_Cajeros_disponibles.Fill(Me.DataSet_Aper_Caja1, "Vista_Cajeros_Disponibles_Abrir_Caja")
        If Me.DataSet_Aper_Caja1.Vista_Cajeros_Disponibles_Abrir_Caja.Count > 0 Then
            Combo_nom_cajero.Focus()
        Else
            MsgBox("No hay cajeros disponibles, para hacer una apertura", MsgBoxStyle.Information)
            Me.DialogResult = DialogResult.Abort
        End If
    End Sub
#End Region

#Region "Controles Funciones"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        nombre_cajero = Me.Combo_nom_cajero.Text
        cedula_cajero = Me.TxtIdentificacion.Text
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If MessageBox.Show("¿Desea salir de " & Me.Text & "..?", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub Combo_nom_cajero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Combo_nom_cajero.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1.Focus()
        End If
    End Sub
#End Region

End Class
