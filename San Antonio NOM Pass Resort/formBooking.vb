Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formBooking
    Public intTotalNight As Integer = 0
    Public intTotalGuests As Integer = 0
    Public intSeniorGuests As Integer = 0
    Public intMinorGuests As Integer = 0
    Public intRegularGuests As Integer = 0
    Public intReceiptNumber As Integer = 0
    Dim listCustomerInfo As New List(Of String)({})

    Class Booking

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
        Dim strGuestTotal As String
        Dim strStayLength As String

        'For the combobox, it can be seen in the properties.
        Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal sex As String, ByVal birthday As String, ByVal arrival As String, ByVal departure As String, ByVal regular As String, ByVal senior As String, ByVal minor As String, ByVal total As String, ByVal stayLength As String)
            strFirstName = firstName
            strLastName = lastName
            strSex = sex
            strDatBirth = birthday
            strDatArrival = arrival
            strDatDeparture = departure
            strGuestSenior = senior
            strGuestMinor = minor
            strGuestRegular = regular
            strGuestTotal = total
            strStayLength = stayLength
        End Sub
        Function getCustomerDetails()
            Return strFirstName + "-" + strLastName + "-" + strSex + "-" + strDatBirth + "-" + strDatArrival + "-" + strDatDeparture + "-" + strGuestRegular + "-" + strGuestSenior + "-" + strGuestMinor + "-" + strGuestTotal + "-" + strStayLength
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

        intMinorGuests = nudMinorGuests.Value
        intSeniorGuests = nudSeniorGuests.Value
        intRegularGuests = nudRegularGuests.Value
        intTotalGuests = intMinorGuests + intSeniorGuests + intRegularGuests

        If (Not intTotalGuests > 0) Or txtFirstName.Text = "" Or txtLastName.Text = "" Then
            MessageBox.Show("Please Input Required Elements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result = MessageBox.Show("Do you confirm all information is correctly filled out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then

                formRooms.Show()
                setCustomerDetails()
                Me.Hide()

            End If

        End If

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dtpArrival_ValueChanged(sender As Object, e As EventArgs) Handles dtpArrival.ValueChanged
        dtpDeparture.MinDate = dtpArrival.Value.AddDays(1)
    End Sub


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
        Dim guestTotal = (nudSeniorGuests.Value + nudMinorGuests.Value + nudSeniorGuests.Value).ToString
        Dim intStayLength = Math.Round((dtpDeparture.Value - dtpArrival.Value).TotalDays)

        Dim customerInfo = New CustomerDetails(nameFirst, nameLast, sex, dateBirth, dateArrival, dateDeparture, guestReg, guestSen, guestMin, guestTotal, intStayLength)
        listCustomerInfo.Add(customerInfo.getCustomerDetails())

        Dim pathCustomersTxt As String = Path.GetFullPath("Customers.txt")
        Dim writerCustomer = New StreamWriter(pathCustomersTxt, True)
        writerCustomer.WriteLine(customerInfo.getCustomerDetails())
        writerCustomer.Close()

    End Sub


End Class
