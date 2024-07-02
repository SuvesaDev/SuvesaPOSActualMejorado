Imports System.Windows.Forms
Imports System.Drawing
Imports GenCode128
Imports System.Data
Imports System.IO

Public Class frmEtiquetarGuanavet
    Public WithEvents printDocument1 As New System.Drawing.Printing.PrintDocument
    Public CerrarAlTerminar As Boolean = False

    Public I As Integer = 0

    Private Function GetCunaVertical() As Integer
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

    Private Function GetCunaHorizontal() As Integer
        Dim cuna2 As String = 0
        Try
            cuna2 = GetSetting("SeeSOFT", "SeePOs", "cuna2")
            If cuna2 = "" Then
                SaveSetting("SeeSOFT", "SeePOS", "cuna2", "0")
            End If
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOS", "cuna2", "0")
            cuna2 = "0"
        End Try
        Return CInt(cuna2)
    End Function

    Public LineasBarCode As New System.Collections.Generic.List(Of LineaImprecion)
    Private ReadOnly Property NCopias As Integer
        Get
            'Return CInt(Me.txtNCopia.Value)
            Return Me.LineasBarCode.Count() - 1
        End Get
    End Property
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument1.PrintPage

        '************************************************************************************************************************
        Dim tCodArticulo As String = Me.LineasBarCode(I).CodArticulo 'Me.txtCodArticulo.Text
        Dim tDescripcion As String = Me.LineasBarCode(I).Descripcion 'Me.txtDescripcion.Text        
        Dim tPresentacion As String = Me.LineasBarCode(I).Presentaccion 'Me.lblPresentacion.Text
        Dim tPrecio As Decimal = Me.LineasBarCode(I).Precio 'CDec(txtPrecio.Text)
        Dim tPrecioLent As Integer = Me.LineasBarCode(I).PrecioLent 'CInt(lblPrecioLent.Text)
        Dim tBarCode As System.Drawing.Image = Me.LineasBarCode(I).BarCode 'pictBarcode.Image
        '************************************************************************************************************************

        Dim caption As String = ""
        Dim tamanyo As Integer = 0
        Dim cuna As Integer = Me.GetCunaVertical
        Dim cuna2 As Integer = Me.GetCunaHorizontal
        Dim vVertical As Integer = 0
        Dim vHorisontal As Integer = 27 + cuna2

        Dim g As Graphics = e.Graphics
        Dim fnt As Font = New Font("Arial", 7)

        vVertical = 15 + cuna
        caption = tDescripcion
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, vHorisontal, vVertical)

        vVertical = 27 + cuna
        vVertical = 27 + cuna
        'g.DrawImage(tBarCode, vHorisontal, vVertical, 190, 50)
        g.DrawImage(tBarCode, vHorisontal, vVertical, 180, 40)

        vVertical = 80 + cuna
        caption = "COD: " & tCodArticulo & IIf(Me.IncluirPrecio = True, "     ₡" & tPrecio.ToString("N2"), "")
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, vHorisontal, vVertical)

        If tPrecioLent <= 10 Then vVertical = 180 + cuna
        If tPrecioLent > 10 Then vVertical = 130 + cuna
        vVertical = 74 + cuna

        vVertical = 90 + cuna

        Dim NombreEmpresa As String = ""
        Select Case Me.Cedula
            Case "3101696098"
                NombreEmpresa = "  Guanavet"
            Case "3101105432"
                NombreEmpresa = "  SUPER VETERINARIA LIBERIA"
            Case Else
                NombreEmpresa = "  " & Me.Empresa
        End Select

        caption = tPresentacion & NombreEmpresa
        g.DrawString(caption, fnt, System.Drawing.Brushes.Black, vHorisontal, vVertical)

        fnt = New Font("Arial", 7)

        vVertical = 98 + cuna
        caption = Me.Empresa.Replace(", S.A.", "") & " " & "Tel. :" & Me.Telefono & " Cel. :" & Me.Celular

        e.HasMorePages = I < NCopias        
        If Me.CerrarAlTerminar = True And e.HasMorePages = False Then
            Me.Close()
        End If

        I += 1
    End Sub

    Public IncluirPrecio As Boolean = False
    Dim EtiquetasGuanavet As New rptEtiquetasGuanavetClinica
    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If CadenaConexionSeePOS.IndexOf("192.168.0.2") > 0 Then
            If MsgBox("Desea agregar el precio de venta a la etiqueta.", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmar Accion.") = MsgBoxResult.Yes Then
                Me.IncluirPrecio = True
            Else
                Me.IncluirPrecio = False
            End If


            Me.I = 0
            Me.LineasBarCode.Clear()
            Dim Linea As LineaImprecion
            For j As Integer = 0 To Me.txtNCopia.Value
                Linea = New LineaImprecion(Me.txtCodArticulo.Text, Me.txtDescripcion.Text, Me.lblPresentacion.Text, Me.txtPrecio.Text, Me.txtCantidad.Value)
                Me.LineasBarCode.Add(Linea)
            Next

            printDocument1.Print()
        Else
            '' imprime desde crystal reports
            Dim vueltas As Integer = 0
            Dim lineas As Integer = 0
            Dim dts As New DataSetEtiquetasGuanavetClinica

            While vueltas < Me.txtNCopia.Value

                Dim row As DataRow = dts.DatosEtiquetasAlbaranesCompra_Crystal.NewRow
                row!idAlbaran = 0
                row!cantidad = 0
                row!ImporteUnitario = 0
                row!descripcion = Me.txtDescripcion.Text '***
                row!factorConversion = 0
                row!idArticulo = Me.txtCodArticulo.Text '***
                row!orden = ""
                row!PVP1 = 0 '***
                row!Moneda = 1 '***
                row!UnidadMedida = ""
                row!PesoEnvase = ""

                dts.DatosEtiquetasAlbaranesCompra_Crystal.Rows.Add(row)
                vueltas += 1
                lineas += 1

                'If lineas >= 2 Then
                EtiquetasGuanavet.SetDataSource(dts)
                'EtiquetasGuanavet.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.CrystalReport, "C:\a\algo.rpt")
                'Me.rptViewer.ReportSource = EtiquetasGuanavet
                EtiquetasGuanavet.PrintToPrinter(1, True, 1, 1)
                dts = New DataSetEtiquetasGuanavetClinica
                lineas = 0
                'End If
            End While
        End If
    End Sub

    Public Sub ImprimirColeccion()
        If MsgBox("Desea agregar el precio de venta a la etiqueta.", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirmar Accion.") = MsgBoxResult.Yes Then
            Me.IncluirPrecio = True
        Else
            Me.IncluirPrecio = False
        End If

        Me.I = 0
        Me.LineasBarCode.Clear()
        Dim Linea As LineaImprecion
        For j As Integer = 0 To Me.txtNCopia.Value
            Linea = New LineaImprecion(Me.txtCodArticulo.Text, Me.txtDescripcion.Text, Me.lblPresentacion.Text, Me.txtPrecio.Text, Me.txtCantidad.Value)
            Me.LineasBarCode.Add(Linea)
        Next
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

            Try
                Dim myimg As Image = Code128Rendering.MakeBarcodeImage(Me.txtCantidad.Value & "?" & txtCodigo.Text, Integer.Parse(1), True)
                pictBarcode.Image = myimg
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, Me.Text)
            End Try

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

    Private Cedula, Empresa, Telefono, Celular As String
    Private Sub frmEtiquetar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select RTRIM(REPLACE(cedula,'-','')) as Cedula, Empresa, Tel_01, Fax_02, Logo from configuraciones", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Dim data As Byte() = New Byte(-1) {}
            data = CType((dt.Rows(0)("Logo")), Byte())
            Dim mem As MemoryStream = New MemoryStream(data)
            pLogo.Image = Image.FromStream(mem)
            Me.Cedula = dt.Rows(0).Item("Cedula")
            Me.Empresa = dt.Rows(0).Item("Empresa")
            Me.Telefono = dt.Rows(0).Item("Tel_01")
            Me.Celular = dt.Rows(0).Item("Fax_02")
        End If

        CrystalReportsConexion.LoadReportViewer(Nothing, EtiquetasGuanavet, True)
    End Sub

End Class

Public Class LineaImprecion

    Public Property CodArticulo As String
    Public Property Descripcion As String
    Public Property Presentaccion As String
    Public Property Precio As String
    Public Property PrecioLent As Integer
    Public Property BarCode As System.Drawing.Image
    Sub New(_codarticulo As String, _descripcion As String, _presentacion As String, _precio As String, _cantidad As Integer)

        Me.CodArticulo = _codarticulo
        Me.Descripcion = _descripcion
        Me.Presentaccion = _presentacion
        Me.Precio = _precio
        Me.PrecioLent = Me.Precio.Length
        Me.BarCode = Code128Rendering.MakeBarcodeImage(_cantidad & "?" & CodArticulo, Integer.Parse(1), True)

    End Sub
End Class
