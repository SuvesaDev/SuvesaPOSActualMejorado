Public Class Vaccion
    Dim id, id_empleado, id_categoria, nombre, observacion As String
    Dim anulado As Boolean
    Dim fecha_inicio, fecha_fin As Date

    Public Property gid()
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
        End Set
    End Property
    Public Property gid_empleado()
        Get
            Return id_empleado
        End Get
        Set(ByVal value)
            id_empleado = value
        End Set
    End Property
    Public Property gid_categoria()
        Get
            Return id_categoria
        End Get
        Set(ByVal value)
            id_categoria = value
        End Set
    End Property
    Public Property gnombre()
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
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
    Public Property gfecha_inicio()
        Get
            Return fecha_inicio
        End Get
        Set(ByVal value)
            fecha_inicio = value
        End Set
    End Property
    Public Property gfecha_fin()
        Get
            Return fecha_fin
        End Get
        Set(ByVal value)
            fecha_fin = value
        End Set
    End Property
    Public Sub New(ByVal id As String, ByVal id_empleado As String, ByVal nombre As String, ByVal id_categoria As String, ByVal observacion As String, ByVal anulado As Boolean, ByVal fecha_inicio As Date, ByVal fecha_fin As Date)

        gid = id
        gid_empleado = nombre
        gid_categoria = id_categoria
        gnombre = nombre
        gobservacion = observacion
        ganulado = anulado
        gfecha_inicio = fecha_inicio
        gfecha_fin = fecha_fin

    End Sub
    Public Sub New()

    End Sub
End Class
