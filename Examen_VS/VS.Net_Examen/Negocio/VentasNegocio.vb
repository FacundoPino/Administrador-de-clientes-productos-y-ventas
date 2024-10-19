Public Class VentasNegocio
    Public Function Listar() As List(Of Ventas)
        Dim datos As New AccesoDatos
        Dim lista As New List(Of Ventas)
        Try
            datos.SetearConsulta("select ID, IDCliente, Fecha, Total from ventas")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                Dim ven As New Ventas
                ven.Cliente = New Clientes
                ven.Id = Convert.ToInt32(datos.Lector("ID"))
                ven.Cliente.Id = Convert.ToInt32(datos.Lector("IDCliente"))
                ven.IdCliente = Convert.ToInt32(datos.Lector("IDCliente"))
                ven.Fecha = Convert.ToDateTime(datos.Lector("Fecha"))
                ven.Total = Convert.ToDouble(datos.Lector("Total"))

                lista.Add(ven)
            End While

            Return lista
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Function

    Public Sub Modificar(ven As Ventas)
        Dim datos As New AccesoDatos
        Try
            datos.LimpiarParametros()
            datos.SetearConsulta("update Ventas set IdCliente = @idCliente, Fecha = @fecha, Total = @total where ID = @id")
            datos.SeterParametros("@idcliente", ven.Cliente)
            datos.SeterParametros("@fecha", ven.Fecha)
            datos.SeterParametros("@total", ven.Total)
            datos.SeterParametros("@id", ven.Id)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub
    Public Sub Agregar(ven As Ventas)
        Dim datos As New AccesoDatos
        Try
            datos.LimpiarParametros()
            datos.SetearConsulta("insert Ventas (IdCliente, Fecha, Total) VALUES (@idcliente, @fecha, @total)")
            datos.SeterParametros("@idcliente", ven.Cliente.Id)
            datos.SeterParametros("@fecha", ven.Fecha)
            datos.SeterParametros("@total", ven.Total)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Sub Eliminar(id As Integer)
        Dim datos As New AccesoDatos
        Try
            datos.SetearConsulta("delete Ventas where ID = @id")
            datos.SeterParametros("@id", id)
            datos.EjecutarAccion()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            datos.CerrarConexion()
        End Try
    End Sub

    Public Function DevolverId() As Integer
        Dim datos As New AccesoDatos
        Dim id As Integer
        Try
            datos.SetearConsulta("SELECT TOP 1 ID FROM Ventas ORDER BY ID DESC;")
            datos.EjecutarLectura()

            While datos.Lector.Read()
                id = Convert.ToInt32(datos.Lector("ID"))
            End While
            Return id
        Catch ex As Exception
            Throw ex
        Finally
            datos.CerrarConexion()
        End Try
    End Function

End Class
