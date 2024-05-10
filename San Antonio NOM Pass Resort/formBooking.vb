Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formBooking
    Dim intStayLength
    Public intTotalNight As Double = 1.0
    Public intTotalGuests As Integer
    Public strUserName As String
    Public intReceiptNumber As Integer = 0

    Dim listCustomerInfo As New List(Of String)({})

    Class Booking
        Private totalGuests As Integer
        Public Function getTotalGuests(x, y, z) As Integer
            totalGuests = x + y + z
            Return totalGuests
        End Function
        Public Sub fewGuests()

        End Sub
    End Class

    Class CustomerDetails
        Dim strFirstName As String
        Dim strLastName As String
        Dim strSex As String
        Dim strDatBirth As String
        Dim strDatDeparture As String
        Dim strDatArrival As String
        Dim strGuestSenior As String
        Dim strGuestMinor As String
        Dim strGuestRegular As String

        'For the combobox, it can be seen in the properties.


        Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal sex As String, ByVal birthday As String, ByVal arrival As String, ByVal departure As String, ByVal senior As String, ByVal minor As String, ByVal regular As String)
            strFirstName = firstName
            strLastName = lastName
            strSex = sex
            strDatBirth = birthday
            strDatArrival = arrival
            strDatDeparture = departure
            strGuestSenior = senior
            strGuestMinor = minor
            strGuestRegular = regular

        End Sub
        Function getCustomerDetails()
            Return strFirstName + "-" + strLastName + "-" + strSex + "-" + strDatBirth + "-" + strDatArrival + "-" + strDatDeparture + "-" + strGuestSenior + "-" + strGuestMinor + "-" + strGuestRegular
        End Function
    End Class

    Private Sub formBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' already customized in properties
        dtpBirth.Format = DateTimePickerFormat.Custom
        dtpBirth.CustomFormat = "ddd, MM / dd / yyyy"

        cbSex.Items.Add("Male")
        cbSex.Items.Add("Female")

        dtpArrival.Format = DateTimePickerFormat.Custom
        dtpArrival.CustomFormat = "ddd, MM / dd / yyyy"
        dtpArrival.MinDate = New DateTime(2024, 1, 1)

        dtpDeparture.Format = DateTimePickerFormat.Custom
        dtpDeparture.CustomFormat = "ddd, MM / dd / yyyy"
        dtpDeparture.MinDate = New DateTime(2024, 1, 1)

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim booking = New Booking

        strUserName = txtFirstName.Text + txtLastName.Text
        intTotalGuests = booking.getTotalGuests(Val(nudRegularGuests.Text), Val(nudMinorGuests.Text), Val(nudSeniorGuests.Text))

        If intTotalGuests > 0 And intTotalGuests < 4 Then
            booking.fewGuests()
        ElseIf intTotalGuests > 3 And intTotalGuests < 9 Then

        ElseIf intTotalGuests > 8 Then
        Else

        End If

        formRooms.Show()

        Dim result
        result = MsgBox("Do you confirm all information is correctly filled out?", vbOKCancel, "San Antonio Nom Pass Resort")
        If result = vbOK Then
            Me.Hide()
            intStayLength = Math.Round((dtpDeparture.Value - dtpArrival.Value).TotalDays)
        End If
        setCustomerDetails()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        formSplashScreen.ProgressBar1.Value = 1
        formSplashScreen.Timer1.Start()
        formSplashScreen.Show()
    End Sub

    Private Sub dtpArrival_ValueChanged(sender As Object, e As EventArgs) Handles dtpArrival.ValueChanged
        dtpDeparture.MinDate = dtpArrival.Value.AddDays(1)
    End Sub

    Function readCustomer()
        Dim xd As String = Path.GetFullPath("Customers.txt")
        Dim sheesh = New StreamReader(xd)
        Dim cumList = sheesh.ReadLine.Split("-")
        Return cumList(0)
    End Function

    Sub setCustomerDetails()

        Dim nameFirst = txtFirstName.Text
        Dim nameLast = txtLastName.Text
        Dim sex = cbSex.Text
        Dim dateBirth = dtpBirth.Text
        Dim dateArrival = dtpArrival.Text
        Dim dateDeparture = dtpDeparture.Text
        Dim guestSen = nudSeniorGuests.Value.ToString
        Dim guestMin = nudMinorGuests.Value.ToString
        Dim guestReg = nudRegularGuests.Value.ToString

        Dim customerInfo = New CustomerDetails(nameFirst, nameLast, sex, dateBirth, dateArrival, dateDeparture, guestSen, guestMin, guestReg)
        listCustomerInfo.Add(customerInfo.getCustomerDetails())


        Dim xd As String = Path.GetFullPath("Customers.txt")
        Dim writerCustomer = New StreamWriter("C:\Users\Gabby\Documents\GitHub\ComProg-Case-Study---San-Antionio-Nom-Pass\San Antonio NOM Pass Resort\Customers.txt", True)
        writerCustomer.WriteLine(customerInfo.getCustomerDetails())
        writerCustomer.Close()
        MsgBox(readCustomer())

    End Sub

End Class
