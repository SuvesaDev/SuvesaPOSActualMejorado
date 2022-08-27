<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarPrecioVenta_FacturaElectronica
    Inherits System.Windows.Forms.Form

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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TxtPrecioVenta_IV_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_B = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_IV_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_B = New DevExpress.XtraEditors.TextEdit()
        Me.TextBoxValorMonedaEnVenta = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CBMonedaVenta = New System.Windows.Forms.ComboBox()
        Me.DataSetCompras = New LcPymes_5._2.DataSetCompras()
        Me.TxtUtilidad_C = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_D = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_B = New DevExpress.XtraEditors.TextEdit()
        Me.TxtUtilidad_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPrecioVenta_A = New DevExpress.XtraEditors.TextEdit()
        Me.TxtCostoReal = New ValidText.ValidText()
        Me.TxtBaseEquivalente = New System.Windows.Forms.TextBox()
        Me.TxtFleteEquivalente = New System.Windows.Forms.TextBox()
        Me.TxtOtrosCargosEquivalente = New System.Windows.Forms.TextBox()
        Me.ButtonAgregarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtImpuesto_Porcentaje = New ValidText.ValidText()
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection()
        Me.TextBoxValorMonedaEnCosto = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TxtPrecioVenta_IV_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_IV_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_C.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_B.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUtilidad_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPrecioVenta_A.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.ButtonAgregarDetalle)
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Location = New System.Drawing.Point(9, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 208)
        Me.Panel2.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Precio de Venta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_D)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_C)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_D)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_C)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_B)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_IV_A)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_B)
        Me.GroupBox2.Controls.Add(Me.TextBoxValorMonedaEnVenta)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.CBMonedaVenta)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_C)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_D)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_B)
        Me.GroupBox2.Controls.Add(Me.TxtUtilidad_A)
        Me.GroupBox2.Controls.Add(Me.TxtPrecioVenta_A)
        Me.GroupBox2.Controls.Add(Me.TxtCostoReal)
        Me.GroupBox2.Controls.Add(Me.TxtBaseEquivalente)
        Me.GroupBox2.Controls.Add(Me.TxtFleteEquivalente)
        Me.GroupBox2.Controls.Add(Me.TxtOtrosCargosEquivalente)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 184)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precio de Venta"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(13, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "Nuevo Costo"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(88, 39)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(80, 13)
        Me.Label48.TabIndex = 103
        Me.Label48.Text = "> Reg."
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPrecioVenta_IV_D
        '
        Me.TxtPrecioVenta_IV_D.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_D.Location = New System.Drawing.Point(188, 132)
        Me.TxtPrecioVenta_IV_D.Name = "TxtPrecioVenta_IV_D"
        '
        '
        '
        Me.TxtPrecioVenta_IV_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_D.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_D.TabIndex = 12
        '
        'TxtPrecioVenta_IV_C
        '
        Me.TxtPrecioVenta_IV_C.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_C.Location = New System.Drawing.Point(188, 114)
        Me.TxtPrecioVenta_IV_C.Name = "TxtPrecioVenta_IV_C"
        '
        '
        '
        Me.TxtPrecioVenta_IV_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_C.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_C.TabIndex = 11
        '
        'TxtPrecioVenta_D
        '
        Me.TxtPrecioVenta_D.EditValue = "0.00"
        Me.TxtPrecioVenta_D.Location = New System.Drawing.Point(85, 132)
        Me.TxtPrecioVenta_D.Name = "TxtPrecioVenta_D"
        '
        '
        '
        Me.TxtPrecioVenta_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_D.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_D.TabIndex = 8
        '
        'TxtPrecioVenta_C
        '
        Me.TxtPrecioVenta_C.EditValue = "0.00"
        Me.TxtPrecioVenta_C.Location = New System.Drawing.Point(85, 114)
        Me.TxtPrecioVenta_C.Name = "TxtPrecioVenta_C"
        '
        '
        '
        Me.TxtPrecioVenta_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_C.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_C.TabIndex = 7
        '
        'TxtPrecioVenta_IV_B
        '
        Me.TxtPrecioVenta_IV_B.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_B.Location = New System.Drawing.Point(188, 95)
        Me.TxtPrecioVenta_IV_B.Name = "TxtPrecioVenta_IV_B"
        '
        '
        '
        Me.TxtPrecioVenta_IV_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_B.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_B.TabIndex = 10
        '
        'TxtPrecioVenta_IV_A
        '
        Me.TxtPrecioVenta_IV_A.EditValue = "0.00"
        Me.TxtPrecioVenta_IV_A.Location = New System.Drawing.Point(188, 76)
        Me.TxtPrecioVenta_IV_A.Name = "TxtPrecioVenta_IV_A"
        '
        '
        '
        Me.TxtPrecioVenta_IV_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_IV_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_IV_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_IV_A.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_IV_A.TabIndex = 9
        '
        'TxtPrecioVenta_B
        '
        Me.TxtPrecioVenta_B.EditValue = "0.00"
        Me.TxtPrecioVenta_B.Location = New System.Drawing.Point(85, 95)
        Me.TxtPrecioVenta_B.Name = "TxtPrecioVenta_B"
        '
        '
        '
        Me.TxtPrecioVenta_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_B.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_B.TabIndex = 6
        '
        'TextBoxValorMonedaEnVenta
        '
        Me.TextBoxValorMonedaEnVenta.AcceptsTab = True
        Me.TextBoxValorMonedaEnVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxValorMonedaEnVenta.Enabled = False
        Me.TextBoxValorMonedaEnVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBoxValorMonedaEnVenta.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxValorMonedaEnVenta.Location = New System.Drawing.Point(185, 19)
        Me.TextBoxValorMonedaEnVenta.Name = "TextBoxValorMonedaEnVenta"
        Me.TextBoxValorMonedaEnVenta.ReadOnly = True
        Me.TextBoxValorMonedaEnVenta.Size = New System.Drawing.Size(84, 13)
        Me.TextBoxValorMonedaEnVenta.TabIndex = 75
        Me.TextBoxValorMonedaEnVenta.Text = "0.00"
        Me.TextBoxValorMonedaEnVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(8, 59)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(51, 13)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Utilidad"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(186, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Precio + I.V."
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(85, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 13)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "Precio Venta"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label30.ForeColor = System.Drawing.Color.Blue
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(171, 137)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 12)
        Me.Label30.TabIndex = 48
        Me.Label30.Text = "+"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(171, 118)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 12)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "+"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(171, 98)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 12)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "+"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label33.ForeColor = System.Drawing.Color.Blue
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(64, 78)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(16, 12)
        Me.Label33.TabIndex = 40
        Me.Label33.Text = "A"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label34.ForeColor = System.Drawing.Color.Blue
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(64, 116)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(16, 13)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "C"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(64, 96)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 13)
        Me.Label35.TabIndex = 41
        Me.Label35.Text = "B"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(64, 136)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(16, 13)
        Me.Label36.TabIndex = 44
        Me.Label36.Text = "D"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(171, 80)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 12)
        Me.Label37.TabIndex = 45
        Me.Label37.Text = "+"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label38.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(8, 19)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(59, 15)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "Moneda"
        '
        'CBMonedaVenta
        '
        Me.CBMonedaVenta.DataSource = Me.DataSetCompras
        Me.CBMonedaVenta.DisplayMember = "Monedas.MonedaNombre"
        Me.CBMonedaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMonedaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBMonedaVenta.ForeColor = System.Drawing.Color.Blue
        Me.CBMonedaVenta.ItemHeight = 13
        Me.CBMonedaVenta.Location = New System.Drawing.Point(84, 15)
        Me.CBMonedaVenta.Name = "CBMonedaVenta"
        Me.CBMonedaVenta.Size = New System.Drawing.Size(84, 21)
        Me.CBMonedaVenta.TabIndex = 0
        Me.CBMonedaVenta.ValueMember = "Monedas.CodMoneda"
        '
        'DataSetCompras
        '
        Me.DataSetCompras.DataSetName = "DataSetCompras"
        Me.DataSetCompras.Locale = New System.Globalization.CultureInfo("")
        Me.DataSetCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtUtilidad_C
        '
        Me.TxtUtilidad_C.EditValue = "0.00"
        Me.TxtUtilidad_C.Location = New System.Drawing.Point(8, 114)
        Me.TxtUtilidad_C.Name = "TxtUtilidad_C"
        '
        '
        '
        Me.TxtUtilidad_C.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_C.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_C.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_C.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_C.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_C.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_C.TabIndex = 3
        '
        'TxtUtilidad_D
        '
        Me.TxtUtilidad_D.EditValue = "0.00"
        Me.TxtUtilidad_D.Location = New System.Drawing.Point(8, 132)
        Me.TxtUtilidad_D.Name = "TxtUtilidad_D"
        '
        '
        '
        Me.TxtUtilidad_D.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_D.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_D.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_D.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_D.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_D.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_D.TabIndex = 4
        '
        'TxtUtilidad_B
        '
        Me.TxtUtilidad_B.EditValue = "0.00"
        Me.TxtUtilidad_B.Location = New System.Drawing.Point(8, 95)
        Me.TxtUtilidad_B.Name = "TxtUtilidad_B"
        '
        '
        '
        Me.TxtUtilidad_B.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_B.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_B.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_B.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_B.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_B.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_B.TabIndex = 2
        '
        'TxtUtilidad_A
        '
        Me.TxtUtilidad_A.EditValue = "0.00"
        Me.TxtUtilidad_A.Location = New System.Drawing.Point(8, 76)
        Me.TxtUtilidad_A.Name = "TxtUtilidad_A"
        '
        '
        '
        Me.TxtUtilidad_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtUtilidad_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtUtilidad_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtUtilidad_A.Size = New System.Drawing.Size(51, 19)
        Me.TxtUtilidad_A.TabIndex = 1
        '
        'TxtPrecioVenta_A
        '
        Me.TxtPrecioVenta_A.EditValue = "0.00"
        Me.TxtPrecioVenta_A.Location = New System.Drawing.Point(85, 76)
        Me.TxtPrecioVenta_A.Name = "TxtPrecioVenta_A"
        '
        '
        '
        Me.TxtPrecioVenta_A.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_A.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_A.Properties.EditFormat.FormatString = "#,#0.00"
        Me.TxtPrecioVenta_A.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TxtPrecioVenta_A.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.TxtPrecioVenta_A.Size = New System.Drawing.Size(82, 19)
        Me.TxtPrecioVenta_A.TabIndex = 5
        '
        'TxtCostoReal
        '
        Me.TxtCostoReal.BackColor = System.Drawing.Color.White
        Me.TxtCostoReal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCostoReal.Enabled = False
        Me.TxtCostoReal.FieldReference = Nothing
        Me.TxtCostoReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCostoReal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TxtCostoReal.Location = New System.Drawing.Point(185, 39)
        Me.TxtCostoReal.MaskEdit = ""
        Me.TxtCostoReal.Name = "TxtCostoReal"
        Me.TxtCostoReal.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCostoReal.Required = False
        Me.TxtCostoReal.ShowErrorIcon = False
        Me.TxtCostoReal.Size = New System.Drawing.Size(84, 13)
        Me.TxtCostoReal.TabIndex = 101
        Me.TxtCostoReal.Text = "0.00"
        Me.TxtCostoReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCostoReal.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCostoReal.ValidText = "#0"
        '
        'TxtBaseEquivalente
        '
        Me.TxtBaseEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBaseEquivalente.Enabled = False
        Me.TxtBaseEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtBaseEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtBaseEquivalente.Location = New System.Drawing.Point(8, 160)
        Me.TxtBaseEquivalente.Name = "TxtBaseEquivalente"
        Me.TxtBaseEquivalente.ReadOnly = True
        Me.TxtBaseEquivalente.Size = New System.Drawing.Size(72, 13)
        Me.TxtBaseEquivalente.TabIndex = 101
        Me.TxtBaseEquivalente.Text = "0.00"
        Me.TxtBaseEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtFleteEquivalente
        '
        Me.TxtFleteEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFleteEquivalente.Enabled = False
        Me.TxtFleteEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtFleteEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtFleteEquivalente.Location = New System.Drawing.Point(96, 160)
        Me.TxtFleteEquivalente.Name = "TxtFleteEquivalente"
        Me.TxtFleteEquivalente.ReadOnly = True
        Me.TxtFleteEquivalente.Size = New System.Drawing.Size(72, 13)
        Me.TxtFleteEquivalente.TabIndex = 102
        Me.TxtFleteEquivalente.Text = "0.00"
        Me.TxtFleteEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtOtrosCargosEquivalente
        '
        Me.TxtOtrosCargosEquivalente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOtrosCargosEquivalente.Enabled = False
        Me.TxtOtrosCargosEquivalente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtOtrosCargosEquivalente.ForeColor = System.Drawing.Color.Blue
        Me.TxtOtrosCargosEquivalente.Location = New System.Drawing.Point(176, 160)
        Me.TxtOtrosCargosEquivalente.Name = "TxtOtrosCargosEquivalente"
        Me.TxtOtrosCargosEquivalente.ReadOnly = True
        Me.TxtOtrosCargosEquivalente.Size = New System.Drawing.Size(89, 13)
        Me.TxtOtrosCargosEquivalente.TabIndex = 103
        Me.TxtOtrosCargosEquivalente.Text = "0.00"
        Me.TxtOtrosCargosEquivalente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonAgregarDetalle
        '
        Me.ButtonAgregarDetalle.Location = New System.Drawing.Point(46, 184)
        Me.ButtonAgregarDetalle.Name = "ButtonAgregarDetalle"
        Me.ButtonAgregarDetalle.Size = New System.Drawing.Size(84, 20)
        Me.ButtonAgregarDetalle.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonAgregarDetalle.TabIndex = 1
        Me.ButtonAgregarDetalle.Text = "Agregar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(177, 183)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(84, 20)
        Me.SimpleButton2.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Cancelar"
        '
        'TxtImpuesto_Porcentaje
        '
        Me.TxtImpuesto_Porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtImpuesto_Porcentaje.FieldReference = Nothing
        Me.TxtImpuesto_Porcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto_Porcentaje.ForeColor = System.Drawing.Color.Blue
        Me.TxtImpuesto_Porcentaje.Location = New System.Drawing.Point(318, 15)
        Me.TxtImpuesto_Porcentaje.MaskEdit = ""
        Me.TxtImpuesto_Porcentaje.Name = "TxtImpuesto_Porcentaje"
        Me.TxtImpuesto_Porcentaje.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtImpuesto_Porcentaje.Required = True
        Me.TxtImpuesto_Porcentaje.ShowErrorIcon = False
        Me.TxtImpuesto_Porcentaje.Size = New System.Drawing.Size(42, 13)
        Me.TxtImpuesto_Porcentaje.TabIndex = 11
        Me.TxtImpuesto_Porcentaje.Text = "0.00"
        Me.TxtImpuesto_Porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtImpuesto_Porcentaje.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtImpuesto_Porcentaje.ValidText = "#0"
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand4
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "Data Source=.;Initial Catalog=SeePos;Integrated Security=True"
        Me.SqlConnection.FireInfoMessageEventOnUserErrors = False
        '
        'TextBoxValorMonedaEnCosto
        '
        Me.TextBoxValorMonedaEnCosto.AcceptsTab = True
        Me.TextBoxValorMonedaEnCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxValorMonedaEnCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCompras, "Moneda.ValorCompra", True))
        Me.TextBoxValorMonedaEnCosto.Enabled = False
        Me.TextBoxValorMonedaEnCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBoxValorMonedaEnCosto.ForeColor = System.Drawing.Color.Blue
        Me.TextBoxValorMonedaEnCosto.Location = New System.Drawing.Point(318, 31)
        Me.TextBoxValorMonedaEnCosto.Name = "TextBoxValorMonedaEnCosto"
        Me.TextBoxValorMonedaEnCosto.ReadOnly = True
        Me.TextBoxValorMonedaEnCosto.Size = New System.Drawing.Size(42, 13)
        Me.TextBoxValorMonedaEnCosto.TabIndex = 106
        Me.TextBoxValorMonedaEnCosto.Text = "0.00"
        Me.TextBoxValorMonedaEnCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmEditarPrecioVenta_FacturaElectronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 236)
        Me.Controls.Add(Me.TextBoxValorMonedaEnCosto)
        Me.Controls.Add(Me.TxtImpuesto_Porcentaje)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditarPrecioVenta_FacturaElectronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Precio de Venta"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TxtPrecioVenta_IV_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_IV_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_C.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_B.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUtilidad_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPrecioVenta_A.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecioVenta_IV_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_IV_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextBoxValorMonedaEnVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CBMonedaVenta As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUtilidad_C As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_D As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_B As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtUtilidad_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPrecioVenta_A As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtCostoReal As ValidText.ValidText
    Friend WithEvents TxtBaseEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtFleteEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents TxtOtrosCargosEquivalente As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtImpuesto_Porcentaje As ValidText.ValidText
    Friend WithEvents DataSetCompras As LcPymes_5._2.DataSetCompras
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents TextBoxValorMonedaEnCosto As System.Windows.Forms.TextBox
End Class
