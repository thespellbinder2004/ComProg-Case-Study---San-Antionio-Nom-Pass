Public Class formReciept
    Dim getTotalBill As Double
    Private Sub formReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGuestsName.Text = formBooking.getFullName
        txtNumberOfGuest.Text = formBooking.getTotalGuest
        txtArrivalDate.Text = formBooking.getArrivalDate
        txtDepartureDate.Text = formBooking.getDepartureDate
        txtTotalPayment.Text = formRooms.getTotalBill
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
        formBooking.Show()
        formBooking.resetForm()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        Me.Hide()
        formRooms.Show()

    End Sub

End Class