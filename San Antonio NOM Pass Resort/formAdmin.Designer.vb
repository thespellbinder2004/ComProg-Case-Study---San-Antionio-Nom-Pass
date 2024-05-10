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
        txtAdminContact2 = New TextBox()
        txtAdminContact1 = New TextBox()
        txtAdminRole = New TextBox()
        txtCurrentAdmin = New TextBox()
        Label39 = New Label()
        Label38 = New Label()
        Label37 = New Label()
        Label30 = New Label()
        Label29 = New Label()
        Label28 = New Label()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        GroupBox1 = New GroupBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label36 = New Label()
        Label35 = New Label()
        Label34 = New Label()
        Label33 = New Label()
        Label32 = New Label()
        Label31 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        tabRooms = New TabPage()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        btnPresidentialRoomDetails = New Button()
        txtPresidentialRoomNumbers = New TextBox()
        txtPresidentialAvailableRooms = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        btnExecutiveRoomDetails = New Button()
        txtExecutiveRoomNumbers = New TextBox()
        txtExecutiveAvailableRooms = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        btnStandardRoomDetails = New Button()
        txtStandardRoomNumbers = New TextBox()
        txtStandardAvailableRooms = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        btnTwinRoomDetails = New Button()
        txtTwinRoomNumbers = New TextBox()
        txtTwinAvailableRooms = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        btnKingRoomDetails = New Button()
        txtKingRoomNumbers = New TextBox()
        txtKingAvailableRooms = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnQueenRoomDetails = New Button()
        txtQueenRoomNumbers = New TextBox()
        txtQueenAvailableRooms = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
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
        tbcAdmin.SuspendLayout()
        tabAdminInfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        tabRooms.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbcAdmin
        ' 
        tbcAdmin.Controls.Add(tabAdminInfo)
        tbcAdmin.Controls.Add(tabRooms)
        tbcAdmin.Controls.Add(tabGuests)
        tbcAdmin.Controls.Add(tabGuestInfo)
        tbcAdmin.Location = New Point(0, 70)
        tbcAdmin.Name = "tbcAdmin"
        tbcAdmin.SelectedIndex = 0
        tbcAdmin.Size = New Size(801, 530)
        tbcAdmin.SizeMode = TabSizeMode.Fixed
        tbcAdmin.TabIndex = 0
        ' 
        ' tabAdminInfo
        ' 
        tabAdminInfo.Controls.Add(txtAdminContact2)
        tabAdminInfo.Controls.Add(txtAdminContact1)
        tabAdminInfo.Controls.Add(txtAdminRole)
        tabAdminInfo.Controls.Add(txtCurrentAdmin)
        tabAdminInfo.Controls.Add(Label39)
        tabAdminInfo.Controls.Add(Label38)
        tabAdminInfo.Controls.Add(Label37)
        tabAdminInfo.Controls.Add(Label30)
        tabAdminInfo.Controls.Add(Label29)
        tabAdminInfo.Controls.Add(Label28)
        tabAdminInfo.Controls.Add(Label27)
        tabAdminInfo.Controls.Add(Label26)
        tabAdminInfo.Controls.Add(Label25)
        tabAdminInfo.Controls.Add(GroupBox1)
        tabAdminInfo.Controls.Add(Label24)
        tabAdminInfo.Controls.Add(Label23)
        tabAdminInfo.Controls.Add(Label22)
        tabAdminInfo.Controls.Add(Label21)
        tabAdminInfo.Location = New Point(4, 24)
        tabAdminInfo.Name = "tabAdminInfo"
        tabAdminInfo.Padding = New Padding(3)
        tabAdminInfo.Size = New Size(793, 502)
        tabAdminInfo.TabIndex = 0
        tabAdminInfo.Text = "Admin Info"
        tabAdminInfo.UseVisualStyleBackColor = True
        ' 
        ' txtAdminContact2
        ' 
        txtAdminContact2.Location = New Point(220, 439)
        txtAdminContact2.Name = "txtAdminContact2"
        txtAdminContact2.Size = New Size(225, 23)
        txtAdminContact2.TabIndex = 28
        ' 
        ' txtAdminContact1
        ' 
        txtAdminContact1.Location = New Point(220, 406)
        txtAdminContact1.Name = "txtAdminContact1"
        txtAdminContact1.Size = New Size(225, 23)
        txtAdminContact1.TabIndex = 27
        ' 
        ' txtAdminRole
        ' 
        txtAdminRole.Location = New Point(220, 377)
        txtAdminRole.Name = "txtAdminRole"
        txtAdminRole.Size = New Size(225, 23)
        txtAdminRole.TabIndex = 26
        ' 
        ' txtCurrentAdmin
        ' 
        txtCurrentAdmin.Location = New Point(220, 348)
        txtCurrentAdmin.Name = "txtCurrentAdmin"
        txtCurrentAdmin.Size = New Size(225, 23)
        txtCurrentAdmin.TabIndex = 25
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label39.Location = New Point(65, 409)
        Label39.Name = "Label39"
        Label39.Size = New Size(90, 19)
        Label39.TabIndex = 24
        Label39.Text = "Contacts:"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(65, 380)
        Label38.Name = "Label38"
        Label38.Size = New Size(135, 19)
        Label38.TabIndex = 23
        Label38.Text = "Role/Position:"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label37.Location = New Point(65, 352)
        Label37.Name = "Label37"
        Label37.Size = New Size(135, 19)
        Label37.TabIndex = 22
        Label37.Text = "Current Admin:"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(17, 323)
        Label30.Name = "Label30"
        Label30.Size = New Size(162, 19)
        Label30.TabIndex = 21
        Label30.Text = "Admin Information"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(184, 139)
        Label29.Name = "Label29"
        Label29.Size = New Size(261, 19)
        Label29.TabIndex = 20
        Label29.Text = "https://SanAntonioResort.com"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(184, 118)
        Label28.Name = "Label28"
        Label28.Size = New Size(108, 19)
        Label28.TabIndex = 19
        Label28.Text = "09123456789"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(184, 95)
        Label27.Name = "Label27"
        Label27.Size = New Size(216, 19)
        Label27.TabIndex = 18
        Label27.Text = "sanantonio143@gmail.com"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(184, 70)
        Label26.Name = "Label26"
        Label26.Size = New Size(234, 19)
        Label26.TabIndex = 17
        Label26.Text = "Kaliwa, Doon, Tarlac City"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(184, 44)
        Label25.Name = "Label25"
        Label25.Size = New Size(252, 19)
        Label25.TabIndex = 16
        Label25.Text = "San Antonio Nom Pass Resort"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label36)
        GroupBox1.Controls.Add(Label35)
        GroupBox1.Controls.Add(Label34)
        GroupBox1.Controls.Add(Label33)
        GroupBox1.Controls.Add(Label32)
        GroupBox1.Controls.Add(Label31)
        GroupBox1.Font = New Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(184, 173)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(376, 132)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Resort Details"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Internet Access", "Swimming Pools", "Water Sports/Activities", "On-site Restaurant and Bar", "Kids' Club", "Laundry and Dry Cleaning", "Transportation"})
        ComboBox2.Location = New Point(180, 79)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 25
        ComboBox2.Text = "Services"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Single Room", "", "Queen Room", "", "King Room", "", "Twin Room", "", "Standard Room", "", "Executive Suite", "", "Presidential Suite"})
        ComboBox1.Location = New Point(180, 50)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 24
        ComboBox1.Text = "Room Type"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label36.ForeColor = Color.Orange
        Label36.Location = New Point(175, 96)
        Label36.Name = "Label36"
        Label36.Size = New Size(105, 34)
        Label36.TabIndex = 23
        Label36.Text = "★★★★★"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(180, 27)
        Label35.Name = "Label35"
        Label35.Size = New Size(27, 19)
        Label35.TabIndex = 22
        Label35.Text = "71"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label34.Location = New Point(31, 103)
        Label34.Name = "Label34"
        Label34.Size = New Size(81, 19)
        Label34.TabIndex = 14
        Label34.Text = "Ratings:"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label33.Location = New Point(31, 78)
        Label33.Name = "Label33"
        Label33.Size = New Size(90, 19)
        Label33.TabIndex = 13
        Label33.Text = "Services:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(31, 52)
        Label32.Name = "Label32"
        Label32.Size = New Size(108, 19)
        Label32.TabIndex = 12
        Label32.Text = "Room Types:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(31, 27)
        Label31.Name = "Label31"
        Label31.Size = New Size(117, 19)
        Label31.TabIndex = 11
        Label31.Text = "Total Rooms:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(65, 95)
        Label24.Name = "Label24"
        Label24.Size = New Size(90, 19)
        Label24.TabIndex = 14
        Label24.Text = "Contacts:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(65, 70)
        Label23.Name = "Label23"
        Label23.Size = New Size(90, 19)
        Label23.TabIndex = 13
        Label23.Text = "Location:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(65, 44)
        Label22.Name = "Label22"
        Label22.Size = New Size(54, 19)
        Label22.TabIndex = 12
        Label22.Text = "Name:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(17, 14)
        Label21.Name = "Label21"
        Label21.Size = New Size(171, 19)
        Label21.TabIndex = 11
        Label21.Text = "Resort Information"
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
        tabRooms.Location = New Point(4, 24)
        tabRooms.Name = "tabRooms"
        tabRooms.Padding = New Padding(3)
        tabRooms.Size = New Size(793, 502)
        tabRooms.TabIndex = 1
        tabRooms.Text = "Rooms"
        tabRooms.UseVisualStyleBackColor = True
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(628, 207)
        Label20.Name = "Label20"
        Label20.Size = New Size(62, 14)
        Label20.TabIndex = 102
        Label20.Text = "1 King Bed |"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(360, 214)
        Label19.Name = "Label19"
        Label19.Size = New Size(75, 14)
        Label19.TabIndex = 101
        Label19.Text = "1 Double Bed |"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(360, 379)
        Label18.Name = "Label18"
        Label18.Size = New Size(70, 14)
        Label18.TabIndex = 100
        Label18.Text = "2 Twin Beds |"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(360, 44)
        Label17.Name = "Label17"
        Label17.Size = New Size(70, 14)
        Label17.TabIndex = 99
        Label17.Text = "2 Twin Beds |"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(69, 379)
        Label16.Name = "Label16"
        Label16.Size = New Size(62, 14)
        Label16.TabIndex = 98
        Label16.Text = "1 King Bed |"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(82, 214)
        Label15.Name = "Label15"
        Label15.Size = New Size(72, 14)
        Label15.TabIndex = 97
        Label15.Text = "1 Queen Bed |"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(82, 44)
        Label14.Name = "Label14"
        Label14.Size = New Size(75, 14)
        Label14.TabIndex = 96
        Label14.Text = "1 Double Bed |"
        ' 
        ' btnPresidentialRoomDetails
        ' 
        btnPresidentialRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnPresidentialRoomDetails.Location = New Point(570, 310)
        btnPresidentialRoomDetails.Margin = New Padding(3, 2, 3, 2)
        btnPresidentialRoomDetails.Name = "btnPresidentialRoomDetails"
        btnPresidentialRoomDetails.Size = New Size(216, 22)
        btnPresidentialRoomDetails.TabIndex = 95
        btnPresidentialRoomDetails.Text = "ROOM DETAILS"
        btnPresidentialRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtPresidentialRoomNumbers
        ' 
        txtPresidentialRoomNumbers.Location = New Point(676, 286)
        txtPresidentialRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        txtPresidentialRoomNumbers.Name = "txtPresidentialRoomNumbers"
        txtPresidentialRoomNumbers.Size = New Size(110, 23)
        txtPresidentialRoomNumbers.TabIndex = 94
        ' 
        ' txtPresidentialAvailableRooms
        ' 
        txtPresidentialAvailableRooms.Location = New Point(676, 256)
        txtPresidentialAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        txtPresidentialAvailableRooms.Name = "txtPresidentialAvailableRooms"
        txtPresidentialAvailableRooms.Size = New Size(110, 23)
        txtPresidentialAvailableRooms.TabIndex = 93
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label12.Location = New Point(570, 289)
        Label12.Name = "Label12"
        Label12.Size = New Size(87, 14)
        Label12.TabIndex = 92
        Label12.Text = "ROOM NUMBERS:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label13.Location = New Point(570, 259)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 14)
        Label13.TabIndex = 91
        Label13.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnExecutiveRoomDetails
        ' 
        btnExecutiveRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnExecutiveRoomDetails.Location = New Point(273, 478)
        btnExecutiveRoomDetails.Margin = New Padding(3, 2, 3, 2)
        btnExecutiveRoomDetails.Name = "btnExecutiveRoomDetails"
        btnExecutiveRoomDetails.Size = New Size(216, 22)
        btnExecutiveRoomDetails.TabIndex = 90
        btnExecutiveRoomDetails.Text = "ROOM DETAILS"
        btnExecutiveRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtExecutiveRoomNumbers
        ' 
        txtExecutiveRoomNumbers.Location = New Point(380, 454)
        txtExecutiveRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        txtExecutiveRoomNumbers.Name = "txtExecutiveRoomNumbers"
        txtExecutiveRoomNumbers.Size = New Size(110, 23)
        txtExecutiveRoomNumbers.TabIndex = 89
        ' 
        ' txtExecutiveAvailableRooms
        ' 
        txtExecutiveAvailableRooms.Location = New Point(380, 424)
        txtExecutiveAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        txtExecutiveAvailableRooms.Name = "txtExecutiveAvailableRooms"
        txtExecutiveAvailableRooms.Size = New Size(110, 23)
        txtExecutiveAvailableRooms.TabIndex = 88
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label10.Location = New Point(273, 457)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 14)
        Label10.TabIndex = 87
        Label10.Text = "ROOM NUMBERS:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label11.Location = New Point(273, 427)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 14)
        Label11.TabIndex = 86
        Label11.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnStandardRoomDetails
        ' 
        btnStandardRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnStandardRoomDetails.Location = New Point(289, 310)
        btnStandardRoomDetails.Margin = New Padding(3, 2, 3, 2)
        btnStandardRoomDetails.Name = "btnStandardRoomDetails"
        btnStandardRoomDetails.Size = New Size(216, 22)
        btnStandardRoomDetails.TabIndex = 85
        btnStandardRoomDetails.Text = "ROOM DETAILS"
        btnStandardRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtStandardRoomNumbers
        ' 
        txtStandardRoomNumbers.Location = New Point(396, 286)
        txtStandardRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        txtStandardRoomNumbers.Name = "txtStandardRoomNumbers"
        txtStandardRoomNumbers.Size = New Size(110, 23)
        txtStandardRoomNumbers.TabIndex = 84
        ' 
        ' txtStandardAvailableRooms
        ' 
        txtStandardAvailableRooms.Location = New Point(396, 256)
        txtStandardAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        txtStandardAvailableRooms.Name = "txtStandardAvailableRooms"
        txtStandardAvailableRooms.Size = New Size(110, 23)
        txtStandardAvailableRooms.TabIndex = 83
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label8.Location = New Point(289, 289)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 14)
        Label8.TabIndex = 82
        Label8.Text = "ROOM NUMBERS:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label9.Location = New Point(289, 259)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 14)
        Label9.TabIndex = 81
        Label9.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnTwinRoomDetails
        ' 
        btnTwinRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnTwinRoomDetails.Location = New Point(289, 138)
        btnTwinRoomDetails.Margin = New Padding(3, 2, 3, 2)
        btnTwinRoomDetails.Name = "btnTwinRoomDetails"
        btnTwinRoomDetails.Size = New Size(216, 22)
        btnTwinRoomDetails.TabIndex = 80
        btnTwinRoomDetails.Text = "ROOM DETAILS"
        btnTwinRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtTwinRoomNumbers
        ' 
        txtTwinRoomNumbers.Location = New Point(396, 113)
        txtTwinRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        txtTwinRoomNumbers.Name = "txtTwinRoomNumbers"
        txtTwinRoomNumbers.Size = New Size(110, 23)
        txtTwinRoomNumbers.TabIndex = 79
        ' 
        ' txtTwinAvailableRooms
        ' 
        txtTwinAvailableRooms.Location = New Point(396, 84)
        txtTwinAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        txtTwinAvailableRooms.Name = "txtTwinAvailableRooms"
        txtTwinAvailableRooms.Size = New Size(110, 23)
        txtTwinAvailableRooms.TabIndex = 78
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label6.Location = New Point(289, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 14)
        Label6.TabIndex = 77
        Label6.Text = "ROOM NUMBERS:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label7.Location = New Point(289, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 14)
        Label7.TabIndex = 76
        Label7.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnKingRoomDetails
        ' 
        btnKingRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnKingRoomDetails.Location = New Point(9, 478)
        btnKingRoomDetails.Margin = New Padding(3, 2, 3, 2)
        btnKingRoomDetails.Name = "btnKingRoomDetails"
        btnKingRoomDetails.Size = New Size(216, 22)
        btnKingRoomDetails.TabIndex = 75
        btnKingRoomDetails.Text = "ROOM DETAILS"
        btnKingRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtKingRoomNumbers
        ' 
        txtKingRoomNumbers.Location = New Point(116, 454)
        txtKingRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        txtKingRoomNumbers.Name = "txtKingRoomNumbers"
        txtKingRoomNumbers.Size = New Size(110, 23)
        txtKingRoomNumbers.TabIndex = 74
        ' 
        ' txtKingAvailableRooms
        ' 
        txtKingAvailableRooms.Location = New Point(116, 424)
        txtKingAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        txtKingAvailableRooms.Name = "txtKingAvailableRooms"
        txtKingAvailableRooms.Size = New Size(110, 23)
        txtKingAvailableRooms.TabIndex = 73
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label4.Location = New Point(9, 457)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 14)
        Label4.TabIndex = 72
        Label4.Text = "ROOM NUMBERS:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label5.Location = New Point(9, 427)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 14)
        Label5.TabIndex = 71
        Label5.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnQueenRoomDetails
        ' 
        btnQueenRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnQueenRoomDetails.Location = New Point(9, 310)
        btnQueenRoomDetails.Margin = New Padding(3, 2, 3, 2)
        btnQueenRoomDetails.Name = "btnQueenRoomDetails"
        btnQueenRoomDetails.Size = New Size(216, 22)
        btnQueenRoomDetails.TabIndex = 70
        btnQueenRoomDetails.Text = "ROOM DETAILS"
        btnQueenRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtQueenRoomNumbers
        ' 
        txtQueenRoomNumbers.Location = New Point(116, 286)
        txtQueenRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        txtQueenRoomNumbers.Name = "txtQueenRoomNumbers"
        txtQueenRoomNumbers.Size = New Size(110, 23)
        txtQueenRoomNumbers.TabIndex = 69
        ' 
        ' txtQueenAvailableRooms
        ' 
        txtQueenAvailableRooms.Location = New Point(116, 256)
        txtQueenAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        txtQueenAvailableRooms.Name = "txtQueenAvailableRooms"
        txtQueenAvailableRooms.Size = New Size(110, 23)
        txtQueenAvailableRooms.TabIndex = 68
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label2.Location = New Point(9, 289)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 14)
        Label2.TabIndex = 67
        Label2.Text = "ROOM NUMBERS:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label3.Location = New Point(9, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 14)
        Label3.TabIndex = 66
        Label3.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnSingleRoomDetails
        ' 
        btnSingleRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnSingleRoomDetails.Location = New Point(9, 138)
        btnSingleRoomDetails.Margin = New Padding(3, 2, 3, 2)
        btnSingleRoomDetails.Name = "btnSingleRoomDetails"
        btnSingleRoomDetails.Size = New Size(216, 22)
        btnSingleRoomDetails.TabIndex = 65
        btnSingleRoomDetails.Text = "ROOM DETAILS"
        btnSingleRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' txtSingleRoomNumbers
        ' 
        txtSingleRoomNumbers.Location = New Point(116, 113)
        txtSingleRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        txtSingleRoomNumbers.Name = "txtSingleRoomNumbers"
        txtSingleRoomNumbers.Size = New Size(110, 23)
        txtSingleRoomNumbers.TabIndex = 64
        ' 
        ' lblPresidentialRoom
        ' 
        lblPresidentialRoom.AutoSize = True
        lblPresidentialRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblPresidentialRoom.Location = New Point(605, 162)
        lblPresidentialRoom.Name = "lblPresidentialRoom"
        lblPresidentialRoom.Size = New Size(124, 19)
        lblPresidentialRoom.TabIndex = 60
        lblPresidentialRoom.Text = "Presidential Room"
        ' 
        ' txtSingleAvailableRooms
        ' 
        txtSingleAvailableRooms.Location = New Point(116, 84)
        txtSingleAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        txtSingleAvailableRooms.Name = "txtSingleAvailableRooms"
        txtSingleAvailableRooms.Size = New Size(110, 23)
        txtSingleAvailableRooms.TabIndex = 63
        ' 
        ' lblRoomNumbers1
        ' 
        lblRoomNumbers1.AutoSize = True
        lblRoomNumbers1.BackColor = Color.Transparent
        lblRoomNumbers1.Font = New Font("Bahnschrift SemiCondensed", 9F)
        lblRoomNumbers1.Location = New Point(9, 116)
        lblRoomNumbers1.Name = "lblRoomNumbers1"
        lblRoomNumbers1.Size = New Size(87, 14)
        lblRoomNumbers1.TabIndex = 62
        lblRoomNumbers1.Text = "ROOM NUMBERS:"
        ' 
        ' lblAvailableRooms1
        ' 
        lblAvailableRooms1.AutoSize = True
        lblAvailableRooms1.BackColor = Color.Transparent
        lblAvailableRooms1.Font = New Font("Bahnschrift SemiCondensed", 9F)
        lblAvailableRooms1.Location = New Point(9, 86)
        lblAvailableRooms1.Name = "lblAvailableRooms1"
        lblAvailableRooms1.Size = New Size(99, 14)
        lblAvailableRooms1.TabIndex = 61
        lblAvailableRooms1.Text = "AVAILABLE ROOMS:"
        ' 
        ' lblExucutiveRoom
        ' 
        lblExucutiveRoom.AutoSize = True
        lblExucutiveRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblExucutiveRoom.Location = New Point(346, 334)
        lblExucutiveRoom.Name = "lblExucutiveRoom"
        lblExucutiveRoom.Size = New Size(108, 19)
        lblExucutiveRoom.TabIndex = 52
        lblExucutiveRoom.Text = "Executive Room"
        ' 
        ' lblStandardRoom
        ' 
        lblStandardRoom.AutoSize = True
        lblStandardRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblStandardRoom.Location = New Point(346, 162)
        lblStandardRoom.Name = "lblStandardRoom"
        lblStandardRoom.Size = New Size(107, 19)
        lblStandardRoom.TabIndex = 44
        lblStandardRoom.Text = "Standard Room"
        ' 
        ' lblTwinRoom
        ' 
        lblTwinRoom.AutoSize = True
        lblTwinRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblTwinRoom.Location = New Point(360, 3)
        lblTwinRoom.Name = "lblTwinRoom"
        lblTwinRoom.Size = New Size(77, 19)
        lblTwinRoom.TabIndex = 36
        lblTwinRoom.Text = "Twin Room"
        ' 
        ' lblKingRoom
        ' 
        lblKingRoom.AutoSize = True
        lblKingRoom.BackColor = SystemColors.ButtonHighlight
        lblKingRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblKingRoom.Location = New Point(5, 334)
        lblKingRoom.Name = "lblKingRoom"
        lblKingRoom.Size = New Size(77, 19)
        lblKingRoom.TabIndex = 28
        lblKingRoom.Text = "King Room"
        ' 
        ' lblQueenRoom
        ' 
        lblQueenRoom.AutoSize = True
        lblQueenRoom.BackColor = SystemColors.ButtonHighlight
        lblQueenRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblQueenRoom.Location = New Point(3, 162)
        lblQueenRoom.Name = "lblQueenRoom"
        lblQueenRoom.Size = New Size(87, 19)
        lblQueenRoom.TabIndex = 20
        lblQueenRoom.Text = "Queen Room"
        ' 
        ' lblSingleRoom
        ' 
        lblSingleRoom.AutoSize = True
        lblSingleRoom.BackColor = SystemColors.ButtonHighlight
        lblSingleRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblSingleRoom.Location = New Point(3, 3)
        lblSingleRoom.Name = "lblSingleRoom"
        lblSingleRoom.Size = New Size(87, 19)
        lblSingleRoom.TabIndex = 7
        lblSingleRoom.Text = "Single Room"
        ' 
        ' tabGuests
        ' 
        tabGuests.AutoScroll = True
        tabGuests.Location = New Point(4, 24)
        tabGuests.Name = "tabGuests"
        tabGuests.Size = New Size(793, 502)
        tabGuests.TabIndex = 2
        tabGuests.Text = "Guests"
        tabGuests.UseVisualStyleBackColor = True
        ' 
        ' tabGuestInfo
        ' 
        tabGuestInfo.Location = New Point(4, 24)
        tabGuestInfo.Name = "tabGuestInfo"
        tabGuestInfo.Size = New Size(793, 502)
        tabGuestInfo.TabIndex = 3
        tabGuestInfo.Text = "Guest Info"
        tabGuestInfo.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(419, 32)
        Label1.TabIndex = 1
        Label1.Text = "San Antonio Nom Pass Resort"
        ' 
        ' formAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 598)
        Controls.Add(Label1)
        Controls.Add(tbcAdmin)
        Name = "formAdmin"
        Text = "formAdmin"
        tbcAdmin.ResumeLayout(False)
        tabAdminInfo.ResumeLayout(False)
        tabAdminInfo.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents txtAdminContact2 As TextBox
    Friend WithEvents txtAdminContact1 As TextBox
    Friend WithEvents txtAdminRole As TextBox
    Friend WithEvents txtCurrentAdmin As TextBox
End Class
