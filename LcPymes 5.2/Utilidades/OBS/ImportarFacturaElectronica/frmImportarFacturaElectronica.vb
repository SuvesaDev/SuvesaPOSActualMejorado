Imports System.IO
Imports System.Windows.Forms
Imports System.Data

Public Class frmImportarFacturaElectronica

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
                Dim Cantidad, Costo, Descuento, MontoDescuento, Impuesto As Decimal
                Cantidad = 0
                Costo = 0
                Descuento = 0
                MontoDescuento = 0
                Impuesto = 13

                For i As Integer = 0 To xmlEnvia.GetElementsByTagName("LineaDetalle").Count - 1

                    Dim codigolinea As String = ""

                    Try
                        codigolinea = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("CodigoComercial")("Codigo").InnerText
                    Catch ex As Exception
                        MsgBox("El xml del proveedor no contiene el campo Codigo de producto", MsgBoxStyle.Exclamation, "Este xml no se puede procesar")
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    End Try

                    dt = Me.Articulo.GET_ARTICULOS_PROVEEDOR_x_CODIGO_PROVEEDOR(Me.txtCedula.Text, codigolinea)

                    Me.viewDatos.Rows.Add()
                    Me.viewDatos.Item("cCodigoProveedor", Index).Value = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("CodigoComercial")("Codigo").InnerText
                    Me.viewDatos.Item("cDescripcion", Index).Value = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Detalle").InnerText.ToUpper
                    Me.viewDatos.Item("cBuscaCodigoInterno", Index).Value = "B"

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
                    Else
                        Me.viewDatos.Item("cId_ArticuloInterno", Index).Value = "0"
                        Me.viewDatos.Item("cCodigoInterno", Index).Value = ""
                        Me.viewDatos.Item("cDescripcionInterno", Index).Value = ""
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
    Private Sub viewMatriculaAdjunto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            Dim CodigoInterno As String
            CodigoInterno = Me.Articulo.BuscarArticulo

            If IsNumeric(CodigoInterno) And CodigoInterno <> "" Then
                If CodigoInterno <> 0 Then
                    Me.Articulo.GET_ARTICULO(CodigoInterno)
                    Me.viewDatos.Item("cId_ArticuloInterno", e.RowIndex).Value = Me.Articulo.Id_Articulo
                    Me.viewDatos.Item("cCodigoInterno", e.RowIndex).Value = Me.Articulo.Codigo
                    Me.viewDatos.Item("cDescripcionInterno", e.RowIndex).Value = Me.Articulo.Descripcion
                    Me.viewDatos.Item("cPresentacion", e.RowIndex).Value = CStr(Me.Articulo.Cantidad_Presentacion & " " & Me.Articulo.Presentacion)
                    Me.viewDatos.Item("cPrecioIva1", e.RowIndex).Value = Me.Articulo.Precio_IVA1
                    Me.viewDatos.Item("cPrecioIva2", e.RowIndex).Value = Me.Articulo.Precio_IVA2
                    Me.viewDatos.Item("cPrecioIva3", e.RowIndex).Value = Me.Articulo.Precio_IVA3
                End If
            End If

        End If
    End Sub

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
            Dim Pasa As Boolean = True
            For Each r As DataGridViewRow In Me.viewDatos.Rows
                If r.Cells("cId_ArticuloInterno").Value.ToString = "" Then
                    Pasa = False
                End If
                If IsNumeric(r.Cells("cId_ArticuloInterno").Value.ToString) = False Then
                    Pasa = False
                End If
            Next

            If Pasa = False Then
                MsgBox("Faltan datos por ingresar o dato invalido", MsgBoxStyle.Exclamation, Text)
                Exit Sub
            End If

            For Each r As DataGridViewRow In Me.viewDatos.Rows
                If CDec(r.Cells("cId_ArticuloInterno").Value) > 0 Then
                    Me.Articulo.SAVE_ARTICULO_PROVEEDOR(Me.txtCedula.Text, r.Cells("cCodigoProveedor").Value, r.Cells("cId_ArticuloInterno").Value, r.Cells("cCantidadxPresentacion").Value)
                End If
            Next

            Me.EstadoCompra = Me.cboEstado.Text

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Sub frmImportarFacturaElectronica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboEstado.SelectedIndex = 0

    End Sub

    Private Sub viewDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewDatos.CellDoubleClick
        Dim frm As New frmEditarPrecioVenta_FacturaElectronica
        frm.TxtImpuesto_Porcentaje.Text = Me.viewDatos.Item("cImpuesto", Me.viewDatos.CurrentRow.Index).Value
        frm.Base = 0

        Dim cant As Decimal = 0
        Dim costo As Decimal = 0

        cant = CDec(Me.viewDatos.Item("cCantidad", e.RowIndex).Value) * CDec(Me.viewDatos.Item("cCantidadxPresentacion", e.RowIndex).Value)
        costo = (CDec(Me.viewDatos.Item("cCosto", e.RowIndex).Value) * CDec(Me.viewDatos.Item("cCantidad", e.RowIndex).Value)) / cant

        frm.Base = Math.Round(costo, 2)

        frm.TxtPrecioVenta_A.Text = Me.viewDatos.Item("cPrecioIva1", e.RowIndex).Value
        frm.TxtPrecioVenta_B.Text = Me.viewDatos.Item("cPrecioIva2", e.RowIndex).Value
        frm.TxtPrecioVenta_C.Text = Me.viewDatos.Item("cPrecioIva3", e.RowIndex).Value
        frm.TxtPrecioVenta_D.Enabled = False
        frm.TxtUtilidad_D.Enabled = False
        frm.TxtPrecioVenta_IV_D.Enabled = False

        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.viewDatos.Item("cPrecioIva1", e.RowIndex).Value = frm.TxtPrecioVenta_A.Text
            Me.viewDatos.Item("cPrecioIva2", e.RowIndex).Value = frm.TxtPrecioVenta_B.Text
            Me.viewDatos.Item("cPrecioIva3", e.RowIndex).Value = frm.TxtPrecioVenta_C.Text
        End If
    End Sub

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()
        InitializeComponent() 'This call is required by the Windows Form Designer.
        Usua = Usuario_Parametro
    End Sub

    Dim Usua As New Object
    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim frm As New FrmInventario(Usua)
        frm.ShowDialog()
    End Sub

