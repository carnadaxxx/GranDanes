Public Class FrPrestamoDetalle

    Dim prestamoRepository As New PrestamosRepository

    Private prestamoID As Integer

    ' Constructor que recibe el ID del préstamo
    Public Sub New(prestamoID As Integer)
        InitializeComponent()
        Me.prestamoID = prestamoID
    End Sub

    Private Sub FrPrestamoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Llama a una función para obtener el préstamo con el prestamoID
        Dim prestamo As PrestamoEntity = prestamoRepository.ObtenerDetallePrestamo(prestamoID)

        ' Muestra los detalles en los controles del formulario
        lblCliente.Text = prestamo.ClienteID.ToString()
        lblMonto.Text = prestamo.MontoTotal.ToString("C")
        lblMontoConInteres.Text = prestamo.MontoConIntereses.ToString("C")
        lblMontoCancelado.Text = prestamoRepository.ObtenerMontoCanceladoPorPrestamo(prestamo.PrestamoID).ToString("C")
        lblTasaInteres.Text = prestamo.TasaInteres.ToString() & "%"
        lblFechaInicio.Text = prestamo.FechaPrestamo.ToShortDateString()
        lblEstadoPago.Text = prestamo.Estado.ToString()
        lblAprobacion.Text = prestamo.EstadoAprobacion.ToString()

        DataGridListaCuotas.DataSource = prestamoRepository.ObtenerCuotasPorPrestamo(prestamo.PrestamoID)

    End Sub

    Private Sub DataGridListaCuotas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridListaCuotas.CellContentClick
        ' Asegurarse de que la fila seleccionada no sea el encabezado
        If e.RowIndex >= 0 Then

            Dim cuotaID As Integer = Convert.ToInt32(DataGridListaCuotas.Rows(e.RowIndex).Cells("CuotaID").Value)

            ' Crear una instancia del formulario de detalles y pasarle el prestamoID
            Dim cancelarCuotaFrm As New FrPagarCuota(cuotaID)
            cancelarCuotaFrm.ShowDialog()
        End If
    End Sub
End Class