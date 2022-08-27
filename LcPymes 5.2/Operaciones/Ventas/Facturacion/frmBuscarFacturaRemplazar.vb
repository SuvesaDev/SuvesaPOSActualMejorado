Imports System.Data
Public Class frmBuscarFacturaRemplazar

    Public Id_Factura As Long = 0

    Private Sub CargarFactura()
        Try
            Dim dt As New DataTable
            Dim strSQL As String = "Select Id, Fecha, Num_Factura, Tipo, Nombre_Cliente, Total From Ventas "
            If cboTipo.Text <> "" Then
                strSQL += "Where Num_Factura = " & Me.txtNumero.Text & " And Tipo = '" & Me.cboTipo.Text & "'"
            Else
                strSQL += "Where Num_Factura = " & Me.txtNumero.Text
            End If
            cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
            Me.viewFacturas.DataSource = dt
            Me.viewFacturas.Columns("Id").Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.txtNumero.Text <> "" Then
            Me.CargarFactura()
        End If
    End Sub

End Class