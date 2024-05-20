Imports System.Net.Quic

Public Class formUser
    Dim listCustomer As New List(Of String)
    Dim listCustomerInfo As New List(Of List(Of String))
    Function Reload()
        listCustomerInfo.Clear()
        listCustomer = Globals.getCustomerList
        For i = 0 To listCustomer.Count - 1
            listCustomerInfo.Add(Globals.getSplitString(listCustomer(i)))
        Next
        pnlCustomerDetails.Enabled = False
        pnlLogIn.Enabled = True

        txtAddress.Clear()
        txtAge.Clear()
        txtBirthday.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPassword.Clear()
        txtSex.Clear()
        txtTotalBill.Clear()
        txtUsername.Clear()
        lbGuests.Items.Clear()
        lbRooms.Items.Clear()

        txtAddress.ReadOnly = True
        txtAge.ReadOnly = True
        txtBirthday.ReadOnly = True
        txtFirstName.ReadOnly = True
        txtLastName.ReadOnly = True
        txtSex.ReadOnly = True
        txtTotalBill.ReadOnly = True

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim logged As Boolean = False
        For i = 0 To listCustomerInfo.Count - 1
            If listCustomerInfo(i)(0) = txtUsername.Text And listCustomerInfo(i)(1) = txtPassword.Text Then
                pnlCustomerDetails.Enabled = True
                pnlLogIn.Enabled = False
                MessageBox.Show("Log In Success!", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                setInfo(i)
                logged = True
                Exit For
            End If
        Next
        If logged = False Then
            MessageBox.Show("Incorrect Username or Password, try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Function setInfo(ByVal i As Integer)
        txtFirstName.Text = listCustomerInfo(i)(2)
        txtLastName.Text = listCustomerInfo(i)(3)
        txtSex.Text = listCustomerInfo(i)(4)
        txtBirthday.Text = listCustomerInfo(i)(5)
        txtArrivalDate.Text = listCustomerInfo(i)(6)
        txtDepartureDate.Text = listCustomerInfo(i)(7)
        txtAddress.Text = listCustomerInfo(i)(13)

        Dim indexOccupants As Integer = 0
        Dim indexRooms As Integer = 0

        For j = 0 To listCustomerInfo(i).Count - 1
            If listCustomerInfo(i)(j) = "Occupants:" Then
                indexOccupants = j
            End If
            If listCustomerInfo(i)(j) = "Rooms:" Then
                indexRooms = j
            End If
        Next

        Dim roomCount As Integer = 1
        For j = indexRooms + 1 To indexOccupants - 1 Step 4
            lbRooms.Items.Add(roomCount.ToString + ".")
            lbRooms.Items.Add("Type: " + listCustomerInfo(i)(j))
            lbRooms.Items.Add("Room Number: " + listCustomerInfo(i)(j + 1))
            lbRooms.Items.Add("Price: " + listCustomerInfo(i)(j + 2))
            lbRooms.Items.Add("Max Capacity: " + listCustomerInfo(i)(j + 3))
            lbRooms.Items.Add("")
            roomCount += 1
        Next

    End Function

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        formBooking.Show()
        Close()
    End Sub

    Private Sub formUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Globals.setAvailableRooms()

        Reload()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Reload()
    End Sub

End Class