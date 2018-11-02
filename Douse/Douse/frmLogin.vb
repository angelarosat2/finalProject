Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        'closeForms(form)
        'Adapta el form children con el padre
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim oLogin As New Login()

        Dim username As String = txtUser.Text
        Dim password As String = txtPassword.Text

        If oLogin.login(username, password) Then

            Me.Hide()
            'frmPrincipal.Visible = True
            openForm(frmOpciones)
        Else
            MsgBox("El usuario o la contraseña es incorrecta", MsgBoxStyle.Exclamation, "Algo salio mal...")
        End If


    End Sub
End Class