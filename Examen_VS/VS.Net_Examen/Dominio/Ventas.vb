Public Class Ventas
    Private _Id As Integer
    Private _Cliente As Clientes
    Private _IdCliente As Integer
    Private _Fecha As DateTime
    Private _Total As Double
    Public Sub New()
        _Id = 0
        _Cliente = New Clientes
        _Fecha = New DateTime
        _Total = 0
        _IdCliente = 0
    End Sub
    Public Sub New(id As Integer, cliente As Clientes, fecha As DateTime, total As Double, ncli As Integer)
        _Id = id
        _Cliente = cliente
        _Fecha = fecha
        _Total = total
        _IdCliente = ncli
    End Sub
    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property Cliente As Clientes
        Get
            Return _Cliente
        End Get
        Set(value As Clientes)
            _Cliente = value
        End Set
    End Property
    Public Property Fecha As DateTime
        Get
            Return _Fecha
        End Get
        Set(value As DateTime)
            _Fecha = value
        End Set
    End Property
    Public Property Total As Double
        Get
            Return _Total
        End Get
        Set(value As Double)
            _Total = value
        End Set
    End Property
    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(value As Integer)
            _IdCliente = value
        End Set
    End Property
End Class
