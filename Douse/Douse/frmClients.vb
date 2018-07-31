Public Class frmClients
    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        openForm(frmOpciones)
        Me.Close()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        openForm(frmAddClient)
        Me.Close()
    End Sub

    Private Sub btnModifyClient_Click(sender As Object, e As EventArgs) Handles btnModifyClient.Click
        openForm(frmModifyClient)
        Me.Close()
    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        MsgBox("Esta seguro que desea eliminar este cliente?", MsgBoxStyle.Exclamation, "Atention")
    End Sub
End Class