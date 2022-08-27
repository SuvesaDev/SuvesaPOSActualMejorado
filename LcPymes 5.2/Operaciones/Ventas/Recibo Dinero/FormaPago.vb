Public Class FormaPago
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GB_PagaCon As System.Windows.Forms.GroupBox
    Friend WithEvents BAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RBEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents RBCheque As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GB_PagaCon = New System.Windows.Forms.GroupBox
        Me.txtCheque = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.RBCheque = New System.Windows.Forms.RadioButton
        Me.RBEfectivo = New System.Windows.Forms.RadioButton
        Me.BAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.BCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GB_PagaCon.SuspendLayout()
        CType(Me.txtCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_PagaCon
        '
        Me.GB_PagaCon.Controls.Add(Me.txtCheque)
        Me.GB_PagaCon.Controls.Add(Me.Label1)
        Me.GB_PagaCon.Controls.Add(Me.RBCheque)
        Me.GB_PagaCon.Controls.Add(Me.RBEfectivo)
        Me.GB_PagaCon.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GB_PagaCon.Location = New System.Drawing.Point(8, 8)
        Me.GB_PagaCon.Name = "GB_PagaCon"
        Me.GB_PagaCon.Size = New System.Drawing.Size(264, 72)
        Me.GB_PagaCon.TabIndex = 0
        Me.GB_PagaCon.TabStop = False
        Me.GB_PagaCon.Text = "Paga con"
        '
        'txtCheque
        '
        Me.txtCheque.EditValue = ""
        Me.txtCheque.Location = New System.Drawing.Point(112, 40)
        Me.txtCheque.Name = "txtCheque"
        '
        'txtCheque.Properties
        '
        Me.txtCheque.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCheque.Properties.Enabled = False
        Me.txtCheque.Size = New System.Drawing.Size(144, 19)
        Me.txtCheque.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número : "
        '
        'RBCheque
        '
        Me.RBCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCheque.Location = New System.Drawing.Point(120, 16)
        Me.RBCheque.Name = "RBCheque"
        Me.RBCheque.Size = New System.Drawing.Size(80, 16)
        Me.RBCheque.TabIndex = 1
        Me.RBCheque.Text = "Cheque"
        '
        'RBEfectivo
        '
        Me.RBEfectivo.Checked = True
        Me.RBEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBEfectivo.Location = New System.Drawing.Point(8, 16)
        Me.RBEfectivo.Name = "RBEfectivo"
        Me.RBEfectivo.Size = New System.Drawing.Size(88, 16)
        Me.RBEfectivo.TabIndex = 0
        Me.RBEfectivo.TabStop = True
        Me.RBEfectivo.Text = "Efectivo"
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(40, 88)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.TabIndex = 1
        Me.BAceptar.Text = "Aceptar"
        '
        'BCancelar
        '
        Me.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancelar.Location = New System.Drawing.Point(152, 88)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.TabIndex = 2
        Me.BCancelar.Text = "Cancelar"
        '
        'FormaPago
        '
        Me.AcceptButton = Me.BAceptar
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.BCancelar
        Me.ClientSize = New System.Drawing.Size(280, 118)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.GB_PagaCon)
        Me.MaximizeBox = False
        Me.Name = "FormaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma de Pago"
        Me.GB_PagaCon.ResumeLayout(False)
        CType(Me.txtCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Public Cheque As String
#End Region

#Region "Load"
    Private Sub FormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BAceptar.Focus()
    End Sub
#End Region

#Region "Controles Funciones"
    Private Sub txtCheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCheque.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Aceptar()
        End If
    End Sub

    Private Sub BAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAceptar.Click
        Aceptar()
    End Sub

    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RBCheque_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RBCheque.CheckedChanged, RBEfectivo.CheckedChanged
        txtCheque.Enabled = RBCheque.Checked
        If RBCheque.Checked Then
            txtCheque.Focus()
        End If
    End Sub
#End Region

#Region "Aceptar"
    Private Sub Aceptar()
        Try
            If RBCheque.Checked And txtCheque.Text = "" Then
                MsgBox("Debe de ingresar un número de cheque!", MsgBoxStyle.Critical, "LcPymes")
                Exit Sub
            ElseIf RBCheque.Checked And txtCheque.Text <> "" Then
                Cheque = txtCheque.Text
            End If

            DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class