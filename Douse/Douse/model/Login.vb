Imports System.Data.SqlClient

Public Class Login
    Inherits Generica

    Private _document As Integer
    Private _username As String
    Private _password As String

    Public Sub New()
        Initialize()
    End Sub

    Public Function login(username As String, password As String) As Boolean
        Dim conn As DBConn = DBConn.Instance

        Dim reader As SqlDataReader = conn.SelectStatement("SELECT * FROM username U JOIN user_employees E ON U.username = E.username WHERE U.username = '" & username)
        If reader.HasRows Then
            reader.Close()
            Return True
        End If

        reader.Close()
        Return False
    End Function

    Public Sub Initialize()
        MyBase.nomTabla = "username"
    End Sub
    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
End Class
