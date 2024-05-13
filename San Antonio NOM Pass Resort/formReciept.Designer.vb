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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 32)
        Label1.TabIndex = 1
        Label1.Text = "Receipt No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(215, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 32)
        Label2.TabIndex = 2
        Label2.Text = "000000"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(36, 177)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 18)
        Label10.TabIndex = 14
        Label10.Text = "Departure Date"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(36, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 18)
        Label9.TabIndex = 13
        Label9.Text = "Arrival Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(36, 61)
        Label11.Name = "Label11"
        Label11.Size = New Size(112, 18)
        Label11.TabIndex = 16
        Label11.Text = "Guest's Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 18)
        Label3.TabIndex = 17
        Label3.Text = "Number of Guests:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(55, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(264, 36)
        Label4.TabIndex = 18
        Label4.Text = "Please take a picture or a" & vbCrLf & "screenshot as ticket for payment"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(186, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 18)
        Label5.TabIndex = 19
        ' 
        ' txtGuestsName
        ' 
        txtGuestsName.BackColor = Color.Gainsboro
        txtGuestsName.BorderStyle = BorderStyle.FixedSingle
        txtGuestsName.Location = New Point(154, 56)
        txtGuestsName.Name = "txtGuestsName"
        txtGuestsName.Size = New Size(165, 23)
        txtGuestsName.TabIndex = 20
        ' 
        ' txtNumberOfGuest
        ' 
        txtNumberOfGuest.BackColor = Color.Gainsboro
        txtNumberOfGuest.BorderStyle = BorderStyle.FixedSingle
        txtNumberOfGuest.Location = New Point(186, 85)
        txtNumberOfGuest.Name = "txtNumberOfGuest"
        txtNumberOfGuest.Size = New Size(133, 23)
        txtNumberOfGuest.TabIndex = 21
        ' 
        ' txtArrivalDate
        ' 
        txtArrivalDate.BackColor = Color.Gainsboro
        txtArrivalDate.BorderStyle = BorderStyle.FixedSingle
        txtArrivalDate.Location = New Point(172, 143)
        txtArrivalDate.Name = "txtArrivalDate"
        txtArrivalDate.Size = New Size(147, 23)
        txtArrivalDate.TabIndex = 22
        ' 
        ' txtDepartureDate
        ' 
        txtDepartureDate.BackColor = Color.Gainsboro
        txtDepartureDate.BorderStyle = BorderStyle.FixedSingle
        txtDepartureDate.Location = New Point(172, 172)
        txtDepartureDate.Name = "txtDepartureDate"
        txtDepartureDate.Size = New Size(147, 23)
        txtDepartureDate.TabIndex = 23
        ' 
        ' txtTotalPayment
        ' 
        txtTotalPayment.BackColor = Color.Gainsboro
        txtTotalPayment.BorderStyle = BorderStyle.FixedSingle
        txtTotalPayment.Location = New Point(186, 221)
        txtTotalPayment.Name = "txtTotalPayment"
        txtTotalPayment.Size = New Size(133, 23)
        txtTotalPayment.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(36, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 18)
        Label6.TabIndex = 24
        Label6.Text = "Total Payment:"
        ' 
        ' formReciept
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 323)
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
        Name = "formReciept"
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
End Class
