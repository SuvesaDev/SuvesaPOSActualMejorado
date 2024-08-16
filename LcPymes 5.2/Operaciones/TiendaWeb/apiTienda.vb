Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Text
Imports System.Net.Http.Headers
Imports System.Net
Imports System.IO
Imports System.Collections.Generic

Namespace TiendaWeb
    Public Class apiTienda
        Private Usuario As String = ""
        Private Clave As String = ""
        Private url As String = ""
        Sub New()
            Try
                Me.Usuario = GetSetting("SeeSOFT", "Seguridad", "UsuarioApiTienda")
                Me.Clave = GetSetting("SeeSOFT", "Seguridad", "ClaveApiTienda")
            Catch ex As Exception
                SaveSetting("SeeSOFT", "Seguridad", "UsuarioApiTienda", "ck_60c995c24899da765280530086acae76c56997d4")
                SaveSetting("SeeSOFT", "Seguridad", "ClaveApiTienda", "cs_a2f3adcf4899b0cc7259a4c2604f231e9a14d19b")
            End Try

            If Me.Usuario = "" Then
                Me.Usuario = "ck_60c995c24899da765280530086acae76c56997d4"
                Me.Clave = "cs_a2f3adcf4899b0cc7259a4c2604f231e9a14d19b"
                SaveSetting("SeeSOFT", "Seguridad", "UsuarioApiTienda", "ck_60c995c24899da765280530086acae76c56997d4")
                SaveSetting("SeeSOFT", "Seguridad", "ClaveApiTienda", "cs_a2f3adcf4899b0cc7259a4c2604f231e9a14d19b")
            End If
        End Sub
        Public Async Function AllPedidos(Optional ByVal _Pagina As Integer = 1, Optional ByVal _Status As String = "any") As Task(Of System.Collections.Generic.List(Of Pedidos))
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Me.Usuario & ":" & Me.Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado
                Dim url As String = ""
                'https://guanavetcr.com/wp-json/wc/v3/orders?per_page=25&page=1
                Select Case _Status
                    Case "any" : url = "https://guanavetcr.com/wp-json/wc/v3/orders?per_page=25&page=" & _Pagina
                    Case Else : url = "https://guanavetcr.com/wp-json/wc/v3/orders?per_page=25&page=" & _Pagina & "&status=" & _Status
                End Select
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Dim dataStream As Stream = Await response.Content.ReadAsStreamAsync()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim result As String = responseFromServer
                    reader.Close()
                    Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of System.Collections.Generic.List(Of Pedidos))(result)
                Else
                    'MsgBox(response.ReasonPhrase)
                    Return Nothing
                End If
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
        Public Async Function GetPedido(_Id As Integer) As Task(Of Pedidos)
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado
                Dim url As String = "https://guanavetcr.com/wp-json/wc/v3/orders/" & _Id
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Dim dataStream As Stream = Await response.Content.ReadAsStreamAsync()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim result As String = responseFromServer
                    reader.Close()
                    Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of Pedidos)(result)
                Else
                    Return Nothing
                End If
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
        Public Async Function UdatePedido(_Id As Integer, _Estado As String) As Task(Of Boolean)
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado

                Dim payload = "  { ""status"": """ & _Estado & """ }  "
                Dim stringContent As StringContent = New StringContent(payload, Encoding.UTF8, "application/json")

                Dim url As String = "https://guanavetcr.com/wp-json/wc/v3/orders/" & _Id

                Dim response As HttpResponseMessage = Await client.PutAsync(url, stringContent)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception

            End Try
            Return False
        End Function
        Public Async Function UdateProducto(_Id As Integer, _PrecioFinal As Decimal) As Task(Of Boolean)
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado

                Dim payload = "  { ""regular_price"": """ & _PrecioFinal & """,  ""price"": """ & _PrecioFinal & """ }  "
                Dim stringContent As StringContent = New StringContent(payload, Encoding.UTF8, "application/json")

                Dim url As String = "https://guanavetcr.com/wp-json/wc/v3/products/" & _Id

                Dim response As HttpResponseMessage = Await client.PutAsync(url, stringContent)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception

            End Try
            Return False
        End Function
        Public Async Function UdateVariacion(_Id As Integer, _IdVariacion As Integer, _PrecioFinal As Decimal) As Task(Of Boolean)
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado

                Dim payload = "  { ""regular_price"": """ & _PrecioFinal & """,  ""price"": """ & _PrecioFinal & """ }  "
                Dim stringContent As StringContent = New StringContent(payload, Encoding.UTF8, "application/json")

                Dim url As String = "https://guanavetcr.com/wp-json/wc/v3/products/" & _Id & "/variations/" & _IdVariacion

                Dim response As HttpResponseMessage = Await client.PutAsync(url, stringContent)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception

            End Try
            Return False
        End Function
        Public Async Function GetVariacion(_IdProducto As Integer, _IdVariacion As Integer) As Task(Of Variacion)
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado
                Dim url As String = "https://guanavetcr.com/wp-json/wc/v3/products/" & _IdProducto & "/variations/" & _IdVariacion
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Dim dataStream As Stream = Await response.Content.ReadAsStreamAsync()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim result As String = responseFromServer
                    reader.Close()
                    Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of Variacion)(result)
                Else
                    Return Nothing
                End If
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
        Public Async Function GetProducto(_Id As Integer) As Task(Of Products)
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado
                Dim url As String = "https://guanavetcr.com/wp-json/wc/v3/products/" & _Id
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Dim dataStream As Stream = Await response.Content.ReadAsStreamAsync()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim result As String = responseFromServer
                    reader.Close()
                    Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of Products)(result)
                Else
                    Return Nothing
                End If
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
        Public Async Function AllProductos(Optional ByVal _Pagina As Integer = 1, Optional ByVal _Tipo As String = "Todos") As Task(Of System.Collections.Generic.List(Of Products))
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado
                Dim url As String = ""
                Select Case _Tipo
                    Case "simple" : url = "https://guanavetcr.com/wp-json/wc/v3/products?type=simple&per_page=25&page=" & _Pagina
                    Case "variable" : url = "https://guanavetcr.com/wp-json/wc/v3/products?type=variable&per_page=25&page=" & _Pagina
                    Case Else : url = "https://guanavetcr.com/wp-json/wc/v3/products?per_page=25&page=" & _Pagina
                End Select
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Dim dataStream As Stream = Await response.Content.ReadAsStreamAsync()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim result As String = responseFromServer
                    reader.Close()
                    Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of System.Collections.Generic.List(Of Products))(result)
                Else
                    Return Nothing
                End If
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
        Public Async Function GetProductosDescripcion(_Descripccion As String) As Task(Of System.Collections.Generic.List(Of Products))
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado
                Dim response As HttpResponseMessage = Await client.GetAsync("https://guanavetcr.com/wp-json/wc/v3/products?search=" & _Descripccion)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Dim dataStream As Stream = Await response.Content.ReadAsStreamAsync()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim result As String = responseFromServer
                    reader.Close()
                    Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of System.Collections.Generic.List(Of Products))(result)
                Else
                    Return Nothing
                End If
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
        Public Async Function GetProductosSku(_Sku As String) As Task(Of System.Collections.Generic.List(Of Products))
            Try
                ' Crear una instancia de HttpClient
                Dim client As New HttpClient
                ' Agregar las credenciales de autenticación básica a la cabecera Authorization del cliente
                Dim authenticationString As String = "" & Usuario & ":" & Clave & ""
                Dim base64EncodedAuthenticationString As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString))
                client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString)
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                ' Realizar una solicitud GET al recurso deseado
                Dim response As HttpResponseMessage = Await client.GetAsync("https://guanavetcr.com/wp-json/wc/v3/products?sku=" & _Sku)

                ' Procesar la respuesta
                If response.IsSuccessStatusCode Then
                    Dim dataStream As Stream = Await response.Content.ReadAsStreamAsync()
                    Dim reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()
                    Dim result As String = responseFromServer
                    reader.Close()
                    Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of System.Collections.Generic.List(Of Products))(result)
                Else
                    Return Nothing
                End If
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
    End Class

    Public Class Products
        Public Property id As Integer
        Public Property name As String
        'Public Property slug As String
        'Public Property permalink As String
        'Public Property date_created As DateTime
        'Public Property date_created_gmt As DateTime
        Public Property date_modified As DateTime
        'Public Property date_modified_gmt As DateTime
        Public Property type As String
        Public Property status As String
        'Public Property featured As Boolean
        'Public Property catalog_visibility As String
        'Public Property description As String
        'Public Property short_description As String
        Public Property sku As String

        Private vCodigo As Long = 0
        Private vCosto As Decimal = 0
        Private vPrecio As Decimal = 0
        Private vPrecioUnit As Decimal = 0
        Private vUtilidad As Decimal = 0
        Private vImpuesto As Decimal = 0
        Private vBaseDatos As String = ""

        Public Sub Calcular()
            Try
                Me.vCodigo = 0
                Me.vCosto = 0
                If sku <> "" Then
                    Dim dt As New System.Data.DataTable
                    Dim strSql As String = ""
                    If sku.Contains("-") = True Then
                        Me.vBaseDatos = "seepos"
                        If sku.Substring(sku.Length - 1, 1) = "-" Then
                            strSql = "Select top 1 Codigo, isnull(SeePos.dbo.precio_finalEcommer(Codigo),0) as CostoTienda, Costo, IVenta from SeePos.dbo.Inventario where Cod_Articulo = '" & sku.Replace("-", "") & "' "
                            sku = sku.Replace("-", "")
                        Else
                            strSql = "Select top 1 Codigo, isnull(SeePos.dbo.precio_finalEcommer(Codigo),0) as CostoTienda, Costo, IVenta from SeePos.dbo.Inventario where Cod_Articulo = '" & sku.Replace("-", ".") & "' "
                        End If
                    Else
                        Me.vBaseDatos = "clinica"
                        sku = sku.Replace("_", " ")
                        sku = sku.Replace(".", "")
                        sku = sku.Replace(" ", "")
                        sku = sku.Replace("-", ".")

                        strSql = "Select top 1 Codigo, isnull(dbo.precio_finalEcommer(Codigo),0) as CostoTienda, Costo, IVenta from dbo.Inventario where Cod_Articulo = '" & sku & "' "
                    End If

                    sku = sku.Replace("_", " ")
                    sku = sku.Replace(".", "")
                    sku = sku.Replace(" ", "")
                    sku = sku.Replace("-", ".")

                    cFunciones.Llenar_Tabla_Generico(strSql, dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.vCodigo = dt.Rows(0).Item("Codigo")
                        Me.vCosto = dt.Rows(0).Item("CostoTienda")
                        If IsNumeric(price) Then
                            Me.vPrecio = CDec(Me.price)
                            Me.vImpuesto = dt.Rows(0).Item("IVenta")
                            Me.vPrecioUnit = Me.vPrecio / (1 + (Me.vImpuesto / 100))
                            Me.vUtilidad = (((Me.vPrecioUnit / Me.vCosto) - 1) * 100)
                        Else
                            Me.vCosto = 0
                            Me.vPrecio = 0
                            Me.vImpuesto = 0
                            Me.vPrecioUnit = 0
                            Me.vUtilidad = 0
                        End If
                    Else
                        Me.vCodigo = 0
                        Me.vCosto = 0
                        If IsNumeric(price) Then
                            Me.vPrecio = CDec(Me.price)
                        Else
                            Me.vPrecio = 0
                        End If
                        Me.vImpuesto = 0
                        Me.vPrecioUnit = 0
                        Me.vUtilidad = 0
                    End If
                Else
                    Me.vBaseDatos = ""
                    Me.vCodigo = 0
                    Me.vCosto = 0
                    If IsNumeric(price) Then
                        Me.vPrecio = CDec(Me.price)
                    Else
                        Me.vPrecio = 0
                    End If
                    Me.vImpuesto = 0
                    Me.vPrecioUnit = 0
                    Me.vUtilidad = 0
                End If
            Catch ex As Exception
            End Try
        End Sub

        Public ReadOnly Property Costo As Decimal
            Get
                Return vCosto
            End Get
        End Property
        Public Property price As String

        Public ReadOnly Property Precio As Decimal
            Get
                Return Me.vPrecio
            End Get
        End Property
        Public ReadOnly Property PrecioUnit As Decimal
            Get
                Return Me.vPrecioUnit
            End Get
        End Property
        Public ReadOnly Property Impuesto As Decimal
            Get
                Return Me.vImpuesto
            End Get
        End Property
        Public ReadOnly Property Utilidad As Decimal
            Get
                Return Me.vUtilidad
            End Get
        End Property
        Public ReadOnly Property Codigo As Decimal
            Get
                Return Me.vCodigo
            End Get
        End Property

        Public ReadOnly Property BaseDatos As String
            Get
                Return Me.vBaseDatos
            End Get
        End Property

        'Public Property regular_price As String
        'Public Property sale_price As String
        'Public Property date_on_sale_from As Object
        'Public Property date_on_sale_from_gmt As Object
        'Public Property date_on_sale_to As Object
        'Public Property date_on_sale_to_gmt As Object
        'Public Property on_sale As Boolean
        'Public Property purchasable As Boolean
        'Public Property total_sales As String
        'Public Property virtual As Boolean
        'Public Property downloadable As Boolean
        'Public Property downloads As Object()
        'Public Property download_limit As Integer
        'Public Property download_expiry As Integer
        'Public Property external_url As String
        'Public Property button_text As String
        Public Property tax_status As String
        'Public Property tax_class As String
        'Public Property manage_stock As Boolean
        'Public Property stock_quantity As Object
        'Public Property backorders As String
        'Public Property backorders_allowed As Boolean
        'Public Property backordered As Boolean
        'Public Property low_stock_amount As Object
        'Public Property sold_individually As Boolean
        'Public Property weight As String
        'Public Property shipping_required As Boolean
        'Public Property shipping_taxable As Boolean
        'Public Property shipping_class As String
        'Public Property shipping_class_id As Integer
        'Public Property reviews_allowed As Boolean
        'Public Property average_rating As String
        'Public Property rating_count As Integer
        'Public Property upsell_ids As Object()
        'Public Property cross_sell_ids As Object()
        'Public Property parent_id As Integer
        'Public Property purchase_note As String
        'Public Property categories As Object()
        'Public Property tags As Object()
        'Public Property default_attributes As Object()
        Public Property variations As System.Collections.Generic.List(Of String)
        'Public Property grouped_products As Object()
        'Public Property menu_order As Integer
        'Public Property price_html As String
        'Public Property related_ids As System.Collections.Generic.List(Of String)
        'Public Property meta_data As Object()
        'Public Property stock_status As String
        'Public Property has_options As Boolean
        'Public Property post_password As String
    End Class
    Public Class Variacion
        Public Property id As Integer
        Public Property name As String
        'Public Property date_created As DateTime
        'Public Property date_created_gmt As DateTime
        Public Property date_modified As DateTime
        'Public Property date_modified_gmt As DateTime
        'Public Property description As String
        'Public Property permalink As String
        Public Property sku As String

        Private vCosto As Decimal = 0
        Private vPrecio As Decimal = 0
        Private vPrecioUnit As Decimal = 0
        Private vUtilidad As Decimal = 0
        Private vImpuesto As Decimal = 0
        Private vCodigo As Integer = 0
        Private vBaseDatos As String = ""

        Public Sub Calcular()
            Try
                Me.vCodigo = 0
                If sku <> "" Then
                    Dim dt As New System.Data.DataTable
                    Dim strSql As String = ""
                    If sku.Contains("-") = True Then
                        Me.vBaseDatos = "seepos"
                        If sku.Substring(sku.Length - 1, 1) = "-" Then
                            strSql = "Select top 1 Codigo, isnull(SeePos.dbo.precio_finalEcommer(Codigo),0) as CostoTienda, Costo, IVenta from SeePos.dbo.Inventario where Cod_Articulo = '" & sku.Replace("-", "") & "' "
                            sku = sku.Replace("-", "")
                        Else
                            strSql = "Select top 1 Codigo, isnull(SeePos.dbo.precio_finalEcommer(Codigo),0) as CostoTienda, Costo, IVenta from SeePos.dbo.Inventario where Cod_Articulo = '" & sku.Replace("-", ".") & "' "
                        End If
                    Else
                        Me.vBaseDatos = "clinica"
                        sku = sku.Replace("_", " ")
                        sku = sku.Replace(".", "")
                        sku = sku.Replace(" ", "")
                        sku = sku.Replace("-", ".")

                        strSql = "Select top 1 Codigo, isnull(dbo.precio_finalEcommer(Codigo),0) as CostoTienda, Costo, IVenta from dbo.Inventario where Cod_Articulo = '" & sku & "' "
                    End If

                    sku = sku.Replace("_", " ")
                    sku = sku.Replace(".", "")
                    sku = sku.Replace(" ", "")
                    sku = sku.Replace("-", ".")

                    cFunciones.Llenar_Tabla_Generico(strSql, dt, CadenaConexionSeePOS)
                    If dt.Rows.Count > 0 Then
                        Me.vCodigo = dt.Rows(0).Item("Codigo")
                        vCosto = dt.Rows(0).Item("CostoTienda")
                        If IsNumeric(price) Then
                            Me.vPrecio = CDec(Me.price)
                            Me.vImpuesto = dt.Rows(0).Item("IVenta")
                            Me.vPrecioUnit = Me.vPrecio / (1 + (Me.vImpuesto / 100))
                            Me.vUtilidad = (((Me.vPrecioUnit / Me.vCosto) - 1) * 100)
                        Else
                            Me.vCosto = 0
                            Me.vPrecio = 0
                            Me.vImpuesto = 0
                            Me.vPrecioUnit = 0
                            Me.vUtilidad = 0
                        End If
                    Else
                        Me.vCosto = 0
                        If IsNumeric(price) Then
                            Me.vPrecio = CDec(Me.price)
                        Else
                            Me.vPrecio = 0
                        End If
                        Me.vImpuesto = 0
                        Me.vPrecioUnit = 0
                        Me.vUtilidad = 0
                    End If
                Else
                    Me.vBaseDatos = ""
                    Me.vCosto = 0
                    If IsNumeric(price) Then
                        Me.vPrecio = CDec(Me.price)
                    Else
                        Me.vPrecio = 0
                    End If
                    Me.vImpuesto = 0
                    Me.vPrecioUnit = 0
                    Me.vUtilidad = 0
                End If
            Catch ex As Exception
            End Try
        End Sub

        Public ReadOnly Property Costo As Decimal
            Get
                Return vCosto
            End Get
        End Property
        Public Property price As String

        Public ReadOnly Property Precio As Decimal
            Get
                Return Me.vPrecio
            End Get
        End Property
        Public ReadOnly Property PrecioUnit As Decimal
            Get
                Return Me.vPrecioUnit
            End Get
        End Property
        Public ReadOnly Property Impuesto As Decimal
            Get
                Return Me.vImpuesto
            End Get
        End Property
        Public ReadOnly Property Utilidad As Decimal
            Get
                Return Me.vUtilidad
            End Get
        End Property
        Public ReadOnly Property Codigo As Decimal
            Get
                Return Me.vCodigo
            End Get
        End Property

        Public ReadOnly Property BaseDatos As String
            Get
                Return Me.vBaseDatos
            End Get
        End Property
        'Public Property regular_price As String
        'Public Property sale_price As String
        'Public Property date_on_sale_from As Object
        'Public Property date_on_sale_from_gmt As Object
        'Public Property date_on_sale_to As Object
        'Public Property date_on_sale_to_gmt As Object
        'Public Property on_sale As Boolean
        Public Property status As String
        'Public Property purchasable As Boolean
        'Public Property virtual As Boolean
        'Public Property downloadable As Boolean
        'Public Property downloads As Object()
        'Public Property download_limit As Integer
        'Public Property download_expiry As Integer
        'Public Property tax_status As String
        'Public Property tax_class As String
        'Public Property manage_stock As Boolean
        'Public Property stock_quantity As Object
        'Public Property stock_status As String
        'Public Property backorders As String
        'Public Property backorders_allowed As Boolean
        'Public Property backordered As Boolean
        'Public Property low_stock_amount As Object
        'Public Property weight As String
        'Public Property dimensions As Dimensions
        'Public Property shipping_class As String
        'Public Property shipping_class_id As Integer
        'Public Property image As Image
        'Public Property attributes As Attribute()
        'Public Property menu_order As Integer
        'Public Property meta_data As Object()
        'Public Property parent_id As Integer
        'Public Property _links As Links
    End Class
    Public Class Billing
        Public Property first_name As String
        Public Property last_name As String
        Public Property company As String
        Public Property address_1 As String
        Public Property address_2 As String
        Public Property city As String
        Public Property state As String
        Public Property postcode As String
        Public Property country As String
        Public Property email As String
        Public Property phone As String
    End Class
    Public Class Shipping
        Public Property first_name As String
        Public Property last_name As String
        Public Property company As String
        Public Property address_1 As String
        Public Property address_2 As String
        Public Property city As String
        Public Property state As String
        Public Property postcode As String
        Public Property country As String
        Public Property phone As String
    End Class
    Public Class Tax
        Public Property id As Integer
        Public Property total As String
        Public Property subtotal As String
    End Class
    Public Class LineItem
        Public Property id As Integer
        Public Property name As String
        Public Property product_id As Integer
        Public Property variation_id As Integer
        Public Property quantity As Integer
        Public Property tax_class As String
        Public Property subtotal As String
        Public Property subtotal_tax As String
        Public Property total As String
        Public Property total_tax As String
        Public Property taxes As Tax()
        Public Property meta_data As Object()
        Public Property sku As String
        Public Property price As Double
        Public Property parent_name As Object
    End Class
    Public Class TaxLine
        Public Property id As Integer
        Public Property rate_code As String
        Public Property rate_id As Integer
        Public Property label As String
        Public Property compound As Boolean
        Public Property tax_total As String
        Public Property shipping_tax_total As String
        Public Property rate_percent As Integer
        Public Property meta_data As Object()
    End Class
    Public Class ShippingLine
        Public Property id As Integer
        Public Property method_title As String
        Public Property method_id As String
        Public Property instance_id As String
        Public Property total As String
        Public Property total_tax As String
        Public Property taxes As Object()
    End Class
    Public Class Pedidos
        Public Property id As Integer
        Public Property parent_id As Integer
        Public Property status As String
        Public Property currency As String
        Public Property version As String
        Public Property prices_include_tax As Boolean
        Public Property date_created As DateTime
        Public Property date_modified As DateTime
        Public Property discount_total As String
        Public Property discount_tax As String
        Public Property shipping_total As String
        Public Property shipping_tax As String
        Public Property cart_tax As String
        Public Property total As String
        Public Property total_tax As String
        Public Property customer_id As Integer
        Public Property order_key As String
        Public Property billing As Billing
        Public Property shipping As Shipping
        Public Property payment_method As String
        Public Property payment_method_title As String
        Public Property transaction_id As String
        Public Property customer_ip_address As String
        Public Property customer_user_agent As String
        Public Property created_via As String
        Public Property customer_note As String
        Public Property date_completed As String
        Public Property date_paid As String
        Public Property cart_hash As String
        Public Property number As String
        Public Property line_items As LineItem()
        Public Property tax_lines As TaxLine()
        Public Property shipping_lines As ShippingLine()
        'Public Property fee_lines As Object()
        'Public Property coupon_lines As Object()
        'Public Property refunds As Object()
        Public Property payment_url As String
        Public Property is_editable As Boolean
        Public Property needs_payment As Boolean
        Public Property needs_processing As Boolean
        Public Property date_created_gmt As String
        Public Property date_modified_gmt As String
        Public Property date_completed_gmt As String
        Public Property date_paid_gmt As String
        Public Property currency_symbol As String
    End Class
End Namespace

