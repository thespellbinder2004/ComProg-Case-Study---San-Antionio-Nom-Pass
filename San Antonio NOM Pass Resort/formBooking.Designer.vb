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
        Label1 = New Label()
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
        Label3 = New Label()
        txtUsername = New TextBox()
        Label11 = New Label()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 22)
        Label1.TabIndex = 0
        Label1.Text = "San Antonio NOM Pass Resort"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(37, 141)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(223, 23)
        txtFirstName.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(37, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 18)
        Label4.TabIndex = 0
        Label4.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(266, 141)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(221, 23)
        txtLastName.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(266, 120)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 18)
        Label5.TabIndex = 5
        Label5.Text = "Last Name"
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Location = New Point(37, 188)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(223, 23)
        dtpBirth.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(37, 167)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 18)
        Label6.TabIndex = 0
        Label6.Text = "Birthdate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(266, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 18)
        Label7.TabIndex = 2
        Label7.Text = "Sex"
        ' 
        ' cbSex
        ' 
        cbSex.FormattingEnabled = True
        cbSex.Location = New Point(266, 188)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(221, 23)
        cbSex.TabIndex = 3
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(37, 235)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(450, 23)
        txtAddress.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(37, 214)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 18)
        Label8.TabIndex = 8
        Label8.Text = "Address"
        ' 
        ' dtpArrival
        ' 
        dtpArrival.Location = New Point(37, 282)
        dtpArrival.Name = "dtpArrival"
        dtpArrival.Size = New Size(223, 23)
        dtpArrival.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(38, 262)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 18)
        Label9.TabIndex = 10
        Label9.Text = "Arrival Date"
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(266, 282)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(223, 23)
        dtpDeparture.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(267, 262)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 18)
        Label10.TabIndex = 12
        Label10.Text = "Departure Date"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSubmit.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = SystemColors.ButtonFace
        btnSubmit.Location = New Point(35, 487)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(221, 50)
        btnSubmit.TabIndex = 14
        btnSubmit.Text = "Submit Reservation"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Maroon
        btnCancel.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = SystemColors.ButtonFace
        btnCancel.Location = New Point(266, 487)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(221, 50)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(38, 324)
        Label12.Name = "Label12"
        Label12.Size = New Size(152, 18)
        Label12.TabIndex = 17
        Label12.Text = "Input Guest Names:"
        ' 
        ' lbxGuestNames
        ' 
        lbxGuestNames.FormattingEnabled = True
        lbxGuestNames.ItemHeight = 15
        lbxGuestNames.Location = New Point(35, 374)
        lbxGuestNames.Name = "lbxGuestNames"
        lbxGuestNames.Size = New Size(352, 109)
        lbxGuestNames.TabIndex = 20
        ' 
        ' txtGuestName
        ' 
        txtGuestName.Location = New Point(35, 345)
        txtGuestName.Name = "txtGuestName"
        txtGuestName.Size = New Size(270, 23)
        txtGuestName.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 22
        ' 
        ' cbGuestType
        ' 
        cbGuestType.FormattingEnabled = True
        cbGuestType.Items.AddRange(New Object() {"Regular", "Below 7", "Senior"})
        cbGuestType.Location = New Point(311, 345)
        cbGuestType.Name = "cbGuestType"
        cbGuestType.Size = New Size(76, 23)
        cbGuestType.TabIndex = 23
        ' 
        ' btnEnterGuest
        ' 
        btnEnterGuest.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnEnterGuest.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnterGuest.ForeColor = SystemColors.ButtonFace
        btnEnterGuest.Location = New Point(393, 345)
        btnEnterGuest.Name = "btnEnterGuest"
        btnEnterGuest.Size = New Size(96, 69)
        btnEnterGuest.TabIndex = 14
        btnEnterGuest.Text = "Enter"
        btnEnterGuest.UseVisualStyleBackColor = False
        ' 
        ' btnClearList
        ' 
        btnClearList.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClearList.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearList.ForeColor = SystemColors.ButtonFace
        btnClearList.Location = New Point(393, 420)
        btnClearList.Name = "btnClearList"
        btnClearList.Size = New Size(94, 63)
        btnClearList.TabIndex = 14
        btnClearList.Text = "Clear"
        btnClearList.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(37, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 18)
        Label3.TabIndex = 0
        Label3.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(37, 94)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(223, 23)
        txtUsername.TabIndex = 4
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(266, 73)
        Label11.Name = "Label11"
        Label11.Size = New Size(80, 18)
        Label11.TabIndex = 5
        Label11.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(266, 94)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(221, 23)
        txtPassword.TabIndex = 6
        ' 
        ' formBooking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 646)
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
        Controls.Add(Label11)
        Controls.Add(txtLastName)
        Controls.Add(txtUsername)
        Controls.Add(Label5)
        Controls.Add(txtFirstName)
        Controls.Add(cbSex)
        Controls.Add(Label7)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "formBooking"
        Text = "formBooking"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPassword As TextBox

End Class
