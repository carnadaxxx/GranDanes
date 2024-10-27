Imports Entidades.Entidades

Public Class FrClienteDetalle

    Public Sub New(cliente As Cliente)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Dim clienteRepository As New ClienteRepository

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        TextNombre.Text = cliente.Name
        TextDireccion.Text = cliente.Address
        TextTelefono.Text = cliente.Phone

        PrestamosDatagrid.DataSource = clienteRepository.ListarPrestamosPorCliente(cliente.ClientID)

    End Sub


End Class