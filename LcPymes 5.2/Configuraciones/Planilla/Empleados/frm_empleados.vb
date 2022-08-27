Imports System.Data.SqlClient
Imports System.Data
Public Class frm_empleados
    Private Sub Bt_guardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_guardar.Click
        Try
            Dim dts As New Vempleado
            Dim func As New Fempleado

            'If validacion() Then
            '    MsgBox("Falta rellenar campos", MsgBoxStyle.Critical, "Validación")
            '    Exit Sub
            'End If

            dts.gcedula = txt_cedula.Text
            dts.gnombre = txt_nombre.Text
            dts.gapellido = txt_apellidos.Text
            dts.gtelefono = txt_telefono.Text
            dts.gpuesto = txt_puesto.Text
            dts.gactivo = ck_activo.Checked
            dts.gfecha_ingreso = dt_fecha_ingreso.Text
            dts.gfecha_salida = dt_fecha_salida.Text
            dts.gsalario = txt_salario.Text

            If Bt_guardar.Text = "Actualizar" Then
                If func.editar(dts) Then
                    MsgBox(" Modificado Correctamente")
                    Me.Close()
                Else
                    MsgBox("Error al intentar Modificar")
                    Me.Close()
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
    Public Sub limpiar()
        txt_cedula.Text = ""
        txt_nombre.Text = ""
        txt_apellidos.Text = ""
        txt_telefono.Text = ""
        txt_puesto.Text = ""
        ck_activo.Checked = False
        txt_salario.Text = "0"

    End Sub

    Private Sub Bt_nuevo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_nuevo.Click
        limpiar()
        Me.Panel2.Enabled = True
        Me.Bt_guardar.Text = "Guardar"
        Bt_guardar.Enabled = True
        Bt_editar.Enabled = False
        Bt_eliminar.Enabled = False
        Me.txt_cedula.Enabled = True
        txt_cedula.Focus()
    End Sub

    Private Sub Bt_editar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_editar.Click
        Panel2.Enabled = True
        txt_cedula.Enabled = False
        Bt_guardar.Text = "Actualizar"
        Bt_guardar.Enabled = True
    End Sub

    Private Sub Bt_eliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bt_eliminar.Click
        Try
            Dim dts As New Vempleado
            Dim func As New Fempleado
            dts.gcedula = txt_cedula.Text
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
        Dim frm As New frm_buscar_empleado
        Try
            frm.ShowDialog()
            txt_cedula.Text = frm.codigo
            If txt_cedula.Text = "" Then
                Exit Sub
            End If
            cargar_informacion(frm.codigo)
            Panel2.Enabled = False
            Bt_guardar.Enabled = False
            'Bt_editar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub cargar_informacion(ByVal codigo As String)
        Dim dts As New Vempleado
        Dim func As New Fempleado
        Dim dt As DataTable
        Try
            dts.gcedula = codigo
            dt = func.buscar(codigo)

            If dt.Rows.Count > 0 Then

                txt_cedula.Text = dt.Rows(0).Item("cedula")
                txt_nombre.Text = dt.Rows(0).Item("nombre")
                txt_apellidos.Text = dt.Rows(0).Item("apellidos")
                txt_telefono.Text = dt.Rows(0).Item("telefono")
                txt_puesto.Text = dt.Rows(0).Item("puesto")
                ck_activo.Checked = dt.Rows(0).Item("activo")
                txt_salario.Text = dt.Rows(0).Item("salario")
                dt_fecha_ingreso.Value = dt.Rows(0).Item("fecha_ingreso")
                dt_fecha_salida.Value = dt.Rows(0).Item("fecha_salida")
                Bt_eliminar.Enabled = True
                Bt_editar.Enabled = True
            Else
                MsgBox("No hay registros que mostrar", MsgBoxStyle.Exclamation, "Verifique el número ingresado")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
   
    Private Sub frm_empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class