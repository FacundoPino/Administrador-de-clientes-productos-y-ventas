Public Class ModificarVentas
    Private identificador As Ventas
    Public Sub New(iden As Ventas)
        InitializeComponent()
        identificador = iden
    End Sub
    Private Sub ModificarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.Text = identificador.Id
        txtIdCliente.Text = identificador.Cliente.Id.ToString()
        txtFecha.Text = identificador.Fecha.ToString()
        txtTotal.Text = identificador.Total
    End Sub

    Private Sub btnAdmProducto_Click(sender As Object, e As EventArgs) Handles btnAdmProducto.Click
        Dim b As Boolean = True
        Dim ven As New Ventas
        Dim negocio As New VentasNegocio

        If String.IsNullOrEmpty(txtIdCliente.Text) Then
            MessageBox.Show("Por favor, complete el campo de Id Cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            b = False
        End If
        If String.IsNullOrEmpty(txtFecha.Text) Then
            MessageBox.Show("Por favor, complete el campo de Fecha.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            b = False
        End If
        If String.IsNullOrEmpty(txtTotal.Text) Then
            MessageBox.Show("Por favor, complete el campo del Total.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            b = False
        End If

        If b = True Then
            ven.Id = Convert.ToInt32(txtId.Text)
            ven.Cliente.Id = Convert.ToInt32(txtIdCliente.Text)
            ven.Fecha = Convert.ToDateTime(txtFecha.Text)
            ven.Total = Convert.ToDouble(txtTotal.Text)

            negocio.Modificar(ven)
            MessageBox.Show("Modificado exitosamente :)")
            Close()
        End If

    End Sub
End Class