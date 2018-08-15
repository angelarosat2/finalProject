Public Class frmUsuarios

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        'closeForms(form)
        'Adapta el form children con el padre
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        openForm(frmAddUser)
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        MsgBox("¿Está seguro que desea eliminar este usuario?", MsgBoxStyle.YesNo, "Atention")
    End Sub

    Private Sub btnModifyUser_Click(sender As Object, e As EventArgs) Handles btnModifyUser.Click
        openForm(frmModifyUser)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        openForm(frmOpciones)
        Me.Close()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        openForm(frmControlPanel)
        Me.Close()
    End Sub
End Class