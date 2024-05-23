<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formBooking
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
        txtFirstName = New TextBox()
        Label4 = New Label()
        txtLastName = New TextBox()
        Label5 = New Label()
        dtpBirth = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        cbSex = New ComboBox()
        txtAddress = New TextBox()
        Label8 = New Label()
        dtpArrival = New DateTimePicker()
        Label9 = New Label()
        dtpDeparture = New DateTimePicker()
        Label10 = New Label()
        btnSubmit = New Button()
        btnCancel = New Button()
        Label12 = New Label()
        lbxGuestNames = New ListBox()
        txtGuestName = New TextBox()
        Label2 = New Label()
        cbGuestType = New ComboBox()
        btnEnterGuest = New Button()
        btnClearList = New Button()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label1 = New Label()
        Label11 = New Label()
        txtUsername = New TextBox()
        Label13 = New Label()
        txtPassword = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(88, 171)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(223, 23)
        txtFirstName.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(88, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 18)
        Label4.TabIndex = 0
        Label4.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(353, 171)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(221, 23)
        txtLastName.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(353, 150)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 18)
        Label5.TabIndex = 5
        Label5.Text = "Last Name"
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Location = New Point(88, 221)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(223, 23)
        dtpBirth.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(88, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 18)
        Label6.TabIndex = 0
        Label6.Text = "Birthdate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(353, 200)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 18)
        Label7.TabIndex = 2
        Label7.Text = "Sex"
        ' 
        ' cbSex
        ' 
        cbSex.FormattingEnabled = True
        cbSex.Location = New Point(353, 221)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(221, 23)
        cbSex.TabIndex = 3
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(88, 269)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(487, 23)
        txtAddress.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(88, 248)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 18)
        Label8.TabIndex = 8
        Label8.Text = "Address"
        ' 
        ' dtpArrival
        ' 
        dtpArrival.Location = New Point(89, 315)
        dtpArrival.Name = "dtpArrival"
        dtpArrival.Size = New Size(223, 23)
        dtpArrival.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(90, 295)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 18)
        Label9.TabIndex = 10
        Label9.Text = "Arrival Date"
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(352, 315)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(223, 23)
        dtpDeparture.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(353, 295)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 18)
        Label10.TabIndex = 12
        Label10.Text = "Departure Date"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DarkSlateGray
        btnSubmit.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = SystemColors.ButtonFace
        btnSubmit.Location = New Point(75, 546)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(234, 56)
        btnSubmit.TabIndex = 14
        btnSubmit.Text = "Submit Reservation"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Maroon
        btnCancel.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = SystemColors.ButtonFace
        btnCancel.Location = New Point(361, 546)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(234, 56)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(93, 360)
        Label12.Name = "Label12"
        Label12.Size = New Size(152, 18)
        Label12.TabIndex = 17
        Label12.Text = "Input Guest Names:"
        ' 
        ' lbxGuestNames
        ' 
        lbxGuestNames.FormattingEnabled = True
        lbxGuestNames.ItemHeight = 15
        lbxGuestNames.Location = New Point(90, 410)
        lbxGuestNames.Name = "lbxGuestNames"
        lbxGuestNames.Size = New Size(365, 109)
        lbxGuestNames.TabIndex = 20
        ' 
        ' txtGuestName
        ' 
        txtGuestName.Location = New Point(90, 381)
        txtGuestName.Name = "txtGuestName"
        txtGuestName.Size = New Size(283, 23)
        txtGuestName.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(90, 363)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 22
        ' 
        ' cbGuestType
        ' 
        cbGuestType.FormattingEnabled = True
        cbGuestType.Items.AddRange(New Object() {"Regular", "Below 7", "Senior"})
        cbGuestType.Location = New Point(379, 381)
        cbGuestType.Name = "cbGuestType"
        cbGuestType.Size = New Size(76, 23)
        cbGuestType.TabIndex = 23
        ' 
        ' btnEnterGuest
        ' 
        btnEnterGuest.BackColor = Color.DarkSlateGray
        btnEnterGuest.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnterGuest.ForeColor = SystemColors.ButtonFace
        btnEnterGuest.Location = New Point(479, 377)
        btnEnterGuest.Name = "btnEnterGuest"
        btnEnterGuest.Size = New Size(96, 61)
        btnEnterGuest.TabIndex = 14
        btnEnterGuest.Text = "Enter"
        btnEnterGuest.UseVisualStyleBackColor = False
        ' 
        ' btnClearList
        ' 
        btnClearList.BackColor = Color.DarkSlateGray
        btnClearList.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearList.ForeColor = SystemColors.ButtonFace
        btnClearList.Location = New Point(479, 454)
        btnClearList.Name = "btnClearList"
        btnClearList.Size = New Size(96, 61)
        btnClearList.TabIndex = 14
        btnClearList.Text = "Clear"
        btnClearList.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources._863ddd18_06e3_448e_8aa3_d6c3760816ca_removebg_preview__1_1
        PictureBox1.Location = New Point(24, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 66)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 24
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(107, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(531, 41)
        Label3.TabIndex = 25
        Label3.Text = "San Antonio NOM Pass Resort"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gainsboro
        Label1.Location = New Point(113, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 24)
        Label1.TabIndex = 26
        Label1.Text = "Welcome to"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(87, 103)
        Label11.Name = "Label11"
        Label11.Size = New Size(72, 18)
        Label11.TabIndex = 0
        Label11.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(87, 124)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(223, 23)
        txtUsername.TabIndex = 4
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(352, 103)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 18)
        Label13.TabIndex = 5
        Label13.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(352, 124)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(221, 23)
        txtPassword.TabIndex = 6
        ' 
        ' formBooking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        BackgroundImage = My.Resources.Resources.Desktop___1
        ClientSize = New Size(684, 675)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(cbGuestType)
        Controls.Add(Label2)
        Controls.Add(txtGuestName)
        Controls.Add(lbxGuestNames)
        Controls.Add(Label12)
        Controls.Add(btnCancel)
        Controls.Add(btnClearList)
        Controls.Add(btnEnterGuest)
        Controls.Add(btnSubmit)
        Controls.Add(dtpDeparture)
        Controls.Add(Label10)
        Controls.Add(dtpArrival)
        Controls.Add(Label9)
        Controls.Add(txtAddress)
        Controls.Add(Label8)
        Controls.Add(dtpBirth)
        Controls.Add(txtPassword)
        Controls.Add(Label13)
        Controls.Add(txtLastName)
        Controls.Add(txtUsername)
        Controls.Add(Label5)
        Controls.Add(txtFirstName)
        Controls.Add(cbSex)
        Controls.Add(Label7)
        Controls.Add(Label11)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Name = "formBooking"
        Text = "formBooking"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpArrival As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lbxGuestNames As ListBox
    Friend WithEvents txtGuestName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbGuestType As ComboBox
    Friend WithEvents btnEnterGuest As Button
    Friend WithEvents btnClearList As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPassword As TextBox

End Class
