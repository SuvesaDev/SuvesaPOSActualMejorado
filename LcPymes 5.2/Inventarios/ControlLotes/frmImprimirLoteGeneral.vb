Imports System.Data
Imports System.Drawing
Imports GenCode128

Public Class frmImprimirLoteGeneral

    Private Sub CargarLotes()
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from viewImpresoGeneralLote", dt, CadenaConexionSeePOS)

            Me.viewLotes.DataSource = dt
            Me.viewLotes.Columns("Id").Visible = False
            Me.viewLotes.Columns("Vence").Visible = False
            Me.viewLotes.Columns("Lote").ReadOnly = True
            Me.viewLotes.Columns("Actual").ReadOnly = False
            Me.viewLotes.Columns("Actual").HeaderText = "Cantidad"
            Me.viewLotes.Columns("Cod_Articulo").ReadOnly = True
            Me.viewLotes.Columns("Cod_Articulo").HeaderText = "Codigo"
            Me.viewLotes.Columns("Descripcion").ReadOnly = True
            Me.viewLotes.Columns("Presentacion").ReadOnly = True
            Me.viewLotes.Columns("Barras").ReadOnly = True
            Me.viewLotes.Columns("Imprimir").ReadOnly = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub btnCargarlotes_Click(sender As Object, e As EventArgs) Handles btnCargarlotes.Click
        Me.CargarLotes()
    End Sub

    Private Lotes As New System.Collections.Generic.List(Of Lote)
    Private LotesImprimir As New System.Collections.Generic.List(Of Lote)

    Private WithEvents printDocument1 As New System.Drawing.Printing.PrintDocument
    Private pictBarcode As New PictureBox
    Private I As Integer = 0

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim caption As String = ""
        Dim tamanyo As Integer = 0
        Dim pos As Integer = 0

        Dim g As Graphics = e.Graphics
        Dim fnt As Font = New Font("Arial", 7)

        pos = 15
        caption = Me.LotesImprimir(I).Descripcion
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 55, pos)

        pos = 27
        Try
            Dim myimg As Image = Code128Rendering.MakeBarcodeImage(Me.LotesImprimir(I).Barras, Integer.Parse(1), True)
            pictBarcode.Image = myimg
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, Me.Text)
        End Try
        g.DrawImage(pictBarcode.Image, 50, pos, 190, 50)

        pos = 80
        caption = "COD: " & Me.LotesImprimir(I).Cod_Articulo & "     Lote:" & Me.LotesImprimir(I).Lote
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 55, pos)

        pos = 90
        caption = Me.LotesImprimir(I).Presentacion & "  SUPER VETERINARIA LIBERIA"
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, 55, pos)

        I += 1
        e.HasMorePages = I < CInt(Me.LotesImprimir.Count)
    End Sub

    Private Sub ImprimirLotes()
        Me.LotesImprimir.Clear()
        Dim lotetemp As Lote
        Dim Lista As New System.Collections.Generic.List(Of Lote)

        Dim nuevoLote As Lote
        For Each r As DataGridViewRow In Me.viewLotes.Rows
            If r.Cells("Imprimir").Value = True Then
                nuevoLote = New Lote(r.Cells("Id").Value, r.Cells("Lote").Value, r.Cells("Vence").Value, 0, r.Cells("Descripcion").Value, r.Cells("Presentacion").Value, r.Cells("Barras").Value, r.Cells("Actual").Value, r.Cells("Actual").Value, r.Cells("Cod_Articulo").Value)
                Lista.Add(nuevoLote)
            End If
        Next

        For Each l As Lote In Lista
            lotetemp = New Lote(l.Id, l.Lote, l.Vence, l.Codigo, l.Descripcion, l.Presentacion, l.Barras, 1, 1, l.Cod_Articulo)
            For I As Integer = 0 To l.CantidadImprimir - 1
                Me.LotesImprimir.Add(lotetemp)
            Next
        Next

        If Lista.Count > 0 Then
            Me.I = 0
            printDocument1.Print()
        End If

        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        For Each l As Lote In Lista
            db.Ejecutar("update ControlLotes set ImpresoGeneral = 1 where Id = " & l.Id, CommandType.Text)
        Next

        If I = CInt(Me.LotesImprimir.Count) Then
            Me.CargarLotes()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ImprimirLotes()
    End Sub
End Class