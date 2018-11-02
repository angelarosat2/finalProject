Public Class frmAddUser
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()

        frmUsuarios.Visible = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Insertar()
        MsgBox("Se ha agregado el usuario correctamente", MsgBoxStyle.Information, "Success!")
    End Sub
End Class