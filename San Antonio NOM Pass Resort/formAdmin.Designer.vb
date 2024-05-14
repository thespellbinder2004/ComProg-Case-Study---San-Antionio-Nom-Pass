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
        nudPresidentialRoomNumbers = New NumericUpDown()
        nudStandardRoomNumbers = New NumericUpDown()
        nudExecutiveRoomNumbers = New NumericUpDown()
        nudTwinRoomNumbers = New NumericUpDown()
        nudKingRoomNumbers = New NumericUpDown()
        nudQueenRoomNumbers = New NumericUpDown()
        nudSingleRoomNumbers = New NumericUpDown()
        nudPresidentialAvailableRooms = New NumericUpDown()
        nudExecutiveAvailableRooms = New NumericUpDown()
        nudStandardAvailableRooms = New NumericUpDown()
        nudTwinAvailableRooms = New NumericUpDown()
        nudKingAvailableRooms = New NumericUpDown()
        nudQueenAvailableRooms = New NumericUpDown()
        nudSingleAvailableRooms = New NumericUpDown()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        btnPresidentialRoomDetails = New Button()
        Label12 = New Label()
        Label13 = New Label()
        btnExecutiveRoomDetails = New Button()
        Label10 = New Label()
        Label11 = New Label()
        btnStandardRoomDetails = New Button()
        Label8 = New Label()
        Label9 = New Label()
        btnTwinRoomDetails = New Button()
        Label6 = New Label()
        Label7 = New Label()
        btnKingRoomDetails = New Button()
        Label4 = New Label()
        Label5 = New Label()
        btnQueenRoomDetails = New Button()
        Label2 = New Label()
        Label3 = New Label()
        btnSingleRoomDetails = New Button()
        lblPresidentialRoom = New Label()
        lblRoomNumbers1 = New Label()
        lblAvailableRooms1 = New Label()
        lblExucutiveRoom = New Label()
        lblStandardRoom = New Label()
        lblTwinRoom = New Label()
        lblKingRoom = New Label()
        lblQueenRoom = New Label()
        lblSingleRoom = New Label()
        tabGuests = New TabPage()
        dgvGuestTable = New DataGridView()
        columnEdit = New DataGridViewButtonColumn()
        columnFirstName = New DataGridViewTextBoxColumn()
        columnLastnName = New DataGridViewTextBoxColumn()
        columnArrival = New DataGridViewTextBoxColumn()
        columnDeparture = New DataGridViewTextBoxColumn()
        columnTotalGuests = New DataGridViewTextBoxColumn()
        tabGuestInfo = New TabPage()
        Label47 = New Label()
        TextBox1 = New TextBox()
        Label41 = New Label()
        TextBox6 = New TextBox()
        Label45 = New Label()
        TextBox3 = New TextBox()
        Label44 = New Label()
        TextBox2 = New TextBox()
        Label43 = New Label()
        TextBox4 = New TextBox()
        Label42 = New Label()
        TextBox0 = New TextBox()
        Label40 = New Label()
        Label1 = New Label()
        btnRefresh = New Button()
        ComboBox3 = New ComboBox()
        tbcAdmin.SuspendLayout()
        tabAdminInfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        tabRooms.SuspendLayout()
        CType(nudPresidentialRoomNumbers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStandardRoomNumbers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudExecutiveRoomNumbers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTwinRoomNumbers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudKingRoomNumbers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudQueenRoomNumbers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSingleRoomNumbers, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPresidentialAvailableRooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudExecutiveAvailableRooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStandardAvailableRooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudTwinAvailableRooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudKingAvailableRooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudQueenAvailableRooms, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSingleAvailableRooms, ComponentModel.ISupportInitialize).BeginInit()
        tabGuests.SuspendLayout()
        CType(dgvGuestTable, ComponentModel.ISupportInitialize).BeginInit()
        tabGuestInfo.SuspendLayout()
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
        tabAdminInfo.Location = New Point(4, 29)
        tabAdminInfo.Margin = New Padding(3, 4, 3, 4)
        tabAdminInfo.Name = "tabAdminInfo"
        tabAdminInfo.Padding = New Padding(3, 4, 3, 4)
        tabAdminInfo.Size = New Size(907, 674)
        tabAdminInfo.TabIndex = 0
        tabAdminInfo.Text = "Admin Info"
        tabAdminInfo.UseVisualStyleBackColor = True
        ' 
        ' txtAdminContact2
        ' 
        txtAdminContact2.Location = New Point(251, 585)
        txtAdminContact2.Margin = New Padding(3, 4, 3, 4)
        txtAdminContact2.Name = "txtAdminContact2"
        txtAdminContact2.Size = New Size(257, 27)
        txtAdminContact2.TabIndex = 28
        ' 
        ' txtAdminContact1
        ' 
        txtAdminContact1.Location = New Point(251, 541)
        txtAdminContact1.Margin = New Padding(3, 4, 3, 4)
        txtAdminContact1.Name = "txtAdminContact1"
        txtAdminContact1.Size = New Size(257, 27)
        txtAdminContact1.TabIndex = 27
        ' 
        ' txtAdminRole
        ' 
        txtAdminRole.Location = New Point(251, 503)
        txtAdminRole.Margin = New Padding(3, 4, 3, 4)
        txtAdminRole.Name = "txtAdminRole"
        txtAdminRole.Size = New Size(257, 27)
        txtAdminRole.TabIndex = 26
        ' 
        ' txtCurrentAdmin
        ' 
        txtCurrentAdmin.Location = New Point(251, 464)
        txtCurrentAdmin.Margin = New Padding(3, 4, 3, 4)
        txtCurrentAdmin.Name = "txtCurrentAdmin"
        txtCurrentAdmin.Size = New Size(257, 27)
        txtCurrentAdmin.TabIndex = 25
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label39.Location = New Point(74, 545)
        Label39.Name = "Label39"
        Label39.Size = New Size(109, 23)
        Label39.TabIndex = 24
        Label39.Text = "Contacts:"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(74, 507)
        Label38.Name = "Label38"
        Label38.Size = New Size(164, 23)
        Label38.TabIndex = 23
        Label38.Text = "Role/Position:"
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label37.Location = New Point(74, 469)
        Label37.Name = "Label37"
        Label37.Size = New Size(164, 23)
        Label37.TabIndex = 22
        Label37.Text = "Current Admin:"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(19, 431)
        Label30.Name = "Label30"
        Label30.Size = New Size(197, 23)
        Label30.TabIndex = 21
        Label30.Text = "Admin Information"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(210, 185)
        Label29.Name = "Label29"
        Label29.Size = New Size(318, 23)
        Label29.TabIndex = 20
        Label29.Text = "https://SanAntonioResort.com"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(210, 157)
        Label28.Name = "Label28"
        Label28.Size = New Size(131, 23)
        Label28.TabIndex = 19
        Label28.Text = "09123456789"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(210, 127)
        Label27.Name = "Label27"
        Label27.Size = New Size(263, 23)
        Label27.TabIndex = 18
        Label27.Text = "sanantonio143@gmail.com"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(210, 93)
        Label26.Name = "Label26"
        Label26.Size = New Size(285, 23)
        Label26.TabIndex = 17
        Label26.Text = "Kaliwa, Doon, Tarlac City"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(210, 59)
        Label25.Name = "Label25"
        Label25.Size = New Size(307, 23)
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
        GroupBox1.Location = New Point(210, 231)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(430, 176)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Resort Details"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Internet Access", "Swimming Pools", "Water Sports/Activities", "On-site Restaurant and Bar", "Kids' Club", "Laundry and Dry Cleaning", "Transportation"})
        ComboBox2.Location = New Point(206, 105)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(138, 27)
        ComboBox2.TabIndex = 25
        ComboBox2.Text = "Services"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Single Room", "", "Queen Room", "", "King Room", "", "Twin Room", "", "Standard Room", "", "Executive Suite", "", "Presidential Suite"})
        ComboBox1.Location = New Point(206, 67)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(138, 27)
        ComboBox1.TabIndex = 24
        ComboBox1.Text = "Room Type"
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label36.ForeColor = Color.Orange
        Label36.Location = New Point(200, 128)
        Label36.Name = "Label36"
        Label36.Size = New Size(139, 43)
        Label36.TabIndex = 23
        Label36.Text = "★★★★★"
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label35.Location = New Point(206, 36)
        Label35.Name = "Label35"
        Label35.Size = New Size(32, 23)
        Label35.TabIndex = 22
        Label35.Text = "71"
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label34.Location = New Point(35, 137)
        Label34.Name = "Label34"
        Label34.Size = New Size(98, 23)
        Label34.TabIndex = 14
        Label34.Text = "Ratings:"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label33.Location = New Point(35, 104)
        Label33.Name = "Label33"
        Label33.Size = New Size(109, 23)
        Label33.TabIndex = 13
        Label33.Text = "Services:"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label32.Location = New Point(35, 69)
        Label32.Name = "Label32"
        Label32.Size = New Size(131, 23)
        Label32.TabIndex = 12
        Label32.Text = "Room Types:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(35, 36)
        Label31.Name = "Label31"
        Label31.Size = New Size(142, 23)
        Label31.TabIndex = 11
        Label31.Text = "Total Rooms:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(74, 127)
        Label24.Name = "Label24"
        Label24.Size = New Size(109, 23)
        Label24.TabIndex = 14
        Label24.Text = "Contacts:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(74, 93)
        Label23.Name = "Label23"
        Label23.Size = New Size(109, 23)
        Label23.TabIndex = 13
        Label23.Text = "Location:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(74, 59)
        Label22.Name = "Label22"
        Label22.Size = New Size(65, 23)
        Label22.TabIndex = 12
        Label22.Text = "Name:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(19, 19)
        Label21.Name = "Label21"
        Label21.Size = New Size(208, 23)
        Label21.TabIndex = 11
        Label21.Text = "Resort Information"
        ' 
        ' tabRooms
        ' 
        tabRooms.AutoScroll = True
        tabRooms.Controls.Add(ComboBox3)
        tabRooms.Controls.Add(nudPresidentialRoomNumbers)
        tabRooms.Controls.Add(nudStandardRoomNumbers)
        tabRooms.Controls.Add(nudExecutiveRoomNumbers)
        tabRooms.Controls.Add(nudTwinRoomNumbers)
        tabRooms.Controls.Add(nudKingRoomNumbers)
        tabRooms.Controls.Add(nudQueenRoomNumbers)
        tabRooms.Controls.Add(nudSingleRoomNumbers)
        tabRooms.Controls.Add(nudPresidentialAvailableRooms)
        tabRooms.Controls.Add(nudExecutiveAvailableRooms)
        tabRooms.Controls.Add(nudStandardAvailableRooms)
        tabRooms.Controls.Add(nudTwinAvailableRooms)
        tabRooms.Controls.Add(nudKingAvailableRooms)
        tabRooms.Controls.Add(nudQueenAvailableRooms)
        tabRooms.Controls.Add(nudSingleAvailableRooms)
        tabRooms.Controls.Add(Label20)
        tabRooms.Controls.Add(Label19)
        tabRooms.Controls.Add(Label18)
        tabRooms.Controls.Add(Label17)
        tabRooms.Controls.Add(Label16)
        tabRooms.Controls.Add(Label15)
        tabRooms.Controls.Add(Label14)
        tabRooms.Controls.Add(btnPresidentialRoomDetails)
        tabRooms.Controls.Add(Label12)
        tabRooms.Controls.Add(Label13)
        tabRooms.Controls.Add(btnExecutiveRoomDetails)
        tabRooms.Controls.Add(Label10)
        tabRooms.Controls.Add(Label11)
        tabRooms.Controls.Add(btnStandardRoomDetails)
        tabRooms.Controls.Add(Label8)
        tabRooms.Controls.Add(Label9)
        tabRooms.Controls.Add(btnTwinRoomDetails)
        tabRooms.Controls.Add(Label6)
        tabRooms.Controls.Add(Label7)
        tabRooms.Controls.Add(btnKingRoomDetails)
        tabRooms.Controls.Add(Label4)
        tabRooms.Controls.Add(Label5)
        tabRooms.Controls.Add(btnQueenRoomDetails)
        tabRooms.Controls.Add(Label2)
        tabRooms.Controls.Add(Label3)
        tabRooms.Controls.Add(btnSingleRoomDetails)
        tabRooms.Controls.Add(lblPresidentialRoom)
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
        ' nudPresidentialRoomNumbers
        ' 
        nudPresidentialRoomNumbers.Location = New Point(773, 381)
        nudPresidentialRoomNumbers.Name = "nudPresidentialRoomNumbers"
        nudPresidentialRoomNumbers.Size = New Size(123, 27)
        nudPresidentialRoomNumbers.TabIndex = 116
        ' 
        ' nudStandardRoomNumbers
        ' 
        nudStandardRoomNumbers.Location = New Point(453, 381)
        nudStandardRoomNumbers.Name = "nudStandardRoomNumbers"
        nudStandardRoomNumbers.Size = New Size(123, 27)
        nudStandardRoomNumbers.TabIndex = 115
        ' 
        ' nudExecutiveRoomNumbers
        ' 
        nudExecutiveRoomNumbers.Location = New Point(453, 605)
        nudExecutiveRoomNumbers.Name = "nudExecutiveRoomNumbers"
        nudExecutiveRoomNumbers.Size = New Size(123, 27)
        nudExecutiveRoomNumbers.TabIndex = 114
        ' 
        ' nudTwinRoomNumbers
        ' 
        nudTwinRoomNumbers.Location = New Point(453, 151)
        nudTwinRoomNumbers.Name = "nudTwinRoomNumbers"
        nudTwinRoomNumbers.Size = New Size(123, 27)
        nudTwinRoomNumbers.TabIndex = 113
        ' 
        ' nudKingRoomNumbers
        ' 
        nudKingRoomNumbers.Location = New Point(134, 605)
        nudKingRoomNumbers.Name = "nudKingRoomNumbers"
        nudKingRoomNumbers.Size = New Size(123, 27)
        nudKingRoomNumbers.TabIndex = 112
        ' 
        ' nudQueenRoomNumbers
        ' 
        nudQueenRoomNumbers.Location = New Point(133, 381)
        nudQueenRoomNumbers.Name = "nudQueenRoomNumbers"
        nudQueenRoomNumbers.Size = New Size(123, 27)
        nudQueenRoomNumbers.TabIndex = 111
        ' 
        ' nudSingleRoomNumbers
        ' 
        nudSingleRoomNumbers.Location = New Point(133, 151)
        nudSingleRoomNumbers.Name = "nudSingleRoomNumbers"
        nudSingleRoomNumbers.Size = New Size(123, 27)
        nudSingleRoomNumbers.TabIndex = 110
        ' 
        ' nudPresidentialAvailableRooms
        ' 
        nudPresidentialAvailableRooms.Location = New Point(773, 341)
        nudPresidentialAvailableRooms.Name = "nudPresidentialAvailableRooms"
        nudPresidentialAvailableRooms.Size = New Size(123, 27)
        nudPresidentialAvailableRooms.TabIndex = 109
        ' 
        ' nudExecutiveAvailableRooms
        ' 
        nudExecutiveAvailableRooms.Location = New Point(454, 565)
        nudExecutiveAvailableRooms.Name = "nudExecutiveAvailableRooms"
        nudExecutiveAvailableRooms.Size = New Size(123, 27)
        nudExecutiveAvailableRooms.TabIndex = 108
        ' 
        ' nudStandardAvailableRooms
        ' 
        nudStandardAvailableRooms.Location = New Point(453, 341)
        nudStandardAvailableRooms.Name = "nudStandardAvailableRooms"
        nudStandardAvailableRooms.Size = New Size(123, 27)
        nudStandardAvailableRooms.TabIndex = 107
        ' 
        ' nudTwinAvailableRooms
        ' 
        nudTwinAvailableRooms.Location = New Point(453, 112)
        nudTwinAvailableRooms.Name = "nudTwinAvailableRooms"
        nudTwinAvailableRooms.Size = New Size(123, 27)
        nudTwinAvailableRooms.TabIndex = 106
        ' 
        ' nudKingAvailableRooms
        ' 
        nudKingAvailableRooms.Location = New Point(134, 565)
        nudKingAvailableRooms.Name = "nudKingAvailableRooms"
        nudKingAvailableRooms.Size = New Size(123, 27)
        nudKingAvailableRooms.TabIndex = 105
        ' 
        ' nudQueenAvailableRooms
        ' 
        nudQueenAvailableRooms.Location = New Point(133, 341)
        nudQueenAvailableRooms.Name = "nudQueenAvailableRooms"
        nudQueenAvailableRooms.Size = New Size(123, 27)
        nudQueenAvailableRooms.TabIndex = 104
        ' 
        ' nudSingleAvailableRooms
        ' 
        nudSingleAvailableRooms.Location = New Point(133, 112)
        nudSingleAvailableRooms.Name = "nudSingleAvailableRooms"
        nudSingleAvailableRooms.Size = New Size(123, 27)
        nudSingleAvailableRooms.TabIndex = 103
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
        ' btnPresidentialRoomDetails
        ' 
        btnPresidentialRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnPresidentialRoomDetails.Location = New Point(651, 413)
        btnPresidentialRoomDetails.Name = "btnPresidentialRoomDetails"
        btnPresidentialRoomDetails.Size = New Size(247, 29)
        btnPresidentialRoomDetails.TabIndex = 95
        btnPresidentialRoomDetails.Text = "ROOM DETAILS"
        btnPresidentialRoomDetails.UseVisualStyleBackColor = True
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
        ' btnExecutiveRoomDetails
        ' 
        btnExecutiveRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnExecutiveRoomDetails.Location = New Point(330, 637)
        btnExecutiveRoomDetails.Name = "btnExecutiveRoomDetails"
        btnExecutiveRoomDetails.Size = New Size(247, 29)
        btnExecutiveRoomDetails.TabIndex = 90
        btnExecutiveRoomDetails.Text = "ROOM DETAILS"
        btnExecutiveRoomDetails.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label10.Location = New Point(330, 609)
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
        Label11.Location = New Point(330, 569)
        Label11.Name = "Label11"
        Label11.Size = New Size(118, 18)
        Label11.TabIndex = 86
        Label11.Text = "AVAILABLE ROOMS:"
        ' 
        ' btnStandardRoomDetails
        ' 
        btnStandardRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnStandardRoomDetails.Location = New Point(330, 413)
        btnStandardRoomDetails.Name = "btnStandardRoomDetails"
        btnStandardRoomDetails.Size = New Size(247, 29)
        btnStandardRoomDetails.TabIndex = 85
        btnStandardRoomDetails.Text = "ROOM DETAILS"
        btnStandardRoomDetails.UseVisualStyleBackColor = True
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
        ' btnKingRoomDetails
        ' 
        btnKingRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnKingRoomDetails.Location = New Point(10, 637)
        btnKingRoomDetails.Name = "btnKingRoomDetails"
        btnKingRoomDetails.Size = New Size(247, 29)
        btnKingRoomDetails.TabIndex = 75
        btnKingRoomDetails.Text = "ROOM DETAILS"
        btnKingRoomDetails.UseVisualStyleBackColor = True
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
        ' btnQueenRoomDetails
        ' 
        btnQueenRoomDetails.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnQueenRoomDetails.Location = New Point(10, 413)
        btnQueenRoomDetails.Name = "btnQueenRoomDetails"
        btnQueenRoomDetails.Size = New Size(247, 29)
        btnQueenRoomDetails.TabIndex = 70
        btnQueenRoomDetails.Text = "ROOM DETAILS"
        btnQueenRoomDetails.UseVisualStyleBackColor = True
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
        lblExucutiveRoom.Location = New Point(395, 445)
        lblExucutiveRoom.Name = "lblExucutiveRoom"
        lblExucutiveRoom.Size = New Size(134, 24)
        lblExucutiveRoom.TabIndex = 52
        lblExucutiveRoom.Text = "Executive Room"
        ' 
        ' lblStandardRoom
        ' 
        lblStandardRoom.AutoSize = True
        lblStandardRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblStandardRoom.Location = New Point(395, 216)
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
        lblKingRoom.Location = New Point(6, 445)
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
        tabGuests.Controls.Add(dgvGuestTable)
        tabGuests.Location = New Point(4, 29)
        tabGuests.Margin = New Padding(3, 4, 3, 4)
        tabGuests.Name = "tabGuests"
        tabGuests.Size = New Size(907, 674)
        tabGuests.TabIndex = 2
        tabGuests.Text = "Guests"
        tabGuests.UseVisualStyleBackColor = True
        ' 
        ' dgvGuestTable
        ' 
        dgvGuestTable.AllowUserToAddRows = False
        dgvGuestTable.AllowUserToDeleteRows = False
        dgvGuestTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuestTable.Columns.AddRange(New DataGridViewColumn() {columnEdit, columnFirstName, columnLastnName, columnArrival, columnDeparture, columnTotalGuests})
        dgvGuestTable.Location = New Point(1, 4)
        dgvGuestTable.Margin = New Padding(3, 4, 3, 4)
        dgvGuestTable.Name = "dgvGuestTable"
        dgvGuestTable.RowHeadersVisible = False
        dgvGuestTable.RowHeadersWidth = 51
        dgvGuestTable.Size = New Size(899, 661)
        dgvGuestTable.TabIndex = 0
        ' 
        ' columnEdit
        ' 
        columnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        columnEdit.HeaderText = "Edit"
        columnEdit.MinimumWidth = 6
        columnEdit.Name = "columnEdit"
        columnEdit.ReadOnly = True
        columnEdit.Resizable = DataGridViewTriState.True
        columnEdit.SortMode = DataGridViewColumnSortMode.Automatic
        columnEdit.Width = 37
        ' 
        ' columnFirstName
        ' 
        columnFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnFirstName.HeaderText = "First Name"
        columnFirstName.MinimumWidth = 10
        columnFirstName.Name = "columnFirstName"
        columnFirstName.ReadOnly = True
        columnFirstName.Resizable = DataGridViewTriState.False
        ' 
        ' columnLastnName
        ' 
        columnLastnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnLastnName.HeaderText = "Last Name"
        columnLastnName.MinimumWidth = 6
        columnLastnName.Name = "columnLastnName"
        columnLastnName.ReadOnly = True
        columnLastnName.Resizable = DataGridViewTriState.False
        ' 
        ' columnArrival
        ' 
        columnArrival.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnArrival.HeaderText = "Arrival"
        columnArrival.MinimumWidth = 6
        columnArrival.Name = "columnArrival"
        columnArrival.ReadOnly = True
        columnArrival.Resizable = DataGridViewTriState.False
        ' 
        ' columnDeparture
        ' 
        columnDeparture.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnDeparture.HeaderText = "Departure"
        columnDeparture.MinimumWidth = 6
        columnDeparture.Name = "columnDeparture"
        columnDeparture.ReadOnly = True
        columnDeparture.Resizable = DataGridViewTriState.False
        ' 
        ' columnTotalGuests
        ' 
        columnTotalGuests.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        columnTotalGuests.HeaderText = "Total Guests"
        columnTotalGuests.MinimumWidth = 6
        columnTotalGuests.Name = "columnTotalGuests"
        columnTotalGuests.ReadOnly = True
        columnTotalGuests.Resizable = DataGridViewTriState.False
        ' 
        ' tabGuestInfo
        ' 
        tabGuestInfo.Controls.Add(Label47)
        tabGuestInfo.Controls.Add(TextBox1)
        tabGuestInfo.Controls.Add(Label41)
        tabGuestInfo.Controls.Add(TextBox6)
        tabGuestInfo.Controls.Add(Label45)
        tabGuestInfo.Controls.Add(TextBox3)
        tabGuestInfo.Controls.Add(Label44)
        tabGuestInfo.Controls.Add(TextBox2)
        tabGuestInfo.Controls.Add(Label43)
        tabGuestInfo.Controls.Add(TextBox4)
        tabGuestInfo.Controls.Add(Label42)
        tabGuestInfo.Controls.Add(TextBox0)
        tabGuestInfo.Controls.Add(Label40)
        tabGuestInfo.Location = New Point(4, 29)
        tabGuestInfo.Margin = New Padding(3, 4, 3, 4)
        tabGuestInfo.Name = "tabGuestInfo"
        tabGuestInfo.Size = New Size(907, 674)
        tabGuestInfo.TabIndex = 3
        tabGuestInfo.Text = "Guest Info"
        tabGuestInfo.UseVisualStyleBackColor = True
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Consolas", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label47.Location = New Point(187, 91)
        Label47.Name = "Label47"
        Label47.Size = New Size(591, 70)
        Label47.TabIndex = 18
        Label47.Text = "Customer Details:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Consolas", 12F)
        TextBox1.Location = New Point(241, 289)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(537, 31)
        TextBox1.TabIndex = 15
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Consolas", 12F)
        Label41.Location = New Point(94, 293)
        Label41.Name = "Label41"
        Label41.Size = New Size(120, 23)
        Label41.TabIndex = 14
        Label41.Text = "Last Name:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Consolas", 12F)
        TextBox6.Location = New Point(241, 351)
        TextBox6.Margin = New Padding(3, 4, 3, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(537, 31)
        TextBox6.TabIndex = 13
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Consolas", 12F)
        Label45.Location = New Point(94, 355)
        Label45.Name = "Label45"
        Label45.Size = New Size(109, 23)
        Label45.TabIndex = 12
        Label45.Text = "Address :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Consolas", 12F)
        TextBox3.Location = New Point(241, 473)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(206, 31)
        TextBox3.TabIndex = 11
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Consolas", 12F)
        Label44.Location = New Point(94, 477)
        Label44.Name = "Label44"
        Label44.Size = New Size(120, 23)
        Label44.TabIndex = 10
        Label44.Text = "Birthday :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Consolas", 12F)
        TextBox2.Location = New Point(523, 417)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(254, 31)
        TextBox2.TabIndex = 9
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Consolas", 12F)
        Label43.Location = New Point(455, 417)
        Label43.Name = "Label43"
        Label43.Size = New Size(65, 23)
        Label43.TabIndex = 8
        Label43.Text = "Sex :"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Consolas", 12F)
        TextBox4.Location = New Point(241, 413)
        TextBox4.Margin = New Padding(3, 4, 3, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(206, 31)
        TextBox4.TabIndex = 7
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Consolas", 12F)
        Label42.Location = New Point(94, 417)
        Label42.Name = "Label42"
        Label42.Size = New Size(65, 23)
        Label42.TabIndex = 6
        Label42.Text = "Age :"
        ' 
        ' TextBox0
        ' 
        TextBox0.Font = New Font("Consolas", 12F)
        TextBox0.Location = New Point(241, 227)
        TextBox0.Margin = New Padding(3, 4, 3, 4)
        TextBox0.Name = "TextBox0"
        TextBox0.Size = New Size(537, 31)
        TextBox0.TabIndex = 3
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Consolas", 12F)
        Label40.Location = New Point(94, 231)
        Label40.Name = "Label40"
        Label40.Size = New Size(142, 23)
        Label40.TabIndex = 0
        Label40.Text = "First Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(530, 40)
        Label1.TabIndex = 1
        Label1.Text = "San Antonio Nom Pass Resort"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(789, 43)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(86, 31)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(281, 233)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 28)
        ComboBox3.TabIndex = 117
        ' 
        ' formAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(914, 797)
        Controls.Add(btnRefresh)
        Controls.Add(Label1)
        Controls.Add(tbcAdmin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "formAdmin"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "formAdmin"
        tbcAdmin.ResumeLayout(False)
        tabAdminInfo.ResumeLayout(False)
        tabAdminInfo.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        tabRooms.ResumeLayout(False)
        tabRooms.PerformLayout()
        CType(nudPresidentialRoomNumbers, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStandardRoomNumbers, ComponentModel.ISupportInitialize).EndInit()
        CType(nudExecutiveRoomNumbers, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTwinRoomNumbers, ComponentModel.ISupportInitialize).EndInit()
        CType(nudKingRoomNumbers, ComponentModel.ISupportInitialize).EndInit()
        CType(nudQueenRoomNumbers, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSingleRoomNumbers, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPresidentialAvailableRooms, ComponentModel.ISupportInitialize).EndInit()
        CType(nudExecutiveAvailableRooms, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStandardAvailableRooms, ComponentModel.ISupportInitialize).EndInit()
        CType(nudTwinAvailableRooms, ComponentModel.ISupportInitialize).EndInit()
        CType(nudKingAvailableRooms, ComponentModel.ISupportInitialize).EndInit()
        CType(nudQueenAvailableRooms, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSingleAvailableRooms, ComponentModel.ISupportInitialize).EndInit()
        tabGuests.ResumeLayout(False)
        CType(dgvGuestTable, ComponentModel.ISupportInitialize).EndInit()
        tabGuestInfo.ResumeLayout(False)
        tabGuestInfo.PerformLayout()
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
    Friend WithEvents btnSingleRoomDetails As Button
    Friend WithEvents btnKingRoomDetails As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnQueenRoomDetails As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPresidentialRoomDetails As Button
    Friend WithEvents txtPresidentialRoomNumbers As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnExecutiveRoomDetails As Button
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
    Friend WithEvents dgvGuestTable As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents columnEdit As DataGridViewButtonColumn
    Friend WithEvents columnFirstName As DataGridViewTextBoxColumn
    Friend WithEvents columnLastnName As DataGridViewTextBoxColumn
    Friend WithEvents columnArrival As DataGridViewTextBoxColumn
    Friend WithEvents columnDeparture As DataGridViewTextBoxColumn
    Friend WithEvents columnTotalGuests As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents nudSingleAvailableRooms As NumericUpDown
    Friend WithEvents nudTwinAvailableRooms As NumericUpDown
    Friend WithEvents nudKingAvailableRooms As NumericUpDown
    Friend WithEvents nudQueenAvailableRooms As NumericUpDown
    Friend WithEvents nudExecutiveAvailableRooms As NumericUpDown
    Friend WithEvents nudStandardAvailableRooms As NumericUpDown
    Friend WithEvents nudPresidentialAvailableRooms As NumericUpDown
    Friend WithEvents nudExecutiveRoomNumbers As NumericUpDown
    Friend WithEvents nudTwinRoomNumbers As NumericUpDown
    Friend WithEvents nudKingRoomNumbers As NumericUpDown
    Friend WithEvents nudQueenRoomNumbers As NumericUpDown
    Friend WithEvents nudSingleRoomNumbers As NumericUpDown
    Friend WithEvents nudPresidentialRoomNumbers As NumericUpDown
    Friend WithEvents nudStandardRoomNumbers As NumericUpDown
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents TextBox0 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents ComboBox3 As ComboBox
End Class
