Public Class Home
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim Ventana As Cliente = New Cliente
        Ventana.ShowDialog()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim ventana As Producto = New Producto
        ventana.ShowDialog()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim ventana As Venta = New Venta
        ventana.ShowDialog()
    End Sub

    Private Sub FacundoPino_Click(sender As Object, e As EventArgs) Handles FacundoPino.Click
        System.Diagnostics.Process.Start("https://www.linkedin.com/in/facundopino/")
    End Sub
End Class
