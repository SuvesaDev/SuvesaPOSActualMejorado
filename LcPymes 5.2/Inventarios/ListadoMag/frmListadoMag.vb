Imports System.Data
Public Class frmListadoMag


    Private Sub CargarDatos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewListaMAG Where Descripcion like '%" & Me.txtDescripcion.Text & "%'", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Codigo").Visible = False
    End Sub

    Private Sub CambiarImpuesto()
        If MsgBox("Desea Cambiar el Impuesto.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ConfirmarAccion") = MsgBoxResult.Yes Then
            Dim frm As New frmSeleccioneImpuesto
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim Id_Impuesto As Integer = frm.cboImpuesto.SelectedValue
                Dim IVenta As Decimal = 0
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select * From Impuestos where Id_Impuesto = " & Id_Impuesto, dt, CadenaConexionSeePOS)

                If dt.Rows.Count > 0 Then
                    IVenta = dt.Rows(0).Item("Porcentaje")
                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    For Each r As DataGridViewRow In Me.viewDatos.SelectedRows
                        db.Ejecutar("Update Inventario set IVenta = " & IVenta & ", Id_Impuesto = " & Id_Impuesto & " Where Codigo = " & r.Cells("Codigo").Value, CommandType.Text)
                    Next
                End If
                Me.CargarDatos()
            End If
        End If
    End Sub

    Private Sub Quitar()
        If MsgBox("Desea Quitar los articulos Seleccionados", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ConfirmarAccion") = MsgBoxResult.Yes Then
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            For Each r As DataGridViewRow In Me.viewDatos.SelectedRows
                db.Ejecutar("Update Inventario set MAG = 0 Where Codigo = " & r.Cells("Codigo").Value, CommandType.Text)
            Next
            Me.CargarDatos()
        End If        
    End Sub

    Private Sub frmListadoMag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        Me.CargarDatos()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Me.Quitar()
    End Sub

    Private Sub btnCambiarImpuesto_Click(sender As Object, e As EventArgs) Handles btnCambiarImpuesto.Click
        Me.CambiarImpuesto()
    End Sub
End Class