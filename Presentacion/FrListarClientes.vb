Public Class FrListarClientes

    Private clientes As List(Of ClienteEntity)

    Private Sub FrListarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim clienteRepo As New ClienteRepository()

        ' Esto es para cargar los clientes en memoria lo que no va a cambiar mas adelante
        Dim clientes As List(Of ClienteEntity) = clienteRepo.ListarTodosLosClientes()

        dgvClientes.DataSource = clientes
        dgvClientes.Columns("ClienteID").Visible = False
        dgvClientes.Columns("Contraseña").Visible = False

    End Sub

    Private Sub BtnFiltrarCliente_Click(sender As Object, e As EventArgs) Handles BtnFiltrarCliente.Click

        Dim filtroNombre As String = InputNombreFiltro.Text.Trim()

        ' Llamar al método para listar clientes filtrados por nombre
        Dim clienteRepo As New ClienteRepository()
        Dim clientesFiltrados As List(Of ClienteEntity) = clienteRepo.ListarClientesPorNombre(filtroNombre)

        ' Asignar los clientes filtrados al DataGridView
        dgvClientes.DataSource = clientesFiltrados

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

        If e.RowIndex >= 0 Then

            ' Obtener el ID del cliente seleccionado
            Dim clienteID As Integer = CType(dgvClientes.Rows(e.RowIndex).Cells("ClienteID").Value, Integer)

            ' Hacer una petición al repositorio para obtener los detalles completos del cliente
            Dim clienteRepository As New ClienteRepository

            Dim clienteSeleccionado As ClienteEntity = clienteRepository.ObtenerClientePorID(clienteID)

            ' Verificar si se obtuvo el cliente correctamente
            If clienteSeleccionado IsNot Nothing Then
                ' Abrir el formulario de detalle y pasar los datos del cliente
                Dim frDetalleCliente As New FrClienteDetalle(clienteSeleccionado)

                ' Hacer que el formulario de detalle sea hijo de MainStrip (MDI)
                frDetalleCliente.MdiParent = Me.MdiParent  ' Asumiendo que FrListarClientes también es un hijo

                ' Mostrar el formulario dentro del contenedor MDI
                frDetalleCliente.ShowDialog()
            Else
                MessageBox.Show("Error al obtener los detalles del cliente.")
            End If

        End If

    End Sub

End Class