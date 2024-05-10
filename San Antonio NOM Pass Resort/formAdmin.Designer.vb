<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        tbcAdmin = New TabControl()
        tabAdminInfo = New TabPage()
        tabRooms = New TabPage()
        btnSingleRoomDetails = New Button()
        txtSingleRoomNumbers = New TextBox()
        lblPresidentialRoom = New Label()
        txtSingleAvailableRooms = New TextBox()
        lblRoomNumbers1 = New Label()
        lblAvailableRooms1 = New Label()
        lblExucutiveRoom = New Label()
        lblStandardRoom = New Label()
        lblTwinRoom = New Label()
        lblKingRoom = New Label()
        lblQueenRoom = New Label()
        lblSingleRoom = New Label()
        tabGuests = New TabPage()
        tabGuestInfo = New TabPage()
        Label1 = New Label()
        btnQueenRoomDetails = New Button()
        txtQueenRoomNumbers = New TextBox()
        txtQueenAvailableRooms = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btnKingRoomDetails = New Button()
        txtKingRoomNumbers = New TextBox()
        txtKingAvailableRooms = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnTwinRoomDetails = New Button()
        txtTwinRoomNumbers = New TextBox()
        txtTwinAvailableRooms = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        btnStandardRoomDetails = New Button()
        txtStandardRoomNumbers = New TextBox()
        txtStandardAvailableRooms = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        btnExecutiveRoomDetails = New Button()
        txtExecutiveRoomNumbers = New TextBox()
        txtExecutiveAvailableRooms = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        btnPresidentialRoomDetails = New Button()
        txtPresidentialRoomNumbers = New TextBox()
        txtPresidentialAvailableRooms = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        tbcAdmin.SuspendLayout()
        tabRooms.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbcAdmin
        ' 
        tbcAdmin.Controls.Add(tabAdminInfo)
        tbcAdmin.Controls.Add(tabRooms)
        tbcAdmin.Controls.Add(tabGuests)
        tbcAdmin.Controls.Add(tabGuestInfo)
        tbcAdmin.Location = New Point(0, 93)
        tbcAdmin.Margin = New Padding(3, 4, 3, 4)
        tbcAdmin.Name = "tbcAdmin"
        tbcAdmin.SelectedIndex = 0
        tbcAdmin.Size = New Size(915, 707)
        tbcAdmin.SizeMode = TabSizeMode.Fixed
        tbcAdmin.TabIndex = 0
        ' 
        ' tabAdminInfo
        ' 
        tabAdminInfo.Location = New Point(4, 29)
        tabAdminInfo.Margin = New Padding(3, 4, 3, 4)
        tabAdminInfo.Name = "tabAdminInfo"
        tabAdminInfo.Padding = New Padding(3, 4, 3, 4)
        tabAdminInfo.Size = New Size(907, 674)
        tabAdminInfo.TabIndex = 0
        tabAdminInfo.Text = "Admin Info"
        tabAdminInfo.UseVisualStyleBackColor = True
        ' 
        ' tabRooms
        ' 
        tabRooms.AutoScroll = True
        tabRooms.Controls.Add(Label20)
        tabRooms.Controls.Add(Label19)
        tabRooms.Controls.Add(Label18)
        tabRooms.Controls.Add(Label17)
        tabRooms.Controls.Add(Label16)
        tabRooms.Controls.Add(Label15)
        tabRooms.Controls.Add(Label14)
        tabRooms.Controls.Add(btnPresidentialRoomDetails)
        tabRooms.Controls.Add(txtPresidentialRoomNumbers)
        tabRooms.Controls.Add(txtPresidentialAvailableRooms)
        tabRooms.Controls.Add(Label12)
        tabRooms.Controls.Add(Label13)
        tabRooms.Controls.Add(btnExecutiveRoomDetails)
        tabRooms.Controls.Add(txtExecutiveRoomNumbers)
        tabRooms.Controls.Add(txtExecutiveAvailableRooms)
        tabRooms.Controls.Add(Label10)
        tabRooms.Controls.Add(Label11)
        tabRooms.Controls.Add(btnStandardRoomDetails)
        tabRooms.Controls.Add(txtStandardRoomNumbers)
        tabRooms.Controls.Add(txtStandardAvailableRooms)
        tabRooms.Controls.Add(Label8)
        tabRooms.Controls.Add(Label9)
        tabRooms.Controls.Add(btnTwinRoomDetails)
        tabRooms.Controls.Add(txtTwinRoomNumbers)
        tabRooms.Controls.Add(txtTwinAvailableRooms)
        tabRooms.Controls.Add(Label6)
        tabRooms.Controls.Add(Label7)
        tabRooms.Controls.Add(btnKingRoomDetails)
        tabRooms.Controls.Add(txtKingRoomNumbers)
        tabRooms.Controls.Add(txtKingAvailableRooms)
        tabRooms.Controls.Add(Label4)
        tabRooms.Controls.Add(Label5)
        tabRooms.Controls.Add(btnQueenRoomDetails)
        tabRooms.Controls.Add(txtQueenRoomNumbers)
        tabRooms.Controls.Add(txtQueenAvailableRooms)
        tabRooms.Controls.Add(Label2)
        tabRooms.Controls.Add(Label3)
        tabRooms.Controls.Add(btnSingleRoomDetails)
        tabRooms.Controls.Add(txtSingleRoomNumbers)
        tabRooms.Controls.Add(lblPresidentialRoom)
        tabRooms.Controls.Add(txtSingleAvailableRooms)
        tabRooms.Controls.Add(lblRoomNumbers1)
        tabRooms.Controls.Add(lblAvailableRooms1)
        tabRooms.Controls.Add(lblExucutiveRoom)
        tabRooms.Controls.Add(lblStandardRoom)
        tabRooms.Controls.Add(lblTwinRoom)
        tabRooms.Controls.Add(lblKingRoom)
        tabRooms.Controls.Add(lblQueenRoom)
        tabRooms.Controls.Add(lblSingleRoom)
        tabRooms.Location = New Point(4, 29)
        tabRooms.Margin = New Padding(3, 4, 3, 4)
        tabRooms.Name = "tabRooms"
        tabRooms.Padding = New Padding(3, 4, 3, 4)
        tabRooms.Size = New Size(907, 674)
        tabRooms.TabIndex = 1
        tabRooms.Text = "Rooms"
        tabRooms.UseVisualStyleBackColor = True
        ' 
        ' btnSingleRoomDetails
        ' 
        btnSingleRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnSingleRoomDetails.Location = New Point(10, 184)
        btnSingleRoomDetails.Name = "btnSingleRoomDetails"
        btnSingleRoomDetails.Size = New Size(247, 29)
        btnSingleRoomDetails.TabIndex = 65
        btnSingleRoomDetails.Text = "ROOM DETAILS"
        btnSingleRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtSingleRoomNumbers
        ' 
        txtSingleRoomNumbers.Location = New Point(132, 151)
        txtSingleRoomNumbers.Name = "txtSingleRoomNumbers"
        txtSingleRoomNumbers.Size = New Size(125, 27)
        txtSingleRoomNumbers.TabIndex = 64
        ' 
        ' lblPresidentialRoom
        ' 
        lblPresidentialRoom.AutoSize = True
        lblPresidentialRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblPresidentialRoom.Location = New Point(691, 216)
        lblPresidentialRoom.Name = "lblPresidentialRoom"
        lblPresidentialRoom.Size = New Size(150, 24)
        lblPresidentialRoom.TabIndex = 60
        lblPresidentialRoom.Text = "Presidential Room"
        ' 
        ' txtSingleAvailableRooms
        ' 
        txtSingleAvailableRooms.Location = New Point(132, 112)
        txtSingleAvailableRooms.Name = "txtSingleAvailableRooms"
        txtSingleAvailableRooms.Size = New Size(125, 27)
        txtSingleAvailableRooms.TabIndex = 63
        ' 
        ' lblRoomNumbers1
        ' 
        lblRoomNumbers1.AutoSize = True
        lblRoomNumbers1.BackColor = Color.Transparent
        lblRoomNumbers1.Font = New Font("Bahnschrift SemiCondensed", 9F)
        lblRoomNumbers1.Location = New Point(10, 155)
        lblRoomNumbers1.Name = "lblRoomNumbers1"
        lblRoomNumbers1.Size = New Size(107, 18)
        lblRoomNumbers1.TabIndex = 62
        lblRoomNumbers1.Text = "ROOM NUMBERS:"
        ' 
        ' lblAvailableRooms1
        ' 
        lblAvailableRooms1.AutoSize = True
        lblAvailableRooms1.BackColor = Color.Transparent
        lblAvailableRooms1.Font = New Font("Bahnschrift SemiCondensed", 9F)
        lblAvailableRooms1.Location = New Point(10, 115)
        lblAvailableRooms1.Name = "lblAvailableRooms1"
        lblAvailableRooms1.Size = New Size(118, 18)
        lblAvailableRooms1.TabIndex = 61
        lblAvailableRooms1.Text = "AVAILABLE ROOMS:"
        ' 
        ' lblExucutiveRoom
        ' 
        lblExucutiveRoom.AutoSize = True
        lblExucutiveRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblExucutiveRoom.Location = New Point(396, 446)
        lblExucutiveRoom.Name = "lblExucutiveRoom"
        lblExucutiveRoom.Size = New Size(134, 24)
        lblExucutiveRoom.TabIndex = 52
        lblExucutiveRoom.Text = "Executive Room"
        ' 
        ' lblStandardRoom
        ' 
        lblStandardRoom.AutoSize = True
        lblStandardRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblStandardRoom.Location = New Point(396, 216)
        lblStandardRoom.Name = "lblStandardRoom"
        lblStandardRoom.Size = New Size(128, 24)
        lblStandardRoom.TabIndex = 44
        lblStandardRoom.Text = "Standard Room"
        ' 
        ' lblTwinRoom
        ' 
        lblTwinRoom.AutoSize = True
        lblTwinRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblTwinRoom.Location = New Point(411, 4)
        lblTwinRoom.Name = "lblTwinRoom"
        lblTwinRoom.Size = New Size(93, 24)
        lblTwinRoom.TabIndex = 36
        lblTwinRoom.Text = "Twin Room"
        ' 
        ' lblKingRoom
        ' 
        lblKingRoom.AutoSize = True
        lblKingRoom.BackColor = SystemColors.ButtonHighlight
        lblKingRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblKingRoom.Location = New Point(6, 446)
        lblKingRoom.Name = "lblKingRoom"
        lblKingRoom.Size = New Size(93, 24)
        lblKingRoom.TabIndex = 28
        lblKingRoom.Text = "King Room"
        ' 
        ' lblQueenRoom
        ' 
        lblQueenRoom.AutoSize = True
        lblQueenRoom.BackColor = SystemColors.ButtonHighlight
        lblQueenRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblQueenRoom.Location = New Point(3, 216)
        lblQueenRoom.Name = "lblQueenRoom"
        lblQueenRoom.Size = New Size(108, 24)
        lblQueenRoom.TabIndex = 20
        lblQueenRoom.Text = "Queen Room"
        ' 
        ' lblSingleRoom
        ' 
        lblSingleRoom.AutoSize = True
        lblSingleRoom.BackColor = SystemColors.ButtonHighlight
        lblSingleRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblSingleRoom.Location = New Point(3, 4)
        lblSingleRoom.Name = "lblSingleRoom"
        lblSingleRoom.Size = New Size(106, 24)
        lblSingleRoom.TabIndex = 7
        lblSingleRoom.Text = "Single Room"
        ' 
        ' tabGuests
        ' 
        tabGuests.AutoScroll = True
        tabGuests.Location = New Point(4, 29)
        tabGuests.Margin = New Padding(3, 4, 3, 4)
        tabGuests.Name = "tabGuests"
        tabGuests.Size = New Size(907, 674)
        tabGuests.TabIndex = 2
        tabGuests.Text = "Guests"
        tabGuests.UseVisualStyleBackColor = True
        ' 
        ' tabGuestInfo
        ' 
        tabGuestInfo.Location = New Point(4, 29)
        tabGuestInfo.Margin = New Padding(3, 4, 3, 4)
        tabGuestInfo.Name = "tabGuestInfo"
        tabGuestInfo.Size = New Size(907, 674)
        tabGuestInfo.TabIndex = 3
        tabGuestInfo.Text = "Guest Info"
        tabGuestInfo.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(549, 40)
        Label1.TabIndex = 1
        Label1.Text = "San Antonion Nom Pass Resort"
        ' 
        ' btnQueenRoomDetails
        ' 
        btnQueenRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnQueenRoomDetails.Location = New Point(10, 414)
        btnQueenRoomDetails.Name = "btnQueenRoomDetails"
        btnQueenRoomDetails.Size = New Size(247, 29)
        btnQueenRoomDetails.TabIndex = 70
        btnQueenRoomDetails.Text = "ROOM DETAILS"
        btnQueenRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtQueenRoomNumbers
        ' 
        txtQueenRoomNumbers.Location = New Point(132, 381)
        txtQueenRoomNumbers.Name = "txtQueenRoomNumbers"
        txtQueenRoomNumbers.Size = New Size(125, 27)
        txtQueenRoomNumbers.TabIndex = 69
        ' 
        ' txtQueenAvailableRooms
        ' 
        txtQueenAvailableRooms.Location = New Point(132, 342)
        txtQueenAvailableRooms.Name = "txtQueenAvailableRooms"
        txtQueenAvailableRooms.Size = New Size(125, 27)
        txtQueenAvailableRooms.TabIndex = 68
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label2.Location = New Point(10, 385)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 18)
        Label2.TabIndex = 67
        Label2.Text = "ROOM NUMBERS:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label3.Location = New Point(10, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 18)
        Label3.TabIndex = 66
        Label3.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnKingRoomDetails
        ' 
        btnKingRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnKingRoomDetails.Location = New Point(10, 638)
        btnKingRoomDetails.Name = "btnKingRoomDetails"
        btnKingRoomDetails.Size = New Size(247, 29)
        btnKingRoomDetails.TabIndex = 75
        btnKingRoomDetails.Text = "ROOM DETAILS"
        btnKingRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtKingRoomNumbers
        ' 
        txtKingRoomNumbers.Location = New Point(132, 605)
        txtKingRoomNumbers.Name = "txtKingRoomNumbers"
        txtKingRoomNumbers.Size = New Size(125, 27)
        txtKingRoomNumbers.TabIndex = 74
        ' 
        ' txtKingAvailableRooms
        ' 
        txtKingAvailableRooms.Location = New Point(132, 566)
        txtKingAvailableRooms.Name = "txtKingAvailableRooms"
        txtKingAvailableRooms.Size = New Size(125, 27)
        txtKingAvailableRooms.TabIndex = 73
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label4.Location = New Point(10, 609)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 18)
        Label4.TabIndex = 72
        Label4.Text = "ROOM NUMBERS:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label5.Location = New Point(10, 569)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 18)
        Label5.TabIndex = 71
        Label5.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnTwinRoomDetails
        ' 
        btnTwinRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnTwinRoomDetails.Location = New Point(330, 184)
        btnTwinRoomDetails.Name = "btnTwinRoomDetails"
        btnTwinRoomDetails.Size = New Size(247, 29)
        btnTwinRoomDetails.TabIndex = 80
        btnTwinRoomDetails.Text = "ROOM DETAILS"
        btnTwinRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtTwinRoomNumbers
        ' 
        txtTwinRoomNumbers.Location = New Point(452, 151)
        txtTwinRoomNumbers.Name = "txtTwinRoomNumbers"
        txtTwinRoomNumbers.Size = New Size(125, 27)
        txtTwinRoomNumbers.TabIndex = 79
        ' 
        ' txtTwinAvailableRooms
        ' 
        txtTwinAvailableRooms.Location = New Point(452, 112)
        txtTwinAvailableRooms.Name = "txtTwinAvailableRooms"
        txtTwinAvailableRooms.Size = New Size(125, 27)
        txtTwinAvailableRooms.TabIndex = 78
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label6.Location = New Point(330, 155)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 18)
        Label6.TabIndex = 77
        Label6.Text = "ROOM NUMBERS:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label7.Location = New Point(330, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 18)
        Label7.TabIndex = 76
        Label7.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnStandardRoomDetails
        ' 
        btnStandardRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnStandardRoomDetails.Location = New Point(330, 414)
        btnStandardRoomDetails.Name = "btnStandardRoomDetails"
        btnStandardRoomDetails.Size = New Size(247, 29)
        btnStandardRoomDetails.TabIndex = 85
        btnStandardRoomDetails.Text = "ROOM DETAILS"
        btnStandardRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtStandardRoomNumbers
        ' 
        txtStandardRoomNumbers.Location = New Point(452, 381)
        txtStandardRoomNumbers.Name = "txtStandardRoomNumbers"
        txtStandardRoomNumbers.Size = New Size(125, 27)
        txtStandardRoomNumbers.TabIndex = 84
        ' 
        ' txtStandardAvailableRooms
        ' 
        txtStandardAvailableRooms.Location = New Point(452, 342)
        txtStandardAvailableRooms.Name = "txtStandardAvailableRooms"
        txtStandardAvailableRooms.Size = New Size(125, 27)
        txtStandardAvailableRooms.TabIndex = 83
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label8.Location = New Point(330, 385)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 18)
        Label8.TabIndex = 82
        Label8.Text = "ROOM NUMBERS:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label9.Location = New Point(330, 345)
        Label9.Name = "Label9"
        Label9.Size = New Size(118, 18)
        Label9.TabIndex = 81
        Label9.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnExecutiveRoomDetails
        ' 
        btnExecutiveRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnExecutiveRoomDetails.Location = New Point(312, 638)
        btnExecutiveRoomDetails.Name = "btnExecutiveRoomDetails"
        btnExecutiveRoomDetails.Size = New Size(247, 29)
        btnExecutiveRoomDetails.TabIndex = 90
        btnExecutiveRoomDetails.Text = "ROOM DETAILS"
        btnExecutiveRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtExecutiveRoomNumbers
        ' 
        txtExecutiveRoomNumbers.Location = New Point(434, 605)
        txtExecutiveRoomNumbers.Name = "txtExecutiveRoomNumbers"
        txtExecutiveRoomNumbers.Size = New Size(125, 27)
        txtExecutiveRoomNumbers.TabIndex = 89
        ' 
        ' txtExecutiveAvailableRooms
        ' 
        txtExecutiveAvailableRooms.Location = New Point(434, 566)
        txtExecutiveAvailableRooms.Name = "txtExecutiveAvailableRooms"
        txtExecutiveAvailableRooms.Size = New Size(125, 27)
        txtExecutiveAvailableRooms.TabIndex = 88
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label10.Location = New Point(312, 609)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 18)
        Label10.TabIndex = 87
        Label10.Text = "ROOM NUMBERS:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label11.Location = New Point(312, 569)
        Label11.Name = "Label11"
        Label11.Size = New Size(118, 18)
        Label11.TabIndex = 86
        Label11.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnPresidentialRoomDetails
        ' 
        btnPresidentialRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnPresidentialRoomDetails.Location = New Point(651, 414)
        btnPresidentialRoomDetails.Name = "btnPresidentialRoomDetails"
        btnPresidentialRoomDetails.Size = New Size(247, 29)
        btnPresidentialRoomDetails.TabIndex = 95
        btnPresidentialRoomDetails.Text = "ROOM DETAILS"
        btnPresidentialRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtPresidentialRoomNumbers
        ' 
        txtPresidentialRoomNumbers.Location = New Point(773, 381)
        txtPresidentialRoomNumbers.Name = "txtPresidentialRoomNumbers"
        txtPresidentialRoomNumbers.Size = New Size(125, 27)
        txtPresidentialRoomNumbers.TabIndex = 94
        ' 
        ' txtPresidentialAvailableRooms
        ' 
        txtPresidentialAvailableRooms.Location = New Point(773, 342)
        txtPresidentialAvailableRooms.Name = "txtPresidentialAvailableRooms"
        txtPresidentialAvailableRooms.Size = New Size(125, 27)
        txtPresidentialAvailableRooms.TabIndex = 93
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label12.Location = New Point(651, 385)
        Label12.Name = "Label12"
        Label12.Size = New Size(107, 18)
        Label12.TabIndex = 92
        Label12.Text = "ROOM NUMBERS:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label13.Location = New Point(651, 345)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 18)
        Label13.TabIndex = 91
        Label13.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(94, 59)
        Label14.Name = "Label14"
        Label14.Size = New Size(90, 18)
        Label14.TabIndex = 96
        Label14.Text = "1 Double Bed |"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(94, 285)
        Label15.Name = "Label15"
        Label15.Size = New Size(86, 18)
        Label15.TabIndex = 97
        Label15.Text = "1 Queen Bed |"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(79, 505)
        Label16.Name = "Label16"
        Label16.Size = New Size(75, 18)
        Label16.TabIndex = 98
        Label16.Text = "1 King Bed |"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(411, 59)
        Label17.Name = "Label17"
        Label17.Size = New Size(83, 18)
        Label17.TabIndex = 99
        Label17.Text = "2 Twin Beds |"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(411, 505)
        Label18.Name = "Label18"
        Label18.Size = New Size(83, 18)
        Label18.TabIndex = 100
        Label18.Text = "2 Twin Beds |"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(411, 285)
        Label19.Name = "Label19"
        Label19.Size = New Size(90, 18)
        Label19.TabIndex = 101
        Label19.Text = "1 Double Bed |"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(718, 276)
        Label20.Name = "Label20"
        Label20.Size = New Size(75, 18)
        Label20.TabIndex = 102
        Label20.Text = "1 King Bed |"
        ' 
        ' formAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 797)
        Controls.Add(Label1)
        Controls.Add(tbcAdmin)
        Margin = New Padding(3, 4, 3, 4)
        Name = "formAdmin"
        Text = "formAdmin"
        tbcAdmin.ResumeLayout(False)
        tabRooms.ResumeLayout(False)
        tabRooms.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbcAdmin As TabControl
    Friend WithEvents tabAdminInfo As TabPage
    Friend WithEvents tabRooms As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tabGuests As TabPage
    Friend WithEvents tabGuestInfo As TabPage
    Friend WithEvents lblRoomNumbers1 As Label
    Friend WithEvents lblAvailableRooms1 As Label
    Friend WithEvents lblPresidentialRoom As Label
    Friend WithEvents lblExucutiveRoom As Label
    Friend WithEvents lblStandardRoom As Label
    Friend WithEvents lblTwinRoom As Label
    Friend WithEvents lblKingRoom As Label
    Friend WithEvents lblQueenRoom As Label
    Friend WithEvents lblSingleRoom As Label
    Friend WithEvents txtSingleAvailableRooms As TextBox
    Friend WithEvents txtSingleRoomNumbers As TextBox
    Friend WithEvents btnSingleRoomDetails As Button
    Friend WithEvents btnKingRoomDetails As Button
    Friend WithEvents txtKingRoomNumbers As TextBox
    Friend WithEvents txtKingAvailableRooms As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnQueenRoomDetails As Button
    Friend WithEvents txtQueenRoomNumbers As TextBox
    Friend WithEvents txtQueenAvailableRooms As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPresidentialRoomDetails As Button
    Friend WithEvents txtPresidentialRoomNumbers As TextBox
    Friend WithEvents txtPresidentialAvailableRooms As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnExecutiveRoomDetails As Button
    Friend WithEvents txtExecutiveRoomNumbers As TextBox
    Friend WithEvents txtExecutiveAvailableRooms As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnStandardRoomDetails As Button
    Friend WithEvents txtStandardRoomNumbers As TextBox
    Friend WithEvents txtStandardAvailableRooms As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnTwinRoomDetails As Button
    Friend WithEvents txtTwinRoomNumbers As TextBox
    Friend WithEvents txtTwinAvailableRooms As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
End Class
