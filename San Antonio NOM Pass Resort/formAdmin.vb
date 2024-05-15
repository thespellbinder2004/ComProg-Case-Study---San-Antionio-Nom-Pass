Public Class formAdmin

    Dim listCustomer As List(Of String) = Globals.getCustomerList()
    Dim listCurCustomer As List(Of String)


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
    '12.    Address


    'GUEST TAB BY JOSEPH
    'START ------------------------------------------
    Dim ListofRooms As List(Of String) = Globals.getRoomsList()
    Dim SingleRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(0))
    Dim TwinRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(1))
    Dim StandardRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(2))
    Dim QueenRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(3))
    Dim KingRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(4))
    Dim ExecutiveRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(5))
    Dim PresidentialRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(6))



    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuestTable.CellContentClick
        Dim colName As String = dgvGuestTable.Columns(e.ColumnIndex).Name
        Dim rowIndex = dgvGuestTable.Rows(e.RowIndex).Index.ToString

        If colName = "columnEdit" Then
            listCurCustomer = Globals.getSplitString(listCustomer(rowIndex))
            tbcAdmin.SelectedTab = tabGuestInfo

            TextBox0.Text = listCurCustomer(0)
            TextBox1.Text = listCurCustomer(1)
            TextBox2.Text = listCurCustomer(2)
            TextBox3.Text = listCurCustomer(3)
            'txtbox4 age need fucntion
            TextBox4.Text = listCurCustomer(0)
            'txtbox5 # of guest
            TextBox5.Text = listCurCustomer(0)
            'txtbox6 address
            TextBox6.Text = listCurCustomer(11)
            'txtbox7 room type
            TextBox7.Text = listCurCustomer(0)
            'txtBox8 room Number
            For i = 0 To listCurCustomer.Count - 1
                'MsgBox(listCurCustomer(i))

            Next

        End If


    End Sub
    'GUEST TAB BY JOSEPH
    'END ------------------------------------------




    'REFRESH AND LOAD
    'START ------------------------------------------
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadData()


    End Sub

    Sub loadData()
        listCustomer = Globals.getCustomerList
        dgvGuestTable.Rows.Clear()

        For i = 0 To listCustomer.Count - 1
            Dim listInfo As List(Of String) = Globals.getSplitString(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(0), listInfo(1), listInfo(4), listInfo(5), listInfo(10))
        Next


        'ROOM NUMBERS CLEAR 
        cbSingleRoomNumbers.Items.Clear()
        cbTwinRoomNumbers.Items.Clear()
        cbStandardRoomNumbers.Items.Clear()
        cbQueenRoomNumbers.Items.Clear()
        cbKingRoomNumbers.Items.Clear()
        cbExecutiveRoomNumbers.Items.Clear()
        cbPresidentialRoomNumbers.Items.Clear()
        'END ------------------------------------
        listCustomer = Globals.getCustomerList()
        dgvGuestTable.Rows.Clear()
        For i = 0 To (listCustomer.Count - 1)
            Dim listInfo As List(Of String) = Globals.getSplitString(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(0), listInfo(1), listInfo(4), listInfo(5), listInfo(10))
        Next

        'SINGLE ROOM
        nudSingleAvailableRooms.Value = SingleRoom.Count - 1


        For i = 1 To SingleRoom.Count - 1
            cbSingleRoomNumbers.Items.Add(SingleRoom(i))
        Next
        cbSingleRoomNumbers.SelectedIndex = 0

        'TWIN ROOM  
        nudTwinAvailableRooms.Value = TwinRoom.Count - 1


        For i = 1 To TwinRoom.Count - 1
            cbTwinRoomNumbers.Items.Add(TwinRoom(i))
        Next
        cbTwinRoomNumbers.SelectedIndex = 0
        '
        'STANDARD ROOM  
        nudStandardAvailableRooms.Value = StandardRoom.Count - 1


        For i = 1 To StandardRoom.Count - 1
            cbStandardRoomNumbers.Items.Add(StandardRoom(i))
        Next
        cbStandardRoomNumbers.SelectedIndex = 0

        'QUEEN ROOM
        nudQueenAvailableRooms.Value = QueenRoom.Count - 1


        For i = 1 To QueenRoom.Count - 1
            cbQueenRoomNumbers.Items.Add(QueenRoom(i))
        Next
        cbQueenRoomNumbers.SelectedIndex = 0

        'KING ROOM
        nudKingAvailableRooms.Value = KingRoom.Count - 1


        For i = 1 To KingRoom.Count - 1
            cbKingRoomNumbers.Items.Add(KingRoom(i))
        Next
        cbKingRoomNumbers.SelectedIndex = 0

        'EXECUTIVE ROOM
        nudExecutiveAvailableRooms.Value = ExecutiveRoom.Count - 1


        For i = 1 To ExecutiveRoom.Count - 1
            cbExecutiveRoomNumbers.Items.Add(ExecutiveRoom(i))
        Next
        cbExecutiveRoomNumbers.SelectedIndex = 0

        'PRESIDENTIAL ROOM
        nudPresidentialAvailableRooms.Value = PresidentialRoom.Count - 1


        For i = 1 To PresidentialRoom.Count - 1
            cbPresidentialRoomNumbers.Items.Add(PresidentialRoom(i))
        Next
        cbPresidentialRoomNumbers.SelectedIndex = 0

    End Sub

    Private Sub formAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        listCustomer = Globals.getCustomerList()
        dgvGuestTable.Rows.Clear()
        For i = 0 To (listCustomer.Count - 1)

            Dim listInfo As List(Of String) = Globals.getSplitString(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(0), listInfo(1), listInfo(4), listInfo(5), listInfo(10))

        Next


    End Sub

    Private Sub tabRooms_Click(sender As Object, e As EventArgs) Handles tabRooms.Click

    End Sub







    'REFRESH AND LOAD
    'END ------------------------------------------






End Class