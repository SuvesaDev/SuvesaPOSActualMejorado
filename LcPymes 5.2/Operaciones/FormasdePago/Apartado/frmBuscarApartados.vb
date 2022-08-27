Imports System.Data
Imports System.IO
Imports System.Diagnostics

Public Class frmBuscarApartados

    Private Sub CargarApartados()
        Dim strSQL As String = "select * from viewapartadosactivos "
        If Me.txtBuscar.Text <> "" Then
            If Me.opNombre.Checked = True Then
                strSQL += "Where Cliente like '%" & Me.txtBuscar.Text & "%'"
            End If
            If Me.opApartado.Checked = True Then
                strSQL += "Where Apartado = '" & Me.txtBuscar.Text & "'"
            End If
        End If

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
        Me.viewApartados.DataSource = dt
        If Me.viewApartados.Rows.Count > 0 Then
            Me.viewApartados.Columns("Total").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.viewApartados.Columns("Total").DefaultCellStyle.Format = "N2"

            Me.viewApartados.Columns("Saldo").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
            Me.viewApartados.Columns("Saldo").DefaultCellStyle.Format = "N2"

            Me.viewApartados.Columns("Fecha").DefaultCellStyle.Format = "d"
        End If
    End Sub

    Private Sub frmBuscarApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarApartados()
    End Sub

    Private Sub opNombre_CheckedChanged(sender As Object, e As EventArgs) Handles opNombre.CheckedChanged, opApartado.CheckedChanged
        Me.CargarApartados()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.CargarApartados()
    End Sub

    Public Id_Usuario As String = ""
    Public Nombre_Usuario As String = ""
    Public Num_Caja As String = ""
    Private Sub btnAbonar_Click(sender As Object, e As EventArgs) Handles btnAbonar.Click
        Dim frm As New frmRegistrarAbonoApartado
        frm.Id_Usuario = Me.Id_Usuario
        frm.Nombre_Usuario = Me.Nombre_Usuario
        frm.Num_Caja = Me.Num_Caja
        frm.BaseDatos = Me.viewApartados.Item("BaseDatos", Me.viewApartados.CurrentRow.Index).Value
        frm.txtSaldoAnterior.Text = Me.viewApartados("Saldo", Me.viewApartados.CurrentRow.Index).Value
        frm.IdApartado = Me.viewApartados("Apartado", Me.viewApartados.CurrentRow.Index).Value
        frm.ShowDialog()
        Me.CargarApartados()
    End Sub

    Private Sub viewApartados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewApartados.CellDoubleClick
        Dim frm As New frmReporteAbonosApartados
        frm.BaseDatos = Me.viewApartados.Item("BaseDatos", Me.viewApartados.CurrentRow.Index).Value
        frm.IdApartado = Me.viewApartados("Apartado", Me.viewApartados.CurrentRow.Index).Value
        frm.Cliente = Me.viewApartados("Cliente", Me.viewApartados.CurrentRow.Index).Value
        frm.TotalApartado = Me.viewApartados("Total", Me.viewApartados.CurrentRow.Index).Value
        frm.Caja = Me.Num_Caja
        frm.ShowDialog()
    End Sub

End Class