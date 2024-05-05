﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formBooking
    Dim intStayLength
    Class CustomerDetails
        Dim strFirstName As String
        Dim strLastName As String
        'For the combobox, it can be seen in the properties.

        Dim cbSex As String
        Dim datBirth As Date
        Dim datArrival As Date
        Dim datDeparture As Date
        Dim intLengthOfStay As Integer

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
        Dim result
        result = MsgBox("Do you confirm all information is correctly filled out?", vbOKCancel, "San Antonio Nom Pass Resort")
        If result = vbOK Then
            Me.Hide()
            intStayLength = Math.Round((dtpDeparture.Value - dtpArrival.Value).TotalDays)
        End If

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
End Class
