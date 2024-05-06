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
        txtFirstName = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 32)
        Label1.TabIndex = 1
        Label1.Text = "Receipt No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(197, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 32)
        Label2.TabIndex = 2
        Label2.Text = "000000"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 182)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 18)
        Label10.TabIndex = 14
        Label10.Text = "Departure Date"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 153)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 18)
        Label9.TabIndex = 13
        Label9.Text = "Arrival Date"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(12, 66)
        Label11.Name = "Label11"
        Label11.Size = New Size(112, 18)
        Label11.TabIndex = 16
        Label11.Text = "Guest's Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 18)
        Label3.TabIndex = 17
        Label3.Text = "Number of Guests:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(39, 278)
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
        Label5.Location = New Point(162, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 18)
        Label5.TabIndex = 19
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BackColor = Color.Gainsboro
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Location = New Point(130, 61)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(165, 23)
        txtFirstName.TabIndex = 20
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(162, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(133, 23)
        TextBox1.TabIndex = 21
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(148, 148)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(147, 23)
        TextBox2.TabIndex = 22
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Gainsboro
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(148, 177)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(147, 23)
        TextBox3.TabIndex = 23
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.Gainsboro
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(162, 226)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(133, 23)
        TextBox4.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 231)
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
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtFirstName)
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
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
End Class
