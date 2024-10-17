Imports System.Configuration
Imports System.Data.SqlClient


Public Class ConexionDB

    Private connectionString As String

    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub

    Public Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

End Class
