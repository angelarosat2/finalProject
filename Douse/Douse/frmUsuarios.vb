Imports System.Data.SqlClient

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

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles lvwUsers.DoubleClick
        openForm(frmControlPanel)
        Me.Close()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oUsuarios As New Usuarios()

        Dim resultado As SqlDataReader = oUsuarios.ObtenerListado()

        If resultado.HasRows Then
            While resultado.Read
                Dim document As ListViewItem = lvwUsers.Items.Add(resultado("document_employees").ToString)
                document.SubItems.Add(resultado("username").ToString)
                document.SubItems.Add(resultado("email").ToString)
                document.SubItems.Add(resultado("password").ToString)
            End While
        End If
        resultado.Close()
    End Sub

    Private Sub lvwUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwUsers.SelectedIndexChanged

    End Sub
End Class