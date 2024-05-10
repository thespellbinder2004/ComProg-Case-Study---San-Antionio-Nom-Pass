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
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        GroupBox1 = New GroupBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        tabRooms = New TabPage()
        tabGuests = New TabPage()
        tabGuestInfo = New TabPage()
        Label1 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        txtCurrentAdmin = New TextBox()
        txtAdminRole = New TextBox()
        txtAdminContact1 = New TextBox()
        txtAdminContact2 = New TextBox()
        tbcAdmin.SuspendLayout()
        tabAdminInfo.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        tabAdminInfo.Controls.Add(Label19)
        tabAdminInfo.Controls.Add(Label18)
        tabAdminInfo.Controls.Add(Label17)
        tabAdminInfo.Controls.Add(Label16)
        tabAdminInfo.Controls.Add(Label15)
        tabAdminInfo.Controls.Add(Label14)
        tabAdminInfo.Controls.Add(Label13)
        tabAdminInfo.Controls.Add(Label12)
        tabAdminInfo.Controls.Add(Label11)
        tabAdminInfo.Controls.Add(GroupBox1)
        tabAdminInfo.Controls.Add(Label6)
        tabAdminInfo.Controls.Add(Label5)
        tabAdminInfo.Controls.Add(Label4)
        tabAdminInfo.Controls.Add(Label3)
        tabAdminInfo.Controls.Add(Label2)
        tabAdminInfo.Location = New Point(4, 24)
        tabAdminInfo.Name = "tabAdminInfo"
        tabAdminInfo.Padding = New Padding(3)
        tabAdminInfo.Size = New Size(793, 502)
        tabAdminInfo.TabIndex = 0
        tabAdminInfo.Text = "Admin Info"
        tabAdminInfo.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(68, 462)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 19)
        Label14.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(68, 427)
        Label13.Name = "Label13"
        Label13.Size = New Size(90, 19)
        Label13.TabIndex = 8
        Label13.Text = "Contacts:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(68, 399)
        Label12.Name = "Label12"
        Label12.Size = New Size(135, 19)
        Label12.TabIndex = 7
        Label12.Text = "Role/Position:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(13, 340)
        Label11.Name = "Label11"
        Label11.Size = New Size(162, 19)
        Label11.TabIndex = 6
        Label11.Text = "Admin Information"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Font = New Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(83, 176)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(620, 150)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Resort Details"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(30, 113)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 19)
        Label10.TabIndex = 9
        Label10.Text = "Raitings:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(30, 84)
        Label9.Name = "Label9"
        Label9.Size = New Size(90, 19)
        Label9.TabIndex = 8
        Label9.Text = "Services:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(30, 56)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 19)
        Label8.TabIndex = 7
        Label8.Text = "Room Types:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(30, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 19)
        Label7.TabIndex = 6
        Label7.Text = "Number of Rooms:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(68, 370)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 19)
        Label6.TabIndex = 4
        Label6.Text = "Current Admin:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(68, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 19)
        Label5.TabIndex = 3
        Label5.Text = "Contacts:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(68, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 19)
        Label4.TabIndex = 2
        Label4.Text = "Location:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(68, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 19)
        Label3.TabIndex = 1
        Label3.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 19)
        Label2.TabIndex = 0
        Label2.Text = "Resort Information"
        ' 
        ' tabRooms
        ' 
        tabRooms.Location = New Point(4, 24)
        tabRooms.Name = "tabRooms"
        tabRooms.Padding = New Padding(3)
        tabRooms.Size = New Size(793, 502)
        tabRooms.TabIndex = 1
        tabRooms.Text = "Rooms"
        tabRooms.UseVisualStyleBackColor = True
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
        Label1.Size = New Size(434, 32)
        Label1.TabIndex = 1
        Label1.Text = "San Antonion Nom Pass Resort"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(181, 49)
        Label15.Name = "Label15"
        Label15.Size = New Size(261, 19)
        Label15.TabIndex = 15
        Label15.Text = "San Antonion Nom Pass Resort"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(181, 76)
        Label16.Name = "Label16"
        Label16.Size = New Size(234, 19)
        Label16.TabIndex = 16
        Label16.Text = "Kaliwa, Doon, Tarlac City"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(181, 104)
        Label17.Name = "Label17"
        Label17.Size = New Size(216, 19)
        Label17.TabIndex = 17
        Label17.Text = "sanantonio143@gmail.com"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(181, 125)
        Label18.Name = "Label18"
        Label18.Size = New Size(108, 19)
        Label18.TabIndex = 18
        Label18.Text = "09123456789"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(181, 145)
        Label19.Name = "Label19"
        Label19.Size = New Size(324, 19)
        Label19.TabIndex = 19
        Label19.Text = "https://SanAntonioNomPassResort.com"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(234, 113)
        Label20.Name = "Label20"
        Label20.Size = New Size(80, 24)
        Label20.TabIndex = 10
        Label20.Text = "⭐⭐⭐⭐⭐"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(234, 27)
        Label21.Name = "Label21"
        Label21.Size = New Size(36, 19)
        Label21.TabIndex = 11
        Label21.Text = "71 "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Single Room", "", "Queen Room", "", "King Room", "", "Twin Room", "", "Standard Room", "", "Executive Suite", "", "Presidential Suite"})
        ComboBox1.Location = New Point(234, 52)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 12
        ComboBox1.Text = "Room Types"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Internet Access", "Swimming Pools", "On-site Restaurant and Bars", "Kids' Club", "Laundry & Dry Cleaning", "Water Sports", "Event Space", "Catering ", ""})
        ComboBox2.Location = New Point(234, 80)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 13
        ComboBox2.Text = "Services"
        ' 
        ' txtCurrentAdmin
        ' 
        txtCurrentAdmin.Location = New Point(242, 366)
        txtCurrentAdmin.Multiline = True
        txtCurrentAdmin.Name = "txtCurrentAdmin"
        txtCurrentAdmin.Size = New Size(263, 23)
        txtCurrentAdmin.TabIndex = 20
        ' 
        ' txtAdminRole
        ' 
        txtAdminRole.Location = New Point(242, 395)
        txtAdminRole.Multiline = True
        txtAdminRole.Name = "txtAdminRole"
        txtAdminRole.Size = New Size(263, 23)
        txtAdminRole.TabIndex = 21
        ' 
        ' txtAdminContact1
        ' 
        txtAdminContact1.Location = New Point(242, 423)
        txtAdminContact1.Multiline = True
        txtAdminContact1.Name = "txtAdminContact1"
        txtAdminContact1.Size = New Size(263, 23)
        txtAdminContact1.TabIndex = 22
        ' 
        ' txtAdminContact2
        ' 
        txtAdminContact2.Location = New Point(242, 452)
        txtAdminContact2.Multiline = True
        txtAdminContact2.Name = "txtAdminContact2"
        txtAdminContact2.Size = New Size(263, 23)
        txtAdminContact2.TabIndex = 23
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbcAdmin As TabControl
    Friend WithEvents tabAdminInfo As TabPage
    Friend WithEvents tabRooms As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents tabGuests As TabPage
    Friend WithEvents tabGuestInfo As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txtAdminContact2 As TextBox
    Friend WithEvents txtAdminContact1 As TextBox
    Friend WithEvents txtAdminRole As TextBox
    Friend WithEvents txtCurrentAdmin As TextBox
End Class
