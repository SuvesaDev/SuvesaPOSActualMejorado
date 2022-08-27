Imports System.Data
Public Class FrmPlantilla
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
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Public WithEvents DataNavigator As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents PictureBoxFondo As System.Windows.Forms.PictureBox
    Public WithEvents TituloModulo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlantilla))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.DataNavigator = New DevExpress.XtraEditors.DataNavigator
        Me.PictureBoxFondo = New System.Windows.Forms.PictureBox
        Me.TituloModulo = New System.Windows.Forms.Label
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 394)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(778, 52)
        Me.ToolBar1.TabIndex = 57
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Name = "ToolBarExcel"
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'DataNavigator
        '
        Me.DataNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataNavigator.Buttons.Append.Visible = False
        Me.DataNavigator.Buttons.CancelEdit.Visible = False
        Me.DataNavigator.Buttons.EndEdit.Visible = False
        Me.DataNavigator.Buttons.Remove.Visible = False
        Me.DataNavigator.DataMember = "Inventario"
        Me.DataNavigator.Location = New System.Drawing.Point(642, 424)
        Me.DataNavigator.Name = "DataNavigator"
        Me.DataNavigator.Size = New System.Drawing.Size(134, 21)
        Me.DataNavigator.TabIndex = 69
        Me.DataNavigator.Text = "DataNavigator"
        '
        'PictureBoxFondo
        '
        Me.PictureBoxFondo.Image = CType(resources.GetObject("PictureBoxFondo.Image"), System.Drawing.Image)
        Me.PictureBoxFondo.Location = New System.Drawing.Point(0, 16)
        Me.PictureBoxFondo.Name = "PictureBoxFondo"
        Me.PictureBoxFondo.Size = New System.Drawing.Size(16, 16)
        Me.PictureBoxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFondo.TabIndex = 70
        Me.PictureBoxFondo.TabStop = False
        Me.PictureBoxFondo.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(778, 32)
        Me.TituloModulo.TabIndex = 58
        Me.TituloModulo.Text = "Titulo del Módulo"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmPlantilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(778, 446)
        Me.Controls.Add(Me.DataNavigator)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.PictureBoxFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPlantilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantilla"
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub NuevosDatos(ByRef DataSet As DataSet, ByRef Tabla As String)
        'Define dataset y tablas para crear  un nuevo campo
        If ToolBar1.Buttons(0).Text = "Nuevo" Then
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8

            Try
                BindingContext(DataSet, Tabla).EndCurrentEdit()
                BindingContext(DataSet, Tabla).AddNew()
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            Me.BindingContext(DataSet, Tabla).CancelCurrentEdit()
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
        End If
    End Sub
    Public Sub EliminarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal RecargarAdatador As Boolean = True)
        Dim resp As Integer

        If MsgBox("Desea eliminar el registrto actual...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
            Try
                BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
                BindingContext(DataSet, Tabla).EndCurrentEdit()
                Adaptador.Update(DataSet, Tabla)
                If RecargarAdatador Then Adaptador.Update(DataSet, Tabla)
                Adaptador.Fill(DataSet, Tabla)

                MsgBox("Los datos se eliminaron satisfactoriamente", MsgBoxStyle.Information)

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Sub
    Public Sub RegistrarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal ActivarNuevo As Boolean = True, Optional ByVal VerMsg As Boolean = True, Optional ByVal RecargarAdatador As Boolean = True)
        Try
            BindingContext(DataSet, Tabla).EndCurrentEdit()
            Adaptador.Update(DataSet, Tabla)
            If RecargarAdatador Then Adaptador.Fill(DataSet, Tabla)
            If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            If VerMsg Then MsgBox("Los datos se actualizaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")
        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub
    Public Sub Cerrar()
        If MsgBox("Desea Cerrar este módulo...[" & Me.Text & "]", MsgBoxStyle.YesNo, "Atención..") = MsgBoxResult.Yes Then Close()
    End Sub

    Private Sub FrmPlantilla_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Visible = True Then
            'Dim imagen As New Drawing.Bitmap(Me.PictureBoxFondo.Image, Me.Width, Me.Height)
            'Me.BackgroundImage = imagen
        End If
    End Sub

    Private Sub FrmPlantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
