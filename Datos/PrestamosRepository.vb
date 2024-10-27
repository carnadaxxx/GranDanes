Imports System.Configuration

Public Class PrestamosRepository

    Private connectionString As String

    ' Constructor
    Public Sub New()
        connectionString = ConfigurationManager.ConnectionStrings("MiConexionSQL").ConnectionString
    End Sub


End Class
