Imports System.Threading
Imports CSP.EMV.InteropStream
Imports System.Xml.Serialization
Imports System.IO
Imports System.Text
Imports System.Drawing

Namespace Credomatic
    Namespace Operaciones
        Public Class Operaciones
            Private request As EMVStreamRequest
            Private response As EMVStreamResponse
            Private Terminal As New Credomatic.Configuracion.Terminal
            Public IdTerminal As String = ""
            Private _procesaOperacion As Respuesta

            Sub New()
                Me.IdTerminal = Me.Terminal.Terminal
            End Sub
            Private Sub GetTags(ByRef _Titulo As String, ByRef _Tags As String)
                Try
                    For Each x As String In Me.response.printTags
                        If _Titulo = "" Then
                            _Titulo = x
                        Else
                            If _Tags = "" Then
                                _Tags += "" & x
                            Else
                                _Tags += ";" & x
                            End If
                        End If
                    Next
                Catch ex As Exception
                    _Titulo = ""
                    _Tags = ""
                End Try
            End Sub
            Private Function ConvertiraFecha() As DateTime
                Try
                    Dim hostDate, hostTime As String
                    hostDate = response.hostDate
                    hostTime = response.hostTime
                    Dim dia, mes, anyo, hora, minuto, segundo As String
                    mes = hostDate.Substring(0, 2)
                    dia = hostDate.Substring(2, 2)
                    anyo = hostDate.Substring(4, 4)
                    hora = hostTime.Substring(0, 2)
                    minuto = hostTime.Substring(2, 2)
                    segundo = hostTime.Substring(4, 2)
                    Return CDate(dia & "/" & mes & "/" & anyo & " " & hora & ":" & minuto & ":" & segundo)
                Catch ex As Exception
                    Return Date.Now
                End Try
            End Function
            Private Function GetMonto(_Monto As String) As Double
                Try
                    Dim MontoTexto As String = _Monto
                    If MontoTexto <> "" Then
                        If Not MontoTexto.Equals(Nothing) Then
                            Return CDbl(MontoTexto.Substring(0, MontoTexto.Count - 2) & "." & MontoTexto.Substring(MontoTexto.Count - 2, 2))
                        Else
                            Return CDbl("0.00")
                        End If
                    Else
                        Return CDbl("0.00")
                    End If
                Catch ex As Exception
                    Return CDbl("0.00")
                End Try
            End Function
            Private Sub ImprimirCierre(_CantidadVentas As Integer, _MontoVentas As Decimal, _Fecha As DateTime)
                Try
                    Dim rpt As New rptCierre
                    CrystalReportsConexion.LoadReportViewer(Nothing, rpt, True)
                    rpt.SetParameterValue("CantidadVenta", _CantidadVentas)
                    rpt.SetParameterValue("MontoVentas", _MontoVentas)
                    rpt.SetParameterValue("TerminalId", Me.IdTerminal)
                    rpt.SetParameterValue("Fecha", _Fecha)
                    rpt.SetParameterValue("Estado", Me.response.responseCode)
                    rpt.SetParameterValue("Descripcion", Me.response.responseCodeDescription)

                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Terminal.Impresora
                    rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                Catch ex As Exception
                    'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ImprimirCierre")
                End Try
                'CIERRES                
            End Sub
            Public Sub ImprimirResumenCierre(_IdApertura As String)
                Try
                    Dim rpt As New rptResumenLog
                    CrystalReportsConexion.LoadReportViewer(Nothing, rpt, True)
                    rpt.SetParameterValue("IdApertura", _IdApertura)

                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Terminal.Impresora
                    rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                Catch ex As Exception
                    'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ImprimirCierre")
                End Try
                'CIERRES                
            End Sub
            Public Sub ImprimirVoucher(_Log As Log)
                Try
                    'VENTAS, ANULACIONES, REIMPRECIONES
                    Dim rpt As New rptVoucher
                    CrystalReportsConexion.LoadReportViewer(Nothing, rpt, True)
                    rpt.SetParameterValue("TerminalID", _Log.IdTerminal)
                    rpt.SetParameterValue("TipoTransaccion", _Log.TipoTransaccion)
                    rpt.SetParameterValue("Autorizacion", _Log.Autorizacion)
                    rpt.SetParameterValue("Referencia", _Log.Referencia)
                    rpt.SetParameterValue("Factura", _Log.Factura)
                    rpt.SetParameterValue("Fecha", _Log.Fecha)
                    rpt.SetParameterValue("TOTAL", _Log.Monto)
                    rpt.SetParameterValue("TituloTag", _Log.TituloTags)
                    rpt.SetParameterValue("Respuesta", IIf(_Log.CodigoRespuesta <> "00", _Log.DescripcionRespuesta, ""))

                    Dim Tag01, Tag02, Tag03, Tag04, Tag05 As String
                    Tag01 = ""
                    Tag02 = ""
                    Tag03 = ""
                    Tag04 = ""
                    Tag05 = ""

                    Dim tags() As String = _Log.Tags.Split(";")
                    For i As Integer = 0 To tags.Count - 1
                        Select Case i
                            Case 0 : Tag01 = tags(i)
                            Case 1 : Tag02 = tags(i)
                            Case 2 : Tag03 = tags(i)
                            Case 3 : Tag04 = tags(i)
                            Case 4 : Tag05 = tags(i)
                        End Select
                    Next

                    rpt.SetParameterValue("Tag01", Tag01)
                    rpt.SetParameterValue("Tag02", Tag02)
                    rpt.SetParameterValue("Tag03", Tag03)
                    rpt.SetParameterValue("Tag04", Tag04)
                    rpt.SetParameterValue("Tag05", Tag05)
                    rpt.SetParameterValue("FacturaRapido", Me.FacturaRapido)
                    rpt.SetParameterValue("NumeroTarjeta", _Log.NumeroTarjeta)

                    Dim PrinterSettings1 As New Printing.PrinterSettings
                    Dim PageSettings1 As New Printing.PageSettings
                    PrinterSettings1.PrinterName = Terminal.Impresora
                    rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                    rpt.PrintToPrinter(PrinterSettings1, PageSettings1, False)
                Catch ex As Exception
                    'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "ImprimirVoucher")
                End Try
            End Sub
            Public Function FacturaRapido() As Decimal
                Dim dt As New System.Data.DataTable
                cFunciones.Llenar_Tabla_Generico("select FacturaRapido from Credomatic", dt, CadenaConexionSeePOS)
                If dt.Rows.Count > 0 Then
                    Return CDec(dt.Rows(0).Item(0))
                Else
                    Return 30000.0
                End If
            End Function

            Public Function Venta(_Factura As String, _Total As Decimal) As Respuesta
                RegistrarLogTarjeta("")
                RegistrarLogTarjeta("  ------  " & Date.Now.ToString)
                Me.request = New EMVStreamRequest()
                Me.request.transactionType = "SALE"
                Me.request.terminalId = Me.IdTerminal
                Me.request.invoice = _Factura
                Me.request.totalAmount = _Total.ToString("N2")
                Dim result As String = Me.request.sendData()
                RegistrarLogTarjeta(result)
                Dim respuesta As Respuesta = Me.ProcesaOperacion(result, "SALE", _Factura)
                RegistrarLogTarjeta(respuesta.Codigo)
                Select Case respuesta.Codigo
                    Case "96"
                        Dim revercion As New CicloRevercion(10)
                        revercion.REVERSE(_Factura)
                    Case "CE"
                        Dim revercion As New CicloRevercion(10)
                        revercion.REVERSE(_Factura)
                    Case "DB"
                        Dim revercion As New CicloRevercion(10)
                        revercion.REVERSE(_Factura)
                    Case "WE"
                        Dim revercion As New CicloRevercion(10)
                        revercion.REVERSE(_Factura)
                    Case "RE"
                        Dim revercion As New CicloRevercion(10)
                        revercion.REVERSE(_Factura)
                End Select
                RegistrarLogTarjeta("  ------  " & Date.Now.ToString)
                RegistrarLogTarjeta("")
                Return respuesta
            End Function
            Public Function Anulacion(_NumeroAutorizacion As String, _NumeroReferencia As String) As Respuesta
                MsgBox("Esta apunto de realizar una anulacion", MsgBoxStyle.Exclamation, "Advertencia!!!!")
                If MsgBox("Confirmar que desea realizar la anulacion", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion!!!!") = MsgBoxResult.Yes Then
                    Me.request = New EMVStreamRequest()
                    Me.request.transactionType = "VOID"
                    Me.request.terminalId = Me.IdTerminal
                    Me.request.authorizationNumber = _NumeroAutorizacion
                    Me.request.referenceNumber = _NumeroReferencia
                    Dim result As String = Me.request.sendData()
                    Return Me.ProcesaOperacion(result, "VOID", 0)
                End If
            End Function
            Public MontoCierre As Decimal = 0
            Public Function Cierre() As Respuesta
                Me.request = New EMVStreamRequest()
                Me.request.transactionType = "BATCH_SETTLEMENT"
                Me.request.terminalId = Me.IdTerminal
                Dim result As String = Me.request.sendData()
                Return Me.ProcesaOperacion(result, "BATCH_SETTLEMENT", 0)
            End Function
            Public Function Reimprecion(_IdTransaccion As String) As Respuesta
                Me.request = New EMVStreamRequest()
                Me.request.transactionType = "REPRINT"
                Me.request.terminalId = Me.IdTerminal
                Me.request.transactionId = _IdTransaccion
                Dim result As String = Me.request.sendData()
                Return Me.ProcesaOperacion(result, "REPRINT", 0)
            End Function

            Private Function ProcesaOperacion(_result As String, _Tipo As String, _Factura As String) As Respuesta
                Me.response = New EMVStreamResponse()
                Dim ser As XmlSerializer = New XmlSerializer(GetType(EMVStreamResponse))
                Dim rdr As StringReader = New StringReader(_result)
                Me.response = CType(ser.Deserialize(rdr), EMVStreamResponse)

                Dim respuesta As Respuesta
                Dim Fecha As DateTime = Me.ConvertiraFecha()
                Dim Monto As Decimal = Me.GetMonto(Me.response.salesAmount)
                Dim Titulo As String = ""
                Dim Tags As String = ""
                Me.GetTags(Titulo, Tags)

                Dim invoice As String = "0"
                If _Factura = 0 Then
                    invoice = Me.response.invoice
                    If invoice = "" Then invoice = "0"
                Else
                    invoice = _Factura
                End If

                Dim Log As New Log(Me.IdTerminal, Fecha, _Tipo, invoice, Monto, Me.response.responseCode, Me.response.responseCodeDescription, Me.response.authorizationNumber, Me.response.referenceNumber, Me.response.transactionId, Titulo, Tags, Me.response.maskedCardNumber)

                If _Tipo = "BATCH_SETTLEMENT" Then
                    Me.MontoCierre = 0
                    Me.ImprimirCierre(Me.response.salesTransactions, Monto, Fecha)
                    Me.MontoCierre = Monto
                    respuesta = New Respuesta(Me.response.responseCode, Me.response.responseCodeDescription)

                    If respuesta.Codigo <> "00" Then
                        Dim frm As New frmAdvertenciaCredomatic
                        frm.lblEncabezado.Text = "No se puede procesar la operacion"
                        frm.lblDetalle.Text = respuesta.Descripcion
                        frm.ShowDialog()
                    End If

                    RegistrarenLog(Log)
                    Return respuesta
                End If

                If Me.response.responseCode = "00" Then
                    'Correcto                    
                    If _Tipo = "SALE" Then General.LogVentas.Add(Log)
                    If _Tipo = "VOID" Then General.LogAnulacion.Add(Log)
                    Me.ImprimirVoucher(Log)
                Else
                    'Incorrecto                    
                    Me.ImprimirVoucher(Log)
                    respuesta = New Respuesta(Me.response.responseCode, Me.response.responseCodeDescription)
                    Dim frm As New frmAdvertenciaCredomatic
                    frm.lblEncabezado.Text = "No se puede procesar la operacion"
                    frm.lblDetalle.Text = respuesta.Descripcion
                    frm.ShowDialog()
                    RegistrarenLog(Log)
                    Return respuesta
                End If

                If RegistrarenLog(Log) = True Then
                    respuesta = New Respuesta(Me.response.responseCode, Me.response.responseCodeDescription)
                Else
                    respuesta = New Respuesta("DB", "Problemas al registrar en base de datos")
                End If

                Return respuesta
            End Function

        End Class

        Public Class CicloRevercion
            Private request As EMVStreamRequest
            Private response As EMVStreamResponse
            Private Terminal As New Credomatic.Configuracion.Terminal
            Private IdTerminal As String = ""

            Private Minutos As Integer = 0
            Private Factura As String = ""
            Private HiloReversa As Thread

            Sub New(Optional ByVal _Minutos As Integer = 10)
                Me.IdTerminal = Me.Terminal.Terminal
                Me.Minutos = (60 * 1000) * _Minutos
            End Sub

            Public Sub REVERSE(_Factura As String)
                Me.Factura = _Factura
                Me.HiloReversa = New Thread(AddressOf REVERSE)
                Me.HiloReversa.Start()
            End Sub

            Private Function ConvertiraFecha() As DateTime
                Try
                    Dim hostDate, hostTime As String
                    hostDate = response.hostDate
                    hostTime = response.hostTime
                    Dim dia, mes, anyo, hora, minuto, segundo As String
                    mes = hostDate.Substring(0, 2)
                    dia = hostDate.Substring(2, 2)
                    anyo = hostDate.Substring(4, 4)
                    hora = hostTime.Substring(0, 2)
                    minuto = hostTime.Substring(2, 2)
                    segundo = hostTime.Substring(4, 2)
                    Return CDate(dia & "/" & mes & "/" & anyo & " " & hora & ":" & minuto & ":" & segundo)
                Catch ex As Exception
                    Return Date.Now
                End Try
            End Function
            Private Function GetMonto() As Double
                Try
                    Dim MontoTexto As String = Me.response.salesAmount
                    If MontoTexto <> "" Then
                        If Not MontoTexto.Equals(Nothing) Then
                            Return CDbl(MontoTexto.Substring(0, MontoTexto.Count - 2) & "." & MontoTexto.Substring(MontoTexto.Count - 2, 2))
                        Else
                            Return CDbl("0.00")
                        End If
                    Else
                        Return CDbl("0.00")
                    End If
                Catch ex As Exception
                    Return CDbl("0.00")
                End Try
            End Function
            Private Sub REVERSE()
                Dim Respuesta As Boolean
                Do While Respuesta = False
                    Me.request = New EMVStreamRequest()
                    Me.request.transactionType = "REVERSE"
                    Me.request.terminalId = Me.IdTerminal
                    Me.request.invoice = Me.Factura
                    Dim result As String = Me.request.sendData()

                    Me.response = New EMVStreamResponse()
                    Dim ser As XmlSerializer = New XmlSerializer(GetType(EMVStreamResponse))
                    Dim rdr As StringReader = New StringReader(result)
                    Me.response = CType(ser.Deserialize(rdr), EMVStreamResponse)

                    Dim Fecha As DateTime = Me.ConvertiraFecha()
                    Dim Monto As Decimal = Me.GetMonto()

                    Dim Log As New Log(Me.IdTerminal, Fecha, "REVERSE", Me.response.invoice, Monto, Me.response.responseCode, Me.response.responseCodeDescription, Me.response.authorizationNumber, Me.response.referenceNumber, Me.response.transactionId, "", "", Me.response.maskedCardNumber)
                    RegistrarenLog(Log)

                    If Me.response.responseCode = "00" Then
                        Respuesta = True
                    Else
                        Respuesta = False
                    End If

                Loop
                Me.HiloReversa.Abort()
            End Sub

        End Class

        Public Structure Respuesta
            Public Codigo As String
            Public Descripcion As String
            Sub New(_Codigo As String, _Descripcion As String)
                Me.Codigo = _Codigo
                Me.Descripcion = _Descripcion
            End Sub
        End Structure

        Public Structure Log
            Public IdTerminal As String
            Public Fecha As DateTime
            Public TipoTransaccion As String
            Public Factura As String
            Public Monto As Decimal
            Public CodigoRespuesta As String
            Public DescripcionRespuesta As String
            Public Autorizacion As String
            Public Referencia As String
            Public IdTransaccion As String
            Public TituloTags As String
            Public Tags As String
            Public NumeroTarjeta As String

            Sub New(_IdTerminal As String, _Fecha As DateTime, _TipoTransaccion As String, _Factura As String, _Monto As Decimal, _CodigoRespuesta As String, _DescripcionRespuesta As String, _Autorizacion As String, _Referencia As String, _IdTrasaccion As String, _TituloTags As String, _Tags As String, _NumeroTarjeta As String)
                Me.IdTerminal = _IdTerminal
                Me.Fecha = _Fecha
                Me.TipoTransaccion = _TipoTransaccion
                Me.Factura = IIf(_Factura = Nothing, "", _Factura)
                Me.Monto = _Monto
                Me.CodigoRespuesta = _CodigoRespuesta
                Me.DescripcionRespuesta = _DescripcionRespuesta
                Me.Autorizacion = IIf(_Autorizacion = Nothing, "", _Autorizacion)
                Me.Referencia = IIf(_Referencia = Nothing, "", _Referencia)
                Me.IdTransaccion = IIf(_IdTrasaccion = Nothing, "", _IdTrasaccion)
                Me.TituloTags = IIf(_TituloTags = Nothing, "", _TituloTags)
                Me.Tags = IIf(_Tags = Nothing, "", _Tags)
                Me.NumeroTarjeta = IIf(_NumeroTarjeta = Nothing, "", _NumeroTarjeta)
            End Sub
        End Structure

        Public Module General
            Public LogVentas As New System.Collections.Generic.List(Of Log)
            Public LogAnulacion As New System.Collections.Generic.List(Of Log)

            Public Sub LimpiarLogVentas()
                LogVentas.Clear()
                LogVentas = New System.Collections.Generic.List(Of Log)
            End Sub
            Public Sub RevertirLogVentas()
                Dim cls As New CicloRevercion
                For Each Log As Log In LogVentas
                    cls.REVERSE(Log.Factura)
                Next
                LimpiarLogVentas()
            End Sub
            Public Sub LimpiarLogAnulacion()
                LogVentas.Clear()
                LogVentas = New System.Collections.Generic.List(Of Log)
            End Sub
            Public Function RegistrarenLog(_Log As Log) As Boolean
                Dim trans As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    trans.SetParametro("@Fecha", _Log.Fecha)
                    trans.Ejecutar("INSERT INTO [dbo].[Log]([IdTerminal],[TipoTransaccion],[Factura],[Monto],[CodigoRespueta],[DescripcionRespuesta],[Autorizacion],[Referencia],[IdTransaccion],[TituloTag],[Tags],[Fecha],[NumeroTarjeta]) Values('" & _Log.IdTerminal & "', '" & _Log.TipoTransaccion & "', " & _Log.Factura & ", " & _Log.Monto & ", '" & _Log.CodigoRespuesta & "', '" & _Log.DescripcionRespuesta & "', '" & _Log.Autorizacion & "', '" & _Log.Referencia & "', '" & _Log.IdTransaccion & "', '" & _Log.TituloTags & "', '" & _Log.Tags & "', @Fecha, '" & _Log.NumeroTarjeta & "')", Data.CommandType.Text)
                    trans.Commit()
                    Return True
                Catch ex As Exception
                    trans.Rollback()
                    Return False
                End Try
            End Function
        End Module

    End Namespace
End Namespace

