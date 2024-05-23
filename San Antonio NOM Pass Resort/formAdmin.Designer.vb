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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tbcAdmin = New TabControl()
        tabAdminInfo = New TabPage()
        Label54 = New Label()
        Label53 = New Label()
        Label52 = New Label()
        Label51 = New Label()
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
        Label71 = New Label()
        Label70 = New Label()
        Label69 = New Label()
        Label68 = New Label()
        Label67 = New Label()
        Label66 = New Label()
        Label65 = New Label()
        Label64 = New Label()
        Label63 = New Label()
        Label62 = New Label()
        Label61 = New Label()
        Label60 = New Label()
        Button1 = New Button()
        Label59 = New Label()
        Label58 = New Label()
        cbPresidentialRoomNumbers = New ComboBox()
        cbExecutiveRoomNumbers = New ComboBox()
        cbStandardRoomNumbers = New ComboBox()
        cbKingRoomNumbers = New ComboBox()
        cbTwinRoomNumbers = New ComboBox()
        cbQueenRoomNumbers = New ComboBox()
        cbSingleRoomNumbers = New ComboBox()
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
        Label12 = New Label()
        Label13 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label3 = New Label()
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
        Panel1 = New Panel()
        dgvGuestTable = New DataGridView()
        columnEdit = New DataGridViewButtonColumn()
        columnFirstName = New DataGridViewTextBoxColumn()
        columnLastnName = New DataGridViewTextBoxColumn()
        columnArrival = New DataGridViewTextBoxColumn()
        columnDeparture = New DataGridViewTextBoxColumn()
        columnTotalGuests = New DataGridViewTextBoxColumn()
        tabGuestInfo = New TabPage()
        pnlPayment = New Panel()
        btnCanc = New Button()
        btnConfi = New Button()
        txtPaym = New TextBox()
        txtTotBill = New TextBox()
        Label57 = New Label()
        Label56 = New Label()
        Label55 = New Label()
        btnCheckOut = New Button()
        TextBox9 = New TextBox()
        Label50 = New Label()
        TextBox8 = New TextBox()
        Label49 = New Label()
        TextBox7 = New TextBox()
        Label48 = New Label()
        TextBox5 = New TextBox()
        Label46 = New Label()
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
        tbcAdmin.SuspendLayout()
        tabAdminInfo.SuspendLayout()
        GroupBox1.SuspendLayout()
        tabRooms.SuspendLayout()
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
        pnlPayment.SuspendLayout()
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
        tabAdminInfo.Controls.Add(Label54)
        tabAdminInfo.Controls.Add(Label53)
        tabAdminInfo.Controls.Add(Label52)
        tabAdminInfo.Controls.Add(Label51)
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
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label54.Location = New Point(215, 444)
        Label54.Name = "Label54"
        Label54.Size = New Size(180, 19)
        Label54.TabIndex = 28
        Label54.Text = "mcquan214@gmail.com"
        ' 
        ' Label53
        ' 
        Label53.AutoSize = True
        Label53.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label53.Location = New Point(215, 416)
        Label53.Name = "Label53"
        Label53.Size = New Size(108, 19)
        Label53.TabIndex = 27
        Label53.Text = "09159615022"
        ' 
        ' Label52
        ' 
        Label52.AutoSize = True
        Label52.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label52.Location = New Point(215, 383)
        Label52.Name = "Label52"
        Label52.Size = New Size(225, 19)
        Label52.TabIndex = 26
        Label52.Text = "Administrative Assistant"
        ' 
        ' Label51
        ' 
        Label51.AutoSize = True
        Label51.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label51.Location = New Point(215, 352)
        Label51.Name = "Label51"
        Label51.Size = New Size(162, 19)
        Label51.TabIndex = 25
        Label51.Text = "Mc Jamiel D. Quan"
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label39.Location = New Point(65, 416)
        Label39.Name = "Label39"
        Label39.Size = New Size(90, 19)
        Label39.TabIndex = 24
        Label39.Text = "Contacts:"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label38.Location = New Point(65, 383)
        Label38.Name = "Label38"
        Label38.Size = New Size(90, 19)
        Label38.TabIndex = 23
        Label38.Text = "Position:"
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
        Label26.Size = New Size(315, 19)
        Label26.TabIndex = 17
        Label26.Text = "Kaliwa, Satabi Langpo, Tarlac City"
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
        ComboBox2.TabIndex = 1
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
        ComboBox1.TabIndex = 0
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
        Label35.Text = "35"
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
        tabRooms.Controls.Add(Label71)
        tabRooms.Controls.Add(Label70)
        tabRooms.Controls.Add(Label69)
        tabRooms.Controls.Add(Label68)
        tabRooms.Controls.Add(Label67)
        tabRooms.Controls.Add(Label66)
        tabRooms.Controls.Add(Label65)
        tabRooms.Controls.Add(Label64)
        tabRooms.Controls.Add(Label63)
        tabRooms.Controls.Add(Label62)
        tabRooms.Controls.Add(Label61)
        tabRooms.Controls.Add(Label60)
        tabRooms.Controls.Add(Button1)
        tabRooms.Controls.Add(Label59)
        tabRooms.Controls.Add(Label58)
        tabRooms.Controls.Add(cbPresidentialRoomNumbers)
        tabRooms.Controls.Add(cbExecutiveRoomNumbers)
        tabRooms.Controls.Add(cbStandardRoomNumbers)
        tabRooms.Controls.Add(cbKingRoomNumbers)
        tabRooms.Controls.Add(cbTwinRoomNumbers)
        tabRooms.Controls.Add(cbQueenRoomNumbers)
        tabRooms.Controls.Add(cbSingleRoomNumbers)
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
        tabRooms.Controls.Add(Label12)
        tabRooms.Controls.Add(Label13)
        tabRooms.Controls.Add(Label10)
        tabRooms.Controls.Add(Label11)
        tabRooms.Controls.Add(Label8)
        tabRooms.Controls.Add(Label9)
        tabRooms.Controls.Add(Label6)
        tabRooms.Controls.Add(Label7)
        tabRooms.Controls.Add(Label4)
        tabRooms.Controls.Add(Label5)
        tabRooms.Controls.Add(Label2)
        tabRooms.Controls.Add(Label3)
        tabRooms.Controls.Add(lblPresidentialRoom)
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
        ' Label71
        ' 
        Label71.AutoSize = True
        Label71.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label71.Location = New Point(249, 1102)
        Label71.Name = "Label71"
        Label71.Size = New Size(73, 14)
        Label71.TabIndex = 137
        Label71.Text = "2699 | 1 Night "
        ' 
        ' Label70
        ' 
        Label70.AutoSize = True
        Label70.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label70.Location = New Point(249, 1083)
        Label70.Name = "Label70"
        Label70.Size = New Size(81, 14)
        Label70.TabIndex = 136
        Label70.Text = "Up to 10 Guests"
        ' 
        ' Label69
        ' 
        Label69.AutoSize = True
        Label69.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label69.Location = New Point(249, 916)
        Label69.Name = "Label69"
        Label69.Size = New Size(74, 14)
        Label69.TabIndex = 135
        Label69.Text = "2299 | 1 Night "
        ' 
        ' Label68
        ' 
        Label68.AutoSize = True
        Label68.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label68.Location = New Point(249, 898)
        Label68.Name = "Label68"
        Label68.Size = New Size(77, 14)
        Label68.TabIndex = 134
        Label68.Text = "Up to 8 Guests"
        ' 
        ' Label67
        ' 
        Label67.AutoSize = True
        Label67.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label67.Location = New Point(249, 748)
        Label67.Name = "Label67"
        Label67.Size = New Size(72, 14)
        Label67.TabIndex = 133
        Label67.Text = "1399 | 1 Night "
        ' 
        ' Label66
        ' 
        Label66.AutoSize = True
        Label66.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label66.Location = New Point(249, 730)
        Label66.Name = "Label66"
        Label66.Size = New Size(77, 14)
        Label66.TabIndex = 132
        Label66.Text = "Up to 3 Guests"
        ' 
        ' Label65
        ' 
        Label65.AutoSize = True
        Label65.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label65.Location = New Point(249, 590)
        Label65.Name = "Label65"
        Label65.Size = New Size(70, 14)
        Label65.TabIndex = 131
        Label65.Text = "1199 | 1 Night "
        ' 
        ' Label64
        ' 
        Label64.AutoSize = True
        Label64.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label64.Location = New Point(249, 571)
        Label64.Name = "Label64"
        Label64.Size = New Size(77, 14)
        Label64.TabIndex = 130
        Label64.Text = "Up to 2 Guests"
        ' 
        ' Label63
        ' 
        Label63.AutoSize = True
        Label63.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label63.Location = New Point(249, 428)
        Label63.Name = "Label63"
        Label63.Size = New Size(71, 14)
        Label63.TabIndex = 129
        Label63.Text = "1999 | 1 Night "
        ' 
        ' Label62
        ' 
        Label62.AutoSize = True
        Label62.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label62.Location = New Point(249, 409)
        Label62.Name = "Label62"
        Label62.Size = New Size(76, 14)
        Label62.TabIndex = 128
        Label62.Text = "Up to 6 Guests"
        ' 
        ' Label61
        ' 
        Label61.AutoSize = True
        Label61.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label61.Location = New Point(249, 268)
        Label61.Name = "Label61"
        Label61.Size = New Size(71, 14)
        Label61.TabIndex = 127
        Label61.Text = "1799 | 1 Night "
        ' 
        ' Label60
        ' 
        Label60.AutoSize = True
        Label60.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label60.Location = New Point(250, 250)
        Label60.Name = "Label60"
        Label60.Size = New Size(77, 14)
        Label60.TabIndex = 126
        Label60.Text = "Up to 4 Guests"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(492, 1036)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 128)
        Button1.TabIndex = 15
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label59
        ' 
        Label59.AutoSize = True
        Label59.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label59.Location = New Point(249, 98)
        Label59.Name = "Label59"
        Label59.Size = New Size(67, 14)
        Label59.TabIndex = 124
        Label59.Text = "999 | 1 Night "
        ' 
        ' Label58
        ' 
        Label58.AutoSize = True
        Label58.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label58.Location = New Point(250, 79)
        Label58.Name = "Label58"
        Label58.Size = New Size(77, 14)
        Label58.TabIndex = 123
        Label58.Text = "Up to 2 Guests"
        ' 
        ' cbPresidentialRoomNumbers
        ' 
        cbPresidentialRoomNumbers.FormattingEnabled = True
        cbPresidentialRoomNumbers.Location = New Point(627, 1099)
        cbPresidentialRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        cbPresidentialRoomNumbers.Name = "cbPresidentialRoomNumbers"
        cbPresidentialRoomNumbers.Size = New Size(109, 23)
        cbPresidentialRoomNumbers.TabIndex = 14
        ' 
        ' cbExecutiveRoomNumbers
        ' 
        cbExecutiveRoomNumbers.FormattingEnabled = True
        cbExecutiveRoomNumbers.Location = New Point(627, 914)
        cbExecutiveRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        cbExecutiveRoomNumbers.Name = "cbExecutiveRoomNumbers"
        cbExecutiveRoomNumbers.Size = New Size(109, 23)
        cbExecutiveRoomNumbers.TabIndex = 12
        ' 
        ' cbStandardRoomNumbers
        ' 
        cbStandardRoomNumbers.FormattingEnabled = True
        cbStandardRoomNumbers.Location = New Point(628, 424)
        cbStandardRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        cbStandardRoomNumbers.Name = "cbStandardRoomNumbers"
        cbStandardRoomNumbers.Size = New Size(109, 23)
        cbStandardRoomNumbers.TabIndex = 6
        ' 
        ' cbKingRoomNumbers
        ' 
        cbKingRoomNumbers.FormattingEnabled = True
        cbKingRoomNumbers.Location = New Point(627, 746)
        cbKingRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        cbKingRoomNumbers.Name = "cbKingRoomNumbers"
        cbKingRoomNumbers.Size = New Size(109, 23)
        cbKingRoomNumbers.TabIndex = 10
        ' 
        ' cbTwinRoomNumbers
        ' 
        cbTwinRoomNumbers.FormattingEnabled = True
        cbTwinRoomNumbers.Location = New Point(628, 266)
        cbTwinRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        cbTwinRoomNumbers.Name = "cbTwinRoomNumbers"
        cbTwinRoomNumbers.Size = New Size(109, 23)
        cbTwinRoomNumbers.TabIndex = 4
        ' 
        ' cbQueenRoomNumbers
        ' 
        cbQueenRoomNumbers.FormattingEnabled = True
        cbQueenRoomNumbers.Location = New Point(629, 586)
        cbQueenRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        cbQueenRoomNumbers.Name = "cbQueenRoomNumbers"
        cbQueenRoomNumbers.Size = New Size(109, 23)
        cbQueenRoomNumbers.TabIndex = 8
        ' 
        ' cbSingleRoomNumbers
        ' 
        cbSingleRoomNumbers.FormattingEnabled = True
        cbSingleRoomNumbers.Location = New Point(628, 94)
        cbSingleRoomNumbers.Margin = New Padding(3, 2, 3, 2)
        cbSingleRoomNumbers.Name = "cbSingleRoomNumbers"
        cbSingleRoomNumbers.Size = New Size(109, 23)
        cbSingleRoomNumbers.TabIndex = 2
        ' 
        ' nudPresidentialAvailableRooms
        ' 
        nudPresidentialAvailableRooms.Location = New Point(627, 1060)
        nudPresidentialAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        nudPresidentialAvailableRooms.Name = "nudPresidentialAvailableRooms"
        nudPresidentialAvailableRooms.ReadOnly = True
        nudPresidentialAvailableRooms.Size = New Size(108, 23)
        nudPresidentialAvailableRooms.TabIndex = 13
        ' 
        ' nudExecutiveAvailableRooms
        ' 
        nudExecutiveAvailableRooms.Location = New Point(627, 875)
        nudExecutiveAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        nudExecutiveAvailableRooms.Name = "nudExecutiveAvailableRooms"
        nudExecutiveAvailableRooms.ReadOnly = True
        nudExecutiveAvailableRooms.Size = New Size(108, 23)
        nudExecutiveAvailableRooms.TabIndex = 11
        ' 
        ' nudStandardAvailableRooms
        ' 
        nudStandardAvailableRooms.Location = New Point(628, 386)
        nudStandardAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        nudStandardAvailableRooms.Name = "nudStandardAvailableRooms"
        nudStandardAvailableRooms.ReadOnly = True
        nudStandardAvailableRooms.Size = New Size(108, 23)
        nudStandardAvailableRooms.TabIndex = 5
        ' 
        ' nudTwinAvailableRooms
        ' 
        nudTwinAvailableRooms.Location = New Point(628, 227)
        nudTwinAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        nudTwinAvailableRooms.Name = "nudTwinAvailableRooms"
        nudTwinAvailableRooms.ReadOnly = True
        nudTwinAvailableRooms.Size = New Size(108, 23)
        nudTwinAvailableRooms.TabIndex = 3
        ' 
        ' nudKingAvailableRooms
        ' 
        nudKingAvailableRooms.Location = New Point(627, 707)
        nudKingAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        nudKingAvailableRooms.Name = "nudKingAvailableRooms"
        nudKingAvailableRooms.ReadOnly = True
        nudKingAvailableRooms.Size = New Size(108, 23)
        nudKingAvailableRooms.TabIndex = 9
        ' 
        ' nudQueenAvailableRooms
        ' 
        nudQueenAvailableRooms.Location = New Point(629, 548)
        nudQueenAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        nudQueenAvailableRooms.Name = "nudQueenAvailableRooms"
        nudQueenAvailableRooms.ReadOnly = True
        nudQueenAvailableRooms.Size = New Size(108, 23)
        nudQueenAvailableRooms.TabIndex = 7
        ' 
        ' nudSingleAvailableRooms
        ' 
        nudSingleAvailableRooms.Location = New Point(628, 56)
        nudSingleAvailableRooms.Margin = New Padding(3, 2, 3, 2)
        nudSingleAvailableRooms.Name = "nudSingleAvailableRooms"
        nudSingleAvailableRooms.ReadOnly = True
        nudSingleAvailableRooms.Size = New Size(108, 23)
        nudSingleAvailableRooms.TabIndex = 1
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(249, 1063)
        Label20.Name = "Label20"
        Label20.Size = New Size(133, 14)
        Label20.TabIndex = 102
        Label20.Text = "2 King Beds | 2 Bathrooms"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(249, 388)
        Label19.Name = "Label19"
        Label19.Size = New Size(146, 14)
        Label19.TabIndex = 101
        Label19.Text = "2 Double Beds | 2 Bathrooms" & vbCrLf
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(249, 878)
        Label18.Name = "Label18"
        Label18.Size = New Size(134, 14)
        Label18.TabIndex = 100
        Label18.Text = "2 Twin Beds | 2 Bathrooms"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(249, 230)
        Label17.Name = "Label17"
        Label17.Size = New Size(134, 14)
        Label17.TabIndex = 99
        Label17.Text = "2 Twin Beds | 2 Bathrooms"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(249, 710)
        Label16.Name = "Label16"
        Label16.Size = New Size(119, 14)
        Label16.TabIndex = 98
        Label16.Text = "1 King Bed | 1 Bathroom"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(249, 550)
        Label15.Name = "Label15"
        Label15.Size = New Size(129, 14)
        Label15.TabIndex = 97
        Label15.Text = "1 Queen Bed | 1 Bathroom"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(249, 58)
        Label14.Name = "Label14"
        Label14.Size = New Size(132, 14)
        Label14.TabIndex = 96
        Label14.Text = "1 Double Bed | 1 Bathroom"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label12.Location = New Point(627, 1083)
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
        Label13.Location = New Point(627, 1045)
        Label13.Name = "Label13"
        Label13.Size = New Size(99, 14)
        Label13.TabIndex = 91
        Label13.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label10.Location = New Point(627, 898)
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
        Label11.Location = New Point(627, 860)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 14)
        Label11.TabIndex = 86
        Label11.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label8.Location = New Point(627, 409)
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
        Label9.Location = New Point(627, 370)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 14)
        Label9.TabIndex = 81
        Label9.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label6.Location = New Point(628, 250)
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
        Label7.Location = New Point(628, 212)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 14)
        Label7.TabIndex = 76
        Label7.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label4.Location = New Point(627, 730)
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
        Label5.Location = New Point(627, 692)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 14)
        Label5.TabIndex = 71
        Label5.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bahnschrift SemiCondensed", 9F)
        Label2.Location = New Point(627, 571)
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
        Label3.Location = New Point(627, 532)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 14)
        Label3.TabIndex = 66
        Label3.Text = "AVAILABLE ROOMS:"
        ' 
        ' lblPresidentialRoom
        ' 
        lblPresidentialRoom.AutoSize = True
        lblPresidentialRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblPresidentialRoom.Location = New Point(5, 975)
        lblPresidentialRoom.Name = "lblPresidentialRoom"
        lblPresidentialRoom.Size = New Size(124, 19)
        lblPresidentialRoom.TabIndex = 60
        lblPresidentialRoom.Text = "Presidential Room"
        ' 
        ' lblRoomNumbers1
        ' 
        lblRoomNumbers1.AutoSize = True
        lblRoomNumbers1.BackColor = Color.Transparent
        lblRoomNumbers1.Font = New Font("Bahnschrift SemiCondensed", 9F)
        lblRoomNumbers1.Location = New Point(628, 79)
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
        lblAvailableRooms1.Location = New Point(628, 40)
        lblAvailableRooms1.Name = "lblAvailableRooms1"
        lblAvailableRooms1.Size = New Size(99, 14)
        lblAvailableRooms1.TabIndex = 61
        lblAvailableRooms1.Text = "AVAILABLE ROOMS:"
        ' 
        ' lblExucutiveRoom
        ' 
        lblExucutiveRoom.AutoSize = True
        lblExucutiveRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblExucutiveRoom.Location = New Point(3, 813)
        lblExucutiveRoom.Name = "lblExucutiveRoom"
        lblExucutiveRoom.Size = New Size(108, 19)
        lblExucutiveRoom.TabIndex = 52
        lblExucutiveRoom.Text = "Executive Room"
        ' 
        ' lblStandardRoom
        ' 
        lblStandardRoom.AutoSize = True
        lblStandardRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblStandardRoom.Location = New Point(3, 327)
        lblStandardRoom.Name = "lblStandardRoom"
        lblStandardRoom.Size = New Size(107, 19)
        lblStandardRoom.TabIndex = 44
        lblStandardRoom.Text = "Standard Room"
        ' 
        ' lblTwinRoom
        ' 
        lblTwinRoom.AutoSize = True
        lblTwinRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblTwinRoom.Location = New Point(3, 165)
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
        lblKingRoom.Location = New Point(3, 651)
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
        lblQueenRoom.Location = New Point(3, 489)
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
        tabGuests.Controls.Add(Panel1)
        tabGuests.Controls.Add(dgvGuestTable)
        tabGuests.Location = New Point(4, 24)
        tabGuests.Name = "tabGuests"
        tabGuests.Size = New Size(793, 502)
        tabGuests.TabIndex = 2
        tabGuests.Text = "Guests"
        tabGuests.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(6, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(32, 20)
        Panel1.TabIndex = 1
        ' 
        ' dgvGuestTable
        ' 
        dgvGuestTable.AllowUserToAddRows = False
        dgvGuestTable.AllowUserToDeleteRows = False
        dgvGuestTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGuestTable.Columns.AddRange(New DataGridViewColumn() {columnEdit, columnFirstName, columnLastnName, columnArrival, columnDeparture, columnTotalGuests})
        dgvGuestTable.Location = New Point(1, 3)
        dgvGuestTable.Name = "dgvGuestTable"
        dgvGuestTable.RowHeadersVisible = False
        dgvGuestTable.RowHeadersWidth = 51
        dgvGuestTable.Size = New Size(787, 496)
        dgvGuestTable.TabIndex = 0
        ' 
        ' columnEdit
        ' 
        columnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        columnEdit.HeaderText = "Edit"
        columnEdit.MinimumWidth = 6
        columnEdit.Name = "columnEdit"
        columnEdit.ReadOnly = True
        columnEdit.SortMode = DataGridViewColumnSortMode.Automatic
        columnEdit.Text = "Edit"
        columnEdit.UseColumnTextForButtonValue = True
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
        tabGuestInfo.Controls.Add(pnlPayment)
        tabGuestInfo.Controls.Add(btnCheckOut)
        tabGuestInfo.Controls.Add(TextBox9)
        tabGuestInfo.Controls.Add(Label50)
        tabGuestInfo.Controls.Add(TextBox8)
        tabGuestInfo.Controls.Add(Label49)
        tabGuestInfo.Controls.Add(TextBox7)
        tabGuestInfo.Controls.Add(Label48)
        tabGuestInfo.Controls.Add(TextBox5)
        tabGuestInfo.Controls.Add(Label46)
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
        tabGuestInfo.Location = New Point(4, 24)
        tabGuestInfo.Name = "tabGuestInfo"
        tabGuestInfo.Size = New Size(793, 502)
        tabGuestInfo.TabIndex = 3
        tabGuestInfo.Text = "Guest Info"
        tabGuestInfo.UseVisualStyleBackColor = True
        ' 
        ' pnlPayment
        ' 
        pnlPayment.BorderStyle = BorderStyle.FixedSingle
        pnlPayment.Controls.Add(btnCanc)
        pnlPayment.Controls.Add(btnConfi)
        pnlPayment.Controls.Add(txtPaym)
        pnlPayment.Controls.Add(txtTotBill)
        pnlPayment.Controls.Add(Label57)
        pnlPayment.Controls.Add(Label56)
        pnlPayment.Controls.Add(Label55)
        pnlPayment.Location = New Point(189, 72)
        pnlPayment.Margin = New Padding(3, 2, 3, 2)
        pnlPayment.Name = "pnlPayment"
        pnlPayment.Size = New Size(380, 241)
        pnlPayment.TabIndex = 28
        pnlPayment.Visible = False
        ' 
        ' btnCanc
        ' 
        btnCanc.Location = New Point(214, 195)
        btnCanc.Margin = New Padding(3, 2, 3, 2)
        btnCanc.Name = "btnCanc"
        btnCanc.Size = New Size(82, 22)
        btnCanc.TabIndex = 3
        btnCanc.Text = "Back"
        btnCanc.UseVisualStyleBackColor = True
        btnCanc.Visible = False
        ' 
        ' btnConfi
        ' 
        btnConfi.Location = New Point(73, 195)
        btnConfi.Margin = New Padding(3, 2, 3, 2)
        btnConfi.Name = "btnConfi"
        btnConfi.Size = New Size(82, 22)
        btnConfi.TabIndex = 2
        btnConfi.Text = "Confirm"
        btnConfi.UseVisualStyleBackColor = True
        btnConfi.Visible = False
        ' 
        ' txtPaym
        ' 
        txtPaym.BackColor = Color.Gainsboro
        txtPaym.BorderStyle = BorderStyle.FixedSingle
        txtPaym.Location = New Point(139, 134)
        txtPaym.Margin = New Padding(3, 2, 3, 2)
        txtPaym.Name = "txtPaym"
        txtPaym.Size = New Size(188, 23)
        txtPaym.TabIndex = 1
        txtPaym.Visible = False
        ' 
        ' txtTotBill
        ' 
        txtTotBill.BackColor = Color.Gainsboro
        txtTotBill.BorderStyle = BorderStyle.FixedSingle
        txtTotBill.Location = New Point(168, 89)
        txtTotBill.Margin = New Padding(3, 2, 3, 2)
        txtTotBill.Name = "txtTotBill"
        txtTotBill.Size = New Size(160, 23)
        txtTotBill.TabIndex = 0
        txtTotBill.Visible = False
        ' 
        ' Label57
        ' 
        Label57.AutoSize = True
        Label57.Font = New Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label57.Location = New Point(131, 19)
        Label57.Name = "Label57"
        Label57.Size = New Size(96, 26)
        Label57.TabIndex = 1
        Label57.Text = "Payment"
        Label57.Visible = False
        ' 
        ' Label56
        ' 
        Label56.AutoSize = True
        Label56.Font = New Font("Consolas", 12F)
        Label56.Location = New Point(44, 89)
        Label56.Name = "Label56"
        Label56.Size = New Size(108, 19)
        Label56.TabIndex = 1
        Label56.Text = "Total Bill:"
        Label56.Visible = False
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Font = New Font("Consolas", 12F)
        Label55.Location = New Point(44, 134)
        Label55.Name = "Label55"
        Label55.Size = New Size(81, 19)
        Label55.TabIndex = 1
        Label55.Text = "Payment:"
        Label55.Visible = False
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.BackColor = Color.AntiqueWhite
        btnCheckOut.Location = New Point(496, 400)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(162, 55)
        btnCheckOut.TabIndex = 10
        btnCheckOut.Text = "Check-Out"
        btnCheckOut.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Consolas", 12F)
        TextBox9.Location = New Point(213, 414)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(197, 26)
        TextBox9.TabIndex = 9
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Font = New Font("Consolas", 12F)
        Label50.Location = New Point(84, 417)
        Label50.Name = "Label50"
        Label50.Size = New Size(117, 19)
        Label50.TabIndex = 25
        Label50.Text = "Total Bill :"
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Consolas", 12F)
        TextBox8.Location = New Point(529, 364)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(153, 26)
        TextBox8.TabIndex = 8
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Consolas", 12F)
        Label49.Location = New Point(84, 367)
        Label49.Name = "Label49"
        Label49.Size = New Size(108, 19)
        Label49.TabIndex = 23
        Label49.Text = "Room Type :"
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Consolas", 12F)
        TextBox7.Location = New Point(213, 364)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(197, 26)
        TextBox7.TabIndex = 7
        ' 
        ' Label48
        ' 
        Label48.AutoSize = True
        Label48.Font = New Font("Consolas", 12F)
        Label48.Location = New Point(429, 367)
        Label48.Name = "Label48"
        Label48.Size = New Size(81, 19)
        Label48.TabIndex = 21
        Label48.Text = "Room # :"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Consolas", 12F)
        TextBox5.Location = New Point(558, 318)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(124, 26)
        TextBox5.TabIndex = 6
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Font = New Font("Consolas", 12F)
        Label46.Location = New Point(429, 321)
        Label46.Name = "Label46"
        Label46.Size = New Size(117, 19)
        Label46.TabIndex = 19
        Label46.Text = "# of Guest :"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Consolas", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label47.Location = New Point(165, 32)
        Label47.Name = "Label47"
        Label47.Size = New Size(466, 56)
        Label47.TabIndex = 18
        Label47.Text = "Customer Details:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Consolas", 12F)
        TextBox1.Location = New Point(213, 180)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(470, 26)
        TextBox1.TabIndex = 1
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Consolas", 12F)
        Label41.Location = New Point(84, 183)
        Label41.Name = "Label41"
        Label41.Size = New Size(99, 19)
        Label41.TabIndex = 14
        Label41.Text = "Last Name:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Consolas", 12F)
        TextBox6.Location = New Point(213, 226)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(470, 26)
        TextBox6.TabIndex = 2
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.Font = New Font("Consolas", 12F)
        Label45.Location = New Point(84, 230)
        Label45.Name = "Label45"
        Label45.Size = New Size(90, 19)
        Label45.TabIndex = 12
        Label45.Text = "Address :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Consolas", 12F)
        TextBox3.Location = New Point(213, 318)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(197, 26)
        TextBox3.TabIndex = 5
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.Font = New Font("Consolas", 12F)
        Label44.Location = New Point(84, 321)
        Label44.Name = "Label44"
        Label44.Size = New Size(99, 19)
        Label44.TabIndex = 10
        Label44.Text = "Birthday :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Consolas", 12F)
        TextBox2.Location = New Point(496, 276)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(186, 26)
        TextBox2.TabIndex = 4
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.Font = New Font("Consolas", 12F)
        Label43.Location = New Point(429, 276)
        Label43.Name = "Label43"
        Label43.Size = New Size(54, 19)
        Label43.TabIndex = 8
        Label43.Text = "Sex :"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Consolas", 12F)
        TextBox4.Location = New Point(213, 273)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(197, 26)
        TextBox4.TabIndex = 3
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Consolas", 12F)
        Label42.Location = New Point(84, 276)
        Label42.Name = "Label42"
        Label42.Size = New Size(54, 19)
        Label42.TabIndex = 6
        Label42.Text = "Age :"
        ' 
        ' TextBox0
        ' 
        TextBox0.Font = New Font("Consolas", 12F)
        TextBox0.Location = New Point(213, 134)
        TextBox0.Name = "TextBox0"
        TextBox0.Size = New Size(470, 26)
        TextBox0.TabIndex = 0
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Consolas", 12F)
        Label40.Location = New Point(84, 136)
        Label40.Name = "Label40"
        Label40.Size = New Size(117, 19)
        Label40.TabIndex = 0
        Label40.Text = "First Name :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(419, 32)
        Label1.TabIndex = 0
        Label1.Text = "San Antonio Nom Pass Resort"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(690, 32)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' formAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Snow
        ClientSize = New Size(800, 598)
        Controls.Add(btnRefresh)
        Controls.Add(Label1)
        Controls.Add(tbcAdmin)
        FormBorderStyle = FormBorderStyle.FixedSingle
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
        pnlPayment.ResumeLayout(False)
        pnlPayment.PerformLayout()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPresidentialRoomNumbers As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtExecutiveAvailableRooms As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStandardRoomNumbers As TextBox
    Friend WithEvents txtStandardAvailableRooms As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
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
    Friend WithEvents dgvGuestTable As DataGridView
    Friend WithEvents btnRefresh As Button
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
    Friend WithEvents cbSingleRoomNumbers As ComboBox
    Friend WithEvents cbKingRoomNumbers As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents cbTwinRoomNumbers As ComboBox
    Friend WithEvents cbQueenRoomNumbers As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents cbStandardRoomNumbers As ComboBox
    Friend WithEvents cbPresidentialRoomNumbers As ComboBox
    Friend WithEvents cbExecutiveRoomNumbers As ComboBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txtTotBill As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents columnEdit As DataGridViewButtonColumn
    Friend WithEvents columnFirstName As DataGridViewTextBoxColumn
    Friend WithEvents columnLastnName As DataGridViewTextBoxColumn
    Friend WithEvents columnArrival As DataGridViewTextBoxColumn
    Friend WithEvents columnDeparture As DataGridViewTextBoxColumn
    Friend WithEvents columnTotalGuests As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlPayment As Panel
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents txtPaym As TextBox
    Friend WithEvents btnCanc As Button
    Friend WithEvents btnConfi As Button
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label61 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label70 As Label
End Class
