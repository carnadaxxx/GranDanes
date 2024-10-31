Imports Entidades.Entidades

Public Class FrClienteDetalle

    Public Sub New(cliente As ClienteEntity)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Dim clienteRepository As New ClienteRepository

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        TextNombre.Text = cliente.Nombre
        TextDireccion.Text = cliente.Direccion
        TextTelefono.Text = cliente.Telefono

        ' PrestamosDatagrid.DataSource = clienteRepository.ListarPrestamosPorCliente(cliente.ClienteID)

    End Sub


End Class