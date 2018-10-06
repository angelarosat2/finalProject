Public Class Usuarios
    Inherits Generica

    Private _document_employees As Integer
    Private _username As String
    Private _email As String
    Private _password As String

    Public Sub New()
        Initialize()
    End Sub

    Public Sub New(document As Integer, username As String, email As String, password As String)
        Me.Document_employees = _document_employees
        Me.Username = username
        Me.Email = email
        Me.Password = password

        Initialize()
    End Sub

    Public Sub Initialize()
        MyBase.nomTabla = "user_employees"
    End Sub

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Document_employees As Integer
        Get
            Return _document_employees
        End Get
        Set(value As Integer)
            _document_employees = value
        End Set
    End Property
End Class
