Imports System.IO

Public Class Globals
    Shared pathCustomersTxt As String = Path.GetFullPath("Customers.txt")
    Shared Function getCustomerList()
        Dim listCustomer As New List(Of String)
        Dim readerCustomersTxt = New StreamReader(pathCustomersTxt)
        Dim count As Integer = 0
        While Not readerCustomersTxt.EndOfStream
            listCustomer.Add(readerCustomersTxt.ReadLine)
        End While
        readerCustomersTxt.Close()
        Return listCustomer
    End Function

    Shared Function getCustomerInfo(ByVal cust As String)
        Dim custInfoList = cust.Split("-")
        Return custInfoList
    End Function


End Class
