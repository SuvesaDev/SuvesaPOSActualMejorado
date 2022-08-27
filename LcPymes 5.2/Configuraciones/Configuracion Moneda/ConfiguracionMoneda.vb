Imports System.Windows.Forms

Public Class ConfiguracionMoneda
    Inherits FrmPlantilla

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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetConfiguracionMoneda1 As DataSetConfiguracionMoneda
    Friend WithEvents AdapterDenominacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionMoneda))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataSetConfiguracionMoneda1 = New LcPymes_5._2.DataSetConfiguracionMoneda
        Me.AdapterDenominacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.DataSetConfiguracionMoneda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Text = "Editar"
        Me.ToolBarExcel.Visible = True
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 100)
        Me.ToolBar1.Size = New System.Drawing.Size(394, 52)
        '
        'DataNavigator
        '
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(394, 32)
        Me.TituloModulo.Text = "Denominación Monedas"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
            "persist security info=False;initial catalog=SeePos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'DataSetConfiguracionMoneda1
        '
        Me.DataSetConfiguracionMoneda1.DataSetName = "DataSetConfiguracionMoneda"
        Me.DataSetConfiguracionMoneda1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetConfiguracionMoneda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdapterDenominacion
        '
        Me.AdapterDenominacion.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterDenominacion.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterDenominacion.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterDenominacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Denominacion_Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Denominacion", "Denominacion"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterDenominacion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Denominacion_Moneda WHERE (Id = @Original_Id) AND (CodMoneda = @Origi" & _
            "nal_CodMoneda) AND (Denominacion = @Original_Denominacion) AND (Tipo = @Original" & _
            "_Tipo)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Denominacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Denominacion_Moneda(CodMoneda, Denominacion, Tipo) VALUES (@CodMoneda" & _
            ", @Denominacion, @Tipo); SELECT Id, CodMoneda, Denominacion, Tipo FROM Denominac" & _
            "ion_Moneda WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Int, 4, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, CodMoneda, Denominacion, Tipo FROM Denominacion_Moneda"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Denominacion", System.Data.SqlDbType.Int, 4, "Denominacion"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Denominacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Denominacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda.CodMoneda", True))
        Me.ComboBox1.DataSource = Me.DataSetConfiguracionMoneda1
        Me.ComboBox1.DisplayMember = "Moneda.MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(8, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 59
        Me.ComboBox1.ValueMember = "Moneda.CodMoneda"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Moneda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda.Tipo", True))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Items.AddRange(New Object() {"MONEDA", "BILLETE"})
        Me.ComboBox2.Location = New System.Drawing.Point(128, 24)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox2.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(128, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Denominación"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(256, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Valor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda.Denominacion", True))
        Me.TextEdit1.EditValue = "0.00"
        Me.TextEdit1.Location = New System.Drawing.Point(256, 24)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit1.Size = New System.Drawing.Size(112, 19)
        Me.TextEdit1.TabIndex = 64
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.NextPage.Visible = False
        Me.DataNavigator1.Buttons.PrevPage.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "Denominacion_Moneda"
        Me.DataNavigator1.DataSource = Me.DataSetConfiguracionMoneda1
        Me.DataNavigator1.Location = New System.Drawing.Point(280, 128)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(104, 24)
        Me.DataNavigator1.TabIndex = 68
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextEdit1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Location = New System.Drawing.Point(8, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(376, 56)
        Me.Panel1.TabIndex = 69
        '
        'ConfiguracionMoneda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(394, 152)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Name = "ConfiguracionMoneda"
        Me.Text = "Configuración Moneda"
        Me.Controls.SetChildIndex(Me.DataNavigator, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.DataNavigator1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.DataSetConfiguracionMoneda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub ConfiguracionMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = CadenaConexionSeePOS

        Me.AdapterDenominacion.Fill(Me.DataSetConfiguracionMoneda1.Denominacion_Moneda)
        Me.AdapterMoneda.Fill(Me.DataSetConfiguracionMoneda1.Moneda)

        Me.DataSetConfiguracionMoneda1.Denominacion_Moneda.IdColumn.AutoIncrement = True
        Me.DataSetConfiguracionMoneda1.Denominacion_Moneda.IdColumn.AutoIncrementStep = 1
        Me.DataSetConfiguracionMoneda1.Denominacion_Moneda.CodMonedaColumn.DefaultValue = 1
        Me.DataSetConfiguracionMoneda1.Denominacion_Moneda.DenominacionColumn.DefaultValue = 1
        Me.DataSetConfiguracionMoneda1.Denominacion_Moneda.TipoColumn.DefaultValue = "BILLETE"
        Inabilitar()
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()
            Case 6 : editar()
            Case 3 : Registrar()
            Case 7 : Me.Close()
        End Select
    End Sub
#End Region

#Region "Nuevo"
    Function Nuevo()
        If Me.DataSetConfiguracionMoneda1.Moneda.Rows.Count = 0 Then
            MsgBox("No Existen Monedas Disponibles", MsgBoxStyle.Critical)
            Exit Function
        End If

        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            Try 'inicia la edicion
                Me.BindingContext(Me.DataSetConfiguracionMoneda1.Denominacion_Moneda).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").AddNew()
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Habilitar()
                Me.ComboBox1.Focus()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        Else
            Try
                Me.BindingContext(Me.DataSetConfiguracionMoneda1.Denominacion_Moneda).CancelCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.Inabilitar()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
#End Region

#Region "Editar"
    Function Editar()
        If Me.ToolBarExcel.ImageIndex = 5 Then
            Me.ToolBarExcel.ImageIndex = 8
            Me.ToolBarExcel.Text = "Cancelar"
            Me.Habilitar()
            ComboBox1.Focus()
        Else
            Me.ToolBarExcel.ImageIndex = 5
            Me.ToolBarExcel.Text = "Editar"
            Me.Inabilitar()
        End If
    End Function
#End Region

#Region "Registrar"
    Function Registrar()
        Dim resp As Integer

        If Validar() Then
            resp = MessageBox.Show("¿Deseas Guardar los cambios?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Try
                    Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").Current("Tipo") = ComboBox2.Text
                    Me.BindingContext(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda").EndCurrentEdit()
                    Me.AdapterDenominacion.Update(Me.DataSetConfiguracionMoneda1, "Denominacion_Moneda")
                    'Para boton Nuevo
                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
                    Me.ToolBar1.Buttons(0).ImageIndex = 0
                    'Para boton Acualizar
                    Me.ToolBar1.Buttons(3).Enabled = False
                    'Para boton Editar
                    Me.ToolBarExcel.Text = "Editar"
                    Me.ToolBarExcel.ImageIndex = 5
                    Me.Inabilitar()

                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
            End If

        Else
            MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")
        End If
    End Function
#End Region

#Region "Funciones"
    Function Habilitar()
        Panel1.Enabled = True
    End Function

    Function Inabilitar()
        Panel1.Enabled = False
    End Function

    Function Validar()
        Return True
    End Function
#End Region

#Region "Controles Funciones"
    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextEdit1.Focus()
        End If
    End Sub

    Private Sub TextEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Registrar()
        End If
    End Sub

    Private Sub TextEdit1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.GotFocus
        TextEdit1.SelectAll()
    End Sub
#End Region

End Class
