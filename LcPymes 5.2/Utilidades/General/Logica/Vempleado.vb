Public Class Vempleado
    Dim cedula, nombre, apellido, telefono, puesto As String
    Dim activo As Boolean
    Dim salario As Double
    Dim fecha_ingreso, fecha_salida As Date
    Public Property gcedula()
        Get
            Return cedula
        End Get
        Set(ByVal value)
            cedula = value
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
    Public Property gapellido()
        Get
            Return apellido
        End Get
        Set(ByVal value)
            apellido = value
        End Set
    End Property
    Public Property gtelefono()
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value
        End Set
    End Property
    Public Property gpuesto()
        Get
            Return puesto
        End Get
        Set(ByVal value)
            puesto = value
        End Set
    End Property
    Public Property gactivo()
        Get
            Return activo
        End Get
        Set(ByVal value)
            activo = value
        End Set
    End Property
    Public Property gsalario()
        Get
            Return salario
        End Get
        Set(ByVal value)
            salario = value
        End Set
    End Property
    Public Property gfecha_ingreso()
        Get
            Return fecha_ingreso
        End Get
        Set(ByVal value)
            fecha_ingreso = value
        End Set
    End Property
    Public Property gfecha_salida()
        Get
            Return fecha_salida
        End Get
        Set(ByVal value)
            fecha_salida = value
        End Set
    End Property
    Public Sub New(ByVal cedula As String, ByVal nombre As String, ByVal apellido As String, ByVal telefono As String, ByVal puesto As String, ByVal activo As Boolean, ByVal salario As Double, ByVal fecha_ingreso As Date, ByVal fecha_salida As Date)
        gcedula = cedula
        gnombre = nombre
        gapellido = apellido
        gpuesto = puesto
        gtelefono = telefono
        gactivo = activo
        gfecha_ingreso = fecha_ingreso
        gfecha_salida = fecha_salida
        gsalario = salario

    End Sub
    Public Sub New()

    End Sub
End Class

