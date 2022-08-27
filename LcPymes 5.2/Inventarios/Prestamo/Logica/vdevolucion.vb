Namespace Prestamos
    Public Class vdevolucion

        Dim id, prestamo, codigo, descripcion, cantidad, id_detalle_prestamo As String
        Dim fecha As Date
        Dim anulado As Boolean

        Public Property gid
            Get
                Return id
            End Get
            Set(ByVal value)
                id = value
            End Set
        End Property
        Public Property gprestamo
            Get
                Return prestamo
            End Get
            Set(ByVal value)
                prestamo = value
            End Set
        End Property
        Public Property gcodigo
            Get
                Return codigo
            End Get
            Set(ByVal value)
                codigo = value
            End Set
        End Property
        Public Property gdescripcion
            Get
                Return descripcion
            End Get
            Set(ByVal value)
                descripcion = value
            End Set
        End Property
        Public Property gcantidad
            Get
                Return cantidad
            End Get
            Set(ByVal value)
                cantidad = value
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
        Public Property ganulado
            Get
                Return anulado
            End Get
            Set(ByVal value)
                anulado = value
            End Set
        End Property
        Public Property gdetalleprestamo
            Get
                Return id_detalle_prestamo
            End Get
            Set(ByVal value)
                id_detalle_prestamo = value
            End Set
        End Property
        Public Sub New(ByVal id_detalle_prestamo As String, ByVal id As String, ByVal prestamo As String, ByVal codigo As String, ByVal descripcion As String, ByVal cantidad As String, ByVal fecha As Date, ByVal anulado As Boolean)
            gid = id
            gprestamo = prestamo
            gcodigo = codigo
            gdescripcion = descripcion
            gcantidad = cantidad
            gfecha = fecha
            ganulado = anulado
            gdetalleprestamo = id_detalle_prestamo
        End Sub
        Public Sub New()

        End Sub
    End Class

End Namespace
