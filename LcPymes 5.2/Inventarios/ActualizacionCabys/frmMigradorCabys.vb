Imports System.Data
Imports System.IO

Public Class frmMigradorCabys
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
        Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
        Try
            Dim xmlEnvia As New Xml.XmlDocument
            xmlEnvia.LoadXml(Me.LeerArchivo(_xml))
            Dim validatexto As String = xmlEnvia.OuterXml
            If validatexto.ToLower.IndexOf("facturaelectronica") > 0 Or validatexto.ToLower.IndexOf("tiqueteelectronico") > 0 Then
                Dim Clave As String = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
                Dim Consecutivo As String = xmlEnvia.GetElementsByTagName("NumeroConsecutivo")(0).InnerText
                Dim CedulaProveedor As String = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
                Dim Proveedor As String = xmlEnvia.GetElementsByTagName("Emisor")(0)("Nombre").InnerText.ToUpper
                Dim Fecha As String = xmlEnvia.GetElementsByTagName("FechaEmision")(0).InnerText
                Dim Cabys, Descripcion As String
                For i As Integer = 0 To xmlEnvia.GetElementsByTagName("LineaDetalle").Count - 1
                    Descripcion = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Detalle").InnerText.ToUpper
                    Cabys = xmlEnvia.GetElementsByTagName("LineaDetalle")(i)("Codigo").InnerText
                    db.Ejecutar("Insert into CabysProveedores(Clave, Consecutivo, Cedula, Proveedor, Descripcion, Cabys) Values ('" & Clave & "','" & Consecutivo & "','" & CedulaProveedor & "','" & Proveedor & "','" & Descripcion & "','" & Cabys & "')", CommandType.Text)
                Next
                db.Commit()
            Else
                db.Rollback()
            End If
        Catch ex As Exception
            db.Rollback()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Direccion As String = FolderBrowserDialog1.SelectedPath
            For Each archivos As String In My.Computer.FileSystem.GetFiles(Direccion, FileIO.SearchOption.SearchAllSubDirectories, "*.xml")
                Me.ObtenerDatos(archivos)
            Next
            Me.Close()
        End If
    End Sub

End Class