Imports System.Windows.Forms
Imports System.Data

Public Class frmBuscarFacturaPendiente

    Public Sub DataGridViewxDefecto(ByRef _view As DataGridView, Optional ByVal _readonly As Boolean = True)
        With _view
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToOrderColumns = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .ReadOnly = _readonly
            .MultiSelect = False
            .BackgroundColor = Drawing.Color.White
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub Buscar(_texto As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select cast(0 as bit) as Usar, Basededatos, PuntoVenta, Id, Id_Factura, Num_Factura, Nombre_Cliente as Cliente, Nombre_Retira as Retiro, Fecha, Cajero, Administrador, Total from viewAutorizacionFacturasPendientes Where Total > 1 and Cancelada = 0 And (Nombre_Cliente like '%" & _texto & "%' or Nombre_Retira like '%" & _texto & "%' or Cajero like '%" & _texto & "%' or Administrador like '%" & _texto & "%') ", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Id").Visible = False
        Me.viewDatos.Columns("Id_Factura").Visible = False
        Me.viewDatos.Columns("Basededatos").Visible = False

        For Each col As DataGridViewColumn In Me.viewDatos.Columns
            col.ReadOnly = True
        Next
        Me.viewDatos.Columns("Usar").ReadOnly = False

    End Sub

    Private Sub frmBuscarFacturaPendiente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewxDefecto(Me.viewDatos, False)
        Me.Buscar(Me.txtBuscar.Text)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.Buscar(Me.txtBuscar.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If viewDatos.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        If viewDatos.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub ckTodos_CheckedChanged(sender As Object, e As EventArgs) Handles ckTodos.CheckedChanged
        Dim usar As Boolean = Me.ckTodos.Checked
        For Each r As DataGridViewRow In Me.viewDatos.Rows
            r.Cells("Usar").Value = usar
        Next
    End Sub

End Class