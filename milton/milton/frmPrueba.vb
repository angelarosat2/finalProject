Imports System.Data.SqlClient

Public Class frmPrueba
    Private Sub frmPrueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conn As DBCon = DBCon.Instance
        Dim reader As SqlDataReader = conn.SelectStatement("SELECT * FROM ciclistas")

        Dim dt = New DataTable()
        dt.Load(reader)

        dgvPrueba.AutoGenerateColumns = True
        dgvPrueba.DataSource = dt

        dgvPrueba.Refresh()

    End Sub

    Private Sub dgvPrueba_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrueba.CellContentClick

    End Sub
End Class
