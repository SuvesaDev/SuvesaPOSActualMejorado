Public Class frmCambioContrasena
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
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bttn_salir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttn_aceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtClaveAccesoNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtClaveInternaNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtClaveAccesoConfirmar As System.Windows.Forms.TextBox
    Friend WithEvents txtClaveInternaConfirmar As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCambioContrasena))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lbl_user = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtClaveAccesoNueva = New System.Windows.Forms.TextBox
        Me.txtClaveInternaNueva = New System.Windows.Forms.TextBox
        Me.txtClaveAccesoConfirmar = New System.Windows.Forms.TextBox
        Me.txtClaveInternaConfirmar = New System.Windows.Forms.TextBox
        Me.bttn_salir = New DevExpress.XtraEditors.SimpleButton
        Me.bttn_aceptar = New DevExpress.XtraEditors.SimpleButton
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(320, 61)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'lbl_user
        '
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_user.Location = New System.Drawing.Point(96, 78)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(94, 16)
        Me.lbl_user.TabIndex = 9
        Me.lbl_user.Text = "Clave de acceso"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(216, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Clave interna"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nueva:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(11, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Confirmar"
        '
        'txtClaveAccesoNueva
        '
        Me.txtClaveAccesoNueva.Location = New System.Drawing.Point(96, 105)
        Me.txtClaveAccesoNueva.Name = "txtClaveAccesoNueva"
        Me.txtClaveAccesoNueva.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveAccesoNueva.Size = New System.Drawing.Size(93, 20)
        Me.txtClaveAccesoNueva.TabIndex = 0
        Me.txtClaveAccesoNueva.Text = ""
        '
        'txtClaveInternaNueva
        '
        Me.txtClaveInternaNueva.Location = New System.Drawing.Point(208, 105)
        Me.txtClaveInternaNueva.Name = "txtClaveInternaNueva"
        Me.txtClaveInternaNueva.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveInternaNueva.Size = New System.Drawing.Size(93, 20)
        Me.txtClaveInternaNueva.TabIndex = 2
        Me.txtClaveInternaNueva.Text = ""
        '
        'txtClaveAccesoConfirmar
        '
        Me.txtClaveAccesoConfirmar.Location = New System.Drawing.Point(96, 142)
        Me.txtClaveAccesoConfirmar.Name = "txtClaveAccesoConfirmar"
        Me.txtClaveAccesoConfirmar.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveAccesoConfirmar.Size = New System.Drawing.Size(93, 20)
        Me.txtClaveAccesoConfirmar.TabIndex = 1
        Me.txtClaveAccesoConfirmar.Text = ""
        '
        'txtClaveInternaConfirmar
        '
        Me.txtClaveInternaConfirmar.Location = New System.Drawing.Point(208, 140)
        Me.txtClaveInternaConfirmar.Name = "txtClaveInternaConfirmar"
        Me.txtClaveInternaConfirmar.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveInternaConfirmar.Size = New System.Drawing.Size(93, 20)
        Me.txtClaveInternaConfirmar.TabIndex = 3
        Me.txtClaveInternaConfirmar.Text = ""
        '
        'bttn_salir
        '
        Me.bttn_salir.Image = CType(resources.GetObject("bttn_salir.Image"), System.Drawing.Image)
        Me.bttn_salir.Location = New System.Drawing.Point(179, 180)
        Me.bttn_salir.Name = "bttn_salir"
        Me.bttn_salir.Size = New System.Drawing.Size(92, 24)
        Me.bttn_salir.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.bttn_salir.TabIndex = 18
        Me.bttn_salir.Text = "Cancelar"
        '
        'bttn_aceptar
        '
        Me.bttn_aceptar.Image = CType(resources.GetObject("bttn_aceptar.Image"), System.Drawing.Image)
        Me.bttn_aceptar.Location = New System.Drawing.Point(63, 180)
        Me.bttn_aceptar.Name = "bttn_aceptar"
        Me.bttn_aceptar.Size = New System.Drawing.Size(88, 24)
        Me.bttn_aceptar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight)
        Me.bttn_aceptar.TabIndex = 17
        Me.bttn_aceptar.Text = "Aceptar"
        '
        'frmCambioContrasena
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 213)
        Me.ControlBox = False
        Me.Controls.Add(Me.bttn_salir)
        Me.Controls.Add(Me.bttn_aceptar)
        Me.Controls.Add(Me.txtClaveInternaConfirmar)
        Me.Controls.Add(Me.txtClaveAccesoConfirmar)
        Me.Controls.Add(Me.txtClaveInternaNueva)
        Me.Controls.Add(Me.txtClaveAccesoNueva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambioContrasena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public ContrasenaActual As String
    Public IdUsuario As String
    Private Sub bttn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_salir.Click

        Me.Close()
    End Sub

    Private Sub bttn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttn_aceptar.Click
        Cambiar()
    End Sub

    Private Sub Cambiar()


        If ValidarCampos() = False Then
            Exit Sub
        End If

        If validarContrasenaActual = False Then
            MsgBox("No se pueden realizar cambios," & vbCrLf & "porque la contraseña de acceso actual, no es correcta", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim sql As String

        If Me.txtClaveAccesoNueva.Text <> "" Then
            sql = "UPDATE Usuarios SET Clave_Entrada = '" & Me.txtClaveAccesoNueva.Text & "'  WHERE Id_usuario = '" & IdUsuario & "'"
            AplicarCambioContrasena(sql)
        End If

        If Me.txtClaveInternaNueva.Text <> "" Then
            sql = "UPDATE Usuarios SET Clave_interna = '" & Me.txtClaveInternaNueva.Text & "'  WHERE Id_usuario = '" & IdUsuario & "'"
            AplicarCambioContrasena(sql)
        End If

        MsgBox("Las nuevas contraseñas se han cambiado satisfactoriamente", MsgBoxStyle.Information)

        Me.Close()
    End Sub

    Private Function ValidarCampos() As Boolean

        If Me.txtClaveAccesoConfirmar.Text <> Me.txtClaveAccesoNueva.Text Then
            MsgBox("No se pudo confirmar la nueva clave de acceso", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtClaveInternaConfirmar.Text <> Me.txtClaveInternaNueva.Text Then
            MsgBox("No se pudo confirmar la nueva clave interna", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtClaveInternaNueva.Text = "" And Me.txtClaveAccesoNueva.Text = "" Then
            MsgBox("No se realizaron cambios", MsgBoxStyle.Information)
            Exit Function
        End If

        ValidarCampos = True
    End Function

    Private Function validarContrasenaActual() As Boolean

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        sql = "SELECT count(*) FROM Usuarios WHERE Id_usuario = '" & IdUsuario & "' AND Clave_Entrada = '" & ContrasenaActual & "'"

        cnnConexion.ConnectionString = CadenaConexionSeguridad
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Function

        If rstReader(0) = 0 Then
            Exit Function
        End If

        validarContrasenaActual = True
    End Function

    Private Function AplicarCambioContrasena(ByVal sql As String)

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
       
        cnnConexion.ConnectionString = CadenaConexionSeguridad
        cnnConexion.Open()
     
        clsConexion.SlqExecute(cnnConexion, sql)

        cnnConexion.Close()
    End Function

    Private Sub frmCambioContrasena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If validarContrasenaActual() = False Then
            MsgBox("No se pueden realizar cambios," & vbCrLf & "porque la contraseña de acceso actual, no es correcta", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
End Class
