Public Class frmAddClient

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MsgBox("El cliente se ha modificado correctamente", MsgBoxStyle.Information, "Success!")
        Me.Close()
        openForm(frmClients)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        openForm(frmClients)
        Me.Close()
    End Sub
End Class