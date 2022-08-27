﻿Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data

Namespace OBSoluciones

    Namespace Utilidades

        Public Class PDF

            Private doc As Document
            Private writer As PdfWriter
            Private vAutor As String
            Private vTitulo As String
            Private tbl As PdfPTable
            Private cl As PdfPCell

            Public Property Autor As String
                Get
                    Return Me.vAutor
                End Get
                Set(value As String)
                    Me.vAutor = value
                End Set
            End Property

            Public Property Titulo As String
                Get
                    Return Me.vTitulo
                End Get
                Set(value As String)
                    Me.vTitulo = value
                End Set
            End Property

            Public Sub CrearDocumento(_Archivo As String)
                Me.doc = New Document(PageSize.A4)
                writer = PdfWriter.GetInstance(doc, New FileStream(_Archivo, FileMode.Create))
                doc.AddTitle(Me.vTitulo)
                doc.AddAuthor(Me.vAutor)
                doc.Open()
            End Sub

            Public Sub Terminar_Documento()
                doc.Close()
                writer.Close()
            End Sub

            Public Sub EscribirTexto(_Texto As String, _Alineado As Integer, Optional ByVal _Tamanyo As Single = 10)
                Dim parrafo As New Paragraph(_Texto)
                parrafo.Font = FontFactory.GetFont("Arial", _Tamanyo)
                parrafo.Alignment = _Alineado
                doc.Add(parrafo)
            End Sub

            Public Sub Agregar_Imagen(_Archivo)
                If File.Exists(_Archivo) = True Then
                    Dim imagen As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(_Archivo)
                    imagen.BorderWidth = 0
                    imagen.ScalePercent(40.0F)
                    imagen.Alignment = Element.ALIGN_RIGHT
                    doc.Add(imagen)
                End If
            End Sub

            Public Sub Crear_Tabla(_Columns As Integer, _tamanio() As Single, Optional ByVal _Porcentaje As Single = 100, Optional ByVal _Aligment As Single = Element.ALIGN_LEFT)
                Me.tbl = New PdfPTable(_Columns)
                tbl.WidthPercentage = _Porcentaje
                tbl.HorizontalAlignment = _Aligment
                tbl.SetWidths(_tamanio)
            End Sub

            Public Sub Crear_Tabla(_Columns As Integer, Optional ByVal _Porcentaje As Single = 100, Optional ByVal _Aligment As Single = Element.ALIGN_LEFT)
                Me.tbl = New PdfPTable(_Columns)
                tbl.WidthPercentage = _Porcentaje
                tbl.HorizontalAlignment = _Aligment
            End Sub

            Public Sub Termina_Tabla()
                doc.Add(tbl)
            End Sub

            Public Sub Agregar_Celda(_Descripcion As String, ByVal _Alineado As Single, Optional ByVal _Borde As Single = 0, Optional ByVal _Tamanyo As Single = 10)
                Dim parrafo As New Paragraph(_Descripcion)
                parrafo.Font = FontFactory.GetFont("Arial", _Tamanyo)
                parrafo.Alignment = _Alineado
                cl = New PdfPCell()
                cl.AddElement(parrafo)
                cl.BorderWidth = 0
                cl.BorderWidthBottom = _Borde
                tbl.AddCell(cl)
            End Sub

            Public Function GetImagen(_Direccion As String) As iTextSharp.text.Image
                If File.Exists(_Direccion) = True Then
                    Dim imagen As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(_Direccion)
                    imagen.BorderWidth = 0
                    imagen.ScalePercent(40.0F)
                    imagen.Alignment = Element.ALIGN_CENTER
                    Return imagen
                End If
            End Function

            Public Sub Agregar_Celda(_Imagen As iTextSharp.text.Image, Optional ByVal _Borde As Single = 0)
                Try
                    cl = New PdfPCell(_Imagen)
                    cl.VerticalAlignment = Element.ALIGN_CENTER
                    cl.BorderWidth = 0
                    cl.BorderWidthBottom = _Borde
                    tbl.AddCell(cl)
                Catch ex As Exception
                End Try
            End Sub

            Public Sub CrearFactura(_Clave As String, _dtsEncabezado As DataTable, _dtsDetalle As DataTable, Optional ByVal Ubicacion As String = "")

                Dim Clave As String = _Clave
                Dim Consecutivo As String = _dtsEncabezado.Rows(0).Item("Consecutivo")

                Dim dir As String = "C:\Facturas\" & Consecutivo & "\" & Clave & ".pdf"
                If Ubicacion <> "" Then
                    dir = Ubicacion
                End If
                Me.CrearDocumento(dir)

                Me.Crear_Tabla(2)
                Me.Agregar_Celda("Factura Electrónica N° " & Consecutivo, Element.ALIGN_LEFT)
                Me.Agregar_Celda("Fecha Emision : " & _dtsEncabezado.Rows(0).Item("FechaEmision"), Element.ALIGN_RIGHT)
                Me.Termina_Tabla()
                Me.Crear_Tabla(1)
                Me.Agregar_Celda("Clave Numérica " & Clave, Element.ALIGN_LEFT)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Me.EscribirTexto(" ", Element.ALIGN_LEFT, 3)

                Me.Crear_Tabla(3)
                Me.Agregar_Celda(Me.GetImagen("C:\Facturas\Logo.png"))
                Me.Agregar_Celda(_dtsEncabezado.Rows(0).Item("Nombre_Emisor") & vbCrLf _
                                 & "Cédula : " & _dtsEncabezado.Rows(0).Item("Numero_Emisor"), Element.ALIGN_CENTER)
                Me.Agregar_Celda("Telefono : " & _dtsEncabezado.Rows(0).Item("NumTelefono_Emisor") & vbCrLf _
                                 & "" & vbCrLf _
                                 & "Correo : " & _dtsEncabezado.Rows(0).Item("CorreoElectronico_Emisor") & vbCrLf _
                                 & "" & vbCrLf _
                                 & "Direccion : " & _dtsEncabezado.Rows(0).Item("OtrasSenas_Emisor"), Element.ALIGN_LEFT, 0, 7)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Me.Crear_Tabla(2)
                Me.Agregar_Celda("Receptor: " & _dtsEncabezado.Rows(0).Item("Nombre_Receptor"), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Condicion Venta: " & IIf(_dtsEncabezado.Rows(0).Item("CondicionVenta") = "01", "CONTADO", "CREDITO"), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Cédula : " & _dtsEncabezado.Rows(0).Item("Numero_Receptor"), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(IIf(_dtsEncabezado.Rows(0).Item("CondicionVenta") = "01", "", "Vence: " & CDate(_dtsEncabezado.Rows(0).Item("FechaVence")).ToShortDateString), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Teléfono: " & _dtsEncabezado.Rows(0).Item("NumTelefono_Receptor"), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Orden Compra: " & _dtsEncabezado.Rows(0).Item("OrdenCompra"), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Correo: " & _dtsEncabezado.Rows(0).Item("CorreoElectronico_Receptor"), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Me.Crear_Tabla(1)
                Me.Agregar_Celda("Líneas de Detalle", Element.ALIGN_CENTER, 0, 10)
                Me.Termina_Tabla()

                Dim _tamanio() As Single = {10, 20, 95, 25, 20, 30}
                Me.Crear_Tabla(6, _tamanio)
                Me.Agregar_Celda("Cant", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("Codigo", Element.ALIGN_CENTER, 0.75F)
                Me.Agregar_Celda("Descripcion", Element.ALIGN_CENTER, 0.75F)
                Me.Agregar_Celda("P. Unit.", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("% Desc.", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("Monto", Element.ALIGN_RIGHT, 0.75F)

                For Each r As DataRow In _dtsDetalle.Rows
                    Me.Agregar_Celda(r.Item("cantidad"), Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(r.Item("Codigo"), Element.ALIGN_CENTER, 0, 8)
                    Me.Agregar_Celda(r.Item("Detalle"), Element.ALIGN_LEFT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.Item("PrecioUnitario")), "N2"), Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(0, Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.Item("MontoTotal")), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Next

                Me.Termina_Tabla()

                Me.Crear_Tabla(1)
                Me.Agregar_Celda("(*) EXCENTO   = = = = = > ULTIMA LINEA < = = = = =", Element.ALIGN_CENTER, 0, 8)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0.75F, 1)
                Me.Termina_Tabla()

                Dim _tamanio2() As Single = {30, 30}
                Me.Crear_Tabla(2, _tamanio2, 25, Element.ALIGN_RIGHT)
                Me.Agregar_Celda("GRAVADO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_dtsEncabezado.Rows(0).Item("TotalGravado")), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("EXENTO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_dtsEncabezado.Rows(0).Item("TotalExento")), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("DESCUENTO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_dtsEncabezado.Rows(0).Item("TotalDescuentos")), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("I.V.", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_dtsEncabezado.Rows(0).Item("TotalImpuesto")), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("TOTAL", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_dtsEncabezado.Rows(0).Item("TotalComprobante")), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Termina_Tabla()

                Me.EscribirTexto(" ", Element.ALIGN_LEFT)

                'codigo QR
                'Me.Agregar_Imagen("C:\Facturas\" & Consecutivo & "\" & Clave & ".png")

                Me.Crear_Tabla(1)
                Me.Agregar_Celda(_dtsEncabezado.Rows(0).Item("NumeroResolucion"), Element.ALIGN_CENTER, 0, 7)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0.75F, 1)
                Me.Termina_Tabla()

                Me.Terminar_Documento()
            End Sub


        End Class

    End Namespace

End Namespace
