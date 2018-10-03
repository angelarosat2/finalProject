Public Class addClient
    Inherits Generica

    'Atributos de la tabla con los mismos tipo de datos
    Private _document As Integer
    Private _number As String
    Private _address As String
    Private _email As String

    Public Sub New()
        MyBase.atributosInsert = {"document", "name", "address", "email"}
    End Sub
End Class
