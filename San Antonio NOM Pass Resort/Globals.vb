Imports System.IO

Public Class Globals
    Shared pathCustomersTxt As String = Path.GetFullPath("Customers.txt")
    Shared pathRoomsTxt As String = Path.GetFullPath("Rooms.txt")
    Shared Function getCustomerList()
        Dim listCustomer As New List(Of String)
        Dim readerCustomersTxt = New StreamReader("Customers.txt")

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

    Shared Function appendAllWithDashes(ByVal listOfString As List(Of String))
        Dim appendedString As String
        appendedString = listOfString(0)

        For i = 1 To listOfString.Count - 1
            appendedString += "-" + listOfString(i)
        Next

        Return appendedString
    End Function

    Shared Function getAvailableRooms()
        Dim listRoomNum As New List(Of List(Of String))
        Dim listRooms As List(Of String) = getRoomsList()
        Dim listCustomer As List(Of String) = getCustomerList()

        Dim indexOccupants As Integer
        Dim indexRooms As Integer

        'identified index of Occupants: and Rooms:
        For i = 0 To listCustomer.Count - 1
            For j = 0 To listCustomer(i).Count - 1
                If listCustomer(i)(j) = "Occupants:" Then
                    indexOccupants = j
                End If
                If listCustomer(i)(j) = "Rooms:" Then
                    indexRooms = j
                End If
            Next
        Next

        For i = 0 To listRooms.Count - 1
            listRoomNum.Add(getSplitString(listRooms(i)))
        Next

        For Each cust In listCustomer
            For i = indexRooms + 2 To indexOccupants - 1 Step 4
                For j = 0 To listRoomNum.Count - 1
                    If listRoomNum(j).Contains(cust(i)) And cust(cust.Count - 1) = "False" Then

                    End If
                Next

            Next
        Next




        Return listRoomNum

    End Function

End Class
