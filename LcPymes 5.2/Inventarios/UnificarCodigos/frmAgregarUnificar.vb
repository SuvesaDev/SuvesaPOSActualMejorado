Public Class frmAgregarUnificar
    Private Articulo As New GestionDatos.Articulo
    Public Codigo1, Codigo2 As Long

    Private Sub CargarCBO(ByRef _cbo As System.Windows.Forms.ComboBox)
        Dim dt As New System.Data.DataTable
        cFunciones.Llenar_Tabla_Generico("Select IdPuntoVenta, PuntoVenta from PuntodeVenta", dt, CadenaConexionSeePOS)
        _cbo.DataSource = dt
        _cbo.ValueMember = "IdPuntoVenta"
        _cbo.DisplayMember = "PuntoVenta"
    End Sub

    Private Sub BuscarArticulo1(_IdPuntoVenta As Integer)
        Dim CodigoInterno As String
        Dim IdPuntoVenta As Integer = _IdPuntoVenta
        CodigoInterno = Me.Articulo.BuscarArticulo(IdPuntoVenta)

        If IsNumeric(CodigoInterno) And CodigoInterno <> "" Then
            If CodigoInterno > 0 Then
                Me.Articulo.GET_ARTICULO(CodigoInterno, IdPuntoVenta)
                Me.Codigo1 = Me.Articulo.Id_Articulo
                Me.txtCodigo1.Text = Me.Articulo.Codigo
                Me.txtDescripcion1.Text = Me.Articulo.Descripcion
            End If
        End If
    End Sub

    Private Sub BuscarArticulo2(_IdPuntoVenta As Integer)
        Dim CodigoInterno As String
        Dim IdPuntoVenta As Integer = _IdPuntoVenta
        CodigoInterno = Me.Articulo.BuscarArticulo(IdPuntoVenta)

        If IsNumeric(CodigoInterno) And CodigoInterno <> "" Then
            If CodigoInterno > 0 Then
                Me.Articulo.GET_ARTICULO(CodigoInterno, IdPuntoVenta)
                Me.Codigo2 = Me.Articulo.Id_Articulo
                Me.txtCodigo2.Text = Me.Articulo.Codigo
                Me.txtDescripcion2.Text = Me.Articulo.Descripcion
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmAgregarUnificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Inicializar()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.Codigo1 > 0 And Me.Codigo2 >= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If        
    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        Me.BuscarArticulo1(Me.cboPuntoVenta1.SelectedValue)
    End Sub

    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click
        Me.BuscarArticulo2(Me.cboPuntoVenta2.SelectedValue)
    End Sub

    Private Sub Inicializar()
        Me.Codigo1 = 0
        Me.txtCodigo1.Text = ""
        Me.txtDescripcion1.Text = ""
        Me.Codigo2 = 0
        Me.txtCodigo2.Text = ""
        Me.txtDescripcion2.Text = ""
        Me.CargarCBO(Me.cboPuntoVenta1)
        Me.CargarCBO(Me.cboPuntoVenta2)
    End Sub

    Private Sub cboPuntoVenta2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPuntoVenta2.SelectedIndexChanged
        Me.Codigo2 = 0
        Me.txtCodigo2.Text = ""
        Me.txtDescripcion2.Text = ""
    End Sub
    Private Sub cboPuntoVenta1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPuntoVenta1.SelectedIndexChanged
        Me.Codigo1 = 0
        Me.txtCodigo1.Text = ""
        Me.txtDescripcion1.Text = ""        
    End Sub
End Class