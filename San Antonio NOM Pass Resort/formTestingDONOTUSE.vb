Public Class formTestingDONOTUSE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dick As New List(Of String)
        dick = Globals.getCustomerList()
        Dim jesus = dick(1)

        Dim foo As List(Of String) = Globals.getSplitString(jesus)

        For i = 0 To (foo.Count - 1)
            MsgBox(foo(i))
        Next



    End Sub
End Class