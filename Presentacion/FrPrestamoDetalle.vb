Public Class FrPrestamoDetalle

    Private btnAprobar As Button
    Private btnDenegar As Button

    Dim prestamoRepository As New PrestamosRepository

    Private prestamoID As Integer

    ' Constructor que recibe el ID del préstamo
    Public Sub New(prestamoID As Integer)
        InitializeComponent()
        Me.prestamoID = prestamoID
        Me.btnAprobar = New Button() With {.Text = "Aprobar", .Visible = False, .Location = New Point(596, 12)}
        Me.btnDenegar = New Button() With {.Text = "Denegar", .Visible = False, .Location = New Point(596, 34)}

        AddHandler btnAprobar.Click, AddressOf btnAprobar_Click
        AddHandler btnDenegar.Click, AddressOf btnDenegar_Click

        Me.Controls.Add(btnAprobar)
        Me.Controls.Add(btnDenegar)
    End Sub

    Private Sub FrPrestamoDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llama a una función para obtener el préstamo con el prestamoID
        Dim prestamo As PrestamoEntity = prestamoRepository.ObtenerDetallePrestamo(prestamoID)

        If prestamo.EstadoAprobacion = "pendiente" Then
            btnAprobar.Visible = True
            btnDenegar.Visible = True
        Else
            btnAprobar.Visible = False
            btnDenegar.Visible = False
        End If


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

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs)
        Try
            If prestamoRepository.AprobarPrestamo(prestamoID) Then
                MessageBox.Show("Prestamo aprobado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al aprobar el prestamo." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnDenegar_Click(sender As Object, e As EventArgs)
        Try
            If prestamoRepository.DenegarPrestamo(prestamoID) Then
                MessageBox.Show("Prestamo Denegado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al Denegar el prestamo." & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class
