Namespace Prestamos
    Public Class frm_empresa

        Public Sub limpiar()
            txt_nombre.Text = ""
            lb_id.Text = ""
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs)
            'frmbuscar_categoria.Show()
        End Sub

        Private Sub frm_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Panel2.Enabled = False
        End Sub

        Private Sub bt_guardar_Click_1(sender As Object, e As EventArgs) Handles bt_guardar.Click
            Try
                Dim dts As New vempresa
                Dim func As New fempresas

                dts.gid = lb_id.Text
                dts.gdescripcion = txt_nombre.Text

                If bt_guardar.Text = "Actualizar" Then
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

        Private Sub bt_nuevo_Click_1(sender As Object, e As EventArgs) Handles bt_nuevo.Click
            limpiar()
            Me.Panel2.Enabled = True
            Me.bt_guardar.Text = "Guardar"
            bt_guardar.Enabled = True
            bt_editar.Enabled = False
            bt_eliminar.Enabled = False
        End Sub

        Private Sub bt_editar_Click_1(sender As Object, e As EventArgs) Handles bt_editar.Click
            Panel2.Enabled = True
            bt_guardar.Text = "Actualizar"
            bt_guardar.Enabled = True
        End Sub

        Private Sub bt_eliminar_Click_1(sender As Object, e As EventArgs) Handles bt_eliminar.Click
            Try
                Dim dts As New vempresa
                Dim func As New fempresas
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
    End Class
End Namespace
