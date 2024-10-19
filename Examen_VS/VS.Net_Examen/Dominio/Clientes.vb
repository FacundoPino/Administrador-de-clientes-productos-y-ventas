Public Class Clientes
    Private _Id As Integer
    Private _Cliente As String
    Private _Telefono As String
    Private _Correo As String
    Public Sub New()
        _Id = 0
        _Cliente = ""
        _Telefono = ""
        _Correo = ""
    End Sub
    Public Sub New(id As Integer, cliente As String, telefono As String, correo As String)
        _Id = id
        _Cliente = cliente
        _Telefono = telefono
        _Correo = correo
    End Sub
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property
End Class
