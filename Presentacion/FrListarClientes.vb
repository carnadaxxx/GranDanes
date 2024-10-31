Public Class FrListarClientes

    Private clientes As List(Of ClienteEntity)

    Private Sub FrListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim clienteRepo As New ClienteRepository()

        ' Esto es para cargar los clientes en memoria lo que no va a cambiar mas adelante
        Dim clientes As List(Of ClienteEntity) = clienteRepo.ListarTodosLosClientes()

        DataGridView1.DataSource = clientes

    End Sub

    Private Sub BtnFiltrarCliente_Click(sender As Object, e As EventArgs) Handles BtnFiltrarCliente.Click

        Dim filtroNombre As String = InputNombreFiltro.Text.Trim()

        Dim clientesFiltrados = clientes.Where(Function(c) c.Nombre.ToLower().Contains(filtroNombre.ToLower())).ToList()

        DataGridView1.DataSource = clientesFiltrados

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then

            ' Obtener el cliente seleccionado
            Dim clienteSeleccionado As ClienteEntity = CType(DataGridView1.Rows(e.RowIndex).DataBoundItem, ClienteEntity)

            ' Abrir el formulario de detalle y pasar los datos del cliente
            Dim frDetalleCliente As New FrClienteDetalle(clienteSeleccionado)

            ' Hacer que el formulario de detalle sea hijo de MainStrip (MDI)
            frDetalleCliente.MdiParent = Me.MdiParent  ' Asumiendo que FrListarClientes también es un hijo

            ' Mostrar el formulario dentro del contenedor MDI
            frDetalleCliente.Show()

        End If

    End Sub
End Class