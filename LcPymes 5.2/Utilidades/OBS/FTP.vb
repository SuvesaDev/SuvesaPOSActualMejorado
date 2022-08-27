Imports System.Net.FtpWebRequest
Imports System.Net
Imports System.IO
Imports System.Windows.Forms

Namespace OBSoluciones
    Namespace Utilidades
        Public Class Cliente_FTP

            '**********************************************************************************
            'crear 2 usuarios
            'iris 123
            'web 123
            'el usario iris es para la aplicacion, con full permisos
            'el usuario web es para la pagina web, solo puede ver archivos
            '**********************************************************************************

            Private localhost, Usuario, Clave As String
            Private vRaiz As String = ""

            Public ReadOnly Property Raiz As String
                Get
                    Return vRaiz
                End Get
            End Property

            Public Sub New()
                Me.localhost = "srv169.main-hosting.eu"
                Me.Usuario = "u879264965.fe"
                Me.Clave = "fe2018"
                Me.vRaiz = "ftp://" & localhost
            End Sub

            Public Sub Crear_Carpeta(_direccion As String)
                Dim reqFTP As FtpWebRequest
                Try
                    reqFTP = DirectCast(FtpWebRequest.Create(New Uri(Convert.ToString(Me.vRaiz + "/") & _direccion)), FtpWebRequest)
                    reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory
                    reqFTP.UseBinary = True
                    reqFTP.Credentials = New NetworkCredential(Me.Usuario, Me.Clave)
                    Dim response As FtpWebResponse = DirectCast(reqFTP.GetResponse(), FtpWebResponse)
                    Dim ftpStream As Stream = response.GetResponseStream()
                    ftpStream.Close()
                    response.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Sub

            Public Function Existe(_direccion As String) As Boolean
                Dim directoryExists__1 As Boolean

                Dim request = DirectCast(WebRequest.Create(_direccion), FtpWebRequest)
                request.Method = WebRequestMethods.Ftp.ListDirectory
                request.Credentials = New NetworkCredential(Me.Usuario, Me.Clave)

                Try
                    Using request.GetResponse()
                        directoryExists__1 = True
                    End Using
                Catch generatedExceptionName As WebException
                    directoryExists__1 = False
                End Try

                Return directoryExists__1
            End Function

            Public Sub Subir(_archivo As String, _direccion As String)
                Dim Direccion As String = Me.vRaiz + _direccion
                Dim fileInf As New FileInfo(_archivo)
                Dim uri As String = Direccion + fileInf.Name

                If Me.Existe(Direccion) = False Then Me.Crear_Carpeta(_direccion)
                If Me.Existe(uri) = True Then Me.Eliminar(fileInf.Name, Direccion)

                Dim reqFTP As FtpWebRequest
                reqFTP = DirectCast(FtpWebRequest.Create(New Uri(uri)), FtpWebRequest)
                reqFTP.Credentials = New NetworkCredential(Me.Usuario, Me.Clave)
                reqFTP.KeepAlive = False
                reqFTP.Method = WebRequestMethods.Ftp.UploadFile
                reqFTP.UseBinary = True
                reqFTP.ContentLength = fileInf.Length

                Dim buffLength As Integer = 2048
                Dim buff As Byte() = New Byte(buffLength - 1) {}
                Dim contentLen As Integer
                Dim fs As FileStream = fileInf.OpenRead()

                Try
                    Dim strm As Stream = reqFTP.GetRequestStream()
                    contentLen = fs.Read(buff, 0, buffLength)

                    While contentLen <> 0
                        strm.Write(buff, 0, contentLen)
                        contentLen = fs.Read(buff, 0, buffLength)
                    End While

                    strm.Close()
                    fs.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Upload Error")
                End Try
            End Sub

            Public Sub Eliminar(_archivo As String, _direccion As String)
                Try
                    Dim uri As String = IIf(_direccion.Contains("tp://") = True, _direccion & _archivo, Convert.ToString(Me.vRaiz + _direccion + "/") & _archivo)
                    Dim reqFTP As FtpWebRequest
                    reqFTP = DirectCast(FtpWebRequest.Create(New Uri(uri)), FtpWebRequest)
                    reqFTP.Credentials = New NetworkCredential(Me.Usuario, Me.Clave)
                    reqFTP.KeepAlive = False
                    reqFTP.Method = WebRequestMethods.Ftp.DeleteFile

                    Dim result As String = [String].Empty
                    Dim response As FtpWebResponse = DirectCast(reqFTP.GetResponse(), FtpWebResponse)
                    Dim size As Long = response.ContentLength
                    Dim datastream As Stream = response.GetResponseStream()
                    Dim sr As New StreamReader(datastream)
                    result = sr.ReadToEnd()
                    sr.Close()
                    datastream.Close()
                    response.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "FTP 2.0 Delete")
                End Try
            End Sub

            Public Sub Descargar(_OrigenFTP As String, _DestinoPC As String)
                Dim reqFTP As FtpWebRequest
                Try
                    Dim outputStream As New FileStream(Convert.ToString(_DestinoPC), FileMode.Create)

                    reqFTP = DirectCast(FtpWebRequest.Create(New Uri(Convert.ToString(_OrigenFTP))), FtpWebRequest)
                    reqFTP.Method = WebRequestMethods.Ftp.DownloadFile
                    reqFTP.UseBinary = True
                    reqFTP.Credentials = New NetworkCredential(Me.Usuario, Me.Clave)
                    Dim response As FtpWebResponse = DirectCast(reqFTP.GetResponse(), FtpWebResponse)
                    Dim ftpStream As Stream = response.GetResponseStream()
                    Dim cl As Long = response.ContentLength
                    Dim bufferSize As Integer = 2048
                    Dim readCount As Integer
                    Dim buffer As Byte() = New Byte(bufferSize - 1) {}

                    readCount = ftpStream.Read(buffer, 0, bufferSize)
                    While readCount > 0
                        outputStream.Write(buffer, 0, readCount)
                        readCount = ftpStream.Read(buffer, 0, bufferSize)
                    End While

                    ftpStream.Close()
                    outputStream.Close()
                    response.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Sub

        End Class
    End Namespace
End Namespace