End Class

Namespace GestionDatos
    Public Class Articulo
        Public Id_Articulo As String
        Public Codigo As String
        Public Descripcion As String
        Public Cantidad_Presentacion As Decimal
        Public Presentacion As String
        Public Precio_IVA1 As Decimal
        Public Precio_IVA2 As Decimal
        Public Precio_IVA3 As Decimal

        Public Function BuscarArticulo(Optional ByVal _IdPuntoVenta As Integer = 0) As String
            Dim Codigo As String = ""
            Dim BuscarArt As New FrmBuscarArticulo2
            BuscarArt.StartPosition = FormStartPosition.CenterParent
            BuscarArt.CheckBoxInHabilitados.Enabled = True
            BuscarArt.Codigo = ""
            BuscarArt.Cod_Articulo = True
            BuscarArt.IdPuntoVenta = _IdPuntoVenta
            BuscarArt.ShowDialog()
            If BuscarArt.Cancelado Then
                Return ""
            End If
            Codigo = BuscarArt.Codigo
            BuscarArt.Close()
            BuscarArt.Dispose()
            BuscarArt = Nothing
            Return Codigo
        End Function

        Private Servidor As String = ""
        Private Function BuscaDatos(ByVal _Texto As String) As String
            Dim Resultado As String = ""
            Dim inicia As Boolean = False
            For Each c As Char In _Texto
                If inicia = True Then
                    If c <> ";" Then
                        Resultado += c
                    End If
                End If
                If c = "=" Then inicia = True
            Next
            Return Resultado
        End Function

        Private Function Conexcion(_PuntoVenta As Integer) As String
            If _PuntoVenta = 0 Then
                Return CadenaConexionSeePOS
            Else
                Dim dt As New DataTable
                Dim Conexion() As String = CadenaConexionSeePOS.Split(";")
                Me.Servidor = Me.BuscaDatos(Conexion(0))
                cFunciones.Llenar_Tabla_Generico("select * from PuntodeVenta where IdPuntoVenta = " & _PuntoVenta, dt, CadenaConexionSeguridad)
                Return "Data Source=" & Me.Servidor & "; Initial Catalog=" & dt.Rows(0).Item("BasedeDatos") & "; Integrated Security=true;"
            End If
        End Function

        Public Sub GET_ARTICULO(_IdArticulo As String, Optional ByVal _IdPuntoVenta As Integer = 0)
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select i.Codigo As Id_Articulo, i.Cod_Articulo As Codigo, i.Descripcion, i.PresentaCant As Cantidad_Presentacion, p.Presentaciones As Presentacion, i.Precio_A As Precio_IVA1, i.Precio_B As Precio_IVA2, i.Precio_C As Precio_IVA3 from Inventario i inner join Presentaciones p on  i.CodPresentacion = p.CodPres where i.Cod_Articulo = '" & _IdArticulo & "'", dt, Me.Conexcion(_IdPuntoVenta))
            If dt.Rows.Count > 0 Then
                Me.Id_Articulo = dt.Rows(0).Item("Id_Articulo")
                Me.Codigo = dt.Rows(0).Item("Codigo")
                Me.Descripcion = dt.Rows(0).Item("Descripcion")
                Me.Cantidad_Presentacion = dt.Rows(0).Item("Cantidad_Presentacion")
                Me.Presentacion = dt.Rows(0).Item("Presentacion")
                Me.Precio_IVA1 = dt.Rows(0).Item("Precio_IVA1")
                Me.Precio_IVA2 = dt.Rows(0).Item("Precio_IVA2")
                Me.Precio_IVA3 = dt.Rows(0).Item("Precio_IVA3")
            End If
        End Sub

        Public Sub SAVE_ARTICULO_PROVEEDOR(_Cedula As String, _CodProveedor As String, _CodInterno As String, _CantPresentacion As Decimal)
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim strSQL As String = "Delete from articulos_proveedor Where Cedula = '" & _CodProveedor & "' and Codigo_Proveedor = '" & _CodInterno & "'"
            db.Ejecutar(strSQL, CommandType.Text)
            strSQL = "Insert Into articulos_proveedor(Cedula, Codigo_Proveedor, Id_Articulo, CantidadxPresentacion) Values('" & _Cedula & "', '" & _CodProveedor & "', " & _CodInterno & ", " & _CantPresentacion & ")"
            db.Ejecutar(strSQL, CommandType.Text)
        End Sub

        Public Function GET_ARTICULOS_PROVEEDOR_x_CODIGO_PROVEEDOR(_Cedula As String, _CodProveedor As String) As DataTable
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select ap.ID_ARTICULO, i.Cod_Articulo As CODIGO, i.Descripcion AS DESCRIPCION, cast(i.PresentaCant as nvarchar) + ' ' + p.Presentaciones As PRESENTACION, i.Precio_A As PRECIO_IVA1, i.Precio_B As PRECIO_IVA2, i.Precio_C As PRECIO_IVA3, ap.CANTIDADxPRESENTACION from Inventario i inner join Presentaciones p on  i.CodPresentacion = p.CodPres inner join articulos_proveedor ap on ap.ID_ARTICULO = i.Codigo where AP.CEDULA = '" & _Cedula & "' and ap.CODIGO_PROVEEDOR = '" & _CodProveedor & "'", dt, CadenaConexionSeePOS)
            Return dt
        End Function

    End Class
End Namespace