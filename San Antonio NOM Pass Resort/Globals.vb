Imports System.IO

Public Class Globals
    Function readCustomer()
        Dim xd As String = Path.GetFullPath("Customers.txt")
        Dim sheesh = New StreamReader(xd)
        Dim cumList = sheesh.ReadLine.Split("-")
        Return cumList(1)
    End Function

End Class
