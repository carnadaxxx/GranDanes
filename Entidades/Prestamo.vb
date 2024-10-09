Namespace Entidades

    Public Class Prestamo
        ' Propiedades de la entidad Préstamo
        Public Property LoanID As Integer        ' Identificador del préstamo (entero)
        Public Property ClientID As Integer      ' Identificador del cliente relacionado (entero)
        Public Property Amount As Decimal        ' Monto del préstamo (decimal con 10 enteros y 2 decimales)
        Public Property InterestRate As Decimal  ' Tasa de interés (decimal con 3 enteros y 2 decimales)
        Public Property LoanDate As Date         ' Fecha del préstamo
        Public Property DueDate As Date          ' Fecha de vencimiento del préstamo
        Public Property NumberOfInstalments As Integer ' Número de cuotas (entero)
        Public Property LoanStatus As String     ' Estado del préstamo (cadena)

        ' Constructor opcional para inicializar los valores
        Public Sub New(loanID As Integer, clientID As Integer, amount As Decimal, interestRate As Decimal, loanDate As Date, dueDate As Date, numberOfInstalments As Integer, loanStatus As String)
            Me.LoanID = loanID
            Me.ClientID = clientID
            Me.Amount = amount
            Me.InterestRate = interestRate
            Me.LoanDate = loanDate
            Me.DueDate = dueDate
            Me.NumberOfInstalments = numberOfInstalments
            Me.LoanStatus = loanStatus
        End Sub

        ' Constructor vacío para inicializar sin parámetros
        Public Sub New()
        End Sub
    End Class



End Namespace

