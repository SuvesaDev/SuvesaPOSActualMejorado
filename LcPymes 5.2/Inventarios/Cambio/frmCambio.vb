Imports System.Data
Public Class frmCambio
    Enum Tipo
        Facturo
        Entrego
    End Enum
    Public IdUsuario As String = ""
    Public CodigoFacturo As String = ""
    Public CodigoEntrego As String = ""
    Public CostoFacturo As Decimal = 0
    Public CostoEntrego As Decimal = 0
    Private Sub BuscarF1(_Tipo As Tipo)
        Dim Codigo As String = ""
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.Codigo = ""
        BuscarArt.Cod_Articulo = True
        BuscarArt.ShowDialog()
        If BuscarArt.Cancelado Then Exit Sub
        Codigo = BuscarArt.Codigo
        Me.BuscarArticulo(Codigo, _Tipo)
    End Sub
    Private Sub BuscarArticulo(_Cod_Articulo As String, _Tipo As Tipo)
        Dim dt As New DataTable
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Codigo", _Cod_Articulo)
        dt = db.Ejecutar("select Codigo, Cod_Articulo, Barras, Precio_A * (1 + (IVenta / 100)) as Costo, Descripcion, Existencia, Consignacion from Inventario where Inhabilitado = 0 and (Cod_Articulo = @Codigo or Barras = @Codigo or Barras2 = @Codigo)", CommandType.Text)
        If dt.Rows.Count > 0 Then
            If _Tipo = Tipo.Facturo Then
                Me.CodigoFacturo = dt.Rows(0).Item("Codigo")
                Me.txtDescripcionFacturado.Text = dt.Rows(0).Item("Descripcion")
                Me.txtCodigoFacturado.Text = dt.Rows(0).Item("Cod_Articulo")
                Me.CostoFacturo = dt.Rows(0).Item("Costo")
                Me.txtCantidadFacturado.Text = ""
                Me.txtCantidadFacturado.Focus()
            End If
            If _Tipo = Tipo.Entrego Then
                Me.CodigoEntrego = dt.Rows(0).Item("Codigo")
                Me.txtDescripcionEntregado.Text = dt.Rows(0).Item("Descripcion")
                Me.txtCodigoEntregado.Text = dt.Rows(0).Item("Cod_Articulo")
                Me.CostoEntrego = dt.Rows(0).Item("Costo")
                Me.txtCantidadEntegado.Text = ""
                Me.txtCantidadEntegado.Focus()
            End If
        End If
    End Sub
    Private Sub CalcularDiferencia()
        Dim SubTotalFacturo As Decimal = 0
        Dim SubTotalEntrego As Decimal = 0
        Dim Diferencia As Decimal = 0
        Dim Facturo As Decimal = 0
        Dim Entrego As Decimal = 0
        If Me.txtCantidadFacturado.Text <> "" Then
            If IsNumeric(Me.txtCantidadFacturado.Text) Then
                If CDec(Me.txtCantidadFacturado.Text) > 0 Then
                    Facturo = CDec(Me.txtCantidadFacturado.Text)
                End If
            End If
        End If
        If Me.txtCantidadEntegado.Text <> "" Then
            If IsNumeric(Me.txtCantidadEntegado.Text) Then
                If CDec(Me.txtCantidadEntegado.Text) > 0 Then
                    Entrego = CDec(Me.txtCantidadEntegado.Text)
                End If
            End If
        End If
        SubTotalFacturo = CDec(Me.CostoFacturo * Facturo)
        SubTotalEntrego = CDec(Me.CostoEntrego * Entrego)
        Diferencia = CDec(SubTotalFacturo - SubTotalEntrego)
        Me.txtDiferencia.Text = Diferencia.ToString("N2")
    End Sub
    Private Sub btnBuscarFacturado_Click(sender As Object, e As EventArgs) Handles btnBuscarFacturado.Click
        Me.BuscarF1(Tipo.Facturo)
    End Sub
    Private Sub btnBuscarEntregado_Click(sender As Object, e As EventArgs) Handles btnBuscarEntregado.Click
        Me.BuscarF1(Tipo.Entrego)
    End Sub
    Private Sub txtCodigoFacturado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoFacturado.KeyDown
        If e.KeyCode = Keys.Enter And txtCodigoFacturado.Text <> "" Then Me.BuscarArticulo(txtCodigoFacturado.Text, Tipo.Facturo)
        If e.KeyCode = Keys.F1 Then Me.BuscarF1(Tipo.Facturo)
    End Sub
    Private Sub txtCodigoEntregado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoEntregado.KeyDown
        If e.KeyCode = Keys.Enter And txtCodigoEntregado.Text <> "" Then Me.BuscarArticulo(txtCodigoEntregado.Text, Tipo.Entrego)
        If e.KeyCode = Keys.F1 Then Me.BuscarF1(Tipo.Entrego)
    End Sub
    Private Sub txtCantidadFacturado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadFacturado.KeyPress, txtCantidadEntegado.KeyPress
        If e.KeyChar <> "." Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtCantidadFacturado_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadFacturado.TextChanged, txtCantidadEntegado.TextChanged
        Me.CalcularDiferencia()
    End Sub
    Private Sub frmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalcularDiferencia()
    End Sub
    Private Sub txtCantidadFacturado_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCantidadFacturado.KeyDown, txtCantidadEntegado.KeyDown
        If e.KeyCode = Keys.Enter And sender.Text <> "" Then SendKeys.Send("{Tab}")
    End Sub
    Private Sub txtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Id_Usuario, Nombre from usuarios where Clave_Interna = '" & Me.txtClave.Text & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.IdUsuario = dt.Rows(0).Item("Id_Usuario")
                Me.txtUsuario.Text = dt.Rows(0).Item("Nombre")
                Me.panelFacturado.Enabled = True
                Me.panelEntregado.Enabled = True
                Me.btnAceptar.Enabled = True
                SendKeys.Send("{Tab}")
            End If
        End If
    End Sub
    Public Sub GuardarCambio()
        'guarda el cambio
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@IdUsuario", Me.IdUsuario)
        db.AddParametro("@Fecha", Date.Now)
        db.AddParametro("@CodigoFacturado", Me.CodigoFacturo)
        db.AddParametro("@CantidadFacturado", Me.txtCantidadFacturado.Text)
        db.AddParametro("@CodigoEntregado", Me.CodigoEntrego)
        db.AddParametro("@CantidadEntregado", Me.txtCantidadEntegado.Text)
        db.AddParametro("@Diferencia", CDec(Me.txtDiferencia.Text))
        db.AddParametro("@Aplicado", False)
        db.Ejecutar("insert into CAmbioInventario(IdUsuario,Fecha,CodigoFacturado,CantidadFacturado,CodigoEntregado,CantidadEntregado,Diferencia,Aplicado) Values(@IdUsuario,@Fecha,@CodigoFacturado,@CantidadFacturado,@CodigoEntregado,@CantidadEntregado,@Diferencia,@Aplicado)", CommandType.Text)
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.GuardarCambio()
    End Sub
End Class