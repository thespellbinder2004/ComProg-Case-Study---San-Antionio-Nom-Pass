﻿Imports System.IO

Public Class formAdmin

    Dim listCustomer As List(Of String) = Globals.getCustomerList()
    Dim listCurCustomer As List(Of String)
    Public intChange As Double
    Public strPayment As Double
    Dim intCounter As Integer

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
    Dim today = Date.Today

    'Function for getting the Age
    Function getAge(ByVal dateBirth As Date) As Integer

        MsgBox(dateBirth.ToString)
        MsgBox(dateBirth.Year)

        Dim age As Integer = today.Year - dateBirth.Year
        MsgBox(age.ToString)
        If (dateBirth > today.AddYears(-age)) Then
            age -= 1
        End If

        Return age

    End Function

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuestTable.CellContentClick
        Dim colName As String = dgvGuestTable.Columns(e.ColumnIndex).Name
        Dim rowIndex = dgvGuestTable.Rows(e.RowIndex).Index.ToString


        If colName = "columnEdit" Then

            listCurCustomer = Globals.getSplitString(listCustomer(rowIndex))
            tbcAdmin.SelectedTab = tabGuestInfo
            Dim dateBirth As Date = Convert.ToDateTime(listCurCustomer(5))
            Dim age As Integer = getAge(dateBirth)
            intCounter = rowIndex

            listCurCustomer(listCurCustomer.Count - 1) = "True"

            TextBox0.Text = listCurCustomer(2)
            TextBox1.Text = listCurCustomer(3)
            TextBox2.Text = listCurCustomer(4)
            TextBox3.Text = listCurCustomer(5)
            'txtbox4 age need fucntion
            TextBox4.Text = age
            'txtbox5 # of guest
            TextBox5.Text = listCurCustomer(11)
            'txtbox6 address
            TextBox6.Text = listCurCustomer(13)
            'txtbox7 room type
            TextBox7.Text = listCurCustomer(15)
            'txtBox8 room Number
            TextBox8.Text = listCurCustomer(16)
            'textbox9 total bill
            TextBox9.Text = listCurCustomer(listCurCustomer.Count - 2)
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
        listCustomer = Globals.getCustomerList()
        dgvGuestTable.Rows.Clear()

        For i = 0 To listCustomer.Count - 1
            Dim listInfo As List(Of String) = Globals.getSplitString(listCustomer(i))
            dgvGuestTable.Rows.Add("Edit", listInfo(2), listInfo(3), listInfo(6), listInfo(7), listInfo(12))
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
            dgvGuestTable.Rows.Add("Edit", listInfo(2), listInfo(3), listInfo(6), listInfo(7), listInfo(12))
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
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Panel2.Visible = True
        Label57.Visible = True
        Label56.Visible = True
        Label55.Visible = True
        txtTotBill.Visible = True
        txtPaym.Visible = True
        btnConfi.Visible = True
        btnCanc.Visible = True
        txtTotBill.Text = TextBox9.Text
    End Sub

    Private Sub btnCanc_Click(sender As Object, e As EventArgs) Handles btnCanc.Click
        Panel2.Visible = False
        Label57.Visible = False
        Label56.Visible = False
        Label55.Visible = False
        txtTotBill.Visible = False
        txtPaym.Visible = False
        btnConfi.Visible = False
        btnCanc.Visible = False
        txtPaym.Text = ""
        txtTotBill.Text = TextBox9.Text
    End Sub


    Private Sub btnConfi_Click(sender As Object, e As EventArgs) Handles btnConfi.Click
        If txtPaym.Text = txtTotBill.Text Then
            checkOut()
            MsgBox("Payment Confirmed!", 0, "Payment")
        ElseIf (Val((txtPaym.Text)) > Val((txtTotBill.Text))) Then
            checkOut()
            MsgBox("Payment Confirmed! Change:" + (Val((txtPaym.Text)) - Val((txtTotBill.Text))).ToString, 0, "Payment")
        ElseIf MsgBox("Insufficient Payment", 0, "Payment") Then
        End If

        Panel2.Visible = False
        Label57.Visible = False
        Label56.Visible = False
        Label55.Visible = False
        txtTotBill.Visible = False
        txtPaym.Visible = False
        btnConfi.Visible = False
        btnCanc.Visible = False
        txtPaym.Text = ""
        txtTotBill.Text = TextBox9.Text


    End Sub
    Sub checkOut()
        intChange = (Val((txtPaym.Text)) - Val((txtTotBill.Text)))
        strPayment = Val(txtPaym.Text)
        Me.Hide()
        formReciept.btnAddRoom.Visible = False
        formReciept.Show()

        formReciept.txtGuestsName.Text = listCurCustomer(2) + " " + listCurCustomer(3)
        formReciept.txtNumberOfGuest.Text = listCurCustomer(11)
        formReciept.txtArrivalDate.Text = listCurCustomer(6)
        formReciept.txtDepartureDate.Text = listCurCustomer(7)
        formReciept.txtTotalPayment.Text = listCurCustomer(listCurCustomer.Count - 2)
        formReciept.txtPayment.Text = strPayment
        formReciept.txtChange.Text = intChange

        listCurCustomer(listCurCustomer.Count - 1) = "True"
        MsgBox(listCurCustomer(listCurCustomer.Count - 1))
        Dim pathCustomersTxt As String = Path.GetFullPath("Customers.txt")
        Dim writerCustomer = System.IO.File.ReadAllLines(pathCustomersTxt)
        writerCustomer(intCounter) = Globals.appendAllWithDashes(listCurCustomer)
        System.IO.File.WriteAllLines(pathCustomersTxt, writerCustomer)

    End Sub







    'REFRESH AND LOAD
    'END ------------------------------------------






End Class