Imports System.Data
Public Class frmVentasSinCabys
    Private dlgExportar As New SaveFileDialog With {.Title = "Guardar Documentos", .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*", .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments}

    Private Sub CargarArticulos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select distinct i.Codigo, i.Cod_Articulo, i.Descripcion, p.nombre as Proveedor, '' as Cabys from Ventas v inner join Ventas_Detalle vd on v.id = vd.id_factura inner join Inventario i on vd.codigo = i.codigo inner join proveedores p on i.Proveedor = p.codigoprov where dbo.dateonly(v.fecha) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(v.fecha) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "') and i.CODCABYS = '0' order by p.Nombre, i.Descripcion", dt, CadenaConexionSeePOS)
        Me.viewDatos.DataSource = dt
        Me.viewDatos.Columns("Codigo").Visible = False
    End Sub

    Private Sub frmVentasSinCabys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CargarArticulos()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Desea asignar el codigo cabys a los productos seleccionados.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Dim frmCabys As New frmBuscadorCodigoCabys
            If frmCabys.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                For Each factura As DataGridViewRow In Me.viewDatos.SelectedRows
                    db.Ejecutar("Update Inventario Set CodCabys = '" & frmCabys.txtCodigo.Text & "' Where Codigo = " & factura.Cells("CODIGO").Value, CommandType.Text)
                Next
                Me.CargarArticulos()
            End If
        End If
    End Sub
End Class