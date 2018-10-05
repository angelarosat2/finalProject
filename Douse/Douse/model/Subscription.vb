Public Class Subscription
    Inherits Generica

    'Atributos de la tabla con los mismos tipo de datos
    Private _number As Integer
    Private _description As String
    Private _price As Double

    Public Sub New()
        MyBase.nomTabla = "subscriptions"
    End Sub
End Class
