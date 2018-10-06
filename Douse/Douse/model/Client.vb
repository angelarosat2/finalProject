Public Class Client
    Inherits Generica

    'Atributos de la tabla con los mismos tipo de datos
    Private _document As Integer
    Private _name As String
    Private _address As String
    Private _email As String

    Public Sub New()

        Initialize()
    End Sub

    Public Sub New(document As Integer, name As String, address As String, email As String)
        Me.Document = document
        Me.Name = name
        Me.Address = address
        Me.Email = email

        Initialize()
    End Sub

    Public Sub Initialize()
        MyBase.nomTabla = "clients"
        MyBase.atributosInsert = {"Document", "Name", "Address", "Email"}
    End Sub

    Public Property Document As Integer
        Get
            Return _document
        End Get
        Set(value As Integer)
            _document = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
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
End Class
