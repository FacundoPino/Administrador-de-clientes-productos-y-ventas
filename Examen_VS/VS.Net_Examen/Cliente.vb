Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging

Public Class Cliente
    Private listaClientes As List(Of Clientes)
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lista As List(Of Clientes) = New List(Of Clientes)
        cboFiltro.Text = "Cliente"
        Try
            Dim negocio As New ClientesNegocio
            listaClientes = negocio.Listar()
            lista = negocio.Listar()
            dgvClientes.DataSource = lista
            Globales.DiseñoDtv(dgvClientes)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    'Private Function ListarDgv() As List(Of Clientes)
    '    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MiConexion").ConnectionString
    '    Dim conexion = New SqlConnection(connectionString)
    '    Dim lista As New List(Of Clientes)
    '    Dim consulta As String = ("select ID, Cliente, Telefono, Correo from clientes")
    '    Dim adaptador As SqlDataAdapter(consulta, conexion)
    'End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim clien As Clientes = dgvClientes.CurrentRow.DataBoundItem
        Dim ventana As AdministrarClientes = New AdministrarClientes(clien)
        ventana.ShowDialog()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ventana As AdministrarClientes = New AdministrarClientes()
        ventana.ShowDialog()
    End Sub

    Private Sub btnLogico_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim seleccionado As New Clientes
        Dim negocio As New ClientesNegocio
        Dim result As DialogResult = MessageBox.Show("¿Estas seguro de Eliminar este Registro?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then

            seleccionado = dgvClientes.CurrentRow.DataBoundItem
            negocio.Eliminar(seleccionado.Id)
            MessageBox.Show("Eliminado exitosamente :)")

            dgvClientes.DataSource = negocio.Listar()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        Dim filtro As String = txtFiltro.Text.ToLower()
        Dim filtrada As New List(Of Clientes)

        If filtro.Length() > 2 Then
            If cboFiltro.Text = "Cliente" Then
                filtrada = listaClientes.FindAll(Function(x) x.Cliente.ToLower().Contains(filtro.ToLower()))

            ElseIf cboFiltro.Text = "Telefono" Then
                filtrada = listaClientes.FindAll(Function(x) x.Telefono.ToLower().Contains(filtro.ToLower()))

            Else
                filtrada = listaClientes.FindAll(Function(x) x.Correo.ToLower().Contains(filtro.ToLower()))
            End If

        Else
            filtrada = listaClientes
        End If

        dgvClientes.DataSource = Nothing
        dgvClientes.DataSource = filtrada
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim negocioC As New ClientesNegocio
        dgvClientes.DataSource = negocioC.Listar()
        Globales.DiseñoDtv(dgvClientes)
    End Sub
End Class