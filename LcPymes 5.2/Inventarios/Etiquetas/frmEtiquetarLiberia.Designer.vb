<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiquetarLiberia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodArticulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblPrecioLent = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNCopia = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPresentacion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pLogo = New System.Windows.Forms.PictureBox()
        Me.pictBarcode = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.porCodigoBarras = New System.Windows.Forms.RadioButton()
        Me.porCodigo = New System.Windows.Forms.RadioButton()
        CType(Me.txtNCopia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(363, 114)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(130, 23)
        Me.cmdPrint.TabIndex = 13
        Me.cmdPrint.Text = "Imprimir Etiquetas"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.Location = New System.Drawing.Point(127, 10)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(364, 20)
        Me.txtCodigo.TabIndex = 8
        '
        'label2
        '
        Me.label2.Enabled = False
        Me.label2.Location = New System.Drawing.Point(6, 160)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 16)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Cantidad : "
        Me.label2.Visible = False
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(5, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(84, 16)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Barra :"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(93, 62)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(398, 20)
        Me.txtDescripcion.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Texto :"
        '
        'txtCodArticulo
        '
        Me.txtCodArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodArticulo.Location = New System.Drawing.Point(93, 36)
        Me.txtCodArticulo.Name = "txtCodArticulo"
        Me.txtCodArticulo.ReadOnly = True
        Me.txtCodArticulo.Size = New System.Drawing.Size(398, 20)
        Me.txtCodArticulo.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Codigo :"
        '
        'txtPrecio
        '
        Me.txtPrecio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrecio.Location = New System.Drawing.Point(3, 205)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(46, 20)
        Me.txtPrecio.TabIndex = 19
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecio.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Precio :"
        '
        'lblPrecio
        '
        Me.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrecio.Location = New System.Drawing.Point(93, 88)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(84, 20)
        Me.lblPrecio.TabIndex = 20
        '
        'lblPrecioLent
        '
        Me.lblPrecioLent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrecioLent.Location = New System.Drawing.Point(55, 205)
        Me.lblPrecioLent.Name = "lblPrecioLent"
        Me.lblPrecioLent.Size = New System.Drawing.Size(32, 20)
        Me.lblPrecioLent.TabIndex = 21
        Me.lblPrecioLent.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(360, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Copias :"
        '
        'txtNCopia
        '
        Me.txtNCopia.Location = New System.Drawing.Point(413, 87)
        Me.txtNCopia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNCopia.Name = "txtNCopia"
        Me.txtNCopia.Size = New System.Drawing.Size(78, 20)
        Me.txtNCopia.TabIndex = 24
        Me.txtNCopia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNCopia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "F1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.DecimalPlaces = 2
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(3, 179)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(84, 20)
        Me.txtCantidad.TabIndex = 26
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtCantidad.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.porCodigo)
        Me.Panel1.Controls.Add(Me.porCodigoBarras)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblPresentacion)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.pictBarcode)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.txtNCopia)
        Me.Panel1.Controls.Add(Me.txtCodigo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmdPrint)
        Me.Panel1.Controls.Add(Me.lblPrecioLent)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCodArticulo)
        Me.Panel1.Location = New System.Drawing.Point(6, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 243)
        Me.Panel1.TabIndex = 27
        '
        'lblPresentacion
        '
        Me.lblPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPresentacion.Location = New System.Drawing.Point(258, 88)
        Me.lblPresentacion.Name = "lblPresentacion"
        Me.lblPresentacion.Size = New System.Drawing.Size(96, 20)
        Me.lblPresentacion.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(183, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Presentacion :"
        '
        'pLogo
        '
        Me.pLogo.Location = New System.Drawing.Point(507, 166)
        Me.pLogo.Name = "pLogo"
        Me.pLogo.Size = New System.Drawing.Size(77, 76)
        Me.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pLogo.TabIndex = 28
        Me.pLogo.TabStop = False
        '
        'pictBarcode
        '
        Me.pictBarcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictBarcode.Location = New System.Drawing.Point(93, 143)
        Me.pictBarcode.Name = "pictBarcode"
        Me.pictBarcode.Size = New System.Drawing.Size(402, 97)
        Me.pictBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictBarcode.TabIndex = 10
        Me.pictBarcode.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(5, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Codigo Barras :"
        '
        'porCodigoBarras
        '
        Me.porCodigoBarras.AutoSize = True
        Me.porCodigoBarras.Checked = True
        Me.porCodigoBarras.Location = New System.Drawing.Point(93, 117)
        Me.porCodigoBarras.Name = "porCodigoBarras"
        Me.porCodigoBarras.Size = New System.Drawing.Size(106, 17)
        Me.porCodigoBarras.TabIndex = 30
        Me.porCodigoBarras.Text = "Codigo de Barras"
        Me.porCodigoBarras.UseVisualStyleBackColor = True
        '
        'porCodigo
        '
        Me.porCodigo.AutoSize = True
        Me.porCodigo.Location = New System.Drawing.Point(205, 117)
        Me.porCodigo.Name = "porCodigo"
        Me.porCodigo.Size = New System.Drawing.Size(58, 17)
        Me.porCodigo.TabIndex = 31
        Me.porCodigo.Text = "Codigo"
        Me.porCodigo.UseVisualStyleBackColor = True
        '
        'frmEtiquetarLiberia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 268)
        Me.Controls.Add(Me.pLogo)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmEtiquetarLiberia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etiquetador - Guanavet Clinica"
        CType(Me.txtNCopia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdPrint As System.Windows.Forms.Button
    Private WithEvents txtCodigo As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents pictBarcode As System.Windows.Forms.PictureBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtCodArticulo As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtPrecio As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents lblPrecio As System.Windows.Forms.Label
    Private WithEvents lblPrecioLent As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNCopia As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pLogo As System.Windows.Forms.PictureBox
    Private WithEvents lblPresentacion As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents porCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents porCodigoBarras As System.Windows.Forms.RadioButton
    Private WithEvents Label8 As System.Windows.Forms.Label
End Class
