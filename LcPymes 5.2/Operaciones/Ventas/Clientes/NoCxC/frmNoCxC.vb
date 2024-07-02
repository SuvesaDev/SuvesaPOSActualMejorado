Imports System.Data
Public Class frmNoCxC


    Private Sub CargarListaNoCxC()
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select identificacion, cedula, nombre, Telefono_01, abierto, max_credito, Plazo_credito from Clientes where NoCXC = 1", dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("identificacion").Visible = False
            Me.viewDatos.Columns("nombre").Width = 310
            Me.viewDatos.Columns("abierto").HeaderText = "Tiene Credito"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub QuitarListaNoCxC()
        Try

            If MsgBox("Desea quitar el cliente de la lista.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Acccion") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim Id As String = Me.viewDatos.Item("identificacion", Me.viewDatos.CurrentRow.Index).Value
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Clientes set NoCxC = 0 where identificacion = " & Id, CommandType.Text)
        Catch ex As Exception
        End Try
        Me.CargarListaNoCxC()
    End Sub

    Private Sub AgregarListaNoCxC()
        Dim frmBuscarCliente As New frm_buscar_cliente
        frmBuscarCliente.txt_nombre.Focus()
        If frmBuscarCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim id As String = frmBuscarCliente.id
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Update Clientes set NoCxC = 1 where identificacion = " & id, CommandType.Text)
        End If
        Me.CargarListaNoCxC()
    End Sub

    Private Sub frmNoCxC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarListaNoCxC()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Me.QuitarListaNoCxC()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.AgregarListaNoCxC()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim visor As New frmVisorReportes
        visor.Button1.Visible = False
        Dim Reporte As New Estado_CXC_Saldo_General_Clientes_NoCxC
        Reporte.SetParameterValue(0, 1)      ' TIPO DE CAMBIO $ - c
        Reporte.SetParameterValue(1, CStr("GENERAL x CLIENTE EN COLONES"))
        Reporte.SetParameterValue(2, False)
        Reporte.SetParameterValue(3, Date.Now)
        Reporte.SetParameterValue(4, Date.Now)
        Reporte.SetParameterValue(5, False)
        'CrystalReportsConexion.LoadReportViewer(Me.rptViewer, Reporte)

        CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Reporte)
        visor.rptViewer.Visible = True
        visor.ShowDialog()
    End Sub
End Class