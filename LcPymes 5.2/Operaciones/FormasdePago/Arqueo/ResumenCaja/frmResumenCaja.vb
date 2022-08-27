Imports System.Data

Public Class frmResumenCaja
    Public Id_Usuario As String
    Public NombreUsuario As String
    Public IdApertura As Integer = 0

    Private Sub CargarResumenCaja()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("exec ResumenCaja " & Me.IdApertura, dt, CadenaConexionSeePOS)
        Me.viewResumenCaja.DataSource = dt
        Me.viewResumenCaja.Columns("Monto").DefaultCellStyle.Format = "N2"
        Me.viewResumenCaja.Columns("Monto").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight

        Me.txtTotalRecumen.Text = "0.00"
        Dim Suma As Decimal = 0
        For Each x As DataRow In dt.Rows
            Select Case x.Item("Tipo")
                Case "CON" : Suma += x.Item("Monto")
                Case "TCO" : Suma += x.Item("Monto")
                Case "PVE" : Suma += x.Item("Monto")
                Case "ABONO" : Suma += x.Item("Monto")
                Case "DEVOLUCION" : Suma -= x.Item("Monto")
            End Select
        Next
        Me.txtTotalRecumen.Text = Suma.ToString("N2")
    End Sub
    Private Sub frmResumenCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select u.Id_Usuario, u.Nombre, a.Num_Caja, a.NApertura from aperturacaja a inner join Usuarios u on a.Cedula = u.Id_Usuario where u.Id_Usuario = '" & Me.Id_Usuario & "' and a.Estado = 'A'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.IdApertura = dt.Rows(0).Item("NApertura")
            Me.CargarResumenCaja()
            Me.lblTexto.Text = "Resumen Caja #" & Me.IdApertura & "   " & NombreUsuario
        End If
    End Sub

End Class