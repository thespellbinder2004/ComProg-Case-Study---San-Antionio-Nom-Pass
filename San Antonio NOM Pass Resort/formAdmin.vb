Public Class formAdmin

    Dim listCustomer As List(Of String) = Globals.getCustomerList()
    Dim listCurCustomer As List(Of String)
    Class Guests

    End Class


    'Customer Info List 
    'Index  Item
    '0. 	First Name
    '1. 	Last Name
    '2. 	Sex
    '3. 	Birthdate
    '4. 	Arrival Date
    '5. 	Departure Date
    '7. 	Guest Regular
    '8. 	Guest Senior
    '9. 	Guest Minor
    '10.	Guest Total
    '11.	Stay Length


    'GUEST TAB BY JOSEPH
    'START ------------------------------------------
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuestTable.CellContentClick
        Dim colName As String = dgvGuestTable.Columns(e.ColumnIndex).Name
        Dim rowIndex = dgvGuestTable.Rows(e.RowIndex).Index.ToString

        If colName = "columnEdit" Then
            listCurCustomer = Globals.getSplitString(listCustomer(rowIndex))
            For i = 0 To listCurCustomer.Count - 1
                MsgBox(listCurCustomer(i))
            Next
        End If
    End Sub
    'GUEST TAB BY JOSEPH
    'END ------------------------------------------




    'REFRESH AND LOAD
    'START ------------------------------------------
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        listCustomer = Globals.getCustomerList()
        dgvGuestTable.Rows.Clear()
        For i = 0 To (listCustomer.Count - 1)
            Dim listInfo As List(Of String) = Globals.getSplitString(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(0), listInfo(1), listInfo(4), listInfo(5), listInfo(10))
        Next
    End Sub
    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listCustomer = Globals.getCustomerList()
        dgvGuestTable.Rows.Clear()
        For i = 0 To (listCustomer.Count - 1)

            Dim listInfo As List(Of String) = Globals.getSplitString(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(0), listInfo(1), listInfo(4), listInfo(5), listInfo(10))
            dgvGuestInfo.Rows.Add(listInfo(0), listInfo(1), listInfo(2), listInfo(3), listInfo(10))
        Next
    End Sub

    Private Sub tabRooms_Click(sender As Object, e As EventArgs) Handles tabRooms.Click

    End Sub


    'REFRESH AND LOAD
    'END ------------------------------------------






End Class