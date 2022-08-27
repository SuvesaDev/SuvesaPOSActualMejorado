
'@utor :
'ing.Rolando Obando Rojas
'Syscript 2015

Public Class frmCONTROL_VALIDA_FIRMADOCONTADO
    Private WithEvents cls As New VALIDA_FIRMADOCONTADO

    Private Sub Crear_Registro()
        Dim frm As New frmGUARDAR_VALIDA_FIRMADOCONTADO
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            cls.ID_VALIDA_FIRMADOCONTADO = 0
            cls.CONTADO = IIf(frm.ckCONTADO.Checked = True, 1, 0)
            cls.PVE = IIf(frm.ckPVE.Checked = True, 1, 0)
            cls.MONTO_MAXIMO = frm.txtMONTO_MAXIMO.Text
            cls.EXIGE_NOMBRE = IIf(frm.ckEXIGE_NOMBRE.Checked = True, 1, 0)
            cls.MAXIMO_CLIENTE = frm.txtMAXIMO_CLIENTE.Text
            cls.MAXIMO_AUTORIZA = frm.txtMAXIMO_AUTORIZA.Text
            cls.MAXIMO_RETIRA = frm.txtMAXIMO_RETIRA.Text
            cls.SAVE_VALIDA_FIRMADOCONTADO(frm.viewEXEPCION_FIRMADOCONTADO)
            Me.Cargar_Registros("%%%")
        End If
    End Sub

    Private Sub Editar_Registro()
        Dim frm As New frmGUARDAR_VALIDA_FIRMADOCONTADO
        frm.ID_VALIDA_FIRMADOCONTADO = Me.viewDatos.Item("ID_VALIDA_FIRMADOCONTADO", Me.viewDatos.CurrentRow.Index).Value
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            cls.ID_VALIDA_FIRMADOCONTADO = frm.ID_VALIDA_FIRMADOCONTADO
            cls.CONTADO = IIf(frm.ckCONTADO.Checked = True, 1, 0)
            cls.PVE = IIf(frm.ckPVE.Checked = True, 1, 0)
            cls.MONTO_MAXIMO = frm.txtMONTO_MAXIMO.Text
            cls.EXIGE_NOMBRE = IIf(frm.ckEXIGE_NOMBRE.Checked = True, 1, 0)
            cls.MAXIMO_CLIENTE = frm.txtMAXIMO_CLIENTE.Text
            cls.MAXIMO_AUTORIZA = frm.txtMAXIMO_AUTORIZA.Text
            cls.MAXIMO_RETIRA = frm.txtMAXIMO_RETIRA.Text
            cls.SAVE_VALIDA_FIRMADOCONTADO(frm.viewEXEPCION_FIRMADOCONTADO)
            Me.Cargar_Registros("%%%")
        End If
    End Sub

    Private Sub Inavilitar_Registro()
            If MsgBox("Desea eliminar este registro", MsgBoxStyle.Question + vbYesNo, "Confirmar Accion!!!") = vbYes Then
                Dim Id As String = Me.viewDatos.Item("ID_VALIDA_FIRMADOCONTADO", Me.viewDatos.CurrentRow.Index).Value
                cls.ALL_VALIDACION(Id, 1)
                Me.Cargar_Registros("%%%")
            End If
    End Sub

    Private Sub Cargar_Registros(_tex As String)
        Me.viewDatos.DataSource = cls.ALL_VALIDACION(_tex)
        For Each C As DataGridViewColumn In Me.viewDatos.Columns
            If C.Name = "ID_VALIDA_FIRMADOCONTADO"  Then 
                C.Visible = False
            End If
        Next
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