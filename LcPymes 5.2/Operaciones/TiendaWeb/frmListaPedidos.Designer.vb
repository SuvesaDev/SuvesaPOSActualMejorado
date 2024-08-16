<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaPedidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.viewDatos = New System.Windows.Forms.DataGridView()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdate_created = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdate_modified = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cshipping_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccustomer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfirst_nameB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clast_nameB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.caddress_1B = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccityB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cstateB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cemailB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfirst_nameE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clast_nameE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.caddress_1E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ccityE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cstateE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cphoneE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.viewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.viewDatos.BackgroundColor = System.Drawing.Color.White
        Me.viewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.cstatus, Me.cdate_created, Me.cdate_modified, Me.cshipping_total, Me.ctotal, Me.ccustomer_id, Me.cfirst_nameB, Me.clast_nameB, Me.caddress_1B, Me.ccityB, Me.cstateB, Me.cemailB, Me.cfirst_nameE, Me.clast_nameE, Me.caddress_1E, Me.ccityE, Me.cstateE, Me.cphoneE})
        Me.viewDatos.Location = New System.Drawing.Point(5, 36)
        Me.viewDatos.Name = "viewDatos"
        Me.viewDatos.ReadOnly = True
        Me.viewDatos.RowHeadersVisible = False
        Me.viewDatos.RowTemplate.Height = 30
        Me.viewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewDatos.Size = New System.Drawing.Size(1010, 575)
        Me.viewDatos.TabIndex = 1
        '
        'cid
        '
        Me.cid.HeaderText = "id"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        Me.cid.Visible = False
        Me.cid.Width = 21
        '
        'cstatus
        '
        Me.cstatus.HeaderText = "Estado"
        Me.cstatus.Name = "cstatus"
        Me.cstatus.ReadOnly = True
        Me.cstatus.Width = 65
        '
        'cdate_created
        '
        Me.cdate_created.HeaderText = "Fecha Creacion"
        Me.cdate_created.Name = "cdate_created"
        Me.cdate_created.ReadOnly = True
        Me.cdate_created.Width = 98
        '
        'cdate_modified
        '
        Me.cdate_modified.HeaderText = "date_modified"
        Me.cdate_modified.Name = "cdate_modified"
        Me.cdate_modified.ReadOnly = True
        Me.cdate_modified.Visible = False
        Me.cdate_modified.Width = 98
        '
        'cshipping_total
        '
        Me.cshipping_total.HeaderText = "shipping_total"
        Me.cshipping_total.Name = "cshipping_total"
        Me.cshipping_total.ReadOnly = True
        Me.cshipping_total.Visible = False
        Me.cshipping_total.Width = 97
        '
        'ctotal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.ctotal.DefaultCellStyle = DataGridViewCellStyle1
        Me.ctotal.HeaderText = "Total"
        Me.ctotal.Name = "ctotal"
        Me.ctotal.ReadOnly = True
        Me.ctotal.Width = 56
        '
        'ccustomer_id
        '
        Me.ccustomer_id.HeaderText = "customer_id"
        Me.ccustomer_id.Name = "ccustomer_id"
        Me.ccustomer_id.ReadOnly = True
        Me.ccustomer_id.Visible = False
        Me.ccustomer_id.Width = 89
        '
        'cfirst_nameB
        '
        Me.cfirst_nameB.HeaderText = "Nombre"
        Me.cfirst_nameB.Name = "cfirst_nameB"
        Me.cfirst_nameB.ReadOnly = True
        Me.cfirst_nameB.Width = 69
        '
        'clast_nameB
        '
        Me.clast_nameB.HeaderText = "Apellido"
        Me.clast_nameB.Name = "clast_nameB"
        Me.clast_nameB.ReadOnly = True
        Me.clast_nameB.Width = 69
        '
        'caddress_1B
        '
        Me.caddress_1B.HeaderText = "Direccion"
        Me.caddress_1B.Name = "caddress_1B"
        Me.caddress_1B.ReadOnly = True
        Me.caddress_1B.Visible = False
        Me.caddress_1B.Width = 77
        '
        'ccityB
        '
        Me.ccityB.HeaderText = "Ciudad"
        Me.ccityB.Name = "ccityB"
        Me.ccityB.ReadOnly = True
        Me.ccityB.Visible = False
        Me.ccityB.Width = 65
        '
        'cstateB
        '
        Me.cstateB.HeaderText = "state"
        Me.cstateB.Name = "cstateB"
        Me.cstateB.ReadOnly = True
        Me.cstateB.Visible = False
        Me.cstateB.Width = 55
        '
        'cemailB
        '
        Me.cemailB.HeaderText = "Correo"
        Me.cemailB.Name = "cemailB"
        Me.cemailB.ReadOnly = True
        Me.cemailB.Width = 63
        '
        'cfirst_nameE
        '
        Me.cfirst_nameE.HeaderText = "Nombre"
        Me.cfirst_nameE.Name = "cfirst_nameE"
        Me.cfirst_nameE.ReadOnly = True
        Me.cfirst_nameE.Width = 69
        '
        'clast_nameE
        '
        Me.clast_nameE.HeaderText = "Apellidos"
        Me.clast_nameE.Name = "clast_nameE"
        Me.clast_nameE.ReadOnly = True
        Me.clast_nameE.Width = 74
        '
        'caddress_1E
        '
        Me.caddress_1E.HeaderText = "Direccion"
        Me.caddress_1E.Name = "caddress_1E"
        Me.caddress_1E.ReadOnly = True
        Me.caddress_1E.Width = 77
        '
        'ccityE
        '
        Me.ccityE.HeaderText = "Ciudad"
        Me.ccityE.Name = "ccityE"
        Me.ccityE.ReadOnly = True
        Me.ccityE.Width = 65
        '
        'cstateE
        '
        Me.cstateE.HeaderText = "state"
        Me.cstateE.Name = "cstateE"
        Me.cstateE.ReadOnly = True
        Me.cstateE.Visible = False
        Me.cstateE.Width = 55
        '
        'cphoneE
        '
        Me.cphoneE.HeaderText = "Telefono"
        Me.cphoneE.Name = "cphoneE"
        Me.cphoneE.ReadOnly = True
        Me.cphoneE.Width = 74
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(5, 7)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(178, 23)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Mostrar Todos"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Procesando"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmListaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 618)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.viewDatos)
        Me.Name = "frmListaPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Pedidos Web"
        CType(Me.viewDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewDatos As System.Windows.Forms.DataGridView
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents cid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdate_created As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdate_modified As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cshipping_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccustomer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfirst_nameB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clast_nameB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents caddress_1B As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccityB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cstateB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cemailB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfirst_nameE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clast_nameE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents caddress_1E As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ccityE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cstateE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cphoneE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
