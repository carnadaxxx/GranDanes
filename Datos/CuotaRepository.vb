Imports System.Configuration
Imports System.Data.SqlClient

Public Class CuotaRepository


    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub

    Public Function MarcarCuotaComoCancelada(cuotaID As Integer) As Boolean
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_MarcarCuotaComoCancelada", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Parámetro de entrada
                command.Parameters.AddWithValue("@CuotaID", cuotaID)

                Try
                    ' Abrir conexión
                    connection.Open()

                    ' Ejecutar el procedimiento almacenado y leer el resultado
                    Dim resultado As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Retorna True si el resultado es 1 (indica éxito)
                    Return resultado = 1
                Catch ex As Exception
                    ' Manejo de errores
                    MessageBox.Show("Error al marcar la cuota como cancelada: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Try
            End Using
        End Using
    End Function

    Public Function ObtenerIdPrestamoPorCuota(idCuota As Integer) As Integer
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerIdPrestamoPorCuota", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Parámetro de entrada
                command.Parameters.AddWithValue("@CuotaID", idCuota)

                ' Parámetro de salida
                Dim idPrestamo As Integer = 0

                Try
                    ' Abrir la conexión
                    connection.Open()

                    ' Ejecutar el procedimiento y obtener el resultado
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Asignar el valor de IdPrestamo
                            idPrestamo = If(reader("PrestamoID") Is DBNull.Value, 0, Convert.ToInt32(reader("PrestamoID")))
                        End If
                    End Using

                    Return idPrestamo
                Catch ex As Exception
                    ' Manejo de errores
                    MessageBox.Show("Error al obtener el IdPrestamo: " & ex.Message)
                    Return 0 ' Retorna 0 si hay un error
                End Try
            End Using
        End Using
    End Function

    Public Function EstaCancelada(idCuota As Integer) As Boolean
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("SELECT Estado FROM Cuotas WHERE CuotaID = @CuotaID", connection)
                command.Parameters.AddWithValue("@CuotaID", idCuota)
                connection.Open()
                Dim estado As String = Convert.ToString(command.ExecuteScalar())
                Return estado = "Cancelada"
            End Using
        End Using
    End Function

End Class
