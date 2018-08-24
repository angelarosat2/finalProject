Public Class frmContracts

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        openForm(frmOpciones)
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Me.Close()
        openForm(frmAddContract)
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        MsgBox("Está seguro que desea eliminar este contrato?", MsgBoxStyle.Exclamation, "Atención!")
    End Sub

    Private Sub btnModifyContract_Click(sender As Object, e As EventArgs) Handles btnModifyContract.Click
        Me.Close()
        openForm(frmModifyContract)
    End Sub
End Class