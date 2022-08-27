Imports System.Data

Public Class frmPD
    Public IdAgente As Integer = 0
    Private IdProveedor As Integer = 0
    Private Index As Integer = 0

    Private Sub CargarDatosAgente()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id, IdAgente, CodProveedor, Proveedor, Tipo, Porcentaje from PrecioDiferenciado Where IdAgente = " & Me.IdAgente, dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            Me.AgregarLinea(r.Item("Id"), r.Item("CodProveedor"), r.Item("Proveedor"), r.Item("Tipo"), CDec(r.Item("Porcentaje")))
        Next
    End Sub

    Private Sub AgregarLinea(_Id As Integer, _CodProveedor As Integer, _Proveedor As String, _Tipo As String, _Porcentaje As Double)
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Item("cId", Index).Value = _Id
        Me.DataGridView1.Item("cCodProveedor", Index).Value = _CodProveedor
        Me.DataGridView1.Item("cProveedor", Index).Value = _Proveedor
        Me.DataGridView1.Item("cTipo", Index).Value = _Tipo
        Me.DataGridView1.Item("cPorcentaje", Index).Value = _Porcentaje
        Me.Index += 1
    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        Dim dt As New DataTable
        Dim Fx As New cFunciones
        Dim valor As String
        valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
        If valor = "" Then
            Me.IdProveedor = "0"
            Me.txtProveedor.Text = ""
        Else
            cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.IdProveedor = dt.Rows(0).Item("CodigoProv")
                Me.txtProveedor.Text = dt.Rows(0).Item("Nombre")
            End If
        End If
    End Sub

    Private Sub frmPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboTipo.SelectedIndex = 0
        If Me.IdAgente > 0 Then Me.CargarDatosAgente()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If IsNumeric(Me.txtDescuento.Text) Then
            If CDec(Me.txtDescuento.Text) Then
                Me.AgregarLinea(0, Me.IdProveedor, Me.txtProveedor.Text, Me.cboTipo.Text, CDec(Me.txtDescuento.Text))
            End If
        End If

    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        Me.Index -= 1
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class