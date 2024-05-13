Imports System.IO

Public Class Globals
    Shared pathCustomersTxt As String = Path.GetFullPath("Customers.txt")
    Shared pathRoomsTxt As String = Path.GetFullPath("Rooms.txt")
    Shared Function getCustomerList()
        Dim listCustomer As New List(Of String)
        Dim readerCustomersTxt = New StreamReader(pathCustomersTxt)

        While Not readerCustomersTxt.EndOfStream
            listCustomer.Add(readerCustomersTxt.ReadLine)
        End While
        readerCustomersTxt.Close()
        Return listCustomer
    End Function

    Shared Function getSplitString(ByVal cust As String)
        Dim custInfoList = cust.Split("-")
        Return custInfoList.ToList
    End Function

    Shared Function getRoomsList()
        Dim listRooms As New List(Of String)
        Dim readerRoomsTxt = New StreamReader(pathRoomsTxt)
        While Not readerRoomsTxt.EndOfStream
            listRooms.Add(readerRoomsTxt.ReadLine)
        End While
        readerRoomsTxt.Close()
        Return listRooms
    End Function

    Shared Function removeBlanks(ByVal list As List(Of String))
        For i = 0 To list.Count - 1
            If list(i) = "" Then
                list.RemoveAt(i)
            End If
        Next
    End Function




End Class
