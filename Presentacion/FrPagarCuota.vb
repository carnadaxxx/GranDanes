Public Class FrPagarCuota

    Private cuotaRepo As New CuotaRepository

    Private cuotaID As Integer

    Public Sub New(cuotaID As Integer)
        InitializeComponent()
        Me.cuotaID = cuotaID
    End Sub


    Private Sub VerificarEstadoCuota()
        Dim estadoCuota As Boolean = cuotaRepo.EstaCancelada(cuotaID)

        If estadoCuota Then
            BtnPagarCuota.Visible = False
            MessageBox.Show("Esta cuota ya ha sido cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BtnPagarCuota.Visible = True
        End If
    End Sub



    Private Sub FrPagarCuota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VerificarEstadoCuota()
    End Sub

    Private Sub BtnPagarCuota_Click(sender As Object, e As EventArgs) Handles BtnPagarCuota.Click
        ' Llamar al método para marcar la cuota como cancelada
        Dim exito As Boolean = cuotaRepo.MarcarCuotaComoCancelada(cuotaID)

        ' Verificar el resultado y mostrar mensajes al usuario
        If exito Then
            MessageBox.Show("La cuota se ha marcado como cancelada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Cerrar el formulario actual
            Me.Close()

            ' Obtener el ID del préstamo correspondiente a la cuota y abrir el detalle del préstamo
            Dim prestamoID As Integer = cuotaRepo.ObtenerIdPrestamoPorCuota(cuotaID)
            If prestamoID > 0 Then ' Verifica que el préstamo se haya encontrado
                Dim detalleForm As New FrPrestamoDetalle(prestamoID)
                detalleForm.ShowDialog()
            Else
                MessageBox.Show("No se encontró el préstamo asociado a esta cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No se pudo marcar la cuota como cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub



End Class