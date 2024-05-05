<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSplashScreen
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSplashScreen))
        Title = New Label()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Title
        ' 
        resources.ApplyResources(Title, "Title")
        Title.BackColor = Color.Transparent
        Title.ForeColor = SystemColors.ActiveCaptionText
        Title.Name = "Title"
        Title.UseWaitCursor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.GrayText
        resources.ApplyResources(ProgressBar1, "ProgressBar1")
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.UseWaitCursor = True
        ' 
        ' formSplashScreen
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuBar
        ControlBox = False
        Controls.Add(ProgressBar1)
        Controls.Add(Title)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        Name = "formSplashScreen"
        UseWaitCursor = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
