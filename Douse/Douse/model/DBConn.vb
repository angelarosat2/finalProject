Imports System.Data.SqlClient

Public NotInheritable Class DBConn

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader


    Private Shared ReadOnly _instance As New Lazy(Of DBConn) _
        (Function() New DBConn(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
        myConn = New SqlConnection("Server=angela-rosa-tic\SQLEXPRESS;Database=douse;Trusted_Connection=True;")
    End Sub

    Public Shared ReadOnly Property Instance() As DBConn
        Get
            Return _instance.Value
        End Get
    End Property

    Public Function SelectStatement(sql As String) As SqlDataReader
        OpenConnection()

        myCmd = myConn.CreateCommand()
        myCmd.CommandText = sql


        Dim sqlResult As SqlDataReader = myCmd.ExecuteReader()

        'esto es medio groncho y lo vamos a cambiar
        myCmd = Nothing

        Return sqlResult


    End Function

    Public Function InsertStatement(sqlCmd As SqlCommand) As Integer
        ' Abrimos la conexión
        OpenConnection()

        ' Le asignamos la conexión al comando
        sqlCmd.Connection = myConn

        ' Ejecuta la consuta y retorna la cantidad de filas afectadas 
        ' Eventualmente vamos a retornar el id insertado
        Return sqlCmd.ExecuteNonQuery()

    End Function


    Public Sub OpenConnection()
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
    End Sub
End Class
