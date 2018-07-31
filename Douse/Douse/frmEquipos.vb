Public Class frmEquipos
    Private Sub btnDeleteDevice_Click(sender As Object, e As EventArgs) Handles btnDeleteDevice.Click
        MsgBox("Está seguro que desea eliminar este equipo?", MsgBoxStyle.Exclamation, "Atencion!")
    End Sub
End Class
