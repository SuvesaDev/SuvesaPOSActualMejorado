Imports System.Data
Public Class frmBloqueoxProveedor

    Private Sub CargarProveedores(_Texto As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select CodigoProv, Nombre, Bloqueado  from Proveedores Where Nombre <> '' and Nombre like '%" & _Texto & "%' Order by Bloqueado desc, Nombre", dt, CadenaConexionSeePOS)

        Me.viewDatos.Rows.Clear()
        Dim Index As Integer = 0
        For Each r As DataRow In dt.Rows
            Me.viewDatos.Rows.Add()
            Me.viewDatos.Item("cCodigoProv", Index).Value = r.Item("CodigoProv")
            Me.viewDatos.Item("cNombre", Index).Value = r.Item("Nombre")
            Me.viewDatos.Item("cBloqueado", Index).Value = r.Item("Bloqueado")
            Index += 1
        Next
    End Sub

    Private Sub Aplicar(_CodigoProv As String, _Bloquear As Boolean)
        If _Bloquear = True Then
            If MsgBox("Desea bloquear los articulos de la casa comercial.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                db.Ejecutar("Update inventario set bloqueado = 1 where proveedor = " & _CodigoProv, CommandType.Text)
                db.Ejecutar("Update proveedores set bloqueado = 1 where codigoprov = " & _CodigoProv, CommandType.Text)
                Me.CargarProveedores(Me.txtBuscar.Text)
                Me.MostrarBotones()
            End If
        Else
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update inventario set bloqueado = 0 where proveedor = " & _CodigoProv, CommandType.Text)
            db.Ejecutar("Update proveedores set bloqueado = 0 where codigoprov = " & _CodigoProv, CommandType.Text)
            Me.CargarProveedores(Me.txtBuscar.Text)
            Me.MostrarBotones()
        End If
    End Sub

    Private Sub MostrarBotones()
        On Error Resume Next
        If Me.viewDatos.Item("cBloqueado", Me.viewDatos.CurrentRow.Index).Value = True Then
            Me.btnBloquear.Enabled = False
            Me.btnDesbloquear.Enabled = True
        Else
            Me.btnBloquear.Enabled = True
            Me.btnDesbloquear.Enabled = False
        End If
    End Sub

    Private Sub frmBloqueoxProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarProveedores(Me.txtBuscar.Text)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Me.CargarProveedores(Me.txtBuscar.Text)
    End Sub

    Private Sub viewDatos_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellEnter
        Me.MostrarBotones()
    End Sub

    Private Sub btnBloquear_Click(sender As Object, e As EventArgs) Handles btnBloquear.Click
        Dim CodigoProv As String = Me.viewDatos.Item("cCodigoProv", Me.viewDatos.CurrentRow.Index).Value
        Me.Aplicar(CodigoProv, True)
    End Sub

    Private Sub btnDesbloquear_Click(sender As Object, e As EventArgs) Handles btnDesbloquear.Click
        Dim CodigoProv As String = Me.viewDatos.Item("cCodigoProv", Me.viewDatos.CurrentRow.Index).Value
        Me.Aplicar(CodigoProv, False)
    End Sub
End Class