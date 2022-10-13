Imports System.Collections.Generic
Imports System.Net
Imports System.IO

Namespace api.Hacienda
    Public Module General

        Public Function ConsultaExoneracion(_NumExoneracion As String) As Exoneracion

            '*********************************************************************************
            'TLS 1.2 Cambio de seguridad por Hacienda
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            '*********************************************************************************

            Dim URL As String = "https://api.hacienda.go.cr/fe/ex?autorizacion=" & _NumExoneracion
            Dim requestUrl As String = URL
            Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim result = responseFromServer
            reader.Close()
            response.Close()
            Dim ThisToken As Exoneracion = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Exoneracion)(result)
            Return ThisToken
        End Function

        Public Function EstaRegistradoMAG(_Cedula As String) As MAG

            '*********************************************************************************
            'TLS 1.2 Cambio de seguridad por Hacienda
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            '*********************************************************************************

            Dim URL As String = "https://api.hacienda.go.cr/fe/agropecuario?identificacion=" & _Cedula
            Dim requestUrl As String = URL
            Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim result = responseFromServer
            reader.Close()
            response.Close()
            Dim ThisToken As MAG = Newtonsoft.Json.JsonConvert.DeserializeObject(Of MAG)(result)
            Return ThisToken
        End Function

        Public Function Consultar_x_Cedula(_Cedula As String) As Entidad

            '*********************************************************************************
            'TLS 1.2 Cambio de seguridad por Hacienda
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            '*********************************************************************************

            Dim URL As String = "https://api.hacienda.go.cr/fe/ae?identificacion=" & _Cedula
            Dim requestUrl As String = URL
            Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim result = responseFromServer
            reader.Close()
            response.Close()
            Dim ThisToken As Entidad = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Entidad)(result)
            Return ThisToken
        End Function
        Public Function ConsultarCabys_x_Descripcion(_Descripcion As String) As CodCabys
            '*********************************************************************************
            'TLS 1.2 Cambio de seguridad por Hacienda
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            '*********************************************************************************
            Dim URL As String = "https://api.hacienda.go.cr/fe/cabys?q=" & _Descripcion
            Dim requestUrl As String = URL
            Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim result = responseFromServer
            reader.Close()
            response.Close()
            Dim ThisToken As CodCabys = Newtonsoft.Json.JsonConvert.DeserializeObject(Of CodCabys)(result)
            Return ThisToken
        End Function
        Public Function ConsultarCabys_x_Codigo(_Codigo As String) As Caby
            '*********************************************************************************
            'TLS 1.2 Cambio de seguridad por Hacienda
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            '*********************************************************************************
            Dim URL As String = "https://api.hacienda.go.cr/fe/cabys?codigo=" & _Codigo
            Dim requestUrl As String = URL
            Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim result = responseFromServer
            reader.Close()
            response.Close()
            Dim ThisToken As Caby = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Caby)(result)
            Return ThisToken
        End Function
        Public Function ConsultarTipoCambioDolar() As TipoCambioDolar
            '*********************************************************************************
            'TLS 1.2 Cambio de seguridad por Hacienda
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
            '*********************************************************************************
            Dim URL As String = "https://api.hacienda.go.cr/indicadores/tc/dolar"
            Dim requestUrl As String = URL
            Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            Dim dataStream As Stream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Dim result = responseFromServer
            reader.Close()
            response.Close()
            Dim ThisToken As TipoCambioDolar = Newtonsoft.Json.JsonConvert.DeserializeObject(Of TipoCambioDolar)(result)
            Return ThisToken
        End Function
    End Module
    '****************************************************************************************************************
    'Consulta Tipo de Cambio
    '****************************************************************************************************************
    Public Class Venta
        Public Property fecha As String
        Public Property valor As Double
    End Class

    Public Class Compra
        Public Property fecha As String
        Public Property valor As Double
    End Class

    Public Class TipoCambioDolar
        Public Property venta As Venta
        Public Property compra As Compra
    End Class
    '****************************************************************************************************************
    'Consulta Codigo Cabys
    '****************************************************************************************************************
    Public Class Caby
        Public ReadOnly Property ListaCategorias
            Get
                Dim Respuesta As String = ""
                For Each texto As String In Me.categorias
                    Respuesta += texto & vbNewLine
                Next
                Return Respuesta
            End Get
        End Property
        Public Property codigo As String
        Public Property descripcion As String
        Public Property categorias As String()
        Public Property impuesto As Integer
        Public Property uri As String
    End Class
    Public Class CodCabys
        Public Property total As Integer
        Public Property cantidad As Integer
        Public Property cabys As Caby()
    End Class
    '****************************************************************************************************************
    'Consulta Cedula
    '****************************************************************************************************************
    Public Class Actividade
        Public Property estado As String
        Public Property codigo As Integer
        Public Property descripcion As String
    End Class

    Public Class Entidad
        Public Property nombre As String
        Public Property tipoIdentificacion As String
        Public Property actividades As List(Of Actividade)
        Public Property situacion As Situacion
    End Class

    '****************************************************************************************************************
    'Consulta Registro en el MAG
    '****************************************************************************************************************
    Public Class ListaDatosMAG
        Public Property indicadorActivoMAG As Boolean
        Public Property fechaBajaMAG As String
        Public Property estadoMAG As String
        Public Property fechaAltaMAG As String
    End Class

    Public Class Regimen
        Public Property codigo As Integer
        Public Property descripcion As String
    End Class

    Public Class Situacion
        Public Property moroso As String
        Public Property omiso As String
        Public Property estado As String
        Public Property administracionTributaria As String
    End Class

    Public Class SituacionTributaria
        Public Property nombre As String
        Public Property tipoIdentificacion As String
        Public Property regimen As Regimen
        Public Property situacion As Situacion
        Public Property actividades As Actividade()
    End Class

    Public Class MAG
        Public Property listaDatosMAG As ListaDatosMAG()
        Public Property situacionTributaria As SituacionTributaria
    End Class

    '****************************************************************************************************************
    'Consulta Exoneraciones Exonet
    '****************************************************************************************************************
    Public Class TipoDocumento
        Public Property codigo As String
        Public Property descripcion As String
    End Class
    Public Class Exoneracion
        Public Property numeroDocumento As String
        Public Property identificacion As String
        Public Property fechaEmision As DateTime
        Public Property fechaVencimiento As DateTime
        Public Property porcentajeExoneracion As Object
        Public Property tipoDocumento As TipoDocumento
        Public Property nombreInstitucion As String
    End Class
    '****************************************************************************************************************

End Namespace

