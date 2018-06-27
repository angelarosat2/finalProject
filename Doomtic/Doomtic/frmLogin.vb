Public Class frmLogin

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim usr, pwd As String
        usr = Trim(txtUsername.Text)
        pwd = Trim(txtPassword.Text)

        'Campos no esten vacios
        If usr = "" Then
            MsgBox("Debe ingresar nombre de usuario", MsgBoxStyle.Exclamation, "Error")
        ElseIf pwd = "" Then
            MsgBox("Debe ingresar contraseña", MsgBoxStyle.Exclamation, "Error")
            'usr y pwd correctos
        ElseIf Not Login(usr, pwd) Then
            MsgBox("Usuario y/o contraseña incorrectos", MsgBoxStyle.Exclamation, "Error")
        Else
            MsgBox("Inicio de sesión correcto", MsgBoxStyle.Information, "Ha funcionado")

            'acá falta cargar el formulario principal
            frmPrincipal.Show()

            Me.Close()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function Login(usr As String, pwd As String) As Boolean
        Return usr = "user01" And pwd = "Password01"
    End Function

End Class
