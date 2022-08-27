Imports System.Data
Public Class frmMargenInventario
    Private dlgExportar As New SaveFileDialog With {.Title = "Guardar Documentos", .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments}

    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)
        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo
        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)
        'exportamos los caracteres de las columnas
        Dim columns As Integer = 0
        For c As Integer = 0 To dgv.Columns.Count - 1
            If dgv.Columns(c).Visible = True Then
                xlWS.cells(1, columns + 1).value = dgv.Columns(c).HeaderText
                columns += 1
            End If
        Next
        'exportamos las cabeceras de columnas
        For r As Integer = 0 To dgv.RowCount - 1
            columns = 0
            For c As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(c).Visible = True Then
                    xlWS.cells(r + 2, columns + 1).value = dgv.Item(c, r).Value
                    columns += 1
                End If
            Next
        Next
        'guardamos la hoja de calculo en la ruta especificada
        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If Me.DataGridView1.RowCount > 0 Then
                If dlgExportar.ShowDialog = DialogResult.OK Then
                    Me.Exportar_Excel(Me.DataGridView1, dlgExportar.FileName)
                    System.Diagnostics.Process.Start(dlgExportar.FileName)
                    MsgBox("Datos Exportados correctamente!!!", MsgBoxStyle.Information, "Exportacion exitosa")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "No se realizo la operacion")
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strSQL As String = ""
        Select Case Me.ComboBox1.SelectedIndex
            Case 0 : strSQL = "select * from viewutilidadarticulo where costo > 0 and utilidad <= 15 order by utilidad"
            Case 1 : strSQL = "select * from viewutilidadarticulo where costo > 0 and utilidad > 15 and utilidad <= 20 order by utilidad"
            Case 2 : strSQL = "select * from viewutilidadarticulo where costo > 0 and utilidad > 20 and utilidad <= 25 order by utilidad"
            Case 3 : strSQL = "select * from viewutilidadarticulo where costo > 0 and utilidad > 25  order by utilidad"
        End Select
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, CadenaConexionSeePOS)
        Me.DataGridView1.DataSource = dt
        Me.DataGridView1.Columns("Codigo").Visible = False
        Me.DataGridView1.Columns("Costo").DefaultCellStyle.Format = "N2"
        Me.DataGridView1.Columns("Costo").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns("PrecioVenta").DefaultCellStyle.Format = "N2"
        Me.DataGridView1.Columns("PrecioVenta").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridView1.Columns("Utilidad").DefaultCellStyle.Format = "N2"
        Me.DataGridView1.Columns("Utilidad").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub frmMargenInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ComboBox1.SelectedIndex = 0
    End Sub
End Class