Imports System.Data
Imports System.Collections.Generic
Imports System.Xml
Imports System.IO

Public Class frmMensajeReceptor

    Private Clave As String
    Private NumeroCedulaEmisor As String
    Private FechaEmisionDoc As String
    Private Mensaje As String
    Private MontoTotalImpuesto As Decimal
    Private TotalFactura As Decimal
    Private NumeroCedulaReceptor As String
    Private NumeroConsecutivoReceptor As String

    Private Nombre As String
    Private Index As Integer = 0

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

    Private ListaXML As New List(Of String)

    'Private Sub GuardarXML()
    '    Try
    '        Dim DireccionRespaldoXML As String = My.Application.Info.DirectoryPath & "\RespaldoXML"
    '        If IO.Directory.Exists(DireccionRespaldoXML) = False Then
    '            IO.Directory.CreateDirectory(DireccionRespaldoXML)
    '        End If
    '        For Each x As String In Me.ListaXML
    '            IO.File.Move(x, DireccionRespaldoXML)
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
    '    End Try        
    'End Sub

    Private Sub ObtenerDatos(_xml As String)

        Dim xmlEnvia As New Xml.XmlDocument
        Try
            xmlEnvia.LoadXml(Me.LeerArchivo(_xml))
            If xmlEnvia.DocumentElement.InnerXml.IndexOf("mensajeHacienda") > 0 Then
                Exit Sub
            End If

            Me.Clave = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
            Me.NumeroCedulaEmisor = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
            Me.Nombre = xmlEnvia.GetElementsByTagName("Emisor")(0)("Nombre").InnerText
            Me.FechaEmisionDoc = xmlEnvia.GetElementsByTagName("FechaEmision")(0).InnerText
            Me.Mensaje = ""
            Me.TotalFactura = xmlEnvia.GetElementsByTagName("TotalComprobante")(0).InnerText
            Me.NumeroConsecutivoReceptor = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try

        Try
            Me.NumeroCedulaReceptor = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Numero").InnerText
        Catch ex As Exception
            Me.NumeroCedulaEmisor = ""
        End Try

        Try
            Me.MontoTotalImpuesto = xmlEnvia.GetElementsByTagName("TotalImpuesto")(0).InnerText
        Catch ex As Exception
            Me.MontoTotalImpuesto = 0
        End Try

        If Me.ClaveExiste(Me.Clave) = False Then
            Me.ListaXML.Add(_xml)
            Me.viewDatosXML.Rows.Add()
            Me.viewDatosXML.Item("cTipo", Me.Index).Value = Me.cboTipo.Text
            Me.viewDatosXML.Item("cClave", Me.Index).Value = Me.Clave
            Me.viewDatosXML.Item("cNumeroCedulaEmisor", Me.Index).Value = Me.NumeroCedulaEmisor
            Me.viewDatosXML.Item("cNombre", Me.Index).Value = Me.Nombre
            Me.viewDatosXML.Item("cMensaje", Me.Index).Value = "ACEPTADO"
            Me.viewDatosXML.Item("cMontoTotalImpuesto", Me.Index).Value = Me.MontoTotalImpuesto
            Me.viewDatosXML.Item("cTotalFactura", Me.Index).Value = Me.TotalFactura
            Me.viewDatosXML.Item("cNumeroCedulaReceptor", Me.Index).Value = Me.NumeroCedulaReceptor
            Me.viewDatosXML.Item("cCodigoActividad", Me.Index).Value = Me.PrimeraActividad
            Me.viewDatosXML.Item("cCondicionImpuesto", Me.Index).Value = Me.PrimeraCondicion
            Me.viewDatosXML.Item("cMontoTotalImpuestoAcreditar", Me.Index).Value = Me.MontoTotalImpuesto
            Me.viewDatosXML.Item("cMontoTotaldeGastoAplicable", Me.Index).Value = Me.TotalFactura - Me.MontoTotalImpuesto

            Me.Index += 1
        Else
            If Me.ckInformar.Checked = True Then
                MsgBox("La Clave '" & Me.Clave & "' ya esta registrada en el sistema", MsgBoxStyle.Exclamation, Text)
            End If
            If Me.ckBorrar.Checked = True Then
                IO.File.Delete(_xml)
            End If
        End If

    End Sub

    Private Function GetFecha() As String
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Return db.Ejecutar("getFecha").Rows(0).Item("FECHA")
    End Function

    Private Function GetConsecutivo(_Mensaje As String) As String
        Dim consecutivo As String = "001" & "00001" & IIf(_Mensaje = "ACEPTADO", "05", "07")
        Return consecutivo
    End Function

    Private Function ClaveExiste(_Clave As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from MensajeReceptor Where Clave = '" & _Clave & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then            
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Guardar_Datos()
        Try
            'delete from MensajeReceptor where Clave not in(select Clave from MensajeReceptor where Clave like '%;%')
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim FechaEmisionDoc As DateTime = Date.Now
            For Each fila As System.Windows.Forms.DataGridViewRow In Me.viewDatosXML.Rows
                If fila.Visible = True Then
                    If Me.ClaveExiste(fila.Cells("cClave").Value) = False Then
                        db.Ejecutar("Insert into MensajeReceptor(Clave,NumeroCedulaEmisor, Proveedor,FechaEmisionDoc,Mensaje,MontoTotalImpuesto,TotalFactura,Estado,DetalleMensaje,CodigoActividad,CondicionImpuesto,MontoTotalImpuestoAcreditar,MontoTotalDeGastoAplicable,Tipo) Values ('" & fila.Cells("cClave").Value & "','" & fila.Cells("cNumeroCedulaEmisor").Value & "', '" & fila.Cells("cNombre").Value & "', Getdate(),'" & fila.Cells("cMensaje").Value & "', " & fila.Cells("cMontoTotalImpuesto").Value & ", " & fila.Cells("cTotalFactura").Value & ",'pendiente', '" & fila.Cells("cDetalleMensaje").Value & "', '" & fila.Cells("cCodigoActividad").Value & "', '" & fila.Cells("cCondicionImpuesto").Value & "', " & fila.Cells("cMontoTotalImpuestoAcreditar").Value & "," & fila.Cells("cMontoTotaldeGastoAplicable").Value & ", '" & fila.Cells("cTipo").Value & "')", Data.CommandType.Text)
                    Else
                        fila.DefaultCellStyle.BackColor = Drawing.Color.Red
                    End If
                End If
            Next
            If ckBorrar.Checked = True Then
                For Each Xml As String In Me.ListaXML
                    IO.File.Delete(Xml)
                Next
            End If
            'Me.GuardarXML()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function CarpetaporDefecto() As String
        Dim Respuesta As String = GetSetting("SeeSOFT", "SeePOS", "CarpetaXML")
        If Respuesta = "" Then
            Me.GuardarCarpetaporDefecto("")
        End If       
        Return Respuesta
    End Function

    Private BanderaCargado As Boolean = False
    Private Sub CargarOpcionesXML()
        Me.BanderaCargado = True
        Dim Informar As String = GetSetting("SeeSOFT", "SeePOS", "InformarXMLDuplicados")
        If Informar = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "InformarXMLDuplicados", "0")
            Informar = "0"
        End If

        Select Case Informar
            Case "1" : Me.ckInformar.Checked = True
            Case "0" : Me.ckInformar.Checked = False
            Case Else : Me.ckInformar.Checked = False
        End Select

        Dim Borrar As String = GetSetting("SeeSOFT", "SeePOS", "BorrarXMLDuplicados")
        If Borrar = "" Then
            SaveSetting("SeeSOFT", "SeePOS", "BorrarXMLDuplicados", "0")
            Borrar = "0"
        End If

        Select Case Borrar
            Case "1" : Me.ckBorrar.Checked = True
            Case "0" : Me.ckBorrar.Checked = False
            Case Else : Me.ckBorrar.Checked = False
        End Select
        Me.BanderaCargado = False
    End Sub

    Private Sub GuardarOpcionesXML()
        If Me.ckInformar.Checked = False Then
            SaveSetting("SeeSOFT", "SeePOS", "InformarXMLDuplicados", "0")
        Else
            SaveSetting("SeeSOFT", "SeePOS", "InformarXMLDuplicados", "1")
        End If

        If Me.ckBorrar.Checked = False Then
            SaveSetting("SeeSOFT", "SeePOS", "BorrarXMLDuplicados", "0")
        Else
            SaveSetting("SeeSOFT", "SeePOS", "BorrarXMLDuplicados", "1")
        End If
    End Sub

    Private Sub GuardarCarpetaporDefecto(Direccion As String)
        SaveSetting("SeeSOFT", "SeePOS", "CarpetaXML", Direccion)
        Me.lblCarpetaXML.Text = "Carpeta con los XML : " & Direccion
    End Sub

    Private Sub ElegirCarpeta()
        Dim Direccion As String = Me.CarpetaporDefecto
        Me.FolderBrowserDialog1.SelectedPath = Direccion
        If Me.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Direccion = Me.FolderBrowserDialog1.SelectedPath
            Me.GuardarCarpetaporDefecto(Direccion)
        End If
    End Sub

    Private Sub CargarCarpetaXML()
        Dim Direccion As String = Me.CarpetaporDefecto
        If IO.Directory.Exists(Direccion) = False Then
            MsgBox("Favor seleccione la carpeta que contiene los xml de las facturas", MsgBoxStyle.Exclamation, Text)
            Exit Sub
        End If
        Me.viewDatosXML.Rows.Clear()
        Me.ListaXML.Clear()
        Me.Index = 0
        For Each xml As String In My.Computer.FileSystem.GetFiles(Direccion)
            If xml.IndexOf(".xml") > 0 Then
                Me.ObtenerDatos(xml)
            End If
        Next
        If Not Me.viewDatosXML.Rows.Count > 0 Then
            MsgBox("No se encontraron archivos xml validos en la carpeta.", MsgBoxStyle.Exclamation, Text)
        End If
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Me.CargarCarpetaXML()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Guardar_Datos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New frmAgregarRespuestaReceptor
        frm.ShowDialog()
    End Sub

    Private Sub viewDatosXML_CellValueChanged(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles viewDatosXML.CellValueChanged
        'On Error Resume Next
        If Me.viewDatosXML.RowCount > 0 Then
            If Me.viewDatosXML.Item("cMensaje", e.RowIndex).Value = "RECHAZADO" Then
                Me.viewDatosXML.Rows(e.RowIndex).Cells("cDetalleMensaje").ReadOnly = False
            Else
                Me.viewDatosXML.Rows(e.RowIndex).Cells("cDetalleMensaje").Value = ""
                Me.viewDatosXML.Rows(e.RowIndex).Cells("cDetalleMensaje").ReadOnly = True
            End If
        End If
    End Sub
    Private PrimeraActividad As String = ""
    Private PrimeraCondicion As String = ""
    Private Sub CargarActividades()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Actividad from actividadEmpresa", dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            If Me.PrimeraActividad = "" Then
                Me.PrimeraActividad = r.Item("Actividad")
            End If
            Me.cCodigoActividad.Items.Add(r.Item("Actividad"))
        Next
    End Sub

    Private Sub CargarCondiciones()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Condicion from CondicionImpuesto", dt, CadenaConexionSeePOS)
        For Each r As DataRow In dt.Rows
            If Me.PrimeraCondicion = "" Then
                Me.PrimeraCondicion = r.Item("Condicion")
            End If
            Me.cCondicionImpuesto.Items.Add(r.Item("Condicion"))
        Next
    End Sub

    Private clsEmisor As New GestionDatos.Emisor
    Public Function getToken() As String
        Try
            Me.clsEmisor.Obtener_Datos()
            Dim iTokenHacienda As New TokenHacienda
            iTokenHacienda.GetTokenHacienda(Me.clsEmisor.usuario, Me.clsEmisor.clave)
            If iTokenHacienda.AccesoConcedido = True Then
                Return iTokenHacienda.accessToken
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub ValidaClaveProveedor()
        Try
            Dim Token As String = getToken()
            Dim pasa As Boolean = True
            If Token <> "" Then
                For Each x As DataGridViewRow In Me.viewDatosXML.Rows
                    Dim enviaComprobante As New Comunicacion
                    If enviaComprobante.ConsultaEstatus(Token, x.Cells("cClave").Value) = True Then
                        If enviaComprobante.estadoFactura <> "aceptado" Then
                            pasa = False
                            Me.btnQuitarRechazados.Enabled = True
                            x.DefaultCellStyle.BackColor = System.Drawing.Color.Red
                        End If
                    End If
                Next
                Me.btnAceptar.Enabled = pasa
            Else
                Me.btnAceptar.Enabled = True
                'MsgBox("No se pudo obtener token", MsgBoxStyle.Critical, Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub frmMensajeReceptor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarActividades()
        Me.CargarCondiciones()
        Me.CargarOpcionesXML()
        Dim Direccion As String = Me.CarpetaporDefecto
        If Direccion <> "" Then
            Me.lblCarpetaXML.Text = "Carpeta con los XML : " & Direccion
        End If
        Me.cboTipo.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnValidarComprobantes.Click
        If Me.viewDatosXML.Rows.Count > 0 Then
            Me.ValidaClaveProveedor()
        End If
    End Sub

    Private Sub btnQuitarRechazados_Click(sender As Object, e As EventArgs) Handles btnQuitarRechazados.Click
        For Each x As DataGridViewRow In Me.viewDatosXML.Rows
            If x.DefaultCellStyle.BackColor = System.Drawing.Color.Red Then
                x.Visible = False
            End If
        Next
        Me.btnAceptar.Enabled = True
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ElegirCarpeta()
    End Sub

    Private Sub ckInformar_CheckedChanged(sender As Object, e As EventArgs) Handles ckInformar.CheckedChanged, ckBorrar.CheckedChanged
        If Me.BanderaCargado = False Then Me.GuardarOpcionesXML()
    End Sub
End Class
