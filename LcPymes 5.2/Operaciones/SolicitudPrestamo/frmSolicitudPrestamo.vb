Imports System.Data
Public Class frmSolicitudPrestamo

    Private CeduaEmisor As String = ""
    Private UsarioEmisor As String = ""
    Private Index As Integer = 0
    Private Codigo As Long = 0
    Private NuevaLinea As Boolean = False

    Private Sub CargarCedulaEmisor()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Identificacion from Seguridad.dbo.Emisor", dt, CadenaConexionSeguridad)
        Me.CeduaEmisor = dt.Rows(0).Item("Identificacion")
    End Sub

    Private Sub CargarEmpresas()
        Dim dt As New DataTable
        dt = OBSoluciones.db.Ejecutar("SELECT e.Cedula, e.Empresa FROM empresa e WHERE e.Cedula <> '" & CeduaEmisor & "'", Data.CommandType.Text)
        Me.cboEmpresa.DataSource = dt
        Me.cboEmpresa.DisplayMember = "Empresa"
        Me.cboEmpresa.ValueMember = "Cedula"
    End Sub

    Private Sub BuscarF1()
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then
            Exit Sub
        End If
        Codigo = BuscarArt.Codigo
        Me.BuscarArticulo(Codigo)
    End Sub

    Private Sub BuscarArticulo(_Cod_Articulo As String)
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Codigo", _Cod_Articulo)
        dt = db.Ejecutar("select i.Codigo, i.Cod_Articulo, i.Barras, i.Costo, i.Descripcion + ' ( ' + CAST(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones + ' )' As Descripcion, i.Existencia, i.Consignacion from Inventario i Inner Join Presentaciones p On i.CodPresentacion = p.CodPres where i.Inhabilitado = 0 and (i.Cod_Articulo = @Codigo or i.Barras = @Codigo or i.Barras2 = @Codigo)", CommandType.Text)
        If dt.Rows.Count > 0 Then
            Me.Codigo = dt.Rows(0).Item("Codigo")
            Me.txtCodigo.Text = dt.Rows(0).Item("Cod_Articulo")
            Me.lblDescripcion.Text = dt.Rows(0).Item("Descripcion")
            Me.txtCantidad.Focus()
        End If
    End Sub

    Private Sub AgregarArticulo(_IdPedidoDetalle As Integer, _Codigo As String, _Descripcion As String, _Cantidad As Decimal)
        Me.viewDatos.Rows.Add()
        Me.viewDatos.Item("cIdPedidoDetalle", Me.Index).Value = _IdPedidoDetalle
        Me.viewDatos.Item("cCodigo", Me.Index).Value = _Codigo
        Me.viewDatos.Item("cDescripcion", Me.Index).Value = _Descripcion
        Me.viewDatos.Item("cCantidad", Me.Index).Value = _Cantidad
        Me.Index += 1
    End Sub

    Private Sub Agregar()
        If Me.Codigo > 0 Then
            Me.AgregarArticulo(0, Me.Codigo, Me.lblDescripcion.Text, Me.txtCantidad.Text)
            Me.Codigo = 0
            Me.txtCodigo.Text = ""
            Me.lblDescripcion.Text = ""
            Me.txtCantidad.Text = ""
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub Registrar()
        If MsgBox("Desea Registrar la Solicitud de Prestamo.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Cofirmar Accion!!!") = MsgBoxResult.Yes Then
            Dim cls As New OBSoluciones.Pedido
            cls.IdPedido = 0
            cls.CedulaEmisor = Me.CeduaEmisor
            cls.CedulaReceptor = Me.cboEmpresa.SelectedValue
            cls.UsuarioEmisor = Me.UsarioEmisor
            cls.UsuarioReceptor = ""
            cls.Fecha = Date.Now
            cls.Observaciones = Me.txtObservaciones.Text
            If cls.GuardarPedido(Me.viewDatos) = True Then
                MsgBox("Solicitud de Prestamo Registrada!!!", MsgBoxStyle.Information, Text)
                Me.Close()
            Else
                MsgBox("No se puedo realizar la Operacion.", MsgBoxStyle.Exclamation, Text)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Me.Registrar()
    End Sub

    Private Sub frmSolicitudPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCedulaEmisor()
        Me.CargarEmpresas()
    End Sub

    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from Usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeguridad)
            If dt.Rows.Count > 0 Then
                Me.UsarioEmisor = dt.Rows(0).Item("Nombre")
                Me.lblUsuario.Text = Me.UsarioEmisor
                Me.txtClave.Enabled = False
                Me.btnRegistrar.Enabled = True
                Me.Panel1.Enabled = True
                Me.cboEmpresa.Focus()
            End If
        End If
    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Me.BuscarF1()
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter And Me.txtCodigo.Text <> "" Then
            Me.BuscarArticulo(Me.txtCodigo.Text)
        End If
        If e.KeyCode = Keys.F1 Then
            Me.BuscarF1()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Agregar()
    End Sub

    Private Sub txtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCantidad.Text <> "" Then
                If IsNumeric(Me.txtCantidad.Text) Then
                    Me.Agregar()
                End If
            End If
        End If        
    End Sub

    Private Sub cboEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles cboEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub frmSolicitudPrestamo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.Registrar()
        End If
    End Sub

    Private Sub viewDatos_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles viewDatos.UserDeletedRow
        Me.Index -= 1
    End Sub
End Class