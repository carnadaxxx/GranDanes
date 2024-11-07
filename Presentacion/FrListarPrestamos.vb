Public Class FrListarPrestamos

    Dim prestamoRepository As New PrestamosRepository

    Private Sub FrListarPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridListaPrestamos.DataSource = prestamoRepository.ObtenerTodosLosPrestamos()

    End Sub

    Private Sub DataGridListaPrestamos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridListaPrestamos.CellContentClick

        ' Asegurarse de que la fila seleccionada no sea el encabezado
        If e.RowIndex >= 0 Then
            ' Obtener el ID del préstamo seleccionado
            Dim prestamoID As Integer = Convert.ToInt32(DataGridListaPrestamos.Rows(e.RowIndex).Cells("PrestamoID").Value)

            ' Crear una instancia del formulario de detalles y pasarle el prestamoID
            Dim detalleForm As New FrPrestamoDetalle(prestamoID)
            detalleForm.ShowDialog()
        End If

    End Sub
End Class