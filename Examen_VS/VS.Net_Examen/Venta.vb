Public Class Venta
    Private listaVentas As List(Of Ventas)
    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As List(Of Ventas) = New List(Of Ventas)
        cboFiltro.Text = "IdCliente"
        Try
            Dim negocio As New VentasNegocio
            listaVentas = negocio.Listar()
            lista = negocio.Listar()
            CargarDgv(lista)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub CargarDgv(lista As List(Of Ventas))
        dgvVentas.DataSource = Nothing
        dgvVentas.DataSource = lista

        dgvVentas.Columns("Cliente").Visible = False
        Globales.DiseñoDtv(dgvVentas)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ventana As AgregarVentas = New AgregarVentas(2)
        ventana.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ven As Ventas = dgvVentas.CurrentRow.DataBoundItem
        Dim ventana As ModificarVentas = New ModificarVentas(ven)
        ventana.ShowDialog()
    End Sub

    Private Sub btnLogico_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim seleccionado As New Ventas
        Dim negocio As New VentasNegocio
        Dim result As DialogResult = MessageBox.Show("¿Estas seguro de Eliminar esta Venta?", "Eliminar venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then

            seleccionado = dgvVentas.CurrentRow.DataBoundItem
            negocio.Eliminar(seleccionado.Id)
            MessageBox.Show("Eliminado exitosamente :)")

            CargarDgv(negocio.Listar())
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim filtro As String = txtFiltro.Text.ToLower()
        Dim filtrada As New List(Of Ventas)

        If filtro.Length() > 2 Then
            If cboFiltro.Text = "IdCliente" Then
                filtrada = listaVentas.FindAll(Function(x) x.Cliente.ToString().ToLower().Contains(filtro.ToLower()))

            Else cboFiltro.Text = "Fecha"
                filtrada = listaVentas.FindAll(Function(x) x.Fecha.ToString().ToLower().Contains(filtro.ToLower()))
            End If

        Else
            filtrada = listaVentas
        End If

        dgvVentas.DataSource = Nothing
        dgvVentas.DataSource = filtrada
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim negocioV As New VentasNegocio
        CargarDgv(negocioV.Listar())
    End Sub
End Class