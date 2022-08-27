Imports System.Windows.Forms

Public Class frm_reportes
#Region "variables"
    Dim Reporte_ID As Byte
#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("SeeSOFT", "SeePos", "CONEXION")
            daMoneda.Fill(DsReportesApartados1, "moneda")
            AdapterCliente.Fill(DsReportesApartados1, "Clientes")
            FechaInicio.Value = Now
            FechaFinal.Value = Now

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


#Region "Controles Funciones"
    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Mostrar()
    End Sub

    Private Sub FechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            FechaFinal.Focus()
        End If
    End Sub

    Private Sub FechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mostrar()
        End If
    End Sub

    Private Sub cboMonedas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboMonedas.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mostrar()
        End If
    End Sub


    Private Sub CBCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBCliente.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Fx As New cFunciones
            Dim valor As String

            AdapterCliente.Fill(Me.DsReportesApartados1, "Clientes")
            valor = Fx.BuscarDatos("Select Identificacion,Nombre from Clientes", "Nombre", "Buscar cliente...")

            If valor = "" Then
                CBCliente.SelectedIndex = -1
            Else
                CBCliente.SelectedValue = CInt(valor)
            End If
        End If

        If e.KeyCode = Keys.Enter Then
            FechaFinal.Focus()
        End If
    End Sub
#End Region

#Region "Funciones"
    Private Sub Mostrar()
        '0	-	1	Pendientes Generales
        '1	-	2	Vencidos Generales
        '3	-	4	Pendientes por Cliente
        '4	-	5	Vencidos por Cliente

        Try
            Select Case Reporte_ID
                'Case 1 '0 'Pendientes Generales
                '    Dim rpt As New ReporteapartadosSaldos
                '    rpt.SetParameterValue(0, Me.FechaInicio.Value)
                '    rpt.SetParameterValue(1, Me.FechaFinal.Value)
                '    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, rpt)

                'Case 2 '1 'Vencidos Generales
                '    Dim rpt As New Reporteapartados
                '    rpt.SetParameterValue(0, Me.FechaFinal.Value)
                '    CrystalReportsConexion.LoadReportViewer(Me.CrystalReportViewer1, rpt)

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Reporte_Seleccionado()
        '0	-	1	Pendientes Generales
        '1	-	2	Vencidos Generales
        '3	-	4	Pendientes por Cliente
        '4	-	5	Vencidos por Cliente

        FechaInicio.Visible = True
        FechaFinal.Visible = True
        FechaInicio.Enabled = True
        FechaFinal.Enabled = True
        CBCliente.Enabled = False

        Select Case Reporte_ID
            Case 1 '0 'Pendientes Generales
                ButtonMostrar.Focus()

            Case 2 '1 'Vencidos Generales                
                FechaInicio.Enabled = False
                ButtonMostrar.Focus()
        End Select
    End Sub
#End Region
End Class