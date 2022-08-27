Imports System.Data
Imports System.Windows.Forms

Public Class frmBuscarArqueo

    Private Sub Buscar(_Usuario As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select aa.NApertura as Apertura, ac.Id as Arqueo, ac.Fecha, ac.Cajero as Usuario from ArqueoCajas ac inner join aperturacaja aa on ac.IdApertura = aa.NApertura where ac.Cajero like '%" & _Usuario & "%' Order By ac.Fecha desc", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
    End Sub

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

    Private Sub frmBuscarTrasladoPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.viewDatos.RowCount > 0 Then
                Me.viewDatos.Focus()
            End If
        End If
    End Sub

    Private Sub viewDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDatos.KeyDown
        If viewDatos.RowCount > 0 Then
            Me.btnAceptar.Focus()
        End If
    End Sub

End Class