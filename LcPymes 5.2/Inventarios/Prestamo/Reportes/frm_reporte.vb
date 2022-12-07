Imports System.Windows.Forms
Imports System.Data
Namespace Prestamos
    Public Class frm_reporte

        Private Sub BuscarF1(_MeDebe As Boolean)
            Dim Codigo As String = ""
            Dim BuscarArt As New FrmBuscarArticulo2
            BuscarArt.StartPosition = FormStartPosition.CenterParent
            BuscarArt.Codigo = ""
            BuscarArt.Cod_Articulo = True
            BuscarArt.ShowDialog()
            If BuscarArt.Cancelado Then
                Exit Sub
            End If
            Codigo = BuscarArt.Codigo
            Me.BuscarArticulo(Codigo, _MeDebe)
        End Sub

        Private CodigoMeDebe As Long = 0
        Private CodigoDebo As Long = 0

        Private Function GetCodArticulo(_Barras As String) As String
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select top 1 Cod_Articulo from Inventario i inner join ControlLotes l on i.Codigo = l.Codigo where i.inhabilitado = 0 and l.Barras = '" & _Barras & "'", dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Cod_Articulo")
            Else
                Return _Barras
            End If
        End Function

        Private Sub BuscarArticulo(_Cod_Articulo As String, _MeDebe As Boolean)
            Dim dt As New DataTable
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)

            If _Cod_Articulo.Contains("_") Then
                Dim barras() As String = _Cod_Articulo.Split("_")
                _Cod_Articulo = barras(1)
            Else
                _Cod_Articulo = Me.GetCodArticulo(_Cod_Articulo)
            End If

            db.AddParametro("@Codigo", _Cod_Articulo)
            dt = db.Ejecutar("select Codigo, Cod_Articulo, Barras, Costo, Descripcion, Existencia, Consignacion from Inventario where Inhabilitado = 0 and (Cod_Articulo = @Codigo or Barras = @Codigo or Barras2 = @Codigo)", CommandType.Text)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("Consignacion") = False Then
                    If _MeDebe Then
                        Me.CodigoMeDebe = dt.Rows(0).Item("Codigo")
                        Me.txtCodigoDebe.Text = dt.Rows(0).Item("Descripcion")
                    Else
                        Me.CodigoDebo = dt.Rows(0).Item("Codigo")
                        Me.txtCodigoDebo.Text = dt.Rows(0).Item("Descripcion")
                    End If
                End If
            End If
        End Sub

        Private Sub frm_reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            llenar_empresas()
        End Sub

        Sub llenar_empresas()
            Try
                Dim func As New fempresas
                Dim dt As DataTable = func.mostrar

                Me.cbo_empresa.DataSource = dt
                Me.cbo_empresa.DisplayMember = "empresa"
                Me.cbo_empresa.ValueMember = "id"

                Me.cbo_empresa2.DataSource = dt
                Me.cbo_empresa2.DisplayMember = "empresa"
                Me.cbo_empresa2.ValueMember = "id"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Try
                Dim rpt As New reporte_debe
                Dim cr As New Crystal_Reports
                cr.LoadReportViewer(visor, rpt, , CadenaConexionSeePOS)
                'rpt.SetParameterValue("id", codigo)
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Try
                Dim rpt As New reporte_debe_empresa
                Dim cr As New Crystal_Reports
                rpt.Refresh()
                cr.LoadReportViewer(visor, rpt, , CadenaConexionSeePOS)
                rpt.SetParameterValue("empresa", cbo_empresa.SelectedValue)
                rpt.SetParameterValue("Codigo", Me.CodigoMeDebe)
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


        Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
            Try
                Dim rpt As New reporte_debo_empresa
                Dim cr As New Crystal_Reports
                rpt.Refresh()
                cr.LoadReportViewer(visor, rpt, , CadenaConexionSeePOS)
                rpt.SetParameterValue("empresa", cbo_empresa.SelectedValue)
                rpt.SetParameterValue("Codigo", Me.CodigoDebo)
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Try
                Dim rpt As New reporte_debo
                Dim cr As New Crystal_Reports
                cr.LoadReportViewer(visor, rpt, , CadenaConexionSeePOS)
                'rpt.SetParameterValue("id", codigo)
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
            Me.BuscarF1(True)
        End Sub

        Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
            Me.CodigoMeDebe = 0
            Me.txtCodigoDebe.Text = ""
        End Sub

        Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
            Me.CodigoDebo = 0
            Me.txtCodigoDebo.Text = ""
        End Sub

        Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
            Me.BuscarF1(False)
        End Sub
    End Class
End Namespace
