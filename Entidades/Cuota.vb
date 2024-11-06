Namespace Entidades

    Public Class CuotaEntity
        Public Property CuotaID As Integer
        Public Property PrestamoID As Integer       ' Relación con el préstamo
        Public Property NumeroCuota As Integer      ' Número de la cuota
        Public Property MontoCuota As Decimal       ' Monto de la cuota
        Public Property FechaVencimiento As Date    ' Fecha de vencimiento de la cuota
        Public Property Estado As String            ' Estado de la cuota (e.g., 'Pendiente', 'Pagado')
        Public Property FechaPago As Date?          ' Fecha de pago de la cuota (si ha sido pagada)

        ' Constructor sin parámetros
        Public Sub New()
        End Sub

        ' Constructor con parámetros
        Public Sub New(cuotaID As Integer, prestamoID As Integer, numeroCuota As Integer, montoCuota As Decimal, fechaVencimiento As Date, estado As String, Optional fechaPago As Date? = Nothing)
            Me.CuotaID = cuotaID
            Me.PrestamoID = prestamoID
            Me.NumeroCuota = numeroCuota
            Me.MontoCuota = montoCuota
            Me.FechaVencimiento = fechaVencimiento
            Me.Estado = estado
            Me.FechaPago = fechaPago
        End Sub
    End Class

End Namespace