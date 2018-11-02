Public Class frmAddUser
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

        frmUsuarios.Visible = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Insertar()
        Dim email As String = Trim(txtEmail.Text)
        Dim user As String = Trim(txtUser.Text)
        Dim password As String = Trim(txtPassword.Text)

        Dim usuario As Usuarios = New Usuarios(user, email, password)

        usuario.Insertar()
        MsgBox("Se ha agregado el usuario correctamente", MsgBoxStyle.Information, "Success!")
    End Sub

    Private Sub frmAddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class