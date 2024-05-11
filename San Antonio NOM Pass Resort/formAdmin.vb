Public Class formAdmin
    Class Guests
        Dim EnerssonTest
    End Class




    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuestTable.CellContentClick

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvGuestTable.Rows.Add("1", "Joseph", "Castro", "3", "4", "4")
    End Sub
End Class