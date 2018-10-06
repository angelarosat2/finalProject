Imports System.Data.SqlClient

Public Class Generica
    ' Public: Todos tienen acceso
    ' Protected: Acceso desde clase y herencia
    ' Private: Acceso solo desde la clase

    Protected nomTabla As String
    Protected atributosInsert() As String

    Public Overridable Function Insertar() As Integer
        ' Crear el comando
        Dim sqlCmd As New SqlCommand()

        ' Asignarle el texto
        ' INSERT INTO tabla (atriutos, que, voy, a, insertar) 
        ' VALUES (@atriutos, @que, @voy, @a, @insertar)
        sqlCmd.CommandText = "INSERT INTO " & nomTabla & "(" & String.Join(", ", atributosInsert) &
            ") VALUES (@" & String.Join(", @", atributosInsert) & ")"

        ' Asignarle todos los parámetros
        For Each propertyName As String In atributosInsert
            Dim pInfo As System.Reflection.PropertyInfo = Me.GetType().GetProperty(propertyName)
            Dim pValue As Object = pInfo.GetValue(Me, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing)

            sqlCmd.Parameters.AddWithValue("@" & propertyName, pValue)
        Next

        ' Ejecuta el Insert de DBConn y retorna lo mismo que ese método
        Return DBConn.Instance.InsertStatement(sqlCmd)
    End Function

    Public Overridable Function ObtenerListado()
        Return DBConn.Instance.SelectStatement("SELECT * FROM " + nomTabla)
    End Function

End Class
