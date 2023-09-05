'' FirmaElectronicaCR es un programa para la firma y envio de documentos XML para la Factura Electrónica de Costa Rica
''
'' Comunicacion es la clase para el envío del documento XML para la Factura Electrónica de Costa Rica
''
'' Esta clase de Firma fue realizado tomando como base el trabajo realizado por:
'' - Departamento de Nuevas Tecnologías - Dirección General de Urbanismo Ayuntamiento de Cartagena
'' - XAdES Starter Kit desarrollado por Microsoft Francia
'' - Cambios y funcionalidad para Costa Rica - Roy Rojas - royrojas@dotnetcr.com
''
'' La clase comunicación fue creada en conjunto con Cristhian Sancho
''
'' Este programa es software libre: puede redistribuirlo y / o modificarlo
'' bajo los + términos de la Licencia Pública General Reducida de GNU publicada por
'' la Free Software Foundation, ya sea la versión 3 de la licencia, o
'' (a su opción) cualquier versión posterior.

'' Este programa se distribuye con la esperanza de que sea útil,
'' pero SIN NINGUNA GARANTÍA; sin siquiera la garantía implícita de
'' COMERCIABILIDAD O IDONEIDAD PARA UN PROPÓSITO PARTICULAR. Ver el
'' Licencia pública general menor de GNU para más detalles.
''
'' Deberías haber recibido una copia de la Licencia Pública General Reducida de GNU
'' junto con este programa. Si no, vea http://www.gnu.org/licenses/.
''
'' This program Is distributed in the hope that it will be useful,
'' but WITHOUT ANY WARRANTY; without even the implied warranty of
'' MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'' GNU Lesser General Public License for more details.
''
'' You should have received a copy of the GNU Lesser General Public License
'' along with this program.  If Not, see http://www.gnu.org/licenses/. 

Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Net

Public Class Comunicacion

    Public Property xmlRespuesta As Xml.XmlDocument
    Public Property jsonEnvio As String = ""
    Public Property jsonRespuesta As String = ""
    Public Property mensajeRespuesta As String = ""
    Public Property estadoFactura As String = ""
    Public Property statusCode As String = ""
    Public Property MotiviRechazo As String = ""

    Public Function ConsultaEstatus(TK As String, claveConsultar As String) As Boolean
        Try

            'Dim URL_RECEPCION As String = "https://api.comprobanteselectronicos.go.cr/recepcion-sandbox/v1/"
            Dim URL_RECEPCION As String = "https://api.comprobanteselectronicos.go.cr/recepcion/v1/"

            Dim http As HttpClient = New HttpClient

            '*********************************************************************************
            'TLS 1.2 Cambio de seguridad por Hacienda
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 'Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            '*********************************************************************************

            http.DefaultRequestHeaders.Add("authorization", "Bearer " + TK)

            Dim response As HttpResponseMessage = http.GetAsync(URL_RECEPCION & "recepcion/" & claveConsultar).Result
            Dim res As String = response.Content.ReadAsStringAsync.Result

            Dim Localizacion = response.StatusCode


            jsonRespuesta = res.ToString

            Dim RH As RespuestaHacienda = Newtonsoft.Json.JsonConvert.DeserializeObject(Of RespuestaHacienda)(res)

            estadoFactura = RH.ind_estado
            statusCode = response.StatusCode

            If RH.respuesta_xml <> "" Then
                xmlRespuesta = Funciones.DecodeBase64ToXML(RH.respuesta_xml)
            End If

            If estadoFactura = "rechazado" Then
                Try
                    MotiviRechazo = xmlRespuesta.GetElementsByTagName("DetalleMensaje")(0).InnerText
                Catch ex As Exception
                End Try
            Else
                MotiviRechazo = ""
            End If

            mensajeRespuesta = "Confirmación: " & statusCode & vbCrLf
            mensajeRespuesta += "Estado: " & estadoFactura
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class

Public Class Funciones

    Public Shared Function DecodeBase64ToXML(valor As String) As Xml.XmlDocument
        Dim myBase64ret As Byte() = Convert.FromBase64String(valor)
        Dim myStr As String = System.Text.Encoding.UTF8.GetString(myBase64ret)
        Dim xmlDoc As New Xml.XmlDocument()
        xmlDoc.LoadXml(myStr)
        Return xmlDoc
    End Function

    Public Shared Function DecodeBase64ToString(valor As String) As String
        Dim myBase64ret As Byte() = Convert.FromBase64String(valor)
        Dim myStr As String = System.Text.Encoding.UTF8.GetString(myBase64ret)
        Return myStr
    End Function

    Public Shared Function EncodeStrToBase64(valor As String) As String
        Dim myByte As Byte() = System.Text.Encoding.UTF8.GetBytes(valor)
        Dim myBase64 As String = Convert.ToBase64String(myByte)
        Return myBase64
    End Function

End Class