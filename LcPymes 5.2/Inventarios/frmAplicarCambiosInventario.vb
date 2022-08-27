Imports System.Data
Public Class frmAplicarCambiosInventario

    Private Sub CargarCambiosPendientes()
        Dim strSQL As String = "select * from viewCambiosInventario Where aplicado = 0"
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
        Me.viewCambios.DataSource = dt
        'Solo lectura
        For Each col As DataGridViewColumn In Me.viewCambios.Columns
            If col.Name <> "Aplicado" Then
                col.ReadOnly = True
            End If
        Next
        'Oculta columnas
        Me.viewCambios.Columns("Id").Visible = False
        Me.viewCambios.Columns("IdUsuario").Visible = False
        Me.viewCambios.Columns("CodigoF").Visible = False
        Me.viewCambios.Columns("CodigoE").Visible = False
        Me.viewCambios.Columns("Cod_ArticuloF").Visible = False
        Me.viewCambios.Columns("Cod_ArticuloE").Visible = False
        'Formato columnas
        Me.viewCambios.Columns("Fecha").DefaultCellStyle.Format = "d"
        Me.viewCambios.Columns("CantidadFacturado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewCambios.Columns("CantidadEntregado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewCambios.Columns("CantidadFacturado").DefaultCellStyle.Format = "N2"
        Me.viewCambios.Columns("CantidadEntregado").DefaultCellStyle.Format = "N2"
        Me.viewCambios.Columns("Diferencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewCambios.Columns("Diferencia").DefaultCellStyle.Format = "N2"
        'Texto Encabezado
        Me.viewCambios.Columns("DescripcionE").HeaderText = "Entregado"
        Me.viewCambios.Columns("DescripcionF").HeaderText = "Facturado"
        Me.viewCambios.Columns("CantidadFacturado").HeaderText = "Facturado"
        Me.viewCambios.Columns("CantidadEntregado").HeaderText = "Entregado"
    End Sub

    Private Sub frmAplicarCambiosInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarCambiosPendientes()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        For Each row As DataGridViewRow In Me.viewCambios.Rows
            If row.Cells("Aplicado").Value = True Then
                db.AddParametro("@Id", row.Cells("Id").Value)
                db.Ejecutar("AplicarCambioInventario")
            End If
        Next
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class