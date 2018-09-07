Imports System.Data.SqlClient

Public NotInheritable Class DBCon

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader


    Private Shared ReadOnly _instance As New Lazy(Of DBCon) _
        (Function() New DBCon(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
        myConn = New SqlConnection("Server=angela-rosa-tic\SQLEXPRESS;Database=miltondb;Trusted_Connection=True;")
    End Sub

    Public Shared ReadOnly Property Instance() As DBCon
        Get
            Return _instance.Value
        End Get
    End Property

    Public Function SelectStatement(sql As String) As SqlDataReader

        myCmd = myConn.CreateCommand
        myCmd.CommandText = sql

        myConn.Open()

        Return myCmd.ExecuteReader()


    End Function

End Class
