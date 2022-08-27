Namespace Prestamos
    Public Class vprestamo
        Dim id, boleta, destinatario, nombre_destinatario, destino, nombre_destino, transportista, observacion, Id_UsuariCreo As String
        Dim anulado, estado, entrada, salida As Boolean
        Dim fecha As Date

        Public Property gid
            Get
                Return id
            End Get
            Set(ByVal value)
                id = value
            End Set
        End Property
        Public Property gboleta
            Get
                Return boleta
            End Get
            Set(ByVal value)
                boleta = value
            End Set
        End Property
        Public Property gdestino
            Get
                Return destino
            End Get
            Set(ByVal value)
                destino = value
            End Set
        End Property
        Public Property gdestinatario
            Get
                Return destinatario
            End Get
            Set(ByVal value)
                destinatario = value
            End Set
        End Property
        Public Property gtransportista
            Get
                Return transportista
            End Get
            Set(ByVal value)
                transportista = value
            End Set
        End Property
        Public Property gfecha
            Get
                Return fecha
            End Get
            Set(ByVal value)
                fecha = value
            End Set
        End Property
        Public Property gestado
            Get
                Return estado
            End Get
            Set(ByVal value)
                estado = value
            End Set
        End Property
        Public Property ganulado
            Get
                Return anulado
            End Get
            Set(ByVal value)
                anulado = value
            End Set
        End Property
        Public Property gentrada
            Get
                Return entrada
            End Get
            Set(ByVal value)
                entrada = value
            End Set
        End Property
        Public Property gsalida
            Get
                Return salida
            End Get
            Set(ByVal value)
                salida = value
            End Set
        End Property
        Public Property gobservacion
            Get
                Return observacion
            End Get
            Set(ByVal value)
                observacion = value
            End Set
        End Property
        Public Property gId_UsuariCreo
            Get
                Return Id_UsuariCreo
            End Get
            Set(ByVal value)
                Id_UsuariCreo = value
            End Set
        End Property
        Public Property gnombre_destinatario
            Get
                Return nombre_destinatario
            End Get
            Set(ByVal value)
                nombre_destinatario = value
            End Set
        End Property
        Public Property gnombre_destino
            Get
                Return nombre_destino
            End Get
            Set(ByVal value)
                nombre_destino = value
            End Set
        End Property
        Public Sub New(ByVal nombre_destino As String, ByVal nombre_destinatario As String, ByVal id As String, ByVal boleta As String, ByVal destinatario As String, ByVal destino As String, ByVal transportista As String, ByVal observacion As String,
        ByVal anulado As Boolean, ByVal estado As Boolean, ByVal entrada As Boolean, ByVal salida As Boolean, ByVal fecha As Date, _Id_UsuariCreo As String)
            gid = id
            gboleta = boleta
            gdestino = destino
            gdestinatario = destinatario
            gtransportista = transportista
            gobservacion = observacion
            ganulado = anulado
            gestado = estado
            gentrada = entrada
            gsalida = salida
            gfecha = fecha
            gnombre_destinatario = nombre_destinatario
            gnombre_destino = nombre_destino
            gId_UsuariCreo = _Id_UsuariCreo
        End Sub
        Public Sub New()

        End Sub
    End Class
End Namespace
