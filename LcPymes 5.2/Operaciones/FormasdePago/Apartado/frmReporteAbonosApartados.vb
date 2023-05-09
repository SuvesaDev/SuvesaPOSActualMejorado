Imports System.Data
Public Class frmReporteAbonosApartados

    Public IdApartado As Long
    Public Cliente As String
    Public TotalApartado As Decimal
    Private TotalAbonos As Decimal
    Public Caja As Integer
    Public BaseDatos As String = "SeePOS"

    Private Sub CargarAbonos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select a.Id_abonoapartado, a.Num_Recibo, a.Fecha, case a.Anula when 1 then 0 else ad.Saldo_Ant end as Saldo_Ant, case a.Anula when 1 then 0 else ad.Abono end as Abono, case a.Anula when 1 then 0 else ad.Saldo end as Saldo from " & Me.BaseDatos & ".dbo.Abono_Apartados a inner join " & Me.BaseDatos & ".dbo.Abono_apartadosdetalle ad on a.Id_abonoapartado = ad.Id_abonoapartado where ad.apartado = " & Me.IdApartado, dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Id_abonoapartado").Visible = False

        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"

        Me.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewDatos.Columns("Abono").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("Abono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.viewDatos.Columns("Saldo").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        Me.TotalAbonos = (From x As DataGridViewRow In Me.viewDatos.Rows Select CDec(x.Cells("Abono").Value)).Sum

        Me.txtTotalInicial.Text = Me.TotalApartado.ToString("N2")
        Me.txtTotalAbonos.Text = Me.TotalAbonos.ToString("N2")
        Me.txtTotalPendiente.Text = CDec(Me.TotalApartado - Me.TotalAbonos).ToString("N2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmReporteAbonosApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtIdApartado.Text = Me.IdApartado
        Me.txtCliente.Text = Me.Cliente
        Me.txtTotalApartado.Text = TotalApartado.ToString("N2")
        Me.CargarAbonos()
    End Sub

    Private Sub btnImprimirApartado_Click(sender As Object, e As EventArgs) Handles btnImprimirApartado.Click
        GeneralCaja.clsImpresion.ImprimirApartado(Me.IdApartado, "SeePOS", Me.Caja)
    End Sub

    Private Sub btnImprimirLista_Click(sender As Object, e As EventArgs) Handles btnImprimirLista.Click
        For Each a As DataGridViewRow In Me.viewDatos.Rows
            GeneralCaja.clsImpresion.ImprimirAbonoApartado2(a.Cells("Id_abonoapartado").Value, "SeePOS", Me.Caja)
        Next
    End Sub

End Class