Imports System.Data
Public Class frmSaldoFirmadoContado
    Public Id_Factura As String
    Public Devolucion As Decimal = 0
    Public Abono As Decimal = 0

    Private Sub CargarDatosFacturaFirmado()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select av.Id_Factura, v.Num_Factura, v.Nombre_Cliente, av.Cedula_Retira, av.Nombre_Retira, v.Total, isnull(dbo.fnAbonoReintegro(v.Id),0) as Abonos, isnull(dbo.fnDevolucionesContadoFirmado(getdate(), v.Id),0) as Devoluciones from Ventas v inner join AutorizacionVenta av on v.id = av.Id_Factura Where av.Id_Factura = " & Me.Id_Factura, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtNumFactura.Text = dt.Rows(0).Item("Num_Factura")
            Me.txtCliente.Text = dt.Rows(0).Item("Nombre_Cliente")
            Me.txtCedula.Text = dt.Rows(0).Item("Cedula_Retira")
            Me.txtRetiro.Text = dt.Rows(0).Item("Nombre_Retira")
            Me.txtTotalFactura.Text = CDec(dt.Rows(0).Item("Total")).ToString("N2")
            Me.txtAbonos.Text = CDec(dt.Rows(0).Item("Abonos") + Me.Abono).ToString("N2")
            Me.txtDevoluciones.Text = CDec(dt.Rows(0).Item("Devoluciones") + Me.Devolucion).ToString("N2")
            Me.txtSaldoPendiente.Text = CDec(CDec(Me.txtTotalFactura.Text) - CDec(Me.txtAbonos.Text) - CDec(Me.txtDevoluciones.Text)).ToString("N2")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmSaldoFirmadoContado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatosFacturaFirmado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class