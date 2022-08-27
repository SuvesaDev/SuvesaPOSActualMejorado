Imports System.Data
Public Class frmFichasporUsuario

    Private Sub CargarUsuario()
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Id, IdUsuario, Usuario, Desde, Hasta, EnMostrador From FichasxUsuario", dt, CadenaConexionSeePOS)
            Me.viewDatos.Rows.Clear()
            Dim Index As Integer = 0
            For Each r As DataRow In dt.Rows
                Me.viewDatos.Rows.Add()
                Me.viewDatos.Item("cId", Index).Value = r.Item("Id")
                Me.viewDatos.Item("cIdUsuario", Index).Value = r.Item("IdUsuario")
                Me.viewDatos.Item("cUsuario", Index).Value = r.Item("Usuario")
                Me.viewDatos.Item("cDesde", Index).Value = r.Item("Desde")
                Me.viewDatos.Item("cHasta", Index).Value = r.Item("Hasta")
                Me.viewDatos.Item("cEnMostrador", Index).Value = r.Item("EnMostrador")
                Index += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Problemas al Obtener los Datos.")
        End Try
    End Sub

    Private Sub Registrar(_IdUsuario As String, _Nombre As String, _Desde As Decimal, _Hasta As Decimal, _EnMostrador As Integer)
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.AddParametro("@IdUsuario", _IdUsuario)
            db.AddParametro("@Nombre", _Nombre)
            db.AddParametro("@Desde", _Desde)
            db.AddParametro("@Hasta", _Hasta)
            db.AddParametro("@EnMostrador", _EnMostrador)
            db.Ejecutar("Insert into FichasxUsuario(IdUsuario, Usuario,Desde,Hasta, EnMostrador) Values(@IdUsuario, @Nombre, @Desde, @Hasta, @EnMostrador);", CommandType.Text)
            Me.CargarUsuario()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "No se puedo realizar la operacion.")
        End Try
    End Sub

    Private Sub frmFichasporUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarUsuario()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New frmAsignarFichaUsuario
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.Registrar(frm.cboUsuario.SelectedValue, frm.cboUsuario.Text, frm.txtDesde.Text, frm.txtHasta.Text, frm.txtMostrador.Text)
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If Me.viewDatos.Rows.Count > 0 Then
            If MsgBox("Desea quitar los usuarios seleccionados.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                For Each r As DataGridViewRow In Me.viewDatos.SelectedRows
                    db.Ejecutar("Delete from FichasxUsuario where Id = " & r.Cells("cId").Value, CommandType.Text)
                Next
                Me.CargarUsuario()
            End If
        End If        
    End Sub

End Class