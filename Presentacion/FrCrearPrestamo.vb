Imports Negocios

Public Class FrCrearPrestamo
    Private Sub FrCrearPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar clientes en el ComboBox
        Dim clienteRepo As New ClienteRepository()
        Dim configRepo As New ConfiguracionesRepository()

        Dim clientes As List(Of ClienteEntity) = clienteRepo.ListarTodosLosClientes()

        txtTasaInteres.Text = configRepo.ObtenerConfiguracion("TasaInteresPorDefecto")

        Dim numeroCuotasPorDefecto As String = configRepo.ObtenerConfiguracion("NumeroDeCuotasPorDefecto")
        nudNumeroCuotas.Value = Convert.ToInt32(numeroCuotasPorDefecto)
        cmbClientes.DataSource = clientes
        cmbClientes.ValueMember = "ClienteID"
        cmbClientes.DisplayMember = "NombreCompleto"

    End Sub

    Private Sub btnCrearPrestamo_Click(sender As Object, e As EventArgs) Handles btnCrearPrestamo.Click

        Dim prestamoRepo As New PrestamosRepository()

        ' Crear la entidad PrestamoEntity con los datos del formulario
        Dim nuevoPrestamo As New PrestamoEntity With {
            .ClienteID = Convert.ToInt32(cmbClientes.SelectedValue),        ' ID del cliente seleccionado
            .MontoTotal = Convert.ToDecimal(txtMontoTotal.Text),            ' Monto total del préstamo
            .TasaInteres = Convert.ToDecimal(txtTasaInteres.Text),          ' Tasa de interés
            .NumeroCuotas = Convert.ToInt32(nudNumeroCuotas.Value),         ' Número de cuotas
            .FrecuenciaPago = cmbFrecuenciaPago.SelectedItem.ToString()     ' Frecuencia de pago
        }

        ' Instancia del servicio y validación del préstamo
        Dim prestamoService As New PrestamoService()
        Dim errores As List(Of String) = prestamoService.ValidarPrestamo(nuevoPrestamo)

        If errores.Any() Then
            MessageBox.Show(String.Join(Environment.NewLine, errores), "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim prestamoID As Integer = prestamoRepo.CrearPrestamoConCuotas(nuevoPrestamo)

            ' Validar si el préstamo fue creado exitosamente
            If prestamoID > 0 Then
                MessageBox.Show($"Préstamo creado exitosamente. ID del préstamo: {prestamoID}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("No se pudo crear el préstamo. Verifique los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

End Class