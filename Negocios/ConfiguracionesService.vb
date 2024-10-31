Imports Entidades.Entidades

Public Class ConfiguracionesService

    Public Function ValidarConfiguracion(config As ConfiguracionEntity) As List(Of String)

        Dim errores As New List(Of String)

        If String.IsNullOrWhiteSpace(config.ConfigKey) Then
            errores.Add("El Key es obligatorio.")
        End If

        If String.IsNullOrWhiteSpace(config.ConfigDescription) Then
            errores.Add("La Descripcion es obligatoria.")
        End If

        If String.IsNullOrWhiteSpace(config.ConfigValue) Then
            errores.Add("El Valor es obligatorio")
        End If

        Return errores

    End Function

End Class
