Imports System.Configuration
Imports System.Data.SqlClient

Public Class PrestamosRepository

    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub

    Public Function CrearPrestamoConCuotas(prestamo As PrestamoEntity) As Integer
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_CrearPrestamoConCuotas", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Agregar los parámetros de entrada
                command.Parameters.AddWithValue("@ClienteID", prestamo.ClienteID)
                command.Parameters.AddWithValue("@MontoTotal", prestamo.MontoTotal)
                command.Parameters.AddWithValue("@NumeroCuotas", prestamo.NumeroCuotas)
                command.Parameters.AddWithValue("@FrecuenciaPago", prestamo.FrecuenciaPago)
                command.Parameters.AddWithValue("@TasaInteres", prestamo.TasaInteres)

                ' Abrir la conexión y ejecutar el comando
                connection.Open()

                Try
                    ' Ejecutar el comando y obtener el ID del préstamo como resultado
                    Dim prestamoID As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Retornar el ID del préstamo recién creado
                    Return prestamoID
                Catch ex As Exception
                    ' Manejo de excepciones
                    MessageBox.Show("Error al crear el préstamo: " & ex.Message)
                    Return -1 ' Retorna -1 en caso de error
                End Try
            End Using
        End Using
    End Function


End Class
