Imports Datos
Imports Entidades.Entidades

Public Class PrestamoService

    Private configuracionRepo As New ConfiguracionesRepository

    Public Function ValidarPrestamo(prestamo As PrestamoEntity) As List(Of String)
        Dim errores As New List(Of String)()

        ' Validación de ClienteID
        If prestamo.ClienteID <= 0 Then
            errores.Add("Debe seleccionar un cliente válido.")
        End If

        ' Validación de MontoTotal
        If prestamo.MontoTotal <= 0 Then
            errores.Add("El monto total debe ser mayor a 0.")
        Else
            Dim montoMinimoString As String = configuracionRepo.ObtenerConfiguracion("MontoMinimoPrestamo")
            Dim montoMinimo As Decimal

            If Decimal.TryParse(montoMinimoString, montoMinimo) Then
                If prestamo.MontoTotal < montoMinimo Then
                    errores.Add($"El monto total debe ser mayor o igual a {montoMinimo}.")
                End If
            Else
                MessageBox.Show("El valor de MontoMinimoPrestamo no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

            ' Validación de TasaInteres
            If prestamo.TasaInteres <= 0 OrElse prestamo.TasaInteres > 100 Then
            errores.Add("La tasa de interés debe ser un valor positivo y no mayor a 100%.")
        End If

        ' Validación de NumeroCuotas
        If prestamo.NumeroCuotas <= 0 Then
            errores.Add("El número de cuotas debe ser mayor a 0.")
        End If

        ' Validación de FrecuenciaPago
        Dim frecuenciasValidas As List(Of String) = New List(Of String) From {"Mensual", "Quincenal"}
        If Not frecuenciasValidas.Contains(prestamo.FrecuenciaPago) Then
            errores.Add("La frecuencia de pago debe ser 'Mensual' o 'Quincenal'.")
        End If

        Return errores
    End Function
End Class


