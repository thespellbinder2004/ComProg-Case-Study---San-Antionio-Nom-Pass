Public Class formAdmin

    Dim listCustomer As List(Of String) = Globals.getCustomerList()
    Dim listCurCustomer As List(Of String)
    Class Guests
        Dim EnerssonTest
    End Class


    'GUEST TAB BY JOSEPH
    'START ------------------------------------------
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuestTable.CellContentClick
        Dim colName As String = dgvGuestTable.Columns(e.ColumnIndex).Name
        Dim rowIndex = dgvGuestTable.Rows(e.RowIndex).Index.ToString

        If colName = "columnEdit" Then
            listCurCustomer = Globals.getCustomerInfo(listCustomer(rowIndex))
            For i = 0 To listCurCustomer.Count - 1
                MsgBox(listCurCustomer(i))
            Next
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        listCustomer = Globals.getCustomerList()
        dgvGuestTable.Rows.Clear()
        For i = 0 To (listCustomer.Count - 1)
            Dim listInfo As List(Of String) = Globals.getCustomerInfo(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(0), listInfo(1), listInfo(4), listInfo(5), "4")
        Next
    End Sub
    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listCustomer = Globals.getCustomerList()
        dgvGuestTable.Rows.Clear()
        For i = 0 To (listCustomer.Count - 1)

            Dim listInfo As List(Of String) = Globals.getCustomerInfo(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(0), listInfo(1), listInfo(4), listInfo(5), "4")
        Next
    End Sub
    'GUEST TAB BY JOSEPH
    'END ------------------------------------------

End Class