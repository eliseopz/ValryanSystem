Public Class Usuarios
    'Atributos'
    Dim _idUsuario As Integer
    Dim _passwordUsuario As String
    Dim _primerNomUsuario As String
    Dim _segundoNomUsuario As String
    Dim _primerApeUsuario As String
    Dim _segundoApeUsuario As String
    Dim _fechaNacimiento As String
    Dim _telefonoUsuario As String
    Dim _cedula As String
    Dim _rol As Boolean
    Dim _sexo As Boolean


    'Constructor Vacio'
    Public Sub New()

    End Sub

    'Constructor'
    Public Sub New(idUsuario As Integer, passwordUsuario As String, primerNomUsuario As String, segundoNomUsuario As String, primerApeUsuario As String, segundoApeUsuario As String, fechaNacimiento As String, telefonoUsuario As String, cedula As String, rol As Boolean, sexo As Boolean)
        _idUsuario = idUsuario
        _passwordUsuario = passwordUsuario
        _primerNomUsuario = primerNomUsuario
        _segundoNomUsuario = segundoNomUsuario
        _primerApeUsuario = primerApeUsuario
        _segundoApeUsuario = segundoApeUsuario
        _fechaNacimiento = fechaNacimiento
        _telefonoUsuario = telefonoUsuario
        _cedula = cedula
        _rol = rol
        _sexo = sexo
    End Sub

    'Propiedades'
    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value

        End Set
    End Property

    Public Property PasswordUsuario As String
        Get
            Return _passwordUsuario
        End Get
        Set(value As String)
            _passwordUsuario = value
        End Set
    End Property

    Public Property PrimerNomUsuario As String
        Get
            Return _primerNomUsuario
        End Get
        Set(value As String)
            _primerNomUsuario = value
        End Set
    End Property

    Public Property SegundoNomUsuario As String
        Get
            Return _segundoNomUsuario
        End Get
        Set(value As String)
            _segundoNomUsuario = value
        End Set
    End Property

    Public Property PrimerApeUsuario As String
        Get
            Return _primerApeUsuario
        End Get
        Set(value As String)
            _primerApeUsuario = value

        End Set
    End Property

    Public Property SegundoApeUsuario As String
        Get
            Return _segundoApeUsuario
        End Get
        Set(value As String)
            _segundoApeUsuario = value
        End Set
    End Property

    Public Property FechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set(value As String)
            _fechaNacimiento = value

        End Set
    End Property

    Public Property TelefonoUsuario As String
        Get
            Return _telefonoUsuario
        End Get
        Set(value As String)
            _telefonoUsuario = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property Rol As Boolean

        Get
            Return _rol
        End Get
        Set(value As Boolean)
            _rol = value

        End Set
    End Property

    Public Property Sexo As Boolean
        Get
            Return _sexo
        End Get
        Set(value As Boolean)
            _sexo = value
        End Set
    End Property
End Class
