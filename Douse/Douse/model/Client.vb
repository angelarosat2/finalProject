Public Class Client
    Inherits Generica

    'Atributos de la tabla con los mismos tipo de datos
    Private _document As Integer
    Private _name As String
    Private _address As String
    Private _email As String

    Public Sub New()
        MyBase.nomTabla = "clients"
    End Sub
End Class
