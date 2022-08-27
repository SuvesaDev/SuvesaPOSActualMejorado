Imports System.Data
Public Class frm_categoria_accion

    Private Sub Bt_guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_guardar.Click
        Try
            Dim dts As New Vcategoria_accion
            Dim func As New Fcategoria_accion

            dts.gid = lb_id.Text
            dts.gnombre = txt_nombre.Text

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

    Private Sub Bt_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_editar.Click
        Panel2.Enabled = True
        Bt_guardar.Text = "Actualizar"
        Bt_guardar.Enabled = True
    End Sub

    Private Sub Bt_nuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_nuevo.Click
        limpiar()
        Me.Panel2.Enabled = True
        Me.Bt_guardar.Text = "Guardar"
        Bt_guardar.Enabled = True
        Bt_editar.Enabled = False
        Bt_eliminar.Enabled = False
    End Sub
    Public Sub limpiar()
        txt_nombre.Text = ""
        lb_id.Text = ""

    End Sub

    Private Sub Bt_eliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_eliminar.Click
        Try
            Dim dts As New Vcategoria_accion
            Dim func As New Fcategoria_accion
            dts.gid = lb_id.Text
            If MsgBox("Desea eliminar este registro?", MsgBoxStyle.YesNo, "Eliminar") = MsgBoxResult.Yes Then
                If func.eliminar(dts) Then
                    MsgBox("Eliminado Correctamente")
                    limpiar()
                Else
                    MsgBox("Error al intentar Eliminar ")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click

        Dim frm As New frm_buscar_categoria
        Try
            frm.ShowDialog()
            lb_id.Text = frm.codigo
            If lb_id.Text = "" Then
                Exit Sub
            End If
            cargar_informacion(frm.codigo)
            Panel2.Enabled = False
            Bt_guardar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub cargar_informacion(ByVal codigo As String)
        Dim dts As New Vcategoria_accion
        Dim func As New Fcategoria_accion
        Dim dt As DataTable
        Try
            dts.gid = codigo
            dt = func.buscar(codigo)

            If dt.Rows.Count > 0 Then
                txt_nombre.Text = dt.Rows(0).Item("categoria")
                Bt_editar.Enabled = True
                Bt_eliminar.Enabled = True
            Else
                MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class