Imports System.Data
Public Class frmValidaInscritoHacienda



    Private Sub cargarMAG()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select identificacion, cedula, nombre from Clientes  where mag = 1 and EstadoSituacion = ''", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Identificacion").Visible = False
    End Sub

    Private Sub frmValidaInscritoHacienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarMAG()
    End Sub

    Private Sub btnValidarClientes_Click(sender As Object, e As EventArgs) Handles btnValidarClientes.Click
        Try
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim contador As Integer = 0
            For Each row As DataGridViewRow In Me.viewDatos.Rows
                Dim CedulaCliente As String = row.Cells("cedula").Value
                CedulaCliente = CedulaCliente.Replace("-", "")
                CedulaCliente = CedulaCliente.Replace(" ", "")
                Dim ObtenerDatosCliente As api.Hacienda.Entidad = api.Hacienda.Consultar_x_Cedula(CedulaCliente)
                db.Ejecutar("Update Clientes set EstadoSituacion = '" & ObtenerDatosCliente.situacion.estado & "' where identificacion = " & row.Cells("identificacion").Value, CommandType.Text)
                contador += 1
                If contador = 10 Then
                    'procesamos de 10 en 10
                    'para evitar ser bloqueados

                    'MsgBox("espera")
                    contador = 0
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
        
        Me.cargarMAG()
    End Sub

End Class