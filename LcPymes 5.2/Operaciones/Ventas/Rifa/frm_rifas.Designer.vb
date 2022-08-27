<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rifas
    Inherits LcPymes_5._2.FrmPlantilla

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rifas))
        Me.gp = New System.Windows.Forms.GroupBox
        Me.btnAgregarProveedor = New System.Windows.Forms.Button
        Me.btnQuitarproveedor = New System.Windows.Forms.Button
        Me.viewProveedores = New System.Windows.Forms.DataGridView
        Me.cIdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cant_minima = New System.Windows.Forms.NumericUpDown
        Me.Dsrifa1 = New LcPymes_5._2.dsrifa
        Me.Label4 = New System.Windows.Forms.Label
        Me.ck_anulado = New System.Windows.Forms.CheckBox
        Me.ck_finalizada = New System.Windows.Forms.CheckBox
        Me.dt_fin = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dt_ini = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_descripcion = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adapte_rifa = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand
        Me.gp.SuspendLayout()
        CType(Me.viewProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cant_minima, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsrifa1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 5
        Me.ToolBarImprimir.Text = "Editar"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 363)
        Me.ToolBar1.Size = New System.Drawing.Size(454, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.Location = New System.Drawing.Point(314, 382)
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(454, 32)
        Me.TituloModulo.Text = "Rifas"
        '
        'gp
        '
        Me.gp.Controls.Add(Me.btnAgregarProveedor)
        Me.gp.Controls.Add(Me.btnQuitarproveedor)
        Me.gp.Controls.Add(Me.viewProveedores)
        Me.gp.Controls.Add(Me.cant_minima)
        Me.gp.Controls.Add(Me.Label4)
        Me.gp.Controls.Add(Me.ck_anulado)
        Me.gp.Controls.Add(Me.ck_finalizada)
        Me.gp.Controls.Add(Me.dt_fin)
        Me.gp.Controls.Add(Me.Label3)
        Me.gp.Controls.Add(Me.dt_ini)
        Me.gp.Controls.Add(Me.Label2)
        Me.gp.Controls.Add(Me.Label1)
        Me.gp.Controls.Add(Me.txt_descripcion)
        Me.gp.Enabled = False
        Me.gp.Location = New System.Drawing.Point(4, 38)
        Me.gp.Name = "gp"
        Me.gp.Size = New System.Drawing.Size(444, 319)
        Me.gp.TabIndex = 71
        Me.gp.TabStop = False
        '
        'btnAgregarProveedor
        '
        Me.btnAgregarProveedor.Location = New System.Drawing.Point(179, 292)
        Me.btnAgregarProveedor.Name = "btnAgregarProveedor"
        Me.btnAgregarProveedor.Size = New System.Drawing.Size(115, 23)
        Me.btnAgregarProveedor.TabIndex = 12
        Me.btnAgregarProveedor.Text = "Agregar Proveedor"
        Me.btnAgregarProveedor.UseVisualStyleBackColor = True
        '
        'btnQuitarproveedor
        '
        Me.btnQuitarproveedor.Location = New System.Drawing.Point(302, 292)
        Me.btnQuitarproveedor.Name = "btnQuitarproveedor"
        Me.btnQuitarproveedor.Size = New System.Drawing.Size(115, 23)
        Me.btnQuitarproveedor.TabIndex = 11
        Me.btnQuitarproveedor.Text = "Quitar Proveedor"
        Me.btnQuitarproveedor.UseVisualStyleBackColor = True
        '
        'viewProveedores
        '
        Me.viewProveedores.AllowUserToAddRows = False
        Me.viewProveedores.AllowUserToDeleteRows = False
        Me.viewProveedores.AllowUserToResizeColumns = False
        Me.viewProveedores.AllowUserToResizeRows = False
        Me.viewProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewProveedores.BackgroundColor = System.Drawing.Color.White
        Me.viewProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdProveedor, Me.cProveedor})
        Me.viewProveedores.Location = New System.Drawing.Point(23, 114)
        Me.viewProveedores.MultiSelect = False
        Me.viewProveedores.Name = "viewProveedores"
        Me.viewProveedores.ReadOnly = True
        Me.viewProveedores.RowHeadersVisible = False
        Me.viewProveedores.Size = New System.Drawing.Size(394, 173)
        Me.viewProveedores.TabIndex = 10
        '
        'cIdProveedor
        '
        Me.cIdProveedor.HeaderText = "Id Proveedor"
        Me.cIdProveedor.Name = "cIdProveedor"
        Me.cIdProveedor.ReadOnly = True
        Me.cIdProveedor.Visible = False
        '
        'cProveedor
        '
        Me.cProveedor.HeaderText = "Proveedor"
        Me.cProveedor.Name = "cProveedor"
        Me.cProveedor.ReadOnly = True
        '
        'cant_minima
        '
        Me.cant_minima.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Dsrifa1, "rifa.cant_min", True))
        Me.cant_minima.Location = New System.Drawing.Point(102, 84)
        Me.cant_minima.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.cant_minima.Name = "cant_minima"
        Me.cant_minima.Size = New System.Drawing.Size(103, 20)
        Me.cant_minima.TabIndex = 9
        Me.cant_minima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Dsrifa1
        '
        Me.Dsrifa1.DataSetName = "dsrifa"
        Me.Dsrifa1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Monto Min."
        '
        'ck_anulado
        '
        Me.ck_anulado.AutoSize = True
        Me.ck_anulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Dsrifa1, "rifa.anulada", True))
        Me.ck_anulado.Enabled = False
        Me.ck_anulado.Location = New System.Drawing.Point(324, 87)
        Me.ck_anulado.Name = "ck_anulado"
        Me.ck_anulado.Size = New System.Drawing.Size(65, 17)
        Me.ck_anulado.TabIndex = 7
        Me.ck_anulado.Text = "Anulada"
        Me.ck_anulado.UseVisualStyleBackColor = True
        '
        'ck_finalizada
        '
        Me.ck_finalizada.AutoSize = True
        Me.ck_finalizada.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Dsrifa1, "rifa.finalizada", True))
        Me.ck_finalizada.Location = New System.Drawing.Point(235, 87)
        Me.ck_finalizada.Name = "ck_finalizada"
        Me.ck_finalizada.Size = New System.Drawing.Size(73, 17)
        Me.ck_finalizada.TabIndex = 6
        Me.ck_finalizada.Text = "Finalizada"
        Me.ck_finalizada.UseVisualStyleBackColor = True
        '
        'dt_fin
        '
        Me.dt_fin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dsrifa1, "rifa.fecha_fin", True))
        Me.dt_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fin.Location = New System.Drawing.Point(301, 51)
        Me.dt_fin.Name = "dt_fin"
        Me.dt_fin.Size = New System.Drawing.Size(116, 20)
        Me.dt_fin.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Final"
        '
        'dt_ini
        '
        Me.dt_ini.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dsrifa1, "rifa.fecha_inicio", True))
        Me.dt_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_ini.Location = New System.Drawing.Point(102, 51)
        Me.dt_ini.Name = "dt_ini"
        Me.dt_ini.Size = New System.Drawing.Size(103, 20)
        Me.dt_ini.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Inicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Dsrifa1, "rifa.descripcion", True))
        Me.txt_descripcion.Location = New System.Drawing.Point(102, 18)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(315, 20)
        Me.txt_descripcion.TabIndex = 1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""DESKTOP-NCOO4KP"";packet size=4096;integrated security=SSPI;data s" & _
            "ource=""."";persist security info=False;initial catalog=Seepos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'adapte_rifa
        '
        Me.adapte_rifa.DeleteCommand = Me.SqlDeleteCommand
        Me.adapte_rifa.InsertCommand = Me.SqlInsertCommand
        Me.adapte_rifa.SelectCommand = Me.SqlSelectCommand3
        Me.adapte_rifa.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "rifa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("descripcion", "descripcion"), New System.Data.Common.DataColumnMapping("fecha_inicio", "fecha_inicio"), New System.Data.Common.DataColumnMapping("fecha_fin", "fecha_fin"), New System.Data.Common.DataColumnMapping("cant_min", "cant_min"), New System.Data.Common.DataColumnMapping("finalizada", "finalizada"), New System.Data.Common.DataColumnMapping("anulada", "anulada")})})
        Me.adapte_rifa.UpdateCommand = Me.SqlUpdateCommand
        '
        'SqlDeleteCommand
        '
        Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        Me.SqlDeleteCommand.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_inicio", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_inicio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cant_min", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cant_min", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_finalizada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "finalizada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anulada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anulada", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.NVarChar, 0, "descripcion"), New System.Data.SqlClient.SqlParameter("@fecha_inicio", System.Data.SqlDbType.[Date], 0, "fecha_inicio"), New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.[Date], 0, "fecha_fin"), New System.Data.SqlClient.SqlParameter("@cant_min", System.Data.SqlDbType.Int, 0, "cant_min"), New System.Data.SqlClient.SqlParameter("@finalizada", System.Data.SqlDbType.Bit, 0, "finalizada"), New System.Data.SqlClient.SqlParameter("@anulada", System.Data.SqlDbType.Bit, 0, "anulada")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT        id, descripcion, fecha_inicio, fecha_fin, cant_min, finalizada, anu" & _
            "lada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            rifa"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand
        '
        Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        Me.SqlUpdateCommand.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.NVarChar, 0, "descripcion"), New System.Data.SqlClient.SqlParameter("@fecha_inicio", System.Data.SqlDbType.[Date], 0, "fecha_inicio"), New System.Data.SqlClient.SqlParameter("@fecha_fin", System.Data.SqlDbType.[Date], 0, "fecha_fin"), New System.Data.SqlClient.SqlParameter("@cant_min", System.Data.SqlDbType.Int, 0, "cant_min"), New System.Data.SqlClient.SqlParameter("@finalizada", System.Data.SqlDbType.Bit, 0, "finalizada"), New System.Data.SqlClient.SqlParameter("@anulada", System.Data.SqlDbType.Bit, 0, "anulada"), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_descripcion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_inicio", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_inicio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_fecha_fin", System.Data.SqlDbType.[Date], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fecha_fin", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_cant_min", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cant_min", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_finalizada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "finalizada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_anulada", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "anulada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.BigInt, 8, "id")})
        '
        'frm_rifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 415)
        Me.Controls.Add(Me.gp)
        Me.Name = "frm_rifas"
        Me.Text = "Formulario de Rifas"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.gp, 0)
        Me.gp.ResumeLayout(False)
        Me.gp.PerformLayout()
        CType(Me.viewProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cant_minima, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsrifa1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gp As System.Windows.Forms.GroupBox
    Friend WithEvents ck_anulado As System.Windows.Forms.CheckBox
    Friend WithEvents ck_finalizada As System.Windows.Forms.CheckBox
    Friend WithEvents dt_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dt_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adapte_rifa As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dsrifa1 As LcPymes_5._2.dsrifa
    Friend WithEvents cant_minima As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents viewProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregarProveedor As System.Windows.Forms.Button
    Friend WithEvents btnQuitarproveedor As System.Windows.Forms.Button
    Friend WithEvents cIdProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
