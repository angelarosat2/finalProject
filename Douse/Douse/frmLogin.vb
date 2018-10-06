Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim oLogin As New Login()

        Dim username As String = txtUser.Text
        Dim password As String = txtPassword.Text

        If oLogin.login(username, password) Then
            MsgBox("Yasabes", MsgBoxStyle.Exclamation, "YAS!")

            Me.Hide()
            frmPrincipal.Visible = True
        Else
            MsgBox("eeee aprendete el user", MsgBoxStyle.Exclamation, "Casi")
        End If


    End Sub
End Class