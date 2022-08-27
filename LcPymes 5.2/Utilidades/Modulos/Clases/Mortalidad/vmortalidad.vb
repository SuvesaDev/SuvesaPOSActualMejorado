Public Class vmortalidad
    Dim id, codigo, descripcion, cantidad, observacion As String
    Dim anulado As Boolean
    Dim fecha As Date

    Public Property gid()
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
        End Set
    End Property
    Public Property gcodigo()
        Get
            Return codigo
        End Get
        Set(ByVal value)
            codigo = value
        End Set
    End Property
    Public Property gdescripcion()
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property
    Public Property gcantidad()
        Get
            Return cantidad
        End Get
        Set(ByVal value)
            cantidad = value
        End Set
    End Property
    Public Property gobservacion()
        Get
            Return observacion
        End Get
        Set(ByVal value)
            observacion = value
        End Set
    End Property
    Public Property ganulado()
        Get
            Return anulado
        End Get
        Set(ByVal value)
            anulado = value
        End Set
    End Property
    Public Property gfecha()
        Get
            Return fecha
        End Get
        Set(ByVal value)
            fecha = value
        End Set
    End Property
    Public Sub New(ByVal id As String, ByVal codigo As String, ByVal descripcion As String, ByVal cantidad As String, ByVal observacion As String, ByVal anulado As Boolean, ByVal fecha As Date)
        gid = id
        gcodigo = codigo
        gdescripcion = descripcion
        gcantidad = cantidad
        gobservacion = observacion
        ganulado = anulado
        gfecha = fecha
    End Sub
    Public Sub New()

    End Sub
End Class
