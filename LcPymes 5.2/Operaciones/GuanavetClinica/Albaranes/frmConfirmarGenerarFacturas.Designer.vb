﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmarGenerarFacturas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIdentificacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSaldoPrepago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCaja = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cTipo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPlazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGenerarFacturas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboDoctorEncargado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewDatos
        '
        Me.viewDatos.AllowUserToAddRows = False
        Me.viewDatos.AllowUserToDeleteRows = False
        Me.viewDatos.AllowUserToResizeColumns = False
        Me.viewDatos.AllowUserToResizeRows = False
        Me.viewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIdentificacion, Me.cIdentificacion2, Me.cCliente, Me.cSaldoPrepago, Me.cCaja, Me.cTipo, Me.cTotal, Me.cPlazo})
        Me.viewDatos.Location = New System.Drawing.Point(7, 47)
        Me.viewDatos.MultiSelect = False
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowHeadersWidth = 51
        Me.viewDatos.RowTemplate.Height = 27
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(776, 228)
        Me.viewDatos.TabIndex = 72
        '
        'cIdentificacion
        '
        Me.cIdentificacion.HeaderText = "Identificacion"
        Me.cIdentificacion.MinimumWidth = 6
        Me.cIdentificacion.Name = "cIdentificacion"
        Me.cIdentificacion.Visible = False
        '
        'cIdentificacion2
        '
        Me.cIdentificacion2.HeaderText = "Identificacion2"
        Me.cIdentificacion2.MinimumWidth = 6
        Me.cIdentificacion2.Name = "cIdentificacion2"
        Me.cIdentificacion2.Visible = False
        '
        'cCliente
        '
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.MinimumWidth = 6
        Me.cCliente.Name = "cCliente"
        Me.cCliente.ReadOnly = True
        Me.cCliente.Width = 325
        '
        'cSaldoPrepago
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.cSaldoPrepago.DefaultCellStyle = DataGridViewCellStyle1
        Me.cSaldoPrepago.HeaderText = "Anticipos"
        Me.cSaldoPrepago.Name = "cSaldoPrepago"
        Me.cSaldoPrepago.ReadOnly = True
        Me.cSaldoPrepago.Width = 125
        '
        'cCaja
        '
        Me.cCaja.HeaderText = "Caja"
        Me.cCaja.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cCaja.MinimumWidth = 6
        Me.cCaja.Name = "cCaja"
        Me.cCaja.Width = 75
        '
        'cTipo
        '
        Me.cTipo.HeaderText = "Tipo"
        Me.cTipo.Items.AddRange(New Object() {"CONTADO", "CREDITO", "TIQUETE"})
        Me.cTipo.MinimumWidth = 6
        Me.cTipo.Name = "cTipo"
        Me.cTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cTotal
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.cTotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.MinimumWidth = 6
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        Me.cTotal.Width = 125
        '
        'cPlazo
        '
        Me.cPlazo.HeaderText = "Plazo"
        Me.cPlazo.MinimumWidth = 6
        Me.cPlazo.Name = "cPlazo"
        Me.cPlazo.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(7, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(776, 36)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Acontinuacion se generaran las siguientes facturas :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(554, 280)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(229, 43)
        Me.btnCancelar.TabIndex = 85
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGenerarFacturas
        '
        Me.btnGenerarFacturas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerarFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerarFacturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarFacturas.Image = Global.LcPymes_5._2.My.Resources.Resources.accept_button
        Me.btnGenerarFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarFacturas.Location = New System.Drawing.Point(321, 280)
        Me.btnGenerarFacturas.Name = "btnGenerarFacturas"
        Me.btnGenerarFacturas.Size = New System.Drawing.Size(229, 43)
        Me.btnGenerarFacturas.TabIndex = 84
        Me.btnGenerarFacturas.Text = "Generar Facturas"
        Me.btnGenerarFacturas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 43)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Crear Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboDoctorEncargado
        '
        Me.cboDoctorEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDoctorEncargado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDoctorEncargado.FormattingEnabled = True
        Me.cboDoctorEncargado.Location = New System.Drawing.Point(259, 251)
        Me.cboDoctorEncargado.Name = "cboDoctorEncargado"
        Me.cboDoctorEncargado.Size = New System.Drawing.Size(379, 24)
        Me.cboDoctorEncargado.TabIndex = 87
        Me.cboDoctorEncargado.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Encargado :"
        Me.Label1.Visible = False
        '
        'frmConfirmarGenerarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 327)
        Me.Controls.Add(Me.viewDatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDoctorEncargado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGenerarFacturas)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfirmarGenerarFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar Accion"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarFacturas As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cboDoctorEncargado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cIdentificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cIdentificacion2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSaldoPrepago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCaja As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cTipo As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPlazo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
