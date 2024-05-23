Public Class formAdminLogin

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            formAdmin.Show()
            txtUsername.Clear()
            txtPassword.Clear()
            Globals.typeUser = "Admin"
            Me.Close()

        End If
    End Sub

    Private Sub formAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        formUser.Show()
        Close()
    End Sub
End Class