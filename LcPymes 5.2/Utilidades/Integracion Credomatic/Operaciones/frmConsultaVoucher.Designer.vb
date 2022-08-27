Namespace Credomatic
    Namespace Operaciones
        <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Class frmConsultaVoucher
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
                Me.ViewDatos = New System.Windows.Forms.DataGridView()
                Me.txtBuscar = New System.Windows.Forms.TextBox()
                Me.btnMostrar = New System.Windows.Forms.Button()
                Me.btnImprimir = New System.Windows.Forms.Button()
                Me.btnAnular = New System.Windows.Forms.Button()
                Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
                Me.Label1 = New System.Windows.Forms.Label()
                Me.Label2 = New System.Windows.Forms.Label()
                Me.Label3 = New System.Windows.Forms.Label()
                Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
                CType(Me.ViewDatos, System.ComponentModel.ISupportInitialize).BeginInit()
                Me.SuspendLayout()
                '
                'ViewDatos
                '
                Me.ViewDatos.AllowUserToAddRows = False
                Me.ViewDatos.AllowUserToDeleteRows = False
                Me.ViewDatos.AllowUserToResizeColumns = False
                Me.ViewDatos.AllowUserToResizeRows = False
                Me.ViewDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.ViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
                Me.ViewDatos.BackgroundColor = System.Drawing.Color.White
                Me.ViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
                Me.ViewDatos.Location = New System.Drawing.Point(12, 68)
                Me.ViewDatos.MultiSelect = False
                Me.ViewDatos.Name = "ViewDatos"
                Me.ViewDatos.ReadOnly = True
                Me.ViewDatos.RowHeadersVisible = False
                Me.ViewDatos.RowTemplate.Height = 30
                Me.ViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
                Me.ViewDatos.Size = New System.Drawing.Size(801, 321)
                Me.ViewDatos.TabIndex = 0
                '
                'txtBuscar
                '
                Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.txtBuscar.Location = New System.Drawing.Point(74, 33)
                Me.txtBuscar.Name = "txtBuscar"
                Me.txtBuscar.Size = New System.Drawing.Size(613, 29)
                Me.txtBuscar.TabIndex = 1
                '
                'btnMostrar
                '
                Me.btnMostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnMostrar.Location = New System.Drawing.Point(693, 33)
                Me.btnMostrar.Name = "btnMostrar"
                Me.btnMostrar.Size = New System.Drawing.Size(120, 29)
                Me.btnMostrar.TabIndex = 2
                Me.btnMostrar.Text = "Mostrar"
                Me.btnMostrar.UseVisualStyleBackColor = True
                '
                'btnImprimir
                '
                Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnImprimir.Location = New System.Drawing.Point(12, 400)
                Me.btnImprimir.Name = "btnImprimir"
                Me.btnImprimir.Size = New System.Drawing.Size(206, 48)
                Me.btnImprimir.TabIndex = 3
                Me.btnImprimir.Text = "Imprimir Voucher"
                Me.btnImprimir.UseVisualStyleBackColor = True
                '
                'btnAnular
                '
                Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.btnAnular.Location = New System.Drawing.Point(273, 400)
                Me.btnAnular.Name = "btnAnular"
                Me.btnAnular.Size = New System.Drawing.Size(206, 48)
                Me.btnAnular.TabIndex = 4
                Me.btnAnular.Text = "Anular Voucher"
                Me.btnAnular.UseVisualStyleBackColor = True
                '
                'dtpDesde
                '
                Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
                Me.dtpDesde.Location = New System.Drawing.Point(74, 5)
                Me.dtpDesde.Name = "dtpDesde"
                Me.dtpDesde.Size = New System.Drawing.Size(139, 22)
                Me.dtpDesde.TabIndex = 5
                '
                'Label1
                '
                Me.Label1.AutoSize = True
                Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.Label1.Location = New System.Drawing.Point(12, 9)
                Me.Label1.Name = "Label1"
                Me.Label1.Size = New System.Drawing.Size(55, 16)
                Me.Label1.TabIndex = 6
                Me.Label1.Text = "Desde :"
                '
                'Label2
                '
                Me.Label2.AutoSize = True
                Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.Label2.Location = New System.Drawing.Point(12, 39)
                Me.Label2.Name = "Label2"
                Me.Label2.Size = New System.Drawing.Size(56, 16)
                Me.Label2.TabIndex = 7
                Me.Label2.Text = "Buscar :"
                '
                'Label3
                '
                Me.Label3.AutoSize = True
                Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.Label3.Location = New System.Drawing.Point(226, 7)
                Me.Label3.Name = "Label3"
                Me.Label3.Size = New System.Drawing.Size(50, 16)
                Me.Label3.TabIndex = 9
                Me.Label3.Text = "Hasta :"
                '
                'dtpHasta
                '
                Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
                Me.dtpHasta.Location = New System.Drawing.Point(281, 4)
                Me.dtpHasta.Name = "dtpHasta"
                Me.dtpHasta.Size = New System.Drawing.Size(139, 22)
                Me.dtpHasta.TabIndex = 8
                '
                'frmConsultaVoucher
                '
                Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
                Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                Me.ClientSize = New System.Drawing.Size(829, 455)
                Me.Controls.Add(Me.Label3)
                Me.Controls.Add(Me.dtpHasta)
                Me.Controls.Add(Me.Label2)
                Me.Controls.Add(Me.Label1)
                Me.Controls.Add(Me.dtpDesde)
                Me.Controls.Add(Me.btnAnular)
                Me.Controls.Add(Me.btnImprimir)
                Me.Controls.Add(Me.btnMostrar)
                Me.Controls.Add(Me.txtBuscar)
                Me.Controls.Add(Me.ViewDatos)
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                Me.MaximizeBox = False
                Me.MinimizeBox = False
                Me.Name = "frmConsultaVoucher"
                Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                Me.Text = "Consulta de Voucher"
                CType(Me.ViewDatos, System.ComponentModel.ISupportInitialize).EndInit()
                Me.ResumeLayout(False)
                Me.PerformLayout()

            End Sub
            Friend WithEvents ViewDatos As System.Windows.Forms.DataGridView
            Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
            Friend WithEvents btnMostrar As System.Windows.Forms.Button
            Friend WithEvents btnImprimir As System.Windows.Forms.Button
            Friend WithEvents btnAnular As System.Windows.Forms.Button
            Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
            Friend WithEvents Label1 As System.Windows.Forms.Label
            Friend WithEvents Label2 As System.Windows.Forms.Label
            Friend WithEvents Label3 As System.Windows.Forms.Label
            Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
        End Class

    End Namespace
End Namespace
