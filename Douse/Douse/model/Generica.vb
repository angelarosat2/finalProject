Imports System.Data.SqlClient

Public Class Generica
    ' Public: Todos tienen acceso
    ' Protected: Acceso desde clase y herencia
    ' Private: Acceso solo desde la clase

    Protected nomTabla As String
    Protected atributosInsert

    Public Overridable Function insertar()

        ' generar el insert generico, con los parámetros
        Dim insertSql As String = "INSERT INTO '" & nomTabla & "' ('" & atributosInsert & ") VALUES (@"

        ' y acá tienen que cargar todos los params

        Dim sqlCmd As New SqlCommand(insertSql)

        Return DBCon.Instance.InsertStatement(sqlCmd)
    End Function

    Public Overridable Function obtenerListado()
        Return DBCon.Instance.SelectStatement("SELECT * FROM " + nomTabla)
    End Function

End Class
