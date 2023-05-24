Public Class Entrada
    Dim _idEntrada As Integer
    Dim _unidades As Integer
    Dim _fechaEntrada As String
    Dim _precioEntrada As Double
    Dim _observacionesEntrada As String
    Dim _idProducto As Integer
    Dim _idUsuario As Integer

    Public Sub New()

    End Sub

    Public Sub New(idEntrada As Integer, unidades As Integer, fechaEntrada As String, precioEntrada As Double, observacionesEntrada As String, idProducto As Integer, idUsuario As Integer)
        _idEntrada = idEntrada
        _unidades = unidades
        _fechaEntrada = fechaEntrada
        _precioEntrada = precioEntrada
        _observacionesEntrada = observacionesEntrada
        _idProducto = idProducto
        _idUsuario = idUsuario
    End Sub

    Public Property IdEntrada As Integer
        Get
            Return _idEntrada
        End Get
        Set(value As Integer)
            _idEntrada = value
        End Set
    End Property

    Public Property Unidades As Integer
        Get
            Return _unidades
        End Get
        Set(value As Integer)
            _unidades = value
        End Set
    End Property

    Public Property FechaEntrada As String
        Get
            Return _fechaEntrada

        End Get
        Set(value As String)
            _fechaEntrada = value
        End Set
    End Property

    Public Property PrecioEntrada As Double
        Get
            Return _precioEntrada
        End Get
        Set(value As Double)
            _precioEntrada = value
        End Set
    End Property

    Public Property ObservacionesEntrada As String
        Get
            Return _observacionesEntrada
        End Get
        Set(value As String)
            _observacionesEntrada = value
        End Set
    End Property

    Public Property IdProducto As Integer
        Get
            Return _idProducto
        End Get
        Set(value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property
End Class
