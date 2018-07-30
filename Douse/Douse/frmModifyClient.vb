Public Class frmModifyClient

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) 
        openForm(frmClientes)
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) 
        MsgBox("El usuario se ha modificado correctamente", MsgBoxStyle.Information, "Success!")
        Me.Close()
        openForm(frmClientes)
    End Sub

End Class