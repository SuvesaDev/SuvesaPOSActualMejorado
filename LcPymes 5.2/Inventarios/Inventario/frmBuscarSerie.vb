Imports System.Data
Public Class frmBuscarSerie

    Private Sub BuscarSerie()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewseriesvendidas Where Serie like '%" & Me.txtBuscar.Text & "%' or Nombre_Cliente like '%" & Me.txtBuscar.Text & "%'", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Id").Visible = False
        Me.viewDatos.Columns("CodArticulo").Visible = False
        Me.viewDatos.Columns("Tipo").Visible = False
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"
        Me.viewDatos.Columns("serie").HeaderText = "# Serie"
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmBuscarSerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuscarSerie()
        Me.txtBuscar.Focus()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.BuscarSerie()
    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class