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
        lblRoom.Location = New Point(298, 4)
        lblRoom.Name = "lblRoom"
        lblRoom.Size = New Size(95, 29)
        lblRoom.TabIndex = 0
        lblRoom.Text = "Rooms"
        ' 
        ' lblSAR
        ' 
        lblSAR.AutoSize = True
        lblSAR.BackColor = SystemColors.ControlDark
        lblSAR.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSAR.Location = New Point(250, 31)
        lblSAR.Name = "lblSAR"
        lblSAR.Size = New Size(199, 18)
        lblSAR.TabIndex = 1
        lblSAR.Text = "San Antonio NOM Resort"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlDark
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(11, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 6
        Label2.Text = "Single Room"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlDark
        Label5.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 199)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 18)
        Label5.TabIndex = 10
        Label5.Text = "999/Night"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlDark
        Label6.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(11, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 16)
        Label6.TabIndex = 11
        Label6.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlDark
        Label8.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(11, 247)
        Label8.Name = "Label8"
        Label8.Size = New Size(122, 16)
        Label8.TabIndex = 13
        Label8.Text = "ROOM NUMBERS:"
        ' 
        ' btnSingleRoomBook
        ' 
        btnSingleRoomBook.FlatStyle = FlatStyle.Flat
        btnSingleRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSingleRoomBook.Location = New Point(11, 283)
        btnSingleRoomBook.Name = "btnSingleRoomBook"
        btnSingleRoomBook.Size = New Size(197, 29)
        btnSingleRoomBook.TabIndex = 4
        btnSingleRoomBook.Text = "Book Now"
        btnSingleRoomBook.UseVisualStyleBackColor = True
        ' 
        ' txtSingleAvailableRoom
        ' 
        txtSingleAvailableRoom.BorderStyle = BorderStyle.None
        txtSingleAvailableRoom.Enabled = False
        txtSingleAvailableRoom.Location = New Point(142, 219)
        txtSingleAvailableRoom.Name = "txtSingleAvailableRoom"
        txtSingleAvailableRoom.Size = New Size(67, 20)
        txtSingleAvailableRoom.TabIndex = 2
        txtSingleAvailableRoom.Text = "5"
        txtSingleAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtQueenAvailableRoom
        ' 
        txtQueenAvailableRoom.BorderStyle = BorderStyle.None
        txtQueenAvailableRoom.Enabled = False
        txtQueenAvailableRoom.Location = New Point(375, 219)
        txtQueenAvailableRoom.Name = "txtQueenAvailableRoom"
        txtQueenAvailableRoom.Size = New Size(67, 20)
        txtQueenAvailableRoom.TabIndex = 6
        txtQueenAvailableRoom.Text = "5"
        txtQueenAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnQueenRoomBook
        ' 
        btnQueenRoomBook.FlatStyle = FlatStyle.Flat
        btnQueenRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQueenRoomBook.Location = New Point(245, 283)
        btnQueenRoomBook.Name = "btnQueenRoomBook"
        btnQueenRoomBook.Size = New Size(197, 29)
        btnQueenRoomBook.TabIndex = 8
        btnQueenRoomBook.Text = "Book Now"
        btnQueenRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlDark
        Label1.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(245, 245)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 16)
        Label1.TabIndex = 22
        Label1.Text = "ROOM NUMBERS:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlDark
        Label3.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(245, 220)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 16)
        Label3.TabIndex = 21
        Label3.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlDark
        Label4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(245, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 18)
        Label4.TabIndex = 20
        Label4.Text = "1199/Night"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlDark
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(245, 180)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 20)
        Label7.TabIndex = 19
        Label7.Text = "Queen Room"
        ' 
        ' txtKingAvailableRoom
        ' 
        txtKingAvailableRoom.BorderStyle = BorderStyle.None
        txtKingAvailableRoom.Enabled = False
        txtKingAvailableRoom.Location = New Point(607, 219)
        txtKingAvailableRoom.Name = "txtKingAvailableRoom"
        txtKingAvailableRoom.Size = New Size(67, 20)
        txtKingAvailableRoom.TabIndex = 10
        txtKingAvailableRoom.Text = "5"
        txtKingAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnKingRoomBook
        ' 
        btnKingRoomBook.FlatStyle = FlatStyle.Flat
        btnKingRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKingRoomBook.Location = New Point(477, 283)
        btnKingRoomBook.Name = "btnKingRoomBook"
        btnKingRoomBook.Size = New Size(197, 29)
        btnKingRoomBook.TabIndex = 12
        btnKingRoomBook.Text = "Book Now"
        btnKingRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.ControlDark
        Label9.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(477, 245)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 16)
        Label9.TabIndex = 30
        Label9.Text = "ROOM NUMBERS:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlDark
        Label10.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(477, 220)
        Label10.Name = "Label10"
        Label10.Size = New Size(134, 16)
        Label10.TabIndex = 29
        Label10.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = SystemColors.ControlDark
        Label11.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(477, 199)
        Label11.Name = "Label11"
        Label11.Size = New Size(88, 18)
        Label11.TabIndex = 28
        Label11.Text = "1399/Night"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = SystemColors.ControlDark
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(477, 180)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 20)
        Label12.TabIndex = 27
        Label12.Text = "King Room"
        ' 
        ' txtExecutiveAvailableRoom
        ' 
        txtExecutiveAvailableRoom.BorderStyle = BorderStyle.None
        txtExecutiveAvailableRoom.Enabled = False
        txtExecutiveAvailableRoom.Location = New Point(607, 484)
        txtExecutiveAvailableRoom.Name = "txtExecutiveAvailableRoom"
        txtExecutiveAvailableRoom.Size = New Size(67, 20)
        txtExecutiveAvailableRoom.TabIndex = 22
        txtExecutiveAvailableRoom.Text = "5"
        txtExecutiveAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnExecRoomBook
        ' 
        btnExecRoomBook.FlatStyle = FlatStyle.Flat
        btnExecRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExecRoomBook.Location = New Point(477, 533)
        btnExecRoomBook.Name = "btnExecRoomBook"
        btnExecRoomBook.Size = New Size(197, 29)
        btnExecRoomBook.TabIndex = 24
        btnExecRoomBook.Text = "Book Now"
        btnExecRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(477, 512)
        Label13.Name = "Label13"
        Label13.Size = New Size(122, 16)
        Label13.TabIndex = 54
        Label13.Text = "ROOM NUMBERS:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(477, 485)
        Label14.Name = "Label14"
        Label14.Size = New Size(134, 16)
        Label14.TabIndex = 53
        Label14.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(477, 464)
        Label15.Name = "Label15"
        Label15.Size = New Size(88, 18)
        Label15.TabIndex = 52
        Label15.Text = "2299/Night"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(477, 445)
        Label16.Name = "Label16"
        Label16.Size = New Size(144, 20)
        Label16.TabIndex = 51
        Label16.Text = "Executive Room"
        ' 
        ' txtStandardAvailableRoom
        ' 
        txtStandardAvailableRoom.BorderStyle = BorderStyle.None
        txtStandardAvailableRoom.Enabled = False
        txtStandardAvailableRoom.Location = New Point(375, 484)
        txtStandardAvailableRoom.Name = "txtStandardAvailableRoom"
        txtStandardAvailableRoom.Size = New Size(67, 20)
        txtStandardAvailableRoom.TabIndex = 18
        txtStandardAvailableRoom.Text = "5"
        txtStandardAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnStandardRoomBook
        ' 
        btnStandardRoomBook.FlatStyle = FlatStyle.Flat
        btnStandardRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStandardRoomBook.Location = New Point(245, 533)
        btnStandardRoomBook.Name = "btnStandardRoomBook"
        btnStandardRoomBook.Size = New Size(197, 29)
        btnStandardRoomBook.TabIndex = 20
        btnStandardRoomBook.Text = "Book Now"
        btnStandardRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(245, 512)
        Label17.Name = "Label17"
        Label17.Size = New Size(122, 16)
        Label17.TabIndex = 46
        Label17.Text = "ROOM NUMBERS:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(245, 485)
        Label18.Name = "Label18"
        Label18.Size = New Size(134, 16)
        Label18.TabIndex = 45
        Label18.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(245, 464)
        Label19.Name = "Label19"
        Label19.Size = New Size(88, 18)
        Label19.TabIndex = 44
        Label19.Text = "1999/Night"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(245, 445)
        Label20.Name = "Label20"
        Label20.Size = New Size(138, 20)
        Label20.TabIndex = 43
        Label20.Text = "Standard Room"
        ' 
        ' txtTwinAvailableRoom
        ' 
        txtTwinAvailableRoom.BorderStyle = BorderStyle.None
        txtTwinAvailableRoom.Enabled = False
        txtTwinAvailableRoom.Location = New Point(142, 484)
        txtTwinAvailableRoom.Name = "txtTwinAvailableRoom"
        txtTwinAvailableRoom.Size = New Size(67, 20)
        txtTwinAvailableRoom.TabIndex = 14
        txtTwinAvailableRoom.Text = "5"
        txtTwinAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTwinRoomBook
        ' 
        btnTwinRoomBook.FlatStyle = FlatStyle.Flat
        btnTwinRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTwinRoomBook.Location = New Point(11, 533)
        btnTwinRoomBook.Name = "btnTwinRoomBook"
        btnTwinRoomBook.Size = New Size(197, 29)
        btnTwinRoomBook.TabIndex = 16
        btnTwinRoomBook.Text = "Book Now"
        btnTwinRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(11, 512)
        Label21.Name = "Label21"
        Label21.Size = New Size(122, 16)
        Label21.TabIndex = 38
        Label21.Text = "ROOM NUMBERS:"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(11, 485)
        Label22.Name = "Label22"
        Label22.Size = New Size(134, 16)
        Label22.TabIndex = 37
        Label22.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(11, 464)
        Label23.Name = "Label23"
        Label23.Size = New Size(88, 18)
        Label23.TabIndex = 36
        Label23.Text = "1799/Night"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(11, 445)
        Label24.Name = "Label24"
        Label24.Size = New Size(102, 20)
        Label24.TabIndex = 35
        Label24.Text = "Twin Room"
        ' 
        ' txtPresidentialAvailableRoom
        ' 
        txtPresidentialAvailableRoom.BorderStyle = BorderStyle.None
        txtPresidentialAvailableRoom.Enabled = False
        txtPresidentialAvailableRoom.Location = New Point(375, 736)
        txtPresidentialAvailableRoom.Name = "txtPresidentialAvailableRoom"
        txtPresidentialAvailableRoom.Size = New Size(67, 20)
        txtPresidentialAvailableRoom.TabIndex = 26
        txtPresidentialAvailableRoom.Text = "5"
        txtPresidentialAvailableRoom.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPresRoomBook
        ' 
        btnPresRoomBook.FlatStyle = FlatStyle.Flat
        btnPresRoomBook.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPresRoomBook.Location = New Point(245, 785)
        btnPresRoomBook.Name = "btnPresRoomBook"
        btnPresRoomBook.Size = New Size(197, 29)
        btnPresRoomBook.TabIndex = 28
        btnPresRoomBook.Text = "Book Now"
        btnPresRoomBook.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(245, 763)
        Label25.Name = "Label25"
        Label25.Size = New Size(122, 16)
        Label25.TabIndex = 62
        Label25.Text = "ROOM NUMBERS:"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(245, 737)
        Label26.Name = "Label26"
        Label26.Size = New Size(134, 16)
        Label26.TabIndex = 61
        Label26.Text = "AVAILABLE ROOMS:"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(245, 716)
        Label27.Name = "Label27"
        Label27.Size = New Size(88, 18)
        Label27.TabIndex = 60
        Label27.Text = "2699/Night"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(245, 697)
        Label28.Name = "Label28"
        Label28.Size = New Size(163, 20)
        Label28.TabIndex = 59
        Label28.Text = "Presidential Room"
        ' 
        ' btnSingleRoomInfo
        ' 
        btnSingleRoomInfo.FlatStyle = FlatStyle.Flat
        btnSingleRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSingleRoomInfo.Image = My.Resources.Resources.formRoomsBG
        btnSingleRoomInfo.Location = New Point(11, 56)
        btnSingleRoomInfo.Name = "btnSingleRoomInfo"
        btnSingleRoomInfo.Size = New Size(197, 123)
        btnSingleRoomInfo.TabIndex = 5
        btnSingleRoomInfo.Text = "Click for More Info"
        btnSingleRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnQueenRoomInfo
        ' 
        btnQueenRoomInfo.FlatStyle = FlatStyle.Flat
        btnQueenRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQueenRoomInfo.Location = New Point(245, 56)
        btnQueenRoomInfo.Name = "btnQueenRoomInfo"
        btnQueenRoomInfo.Size = New Size(197, 123)
        btnQueenRoomInfo.TabIndex = 9
        btnQueenRoomInfo.Text = "Click for More Info"
        btnQueenRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnKingRoomInfo
        ' 
        btnKingRoomInfo.FlatStyle = FlatStyle.Flat
        btnKingRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKingRoomInfo.Location = New Point(477, 56)
        btnKingRoomInfo.Name = "btnKingRoomInfo"
        btnKingRoomInfo.Size = New Size(197, 123)
        btnKingRoomInfo.TabIndex = 13
        btnKingRoomInfo.Text = "Click for More Info"
        btnKingRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnTwinRoomInfo
        ' 
        btnTwinRoomInfo.FlatStyle = FlatStyle.Flat
        btnTwinRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTwinRoomInfo.Location = New Point(11, 321)
        btnTwinRoomInfo.Name = "btnTwinRoomInfo"
        btnTwinRoomInfo.Size = New Size(197, 123)
        btnTwinRoomInfo.TabIndex = 17
        btnTwinRoomInfo.Text = "Click for More Info"
        btnTwinRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnStandardRoomInfo
        ' 
        btnStandardRoomInfo.FlatStyle = FlatStyle.Flat
        btnStandardRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStandardRoomInfo.Location = New Point(245, 321)
        btnStandardRoomInfo.Name = "btnStandardRoomInfo"
        btnStandardRoomInfo.Size = New Size(197, 123)
        btnStandardRoomInfo.TabIndex = 21
        btnStandardRoomInfo.Text = "Click for More Info"
        btnStandardRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnExecutiveRoomInfo
        ' 
        btnExecutiveRoomInfo.FlatStyle = FlatStyle.Flat
        btnExecutiveRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExecutiveRoomInfo.Location = New Point(477, 321)
        btnExecutiveRoomInfo.Name = "btnExecutiveRoomInfo"
        btnExecutiveRoomInfo.Size = New Size(197, 123)
        btnExecutiveRoomInfo.TabIndex = 25
        btnExecutiveRoomInfo.Text = "Click for More Info"
        btnExecutiveRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' btnPresidentialRoomInfo
        ' 
        btnPresidentialRoomInfo.FlatStyle = FlatStyle.Flat
        btnPresidentialRoomInfo.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPresidentialRoomInfo.Location = New Point(245, 572)
        btnPresidentialRoomInfo.Name = "btnPresidentialRoomInfo"
        btnPresidentialRoomInfo.Size = New Size(197, 123)
        btnPresidentialRoomInfo.TabIndex = 29
        btnPresidentialRoomInfo.Text = "Click for More Info"
        btnPresidentialRoomInfo.UseVisualStyleBackColor = True
        ' 
        ' cbSingleRoomNumber
        ' 
        cbSingleRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbSingleRoomNumber.FormattingEnabled = True
        cbSingleRoomNumber.Items.AddRange(New Object() {"asdf", "sad", "fsa", "fsad", "fsdaf", "sda"})
        cbSingleRoomNumber.Location = New Point(142, 245)
        cbSingleRoomNumber.Margin = New Padding(3, 4, 3, 4)
        cbSingleRoomNumber.Name = "cbSingleRoomNumber"
        cbSingleRoomNumber.Size = New Size(67, 28)
        cbSingleRoomNumber.TabIndex = 3
        ' 
        ' cbQueenRoomNumber
        ' 
        cbQueenRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbQueenRoomNumber.FormattingEnabled = True
        cbQueenRoomNumber.Location = New Point(375, 245)
        cbQueenRoomNumber.Margin = New Padding(3, 4, 3, 4)
        cbQueenRoomNumber.Name = "cbQueenRoomNumber"
        cbQueenRoomNumber.Size = New Size(67, 28)
        cbQueenRoomNumber.TabIndex = 7
        ' 
        ' cbKingRoomNumber
        ' 
        cbKingRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbKingRoomNumber.FormattingEnabled = True
        cbKingRoomNumber.Location = New Point(607, 247)
        cbKingRoomNumber.Margin = New Padding(3, 4, 3, 4)
        cbKingRoomNumber.Name = "cbKingRoomNumber"
        cbKingRoomNumber.Size = New Size(67, 28)
        cbKingRoomNumber.TabIndex = 11
        ' 
        ' cbTwinRoomNumber
        ' 
        cbTwinRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbTwinRoomNumber.FormattingEnabled = True
        cbTwinRoomNumber.Location = New Point(136, 503)
        cbTwinRoomNumber.Margin = New Padding(3, 4, 3, 4)
        cbTwinRoomNumber.Name = "cbTwinRoomNumber"
        cbTwinRoomNumber.Size = New Size(67, 28)
        cbTwinRoomNumber.TabIndex = 15
        ' 
        ' cbStandardRoomNumber
        ' 
        cbStandardRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbStandardRoomNumber.FormattingEnabled = True
        cbStandardRoomNumber.Location = New Point(375, 507)
        cbStandardRoomNumber.Margin = New Padding(3, 4, 3, 4)
        cbStandardRoomNumber.Name = "cbStandardRoomNumber"
        cbStandardRoomNumber.Size = New Size(67, 28)
        cbStandardRoomNumber.TabIndex = 19
        ' 
        ' cbExecutiveRoomNumber
        ' 
        cbExecutiveRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbExecutiveRoomNumber.FormattingEnabled = True
        cbExecutiveRoomNumber.Location = New Point(603, 503)
        cbExecutiveRoomNumber.Margin = New Padding(3, 4, 3, 4)
        cbExecutiveRoomNumber.Name = "cbExecutiveRoomNumber"
        cbExecutiveRoomNumber.Size = New Size(67, 28)
        cbExecutiveRoomNumber.TabIndex = 23
        ' 
        ' cbPresidentialRoomNumber
        ' 
        cbPresidentialRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList
        cbPresidentialRoomNumber.FormattingEnabled = True
        cbPresidentialRoomNumber.Location = New Point(375, 757)
        cbPresidentialRoomNumber.Margin = New Padding(3, 4, 3, 4)
        cbPresidentialRoomNumber.Name = "cbPresidentialRoomNumber"
        cbPresidentialRoomNumber.Size = New Size(67, 28)
        cbPresidentialRoomNumber.TabIndex = 27
        ' 
        ' formRooms
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.formBookingBG1
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(701, 940)
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
