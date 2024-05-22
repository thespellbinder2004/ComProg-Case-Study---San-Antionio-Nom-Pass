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
        Label1.Location = New Point(55, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 28)
        Label1.TabIndex = 0
        Label1.Text = "San Antonio NOM Pass Resort"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(42, 188)
        txtFirstName.Margin = New Padding(3, 4, 3, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(254, 27)
        txtFirstName.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(42, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 22)
        Label4.TabIndex = 0
        Label4.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(304, 188)
        txtLastName.Margin = New Padding(3, 4, 3, 4)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(252, 27)
        txtLastName.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(304, 160)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 22)
        Label5.TabIndex = 5
        Label5.Text = "Last Name"
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Location = New Point(42, 251)
        dtpBirth.Margin = New Padding(3, 4, 3, 4)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(254, 27)
        dtpBirth.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(42, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 22)
        Label6.TabIndex = 0
        Label6.Text = "Birthdate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(304, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 22)
        Label7.TabIndex = 2
        Label7.Text = "Sex"
        ' 
        ' cbSex
        ' 
        cbSex.FormattingEnabled = True
        cbSex.Location = New Point(304, 251)
        cbSex.Margin = New Padding(3, 4, 3, 4)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(252, 28)
        cbSex.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(42, 313)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(514, 27)
        txtAddress.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(42, 285)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 22)
        Label8.TabIndex = 8
        Label8.Text = "Address"
        ' 
        ' dtpArrival
        ' 
        dtpArrival.Location = New Point(42, 376)
        dtpArrival.Margin = New Padding(3, 4, 3, 4)
        dtpArrival.Name = "dtpArrival"
        dtpArrival.Size = New Size(254, 27)
        dtpArrival.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(43, 349)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 22)
        Label9.TabIndex = 10
        Label9.Text = "Arrival Date"
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(304, 376)
        dtpDeparture.Margin = New Padding(3, 4, 3, 4)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(254, 27)
        dtpDeparture.TabIndex = 8
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(305, 349)
        Label10.Name = "Label10"
        Label10.Size = New Size(150, 22)
        Label10.TabIndex = 12
        Label10.Text = "Departure Date"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSubmit.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = SystemColors.ButtonFace
        btnSubmit.Location = New Point(40, 649)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(253, 67)
        btnSubmit.TabIndex = 14
        btnSubmit.Text = "Submit Reservation"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Maroon
        btnCancel.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = SystemColors.ButtonFace
        btnCancel.Location = New Point(304, 649)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(253, 67)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(43, 432)
        Label12.Name = "Label12"
        Label12.Size = New Size(190, 22)
        Label12.TabIndex = 17
        Label12.Text = "Input Guest Names:"
        ' 
        ' lbxGuestNames
        ' 
        lbxGuestNames.FormattingEnabled = True
        lbxGuestNames.Location = New Point(40, 499)
        lbxGuestNames.Margin = New Padding(3, 4, 3, 4)
        lbxGuestNames.Name = "lbxGuestNames"
        lbxGuestNames.Size = New Size(402, 144)
        lbxGuestNames.TabIndex = 12
        ' 
        ' txtGuestName
        ' 
        txtGuestName.Location = New Point(40, 460)
        txtGuestName.Margin = New Padding(3, 4, 3, 4)
        txtGuestName.Name = "txtGuestName"
        txtGuestName.Size = New Size(308, 27)
        txtGuestName.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 436)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 22
        ' 
        ' cbGuestType
        ' 
        cbGuestType.FormattingEnabled = True
        cbGuestType.Items.AddRange(New Object() {"Regular", "Below 7", "Senior"})
        cbGuestType.Location = New Point(355, 460)
        cbGuestType.Margin = New Padding(3, 4, 3, 4)
        cbGuestType.Name = "cbGuestType"
        cbGuestType.Size = New Size(86, 28)
        cbGuestType.TabIndex = 10
        ' 
        ' btnEnterGuest
        ' 
        btnEnterGuest.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnEnterGuest.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnterGuest.ForeColor = SystemColors.ButtonFace
        btnEnterGuest.Location = New Point(449, 460)
        btnEnterGuest.Margin = New Padding(3, 4, 3, 4)
        btnEnterGuest.Name = "btnEnterGuest"
        btnEnterGuest.Size = New Size(110, 92)
        btnEnterGuest.TabIndex = 11
        btnEnterGuest.Text = "Enter"
        btnEnterGuest.UseVisualStyleBackColor = False
        ' 
        ' btnClearList
        ' 
        btnClearList.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnClearList.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClearList.ForeColor = SystemColors.ButtonFace
        btnClearList.Location = New Point(449, 560)
        btnClearList.Margin = New Padding(3, 4, 3, 4)
        btnClearList.Name = "btnClearList"
        btnClearList.Size = New Size(107, 84)
        btnClearList.TabIndex = 13
        btnClearList.Text = "Clear"
        btnClearList.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(42, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 22)
        Label3.TabIndex = 0
        Label3.Text = "Username:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(42, 125)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(254, 27)
        txtUsername.TabIndex = 0
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(304, 97)
        Label11.Name = "Label11"
        Label11.Size = New Size(100, 22)
        Label11.TabIndex = 5
        Label11.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(304, 125)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(252, 27)
        txtPassword.TabIndex = 1
        ' 
        ' formBooking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 861)
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
        Margin = New Padding(3, 4, 3, 4)
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
