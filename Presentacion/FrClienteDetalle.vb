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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class