Imports System.Net.Quic

Public Class formUser
    Dim listCustomer As New List(Of String)
    Dim listCustomerInfo As New List(Of List(Of String))
    Function Reload()
        listCustomer = Globals.getCustomerList
        For Each i In listCustomer
            listCustomerInfo.Add(Globals.getSplitString(listCustomer(i)))
        Next
        pnlCustomerDetails.Enabled = False
        pnlLogIn.Enabled = True
    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        For i = 0 To listCustomerInfo.Count - 1
            If listCustomerInfo(i)(0) = txtUsername.Text And listCustomerInfo(i)(1) = txtPassword.Text Then
                pnlCustomerDetails.Enabled = True
                pnlLogIn.Enabled = False
            End If
        Next
    End Sub

    Private Sub btnBookNow_Click(sender As Object, e As EventArgs) Handles btnBookNow.Click
        Close()
        formBooking.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Reload()
    End Sub

    Private Sub Label48_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class