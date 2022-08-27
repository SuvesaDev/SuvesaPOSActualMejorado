
'@utor :
'ing.Rolando Obando Rojas
'Syscript 2015

Public Class frmCONTROL_PROVEEDOR_META
    Private WithEvents cls As New PROVEEDOR_META

    Private Sub Crear_Registro()
        Dim frm As New frmGUARDAR_PROVEEDOR_META
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            cls.ID_PROVEEDOR_META = 0
            cls.CODIGOPROV = frm.vCODIGOPROV
            cls.MENSUAL = frm.txtMENSUAL.Text
            cls.FECHA = frm.dtpFECHA.Value
            cls.ANULADO = frm.ANULADO
            cls.SAVE_PROVEEDOR_META()
            Me.Cargar_Registros("%%%")
        End If
    End Sub

    Private Sub Editar_Registro()
        Dim frm As New frmGUARDAR_PROVEEDOR_META
        frm.ID_PROVEEDOR_META = Me.viewDatos.Item("ID_PROVEEDOR_META", Me.viewDatos.CurrentRow.Index).Value
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            cls.ID_PROVEEDOR_META = frm.ID_PROVEEDOR_META
            cls.CODIGOPROV = frm.vCODIGOPROV
            cls.MENSUAL = frm.txtMENSUAL.Text
            cls.FECHA = frm.dtpFECHA.Value
            cls.ANULADO = frm.ANULADO
            cls.SAVE_PROVEEDOR_META()
            Me.Cargar_Registros("%%%")
        End If
    End Sub

    Private Sub Inavilitar_Registro()
            If MsgBox("Desea eliminar este registro", MsgBoxStyle.Question + vbYesNo, "Confirmar Accion!!!") = vbYes Then
                Dim Id As String = Me.viewDatos.Item("ID_PROVEEDOR_META", Me.viewDatos.CurrentRow.Index).Value
                cls.ANULAR_PROVEEDOR_META(Id, 1)
                Me.Cargar_Registros("%%%")
            End If
    End Sub

    Private Sub Cargar_Registros(_tex As String)
        Me.viewDatos.DataSource = cls.ALL_PROVEEDOR_META(_tex)
        For Each C As DataGridViewColumn In Me.viewDatos.Columns
            If C.Name = "ID_PROVEEDOR_META"  Or C.Name = "CODIGOPROV"  Or C.Name = "ANULADO"  Then 
                C.Visible = False
            End If
        Next
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"
        Me.viewDatos.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.viewDatos.Columns("Mensual").DefaultCellStyle.Format = "N2"
        Me.viewDatos.Columns("Mensual").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub cls_AlertaError(ByVal msg As String) Handles cls.AlertaError
        MsgBox(msg, MsgBoxStyle.Critical, Text)
    End Sub

    Private Sub frmAllEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar_Registros("%%%%")
        Me.SplitContainer1.Panel1Collapsed = True
        
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Me.Crear_Registro()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Me.Editar_Registro()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Me.Inavilitar_Registro()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Me.Cargar_Registros(Me.txtNombre.Text)
    End Sub


End Class