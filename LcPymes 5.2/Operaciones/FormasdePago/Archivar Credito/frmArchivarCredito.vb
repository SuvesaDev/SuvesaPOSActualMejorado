Imports System.Data
Public Class frmArchivarCredito

    Private Sub Archiviar()
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        For Each r As DataGridViewRow In Me.viewFacturas.Rows
            If r.Cells("cArchivar").Value = True Then
                db.Ejecutar("Update Ventas set Archivada = 1, UsuarioArchivo = '" & Me.Id_Usuario & "', FechaArchivo = getdate() where Id = " & r.Cells("cId").Value, CommandType.Text)
            End If
        Next
    End Sub

    Private Sub CargarFacturas(_Desde As Date)
        Dim Index As Integer = 0
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select v.Id, v.Num_Factura, v.Nombre_Cliente as Cliente, u.Nombre as Usuario, v.Fecha, v.Total from ventas v inner join Usuarios u on v.Cedula_Usuario = u.Cedula  where Archivada = 0 and Tipo in('CRE','TCR','MCR') and dbo.DateOnly(v.Fecha)  = dbo.dateonly('" & _Desde & "')", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.viewFacturas.Rows.Clear()
            Index = 0
            For Each r As DataRow In dt.Rows
                Me.viewFacturas.Rows.Add()
                Me.viewFacturas.Item("cId", Index).Value = r.Item("Id")
                Me.viewFacturas.Item("cArchivar", Index).Value = True
                Me.viewFacturas.Item("cNum_Factura", Index).Value = r.Item("Num_Factura")
                Me.viewFacturas.Item("cCliente", Index).Value = r.Item("Cliente")
                Me.viewFacturas.Item("cUsuario", Index).Value = r.Item("Usuario")
                Me.viewFacturas.Item("cFecha", Index).Value = r.Item("Fecha")
                Me.viewFacturas.Item("cTotal", Index).Value = r.Item("Total")
                Index += 1
            Next
        End If
    End Sub

    Private Sub btnCargarFacturas_Click(sender As Object, e As EventArgs) Handles btnCargarFacturas.Click
        Me.CargarFacturas(Me.dtpDesde.Value)
    End Sub

    Public Id_Usuario As String = ""
    Private Sub frmArchivarCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Id_Usuario <> "" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * from usuarios where id_usuario = " & Me.Id_Usuario, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.lblUsuario.Text = dt.Rows(0).Item("Nombre")
            Else
                Me.lblUsuario.Text = ""
                Me.btnArchivar.Enabled = False
            End If
        Else
            Me.lblUsuario.Text = ""
            Me.btnArchivar.Enabled = False
        End If
    End Sub

    Private Sub btnArchivar_Click(sender As Object, e As EventArgs) Handles btnArchivar.Click
        Me.Archiviar()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmReporteFacturassinArchivar
        frm.ShowDialog()
    End Sub

End Class