<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUser
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
        pnlCustomerDetails = New Panel()
        pnlPayment = New Panel()
        btnCanc = New Button()
        btnConfi = New Button()
        txtPaym = New TextBox()
        txtTotBill = New TextBox()
        Label57 = New Label()
        Label56 = New Label()
        Label55 = New Label()
        lbRooms = New ListBox()
        lbGuests = New ListBox()
        Panel1 = New Panel()
        Label7 = New Label()
        Label3 = New Label()
        btnLogOut = New Button()
        btnCheckOut = New Button()
        txtTotalBill = New TextBox()
        Label50 = New Label()
        Label49 = New Label()
        Label46 = New Label()
        Label47 = New Label()
        txtLastName = New TextBox()
        Label41 = New Label()
        txtAddress = New TextBox()
        Label45 = New Label()
        txtBirthday = New TextBox()
        Label44 = New Label()
        txtDepartureDate = New TextBox()
        Label6 = New Label()
        txtSex = New TextBox()
        txtArrivalDate = New TextBox()
        Label43 = New Label()
        txtAge = New TextBox()
        Label42 = New Label()
        txtFirstName = New TextBox()
        Label40 = New Label()
        pnlLogIn = New Panel()
        btnAdmin = New Button()
        btnBookNow = New Button()
        btnSubmit = New Button()
        Label8 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        pnlCustomerDetails.SuspendLayout()
        pnlPayment.SuspendLayout()
        pnlLogIn.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCustomerDetails
        ' 
        pnlCustomerDetails.AutoScroll = True
        pnlCustomerDetails.BackColor = Color.Transparent
        pnlCustomerDetails.BackgroundImage = My.Resources.Resources.Desktop___1__1_
        pnlCustomerDetails.Controls.Add(pnlPayment)
        pnlCustomerDetails.Controls.Add(lbRooms)
        pnlCustomerDetails.Controls.Add(lbGuests)
        pnlCustomerDetails.Controls.Add(Panel1)
        pnlCustomerDetails.Controls.Add(Label7)
        pnlCustomerDetails.Controls.Add(Label3)
        pnlCustomerDetails.Controls.Add(btnLogOut)
        pnlCustomerDetails.Controls.Add(btnCheckOut)
        pnlCustomerDetails.Controls.Add(txtTotalBill)
        pnlCustomerDetails.Controls.Add(Label50)
        pnlCustomerDetails.Controls.Add(Label49)
        pnlCustomerDetails.Controls.Add(Label46)
        pnlCustomerDetails.Controls.Add(Label47)
        pnlCustomerDetails.Controls.Add(txtLastName)
        pnlCustomerDetails.Controls.Add(Label41)
        pnlCustomerDetails.Controls.Add(txtAddress)
        pnlCustomerDetails.Controls.Add(Label45)
        pnlCustomerDetails.Controls.Add(txtBirthday)
        pnlCustomerDetails.Controls.Add(Label44)
        pnlCustomerDetails.Controls.Add(txtDepartureDate)
        pnlCustomerDetails.Controls.Add(Label6)
        pnlCustomerDetails.Controls.Add(txtSex)
        pnlCustomerDetails.Controls.Add(txtArrivalDate)
        pnlCustomerDetails.Controls.Add(Label43)
        pnlCustomerDetails.Controls.Add(txtAge)
        pnlCustomerDetails.Controls.Add(Label42)
        pnlCustomerDetails.Controls.Add(txtFirstName)
        pnlCustomerDetails.Controls.Add(Label40)
        pnlCustomerDetails.Enabled = False
        pnlCustomerDetails.Location = New Point(277, 0)
        pnlCustomerDetails.Name = "pnlCustomerDetails"
        pnlCustomerDetails.Size = New Size(780, 502)
        pnlCustomerDetails.TabIndex = 0
        ' 
        ' pnlPayment
        ' 
        pnlPayment.BackColor = SystemColors.InactiveCaption
        pnlPayment.BorderStyle = BorderStyle.FixedSingle
        pnlPayment.Controls.Add(btnCanc)
        pnlPayment.Controls.Add(btnConfi)
        pnlPayment.Controls.Add(txtPaym)
        pnlPayment.Controls.Add(txtTotBill)
        pnlPayment.Controls.Add(Label57)
        pnlPayment.Controls.Add(Label56)
        pnlPayment.Controls.Add(Label55)
        pnlPayment.Location = New Point(216, 442)
        pnlPayment.Margin = New Padding(3, 2, 3, 2)
        pnlPayment.Name = "pnlPayment"
        pnlPayment.Size = New Size(380, 241)
        pnlPayment.TabIndex = 51
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
        ' 
        ' lbRooms
        ' 
        lbRooms.FormattingEnabled = True
        lbRooms.ItemHeight = 15
        lbRooms.Location = New Point(207, 343)
        lbRooms.Name = "lbRooms"
        lbRooms.Size = New Size(253, 94)
        lbRooms.TabIndex = 8
        ' 
        ' lbGuests
        ' 
        lbGuests.FormattingEnabled = True
        lbGuests.ItemHeight = 15
        lbGuests.Location = New Point(207, 456)
        lbGuests.Name = "lbGuests"
        lbGuests.Size = New Size(253, 94)
        lbGuests.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Location = New Point(3, 737)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(750, 32)
        Panel1.TabIndex = 50
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Consolas", 12F)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(69, 256)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 19)
        Label7.TabIndex = 7
        Label7.Text = "Arrival Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(114, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 19)
        Label3.TabIndex = 7
        Label3.Text = "Age :"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.AntiqueWhite
        btnLogOut.Location = New Point(566, 590)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(162, 55)
        btnLogOut.TabIndex = 12
        btnLogOut.Text = "Log Out"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnCheckOut
        ' 
        btnCheckOut.BackColor = Color.AntiqueWhite
        btnCheckOut.Location = New Point(398, 590)
        btnCheckOut.Name = "btnCheckOut"
        btnCheckOut.Size = New Size(162, 55)
        btnCheckOut.TabIndex = 11
        btnCheckOut.Text = "Check-Out"
        btnCheckOut.UseVisualStyleBackColor = False
        ' 
        ' txtTotalBill
        ' 
        txtTotalBill.Font = New Font("Consolas", 12F)
        txtTotalBill.Location = New Point(168, 604)
        txtTotalBill.Name = "txtTotalBill"
        txtTotalBill.Size = New Size(197, 26)
        txtTotalBill.TabIndex = 10
        ' 
        ' Label50
        ' 
        Label50.AutoSize = True
        Label50.Font = New Font("Consolas", 12F)
        Label50.ForeColor = Color.White
        Label50.Location = New Point(39, 607)
        Label50.Name = "Label50"
        Label50.Size = New Size(117, 19)
        Label50.TabIndex = 47
        Label50.Text = "Total Bill :"
        ' 
        ' Label49
        ' 
        Label49.AutoSize = True
        Label49.Font = New Font("Consolas", 12F)
        Label49.ForeColor = Color.White
        Label49.Location = New Point(105, 369)
        Label49.Name = "Label49"
        Label49.Size = New Size(63, 19)
        Label49.TabIndex = 45
        Label49.Text = "Rooms:"
        ' 
        ' Label46
        ' 
        Label46.AutoSize = True
        Label46.Font = New Font("Consolas", 12F)
        Label46.ForeColor = Color.White
        Label46.Location = New Point(51, 469)
        Label46.Name = "Label46"
        Label46.Size = New Size(144, 19)
        Label46.TabIndex = 41
        Label46.Text = "List of Guests:"
        ' 
        ' Label47
        ' 
        Label47.AutoSize = True
        Label47.Font = New Font("Consolas", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label47.Location = New Point(159, -82)
        Label47.Name = "Label47"
        Label47.Size = New Size(466, 56)
        Label47.TabIndex = 40
        Label47.Text = "Customer Details:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Consolas", 12F)
        txtLastName.Location = New Point(207, 66)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(470, 26)
        txtLastName.TabIndex = 1
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.BackColor = Color.Transparent
        Label41.Font = New Font("Consolas", 12F)
        Label41.ForeColor = Color.White
        Label41.Location = New Point(78, 69)
        Label41.Name = "Label41"
        Label41.Size = New Size(99, 19)
        Label41.TabIndex = 38
        Label41.Text = "Last Name:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Consolas", 12F)
        txtAddress.Location = New Point(207, 112)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(470, 26)
        txtAddress.TabIndex = 2
        ' 
        ' Label45
        ' 
        Label45.AutoSize = True
        Label45.BackColor = Color.Transparent
        Label45.Font = New Font("Consolas", 12F)
        Label45.ForeColor = Color.White
        Label45.Location = New Point(78, 116)
        Label45.Name = "Label45"
        Label45.Size = New Size(90, 19)
        Label45.TabIndex = 36
        Label45.Text = "Address :"
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Font = New Font("Consolas", 12F)
        txtBirthday.Location = New Point(207, 204)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(197, 26)
        txtBirthday.TabIndex = 5
        ' 
        ' Label44
        ' 
        Label44.AutoSize = True
        Label44.BackColor = Color.Transparent
        Label44.Font = New Font("Consolas", 12F)
        Label44.ForeColor = Color.White
        Label44.Location = New Point(78, 207)
        Label44.Name = "Label44"
        Label44.Size = New Size(99, 19)
        Label44.TabIndex = 34
        Label44.Text = "Birthday :"
        ' 
        ' txtDepartureDate
        ' 
        txtDepartureDate.Font = New Font("Consolas", 12F)
        txtDepartureDate.Location = New Point(207, 300)
        txtDepartureDate.Name = "txtDepartureDate"
        txtDepartureDate.Size = New Size(197, 26)
        txtDepartureDate.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Consolas", 12F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(51, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 19)
        Label6.TabIndex = 32
        Label6.Text = "Departure Date:"
        ' 
        ' txtSex
        ' 
        txtSex.Font = New Font("Consolas", 12F)
        txtSex.Location = New Point(490, 162)
        txtSex.Name = "txtSex"
        txtSex.Size = New Size(186, 26)
        txtSex.TabIndex = 4
        ' 
        ' txtArrivalDate
        ' 
        txtArrivalDate.Font = New Font("Consolas", 12F)
        txtArrivalDate.Location = New Point(207, 250)
        txtArrivalDate.Name = "txtArrivalDate"
        txtArrivalDate.Size = New Size(197, 26)
        txtArrivalDate.TabIndex = 6
        ' 
        ' Label43
        ' 
        Label43.AutoSize = True
        Label43.BackColor = Color.Transparent
        Label43.Font = New Font("Consolas", 12F)
        Label43.ForeColor = Color.White
        Label43.Location = New Point(423, 162)
        Label43.Name = "Label43"
        Label43.Size = New Size(54, 19)
        Label43.TabIndex = 32
        Label43.Text = "Sex :"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Consolas", 12F)
        txtAge.Location = New Point(207, 159)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(197, 26)
        txtAge.TabIndex = 3
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Consolas", 12F)
        Label42.Location = New Point(-37, 157)
        Label42.Name = "Label42"
        Label42.Size = New Size(54, 19)
        Label42.TabIndex = 30
        Label42.Text = "Age :"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Consolas", 12F)
        txtFirstName.Location = New Point(207, 20)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(470, 26)
        txtFirstName.TabIndex = 0
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.BackColor = Color.Transparent
        Label40.Font = New Font("Consolas", 12F)
        Label40.ForeColor = Color.White
        Label40.Location = New Point(78, 22)
        Label40.Name = "Label40"
        Label40.Size = New Size(117, 19)
        Label40.TabIndex = 28
        Label40.Text = "First Name :"
        ' 
        ' pnlLogIn
        ' 
        pnlLogIn.BackColor = Color.Transparent
        pnlLogIn.BackgroundImage = My.Resources.Resources.Desktop___1
        pnlLogIn.Controls.Add(btnAdmin)
        pnlLogIn.Controls.Add(btnBookNow)
        pnlLogIn.Controls.Add(btnSubmit)
        pnlLogIn.Controls.Add(Label8)
        pnlLogIn.Controls.Add(Label2)
        pnlLogIn.Controls.Add(Label5)
        pnlLogIn.Controls.Add(Label4)
        pnlLogIn.Controls.Add(Label1)
        pnlLogIn.Controls.Add(txtPassword)
        pnlLogIn.Controls.Add(txtUsername)
        pnlLogIn.Location = New Point(0, 0)
        pnlLogIn.Name = "pnlLogIn"
        pnlLogIn.Size = New Size(281, 502)
        pnlLogIn.TabIndex = 0
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = SystemColors.Control
        btnAdmin.Location = New Point(183, 435)
        btnAdmin.Margin = New Padding(3, 4, 3, 4)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(78, 23)
        btnAdmin.TabIndex = 3
        btnAdmin.Text = "Admin"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' btnBookNow
        ' 
        btnBookNow.BackColor = SystemColors.Control
        btnBookNow.Location = New Point(184, 465)
        btnBookNow.Margin = New Padding(3, 4, 3, 4)
        btnBookNow.Name = "btnBookNow"
        btnBookNow.Size = New Size(78, 23)
        btnBookNow.TabIndex = 3
        btnBookNow.Text = "Book now!"
        btnBookNow.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(82, 253)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(109, 44)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(38, 440)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 14)
        Label8.TabIndex = 0
        Label8.Text = "Are you an admin?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(39, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 14)
        Label2.TabIndex = 0
        Label2.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(39, 470)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 14)
        Label5.TabIndex = 0
        Label5.Text = "Haven't booked yet?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(22, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 32)
        Label4.TabIndex = 0
        Label4.Text = "Log In"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(39, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 14)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(39, 178)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(197, 23)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(39, 118)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(197, 23)
        txtUsername.TabIndex = 0
        ' 
        ' formUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1057, 500)
        Controls.Add(pnlLogIn)
        Controls.Add(pnlCustomerDetails)
        Name = "formUser"
        Text = "formUser"
        pnlCustomerDetails.ResumeLayout(False)
        pnlCustomerDetails.PerformLayout()
        pnlPayment.ResumeLayout(False)
        pnlPayment.PerformLayout()
        pnlLogIn.ResumeLayout(False)
        pnlLogIn.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCustomerDetails As Panel
    Friend WithEvents pnlLogIn As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents txtTotalBill As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents txtSex As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBookNow As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents lbGuests As ListBox
    Friend WithEvents lbRooms As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDepartureDate As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArrivalDate As TextBox
    Friend WithEvents pnlPayment As Panel
    Friend WithEvents btnCanc As Button
    Friend WithEvents btnConfi As Button
    Friend WithEvents txtPaym As TextBox
    Friend WithEvents txtTotBill As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Label8 As Label
End Class
