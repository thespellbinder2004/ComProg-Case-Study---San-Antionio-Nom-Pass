Imports System.IO

Public Class formReciept
    Dim getTotalBill As Double
    Dim totalGuests As Integer
    Dim listRoomsSelected As List(Of String)
    Dim listCustomerInfo As List(Of String)
    Dim listOccupants As List(Of String)
    Dim intMaxCapacity As Integer = 0
    Private Sub formReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGuestsName.Text = formBooking.getFullName
        txtNumberOfGuest.Text = formBooking.getTotalGuest
        txtArrivalDate.Text = formBooking.getArrivalDate
        txtDepartureDate.Text = formBooking.getDepartureDate
        txtTotalPayment.Text = formRooms.getTotalBill
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        listCustomerInfo.Add("Rooms:")
        For Each i In listRoomsSelected
            listCustomerInfo.Add(i)
        Next

        listCustomerInfo.Add("Occupants:")
        For Each i In listOccupants
            listCustomerInfo.Add(i)
        Next

        Dim pathCustomersTxt As String = Path.GetFullPath("Customers.txt")
        Dim writerCustomer = New StreamWriter("C:\Users\Gabby\Documents\GitHub\ComProg-Case-Study---San-Antionio-Nom-Pass\San Antonio NOM Pass Resort\Customers.txt", True)
        writerCustomer.WriteLine(Globals.appendAllWithDashes(formBooking.getListCustomerInfo))
        writerCustomer.Close()

        Me.Close()
        formBooking.Show()
        formBooking.resetForm()

    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        Me.Hide()
        formRooms.Reload()
        formRooms.Show()

    End Sub
    Sub Reload()
        listCustomerInfo = formBooking.getListCustomerInfo
        listRoomsSelected = formRooms.getSelectedRooms
        listOccupants = formBooking.getListOccupants
        For i = 3 To listRoomsSelected.Count - 1 Step 4
            intMaxCapacity += listRoomsSelected(i)
        Next

    End Sub
    Sub setRooms()

    End Sub

End Class