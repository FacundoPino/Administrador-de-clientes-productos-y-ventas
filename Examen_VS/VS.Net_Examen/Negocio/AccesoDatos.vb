Imports System.Data.SqlClient
Imports System.Configuration

Public Class AccesoDatos
    Private _conexion As SqlConnection
    Private _comando As SqlCommand
    Private _lector As SqlDataReader

    Public ReadOnly Property Lector() As SqlDataReader
        Get
            Return _lector
        End Get
    End Property

    Public Sub New()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
        _conexion = New SqlConnection(connectionString)
        _comando = New SqlCommand()

        '_conexion = New SqlConnection("server=.\\SQLEXPRESS; database=pruebademo; integrated security=true")
        '_comando = New SqlCommand()
    End Sub

    Public Sub EjecutarLectura()
        _comando.Connection = _conexion
        Try
            _conexion.Open()
            _lector = _comando.ExecuteReader()
        Catch ex As Exception
            ' Asegúrate de cerrar la conexión si algo sale mal
            If _conexion.State = ConnectionState.Open Then
                _conexion.Close()
            End If
            ' Propaga la excepción con información adicional
            Throw New Exception("Error al ejecutar la lectura: " & ex.Message, ex)
        End Try
    End Sub

    'Public Sub EjecutarLectura()
    '    _comando.Connection = _conexion
    '    Try
    '        _conexion.Open()
    '        _lector = _comando.ExecuteReader()

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub SetearConsulta(consulta As String)
        _comando.CommandType = System.Data.CommandType.Text
        _comando.CommandText = consulta

    End Sub

    Public Sub setearProcedimiento(procedimiento As String)
        _comando.CommandType = System.Data.CommandType.StoredProcedure
        _comando.CommandText = procedimiento

    End Sub

    Public Sub EjecutarConsulta()
        _comando.Connection = _conexion
        Try

            _conexion.Open()
            _lector = _comando.ExecuteReader()

        Catch ex As Exception

            Throw ex

        End Try

    End Sub

    Public Sub EjecutarAccion()
        _comando.Connection = _conexion
        Try
            _conexion.Open()
            _comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub SeterParametros(nombre As String, valor As Object)
        _comando.Parameters.AddWithValue(nombre, valor)

    End Sub

    Public Sub CerrarConexion()
        If _lector IsNot Nothing Then
            _lector.Close()
            _conexion.Close()
        End If
    End Sub

    Public Sub LimpiarParametros()
        _comando.Parameters.Clear()
    End Sub
End Class