Imports System.IO
Imports System.Windows.Forms
Imports System.Data

Public Class frmImportarFacturaElectronicaGasto

    Private Function LeerArchivo(_Archivo As String) As String
        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
        Dim leer As New StreamReader(_Archivo)
        ':::Limpiamos nuestro ListBox
        Dim Texto As String = ""
        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                ':::Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                ':::Validamos que la linea no este vacia
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                ':::Agregramos los registros encontrados
                linea = linea.Replace("'", """")
                Texto += limpiarCadenaNombreFichero(linea, "")
            End While
            leer.Close()
            Return Texto
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Function

    Function limpiarCadenaNombreFichero(cadenaTexto As String, _
    sustituirPor As String) As String
        Dim tamanoCadena, cadenaResultado, caracteresValidos As String
        Dim caracterActual As String

        tamanoCadena = Len(cadenaTexto)
        If tamanoCadena > 0 Then
            caracteresValidos = " 0123456789abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ-_.:<>/?""=#@,+"
            For i As Integer = 1 To tamanoCadena
                caracterActual = Mid(cadenaTexto, i, 1)
                If InStr(caracteresValidos, caracterActual) Then
                    cadenaResultado = cadenaResultado & caracterActual
                Else
                    cadenaResultado = cadenaResultado & sustituirPor
                End If
            Next
        End If

        limpiarCadenaNombreFichero = cadenaResultado
    End Function


    Public CondicionVenta As String = ""
    Public PlazoCredito As Decimal = 0
    Public MontoTotalImpuesto As Decimal = 0
    Public TotalFactura As Decimal = 0
    Public EstadoCompra As String = ""
    Public TipoCambio As Decimal = 1
    Public NoExisteCedula As Boolean = False

    Private Sub ObtenerDatos(_xml As String)
        Try
            Dim xmlEnvia As New Xml.XmlDocument
            xmlEnvia.LoadXml(Me.LeerArchivo(_xml))
            Dim validatexto As String = xmlEnvia.OuterXml
            If validatexto.ToLower.IndexOf("facturaelectronica") > 0 Or validatexto.ToLower.IndexOf("tiqueteelectronico") > 0 Then

                Me.txtClave.Text = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
                Me.txtConsecutivo.Text = xmlEnvia.GetElementsByTagName("NumeroConsecutivo")(0).InnerText
                Me.txtCedula.Text = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
                Me.txtProveedor.Text = xmlEnvia.GetElementsByTagName("Emisor")(0)("Nombre").InnerText.ToUpper
                Me.txtFecha.Text = xmlEnvia.GetElementsByTagName("FechaEmision")(0).InnerText

                If validatexto.IndexOf("CodigoMoneda") > 0 Then
                    If validatexto.IndexOf("TipoCambio") > 0 Then
                        If xmlEnvia.GetElementsByTagName("CodigoMoneda")(0).InnerText <> "CRC" Then
                            Me.TipoCambio = xmlEnvia.GetElementsByTagName("TipoCambio")(0).InnerText
                        Else
                            Me.TipoCambio = 1
                        End If
                    Else
                        Me.TipoCambio = 1
                    End If
                End If

                If validatexto.IndexOf("TotalImpuesto") > 0 Then
                    Me.MontoTotalImpuesto = CDec(xmlEnvia.GetElementsByTagName("TotalImpuesto")(0).InnerText) * Me.TipoCambio
                Else
                    Me.MontoTotalImpuesto = 0
                End If

                Me.TotalFactura = CDec(xmlEnvia.GetElementsByTagName("TotalComprobante")(0).InnerText) * Me.TipoCambio

                Me.CondicionVenta = xmlEnvia.GetElementsByTagName("CondicionVenta")(0).InnerText
                If validatexto.IndexOf("PlazoCredito") > 0 Then
                    Dim temp As String = xmlEnvia.GetElementsByTagName("PlazoCredito")(0).InnerText
                    If IsNumeric(temp) = True Then
                        Me.PlazoCredito = temp
                    Else
                        Me.PlazoCredito = 0
                    End If
                Else
                    Me.PlazoCredito = 0
                End If

                Dim Index As Integer = 0
                Me.viewDatos.Rows.Clear()

                Dim dt As New DataTable
                Dim cCabys As String = "0"
                Dim Cantidad, Costo, Descuento, MontoDescuento, Impuesto, ExoneracionImpuesto As Decimal
                Cantidad = 0
                Costo = 0
                Descuento = 0
                MontoDescuento = 0
                Impuesto = 13
                ExoneracionImpuesto = 0

                For i As Integer = 0 To xmlEnvia.GetElementsByTagName("LineaDetalle").Count - 1

                    Dim codigolinea As String = ""
                    Dim descricionlinea As String = ""

                    Try
                        descricionlinea = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Detalle").InnerText.ToUpper
                        codigolinea = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("CodigoComercial")("Codigo").InnerText
                    Catch ex As Exception
                        'MsgBox("El xml del proveedor no contiene el campo Codigo de producto", MsgBoxStyle.Exclamation, "Este xml no se puede procesar")
                        'Me.DialogResult = Windows.Forms.DialogResult.Cancel
                        codigolinea = ""
                    End Try

                    dt = Me.Articulo.GET_ARTICULOS_PROVEEDOR_x_CODIGO_PROVEEDOR(Me.txtCedula.Text, codigolinea, descricionlinea)

                    Me.viewDatos.Rows.Add()
                    Me.viewDatos.Item("cFlete", Index).Value = False
                    Me.viewDatos.Item("cCodigoProveedor", Index).Value = codigolinea 'xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("CodigoComercial")("Codigo").InnerText
                    Me.viewDatos.Item("cDescripcion", Index).Value = descricionlinea
                    Me.viewDatos.Item("cBuscaCodigoInterno", Index).Value = "B"

                    If CStr(Me.viewDatos.Item("cDescripcion", Index).Value).Contains("FLETE") = True Or _
                    CStr(Me.viewDatos.Item("cCodigoProveedor", Index).Value).Contains("FLETE") = True Then
                        Me.viewDatos.Item("cFlete", Index).Value = True
                    End If

                    '********************************************************************************************************
                    'Carga el detalle de la compra
                    '********************************************************************************************************
                    Cantidad = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Cantidad").InnerText)
                    Costo = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("PrecioUnitario").InnerText) * Me.TipoCambio

                    Try
                        Me.viewDatos.Item("cCabys", Index).Value = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Codigo").InnerText
                    Catch ex As Exception
                        Me.viewDatos.Item("cCabys", Index).Value = "0"
                    End Try

                    Try
                        MontoDescuento = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Descuento")("MontoDescuento").InnerText) * Me.TipoCambio
                    Catch ex As Exception
                        MontoDescuento = CDec(0)
                    End Try

                    If Costo > 0 Then
                        Descuento = Math.Round(100 * (MontoDescuento / (Costo * Cantidad)), 4)
                    Else
                        Descuento = 0
                    End If

                    Try
                        Impuesto = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Impuesto")("Tarifa").InnerText)
                        Try
                            ExoneracionImpuesto = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Impuesto")("Exoneracion")("PorcentajeExoneracion").InnerText)
                        Catch ex As Exception
                            ExoneracionImpuesto = 0
                        End Try
                        Impuesto = Impuesto - ExoneracionImpuesto
                        'Exoneracion
                        'PorcentajeExoneracion
                    Catch ex As Exception
                        Impuesto = CDec(0)
                    End Try

                    Me.viewDatos.Item("cCantidad", Index).Value = Cantidad
                    Me.viewDatos.Item("cCosto", Index).Value = Costo
                    Me.viewDatos.Item("cMontoDescuento", Index).Value = MontoDescuento
                    Me.viewDatos.Item("cDescuento", Index).Value = Descuento
                    Me.viewDatos.Item("cImpuesto", Index).Value = Impuesto
                    '********************************************************************************************************

                    If dt.Rows.Count > 0 Then
                        Me.viewDatos.Item("cId_ArticuloInterno", Index).Value = dt.Rows(0).Item("ID_ARTICULO")
                        Me.viewDatos.Item("cCodigoInterno", Index).Value = dt.Rows(0).Item("CODIGO")
                        Me.viewDatos.Item("cDescripcionInterno", Index).Value = dt.Rows(0).Item("DESCRIPCION")
                        Me.viewDatos.Item("cPresentacion", Index).Value = dt.Rows(0).Item("PRESENTACION")
                        Me.viewDatos.Item("cPrecioIva1", Index).Value = dt.Rows(0).Item("PRECIO_IVA1")
                        Me.viewDatos.Item("cPrecioIva2", Index).Value = dt.Rows(0).Item("PRECIO_IVA2")
                        Me.viewDatos.Item("cPrecioIva3", Index).Value = dt.Rows(0).Item("PRECIO_IVA3")
                        Me.viewDatos.Item("cCantidadxPresentacion", Index).Value = dt.Rows(0).Item("CANTIDADxPRESENTACION")
                        Me.viewDatos.Item("cSubFamilia", Index).Value = dt.Rows(0).Item("CodFamilia")
                        Me.viewDatos.Item("cFamilia", Index).Value = dt.Rows(0).Item("Familia")
                    Else
                        Me.viewDatos.Item("cId_ArticuloInterno", Index).Value = "0"
                        Me.viewDatos.Item("cCodigoInterno", Index).Value = ""
                        Me.viewDatos.Item("cDescripcionInterno", Index).Value = ""
                        Me.viewDatos.Item("cSubFamilia", Index).Value = ""
                        Me.viewDatos.Item("cFamilia", Index).Value = ""
                        Me.viewDatos.Item("cPresentacion", Index).Value = ""
                        Me.viewDatos.Item("cPrecioIva1", Index).Value = 0
                        Me.viewDatos.Item("cPrecioIva2", Index).Value = 0
                        Me.viewDatos.Item("cPrecioIva3", Index).Value = 0
                        Me.viewDatos.Item("cCantidadxPresentacion", Index).Value = "1"
                    End If
                    Index += 1

                Next

                If GetProveedor(Me.txtCedula.Text) = "0" Then
                    Me.NoExisteCedula = True
                Else
                    Me.NoExisteCedula = False
                End If

            Else
                MsgBox("xml no valido", MsgBoxStyle.Exclamation, Text)
                Exit Sub
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetProveedor(_Cedula As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select CodigoProv from Proveedores where Cedula = '" & _Cedula & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("CodigoProv")
        Else
            Return "0"
        End If
    End Function

    Private Articulo As New GestionDatos.Articulo
    
    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Me.OpenFileDialog1.Multiselect = False
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.ObtenerDatos(Me.OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try           
            Me.EstadoCompra = Me.cboEstado.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub frmImportarFacturaElectronica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboEstado.SelectedIndex = 0
    End Sub

End Class

