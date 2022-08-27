Imports System.Windows.Forms
Imports System.Data

Public Class frmBuscarTomaProveedor

    Public Tabla As String = "viewTomaProveedor"
    Public CodigoProv As Integer = 0
    Public sinAplicar As Boolean = False

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
        If Me.Tabla = "viewPreTomaProveedor" And Me.sinAplicar = True Then
            cFunciones.Llenar_Tabla_Generico("select * from " & Me.Tabla & " where CodigoProv = " & Me.CodigoProv & " and anulado = 0 and Usado = 0 and Proveedor like '%" & _texto & "%' Order by Id Desc", dt, CadenaConexionSeePOS)
        Else
            cFunciones.Llenar_Tabla_Generico("select * from " & Me.Tabla & " where Proveedor like '%" & _texto & "%' Order by Id Desc", dt, CadenaConexionSeePOS)
        End If
        Me.viewDatos.DataSource = dt
        'Me.viewDatos.Columns("Id").Visible = False
        Me.viewDatos.Columns("Id_UsuarioCreo").Visible = False
        Me.viewDatos.Columns("CodigoProv").Visible = False
    End Sub

    Private Sub frmBuscarTrasladoPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Buscar " & Me.Tabla.Replace("view", "")
        DataGridViewxDefecto(Me.viewDatos)
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

End Class