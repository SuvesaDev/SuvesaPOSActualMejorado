Public Class frm_mortalidad
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_descripcion As System.Windows.Forms.Label
    Friend WithEvents dt_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ck_anulado As System.Windows.Forms.CheckBox
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents bt_eliminar As System.Windows.Forms.Button
    Friend WithEvents bt_buscar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_codigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_descripcion = New System.Windows.Forms.Label
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_observacion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ck_anulado = New System.Windows.Forms.CheckBox
        Me.btn_nuevo = New System.Windows.Forms.Button
        Me.bt_guardar = New System.Windows.Forms.Button
        Me.bt_eliminar = New System.Windows.Forms.Button
        Me.bt_buscar = New System.Windows.Forms.Button
        Me.lb_id = New System.Windows.Forms.Label
        Me.txt_cantidad = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_nuevo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.bt_guardar)
        Me.Panel1.Controls.Add(Me.bt_eliminar)
        Me.Panel1.Controls.Add(Me.bt_buscar)
        Me.Panel1.Controls.Add(Me.ck_anulado)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 304)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dt_fecha)
        Me.Panel2.Controls.Add(Me.txt_codigo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lb_descripcion)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_observacion)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lb_id)
        Me.Panel2.Controls.Add(Me.txt_cantidad)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(16, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(632, 200)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(80, 48)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(80, 23)
        Me.txt_codigo.TabIndex = 1
        Me.txt_codigo.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Id:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(168, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Descripción:"
        '
        'lb_descripcion
        '
        Me.lb_descripcion.Location = New System.Drawing.Point(256, 48)
        Me.lb_descripcion.Name = "lb_descripcion"
        Me.lb_descripcion.Size = New System.Drawing.Size(360, 24)
        Me.lb_descripcion.TabIndex = 0
        Me.lb_descripcion.Text = "nombre"
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dt_fecha.Location = New System.Drawing.Point(504, 8)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(112, 23)
        Me.dt_fecha.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(448, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha:"
        '
        'txt_observacion
        '
        Me.txt_observacion.Location = New System.Drawing.Point(24, 144)
        Me.txt_observacion.Multiline = True
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(584, 40)
        Me.txt_observacion.TabIndex = 1
        Me.txt_observacion.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Observación"
        '
        'ck_anulado
        '
        Me.ck_anulado.Location = New System.Drawing.Point(552, 264)
        Me.ck_anulado.Name = "ck_anulado"
        Me.ck_anulado.Size = New System.Drawing.Size(88, 24)
        Me.ck_anulado.TabIndex = 3
        Me.ck_anulado.Text = "Anulado"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.LightGray
        Me.btn_nuevo.Location = New System.Drawing.Point(16, 232)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(88, 56)
        Me.btn_nuevo.TabIndex = 1
        Me.btn_nuevo.Text = "Nuevo"
        '
        'bt_guardar
        '
        Me.bt_guardar.BackColor = System.Drawing.Color.LightGray
        Me.bt_guardar.Location = New System.Drawing.Point(112, 232)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(88, 56)
        Me.bt_guardar.TabIndex = 1
        Me.bt_guardar.Text = "Guardar"
        '
        'bt_eliminar
        '
        Me.bt_eliminar.BackColor = System.Drawing.Color.LightGray
        Me.bt_eliminar.Location = New System.Drawing.Point(304, 232)
        Me.bt_eliminar.Name = "bt_eliminar"
        Me.bt_eliminar.Size = New System.Drawing.Size(88, 56)
        Me.bt_eliminar.TabIndex = 1
        Me.bt_eliminar.Text = "Eliminar"
        '
        'bt_buscar
        '
        Me.bt_buscar.BackColor = System.Drawing.Color.LightGray
        Me.bt_buscar.Location = New System.Drawing.Point(208, 232)
        Me.bt_buscar.Name = "bt_buscar"
        Me.bt_buscar.Size = New System.Drawing.Size(88, 56)
        Me.bt_buscar.TabIndex = 1
        Me.bt_buscar.Text = "Buscar"
        '
        'lb_id
        '
        Me.lb_id.Location = New System.Drawing.Point(64, 16)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(24, 16)
        Me.lb_id.TabIndex = 0
        Me.lb_id.Text = "0.0"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(96, 88)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(80, 23)
        Me.txt_cantidad.TabIndex = 1
        Me.txt_cantidad.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cantidad:"
        '
        'frm_mortalidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(680, 321)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_mortalidad"
        Me.Text = "Mortalidad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
