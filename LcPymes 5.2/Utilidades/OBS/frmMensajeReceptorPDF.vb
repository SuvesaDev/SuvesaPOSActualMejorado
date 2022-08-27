Imports System.Data
Imports System.Collections.Generic
Imports System.Xml
Imports System.IO

Public Class frmMensajeReceptorPDF

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

    Private Sub ObtenerDatos(_xml As String)

        Dim xmlEnvia As New Xml.XmlDocument
        Try
            xmlEnvia.LoadXml(Me.LeerArchivo(_xml))
            Me.Clave = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
            Me.NumeroCedulaEmisor = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
            Me.Nombre = xmlEnvia.GetElementsByTagName("Emisor")(0)("Nombre").InnerText
            Me.FechaEmisionDoc = xmlEnvia.GetElementsByTagName("FechaEmision")(0).InnerText
            Me.Mensaje = ""
            Me.TotalFactura = xmlEnvia.GetElementsByTagName("TotalComprobante")(0).InnerText
            Me.NumeroCedulaReceptor = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Numero").InnerText
            Me.NumeroConsecutivoReceptor = ""
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End Try

        Try
            Me.MontoTotalImpuesto = xmlEnvia.GetElementsByTagName("TotalImpuesto")(0).InnerText
        Catch ex As Exception
            Me.MontoTotalImpuesto = 0
        End Try

        If Me.ClaveExiste(Me.Clave) = False Then
            Me.viewDatosXML.Rows.Add()
            Me.viewDatosXML.Item("cClave", Me.Index).Value = Me.Clave
            Me.viewDatosXML.Item("cNumeroCedulaEmisor", Me.Index).Value = Me.NumeroCedulaEmisor
            Me.viewDatosXML.Item("cNombre", Me.Index).Value = Me.Nombre
            Me.viewDatosXML.Item("cMensaje", Me.Index).Value = "ACEPTADO"
            Me.viewDatosXML.Item("cMontoTotalImpuesto", Me.Index).Value = Me.MontoTotalImpuesto
            Me.viewDatosXML.Item("cTotalFactura", Me.Index).Value = Me.TotalFactura
            Me.viewDatosXML.Item("cNumeroCedulaReceptor", Me.Index).Value = Me.NumeroCedulaReceptor
            Me.Index += 1
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
            MsgBox("La Clave '" & _Clave & "' ya esta registrada en el sistema", MsgBoxStyle.Exclamation, Text)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Guardar_Datos()
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        Dim FechaEmisionDoc As DateTime = Date.Now
        For Each fila As System.Windows.Forms.DataGridViewRow In Me.viewDatosXML.Rows
            If Me.ClaveExiste(fila.Cells("cClave").Value) = False Then
                db.Ejecutar("Insert into MensajeReceptor(Clave,NumeroCedulaEmisor,FechaEmisionDoc,Mensaje,MontoTotalImpuesto,TotalFactura,Estado) Values ('" & fila.Cells("cClave").Value & "','" & fila.Cells("cNumeroCedulaEmisor").Value & "', Getdate(),'" & fila.Cells("cMensaje").Value & "', " & fila.Cells("cMontoTotalImpuesto").Value & ", " & fila.Cells("cTotalFactura").Value & ",'pendiente')", Data.CommandType.Text)
            Else
                fila.DefaultCellStyle.BackColor = Drawing.Color.Red
            End If
        Next
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each x As String In Me.OpenFileDialog1.FileNames
                Me.ObtenerDatos(x)
            Next
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Guardar_Datos()
    End Sub

End Class
