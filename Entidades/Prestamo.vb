Namespace Entidades

    Public Class PrestamoEntity
        Public Property PrestamoID As Integer
        Public Property ClienteID As Integer
        Public Property MontoTotal As Decimal       ' Monto solicitado por el cliente
        Public Property MontoConIntereses As Decimal ' Monto total a pagar incluyendo intereses
        Public Property TasaInteres As Decimal      ' Tasa de interés del préstamo
        Public Property FechaPrestamo As Date       ' Fecha de creación del préstamo
        Public Property FechaVencimiento As Date    ' Fecha de vencimiento del préstamo
        Public Property Estado As String            ' Estado del préstamo (e.g., 'Pendiente', 'Pagado')
        Public Property NumeroCuotas As Integer     ' Numero de cuotas
        Public Property FrecuenciaPago As String    ' Frecuencia de Pagos (e.g., 'Mensual', 'Quincenal')

        ' Constructor sin parámetros
        Public Sub New()
        End Sub

        ' Constructor con parámetros
        Public Sub New(prestamoID As Integer, clienteID As Integer, montoTotal As Decimal, montoConIntereses As Decimal, tasaInteres As Decimal, fechaPrestamo As Date, fechaVencimiento As Date, estado As String, numeroCuotas As Integer, frecuenciaPago As String)
            Me.PrestamoID = prestamoID
            Me.ClienteID = clienteID
            Me.MontoTotal = montoTotal
            Me.MontoConIntereses = montoConIntereses
            Me.TasaInteres = tasaInteres
            Me.FechaPrestamo = fechaPrestamo
            Me.FechaVencimiento = fechaVencimiento
            Me.Estado = estado
            Me.NumeroCuotas = numeroCuotas
            Me.FrecuenciaPago = frecuenciaPago
        End Sub
    End Class

End Namespace

