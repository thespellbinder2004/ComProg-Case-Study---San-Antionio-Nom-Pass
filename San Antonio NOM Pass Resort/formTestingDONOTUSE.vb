Public Class formTestingDONOTUSE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dick As New List(Of String)
        dick = Globals.getCustomerList()
        Dim jesus = dick(0)
    End Sub
End Class