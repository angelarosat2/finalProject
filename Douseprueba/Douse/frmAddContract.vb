Public Class frmAddContract
    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        openForm(frmDevices)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MsgBox("Se ha agregado correctamente el nuevo contrato", MsgBoxStyle.Information, "Éxito")
    End Sub
End Class