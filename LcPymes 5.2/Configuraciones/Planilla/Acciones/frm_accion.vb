Imports System.Data
Imports System.Data.SqlClient
Public Class frm_accion
    Private Sub Bt_nuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_nuevo.Click
        limpiar()
        Me.Panel2.Enabled = True
        Me.Bt_guardar.Text = "Guardar"
        Bt_guardar.Enabled = True
        Bt_editar.Enabled = False
        Bt_eliminar.Enabled = False
    End Sub
    Public Sub limpiar()
        lbid.Text = ""
        txt_empleado.Text = ""
        txt_nombre_empleado.Text = ""
        txt_observaciones.Text = ""
        ck_anulada.Checked = False
    End Sub

    Private Sub Bt_guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_guardar.Click
        Try
            Dim dts As New Vaccion
            Dim func As New Faccion

            'If validacion() Then
            '    MsgBox("Falta rellenar campos", MsgBoxStyle.Critical, "Validación")
            '    Exit Sub
            'End If
            dts.gid = lbid.Text
            dts.gid_categoria = cbo_categoria.SelectedValue
            dts.gnombre = txt_nombre_empleado.Text
            dts.gid_empleado = txt_empleado.Text
            dts.gfecha_inicio = dt_inicio.Value
            dts.gfecha_fin = dt_final.Value
            dts.ganulado = ck_anulada.Checked
            dts.gobservacion = txt_observaciones.Text

            If Bt_guardar.Text = "Actualizar" Then
                If func.editar(dts) Then
                    MsgBox(" Modificado Correctamente")
                Else
                    MsgBox("Error al intentar Modificar")
                End If

            Else
                If func.insertar(dts) Then
                    MsgBox("Guardado Correctamente")
                    limpiar()
                Else
                    MsgBox("Error al intentar guardar")
                    limpiar()
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim frm As New frm_buscar_accion
        Try
            frm.ShowDialog()
            lbid.Text = frm.codigo
            If lbid.Text = "" Then
                Exit Sub
            End If
            cargar_informacion(frm.codigo)
            Bt_guardar.Enabled = False
            Panel2.Enabled = False
            Bt_guardar.Enabled = False : Bt_guardar.Text = "Guardar"
            Bt_editar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub cargar_informacion(ByVal codigo As String)
        Dim dts As New Vaccion
        Dim func As New Faccion
        Dim dt As DataTable
        Try
            dts.gid = codigo
            dt = func.buscar(codigo)

            If dt.Rows.Count > 0 Then

                lbid.Text = dt.Rows(0).Item("id")
                txt_empleado.Text = dt.Rows(0).Item("id_empleado")
                txt_nombre_empleado.Text = dt.Rows(0).Item("nombre")
                cbo_categoria.SelectedValue = dt.Rows(0).Item("id_categoria")
                dt_inicio.Text = dt.Rows(0).Item("fecha_inicio")
                dt_final.Text = dt.Rows(0).Item("fecha_fin")
                txt_observaciones.Text = dt.Rows(0).Item("observacion")
                ck_anulada.Checked = dt.Rows(0).Item("anulada")

                Bt_editar.Enabled = True
                Bt_eliminar.Enabled = True
            Else
                MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub cargar_informacion_empleado(ByVal codigo As String)
        Dim dts As New Vempleado
        Dim func As New Fempleado
        Dim dt As DataTable
        Try
            dts.gcedula = codigo
            dt = func.buscar(codigo)
            If dt.Rows.Count > 0 Then
                txt_nombre_empleado.Text = dt.Rows(0).Item("nombre")
                Bt_eliminar.Enabled = True
            Else
                MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub llenar_categoria()
        Try
            Dim func As New Fcategoria_accion
            Dim dt As DataTable = func.mostrar
            Dim dts As DataTable = func.mostrar
            Me.cbo_categoria.DataSource = dts
            Me.cbo_categoria.DisplayMember = "categoria"
            Me.cbo_categoria.ValueMember = "id"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Bt_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_editar.Click
        Panel2.Enabled = True
        Bt_guardar.Text = "Actualizar"
        Bt_guardar.Enabled = True
    End Sub
    Private Sub frm_accion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenar_categoria()
    End Sub

    Private Sub txt_empleado_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_empleado.KeyDown
        Dim frm As New frm_buscar_empleado
        If e.KeyCode = Windows.Forms.Keys.F1 Then
            Try
                frm.ShowDialog()
                txt_empleado.Text = frm.codigo
                If txt_empleado.Text = "" Then
                    Exit Sub
                End If
                cargar_informacion_empleado(frm.codigo)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txt_empleado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_empleado.TextChanged

    End Sub
End Class