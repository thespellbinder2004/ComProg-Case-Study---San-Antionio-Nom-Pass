Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.IO
Imports System.Net.Quic
Imports System.Runtime.CompilerServices

Public Class formRooms

    Dim listRoomNums As New List(Of List(Of String))
    Dim totalBill As Double


    Private Sub formRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listRooms = Globals.getRoomsList()
        Reload()
    End Sub

    Sub Reload()
        Dim listRooms As List(Of String) = Globals.getRoomsList()
        Dim singleRoom As List(Of String) = Globals.getSplitString(Globals.getRoomsList()(0))

        Dim arrCbRoomNum As Array = {cbSingleRoomNumber, cbTwinRoomNumber, cbStandardRoomNumber, cbQueenRoomNumber, cbKingRoomNumber, cbExecutiveRoomNumber, cbPresidentialRoomNumber}
        Dim arrTxtAvailableRoom As Array = {txtSingleAvailableRoom, txtTwinAvailableRoom, txtStandardAvailableRoom, txtQueenAvailableRoom, txtKingAvailableRoom, txtExecutiveAvailableRoom, txtPresidentialAvailableRoom}

        For i = 0 To listRooms.Count - 1
            listRoomNums.Add(Globals.getSplitString(listRooms(i)))
        Next

        For i = 0 To listRoomNums.Count - 1
            setRoomNum(arrCbRoomNum(i), listRoomNums(i))
            arrCbRoomNum(i).SelectedIndex = 0
            arrTxtAvailableRoom(i).Text = listRoomNums(i).Count.ToString - 1
        Next

    End Sub

    Sub setRoomNum(ByRef cb As ComboBox, ByVal listRoom As List(Of String))
        cb.Items.Clear()
        For i = 1 To listRoom.Count - 1
            cb.Items.Add(listRoom(i))
        Next
    End Sub

    Function submitBook(ByVal typeRoom As String, ByVal cbIndex As String, ByVal maxCapacity As Integer, ByVal roomCost As Integer, ByVal index As Integer)

        Dim mbResult = MessageBox.Show("Do you confirm the details that you entered?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If mbResult = DialogResult.Yes Then
            Dim listCustomer As New List(Of String)
            listCustomer = formBooking.getListCustomerInfo()
            listCustomer.Add(typeRoom)
            listCustomer.Add(listRoomNums(index)(cbIndex + 1))

            totalBill = calcTotalBill(formBooking.getGuestToPay, formBooking.getLengthOfStay, roomCost, maxCapacity)
            listCustomer.Add(totalBill)

            Dim customerInfo As String = appendAllWithDashes(listCustomer)

            listRoomNums(index).RemoveAt(cbIndex + 1)

            Dim pathCustomersTxt As String = Path.GetFullPath("Customers.txt")
            Dim writerCustomer = New StreamWriter(pathCustomersTxt, True)
            writerCustomer.WriteLine(customerInfo)
            writerCustomer.Close()

            Dim pathRoomsTxt As String = Path.GetFullPath("Rooms.txt")
            System.IO.File.WriteAllText(pathRoomsTxt, "")
            Dim writerRooms = New StreamWriter(pathRoomsTxt, True)

            For i = 0 To listRoomNums.Count - 1
                writerRooms.Write(listRoomNums(i)(0))
                For j = 1 To listRoomNums(i).Count - 1
                    writerRooms.Write("-" + listRoomNums(i)(j))
                Next
                writerRooms.WriteLine()
            Next

            writerRooms.Close()

            Close()
            formReciept.Show()
        End If

    End Function
    Function appendAllWithDashes(ByVal listOfString As List(Of String))
        Dim appendedString As String
        appendedString = listOfString(0)
        For i = 1 To listOfString.Count - 1
            appendedString += "-" + listOfString(i)
        Next
        Return appendedString
    End Function

    Function calcTotalBill(ByVal Guests As Double, ByVal lengthOfStay As Double, ByVal roomCost As Double, ByVal maxCapacity As Double)
        Dim totalBill As Double
        Dim additionBill As Double = 0
        If Guests > maxCapacity Then
            additionBill = 500 * (Guests - maxCapacity)
        End If
        totalBill = (lengthOfStay * roomCost) + additionBill
        Return totalBill

    End Function


    Private Sub btnSingleRoomBook_Click(sender As Object, e As EventArgs) Handles btnSingleRoomBook.Click
        submitBook("Single Room", cbSingleRoomNumber.SelectedIndex, 1, 999, 0)
    End Sub
    Private Sub btnTwinRoomBook_Click(sender As Object, e As EventArgs) Handles btnTwinRoomBook.Click
        submitBook("Twin Room", cbTwinRoomNumber.SelectedIndex, 5, 1799, 1)
    End Sub
    Private Sub btnStandardRoomBook_Click(sender As Object, e As EventArgs) Handles btnStandardRoomBook.Click
        submitBook("Standard Room", cbStandardRoomNumber.SelectedIndex, 6, 1999, 2)
    End Sub

    Private Sub btnQueenRoomBook_Click(sender As Object, e As EventArgs) Handles btnQueenRoomBook.Click
        submitBook("Queen Room", cbQueenRoomNumber.SelectedIndex, 2, 1199, 3)
    End Sub

    Private Sub btnKingRoomBook_Click(sender As Object, e As EventArgs) Handles btnKingRoomBook.Click
        submitBook("King Room", cbKingRoomNumber.SelectedIndex, 3, 1399, 4)
    End Sub

    Private Sub btnExecRoomBook_Click(sender As Object, e As EventArgs) Handles btnExecRoomBook.Click
        submitBook("Executive Room", cbExecutiveRoomNumber.SelectedIndex, 8, 2299, 5)
    End Sub

    Private Sub btnPresRoomBook_Click(sender As Object, e As EventArgs) Handles btnPresRoomBook.Click
        submitBook("Presidential Room", cbPresidentialRoomNumber.SelectedIndex, 10, 2699, 6)
    End Sub

    Private Sub btnSingleRoomInfo_Click(sender As Object, e As EventArgs) Handles btnSingleRoomInfo.Click
        If btnSingleRoomInfo.Text.Contains("Info") Then
            btnSingleRoomInfo.Text = "Max Guest Number: 1" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 1"
        Else
            btnSingleRoomInfo.Text = "Click for more Info"
        End If
    End Sub

    Private Sub btnQueenRoomInfo_Click(sender As Object, e As EventArgs) Handles btnQueenRoomInfo.Click
        If btnSingleRoomInfo.Text.Contains("Info") Then
            btnSingleRoomInfo.Text = "Max Guest Number: 2" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 1"
        Else
            btnSingleRoomInfo.Text = "Click for more Info"
        End If
    End Sub

    Private Sub btnKingRoomInfo_Click(sender As Object, e As EventArgs) Handles btnKingRoomInfo.Click
        If btnSingleRoomInfo.Text.Contains("Info") Then
            btnSingleRoomInfo.Text = "Max Guest Number: 3" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 1"
        Else
            btnSingleRoomInfo.Text = "Click for more Info"
        End If
    End Sub

    Private Sub btnTwinRoomInfo_Click(sender As Object, e As EventArgs) Handles btnTwinRoomInfo.Click
        If btnSingleRoomInfo.Text.Contains("Info") Then
            btnSingleRoomInfo.Text = "Max Guest Number: 4" & vbNewLine & "Bathroom: 2" & vbNewLine & "Bedroom: 2"
        Else
            btnSingleRoomInfo.Text = "Click for more Info"
        End If
    End Sub

    Private Sub btnStandardRoomInfo_Click(sender As Object, e As EventArgs) Handles btnStandardRoomInfo.Click
        If btnSingleRoomInfo.Text.Contains("Info") Then
            btnSingleRoomInfo.Text = "Max Guest Number: 6" & vbNewLine & "Bathroom: 2" & vbNewLine & "Bedroom: 2"
        Else
            btnSingleRoomInfo.Text = "Click for more Info"
        End If
    End Sub

    Private Sub btnExecutiveRoomInfo_Click(sender As Object, e As EventArgs) Handles btnExecutiveRoomInfo.Click
        If btnSingleRoomInfo.Text.Contains("Info") Then
            btnSingleRoomInfo.Text = "Max Guest Number: 8" & vbNewLine & "Bathroom: 2" & vbNewLine & "Bedroom: 2"
        Else
            btnSingleRoomInfo.Text = "Click for more Info"
        End If
    End Sub

    Private Sub btnPresidentialRoomInfo_Click(sender As Object, e As EventArgs) Handles btnPresidentialRoomInfo.Click
        If btnSingleRoomInfo.Text.Contains("Info") Then
            btnSingleRoomInfo.Text = "Max Guest Number: 10" & vbNewLine & "Bathroom: 2" & vbNewLine & "Bedroom: 2"
        Else
            btnSingleRoomInfo.Text = "Click for more Info"
        End If
    End Sub

    'GETTER FUNCTIONS
    'START ---------------------------------------
    Function getTotalBill()
        Return totalBill
    End Function

End Class
