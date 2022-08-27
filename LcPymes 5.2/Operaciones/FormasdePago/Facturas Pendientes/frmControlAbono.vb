Imports System.Data
Public Class frmControlAbono

    Public IdFactura As String = ""

    Private Sub CargarAbonos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select IdAbono, Id_Factura, Fecha, Monto, Anulado from abonoreintegro where Id_Factura = " & Me.IdFactura, dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("IdAbono").Visible = False
        Me.viewDatos.Columns("Id_Factura").Visible = False
        Me.viewDatos.Columns("Monto").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("Monto").DefaultCellStyle.Format = "N2"
    End Sub

    Private Function GetAbono() As Decimal
        If CDec(Me.IdFactura) > 0 Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select isnull(sum(Monto),0) as Abono from abonoreintegro Where Anulado = 0 and Id_Factura = " & Me.IdFactura, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Abono")
            Else
                Return 0
            End If
        Else
            Return 0
        End If
    End Function

    Private Sub CalcularTotalCobro()
        Dim Abono As Decimal = Me.GetAbono
        Me.txtTotalAbono.Text = Abono.ToString("N2")
        Me.txtTotalCobro.Text = (CDec(Me.txtTotalFactura.Text) - Abono).ToString("N2")
    End Sub

    Private Sub frmControlAbono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarAbonos()
        Me.CalcularTotalCobro()
    End Sub

    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As String = ""

    Private Sub btnAbonar_Click(sender As Object, e As EventArgs) Handles btnAbonar.Click
        Dim frm As New frmAbonoReintegro
        frm.Id_Usuario = Me.Id_Usuario
        frm.NombreUsuario = Me.NombreUsuario
        frm.Numero_Caja = Me.Numero_Caja
        frm.IdFactura = Me.IdFactura
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.CargarAbonos()
            Me.CalcularTotalCobro()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class