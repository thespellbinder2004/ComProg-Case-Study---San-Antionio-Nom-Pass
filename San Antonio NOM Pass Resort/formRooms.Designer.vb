<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formRooms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        lblRoom = New Label()
        lblSAR = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        btnSingleRoomBook = New Button()
        txtSingleAvailableRoom = New TextBox()
        txtQueenAvailableRoom = New TextBox()
        btnQueenRoomBook = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        txtKingAvailableRoom = New TextBox()
        btnKingRoomBook = New Button()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        txtExecutiveAvailableRoom = New TextBox()
        btnExecRoomBook = New Button()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        txtStandardAvailableRoom = New TextBox()
        btnStandardRoomBook = New Button()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        txtTwinAvailableRoom = New TextBox()
        btnTwinRoomBook = New Button()
        Label21 = New Label()
        Label22 = New Label()
        Label23 = New Label()
        Label24 = New Label()
        txtPresidentialAvailableRoom = New TextBox()
        btnPresRoomBook = New Button()
        Label25 = New Label()
        Label26 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        btnSingleRoomInfo = New Button()
        btnQueenRoomInfo = New Button()
        btnKingRoomInfo = New Button()
        btnTwinRoomInfo = New Button()
        btnStandardRoomInfo = New Button()
        btnExecutiveRoomInfo = New Button()
        btnPresidentialRoomInfo = New Button()
        cbSingleRoomNumber = New ComboBox()
        cbQueenRoomNumber = New ComboBox()
        cbKingRoomNumber = New ComboBox()
        cbTwinRoomNumber = New ComboBox()
        cbStandardRoomNumber = New ComboBox()
        cbExecutiveRoomNumber = New ComboBox()
        cbPresidentialRoomNumber = New ComboBox()
        SuspendLayout()
        ' 
        ' lblRoom
        ' 
        lblRoom.AutoSize = True
        lblRoom.BackColor = SystemColors.ControlDark
        lblRoom.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRoom.Location = New Point(261, 3)
        lblRoom.Name = "lblRoom"
        lblRoom.Size = New Size(75, 24)
        lblRoom.TabIndex = 0
        lblRoom.Text = "Rooms"
        ' 
        ' lblSAR
        ' 
        lblSAR.AutoSize = True
        lblSAR.BackColor = SystemColors.ControlDark
        lblSAR.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSAR.Location = New Point(219, 23)
        lblSAR.Name = "lblSAR"
        lblSAR.Size = New Size(166, 15)
        lblSAR.TabIndex = 1
        lblSAR.Text = "San Antonio NOM Resort"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlDark
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 17)
        Label2.TabIndex = 6
        Label2.Text = "Single Room"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlDark
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(10, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 10
        Label5.Text = "999/Night"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlDark
        Label6.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(10, 165)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 13)
        Label6.TabIndex = 11
        Label6.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlDark
        Label8.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(10, 185)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 13)
        Label8.TabIndex = 13
        Label8.Text = "ROOM NUMBERS:"
        ' 
        ' btnSingleRoomBook
        ' 
        btnSingleRoomBook.FlatStyle = FlatStyle.Flat
        btnSingleRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSingleRoomBook.Location = New Point(10, 212)
        btnSingleRoomBook.Margin = New Padding(3, 2, 3, 2)
        btnSingleRoomBook.Name = "btnSingleRoomBook"
        btnSingleRoomBook.Size = New Size(172, 22)
        btnSingleRoomBook.TabIndex = 15
        btnSingleRoomBook.Text = "Book Now"
        btnSingleRoomBook.UseVisualStyleBackColor = True
        ' 
        ' txtSingleAvailableRoom
        ' 
        txtSingleAvailableRoom.BorderStyle = BorderStyle.None
        txtSingleAvailableRoom.Enabled = False
        txtSingleAvailableRoom.Location = New Point(124, 164)
        txtSingleAvailableRoom.Margin = New Padding(3, 2, 3, 2)
        txtSingleAvailableRoom.Name = "txtSingleAvailableRoom"
        txtSingleAvailableRoom.Size = New Size(59, 16)
        txtSingleAvailableRoom.TabIndex = 16
        txtSingleAvailableRoom.Text = "5"
        txtSingleAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtQueenAvailableRoom
        ' 
        txtQueenAvailableRoom.BorderStyle = BorderStyle.None
        txtQueenAvailableRoom.Location = New Point(328, 164)
        txtQueenAvailableRoom.Margin = New Padding(3, 2, 3, 2)
        txtQueenAvailableRoom.Name = "txtQueenAvailableRoom"
        txtQueenAvailableRoom.Size = New Size(59, 16)
        txtQueenAvailableRoom.TabIndex = 24
        txtQueenAvailableRoom.Text = "5"
        txtQueenAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnQueenRoomBook
        ' 
        btnQueenRoomBook.FlatStyle = FlatStyle.Flat
        btnQueenRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQueenRoomBook.Location = New Point(214, 212)
        btnQueenRoomBook.Margin = New Padding(3, 2, 3, 2)
        btnQueenRoomBook.Name = "btnQueenRoomBook"
        btnQueenRoomBook.Size = New Size(172, 22)
        btnQueenRoomBook.TabIndex = 23
        btnQueenRoomBook.Text = "Book Now"
        btnQueenRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(214, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 13)
        Label1.TabIndex = 22
        Label1.Text = "ROOM NUMBERS:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlDark
        Label3.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(214, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 13)
        Label3.TabIndex = 21
        Label3.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlDark
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(214, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 15)
        Label4.TabIndex = 20
        Label4.Text = "1199/Night"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlDark
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(214, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 17)
        Label7.TabIndex = 19
        Label7.Text = "Queen Room"
        ' 
        ' txtKingAvailableRoom
        ' 
        txtKingAvailableRoom.BorderStyle = BorderStyle.None
        txtKingAvailableRoom.Enabled = False
        txtKingAvailableRoom.Location = New Point(531, 164)
        txtKingAvailableRoom.Margin = New Padding(3, 2, 3, 2)
        txtKingAvailableRoom.Name = "txtKingAvailableRoom"
        txtKingAvailableRoom.Size = New Size(59, 16)
        txtKingAvailableRoom.TabIndex = 32
        txtKingAvailableRoom.Text = "5"
        txtKingAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnKingRoomBook
        ' 
        btnKingRoomBook.FlatStyle = FlatStyle.Flat
        btnKingRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKingRoomBook.Location = New Point(417, 212)
        btnKingRoomBook.Margin = New Padding(3, 2, 3, 2)
        btnKingRoomBook.Name = "btnKingRoomBook"
        btnKingRoomBook.Size = New Size(172, 22)
        btnKingRoomBook.TabIndex = 31
        btnKingRoomBook.Text = "Book Now"
        btnKingRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlDark
        Label9.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(417, 184)
        Label9.Name = "Label9"
        Label9.Size = New Size(100, 13)
        Label9.TabIndex = 30
        Label9.Text = "ROOM NUMBERS:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlDark
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(417, 165)
        Label10.Name = "Label10"
        Label10.Size = New Size(110, 13)
        Label10.TabIndex = 29
        Label10.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ControlDark
        Label11.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(417, 149)
        Label11.Name = "Label11"
        Label11.Size = New Size(77, 15)
        Label11.TabIndex = 28
        Label11.Text = "1399/Night"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.ControlDark
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(417, 135)
        Label12.Name = "Label12"
        Label12.Size = New Size(86, 17)
        Label12.TabIndex = 27
        Label12.Text = "King Room"
        ' 
        ' txtExecutiveAvailableRoom
        ' 
        txtExecutiveAvailableRoom.BorderStyle = BorderStyle.None
        txtExecutiveAvailableRoom.Enabled = False
        txtExecutiveAvailableRoom.Location = New Point(531, 363)
        txtExecutiveAvailableRoom.Margin = New Padding(3, 2, 3, 2)
        txtExecutiveAvailableRoom.Name = "txtExecutiveAvailableRoom"
        txtExecutiveAvailableRoom.Size = New Size(59, 16)
        txtExecutiveAvailableRoom.TabIndex = 56
        txtExecutiveAvailableRoom.Text = "5"
        txtExecutiveAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnExecRoomBook
        ' 
        btnExecRoomBook.FlatStyle = FlatStyle.Flat
        btnExecRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExecRoomBook.Location = New Point(417, 400)
        btnExecRoomBook.Margin = New Padding(3, 2, 3, 2)
        btnExecRoomBook.Name = "btnExecRoomBook"
        btnExecRoomBook.Size = New Size(172, 22)
        btnExecRoomBook.TabIndex = 55
        btnExecRoomBook.Text = "Book Now"
        btnExecRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(417, 384)
        Label13.Name = "Label13"
        Label13.Size = New Size(100, 13)
        Label13.TabIndex = 54
        Label13.Text = "ROOM NUMBERS:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(417, 364)
        Label14.Name = "Label14"
        Label14.Size = New Size(110, 13)
        Label14.TabIndex = 53
        Label14.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(417, 348)
        Label15.Name = "Label15"
        Label15.Size = New Size(77, 15)
        Label15.TabIndex = 52
        Label15.Text = "2299/Night"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(417, 334)
        Label16.Name = "Label16"
        Label16.Size = New Size(123, 17)
        Label16.TabIndex = 51
        Label16.Text = "Executive Room"
        ' 
        ' txtStandardAvailableRoom
        ' 
        txtStandardAvailableRoom.BorderStyle = BorderStyle.None
        txtStandardAvailableRoom.Enabled = False
        txtStandardAvailableRoom.Location = New Point(328, 363)
        txtStandardAvailableRoom.Margin = New Padding(3, 2, 3, 2)
        txtStandardAvailableRoom.Name = "txtStandardAvailableRoom"
        txtStandardAvailableRoom.Size = New Size(59, 16)
        txtStandardAvailableRoom.TabIndex = 48
        txtStandardAvailableRoom.Text = "5"
        txtStandardAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnStandardRoomBook
        ' 
        btnStandardRoomBook.FlatStyle = FlatStyle.Flat
        btnStandardRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStandardRoomBook.Location = New Point(214, 400)
        btnStandardRoomBook.Margin = New Padding(3, 2, 3, 2)
        btnStandardRoomBook.Name = "btnStandardRoomBook"
        btnStandardRoomBook.Size = New Size(172, 22)
        btnStandardRoomBook.TabIndex = 47
        btnStandardRoomBook.Text = "Book Now"
        btnStandardRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(214, 384)
        Label17.Name = "Label17"
        Label17.Size = New Size(100, 13)
        Label17.TabIndex = 46
        Label17.Text = "ROOM NUMBERS:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(214, 364)
        Label18.Name = "Label18"
        Label18.Size = New Size(110, 13)
        Label18.TabIndex = 45
        Label18.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(214, 348)
        Label19.Name = "Label19"
        Label19.Size = New Size(77, 15)
        Label19.TabIndex = 44
        Label19.Text = "1999/Night"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(214, 334)
        Label20.Name = "Label20"
        Label20.Size = New Size(120, 17)
        Label20.TabIndex = 43
        Label20.Text = "Standard Room"
        ' 
        ' txtTwinAvailableRoom
        ' 
        txtTwinAvailableRoom.BorderStyle = BorderStyle.None
        txtTwinAvailableRoom.Enabled = False
        txtTwinAvailableRoom.Location = New Point(124, 363)
        txtTwinAvailableRoom.Margin = New Padding(3, 2, 3, 2)
        txtTwinAvailableRoom.Name = "txtTwinAvailableRoom"
        txtTwinAvailableRoom.Size = New Size(59, 16)
        txtTwinAvailableRoom.TabIndex = 40
        txtTwinAvailableRoom.Text = "5"
        txtTwinAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTwinRoomBook
        ' 
        btnTwinRoomBook.FlatStyle = FlatStyle.Flat
        btnTwinRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTwinRoomBook.Location = New Point(10, 400)
        btnTwinRoomBook.Margin = New Padding(3, 2, 3, 2)
        btnTwinRoomBook.Name = "btnTwinRoomBook"
        btnTwinRoomBook.Size = New Size(172, 22)
        btnTwinRoomBook.TabIndex = 39
        btnTwinRoomBook.Text = "Book Now"
        btnTwinRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(10, 384)
        Label21.Name = "Label21"
        Label21.Size = New Size(100, 13)
        Label21.TabIndex = 38
        Label21.Text = "ROOM NUMBERS:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(10, 364)
        Label22.Name = "Label22"
        Label22.Size = New Size(110, 13)
        Label22.TabIndex = 37
        Label22.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(10, 348)
        Label23.Name = "Label23"
        Label23.Size = New Size(77, 15)
        Label23.TabIndex = 36
        Label23.Text = "1799/Night"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(10, 334)
        Label24.Name = "Label24"
        Label24.Size = New Size(87, 17)
        Label24.TabIndex = 35
        Label24.Text = "Twin Room"
        ' 
        ' txtPresidentialAvailableRoom
        ' 
        txtPresidentialAvailableRoom.BorderStyle = BorderStyle.None
        txtPresidentialAvailableRoom.Enabled = False
        txtPresidentialAvailableRoom.Location = New Point(328, 552)
        txtPresidentialAvailableRoom.Margin = New Padding(3, 2, 3, 2)
        txtPresidentialAvailableRoom.Name = "txtPresidentialAvailableRoom"
        txtPresidentialAvailableRoom.Size = New Size(59, 16)
        txtPresidentialAvailableRoom.TabIndex = 64
        txtPresidentialAvailableRoom.Text = "5"
        txtPresidentialAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPresRoomBook
        ' 
        btnPresRoomBook.FlatStyle = FlatStyle.Flat
        btnPresRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPresRoomBook.Location = New Point(214, 589)
        btnPresRoomBook.Margin = New Padding(3, 2, 3, 2)
        btnPresRoomBook.Name = "btnPresRoomBook"
        btnPresRoomBook.Size = New Size(172, 22)
        btnPresRoomBook.TabIndex = 63
        btnPresRoomBook.Text = "Book Now"
        btnPresRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(214, 572)
        Label25.Name = "Label25"
        Label25.Size = New Size(100, 13)
        Label25.TabIndex = 62
        Label25.Text = "ROOM NUMBERS:"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(214, 553)
        Label26.Name = "Label26"
        Label26.Size = New Size(110, 13)
        Label26.TabIndex = 61
        Label26.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(214, 537)
        Label27.Name = "Label27"
        Label27.Size = New Size(77, 15)
        Label27.TabIndex = 60
        Label27.Text = "2699/Night"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(214, 523)
        Label28.Name = "Label28"
        Label28.Size = New Size(140, 17)
        Label28.TabIndex = 59
        Label28.Text = "Presidential Room"
        ' 
        ' btnSingleRoomInfo
        ' 
        btnSingleRoomInfo.FlatStyle = FlatStyle.Flat
        btnSingleRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSingleRoomInfo.Image = My.Resources.Resources.formRoomsBG
        btnSingleRoomInfo.Location = New Point(10, 42)
        btnSingleRoomInfo.Margin = New Padding(3, 2, 3, 2)
        btnSingleRoomInfo.Name = "btnSingleRoomInfo"
        btnSingleRoomInfo.Size = New Size(172, 92)
        btnSingleRoomInfo.TabIndex = 66
        btnSingleRoomInfo.Text = "Click for More Info"
        btnSingleRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnQueenRoomInfo
        ' 
        btnQueenRoomInfo.FlatStyle = FlatStyle.Flat
        btnQueenRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQueenRoomInfo.Location = New Point(214, 42)
        btnQueenRoomInfo.Margin = New Padding(3, 2, 3, 2)
        btnQueenRoomInfo.Name = "btnQueenRoomInfo"
        btnQueenRoomInfo.Size = New Size(172, 92)
        btnQueenRoomInfo.TabIndex = 67
        btnQueenRoomInfo.Text = "Click for More Info"
        btnQueenRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnKingRoomInfo
        ' 
        btnKingRoomInfo.FlatStyle = FlatStyle.Flat
        btnKingRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKingRoomInfo.Location = New Point(417, 42)
        btnKingRoomInfo.Margin = New Padding(3, 2, 3, 2)
        btnKingRoomInfo.Name = "btnKingRoomInfo"
        btnKingRoomInfo.Size = New Size(172, 92)
        btnKingRoomInfo.TabIndex = 68
        btnKingRoomInfo.Text = "Click for More Info"
        btnKingRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnTwinRoomInfo
        ' 
        btnTwinRoomInfo.FlatStyle = FlatStyle.Flat
        btnTwinRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTwinRoomInfo.Location = New Point(10, 241)
        btnTwinRoomInfo.Margin = New Padding(3, 2, 3, 2)
        btnTwinRoomInfo.Name = "btnTwinRoomInfo"
        btnTwinRoomInfo.Size = New Size(172, 92)
        btnTwinRoomInfo.TabIndex = 69
        btnTwinRoomInfo.Text = "Click for More Info"
        btnTwinRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnStandardRoomInfo
        ' 
        btnStandardRoomInfo.FlatStyle = FlatStyle.Flat
        btnStandardRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStandardRoomInfo.Location = New Point(214, 241)
        btnStandardRoomInfo.Margin = New Padding(3, 2, 3, 2)
        btnStandardRoomInfo.Name = "btnStandardRoomInfo"
        btnStandardRoomInfo.Size = New Size(172, 92)
        btnStandardRoomInfo.TabIndex = 70
        btnStandardRoomInfo.Text = "Click for More Info"
        btnStandardRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnExecutiveRoomInfo
        ' 
        btnExecutiveRoomInfo.FlatStyle = FlatStyle.Flat
        btnExecutiveRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExecutiveRoomInfo.Location = New Point(417, 241)
        btnExecutiveRoomInfo.Margin = New Padding(3, 2, 3, 2)
        btnExecutiveRoomInfo.Name = "btnExecutiveRoomInfo"
        btnExecutiveRoomInfo.Size = New Size(172, 92)
        btnExecutiveRoomInfo.TabIndex = 71
        btnExecutiveRoomInfo.Text = "Click for More Info"
        btnExecutiveRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnPresidentialRoomInfo
        ' 
        btnPresidentialRoomInfo.FlatStyle = FlatStyle.Flat
        btnPresidentialRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPresidentialRoomInfo.Location = New Point(214, 429)
        btnPresidentialRoomInfo.Margin = New Padding(3, 2, 3, 2)
        btnPresidentialRoomInfo.Name = "btnPresidentialRoomInfo"
        btnPresidentialRoomInfo.Size = New Size(172, 92)
        btnPresidentialRoomInfo.TabIndex = 72
        btnPresidentialRoomInfo.Text = "Click for More Info"
        btnPresidentialRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' cbSingleRoomNumber
        ' 
        cbSingleRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbSingleRoomNumber.FormattingEnabled = True
        cbSingleRoomNumber.Items.AddRange(New Object() {"asdf", "sad", "fsa", "fsad", "fsdaf", "sda"})
        cbSingleRoomNumber.Location = New Point(124, 184)
        cbSingleRoomNumber.Name = "cbSingleRoomNumber"
        cbSingleRoomNumber.Size = New Size(59, 23)
        cbSingleRoomNumber.TabIndex = 73
        ' 
        ' cbQueenRoomNumber
        ' 
        cbQueenRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbQueenRoomNumber.FormattingEnabled = True
        cbQueenRoomNumber.Location = New Point(328, 184)
        cbQueenRoomNumber.Name = "cbQueenRoomNumber"
        cbQueenRoomNumber.Size = New Size(59, 23)
        cbQueenRoomNumber.TabIndex = 74
        ' 
        ' cbKingRoomNumber
        ' 
        cbKingRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbKingRoomNumber.FormattingEnabled = True
        cbKingRoomNumber.Location = New Point(531, 185)
        cbKingRoomNumber.Name = "cbKingRoomNumber"
        cbKingRoomNumber.Size = New Size(59, 23)
        cbKingRoomNumber.TabIndex = 75
        ' 
        ' cbTwinRoomNumber
        ' 
        cbTwinRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbTwinRoomNumber.FormattingEnabled = True
        cbTwinRoomNumber.Location = New Point(119, 377)
        cbTwinRoomNumber.Name = "cbTwinRoomNumber"
        cbTwinRoomNumber.Size = New Size(59, 23)
        cbTwinRoomNumber.TabIndex = 76
        ' 
        ' cbStandardRoomNumber
        ' 
        cbStandardRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbStandardRoomNumber.FormattingEnabled = True
        cbStandardRoomNumber.Location = New Point(328, 380)
        cbStandardRoomNumber.Name = "cbStandardRoomNumber"
        cbStandardRoomNumber.Size = New Size(59, 23)
        cbStandardRoomNumber.TabIndex = 77
        ' 
        ' cbExecutiveRoomNumber
        ' 
        cbExecutiveRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbExecutiveRoomNumber.FormattingEnabled = True
        cbExecutiveRoomNumber.Location = New Point(528, 377)
        cbExecutiveRoomNumber.Name = "cbExecutiveRoomNumber"
        cbExecutiveRoomNumber.Size = New Size(59, 23)
        cbExecutiveRoomNumber.TabIndex = 78
        ' 
        ' cbPresidentialRoomNumber
        ' 
        cbPresidentialRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbPresidentialRoomNumber.FormattingEnabled = True
        cbPresidentialRoomNumber.Location = New Point(328, 568)
        cbPresidentialRoomNumber.Name = "cbPresidentialRoomNumber"
        cbPresidentialRoomNumber.Size = New Size(59, 23)
        cbPresidentialRoomNumber.TabIndex = 79
        ' 
        ' formRooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.formBookingBG1
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(613, 705)
        Controls.Add(cbPresidentialRoomNumber)
        Controls.Add(cbExecutiveRoomNumber)
        Controls.Add(cbStandardRoomNumber)
        Controls.Add(cbTwinRoomNumber)
        Controls.Add(cbKingRoomNumber)
        Controls.Add(cbQueenRoomNumber)
        Controls.Add(cbSingleRoomNumber)
        Controls.Add(btnPresidentialRoomInfo)
        Controls.Add(btnExecutiveRoomInfo)
        Controls.Add(btnStandardRoomInfo)
        Controls.Add(btnTwinRoomInfo)
        Controls.Add(btnKingRoomInfo)
        Controls.Add(btnQueenRoomInfo)
        Controls.Add(btnSingleRoomInfo)
        Controls.Add(txtPresidentialAvailableRoom)
        Controls.Add(btnPresRoomBook)
        Controls.Add(Label25)
        Controls.Add(Label26)
        Controls.Add(Label27)
        Controls.Add(Label28)
        Controls.Add(txtExecutiveAvailableRoom)
        Controls.Add(btnExecRoomBook)
        Controls.Add(Label13)
        Controls.Add(Label14)
        Controls.Add(Label15)
        Controls.Add(Label16)
        Controls.Add(txtStandardAvailableRoom)
        Controls.Add(btnStandardRoomBook)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label19)
        Controls.Add(Label20)
        Controls.Add(txtTwinAvailableRoom)
        Controls.Add(btnTwinRoomBook)
        Controls.Add(Label21)
        Controls.Add(Label22)
        Controls.Add(Label23)
        Controls.Add(Label24)
        Controls.Add(txtKingAvailableRoom)
        Controls.Add(btnKingRoomBook)
        Controls.Add(Label9)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(txtQueenAvailableRoom)
        Controls.Add(btnQueenRoomBook)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label7)
        Controls.Add(txtSingleAvailableRoom)
        Controls.Add(btnSingleRoomBook)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(lblSAR)
        Controls.Add(lblRoom)
        Margin = New Padding(3, 2, 3, 2)
        Name = "formRooms"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRoom As Label
    Friend WithEvents lblSAR As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSingleRoomBook As Button
    Friend WithEvents txtSingleAvailableRoom As TextBox
    Friend WithEvents txtQueenAvailableRoom As TextBox
    Friend WithEvents btnQueenRoomBook As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKingAvailableRoom As TextBox
    Friend WithEvents btnKingRoomBook As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtExecutiveAvailableRoom As TextBox
    Friend WithEvents btnExecRoomBook As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtStandardAvailableRoom As TextBox
    Friend WithEvents btnStandardRoomBook As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTwinAvailableRoom As TextBox
    Friend WithEvents btnTwinRoomBook As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtPresidentialAvailableRoom As TextBox
    Friend WithEvents btnPresRoomBook As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnSingleRoomInfo As Button
    Friend WithEvents btnQueenRoomInfo As Button
    Friend WithEvents btnKingRoomInfo As Button
    Friend WithEvents btnTwinRoomInfo As Button
    Friend WithEvents btnStandardRoomInfo As Button
    Friend WithEvents btnExecutiveRoomInfo As Button
    Friend WithEvents btnPresidentialRoomInfo As Button
    Friend WithEvents cbSingleRoomNumber As ComboBox
    Friend WithEvents cbQueenRoomNumber As ComboBox
    Friend WithEvents cbKingRoomNumber As ComboBox
    Friend WithEvents cbTwinRoomNumber As ComboBox
    Friend WithEvents cbStandardRoomNumber As ComboBox
    Friend WithEvents cbExecutiveRoomNumber As ComboBox
    Friend WithEvents cbPresidentialRoomNumber As ComboBox

End Class
