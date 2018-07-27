Public Class frmModifyUser

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        'Adapta el form children con el padre
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MsgBox("Se ha modificado el usuario correctamente", MsgBoxStyle.Information, "Success!")
        Me.Close()
        openForm(frmUsuarios)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        openForm(frmUsuarios)
        Me.Close()
    End Sub
End Class