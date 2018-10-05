Imports System.Data.SqlClient

Public NotInheritable Class DBCon

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader


    Private Shared ReadOnly _instance As New Lazy(Of DBCon) _
        (Function() New DBCon(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
        myConn = New SqlConnection("Server=rosas\SQLEXPRESS;Database=douse;Trusted_Connection=True;")
    End Sub

    Public Shared ReadOnly Property Instance() As DBCon
        Get
            Return _instance.Value
        End Get
    End Property

    Public Function SelectStatement(sql As String) As SqlDataReader

        myCmd = myConn.CreateCommand
        myCmd.CommandText = sql

        OpenConnection()

        Dim sqlResult As SqlDataReader = myCmd.ExecuteReader()

        myCmd = Nothing

        Return sqlResult


    End Function

    Public Function InsertStatement(sqlCmd As SqlCommand) As Integer

        OpenConnection()

        sqlCmd.Connection = myConn

        Return sqlCmd.ExecuteNonQuery()

    End Function


    Public Sub OpenConnection()
        myConn.Open()
    End Sub
End Class
