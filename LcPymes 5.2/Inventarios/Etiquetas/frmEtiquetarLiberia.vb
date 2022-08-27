Imports System.Windows.Forms
Imports System.Drawing
Imports GenCode128
Imports System.Data
Imports System.IO

Public Class frmEtiquetarLiberia
    Private WithEvents printDocument1 As New System.Drawing.Printing.PrintDocument

    Private I As Integer = 0

    Private Function GetCuna() As Integer
        Dim cuna As String = 0
        Try
            cuna = GetSetting("SeeSOFT", "SeePOs", "cuna")
            If cuna = "" Then
                SaveSetting("SeeSOFT", "SeePOS", "cuna", "0")
            End If
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOS", "cuna", "0")
            cuna = "0"
        End Try
        Return CInt(cuna)
    End Function

    Private Function GetMIzquierdo() As Integer
        Dim cuna As String = 0
        Try
            cuna = GetSetting("SeeSOFT", "SeePOs", "cunaIzquida")
            If cuna = "" Then
                SaveSetting("SeeSOFT", "SeePOS", "cunaIzquida", "0")
            End If
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOS", "cunaIzquida", "0")
            cuna = "0"
        End Try
        Return CInt(cuna)
    End Function

    Private Function getPrecio() As String
        Try
            Return "     ₡" & CDec(txtPrecio.Text).ToString("N2")
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage
        Dim caption As String = ""
        Dim tamanyo As Integer = 0
        Dim pos As Integer = 0
        Dim cuna As Integer = Me.GetCuna
        Dim cunaIzquierda As Integer = Me.GetMIzquierdo
        Dim SegundaImpresion As Integer = 197
        Dim MIzquierdo As Integer = 55
        MIzquierdo = 8 + cunaIzquierda

        Dim g As Graphics = e.Graphics
        Dim fnt As Font = New Font("Arial", 7)

        '********************************************************************************************
        'Imprime la descripcion del articulo
        pos = 15 + cuna
        If Me.txtDescripcion.Text.Length > 35 Then
            caption = Me.txtDescripcion.Text.Substring(0, 35)
        Else
            caption = Me.txtDescripcion.Text
        End If
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo, pos)

        If SegundaImpresion > 0 Then
            g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo + SegundaImpresion, pos)
        End If
        '********************************************************************************************
        'Imprime la imagen con el codigo del producto
        pos = 27 + cuna
        g.DrawImage(pictBarcode.Image, MIzquierdo, pos, 180, 50)

        If SegundaImpresion > 0 Then
            g.DrawImage(pictBarcode.Image, MIzquierdo + SegundaImpresion, pos, 180, 50)
        End If
        '********************************************************************************************
        'Imprime el codigo y opcionalmente el precio de venta del articulo
        pos = 80 + cuna
        caption = "COD: " & Me.txtCodArticulo.Text & IIf(Me.IncluirPrecio = True, Me.getPrecio, "")
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo, pos)

        If SegundaImpresion > 0 Then
            g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo + SegundaImpresion, pos)
        End If
        '********************************************************************************************
        'imprime la presentacion del articulo
        pos = 90 + cuna
        caption = Me.lblPresentacion.Text
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo, pos)

        If SegundaImpresion > 0 Then
            g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo + SegundaImpresion, pos)
        End If
        '********************************************************************************************
        'Imprime el nombre de la empresa
        pos = 100 + cuna
        caption = "GUANAVET CLINICA"
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo, pos)

        If SegundaImpresion > 0 Then
            g.DrawString(caption, fnt, System.Drawing.Brushes.Black, MIzquierdo + SegundaImpresion, pos)
        End If
        '********************************************************************************************
        I += 1
        e.HasMorePages = I < CInt(Me.txtNCopia.Value)
    End Sub

    Private IncluirPrecio As Boolean = False
    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If MsgBox("Desea agregar el precio de venta a la etiqueta.", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Me.IncluirPrecio = True
        Else
            Me.IncluirPrecio = False
        End If
        Me.I = 0
        printDocument1.Print()
    End Sub


    Private CantPresentacion As String
    Private Presentacion As String

    Private Sub PonePresentacion()
        Me.lblPresentacion.Text = (CDec(Me.CantPresentacion) * Me.txtCantidad.Value).ToString + " " + Me.Presentacion
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim BuscarArt As New FrmBuscarArticulo2
        BuscarArt.StartPosition = FormStartPosition.CenterParent
        BuscarArt.CheckBoxInHabilitados.Enabled = True
        BuscarArt.Cod_Articulo = False
        BuscarArt.ShowDialog()

        If BuscarArt.Cancelado Then
            Exit Sub
        End If

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Barras, Cod_Articulo, Descripcion, case IVenta when 0 then Precio_A else (Precio_A * (1 + (IVenta / 100))) end Precio_A, PresentaCant as CantidadPresentacion, (Select p.Presentaciones from Presentaciones p where p.CodPres = CodPresentacion) as Presentacion from inventario where Codigo = " & BuscarArt.Codigo, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtCodigo.Text = dt.Rows(0).Item("Barras")
            Me.txtCodArticulo.Text = dt.Rows(0).Item("Cod_Articulo")
            Me.txtDescripcion.Text = dt.Rows(0).Item("Descripcion")
            Me.txtPrecio.Text = Format(CDec(dt.Rows(0).Item("Precio_A")), "N2")
            Me.lblPrecio.Text = "₡" & " " & Format(CDec(Me.txtPrecio.Text), "N2")
            Me.lblPrecioLent.Text = Me.lblPrecio.Text.Length

            Me.CantPresentacion = dt.Rows(0).Item("CantidadPresentacion")
            Me.Presentacion = dt.Rows(0).Item("Presentacion")

            Me.PonePresentacion()

            Me.GenerarBarras()

            Me.txtNCopia.Focus()
        End If

    End Sub

    Private Sub txtCantidad_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.ValueChanged
        On Error Resume Next
        Me.lblPrecio.Text = "₡" & " " & Format(CDec(Me.txtPrecio.Text) * Me.txtCantidad.Value, "N2")
        Me.lblPrecioLent.Text = Me.lblPrecio.Text.Length

        Dim myimg As Image = Code128Rendering.MakeBarcodeImage(Me.txtCantidad.Value & "?" & txtCodigo.Text, Integer.Parse(1), True)
        pictBarcode.Image = myimg

        Me.PonePresentacion()
    End Sub

    Private Empresa, Telefono, Celular As String
    Private Sub frmEtiquetar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Empresa, Tel_01, Fax_02, Logo from configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Dim data As Byte() = New Byte(-1) {}
            data = CType((dt.Rows(0)("Logo")), Byte())
            Dim mem As MemoryStream = New MemoryStream(data)
            pLogo.Image = Image.FromStream(mem)
            Me.Empresa = dt.Rows(0).Item("Empresa")
            Me.Telefono = dt.Rows(0).Item("Tel_01")
            Me.Celular = dt.Rows(0).Item("Fax_02")
        End If
    End Sub

    Private Sub GenerarBarras()

        If porCodigoBarras.Checked = True Then
            Try
                Dim myimg As Image = Code128Rendering.MakeBarcodeImage(txtCodigo.Text, Integer.Parse(1), True)
                pictBarcode.Image = myimg
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, Me.Text)
            End Try
        End If

        If porCodigo.Checked = True Then
            Try
                Dim myimg As Image = Code128Rendering.MakeBarcodeImage(txtCodArticulo.Text, Integer.Parse(1), True)
                pictBarcode.Image = myimg
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, Me.Text)
            End Try
        End If

    End Sub

    Private Sub porCodigoBarras_CheckedChanged(sender As Object, e As EventArgs) Handles porCodigoBarras.CheckedChanged, porCodigo.CheckedChanged
        Me.GenerarBarras()
    End Sub

End Class
