Imports Negocios

Public Class FrCrearConfiguracion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nuevaConfiguracion As New ConfiguracionEntity() With {
            .ConfigDescription = TextBoxDescripcion.Text,
            .ConfigValue = TextBoxValorPorDefecto.Text,
            .ConfigKey = TextBoxNombreConfiguracion.Text
        }

        Dim configService As New ConfiguracionesService

        Dim errores As List(Of String) = configService.ValidarConfiguracion(nuevaConfiguracion)

        If errores.Any() Then
            MessageBox.Show(String.Join(Environment.NewLine, errores), "Errores de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim configRepo As New ConfiguracionesRepository()
            Dim exito As Boolean = configRepo.CrearConfiguracion(nuevaConfiguracion)

            If exito Then
                MessageBox.Show("Configuración creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Cerrar el formulario de creación de configuraciones
                Me.Close()
            Else
                MessageBox.Show("Hubo un error al crear la Configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

    End Sub
End Class