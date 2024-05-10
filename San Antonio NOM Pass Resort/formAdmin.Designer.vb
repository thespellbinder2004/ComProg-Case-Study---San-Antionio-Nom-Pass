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
        btnSingle = New Button()
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
        tabRooms.Controls.Add(btnSingle)
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
        ' btnSingle
        ' 
        btnSingle.Font = New Font("Bahnschrift SemiCondensed", 9F)
        btnSingle.Location = New Point(10, 120)
        btnSingle.Name = "btnSingle"
        btnSingle.Size = New Size(247, 29)
        btnSingle.TabIndex = 65
        btnSingle.Text = "ROOM DETAILS"
        btnSingle.UseVisualStyleBackColor = True
        ' 
        ' txtSingleRoomNumbers
        ' 
        txtSingleRoomNumbers.Location = New Point(132, 87)
        txtSingleRoomNumbers.Name = "txtSingleRoomNumbers"
        txtSingleRoomNumbers.Size = New Size(125, 27)
        txtSingleRoomNumbers.TabIndex = 64
        ' 
        ' lblPresidentialRoom
        ' 
        lblPresidentialRoom.AutoSize = True
        lblPresidentialRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblPresidentialRoom.Location = New Point(425, 423)
        lblPresidentialRoom.Name = "lblPresidentialRoom"
        lblPresidentialRoom.Size = New Size(150, 24)
        lblPresidentialRoom.TabIndex = 60
        lblPresidentialRoom.Text = "Presidential Room"
        ' 
        ' txtSingleAvailableRooms
        ' 
        txtSingleAvailableRooms.Location = New Point(132, 48)
        txtSingleAvailableRooms.Name = "txtSingleAvailableRooms"
        txtSingleAvailableRooms.Size = New Size(125, 27)
        txtSingleAvailableRooms.TabIndex = 63
        ' 
        ' lblRoomNumbers1
        ' 
        lblRoomNumbers1.AutoSize = True
        lblRoomNumbers1.BackColor = Color.Transparent
        lblRoomNumbers1.Font = New Font("Bahnschrift SemiCondensed", 9F)
        lblRoomNumbers1.Location = New Point(10, 91)
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
        lblAvailableRooms1.Location = New Point(10, 51)
        lblAvailableRooms1.Name = "lblAvailableRooms1"
        lblAvailableRooms1.Size = New Size(118, 18)
        lblAvailableRooms1.TabIndex = 61
        lblAvailableRooms1.Text = "AVAILABLE ROOMS:"
        ' 
        ' lblExucutiveRoom
        ' 
        lblExucutiveRoom.AutoSize = True
        lblExucutiveRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblExucutiveRoom.Location = New Point(659, 257)
        lblExucutiveRoom.Name = "lblExucutiveRoom"
        lblExucutiveRoom.Size = New Size(134, 24)
        lblExucutiveRoom.TabIndex = 52
        lblExucutiveRoom.Text = "Executive Room"
        ' 
        ' lblStandardRoom
        ' 
        lblStandardRoom.AutoSize = True
        lblStandardRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblStandardRoom.Location = New Point(376, 257)
        lblStandardRoom.Name = "lblStandardRoom"
        lblStandardRoom.Size = New Size(128, 24)
        lblStandardRoom.TabIndex = 44
        lblStandardRoom.Text = "Standard Room"
        ' 
        ' lblTwinRoom
        ' 
        lblTwinRoom.AutoSize = True
        lblTwinRoom.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold)
        lblTwinRoom.Location = New Point(3, 257)
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
        lblKingRoom.Location = New Point(659, 4)
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
        lblQueenRoom.Location = New Point(376, 4)
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
    Friend WithEvents btnSingle As Button
End Class
