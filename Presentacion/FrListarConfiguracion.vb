Public Class FrListarConfiguracion

    Private configuraciones As List(Of ConfiguracionEntity)

    Private Sub FrListarConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim configuracionRepository As New ConfiguracionesRepository

        Dim configuraciones As List(Of ConfiguracionEntity) = configuracionRepository.ListarConfiguraciones()

        DataGridView1.DataSource = configuraciones

    End Sub
End Class