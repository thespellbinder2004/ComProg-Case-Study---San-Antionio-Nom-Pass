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
        Label3 = New Label()
        txtFirstName = New TextBox()
        Label4 = New Label()
        txtLastName = New TextBox()
        Label5 = New Label()
        dtpBirth = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        cbSex = New ComboBox()
        TextBox3 = New TextBox()
        Label8 = New Label()
        dtpArrival = New DateTimePicker()
        Label9 = New Label()
        dtpDeparture = New DateTimePicker()
        Label10 = New Label()
        btnSubmit = New Button()
        btnCancel = New Button()
        Label11 = New Label()
        Label12 = New Label()
        nudRegularGuests = New NumericUpDown()
        nudMinorGuests = New NumericUpDown()
        nudSeniorGuests = New NumericUpDown()
        CType(nudRegularGuests, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudMinorGuests, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSeniorGuests, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 18)
        Label3.TabIndex = 2
        Label3.Text = "Regular Guests"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(48, 206)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(223, 23)
        txtFirstName.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(48, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 18)
        Label4.TabIndex = 0
        Label4.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(277, 206)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(221, 23)
        txtLastName.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(277, 185)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 18)
        Label5.TabIndex = 5
        Label5.Text = "Last Name"
        ' 
        ' dtpBirth
        ' 
        dtpBirth.CustomFormat = ""
        dtpBirth.Location = New Point(48, 253)
        dtpBirth.Name = "dtpBirth"
        dtpBirth.Size = New Size(223, 23)
        dtpBirth.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(48, 232)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 18)
        Label6.TabIndex = 0
        Label6.Text = "Birthdate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(277, 232)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 18)
        Label7.TabIndex = 2
        Label7.Text = "Sex"
        ' 
        ' cbSex
        ' 
        cbSex.FormattingEnabled = True
        cbSex.Location = New Point(277, 253)
        cbSex.Name = "cbSex"
        cbSex.Size = New Size(221, 23)
        cbSex.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(48, 300)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(450, 23)
        TextBox3.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(48, 279)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 18)
        Label8.TabIndex = 8
        Label8.Text = "Address"
        ' 
        ' dtpArrival
        ' 
        dtpArrival.Location = New Point(48, 347)
        dtpArrival.Name = "dtpArrival"
        dtpArrival.Size = New Size(223, 23)
        dtpArrival.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(49, 327)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 18)
        Label9.TabIndex = 10
        Label9.Text = "Arrival Date"
        ' 
        ' dtpDeparture
        ' 
        dtpDeparture.Location = New Point(277, 347)
        dtpDeparture.Name = "dtpDeparture"
        dtpDeparture.Size = New Size(223, 23)
        dtpDeparture.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(278, 327)
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
        btnSubmit.Location = New Point(46, 483)
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
        btnCancel.Location = New Point(277, 483)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(221, 50)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(46, 138)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 18)
        Label11.TabIndex = 15
        Label11.Text = "Minor Guests"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(273, 91)
        Label12.Name = "Label12"
        Label12.Size = New Size(112, 18)
        Label12.TabIndex = 17
        Label12.Text = "Senior Guests"
        ' 
        ' nudRegularGuests
        ' 
        nudRegularGuests.Location = New Point(49, 112)
        nudRegularGuests.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        nudRegularGuests.Name = "nudRegularGuests"
        nudRegularGuests.Size = New Size(222, 23)
        nudRegularGuests.TabIndex = 19
        ' 
        ' nudMinorGuests
        ' 
        nudMinorGuests.Location = New Point(49, 159)
        nudMinorGuests.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        nudMinorGuests.Name = "nudMinorGuests"
        nudMinorGuests.Size = New Size(222, 23)
        nudMinorGuests.TabIndex = 19
        ' 
        ' nudSeniorGuests
        ' 
        nudSeniorGuests.Location = New Point(278, 112)
        nudSeniorGuests.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        nudSeniorGuests.Name = "nudSeniorGuests"
        nudSeniorGuests.Size = New Size(222, 23)
        nudSeniorGuests.TabIndex = 19
        ' 
        ' formBooking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(546, 646)
        Controls.Add(nudSeniorGuests)
        Controls.Add(nudMinorGuests)
        Controls.Add(nudRegularGuests)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(dtpDeparture)
        Controls.Add(Label10)
        Controls.Add(dtpArrival)
        Controls.Add(Label9)
        Controls.Add(TextBox3)
        Controls.Add(Label8)
        Controls.Add(dtpBirth)
        Controls.Add(txtLastName)
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
        CType(nudRegularGuests, ComponentModel.ISupportInitialize).EndInit()
        CType(nudMinorGuests, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSeniorGuests, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpArrival As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpDeparture As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents nudRegularGuests As NumericUpDown
    Friend WithEvents nudMinorGuests As NumericUpDown
    Friend WithEvents nudSeniorGuests As NumericUpDown

End Class
