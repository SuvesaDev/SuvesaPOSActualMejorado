Imports System.Data
Public Class frmFirmadoContadoViejo
    Private dlgExportar As New SaveFileDialog With {.Title = "Guardar Documentos", .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments}

    Private Sub frmFirmadoContadoViejo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from viewDiasContadoFirmado where dias > 7 order by dias desc", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Try
            Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"
            Me.viewDatos.Columns("Dias").Visible = False
            Me.viewDatos.Columns("Total").DefaultCellStyle.Format = "N2"
            Me.viewDatos.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Catch ex As Exception
        End Try
    End Sub

    '*******************************************************
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
                    xlWS.cells(r + 2, columns + 1).value = dgv.Item(c, r).Value.ToString
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

    '*******************************************************

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Me.viewDatos.RowCount > 0 Then
                If dlgExportar.ShowDialog = DialogResult.OK Then
                    Me.Exportar_Excel(Me.viewDatos, dlgExportar.FileName)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class