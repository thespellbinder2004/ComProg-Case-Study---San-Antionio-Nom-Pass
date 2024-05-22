<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReciept
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
        Label1 = New Label()
        Label2 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtGuestsName = New TextBox()
        txtNumberOfGuest = New TextBox()
        txtArrivalDate = New TextBox()
        txtDepartureDate = New TextBox()
        txtTotalPayment = New TextBox()
        Label6 = New Label()
        btnConfirm = New Button()
        btnAddRoom = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 40)
        Label1.TabIndex = 1
        Label1.Text = "Receipt No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(261, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 40)
        Label2.TabIndex = 2
        Label2.Text = "000000"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(41, 236)
        Label10.Name = "Label10"
        Label10.Size = New Size(150, 22)
        Label10.TabIndex = 14
        Label10.Text = "Departure Date"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(41, 197)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 22)
        Label9.TabIndex = 13
        Label9.Text = "Arrival Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(41, 81)
        Label11.Name = "Label11"
        Label11.Size = New Size(140, 22)
        Label11.TabIndex = 16
        Label11.Text = "Guest's Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(41, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 22)
        Label3.TabIndex = 17
        Label3.Text = "Number of Guests:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 353)
        Label4.Name = "Label4"
        Label4.Size = New Size(330, 44)
        Label4.TabIndex = 18
        Label4.Text = "Please take a picture or a" & vbCrLf & "screenshot as ticket for payment"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(213, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 22)
        Label5.TabIndex = 19
        ' 
        ' txtGuestsName
        ' 
        txtGuestsName.BackColor = Color.Gainsboro
        txtGuestsName.BorderStyle = BorderStyle.FixedSingle
        txtGuestsName.Enabled = False
        txtGuestsName.ForeColor = SystemColors.WindowText
        txtGuestsName.Location = New Point(176, 75)
        txtGuestsName.Margin = New Padding(3, 4, 3, 4)
        txtGuestsName.Name = "txtGuestsName"
        txtGuestsName.ReadOnly = True
        txtGuestsName.Size = New Size(188, 27)
        txtGuestsName.TabIndex = 0
        ' 
        ' txtNumberOfGuest
        ' 
        txtNumberOfGuest.BackColor = Color.Gainsboro
        txtNumberOfGuest.BorderStyle = BorderStyle.FixedSingle
        txtNumberOfGuest.Enabled = False
        txtNumberOfGuest.ForeColor = SystemColors.WindowText
        txtNumberOfGuest.Location = New Point(213, 113)
        txtNumberOfGuest.Margin = New Padding(3, 4, 3, 4)
        txtNumberOfGuest.Name = "txtNumberOfGuest"
        txtNumberOfGuest.ReadOnly = True
        txtNumberOfGuest.Size = New Size(152, 27)
        txtNumberOfGuest.TabIndex = 1
        ' 
        ' txtArrivalDate
        ' 
        txtArrivalDate.BackColor = Color.Gainsboro
        txtArrivalDate.BorderStyle = BorderStyle.FixedSingle
        txtArrivalDate.Enabled = False
        txtArrivalDate.ForeColor = SystemColors.WindowText
        txtArrivalDate.Location = New Point(197, 191)
        txtArrivalDate.Margin = New Padding(3, 4, 3, 4)
        txtArrivalDate.Name = "txtArrivalDate"
        txtArrivalDate.ReadOnly = True
        txtArrivalDate.Size = New Size(168, 27)
        txtArrivalDate.TabIndex = 2
        ' 
        ' txtDepartureDate
        ' 
        txtDepartureDate.BackColor = Color.Gainsboro
        txtDepartureDate.BorderStyle = BorderStyle.FixedSingle
        txtDepartureDate.Enabled = False
        txtDepartureDate.ForeColor = SystemColors.WindowText
        txtDepartureDate.Location = New Point(197, 229)
        txtDepartureDate.Margin = New Padding(3, 4, 3, 4)
        txtDepartureDate.Name = "txtDepartureDate"
        txtDepartureDate.ReadOnly = True
        txtDepartureDate.Size = New Size(168, 27)
        txtDepartureDate.TabIndex = 3
        ' 
        ' txtTotalPayment
        ' 
        txtTotalPayment.BackColor = Color.Gainsboro
        txtTotalPayment.BorderStyle = BorderStyle.FixedSingle
        txtTotalPayment.Enabled = False
        txtTotalPayment.ForeColor = SystemColors.WindowText
        txtTotalPayment.Location = New Point(213, 295)
        txtTotalPayment.Margin = New Padding(3, 4, 3, 4)
        txtTotalPayment.Name = "txtTotalPayment"
        txtTotalPayment.ReadOnly = True
        txtTotalPayment.Size = New Size(152, 27)
        txtTotalPayment.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(41, 301)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 22)
        Label6.TabIndex = 24
        Label6.Text = "Total Payment:"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(74, 423)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(94, 29)
        btnConfirm.TabIndex = 5
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnAddRoom
        ' 
        btnAddRoom.Location = New Point(222, 423)
        btnAddRoom.Name = "btnAddRoom"
        btnAddRoom.Size = New Size(94, 29)
        btnAddRoom.TabIndex = 6
        btnAddRoom.Text = "Add Room"
        btnAddRoom.UseVisualStyleBackColor = True
        ' 
        ' formReciept
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(410, 492)
        Controls.Add(btnAddRoom)
        Controls.Add(btnConfirm)
        Controls.Add(txtTotalPayment)
        Controls.Add(Label6)
        Controls.Add(txtDepartureDate)
        Controls.Add(txtArrivalDate)
        Controls.Add(txtNumberOfGuest)
        Controls.Add(txtGuestsName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "formReciept"
        StartPosition = FormStartPosition.CenterScreen
        Text = "formReciept"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGuestsName As TextBox
    Friend WithEvents txtNumberOfGuest As TextBox
    Friend WithEvents txtArrivalDate As TextBox
    Friend WithEvents txtDepartureDate As TextBox
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnAddRoom As Button
End Class
