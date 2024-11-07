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

    Public Function ObtenerTodosLosPrestamos() As List(Of PrestamoEntity)
        Dim listaPrestamos As New List(Of PrestamoEntity)()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerTodosLosPrestamos", connection)
                command.CommandType = CommandType.StoredProcedure
                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim prestamo As New PrestamoEntity() With {
                        .PrestamoID = reader("PrestamoID"),
                        .ClienteID = reader("ClienteID"),
                        .MontoTotal = Convert.ToDecimal(reader("MontoTotal")),
                        .MontoConIntereses = Convert.ToDecimal(reader("MontoConIntereses")),
                        .TasaInteres = Convert.ToDecimal(reader("TasaInteres")),
                        .FechaPrestamo = Convert.ToDateTime(reader("FechaPrestamo")),
                        .FechaVencimiento = Convert.ToDateTime(reader("FechaVencimiento")),
                        .Estado = reader("Estado").ToString(),
                        .NumeroCuotas = Convert.ToInt32(reader("NumeroCuotas")),
                        .FrecuenciaPago = reader("FrecuenciaPago").ToString()
                    }
                        listaPrestamos.Add(prestamo)
                    End While
                End Using
            End Using
        End Using

        Return listaPrestamos
    End Function

    Public Function ObtenerDetallePrestamo(prestamoID As Integer) As PrestamoEntity
        Dim detallePrestamo As PrestamoEntity = Nothing

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerDetallePrestamo", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@PrestamoID", prestamoID)

                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        detallePrestamo = New PrestamoEntity() With {
                        .PrestamoID = reader.GetInt32(reader.GetOrdinal("PrestamoID")),
                        .ClienteID = reader.GetInt32(reader.GetOrdinal("ClienteID")),
                        .MontoTotal = reader.GetDecimal(reader.GetOrdinal("MontoTotal")),
                        .MontoConIntereses = reader.GetDecimal(reader.GetOrdinal("MontoConIntereses")),
                        .TasaInteres = reader.GetDecimal(reader.GetOrdinal("TasaInteres")),
                        .NumeroCuotas = reader.GetInt32(reader.GetOrdinal("NumeroCuotas")),
                        .FrecuenciaPago = reader.GetString(reader.GetOrdinal("FrecuenciaPago")),
                        .FechaPrestamo = reader.GetDateTime(reader.GetOrdinal("FechaPrestamo")),
                        .FechaVencimiento = reader.GetDateTime(reader.GetOrdinal("FechaVencimiento")),
                        .Estado = reader.GetString(reader.GetOrdinal("Estado"))
                    }
                    End If
                End Using
            End Using
        End Using

        Return detallePrestamo
    End Function

    Public Function ObtenerCuotasPorPrestamo(prestamoID As Integer) As List(Of CuotaEntity)
        Dim cuotas As New List(Of CuotaEntity)()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerCuotasPorPrestamo", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@PrestamoID", prestamoID)

                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim cuota As New CuotaEntity() With {
                        .CuotaID = Convert.ToInt32(reader("CuotaID")),
                        .PrestamoID = Convert.ToInt32(reader("PrestamoID")),
                        .NumeroCuota = Convert.ToInt32(reader("NumeroCuota")),
                        .MontoCuota = Convert.ToDecimal(reader("MontoCuota")),
                        .FechaVencimiento = Convert.ToDateTime(reader("FechaVencimiento")),
                        .Estado = Convert.ToString(reader("Estado"))
                    }
                        cuotas.Add(cuota)
                    End While
                End Using
            End Using
        End Using

        Return cuotas
    End Function

    Public Function ObtenerMontoCanceladoPorPrestamo(prestamoID As Integer) As Decimal
        Dim montoCancelado As Decimal = 0

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand("sp_ObtenerMontoCancelado", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Agregar el parámetro para el ID del préstamo
                command.Parameters.AddWithValue("@PrestamoID", prestamoID)

                ' Abrir la conexión y ejecutar el comando
                connection.Open()

                Try
                    ' Ejecutar el procedimiento almacenado y obtener el monto cancelado
                    montoCancelado = Convert.ToDecimal(command.ExecuteScalar())
                Catch ex As Exception
                    ' Manejo de excepciones
                    MessageBox.Show("Error al obtener el monto cancelado: " & ex.Message)
                End Try
            End Using
        End Using

        ' Retornar el monto cancelado
        Return montoCancelado
    End Function




End Class
