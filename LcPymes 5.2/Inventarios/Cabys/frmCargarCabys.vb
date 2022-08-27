Imports System.IO
Imports System.Data
Public Class frmCargarCabys

    '    Public DirXML As String = ""
    '    Private Function LeerArchivo(_Archivo As String) As String
    '        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
    '        Dim leer As New StreamReader(_Archivo)
    '        ':::Limpiamos nuestro ListBox
    '        Dim Texto As String = ""
    '        Try
    '            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
    '            While leer.Peek <> -1
    '                ':::Leemos cada linea del archivo TXT
    '                Dim linea As String = leer.ReadLine()
    '                ':::validamos que la linea no este vacia
    '                If String.IsNullOrEmpty(linea) Then
    '                    Continue While
    '                End If
    '                ':::Agregramos los registros encontrados
    '                Texto += limpiarCadenaNombreFichero(linea, "")
    '            End While
    '            leer.Close()
    '            Return Texto
    '        Catch ex As Exception
    '            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
    '        End Try
    '    End Function


    '    Function limpiarCadenaNombreFichero(cadenaTexto As String, _
    'sustituirPor As String) As String
    '        Dim tamanoCadena, cadenaResultado, caracteresValidos As String
    '        Dim caracterActual As String

    '        tamanoCadena = Len(cadenaTexto)
    '        If tamanoCadena > 0 Then
    '            caracteresValidos = " 0123456789abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ-_.:<>/?""=#@,+"
    '            For i As Integer = 1 To tamanoCadena
    '                caracterActual = Mid(cadenaTexto, i, 1)
    '                If InStr(caracteresValidos, caracterActual) Then
    '                    cadenaResultado = cadenaResultado & caracterActual
    '                Else
    '                    cadenaResultado = cadenaResultado & sustituirPor
    '                End If
    '            Next
    '        End If

    '        limpiarCadenaNombreFichero = cadenaResultado
    '    End Function

    '    Private Clave, Cedula, Nombre As String
    '    Private Sub ObtenerDatos(_xml As String)
    '        Try
    '            Dim xmlEnvia As New Xml.XmlDocument
    '            xmlEnvia.LoadXml(Me.LeerArchivo(_xml))
    '            Dim validatexto As String = xmlEnvia.OuterXml
    '            If validatexto.ToLower.IndexOf("facturaelectronica") > 0 Or validatexto.ToLower.IndexOf("tiqueteelectronico") > 0 Then

    '                Dim frm As New Conecta_Frm
    '                frm.Show("Espere porfavor, La Operacion puede Tardar varios Minutos", "Procesando...")

    '                Me.Clave = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
    '                Me.Cedula = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
    '                Me.Nombre = xmlEnvia.GetElementsByTagName("Emisor")(0)("Nombre").InnerText.ToUpper

    '                Dim Index As Integer = 0
    '                Me.viewDatos.Rows.Clear()

    '                For i As Integer = 0 To xmlEnvia.GetElementsByTagName("LineaDetalle").Count - 1

    '                    Dim DescripcionLinea As String = ""
    '                    Dim CodigoCaByS As String = "0"

    '                    Try
    '                        CodigoCaByS = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Codigo").InnerText
    '                    Catch ex As Exception
    '                        CodigoCaByS = "0"
    '                    End Try

    '                    DescripcionLinea = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Detalle").InnerText.ToUpper

    '                    Me.viewDatos.Rows.Add()
    '                    Me.viewDatos.Item("cCodigoCabys", Index).Value = CodigoCaByS
    '                    Me.viewDatos.Item("cDescripcion", Index).Value = DescripcionLinea

    '                    '********************************************************************************************************
    '                    'Carga el detalle de la compra
    '                    '********************************************************************************************************
    '                    Cantidad = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Cantidad").InnerText)
    '                    Costo = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("PrecioUnitario").InnerText) * Me.TipoCambio


    '                    Try
    '                        MontoDescuento = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Descuento")("MontoDescuento").InnerText) * Me.TipoCambio
    '                    Catch ex As Exception
    '                        MontoDescuento = CDec(0)
    '                    End Try

    '                    If Costo > 0 Then
    '                        Descuento = Math.Round(100 * (MontoDescuento / (Costo * Cantidad)), 4)
    '                    Else
    '                        Descuento = 0
    '                    End If

    '                    Dim montoImpuesto As Decimal
    '                    Dim ImpuestoRegalia As Decimal = 0
    '                    Try
    '                        Dim subtotal As Decimal = CDec(xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("SubTotal").InnerText)
    '                        montoImpuesto = 0
    '                        OtrosImpuestos = 0
    '                        For Each x As System.Xml.XmlElement In xmlEnvia.GetElementsByTagName("LineaDetalle")(i)
    '                            Dim nombre As String = x.Name
    '                            If nombre = "Impuesto" Then
    '                                If x("Codigo").InnerText = "01" Then
    '                                    montoImpuesto += x("Monto").InnerText
    '                                    ImpuestoRegalia = x("Tarifa").InnerText
    '                                End If
    '                                If x("Codigo").InnerText = "99" Then
    '                                    OtrosImpuestos += x("Monto").InnerText
    '                                End If
    '                            End If
    '                        Next

    '                        subtotal += OtrosImpuestos
    '                        Impuesto = (montoImpuesto / subtotal) * 100
    '                        If OtrosImpuestos > 0 Then
    '                            Costo = subtotal / Cantidad
    '                        End If

    '                    Catch ex As Exception
    '                        Impuesto = CDec(0)
    '                    End Try

    '                    Me.viewDatos.Item("cDescripcion", Index).Value = DescripcionLinea
    '                    Me.viewDatos.Item("cCantidad", Index).Value = Cantidad
    '                    Me.viewDatos.Item("cCosto", Index).Value = Costo
    '                    Me.viewDatos.Item("cMontoDescuento", Index).Value = MontoDescuento
    '                    Me.viewDatos.Item("cDescuento", Index).Value = Descuento
    '                    Me.viewDatos.Item("cImpuesto", Index).Value = IIf(Costo > 0, Impuesto, ImpuestoRegalia)
    '                    Me.viewDatos.Item("cMontoImpuesto", Index).Value = montoImpuesto
    '                    Me.viewDatos.Item("cMontoOtroImpuestos", Index).Value = OtrosImpuestos
    '                    '********************************************************************************************************

    '                    Dim dt As New DataTable
    '                    dt = Me.Articulo.GET_ARTICULOS_PROVEEDOR_x_CODIGO_PROVEEDOR(Me.txtCedula.Text, CodigoLinea)

    '                    'If Not dt.Rows.Count > 0 Then
    '                    '    If 0 = 0 Then ' VALIDAR OPCION PARA QUE NO SE ACTIVE PARA TODOS LOS CLIENTES
    '                    '        If Not Me.Articulo.GET_ARTICULO_BY_CODIGO(CodigoLinea).Rows.Count > 0 Then ' SI EL PRODUCTO NO EXISTE
    '                    '            Me.Articulo.INS_ARTICULOXMLCOMPRA(CodigoLinea, DescripcionLinea, (Costo - (MontoDescuento / Cantidad)), Impuesto, Me.txtCedula.Text, CodigoCaByS)
    '                    '            dt = Me.Articulo.GET_ARTICULOS_PROVEEDOR_x_CODIGO_PROVEEDOR(Me.txtCedula.Text, CodigoLinea)
    '                    '        End If
    '                    '    End If
    '                    'End If                    

    '                    If dt.Rows.Count > 0 Then
    '                        Me.viewDatos.Item("cId_ArticuloInterno", Index).Value = dt.Rows(0).Item("ID_ARTICULO")
    '                        Me.viewDatos.Item("cCodigoInterno", Index).Value = dt.Rows(0).Item("CODIGO")
    '                        Me.viewDatos.Item("cDescripcionInterno", Index).Value = dt.Rows(0).Item("DESCRIPCION")
    '                        Me.viewDatos.Item("cPresentacion", Index).Value = dt.Rows(0).Item("PRESENTACION")
    '                        Me.viewDatos.Item("cPrecioIva1", Index).Value = dt.Rows(0).Item("PRECIO_IVA1")
    '                        Me.viewDatos.Item("cPrecioIva2", Index).Value = dt.Rows(0).Item("PRECIO_IVA2")
    '                        Me.viewDatos.Item("cPrecioIva3", Index).Value = dt.Rows(0).Item("PRECIO_IVA3")
    '                        If dt.Rows(0).Item("FRACCIONADO") = 0 Then
    '                            Me.viewDatos.Item("cPrecioFraccion", Index).Value = 0
    '                        End If
    '                        If dt.Rows(0).Item("FRACCIONADO") = 1 Then
    '                            Me.viewDatos.Item("cPrecioFraccion", Index).Value = dt.Rows(0).Item("PRECIO_FRACCION")
    '                        End If
    '                        Me.viewDatos.Item("cCantidadxPresentacion", Index).Value = dt.Rows(0).Item("CANTIDADxPRESENTACION")
    '                    Else
    '                        Me.viewDatos.Item("cId_ArticuloInterno", Index).Value = "0"
    '                        Me.viewDatos.Item("cCodigoInterno", Index).Value = ""
    '                        Me.viewDatos.Item("cDescripcionInterno", Index).Value = ""
    '                        Me.viewDatos.Item("cPresentacion", Index).Value = ""
    '                        Me.viewDatos.Item("cPrecioIva1", Index).Value = 0
    '                        Me.viewDatos.Item("cPrecioIva2", Index).Value = 0
    '                        Me.viewDatos.Item("cPrecioIva3", Index).Value = 0
    '                        Me.viewDatos.Item("cCantidadxPresentacion", Index).Value = "1"
    '                    End If
    '                    Index += 1

    '                Next

    '                Me.DirXML = _xml

    '                frm.Close()
    '            Else
    '                MsgBox("xml no valido", MsgBoxStyle.Exclamation, Text)
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
    '        Me.OpenFileDialog1.Multiselect = False
    '        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            Me.viewDatos.Enabled = True
    '            Me.ObtenerDatos(Me.OpenFileDialog1.FileName)
    '        End If
    '    End Sub
End Class