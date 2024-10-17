Imports Entidades.Entidades

Public Class FrClienteDetalle

    Public Sub New(cliente As Cliente)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        TextNombre.Text = cliente.Name
        TextDireccion.Text = cliente.Address
        TextTelefono.Text = cliente.Phone

    End Sub

End Class