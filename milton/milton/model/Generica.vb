Public Class Generica
    ' Public: Todos tienen acceso
    ' Protected: Acceso desde clase y herencia
    ' Private: Acceso solo desde la clase

    Protected nomTabla As String

    Public Overridable Function obtenerListado()
        Return DBCon.Instance.SelectStatement("SELECT * FROM " + nomTabla)
    End Function

End Class
