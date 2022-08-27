<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaLotes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaVence = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtExistenciaLote = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBarras = New System.Windows.Forms.TextBox()
        Me.viewLotesRelacionados = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.viewLotesRelacionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.viewLotesRelacionados)
        Me.GroupBox1.Controls.Add(Me.txtBarras)
        Me.GroupBox1.Controls.Add(Me.txtExistenciaLote)
        Me.GroupBox1.Controls.Add(Me.txtFechaVence)
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de lote"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(148, 33)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(248, 20)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripcion :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero de Lote :"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(18, 82)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(118, 20)
        Me.txtLote.TabIndex = 2
        Me.txtLote.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha venciemiento :"
        '
        'txtFechaVence
        '
        Me.txtFechaVence.Location = New System.Drawing.Point(148, 82)
        Me.txtFechaVence.Name = "txtFechaVence"
        Me.txtFechaVence.ReadOnly = True
        Me.txtFechaVence.Size = New System.Drawing.Size(118, 20)
        Me.txtFechaVence.TabIndex = 4
        Me.txtFechaVence.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(275, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Existencia Lote :"
        '
        'txtExistenciaLote
        '
        Me.txtExistenciaLote.Location = New System.Drawing.Point(278, 82)
        Me.txtExistenciaLote.Name = "txtExistenciaLote"
        Me.txtExistenciaLote.ReadOnly = True
        Me.txtExistenciaLote.Size = New System.Drawing.Size(118, 20)
        Me.txtExistenciaLote.TabIndex = 6
        Me.txtExistenciaLote.TabStop = False
        Me.txtExistenciaLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Barras :"
        '
        'txtBarras
        '
        Me.txtBarras.Location = New System.Drawing.Point(18, 33)
        Me.txtBarras.Name = "txtBarras"
        Me.txtBarras.Size = New System.Drawing.Size(118, 20)
        Me.txtBarras.TabIndex = 8
        '
        'viewLotesRelacionados
        '
        Me.viewLotesRelacionados.AllowUserToAddRows = False
        Me.viewLotesRelacionados.AllowUserToDeleteRows = False
        Me.viewLotesRelacionados.AllowUserToResizeColumns = False
        Me.viewLotesRelacionados.AllowUserToResizeRows = False
        Me.viewLotesRelacionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewLotesRelacionados.BackgroundColor = System.Drawing.Color.White
        Me.viewLotesRelacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewLotesRelacionados.Location = New System.Drawing.Point(18, 128)
        Me.viewLotesRelacionados.MultiSelect = False
        Me.viewLotesRelacionados.Name = "viewLotesRelacionados"
        Me.viewLotesRelacionados.ReadOnly = True
        Me.viewLotesRelacionados.RowHeadersVisible = False
        Me.viewLotesRelacionados.RowTemplate.Height = 28
        Me.viewLotesRelacionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewLotesRelacionados.Size = New System.Drawing.Size(442, 149)
        Me.viewLotesRelacionados.TabIndex = 10
        Me.viewLotesRelacionados.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Lotes relacionados :"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(402, 19)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(58, 35)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Tag = ""
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmConsultaLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Lote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.viewLotesRelacionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents viewLotesRelacionados As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBarras As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExistenciaLote As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaVence As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
End Class
