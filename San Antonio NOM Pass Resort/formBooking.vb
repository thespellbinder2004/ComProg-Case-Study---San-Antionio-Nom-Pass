Imports System.Net.Security
Imports San_Antonio_NOM_Pass_Resort.formRooms

Public Class formBooking
    Public intTotalNight As Double = 1.0
    Public intTotalGuests As Integer
    Public strUserName As String
    Public intReceiptNumber As Integer = 0

    Class Booking
        Private totalGuests As Integer
        Public Function getTotalGuests(x, y, z) As Integer
            totalGuests = x + y + z
            Return totalGuests
        End Function
        Public Sub fewGuests()

        End Sub
    End Class


    Private Sub btnSubmit_Click_1(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim booking = New Booking

        strUserName = txtFirstName.Text + TextBox2.Text
        intTotalGuests = booking.getTotalGuests(Val(NumericUpDown1.Text), Val(NumericUpDown2.Text), Val(NumericUpDown3.Text))

        If intTotalGuests > 0 And intTotalGuests < 4 Then
            booking.fewGuests()
        ElseIf intTotalGuests > 3 And intTotalGuests < 9 Then

        ElseIf intTotalGuests > 8 Then
        Else

        End If

        formRooms.Show()
    End Sub

    Private Sub formBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel5.BackColor = Color.FromArgb(100, 108, 107, 88)
        Panel4.BackColor = Color.FromArgb(200, 108, 107, 88)
        Panel3.BackColor = Color.FromArgb(200, 108, 107, 88)
        Panel2.BackColor = Color.FromArgb(200, 108, 107, 88)
        Panel1.BackColor = Color.FromArgb(200, 108, 107, 88)
        Label1.BackColor = Color.FromArgb(200, 108, 107, 88)


    End Sub
End Class
