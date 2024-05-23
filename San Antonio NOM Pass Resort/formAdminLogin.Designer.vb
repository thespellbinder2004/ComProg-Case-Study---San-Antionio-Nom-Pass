<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdminLogin
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
        btnSubmit = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        btnAdmin = New Button()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(253, 280)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(109, 44)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(210, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 14)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(210, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 14)
        Label1.TabIndex = 4
        Label1.Text = "Username:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(210, 205)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(197, 23)
        txtPassword.TabIndex = 6
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(210, 145)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(197, 23)
        txtUsername.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Gainsboro
        Label3.Location = New Point(108, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 24)
        Label3.TabIndex = 29
        Label3.Text = "Welcome to"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(102, 57)
        Label4.Name = "Label4"
        Label4.Size = New Size(531, 41)
        Label4.TabIndex = 28
        Label4.Text = "San Antonio NOM Pass Resort"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources._863ddd18_06e3_448e_8aa3_d6c3760816ca_removebg_preview__1_1
        PictureBox1.Location = New Point(19, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(91, 66)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = SystemColors.Control
        btnAdmin.Location = New Point(545, 390)
        btnAdmin.Margin = New Padding(3, 4, 3, 4)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(78, 23)
        btnAdmin.TabIndex = 31
        btnAdmin.Text = "Customer"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(400, 395)
        Label8.Name = "Label8"
        Label8.Size = New Size(140, 14)
        Label8.TabIndex = 30
        Label8.Text = "Are you a customer?"
        ' 
        ' formAdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Desktop___1__1_
        ClientSize = New Size(663, 450)
        Controls.Add(btnAdmin)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(btnSubmit)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "formAdminLogin"
        Text = "formAdminLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Label8 As Label
End Class
