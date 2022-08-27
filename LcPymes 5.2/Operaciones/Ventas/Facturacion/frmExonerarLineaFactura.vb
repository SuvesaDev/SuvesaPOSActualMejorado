Imports System.Data
Imports System.Windows.Forms

Public Class frmExonerarLineaFactura

    Public Identificacion As String = ""
    Private dt As New DataTable

    Public IdTipoExoneracion As Integer
    Public NumeroDocumento As String
    Public FechaEmision As Date
    Public PorcentajeCompra As Decimal

    Private Sub CargarCartas()
        cFunciones.Llenar_Tabla_Generico("Select * from viewcartaexoneracion where identificacion = " & Me.Identificacion & " and dbo.dateonly(fechaVence) >= dbo.dateonly(getdate())", Me.dt, CadenaConexionSeePOS)
        Me.cboCartaExoneracion.DataSource = dt
        Me.cboCartaExoneracion.DisplayMember = "NumeroDocumento"
        Me.cboCartaExoneracion.ValueMember = "Id"
        If Me.dt.Rows.Count > 0 Then
            Me.Button2.Enabled = True
        Else
            Me.Button2.Enabled = False
        End If
    End Sub

    Private Sub frmExonerarLineaFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCartas()
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.CargarCartas()
    End Sub

    Private Sub cboCartaExoneracion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCartaExoneracion.SelectedValueChanged
        Try
            Dim fila() As DataRow
            fila = Me.dt.Select("Id = " & Me.cboCartaExoneracion.SelectedValue)
            Me.txtPorcentajeCompra.Text = fila(0).Item("PorcentajeCompra")
            Me.txtIV.Text = fila(0).Item("Impuesto")

            Me.IdTipoExoneracion = fila(0).Item("IdTipoExoneracion")
            Me.NumeroDocumento = fila(0).Item("NumeroDocumento")
            Me.FechaEmision = fila(0).Item("FechaEmision")
            Me.PorcentajeCompra = fila(0).Item("PorcentajeCompra")

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub txtPorcentajeCompra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPorcentajeCompra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Button2.Focus()
        End If
    End Sub
End Class