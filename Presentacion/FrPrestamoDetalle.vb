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
        lblMontoCancelado.Text = prestamoRepository.ObtenerMontoCanceladoPorPrestamo(prestamo.PrestamoID)
        lblTasaInteres.Text = prestamo.TasaInteres.ToString() & "%"
        lblFechaInicio.Text = prestamo.FechaPrestamo.ToShortDateString()

        DataGridListaCuotas.DataSource = prestamoRepository.ObtenerCuotasPorPrestamo(prestamo.PrestamoID)

    End Sub

    Private Sub lblTasaInteres_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub




End Class