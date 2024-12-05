Public Class FrClienteDetalle

    Public Sub New(cliente As ClienteEntity)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Dim clienteRepository As New ClienteRepository

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        TextNombre.Text = cliente.Nombre
        TextDireccion.Text = cliente.Direccion
        TextApellidos.Text = cliente.Apellido
        TextTelefono.Text = cliente.Telefono

        ' Dividir la cadena de roles y agregar cada rol al ListBox
        Dim roles As String() = cliente.Roles.Split(","c)

        For Each rol In roles
            ListBoxRoles.Items.Add(rol.Trim())
        Next

        PrestamosDatagrid.DataSource = clienteRepository.ObtenerPrestamosPorCliente(cliente.ClienteID)

    End Sub

End Class