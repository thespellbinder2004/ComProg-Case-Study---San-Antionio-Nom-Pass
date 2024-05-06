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
        Panel5 = New Panel()
        Panel4 = New Panel()
        Label10 = New Label()
        Label9 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker3 = New DateTimePicker()
        Panel3 = New Panel()
        ComboBox3 = New ComboBox()
        Label6 = New Label()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox3 = New TextBox()
        Label8 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        NumericUpDown1 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown3 = New NumericUpDown()
        Label3 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        Label4 = New Label()
        txtFirstName = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        btnSubmit = New Button()
        Label1 = New Label()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Controls.Add(Panel4)
        Panel5.Controls.Add(Panel3)
        Panel5.Controls.Add(Panel2)
        Panel5.Controls.Add(Panel1)
        Panel5.Controls.Add(Button2)
        Panel5.Controls.Add(btnSubmit)
        Panel5.Controls.Add(Label1)
        Panel5.Location = New Point(76, 22)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(662, 592)
        Panel5.TabIndex = 27
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(108), CByte(107), CByte(88))
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(DateTimePicker2)
        Panel4.Controls.Add(DateTimePicker3)
        Panel4.Location = New Point(97, 385)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(468, 71)
        Panel4.TabIndex = 33
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(237, 11)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 18)
        Label10.TabIndex = 12
        Label10.Text = "Departure Date"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(8, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 18)
        Label9.TabIndex = 10
        Label9.Text = "Arrival Date"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarMonthBackground = Color.Gainsboro
        DateTimePicker2.Location = New Point(7, 31)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(223, 23)
        DateTimePicker2.TabIndex = 11
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.CalendarMonthBackground = Color.Gainsboro
        DateTimePicker3.Location = New Point(236, 31)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(223, 23)
        DateTimePicker3.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(108), CByte(107), CByte(88))
        Panel3.Controls.Add(ComboBox3)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(Label8)
        Panel3.Location = New Point(97, 262)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(468, 117)
        Panel3.TabIndex = 32
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.Gainsboro
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(300, 28)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(129, 23)
        ComboBox3.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(8, 7)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 18)
        Label6.TabIndex = 0
        Label6.Text = "Birthdate"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(300, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 18)
        Label7.TabIndex = 2
        Label7.Text = "Sex"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = Color.Gainsboro
        DateTimePicker1.CustomFormat = ""
        DateTimePicker1.Location = New Point(8, 28)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(248, 23)
        DateTimePicker1.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gainsboro
        TextBox3.Location = New Point(8, 82)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(450, 23)
        TextBox3.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(8, 61)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 18)
        Label8.TabIndex = 8
        Label8.Text = "Address"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(108), CByte(107), CByte(88))
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(NumericUpDown1)
        Panel2.Controls.Add(NumericUpDown2)
        Panel2.Controls.Add(NumericUpDown3)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label12)
        Panel2.Location = New Point(97, 158)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(468, 98)
        Panel2.TabIndex = 31
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(8, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 18)
        Label2.TabIndex = 22
        Label2.Text = "Number of Guests"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.BackColor = Color.Gainsboro
        NumericUpDown1.Location = New Point(8, 62)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 19
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.BackColor = Color.Gainsboro
        NumericUpDown2.Location = New Point(309, 62)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(120, 23)
        NumericUpDown2.TabIndex = 20
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.BackColor = Color.Gainsboro
        NumericUpDown3.Location = New Point(160, 62)
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(120, 23)
        NumericUpDown3.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(8, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 18)
        Label3.TabIndex = 2
        Label3.Text = "Regular Guests"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(160, 40)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 18)
        Label11.TabIndex = 15
        Label11.Text = "Minor Guests"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(309, 40)
        Label12.Name = "Label12"
        Label12.Size = New Size(112, 18)
        Label12.TabIndex = 17
        Label12.Text = "Senior Guests"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(108), CByte(107), CByte(88))
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtFirstName)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(97, 81)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(468, 71)
        Panel1.TabIndex = 30
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(237, 34)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(221, 23)
        TextBox2.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(8, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 18)
        Label4.TabIndex = 0
        Label4.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = Color.Gainsboro
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Location = New Point(8, 34)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(223, 23)
        txtFirstName.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(237, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 18)
        Label5.TabIndex = 5
        Label5.Text = "Last Name"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Maroon
        Button2.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(97, 507)
        Button2.Name = "Button2"
        Button2.Size = New Size(221, 50)
        Button2.TabIndex = 28
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSubmit.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = SystemColors.ButtonFace
        btnSubmit.Location = New Point(344, 507)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(221, 50)
        btnSubmit.TabIndex = 29
        btnSubmit.Text = "Next"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(108), CByte(107), CByte(88))
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(116, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(419, 32)
        Label1.TabIndex = 27
        Label1.Text = "San Antonio NOM Pass Resort"
        ' 
        ' formBooking
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.formBookingBG1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(858, 646)
        Controls.Add(Panel5)
        Name = "formBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formBooking"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label

End Class
