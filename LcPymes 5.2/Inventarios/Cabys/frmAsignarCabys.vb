Imports System.Data
Public Class frmAsignarCabys
    Private cls As New Modulos.FE.Cabys

    Private Sub CargarDatos()
        Dim dt As New DataTable
        dt = cls.NAVEGADOR_CABYS(Me.txtDescripcion.Text, Me.cboOpcionMostrar.SelectedIndex + 1)

        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("CODIGO").Visible = False
        Me.viewDatos.Columns("EXISTENCIA").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Me.viewDatos.Columns("EXISTENCIA").DefaultCellStyle.Format = "N2"

        Dim recuento As Decimal = (From x As DataGridViewRow In Me.viewDatos.Rows).Count()
        lblRecuento.Text = recuento.ToString("N2")
    End Sub

    Private Sub frmAsignarCabys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.cboOpcionMostrar.SelectedIndex = 0
        Me.CargarDatos()
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim frmCabys As New frmBuscadorCodigoCabys
        If frmCabys.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            For Each factura As DataGridViewRow In Me.viewDatos.SelectedRows
                db.Ejecutar("Update Inventario Set CodCabys = '" & frmCabys.txtCodigo.Text & "' Where Codigo = " & factura.Cells("CODIGO").Value, CommandType.Text)
            Next
            Me.CargarDatos()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If MsgBox("Desea quitar el codigo cabys de los productos seleccionados.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            For Each factura As DataGridViewRow In Me.viewDatos.SelectedRows
                db.Ejecutar("Update Inventario Set CodCabys = '0' Where Codigo = " & factura.Cells("CODIGO").Value, CommandType.Text)
            Next
            Me.CargarDatos()
        End If
    End Sub

    Private Sub btnMAG_Click(sender As Object, e As EventArgs) Handles btnMAG.Click
        If MsgBox("Desea asignar el producto como del MAG.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            For Each factura As DataGridViewRow In Me.viewDatos.SelectedRows
                db.Ejecutar("Update Inventario Set MAG = 1 Where Codigo = " & factura.Cells("CODIGO").Value, CommandType.Text)
            Next
            Me.CargarDatos()
        End If
    End Sub

    Private Sub btnQuitarMAG_Click(sender As Object, e As EventArgs) Handles btnQuitarMAG.Click
        If MsgBox("Desea quitar el producto de la lista del MAG", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            For Each factura As DataGridViewRow In Me.viewDatos.SelectedRows
                db.Ejecutar("Update Inventario Set MAG = 0 Where Codigo = " & factura.Cells("CODIGO").Value, CommandType.Text)
            Next
            Me.CargarDatos()
        End If
    End Sub

    Private Sub cboOpcionMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOpcionMostrar.SelectedIndexChanged
        Me.CargarDatos()
    End Sub

    Private Sub btnAsigarxReferencia_Click(sender As Object, e As EventArgs) Handles btnAsigarxReferencia.Click
        Dim frmCabys As New frmBuscarArticuloMigrador
        If frmCabys.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim CodCabys As String = frmCabys.viewDatos.Item("cabys", frmCabys.viewDatos.CurrentRow.Index).Value
            For Each factura As DataGridViewRow In Me.viewDatos.SelectedRows
                db.Ejecutar("Update Inventario Set CodCabys = '" & CodCabys & "' Where Codigo = " & factura.Cells("CODIGO").Value, CommandType.Text)
            Next
            Me.CargarDatos()
        End If
    End Sub
End Class