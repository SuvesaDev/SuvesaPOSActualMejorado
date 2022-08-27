<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGUARDAR_PROVEEDOR_META
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
        Me.components = New System.ComponentModel.Container()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCODIGOPROV = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtCODIGOPROV = New System.Windows.Forms.TextBox()
        Me.lblMENSUAL = New System.Windows.Forms.Label()
        Me.txtMENSUAL = New System.Windows.Forms.TextBox()
        Me.lblFECHA = New System.Windows.Forms.Label()
        Me.dtpFECHA = New System.Windows.Forms.DateTimePicker()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Location = New System.Drawing.Point(153, 112)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(104, 43)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Location = New System.Drawing.Point(263, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 43)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.TabStop = False
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 500
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblCODIGOPROV
        '
        Me.lblCODIGOPROV.AutoSize = True
        Me.lblCODIGOPROV.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGOPROV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCODIGOPROV.Location = New System.Drawing.Point(30, 20)
        Me.lblCODIGOPROV.Name = "lblCODIGOPROV"
        Me.lblCODIGOPROV.Size = New System.Drawing.Size(95, 18)
        Me.lblCODIGOPROV.TabIndex = 12
        Me.lblCODIGOPROV.Text = "CODIGOPROV :"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(150, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(28, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.TabStop = False
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtCODIGOPROV
        '
        Me.txtCODIGOPROV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCODIGOPROV.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGOPROV.Location = New System.Drawing.Point(180, 20)
        Me.txtCODIGOPROV.Name = "txtCODIGOPROV"
        Me.txtCODIGOPROV.ReadOnly = True
        Me.txtCODIGOPROV.Size = New System.Drawing.Size(187, 23)
        Me.txtCODIGOPROV.TabIndex = 1
        '
        'lblMENSUAL
        '
        Me.lblMENSUAL.AutoSize = True
        Me.lblMENSUAL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMENSUAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMENSUAL.Location = New System.Drawing.Point(30, 50)
        Me.lblMENSUAL.Name = "lblMENSUAL"
        Me.lblMENSUAL.Size = New System.Drawing.Size(107, 18)
        Me.lblMENSUAL.TabIndex = 12
        Me.lblMENSUAL.Text = "META MENSUAL :"
        '
        'txtMENSUAL
        '
        Me.txtMENSUAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMENSUAL.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMENSUAL.Location = New System.Drawing.Point(150, 50)
        Me.txtMENSUAL.MaxLength = 0
        Me.txtMENSUAL.Name = "txtMENSUAL"
        Me.txtMENSUAL.Size = New System.Drawing.Size(217, 23)
        Me.txtMENSUAL.TabIndex = 2
        Me.txtMENSUAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFECHA
        '
        Me.lblFECHA.AutoSize = True
        Me.lblFECHA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFECHA.Location = New System.Drawing.Point(30, 80)
        Me.lblFECHA.Name = "lblFECHA"
        Me.lblFECHA.Size = New System.Drawing.Size(55, 18)
        Me.lblFECHA.TabIndex = 12
        Me.lblFECHA.Text = "FECHA :"
        '
        'dtpFECHA
        '
        Me.dtpFECHA.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.dtpFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHA.Location = New System.Drawing.Point(150, 80)
        Me.dtpFECHA.Name = "dtpFECHA"
        Me.dtpFECHA.Size = New System.Drawing.Size(217, 23)
        Me.dtpFECHA.TabIndex = 3
        '
        'frmGUARDAR_PROVEEDOR_META
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(378, 168)
        Me.Controls.Add(Me.lblCODIGOPROV)
        Me.Controls.Add(Me.txtCODIGOPROV)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblMENSUAL)
        Me.Controls.Add(Me.txtMENSUAL)
        Me.Controls.Add(Me.lblFECHA)
        Me.Controls.Add(Me.dtpFECHA)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmGUARDAR_PROVEEDOR_META"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEEDOR_META"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCODIGOPROV As System.Windows.Forms.Label
    Friend WithEvents txtCODIGOPROV As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button


    Friend WithEvents lblMENSUAL As System.Windows.Forms.Label
    Friend WithEvents txtMENSUAL As System.Windows.Forms.TextBox


    Friend WithEvents lblFECHA As System.Windows.Forms.Label
    Friend WithEvents dtpFECHA As System.Windows.Forms.DateTimePicker

    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
