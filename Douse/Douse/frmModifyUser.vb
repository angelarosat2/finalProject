Public Class frmModifyUser

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        'Adapta el form children con el padre
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim email As String = txtEmail.Text
        Dim username As String = txtUser.Text
        Dim password As String = txtPassword.Text
        Dim usuario As Usuarios = New Usuarios(username, email, password)

        usuario.editar("email", txtEmail.Text)
        MsgBox("Se ha modificado el usuario correctamente", MsgBoxStyle.Information, "Success!")

        Me.Close()
        openForm(frmUsuarios)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        openForm(frmUsuarios)
        Me.Close()
    End Sub

End Class