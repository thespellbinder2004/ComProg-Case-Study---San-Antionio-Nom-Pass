Imports System.ComponentModel
Imports System.Drawing.Imaging
Imports System.Drawing.Text

Public Class formRooms

    Dim intAvailableSingleRoom = 0
    Dim intAvailableQueenRoom = 0
    Dim intAvailableKingRoom = 0
    Dim intAvailanleTwinRoom = 0
    Dim intAvailableStandardRoom = 0
    Dim intAvailableExecutiveRoom = 0
    Dim intAvailablePresidentialRoom = 0

    Public arrSingleRooms(4) As String
    Public arrQueenRooms(4) As String
    Public arrKingRooms(4) As String
    Public arrTwinRoom(4) As String
    Public arrStandardRoom(4) As String
    Public arrExecutiveRoom(4) As String
    Public arrPresidentialRoom(4) As String

    Class Rooms
        Public arrRooms(4) As Boolean
        Public arrNumRoom(4) As String
        Private intRate As Double
        Public Sub setRooms(room1 As String, room2 As String, room3 As String, room4 As String, room5 As String)
            arrNumRoom(0) = room1
            arrNumRoom(1) = room2
            arrNumRoom(2) = room3
            arrNumRoom(3) = room4
            arrNumRoom(4) = room5
        End Sub
        Public Sub setRate(rate As Double)
            intRate = rate
        End Sub
        Public Function getPayment(TotalNights As Integer) As String
            Dim dblPayment As Double = intRate * TotalNights
            Return dblPayment
        End Function
        Public Function removeRoom(intIndex As Integer) As String
            Return arrNumRoom(intIndex) = "Room Unavailable"
        End Function
        Public Function getRoom(intIndex As Integer) As Boolean
            Return arrRooms(intIndex)
        End Function
        Public Sub setRoomUnavailable(intIndex As Integer)
            arrRooms(intIndex) = True
        End Sub
    End Class
    Public Sub New()
        InitializeComponent()
        arrSingleRooms(0) = "101"
        arrSingleRooms(1) = "102"
        arrSingleRooms(2) = "103"
        arrSingleRooms(3) = "104"
        arrSingleRooms(4) = "105"
        arrTwinRoom(0) = "106"
        arrTwinRoom(1) = "107"
        arrTwinRoom(2) = "108"
        arrTwinRoom(3) = "109"
        arrTwinRoom(4) = "110"
        arrStandardRoom(0) = "111"
        arrStandardRoom(1) = "112"
        arrStandardRoom(2) = "113"
        arrStandardRoom(3) = "114"
        arrStandardRoom(4) = "115"
        arrQueenRooms(0) = "116"
        arrQueenRooms(1) = "117"
        arrQueenRooms(2) = "118"
        arrQueenRooms(3) = "119"
        arrQueenRooms(4) = "120"
        arrKingRooms(0) = "121"
        arrKingRooms(1) = "122"
        arrKingRooms(2) = "123"
        arrKingRooms(3) = "124"
        arrKingRooms(4) = "125"
        arrExecutiveRoom(0) = "201"
        arrExecutiveRoom(1) = "202"
        arrExecutiveRoom(2) = "203"
        arrExecutiveRoom(3) = "204"
        arrExecutiveRoom(4) = "205"
        arrPresidentialRoom(0) = "206"
        arrPresidentialRoom(1) = "207"
        arrPresidentialRoom(2) = "208"
        arrPresidentialRoom(3) = "209"
        arrPresidentialRoom(4) = "210"

    End Sub

    Private Sub btnBN1_Click(sender As Object, e As EventArgs) Handles btnSingleRoom.Click
        Dim singleRooms = New Rooms
        singleRooms.setRooms("101", "102", "103", "104", "105")
        singleRooms.setRate(999)
        If singleRooms.arrNumRoom.Length = 0 Then
            MsgBox("There are no available rooms")
        Else
            If intAvailableSingleRoom < 5 Then
                If singleRooms.getRoom(intAvailableSingleRoom) = False And (ComboBox1.Text = "") = False Then
                    Dim getRoom = MsgBox("Are you sure you want to pick this room?", vbYesNo, "Confirm")
                    If getRoom = 6 Then
                        singleRooms.setRoomUnavailable(intAvailableSingleRoom)
                        intAvailableSingleRoom += 1
                        TextBox1.Text = 5 - intAvailableSingleRoom
                        ComboBox1.Items.Remove(ComboBox1.Text)
                        singleRooms.removeRoom(5 - intAvailableSingleRoom)
                        formReciept.Show()
                        formReciept.txtGuestsName.Text = formBooking.txtFirstName.Text + " " + formBooking.txtLastName.Text
                        formReciept.txtNumberOfGuest.Text = formBooking.intTotalGuests
                        formBooking.intReceiptNumber += 1
                        formReciept.txtTotalPayment.Text = singleRooms.getPayment(formBooking.intTotalNight)
                        formReciept.txtArrivalDate.Text = formBooking.dtpArrival.Text
                        formReciept.txtDepartureDate.Text = formBooking.dtpDeparture.Text
                    End If
                Else
                    MsgBox("Choose a Room number")
                End If
            Else
                MsgBox("There are no availble rooms")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text.Contains("Info") Then
            Button1.Text = "Max Guest Number: 3" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 1"
        Else
            Button1.Text = "Click for more Info"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.Click
        If intAvailableSingleRoom > 4 Then
            MsgBox("There are no Available rooms", "Fully Booked", MessageBoxIcon.Warning)
        ElseIf ComboBox1.Text.Count = 0 Then
            For i = 0 To arrSingleRooms.Length - 1
                ComboBox1.Items.Add(arrSingleRooms(i))
            Next i
        End If
    End Sub

    Private Sub btnQueenRoom_Click(sender As Object, e As EventArgs) Handles btnQueenRoom.Click
        Dim queenRoom = New Rooms
        queenRoom.setRooms("116", "117", "118", "119", "120")
        queenRoom.setRate(1199)
        If queenRoom.arrNumRoom.Length = 0 Then
            MsgBox("There are no available rooms")
        Else
            If intAvailableQueenRoom < 5 Then
                If queenRoom.getRoom(intAvailableQueenRoom) = False And (ComboBox2.Text = "") = False Then
                    Dim getRoom = MsgBox("Are you sure you want to pick this room?", vbYesNo, "Confirm")
                    If getRoom = 6 Then
                        queenRoom.setRoomUnavailable(intAvailableQueenRoom)
                        intAvailableQueenRoom += 1
                        TextBox4.Text = 5 - intAvailableQueenRoom
                        ComboBox2.Items.Remove(ComboBox2.Text)
                        queenRoom.removeRoom(5 - intAvailableQueenRoom)
                        formReciept.Show()
                        formReciept.txtGuestsName.Text = formBooking.txtFirstName.Text + " " + formBooking.txtLastName.Text
                        formReciept.txtNumberOfGuest.Text = formBooking.intTotalGuests
                        formBooking.intReceiptNumber += 1
                        formReciept.txtTotalPayment.Text = queenRoom.getPayment(formBooking.intTotalNight)
                        formReciept.txtArrivalDate.Text = formBooking.dtpArrival.Text
                        formReciept.txtDepartureDate.Text = formBooking.dtpDeparture.Text
                    End If
                Else
                    MsgBox("Choose a Room number")
                End If
            Else
                MsgBox("There are no availble rooms")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'QUeenRoom Information
        If Button2.Text.Contains("Info") Then
            Button2.Text = "Max Guest Number: 3" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 1"
        Else
            Button2.Text = "Click for more Info"
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.Click 'queenrooms
        If intAvailableQueenRoom > 4 Then
            MsgBox("There are no Available rooms", "Fully Booked", MessageBoxIcon.Warning)
        ElseIf ComboBox2.Text.Count = 0 Then
            For i = 0 To arrQueenRooms.Length - 1
                ComboBox2.Items.Add(arrQueenRooms(i))
            Next i
        End If
    End Sub

    Private Sub btnKingRoom_Click(sender As Object, e As EventArgs) Handles btnKingRoom.Click
        Dim kingRoom = New Rooms
        kingRoom.setRooms("121", "122", "123", "124", "125")
        kingRoom.setRate(1299)
        If kingRoom.arrNumRoom.Length = 0 Then
            MsgBox("There are no available rooms")
        Else
            If intAvailableKingRoom < 5 Then
                If kingRoom.getRoom(intAvailableKingRoom) = False And (ComboBox3.Text = "") = False Then
                    Dim getRoom = MsgBox("Are you sure you want to pick this room?", vbYesNo, "Confirm")
                    If getRoom = 6 Then
                        kingRoom.setRoomUnavailable(intAvailableKingRoom)
                        intAvailableKingRoom += 1
                        TextBox6.Text = 5 - intAvailableKingRoom
                        ComboBox3.Items.Remove(ComboBox3.Text)
                        kingRoom.removeRoom(5 - intAvailableKingRoom)
                        formReciept.Show()
                        formReciept.txtGuestsName.Text = formBooking.txtFirstName.Text + " " + formBooking.txtLastName.Text
                        formReciept.txtNumberOfGuest.Text = formBooking.intTotalGuests
                        formBooking.intReceiptNumber += 1
                        formReciept.txtTotalPayment.Text = kingRoom.getPayment(formBooking.intTotalNight)
                        formReciept.txtArrivalDate.Text = formBooking.dtpArrival.Text
                        formReciept.txtDepartureDate.Text = formBooking.dtpDeparture.Text
                    End If
                Else
                    MsgBox("Choose a Room number")
                End If
            Else
                MsgBox("There are no availble rooms")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'kingroom information
        If Button3.Text.Contains("Info") Then
            Button3.Text = "Max Guest Number: 3" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 1"
        Else
            Button3.Text = "Click for more Info"
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.Click 'kingrooms
        If intAvailableKingRoom > 4 Then
            MsgBox("There are no Available rooms", "Fully Booked", MessageBoxIcon.Warning)
        ElseIf ComboBox3.Text.Count = 0 Then
            For i = 0 To arrKingRooms.Length - 1
                ComboBox3.Items.Add(arrKingRooms(i))
            Next i
        End If
    End Sub

    Private Sub btnTwinRoom_Click(sender As Object, e As EventArgs) Handles btnTwinRoom.Click
        Dim twinRoom = New Rooms
        twinRoom.setRooms("106", "107", "108", "109", "110")
        twinRoom.setRate(1799)
        If twinRoom.arrNumRoom.Length = 0 Then
            MsgBox("There are no available rooms")
        Else
            If intAvailanleTwinRoom < 5 Then
                If twinRoom.getRoom(intAvailanleTwinRoom) = False And (ComboBox4.Text = "") = False Then
                    Dim getRoom = MsgBox("Are you sure you want to pick this room?", vbYesNo, "Confirm")
                    If getRoom = 6 Then
                        twinRoom.setRoomUnavailable(intAvailanleTwinRoom)
                        intAvailanleTwinRoom += 1
                        TextBox12.Text = 5 - intAvailanleTwinRoom
                        ComboBox4.Items.Remove(ComboBox4.Text)
                        twinRoom.removeRoom(5 - intAvailanleTwinRoom)
                        formReciept.Show()
                        formReciept.txtGuestsName.Text = formBooking.txtFirstName.Text + " " + formBooking.txtLastName.Text
                        formReciept.txtNumberOfGuest.Text = formBooking.intTotalGuests
                        formBooking.intReceiptNumber += 1
                        formReciept.txtTotalPayment.Text = twinRoom.getPayment(formBooking.intTotalNight)
                        formReciept.txtArrivalDate.Text = formBooking.dtpArrival.Text
                        formReciept.txtDepartureDate.Text = formBooking.dtpDeparture.Text
                    End If
                Else
                    MsgBox("Choose a Room number")
                End If
            Else
                MsgBox("There are no availble rooms")
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'twinroom info
        If Button4.Text.Contains("Info") Then
            Button4.Text = "Max Guest Number: 8" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 2"
        Else
            Button4.Text = "Click for more Info"
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.Click 'twinrooms
        If intAvailanleTwinRoom > 4 Then
            MsgBox("There are no Available rooms", "Fully Booked", MessageBoxIcon.Warning)
        ElseIf ComboBox4.Text.Count = 0 Then
            For i = 0 To arrTwinRoom.Length - 1
                ComboBox4.Items.Add(arrTwinRoom(i))
            Next i
        End If
    End Sub

    Private Sub btnStandardRoom_Click(sender As Object, e As EventArgs) Handles btnStandardRoom.Click
        Dim standardRoom = New Rooms
        standardRoom.setRooms("111", "112", "113", "114", "115")
        standardRoom.setRate(1999)
        If standardRoom.arrNumRoom.Length = 0 Then
            MsgBox("There are no available rooms")
        Else
            If intAvailableStandardRoom < 5 Then
                If standardRoom.getRoom(intAvailableStandardRoom) = False And (ComboBox5.Text = "") = False Then
                    Dim getRoom = MsgBox("Are you sure you want to pick this room?", vbYesNo, "Confirm")
                    If getRoom = 6 Then
                        standardRoom.setRoomUnavailable(intAvailableStandardRoom)
                        intAvailableStandardRoom += 1
                        TextBox12.Text = 5 - intAvailableStandardRoom
                        ComboBox5.Items.Remove(ComboBox5.Text)
                        standardRoom.removeRoom(5 - intAvailableStandardRoom)
                        formReciept.Show()
                        formReciept.txtGuestsName.Text = formBooking.txtFirstName.Text + " " + formBooking.txtLastName.Text
                        formReciept.txtNumberOfGuest.Text = formBooking.intTotalGuests
                        formBooking.intReceiptNumber += 1
                        formReciept.txtTotalPayment.Text = standardRoom.getPayment(formBooking.intTotalNight)
                        formReciept.txtArrivalDate.Text = formBooking.dtpArrival.Text
                        formReciept.txtDepartureDate.Text = formBooking.dtpDeparture.Text
                    End If
                Else
                    MsgBox("Choose a Room number")
                End If
            Else
                MsgBox("There are no availble rooms")
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'standard info
        If Button5.Text.Contains("Info") Then
            Button5.Text = "Max Guest Number: 8" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 2"
        Else
            Button5.Text = "Click for more Info"
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.Click 'standardrooms
        If intAvailableStandardRoom > 4 Then
            MsgBox("There are no Available rooms", "Fully Booked", MessageBoxIcon.Warning)
        ElseIf ComboBox5.Text.Count = 0 Then
            For i = 0 To arrStandardRoom.Length - 1
                ComboBox5.Items.Add(arrStandardRoom(i))
            Next i
        End If
    End Sub

    Private Sub btnExecRoom_Click(sender As Object, e As EventArgs) Handles btnExecRoom.Click
        Dim ExecRoom = New Rooms
        ExecRoom.setRooms("201", "202", "203", "204", "205")
        ExecRoom.setRate(2299)
        If ExecRoom.arrNumRoom.Length = 0 Then
            MsgBox("There are no available rooms")
        Else
            If intAvailableExecutiveRoom < 5 Then
                If ExecRoom.getRoom(intAvailableExecutiveRoom) = False And (ComboBox6.Text = "") = False Then
                    Dim getRoom = MsgBox("Are you sure you want to pick this room?", vbYesNo, "Confirm")
                    If getRoom = 6 Then
                        ExecRoom.setRoomUnavailable(intAvailableExecutiveRoom)
                        intAvailableExecutiveRoom += 1
                        TextBox8.Text = 5 - intAvailableExecutiveRoom
                        ComboBox6.Items.Remove(ComboBox6.Text)
                        ExecRoom.removeRoom(5 - intAvailableStandardRoom)
                        formReciept.Show()
                        formReciept.txtGuestsName.Text = formBooking.txtFirstName.Text + " " + formBooking.txtLastName.Text
                        formReciept.txtNumberOfGuest.Text = formBooking.intTotalGuests
                        formBooking.intReceiptNumber += 1
                        formReciept.txtTotalPayment.Text = ExecRoom.getPayment(formBooking.intTotalNight)
                        formReciept.txtArrivalDate.Text = formBooking.dtpArrival.Text
                        formReciept.txtDepartureDate.Text = formBooking.dtpDeparture.Text
                    End If
                Else
                    MsgBox("Choose a Room number")
                End If
            Else
                MsgBox("There are no availble rooms")
            End If
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 'exec info
        If Button6.Text.Contains("Info") Then
            Button6.Text = "Max Guest Number: 8" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 2"
        Else
            Button6.Text = "Click for more Info"
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.Click 'execrooms
        If intAvailableExecutiveRoom > 4 Then
            MsgBox("There are no Available rooms", "Fully Booked", MessageBoxIcon.Warning)
        ElseIf ComboBox6.Text.Count = 0 Then
            For i = 0 To arrExecutiveRoom.Length - 1
                ComboBox6.Items.Add(arrExecutiveRoom(i))
            Next i
        End If
    End Sub

    Private Sub btnPresRoom_Click(sender As Object, e As EventArgs) Handles btnPresRoom.Click
        Dim pressRoom = New Rooms
        pressRoom.setRooms("206", "207", "208", "209", "210")
        pressRoom.setRate(2699)
        If pressRoom.arrNumRoom.Length = 0 Then
            MsgBox("There are no available rooms")
        Else
            If intAvailablePresidentialRoom < 5 Then
                If pressRoom.getRoom(intAvailablePresidentialRoom) = False And (ComboBox7.Text = "") = False Then
                    Dim getRoom = MsgBox("Are you sure you want to pick this room?", vbYesNo, "Confirm")
                    If getRoom = 6 Then
                        pressRoom.setRoomUnavailable(intAvailablePresidentialRoom)
                        intAvailablePresidentialRoom += 1
                        TextBox14.Text = 5 - intAvailablePresidentialRoom
                        ComboBox7.Items.Remove(ComboBox7.Text)
                        pressRoom.removeRoom(5 - intAvailablePresidentialRoom)
                        formReciept.Show()
                        formReciept.txtGuestsName.Text = formBooking.txtFirstName.Text + " " + formBooking.txtLastName.Text
                        formReciept.txtNumberOfGuest.Text = formBooking.intTotalGuests
                        formBooking.intReceiptNumber += 1
                        formReciept.txtTotalPayment.Text = pressRoom.getPayment(formBooking.intTotalNight)
                        formReciept.txtArrivalDate.Text = formBooking.dtpArrival.Text
                        formReciept.txtDepartureDate.Text = formBooking.dtpDeparture.Text
                    End If
                Else
                    MsgBox("Choose a Room number")
                End If
            Else
                MsgBox("There are no availble rooms")
            End If
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click 'exec info
        If Button7.Text.Contains("Info") Then
            Button7.Text = "Max Guest Number: 8" & vbNewLine & "Bathroom: 1" & vbNewLine & "Bedroom: 2"
        Else
            Button7.Text = "Click for more Info"
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.Click 'execrooms
        If intAvailablePresidentialRoom > 4 Then
            MsgBox("There are no Available rooms", "Fully Booked", MessageBoxIcon.Warning)
        ElseIf ComboBox7.Text.Count = 0 Then
            For i = 0 To arrPresidentialRoom.Length - 1
                ComboBox7.Items.Add(arrPresidentialRoom(i))
            Next i
        End If
    End Sub

    Private Sub formRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
