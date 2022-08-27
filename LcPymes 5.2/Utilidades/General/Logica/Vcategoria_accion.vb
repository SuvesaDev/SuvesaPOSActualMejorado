Public Class Vcategoria_accion
    Dim id, nombre As String

    Public Property gid()
        Get
            Return id
        End Get
        Set(ByVal value)
            id = value
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

    Public Sub New(ByVal id As String, ByVal nombre As String)
        gid = id
        gnombre = nombre
    End Sub
    Public Sub New()

    End Sub
End Class
